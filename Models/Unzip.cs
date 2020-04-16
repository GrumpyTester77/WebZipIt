using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace ZipIt
{
    public class Unzip
    {


        //Unzip Function
        //Copy data from newly created file out into seperate files.
        
        public static void unzipFiles(string sourcePath, string destinationPath)
        {
            
            string filePath = sourcePath;
            
            string file = Path.GetFileName(filePath);


            string fileOutput = destinationPath;

                if (File.Exists(filePath))
                {
                    //read the file and get back the filename to create the new file to copy data to.

                    FileUtils.openFileToRead(sourcePath, fileOutput, file);
      
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                    Console.ReadKey();
                }
           }
      }
}
    
