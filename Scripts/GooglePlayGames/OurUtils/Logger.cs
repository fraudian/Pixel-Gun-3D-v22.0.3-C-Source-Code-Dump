using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public class Logger
    {
        // Fields
        private static bool debugLogEnabled;
        private static bool warningLogEnabled;
        
        // Properties
        public static bool DebugLogEnabled { get; set; }
        public static bool WarningLogEnabled { get; set; }
        
        // Methods
        public static bool get_DebugLogEnabled()
        {
            null = null;
            return (bool)GooglePlayGames.OurUtils.Logger.debugLogEnabled;
        }
        public static void set_DebugLogEnabled(bool value)
        {
            null = null;
            GooglePlayGames.OurUtils.Logger.debugLogEnabled = value;
        }
        public static bool get_WarningLogEnabled()
        {
            null = null;
            return (bool)GooglePlayGames.OurUtils.Logger.warningLogEnabled;
        }
        public static void set_WarningLogEnabled(bool value)
        {
            null = null;
            GooglePlayGames.OurUtils.Logger.warningLogEnabled = value;
        }
        public static void d(string msg)
        {
            var val_3;
            .msg = msg;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.debugLogEnabled == false)
            {
                    return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  new Logger.<>c__DisplayClass8_0(), method:  System.Void Logger.<>c__DisplayClass8_0::<d>b__0()));
        }
        public static void w(string msg)
        {
            var val_3;
            .msg = msg;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.warningLogEnabled == false)
            {
                    return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  new Logger.<>c__DisplayClass9_0(), method:  System.Void Logger.<>c__DisplayClass9_0::<w>b__0()));
        }
        public static void e(string msg)
        {
            var val_3;
            .msg = msg;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.warningLogEnabled == false)
            {
                    return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  new Logger.<>c__DisplayClass10_0(), method:  System.Void Logger.<>c__DisplayClass10_0::<e>b__0()));
        }
        public static string describe(byte[] b)
        {
            var val_2;
            if(b != null)
            {
                    string val_1 = "byte[" + b.Length + "]";
                return (string)val_2;
            }
            
            val_2 = "(null)";
            return (string)val_2;
        }
        private static string ToLogMessage(string prefix, string logType, string msg)
        {
            System.DateTime val_1 = System.DateTime.Now;
            object[] val_2 = new object[4];
            val_2[0] = prefix;
            val_2[1] = ;
            val_2[2] = logType;
            val_2[3] = msg;
            return (string)System.String.Format(format:  "{0} [Play Games Plugin DLL] {1} {2}: {3}", args:  val_2);
        }
        public Logger()
        {
        
        }
        private static Logger()
        {
            GooglePlayGames.OurUtils.Logger.debugLogEnabled = false;
            GooglePlayGames.OurUtils.Logger.warningLogEnabled = true;
        }
    
    }

}
