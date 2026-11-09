using UnityEngine;

namespace PGCompany
{
    internal sealed class 三丙业丆上丏三丈丌 : 丐三丛丑丛丟七丕丛
    {
        // Fields
        private PlaceableItemSettings 下丕丛下专丗一丝丄;
        private string 丌丒业丁丝世业丑丞;
        internal PGCompany.万丛下丐与丅与丅专 与丟丑丁三丗丗丅丝;
        
        // Properties
        internal PlaceableItemSettings 丛丐业七业下三丁丛 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal PGCompany.万丛下丐与丅与丅专 上丑三丁丗与丐丆上 { get; }
        
        // Methods
        internal PlaceableItemSettings 丈丏专三世七丒丘丑()
        {
            if(this.下丕丛下专丗一丝丄 != null)
            {
                    return val_4;
            }
            
            this.丌丒业丁丝世业丑丞 = PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.业上丙丞丐丄丆丅七());
            PlaceableItemSettings val_4 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七());
            this.下丕丛下专丗一丝丄 = val_4;
            return val_4;
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            if(val_1 != null)
            {
                    return val_1.ItemRarity;
            }
            
            return val_1.ItemRarity;
        }
        internal PGCompany.万丛下丐与丅与丅专 丝丝丌丟丆丂丂丞业()
        {
            PGCompany.万丛下丐与丅与丅专 val_2 = this.与丟丑丁三丗丗丅丝;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            val_2 = this;
            if((this != null) && (null != null))
            {
                    val_2 = 0;
            }
            
            this.与丟丑丁三丗丗丅丝 = val_2;
            return val_2;
        }
        public 三丙业丆上丏三丈丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丌丒业丁丝世业丑丞 = PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            if(this.丈丏专三世七丒丘丑() == null)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/unknown_item");
            }
            
            PlaceableItemSettings val_2 = this.丈丏专三世七丒丘丑();
            this = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_2.iconName);
            if(this != 0)
            {
                    return (UnityEngine.Texture)this;
            }
            
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/unknown_item");
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            var val_3;
            string val_4;
            val_3 = this;
            if(this.丈丏专三世七丒丘丑() != null)
            {
                    val_3 = this.丈丏专三世七丒丘丑();
                val_4 = val_2.nameLocalizationKey;
                return (string)val_4;
            }
            
            val_4 = "Key_8778";
            return (string)val_4;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            string val_1 = this.七业丑不七丐业丟丂();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
            }
            
            if((val_1.StartsWith(value:  "Key_")) == false)
            {
                    return val_1;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            string val_1 = this.专专三世丘丙丗丂丝();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_8778");
            }
            
            if((val_1.StartsWith(value:  "Key_")) == false)
            {
                    return val_1;
            }
            
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_8778");
        }
        internal override string 东且丏丆万与东丙万()
        {
            string val_6;
            var val_7;
            val_6 = this;
            if(this.丈丏专三世七丒丘丑() != null)
            {
                    PlaceableItemSettings val_2 = this.丈丏专三世七丒丘丑();
                val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2.descriptionLocalizationKey);
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != true)
            {
                    if((val_6.StartsWith(value:  "Key_")) == false)
            {
                    return val_6;
            }
            
            }
            
                val_7 = null;
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
            }
            
            val_7 = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            goto typeof(PGCompany.三丙业丆上丏三丈丌).__il2cppRuntimeField_1C8;
        }
        internal override PGCompany.业丞且丞丁丅丏丏丐 丞不丑丕丕丛丆世且()
        {
            PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丌世丑丄东丞丘三<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  this.丌丒业丁丝世业丑丞);
            }
            
            return val_1.一丌世丑丄东丞丘三<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  this.丌丒业丁丝世业丑丞);
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            if(this == null)
            {
                    return (string)this;
            }
            
            goto typeof(PGCompany.三丙业丆上丏三丈丌).__il2cppRuntimeField_228;
        }
        internal override bool 丞丟丑丆丁丟丁丒万()
        {
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return this.丞丟丑丆丁丟丁丒万();
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.三丙业丆上丏三丈丌(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
