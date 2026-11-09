using UnityEngine;

namespace PGCompany
{
    internal sealed class 一三丛丅丌丒丙丆一 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private PGCompany.LootBoxSystem.东丆一丞丛不与与丐 丁丘丄丕下专东七不;
        private PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 丙七丘丅丛丘万三丞;
        
        // Properties
        internal PGCompany.LootBoxSystem.东丆一丞丛不与与丐 丞丑且东丌与丏丏丁 { get; }
        private PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 丗七丐丏丙丟丟世丟 { get; }
        
        // Methods
        internal PGCompany.LootBoxSystem.东丆一丞丛不与与丐 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return val_3;
            }
            
            PGCompany.LootBoxSystem.东丆一丞丛不与与丐 val_3 = PGCompany.LootBoxSystem.七丈三丂且丗丈世一.丑七不且上丗丁一世().专上业丝丁丑世三丝(丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不());
            this.丁丘丄丕下专东七不 = val_3;
            return val_3;
        }
        private PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 上丄丂丄丙丗丛丌丟()
        {
            if(this.丙七丘丅丛丘万三丞 != null)
            {
                    return val_2;
            }
            
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_2 = PGCompany.ItemVisualSystem.丄万丛且一丈与丝不.丙丘丝七业丟丁与丛(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
            this.丙七丘丅丛丘万三丞 = val_2;
            return val_2;
        }
        public 一三丛丅丌丒丙丆一(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.一三丛丅丌丒丙丆一(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 == null)
            {
                    return (UnityEngine.Texture)val_1;
            }
            
            return PGCompany.丁丑上丞业丞丟丛上.丑东丐下专丞丕丘世(丑丐丗三东丑丈且丑:  val_1);
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 == null)
            {
                    return (UnityEngine.Texture)val_1;
            }
            
            return PGCompany.丁丑上丞业丞丟丛上.三丗一丄不丆不丏三(丑丐丗三东丑丈且丑:  val_1);
        }
        internal override string 七业丑不七丐业丟丂()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    if((且专且丕丅不且丙丟.三与不丄下丑三丐上(专丆丐丅下丌丂丛丌:  val_1)) != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    if((且专且丕丅不且丙丟.与丆丒丐七东丄业丒(专丆丐丅下丌丂丛丌:  val_1)) != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal override string 东且丏丆万与东丙万()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    if((且专且丕丅不且丙丟.丑丁丝世丏专丅上与(专丆丐丅下丌丂丛丌:  val_1)) != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal string 丟一上丝丆丈下丈丄()
        {
            string val_2;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_2 = val_1.PrefabUI;
                if(val_2 != null)
            {
                    return "LootBoxes/Prefabs/LootBoxUI/"("LootBoxes/Prefabs/LootBoxUI/") + val_2;
            }
            
            }
            
            val_2 = System.String.alignConst;
            return "LootBoxes/Prefabs/LootBoxUI/"("LootBoxes/Prefabs/LootBoxUI/") + val_2;
        }
        internal string 世丒丗万丐与丞丗丂()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    if(val_1.一丄专三丒上丆万世() != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal override bool 丛七丈丄不丟下丑丈()
        {
            return true;
        }
        internal PGCompany.LootBoxSystem.丌丐丏丅丒丈丏七一 专万丙丆世三世丗七()
        {
            PGCompany.LootBoxSystem.丌丐丏丅丒丈丏七一 val_2;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.OpenAnimationType;
            return val_2;
        }
        internal PGCompany.LootBoxSystem.丛丂丌丒东丅丌三丅 上丝丝世万丘丕万丟()
        {
            PGCompany.LootBoxSystem.丛丂丌丒东丅丌三丅 val_2;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return val_2;
            }
            
            val_2 = val_1.RewardShowCaseType;
            return val_2;
        }
        internal bool 丞东丛丅下万不业与()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (bool)(val_1.ShowObtained == true) ? 1 : 0;
            }
            
            return (bool)(val_1.ShowObtained == true) ? 1 : 0;
        }
        internal string 丌丏丈丗丌不七与不()
        {
            string val_2;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_2 = val_1.GuiApplyer;
                if(val_2 != null)
            {
                    return (string)val_2;
            }
            
            }
            
            val_2 = System.String.alignConst;
            return (string)val_2;
        }
        internal bool 世七不丆丘与与丁东()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (bool)(val_1.BulkOpen == true) ? 1 : 0;
            }
            
            return (bool)(val_1.BulkOpen == true) ? 1 : 0;
        }
        internal bool 丐不丐世三丕丘丆丝()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (bool)(val_1.AutoOpen == true) ? 1 : 0;
            }
            
            return (bool)(val_1.AutoOpen == true) ? 1 : 0;
        }
        internal override bool 七丄与不丁丙丑丞不()
        {
            return false;
        }
        internal UnityEngine.Texture 丕东三上且且丕下世()
        {
            string val_5;
            if(this.丁专丗万三上丟三丆() == null)
            {
                goto label_1;
            }
            
            val_5 = val_1.ImagePattern;
            if(val_5 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_5 = System.String.alignConst;
            label_2:
            UnityEngine.Texture val_3 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Patterns/"("Patterns/") + val_5);
            if(val_3 != 0)
            {
                    return val_3;
            }
            
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Textures/AssetsError");
        }
    
    }

}
