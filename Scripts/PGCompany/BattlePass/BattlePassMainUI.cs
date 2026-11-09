using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassMainUI : MonoBehaviour
    {
        // Fields
        private UIScrollView _scroll;
        private Rilisoft.BetterWrapContent _wrap;
        private Rilisoft.CharacterHelper _characterHelper;
        private PGCompany.BattlePass.OfferItemDescriptionView _descriptionView;
        private PGCompany.BattlePass.BPPhoenixHandler _phoenixHandler;
        private UnityEngine.GameObject _backLobbyBtn;
        private UnityEngine.GameObject _backBtn;
        private UnityEngine.GameObject _openChallengesBtn;
        private UnityEngine.GameObject _isNewMarkOnOpenButton;
        private UnityEngine.GameObject _woodenShield;
        private UnityEngine.GameObject _goldenShield;
        private UnityEngine.GameObject _buyPremiumRecomend;
        private UnityEngine.GameObject _challengesBadge;
        private UILabel _challengesRewardsCountLabel;
        private StrechSpriteToGameObject _strech;
        private UnityEngine.Transform _strechMin;
        private UnityEngine.Transform _strechMax;
        private UnityEngine.GameObject _buyPremiumBtn;
        private PGCompany.BattlePass.BPDailyRewardView _dailyReward;
        private UnityEngine.Transform _particleAtraktorTarget;
        private PGCompany.BattlePass.BattlePassReminderGiveRewardsButton _reminderGiveRewardsButton;
        private UnityEngine.GameObject _leftNovigationButton;
        private UnityEngine.GameObject _rightNovigationButton;
        private BonusPromotionsView _bonusPromotionsView;
        private UnityEngine.GameObject _3DObjects;
        private UIGrid _gridNotification;
        internal static string 下丐丌丅丗丂丐三七;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Collections.Generic.List<PGCompany.BattlePass.BattlePassMainUI.丕丟丕丌丒丞世与丅> 丄丌专丈丗丆丆丈丗;
        private bool 丒丂丏且上丌下丙丙;
        private PGCompany.BattlePass.BPReward 不一丘丘业丛且上世;
        private int 丑与丗一丘下丆丐丅;
        private BattlePassRootUI.丝丂丅丝丟丞丐上与 不一丐且丗专丙丈丞;
        private UnityEngine.Coroutine 丗丙七世且三丅丟丝;
        private System.Collections.Generic.List<UnityEngine.GameObject> _hideIfSubbannerOpended;
        
        // Methods
        internal void 丈不丘丂丈东丆丐丙()
        {
            this.不一丐且丗专丙丈丞 = 0;
        }
        private void OnEnable()
        {
            var val_8;
            object val_19;
            var val_21;
            val_19 = this;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
            {
                    this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassMainUI::Back()), 与且专丈不万东一万:  0);
            }
            
            List.Enumerator<T> val_6 = this._hideIfSubbannerOpended.GetEnumerator();
            val_21 = 1152921519068955088;
            label_19:
            if(((-345525328) & 1) == 0)
            {
                goto label_13;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if(val_9 == 0)
            {
                goto label_19;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
            goto label_19;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._characterHelper.transform.parent.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丙丐东丘丞丟万丆上();
            this._wrap.UpdateVisibleCells();
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            if(this._isNewMarkOnOpenButton != 0)
            {
                    System.Action val_16 = null;
                val_21 = 1152921560095871280;
                val_16 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与下丐东丙丟丘丑丕());
                PGCompany.BattlePass.三丛上丁丗丌丆丌东.下丏且丞丈丐丅不东(丙业与丙丗丝不丈东:  val_16);
                BPChallengesController.下专丒丌与丙不一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与下丐东丙丟丘丑丕()));
            }
            
            if(this._reminderGiveRewardsButton == 0)
            {
                    return;
            }
            
            val_19 = this._reminderGiveRewardsButton;
            val_19.丒丕丝丄与不三丅丘();
        }
        private void 丙丐东丘丞丟万丆上()
        {
            System.Action val_11;
            System.Action val_1 = null;
            val_11 = 1152921560096070336;
            val_1 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丙丐东丘丞丟万丆上());
            PGCompany.BattlePass.BPTutorialController.不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  val_1);
            if(this._bonusPromotionsView != 0)
            {
                    if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
            {
                    string[] val_4 = new string[2];
                val_4[0] = "source.bonuses.battlePassCurrency";
                val_4[1] = "promotion.content.battlepasscurrency";
                this._bonusPromotionsView.丝一丅下且一丟丒世(丐丑丒丕丐丟丐东与:  new TagSystem.丞丟一丅丐专三万不(东丌丕上丞万丌丙丑:  new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_4), 丟且丒专下丈七丗丕:  4));
                this._bonusPromotionsView.且丕丄丁丟丝丁专丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丟丛丈丆业丙上丒业()));
                this._bonusPromotionsView.且丏丗丌丌丄丕丅丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丘丂丆丆丕下一且丄()));
                System.Action val_9 = null;
                val_11 = val_9;
                val_9 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丁丁七七丈丌万七一());
                this._bonusPromotionsView.丒丗丑丁丙业丏丏与(丙业与丙丗丝不丈东:  val_9);
            }
            else
            {
                    this._bonusPromotionsView.丝一丅下且一丟丒世(丐丑丒丕丐丟丐东与:  0);
                PGCompany.BattlePass.BPTutorialController.丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丙丐东丘丞丟万丆上()));
            }
            
            }
            
            this.丟丛丈丆业丙上丒业();
        }
        private void 丟丛丈丆业丙上丒业()
        {
            PGCompany.BattlePass.BPPhoenixHandler val_5;
            bool val_6;
            val_5 = 1152921504848912384;
            if(this._phoenixHandler == 0)
            {
                    return;
            }
            
            if(this._bonusPromotionsView == 0)
            {
                    val_6 = 1;
            }
            else
            {
                    BonusPromotionsView val_4 = this._bonusPromotionsView;
                val_6 = val_4.丛丆丘不专丑丛上七() ^ 1;
            }
            
            val_4 = val_6;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._phoenixHandler, 丏业丟一东丂东丘丛:  val_4);
            val_5 = this._phoenixHandler;
            val_5.东丝下且专丞且下丄(丛丅丘一丏丙且丌上:  val_4);
            if(val_6 == false)
            {
                    return;
            }
            
            this._phoenixHandler.Setup();
        }
        private void 丘丂丆丆丕下一且丄()
        {
            if(this._bonusPromotionsView == 0)
            {
                    return;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.东上丗东不丈东丑丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 世丁丙世丄一万丆三:  "battlePass", 丐丆丝业丙丈下世丁:  this._bonusPromotionsView.SelectedPromotion);
            if(this._3DObjects != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._3DObjects, 丏业丟一东丂东丘丛:  false);
            }
            
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
        }
        private void 丁丁七七丈丌万七一()
        {
            if(this._3DObjects != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._3DObjects, 丏业丟一东丂东丘丛:  true);
            }
            
            this.七丙丅丘与丈丗三丌(丗七丟丈三不丕一三:  this.不一丘丘业丛且上世);
        }
        private void OnDisable()
        {
            if(this._bonusPromotionsView != 0)
            {
                    this._bonusPromotionsView.不丝东丐丛丝丈与丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丟丛丈丆业丙上丒业()));
                this._bonusPromotionsView.丐丑丘七丄下丝丏丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丘丂丆丆丕下一且丄()));
                this._bonusPromotionsView.东丅一丝丂三七专丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丁丁七七丈丌万七一()));
            }
            
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._characterHelper.transform.parent.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this._phoenixHandler != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._phoenixHandler, 丏业丟一东丂东丘丛:  false);
                this._phoenixHandler.东丝下且专丞且下丄(丛丅丘一丏丙且丌上:  false);
            }
            
            if(this._dailyReward != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._dailyReward.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            if(this._isNewMarkOnOpenButton == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东.下且丅丟且丄丌业丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与下丐东丙丟丘丑丕()));
            BPChallengesController.与万丟不丝丗丒东丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与下丐东丙丟丘丑丕()));
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        public void Show(BattlePassRootUI.丝丂丅丝丟丞丐上与 丈丗与丞一上且上上)
        {
            UnityEngine.GameObject val_13;
            UnityEngine.GameObject val_14;
            var val_15;
            this.不一丐且丗专丙丈丞 = 丈丗与丞一上且上上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._characterHelper.transform.parent.gameObject, 丏业丟一东丂东丘丛:  true);
            val_13 = this._backLobbyBtn;
            if(丈丗与丞一上且上上 == 4)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backBtn, 丏业丟一东丂东丘丛:  true);
                val_14 = this._openChallengesBtn;
                val_15 = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  (~PGCompany.TransitionController.丑七不且上丗丁一世().丟丁与与丘东丈世不()) & 1);
                val_13 = PGCompany.TransitionController.丑七不且上丗丁一世();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backBtn, 丏业丟一东丂东丘丛:  val_13.丟丁与与丘东丈世不());
                val_14 = this._openChallengesBtn;
                val_15 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  true);
            if((this.gameObject.activeInHierarchy != false) && (this.丒丂丏且上丌下丙丙 != false))
            {
                    this._characterHelper.CharacterVisible = true;
                BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            }
            
            this.UpdateView();
        }
        public void Resert()
        {
            this.不一丘丘业丛且上世 = 0;
        }
        public void Hide()
        {
            this.丑与丗一丘下丆丐丅 = 0;
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._characterHelper.transform.parent.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        private void 与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)
        {
            if(世丁丙世丄一万丆三 == 1)
            {
                    return;
            }
            
            this.UpdateView();
        }
        public void UpdateView()
        {
            UnityEngine.Transform val_17;
            int val_18;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 != null)
            {
                    PlayerPaymentState val_3 = val_2.专丟专一丒且丘与丌();
                bool val_4 = (val_3 != 100) ? 1 : 0;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._woodenShield, 丏业丟一东丂东丘丛:  val_4);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goldenShield, 丏业丟一东丂东丘丛:  (val_3 == 100) ? 1 : 0);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumRecomend, 丏业丟一东丂东丘丛:  val_4);
            }
            
            if(this._dailyReward != 0)
            {
                    val_17 = this._particleAtraktorTarget;
                this._dailyReward.SwithOn(丗东三与上上丂丟丅:  val_17);
            }
            
            if(this.gameObject.activeInHierarchy != false)
            {
                    if(this.丗丙七世且三丅丟丝 != null)
            {
                    this.StopCoroutine(routine:  this.丗丙七世且三丅丟丝);
            }
            
                this.丗丙七世且三丅丟丝 = this.StartCoroutine(routine:  this.世丒东丘丞丁丂三丈());
            }
            
            if(this._challengesBadge != 0)
            {
                    System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_13 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
                if(val_13 != null)
            {
                    val_18 = System.Linq.Enumerable.Count<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_13);
            }
            else
            {
                    val_18 = 0;
            }
            
                val_17 = this._challengesBadge;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  (val_18 > 0) ? 1 : 0);
                if(val_18 >= 1)
            {
                    val_17 = val_18.ToString();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._challengesRewardsCountLabel, 丕丗丘丑丛与丑业丒:  val_17);
            }
            
            }
            
            this.与下丐东丙丟丘丑丕();
        }
        private void 与下丐东丙丟丘丑丕()
        {
            var val_12;
            var val_13;
            val_12 = this;
            if(PGCompany.BattlePass.万丈上下三丅丘丛丒.丈丟丒丏丝东丕三下().Count > 0)
            {
                    val_13 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._isNewMarkOnOpenButton, 丏业丟一东丂东丘丛:  (PGCompany.BattlePass.万丈上下三丅丘丛丒.上专丘世丘丂丝上丐().Count > 0) ? 1 : 0);
            if(this._gridNotification == null)
            {
                    return;
            }
            
            val_12 = ???;
            val_13 = ???;
            goto typeof(UIGrid).__il2cppRuntimeField_1A8;
        }
        private void Update()
        {
            this.丆丐丗丁丕丅丞丒丈();
        }
        private void 丆丐丗丁丕丅丞丒丈()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftNovigationButton, 丏业丟一东丂东丘丛:  (this._scroll.horizontalScrollBar.value > 0.001f) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightNovigationButton, 丏业丟一东丂东丘丛:  (this._scroll.horizontalScrollBar.value < 0) ? 1 : 0);
        }
        private System.Collections.IEnumerator 世丒东丘丞丁丂三丈()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassMainUI.不且上业万与丝且丄();
        }
        private PGCompany.BattlePass.BattlePassMainUI.丕丟丕丌丒丞世与丅 且七丕三丞上三丗丛(PGCompany.BattlePass.BPReward 丗七丟丈三不丕一三)
        {
            var val_3;
            var val_4;
            val_3 = 丗七丟丈三不丕一三;
            List.Enumerator<T> val_1 = this.丄丌专丈丗丆丆丈丗.GetEnumerator();
            label_7:
            if(((-342765544) & 1) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0.丐丏七丌丕丗业且上();
            if(val_2.m_stringLength != 0)
            {
                    if((val_2.m_stringLength & 1) != 0)
            {
                goto label_8;
            }
            
            }
            
            if((val_2.m_stringLength == 0) || ((val_2.m_stringLength & 1) == 0))
            {
                goto label_7;
            }
            
            goto label_8;
            label_2:
            val_4 = 0;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (丕丟丕丌丒丞世与丅)val_4;
        }
        private void 与专且丌丕丞丈丑世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)
        {
            System.Collections.Generic.List<丕丟丕丌丒丞世与丅> val_21;
            System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_22;
            var val_23;
            var val_24;
            PGCompany.BattlePass.BPLevelRewardsView val_1 = 丝三丁东丈丒世丅业.GetComponent<PGCompany.BattlePass.BPLevelRewardsView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPLevelRewardsView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丝丈丆世且三与丝东(PGCompany.BattlePass.BPLevelRewardsView 丁世丛业丟下丕三丟)));
            val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPLevelRewardsView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::丝丈丆世且三与丝东(PGCompany.BattlePass.BPLevelRewardsView 丁世丛业丟下丕三丟)));
            val_21 = this.丄丌专丈丗丆丆丈丗;
            if(val_21.Count <= 丗世世丝丄丌且上下)
            {
                    return;
            }
            
            丕丟丕丌丒丞世与丅 val_6 = this.丄丌专丈丗丆丆丈丗.Item[丗世世丝丄丌且上下];
            System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_7 = null;
            val_22 = val_7;
            val_7 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
            val_7.Add(item:  val_6.丒上丄万世且丙且上);
            val_7.Add(item:  val_6.且业丞七丂世丑丞丒);
            int val_10 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().业丈丅丂且丁与丄丂();
            if(val_1 != null)
            {
                    val_23 = val_1;
                val_1.AvailableByLevel = (val_10 >= val_6.丛下一丝丛丗与丄万) ? 1 : 0;
                val_24 = val_6;
                val_1.Setup(与且专丈不万东一万:  val_7, 丆且丁丒丒丆丁三丆:  val_6.丙丘丒一下丝丞七世);
            }
            else
            {
                    val_23 = val_1;
                val_1.AvailableByLevel = (val_10 >= val_6.丛下一丝丛丗与丄万) ? 1 : 0;
                val_24 = val_6;
                val_1.Setup(与且专丈不万东一万:  val_7, 丆且丁丒丒丆丁三丆:  val_6.丙丘丒一下丝丞七世);
            }
            
            val_1.wrapidx = 丗世世丝丄丌且上下;
            if(this._strech == 0)
            {
                goto label_38;
            }
            
            if(this._strech.to != 0)
            {
                    val_22 = val_1.transform;
                if((this._strech.to == val_22) && (val_6.万下且丄丙丅世丒丒 != true))
            {
                    this._strech.to = 0;
            }
            
            }
            
            if((val_6.万下且丄丙丅世丒丒 != false) && ((val_6 + 32) <= 1))
            {
                    val_22 = this._strech;
                this._strech.to = val_1.transform;
            }
            
            if((this._strech.to != 0) || ((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null))
            {
                goto label_38;
            }
            
            if((val_1 + 28) == 0)
            {
                goto label_39;
            }
            
            val_22 = this._strechMax;
            if(this._strech != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            this._strech.to = val_22;
            label_38:
            if(this.不一丘丘业丛且上世 != null)
            {
                    if(this.不一丘丘业丛且上世 == val_6.丒上丄万世且丙且上)
            {
                goto label_43;
            }
            
            }
            
            if(this.不一丘丘业丛且上世 != val_6.且业丞七丂世丑丞丒)
            {
                    val_1.SelectedView = 0;
                return;
            }
            
            label_43:
            val_1.SelectedViewWithReward = this.不一丘丘业丛且上世;
            return;
            label_39:
            if(this._strech != null)
            {
                goto label_44;
            }
            
            goto label_45;
        }
        private void 丝丈丆世且三与丝东(PGCompany.BattlePass.BPLevelRewardsView 丁世丛业丟下丕三丟)
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_78;
            UnityEngine.Object val_79;
            UnityEngine.Object val_80;
            var val_81;
            PGCompany.BattlePass.BPRewardView val_82;
            PGCompany.BattlePass.BPRewardView val_83;
            UnityEngine.GameObject val_84;
            val_79 = 丁世丛业丟下丕三丟;
            if(val_79 == 0)
            {
                    return;
            }
            
            val_80 = val_79.LastClickedView;
            if(val_80 == 0)
            {
                    return;
            }
            
            val_80 = val_79.LastClickedView;
            if(val_80.Context == null)
            {
                    return;
            }
            
            val_80 = val_79.LastClickedView.Context;
            if(val_80.Item == null)
            {
                    return;
            }
            
            val_80 = val_79.LastClickedView.Context.Item;
            if(val_80.IsKnownItem == false)
            {
                    return;
            }
            
            val_80 = Rilisoft.Singleton<BattlePassController>.Instance;
            val_78 = val_80.丛东丛丕东丟丂丈丝();
            if(val_79.LastClickedView.Context.RewardUnDropped == false)
            {
                goto label_24;
            }
            
            val_81 = val_78.业丈丅丂且丁与丄丂();
            PGCompany.BattlePass.BPReward val_20 = val_79.LastClickedView.Context;
            if(val_78 == null)
            {
                goto label_28;
            }
            
            val_78.专业丙丛丌专下丛丂(丗七丟丈三不丕一三:  val_20, 丂丅丑七丌不丄上丞:  true);
            goto label_29;
            label_24:
            this.不一丘丘业丛且上世 = val_79.LastClickedView.Context;
            System.Collections.Generic.List<UnityEngine.GameObject> val_23 = this._wrap.GetAllCellsObjects();
            val_81 = 0;
            goto label_33;
            label_54:
            UnityEngine.GameObject val_24 = val_23.Item[0];
            if(val_24 == 0)
            {
                goto label_41;
            }
            
            PGCompany.BattlePass.BPLevelRewardsView val_26 = val_24.GetComponent<PGCompany.BattlePass.BPLevelRewardsView>();
            if(val_26 == 0)
            {
                goto label_41;
            }
            
            val_82 = UnityEngine.Object.op_Equality(x:  val_26, y:  val_79);
            if(val_26 == null)
            {
                goto label_44;
            }
            
            if(val_82 == false)
            {
                goto label_45;
            }
            
            label_51:
            bool val_78 = false;
            val_78 = val_78 | (UnityEngine.Object.op_Equality(x:  val_26.LastClickedView, y:  val_26.SelectedView));
            if(val_26 == null)
            {
                goto label_49;
            }
            
            val_82 = val_26.LastClickedView;
            goto label_50;
            label_44:
            if(val_82 == true)
            {
                goto label_51;
            }
            
            label_45:
            val_83 = 0;
            goto label_52;
            label_49:
            val_82 = val_26.LastClickedView;
            label_50:
            val_83 = val_82;
            label_52:
            val_26.SelectedView = val_83;
            label_41:
            val_81 = 1;
            label_33:
            if(val_81 < val_23.Count)
            {
                goto label_54;
            }
            
            if(val_78 != false)
            {
                    val_78 = this.transform;
                val_80 = val_79.SelectedView.Context.Item.Id;
                Rilisoft.ItemViewer val_44 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  val_78, 丕丁下丌不万丅丞丛:  val_80, 丅三丟世下丞丝丙万:  val_79.SelectedView.Context.Item.Count, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
                return;
            }
            
            if((((mem[1152921560099418944] != 0) && (mem[1152921560099418944].activeInHierarchy != false)) && (val_79.SelectedView.Context.PaymentState == 100)) && (val_78.专丟专一丒且丘与丌() != 100))
            {
                    UITweener val_51 = mem[1152921560099418944].GetComponent<UITweener>();
                if(val_51 != 0)
            {
                    val_51.PlayForward();
            }
            
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_56 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(val_79.SelectedView.Context.Item != null)
            {
                    val_79 = val_79.SelectedView.Context.Item;
                val_56.Add(item:  val_79);
            }
            
            val_81 = 1152921505138155520;
            val_80 = mem[1152921560099418824];
            val_78 = val_56.丟丞不丅丒丄丈丐丑(专七专与与丄上丂一:  val_56);
            if(BattlePassRootUI.丑七不且上丗丁一世() == null)
            {
                goto label_93;
            }
            
            val_84 = val_61.ShootButton;
            goto label_94;
            label_28:
            0.专业丙丛丌专下丛丂(丗七丟丈三不丕一三:  val_20, 丂丅丑七丌不丄上丞:  true);
            label_29:
            if(val_78.业丈丅丂且丁与丄丂() == val_81)
            {
                    val_79.LastClickedView.PlayRewardGettedAnimation();
            }
            
            if(val_20.Item.Type != 1130)
            {
                    return;
            }
            
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  100)) == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "chest getted");
            int val_70 = Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  val_20.Item.Id);
            if((val_70 & 2147483648) != 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_71 = this._hideIfSubbannerOpended.GetEnumerator();
            val_81 = 1152921505284374528;
            label_119:
            if(((-342015160) & 1) == 0)
            {
                goto label_113;
            }
            
            string val_72 = 0.丐丏七丌丕丗业且上();
            if(val_72 == 0)
            {
                goto label_119;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_72, 丏业丟一东丂东丘丛:  false);
            goto label_119;
            label_93:
            val_84 = 0;
            label_94:
            BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  val_80, 丒丟丕上丅丆丆丝东:  mem[1152921560099418832], 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  val_78, 丒丈七三丄丞丐丝丂:  val_84);
            return;
            label_113:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Rilisoft.GameEventOpenChestBase.不丒丅且上丗丂丗丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::一丄丁万业专且丐丏()));
            System.Action val_75 = null;
            val_80 = val_75;
            val_75 = new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::一丄丁万业专且丐丏());
            Rilisoft.GameEventOpenChestBase.且丐三丅丁且万且下(丙业与丙丗丝不丈东:  val_75);
            val_78 = BattlePassRootUI.丑七不且上丗丁一世().三东丒世专丞上不丟();
            Rilisoft.GameEventOpenChestBase.下与丞三丅丛丄七丕(七万上丐一丈丏丏专:  val_78, 丐东业丕丕丂丗丅丙:  val_70, 世丁丌万丏丟丗世三:  74, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private void 一丄丁万业专且丐丏()
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_5;
            Rilisoft.GameEventOpenChestBase.不丒丅且上丗丂丗丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::一丄丁万业专且丐丏()));
            val_5 = this._hideIfSubbannerOpended;
            List.Enumerator<T> val_2 = val_5.GetEnumerator();
            label_10:
            if(((-341636888) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            goto label_10;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 七丙丅丘与丈丗三丌(PGCompany.BattlePass.BPReward 丗七丟丈三不丕一三)
        {
            PGCompany.BattlePass.BPReward val_13;
            var val_14;
            UnityEngine.GameObject val_15;
            val_13 = 丗七丟丈三不丕一三;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = this._wrap.GetAllCellsObjects();
            val_14 = 0;
            goto label_2;
            label_16:
            UnityEngine.GameObject val_2 = val_1.Item[0];
            if(val_2 == 0)
            {
                goto label_13;
            }
            
            PGCompany.BattlePass.BPLevelRewardsView val_4 = val_2.GetComponent<PGCompany.BattlePass.BPLevelRewardsView>();
            if(val_4 == 0)
            {
                goto label_13;
            }
            
            if(val_4 == null)
            {
                goto label_11;
            }
            
            if((val_4.IsMySubView(丗七丟丈三不丕一三:  val_13)) == false)
            {
                goto label_12;
            }
            
            label_14:
            val_4.SelectedViewWithReward = val_13;
            goto label_13;
            label_11:
            if((val_4.IsMySubView(丗七丟丈三不丕一三:  val_13)) == true)
            {
                goto label_14;
            }
            
            label_12:
            val_4.SelectedView = 0;
            label_13:
            val_14 = 1;
            label_2:
            if(val_14 < val_1.Count)
            {
                goto label_16;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_9 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(val_13 != null)
            {
                    val_13 = val_13.Item;
                val_9.Add(item:  val_13);
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() != null)
            {
                    val_15 = val_12.ShootButton;
            }
            else
            {
                    val_15 = 0;
            }
            
            BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  this._characterHelper, 丒丟丕上丅丆丆丝东:  this._descriptionView, 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  val_9.丟丞不丅丒丄丈丐丑(专七专与与丄上丂一:  val_9), 丒丈七三丄丞丐丝丂:  val_15);
        }
        private System.Collections.Generic.List<Rilisoft.OfferItem> 丟丞不丅丒丄丈丐丑(System.Collections.Generic.List<Rilisoft.OfferItem> 专七专与与丄上丂一)
        {
            var val_8;
            var val_18;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            var val_20;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_22;
            val_18 = 专七专与与丄上丂一;
            val_19 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_19 == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_18;
            }
            
            PGCompany.BattlePass.BPData val_3 = val_19.丁专丗万三上丟三丆();
            if(val_3.PresettedCharacterItems == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_18;
            }
            
            PGCompany.BattlePass.BPData val_4 = val_19.丁专丗万三上丟三丆();
            val_19 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  val_4.PresettedCharacterItems);
            if(val_18 == null)
            {
                goto label_36;
            }
            
            List.Enumerator<T> val_6 = val_18.GetEnumerator();
            label_24:
            if(((-341239872) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if(val_9.Type != 10)
            {
                    if((val_9.Type != 1070) || ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9.Id)) == null))
            {
                goto label_21;
            }
            
            }
            
            val_20 = null;
            val_20 = null;
            val_22 = BattlePassMainUI.<>c.<>9__56_0;
            if(val_22 == null)
            {
                    val_22 = null;
                val_22 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BattlePassMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassMainUI.<>c::丘一与不丙丝一丙三(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                BattlePassMainUI.<>c.<>9__56_0 = val_22;
            }
            
            Rilisoft.OfferItem val_15 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_19, predicate:  null);
            if(val_15 != null)
            {
                    bool val_16 = val_19.Remove(item:  val_15);
            }
            
            label_21:
            val_19.Insert(index:  0, item:  val_9);
            goto label_24;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_36:
            val_18 = val_19;
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_18;
        }
        private PGCompany.BattlePass.BPLevelRewardsView 丐丙业丒丅与三丑丂(PGCompany.BattlePass.BattlePassMainUI.丕丟丕丌丒丞世与丅 一丐丗丁丞丆丅丟丄)
        {
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = this._wrap.GetAllCellsObjects();
            val_12 = 0;
            goto label_2;
            label_22:
            UnityEngine.GameObject val_2 = val_1.Item[0];
            if(val_2 != 0)
            {
                    val_13 = val_2.GetComponent<PGCompany.BattlePass.BPLevelRewardsView>();
                if(val_13 != 0)
            {
                    if(val_13.Context != null)
            {
                    val_14 = val_13.Context;
                if((val_14.Contains(item:  一丐丗丁丞丆丅丟丄.且业丞七丂世丑丞丒)) == true)
            {
                    return (PGCompany.BattlePass.BPLevelRewardsView)val_13;
            }
            
            }
            
            }
            
                val_14 = val_13.Context;
                if((val_14.Contains(item:  一丐丗丁丞丆丅丟丄.丒上丄万世且丙且上)) == true)
            {
                    return (PGCompany.BattlePass.BPLevelRewardsView)val_13;
            }
            
            }
            
            val_12 = 1;
            label_2:
            if(val_12 < val_1.Count)
            {
                goto label_22;
            }
            
            val_13 = 0;
            return (PGCompany.BattlePass.BPLevelRewardsView)val_13;
        }
        private void 万丗丞丂丒世丁丟丟(int 一丆丈东万丙丞丕下, bool 与丑丑丑丂丛一丝一 = False, PGCompany.BattlePass.BPReward 丅丐业与丛世丐丐丞)
        {
            与丑丑丑丂丛一丝一 = 与丑丑丑丂丛一丝一;
            this._wrap.ScrollTo(丘丒丌下丕专且七专:  一丆丈东万丙丞丕下, 与丑丑丑丂丛一丝一:  与丑丑丑丂丛一丝一);
            this.七丙丅丘与丈丗三丌(丗七丟丈三不丕一三:  丅丐业与丛世丐丐丞);
        }
        public void U_ScrollToFirst()
        {
            this._wrap.ScrollTo(丘丒丌下丕专且七专:  0, 与丑丑丑丂丛一丝一:  true);
            this.丑与丗一丘下丆丐丅 = 0;
        }
        public void U_ScrollToLast()
        {
            if(this.丄丌专丈丗丆丆丈丗 == null)
            {
                    return;
            }
            
            this._wrap.ScrollTo(丘丒丌下丕专且七专:  this.丄丌专丈丗丆丆丈丗.Count - 1, 与丑丑丑丂丛一丝一:  true);
            this.丑与丗一丘下丆丐丅 = this.丄丌专丈丗丆丆丈丗.Count - 1;
        }
        public void ToChallanges()
        {
            var val_4;
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 3;
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  2);
        }
        public void Back()
        {
            var val_11;
            var val_12;
            var val_13;
            if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世() != 0)
            {
                    if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世().gameObject.activeSelf != false)
            {
                    PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世().Hide();
            }
            
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            val_11 = null;
            if(this.不一丐且丗专丙丈丞 == 4)
            {
                    val_12 = null;
                BattlePassRootUI.丂丑丌且丄丞丝七上 = 2;
                BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  2);
                return;
            }
            
            val_13 = null;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 3;
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  0);
            this.丑与丗一丘下丆丐丅 = 0;
        }
        public BattlePassMainUI()
        {
            this.丄丌专丈丗丆丆丈丗 = new System.Collections.Generic.List<丕丟丕丌丒丞世与丅>();
            this.丒丂丏且上丌下丙丙 = true;
            this.丑与丗一丘下丆丐丅 = 0;
        }
        private int 上丏世丛上丟不丄与()
        {
            int val_1 = this.丄丌专丈丗丆丆丈丗.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
