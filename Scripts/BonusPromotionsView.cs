using UnityEngine;
internal sealed class BonusPromotionsView : PGBehaviour
{
    // Fields
    private System.Action 上万七丐丗世丅且丅;
    private System.Action 丙丈东且丛丞上丏不;
    private System.Action 万丆丞丒丄丗与丄丘;
    private UnityEngine.GameObject _body;
    private PGCompany.StorePromotionView _storePromotionView;
    private UnityEngine.GameObject _purchaseIndicator;
    private UnityEngine.GameObject _notificationIndicator;
    private bool <不丟东上丂丘一不万>k__BackingField;
    private TagSystem.丞丟一丅丐专三万不 丕不丅万七且世专丛;
    private PGCompany.东丑丆丗丏丐丟下丄 三丂丐丈丄专丛不专;
    private readonly System.Collections.Generic.Dictionary<string, PGCompany.StorePromotionInfoUIAbstract> 丘一丝丝世七丙世丒;
    private UnityEngine.Coroutine 专丛与专丁丅且丏丆;
    
    // Properties
    internal bool 丅业东万丌丕上丌丄 { get; set; }
    internal bool 丙丌丝丁丈七丅丗丟 { get; }
    public PGCompany.东丑丆丗丏丐丟下丄 丌三丒丆丂世丈丐丟 { get; }
    
