using System;

namespace Nutritionist.Web.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel(int statusCode=0, string title="Hata!", string description="A��klama belirtilmemi�.")
        {
            StatusCode = statusCode;
            Title = title;
            Description = description;
        }

        public int StatusCode { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }


        public static ErrorViewModel GetDefaultException => new ErrorViewModel(0, "�stisna", "Beklenmedik bir durum meydana geldi !");
        public static ErrorViewModel GetServerError => new ErrorViewModel(500, "Sunucu Hatas�", "�ste�in �al��t�r�lmas� s�ras�nda hata meydana gelmi�tir.");
        public static ErrorViewModel GetClientError(String exception) => new ErrorViewModel(400, "�stemci Hatas�", "�ste�in �al��t�r�lmas� s�ras�nda hata meydana gelmi�tir.Detay : " + exception);

    }
}
