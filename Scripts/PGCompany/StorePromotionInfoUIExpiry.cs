using UnityEngine;

namespace PGCompany
{
    internal sealed class StorePromotionInfoUIExpiry : StorePromotionInfoUI
    {
        // Fields
        private UILabel _timeLabel;
        private UILabel _coefLable;
        
        // Methods
        protected override void 丝一丅丆三东丂丞七()
        {
            this.丝一丅丆三东丂丞七();
            if(X8 == 0)
            {
                    return;
            }
            
            this.万与万与丟丘一丈丟();
        }
        private void 万与万与丟丘一丈丟()
        {
            UILabel val_18;
            var val_19;
            var val_20;
            var val_21;
            val_18 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._coefLable, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLabel, 丏业丟一东丂东丘丛:  false);
            float val_1 = this._coefLable.alpha;
            PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this._coefLable);
            if(val_2 == null)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            if((PGCompany.ClanStoreBuffsController.三丝专丗丑业丏七与.Equals(value:  val_2.业上丙丞丐丄丆丅七())) == false)
            {
                goto label_8;
            }
            
            val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.上丙业丕丟与七专丁 val_7 = val_20.一丌世丑丄东丞丘三<PGCompany.上丙业丕丟与七专丁>(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  val_2.业上丙丞丐丄丆丅七());
            if(val_7 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._coefLable, 丏业丟一东丂东丘丛:  true);
            System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与> val_8 = val_7.世丙万丞上与一丌丅();
            val_21 = null;
            val_21 = null;
            if((StorePromotionInfoUIExpiry.<>c.<>9__3_0) == null)
            {
                goto label_15;
            }
            
            label_29:
            val_18 = this._coefLable;
            val_20 = val_8.Find(match:  StorePromotionInfoUIExpiry.<>c.<>9__3_0);
            float val_18 = 100f;
            val_18 = (float)val_20.世三丞丅丑丌丈丈一() / val_18;
            val_18 = val_18 + 1f;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8795"), arg0:  val_18));
            return;
            label_8:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLabel, 丏业丟一东丂东丘丛:  (val_2.丙丑丁专一专世万丕() > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._timeLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_2.丙丑丁专一专世万丕(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            return;
            label_15:
            StorePromotionInfoUIExpiry.<>c.<>9__3_0 = new System.Predicate<PGCompany.三丏不丆丈且丐东与>(object:  StorePromotionInfoUIExpiry.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIExpiry.<>c::丁万丗丛上丄丕丅七(PGCompany.三丏不丆丈且丐东与 七丏丄丅丌业与且丙));
            if(val_8 != null)
            {
                goto label_29;
            }
            
            goto label_29;
        }
        public StorePromotionInfoUIExpiry()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
