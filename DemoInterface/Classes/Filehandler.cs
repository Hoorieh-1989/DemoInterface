using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    public static class Filehandler
    {
        private static string _filePath = @"C:\Users\hoori\OneDrive\C\DemoInterface.txt" ;
        public static void WriteToFile(string text)
        {
            using(StreamWriter writer = new StreamWriter(_filePath,true)) 
            {
                writer.WriteLine(text);
            }
         }
    }
}
