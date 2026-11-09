using UnityEngine;

namespace Rilisoft
{
    internal abstract class GameEventSetsViewBase : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑, 丄世专丆丛世下丟东, 七丌且丛万与丞世丁<Rilisoft.丛且世丐丆上七业丁, Rilisoft.与专丒丞丐一丒丂东>
    {
        // Fields
        private static System.Action 丁丙丆丝七丏丈世丆;
        protected static readonly System.Collections.Generic.Dictionary<string, string> 丗丛与丈丒丄丝一丑;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private Rilisoft.与专丒丞丐一丒丂东 <丝七不世七下世东丄>k__BackingField;
        private System.Action<Rilisoft.且丏上上丛丟七丁下> 上与丁丟与专丞丐丐;
        private Rilisoft.BankShopViewGuiElement 丏万世丂专一丕上丗;
        private UILabel _timeLeftLabel;
        private UnityEngine.GameObject _bankHolder;
        protected Rilisoft.GameEventRewardView _rewardView;
        protected UnityEngine.Transform _subWindowsPlaceHolder;
        
        // Properties
        internal abstract string 丄丂丏世丛丏万三丆 { get; }
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        public virtual Rilisoft.与专丒丞丐一丒丂东 丌且丝丘丌丕东丒与 { get; set; }
        public virtual bool 东且世与一东丂一丆 { get; }
        
        // Methods
        internal static void 丌丈丟丂丈丙一丏丗(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.GameEventSetsViewBase.丁丙丆丝七丏丈世丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丄下丑丑上东与丈丅(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.GameEventSetsViewBase.丁丙丆丝七丏丈世丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal abstract string 丌三不七丌丗丞丌专(); // 0
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual Rilisoft.与专丒丞丐一丒丂东 get_Parameter()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丝七不世七下世东丄>k__BackingField;
        }
        public virtual void set_Parameter(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丝七不世七下世东丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丅东专与不三丂丁丝;
            if(this._bankHolder == 0)
            {
                    return;
            }
            
            if(this._bankHolder.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this._bankHolder.SetActive(value:  false);
            this._bankHolder.SetActive(value:  true);
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
            while(this.上与丁丟与专丞丐丐 != 1152921542781977264);
        
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
            while(this.上与丁丟与专丞丐丐 != 1152921542782113840);
        
        }
        public virtual bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        private void 不丑丆丙一东丐世丈()
        {
            Rilisoft.BankShopViewGuiElement val_4;
            Rilisoft.BankShopViewGuiElement val_5;
            var val_6;
            val_4 = this;
            if(this.丏万世丂专一丕上丗 == 0)
            {
                    val_5 = this.GetComponentInChildren<Rilisoft.BankShopViewGuiElement>();
                this.丏万世丂专一丕上丗 = val_5;
            }
            else
            {
                    val_5 = this.丏万世丂专一丕上丗;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_4 = this.丏万世丂专一丕上丗;
            val_6 = null;
            val_6 = null;
            this.丏万世丂专一丕上丗.desiredCurrency = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        }
        public virtual void ShowWindow()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this.上与丁丟与专丞丐丐 == null)
            {
                    return;
            }
            
            this.上与丁丟与专丞丐丐.Invoke(obj:  1);
        }
        public virtual void HideWindow()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this.上与丁丟与专丞丐丐 == null)
            {
                    return;
            }
            
