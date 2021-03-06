﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Core.Models
{
    public class MyApiRequestModel
    {
        public String controller;
        public String method;

        public MyApiRequestModel(String controller, String method)
        {
            this.controller = controller;
            this.method = method;
        }

        public static MyApiRequestModel GetSiteDatasCount => new MyApiRequestModel("Home", "SiteDatasCount");
        public static MyApiRequestModel PostUserLogin => new MyApiRequestModel("User", "Login");
        public static MyApiRequestModel GetUserDetail => new MyApiRequestModel("User", "Detail");
        public static MyApiRequestModel PostUserRegister => new MyApiRequestModel("User", "Register");
        public static MyApiRequestModel PostEditUser => new MyApiRequestModel("User", "Edit");
        public static MyApiRequestModel DeleteUser => new MyApiRequestModel("User", "Delete");
        public static MyApiRequestModel PostNutritionistRegister => new MyApiRequestModel("Nutritionist", "NutRegister");
        public static MyApiRequestModel GetNutritionistDetail => new MyApiRequestModel("Nutritionist", "Detail");
        public static MyApiRequestModel PostEditNutritionist => new MyApiRequestModel("Nutritionist", "Edit");

        public static MyApiRequestModel GetNutritionistsList => new MyApiRequestModel("Nutritionist", "List");
        public static MyApiRequestModel DeleteNutritionist => new MyApiRequestModel("Nutritionist", "Delete");
        public static MyApiRequestModel PostArticleAdd => new MyApiRequestModel("Article", "Add");
        public static MyApiRequestModel GetArticleDetail => new MyApiRequestModel("Article", "Detail");
        public static MyApiRequestModel GetArticlesList => new MyApiRequestModel("Article", "List");
        public static MyApiRequestModel PostArticleEdit => new MyApiRequestModel("Article", "Edit");
        public static MyApiRequestModel GetNutritionistArticlesList => new MyApiRequestModel("Article", "NutArticleList");
        public static MyApiRequestModel DeleteArticle => new MyApiRequestModel("Article", "Delete");
        public static MyApiRequestModel GetTakeFewArticles => new MyApiRequestModel("Article", "TakeFewArticles");
        public static MyApiRequestModel PostAddComment => new MyApiRequestModel("Comment", "Add");
        public static MyApiRequestModel GetCommentList => new MyApiRequestModel("Comment", "List");
        public static MyApiRequestModel DeleteComment => new MyApiRequestModel("Comment", "Delete");

    }
}
