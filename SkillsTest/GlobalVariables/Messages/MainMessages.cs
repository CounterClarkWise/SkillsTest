using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest.GlobalVariables.Messages
{
    public class MainMessages
    {
        private static string continueExit;
        private static string cancelExit;
        private static string exitText = "Do you want to close the application?";
        private static string exitCaption = "Exit Verification";

        private static string resetText = "Do you want to reset the application?";
        private static string resetCaption = "Reset Verification";

        private static string noStrategyErrorText = "Please choose a Stragegy";
        private static string noStrategyErrorCaption = "No Stragegy";

        public static string ContinueExit
        {
            get { return continueExit; }
            set { continueExit = value; }
        }
        public static string CancelExit
        {
            get { return cancelExit; }
            set { cancelExit = value; }
        }
        public static string ExitText
        {
            get { return exitText; }
            set { exitText = value; }
        }
        public static string ExitCaption
        {
            get { return exitCaption; }
            set { exitCaption = value; }
        }
        public static string ResetText
        {
            get { return resetText; }
            set { resetText = value; }
        }
        public static string ResetCaption
        {
            get { return resetCaption; }
            set { resetCaption = value; }
        }
        public static string NoStrategyErrorText
        {
            get { return noStrategyErrorText; }
            set { noStrategyErrorText = value; }
        }
        public static string NoStrategyErrorCaption
        {
            get { return noStrategyErrorCaption; }
            set { noStrategyErrorCaption = value; }
        }
    }
}

