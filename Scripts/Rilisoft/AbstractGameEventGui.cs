using UnityEngine;

namespace Rilisoft
{
    internal abstract class AbstractGameEventGui : MonoBehaviour, 三丄丝丏丌丏一丙万<Rilisoft.丛且世丐丆上七业丁>, 不丈丒丒丆丐三万专<Rilisoft.丛且世丐丆上七业丁>, 丈丕丑且丘丘丆东丑, 业业丌三丞丅世丐丞, 丄世专丆丛世下丟东, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private Rilisoft.SubscribeToBloggerBanner subscribeToBloggerBanner;
        internal static System.Nullable<UnityEngine.Vector3> 丌丒丗丕专东丐上丗;
        internal static int 丏世且丞世丂丈丗东;
        public GameEventEndingBanner GameEventEndingBanner;
        private System.Collections.Generic.List<Rilisoft.DroppedItemData> 丗丟丕专丂不丛丗丛;
        private Rilisoft.WindowAnimator 丞业丆丛业丟一丛东;
        private ConnectionControl 丙不丅丝丙专丕世丐;
        private static Rilisoft.AbstractGameEventGui <不丁丄七丛不丆丁丕>k__BackingField;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private static Rilisoft.DroppedItemData <丄丞七丌一丗丁不丒>k__BackingField;
        private System.Action<Rilisoft.且丏上上丛丟七丁下> 上与丁丟与专丞丐丐;
        private static System.Action<Rilisoft.且丏上上丛丟七丁下> 上丁丞丈丅丄东丙丐;
        private UIPanel 丛丈七丒丄业丒丈丕;
        private UIPanel 丛丘下丗业丂一且业;
        private Rilisoft.GameEventBuyCurrencyView 世丄万丄丐东丟丞丞;
        protected UnityEngine.GameObject _purchaseTouchBlocker;
        protected UnityEngine.GameObject _invisibleTouchBlocker;
        protected UnityEngine.AudioClip _buySpinClip;
        private System.Collections.Generic.List<GameEventPlayerGot> 丕业万与下丅与丈丙;
        
        // Properties
        internal static Rilisoft.AbstractGameEventGui 丆丕丝丒不丙且丐丗 { get; set; }
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        internal static Rilisoft.DroppedItemData 丞丒与丐丕丌丛丟丟 { get; set; }
        public bool 东且世与一东丂一丆 { get; }
        public static bool 不丁丄丌丒上丅丂丟 { get; }
        protected Rilisoft.GameEventBuyCurrencyView 专东丙丏丂丌世丞丕 { get; }
        protected System.Collections.Generic.List<GameEventPlayerGot> 七专世东专万丂丝丛 { get; }
        
