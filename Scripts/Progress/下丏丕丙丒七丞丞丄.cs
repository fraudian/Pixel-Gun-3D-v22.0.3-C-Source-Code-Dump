using UnityEngine;

namespace Progress
{
    internal class 下丏丕丙丒七丞丞丄 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private Progress.一丒丂丘丛丂下丟世 <丁丄丈丕丏丘丑丝专>k__BackingField;
        private Progress.下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗 且丈丘七丐下专东丁;
        
        // Properties
        internal Progress.一丒丂丘丛丂下丟世 丐下下丄丈丕上丗专 { get; set; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal Progress.一丒丂丘丛丂下丟世 丟丆下丟丈世业丁丈()
        {
            return (Progress.一丒丂丘丛丂下丟世)this.<丁丄丈丕丏丘丑丝专>k__BackingField;
        }
        private void 且丆丙与丐丟业世丑(Progress.一丒丂丘丛丂下丟世 丙业与丙丗丝不丈东)
        {
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丄丄丙东万一不丞丛(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SaveTimeBuyPromotions != null)
            {
                    return this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.Item[与丕丗与丄丞东业丞];
        }
        internal int 丟丟上丗上丙丞丛丈(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SaveSets.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SaveSets != null)
            {
                    return this.且丈丘七丐下专东丁.SaveSets.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SaveSets.Item[与丕丗与丄丞东业丞];
        }
        internal int 丗丄三丒三丂与丕与(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions != null)
            {
                    return this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.Item[与丕丗与丄丞东业丞];
        }
        internal int 丂丝且丌丈丆丝专丒(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions != null)
            {
                    return this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.Item[与丕丗与丄丞东业丞];
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗();
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = new Progress.一丒丂丘丛丂下丟世();
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 下丏丕丙丒七丞丞丄.丁丘丏三丙上专丕丗();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 64;
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
            return (string)Progress.下丏丕丙丒七丞丞丄.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.下丏丕丙丒七丞丞丄.丐丌丞上世丛丐丏丛;
        }
        internal bool 世丕丝丑七上丟丆且(int 与丕丗与丄丞东业丞, int 丂三丟丂丈丐丆丗丟)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(丂三丟丂丈丐丆丗丟 <= 0)
            {
                    return this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            if((this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SaveTimeBuyPromotions.Item[与丕丗与丄丞东业丞] == 丂三丟丂丈丐丆丗丟)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SaveTimeBuyPromotions;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  丂三丟丂丈丐丆丗丟);
            val_4 = 1;
            return (bool)val_4;
        }
        internal bool 万丗丈丟且丐东丞三(int 与丕丗与丄丞东业丞, int 业东万丌丒业丟世丛)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(this.且丈丘七丐下专东丁.SaveSets == null)
            {
                goto label_1;
            }
            
            if((业东万丌丒业丟世丛 & 2147483648) != 0)
            {
                    return this.且丈丘七丐下专东丁.SaveSets.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            label_10:
            if((this.且丈丘七丐下专东丁.SaveSets.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SaveSets.Item[与丕丗与丄丞东业丞] == 业东万丌丒业丟世丛)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SaveSets;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  业东万丌丒业丟世丛);
            val_4 = 1;
            return (bool)val_4;
            label_1:
            if((业东万丌丒业丟世丛 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            return this.且丈丘七丐下专东丁.SaveSets.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
        }
        internal bool 东丗丁业与丒下丐丐(int 与丕丗与丄丞东业丞, int 丂三丟丂丈丐丆丗丟)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(丂三丟丂丈丐丆丗丟 <= 0)
            {
                    return this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            if((this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions.Item[与丕丗与丄丞东业丞] == 丂三丟丂丈丐丆丗丟)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SaveLastTimeViewPromotions;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  丂三丟丂丈丐丆丗丟);
            val_4 = 1;
            return (bool)val_4;
        }
        internal bool 丏与丂万丙丂上下丘(int 与丕丗与丄丞东业丞, int 丂三丟丂丈丐丆丗丟)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(丂三丟丂丈丐丆丗丟 <= 0)
            {
                    return this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            if((this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions.Item[与丕丗与丄丞东业丞] == 丂三丟丂丈丐丆丗丟)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SaveLastPresentationTimeViewPromotions;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  丂三丟丂丈丐丆丗丟);
            val_4 = 1;
            return (bool)val_4;
        }
        public 下丏丕丙丒七丞丞丄()
        {
        
        }
        private static 下丏丕丙丒七丞丞丄()
        {
            Progress.下丏丕丙丒七丞丞丄.丕丟一七丑丙丂丆丙 = "ManualOffersSlot";
            Progress.下丏丕丙丒七丞丞丄.丐丌丞上世丛丐丏丛 = "ManualOffersSlot_Key_2020";
        }
    
    }

}
