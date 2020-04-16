using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZipIt
{
     public class Zip
    {
         //Zip Function
            //copy data to newly created file
         public static void zipFiles(string importPath, string zipPath)
         {

             //Getting the path and file
             DirectoryUtil.directoryCreateListOfFiles(zipPath, importPath);




                 //Console.WriteLine("Files copied successfully");
                 //Console.ReadKey();
             }
         } 
}
