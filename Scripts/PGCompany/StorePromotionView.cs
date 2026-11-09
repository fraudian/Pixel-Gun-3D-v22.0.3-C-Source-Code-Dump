using UnityEngine;

namespace PGCompany
{
    internal class StorePromotionView : PromotionViewAbstract
    {
        // Fields
        private System.Action<PGCompany.东丑丆丗丏丐丟下丄, object> 丂东丟下丒与丛专上;
        protected UILabel _titleLabel;
        protected UILabel _descriptionLabel;
        private UIBasicSprite _mainTexture;
        protected UILabel _countLabel;
        protected PGCompany.InventoryItemView _priceUI;
        protected PGCompany.InventoryItemView _itemView;
        protected UnityEngine.GameObject _infoButtonContainer;
        protected UnityEngine.GameObject _saleContainer;
        protected UILabel _saleLabel;
        protected UnityEngine.GameObject _detailsContainer;
        protected UILabel _detailsCountLabel;
        protected UILabel _detailsDescriptionLabel;
        protected UISprite _detailsSprite;
        protected UnityEngine.GameObject _enoughToCraft;
        internal UnityEngine.GameObject clanRankValue;
        internal UILabel clanRankExpLabel;
        private UILabel _timeLabel;
        private UILabel _coefLable;
        private PGCompany.TimerUI _timerUi;
        private static System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, string> 丐丂丝丛丅丈上丂一;
        
