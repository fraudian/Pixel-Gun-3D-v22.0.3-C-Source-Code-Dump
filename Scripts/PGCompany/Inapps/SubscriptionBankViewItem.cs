using UnityEngine;

namespace PGCompany.Inapps
{
    internal class SubscriptionBankViewItem : AbstractBankViewItem
    {
        // Fields
        private UIBasicSprite _mainTexture;
        private UIBasicSprite _singleRewardTexture;
        private UnityEngine.GameObject _singleRewardContainer;
        private UISprite _repeatableRewardSprite;
        private System.Collections.Generic.List<UILabel> _repeatableRewardLabels;
        private UISprite _repeatableRewardTotalSprite;
        private System.Collections.Generic.List<UILabel> _repeatableRewardTotalLabels;
        private UnityEngine.GameObject _trialContainer;
        private System.Collections.Generic.List<UILabel> _trialLabels;
        private UnityEngine.GameObject _buyContainer;
        private System.Collections.Generic.List<UILabel> _buyLabels;
        private UnityEngine.GameObject _timerContainer;
        private System.Collections.Generic.List<UILabel> _timerLabels;
        private UnityEngine.GameObject _pickupContainer;
        private UnityEngine.GameObject _giveObject;
        private Rilisoft.Offers.业与丁丒业七丘丙丁 丕丗丛丅丆丏业丕丅;
        private PGCompany.丈万丟丟丗丞专专与 世丘丛万丙与丒业丌;
        private long 与三一丁三不丌丛丞;
        private float 业丗世上万东丁丁丈;
        private bool 东专丙七与丕丑丆丕;
        
