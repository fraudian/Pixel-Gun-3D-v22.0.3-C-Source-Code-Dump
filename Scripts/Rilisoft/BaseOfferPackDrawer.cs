using UnityEngine;

namespace Rilisoft
{
    public abstract class BaseOfferPackDrawer : MonoBehaviour, 丄与且丈丘丄三丗丐
    {
        // Fields
        private static UnityEngine.Coroutine 且世丅丌东一丒丁下;
        protected Rilisoft.BonusData 世下丁丗专丘与丏业;
        private string 东不上丐丘丈下丞丏;
        private bool 丌东业丙丞丟丄且与;
        private UnityEngine.Vector3 丘丕丒丌丆业丕丙丅;
        private bool 丙丘万丅三下丈上丌;
        protected System.Collections.Generic.List<Rilisoft.OfferItem> 七丏丏丒丙丘丏丅下;
        protected Rilisoft.业丙丘丆东丈丕丂丄 万与下下丘下与丅丒;
        private UnityEngine.Transform 丗丟丁丕专业丞上丛;
        private System.Nullable<UnityEngine.Vector3> 七与专且丈世丞丕丁;
        private System.Action 上丏七丆丁丝丒东丑;
        private System.Action 丗与一东丑丁下一丘;
        private bool <世丏丑一丛丄东专上>k__BackingField;
        private static UnityEngine.Coroutine 丝下且丙七丆丘丈丑;
        private decimal 丄丛世丅丞丙专丙不;
        private UnityEngine.Transform _pixelMansContainer;
        private UITweener[] _tweensHide;
        private float _animationTime;
        protected UnityEngine.GameObject _windowObject;
        protected Rilisoft.TextGroup _headerText;
        protected Rilisoft.TextGroup _subHeaderText;
        protected UnityEngine.GameObject _timerBar;
        private int _timeBarPowerPosition;
        private int _timeBarBasePosition;
        protected Rilisoft.TextGroup _descriptionText;
        protected UILabel[] _offerPriceLabels;
        protected UILabel[] _offerRegularPriceLabels;
        protected UnityEngine.GameObject _saleContainer;
        protected UILabel _saleTopLabel;
        protected UILabel _saleBottomLabel;
        protected UnityEngine.GameObject _timeLeftObject;
        protected UILabel _timeLeftLabel;
        private UnityEngine.GameObject _pcsLeftObject;
        protected UILabel _pcsLeftLabel;
        private UITable[] _buttonPackTables;
        private UnityEngine.GameObject _buttonOfferObject;
        private UnityEngine.GameObject _buttonPackObject;
        private int _defaultPixelman;
        
        // Properties
        public Rilisoft.业丙丘丆东丈丕丂丄 与丄丏丞业三与东丗 { get; }
        public Rilisoft.BonusData 丙丘专丝丄下下七丅 { get; }
        public bool 丗七丟丏丏丑丞丅东 { get; set; }
        public bool 丕丆下东丁丒丁丕丈 { get; }
        public string 专丕与丒丗丁丘专丟 { get; }
        public abstract int 下丄丈不与世丐业专 { get; }
        