        // Methods
        internal void 业丝丝专丂三世丅不(System.Action<PGCompany.东丑丆丗丏丐丟下丄, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丂东丟下丒与丛专上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂东丟下丒与丛专上 != 1152921556001906048);
        
        }
        internal void 丗一丞丌与东与三且(System.Action<PGCompany.东丑丆丗丏丐丟下丄, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丂东丟下丒与丛专上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂东丟下丒与丛专上 != 1152921556002042624);
        
        }
        public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
            goto typeof(PGCompany.StorePromotionView).__il2cppRuntimeField_198;
        }
        internal override bool 丝一丅丆三东丂丞七()
        {
            UILabel val_53;
            PGCompany.TimerUI val_54;
            var val_55;
            var val_56;
            PGCompany.七东万三万丒丏一丁 val_57;
            var val_58;
            val_53 = this;
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                goto label_1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanRankValue, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  this.与丞丆丑东东丟丆丌());
            var val_6 = ((丞东丑专丛丆丄丝世.丁七丒丞下丟一丅丅(丁丅丈丌丟世丗丗丟:  this.与丞丆丑东东丟丆丌().丟丄丐丙万丛丂丆三())) != true) ? (2 + 1) : 2;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._descriptionLabel, 丕丗丘丑丛与丑业丒:  this.与丞丆丑东东丟丆丌());
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._mainTexture, 与万丆丛丒万丝丙丑:  this.与丞丆丑东东丟丆丌());
            if(this._priceUI != 0)
            {
                    this._priceUI.Setup(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌());
            }
            
            if(this._itemView != 0)
            {
                    this._itemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌()));
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countLabel, 丕丗丘丑丛与丑业丒:  this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌());
            this.丆丄上丒丏上不丈丙();
            this.万与万与丟丘一丈丟();
            string val_52 = "";
            val_52 = System.String.op_Inequality(a:  this.与丞丆丑东东丟丆丌().丐万丐丌丌丆丒丐丝(), b:  val_52);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._infoButtonContainer, 丏业丟一东丂东丘丛:  val_52);
            PGCompany.丗丟丄丈东丝丕丄世 val_20 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleContainer, 丏业丟一东丂东丘丛:  (this.与丞丆丑东东丟丆丌().丆丞上丛丂一业丟丕() > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._saleLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2555"), arg0:  this.与丞丆丑东东丟丆丌().丆丞上丛丂一业丟丕()));
            if(this._timerUi != 0)
            {
                    val_54 = this._timerUi;
                val_55 = PixelTime.丙丅丅业丟丁世丁丗();
                val_54.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.与丞丆丑东东丟丆丌().下丒丗丄丌丘不丑丘() - val_55, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            if(val_20 == null)
            {
                goto label_63;
            }
            
            if(null == null)
            {
                goto label_35;
            }
            
            val_54 = 0;
            goto label_36;
            label_1:
            val_56 = 0;
            return (bool)val_56;
            label_35:
            if(this.与丞丆丑东东丟丆丌().不业丙丒丂丞下丆丙() == 3)
            {
                    val_57 = 0;
                int val_35 = 丌丅且丗七丘丅丛丑.丞丛丈丐丂丞丅上东();
            }
            else
            {
                    val_57 = val_20;
            }
            
            val_54 = 丌丅且丗七丘丅丛丑.七丛一且丝丆上丅丑(专业丗丛不丕七丐东:  val_57);
            label_36:
            if(null != null)
            {
                goto label_57;
            }
            
            val_54 = 丌丅且丗七丘丅丛丑.丌万东专业丏丞上丝(下丅丙一丂丗丅丝七:  val_20);
            if(val_20.不业丙丒丂丞下丆丙() != 1240)
            {
                goto label_57;
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_42 = this.与丞丆丑东东丟丆丌();
            if((this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七().Equals(value:  "Real", comparisonType:  5)) == false)
            {
                goto label_54;
            }
            
            val_58 = val_42;
            int val_43 = val_58.丂丁丏一丙丛业且丌();
            goto label_55;
            label_54:
            if((val_42.业上丙丞丐丄丆丅七().Equals(value:  "GemsCurrency", comparisonType:  5)) == false)
            {
                goto label_57;
            }
            
            var val_53 = 0;
            val_53 = val_53 + this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌();
            val_53 = (val_53 >> 4) + (val_53 >> 31);
            val_58 = 0;
            int val_49 = UnityEngine.Mathf.RoundToInt(f:  (float)val_53);
            label_55:
            val_53 = val_49 + (val_49 << 2);
            val_55 = val_53 << 2;
            goto label_62;
            label_57:
            val_55 = 0;
            label_62:
            if(val_54 >= 1)
            {
                    val_56 = 1;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanRankValue, 丏业丟一东丂东丘丛:  true);
                val_53 = this.clanRankExpLabel;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_53, 丕丗丘丑丛与丑业丒:  val_54 + val_55.ToString());
                return (bool)val_56;
            }
            
            label_63:
            val_56 = 1;
            return (bool)val_56;
        }
        internal override void 丐丌丘不上且东业丘()
        {
        
        }
        internal override void 丌丆丌且丘丝丝丑丄()
        {
        
        }
        internal override void 世世丑丞丒丟业丁与()
        {
        
        }
        private void 万与万与丟丘一丈丟()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._coefLable, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLabel, 丏业丟一东丂东丘丛:  false);
            PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌());
            if(val_2 == null)
            {
                    return;
            }
            
            if((PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_2)) == null)
            {
                    return;
            }
        
        }
        private void 丆丄上丒丏上不丈丙()
        {
            UILabel val_26;
            var val_27;
            var val_28;
            val_26 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._detailsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._detailsDescriptionLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughToCraft, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._descriptionLabel, 丏业丟一东丂东丘丛:  false);
            PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌());
            if(val_2 == null)
            {
                    return;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_2);
            if((PGCompany.万丞丘与丕丞下万丌.丏丟下丐丝丙三且东(丁丅丈丌丟世丗丗丟:  val_2.不业丙丒丂丞下丆丙())) == false)
            {
                goto label_9;
            }
            
            label_43:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._detailsContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._detailsCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4726"), arg0:  val_2.丂丁丏一丙丛业且丌()));
            this.丗东丘丝万丆三万丌(下丅丙一丂丗丅丝七:  val_3);
            label_47:
            if(this._detailsContainer != 0)
            {
                    if(this._detailsContainer.activeSelf == true)
            {
                    return;
            }
            
            }
            
            val_26 = this._descriptionLabel;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_26, 丏业丟一东丂东丘丛:  true);
            return;
            label_9:
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丞世不丒下上上丝丑:  val_2.业东丅东丌上丗丑不())) == false)
            {
                goto label_22;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughToCraft, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._detailsContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._detailsCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4726"), arg0:  val_2.丂丁丏一丙丛业且丌()));
            this.丗东丘丝万丆三万丌(下丅丙一丂丗丅丝七:  val_3);
            PGCompany.丗丟丄丈东丝丕丄世 val_18 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(上七下丘一下三世丏:  val_2);
            if(val_18 == null)
            {
                goto label_28;
            }
            
            if(val_2.不业丙丒丂丞下丆丙() != 10)
            {
                goto label_47;
            }
            
            val_27 = null;
            val_27 = null;
            if(null != null)
            {
                goto label_48;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._detailsDescriptionLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[val_18]));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._detailsDescriptionLabel, 丏业丟一东丂东丘丛:  true);
            goto label_47;
            label_22:
            if(((PGCompany.万丞丘与丕丞下万丌.七下丑不丙丆上上丗(丁丅丈丌丟世丗丗丟:  val_2.不业丙丒丂丞下丆丙())) == true) || (val_2.不业丙丒丂丞下丆丙() == 1300))
            {
                goto label_43;
            }
            
            goto label_47;
            label_28:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "\'{0}\' is not {1}", arg0:  val_2, arg1:  "craftableItem"));
            goto label_47;
            label_48:
            val_28 = X0;
        }
        private void 丗东丘丝万丆三万丌(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if(this._detailsSprite == 0)
            {
                    return;
            }
            
            UnityEngine.Color val_2 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  下丅丙一丂丗丅丝七);
            this._detailsSprite.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        private void 丘下丟丁上丏丛且且()
        {
        
        }
        public virtual void U_Purchase()
        {
            goto typeof(PGCompany.StorePromotionView).__il2cppRuntimeField_188;
        }
        public override void TryPurchase()
        {
            var val_26;
            PGCompany.三东丏不丗世丅丌丄 val_27;
            var val_28;
            var val_29;
            string val_30;
            var val_31;
            string val_32;
            var val_33;
            var val_34;
            var val_35;
            val_26 = this;
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                    return;
            }
            
            val_27 = this.与丞丆丑东东丟丆丌().且丏三丞丝丟丘丅丕();
            PGCompany.东丑丆丗丏丐丟下丄 val_4 = this.与丞丆丑东东丟丆丌();
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_27 == false)
            {
                goto label_4;
            }
            
            label_5:
            val_4.丈丙且一万丟丕万下();
            return;
            label_3:
            if(val_27 == true)
            {
                goto label_5;
            }
            
            label_4:
            if(((val_4 == null) || (this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() == 10015)) || (this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() == 11015))
            {
                goto label_12;
            }
            
            val_27 = this.与丞丆丑东东丟丆丌();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_27, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_15;
            }
            
            label_12:
            val_26 = this.与丞丆丑东东丟丆丌();
            val_26.丏丝丘七丕与世丅丆();
            return;
            label_15:
            if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false)
            {
                    BankController.丑七不且上丗丁一世().丈丄丁与丝丌丛与世(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌());
            }
            else
            {
                    StorePromotionView.丂丄丕业东丆丄三三 val_17 = new StorePromotionView.丂丄丕业东丆丄三三();
                val_28 = null;
                if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() != false)
            {
                    val_29 = null;
                val_30 = 1152921505690874512;
            }
            else
            {
                    val_31 = null;
                val_30 = 1152921505690874520;
            }
            
                if(val_17 != null)
            {
                    val_33 = val_17;
                .世丁丙世丄一万丆三 = val_30;
            }
            else
            {
                    val_33 = val_17;
                .世丁丙世丄一万丆三 = val_30;
                val_32 = .世丁丙世丄一万丆三;
            }
            
                val_34 = null;
                val_34 = null;
                BankView.丗一专业丘丙丟丄万 = val_32;
                val_35 = null;
                val_35 = null;
                BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
                BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_17, method:  System.Void StorePromotionView.丂丄丕业东丆丄三三::丟丁丙万专丅专丝丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七(), 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  .世丁丙世丄一万丆三);
            }
            
            ButtonClickSound.丁业上丏不丕三丗不();
        }
        public void U_ClickOnInfo()
        {
            if(this.丂东丟下丒与丛专上 == null)
            {
                    return;
            }
            
            this.丂东丟下丒与丛专上.Invoke(arg1:  this.与丞丆丑东东丟丆丌(), arg2:  0);
        }
        public void U_ClickOnMultiInfo()
        {
            if(this.丂东丟下丒与丛专上 == null)
            {
                    return;
            }
            
            this.丂东丟下丒与丛专上.Invoke(arg1:  this.与丞丆丑东东丟丆丌(), arg2:  true);
        }
        public StorePromotionView()
        {
        
        }
        private static StorePromotionView()
        {
            System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.String> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, System.String>();
            val_1.Add(key:  20, value:  "");
            PGCompany.StorePromotionView.丐丂丝丛丅丈上丂一 = val_1;
        }
    
    }

}
