using UnityEngine;

namespace Progress
{
    internal class 丙丆丞丆一丏一丁业
    {
        // Fields
        internal System.Action<System.Collections.Generic.Dictionary<string, object>> 下三丐丙下丛东专丞;
        internal System.Action 丐丒丙业丕丞一一丄;
        internal string 业丘丛专丗丛万专业;
        internal string 三东与丄上世丒丞丝;
        internal int 且丗丄丌上业不丅丆;
        internal bool 丆丘丌丒七丈上丞世;
        internal string 丄丙丐丌东丂丞丌丒;
        internal System.Collections.Generic.Dictionary<int, float> 七丅丟丕丁丂丞七丈;
        internal float 下丑丗丞丒丅丛万且;
        internal static System.Collections.Generic.Dictionary<int, float> 且丗丌丈丙丑东下一;
        
        // Methods
        internal float 丏万丝下丕万丐丙丒()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Single> val_4;
            var val_5;
            var val_6;
            if((this.七丅丟丕丁丂丞七丈 != null) && ((this.七丅丟丕丁丂丞七丈.ContainsKey(key:  this.且丗丄丌上业不丅丆)) != false))
            {
                    val_4 = this.七丅丟丕丁丂丞七丈;
            }
            else
            {
                    val_5 = null;
                val_5 = null;
                if((Progress.丙丆丞丆一丏一丁业.且丗丌丈丙丑东下一.ContainsKey(key:  this.且丗丄丌上业不丅丆)) == false)
            {
                    return (float)(this.下丑丗丞丒丅丛万且 < 0f) ? 15f : this.下丑丗丞丒丅丛万且;
            }
            
                val_6 = null;
                val_6 = null;
                val_4 = Progress.丙丆丞丆一丏一丁业.且丗丌丈丙丑东下一;
            }
            
            if(val_4 != null)
            {
                    return val_4.Item[this.且丗丄丌上业不丅丆];
            }
            
            return val_4.Item[this.且丗丄丌上业不丅丆];
        }
        public 丙丆丞丆一丏一丁业()
        {
            this.下丑丗丞丒丅丛万且 = -1f;
        }
        private static 丙丆丞丆一丏一丁业()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
            if(val_1 != null)
            {
                    val_1.Add(key:  0, value:  0f);
                val_1.Add(key:  1, value:  2f);
                val_1.Add(key:  2, value:  3f);
                val_1.Add(key:  3, value:  4f);
                val_1.Add(key:  4, value:  10f);
            }
            else
            {
                    val_1.Add(key:  0, value:  0f);
                val_1.Add(key:  1, value:  2f);
                val_1.Add(key:  2, value:  3f);
                val_1.Add(key:  3, value:  4f);
                val_1.Add(key:  4, value:  10f);
            }
            
            val_1.Add(key:  5, value:  15f);
            Progress.丙丆丞丆一丏一丁业.且丗丌丈丙丑东下一 = val_1;
        }
    
    }

}
