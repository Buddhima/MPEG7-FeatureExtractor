using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1.FileAccessors
{
    class FileSystemWriter
    {

        StreamWriter writer;

        public FileSystemWriter()
        {

        }

        public FileSystemWriter(string outputFileName) {
            
            writer = new StreamWriter(outputFileName);
        }

        public void setStreamWriter(string outputFileName)
        {
            writer = new StreamWriter(outputFileName);
        }

        public void writeFile(string imageFileName, List<int> data )
        {
            string entry=imageFileName;
            
            // decode result and write to the given file
            foreach (int num in data) 
            {
                entry += "," + num;
            }
            writer.WriteLine(entry);
        }

        public void closeFile() 
        {
            writer.Close();
        }
    }
}
