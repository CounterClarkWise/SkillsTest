using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest.GlobalVariables.frmMain
{
    public class LogicVar
    {
        private static char[] charArray;
        private static bool[] isCapitalizedArray;
        private static char[] lowercaseArray;

        public static char[] CharArray
        {
            get { return charArray; }
            set { charArray = value; }
        }
        public static bool[] IsCapitalizedArray
        {
            get { return isCapitalizedArray; }
            set { isCapitalizedArray = value; }
        }
        public static char[] LowercaseArray
        {
            get { return lowercaseArray; }
            set { lowercaseArray = value; }
        }
    }
}
