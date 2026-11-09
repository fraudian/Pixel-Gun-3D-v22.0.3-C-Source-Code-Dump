using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventGui : AbstractGameEventGui
    {
        // Fields
        private Rilisoft.AbstractGameEventView _mainView;
        private Rilisoft.GameEventInfoView _infoView;
        private Rilisoft.GameEventItemsView _rewardsView;
        private Rilisoft.GameEventItemsView _rewardsHistoryView;
        private UnityEngine.GameObject _progressObject;
        private UnityEngine.GameObject _touchBlocker;
        private UnityEngine.GameObject _bankHolder;
        private UnityEngine.GameObject _buttonGoToEventHub;
        private UnityEngine.GameObject _buttonNotificationOffers;
        private BonusPromotionsView bonusPromotionsView;
        private UnityEngine.GameObject CameraContainer;
        public Rilisoft.GameEventExtendedEventInfoView ExtendedInfoEventView;
        public Rilisoft.GameEventRewardView RewardView;
        private UnityEngine.Coroutine 不丒三丘丁下丗丂东;
        private bool 且丘丞专七丑丑丁一;
        
        // Properties
        internal bool 丈丝丗丄丐一下下下 { get; }
        private static string 东世丅丙丑丌丐丙业 { get; }
        private static string 丌丛丏丒丕丅一万万 { get; }
        private static string 三东丟丁万丟七且丕 { get; }
        
        // Methods
        internal bool 与丅七丏万丈丝丞丅()
        {
            if(this._touchBlocker != null)
            {
                    return this._touchBlocker.activeSelf;
            }
            
            return this._touchBlocker.activeSelf;
        }
        private static string 丝丗七丅丆丏丙世三()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2918");
        }
        private static string 一世不丅三丑丌丞丄()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2917");
        }
        private static string 丑丈且三万不下丕丗()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2913");
        }
        protected override void Awake()
        {
            this.Awake();
            this.丗丑丌不三丌丑丛东();
            if(this.bonusPromotionsView == 0)
            {
                    return;
            }
            
            this.bonusPromotionsView.且丏丗丌丌丄丕丅丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丛业丁不与丙且丕丙()));
            this.bonusPromotionsView.丒丗丑丁丙业丏丏与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::一丟丂丆下丛丐上上()));
        }
        public override void ShowWindow(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            if(与且专丈不万东一万 != null)
            {
                
            }
            else
            {
                    this.丌丟丄丟丛上丂丈丆(丂丞与丘丌丕上丑不:  true, 丐丛丏丙上丁世丛一:  false);
            }
        
        }
        public override void HideWindow()
        {
            this.Hide();
        }
        private void 丗丑丌不三丌丑丛东()
        {
            if(this.bonusPromotionsView == 0)
            {
                    return;
            }
            
            string[] val_2 = new string[2];
            val_2[0] = "source.bonuses.event_currence";
            val_2[1] = "promotion.content.eventcurrency";
            this.bonusPromotionsView.丝一丅下且一丟丒世(丐丑丒丕丐丟丐东与:  new TagSystem.丞丟一丅丐专三万不(东丌丕上丞万丌丙丑:  new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_2), 丟且丒专下丈七丗丕:  4));
        }
        public void HandleCoinsShop()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.Context.且丌三丙丙与与丝世() != null)
            {
                    string val_5 = this.Context.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
            }
        
        }
        private void 丕丛丌一业丁不丙业()
        {
            string val_6;
            var val_7;
            val_6 = StoreKitEventListener.丕上丆七丞七丐丘丞();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = StoreKitEventListener.丒丕丗丑丕且丌丁丂;
            if((System.Linq.Enumerable.Contains<System.String>(source:  val_6, value:  StoreKitEventListener.丕上丆七丞七丐丘丞())) == false)
            {
                    return;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丈丕丐东丏丈丐一丗(丄丒且东不丁丂三丛:  StoreKitEventListener.丕上丆七丞七丐丘丞());
        }
        protected override void Start()
        {
            var val_7;
            System.Func<UnityEngine.GameObject, System.Boolean> val_9;
            this.Start();
            val_7 = null;
            val_7 = null;
            val_9 = GameEventGui.<>c.<>9__27_0;
            if(val_9 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Boolean> val_2 = null;
                val_9 = val_2;
                val_2 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  GameEventGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventGui.<>c::下丏不丅三七世世丗(UnityEngine.GameObject 丂丈丛下丄专丅与三));
                GameEventGui.<>c.<>9__27_0 = val_9;
            }
            
            UnityEngine.GameObject val_3 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  this._bankHolder), predicate:  val_2);
            if(val_3 == 0)
            {
                    return;
            }
            
            UIButton val_5 = val_3.GetComponent<UIButton>();
            EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_5.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HandleCoinsShop"));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._infoView.add_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
            this.ExtendedInfoEventView.add_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
            if(this._rewardsHistoryView == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardsHistoryView.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this._infoView.remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
            this.ExtendedInfoEventView.remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(this.bonusPromotionsView != 0)
            {
                    this.bonusPromotionsView.丐丑丘七丄下丝丏丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丛业丁不与丙且丕丙()));
                this.bonusPromotionsView.东丅一丝丂三七专丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::一丟丂丆下丛丐上上()));
            }
            
            this._infoView.remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
            this.ExtendedInfoEventView.remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丏专丄丏丆不丕三丒()));
            StoreKitEventListener.丘东丒七业七专专业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丕丛丌一业丁不丙业()));
        }
        protected override void Update()
        {
            var val_7;
            this.Update();
            if((this._mainView & 1) == 0)
            {
                    if(this.ExtendedInfoEventView.gameObject.activeInHierarchy == false)
            {
                goto label_4;
            }
            
            }
            
            val_7 = 1;
            goto label_5;
            label_4:
            val_7 = this.丝世丅一丞丙丌世一().gameObject;
            label_5:
            this.丙丂丙三丝丆丌丄丗(丆丛丆丞下丅丂且丝:  val_7.activeInHierarchy);
        }
        private void 丙丂丙三丝丆丌丄丗(bool 丆丛丆丞下丅丂且丝)
        {
            if(this._touchBlocker.activeSelf ^ 丆丛丆丞下丅丂且丝 == false)
            {
                    return;
            }
            
            if(丆丛丆丞下丅丂且丝 != false)
            {
                    if(this.不丒三丘丁下丗丂东 != null)
            {
                    this.StopCoroutine(routine:  this.不丒三丘丁下丗丂东);
                this.不丒三丘丁下丗丂东 = 0;
            }
            
                this._touchBlocker.SetActive(value:  true);
                return;
            }
            
            if(this.不丒三丘丁下丗丂东 != null)
            {
                    return;
            }
            
            this.不丒三丘丁下丗丂东 = this.StartCoroutine(routine:  this.丈丈丟丛丂丞万丐丁());
        }
        private System.Collections.IEnumerator 丈丈丟丛丂丞万丐丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventGui.丛七一且一三业业丕();
        }
        private void 丏专丄丏丆不丕三丒()
        {
            this.丌丟丄丟丛上丂丈丆(丂丞与丘丌丕上丑不:  false, 丐丛丏丙上丁世丛一:  false);
        }
        private void 丆专丅丐丌三丑上三(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                goto label_0;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                goto label_2;
            }
            
            this.且丘丞专七丑丑丁一 = true;
            this.gameObject.SetActive(value:  false);
            return;
            label_0:
            if(this.且丘丞专七丑丑丁一 == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Rilisoft.AbstractGameEventView).__il2cppRuntimeField_208;
            label_2:
            mem2[0] = 0;
        }
        public override void SetContext(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            this.SetContext(与且专丈不万东一万:  与且专丈不万东一万);
            if(this.Context == null)
            {
                    return;
            }
            
            this.Context.七丏丟丈丞丌一丆丒(丏上一世一下丑丂三:  new System.Nullable<System.Boolean>() {HasValue = false});
            this.丌丟丄丟丛上丂丈丆(丂丞与丘丌丕上丑不:  true, 丐丛丏丙上丁世丛一:  false);
        }
        internal void 一丈丌且下丌七丟丂(bool 丛丅丘一丏丙且丌上)
        {
            var val_4;
            UnityEngine.GameObject val_5;
            var val_6;
            if(丛丅丘一丏丙且丌上 == false)
            {
                goto label_1;
            }
            
            if(PGCompany.EventHub.丗且丅丕丒丑丞一丙.业丐万东丕丗一丘与() == false)
            {
                goto label_2;
            }
            
            val_4 = PGCompany.EventHub.丗且丅丕丒丑丞一丙.丅专丞丝专丐与丂一();
            goto label_3;
            label_1:
            val_5 = this._buttonGoToEventHub;
            val_6 = 0;
            goto label_6;
            label_2:
            val_4 = 0;
            label_3:
            val_5 = this._buttonGoToEventHub;
            val_6 = val_4;
            label_6:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丞丙三丛专丌丞不丐(bool 丛丅丘一丏丙且丌上)
        {
            丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonNotificationOffers, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
        }
        internal void 丌丟丄丟丛上丂丈丆(bool 丂丞与丘丌丕上丑不 = True, bool 丐丛丏丙上丁世丛一 = False)
        {
            Rilisoft.AbstractGameEventView val_46;
            var val_47;
            Rilisoft.AbstractGameEventView val_48;
            var val_49;
            var val_50;
            System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData> val_52;
            var val_53;
            System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItem> val_55;
            val_46 = 丂丞与丘丌丕上丑不;
            if(this.Context == null)
            {
                goto label_1;
            }
            
            if(this._progressObject == 0)
            {
                goto label_4;
            }
            
            if(this.Context.不七丘丙不三丗业上() == null)
            {
                goto label_6;
            }
            
            var val_8 = (this.Context.不七丘丙不三丗业上().Count > 0) ? 1 : 0;
            goto label_10;
            label_1:
            UnityEngine.Debug.LogError(message:  "event not setted, please for first show use ShowEvent() method");
            return;
            label_6:
            val_47 = 1;
            label_10:
            this._progressObject.SetActive(value:  true);
            label_4:
            this.gameObject.SetActive(value:  true);
            this._mainView.gameObject.SetActive(value:  true);
            val_48 = this._mainView;
            if(val_48 != null)
            {
                    val_48 = 0;
            }
            
            bool val_11 = (val_48 == 0) ? 1 : 0;
            this.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  val_11);
            this.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  val_11);
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_14 = this.Context.不业丙丒丂丞下丆丙();
            }
            
            val_49 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_16 = val_49.业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false});
            if(val_16 != null)
            {
                    if(val_16.Count >= 1)
            {
                    val_50 = null;
                val_50 = null;
                val_52 = GameEventGui.<>c.<>9__41_1;
                if(val_52 == null)
            {
                    System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData> val_18 = null;
                val_52 = val_18;
                val_18 = new System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData>(object:  GameEventGui.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.GameEventItemData GameEventGui.<>c::丑丞丕丁世一丂丐世(Rilisoft.DroppedItemData 七丞丙丒三丕且丌丟));
                GameEventGui.<>c.<>9__41_1 = val_52;
            }
            
                this._rewardsView.SetItems(丑七不与丛丆一丂丞:  System.Linq.Enumerable.ToList<Rilisoft.GameEventItemData>(source:  System.Linq.Enumerable.Select<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData>(source:  val_16, selector:  val_18)), 丒丄丒丌上丂下专丑:  true);
                this._rewardsView.gameObject.SetActive(value:  true);
            }
            
                Rilisoft.丛且世丐丆上七业丁 val_23 = val_16.Item[0].丌丐东业专丑丘丑丗();
                val_53 = null;
                val_53 = null;
                val_55 = GameEventGui.<>c.<>9__41_0;
                if(val_55 == null)
            {
                    System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItem> val_24 = null;
                val_55 = val_24;
                val_24 = new System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItem>(object:  GameEventGui.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.GameEventItem GameEventGui.<>c::七丟丕丒丛丘丂且与(Rilisoft.DroppedItemData 七丞丙丒三丕且丌丟));
                GameEventGui.<>c.<>9__41_0 = val_55;
            }
            
                System.Collections.Generic.List<TSource> val_26 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItem>(source:  System.Linq.Enumerable.Select<Rilisoft.DroppedItemData, Rilisoft.GameEventItem>(source:  val_16, selector:  val_24));
                Rilisoft.DroppedItemData val_27 = val_16.Item[0];
                Rilisoft.DroppedItemData val_28 = val_16.Item[0];
                val_49 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
                val_49.专且丈丒世丘丅丝下(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false}, 丑七不与丛丆一丂丞:  0);
            }
            else
            {
                    this._rewardsView.gameObject.SetActive(value:  false);
            }
            
            this._infoView.gameObject.SetActive(value:  false);
            this.ExtendedInfoEventView.gameObject.SetActive(value:  false);
            if(val_46 == false)
            {
                    return;
            }
            
            if(this.Context != null)
            {
                    if(this.Context.丕丒丙七丘丈丙且丂() != false)
            {
                    label_65:
                this.Context.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  this.Context.不七丘丙不三丗业上());
            }
            else
            {
                    if(this.Context.下一三万丝丟丐丒丆() != false)
            {
                    if((this.Context.不七丘丙不三丗业上().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == true)
            {
                goto label_65;
            }
            
            }
            
            }
            
            }
            
            val_46 = this._mainView;
            Rilisoft.丛且世丐丆上七业丁 val_44 = this.Context;
            bool val_45 = 丐丛丏丙上丁世丛一;
        }
        public void Hide()
        {
            Rilisoft.GameEventGuiHandler.丆三丘丅且东万与丘();
        }
        public void ShowInfo()
        {
            this._mainView.gameObject.SetActive(value:  false);
            this._rewardsView.gameObject.SetActive(value:  false);
            this.ExtendedInfoEventView.gameObject.SetActive(value:  false);
            this._infoView.Show(丅东专与不三丂丁丝:  this.Context);
        }
        public void ShowCurrentEventInfo()
        {
            if(this.Context == null)
            {
                    return;
            }
            
            this.不世万丑且丗丒一万(丐下丝丘丑丟丟丗丌:  this.Context.且丌三丙丙与与丝世());
        }
        public void ShowCurrentEventInfo(int 丐东业丕丕丂丗丅丙)
        {
            Rilisoft.上专业三丟丁丞专下 val_10;
            .丐东业丕丕丂丗丅丙 = 丐东业丕丕丂丗丅丙;
            if(this.Context == null)
            {
                    return;
            }
            
            val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.Context.丄三丐丟丗丄丟上丞(), predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new GameEventGui.丈丞丕丘丄丐且丈丂(), method:  System.Boolean GameEventGui.丈丞丕丘丄丐且丈丂::不丗丌不三七丌丐世(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)));
            if(val_10 == null)
            {
                    val_10 = this.Context.丄三丐丟丗丄丟上丞().Item[0];
            }
            
            this.不世万丑且丗丒一万(丐下丝丘丑丟丟丗丌:  val_10);
        }
        public void ShowChildEventInfo()
        {
            if(this.Context == null)
            {
                    return;
            }
            
            bool val_3 = this.Context.下一三万丝丟丐丒丆();
            Rilisoft.丛且世丐丆上七业丁 val_4 = this.Context;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_3 == false)
            {
                goto label_4;
            }
            
            label_9:
            if((val_4.不七丘丙不三丗业上().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
            {
                goto label_6;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_8 = this.Context.不七丘丙不三丗业上();
            this = ???;
            goto typeof(Rilisoft.AbstractGameEventView).__il2cppRuntimeField_1E8;
            label_3:
            if(val_3 == true)
            {
                goto label_9;
            }
            
            label_4:
            Rilisoft.上专业三丟丁丞专下 val_15 = val_4.丄三丐丟丗丄丟上丞().Item[0];
            goto label_11;
            label_6:
            label_11:
            this.不世万丑且丗丒一万(丐下丝丘丑丟丟丗丌:  this.Context.不七丘丙不三丗业上());
        }
        public void ShowRewardsHistory()
        {
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemData>(source:  this.Context.丝丁丅丆丌丗丌丛丌().丒丄下丏专且丙丄丒());
            val_4.Reverse();
            this._rewardsHistoryView.SetItems(丑七不与丛丆一丂丞:  val_4, 丒丄丒丌上丂下专丑:  false);
            this._rewardsHistoryView.ShowAsReward(丌不丞丁七丂万上丏:  0);
            GameEventLastRewards val_6 = this._rewardsHistoryView.gameObject.GetComponent<GameEventLastRewards>();
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6.Setup(与且专丈不万东一万:  this.Context);
        }
        private void 不世万丑且丗丒一万(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            if((this._mainView & 1) != 0)
            {
                    return;
            }
            
            this._infoView.gameObject.SetActive(value:  false);
            this._rewardsView.gameObject.SetActive(value:  false);
            this.ExtendedInfoEventView.gameObject.SetActive(value:  true);
            this.ExtendedInfoEventView.Show(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丁丞丅上丝三丐丅丆:  false);
        }
        internal void 丈丄丗丐丒与东丏三(int 丐东业丕丕丂丗丅丙)
        {
            int val_14;
            var val_15;
            val_14 = 丐东业丕丕丂丗丅丙;
            val_15 = this;
            .丐东业丕丕丂丗丅丙 = val_14;
            if(this.Context == null)
            {
                    return;
            }
            
            val_14 = this.Context.丄三丐丟丗丄丟上丞();
            Rilisoft.上专业三丟丁丞专下 val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_14, predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new GameEventGui.三丂丝丆丆丈丅丟且(), method:  System.Boolean GameEventGui.三丂丝丆丆丈丅丟且::丝万丕丞万不不且丘(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)));
            if(val_6 == null)
            {
                    return;
            }
            
            this.Context.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  val_6);
            val_15 = ???;
            val_14 = ???;
            goto typeof(Rilisoft.GameEventGui).__il2cppRuntimeField_278;
        }
        public override void ShowBuyCurrencyGui(string 丏丂不专上丘丂不丅)
        {
            this.ShowBuyCurrencyGui(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅);
            this.丙丂丙三丝丆丌丄丗(丆丛丆丞下丅丂且丝:  true);
        }
        public void Spin()
        {
            goto typeof(Rilisoft.GameEventGui).__il2cppRuntimeField_278;
        }
        public override void Spin(int 下丅三丈世丐丕丌丑)
        {
            Rilisoft.GameEventGui val_52;
            int val_53;
            System.Nullable<Rilisoft.GameEventType> val_54;
            int val_55;
            var val_56;
            val_52 = this;
            GameEventGui.丛世且不丕丕东丒三 val_1 = new GameEventGui.丛世且不丕丕东丒三();
            if(val_1 != null)
            {
                    val_53 = val_1;
                .下丅三丈世丐丕丌丑 = 下丅三丈世丐丕丌丑;
                mem[1152921542716635312] = val_52;
            }
            else
            {
                    mem[16] = val_52;
                val_53 = 24;
                mem[24] = 下丅三丈世丐丕丌丑;
            }
            
            .丁丅丈丌丟世丗丗丟 = 0;
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_4 = this.Context.不业丙丒丂丞下丆丙();
                .丁丅丈丌丟世丗丗丟 = 0;
            }
            
            if(this.Context.且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛() != false)
            {
                    if((this.Context.且丌三丙丙与与丝世().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) != true)
            {
                    val_54 = this.Context.丂世上东丞且丏丝丗();
                if(val_54 < this.Context.不七丘丙不三丗业上().丂丙丐丆丝上万业世())
            {
                    return;
            }
            
            }
            
            }
            
            val_55 = 1152921505459986432;
            val_54 = (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丁丅丈丌丟世丗丗丟;
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_17 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = val_54});
            if(val_17 != null)
            {
                    if(val_17.Count > 0)
            {
                    return;
            }
            
            }
            
            val_54 = this.Context;
            if(val_54.且丌三丙丙与与丝世() == null)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  mem[24]);
            Rilisoft.丛且世丐丆上七业丁 val_22 = this.Context;
            .丅东专与不三丂丁丝 = val_22;
            .丌下专丅丟丛丒丑三 = val_22.且丌三丙丙与与丝世();
            mem[24] = UnityEngine.Mathf.Max(a:  1, b:  val_53);
            .丑万丌丂上业丏上世 = true;
            .丄丆丂下不丝东丂一 = false;
            .丏业丂七丈丆丛丏上 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  mem[24] * (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.丟丂丞不专丆万丒世(), 丏丂不专上丘丂不丅:  Rilisoft.丛且世丐丆上七业丁.丕万丑且上七世丛不(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七()));
            val_56 = 1152921504615739392;
            System.Action val_31 = null;
            val_54 = val_31;
            val_31 = new System.Action(object:  val_1, method:  System.Void GameEventGui.丛世且不丕丕东丒三::丝丗丛丟三丛丏丟丄());
            if((((GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false) || (mem[24] != 1))
            {
                goto label_33;
            }
            
            .丄丆丂下不丝东丂一 = mem[24];
            bool val_33 = (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false});
            if((GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.丐丏下丕三丒丗丅丛() != false)
            {
                    if(((GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.丐丏下丕三丒丗丅丛() == false) || ((GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丅东专与不三丂丁丝.丕丒丙七丘丈丙且丂() == true))
            {
                goto label_40;
            }
            
            }
            
            val_55 = (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三.业上丙丞丐丄丆丅七();
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().且下下丆丝丛丑丅丏(丐东业丕丕丂丗丅丙:  val_55, 丁丅丈丌丟世丗丗丟:  (val_33 != true) ? 0 : 10, 下丅三丈世丐丕丌丑:  -mem[24], 三丙世丒丙丘一丗上:  false);
            label_40:
            if(val_33 != false)
            {
                    .丑万丌丂上业丏上世 = false;
            }
            
            val_31.Invoke();
            .丏业丂七丈丆丛丏上 = 0;
            goto label_47;
            label_33:
            .丄丆丂下不丝东丂一 = false;
            if((this.丟丆丘丒丘三丙三与(下丅三丈世丐丕丌丑:  mem[24])) == true)
            {
                goto label_57;
            }
            
            StoreKitEventListener.下与上三业丝且丂丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventGui::丕丛丌一业丁不丙业()));
            .丑万丌丂上业丏上世 = true;
            string val_44 = Rilisoft.丛且世丐丆上七业丁.丕万丑且上七世丛不(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七());
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丏业丂七丈丆丛丏上, 七丒上且丝业业下七:  val_31, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void GameEventGui.丛世且不丕丕东丒三::丟丙丑丄不丑三专且()), 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  85);
            label_47:
            val_54 = mem[24];
            val_56 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_56.一业丝且丘丁专丆丕(丅丛下专丅丁一且东:  val_54, 丏业丂七丈丆丛丏上:  (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丏业丂七丈丆丛丏上, 丅东专与不三丂丁丝:  this.Context, 丌且丐专七丏与丟丌:  (GameEventGui.丛世且不丕丕东丒三)[1152921542716635296].丌下专丅丟丛丒丑三, 丞七丂丐丂丈丞上丑:  0);
            if(Rilisoft.丛且世丐丆上七业丁.专丕东不东丟丂丅丒 != null)
            {
                    Rilisoft.丛且世丐丆上七业丁.专丕东不东丟丂丅丒.Invoke(obj:  this.Context.不业丙丒丂丞下丆丙());
            }
            
            label_57:
            val_52 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_52.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private System.Collections.IEnumerator 世丛万丆丑丌不东丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventGui.丕且七七下丑且丌不();
        }
        private void 丟丛业丂丅丂丝丘万()
        {
            Rilisoft.GameEventGui val_14;
            System.Nullable<Rilisoft.GameEventType> val_15;
            val_14 = this;
            GameEventGui.丛丄丁业且世丝丂丅 val_1 = new GameEventGui.丛丄丁业且世丝丂丅();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = val_14;
            }
            else
            {
                    mem[32] = val_14;
            }
            
            .丁丅丈丌丟世丗丗丟 = 0;
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_4 = this.Context.不业丙丒丂丞下丆丙();
                .丁丅丈丌丟世丗丗丟 = 0;
            }
            
            val_15 = (GameEventGui.丛丄丁业且世丝丂丅)[1152921542717097888].丁丅丈丌丟世丗丗丟;
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = val_15});
            .丕丌丏丒丟丁世丒丅 = val_6;
            if(val_6 == null)
            {
                    return;
            }
            
            if(this.Context.丕丒丙七丘丈丙且丂() != false)
            {
                    val_15 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
                val_15.专且丈丒世丘丅丝下(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = (GameEventGui.丛丄丁业且世丝丂丅)[1152921542717097888].丁丅丈丌丟世丗丗丟}, 丑七不与丛丆一丂丞:  0);
                this.丂丈世丞丂丐世丙上();
                return;
            }
            
            val_15 = this._mainView;
            System.Action val_10 = new System.Action(object:  val_1, method:  System.Void GameEventGui.丛丄丁业且世丝丂丅::东丛丏丄丆丐业东丁());
            val_14 = this.Context.丂世上东丞且丏丝丗();
            var val_13 = (val_14 != 0) ? 1 : 0;
        }
        private void 丂丈世丞丂丐世丙上()
        {
            var val_23;
            if(this._progressObject != 0)
            {
                    if(this.Context.不七丘丙不三丗业上() != null)
            {
                    var val_7 = (this.Context.不七丘丙不三丗业上().Count > 0) ? 1 : 0;
            }
            else
            {
                    val_23 = 0;
            }
            
                this._progressObject.SetActive(value:  false);
            }
            
            if(this.Context.不七丘丙不三丗业上() != null)
            {
                    if(this.Context.丂世上东丞且丏丝丗() >= this.Context.不七丘丙不三丗业上().丂丙丐丆丝上万业世())
            {
                    if(this.Context.不七丘丙不三丗业上().Count < 1)
            {
                goto label_30;
            }
            
                this.gameObject.SetActive(value:  true);
                this._mainView.gameObject.SetActive(value:  true);
                this._infoView.gameObject.SetActive(value:  false);
                this._rewardsView.gameObject.SetActive(value:  false);
                this.ExtendedInfoEventView.gameObject.SetActive(value:  false);
            }
            
            }
            
            label_30:
            this.丌丟丄丟丛上丂丈丆(丂丞与丘丌丕上丑不:  true, 丐丛丏丙上丁世丛一:  true);
        }
        internal override void BackRequest()
        {
            if(this._touchBlocker.activeSelf != false)
            {
                    UnityEngine.Debug.LogError(message:  "BackRequest fail, _touchBlocker.activeSelf");
                return;
            }
            
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丅万丙丛丅一业不且();
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丘东丐业丅上东丏下(不七丆万丁一丞七下:  208)) != false)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.丝东丐丝东三丈世丝();
        }
        internal override void 不一丒丁丗上丗上世(object 丙丈下丕丑专上丕丛)
        {
            PGCompany.丁七丛丑丄丄丂东世.丞上一丈丘丞三丞三(丙丈下丕丑专上丕丛:  丙丈下丕丑专上丕丛, 丆丏七丟不丒与七专:  this.transform);
        }
        private void 一丟丂丆下丛丐上上()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CameraContainer, 丏业丟一东丂东丘丛:  true);
        }
        private void 丛业丁不与丙且丕丙()
        {
            if(this.bonusPromotionsView.SelectedPromotion != null)
            {
                    PGCompany.Analytics.一业丗丆世世上丁且.东上丗东不丈东丑丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 世丁丙世丄一万丆三:  "three_chests", 丐丆丝业丙丈下世丁:  this.bonusPromotionsView.SelectedPromotion);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CameraContainer, 丏业丟一东丂东丘丛:  false);
        }
        public void U_GoToEventHub()
        {
            PGCompany.丌不丞丐世丞三丘丌 val_1 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_1 != null)
            {
                    .Type = 21;
            }
            else
            {
                    mem[16] = 21;
            }
            
            .丄世丌东丏三东丒丂 = 3;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1)) == null)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        public GameEventGui()
        {
        
        }
    
    }

}
