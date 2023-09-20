using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExamApp
{
    internal class WriteToFile
    {
      
        public void WriteFile(ListBox Result) 
        {
           
            TextWriter writer = new StreamWriter("D:/Prog/ExamApp/File1.txt");
            foreach (var item in Result.Items)
                writer.WriteLine(item.ToString());
            writer.Close();
        }
    }
}
