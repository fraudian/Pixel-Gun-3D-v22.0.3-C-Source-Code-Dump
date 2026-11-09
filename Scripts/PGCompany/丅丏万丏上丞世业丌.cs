using UnityEngine;

namespace PGCompany
{
    internal sealed class 丅丏万丏上丞世业丌 : 丑业七一丏丈丟丒三
    {
        // Methods
        protected override string 丁丅下丅七丂丆一丟()
        {
            if(X19.三丘丆丅丝丙一丑与() == null)
            {
                
            }
        
        }
        protected override string 不万业不三丌东丒万()
        {
            var val_12;
            object val_13;
            string val_15;
            string val_16;
            val_12 = this.三丘丆丅丝丙一丑与();
            Rilisoft.OfferItemType val_5 = val_12.不业丙丒丂丞下丆丙();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_12.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
            {
                    val_13 = val_5;
                string val_6 = val_12.业上丙丞丐丄丆丅七();
                val_15 = "PromotionExtend_{0}_{1}";
            }
            else
            {
                    val_13 = val_5;
                val_15 = "PromotionBuy_{0}_{1}";
            }
            
            val_16 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  val_15, arg0:  val_5, arg1:  val_12.业上丙丞丐丄丆丅七()));
            if(val_12 == null)
            {
                    return (string)val_16;
            }
            
            if(null != null)
            {
                    return (string)val_16;
            }
            
            val_16 = (null == null) ? (val_12) : 0.东且丏丆万与东丙万(不丗丆专业丈丞东七:  val_16);
            return (string)val_16;
        }
        protected override string 万丝专万专专丘万丙()
        {
            var val_8;
            string val_9;
            val_8 = this.三丘丆丅丝丙一丑与();
            val_9 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "PromotionGift_{0}_{1}", arg0:  val_8.不业丙丒丂丞下丆丙(), arg1:  val_8.业上丙丞丐丄丆丅七()));
            if(val_8 == null)
            {
                    return (string)val_9;
            }
            
            if(null != null)
            {
                    return (string)val_9;
            }
            
            val_9 = (null == null) ? (val_8) : 0.东且丏丆万与东丙万(不丗丆专业丈丞东七:  val_9);
            return (string)val_9;
        }
        protected override string 丈丘丆丏三一丅三七()
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_1 = this.三丘丆丅丝丙一丑与();
            PGCompany.ClanStoreBuffSetting val_8 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().业丆丐丘丞上丅丕丛(丞世不丒下上上丝丑:  val_1.业东丅东丌上丗丑不());
            return (string)System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "PromotionBannerExtend_{0}_{1}", arg0:  val_1.不业丙丒丂丞下丆丙(), arg1:  val_1.业上丙丞丐丄丆丅七())), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  -219704680, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0), arg1:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  -219704648, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        public 丅丏万丏上丞世业丌()
        {
        
        }
    
    }

}
