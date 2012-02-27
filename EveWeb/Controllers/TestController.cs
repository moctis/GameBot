using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveWeb.Controllers
{
    using System.Drawing.Imaging;
    using System.IO;

    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ShowImage()
        { 

            var path = @"D:\";
            var file = "key.png";
            var fullPath = Path.Combine(path, file);
            //return File(fullPath, "image/png", file);

            var reader = new FileStream(fullPath, FileMode.Open);
            return File(reader, "image/png", "key.png"); 
        }

        public ActionResult ShowImage2()
        {
            var reader = new FileStream(@"D:\test.jpg", FileMode.Open);
            return File(reader, "image/jpeg", "test.jpg"); 
        }

        public ActionResult ShowImage3()
        {
            IntPtr hwnd = SystemLib.User32.FindWindowByCaption(IntPtr.Zero, "EVE - MoctisMining");
            if (hwnd == IntPtr.Zero) return ShowImage();
            var image = SystemLib.ScreenCapture.CaptureWindow(hwnd);
            Stream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            image.Dispose();
            stream.Seek(0, SeekOrigin.Begin);

            var result = this.File(stream, "image/jpg", "key.png");
            stream.Flush();
            return result;
        }
    }
}
