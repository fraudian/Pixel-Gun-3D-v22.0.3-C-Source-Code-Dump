using UnityEngine;

namespace PGCompany
{
    internal sealed class StorePromotionOffersView : StorePromotionView
    {
        // Fields
        private UnityEngine.GameObject _newItemContainer;
        private UnityEngine.GameObject _moduleBG;
        private UnityEngine.GameObject _fortBG;
        private UnityEngine.GameObject _tankBG;
        private System.Collections.Generic.List<UISprite> _newItemRarity;
        private UILabel _newLevelUpLabel;
        private UnityEngine.GameObject _progressBarContainer;
        private UnityEngine.GameObject _enoughToUpgradeDecor;
        private UILabel _enoughToUpgradeLabel;
        private UISprite _progressCurrent;
        private UISprite _progressAddition;
        private UILabel _levelLabel;
        private UnityEngine.GameObject _moduleIcon;
        private UnityEngine.GameObject _gearIcon;
        private UILabel _progressAmountLabel;
        
        // Methods
        internal override bool 丝一丅丆三东丂丞七()
        {
            UILabel val_49;
            object val_50;
            var val_51;
            PGCompany.丗丟丄丈东丝丕丄世 val_52;
            bool val_53;
            PGCompany.丗丟丄丈东丝丕丄世 val_54;
            PGCompany.丗丟丄丈东丝丕丄世 val_55;
            PGCompany.丗丟丄丈东丝丕丄世 val_56;
            PGCompany.丗丟丄丈东丝丕丄世 val_57;
            string val_58;
            int val_59;
            var val_60;
            var val_61;
            object val_62;
            object val_63;
            var val_64;
            var val_65;
            var val_66;
            string val_67;
            val_49 = this;
            StorePromotionOffersView.丕丛业丁丏下一七丘 val_1 = null;
            val_50 = val_1;
            val_1 = new StorePromotionOffersView.丕丛业丁丏下一七丘();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleBG, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._fortBG, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tankBG, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newItemContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressBarContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughToUpgradeDecor, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleIcon, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gearIcon, 丏业丟一东丂东丘丛:  false);
            val_51 = 0;
            if(this.丝一丅丆三东丂丞七() == false)
            {
                    return (bool)val_51;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌());
            val_52 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            if(val_50 != null)
            {
                    val_53 = val_50;
                .丄不丒业不一丗丅丙 = val_52;
            }
            else
            {
                    val_53 = true;
                mem[16] = val_52;
                val_52 = mem[16];
            }
            
            val_51 = 0;
            if(val_4 == null)
            {
                    return (bool)val_51;
            }
            
            if(val_52 == 0)
            {
                    return (bool)val_51;
            }
            
            string val_7 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8970");
            string val_8 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8802");
            bool val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_53.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_54 = mem[16];
            if((PGCompany.万丞丘与丕丞下万丌.丏丟下丐丝丙三且东(丁丅丈丌丟世丗丗丟:  mem[16].不业丙丒丂丞下丆丙())) == false)
            {
                goto label_18;
            }
            
            if(val_54 != 0)
            {
                    if(val_54 == null)
            {
                goto label_20;
            }
            
            }
            
            if(val_50 == null)
            {
                    val_55 = mem[16];
            }
            
            if(val_55 == 0)
            {
                goto label_22;
            }
            
            if(val_55 == null)
            {
                goto label_25;
            }
            
            val_55 = 0;
            goto label_25;
            label_18:
            if((PGCompany.万丞丘与丕丞下万丌.七下丑不丙丆上上丗(丁丅丈丌丟世丗丗丟:  val_54.不业丙丒丂丞下丆丙())) == false)
            {
                goto label_29;
            }
            
            val_56 = mem[16];
            if(val_56 != 0)
            {
                    if(val_56 == null)
            {
                goto label_32;
            }
            
            }
            
            if(val_50 == null)
            {
                    val_57 = mem[16];
            }
            
            if(val_57 == 0)
            {
                goto label_34;
            }
            
            if(val_57 == null)
            {
                goto label_37;
            }
            
