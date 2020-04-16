using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZipItWebApp.Models;

namespace ZipItWebApp.Controllers
{
    public class UnzipController : Controller
    {
        // GET: Unzip
        public ActionResult Index()
        {
            ViewBag.Message = "Please select a file to unzip:";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                string sourcePath = Convert.ToString(collection["txtsourcePath"]);
                string destinationPath = Convert.ToString(collection["txtdestinationPath"]);

                ZipIt.Unzip.unzipFiles(sourcePath, destinationPath);
                return View("Successful");


            }
            else
            {
                return View("Index");
            }
        }





   
    }
}