using UnityEngine;

namespace Progress
{
    internal class 专丟丝丂丕丟丒世东 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private Progress.丏丛七专丐不丅丐丆 <丁丄丈丕丏丘丑丝专>k__BackingField;
        private Progress.专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑 且丈丘七丐下专东丁;
        
        // Properties
        internal Progress.丏丛七专丐不丅丐丆 丐下下丄丈丕上丗专 { get; set; }
        internal bool 不上一丟丘丁不不业 { get; }
        internal int 业世丙丐上业不丒东 { get; }
        internal int 丒丁东三一丆丙丘世 { get; }
        internal bool 业一与丏丄与丁丅七 { get; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal Progress.丏丛七专丐不丅丐丆 丟丆下丟丈世业丁丈()
        {
            return (Progress.丏丛七专丐不丅丐丆)this.<丁丄丈丕丏丘丑丝专>k__BackingField;
        }
        private void 且丆丙与丐丟业世丑(Progress.丏丛七专丐不丅丐丆 丙业与丙丗丝不丈东)
        {
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 且丛丈丝丘丈一丙丟()
        {
            return (bool)(this.且丈丘七丐下专东丁._isMarkEndSeason != 0) ? 1 : 0;
        }
        internal int 与三丌专丒下丏丏丏()
        {
        
        }
        internal int 世万丅丞下丌丐不丈()
        {
        
        }
        internal bool 七丝丁丗七丆下丈丌()
        {
            return (bool)(this.且丈丘七丐下专东丁._isActiveSeason != 0) ? 1 : 0;
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑();
            this.<丁丄丈丕丏丘丑丝专>k__BackingField = new Progress.丏丛七专丐不丅丐丆();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 55;
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
            return (string)Progress.专丟丝丂丕丟丒世东.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.专丟丝丂丕丟丒世东.丐丌丞上世丛丐丏丛;
        }
        internal bool 业一丅业三丒业七业(int 丈丘丝一丗下丈丐不)
        {
            var val_2;
            if(this.且丈丘七丐下专东丁._currentLevel < 丈丘丝一丗下丈丐不)
            {
                    int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                val_2 = 1;
                this.且丈丘七丐下专东丁._currentLevel = 0;
                mem2[0] = 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        internal bool 丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)
        {
            if(this.且丈丘七丐下专东丁 != null)
            {
                    return this.且丈丘七丐下专东丁.丄丝下丙丅且丘丞丏(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不);
            }
            
            return this.且丈丘七丐下专东丁.丄丝下丙丅且丘丞丏(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不);
        }
        internal bool 丑三三丝下丙丌丄下(int 丈丘丝一丗下丈丐不)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丘丝一丗下丈丐不);
            return this.且丈丘七丐下专东丁.下丟万世东丞丛丏丟(丈丄七下下丙一丐丛:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_1.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_1.上万三丆专丏丒丗业});
        }
        internal void 世丄且丒丌丟丕世丛(long 丝丙一丝丈丂不丙一, int 一七丒丘东丑丞且且)
        {
            this.且丈丘七丐下专东丁.三东上东丝业丂世丆(丙业与丙丗丝不丈东:  true);
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.且丈丘七丐下专东丁._currentSeason = 0;
            mem2[0] = 0;
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.且丈丘七丐下专东丁._lastSeason = 0;
            mem2[0] = 0;
            this.且丈丘七丐下专东丁.不东丗丏七丈且丁一(丙业与丙丗丝不丈东:  false);
        }
        internal void 丗丟七丁不丟一业下(long 丝丙一丝丈丂不丙一)
        {
            this.且丈丘七丐下专东丁.三东上东丝业丂世丆(丙业与丙丗丝不丈东:  false);
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.且丈丘七丐下专东丁._currentSeason = 0;
            mem2[0] = 0;
        }
        internal void 业不三丌丅且万三三()
        {
            this.且丈丘七丐下专东丁.不东丗丏七丈且丁一(丙业与丙丗丝不丈东:  true);
        }
        internal int 三三三东丑丁且与万()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑();
        }
        public 专丟丝丂丕丟丒世东()
        {
        
        }
        private static 专丟丝丂丕丟丒世东()
        {
            Progress.专丟丝丂丕丟丒世东.丕丟一七丑丙丂丆丙 = "TrophyRoadSlot";
            Progress.专丟丝丂丕丟丒世东.丐丌丞上世丛丐丏丛 = "TrophyRoadSlot_Key_2020";
        }
    
    }

}
