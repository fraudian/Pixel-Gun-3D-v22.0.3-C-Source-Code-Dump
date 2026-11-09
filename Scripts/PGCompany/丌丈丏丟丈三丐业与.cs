using UnityEngine;

namespace PGCompany
{
    internal class 丌丈丏丟丈三丐业与 : 丌丐下丌丘下丝丞业
    {
        // Methods
        internal 丌丈丏丟丈三丐业与(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4053");
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4054");
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons\\VIP_universal");
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/VIP_small_icon");
        }
        internal override bool 丛七丈丄不丟下丑丈()
        {
            return true;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丌丈丏丟丈三丐业与(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