        // Methods
        public void add_HideRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上丏七丆丁丝丒东丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上丏七丆丁丝丒东丑 != 1152921543272357816);
        
        }
        public void remove_HideRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上丏七丆丁丝丒东丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上丏七丆丁丝丒东丑 != 1152921543272494392);
        
        }
        public void add_BuyRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丗与一东丑丁下一丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗与一东丑丁下一丘 != 1152921543272630976);
        
        }
        public void remove_BuyRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丗与一东丑丁下一丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗与一东丑丁下一丘 != 1152921543272767552);
        
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 get_Pack()
        {
            return (Rilisoft.业丙丘丆东丈丕丂丄)this.万与下下丘下与丅丒;
        }
        public Rilisoft.BonusData get_BonusData()
        {
            return (Rilisoft.BonusData)this.世下丁丗专丘与丏业;
        }
        public bool get_DisableAnimations()
        {
            return (bool)this.<世丏丑一丛丄东专上>k__BackingField;
        }
        public void set_DisableAnimations(bool 丙业与丙丗丝不丈东)
        {
            this.<世丏丑一丛丄东专上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_AnimationsRunning()
        {
            return (bool)this.丌东业丙丞丟丄且与;
        }
        public virtual bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            Rilisoft.BaseOfferPackDrawer val_14;
            var val_15;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_16;
            var val_17;
            val_14 = this;
            .丝且与丝丒丟万丁专 = val_14;
            this.万与下下丘下与丅丒 = 不专一业下丞丝丑丗;
            this.世下丁丗专丘与丏业 = 丛丝丙丄七一丁丅三;
            val_15 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonOfferObject, 丏业丟一东丂东丘丛:  (丛丝丙丄七一丁丅三 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonPackObject, 丏业丟一东丂东丘丛:  (this.世下丁丗专丘与丏业 == 0) ? 1 : 0);
            if(this.世下丁丗专丘与丏业 != null)
            {
                    val_16 = this.东不丕与丙丗丆丏丄();
            }
            else
            {
                    this.万与下下丘下与丅丒.丘丞丒丈丕丐丕一丄();
                System.Collections.Generic.List<Rilisoft.OfferItem> val_5 = this.万与下下丘下与丅丒.丏与丅专三丙与丘丒();
                if(val_5 != null)
            {
                    val_16 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  val_5);
            }
            else
            {
                    System.Collections.Generic.List<Rilisoft.OfferItem> val_7 = null;
                val_16 = val_7;
                val_7 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            }
            
            }
            
            this.七丏丏丒丙丘丏丅下 = val_16;
            if(val_16 == null)
            {
                goto label_10;
            }
            
            val_17 = val_16;
            if(val_7.Count == 0)
            {
                    return (bool)val_17;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丌东业丙丞丟丄且与 = false;
            this.丙丘万丅三下丈上丌 = true;
            this.丒一丏丄丝且丑万丏();
            this.三丛丆上丈丆丗丆专();
            this.丆丝丌丞丐丈丟不上();
            this.且东丝丟丙专丄丒丂();
            this.丝丛丙丏丈上丆丁与();
            this.三上世业东丁丒丟丁();
            val_16 = this.gameObject.GetComponentsInChildren<UIPanel>();
            val_15 = 0;
            .丕丗丒丞丙丑丟一丗 = val_16;
            goto label_15;
            label_20:
            UIPanel val_14 = (BaseOfferPackDrawer.丒丂万丒丂一上丞一)[1152921543273693648].丕丗丒丞丙丑丟一丗[0];
            (BaseOfferPackDrawer.丒丂万丒丂一上丞一)[1152921543273693648].丕丗丒丞丙丑丟一丗[0x0][0].widgetsAreStatic = true;
            val_16 = (BaseOfferPackDrawer.丒丂万丒丂一上丞一)[1152921543273693648].丕丗丒丞丙丑丟一丗;
            val_15 = 1;
            label_15:
            if(val_15 < (BaseOfferPackDrawer.丒丂万丒丂一上丞一)[1152921543273693648].丕丗丒丞丙丑丟一丗.Length)
            {
                goto label_20;
            }
            
            System.Action val_12 = null;
            val_14 = val_12;
            val_12 = new System.Action(object:  new BaseOfferPackDrawer.丒丂万丒丂一上丞一(), method:  System.Void BaseOfferPackDrawer.丒丂万丒丂一上丞一::丆且丒丗丈丞丈丘且());
            Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._animationTime, 丌专业且丛丏丞丝且:  val_12);
            val_17 = 1;
            return (bool)val_17;
            label_10:
            val_17 = 0;
            return (bool)val_17;
        }
        public virtual void Hide(System.Action 不丐世丞丏且丛丐业)
        {
            UITweener val_3;
            if((this._tweensHide != null) && (this._tweensHide.Length != 0))
            {
                    if(this._tweensHide.Length >= 1)
            {
                    do
            {
                val_3 = this._tweensHide[0];
                val_3.PlayForward();
            }
            while((0 + 1) < this._tweensHide.Length);
            
            }
            
                Rilisoft.BaseOfferPackDrawer.丝下且丙七丆丘丈丑 = this.StartCoroutine(routine:  this.丈丒不下且丌世丑丘(不丐世丞丏且丛丐业:  不丐世丞丏且丛丐业));
                this.不业丗三丐丂丏七下();
                return;
            }
            
            不丐世丞丏且丛丐业.Invoke();
        }
        private System.Collections.IEnumerator 丈丒不下且丌世丑丘(System.Action 不丐世丞丏且丛丐业)
        {
            BaseOfferPackDrawer.丏丁丕丐不丝丌丂不 val_1 = new BaseOfferPackDrawer.丏丁丕丐不丝丌丂不();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .不丐世丞丏且丛丐业 = 不丐世丞丏且丛丐业;
            return (System.Collections.IEnumerator)val_1;
        }
        public virtual void HideForce()
        {
            if(this.gameObject == 0)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        public string get_Name()
        {
            return 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        }
        public abstract int get_Id(); // 0
        public void Destroy()
        {
            if(this.gameObject.activeSelf != false)
            {
                    this.gameObject.transform.SetParent(p:  0);
                this.gameObject.SetActive(value:  false);
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        protected virtual void Awake()
        {
        
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void Update()
        {
            UITable val_4;
            UnityEngine.Object val_5;
            val_4 = this;
            if(this.丙丘万丅三下丈上丌 == false)
            {
                    return;
            }
            
            if(this._buttonPackTables == null)
            {
                    return;
            }
            
            this.丙丘万丅三下丈上丌 = false;
            if(this._buttonPackTables.Length < 1)
            {
                    return;
            }
            
            label_14:
            val_4 = this._buttonPackTables[0];
            if(val_4 == 0)
            {
                goto label_7;
            }
            
            Rilisoft.UIScaller val_2 = val_4.GetComponent<Rilisoft.UIScaller>();
            val_5 = 0;
            if(val_2 != val_5)
            {
                    val_5 = 0;
                val_2.Execute();
            }
            
            if(val_4 == null)
            {
                goto label_13;
            }
            
            val_4.repositionNow = true;
            label_7:
            if((0 + 1) < this._buttonPackTables.Length)
            {
                goto label_14;
            }
            
            return;
            label_13:
        }
        protected virtual void OnEnable()
        {
            this.StopCoroutine(routine:  this.丘丗丈丛下一且世丐());
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
        }
        protected virtual void OnDisable()
        {
            if(Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下);
                Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下 = 0;
            }
            
            this.丌东业丙丞丟丄且与 = false;
            if((this.七与专且丈世丞丕丁 & 1) == 0)
            {
                    return;
            }
            
            this._windowObject.transform.position = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        }
        protected virtual void OnDestroy()
        {
            if(Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下);
                Rilisoft.BaseOfferPackDrawer.且世丅丌东一丒丁下 = 0;
            }
            
            if(Rilisoft.BaseOfferPackDrawer.丝下且丙七丆丘丈丑 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  Rilisoft.BaseOfferPackDrawer.丝下且丙七丆丘丈丑);
            Rilisoft.BaseOfferPackDrawer.丝下且丙七丆丘丈丑 = 0;
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BaseOfferPackDrawer.丞下丙丈丄业丙专丘();
        }
        protected virtual void 丟且丆丙丆丁丆一万()
        {
        
        }
        protected void 东不丞丂万下三与丕()
        {
            UnityEngine.Object val_19;
            if((this.七与专且丈世丞丕丁 & 1) == 0)
            {
                    val_19 = this._windowObject.transform;
                UnityEngine.Vector3 val_2 = val_19.position;
                this.七与专且丈世丞丕丁 = 0;
                mem[1152921543275824688] = 0;
            }
            
            this.丗丟丁丕专业丞上丛 = 0;
            if((this.<世丏丑一丛丄东专上>k__BackingField) == true)
            {
                    return;
            }
            
            val_19 = Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世();
            if(val_19 == 0)
            {
                    return;
            }
            
            if(Rilisoft.OfferPackWindow.丘世丆丐丒一丙丝丙() == 0)
            {
                goto label_12;
            }
            
            this.丗丟丁丕专业丞上丛 = Rilisoft.OfferPackWindow.丘世丆丐丒一丙丝丙();
            Rilisoft.OfferPackWindow.丅业丂丒七丌丒丙丟(丙业与丙丗丝不丈东:  0);
            goto label_25;
            label_12:
            if(this.世下丁丗专丘与丏业 == null)
            {
                goto label_16;
            }
            
            Rilisoft.InAppBonusLobbyController val_8 = Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世();
            if(val_8 != null)
            {
                goto label_27;
            }
            
            label_28:
            label_27:
            this.丗丟丁丕专业丞上丛 = val_8.GetOfferButtonPositionByOfferId(丂东丄丏丕丕丅上一:  this.世下丁丗专丘与丏业.Key);
            label_25:
            val_19 = this.丗丟丁丕专业丞上丛;
            if(val_19 == 0)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.下丏且一三丐一丐不());
            this.丌东业丙丞丟丄且与 = false;
            val_19 = this._windowObject.transform;
            UnityEngine.Vector3 val_13 = this.丗丟丁丕专业丞上丛.position;
            val_19.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.丘丕丒丌丆业丕丙丅 = val_13;
            mem[1152921543275824640] = val_13.y;
            mem[1152921543275824644] = val_13.z;
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.下丏且一三丐一丐不());
            return;
            label_16:
            if(this.万与下下丘下与丅丒 == null)
            {
                goto label_25;
            }
            
            string val_18 = "offer-"("offer-") + this.万与下下丘下与丅丒.业上丙丞丐丄丆丅七();
            if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世() != null)
            {
                goto label_27;
            }
            
            goto label_28;
        }
        protected void 不业丗三丐丂丏七下()
        {
            if(this.丗丟丁丕专业丞上丛 == 0)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.下丏且一三丐一丐不());
            this.丌东业丙丞丟丄且与 = false;
            UnityEngine.Vector3 val_3 = this.丗丟丁丕专业丞上丛.position;
            this.丘丕丒丌丆业丕丙丅 = val_3;
            mem[1152921543276047232] = val_3.y;
            mem[1152921543276047236] = val_3.z;
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.下丏且一三丐一丐不());
        }
        private System.Collections.IEnumerator 下丏且一三丐一丐不()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BaseOfferPackDrawer.不业业丙丐丂丆丞丈();
        }
        public void U_Buy()
        {
            if(this.丗与一东丑丁下一丘 == null)
            {
                    return;
            }
            
            this.丗与一东丑丁下一丘.Invoke();
        }
        public void U_Hide()
        {
            if(this.上丏七丆丁丝丒东丑 == null)
            {
                    return;
            }
            
            this.上丏七丆丁丝丒东丑.Invoke();
        }
        private System.Collections.Generic.List<Rilisoft.OfferItem> 东不丕与丙丗丆丏丄()
        {
            var val_10;
            Rilisoft.BonusData val_42;
            System.Collections.Generic.List<T> val_43;
            Rilisoft.OfferItem val_44;
            Rilisoft.BonusData val_45;
            int val_46;
            var val_47;
            Rilisoft.BonusData val_48;
            var val_49;
            var val_50;
            Rilisoft.BonusData val_51;
            Rilisoft.OfferItem val_53;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = null;
            val_43 = val_1;
            val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(this.世下丁丗专丘与丏业 == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_43;
            }
            
            val_44 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.世下丁丗专丘与丏业.PetId)) != true)
            {
                    val_45 = this.世下丁丗专丘与丏业;
                if(this.世下丁丗专丘与丏业 == null)
            {
                    val_45 = this.世下丁丗专丘与丏业;
                if(val_45 == null)
            {
                goto label_124;
            }
            
            }
            
                val_46 = this.世下丁丗专丘与丏业.Quantity;
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  80, 丞一丁业丄一一业且:  this.世下丁丗专丘与丏业.PetId, 丂丕丂丏专丂丄丕且:  val_46));
            }
            
            val_44 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.世下丁丗专丘与丏业.WeaponId)) != true)
            {
                    Rilisoft.OfferItem val_5 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  10, 丞一丁业丄一一业且:  this.世下丁丗专丘与丏业.WeaponId, 丂丕丂丏专丂丄丕且:  1);
                val_44 = val_5;
                val_1.Add(item:  val_5);
            }
            
            if(this.世下丁丗专丘与丏业.LeprechaunPerDay >= 1)
            {
                    Rilisoft.OfferItem val_6 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  1020, 丞一丁业丄一一业且:  System.String.alignConst, 丂丕丂丏专丂丄丕且:  1);
                val_44 = val_6;
                val_1.Add(item:  val_6);
            }
            
            if(this.世下丁丗专丘与丏业.Gadgets == null)
            {
                goto label_32;
            }
            
            val_44 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            if(this.世下丁丗专丘与丏业.Gadgets.Count < 1)
            {
                goto label_32;
            }
            
            List.Enumerator<T> val_8 = this.世下丁丗专丘与丏业.Gadgets.GetEnumerator();
            val_46 = 1152921519126359200;
            val_47 = 1152921537134046960;
            label_26:
            if((15312368 & 1) == 0)
            {
                goto label_24;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  70, 丞一丁业丄一一业且:  val_10.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
            val_1.Add(item:  new Rilisoft.OfferItem());
            goto label_26;
            label_24:
            val_44 = public System.Void List.Enumerator<System.String>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_32:
            if(this.世下丁丗专丘与丏业.Royales == null)
            {
                goto label_48;
            }
            
            val_44 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            if(this.世下丁丗专丘与丏业.Royales.Count < 1)
            {
                goto label_48;
            }
            
            List.Enumerator<T> val_14 = this.世下丁丗专丘与丏业.Royales.GetEnumerator();
            val_46 = 1152921519126359200;
            val_47 = 1152921537134046960;
            label_42:
            if((15312368 & 1) == 0)
            {
                goto label_40;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  56, 丞一丁业丄一一业且:  val_10.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
            val_1.Add(item:  new Rilisoft.OfferItem());
            goto label_42;
            label_40:
            val_44 = public System.Void List.Enumerator<System.String>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_48:
            if(this.世下丁丗专丘与丏业.VipSeconds >= 1)
            {
                    Rilisoft.OfferItem val_17 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  36, 丞一丁业丄一一业且:  "VIPseconds", 丂丕丂丏专丂丄丕且:  this.世下丁丗专丘与丏业.VipSeconds);
                val_44 = val_17;
                val_1.Add(item:  val_17);
            }
            
            if(this.世下丁丗专丘与丏业.BattlePassCurrency >= 1)
            {
                    Rilisoft.OfferItem val_18 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  86, 丞一丁业丄一一业且:  "BattlePassCurrency", 丂丕丂丏专丂丄丕且:  this.世下丁丗专丘与丏业.BattlePassCurrency);
                val_44 = val_18;
                val_1.Add(item:  val_18);
            }
            
            if(this.世下丁丗专丘与丏业.WeaponDetails >= 1)
            {
                    val_48 = this.世下丁丗专丘与丏业;
                if(this.世下丁丗专丘与丏业 == null)
            {
                    val_48 = this.世下丁丗专丘与丏业;
                if(val_48 == null)
            {
                goto label_124;
            }
            
            }
            
                Rilisoft.OfferItem val_19 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  this.世下丁丗专丘与丏业.WeaponDetailsTag, 丂丕丂丏专丂丄丕且:  this.世下丁丗专丘与丏业.WeaponDetails);
            }
            
            if(this.世下丁丗专丘与丏业.EventCurrencies == null)
            {
                goto label_62;
            }
            
            val_47 = 1152921543276692368;
            val_49 = 1152921505459986432;
            val_50 = 0;
            goto label_63;
            label_76:
            EventCurrencyData val_20 = this.世下丁丗专丘与丏业.EventCurrencies.Item[0];
            if(val_20.Count >= 1)
            {
                    val_46 = val_20.EventType;
                Rilisoft.丛且世丐丆上七业丁 val_22 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  val_46);
                if(val_22 != null)
            {
                    Rilisoft.GameEventData val_23 = val_22.丁专丗万三上丟三丆();
                val_46 = val_43;
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  26, 丞一丁业丄一一业且:  val_23.EventId, 丂丕丂丏专丂丄丕且:  val_20.Count));
            }
            
            }
            
            val_50 = 1;
            label_63:
            if(val_50 < this.世下丁丗专丘与丏业.EventCurrencies.Count)
            {
                goto label_76;
            }
            
            label_62:
            val_43 = val_43;
            val_44 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.世下丁丗专丘与丏业.DetailsItemId)) != true)
            {
                    val_51 = this.世下丁丗专丘与丏业;
                if(this.世下丁丗专丘与丏业 == null)
            {
                    val_51 = this.世下丁丗专丘与丏业;
                if(val_51 == null)
            {
                goto label_124;
            }
            
            }
            
                val_46 = this.世下丁丗专丘与丏业.DetailsCount;
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  this.世下丁丗专丘与丏业.DetailsItemId, 丂丕丂丏专丂丄丕且:  val_46));
            }
            
            if((this.世下丁丗专丘与丏业.Wears == null) || (this.世下丁丗专丘与丏业.Wears.Count < 1))
            {
                goto label_88;
            }
            
            List.Enumerator<T> val_29 = this.世下丁丗专丘与丏业.Wears.GetEnumerator();
            label_102:
            if((15312368 & 1) == 0)
            {
                goto label_91;
            }
            
            string val_30 = val_10.丐丏七丌丕丗业且上();
            int val_31 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_30);
            if((val_31 & 2147483648) != 0)
            {
                goto label_102;
            }
            
            if((val_31 - 6) > 6)
            {
                goto label_99;
            }
            
            var val_41 = 106040236 + ((val_31 - 6)) << 2;
            val_41 = val_41 + 106040236;
            goto (106040236 + ((val_31 - 6)) << 2 + 106040236);
            label_99:
            if((15312360 & 1) == 0)
            {
                goto label_102;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  0, 丞一丁业丄一一业且:  val_30, 丂丕丂丏专丂丄丕且:  1);
            val_1.Add(item:  new Rilisoft.OfferItem());
            goto label_102;
            label_88:
            val_53 = 0;
            label_146:
            var val_42 = 0;
            label_148:
            if((this.世下丁丗专丘与丏业.LobbyItems == null) || (this.世下丁丗专丘与丏业.LobbyItems.Count < 1))
            {
                goto label_143;
            }
            
            List.Enumerator<T> val_35 = this.世下丁丗专丘与丏业.LobbyItems.GetEnumerator();
            val_47 = 1152921519126359200;
            val_49 = 1152921537134046960;
            label_115:
            if((15312368 & 1) == 0)
            {
                goto label_110;
            }
            
            string val_36 = val_10.丐丏七丌丕丗业且上();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_36)) == true)
            {
                goto label_115;
            }
            
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  85, 丞一丁业丄一一业且:  val_36, 丂丕丂丏专丂丄丕且:  1);
            val_1.Add(item:  new Rilisoft.OfferItem());
            goto label_115;
            label_110:
            val_42 = val_42 + 1;
            mem2[0] = 1080;
            goto label_116;
            label_91:
            val_55 = 0;
            val_56 = 0;
            goto label_117;
            label_116:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(W24 == 1)
            {
                goto label_127;
            }
            
            if(( == 0) || ((15312304 + (W24) << 2) == 1080))
            {
                goto label_143;
            }
            
            label_142:
            label_143:
            if(this.世下丁丗专丘与丏业.Gems >= 1)
            {
                    val_57 = null;
                val_57 = null;
                val_46 = this.世下丁丗专丘与丏业.Gems;
                Rilisoft.OfferItem val_39 = null;
                val_53 = val_39;
                val_39 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  232, 丞一丁业丄一一业且:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丂丕丂丏专丂丄丕且:  val_46);
                val_1.Add(item:  val_39);
            }
            
            val_42 = this.世下丁丗专丘与丏业;
            if(this.世下丁丗专丘与丏业.Coins < 1)
            {
                    return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_43;
            }
            
            val_58 = null;
            val_58 = null;
            val_42 = this.世下丁丗专丘与丏业;
            val_53 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  242, 丞一丁业丄一一业且:  val_53, 丂丕丂丏专丂丄丕且:  this.世下丁丗专丘与丏业.Coins));
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_43;
            label_127:
            if( != 0)
            {
                goto label_142;
            }
            
            goto label_143;
            label_124:
            if(val_44 != 1)
            {
                goto label_144;
            }
            
            val_56 = 1179403647;
            val_55 = 0;
            label_117:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_55 != 1)
            {
                    if(965 == 965)
            {
                goto label_146;
            }
            
            }
            
            if(val_56 == 0)
            {
                goto label_148;
            }
            
            goto label_148;
            label_144:
        }
        private void 丒一丏丄丝且丑万丏()
        {
            string val_11;
            string val_12;
            if(this.世下丁丗专丘与丏业 == null)
            {
                goto label_1;
            }
            
            val_11 = this.世下丁丗专丘与丏业.Action;
            val_12 = 0;
            if((System.String.op_Equality(a:  val_11, b:  "pet")) == false)
            {
                goto label_23;
            }
            
            val_12 = this.世下丁丗专丘与丏业.PetId;
            goto label_23;
            label_1:
            if(this.万与下下丘下与丅丒 == null)
            {
                goto label_5;
            }
            
            val_11 = this.万与下下丘下与丅丒.业上丙丞丐丄丆丅七();
            if(this._subHeaderText != 0)
            {
                    this._subHeaderText.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3873");
            }
            
            if(this.万与下下丘下与丅丒.丁专丗万三上丟三丆() == null)
            {
                goto label_13;
            }
            
            val_12 = 0;
            if(this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 120)
            {
                goto label_23;
            }
            
            Rilisoft.七丈业与与不七丈丟 val_7 = this.万与下下丘下与丅丒.丁专丗万三上丟三丆();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(丟丅丘丂丆丘三丟丄:  this._headerText, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7.丒上一丁丆丛东专丙.三丁丟丈丙上一丕三));
            return;
            label_5:
            val_12 = 0;
            val_11 = 0;
            goto label_23;
            label_13:
            val_12 = 0;
            label_23:
            if(this._headerText == 0)
            {
                    return;
            }
            
            this._headerText.Text = Rilisoft.Offers.丁且丕专万丈丒丏丗.丈七下丗万七不不一(丗丟丁丐与下丙丕丛:  val_11, 丐丁不丆丘丂丐丈丆:  val_12);
        }
        private void 三丛丆上丈丆丗丆专()
        {
            int val_30;
            string val_31;
            string val_33;
            object val_34;
            var val_35;
            var val_37;
            var val_38;
            val_30 = System.String.alignConst;
            if(this.世下丁丗专丘与丏业 == null)
            {
                goto label_1;
            }
            
            val_31 = this.世下丁丗专丘与丏业.Action;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_31)) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  "currence")) == false)
            {
                goto label_6;
            }
            
            val_31 = System.String.alignConst;
            goto label_54;
            label_1:
            if(this.万与下下丘下与丅丒 == null)
            {
                goto label_52;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
            {
                    if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                goto label_14;
            }
            
            }
            
            if(this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 60)
            {
                    if(this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 90)
            {
                goto label_16;
            }
            
            }
            
            label_14:
            val_31 = this._descriptionText.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
            goto label_52;
            label_6:
            bool val_8 = System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  "gadget");
            if(this.世下丁丗专丘与丏业 == null)
            {
                goto label_22;
            }
            
            if(val_8 == false)
            {
                goto label_23;
            }
            
            label_27:
            label_46:
            string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2904");
            goto label_26;
            label_22:
            if(val_8 == true)
            {
                goto label_27;
            }
            
            label_23:
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  "pet")) == false)
            {
                goto label_28;
            }
            
            val_31 = val_30;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.世下丁丗专丘与丏业.PetId)) == null)
            {
                goto label_54;
            }
            
            string val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2903");
            val_34 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_12.Lkey);
            goto label_34;
            label_16:
            if(this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 120)
            {
                goto label_36;
            }
            
            val_31 = this._descriptionText;
            val_35 = null;
            val_35 = null;
            string val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  且丙丙丈丙丄丌丌不.三三丕下三丏丙丞丝);
            goto label_41;
            label_28:
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  "weapon")) == false)
            {
                goto label_43;
            }
            
            goto label_46;
            label_36:
            decimal val_18 = this.万与下下丘下与丅丒.丕丗丁七下且与丝万();
            val_31 = this._descriptionText;
            val_30 = BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_18.flags, hi = val_18.hi, lo = val_18.lo, mid = val_18.mid}, 七丏丂丈世万丈上丕:  "F0");
            label_41:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(丟丅丘丂丆丘三丟丄:  val_31, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3695"), arg1:  val_30));
            goto label_52;
            label_43:
            val_31 = val_30;
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  "leprechaun")) == false)
            {
                goto label_54;
            }
            
            val_34 = this.世下丁丗专丘与丏业.LeprechaunPerDay;
            val_33 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2898");
            label_34:
            label_26:
            val_31 = System.String.Format(format:  val_33, arg0:  this.世下丁丗专丘与丏业.LeprechaunPerDay);
            label_54:
            this._descriptionText.Text = val_31;
            label_52:
            val_37 = 0;
            goto label_59;
            label_77:
            UILabel val_30 = this._offerRegularPriceLabels[0];
            if(val_30 == 0)
            {
                goto label_68;
            }
            
            val_30.text = val_30;
            if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1))
            {
                goto label_68;
            }
            
            val_38 = 0;
            goto label_71;
            label_75:
            val_31 = val_30.gameObject.GetComponentsInChildren<UISprite>()[0];
            val_31.enabled = false;
            val_38 = 1;
            label_71:
            if(val_38 < val_29.Length)
            {
                goto label_75;
            }
            
            label_68:
            val_37 = 1;
            label_59:
            if(val_37 < this._offerRegularPriceLabels.Length)
            {
                goto label_77;
            }
        
        }
        private void 丆丝丌丞丐丈丟不上()
        {
            UILabel[] val_4;
            Rilisoft.BonusData val_5;
            var val_6;
            val_4 = this;
            val_5 = this.世下丁丗专丘与丏业;
            if(val_5 == null)
            {
                goto label_1;
            }
            
            val_6 = null;
            val_5 = this.世下丁丗专丘与丏业;
            if(val_5 == null)
            {
                goto label_4;
            }
            
            val_6 = null;
            Rilisoft.与丗丌丑专业丝丛丏 val_1 = StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  this.世下丁丗专丘与丏业.BonusId);
            goto label_6;
            label_1:
            if(this.万与下下丘下与丅丒 == null)
            {
                    return;
            }
            
            Rilisoft.与丗丌丑专业丝丛丏 val_2 = this.万与下下丘下与丅丒.丄丑且丆上丛丁且七();
            label_6:
            if(val_2 == null)
            {
                    return;
            }
            
            val_4 = this._offerPriceLabels;
            if(val_4 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_4, 丕丗丘丑丛与丑业丒:  val_2.丟丂丞不专丆万丒世());
            return;
            label_4:
        }
        private void 且东丝丟丙专丄丒丂()
        {
            int val_15;
            var val_16;
            int val_17;
            var val_18;
            var val_19;
            if(this.世下丁丗专丘与丏业 != null)
            {
                    val_15 = this.世下丁丗专丘与丏业.Profit;
                val_16 = 137134080;
                decimal val_1 = System.Math.Abs(value:  new System.Decimal() {flags = val_15, hi = val_15, lo = 137134080});
            }
            else
            {
                    val_15 = this.万与下下丘下与丅丒;
                if(val_15 == null)
            {
                goto label_26;
            }
            
                val_16 = 0;
                decimal val_2 = val_15.丐丁丒世丟世丘丌丅();
            }
            
            val_17 = val_2.lo;
            label_26:
            this.丄丛世丅丞丙专丙不 = val_2;
            mem[1152921543278546388] = val_17;
            mem[1152921543278546392] = val_2.mid;
            val_18 = null;
            val_18 = null;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_17, mid = val_2.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleContainer, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleContainer, 丏业丟一东丂东丘丛:  true);
            val_19 = null;
            val_19 = null;
            decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_17, mid = val_2.mid});
            decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
            decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal());
            decimal val_7 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, 专丂丕丗丗东世丞下:  5);
            bool val_8 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid}, d2:  new System.Decimal());
            string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3764");
            val_17 = System.String.Format(format:  "{0}%", arg0:  val_7.flags.ToString(format:  "0"));
            if(val_9.Length > 5)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._saleTopLabel, 丕丗丘丑丛与丑业丒:  val_9);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._saleBottomLabel, 丕丗丘丑丛与丑业丒:  val_17);
            }
            else
            {
                    this._saleTopLabel.text = val_17;
                this._saleBottomLabel.text = val_9;
            }
            
            this.东不上丐丘丈下丞丏 = System.String.Format(format:  "{0}{1}{2}", arg0:  val_9, arg1:  System.Environment.NewLine, arg2:  val_17);
        }
        protected void 丝丛丙丏丈上丆丁与()
        {
            UILabel val_18;
            string val_19;
            string val_20;
            UILabel val_21;
            string val_22;
            string val_23;
            val_18 = this;
            if(this.世下丁丗专丘与丏业 == null)
            {
                goto label_1;
            }
            
            if(this.世下丁丗专丘与丏业.IsTypePack == false)
            {
                goto label_2;
            }
            
            val_19 = "Key_2864";
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  this.世下丁丗专丘与丏业.Action);
            if(val_1 > 2014462896)
            {
                goto label_3;
            }
            
            if(val_1 > 1766558334)
            {
                goto label_4;
            }
            
            if(val_1 == 1701332399)
            {
                goto label_5;
            }
            
            if(val_1 != 1766558334)
            {
                goto label_47;
            }
            
            val_20 = "pet";
            goto label_46;
            label_1:
            if(this.万与下下丘下与丅丒 == null)
            {
                    return;
            }
            
            this.丝东世丈丝丆丛世丈(丅下专丄丐丙下丒丅:  false);
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            System.Nullable<System.TimeSpan> val_3 = this.万与下下丘下与丅丒.丙世丑丅丒丑业与不();
            val_21;
            if(this.万与下下丘下与丅丒 == null)
            {
                goto label_13;
            }
            
            if((val_21 & 1) == 0)
            {
                goto label_14;
            }
            
            label_35:
            System.Nullable<System.TimeSpan> val_4 = this.万与下下丘下与丅丒.丙世丑丅丒丑业与不();
            double val_5 = val_4.HasValue.TotalSeconds;
            goto label_15;
            label_2:
            this.丝东世丈丝丆丛世丈(丅下专丄丐丙下丒丅:  false);
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            val_18 = this._timeLeftLabel;
            int val_7 = this.世下丁丗专丘与丏业.End;
            val_22 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            goto label_23;
            label_3:
            if(val_1 > (-844536739))
            {
                goto label_24;
            }
            
            if(val_1 == (-844536739))
            {
                goto label_25;
            }
            
            if(val_1 != 2053176545)
            {
                goto label_47;
            }
            
            val_20 = "craft_lobby_items";
            goto label_46;
            label_4:
            if(val_1 == 1865621569)
            {
                goto label_28;
            }
            
            if(val_1 != 2014462896)
            {
                goto label_47;
            }
            
            val_20 = "vip";
            goto label_46;
            label_24:
            if(val_1 == (-349333172))
            {
                goto label_31;
            }
            
            if(val_1 == (-457432930))
            {
                goto label_32;
            }
            
            if(val_1 != (-638418966))
            {
                goto label_47;
            }
            
            val_23 = "currence";
            goto label_34;
            label_13:
            if((val_21 & 1) != 0)
            {
                goto label_35;
            }
            
            label_14:
            Rilisoft.七丈业与与不七丈丟 val_9 = this.万与下下丘下与丅丒.丁专丗万三上丟三丆();
            label_15:
            val_18 = this._timeLeftLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            return;
            label_5:
            val_20 = "event_currence";
            goto label_46;
            label_25:
            val_23 = "gadget";
            label_34:
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  val_23)) == false)
            {
                goto label_47;
            }
            
            goto label_48;
            label_28:
            val_20 = "weapon";
            goto label_46;
            label_31:
            val_20 = "leprechaun";
            goto label_46;
            label_32:
            val_20 = "wear";
            label_46:
            if((System.String.op_Equality(a:  this.世下丁丗专丘与丏业.Action, b:  val_20)) == false)
            {
                goto label_47;
            }
            
            val_19 = "Key_2896";
            goto label_48;
            label_47:
            object[] val_13 = new object[1];
            val_13[0] = this.世下丁丗专丘与丏业.Action;
            UnityEngine.Debug.LogErrorFormat(format:  "UpdateItemsLeft Unknown action type:  {0}", args:  val_13);
            label_48:
            this.丝东世丈丝丆丛世丈(丅下专丄丐丙下丒丅:  true);
            val_21 = this._pcsLeftLabel;
            val_18 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.世下丁丗专丘与丏业.Pack));
            val_22 = val_18;
            label_23:
            val_21.text = val_22;
        }
        private void 丝东世丈丝丆丛世丈(bool 丅下专丄丐丙下丒丅)
        {
            UnityEngine.GameObject val_6;
            UnityEngine.GameObject val_7;
            var val_8;
            UnityEngine.GameObject val_9;
            if((this.万与下下丘下与丅丒 != null) && (this.万与下下丘下与丅丒.不丌上丟不下丒与世 == 30000))
            {
                    val_6 = 1152921505284374528;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._pcsLeftObject, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  false);
                if(this._subHeaderText == 0)
            {
                    return;
            }
            
                val_7 = this._subHeaderText.gameObject;
                val_8 = 1;
                val_9 = val_7;
            }
            else
            {
                    val_6 = this._pcsLeftObject;
                丅下专丄丐丙下丒丅 = 丅下专丄丐丙下丒丅;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  丅下专丄丐丙下丒丅);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  (~丅下专丄丐丙下丒丅) & 1);
                if(this._subHeaderText == 0)
            {
                    return;
            }
            
                val_7 = this._subHeaderText.gameObject;
                val_9 = val_7;
                val_8 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
        }
        private void 三上世业东丁丒丟丁()
        {
            UnityEngine.GameObject val_39;
            var val_40;
            var val_42;
            string val_43;
            UnityEngine.Object val_44;
            UnityEngine.GameObject val_45;
            var val_46;
            var val_47;
            val_39 = this;
            if(this._pixelMansContainer != 0)
            {
                goto label_5;
            }
            
            val_40 = null;
            goto label_4;
            label_11:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._pixelMansContainer.GetChild(index:  0).gameObject);
            label_5:
            if(this._pixelMansContainer.childCount > 0)
            {
                goto label_11;
            }
            
            if(this.万与下下丘下与丅丒 == null)
            {
                goto label_18;
            }
            
            if(this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 100)
            {
                goto label_13;
            }
            
            UnityEngine.GameObject val_9 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners/PixelmansForBanners/"("Banners/PixelmansForBanners/") + 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)(丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)) + "/PixelmanStarterPack"("/PixelmanStarterPack"));
            val_42 = "starter_pack";
            goto label_21;
            label_13:
            if((this.万与下下丘下与丅丒 == null) || (this.万与下下丘下与丅丒.丑且一丐东三不丈丝() != 120))
            {
                goto label_18;
            }
            
            UnityEngine.GameObject val_14 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners/PixelmansForBanners/"("Banners/PixelmansForBanners/") + 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)(丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)) + "/Pixelman27"("/Pixelman27"));
            val_42 = "lobby_pack";
            goto label_21;
            label_18:
            string val_17 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
            System.Collections.Generic.List<System.Int32> val_18 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丅万万丈丞丛丄万业(丝上下丂丌丏上丙不:  val_17);
            if((val_18 == null) || (val_18.Count == 0))
            {
                goto label_28;
            }
            
            val_43 = val_18.Item[UnityEngine.Random.Range(min:  0, max:  val_18.Count)].ToString();
            val_44 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners/PixelmansForBanners/"("Banners/PixelmansForBanners/") + 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)(丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)) + "/Pixelman"("/Pixelman") + val_43);
            if(val_44 != 0)
            {
                goto label_33;
            }
            
            label_21:
            val_44 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "Banners/PixelmansForBanners/{0}/Pixelman{1}", arg0:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), arg1:  this._defaultPixelman));
            label_33:
            if(val_44 == 0)
            {
                goto label_47;
            }
            
            UnityEngine.GameObject val_34 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_44, 丈东丘丏与丌东东下:  this._pixelMansContainer, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_44 = val_34;
            val_44.name = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_34);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_44, 丏业丟一东丂东丘丛:  true);
            Rilisoft.OfferPackWindow.与丄丄丕下上丈丌丄(丙业与丙丗丝不丈东:  val_43);
            Rilisoft.OfferPackSaleViewer val_36 = val_44.GetComponent<Rilisoft.OfferPackSaleViewer>();
            if(val_36 == 0)
            {
                goto label_47;
            }
            
            val_44 = this.东不上丐丘丈下丞丏;
            val_36.SetSale(丗丅上丁丂丘丏业丐:  val_44);
            val_39 = this._saleContainer;
            val_45 = val_39;
            val_46 = 0;
            goto label_51;
            label_28:
            val_47 = null;
            val_47 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.丄丛世丅丞丙专丙不, hi = this.丄丛世丅丞丙专丙不, lo = val_17, mid = val_17}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
            {
                    return;
            }
            
            label_47:
            val_40 = null;
            label_4:
            val_39 = this._saleContainer;
            val_46 = 1;
            val_45 = val_39;
            label_51:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_45, 丏业丟一东丂东丘丛:  true);
        }
        internal static void 且丑专业上三丌东东(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, int 丌丒丝东丌下丕丁丅, UnityEngine.GameObject 东丙丑万下丁丅一万, float 丆一丆七丕丑丛世东 = 30)
        {
            float val_14;
            var val_15;
            string val_16;
            System.Object[] val_17;
            object val_18;
            val_14 = 丆一丆七丕丑丛世东;
            if(丁丅丈丌丟世丗丗丟 == 1010)
            {
                goto label_1;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1000)
            {
                goto label_2;
            }
            
            val_15 = "Common/Gems_1";
            goto label_4;
            label_1:
            val_15 = "Common/Coins_1";
            goto label_4;
            label_2:
            val_16 = 0;
            label_4:
            UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_16);
            if(val_1 == 0)
            {
                    object[] val_3 = new object[2];
                val_17 = val_3;
                val_18 = 丁丅丈丌丟世丗丗丟;
                val_17[0] = val_18;
                val_17[1] = 丌丒丝东丌下丕丁丅;
                UnityEngine.Debug.LogErrorFormat(format:  "prefab for currency \'{0},{1}\' not found", args:  val_3);
                return;
            }
            
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1);
            val_4.transform.SetParent(p:  东丙丑万下丁丅一万.transform);
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_14);
            val_4.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_18 = val_4.transform;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_14 = val_12.x;
            val_18.localRotation = new UnityEngine.Quaternion() {x = val_14, y = val_12.y, z = val_12.z, w = val_12.w};
            val_17 = 东丙丑万下丁丅一万.layer;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_4, 不东丛三丂丌丑专丆:  val_17, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        protected BaseOfferPackDrawer()
        {
            this.丙丘万丅三下丈上丌 = true;
            this._animationTime = 0.3f;
            this._timeBarPowerPosition = 222;
            this._timeBarBasePosition = 106;
            this.丄丛世丅丞丙专丙不 = 0m;
            mem[1152921543279817220] = 0;
            this._defaultPixelman = 3;
        }
    
    }

}
