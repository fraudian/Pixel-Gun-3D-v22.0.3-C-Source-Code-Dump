using UnityEngine;

namespace PGCompany
{
    internal sealed class 丌丑丕丙丅丈丈丘丄 : 丗丟丄丈东丝丕丄世
    {
        // Methods
        public 丌丑丕丙丅丈丈丘丄(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            var val_8;
            Rilisoft.OfferItemType val_1 = this.不业丙丒丂丞下丆丙();
            if(val_1 <= 1050)
            {
                goto label_1;
            }
            
            if(val_1 == 1110)
            {
                goto label_2;
            }
            
            if(val_1 == 1140)
            {
                goto label_3;
            }
            
            if(val_1 != 1190)
            {
                goto label_8;
            }
            
            val_8 = "Key_7567";
            return (string)val_8;
            label_1:
            if(val_1 == 1000)
            {
                goto label_6;
            }
            
            if(val_1 == 1010)
            {
                goto label_7;
            }
            
            if(val_1 == 1050)
            {
                    val_8 = "Key_3411";
                return (string)val_8;
            }
            
            label_8:
            if(this.业东丅东丌上丗丑不() != 8015)
            {
                goto label_10;
            }
            
            val_8 = "Key_7989";
            return (string)val_8;
            label_2:
            string val_4 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6007"), arg0:  "");
            if(val_4 != null)
            {
                    return val_4.Trim();
            }
            
            return val_4.Trim();
            label_3:
            val_8 = "ModuleChest_Property_CraftСurrencyCount";
            return (string)val_8;
            label_6:
            val_8 = "Key_0951";
            return (string)val_8;
            label_7:
            val_8 = "Key_0275";
            return (string)val_8;
            label_10:
            if(this.业东丅东丌上丗丑不() == 601015)
            {
                    val_8 = "Key_11442";
                return (string)val_8;
            }
            
            if(this.业东丅东丌上丗丑不() == (601015 + 1000))
            {
                    val_8 = "Key_11443";
                return (string)val_8;
            }
            
            if(this.业东丅东丌上丗丑不() != (601015 + 2000))
            {
                    return this.七丝七丈丆东三丞丞();
            }
            
            val_8 = "Key_12339";
            return (string)val_8;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((this.不业丙丒丂丞下丆丙().Equals(obj:  1110)) == false)
            {
                    return (string)this.Trim();
            }
            
            this = System.String.Format(format:  this.七业丑不七丐业丟丂(), arg0:  "");
            return (string)this.Trim();
        }
        internal override string 东且丏丆万与东丙万()
        {
            if(this.业东丅东丌上丗丑不() != 3015)
            {
                    return this.东且丏丆万与东丙万();
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5775");
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((this.不业丙丒丂丞下丆丙().Equals(obj:  1110)) == false)
            {
                    return (string)this.Trim();
            }
            
            this = System.String.Format(format:  this.专专三世丘丙丗丂丝(), arg0:  "");
            return (string)this.Trim();
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            UnityEngine.Texture val_2 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.下七丟丄丁丗下丞丕());
            bool val_3 = UnityEngine.Object.op_Equality(x:  val_2, y:  0);
            return val_2;
        }
        internal string 下七丟丄丁丗下丞丕()
        {
            var val_20;
            string val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            Rilisoft.OfferItemType val_1 = this.不业丙丒丂丞下丆丙();
            if(val_1 <= 1050)
            {
                goto label_1;
            }
            
            if(val_1 == 1110)
            {
                goto label_2;
            }
            
            if(val_1 == 1140)
            {
                goto label_3;
            }
            
            if(val_1 != 1190)
            {
                goto label_10;
            }
            
            val_20 = this.丂丁丏一丙丛业且丌();
            val_21 = "Coupons";
            val_22 = 0;
            return BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_21 = val_26, 世与丂且丘丐万丗丞:  0);
            label_1:
            if(val_1 == 1000)
            {
                goto label_8;
            }
            
            if(val_1 == 1010)
            {
                goto label_9;
            }
            
            if(val_1 != 1050)
            {
                goto label_10;
            }
            
            if(this.丂丁丏一丙丛业且丌() <= 499)
            {
                goto label_11;
            }
            
            if(this.丂丁丏一丙丛业且丌() >= 500)
            {
                    if(this.丂丁丏一丙丛业且丌() <= 999)
            {
                goto label_13;
            }
            
            }
            
            val_23 = "Textures/Bank/Event/Event_Currency_3";
            return (string)val_23;
            label_10:
            int val_6 = this.业东丅东丌上丗丑不();
            if(val_6 == 26015)
            {
                goto label_15;
            }
            
            if(val_6 != 8015)
            {
                    return "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七().ToLower();
            }
            
            val_23 = "OfferIcons/silver_1";
            return (string)val_23;
            label_3:
            val_23 = "OfferIcons/CraftCurrency";
            return (string)val_23;
            label_9:
            val_24 = null;
            val_24 = null;
            val_26 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            goto label_21;
            label_2:
            if(this.丂丁丏一丙丛业且丌() > 5000)
            {
                goto label_22;
            }
            
            if(this.丂丁丏一丙丛业且丌() > 2000)
            {
                goto label_23;
            }
            
