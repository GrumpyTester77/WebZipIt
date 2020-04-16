using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZipItWebApp;

namespace ZipItWebApp.Controllers
{
    public class ZipController : Controller
    {
        // GET: Zip
        public ActionResult Index()
        {
            ViewBag.Message = "Please Create a file to import to:";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            if (!ModelState.IsValid)
            {


                return View("Error");
            }

            string fileNamePath = Convert.ToString(collection["txtImportPath"]);
            string zipPath = Convert.ToString(collection["txtZipPath"]);
            
            string importPath = Zip.Files.createFiles(fileNamePath);
            ZipIt.Zip.zipFiles(importPath, zipPath);

            return View("Successful");
        }


    }
}