        // Methods
        internal static Rilisoft.AbstractGameEventGui 丑七不且上丗丁一世()
        {
            return (Rilisoft.AbstractGameEventGui)Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.AbstractGameEventGui 丙业与丙丗丝不丈东)
        {
            Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        protected void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.DroppedItemData 一与东专丛丄世丟丕()
        {
            return (Rilisoft.DroppedItemData)Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField;
        }
        private static void 业丝与业丛丌丕丆丆(Rilisoft.DroppedItemData 丙业与丙丗丝不丈东)
        {
            Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get___InterfaceEnabled()
        {
            return Rilisoft.AbstractGameEventGui.InterfaceEnabled;
        }
        public static bool get_InterfaceEnabled()
        {
            Rilisoft.AbstractGameEventGui val_8 = Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField;
            if(val_8 != 0)
            {
                    val_8 = Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField;
                if((val_8.Equals(other:  0)) != true)
            {
                    val_8 = Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField.gameObject;
                if(val_8 != 0)
            {
                    val_8 = Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField.gameObject;
                if((val_8 & 1) == 0)
            {
                goto label_20;
            }
            
            }
            
            }
            
            }
            
            var val_8 = 0;
            label_20:
            val_8 = val_8 & 1;
            return (bool)val_8;
        }
        public abstract void ShowWindow(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万); // 0
        public abstract void HideWindow(); // 0
        public virtual void SetContext(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            var val_4;
            Rilisoft.丛且世丐丆上七业丁 val_12;
            Rilisoft.SubscribeToBloggerBanner val_13 = this;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            List.Enumerator<T> val_2 = this.丛万丆丅丙丘东丄丕().GetEnumerator();
            label_7:
            if(((-559211088) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            val_5.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
            {
                    if(this.gameObject.activeInHierarchy != false)
            {
                    this.业丂且丂七上丂丒丙();
            }
            
                Rilisoft.SubscribeToBlogger val_9 = this.GetComponentInChildren<Rilisoft.SubscribeToBlogger>(includeInactive:  true);
                if(val_9 == 0)
            {
                    return;
            }
            
                val_12 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                val_13 = this.subscribeToBloggerBanner;
                val_9.Setup(与且专丈不万东一万:  val_12, 丈丁丅丈丌三丕七丗:  val_13);
                return;
            }
            
            val_13 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "nullable context", args:  val_13);
        }
        public virtual void Kill()
        {
            if(this.gameObject == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
        }
        public void add_OnVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上与丁丟与专丞丐丐, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上与丁丟与专丞丐丐 != 1152921542702680120);
        
        }
        public void remove_OnVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上与丁丟与专丞丐丐, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上与丁丟与专丞丐丐 != 1152921542702816696);
        
        }
        public static void add_OnGuiVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 != 1152921505450565672);
        
        }
        public static void remove_OnGuiVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 != 1152921505450565672);
        
        }
        internal virtual void 不一丒丁丗上丗上世(object 丙丈下丕丑专上丕丛)
        {
        
        }
        public abstract void Spin(int 下丅三丈世丐丕丌丑); // 0
        internal virtual void BackRequest()
        {
        
        }
        internal static void 丙丛东世东丌业一丝()
        {
            Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 = 0;
        }
        protected virtual void Awake()
        {
            Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField = this;
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void OnEnable()
        {
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            float val_33;
            丙丟丙三万丐丛丑丒 val_34;
            var val_35;
            UIPanel val_36;
            var val_37;
            var val_38;
            if(this.世丄万丄丐东丟丞丞 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.世丄万丄丐东丟丞丞.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            this.业丂且丂七上丂丒丙();
            Rilisoft.WindowAnimator val_3 = this.GetComponent<Rilisoft.WindowAnimator>();
            this.丞业丆丛业丟一丛东 = val_3;
            bool val_4 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            if(val_4 == false)
            {
                goto label_14;
            }
            
            val_26 = null;
            val_26 = null;
            if(UICamera.currentCamera == 0)
            {
                goto label_14;
            }
            
            this.丞业丆丛业丟一丛东.remove_OnAnimationStateChanged(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, 丙丟丙三万丐丛丑丒>(object:  this, method:  typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_300));
            this.丞业丆丛业丟一丛东.add_OnAnimationStateChanged(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, 丙丟丙三万丐丛丑丒>(object:  this, method:  typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_300));
            val_27 = null;
            val_27 = null;
            UnityEngine.Vector3 val_9 = UICamera.currentCamera.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            val_28 = val_9.x;
            val_29 = val_9.z;
            Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗 = 0;
            Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗.__il2cppRuntimeField_8 = 0;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_33 = val_10.y;
            val_34 = 0;
            val_35 = 0;
            goto label_25;
            label_14:
            val_4.与丙万且丂丌丛丗丄(丝三丄专丗丞丄丄丌:  false);
            if(this.上与丁丟与专丞丐丐 != null)
            {
                    this.上与丁丟与专丞丐丐.Invoke(obj:  1);
            }
            
            if(Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 == null)
            {
                goto label_28;
            }
            
            Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐.Invoke(obj:  1);
            goto label_28;
            label_25:
            this.丞业丆丛业丟一丛东.Animate(丈丗与丞一上且上上:  new UnityEngine.Vector3() {y = val_11.y}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_12.x, z = val_12.z}, 世一丑丝丈一上三丕:  null, 丗三丐丞丒专丆丁丅:  true);
            label_28:
            val_36 = 1152921505080860672;
            val_37 = null;
            val_37 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_38 = null;
                val_38 = null;
                UIPanel val_14 = GetComponent<UIPanel>();
                this.丛丈七丒丄业丒丈丕 = val_14;
                int val_15 = val_14.depth;
                UIPanel val_17 = this.gameObject.GetComponentInChildren<UIPanel>();
                this.丛丘下丗业丂一且业 = val_17;
                if(val_17 != 0)
            {
                    val_36 = this.丛丈七丒丄业丒丈丕;
                if(this.丛丘下丗业丂一且业.depth <= val_36.depth)
            {
                    int val_26 = this.丛丈七丒丄业丒丈丕.depth;
                val_36 = this.丛丘下丗业丂一且业;
                val_26 = (val_26 + 1) - this.丛丘下丗业丂一且业.depth;
                丞东丑专丛丆丄丝世.丄万一丅丘丏丅丑东(丛丘下丗业丂一且业:  val_36, 丙业与丙丗丝不丈东:  val_26);
            }
            
            }
            
            }
            
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丗丑丛万丒丐丕丆丒(丅且三万丘丙业丙丗:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅丙丛丑丌丆丌丕丒());
        }
        protected virtual void Update()
        {
            var val_12;
            var val_13;
            if(StoreKitEventListener.三丘丈不丝丕丞东丌() == false)
            {
                goto label_3;
            }
            
            if(Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() == 0)
            {
                goto label_8;
            }
            
            val_12 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject.activeInHierarchy ^ 1;
            goto label_14;
            label_3:
            val_12 = 0;
            goto label_14;
            label_8:
            val_12 = 1;
            label_14:
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  val_12 & 1);
            if(this._purchaseTouchBlocker != 0)
            {
                    丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._purchaseTouchBlocker, 丏业丟一东丂东丘丛:  val_12 & 1);
            }
            
            if(this._invisibleTouchBlocker == 0)
            {
                    return;
            }
            
            if(this.丞业丆丛业丟一丛东 != 0)
            {
                    val_13 = this.丞业丆丛业丟一丛东.AnimationPlaying;
            }
            else
            {
                    val_13 = 0;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._invisibleTouchBlocker, 丏业丟一东丂东丘丛:  false);
        }
        protected virtual void OnDisable()
        {
            if(ActivityIndicator.丙专三丙丌丝丏丌丅() != false)
            {
                    ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            }
            
            this.下一且万丕一丈丄丗();
            if(this.丞业丆丛业丟一丛东 != 0)
            {
                    this.丞业丆丛业丟一丛东.remove_OnAnimationStateChanged(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, 丙丟丙三万丐丛丑丒>(object:  this, method:  typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_300));
            }
            
            this.丞业丆丛业丟一丛东.与丙万且丂丌丛丗丄(丝三丄专丗丞丄丄丌:  true);
            if(this.上与丁丟与专丞丐丐 != null)
            {
                    this.上与丁丟与专丞丐丐.Invoke(obj:  0);
            }
            
            if(Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 != null)
            {
                    Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐.Invoke(obj:  0);
            }
            
            this.丞丘三丝专世且丈丐();
        }
        protected virtual void OnDestroy()
        {
        
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return false;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        private void 与丙万且丂丌丛丗丄(bool 丝三丄专丗丞丄丄丌)
        {
            if(MainMenuHeroCamera.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = 丝三丄专丗丞丄丄丌;
            MainMenuHeroCamera.丑七不且上丗丁一世().丑丏丘丛丑丆与三丟().enabled = 丝三丄专丗丞丄丄丌;
        }
        protected virtual void 丐上丝专丅且不丟丄(bool 不七丞丄丙一一丒丆, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 世一丑丝丈一上三丕)
        {
            bool val_1 = 不七丞丄丙一一丒丆;
            this.与丙万且丂丌丛丗丄(丝三丄专丗丞丄丄丌:  val_1);
            if(this.上与丁丟与专丞丐丐 != null)
            {
                    this.上与丁丟与专丞丐丐.Invoke(obj:  val_1);
            }
            
            if(Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 == null)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐.Invoke(obj:  不七丞丄丙一一丒丆);
        }
        private void 业丂且丂七上丂丒丙()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  "menu_music_event_")) != false)
            {
                    return;
            }
            
            MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.东不上丑丞七丑丅丗(), 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
        }
        private void 下一且万丕一丈丄丗()
        {
            if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  "menu_music_event_")) == false)
            {
                    return;
            }
            
            MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆(), 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
        }
        private void 丑丅丒且业丐丛一丙(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            this.丝世丅一丞丙丌世一().Hide();
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不丞丘一丙丝丒与与(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
        }
        public virtual void ShowBuyCurrencyGui(string 丏丂不专上丘丂不丅)
        {
            System.Action val_11;
            var val_12;
            var val_13;
            var val_14;
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅)) == false)
            {
                goto label_1;
            }
            
            if(this.丝世丅一丞丙丌世一() != 0)
            {
                goto label_4;
            }
            
            UnityEngine.Debug.LogError(message:  "_buyCurrencyView not setted");
            return;
            label_1:
            AbstractGameEventGui.丙丟与业不万丈丄丈 val_4 = new AbstractGameEventGui.丙丟与业不万丈丄丈();
            .丞丈丟专七丗丕不业 = 0;
            System.Action val_5 = null;
            val_11 = val_5;
            val_5 = new System.Action(object:  val_4, method:  System.Void AbstractGameEventGui.丙丟与业不万丈丄丈::丄丏丏不万丑丛上不());
            if(val_4 == null)
            {
                goto label_8;
            }
            
            .丞丈丟专七丗丕不业 = val_11;
            goto label_9;
            label_4:
            this.丝世丅一丞丙丌世一().remove_OnPurchaseSelected(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameCurrencyData>(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::丑丅丒且业丐丛一丙(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)));
            this.丝世丅一丞丙丌世一().add_OnPurchaseSelected(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameCurrencyData>(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::丑丅丒且业丐丛一丙(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)));
            this.丝世丅一丞丙丌世一().Show(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            return;
            label_8:
            .丞丈丟专七丗丕不业 = val_11;
            val_11 = (AbstractGameEventGui.丙丟与业不万丈丄丈)[1152921542705852512].丞丈丟专七丗丕不业;
            label_9:
            BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  val_11);
            val_12 = null;
            val_12 = null;
            val_13 = null;
            val_13 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丞丛丞三丁三丐丅丗;
            val_14 = null;
            val_14 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  false, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丞丛丞三丁三丐丅丗, 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
        }
        protected bool 丟丆丘丒丘三丙三与(int 下丅三丈世丐丕丌丑)
        {
            object val_26;
            UnityEngine.Object val_27;
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_26 = this;
            val_27 = this.丝世丅一丞丙丌世一();
            if(val_27 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "_buyCurrencyView not setted");
                val_28 = 0;
                return (bool)val_28;
            }
            
            val_27 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            if(val_27.且丌三丙丙与与丝世() == null)
            {
                    return (bool)val_28;
            }
            
            int val_26 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丌三丙丙与与丝世().丟丂丞不专丆万丒世();
            string val_8 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
            val_27 = val_8;
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_8)) != false)
            {
                    val_29 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七();
                int val_11 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  val_29);
            }
            else
            {
                    val_30 = null;
                val_30 = null;
                if((System.String.op_Equality(a:  val_27, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_29 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
                int val_14 = val_29.世丄丂下丏丝丞丒且();
            }
            else
            {
                    val_31 = null;
                val_31 = null;
                if((System.String.op_Equality(a:  val_27, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_47;
            }
            
                val_29 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
            }
            
            }
            
            val_32 = val_29.丗丞丝丅丈丑丗丂丌();
            label_47:
            val_26 = val_26 * (UnityEngine.Mathf.Max(a:  1, b:  下丅三丈世丐丕丌丑));
            val_28 = 0;
            if(val_32 >= val_26)
            {
                    return (bool)val_28;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛()) == true)
            {
                    return (bool)val_28;
            }
            
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_27)) != false)
            {
                    System.Action<Rilisoft.GameCurrencyData> val_22 = null;
                val_32 = 1152921542705765792;
                val_22 = new System.Action<Rilisoft.GameCurrencyData>(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::丑丅丒且业丐丛一丙(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆));
                this.丝世丅一丞丙丌世一().remove_OnPurchaseSelected(丙业与丙丗丝不丈东:  val_22);
                System.Action<Rilisoft.GameCurrencyData> val_24 = null;
                val_27 = val_24;
                val_24 = new System.Action<Rilisoft.GameCurrencyData>(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::丑丅丒且业丐丛一丙(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆));
                this.丝世丅一丞丙丌世一().add_OnPurchaseSelected(丙业与丙丗丝不丈东:  val_24);
                val_26 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                this.丝世丅一丞丙丌世一().Show(丅东专与不三丂丁丝:  val_26);
            }
            else
            {
                    val_33 = null;
                val_33 = null;
                val_26 = MainMenuController.丄丞丁丈与业上丞丟;
                val_26.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  false, 丆丟七丝丏业丅上丄:  val_27, 世丁丙世丄一万丆三:  "", 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
            }
            
            val_28 = 1;
            return (bool)val_28;
        }
        internal static System.Collections.Generic.List<Rilisoft.DroppedItemData> 丗丛七丂丁且丟专丕(int 下丅三丈世丐丕丌丑, bool 丑万丌丂上业丏上世, Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, bool 丄丆丂下不丝东丂一)
        {
            int val_22;
            Rilisoft.上专业三丟丁丞专下 val_76;
            var val_77;
            var val_78;
            Rilisoft.上业丝丟东下丏丗业 val_79;
            var val_80;
            Rilisoft.DroppedItemData val_81;
            var val_82;
            int val_83;
            var val_84;
            Rilisoft.GameEventItemData val_85;
            var val_86;
            int val_87;
            var val_88;
            val_76 = 丐下丝丘丑丟丟丗丌;
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_1 = new System.Collections.Generic.List<Rilisoft.DroppedItemData>();
            System.Collections.Generic.List<Rilisoft.上业丝丟东下丏丗业> val_2 = new System.Collections.Generic.List<Rilisoft.上业丝丟东下丏丗业>();
            val_77 = 1152921542706239648;
            val_78 = 0;
            goto label_7;
            label_87:
            AbstractGameEventGui.丏丑丅丙世东丈丑丆 val_4 = new AbstractGameEventGui.丏丑丅丙世东丈丑丆();
            if(val_4 == null)
            {
                goto label_2;
            }
            
            .丐与丅丛一丘与丙丘 = 0;
            if(丅东专与不三丂丁丝 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            if((丅东专与不三丂丁丝.丑丈且与丈上丑丂世(丐下丝丘丑丟丟丗丌:  val_76, 丑万丌丂上业丏上世:  丑万丌丂上业丏上世, 下不业丄一丐万丒世:  (下丅三丈世丐丕丌丑 > 9) ? 1 : 0, 丑丗丈丒丏上与三七:  val_2, 下丅丙一丂丗丅丝七: out  .丐与丅丛一丘与丙丘, 丒丞丙丝与丕业丟不: out  0)) == true)
            {
                goto label_4;
            }
            
            UnityEngine.Debug.LogError(message:  "drop item fail");
            goto label_7;
            label_2:
            mem[16] = 0;
            if(丅东专与不三丂丁丝 != null)
            {
                goto label_8;
            }
            
            goto label_9;
            label_4:
            Rilisoft.DroppedItemData val_8 = new Rilisoft.DroppedItemData();
            Rilisoft.GameEventItemData val_9 = .丐与丅丛一丘与丙丘.Data;
            if(val_8 == null)
            {
                goto label_12;
            }
            
            val_8.丅专下万丕丑丆丅丝(丏专丕万丘丝与万三:  val_9, 丐下丝丘丑丟丟丗丌:  val_76, 万三丂且丆三且丝且:  0, 丅东专与不三丂丁丝:  丅东专与不三丂丁丝, 丄丆丂下不丝东丂一:  丄丆丂下不丝东丂一);
            if((Rilisoft.DroppedItemData)[1152921542706500768].ItemData != null)
            {
                goto label_39;
            }
            
            label_40:
            label_39:
            (Rilisoft.DroppedItemData)[1152921542706500768].ItemData.PresettedCount = (Rilisoft.DroppedItemData)[1152921542706500768].ItemData.Count;
            val_1.Add(item:  val_8);
            val_78 = val_78;
            val_79 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上业丝丟东下丏丗业>(source:  val_2, predicate:  new System.Func<Rilisoft.上业丝丟东下丏丗业, System.Boolean>(object:  val_4, method:  System.Boolean AbstractGameEventGui.丏丑丅丙世东丈丑丆::丅丛专且丏万丅七上(Rilisoft.上业丝丟东下丏丗业 丗丛丂且丕丆上世丛)));
            if(val_79 != null)
            {
                goto label_57;
            }
            
            Rilisoft.上业丝丟东下丏丗业 val_18 = null;
            val_79 = val_18;
            val_18 = new Rilisoft.上业丝丟东下丏丗业(丁丅丈丌丟世丗丗丟:  .丐与丅丛一丘与丙丘.Data.Type, 丞丅上丏丂且下丅与:  .丐与丅丛一丘与丙丘.Data.Id);
            if(val_18.不业丙丒丂丞下丆丙() != 1600)
            {
                goto label_62;
            }
            
            List.Enumerator<T> val_20 = val_2.GetEnumerator();
            label_38:
            label_32:
            if(((-555116496) & 1) == 0)
            {
                goto label_26;
            }
            
            string val_23 = val_22.丐丏七丌丕丗业且上();
            if((val_23.不业丙丒丂丞下丆丙() != 1600) || ((val_23.业上丙丞丐丄丆丅七().Equals(value:  val_18.业上丙丞丐丄丆丅七())) == false))
            {
                goto label_32;
            }
            
            val_23.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  .丐与丅丛一丘与丙丘.Data.Count + val_23.丂丁丏一丙丛业且丌());
            goto label_38;
            label_12:
            val_8.丅专下万丕丑丆丅丝(丏专丕万丘丝与万三:  val_9, 丐下丝丘丑丟丟丗丌:  val_76, 万三丂且丆三且丝且:  0, 丅东专与不三丂丁丝:  丅东专与不三丂丁丝, 丄丆丂下不丝东丂一:  丄丆丂下不丝东丂一);
            if(135970152 != 0)
            {
                goto label_39;
            }
            
            goto label_40;
            label_26:
            val_78 = val_78 + 1;
            mem2[0] = 334;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_78 == 1) || ((-555116656 + ((val_78 + 1)) << 2) != 334))
            {
                goto label_53;
            }
            
            var val_75 = 0;
            val_75 = val_75 ^ (val_78 >> 31);
            val_78 = val_78 + val_75;
            if((0 & 1) == 0)
            {
                goto label_54;
            }
            
            goto label_57;
            label_53:
            if((0 & 1) != 0)
            {
                goto label_57;
            }
            
            label_54:
            val_18.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  .丐与丅丛一丘与丙丘.Data.Count);
            label_62:
            val_2.Add(item:  val_18);
            label_57:
            val_18.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  .丐与丅丛一丘与丙丘.Data.Count + val_18.丂丁丏一丙丛业且丌());
            object[] val_39 = new object[3];
            val_22 = 0.Id;
            val_77 = 1152921542706239648;
            val_39[0] = val_22;
            val_39[1] = .丐与丅丛一丘与丙丘.Data.Id;
            val_39[2] = .丐与丅丛一丘与丙丘.Data;
            UnityEngine.Debug.LogFormat(format:  ">>> dropped item: container \'{0}\', item \'{1}\', count: {2}", args:  val_39);
            val_76 = val_76;
            label_7:
            if(val_1.Count < 下丅三丈世丐丕丌丑)
            {
                goto label_87;
            }
            
            if(val_76.丐丏下丕三丒丗丅丛() != false)
            {
                    if(丅东专与不三丂丁丝.丕丒丙七丘丈丙且丂() != false)
            {
                    丅东专与不三丂丁丝.下丄专一下丂三业丆();
            }
            
            }
            
            if(val_1.Count < 1)
            {
                goto label_94;
            }
            
            if(val_1 == null)
            {
                goto label_95;
            }
            
            val_80 = val_1.Count;
            goto label_96;
            label_94:
            val_81 = 0;
            goto label_97;
            label_95:
            val_80 = val_1.Count;
            label_96:
            val_81 = val_1.Item[val_80 - 1];
            label_97:
            val_82 = null;
            Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField = val_81;
            val_82 = null;
            if(((Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField) != null) && (val_76.丐世丑丗且丙万上上() == 1))
            {
                    Rilisoft.GameEventItemContainer val_53 = Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField.一一一不万专东下业();
                if(val_53 != null)
            {
                    Rilisoft.GameEventItemContainerContentType val_54 = val_53.ContentType;
            }
            
            }
            
            if(val_1 != null)
            {
                goto label_155;
            }
            
            label_156:
            label_155:
            List.Enumerator<T> val_55 = val_1.GetEnumerator();
            label_117:
            if(((-555116560) & 1) == 0)
            {
                goto label_111;
            }
            
            if(Type != 100)
            {
                goto label_117;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_60 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_22.丐丏七丌丕丗业且上().Id);
            if(val_60 == null)
            {
                goto label_117;
            }
            
            val_83 = 0;
            Rilisoft.丞丛七上丕专丏丌丈.丙丛丄丛丏丅专专丞(丈下丑丆上丏丗丈专:  val_60);
            val_84 = -555116656;
            goto label_120;
            label_111:
            val_84 = -555116656;
            val_83 = 0;
            label_120:
            val_78 = val_78 + 1;
            mem2[0] = 923;
            goto label_121;
            label_136:
            if(((-555116528) & 1) == 0)
            {
                goto label_127;
            }
            
            new Rilisoft.DroppedItemData() = new Rilisoft.DroppedItemData();
            new Rilisoft.DroppedItemData().丅专下万丕丑丆丅丝(丏专丕万丘丝与万三:  val_22.丐丏七丌丕丗业且上().Data, 丐下丝丘丑丟丟丗丌:  val_76, 万三丂且丆三且丝且:  null, 丅东专与不三丂丁丝:  丅东专与不三丂丁丝, 丄丆丂下不丝东丂一:  false);
            if(new Rilisoft.DroppedItemData() == null)
            {
                goto label_130;
            }
            
            val_85 = (Rilisoft.DroppedItemData)[1152921542706648256].ItemData;
            val_86 = val_85;
            if(val_85 != null)
            {
                goto label_133;
            }
            
            goto label_132;
            label_130:
            val_86 = 135970152;
            val_85 = 135970152;
            if(val_85 != 0)
            {
                goto label_133;
            }
            
            label_132:
            label_133:
            int val_73 = val_85.Count;
            Add(item:  new Rilisoft.DroppedItemData());
            goto label_136;
            label_127:
            val_87 = 0;
            val_88 = val_78 + 1;
            mem2[0] = 789;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && ((-555116656 + ((val_78 + 1)) << 2) == 789))
            {
                    var val_76 = 0;
                val_76 = val_76 ^ ( >> 31);
                 =  + val_76;
            }
            else
            {
                    if( != 0)
            {
                    val_87 = 0;
            }
            
            }
            
            val_76.丕且专一三不世东丈(丒丁东世世丗丅丅丄:  Id);
            val_1.InsertRange(index:  0, collection:  null);
            if(val_1 != null)
            {
                goto label_155;
            }
            
            goto label_156;
            label_121:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_88 != 1)
            {
                    if( == 0)
            {
                    return val_1;
            }
            
                if((-555116656 + (((val_78 + 1) + 1)) << 2) == 923)
            {
                    return val_1;
            }
            
                return val_1;
            }
            
            if( != 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        protected System.Collections.Generic.List<Rilisoft.DroppedItemData> 丗丛七丂丁且丟专丕(System.Collections.Generic.List<Rilisoft.GameEventItem> 丑七不与丛丆一丂丞, bool 东丅与丟丁上不业丏)
        {
            var val_5;
            var val_21;
            Rilisoft.GameEventItem val_22;
            Rilisoft.丛且世丐丆上七业丁 val_23;
            if((丑七不与丛丆一丂丞 == null) || (丑七不与丛丆一丂丞.Count < 1))
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_2 = null;
            val_21 = val_2;
            val_2 = new System.Collections.Generic.List<Rilisoft.DroppedItemData>();
            List.Enumerator<T> val_3 = 丑七不与丛丆一丂丞.GetEnumerator();
            label_19:
            if(((-554743328) & 1) == 0)
            {
                goto label_3;
            }
            
            new AbstractGameEventGui.丑丌与七下丈丅一丐() = new System.Object();
            string val_7 = val_5.丐丏七丌丕丗业且上();
            if(new AbstractGameEventGui.丑丌与七下丈丅一丐() != null)
            {
                    val_22 = new AbstractGameEventGui.丑丌与七下丈丅一丐();
                .下丅丙一丂丗丅丝七 = val_7;
                val_23 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            }
            else
            {
                    mem[16] = val_7;
                val_23 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                val_22 = 16;
            }
            
            东丅与丟丁上不业丏 = 东丅与丟丁上不业丏;
            if((val_23.丞上世一丘丐业且一(下丅丙一丂丗丅丝七:  val_22, 丄丆丂下不丝东丂一:  东丅与丟丁上不业丏)) == false)
            {
                goto label_19;
            }
            
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_10 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new AbstractGameEventGui.丑丌与七下丈丅一丐(), method:  System.Boolean AbstractGameEventGui.丑丌与七下丈丅一丐::丅丛专且丏万丅七上(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
            Rilisoft.上专业三丟丁丞专下 val_11 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞(), predicate:  null);
            if(val_11 == null)
            {
                goto label_19;
            }
            
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_12 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new AbstractGameEventGui.丑丌与七下丈丅一丐(), method:  System.Boolean AbstractGameEventGui.丑丌与七下丈丅一丐::七丆下丄丁丛世专丅(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            Rilisoft.GameEventItemContainer val_13 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_11, predicate:  null);
            if(val_13 == null)
            {
                goto label_19;
            }
            
            new Rilisoft.DroppedItemData() = new Rilisoft.DroppedItemData();
            new Rilisoft.DroppedItemData().丅专下万丕丑丆丅丝(丏专丕万丘丝与万三:  mem[16].Data, 丐下丝丘丑丟丟丗丌:  val_11, 万三丂且丆三且丝且:  val_13, 丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丄丆丂下不丝东丂一:  东丅与丟丁上不业丏);
            val_2.Add(item:  new Rilisoft.DroppedItemData());
            if((val_11.丐丏下丕三丒丗丅丛() == false) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丕丒丙七丘丈丙且丂()) == false))
            {
                goto label_19;
            }
            
            this.<丅丝丌丝丁丏丙东丞>k__BackingField.下丄专一下丂三业丆();
            goto label_19;
            label_2:
            val_21 = 0;
            return (System.Collections.Generic.List<Rilisoft.DroppedItemData>)val_21;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Comparison<Rilisoft.DroppedItemData> val_19 = new System.Comparison<Rilisoft.DroppedItemData>(object:  0, method:  static System.Int32 Rilisoft.丛且世丐丆上七业丁::丙上丏不丗与丒专与(Rilisoft.DroppedItemData 丏丆丑丗七丄丙丝与, Rilisoft.DroppedItemData 丒丈丙丐丏丕丆万丗));
            if(val_21 != null)
            {
                    val_2.Sort(comparison:  val_19);
            }
            else
            {
                    val_2.Sort(comparison:  val_19);
            }
            
            val_2.Reverse();
            return (System.Collections.Generic.List<Rilisoft.DroppedItemData>)val_21;
        }
        public void U_ShowBank()
        {
            null = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  0, 世丁丙世丄一万丆三:  "", 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
        }
        public void U_GoBattle()
        {
            this.丝丂丌一万丕丁与三();
        }
        private void 且七丂东丞七一七下()
        {
            UnityEngine.GameObject val_15;
            var val_16;
            UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "ConnectPanel");
            if(val_1 != null)
            {
                    val_1 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_15);
            val_2.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
            val_2.SetActive(value:  false);
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"));
            ConnectionControl val_7 = this.gameObject.AddComponent<ConnectionControl>();
            this.丙不丅丝丙专丕世丐 = val_7;
            val_7.SetConnectPanel(丛丘下丗业丂一且业:  val_2.GetComponent<ConnectPanel>());
            if(val_2 != null)
            {
                    val_16 = val_2.transform;
            }
            else
            {
                    val_16 = val_2.transform;
            }
            
            UnityEngine.Vector3 val_12 = val_2.transform.localPosition;
            UnityEngine.Vector3 val_14 = val_2.transform.localPosition;
            val_16.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void 丝丂丌一万丕丁与三()
        {
            var val_7;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.丝世丅一丞丙丌世一().__InterfaceEnabled != false)
            {
                    this.丝世丅一丞丙丌世一().Hide();
            }
            
            Rilisoft.AbstractGameEventGui.上丁丞丈丅丄东丙丐 = 0;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.不业丙丒丂丞下丆丙()) == 300)
            {
                    if(this.丙不丅丝丙专丕世丐 == 0)
            {
                    this.且七丂东丞七一七下();
            }
            
                GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  19);
                this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::丟上丛三丙丄下丄上()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
                return;
            }
            
            val_7 = null;
            val_7 = null;
            MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  false);
        }
        private void 丞丘三丝专世且丈丐()
        {
            var val_7;
            var val_14 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞()) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞().Count) < 1)
            {
                    return;
            }
            
            val_14 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞();
            List.Enumerator<T> val_5 = val_14.GetEnumerator();
            label_11:
            if(((-553919104) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if(val_8 == null)
            {
                goto label_11;
            }
            
            System.Nullable<System.TimeSpan> val_9 = val_8.丙世丑丅丒丑业与不();
            if(((-553919120) & 1) == 0)
            {
                goto label_11;
            }
            
            System.Nullable<System.TimeSpan> val_10 = val_8.丙世丑丅丒丑业与不();
            if(val_10.HasValue.TotalSeconds > 0f)
            {
                goto label_11;
            }
            
            val_14 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            val_14.丗专丟丂东丝七丈丝();
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        protected Rilisoft.GameEventBuyCurrencyView 丝世丅一丞丙丌世一()
        {
            Rilisoft.GameEventBuyCurrencyView val_4;
            if(this.世丄万丄丐东丟丞丞 == 0)
            {
                    this.世丄万丄丐东丟丞丞 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventBuyCurrencyView>(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丒丘丏上丙丟丑丕丈:  "buy", 丈东丘丏与丌东东下:  this.transform, 丛下丅丏丄且丁一业:  true);
                return val_4;
            }
            
            val_4 = this.世丄万丄丐东丟丞丞;
            return val_4;
        }
        protected System.Collections.Generic.List<GameEventPlayerGot> 丛万丆丅丙丘东丄丕()
        {
            if(this.丕业万与下丅与丈丙 != null)
            {
                    return (System.Collections.Generic.List<GameEventPlayerGot>)val_3;
            }
            
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<GameEventPlayerGot>(source:  this.gameObject.GetComponentsInChildren<GameEventPlayerGot>(includeInactive:  true));
            this.丕业万与下丅与丈丙 = val_3;
            return (System.Collections.Generic.List<GameEventPlayerGot>)val_3;
        }
        internal void 三上丞丅丗专丝东世()
        {
            if(this.GameEventEndingBanner == null)
            {
                    return;
            }
            
            this.GameEventEndingBanner.丈且东丑丂且万丒丅(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        protected AbstractGameEventGui()
        {
        
        }
        private void 丟上丛三丙丄下丄上()
        {
            this.丙不丅丝丙专丕世丐.一丙丅丛丁东丅丅世(上业丈东万下世丝丁:  new System.Action(object:  this, method:  System.Void Rilisoft.AbstractGameEventGui::业丐丕且丛一丟丝丄()), 丏丈丗世丙万丆丐丅:  0, 丐且丘丑与万丞丑丅:  0);
        }
        private void 业丐丕且丛一丟丝丄()
        {
            丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
            UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  MainMenuController.丝业丗上上丘丐与丗(丛丑丂丛丙一上专丆:  false, 世不丛业丟丝与丆丙:  true, 丑丐丗三丒世丏东丅:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七(), 丒不丙万万不丕丞与:  false, 丌与一丌且一不七丆:  false, 丝丅与业且一丛丒一:  false, 丁丟丑丆三丆业一丅:  0, 丅与丏与丙东世丌世:  100));
        }
    
    }

}