            val_57 = 0;
            goto label_37;
            label_29:
            val_58 = val_7;
            val_59 = 0;
            val_60 = 0;
            goto label_38;
            label_22:
            label_25:
            val_61 = val_55.丑且一丐东三不丈丝();
            label_20:
            if(val_61 == null)
            {
                goto label_43;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleBG, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleIcon, 丏业丟一东丂东丘丛:  true);
            val_59 = val_61.丟丝业世丞三世丛丑(丛丛丆丛丏丟业万上:  val_4.丂丁丏一丙丛业且丌());
            val_58 = System.String.Format(format:  val_7, arg0:  val_59);
            val_62 = val_61.且丆丟业丞丕丑上且();
            val_63 = val_61.丏丈丁专专丘丒丂丂();
            val_64 = val_61;
            int val_22 = val_64.丁丕丁三丁丗不三丟();
            goto label_42;
            label_34:
            label_37:
            val_65 = val_57.丝丝丌丟丆丂丂丞业();
            label_32:
            if(val_65 == null)
            {
                goto label_43;
            }
            
            PlaceableItemSettings val_24 = val_65.丈丏专三世七丒丘丑();
            val_66 = null;
            val_66 = null;
            string val_47 = PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄;
            val_47 = System.String.op_Equality(a:  val_24.supercategory, b:  val_47);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._fortBG, 丏业丟一东丂东丘丛:  val_47);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gearIcon, 丏业丟一东丂东丘丛:  true);
            PlaceableItemSettings val_26 = val_65.丈丏专三世七丒丘丑();
            string val_48 = PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛;
            val_48 = System.String.op_Equality(a:  val_26.supercategory, b:  val_48);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tankBG, 丏业丟一东丂东丘丛:  val_48);
            val_59 = val_65.丟丝业世丞三世丛丑(丛丛丆丛丏丟业万上:  val_4.丂丁丏一丙丛业且丌());
            val_58 = System.String.Format(format:  val_7, arg0:  val_59);
            val_62 = val_65.且丆丟业丞丕丑上且();
            val_63 = val_65.丏丈丁专专丘丒丂丂();
            val_64 = val_65;
            label_42:
            val_60 = val_64.丁丕丁三丁丗不三丟();
            goto label_50;
            label_43:
            val_58 = val_7;
            val_59 = 0;
            label_38:
            val_63 = 0;
            val_62 = 0;
            label_50:
            val_53 = val_11 ^ 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newItemContainer, 丏业丟一东丂东丘丛:  val_53);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressBarContainer, 丏业丟一东丂东丘丛:  val_11);
            System.Action<UISprite> val_36 = null;
            val_53 = val_36;
            val_36 = new System.Action<UISprite>(object:  val_1, method:  System.Void StorePromotionOffersView.丕丛业丁丏下一七丘::七丅丐丏丝七丄丏丛(UISprite 与丄丈丘丟丕丏丐丁));
            this._newItemRarity.ForEach(action:  val_36);
            if(val_11 == false)
            {
                goto label_54;
            }
            
            int val_38 = val_4.丂丁丏一丙丛业且丌() + val_62;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughToUpgradeDecor, 丏业丟一东丂东丘丛:  (val_38 >= val_63) ? 1 : 0);
            PGCompany.丏丂一丗丙世丏丐三 val_40 = val_59 - val_61;
            if(val_38 <= val_63)
            {
                goto label_57;
            }
            
            val_67 = val_8;
            if(val_40 < 2)
            {
                goto label_59;
            }
            
            val_67 = System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9001"), arg0:  val_40);
            goto label_59;
            label_54:
            val_49 = this._newLevelUpLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_49, 丕丗丘丑丛与丑业丒:  val_58);
            goto label_62;
            label_57:
            val_67 = val_8;
            label_59:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._enoughToUpgradeLabel, 丕丗丘丑丛与丑业丒:  val_67);
            val_53 = 1152921504622075904;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressAmountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_62, arg1:  val_63));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  val_61 + 1);
            val_50 = this._progressCurrent;
            float val_49 = 0f;
            val_49 = val_49 / 0f;
            val_50.fillAmount = val_49;
            val_49 = this._progressAddition;
            float val_50 = (float)val_4.丂丁丏一丙丛业且丌() + val_62;
            val_50 = val_50 / 0f;
            val_49.fillAmount = val_50;
            label_62:
            val_51 = 1;
            return (bool)val_51;
        }
        public StorePromotionOffersView()
        {
            this._newItemRarity = new System.Collections.Generic.List<UISprite>();
            this = new PromotionViewAbstract();
        }
    
    }

}
