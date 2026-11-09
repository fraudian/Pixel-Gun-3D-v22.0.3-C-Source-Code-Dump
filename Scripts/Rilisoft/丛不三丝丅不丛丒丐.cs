using UnityEngine;

namespace Rilisoft
{
    public sealed class 丛不三丝丅不丛丒丐 : ILogHandler
    {
        // Methods
        public void LogFormat(UnityEngine.LogType 世丗丕东丄三丕丂丒, UnityEngine.Object 与且专丈不万东一万, string 丆丗丘丕且丈丘丁不, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_6;
            System.Object[] val_7 = 专丒丌丆下丐丞丟丞;
            if(丆丗丘丕且丈丘丁不 == null)
            {
                    return;
            }
            
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = System.String.Format(format:  丆丗丘丕且丈丘丁不, args:  val_7 = 专丒丌丆下丐丞丟丞);
            if(val_7 == null)
            {
                    return;
            }
            
            string val_2 = System.Environment.StackTrace;
            val_6 = 世丗丕东丄三丕丂丒;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_5 = System.String.Format(format:  "{0}: {1}\n{2}", arg0:  世丗丕东丄三丕丂丒.ToString(), arg1:  val_7, arg2:  (val_2 == null) ? "empty stack trace" : (val_2));
        }
        public void LogException(System.Exception 世丝丒丙下东丗丙上, UnityEngine.Object 与且专丈不万东一万)
        {
            System.Exception val_2 = 世丝丒丙下东丗丙上;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = val_2;
            T[] val_1 = System.Array.Empty<System.Object>();
            val_1.LogFormat(世丗丕东丄三丕丂丒:  4, 与且专丈不万东一万:  与且专丈不万东一万, 丆丗丘丕且丈丘丁不:  val_2, 专丒丌丆下丐丞丟丞:  val_1);
        }
        internal static void 与东丘丕丅丆丄东丕(string 丄丙下丝丛丒七丂丘)
        {
        
        }
        public 丛不三丝丅不丛丒丐()
        {
        
        }
    
    }

}
