using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyController : MonoBehaviour
    {
        // Fields
        private const string 丕丁业丒丐一丅万丞 = "offerwall";
        private const string 丂世丝丘丑丝下一丈 = "battlepass";
        private static int 专世丙上丒世丏丁三;
        private readonly System.Collections.Generic.Dictionary<string, Rilisoft.InAppBonusLobbyButtonView> 丌三七丕丘丆不且业;
        private readonly System.Collections.Generic.Dictionary<string, Rilisoft.InAppBonusLobbyScrollView> 丕丏丑丐业丛世一丟;
        private readonly System.Collections.Generic.Dictionary<string, Rilisoft.InAppBonusLobbyTopView> 丅不万丐丆且丛丅七;
        private Rilisoft.丘丏专世丘丒丆七一 世一丛且丁东业世丙;
        private Rilisoft.丘丏专世丘丒丆七一 下不丄丅丑丁上不丌;
        private Rilisoft.丟上业世丞丑丛丏与 丕丆与七丙丑东不丐;
        private Rilisoft.丘丏专世丘丒丆七一 丄丏且丙七丙上不丒;
        private Rilisoft.丘丏专世丘丒丆七一 东下万丁业丒丐专不;
        private Rilisoft.丘丏专世丘丒丆七一 世下不丟世七丂且丙;
        private Rilisoft.丘丏专世丘丒丆七一 丆丑下丒下丟世三丂;
        private Rilisoft.丘丏专世丘丒丆七一 丟下且上下丂丙丈丅;
        private Rilisoft.丘丏专世丘丒丆七一 东丕丌丆丒丕三丂七;
        private Rilisoft.丘丏专世丘丒丆七一 丟丂与且世丌与一丂;
        private Rilisoft.丑丞一丁丕丌丅丄上 丗丌世丂世丅丂丏丄;
        private Rilisoft.丘丏专世丘丒丆七一 丕丝万且丆丝丘世丈;
        private Rilisoft.丗丝丐丗且丕与七业 丏丌丝丄专丝世丘三;
        private Rilisoft.丈一且丄与丆丆上东 丟丏丙丙丕丄万丛万;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丟东丘丌丘丄丆上丏;
        private UICenterOnChild _centerOnChild;
        private bool 与丒丕丁下世东丅丌;
        private UnityEngine.GameObject _frameObj;
        private System.Collections.Generic.List<GameEventPlayerGot> _gotNotifications;
        private bool 七丛丙丏丗丏丁东丌;
        private Rilisoft.PrefabHandler _leftButtonViewPrefabHandler;
        private Rilisoft.BasicGrid _leftGrid;
        private float 丆世三丅万三丒丘丐;
        private float 世与万丗丒专丂丈丙;
        private float 丘不丂上丄上丁丙不;
        private float _rotateDelay;
        private float 下万丄七丏丝丗丘丅;
        private UIScrollView _scroll;
        private UnityEngine.Vector3 丆一七丛专一且专东;
        private Rilisoft.PrefabHandler _scrollViewPrefabHandler;
        private UIWrapContent _scrollViewsRoot;
        private Rilisoft.PrefabHandler _topButtonViewPrefabHandler;
        private Rilisoft.BasicGrid _topGrid;
        private bool 七一丂丝丕丝丄东丏;
        private static Rilisoft.InAppBonusLobbyController <不丁丄七丛不丆丁丕>k__BackingField;
        private System.EventHandler<Rilisoft.万丈丁丞丆丁丕丕丐> 丛三且东万丝丐且丛;
        
        // Properties
        internal static Rilisoft.InAppBonusLobbyController 丆丕丝丒不丙且丐丗 { get; set; }
        public bool 三不专丗七丄且丝业 { get; set; }
        public bool 业丑丂不丞丝丟丟丛 { get; }
        internal float 上丂丆丂丈七丏上丒 { get; }
        
        // Methods
        internal static Rilisoft.InAppBonusLobbyController 丑七不且上丗丁一世()
        {
            return (Rilisoft.InAppBonusLobbyController)Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.InAppBonusLobbyController 丙业与丙丗丝不丈东)
        {
            Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_Enabled()
        {
            return (bool)this.与丒丕丁下世东丅丌;
        }
        public void set_Enabled(bool 丙业与丙丗丝不丈东)
        {
            float val_30;
            var val_1 = (this.与丒丕丁下世东丅丌 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            if(丙业与丙丗丝不丈东 != false)
            {
                    this._centerOnChild.CenterOn(丞下万上三丘上与专:  0);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                this._scroll.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                this._leftGrid.transform.parent.gameObject.SetActive(value:  true);
                this._topGrid.transform.parent.gameObject.SetActive(value:  true);
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                this._scroll.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
                this._scroll.gameObject.GetComponent<UIPanel>().clipOffset = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
                val_30 = val_19.x;
                this._scrollViewsRoot.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_19.y, z = val_19.z};
                this.丄不丕丛丌丞三东丁();
                this._scroll.ResetPosition();
                this._leftGrid.UpdatePositions();
                this._topGrid.UpdatePositions();
            }
            else
            {
                    UnityEngine.Vector3 val_21 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  10000f);
                val_30 = val_22.x;
                this._scroll.transform.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_22.y, z = val_22.z};
                this._leftGrid.transform.parent.gameObject.SetActive(value:  false);
                this._topGrid.transform.parent.gameObject.SetActive(value:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._frameObj, 丏业丟一东丂东丘丛:  false);
            this.与丒丕丁下世东丅丌 = 丙业与丙丗丝不丈东;
        }
        public bool get_CanShowEventNotification()
        {
            var val_3;
            if(this.丕丏丑丐业丛世一丟.Count >= 2)
            {
                    var val_2 = (this.下万丄七丏丝丗丘丅 > 4f) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        internal float 东丁丗丁丕万丝世世()
        {
            return (float)this.下万丄七丏丝丗丘丅;
        }
        private void Awake()
        {
            Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        }
        private void Start()
        {
            var val_14;
            var val_15;
            System.Func<System.Boolean> val_17;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "action", value:  "multiplier");
            }
            else
            {
                    val_1.Add(key:  "action", value:  "multiplier");
            }
            
            val_1.Add(key:  "Type", value:  "multiplier");
            val_1.Add(key:  "Key", value:  "multiplier");
            val_1.Add(key:  "isOffer", value:  true);
            val_1.Add(key:  "Profit", value:  10);
            val_14 = 0;
            val_1.Add(key:  "EndTime", value:  丅且东丙业丏丛东丛.丑七不且上丗丁一世().丛丏丆东丙丁丅丛丐());
            val_15 = null;
            val_15 = null;
            val_17 = InAppBonusLobbyController.<>c.<>9__52_0;
            if(val_17 == null)
            {
                    System.Func<System.Boolean> val_8 = null;
                val_17 = val_8;
                val_8 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丌丒一丝丂丙丞丌丙());
                InAppBonusLobbyController.<>c.<>9__52_0 = val_17;
            }
            
            this.丏丌丝丄专丝世丘三 = new Rilisoft.丗丝丐丗且丕与七业(丂丈丗丄不丅丅丙丒:  val_1, 丒丗一丏东与丒丐丆:  val_8);
            UnityEngine.Vector3 val_11 = this._scroll.transform.localPosition;
            this.丆一七丛专一且专东 = val_11;
            mem[1152921542987802004] = val_11.y;
            mem[1152921542987802008] = val_11.z;
            BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyController::上且万专一东东东不()));
            丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyController::丞不丅专不丈世丆丌()));
        }
        private void 上且万专一东东东不()
        {
            this.丆世三丅万三丒丘丐 = 0f;
        }
        private void OnEnable()
        {
            if(this.与丒丕丁下世东丅丌 == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this._scroll.GetComponent<UIPanel>().clipOffset = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector3 val_7 = this._scroll.gameObject.transform.localPosition;
            UnityEngine.Vector3 val_10 = this._scroll.gameObject.transform.localPosition;
            this._scroll.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._leftGrid.transform.parent.gameObject.SetActive(value:  true);
            this = this._topGrid.transform.parent.gameObject;
            this.SetActive(value:  true);
        }
        public Rilisoft.InAppBonusLobbyViewBase GetScrollViewForEvent(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            var val_4;
            var val_8;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丕丏丑丐业丛世一丟.GetEnumerator();
            label_8:
            if(((-273187392) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            Rilisoft.BonusData val_6 = val_5._value._obj.Data;
            if(val_6.Type != 6)
            {
                goto label_8;
            }
            
            Rilisoft.BonusData val_7 = val_5._value._obj.Data;
            if(val_7.GameEvent != 丅东专与不三丂丁丝)
            {
                goto label_8;
            }
            
            val_8;
            goto label_9;
            label_2:
            val_8 = 0;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.InAppBonusLobbyViewBase)val_8;
        }
        public Rilisoft.InAppBonusLobbyViewBase GetTopViewForEvent(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            var val_4;
            var val_8;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丅不万丐丆且丛丅七.GetEnumerator();
            label_8:
            if(((-273021120) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            Rilisoft.BonusData val_6 = val_5._value._obj.Data;
            if(val_6.Type != 6)
            {
                goto label_8;
            }
            
            Rilisoft.BonusData val_7 = val_5._value._obj.Data;
            if(val_7.GameEvent != 丅东专与不三丂丁丝)
            {
                goto label_8;
            }
            
            val_8;
            goto label_9;
            label_2:
            val_8 = 0;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.InAppBonusLobbyViewBase)val_8;
        }
        internal void 丁丞丟丏七丑世丙丑(System.EventHandler<Rilisoft.万丈丁丞丆丁丕丕丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛三且东万丝丐且丛, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛三且东万丝丐且丛 != this.丛三且东万丝丐且丛);
        
        }
        internal void 与业上三且上丅一一(System.EventHandler<Rilisoft.万丈丁丞丆丁丕丕丐> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛三且东万丝丐且丛, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛三且东万丝丐且丛 != this.丛三且东万丝丐且丛);
        
        }
        private void Update()
        {
            if(this.与丒丕丁下世东丅丌 == false)
            {
                    return;
            }
            
            this.丞不丅专不丈世丆丌();
        }
        private void 丞不丅专不丈世丆丌()
        {
            float val_15;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_16;
            val_15 = this.下万丄七丏丝丗丘丅 - UnityEngine.Time.deltaTime;
            this.下万丄七丏丝丗丘丅 = val_15;
            if(val_15 <= 0f)
            {
                    this.下万丄七丏丝丗丘丅 = this._rotateDelay;
                val_15 = this.世与万丗丒专丂丈丙;
                if((UnityEngine.Mathf.Approximately(a:  val_15, b:  0f)) != false)
            {
                    this.丕与不丙不且丏丐丛();
            }
            
            }
            
            UnityEngine.Vector3 val_4 = this._scroll.transform.localPosition;
            val_4.x = val_4.x - this.丘不丂上丄上丁丙不;
            this.世与万丗丒专丂丈丙 = System.Math.Abs(val_4.x);
            UnityEngine.Vector3 val_6 = this._scroll.transform.localPosition;
            this.丘不丂上丄上丁丙不 = val_6.x;
            float val_7 = UnityEngine.Time.deltaTime;
            val_7 = this.丆世三丅万三丒丘丐 - val_7;
            this.丆世三丅万三丒丘丐 = val_7;
            if(FriendsController.丝丗专上三不丄丑丑() <= 0)
            {
                goto label_13;
            }
            
            int val_9 = UnityEngine.Time.frameCount;
            if(0 != 0)
            {
                    return;
            }
            
            if(this.丆世三丅万三丒丘丐 > 0f)
            {
                goto label_43;
            }
            
            this.丆世三丅万三丒丘丐 = 1f;
            if(this.丟东丘丌丘丄丆上丏 == null)
            {
                goto label_16;
            }
            
            this.丟东丘丌丘丄丆上丏.Clear();
            val_16 = this.丟东丘丌丘丄丆上丏;
            goto label_17;
            label_13:
            if(this.丟东丘丌丘丄丆上丏 == null)
            {
                goto label_18;
            }
            
            this.丟东丘丌丘丄丆上丏.Clear();
            goto label_43;
            label_18:
            this.丟东丘丌丘丄丆上丏 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            goto label_43;
            label_16:
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_11 = null;
            val_16 = val_11;
            val_11 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丟东丘丌丘丄丆上丏 = val_16;
            label_17:
            this.下不丄丅丑丁上不丌.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  val_11);
            this.东下万丁业丒丐专不.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.世下不丟世七丂且丙.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丟下且上下丂丙丈丅.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丟丂与且世丌与一丂.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丏丌丝丄专丝世丘三.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丄丏且丙七丙上不丒.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丕丝万且丆丝丘世丈.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.世一丛且丁东业世丙.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丟丏丙丙丕丄万丛万.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            this.丆丑下丒下丟世三丂.下丈丂丟丐业丟丂丁(与万丁丈与且丁三丁:  this.丟东丘丌丘丄丆上丏);
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_12 = BalanceController.下丂万丐丄丅七一东();
            if(val_12 == null)
            {
                goto label_43;
            }
            
            List.Enumerator<T> val_13 = val_12.GetEnumerator();
            label_39:
            if(((-272356024) & 1) == 0)
            {
                goto label_36;
            }
            
            string val_14 = 0.丐丏七丌丕丗业且上();
            if(val_14 == null)
            {
                goto label_39;
            }
            
            this.丟东丘丌丘丄丆上丏.Add(item:  val_14);
            goto label_39;
            label_36:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_43:
            this.丄不丕丛丌丞三东丁();
        }
        private void OnDestroy()
        {
            BattlePassController.业丏专与丝不东丁一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyController::上且万专一东东东不()));
            丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyController::丞不丅专不丈世丆丌()));
            Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 不丆东丐上丙丛七丕()
        {
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = this.丟东丘丌丘丄丆上丏;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丟东丘丌丘丄丆上丏 = val_2;
            return val_2;
        }
        internal static void 丝上丌丂七东东与丈()
        {
            int val_1 = Rilisoft.InAppBonusLobbyController.专世丙上丒世丏丁三;
            val_1 = val_1 + 1;
            Rilisoft.InAppBonusLobbyController.专世丙上丒世丏丁三 = val_1;
        }
        private void 丄不丕丛丌丞三东丁()
        {
            var val_7;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_57;
            var val_58;
            string val_59;
            var val_60;
            string val_61;
            string val_62;
            string val_63;
            string val_64;
            string val_65;
            string val_66;
            string val_67;
            var val_68;
            string val_69;
            string val_70;
            System.Collections.Generic.List<T> val_71;
            Rilisoft.BasicGrid val_74;
            var val_76;
            if(this.丟东丘丌丘丄丆上丏 == null)
            {
                goto label_1;
            }
            
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            val_57 = this.丟东丘丌丘丄丆上丏;
            List.Enumerator<T> val_5 = val_57.GetEnumerator();
            label_55:
            if(((-271627536) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if((val_8 == null) || ((val_8.ContainsKey(key:  "Type")) == false))
            {
                goto label_55;
            }
            
            val_58 = 1152921516622706448;
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_59 = 0;
            }
            
            if((System.String.op_Equality(a:  val_59, b:  "gameEvent")) == false)
            {
                goto label_8;
            }
            
            if(PGCompany.丁东丌世与丕东丆上.丗不上丒丙七丆丏东() == false)
            {
                goto label_11;
            }
            
            val_58 = 1152921516622706448;
            val_1.Add(item:  val_8);
            val_60 = 1;
            goto label_13;
            label_11:
            val_58 = 1152921516622706448;
            label_8:
            val_60 = 0;
            label_13:
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_61 = 0;
            }
            
            if((System.String.op_Equality(a:  val_61, b:  "vipInSeconds")) == true)
            {
                goto label_24;
            }
            
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_62 = 0;
            }
            
            if((System.String.op_Equality(a:  val_62, b:  "recomendation")) == true)
            {
                goto label_24;
            }
            
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_63 = 0;
            }
            
            if((System.String.op_Equality(a:  val_63, b:  "offerwall")) == false)
            {
                goto label_22;
            }
            
            val_58 = 1152921516622706448;
            if(PGCompany.OfferwallController.丑七不且上丗丁一世().丞一丕一不丑丐丆丁() == true)
            {
                goto label_24;
            }
            
            label_22:
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_64 = 0;
            }
            
            if((System.String.op_Equality(a:  val_64, b:  "EventStore")) == false)
            {
                goto label_27;
            }
            
            label_24:
            val_1.Add(item:  val_8);
            val_60 = 1;
            label_27:
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_65 = 0;
            }
            
            if((System.String.op_Equality(a:  val_65, b:  "gameEvent")) == true)
            {
                goto label_46;
            }
            
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_66 = 0;
            }
            
            if((System.String.op_Equality(a:  val_66, b:  "vipInSeconds")) == false)
            {
                goto label_34;
            }
            
            label_46:
            val_3.Add(item:  val_8);
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_67 = 0;
            }
            
            if((System.String.op_Equality(a:  val_67, b:  "gameEvent")) == false)
            {
                goto label_44;
            }
            
            val_4.Add(item:  val_8);
            goto label_44;
            label_34:
            string val_56 = "Type";
            object val_37 = val_8.Item[val_56];
            val_68 = "offerwall";
            if("offerwall" == null)
            {
                    val_68 = "offerwall";
            }
            
            if(val_37 != null)
            {
                    val_56 = (null == null) ? (val_37) : 0;
            }
            else
            {
                    val_69 = 0;
            }
            
            if((Equals(value:  val_69)) != false)
            {
                    if(PGCompany.OfferwallController.丑七不且上丗丁一世().东丘专丒丅业三丈世() == true)
            {
                goto label_46;
            }
            
            }
            
            label_44:
            if((val_60 & 1) != 0)
            {
                goto label_55;
            }
            
            if((val_8.Item["Type"] != null) && (null != null))
            {
                    val_70 = 0;
            }
            
            if(((System.String.op_Inequality(a:  val_70, b:  "offerwall")) == false) || ((PGCompany.丁东丌世与丕东丆上.丗一一丂万业一丛丗(丂丈丗丄不丅丅丙丒:  val_8)) == false))
            {
                goto label_55;
            }
            
            val_2.Add(item:  val_8);
            goto label_55;
            label_1:
            val_71 = 0;
            goto label_56;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.七丛丙丏丗丏丁东丌 != false)
            {
                    this.七丛丙丏丗丏丁东丌 = false;
            }
            
            val_1.Sort(comparison:  new System.Comparison<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Int32 Rilisoft.InAppBonusLobbyController::丂且七一不丌世与丅(System.Collections.Generic.Dictionary<string, object> 丏丆丑丗七丄丙丝与, System.Collections.Generic.Dictionary<string, object> 丒丈丙丐丏丕丆万丗)));
            val_74 = this._leftGrid;
            int val_46 = val_74.MaxVerticalCells;
            Rilisoft.InAppBonusLobbyController.丆且丟三七丈丏丅丆(一丐丗丁丞丆丅丟丄:  val_2, 丕业丞东丗不专且东:  0);
            if((System.Linq.Enumerable.Count<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_4)) < 1)
            {
                goto label_130;
            }
            
            List.Enumerator<T> val_48 = val_4.GetEnumerator();
            label_118:
            if(((-271627536) & 1) == 0)
            {
                goto label_112;
            }
            
            string val_49 = val_7.丐丏七丌丕丗业且上();
            if((val_49 == null) || ((val_3.IndexOf(item:  val_49)) == 0))
            {
                goto label_118;
            }
            
            bool val_51 = val_3.Remove(item:  val_49);
            val_3.Insert(index:  0, item:  val_49);
            goto label_118;
            label_112:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_57 = 1152921505463234560;
            val_76 = null;
            val_76 = null;
            val_74 = InAppBonusLobbyController.<>c.<>9__65_0;
            if(val_74 == null)
            {
                    System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_52 = null;
                val_74 = val_52;
                val_52 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丙丐业丗下三丂一丄(System.Collections.Generic.Dictionary<string, object> 丌丗丏丏丛东专丁且));
                InAppBonusLobbyController.<>c.<>9__65_0 = val_74;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_53 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_4, predicate:  val_52);
            if(val_53 != null)
            {
                    if(val_3 != null)
            {
                    bool val_54 = val_3.Remove(item:  val_53);
            }
            else
            {
                    bool val_55 = val_3.Remove(item:  val_53);
            }
            
                val_3.Insert(index:  0, item:  val_53);
            }
            
            label_130:
            val_71 = val_2;
            label_56:
            this.丁丈与上业丟丂东丁(丑上与且丏专万丝专:  val_2);
        }
        private static void 丆且丟三七丈丏丅丆(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 一丐丗丁丞丆丅丟丄, int 丕业丞东丗不专且东)
        {
            一丐丗丁丞丆丅丟丄.Sort(comparison:  new System.Comparison<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Int32 Rilisoft.InAppBonusLobbyController::上世丐一丆不东丙世(System.Collections.Generic.Dictionary<string, object> 丏丆丑丗七丄丙丝与, System.Collections.Generic.Dictionary<string, object> 丒丈丙丐丏丕丆万丗)));
        }
        private static int 丂且七一不丌世与丅(System.Collections.Generic.Dictionary<string, object> 丏丆丑丗七丄丙丝与, System.Collections.Generic.Dictionary<string, object> 丒丈丙丐丏丕丆万丗)
        {
            var val_11;
            var val_14;
            if((丒丈丙丐丏丕丆万丗 == null) || (丏丆丑丗七丄丙丝与 == null))
            {
                goto label_2;
            }
            
            val_11 = "Type";
            if((丏丆丑丗七丄丙丝与.ContainsKey(key:  "Type")) == false)
            {
                goto label_4;
            }
            
            if((丒丈丙丐丏丕丆万丗.ContainsKey(key:  "Type")) == false)
            {
                goto label_5;
            }
            
            int val_5 = Rilisoft.InAppBonusLobbyController.丟丟丑业世上丞专东(丆丙丅丝七丒丐丙万:  (null == null) ? 丏丆丑丗七丄丙丝与.Item["Type"] : 0);
            int val_8 = Rilisoft.InAppBonusLobbyController.丟丟丑业世上丞专东(丆丙丅丝七丒丐丙万:  (null == null) ? 丒丈丙丐丏丕丆万丗.Item["Type"] : 0);
            if(val_5 != val_8)
            {
                    return (int)(val_5 <= val_8) ? (-1) : 1;
            }
            
            val_14 = 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_2:
            var val_9 = (丏丆丑丗七丄丙丝与 == 0) ? (-0) : 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_4:
            val_14 = 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_5:
            val_14 = 1;
            return (int)(val_5 <= val_8) ? (-1) : 1;
        }
        private static int 上世丐一丆不东丙世(System.Collections.Generic.Dictionary<string, object> 丏丆丑丗七丄丙丝与, System.Collections.Generic.Dictionary<string, object> 丒丈丙丐丏丕丆万丗)
        {
            var val_11;
            var val_14;
            if((丒丈丙丐丏丕丆万丗 == null) || (丏丆丑丗七丄丙丝与 == null))
            {
                goto label_2;
            }
            
            val_11 = "Type";
            if((丏丆丑丗七丄丙丝与.ContainsKey(key:  "Type")) == false)
            {
                goto label_4;
            }
            
            if((丒丈丙丐丏丕丆万丗.ContainsKey(key:  "Type")) == false)
            {
                goto label_5;
            }
            
            int val_5 = Rilisoft.InAppBonusLobbyController.丟丟丑业世上丞专东(丆丙丅丝七丒丐丙万:  (null == null) ? 丏丆丑丗七丄丙丝与.Item["Type"] : 0);
            int val_8 = Rilisoft.InAppBonusLobbyController.丟丟丑业世上丞专东(丆丙丅丝七丒丐丙万:  (null == null) ? 丒丈丙丐丏丕丆万丗.Item["Type"] : 0);
            if(val_5 != val_8)
            {
                    return (int)(val_5 <= val_8) ? (-1) : 1;
            }
            
            val_14 = 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_2:
            var val_9 = (丏丆丑丗七丄丙丝与 == 0) ? (-0) : 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_4:
            val_14 = 1;
            return (int)(val_5 <= val_8) ? (-1) : 1;
            label_5:
            val_14 = 0;
            return (int)(val_5 <= val_8) ? (-1) : 1;
        }
        private static int 丟丟丑业世上丞专东(string 丆丙丅丝七丒丐丙万)
        {
            var val_17;
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "offerwall")) != false)
            {
                    return PGCompany.OfferwallController.丙下丅七万丐与丌丁();
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "battlepass")) != false)
            {
                    val_17 = 5;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "gameEvent")) != false)
            {
                    val_17 = 20;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "vipInSeconds")) != false)
            {
                    val_17 = 10;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recomendation")) != false)
            {
                    val_17 = 30;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-clan")) != false)
            {
                    val_17 = 80;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-duel")) != false)
            {
                    val_17 = 85;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "multiplier")) != false)
            {
                    val_17 = 90;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "update-info")) != false)
            {
                    val_17 = 99;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "vipInSeconds")) != false)
            {
                    val_17 = 109;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "offerwall")) != false)
            {
                    val_17 = 119;
                return (int)val_17;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recomendation")) != true)
            {
                    if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-characters")) == false)
            {
                goto label_23;
            }
            
            }
            
            val_17 = 129;
            return (int)val_17;
            label_23:
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-clan")) != false)
            {
                    return (int)val_17;
            }
            
            var val_16 = ((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-duel")) != true) ? 149 : 2147483647;
            return (int)val_17;
        }
        private static int 丏丒丛与丁丏专丆丈(string 丆丙丅丝七丒丐丙万)
        {
            var val_5;
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "multiplier")) != false)
            {
                    val_5 = 10;
                return (int)((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "offer")) != true) ? 30 : 100;
            }
            
            if((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "recommend-lobby-bundles")) == false)
            {
                    return (int)((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "offer")) != true) ? 30 : 100;
            }
            
            val_5 = 20;
            return (int)((System.String.op_Equality(a:  丆丙丅丝七丒丐丙万, b:  "offer")) != true) ? 30 : 100;
        }
        private void 丘丕不且丌丙丞一一(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丑上与且丏专万丝专)
        {
        
        }
        internal Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丂丆丙丞丑丅专专业()
        {
            if((this.丌三七丕丘丆不且业.ContainsKey(key:  "offers-button")) == false)
            {
                    return 0;
            }
            
            this = this.丌三七丕丘丆不且业.Item["offers-button"].gameObject.GetComponent<Rilisoft.InAppBonusLobbyButtonCollectionManager>();
            if(this == 0)
            {
                    return 0;
            }
            
            if(this != null)
            {
                    return this.丅丁一丙丆丁一丛丗();
            }
            
            return this.丅丁一丙丆丁一丛丗();
        }
        private void 丁丈与上业丟丂东丁(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丑上与且丏专万丝专)
        {
            var val_25;
            System.Collections.Generic.IEnumerable<TSource> val_81;
            Rilisoft.BasicGrid val_82;
            UnityEngine.Object val_83;
            var val_84;
            System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_86;
            System.Collections.Generic.IEnumerable<TSource> val_87;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.InAppBonusLobbyButtonView> val_89;
            var val_92;
            val_81 = 丑上与且丏专万丝专;
            val_82 = this;
            string val_43 = 0;
            if(val_81 == null)
            {
                    System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = null;
                val_81 = val_1;
                val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            }
            
            val_83 = 1152921505463234560;
            val_84 = null;
            val_84 = null;
            val_86 = InAppBonusLobbyController.<>c.<>9__73_0;
            if(val_86 == null)
            {
                    System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_2 = null;
                val_86 = val_2;
                val_2 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丑丆且丟丏万三不丁(System.Collections.Generic.Dictionary<string, object> 丌丗丏丏丛东专丁且));
                InAppBonusLobbyController.<>c.<>9__73_0 = val_86;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_1, predicate:  val_2);
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Except<System.Collections.Generic.Dictionary<System.String, System.Object>>(first:  val_1, second:  val_3));
            System.Collections.Generic.List<System.String> val_6 = null;
            val_87 = val_6;
            val_6 = new System.Collections.Generic.List<System.String>();
            if((System.Linq.Enumerable.Any<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_3)) == false)
            {
                goto label_7;
            }
            
            if((this.丌三七丕丘丆不且业.ContainsKey(key:  "offers-button")) == false)
            {
                goto label_9;
            }
            
            Rilisoft.InAppBonusLobbyButtonCollectionManager val_11 = this.丌三七丕丘丆不且业.Item["offers-button"].gameObject.GetComponent<Rilisoft.InAppBonusLobbyButtonCollectionManager>();
            goto label_13;
            label_9:
            UnityEngine.GameObject val_15 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._leftButtonViewPrefabHandler.Prefab, 丈东丘丏与丌东东下:  this._leftGrid.gameObject.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_89 = this.丌三七丕丘丆不且业;
            val_89.Add(key:  "offers-button", value:  val_15.GetComponent<Rilisoft.InAppBonusLobbyButtonView>());
            val_83 = val_15.GetComponent<Rilisoft.InAppBonusLobbyButtonCollectionManager>();
            if(val_83 != 0)
            {
                goto label_24;
            }
            
            label_13:
            val_83 = val_15.AddComponent<Rilisoft.InAppBonusLobbyButtonCollectionManager>();
            label_24:
            if(val_83.transform.GetSiblingIndex() != 0)
            {
                    val_83.transform.SetSiblingIndex(index:  0);
            }
            
            val_6.Add(item:  "offers-button");
            val_83.SetData(一丐丗丁丞丆丅丟丄:  val_3);
            label_7:
            List.Enumerator<T> val_23 = val_5.GetEnumerator();
            label_93:
            if(((-270190544) & 1) == 0)
            {
                goto label_34;
            }
            
            string val_26 = val_25.丐丏七丌丕丗业且上();
            if(val_26 == null)
            {
                goto label_93;
            }
            
            if((val_26.ContainsKey(key:  "action")) != false)
            {
                    if((System.String.op_Equality(a:  System.Convert.ToString(value:  val_26.Item["action"]), b:  "battlepass")) == true)
            {
                goto label_93;
            }
            
            }
            
            string val_32 = System.Convert.ToString(value:  val_26.Item["Key"]);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_32)) == true)
            {
                goto label_93;
            }
            
            val_6.Add(item:  val_32);
            if((this.丌三七丕丘丆不且业.ContainsKey(key:  val_32)) == false)
            {
                goto label_47;
            }
            
            this.丌三七丕丘丆不且业.Item[val_32].SetData(丛丝丙丄七一丁丅三:  val_26);
            goto label_93;
            label_47:
            if(this._leftButtonViewPrefabHandler.Prefab == 0)
            {
                goto label_109;
            }
            
            UnityEngine.GameObject val_39 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._leftButtonViewPrefabHandler.Prefab);
            if(val_39 == 0)
            {
                goto label_109;
            }
            
            Rilisoft.InAppBonusLobbyButtonView val_41 = val_39.GetComponent<Rilisoft.InAppBonusLobbyButtonView>();
            if(val_41 == 0)
            {
                goto label_62;
            }
            
            val_41.SetData(丛丝丙丄七一丁丅三:  val_26);
            if(((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_26, 下上丐丆丝丟丝丒不:  "action", 丙业与丙丗丝不丈东: out  val_43)) != false) && ((System.String.op_Equality(a:  val_43, b:  "recommend-duel")) != false))
            {
                    if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "RecommendDuelButtonShownOnThisDeviceKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 0)
            {
                    丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "RecommendDuelButtonShownOnThisDeviceKey", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            }
            
                if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  "RecommendDuelButtonShownOnAnyDeviceKey", 丝丒上丑一三丑丐丛:  true)) != true)
            {
                    丌丝世丞世丛丆丅丟.东丌丟三丞世一一丑(丌丘不丆丈丈世万上:  "RecommendDuelButtonShownOnAnyDeviceKey", 丕万不丌世丟三丛丈:  false);
            }
            
            }
            
            val_39.transform.SetParent(p:  this._leftGrid.gameObject.transform);
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.zero;
            val_39.transform.localPosition = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
            UnityEngine.Quaternion val_54 = UnityEngine.Quaternion.identity;
            val_39.transform.localRotation = new UnityEngine.Quaternion() {x = val_54.x, y = val_54.y, z = val_54.z, w = val_54.w};
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.one;
            val_39.transform.localScale = new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z};
            this.丌三七丕丘丆不且业.Add(key:  val_32, value:  val_41);
            goto label_93;
            label_34:
            label_109:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(754 == 1049)
            {
                    return;
            }
            
            var val_58 = (754 == 754) ? -1 : 0;
            goto label_106;
            label_62:
            UnityEngine.Object.Destroy(obj:  val_39);
            goto label_109;
            label_106:
            System.Collections.Generic.List<TSource> val_61 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  this.丌三七丕丘丆不且业.Keys, second:  val_6));
            if((val_61.Count < 1) || (this.丌三七丕丘丆不且业.Count < 1))
            {
                goto label_196;
            }
            
            List.Enumerator<T> val_64 = val_61.GetEnumerator();
            label_165:
            if(((-270190576) & 1) == 0)
            {
                goto label_155;
            }
            
            string val_65 = val_25.丐丏七丌丕丗业且上();
            this.丌三七丕丘丆不且业.Item[val_65].gameObject.transform.SetParent(p:  0);
            UnityEngine.Object.Destroy(obj:  this.丌三七丕丘丆不且业.Item[val_65].gameObject);
            bool val_71 = this.丌三七丕丘丆不且业.Remove(key:  val_65);
            goto label_165;
            label_155:
            val_92 = 0;
            val_83 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_83 == 1)
            {
                goto label_176;
            }
            
            if(( == 0) || (910 == 910))
            {
                goto label_196;
            }
            
            label_195:
            label_196:
            val_89 = 1152921537962402672;
            val_87 = 0;
            goto label_179;
            label_193:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_72 = val_5.Item[0];
            if((val_72 != null) && ((val_72.ContainsKey(key:  "Key")) != false))
            {
                    object val_74 = val_72.Item["Key"];
                val_83 = this.丌三七丕丘丆不且业;
                if((val_83.ContainsKey(key:  val_74)) != false)
            {
                    Rilisoft.InAppBonusLobbyButtonView val_76 = this.丌三七丕丘丆不且业.Item[val_74];
                val_83 = val_76.transform;
                if(val_87 != val_83.GetSiblingIndex())
            {
                    val_76.transform.SetSiblingIndex(index:  0);
            }
            
            }
            
            }
            
            val_87 = 1;
            label_179:
            if(val_87 < val_5.Count)
            {
                goto label_193;
            }
            
            val_82 = this._leftGrid;
            val_82.UpdatePositions();
            return;
            label_176:
            if( != 0)
            {
                goto label_195;
            }
            
            goto label_196;
        }
        private void 丌丁七丁丞业七业上(System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, object>> 丑上与且丏专万丝专)
        {
        
        }
        public UnityEngine.Transform GetOfferButtonPositionByOfferId(string 丂东丄丏丕丕丅上一)
        {
            if((this.丌三七丕丘丆不且业.ContainsKey(key:  丂东丄丏丕丕丅上一)) == false)
            {
                    return 0;
            }
            
            Rilisoft.InAppBonusLobbyButtonView val_2 = this.丌三七丕丘丆不且业.Item[丂东丄丏丕丕丅上一];
            if(val_2 != null)
            {
                    return val_2.transform;
            }
            
            return val_2.transform;
        }
        private void 丒不丐丟与丐且一万(Rilisoft.InAppBonusLobbyScrollView 不丈丘丟上丈丘丝丗)
        {
            if(this.丛三且东万丝丐且丛 == null)
            {
                    return;
            }
            
            this.丛三且东万丝丐且丛.Invoke(sender:  this, e:  new Rilisoft.万丈丁丞丆丁丕丕丐(不丈丘丟上丈丘丝丗:  不丈丘丟上丈丘丝丗));
        }
        private void 丕与不丙不且丏丐丛()
        {
            var val_23;
            UICenterOnChild val_24;
            var val_25;
            var val_26;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView>, Rilisoft.InAppBonusLobbyScrollView> val_28;
            int val_29;
            bool val_30;
            val_23 = this;
            val_24 = 1152921542987379280;
            if(this.丕丏丑丐业丛世一丟.Count == 1)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                this._scroll.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                val_23 = this._scroll.GetComponent<UIPanel>();
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_23.clipOffset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                return;
            }
            
            if(this.丕丏丑丐业丛世一丟.Count < 2)
            {
                    return;
            }
            
            if(this._centerOnChild.enabled == false)
            {
                    return;
            }
            
            if(this._centerOnChild.centeredObject != 0)
            {
                goto label_19;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView> val_11 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView>>(source:  this.丕丏丑丐业丛世一丟);
            val_25;
            goto label_20;
            label_19:
            val_26 = null;
            val_26 = null;
            val_28 = InAppBonusLobbyController.<>c.<>9__77_0;
            if(val_28 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView>, Rilisoft.InAppBonusLobbyScrollView> val_12 = null;
                val_28 = val_12;
                val_12 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView>, Rilisoft.InAppBonusLobbyScrollView>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.InAppBonusLobbyScrollView InAppBonusLobbyController.<>c::不业丝且丐丁与丄七(System.Collections.Generic.KeyValuePair<string, Rilisoft.InAppBonusLobbyScrollView> 丅三丄丕丁丘丘业三));
                InAppBonusLobbyController.<>c.<>9__77_0 = val_28;
            }
            
            System.Collections.Generic.List<TSource> val_14 = System.Linq.Enumerable.ToList<Rilisoft.InAppBonusLobbyScrollView>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.InAppBonusLobbyScrollView>, Rilisoft.InAppBonusLobbyScrollView>(source:  this.丕丏丑丐业丛世一丟, selector:  val_12));
            int val_17 = val_14.IndexOf(item:  this._centerOnChild.centeredObject.GetComponent<Rilisoft.InAppBonusLobbyScrollView>());
            if(this.七一丂丝丕丝丄东丏 == false)
            {
                goto label_29;
            }
            
            if(val_17 != 0)
            {
                goto label_30;
            }
            
            val_29 = 1;
            this.七一丂丝丕丝丄东丏 = false;
            if(val_14 != null)
            {
                goto label_36;
            }
            
            goto label_32;
            label_29:
            val_30 = true;
            if(val_17 < (val_14.Count - 1))
            {
                goto label_34;
            }
            
            this.七一丂丝丕丝丄东丏 = val_30;
            label_30:
            val_30 = 0;
            label_34:
            val_29 = val_30 + val_17;
            if((val_29 & 2147483648) != 0)
            {
                goto label_35;
            }
            
            if(val_14 != null)
            {
                goto label_36;
            }
            
            label_32:
            label_36:
            Rilisoft.InAppBonusLobbyScrollView val_20 = val_14.Item[val_29];
            label_20:
            val_24 = this._centerOnChild;
            val_24.CenterOn(丞下万上三丘上与专:  val_20.gameObject.transform);
            this.丒不丐丟与丐且一万(不丈丘丟上丈丘丝丗:  val_20);
            return;
            label_35:
            UnityEngine.Debug.LogError(message:  "fail rotate target caculation");
        }
        public void Click()
        {
            MainMenuController val_4;
            var val_5;
            var val_6;
            val_4 = this.gameObject;
            if(val_4.activeSelf == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  0, 世丁丙世丄一万丆三:  "", 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
        }
        public void ShowAsTryGun(Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            string val_14;
            var val_15;
            val_14 = 丛丝丙丄七一丁丅三;
            val_15 = this;
            if(val_14 == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛丝丙丄七一丁丅三.WeaponId)) == true)
            {
                    return;
            }
            
            TryGunScreenController val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/BuyTryGunWindow")).GetComponent<TryGunScreenController>();
            val_4.transform.SetParent(p:  this.gameObject.transform);
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_4.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_15 = val_4.transform;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            val_15.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            val_14 = 丛丝丙丄七一丁丅三.WeaponId;
            val_4.业三丌世丕丆三丈丙(丒东业不丐丑丕丄丆:  val_14, 丗三专万丌且丂世七:  true);
        }
        public InAppBonusLobbyController()
        {
            var val_37;
            System.Func<System.Boolean> val_39;
            var val_40;
            System.Func<System.Boolean> val_42;
            var val_43;
            System.Func<System.Boolean> val_45;
            var val_46;
            System.Func<System.Boolean> val_48;
            var val_49;
            System.Func<System.Boolean> val_51;
            var val_52;
            System.Func<System.Boolean> val_54;
            var val_55;
            System.Func<System.Boolean> val_57;
            var val_58;
            System.Func<System.Boolean> val_60;
            var val_61;
            System.Func<System.Boolean> val_63;
            var val_64;
            System.Func<System.Boolean> val_66;
            this.丌三七丕丘丆不且业 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.InAppBonusLobbyButtonView>();
            this.丕丏丑丐业丛世一丟 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.InAppBonusLobbyScrollView>();
            this.丅不万丐丆且丛丅七 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.InAppBonusLobbyTopView>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_4 != null)
            {
                    val_4.Add(key:  "action", value:  "battlepass");
            }
            else
            {
                    val_4.Add(key:  "action", value:  "battlepass");
            }
            
            val_4.Add(key:  "Type", value:  "battlepass");
            val_4.Add(key:  "Key", value:  "battlepass");
            val_37 = null;
            val_37 = null;
            val_39 = InAppBonusLobbyController.<>c.<>9__80_0;
            if(val_39 == null)
            {
                    System.Func<System.Boolean> val_5 = null;
                val_39 = val_5;
                val_5 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丁东丕下世三丑上专());
                InAppBonusLobbyController.<>c.<>9__80_0 = val_39;
            }
            
            this.世一丛且丁东业世丙 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_4, 丒丗一丏东与丒丐丆:  val_5);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_7 != null)
            {
                    val_7.Add(key:  "action", value:  "update-info");
            }
            else
            {
                    val_7.Add(key:  "action", value:  "update-info");
            }
            
            val_7.Add(key:  "Type", value:  "update-info");
            val_7.Add(key:  "Key", value:  "update-info");
            val_7.Add(key:  "isOffer", value:  true);
            val_40 = null;
            val_40 = null;
            val_42 = InAppBonusLobbyController.<>c.<>9__80_1;
            if(val_42 == null)
            {
                    InAppBonusLobbyController.<>c val_8 = null;
                val_42 = val_8;
                val_8 = new InAppBonusLobbyController.<>c(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丏丑丄丗下业丙丘丞());
                InAppBonusLobbyController.<>c.<>9__80_1 = val_42;
            }
            
            this.下不丄丅丑丁上不丌 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_7, 丒丗一丏东与丒丐丆:  val_8);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_10 != null)
            {
                    val_10.Add(key:  "action", value:  "recommend-lobby-bundles");
            }
            else
            {
                    val_10.Add(key:  "action", value:  "recommend-lobby-bundles");
            }
            
            val_10.Add(key:  "Type", value:  "recommend-lobby-bundles");
            if(val_10 != null)
            {
                    val_10.Add(key:  "Key", value:  "recommend-lobby-bundles");
            }
            else
            {
                    val_10.Add(key:  "Key", value:  "recommend-lobby-bundles");
            }
            
            val_10.Add(key:  "ID", value:  "bundle_government");
            val_10.Add(key:  "isOffer", value:  true);
            val_43 = null;
            val_43 = null;
            val_45 = InAppBonusLobbyController.<>c.<>9__80_2;
            if(val_45 == null)
            {
                    System.Func<System.Boolean> val_11 = null;
                val_45 = val_11;
                val_11 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丌丗丐上丝丑丅丆丒());
                InAppBonusLobbyController.<>c.<>9__80_2 = val_45;
            }
            
            this.丄丏且丙七丙上不丒 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_10, 丒丗一丏东与丒丐丆:  val_11);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_13 != null)
            {
                    val_13.Add(key:  "action", value:  "offerwall");
            }
            else
            {
                    val_13.Add(key:  "action", value:  "offerwall");
            }
            
            val_13.Add(key:  "Type", value:  "offerwall");
            val_13.Add(key:  "Key", value:  "offerwall");
            val_13.Add(key:  "isOffer", value:  true);
            val_46 = null;
            val_46 = null;
            val_48 = InAppBonusLobbyController.<>c.<>9__80_3;
            if(val_48 == null)
            {
                    System.Func<System.Boolean> val_14 = null;
                val_48 = val_14;
                val_14 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::下丒丟丛专丝丌不上());
                InAppBonusLobbyController.<>c.<>9__80_3 = val_48;
            }
            
            this.东下万丁业丒丐专不 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_13, 丒丗一丏东与丒丐丆:  val_14);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_16 != null)
            {
                    val_16.Add(key:  "action", value:  "recomendation");
            }
            else
            {
                    val_16.Add(key:  "action", value:  "recomendation");
            }
            
            val_16.Add(key:  "Type", value:  "recomendation");
            val_16.Add(key:  "Key", value:  "recomendation");
            val_16.Add(key:  "isOffer", value:  true);
            val_49 = null;
            val_49 = null;
            val_51 = InAppBonusLobbyController.<>c.<>9__80_4;
            if(val_51 == null)
            {
                    System.Func<System.Boolean> val_17 = null;
                val_51 = val_17;
                val_17 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丌七丄业三七丞丈丁());
                InAppBonusLobbyController.<>c.<>9__80_4 = val_51;
            }
            
            this.世下不丟世七丂且丙 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_16, 丒丗一丏东与丒丐丆:  val_17);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_19 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_19 != null)
            {
                    val_19.Add(key:  "action", value:  "ChangeLog");
            }
            else
            {
                    val_19.Add(key:  "action", value:  "ChangeLog");
            }
            
            val_19.Add(key:  "Type", value:  "ChangeLog");
            val_19.Add(key:  "Key", value:  "ChangeLog");
            val_19.Add(key:  "isOffer", value:  true);
            val_52 = null;
            val_52 = null;
            val_54 = InAppBonusLobbyController.<>c.<>9__80_5;
            if(val_54 == null)
            {
                    System.Func<System.Boolean> val_20 = null;
                val_54 = val_20;
                val_20 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::下丄丆丝丟丅丅丐丑());
                InAppBonusLobbyController.<>c.<>9__80_5 = val_54;
            }
            
            this.丆丑下丒下丟世三丂 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_19, 丒丗一丏东与丒丐丆:  val_20);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_22 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_22 != null)
            {
                    val_22.Add(key:  "action", value:  "recommend-clan");
            }
            else
            {
                    val_22.Add(key:  "action", value:  "recommend-clan");
            }
            
            val_22.Add(key:  "Type", value:  "recommend-clan");
            val_22.Add(key:  "Key", value:  "recommend-clan");
            val_22.Add(key:  "isOffer", value:  true);
            val_55 = null;
            val_55 = null;
            val_57 = InAppBonusLobbyController.<>c.<>9__80_6;
            if(val_57 == null)
            {
                    System.Func<System.Boolean> val_23 = null;
                val_57 = val_23;
                val_23 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丝丞丏丑世上丁丛专());
                InAppBonusLobbyController.<>c.<>9__80_6 = val_57;
            }
            
            this.丟下且上下丂丙丈丅 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_22, 丒丗一丏东与丒丐丆:  val_23);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_25 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_25 != null)
            {
                    val_25.Add(key:  "action", value:  "recommend-characters");
            }
            else
            {
                    val_25.Add(key:  "action", value:  "recommend-characters");
            }
            
            val_25.Add(key:  "Type", value:  "recommend-characters");
            val_25.Add(key:  "Key", value:  "recommend-characters");
            val_25.Add(key:  "isOffer", value:  true);
            val_58 = null;
            val_58 = null;
            val_60 = InAppBonusLobbyController.<>c.<>9__80_7;
            if(val_60 == null)
            {
                    System.Func<System.Boolean> val_26 = null;
                val_60 = val_26;
                val_26 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::与一上专丈下七丗三());
                InAppBonusLobbyController.<>c.<>9__80_7 = val_60;
            }
            
            this.东丕丌丆丒丕三丂七 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_25, 丒丗一丏东与丒丐丆:  val_26);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_28 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_28 != null)
            {
                    val_28.Add(key:  "action", value:  "recommend-duel");
            }
            else
            {
                    val_28.Add(key:  "action", value:  "recommend-duel");
            }
            
            val_28.Add(key:  "Type", value:  "recommend-duel");
            val_28.Add(key:  "Key", value:  "recommend-duel");
            val_28.Add(key:  "isOffer", value:  true);
            val_61 = null;
            val_61 = null;
            val_63 = InAppBonusLobbyController.<>c.<>9__80_8;
            if(val_63 == null)
            {
                    System.Func<System.Boolean> val_29 = null;
                val_63 = val_29;
                val_29 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::三丈东不且上丏丁丛());
                InAppBonusLobbyController.<>c.<>9__80_8 = val_63;
            }
            
            this.丟丂与且世丌与一丂 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_28, 丒丗一丏东与丒丐丆:  val_29);
            this.丗丌世丂世丅丂丏丄 = new Rilisoft.丑丞一丁丕丌丅丄上();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_32 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_32 != null)
            {
                    val_32.Add(key:  "action", value:  "vipInSeconds");
            }
            else
            {
                    val_32.Add(key:  "action", value:  "vipInSeconds");
            }
            
            val_32.Add(key:  "Type", value:  "vipInSeconds");
            val_32.Add(key:  "Key", value:  "vipInSeconds");
            val_32.Add(key:  "isOffer", value:  true);
            val_64 = null;
            val_64 = null;
            val_66 = InAppBonusLobbyController.<>c.<>9__80_9;
            if(val_66 == null)
            {
                    System.Func<System.Boolean> val_33 = null;
                val_66 = val_33;
                val_33 = new System.Func<System.Boolean>(object:  InAppBonusLobbyController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InAppBonusLobbyController.<>c::丘不与丗世丕丌东丐());
                InAppBonusLobbyController.<>c.<>9__80_9 = val_66;
            }
            
            this.丕丝万且丆丝丘世丈 = new Rilisoft.丘丏专世丘丒丆七一(丂丈丗丄不丅丅丙丒:  val_32, 丒丗一丏东与丒丐丆:  val_33);
            this.丟丏丙丙丕丄万丛万 = new Rilisoft.丈一且丄与丆丆上东();
            this.丟东丘丌丘丄丆上丏 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.与丒丕丁下世东丅丌 = true;
            this.七丛丙丏丗丏丁东丌 = true;
            this.丘不丂上丄上丁丙不 = -Infinityf;
            this._rotateDelay = 2f;
        }
    
    }

}
