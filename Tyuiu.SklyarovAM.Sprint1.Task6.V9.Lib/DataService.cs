using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SklyarovAM.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            char lastChar = value[value.Length - 1];
            string restOfWord = value.Substring(0, value.Length - 1);

            return lastChar + restOfWord;
        }
    }
}
