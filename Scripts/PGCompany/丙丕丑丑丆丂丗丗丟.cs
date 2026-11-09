using UnityEngine;

namespace PGCompany
{
    internal sealed class 丙丕丑丑丆丂丗丗丟 : 丒丘与丞丐不七丈与
    {
        // Fields
        private PGCompany.ArmorSkinSettings 丅万专且上丁七专丄;
        
        // Properties
        internal PGCompany.ArmorSkinSettings 且丛三丐丁丒下丅万 { get; }
        
        // Methods
        internal 丙丕丑丑丆丂丗丗丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal PGCompany.ArmorSkinSettings 丂丅丅丏丙上专专丕()
        {
            PGCompany.ArmorSkinSettings val_5;
            if(this.丅万专且上丁七专丄 == 0)
            {
                    this.丅万专且上丁七专丄 = PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世().丒丗丁丞不上业万且(且丘世丏丛丛万丟万:  this.业上丙丞丐丄丆丅七());
                return val_5;
            }
            
            val_5 = this.丅万专且上丁七专丄;
            return val_5;
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            PGCompany.ArmorSkinSettings val_1 = this.丂丅丅丏丙上专专丕();
            if(val_1 != null)
            {
                    return val_1.Price;
            }
            
            return val_1.Price;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.丂丅丅丏丙上专专丕().LocalizationKey)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丂丅丅丏丙上专专丕().LocalizationKey);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七() + "_icon1_big");
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七() + "_icon1_big");
        }
        internal string 不丁上上且三丑七丂()
        {
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.丂丅丅丏丙上专专丕().LocalizationKey)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  this.丂丅丅丏丙上专专丕().LocalizationKey);
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1829");
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8968");
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丙丕丑丑丆丂丗丗丟(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
