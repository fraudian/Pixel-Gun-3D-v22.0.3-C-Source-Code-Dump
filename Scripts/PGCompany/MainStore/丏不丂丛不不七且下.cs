using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丏不丂丛不不七且下 : 下丐丒丙丂丁丗丘丘, 业一业不与丝丞丘丘
    {
        // Fields
        public PGCompany.MainStore.丏不丂丛不不七且下.丛东东丐东专三丅丆 丆上丙丈丕丂丘丛丌;
        public string 丞丟丂丄下万丈万东;
        public ItemRarity 东东世丝业丝一丂丄;
        public Rilisoft.OfferItem 丝东丅专下专上丕丌;
        public string 上一丑下丙丛上丕丐;
        private Rilisoft.业丙丘丆东丈丕丂丄.OfferModule <丈丞丝上丑世丙丆丝>k__BackingField;
        private string <丈三一丑丑七丐下不>k__BackingField;
        private Rilisoft.业丙丘丆东丈丕丂丄 <与丂丂丆一丛丒丌一>k__BackingField;
        
        // Properties
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule OfferModule { get; set; }
        public string BindedOfferId { get; set; }
        public Rilisoft.业丙丘丆东丈丕丂丄 丟专丘七丒丙七不丗 { get; set; }
        
        // Methods
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 不丆丑丌三不丗丐丈()
        {
            return (OfferModule)this.<丈丞丝上丑世丙丆丝>k__BackingField;
        }
        private void 七丒丏丂万东丗丄三(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丙业与丙丗丝不丈东)
        {
            this.<丈丞丝上丑世丙丆丝>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string 丙三丝一丝专丌丁丛()
        {
            return (string)this.<丈三一丑丑七丐下不>k__BackingField;
        }
        private void 且丌七丘丒七丙丙丛(string 丙业与丙丗丝不丈东)
        {
            this.<丈三一丑丑七丐下不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丞丂上世丌丒世下七()
        {
            return (Rilisoft.业丙丘丆东丈丕丂丄)this.<与丂丂丆一丛丒丌一>k__BackingField;
        }
        private void 丆七丆丟一丝丑与丑(Rilisoft.业丙丘丆东丈丕丂丄 丙业与丙丗丝不丈东)
        {
            this.<与丂丂丆一丛丒丌一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丏不丂丛不不七且下(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业, PGCompany.DataObjects.专丅一丄上丗且丑一 且万丄丏专丄丛丌丗, Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗与丟上上丑专世丗, Rilisoft.业丙丘丆东丈丕丂丄 丙丌丛丗丙东丟专丟)
        {
            this.<丈丞丝上丑世丙丆丝>k__BackingField = 丗与丟上上丑专世丗;
            this.<与丂丂丆一丛丒丌一>k__BackingField = 丙丌丛丗丙东丟专丟;
            this.<丈三一丑丑七丐下不>k__BackingField = 丙丌丛丗丙东丟专丟.业上丙丞丐丄丆丅七();
        }
        internal string 丏丟丅丑丞丅丌丘丝()
        {
            object val_9;
            Rilisoft.OfferItem val_10;
            string val_11;
            val_9 = this;
            if(this.丆上丙丈丕丂丘丛丌 == 3)
            {
                goto label_1;
            }
            
            if(this.丆上丙丈丕丂丘丛丌 == 2)
            {
                goto label_2;
            }
            
            if(this.丆上丙丈丕丂丘丛丌 != 1)
            {
                goto label_3;
            }
            
            val_9 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.东东世丝业丝一丂丄)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.东东世丝业丝一丂丄)) + "[-]"("[-]");
            string val_4 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丞丟丂丄下万丈万东), arg0:  val_9);
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11 = val_9);
            label_1:
            val_11 = "Key_8557";
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
            label_2:
            val_10 = this.丝东丅专下专上丕丌;
            if(val_10 == null)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
            }
            
            System.Nullable<ItemRarity> val_5 = val_10.Rarity;
            val_10 = 0;
            if(( & 1) == 0)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
            }
            
            System.Nullable<ItemRarity> val_6 = this.丝东丅专下专上丕丌.Rarity;
            val_9;
            string val_7 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_6.HasValue);
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
            label_3:
            val_9 = this.丞丟丂丄下万丈万东;
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
        }
    
    }

}
