using UnityEngine;

namespace Progress
{
    internal sealed class 丐丒丞丅丝丅丑与丘 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal static readonly string 专三丙丄丈丌丁业且;
        private System.Collections.Generic.List<int> 丕丌万丁丆丕丗丑丈;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal bool 丟丂下七且七东丛丞(PGCompany.专丙不不丟万丏一丘 不七丆万丁一丞七下)
        {
            if(this.丕丌万丁丆丕丗丑丈 != null)
            {
                    return this.丕丌万丁丆丕丗丑丈.Contains(item:  不七丆万丁一丞七下);
            }
            
            return this.丕丌万丁丆丕丗丑丈.Contains(item:  不七丆万丁一丞七下);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丕丌万丁丆丕丗丑丈.Clear();
        }
        internal void 三七万不七下不丏万(PGCompany.专丙不不丟万丏一丘 不七丆万丁一丞七下)
        {
            if((this.丟丂下七且七东丛丞(不七丆万丁一丞七下:  不七丆万丁一丞七下)) != false)
            {
                    return;
            }
            
            this.丕丌万丁丆丕丗丑丈.Add(item:  不七丆万丁一丞七下);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_6;
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            val_11 = this;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0;
            val_12 = null;
            val_12 = null;
            val_10 = Progress.丐丒丞丅丝丅丑与丘.专三丙丄丈丌丁业且;
            if((val_1.ContainsKey(key:  val_10)) == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            val_10 = Progress.丐丒丞丅丝丅丑与丘.专三丙丄丈丌丁业且;
            object val_3 = val_1.Item[val_10];
            if(val_3 == null)
            {
                    return;
            }
            
            val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            List.Enumerator<T> val_4 = val_1.GetEnumerator();
            label_19:
            if(((-1851299200) & 1) == 0)
            {
                goto label_15;
            }
            
            this.丕丌万丁丆丕丗丑丈.Add(item:  System.Convert.ToInt32(value:  val_6.丐丏七丌丕丗业且上()));
            goto label_19;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_2 = null;
            val_2 = null;
            val_1.set_Item(key:  Progress.丐丒丞丅丝丅丑与丘.专三丙丄丈丌丁业且, value:  this.丕丌万丁丆丕丗丑丈);
            return (object)val_1;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 56;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丐丒丞丅丝丅丑与丘.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丐丒丞丅丝丅丑与丘.丐丌丞上世丛丐丏丛;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        public 丐丒丞丅丝丅丑与丘()
        {
            this.丕丌万丁丆丕丗丑丈 = new System.Collections.Generic.List<System.Int32>();
        }
        private static 丐丒丞丅丝丅丑与丘()
        {
            Progress.丐丒丞丅丝丅丑与丘.丕丟一七丑丙丂丆丙 = "Tutorial_Slot";
            Progress.丐丒丞丅丝丅丑与丘.丐丌丞上世丛丐丏丛 = "Tutorial_Slot_Key_JUL_2020";
            Progress.丐丒丞丅丝丅丑与丘.专三丙丄丈丌丁业且 = "t";
        }
    
    }

}
