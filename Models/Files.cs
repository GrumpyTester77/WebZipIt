using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Zip
{
    public class Files
    {
        public static string createFiles(string fileNamePath)
        {
            string importPath = fileNamePath;
            //Console.WriteLine("To create the file, Please enter the path and filename: ");
            //importPath = Console.ReadLine();


            if (File.Exists(importPath))
            {
                Console.WriteLine("File already Exists: " + importPath);
            }
            else
            {
                FileStream newFile = File.Create(importPath);
                //Console.WriteLine("File Created: " + importPath);
                newFile.Close();

            }

            return importPath;

        }
    }
}