            var val_10 = (this.丂丁丏一丙丛业且丌() >= 1001) ? 5 : (0 + 1);
            goto label_37;
            label_8:
            val_28 = null;
            val_28 = null;
            val_26 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            label_21:
            val_20 = this.丂丁丏一丙丛业且丌();
            val_22 = 0;
            return BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_21, 世与丂且丘丐万丗丞:  0);
            label_15:
            if(this.丂丁丏一丙丛业且丌() <= 180)
            {
                goto label_29;
            }
            
            val_29 = System.Int32 PGCompany.丗丟丄丈东丝丕丄世::丂丁丏一丙丛业且丌();
            if(this.丂丁丏一丙丛业且丌() < 181)
            {
                goto label_30;
            }
            
            val_29 = System.Int32 PGCompany.丗丟丄丈东丝丕丄世::丂丁丏一丙丛业且丌();
            if(this.丂丁丏一丙丛业且丌() <= 330)
            {
                goto label_31;
            }
            
            label_30:
            if(this.丂丁丏一丙丛业且丌() >= 331)
            {
                    if(this.丂丁丏一丙丛业且丌() <= 660)
            {
                goto label_33;
            }
            
            }
            
            val_23 = "OfferIcons/pixelpasscurrency_4";
            return (string)val_23;
            label_11:
            val_23 = "Textures/Bank/Event/Event_Currency_1";
            return (string)val_23;
            label_22:
            val_27 = 20;
            goto label_37;
            label_29:
            val_23 = "OfferIcons/pixelpasscurrency_1";
            return (string)val_23;
            label_23:
            val_27 = 10;
            label_37:
            string val_19 = System.String.Format(format:  "OfferIcons/bp_currency_{0}", arg0:  10);
            return (string)val_23;
            label_13:
            val_23 = "Textures/Bank/Event/Event_Currency_2";
            return (string)val_23;
            label_31:
            val_23 = "OfferIcons/pixelpasscurrency_2";
            return (string)val_23;
            label_33:
            val_23 = "OfferIcons/pixelpasscurrency_3";
            return (string)val_23;
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            string val_7;
            var val_8;
            var val_9;
            Rilisoft.OfferItemType val_1 = this.不业丙丒丂丞下丆丙();
            if(val_1 <= 1050)
            {
                goto label_1;
            }
            
            if(val_1 == 1110)
            {
                goto label_2;
            }
            
            if(val_1 == 1140)
            {
                goto label_3;
            }
            
            if(val_1 != 1190)
            {
                goto label_8;
            }
            
            val_7 = "OfferMiniIcons/coupon";
            goto label_14;
            label_1:
            if(val_1 == 1000)
            {
                goto label_6;
            }
            
            if(val_1 == 1010)
            {
                goto label_7;
            }
            
            if(val_1 != 1050)
            {
                goto label_8;
            }
            
            val_7 = "OfferMiniIcons/event_currency";
            goto label_14;
            label_8:
            val_8 = "OfferMiniIcons/"("OfferMiniIcons/") + this.业上丙丞丐丄丆丅七().ToLower();
            goto label_11;
            label_2:
            val_7 = "OfferMiniIcons/bp_currency";
            goto label_14;
            label_3:
            val_7 = "OfferMiniIcons/craft_currency";
            goto label_14;
            label_6:
            val_7 = "OfferMiniIcons/gems";
            goto label_14;
            label_7:
            val_7 = "OfferMiniIcons/coins";
            label_14:
            label_11:
            val_9 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == true)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_7);
            }
            
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_7);
        }
        internal override bool 丛七丈丄不丟下丑丈()
        {
            return true;
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            var val_30;
            string val_31;
            var val_32;
            if(this.不业丙丒丂丞下丆丙() == 1000)
            {
                goto label_1;
            }
            
            val_30 = null;
            val_30 = null;
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_4;
            }
            
            label_1:
            val_31 = "Key_0951";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31 = "Key_5772");
            label_4:
            if(this.不业丙丒丂丞下丆丙() == 1010)
            {
                goto label_8;
            }
            
            val_32 = null;
            val_32 = null;
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_11;
            }
            
            label_8:
            val_31 = "Key_0950";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            label_11:
            if(this.不业丙丒丂丞下丆丙() != 1110)
            {
                    if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "BattlePassCurrency")) == false)
            {
                goto label_16;
            }
            
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            label_16:
            if(this.不业丙丒丂丞下丆丙() != 1050)
            {
                    if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "EventCurrency")) == false)
            {
                goto label_20;
            }
            
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_14 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_14 == null)
            {
                    return this.丐丞丐丝下上上丐丂();
            }
            
            string val_15 = val_14.丟万丏且上业丐丈一();
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            label_20:
            if(this.不业丙丒丂丞下丆丙() == 1220)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "ClanShields")) != false)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == 7015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "ClanSilver")) != false)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == 12015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == 12015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == 14015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == 601015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == (601015 + 1000))
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() == (601015 + 2000))
            {
                    return "Key_12339";
            }
            
            if(this.业东丅东丌上丗丑不() == 26015)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
            }
            
            if(this.业东丅东丌上丗丑不() != 25015)
            {
                    return this.丐丞丐丝下上上丐丂();
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丌丑丕丙丅丈丈丘丄(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
