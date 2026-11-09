using UnityEngine;

namespace PGCompany
{
    internal class 且丟万丈丆丞丕丏七 : 丆丒丏不丄丝世丁专
    {
        // Methods
        internal 且丟万丈丆丞丕丏七(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return "[TANK]";
        }
        internal override string 东且丏丆万与东丙万()
        {
            return "[TANK DESCRIPTION]";
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(this.业东丅东丌上丗丑不() == 16015)
            {
                    val_6 = "OfferIcons/keysmallchest";
                return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_5.ToLower());
            }
            
            val_5 = this.业上丙丞丐丄丆丅七();
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_5.ToLower());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(this.业东丅东丌上丗丑不() == 16015)
            {
                    val_6 = "OfferMiniIcons/keysmallchest";
                return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/"("OfferMiniIcons/") + val_5.ToLower());
            }
            
            val_5 = this.业上丙丞丐丄丆丅七();
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/"("OfferMiniIcons/") + val_5.ToLower());
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.且丟万丈丆丞丕丏七(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
