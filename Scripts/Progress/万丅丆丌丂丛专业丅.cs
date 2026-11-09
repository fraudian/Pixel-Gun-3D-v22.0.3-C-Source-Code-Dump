using UnityEngine;

namespace Progress
{
    internal class 万丅丆丌丂丛专业丅 : 三七业三丁丗一七丝
    {
        // Fields
        private static System.Action<PGCompany.丏丂一丗丙世丏丐三> 且丂丂东一丌七丂上;
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal static readonly int 丘丆万丄丛丗丆丙专;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal static void 不万丞与丕丅世不丄(System.Action<PGCompany.丏丂一丗丙世丏丐三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Progress.万丅丆丌丂丛专业丅.且丂丂东一丌七丂上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丝丂业丒丏丏业专丑(System.Action<PGCompany.丏丂一丗丙世丏丐三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Progress.万丅丆丌丂丛专业丅.且丂丂东一丌七丂上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal int 丏丌专万丙丝丝丈一(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            var val_3;
            object val_2 = this.专丏丕下上与与丟不(下上丐丆丝丟丝丒不:  丕上业丕丘上丘七一.业东丅东丌上丗丑不());
            if(val_2 != null)
            {
                    return System.Convert.ToInt32(value:  val_2);
            }
            
            val_3 = null;
            val_3 = null;
            return (int)Progress.万丅丆丌丂丛专业丅.丘丆万丄丛丗丆丙专;
        }
        internal void 丝丘丗丕丈三丈下世(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            int val_5;
            var val_6;
            if(丕上业丕丘上丘七一 != null)
            {
                    val_5 = 丕上业丕丘上丘七一.业东丅东丌上丗丑不();
            }
            else
            {
                    val_5 = 0.业东丅东丌上丗丑不();
            }
            
            this.丂上丆且丘三不丟业(下上丐丆丝丟丝丒不:  val_5, 丙业与丙丗丝不丈东:  丕上业丕丘上丘七一.丑业世丞上丂丄丟丞() + 1);
            val_6 = null;
            val_6 = null;
            if(Progress.万丅丆丌丂丛专业丅.且丂丂东一丌七丂上 == null)
            {
                    return;
            }
            
            Progress.万丅丆丌丂丛专业丅.且丂丂东一丌七丂上.Invoke(obj:  丕上业丕丘上丘七一);
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 37;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.万丅丆丌丂丛专业丅.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.万丅丆丌丂丛专业丅.丐丌丞上世丛丐丏丛;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        public 万丅丆丌丂丛专业丅()
        {
        
        }
        private static 万丅丆丌丂丛专业丅()
        {
            Progress.万丅丆丌丂丛专业丅.丕丟一七丑丙丂丆丙 = "ModuleInfo_slot";
            Progress.万丅丆丌丂丛专业丅.丐丌丞上世丛丐丏丛 = "ModuleInfo_slot_KEY_SPT_2019";
            Progress.万丅丆丌丂丛专业丅.丘丆万丄丛丗丆丙专 = 1;
        }
    
    }

}
