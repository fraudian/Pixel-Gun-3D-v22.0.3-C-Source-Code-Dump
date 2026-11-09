using UnityEngine;

namespace Rilisoft
{
    public struct 与丑丝与业丐丟丏丁
    {
        // Fields
        private int <丑丈七丘丞丝与与丆>k__BackingField;
        private int <丛不一丄与业与丐不>k__BackingField;
        private int <且丘丕七三丅丒万不>k__BackingField;
        
        // Properties
        public int 丕丁丙与丙丝丞上丄 { get; set; }
        public int 丐世丑丈丟丏专专丝 { get; set; }
        public int 丈丆且与丘丑丌东上 { get; set; }
        
        // Methods
        public int 七丌与丆丒业丝丄丞()
        {
            return (int)this;
        }
        public void 东丝丆一丆丒丞专丝(int 丙业与丙丗丝不丈东)
        {
            mem[1152921543512596464] = 丙业与丙丗丝不丈东;
        }
        public int 丘专一丅丞丞丂丑下()
        {
            return (int)this;
        }
        public void 丝业不丙东丗丒业且(int 丙业与丙丗丝不丈东)
        {
            mem[1152921543512820468] = 丙业与丙丗丝不丈东;
        }
        public int 丕丘丁丈丛丗丄丟丌()
        {
            return (int)this;
        }
        public void 丁与丒丈万上丌上三(int 丙业与丙丗丝不丈东)
        {
            mem[1152921543513044472] = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.与丑丝与业丐丟丏丁 东丝七业丄丑丒世七(System.Collections.Generic.Dictionary<string, object> 丗七丟丈三不丕一三)
        {
            object val_10;
            var val_11;
            object val_12;
            var val_13;
            val_10 = 丗七丟丈三不丕一三;
            object val_4 = 0;
            object val_1 = 0;
            object val_7 = 0;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            if((val_10.TryGetValue(key:  "coins", value: out  val_1)) == false)
            {
                goto label_2;
            }
            
            val_11 = System.Convert.ToInt32(value:  val_1);
            goto label_5;
            label_1:
            val_12 = 0;
            val_11 = 0;
            val_13 = 0;
            return new Rilisoft.与丑丝与业丐丟丏丁();
            label_2:
            val_11 = 0;
            label_5:
            if((val_10.TryGetValue(key:  "gems", value: out  val_4)) != false)
            {
                    val_13 = System.Convert.ToInt32(value:  val_4);
            }
            else
            {
                    val_13 = 0;
            }
            
            if((val_10.TryGetValue(key:  "xp", value: out  val_7)) != false)
            {
                    val_10 = val_7;
                val_12 = val_10;
                int val_9 = System.Convert.ToInt32(value:  val_12);
                return new Rilisoft.与丑丝与业丐丟丏丁();
            }
            
            val_12 = 0;
            return new Rilisoft.与丑丝与业丐丟丏丁();
        }
        internal static Rilisoft.与丑丝与业丐丟丏丁 东丝七业丄丑丒世七(System.Collections.Generic.List<object> 丗七丟丈三不丕一三)
        {
            System.Exception val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = 丗七丟丈三不丕一三;
            if(val_6 == null)
            {
                goto label_1;
            }
            
            val_7 = 0;
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            goto label_2;
            label_12:
            int val_2 = System.Convert.ToInt32(value:  val_6.Item[0]);
            if(val_10 == 0)
            {
                goto label_5;
            }
            
            if(val_10 == 1)
            {
                goto label_6;
            }
            
            if(val_10 != 2)
            {
                goto label_9;
            }
            
            val_7 = val_2;
            goto label_9;
            label_6:
            val_9 = val_2;
            goto label_9;
            label_5:
            val_8 = val_2;
            label_9:
            val_10 = 1;
            label_2:
            if(val_10 != (System.Math.Max(val1:  val_6.Count, val2:  3)))
            {
                goto label_12;
            }
            
            return new Rilisoft.与丑丝与业丐丟丏丁() {<丑丈七丘丞丝与与丆>k__BackingField = W24, <丛不一丄与业与丐不>k__BackingField = X23};
            label_1:
            val_11 = 0;
            val_7 = 0;
            return new Rilisoft.与丑丝与业丐丟丏丁() {<丑丈七丘丞丝与与丆>k__BackingField = W24, <丛不一丄与业与丐不>k__BackingField = X23};
        }
        public System.Collections.Generic.List<int> 丂丆丑世一不丘丏七()
        {
            return 106044882;
        }
    
    }

}