            this.上与丁丟与专丞丐丐.Invoke(obj:  0);
        }
        protected virtual void Start()
        {
            if(this._bankHolder != 0)
            {
                    if((this._bankHolder.GetComponentInChildren<UIButton>()) != 0)
            {
                    EventDelegate val_5 = null;
                1152921504848912384 = val_5;
                val_5 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(Rilisoft.GameEventSetsViewBase).__il2cppRuntimeField_280));
                EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_2.onClick, 丙不不丒丁丄丄与丛:  val_5);
            }
            
            }
            
            this.不丑丆丙一东丐世丈();
        }
        protected virtual void 且世东下丝上丞丒上()
        {
            string val_9;
            var val_10;
            Rilisoft.AbstractGameEventGui val_1 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_1 == 0)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui.丙丛东世东丌业一丝();
            ButtonClickSound.丁业上丏不丕三丗不();
            if((val_1.Context == null) || (val_1.Context.且丌三丙丙与与丝世() == null))
            {
                goto label_8;
            }
            
            val_9 = val_1.Context.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
            if(val_1 != null)
            {
                goto typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_308;
            }
            
            goto typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_308;
            label_8:
            val_10 = null;
            val_10 = null;
            val_9 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            if(val_1 == null)
            {
                
            }
        
        }
        protected virtual void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            new System.Action() = new System.Action(object:  this, method:  typeof(Rilisoft.GameEventSetsViewBase).__il2cppRuntimeField_2F0);
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        protected virtual void Update()
        {
        
        }
        protected virtual void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        protected virtual void OnDestroy()
        {
        
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventSetsViewBase.丄丌丒丅七东丏丘丕();
        }
        protected virtual void 丗丌丂丙丈丆不丂七()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(this._timeLeftLabel == 0)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLeftLabel, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLeftLabel, 丏业丟一东丂东丘丛:  true);
            this._timeLeftLabel.text = this;
        }
        protected virtual string 丅丅业丏丒丙丒丁丘()
        {
            object val_15;
            string val_16;
            int val_17;
            string val_18;
            val_15 = this;
            if(this == null)
            {
                goto label_3;
            }
            
            System.Nullable<System.TimeSpan> val_1 = this.丙世丑丅丒丑业与不();
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            System.Nullable<System.TimeSpan> val_2 = this.丙世丑丅丒丑业与不();
            if(TotalSeconds <= 0f)
            {
                goto label_5;
            }
            
            System.Nullable<System.TimeSpan> val_4 = this.丙世丑丅丒丑业与不();
            val_15 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            val_16 = "Key_4959";
            goto label_11;
            label_3:
            if(this == null)
            {
                goto label_14;
            }
            
            System.Nullable<System.TimeSpan> val_6 = this.七丆丄丟丟丕三上上();
            if(( & 1) == 0)
            {
                goto label_14;
            }
            
            System.Nullable<System.TimeSpan> val_7 = this.七丆丄丟丟丕三上上();
            if(TotalSeconds <= 0f)
            {
                goto label_21;
            }
            
            if(this != null)
            {
                    if(this.丟丂丞不专丆万丒世() < 1)
            {
                goto label_21;
            }
            
            }
            
            System.Nullable<System.TimeSpan> val_10 = this.七丆丄丟丟丕三上上();
            val_15 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            val_16 = "Key_4734";
            label_11:
            string val_13 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16), arg0:  val_15);
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_18 = "Key_4735");
            label_14:
            val_18 = "Key_4453";
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_18);
            label_5:
            val_17 = System.String.alignConst;
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_18);
            label_21:
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_18);
        }
        protected virtual void 丝东丐丝东三丈世丝()
        {
            goto typeof(Rilisoft.GameEventSetsViewBase).__il2cppRuntimeField_258;
        }
        public void U_BackRequest()
        {
            goto typeof(Rilisoft.GameEventSetsViewBase).__il2cppRuntimeField_2E8;
        }
        public void U_SpinRequest()
        {
            this.U_SpinManyRequest(下丅三丈世丐丕丌丑:  1);
        }
        public void U_SpinManyRequest(int 下丅三丈世丐丕丌丑)
        {
            if(this == null)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                
            }
        
        }
        internal virtual void 与丈不丟丄三七丗上(Rilisoft.GameEventItem 丝丑丏七业上且三丈)
        {
            UnityEngine.Transform val_34;
            if(丝丑丏七业上且三丈.Data.Type == 800)
            {
                    if((丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  丝丑丏七业上且三丈.Data.Id)) != true)
            {
                    if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  丝丑丏七业上且三丈.Data.Id)) == false)
            {
                goto label_14;
            }
            
            }
            
            }
            
            label_25:
            if(丝丑丏七业上且三丈 != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            label_27:
            this._rewardView.ShowAsInfo(一丐丗丁丞丆丅丟丄:  丝丑丏七业上且三丈.Data);
            return;
            label_14:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  丝丑丏七业上且三丈.Data.Id)) == false)
            {
                goto label_21;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  丝丑丏七业上且三丈.Data.Id)) == null)
            {
                goto label_25;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_19 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_17.Id);
            if(new Rilisoft.GameEventItemData() == null)
            {
                goto label_26;
            }
            
            .ItemParams = val_19;
            goto label_27;
            label_21:
            if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丝丑丏七业上且三丈.Data.Id)) != null)
            {
                    Rilisoft.GameEventItemData val_23 = new Rilisoft.GameEventItemData();
                .ItemParams = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  丝丑丏七业上且三丈.Data.Id);
            }
            
            val_34 = this._subWindowsPlaceHolder;
            if(val_34 == null)
            {
                    val_34 = this.gameObject.transform;
            }
            
            Rilisoft.ItemViewer val_33 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_34, 丕丁下丌不万丅丞丛:  丝丑丏七业上且三丈.Data.Id, 丅三丟世下丞丝丙万:  丝丑丏七业上且三丈.Data.Count, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
            return;
            label_26:
            .ItemParams = val_19;
            if(丝丑丏七业上且三丈 != null)
            {
                goto label_44;
            }
            
            goto label_45;
        }
        protected void 东丁丆丄丒丂与一东()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.GameEventSetsViewBase.丁丙丆丝七丏丈世丆;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.GameEventSetsViewBase.丁丙丆丝七丏丈世丆;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        protected GameEventSetsViewBase()
        {
        
        }
        private static GameEventSetsViewBase()
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "cyber_santa_set", value:  "Key_5014");
            }
            else
            {
                    val_1.Add(key:  "cyber_santa_set", value:  "Key_5014");
            }
            
            val_1.Add(key:  "exoskeletons", value:  "Key_5015");
            if(val_1 != null)
            {
                    val_1.Add(key:  "exoskeletons_set2", value:  "Key_5016");
            }
            else
            {
                    val_1.Add(key:  "exoskeletons_set2", value:  "Key_5016");
            }
            
            val_1.Add(key:  "BTroulette", value:  "Key_5479");
            if(val_1 != null)
            {
                    val_1.Add(key:  "HALLOWEEN_2018_SET", value:  "Key_6284");
            }
            else
            {
                    val_1.Add(key:  "HALLOWEEN_2018_SET", value:  "Key_6284");
            }
            
            val_1.Add(key:  "syber_set", value:  "Key_6370");
            if(val_1 != null)
            {
                    val_1.Add(key:  "pilgrim_set", value:  "Key_6473");
            }
            else
            {
                    val_1.Add(key:  "pilgrim_set", value:  "Key_6473");
            }
            
            val_1.Add(key:  "blogger_set", value:  "Key_6470");
            val_1.Add(key:  "big_b_set", value:  "Key_6981");
            Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑 = val_1;
        }
    
    }

}
