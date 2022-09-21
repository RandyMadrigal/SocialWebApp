using Microsoft.AspNetCore.Http;
using System;
using System.IO;


namespace SocialApp.Core.Application.Helpers
{
    public static class ImgManage
    {
        //Metodo que procesa subida de la imagen
        public static string UploadFile(IFormFile file, int Id, bool editMode = false, string imgUrl = " ")
        {

            if (editMode)
            {
                if (file == null)
                {
                    return imgUrl = " ";
                }
            }

            //Get Directory path
            string basePath = $"/Img/ProfileImg/{Id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //Create folder if not exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {

                //Get File Path
                Guid guid = Guid.NewGuid();

                FileInfo fileInfo = new(file.FileName);


                string fileName = guid + fileInfo.Extension;

                //Ruta definitiva

                string fileNameWPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                if (editMode)
                {
                    string[] OldImgPart = imgUrl.Split("/");

                    string oldImagePath = OldImgPart[^1];

                    string completeImageOldPath = Path.Combine(path, oldImagePath);

                    if (System.IO.File.Exists(completeImageOldPath))
                    {
                        System.IO.File.Delete(completeImageOldPath);
                    }
                }

                return $"{basePath}/{fileName}";
            }
            catch (Exception)
            {


            }

            return $"{basePath}/{"Error"}";
        }
    }
}
