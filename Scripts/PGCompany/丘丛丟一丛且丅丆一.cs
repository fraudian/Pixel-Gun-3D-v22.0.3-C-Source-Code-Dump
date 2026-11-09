using UnityEngine;

namespace PGCompany
{
    internal class 丘丛丟一丛且丅丆一 : 丆丒丏不丄丝世丁专
    {
        // Methods
        public 丘丛丟一丛且丅丆一(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Stats/"("OfferIcons/Stats/") + this.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Stats/"("OfferIcons/Stats/") + this.业上丙丞丐丄丆丅七() + "_mini");
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            if(this.业东丅东丌上丗丑不() != 305015)
            {
                    return this.丐丞丐丝下上上丐丂();
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9625");
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丘丛丟一丛且丅丆一(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
