using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丁丙下丅上上丛东万 : 丅三丑丂丝丈专不一
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.daily-tier";
        }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝()
        {
            return 90;
        }
        protected override PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            var val_18;
            var val_19;
            var val_20;
            string val_22;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_1 = this.丝与丘丘丅业一业丘(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌);
            val_18 = 0;
            goto label_1;
            label_12:
            val_19 = null;
            val_19 = null;
            if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == 丙业丞丑七丗下丟丌.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世())
            {
                goto label_8;
            }
            
            val_18 = 1;
            label_1:
            val_20 = null;
            val_20 = null;
            if(val_18 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                goto label_12;
            }
            
            label_8:
            PGCompany.StorePromotionConfig val_4 = val_1.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_5 = val_4.Settings;
            val_5.TexturePath = System.String.Format(format:  "OfferIcons\\offer_tier_{0}", arg0:  0 + 1);
            val_1.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_4);
            int val_9 = 丙业丞丑七丗下丟丌.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世();
            if(val_9 <= 10)
            {
                goto label_19;
            }
            
            if(val_9 == 20)
            {
                goto label_20;
            }
            
            if(val_9 == 50)
            {
                goto label_21;
            }
            
            if(val_9 != 100)
            {
                goto label_26;
            }
            
            if(val_4.Settings == null)
            {
                goto label_43;
            }
            
            val_22 = "Key_7589";
            goto label_41;
            label_19:
            if((val_9 - 1) > 9)
            {
                goto label_26;
            }
            
            var val_19 = 106037776 + ((val_9 - 1)) << 2;
            val_19 = val_19 + 106037776;
            goto (106037776 + ((val_9 - 1)) << 2 + 106037776);
            label_26:
            if(val_4.Settings == null)
            {
                goto label_43;
            }
            
            val_22 = "Key_7584";
            goto label_41;
            label_20:
            if(val_4.Settings == null)
            {
                goto label_43;
            }
            
            val_22 = "Key_1056";
            goto label_41;
            label_21:
            if(val_4.Settings == null)
            {
                goto label_43;
            }
            
            val_22 = "Key_7588";
            label_41:
            val_17.TitleLocKey = ;
            PGCompany.StorePromotionSettings val_18 = val_4.Settings;
            val_18.DescriptionLocKey = "Key_5584";
            return val_1;
            label_43:
        }
        public 丁丙下丅上上丛东万()
        {
        
        }
    
    }

}
