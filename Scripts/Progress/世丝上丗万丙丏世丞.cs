using UnityEngine;

namespace Progress
{
    internal sealed class 世丝上丗万丙丏世丞 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private Progress.丛东丙丙三丐丒业三 <丁丄丈丕丏丘丑丝专>k__BackingField;
        private Progress.世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗 且丈丘七丐下专东丁;
        
        // Properties
        internal Progress.丛东丙丙三丐丒业三 丐下下丄丈丕上丗专 { get; set; }
        internal bool 丟世东丁丑丐丑丙丌 { get; }
        internal int 丆丙丈丘专丆七丘丑 { get; }
        internal bool 丗丕世丑丛不丌丁丈 { get; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal Progress.丛东丙丙三丐丒业三 丟丆下丟丈世业丁丈()
        {
            return (Progress.丛东丙丙三丐丒业三)this.<丁丄丈丕丏丘丑丝专>k__BackingField;
        }
        private void 且丆丙与丐丟业世丑(Progress.丛东丙丙三丐丒业三 丙业与丙丗丝不丈东)
        {
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丟一不丐丆丑丕东丅()
        {
            return (bool)(this.且丈丘七丐下专东丁._vip20IsOver != 0) ? 1 : 0;
        }
        internal int 一且丄丄丏丛丁丗东()
        {
        
        }
        internal bool 丈丂丗与下万丕丁不()
        {
            return (bool)(this.且丈丘七丐下专东丁._isCompleteMigration != 0) ? 1 : 0;
        }
        internal Rilisoft.PlayerPaymentType 一与不丙丝万丐丂七(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SavePaymentType.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SavePaymentType != null)
            {
                    return this.且丈丘七丐下专东丁.SavePaymentType.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SavePaymentType.Item[与丕丗与丄丞东业丞];
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
        internal int 丑丑专丄丐下下万丑(int 与丕丗与丄丞东业丞)
        {
            if((this.且丈丘七丐下专东丁.SaveTimeGeneration.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) == false)
            {
                    return 0;
            }
            
            if(this.且丈丘七丐下专东丁.SaveTimeGeneration != null)
            {
                    return this.且丈丘七丐下专东丁.SaveTimeGeneration.Item[与丕丗与丄丞东业丞];
            }
            
            return this.且丈丘七丐下专东丁.SaveTimeGeneration.Item[与丕丗与丄丞东业丞];
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗();
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = new Progress.丛东丙丙三丐丒业三();
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 66;
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
            return (string)Progress.世丝上丗万丙丏世丞.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.世丝上丗万丙丏世丞.丐丌丞上世丛丐丏丛;
        }
        internal bool 下业世万丆与上丈丙(int 与丕丗与丄丞东业丞, Rilisoft.PlayerPaymentType 丈且丟丗丈专丒与丁)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(this.且丈丘七丐下专东丁.SavePaymentType == null)
            {
                goto label_1;
            }
            
            if(丈且丟丗丈专丒与丁 == 0)
            {
                    return this.且丈丘七丐下专东丁.SavePaymentType.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            label_10:
            if((this.且丈丘七丐下专东丁.SavePaymentType.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SavePaymentType.Item[与丕丗与丄丞东业丞] == 丈且丟丗丈专丒与丁)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SavePaymentType;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  丈且丟丗丈专丒与丁);
            val_4 = 1;
            return (bool)val_4;
            label_1:
            if(丈且丟丗丈专丒与丁 != 0)
            {
                goto label_10;
            }
            
            return this.且丈丘七丐下专东丁.SavePaymentType.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
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
        internal bool 业不与东万丄丅丘丌(int 与丕丗与丄丞东业丞, int 丂三丟丂丈丐丆丗丟)
        {
            PGCompany.上丅丙丟不业不丆东 val_3;
            var val_4;
            val_3 = this;
            if(丂三丟丂丈丐丆丗丟 <= 0)
            {
                    return this.且丈丘七丐下专东丁.SaveTimeGeneration.Remove(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞);
            }
            
            if((this.且丈丘七丐下专东丁.SaveTimeGeneration.ContainsKey(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞)) != false)
            {
                    if(this.且丈丘七丐下专东丁.SaveTimeGeneration.Item[与丕丗与丄丞东业丞] == 丂三丟丂丈丐丆丗丟)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            }
            
            val_3 = this.且丈丘七丐下专东丁.SaveTimeGeneration;
            val_3.set_Item(下上丐丆丝丟丝丒不:  与丕丗与丄丞东业丞, 丙业与丙丗丝不丈东:  丂三丟丂丈丐丆丗丟);
            val_4 = 1;
            return (bool)val_4;
        }
        internal bool 与丞下丂丐与不业与(bool 丙业与丙丗丝不丈东)
        {
            var val_3;
            if(this.丟一不丐丆丑丕东丅() ^ 丙业与丙丗丝不丈东 != false)
            {
                    丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
                this.且丈丘七丐下专东丁.专丞下世七丄丞丛丞(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        internal bool 东丗丁业与丒下丐丐(int 丂三丟丂丈丐丆丗丟)
        {
            var val_3;
            if(this.一且丄丄丏丛丁丗东() == 丂三丟丂丈丐丆丗丟)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_3 = 1;
            this.且丈丘七丐下专东丁._lastTimeView = 0;
            mem2[0] = 0;
            return (bool)val_3;
        }
        internal bool 万丗丗下丞万与七丗()
        {
            丁丘丏三丙上专丕丗 val_2;
            var val_3;
            val_2 = this;
            if(this.丈丂丗与下万丕丁不() != false)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            val_2 = this.且丈丘七丐下专东丁;
            val_3 = 1;
            val_2.世丕七丕丛上业一丄(丙业与丙丗丝不丈东:  true);
            return (bool)val_3;
        }
        public 世丝上丗万丙丏世丞()
        {
        
        }
        private static 世丝上丗万丙丏世丞()
        {
            Progress.世丝上丗万丙丏世丞.丕丟一七丑丙丂丆丙 = "Vip20Slot";
            Progress.世丝上丗万丙丏世丞.丐丌丞上世丛丐丏丛 = "Vip20Slot_Key_2021";
        }
    
    }

}
