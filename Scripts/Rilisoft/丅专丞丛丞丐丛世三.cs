using UnityEngine;

namespace Rilisoft
{
    internal static class 丅专丞丛丞丐丛世三
    {
        // Fields
        internal const string 业丙丁丛丑丙丑丄丙 = "LogsManager.LoggingEnabledKey";
        private static Rilisoft.丅专丞丛丞丐丛世三.丟丝七一三万丅丘专 丂且丄丒万丏丐丗丞;
        
        // Properties
        internal static Rilisoft.丅专丞丛丞丐丛世三.丟丝七一三万丅丘专 丙丟与丐三丐万万丆 { get; }
        
        // Methods
        internal static Rilisoft.丅专丞丛丞丐丛世三.丟丝七一三万丅丘专 丄丙丂丝丄丌丗丂丅()
        {
            null = null;
            return (丟丝七一三万丅丘专)Rilisoft.丅专丞丛丞丐丛世三.丂且丄丒万丏丐丗丞;
        }
        internal static void 上丛丌丆丑上七世三()
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 0;
            val_9 = null;
            val_9 = null;
            Rilisoft.丅专丞丛丞丐丛世三.丂且丄丒万丏丐丗丞 = ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "LogsManager.LoggingEnabledKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1) ? 1 : 0;
            Rilisoft.丅专丞丛丞丐丛世三.丈丘丅世丅上丈下七(丝三丄专丗丞丄丄丌:  true);
            if(UnityEngine.Application.platform != 8)
            {
                    return;
            }
            
            val_8 = UnityEngine.Debug.unityLogger;
            new Rilisoft.丛不三丝丅不丛丒丐() = new Rilisoft.丛不三丝丅不丛丒丐();
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 0;
            val_8.logHandler = new Rilisoft.丛不三丝丅不丛丒丐();
        }
        internal static void 丘丙世专丛丟一丛业()
        {
            null = null;
            if(Rilisoft.丅专丞丛丞丐丛世三.丂且丄丒万丏丐丗丞 == 1)
            {
                    return;
            }
            
            Rilisoft.丅专丞丛丞丐丛世三.丈丘丅世丅上丈下七(丝三丄专丗丞丄丄丌:  false);
        }
        internal static void 丗丘一与不世丘专丟()
        {
            null = null;
            Rilisoft.丅专丞丛丞丐丛世三.丂且丄丒万丏丐丗丞 = 1;
            Rilisoft.丅专丞丛丞丐丛世三.丈丘丅世丅上丈下七(丝三丄专丗丞丄丄丌:  true);
        }
        internal static void 世七一丒世丌丅丂丛(bool 丝三丄专丗丞丄丄丌)
        {
            var val_3;
            bool val_1 = 丝三丄专丗丞丄丄丌;
            val_3 = null;
            val_3 = null;
            Rilisoft.丅专丞丛丞丐丛世三.丂且丄丒万丏丐丗丞 = val_1;
            Rilisoft.丅专丞丛丞丐丛世三.丈丘丅世丅上丈下七(丝三丄专丗丞丄丄丌:  丝三丄专丗丞丄丄丌);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "LogsManager.LoggingEnabledKey", 下下丏一丙不丘丌丞:  val_1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private static void 世丟丂丆丏丛丏世丏(string 丞三丕世业三丒丅三, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟)
        {
            if(丁丅丈丌丟世丗丗丟 != 4)
            {
                    return;
            }
            
            if(丞三丕世业三丒丅三 == null)
            {
                goto label_2;
            }
            
            label_6:
            string val_1 = System.String.Format(format:  "EXCEPTION: {0}\n{1}", arg0:  丞三丕世业三丒丅三, arg1:  三丐丄上丕下丞丅专);
            if(val_1 == null)
            {
                    return;
            }
            
            Rilisoft.丛不三丝丅不丛丒丐.与东丘丕丅丆丄东丕(丄丙下丝丛丒七丂丘:  val_1);
            return;
            label_2:
            if(三丐丄上丕下丞丅专 != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private static void 丈丘丅世丅上丈下七(bool 丝三丄专丗丞丄丄丌)
        {
            IntPtr val_8;
            bool val_9;
            if(UnityEngine.Application.platform == 8)
            {
                    Application.LogCallback val_2 = null;
                val_8 = static System.Void Rilisoft.丅专丞丛丞丐丛世三::世丟丂丆丏丛丏世丏(string 丞三丕世业三丒丅三, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟);
                val_2 = new Application.LogCallback(object:  0, method:  val_8);
                UnityEngine.Application.remove_logMessageReceived(value:  val_2);
                if(丝三丄专丗丞丄丄丌 != false)
            {
                    Application.LogCallback val_3 = null;
                val_8 = static System.Void Rilisoft.丅专丞丛丞丐丛世三::世丟丂丆丏丛丏世丏(string 丞三丕世业三丒丅三, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟);
                val_3 = new Application.LogCallback(object:  0, method:  val_8);
                UnityEngine.Application.add_logMessageReceived(value:  val_3);
            }
            
            }
            
            UnityEngine.ILogger val_4 = UnityEngine.Debug.unityLogger;
            if(丝三丄专丗丞丄丄丌 == false)
            {
                goto label_5;
            }
            
            val_9 = 1;
            if(val_4 != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_9 = UnityEngine.Application.isEditor;
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = 2;
            val_4.logEnabled = val_9;
        }
        private static 丅专丞丛丞丐丛世三()
        {
        
        }
    
    }

}
