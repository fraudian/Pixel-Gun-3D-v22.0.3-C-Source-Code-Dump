using UnityEngine;

namespace Progress
{
    internal class 不东丌丈专丞丅三丆 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private 万丟与七上丝上丟丅 <丁丄丈丕丏丘丑丝专>k__BackingField;
        private Progress.不东丌丈专丞丅三丆.专业一丟东上丙丙丘 且丈丘七丐下专东丁;
        
        // Properties
        internal 万丟与七上丝上丟丅 丐下下丄丈丕上丗专 { get; set; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal 万丟与七上丝上丟丅 丟丆下丟丈世业丁丈()
        {
            return (万丟与七上丝上丟丅)this.<丁丄丈丕丏丘丑丝专>k__BackingField;
        }
        private void 且丆丙与丐丟业世丑(万丟与七上丝上丟丅 丙业与丙丗丝不丈东)
        {
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 不东丌丈专丞丅三丆.专业一丟东上丙丙丘();
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = new 万丟与七上丝上丟丅();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 54;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            this.且丈丘七丐下专东丁 = this.<丁丄丈丕丏丘丑丝专>k__BackingField.三丆丁丙与万丑丕丗(一丐丗丁丞丆丅丟丄:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            if((this.<丁丄丈丕丏丘丑丝专>k__BackingField) != null)
            {
                    return this.<丁丄丈丕丏丘丑丝专>k__BackingField.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
            }
            
            return this.<丁丄丈丕丏丘丑丝专>k__BackingField.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.不东丌丈专丞丅三丆.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.不东丌丈专丞丅三丆.丐丌丞上世丛丐丏丛;
        }
        internal bool 且丑丒丏丙丕三丞丏(int 万丕丘丒丛丑一业专, int 专世专丟丝丌与丘上)
        {
            专业一丟东上丙丙丘 val_3;
            var val_4;
            val_3 = this;
            if((this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  万丕丘丒丛丑一业专)) != false)
            {
                    if((this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField.Item[万丕丘丒丛丑一业专]) >= 专世专丟丝丌与丘上)
            {
                goto label_5;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁;
            val_3.丒丒丆丅业不下丞丄(万丕丘丒丛丑一业专:  万丕丘丒丛丑一业专, 专世专丟丝丌与丘上:  专世专丟丝丌与丘上);
            val_4 = 1;
            return (bool)val_4;
            label_5:
            val_4 = 0;
            return (bool)val_4;
        }
        internal int 业三丕丏不丅七丁三(下下丟丒三不下三丗.丞三丕丒且丗与世丄 万丕丘丒丛丑一业专)
        {
            return this.业三丕丏不丅七丁三(万丕丘丒丛丑一业专:  万丕丘丒丛丑一业专);
        }
        internal int 业三丕丏不丅七丁三(int 万丕丘丒丛丑一业专)
        {
            if((this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  万丕丘丒丛丑一业专)) == false)
            {
                    return 1;
            }
            
            if((this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField) != null)
            {
                    return this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField.Item[万丕丘丒丛丑一业专];
            }
            
            return this.且丈丘七丐下专东丁.<上业丘世一丌丆丟业>k__BackingField.Item[万丕丘丒丛丑一业专];
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 不东丌丈专丞丅三丆.专业一丟东上丙丙丘();
        }
        public 不东丌丈专丞丅三丆()
        {
        
        }
        private static 不东丌丈专丞丅三丆()
        {
            Progress.不东丌丈专丞丅三丆.丕丟一七丑丙丂丆丙 = "RankSlotV2";
            Progress.不东丌丈专丞丅三丆.丐丌丞上世丛丐丏丛 = "RankSlotV2_Key_2020";
        }
    
    }

}
