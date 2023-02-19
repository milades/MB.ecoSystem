using MB.PublicLibraries.String;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace MB.PublicLibraries.File
{
    //public class FileHelper
    //{
    //    private IWebHostEnvironment hostingEnv;
    //    String_Helper string_helper = new String_Helper();
    //    public string[] PicTypes = new[] { ".jpg", ".jpeg", ".png" };
    //    public string get_defaultAvatar()
    //    {

    //        return SharedConstants.defaultAvatar;
    //    }
    //    public Files_Helper(IWebHostEnvironment env)
    //    {
    //        hostingEnv = env;
    //    }

    //    public string? SaveFile(IFormFile file)
    //    {
    //        try
    //        {
    //            //
    //            string fileAddress = "";
    //            var fileExt = Path.GetExtension(ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"'));
    //            string file_folder = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString();

    //            //  var filename = file_folder + "__" + string_helper.RandomNumberString(10) + fileExt;
    //            var filename = Guid.NewGuid().ToString().Replace("-", "") + fileExt;
    //            var folder_address = Path.Combine(hostingEnv.WebRootPath + $@"\uploads\{file_folder}");
    //            if (!Directory.Exists(folder_address))
    //            {
    //                Directory.CreateDirectory(folder_address);
    //            }
    //            filename = folder_address + $@"\" + filename;
    //            using (FileStream fs = File.Create(filename))
    //            {
    //                file.CopyTo(fs);
    //                fs.Flush();
    //            }
    //            fileAddress = filename.Substring(hostingEnv.ContentRootPath.Length)
    //                 .Replace("\\", "/").Replace("wwwroot/", "");
    //            return fileAddress;
    //        }
    //        catch
    //        {
    //            return null;
    //        }
    //    }

    //    public bool DeleteFile(string path)
    //    {
    //        try
    //        {
    //            var address = hostingEnv.WebRootPath.Replace("\\", "/") + path.Replace("~", "");
    //            System.IO.File.Delete(address);
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            return false;
    //        }
    //    }
    //}
}
