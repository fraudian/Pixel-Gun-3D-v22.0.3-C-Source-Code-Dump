using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallengeView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.三丛上丁丗丌丆丌东>, 万丟丞不世丛七一专<PGCompany.BattlePass.BattlePassChallengeView>
    {
        // Fields
        internal bool 丅与丟丄业三丅丁丞;
        private Rilisoft.OfferItem <丂下丟专不东三七七>k__BackingField;
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<PGCompany.BattlePass.BattlePassChallengeView> 丅丕丌丛万丂丈七与;
        private System.Action<PGCompany.BattlePass.BattlePassChallengeView> 三丂业上丂专七与丒;
        private System.EventHandler 丄不与丒世专三专丕;
        private PGCompany.BattlePass.BattlePassReminderGiveRewardsButton 且丂一一丞业七丟世;
        private UILabel _pointsLabel;
        private UIBasicSprite _progressSprite;
        private UIBasicSprite _progressPremiumSprite;
        private UILabel _descriptionLabel;
        private UnityEngine.GameObject _freeObject;
        private UnityEngine.GameObject _paidObject;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPOfferItemView> _rewardsViews;
        private PGCompany.BattlePass.BPOfferListExpView _expRewardsView;
        private UnityEngine.GameObject _noRewardObject;
        private UnityEngine.GameObject _isCompletedObject;
        private UIWidget _bodyWidget;
        private UnityEngine.GameObject _lockIndicator;
        private UILabel _dayLabel;
        private PGCompany.BattlePass.BPChallengeConditionsView _conditionsView;
        private UnityEngine.GameObject _toBattleButton;
        private UnityEngine.GameObject _unlockBpButton;
        private UnityEngine.GameObject _readyToClaimObj;
        private float _alphaIfNotAvailable;
        private bool _changeAlpha;
        private UnityEngine.Transform _startCrownParticles;
        private UnityEngine.Transform _targetCrownParticles;
        private UnityEngine.GameObject _paidEffectObj;
        
        // Properties
        public Rilisoft.OfferItem 丛丌丞三丕丞上丘万 { get; set; }
        public PGCompany.BattlePass.三丛上丁丗丌丆丌东 丄丄一丐东丐丝丗七 { get; set; }
        internal PGCompany.BattlePass.BattlePassReminderGiveRewardsButton 丌且丞七丏世且业丂 { get; }
        
        // Methods
        public Rilisoft.OfferItem get_LastClickedReward()
        {
            return (Rilisoft.OfferItem)this.<丂下丟专不东三七七>k__BackingField;
        }
        private void 丝一七丁丁丗丒丆丝(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
        {
            this.<丂下丟专不东三七七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public PGCompany.BattlePass.三丛上丁丗丌丆丌东 get_Context()
        {
            return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.三丛上丁丗丌丆丌东 与且专丈不万东一万)
        {
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_13;
            var val_14;
            System.EventHandler val_15;
            var val_16;
            val_13 = 与且专丈不万东一万;
            this.<丂下丟专不东三七七>k__BackingField = 0;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
            {
                    val_14 = 1152921504615739392;
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().丌丛丙业一世丅丁上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七()));
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七()));
            }
            
            val_15 = this.丄不与丒世专三专丕;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = val_13;
            if(val_15 != null)
            {
                    val_16 = null;
                val_16 = null;
                val_15.Invoke(sender:  this, e:  System.EventArgs.Empty);
                val_13 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            }
            
            if(val_13 != null)
            {
                    System.Action val_6 = null;
                val_14 = 1152921560062626784;
                val_6 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七());
                val_13.丄上丝丌上下丒上丙().丌丛丙业一世丅丁上(丙业与丙丗丝不丈东:  val_6);
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().专丝丕专丆丛丂丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七()));
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七()));
                System.Action val_12 = null;
                val_15 = val_12;
                val_12 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝一丅丆三东丂丞七());
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  val_12);
            }
            
            this.丝一丅丆三东丂丞七();
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BattlePassChallengeView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560062923600);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BattlePassChallengeView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560063060176);
        
        }
        public void add_OnRewardClicked(System.Action<PGCompany.BattlePass.BattlePassChallengeView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.三丂业上丂专七与丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三丂业上丂专七与丒 != 1152921560063196760);
        
        }
        public void remove_OnRewardClicked(System.Action<PGCompany.BattlePass.BattlePassChallengeView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.三丂业上丂专七与丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三丂业上丂专七与丒 != 1152921560063333336);
        
        }
        public void add_ContextChanged(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄不与丒世专三专丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄不与丒世专三专丕 != 1152921560063469920);
        
        }
        public void remove_ContextChanged(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄不与丒世专三专丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄不与丒世专三专丕 != 1152921560063606496);
        
        }
        private void OnEnable()
        {
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)));
            BPChallengesController.丛丄丂与丄丈丟丂丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)));
        }
        private void OnDisable()
        {
            System.Action<System.Int32> val_1 = new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三));
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  val_1);
            val_1.丟丅丐万业丑下丗丅();
        }
        private void OnDestroy()
        {
            System.Action<System.Int32> val_1 = new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三));
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  val_1);
            val_1.丟丅丐万业丑下丗丅();
        }
        private void 丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)
        {
        
        }
        private void 丝一丅丆三东丂丞七()
        {
            object val_91;
            var val_92;
            UIBasicSprite val_93;
            UnityEngine.Object val_94;
            bool val_95;
            var val_96;
            var val_97;
            bool val_98;
            UIWidget val_99;
            var val_100;
            var val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            UnityEngine.GameObject val_106;
            var val_107;
            val_91 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙()) == null)
            {
                    return;
            }
            
            bool val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丒业丐丞业丒丟丙();
            PGCompany.BattlePass.丘丄上丏不丝不丐丐 val_3 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙();
            int val_5 = UnityEngine.Mathf.Clamp(value:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙(), min:  0, max:  val_3);
            if(this._pointsLabel == 0)
            {
                goto label_12;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) == 1)
            {
                    if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.世丑丐丅丆丂丘不丁()) != false)
            {
                    if((PGCompany.BattlePass.万丈上下三丅丘丛丒.丏一丗丐丂万丈丟丆(万丒丑且丈丂丘东丑:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.不业丙丒丂丞下丆丙())) == false)
            {
                goto label_18;
            }
            
            }
            
            }
            
            label_145:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._pointsLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_5, arg1:  val_3));
            label_12:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) != 1)
            {
                goto label_25;
            }
            
            val_92 = val_91;
            if(this._progressPremiumSprite == 0)
            {
                goto label_25;
            }
            
            val_93 = this._progressSprite;
            goto label_26;
            label_25:
            val_93 = this._progressSprite;
            val_92 = val_93;
            label_26:
            val_94 = mem[this._progressSprite];
            UnityEngine.Object val_89 = mem[this._progressSprite];
            val_95 = UnityEngine.Object.op_Equality(x:  val_94, y:  val_89);
            val_89 = val_95;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  mem[this._progressSprite], 丏业丟一东丂东丘丛:  val_89);
            UIBasicSprite val_90 = this._progressPremiumSprite;
            val_90 = UnityEngine.Object.op_Equality(x:  val_94, y:  val_90);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._progressPremiumSprite, 丏业丟一东丂东丘丛:  val_90);
            val_96 = 1152921505284374528;
            if(val_94 != 0)
            {
                    val_94.fillAmount = (float)val_5 / (float)val_3;
            }
            
            if(this._descriptionLabel != 0)
            {
                    this._descriptionLabel.text = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丒万丁丌一丙专丐丞();
            }
            
            if(this._freeObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) == 0) ? 1 : 0);
            }
            
            if(this._paidObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._paidObject, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) == 1) ? 1 : 0);
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕()) == null)
            {
                goto label_54;
            }
            
            val_95 = 1152921525530181280;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕().Count) < 1)
            {
                goto label_54;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noRewardObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._expRewardsView, 丏业丟一东丂东丘丛:  false);
            if(((this._expRewardsView == 0) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕().Count) != 1)) || ((System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕()).Type) != 1100))
            {
                goto label_65;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._expRewardsView, 丏业丟一东丂东丘丛:  true);
            this._expRewardsView.HasUndroppedRewards = val_2;
            this._expRewardsView.Setup(与且专丈不万东一万:  System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕()));
            this._expRewardsView.OnClickAction = new System.Action<PGCompany.BattlePass.BPOfferItemView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丟下丕丌与丈且下丞(PGCompany.BattlePass.BPOfferItemView 丁世丛业丟下丕三丟));
            goto label_75;
            label_54:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noRewardObject, 丏业丟一东丂东丘丛:  true);
            goto label_75;
            label_65:
            val_97 = 0;
            goto label_76;
            label_109:
            PGCompany.BattlePass.BPOfferItemView val_39 = this._rewardsViews.Item[0];
            if(val_39 == 0)
            {
                goto label_86;
            }
            
            val_94 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕();
            var val_91 = val_94.Count;
            val_91 = val_91 - 1;
            if(val_97 <= val_91)
            {
                goto label_83;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_39, 丏业丟一东丂东丘丛:  false);
            goto label_86;
            label_83:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_39, 丏业丟一东丂东丘丛:  true);
            val_39.HasUndroppedRewards = val_2;
            val_39.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕().Item[0]);
            if(this.丅与丟丄业三丅丁丞 == false)
            {
                goto label_93;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.三丝丄丈丆丂专丄东()) != 30)
            {
                goto label_95;
            }
            
            val_98 = 0;
            if(val_39 != null)
            {
                goto label_105;
            }
            
            goto label_97;
            label_93:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_39._itemTexture, 丏业丟一东丂东丘丛:  true);
            goto label_101;
            label_95:
            val_98 = (~(BPChallengesController.丑七不且上丗丁一世().一万丘丁三丆下丝丞(丟专三丙丒丄丂下与:  this.<丅丝丌丝丁丏丙东丞>k__BackingField))) & 1;
            if(val_39 != null)
            {
                goto label_105;
            }
            
            label_97:
            label_105:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_39._itemTexture, 丏业丟一东丂东丘丛:  val_98);
            val_96 = 1152921505284374528;
            label_101:
            System.Action<PGCompany.BattlePass.BPOfferItemView> val_49 = null;
            val_94 = val_49;
            val_49 = new System.Action<PGCompany.BattlePass.BPOfferItemView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengeView::丟下丕丌与丈且下丞(PGCompany.BattlePass.BPOfferItemView 丁世丛业丟下丕三丟));
            val_39.OnClickAction = val_94;
            label_86:
            val_97 = 1;
            label_76:
            if(val_97 < this._rewardsViews.Count)
            {
                goto label_109;
            }
            
            label_75:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.不丆东丟丘丅一专七()) == false)
            {
                goto label_111;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockIndicator, 丏业丟一东丂东丘丛:  true);
            if((this._changeAlpha == false) || (this._bodyWidget == 0))
            {
                goto label_125;
            }
            
            val_99 = this._bodyWidget;
            if(val_99 != null)
            {
                goto label_119;
            }
            
            goto label_119;
            label_111:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockIndicator, 丏业丟一东丂东丘丛:  false);
            if((this._changeAlpha == false) || (this._bodyWidget == 0))
            {
                goto label_125;
            }
            
            val_99 = this._bodyWidget;
            label_119:
            label_125:
            if(this._isCompletedObject == 0)
            {
                goto label_139;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.世丑丐丅丆丂丘不丁()) != false)
            {
                    val_100 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丞专丝万七一东丆();
            }
            else
            {
                    val_100 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._isCompletedObject, 丏业丟一东丂东丘丛:  false);
            if((this._changeAlpha == false) || (this._bodyWidget == 0))
            {
                goto label_139;
            }
            
            if(val_100 == 0)
            {
                goto label_141;
            }
            
            goto label_142;
            label_18:
            string val_58 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1697");
            goto label_145;
            label_141:
            label_142:
            label_139:
            if(this._dayLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._dayLabel, 丕丗丘丑丛与丑业丒:  (UnityEngine.Mathf.Clamp(value:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.三万七与东丄业丐丙(), min:  0, max:  2147483647)) + 1.ToString());
            }
            
            if(this._conditionsView != 0)
            {
                    this._conditionsView.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙());
            }
            
            if(this._toBattleButton == 0)
            {
                goto label_161;
            }
            
            if(((this.<丅丝丌丝丁丏丙东丞>k__BackingField.不丆东丟丘丅一专七()) == true) || ((PGCompany.BattlePass.三丛上丁丗丌丆丌东.丙丛丝丒丆且丆丛与(丟专三丙丒丄丂下与:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)) == false))
            {
                goto label_164;
            }
            
            if(((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().丘丛丆丕且丂业世丌()) & 2147483648) != 0)
            {
                goto label_215;
            }
            
            val_101 = (Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄上丝丌上下丒上丙().丘丛丆丕且丂业世丌())) ^ 1;
            goto label_215;
            label_164:
            val_101 = 0;
            label_215:
            var val_77 = val_101 | (((this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七()) == 9999) ? 1 : 0);
            val_102 = 0;
            val_77 = val_77 & 1;
            goto label_176;
            label_183:
            val_94 = this._toBattleButton.GetComponents<UIButton>()[0];
            bool val_79 = UnityEngine.Object.op_Inequality(x:  val_94, y:  0);
            val_102 = 1;
            label_176:
            if(val_102 < val_78.Length)
            {
                goto label_183;
            }
            
            label_161:
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_81 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_81 == null)
            {
                    return;
            }
            
            if(val_2 == false)
            {
                goto label_186;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._toBattleButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockBpButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._paidEffectObj, 丏业丟一东丂东丘丛:  false);
            val_91 = this._readyToClaimObj;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七()) != 9999)
            {
                goto label_190;
            }
            
            val_103 = null;
            val_104 = PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁();
            goto label_193;
            label_186:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._readyToClaimObj, 丏业丟一东丂东丘丛:  false);
            if(((this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七()) != 9999) && ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.世丑丐丅丆丂丘不丁()) != false))
            {
                    val_105 = (~(this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丞专丝万七一东丆())) & 1;
            }
            else
            {
                    val_105 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._paidEffectObj, 丏业丟一东丂东丘丛:  false);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) == 1)
            {
                    if(val_81.专丟专一丒且丘与丌() == 0)
            {
                goto label_206;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._toBattleButton, 丏业丟一东丂东丘丛:  true);
            val_106 = this._unlockBpButton;
            val_107 = 0;
            goto label_214;
            label_190:
            val_104 = 1;
            label_193:
            val_106 = val_91;
            val_107 = val_104;
            label_214:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_106, 丏业丟一东丂东丘丛:  true);
            return;
            label_206:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._toBattleButton, 丏业丟一东丂东丘丛:  false);
            goto label_214;
        }
        private void 丟下丕丌与丈且下丞(PGCompany.BattlePass.BPOfferItemView 丁世丛业丟下丕三丟)
        {
            this.<丂下丟专不东三七七>k__BackingField = 丁世丛业丟下丕三丟.Context;
            if(this.三丂业上丂专七与丒 == null)
            {
                    return;
            }
            
            this.三丂业上丂专七与丒.Invoke(obj:  this);
        }
        public void U_Click()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public void U_GoToBattle()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().GoBattleRequest(丟专三丙丒丄丂下与:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        public void U_BuyPrem()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().U_BuyPremium();
        }
        public void U_Claim()
        {
            var val_24;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            val_24 = null;
            val_24 = null;
            PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟 = PGCompany.BattlePass.BattlePassSettings.不丈丑丑丆丁上下丛();
            if(this._startCrownParticles != 0)
            {
                    UnityEngine.Vector3 val_6 = this._startCrownParticles.position;
            }
            else
            {
                    UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            }
            
            BPChallengesController.丑七不且上丗丁一世().世丗丟丆丒丈万丕丈(丞丅上丏丂且下丅与:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七());
            不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PGCompany.BattlePass.BattlePassSettings.Instance.GiveBPExpStartAudioClip).丟丅丐万业丑下丗丅();
            Rilisoft.OfferItem val_17 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕());
            if(this._targetCrownParticles == 0)
            {
                    return;
            }
            
            if(val_2.业丈丅丂且丁与丄丂() != val_2.业丈丅丂且丁与丄丂())
            {
                    return;
            }
            
            if(val_17 == null)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(val_17.Type != 1100)
            {
                    return;
            }
            
            int val_23 = val_17.Count;
            val_23.业丁丞不业丘下七丄(丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丞下万上三丘上与专:  this._targetCrownParticles, 丄万不且丂丛丘业丐:  val_23);
        }
        internal void 下万丑且东丑丅丟专()
        {
            if(this.丂丙丙与且丗丗丆丏() == 0)
            {
                    return;
            }
            
            this.丂丙丙与且丗丗丆丏().丒丕丝丄与不三丅丘();
        }
        internal PGCompany.BattlePass.BattlePassReminderGiveRewardsButton 丂丙丙与且丗丗丆丏()
        {
            PGCompany.BattlePass.BattlePassReminderGiveRewardsButton val_3;
            if(this.且丂一一丞业七丟世 == 0)
            {
                    this.且丂一一丞业七丟世 = this.GetComponentInChildren<PGCompany.BattlePass.BattlePassReminderGiveRewardsButton>(includeInactive:  true);
                return val_3;
            }
            
            val_3 = this.且丂一一丞业七丟世;
            return val_3;
        }
        private void 丟丅丐万业丑下丗丅()
        {
            BattlePassRootUI val_8 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅();
            if(val_8 == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅().丌丄丏下七丁专丂世();
        }
        private void 业丁丞不业丘下七丄(UnityEngine.Vector3 丈万丏丈上丑不丅上, UnityEngine.Transform 丞下万上三丘上与专, int 丄万不且丂丛丘业丐)
        {
            BattlePassRootUI val_8 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅();
            if(val_8 == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅().三且世三丂七丐一丟(丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = 丈万丏丈上丑不丅上.y, z = 丈万丏丈上丑不丅上.z}, 丞下万上三丘上与专:  丞下万上三丘上与专, 丄万不且丂丛丘业丐:  丄万不且丂丛丘业丐);
        }
        public BattlePassChallengeView()
        {
            this._alphaIfNotAvailable = -1f;
        }
    
    }

}
