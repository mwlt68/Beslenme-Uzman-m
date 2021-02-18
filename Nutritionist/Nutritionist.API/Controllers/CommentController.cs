﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nutritionist.Core.Models.ResponseModels;
using Nutritionist.Services;
using CommentListModel = Nutritionist.Core.Models.Comment.List;
using CommentInsertModel = Nutritionist.Core.Models.Comment.Insert;
using Nutritionist.Core.StaticDatas;
using Nutritionist.Core.ActionFilters;

namespace Nutritionist.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private CommentService commentService;
        private UserService userService;
        private NutritionistService nutritionistService;
        public CommentController()
        {
           commentService = new CommentService();
            userService = new UserService();
            nutritionistService = new NutritionistService();
        }

        [ValidateModelState]
        [HttpPost("AddComment")]
        public ActionResult<BaseResponseModel> PostAddComment([FromBody] CommentInsertModel commentInsertModel)
        {
            try
            {
                commentService.AddComment(commentInsertModel);
                return new SuccessResponseModel<bool>(true);
            }
            catch (Exception ex)
            {

                return new BaseResponseModel(ex.Message);
            }
        }
        [HttpGet("CommentList/{nutritionistId}")]
        public ActionResult<BaseResponseModel> GetCommentsList(int nutritionistId)
        {
            try
            {
                List<CommentListModel> commentsListModel= commentService.GetNutritionistAllCommentLists(nutritionistId);
                if (commentsListModel != null)
                {
                    foreach (var commentListModel in commentsListModel)
                    {
                        var commentNutritionist = nutritionistService.GetNutritionistListModel(commentListModel.NutritionstId);
                        if (commentNutritionist != null)
                        {
                            commentListModel.Nutritionist = commentNutritionist;
                            var nutUser = userService.GetUserListModel(commentNutritionist.UserId);
                            if (nutUser != null)
                            {
                                commentListModel.Nutritionist.User = nutUser;
                            }
                        }
                        var commentUser = userService.GetUserListModel(commentListModel.UserId);
                        if (commentUser != null)
                        {
                            commentListModel.User = commentUser;
                        }
                    }
                    return  new SuccessResponseModel<List<CommentListModel>>(commentsListModel);
                }
                else return new BaseResponseModel(ReadOnlyValues.CommentsNotFound);
            }
            catch (Exception ex)
            {

                return new BaseResponseModel(ex.Message);
            }
        }
        // UserId for security

        [HttpDelete("DeleteComment/{commentId}/{userId}")]
        public ActionResult<BaseResponseModel> DeleteComment(int commentId,int userId)
        {
            try
            {
                bool res = commentService.RemoveComment(commentId, userId);
                if (res)
                {
                    return new SuccessResponseModel<bool>(res);
                }
                else
                {
                    return new BaseResponseModel(ReadOnlyValues.CommentNotFound);
                }
            }
            catch (Exception ex)
            {

                return new BaseResponseModel(ex.Message);
            }
        }
    }
}
