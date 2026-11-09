using UnityEngine;

namespace PGCompany
{
    internal sealed class 三丘丌上丁万丏丛丟 : 丅丄不丛东丝一七丞
    {
        // Properties
        internal bool 丏专丆丘丂丁专丛东 { get; set; }
        internal ModuleChestData 一丐丗丁丞丆丅丟丄 { get; }
        internal int 丂丘丘丅丌丁丆业丅 { get; }
        internal 丈丞丕丘丕丗与上一 业丏丌丌丝东丌世丑 { get; }
        internal System.Collections.Generic.List<ModulePointWithProbability> 上丈丝丙不丛专丝丅 { get; }
        
        // Methods
        internal bool 丆丒七丈丅且丂丒丑()
        {
            return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ModuleChest_ShownInShop_" + this.丅丙丛丑丌丆丌丕丒(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
        }
        internal void 且且丛世丟丈世丄丄(bool 丙业与丙丗丝不丈东)
        {
            string val_4;
            var val_5;
            string val_6;
            int val_1 = this.丅丙丛丑丌丆丌丕丒();
            if(丙业与丙丗丝不丈东 != false)
            {
                    val_4 = "ModuleChest_ShownInShop_" + val_1;
                val_5 = 1;
                val_6 = val_4;
            }
            else
            {
                    val_4 = "ModuleChest_ShownInShop_" + val_1;
                val_6 = val_4;
                val_5 = 0;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_6, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/ModuleChests/ModuleChest_"("OfferIcons/ModuleChests/ModuleChest_") + this.业上丙丞丐丄丆丅七() + "_icon");
        }
        internal ModuleChestData 丁且七专七丗上与丑()
        {
            return 丐东不丅丂丂丅丙不.丑丟丆业上七丅不丏(丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七());
        }
        internal int 丑丞一丘万丘丗业丘()
        {
            ModuleChestData val_1 = this.丁且七专七丗上与丑();
        }
        internal 丈丞丕丘丕丗与上一 丆一丘万丁上丒丏三()
        {
            if(this.丁且七专七丗上与丑() != null)
            {
                    return (丈丞丕丘丕丗与上一)val_1.openPrice;
            }
            
            return (丈丞丕丘丕丗与上一)val_1.openPrice;
        }
        internal System.Collections.Generic.List<ModulePointWithProbability> 不丌七万一丗丙与丆()
        {
            ModuleChestData val_1 = this.丁且七专七丗上与丑();
            if(val_1.modulesList != null)
            {
                    return (System.Collections.Generic.List<ModulePointWithProbability>)val_1.modulesList.BaseConfig;
            }
            
            return (System.Collections.Generic.List<ModulePointWithProbability>)val_1.modulesList.BaseConfig;
        }
        internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七()
        {
            ModuleChestData val_1 = this.丁且七专七丗上与丑();
            if(val_1 != null)
            {
                    return val_1.丙丐不与丏丁下丑七();
            }
            
            return val_1.丙丐不与丏丁下丑七();
        }
        internal 丈丞丕丘丕丗与上一 且丁不丟丗丘东丘世(int 丄专万丏丘上丑与一)
        {
            float val_13;
            ModuleChestData val_5 = this.丁且七专七丗上与丑();
            val_13 = ((float)丄专万丏丘上丑与一 / (float)this.丑丞一丘万丘丗业丘()) * (float)this.丆一丘万丁上丒丏三().丟丂丞不专丆万丒世();
            if(val_5.Type == 6)
            {
                    return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  UnityEngine.Mathf.CeilToInt(f:  val_13 = (float)this.丆一丘万丁上丒丏三().丟丂丞不专丆万丒世()), 丏丂不专上丘丂不丅:  this.丆一丘万丁上丒丏三().东与三丌丅三丒丏业());
            }
            
            if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
            {
                    return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  UnityEngine.Mathf.CeilToInt(f:  val_13), 丏丂不专上丘丂不丅:  this.丆一丘万丁上丒丏三().东与三丌丅三丒丏业());
            }
            
            return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  UnityEngine.Mathf.CeilToInt(f:  val_13), 丏丂不专上丘丂不丅:  this.丆一丘万丁上丒丏三().东与三丌丅三丒丏业());
        }
        internal 三丘丌上丁万丏丛丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            ModuleChestData val_1 = this.丁且七专七丗上与丑();
            return (string)"ModuleChest_" + val_1.Type;
        }
        internal override string 东且丏丆万与东丙万()
        {
            ModuleChestData val_1 = this.丁且七专七丗上与丑();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "ModuleChest_Description_" + val_1.Type.ToString());
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.三丘丌上丁万丏丛丟(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
