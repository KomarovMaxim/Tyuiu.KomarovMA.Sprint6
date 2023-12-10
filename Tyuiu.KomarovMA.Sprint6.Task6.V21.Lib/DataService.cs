using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovMA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string str, string path)
        {
            
            string strLine = "";
            string line;
            using (StreamReader reader = new StreamReader(path))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains(str)) strLine += word + " ";
                    }
                }
            }
            return strLine.Trim();
        }
    }
}