    // Methods
    internal void 且丏丗丌丌丄丕丅丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上万七丐丗世丅且丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上万七丐丗世丅且丅 != 1152921537157220040);
    
    }
    internal void 丐丑丘七丄下丝丏丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上万七丐丗世丅且丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上万七丐丗世丅且丅 != 1152921537157356616);
    
    }
    internal void 丒丗丑丁丙业丏丏与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙丈东且丛丞上丏不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙丈东且丛丞上丏不 != 1152921537157493200);
    
    }
    internal void 东丅一丝丂三七专丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙丈东且丛丞上丏不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙丈东且丛丞上丏不 != 1152921537157629776);
    
    }
    internal void 且丕丄丁丟丝丁专丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.万丆丞丒丄丗与丄丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.万丆丞丒丄丗与丄丘 != 1152921537157766360);
    
    }
    internal void 不丝东丐丛丝丈与丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.万丆丞丒丄丗与丄丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.万丆丞丒丄丗与丄丘 != 1152921537157902936);
    
    }
    internal bool 丈丐丞丐上丑且丕万()
    {
        return (bool)this.<不丟东上丂丘一不万>k__BackingField;
    }
    private void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
    {
        this.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丛丆丘不专丑丛上七()
    {
        if(this._body != null)
        {
                return this._body.activeSelf;
        }
        
        return this._body.activeSelf;
    }
    public PGCompany.东丑丆丗丏丐丟下丄 get_SelectedPromotion()
    {
        return (PGCompany.东丑丆丗丏丐丟下丄)this.三丂丐丈丄专丛不专;
    }
    private PGCompany.StorePromotionInfoUIAbstract 不丒丏丘丁丘专丝业()
    {
        object val_15;
        PGCompany.东丑丆丗丏丐丟下丄 val_16;
        System.Collections.Generic.Dictionary<System.String, PGCompany.StorePromotionInfoUIAbstract> val_17;
        val_15 = this;
        val_16 = this.三丂丐丈丄专丛不专;
        if(val_16 == null)
        {
                return (PGCompany.StorePromotionInfoUIAbstract)val_15.Item[val_4];
        }
        
        val_17 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_16.丝丈上丌且丈丒丈万());
        if(this.三丂丐丈丄专丛不专 == null)
        {
            goto label_4;
        }
        
        if(val_17 == false)
        {
            goto label_5;
        }
        
        label_7:
        string val_3 = this.三丂丐丈丄专丛不专.丝丈上丌且丈丒丈万();
        goto label_6;
        label_4:
        if(val_17 == true)
        {
            goto label_7;
        }
        
        label_5:
        string val_4 = this.三丂丐丈丄专丛不专.丐万丐丌丌丆丒丐丝();
        label_6:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != false)
        {
                val_15 = System.String.Format(format:  "infoPrefabName not setted for promotion: \'{0}\'", arg0:  this.三丂丐丈丄专丛不专.七丈丒丒下下且万与());
            UnityEngine.Debug.LogError(message:  val_15);
            val_16 = 0;
            return (PGCompany.StorePromotionInfoUIAbstract)val_15.Item[val_4];
        }
        
        val_17 = this.丘一丝丝世七丙世丒;
        if((val_17.ContainsKey(key:  val_4)) != true)
        {
                val_17 = UnityEngine.Resources.Load<PGCompany.StorePromotionInfoUIAbstract>(path:  val_4);
            val_16 = 0;
            if(val_17 == 0)
        {
                return (PGCompany.StorePromotionInfoUIAbstract)val_15.Item[val_4];
        }
        
            val_17 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.StorePromotionInfoUIAbstract>(丑且不丕与专丄业丙:  val_17, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_17.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void BonusPromotionsView::三丌丙业丑一丛丏丈(PGCompany.StorePromotionInfoUIAbstract 且丗丆丐丄丅丁三丑)));
            this.丘一丝丝世七丙世丒.set_Item(key:  val_4, value:  val_17);
        }
        
        val_15 = this.丘一丝丝世七丙世丒;
        return (PGCompany.StorePromotionInfoUIAbstract)val_15.Item[val_4];
    }
    private void Awake()
    {
        if(this._storePromotionView == 0)
        {
                return;
        }
        
        this._storePromotionView.业丝丝专丂三世丅不(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Object>(object:  this, method:  System.Void BonusPromotionsView::与丈不丟丄三七丗上(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)));
    }
    private void OnDestroy()
    {
        if(this._storePromotionView == 0)
        {
                return;
        }
        
        this._storePromotionView.丗一丞丌与东与三且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Object>(object:  this, method:  System.Void BonusPromotionsView::与丈不丟丄三七丗上(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)));
    }
    private void OnEnable()
    {
        this.三丂丐丈丄专丛不专 = 0;
        this.<不丟东上丂丘一不万>k__BackingField = true;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._purchaseIndicator, 丏业丟一东丂东丘丛:  false);
        this.丈且东丑丂且万丒丅();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丗一万丌世上丆丏丅());
        PGCompany.MainStore.万丝丞东丘丒丌七专.丙上不丆丘丂丒三丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BonusPromotionsView::Reset()));
        StoreKitEventListener.一万丟丌东丈丄三一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void BonusPromotionsView::且丘丛丘且丏下东业(bool 丕丗丐丁丕一丙世丌)));
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void BonusPromotionsView::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
    }
    private void OnDisable()
    {
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void BonusPromotionsView::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
        PGCompany.MainStore.万丝丞东丘丒丌七专.丈一七与丈丘丞丗上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BonusPromotionsView::Reset()));
        StoreKitEventListener.丛丈专丑上丙丕丗丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void BonusPromotionsView::且丘丛丘且丏下东业(bool 丕丗丐丁丕一丙世丌)));
        this.<不丟东上丂丘一不万>k__BackingField = false;
    }
    private void 丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        if(且丘丏丁丑与丙与丁.七丈丒丒下下且万与() == null)
        {
                return;
        }
        
        if(this.三丂丐丈丄专丛不专 == null)
        {
                return;
        }
        
        if(this.三丂丐丈丄专丛不专.七丈丒丒下下且万与() == null)
        {
                return;
        }
        
        if(StoreKitEventListener.三丘丈不丝丕丞东丌() == true)
        {
                return;
        }
        
        PGCompany.专丟专世丅丂丁且专 val_5 = this.三丂丐丈丄专丛不专.七丈丒丒下下且万与();
        var val_8 = 0;
        val_8 = val_8 + 1;
        if((且丘丏丁丑与丙与丁.七丈丒丒下下且万与().Equals(other:  ???)) == false)
        {
                return;
        }
        
        this.三丂丐丈丄专丛不专 = 0;
        this.丈且东丑丂且万丒丅();
    }
    internal void 丝一丅下且一丟丒世(TagSystem.丞丟一丅丐专三万不 丐丑丒丕丐丟丐东与)
    {
        this.丕不丅万七且世专丛 = 丐丑丒丕丐丟丐东与;
        this.三丂丐丈丄专丛不专 = 0;
        this.丈且东丑丂且万丒丅();
    }
    private void Reset()
    {
        this.三丂丐丈丄专丛不专 = 0;
        this.丈且东丑丂且万丒丅();
    }
    private void 丈且东丑丂且万丒丅()
    {
        UnityEngine.GameObject val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Func<PGCompany.MainStore.下丐丒丙丂丁丗丘丘, System.Int32> val_28;
        if(this.三丂丐丈丄专丛不专 == null)
        {
            goto label_1;
        }
        
        label_51:
        val_23 = this._body;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  (this.三丂丐丈丄专丛不专 != 0) ? 1 : 0);
        if(this.专丛与专丁丅且丏丆 != null)
        {
                this.StopCoroutine(routine:  this.专丛与专丁丅且丏丆);
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._purchaseIndicator, 丏业丟一东丂东丘丛:  false);
        if(this._storePromotionView == 0)
        {
            goto label_9;
        }
        
        if(this.三丂丐丈丄专丛不专 == null)
        {
            goto label_12;
        }
        
        TagSystem.三与下丘七丘丌丏丄 val_3 = this.三丂丐丈丄专丛不专.与不丞丑七丘丁丂丛();
        if(val_3 == null)
        {
            goto label_12;
        }
        
        string val_22 = "new";
        val_22 = val_3.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_22);
        val_24 = 0;
        goto label_13;
        label_1:
        if(this.丕不丅万七且世专丛 == null)
        {
            goto label_51;
        }
        
        PGCompany.东丑丒丗一丞下丙丙<T> val_7 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        val_25 = 0;
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(七丄丆丘丒与丐丘丅: ref  val_7);
        System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_8 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
        List.Enumerator<T> val_9 = val_7.GetEnumerator();
        label_26:
        if(((-1806764304) & 1) == 0)
        {
            goto label_20;
        }
        
        string val_11 = 0.丐丏七丌丕丗业且上();
        if(((val_11 == null) || (val_11 == null)) || ((this.丕不丅万七且世专丛.丞丐丂与下与上且丆(专丛丐上丈丙丏丛丂:  val_11.与不丞丑七丘丁丂丛())) == false))
        {
            goto label_26;
        }
        
        val_8.Add(item:  val_11);
        goto label_26;
        label_12:
        val_24 = 0;
        label_13:
        if(((-1806764308) & 1) != 0)
        {
                val_23 = val_24.GetValueOrDefault();
        }
        else
        {
                val_23 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notificationIndicator, 丏业丟一东丂东丘丛:  false);
        label_9:
        if(this.万丆丞丒丄丗与丄丘 == null)
        {
                return;
        }
        
        this.万丆丞丒丄丗与丄丘.Invoke();
        return;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.东丑丒丗一丞下丙丙<T> val_15 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        if((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_8)) == false)
        {
            goto label_51;
        }
        
        val_26 = null;
        val_26 = null;
        val_28 = BonusPromotionsView.<>c.<>9__32_0;
        if(val_28 == null)
        {
                System.Func<PGCompany.MainStore.下丐丒丙丂丁丗丘丘, System.Int32> val_18 = null;
            val_28 = val_18;
            val_18 = new System.Func<PGCompany.MainStore.下丐丒丙丂丁丗丘丘, System.Int32>(object:  BonusPromotionsView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BonusPromotionsView.<>c::丗上丆丐丅七丏东下(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 七丏丄丅丌业与且丙));
            BonusPromotionsView.<>c.<>9__32_0 = val_28;
        }
        
        .丄丆七丂丐且业三一 = System.Linq.Enumerable.Max<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_8, selector:  val_18);
        this.三丂丐丈丄专丛不专 = System.Linq.Enumerable.First<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_8, predicate:  new System.Func<PGCompany.MainStore.下丐丒丙丂丁丗丘丘, System.Boolean>(object:  new BonusPromotionsView.且下七业七业一上丈(), method:  System.Boolean BonusPromotionsView.且下七业七业一上丈::一丄业丐丄丒下丏丞(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 七丏丄丅丌业与且丙)));
        goto label_51;
    }
    private System.Collections.IEnumerator 丗一万丌世上丆丏丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BonusPromotionsView.丟七丏丈且丝丏丞专();
    }
    private void 与丈不丟丄三七丗上(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, object 一丐丗丁丞丆丅丟丄)
    {
        var val_6;
        if(this.三丂丐丈丄专丛不专 == null)
        {
                return;
        }
        
        if((this.三丂丐丈丄专丛不专.Equals(丘丛丏丘丝七世七丅:  丐丆丝业丙丈下世丁)) == false)
        {
                return;
        }
        
        PGCompany.StorePromotionInfoUIAbstract val_2 = this.不丒丏丘丁丘专丝业();
        if(val_2 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notificationIndicator, 丏业丟一东丂东丘丛:  false);
        PGCompany.MainStore.万丝丞东丘丒丌七专 val_4 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        if(val_4 == null)
        {
            goto label_9;
        }
        
        if(this.三丂丐丈丄专丛不专 != null)
        {
            goto label_10;
        }
        
        goto label_12;
        label_9:
        if(this.三丂丐丈丄专丛不专 == null)
        {
            goto label_12;
        }
        
        label_10:
        label_12:
        val_6 = 0;
        val_4.东七丙三丌丘一不丙(且丘丏丁丑与丙与丁:  null, 不丝丐与丑一丈丌世:  0);
        if(this.上万七丐丗世丅且丅 == null)
        {
                return;
        }
        
        this.上万七丐丗世丅且丅.Invoke();
    }
    private void 三丌丙业丑一丛丏丈(PGCompany.StorePromotionInfoUIAbstract 且丗丆丐丄丅丁三丑)
    {
        PGCompany.StorePromotionInfoUIAbstract val_1 = this.不丒丏丘丁丘专丝业();
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
        {
                if(val_1 == 且丗丆丐丄丅丁三丑)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        if(this.丙丈东且丛丞上丏不 == null)
        {
                return;
        }
        
        this.丙丈东且丛丞上丏不.Invoke();
    }
    private void 且丘丛丘且丏下东业(bool 丕丗丐丁丕一丙世丌)
    {
        if(丕丗丐丁丕一丙世丌 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._purchaseIndicator, 丏业丟一东丂东丘丛:  true);
        if(this.专丛与专丁丅且丏丆 != null)
        {
                this.StopCoroutine(routine:  this.专丛与专丁丅且丏丆);
        }
        
        this.专丛与专丁丅且丏丆 = this.StartCoroutine(routine:  this.下丁丙丏下丕丁丗一());
    }
    private System.Collections.IEnumerator 下丁丙丏下丕丁丗一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BonusPromotionsView.三丟丛丙下世丐丘且();
    }
    public BonusPromotionsView()
    {
        this.丘一丝丝世七丙世丒 = new System.Collections.Generic.Dictionary<System.String, PGCompany.StorePromotionInfoUIAbstract>();
    }

}
