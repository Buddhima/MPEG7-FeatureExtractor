using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1.FileAccessors
{
    class FileSystemReader
    {
        public Dictionary<string,Bitmap> readFiles(string folderPath) {

            Dictionary<string,Bitmap> fileList = new Dictionary<string,Bitmap>();
            
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {
                fileList.Add(file, new Bitmap(file));
            }
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.png"))
            {
                fileList.Add(file, new Bitmap(file));
            }

            return fileList;
        }

        

    }
}
