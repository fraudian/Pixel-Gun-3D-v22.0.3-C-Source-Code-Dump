using UnityEngine;

namespace PGCompany
{
    internal sealed class 丏丈万丐东丝丟下丗 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private PGCompany.万丅专业专丗七丌与 丁丘丄丕下专东七不;
        
        // Properties
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        
        // Methods
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            if(this.丁丘丄丕下专东七不 == null)
            {
                    return 9990000;
            }
            
            return (CategoryNames)this.丁丘丄丕下专东七不.七丌丌丏丗东丕且丅;
        }
        public 丏丈万丐东丝丟下丗(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_9;
            PGCompany.万丅专业专丗七丌与 val_10;
            val_9 = PGCompany.丂七下丟不丑丐丅丗.丑七不且上丗丁一世().且丕丄且丈丁丅下丙();
            if((val_9.ContainsKey(key:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七())) == false)
            {
                goto label_4;
            }
            
            val_9 = PGCompany.丂七下丟不丑丐丅丗.丑七不且上丗丁一世().且丕丄且丈丁丅下丙();
            val_10 = val_9.Item[丈丄不七三万丄丁不.业上丙丞丐丄丆丅七()];
            if(this != null)
            {
                goto label_10;
            }
            
            goto label_9;
            label_4:
            val_10 = 0;
            if(this != null)
            {
                goto label_10;
            }
            
            label_9:
            label_10:
            this.丁丘丄丕下专东七不 = val_10;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/FreeUpgrade/"("OfferIcons/FreeUpgrade/") + this.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/FreeUpgrade/"("OfferIcons/FreeUpgrade/") + this.业上丙丞丐丄丆丅七() + "_mini");
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5061");
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丏丈万丐东丝丟下丗(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