        // Methods
        public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
        {
            var val_2;
            this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丛与世且丑丅丟下丛);
            val_2 = 0;
            this.丕丗丛丅丆丏业丕丅 = ;
            this.不与丞下业丑丒丙万();
            this.下丌业业丐丘丐丘三();
            this.丝一丅丆三东丂丞七();
        }
        protected override void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
            this.不与丞下业丑丒丙万();
            this.下丌业业丐丘丐丘三();
        }
        protected override void OnDisable()
        {
            this.不与丞下业丑丒丙万();
        }
        protected override void OnDestroy()
        {
            this.不与丞下业丑丒丙万();
            this.OnDestroy();
        }
        protected override void Update()
        {
            this.Update();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  (~东下丗世丘上丞世丛.丆不丁万丌丕丟与下()) & 1);
        }
        protected override void 丞业与下丛万丁下丙()
        {
        
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_7;
            var val_27;
            UnityEngine.GameObject val_28;
            UISprite val_29;
            if(this.Offer == null)
            {
                    return;
            }
            
            if(this.丕丗丛丅丆丏业丕丅 == null)
            {
                    return;
            }
            
            Rilisoft.OfferItem val_2 = this.丕丗丛丅丆丏业丕丅.丕丏丂一与万丟专丙(丁丅丈丌丟世丗丗丟:  2);
            Rilisoft.OfferItem val_3 = this.丕丗丛丅丆丏业丕丅.丕丏丂一与万丟专丙(丁丅丈丌丟世丗丗丟:  1);
            if((true == 0) || ((System.Linq.Enumerable.Any<UILabel>(source:  true)) == false))
            {
                goto label_16;
            }
            
            List.Enumerator<T> val_5 = X22.GetEnumerator();
            label_11:
            if(((-785466880) & 1) == 0)
            {
                goto label_7;
            }
            
            val_7.丐丏七丌丕丗业且上().text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8018");
            goto label_11;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            label_16:
            if(this._singleRewardContainer != 0)
            {
                    if(val_3 != null)
            {
                    if(this._singleRewardTexture != 0)
            {
                    UnityEngine.Texture val_12 = val_3.Texture;
            }
            
                val_27 = 1;
                val_28 = this._singleRewardContainer;
            }
            else
            {
                    val_28 = this._singleRewardContainer;
                val_27 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28, 丏业丟一东丂东丘丛:  false);
            }
            
            bool val_13 = UnityEngine.Object.op_Inequality(x:  this._repeatableRewardSprite, y:  0);
            if((val_2 != null) && (val_13 != false))
            {
                    this._repeatableRewardSprite.spriteName = val_13.东东丐丕东丒丝丗丆(丗七丟丈三不丕一三:  val_2);
            }
            
            if((val_2 != null) && (this._repeatableRewardLabels != null))
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._repeatableRewardLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8025"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.Count)));
            }
            
            val_29 = this._repeatableRewardTotalSprite;
            bool val_19 = UnityEngine.Object.op_Inequality(x:  val_29, y:  0);
            if((val_2 != null) && (val_19 != false))
            {
                    val_29 = this._repeatableRewardTotalSprite;
                val_29.spriteName = val_19.东东丐丕东丒丝丗丆(丗七丟丈三不丕一三:  val_2);
            }
            
            if(this._repeatableRewardTotalLabels != null)
            {
                    val_29 = this._repeatableRewardTotalLabels;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_29, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8027"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丕丗丛丅丆丏业丕丅.丒丂丘丈世丝丅丑上())));
            }
            
            PGCompany.丈万丟丟丗丞专专与 val_25 = PGCompany.丘丒丑万专一业丒专.丗丝丌丄丂丗丅世与(丙业丞丑七丗下丟丌:  this.丕丗丛丅丆丏业丕丅);
            this.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  val_25);
            this.世丘丛万丙与丒业丌 = val_25;
        }
        private string 东东丐丕东丒丝丗丆(Rilisoft.OfferItem 丗七丟丈三不丕一三)
        {
            string val_4;
            var val_5;
            val_4 = 丗七丟丈三不丕一三;
            if(val_4 == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_4 = val_4.Id;
            val_5 = null;
            val_5 = null;
            var val_3 = ((System.String.op_Equality(a:  val_4, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? "gem_znachek" : "coin_znachek";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new SubscriptionBankViewItem.三丛丏业丕万上七丞();
        }
        private void 丄丑七丘丁且丞丙专(PGCompany.丈万丟丟丗丞专专与 丏业丟一东丂东丘丛)
        {
            if((丏业丟一东丂东丘丛 - 1) <= 3)
            {
                    var val_4 = 106039372 + ((丏业丟一东丂东丘丛 - 1)) << 2;
                val_4 = val_4 + 106039372;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  System.String.Format(format:  "usupported {0}: \'{1}\'", arg0:  "state", arg1:  丏业丟一东丂东丘丛));
            }
        
        }
        private void 丂丐丂丐丛丈专丛不()
        {
            string val_9;
            var val_10;
            System.TimeSpan val_11;
            var val_13;
            val_9 = this;
            if(this.丕丗丛丅丆丏业丕丅 == null)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            val_11 = System.TimeSpan.Zero;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                goto label_6;
            }
            
            System.Nullable<System.TimeSpan> val_2 = this.丕丗丛丅丆丏业丕丅.丏丈丑丐上三丙不丟(丝丙一丝丈丂不丙一:  new System.Nullable<System.Int64>() {HasValue = false});
            if(((-784764672) & 1) == 0)
            {
                goto label_12;
            }
            
            goto label_9;
            label_6:
            if(this.业丗世上万东丁丁丈 <= 0f)
            {
                goto label_12;
            }
            
            float val_3 = UnityEngine.Time.realtimeSinceStartup;
            val_3 = val_3 - this.业丗世上万东丁丁丈;
            long val_4 = this.与三一丁三不丌丛丞 + (long)val_3;
            System.Nullable<System.TimeSpan> val_5 = this.丕丗丛丅丆丏业丕丅.丏丈丑丐上三丙不丟(丝丙一丝丈丂不丙一:  new System.Nullable<System.Int64>() {HasValue = false});
            if(((-784764688) & 1) == 0)
            {
                goto label_12;
            }
            
            if(val_5.HasValue.TotalSeconds < 0)
            {
                    val_13 = null;
                val_13 = null;
            }
            
            label_9:
            val_11;
            label_12:
            if(this.丕丗丛丅丆丏业丕丅.丕与东不丈丄丞万丁() == true)
            {
                    return;
            }
            
            val_9 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_11}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._timerLabels, 丕丗丘丑丛与丑业丒:  val_9);
        }
        private void 丕丁专上丐东丐丗丒()
        {
            var val_11;
            var val_12;
            if(static_value_082C8000 == 0)
            {
                    return;
            }
            
            if(this.东专丙七与丕丑丆丕 == true)
            {
                    return;
            }
            
            UIPanel val_2 = this.不丘丁专丙丈万丌丑();
            if(val_2 == 0)
            {
                    return;
            }
            
            val_11 = mem[X21 + 24];
            val_11 = X21 + 24;
            if(val_11 == 0)
            {
                    val_11 = mem[X21 + 24];
                val_11 = X21 + 24;
            }
            
            if(val_11 <= 1)
            {
                    val_11 = mem[X21 + 24];
                val_11 = X21 + 24;
            }
            
            if(val_11 <= 2)
            {
                    val_11 = mem[X21 + 24];
                val_11 = X21 + 24;
            }
            
            if((val_2.IsVisible(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = X21 + 32, y = X21 + 36, z = X21 + 40}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = X21 + 44, y = X21 + 48, z = X21 + 48 + 4}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = X21 + 56, y = X21 + 64, z = X21 + 68}, 丐丆丂丒丁万丈丛丅:  new UnityEngine.Vector3() {x = X21 + 76, y = X21 + 44, z = X21 + 36})) == false)
            {
                    return;
            }
            
            this.东专丙七与丕丑丆丕 = val_2.isVisible;
            if(Rilisoft.Offers.东丝万业丘丙丄丁与.上丈丘丙丞三丟丝丞() != false)
            {
                    return;
            }
            
            val_12 = 1152921505132990464;
            if(东下丗世丘上丞世丛.丆不丁万丌丕丟与下() != false)
            {
                    val_12 = 东下丗世丘上丞世丛.丑七不且上丗丁一世();
                if(val_12.丌一不不丕丟丞丛丝() == false)
            {
                    return;
            }
            
            }
            
            Rilisoft.Offers.东丝万业丘丙丄丁与.丆丁丆丕专不七丅丅(丙业与丙丗丝不丈东:  true);
        }
        public void U_BuyTrial()
        {
            System.EventHandler val_1 = this.万丗万丆丐三丐丝东();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(sender:  this, e:  0);
        }
        public void U_PickUp()
        {
            System.EventHandler val_1 = this.万丗万丆丐三丐丝东();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(sender:  this, e:  0);
        }
        private void 下丌业业丐丘丐丘三()
        {
            if(this.丕丗丛丅丆丏业丕丅 != null)
            {
                    this.丕丗丛丅丆丏业丕丅.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Inapps.SubscriptionBankViewItem::丝一丅丆三东丂丞七()));
            }
            
            东下丗世丘上丞世丛.万东丏丑丘丙丕上丄(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.Inapps.SubscriptionBankViewItem::丆丘不东东万下丙丁(string 万且万且丑丗且丌丆)));
        }
        private void 丆丘不东东万下丙丁(string 万且万且丑丗且丌丆)
        {
            this.丝一丅丆三东丂丞七();
        }
        private void 不与丞下业丑丒丙万()
        {
            东下丗世丘上丞世丛.专不丙不丙丟丑丂丛(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.Inapps.SubscriptionBankViewItem::丆丘不东东万下丙丁(string 万且万且丑丗且丌丆)));
            if(this.丕丗丛丅丆丏业丕丅 == null)
            {
                    return;
            }
            
            this.丕丗丛丅丆丏业丕丅.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Inapps.SubscriptionBankViewItem::丝一丅丆三东丂丞七()));
        }
        public SubscriptionBankViewItem()
        {
            this.与三一丁三不丌丛丞 = 0;
            this.业丗世上万东丁丁丈 = -1f;
        }
    
    }

}
