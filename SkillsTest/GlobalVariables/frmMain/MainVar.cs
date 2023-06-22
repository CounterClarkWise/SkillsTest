using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest.GlobalVariables
{
    public class MainVar
    {
        private static string initialString;
        private static string convertedString;
        private static string strategy;

        public static string InitialString
        {
            get { return initialString; }
            set { initialString = value; }
        }
        public static string ConvertedString
        {
            get { return convertedString; }
            set { convertedString = value; }
        }
        public static string Strategy
        {
            get { return strategy; }
            set { strategy = value; }
        }
    }
}
