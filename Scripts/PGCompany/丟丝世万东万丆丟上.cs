using UnityEngine;

namespace PGCompany
{
    internal sealed class 丟丝世万东万丆丟上 : 丒丘与丞丐不七丈与
    {
        // Fields
        private WeaponSkinSettings 世丂丛上业丒丄三丐;
        
        // Properties
        internal WeaponSkinSettings 丂丐丐丗丂丄上丂丗 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        
        // Methods
        internal 丟丝世万东万丆丟上(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal WeaponSkinSettings 上专丗丏丛丁专丑丄()
        {
            WeaponSkinSettings val_4;
            if(this.世丂丛上业丒丄三丐 == 0)
            {
                    this.世丂丛上业丒丄三丐 = 丏丞丛上七丁丞丛万.丆丄三丐丌世下万丟(丝与丙丘丞且丄专丅:  this.业上丙丞丐丄丆丅七());
                return val_4;
            }
            
            val_4 = this.世丂丛上业丒丄三丐;
            return val_4;
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            WeaponSkinSettings val_1 = this.上专丗丏丛丁专丑丄();
            if(val_1 != null)
            {
                    return val_1.Rarity;
            }
            
            return val_1.Rarity;
        }
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            return 240000;
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            WeaponSkinSettings val_1 = this.上专丗丏丛丁专丑丄();
            if(val_1 != null)
            {
                    return val_1.PurchasePrice;
            }
            
            return val_1.PurchasePrice;
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            var val_4;
            string val_5;
            val_4 = this;
            WeaponSkinSettings val_1 = this.上专丗丏丛丁专丑丄();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_1.nameLocalizationKey)) == false)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_4 = this.上专丗丏丛丁专丑丄();
            val_5 = val_3.nameLocalizationKey;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            if(this.上专丗丏丛丁专丑丄().IsDefault == false)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七() + "_icon1_big");
            }
            
            PGCompany.丟丝东丈丐丙三下丛 val_4 = this.上专丗丏丛丁专丑丄().ItemWeapon;
            this = ???;
            goto typeof(PGCompany.丟丝东丈丐丙三下丛).__il2cppRuntimeField_1C8;
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            if(this.上专丗丏丛丁专丑丄().IsDefault == false)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七() + "_icon1_big");
            }
            
            PGCompany.丟丝东丈丐丙三下丛 val_4 = this.上专丗丏丛丁专丑丄().ItemWeapon;
            this = ???;
            goto typeof(PGCompany.丟丝东丈丐丙三下丛).__il2cppRuntimeField_1C8;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            if(this.上专丗丏丛丁专丑丄() == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            WeaponSkinSettings val_3 = this.上专丗丏丛丁专丑丄();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3.nameLocalizationKey)) == false)
            {
                    return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12390"), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this));
            }
            
            return (string)System.String.alignConst;
        }
        internal override string 东且丏丆万与东丙万()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12388"), arg0:  丏丄丑上丛不丈且万.丌下丗东不丞三七东()[(long)this.上专丗丏丛丁专丑丄().ItemWeapon] + this.上专丗丏丛丁专丑丄().ItemWeapon + "[-]"("[-]"));
        }
        internal string 不丁上上且三丑七丂()
        {
            WeaponSkinSettings val_1 = this.上专丗丏丛丁专丑丄();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_1.nameLocalizationKey)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            WeaponSkinSettings val_3 = this.上专丗丏丛丁专丑丄();
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_3.nameLocalizationKey);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丟丝世万东万丆丟上(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
