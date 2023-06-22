using SkillsTest.GlobalVariables.frmMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Logic
    {
        public static string SortString(string tbinput, string cbstrategy)
        {
            //Initialize Arrays
            LogicVar.CharArray = tbinput.ToCharArray(); //storage of string from TB
            LogicVar.IsCapitalizedArray = new bool[LogicVar.CharArray.Length]; //storage wether char is capitalized or not
            LogicVar.LowercaseArray = new char[LogicVar.CharArray.Length]; //storage of correct sorted char

            //Logic
            for (int i = 0; i < LogicVar.CharArray.Length; i++)
            {
                LogicVar.LowercaseArray[i] = char.ToLower(LogicVar.CharArray[i]); //convert charArray lowercase
                LogicVar.IsCapitalizedArray[i] = char.IsUpper(LogicVar.CharArray[i]); //store every char in isCapitalizedArray[]; char == capitalized ? true : false
            }

            Array.Sort(LogicVar.LowercaseArray, LogicVar.CharArray); //sorting

            if (cbstrategy == "Descending")
            {
                Array.Reverse(LogicVar.CharArray);
            }
            return new string(LogicVar.CharArray);
        }
    }
}
