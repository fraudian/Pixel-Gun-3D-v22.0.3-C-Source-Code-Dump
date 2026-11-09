using UnityEngine;
public class Base_BuildingUI : PGBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    private System.Action 丐丌三丈东丘丝丑世;
    private System.Action 业丏丗上专与丐丌丒;
    private System.Action 丗不东丝丑三不业丒;
    public static Base_BuildingUI instance;
    public string supercategory;
    private UnityEngine.Transform holder;
    public string selectedCategory;
    public string selectedSubcategory;
    public string selectedItem;
    public PlaceableItemSettings selectedItemSettings;
    public PlacebleItemCategoryUI categoryUI;
    public PlacebleItemSubcategoryUI subcategoryUI;
    public PlacebleItemsListUI itemsListUI;
    public UnityEngine.GameObject bBuildInfoUI;
    public UnityEngine.GameObject rightAnchorUI;
    public PlaceableItemInfoUI itemInfoUI;
    private System.Collections.Generic.List<UIWidget> widgetsAlpha;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnSlideUp;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnSlideDown;
    private UnityEngine.GameObject tankTestButton;
    private UnityEngine.GameObject fortTestButton;
    private UnityEngine.GameObject clanDivisionPromo;
    public UnityEngine.Vector3 slideUpPos;
    public UnityEngine.Vector3 slideDownPos;
    public bool slideUp;
    public float slideSpeed;
    public UILabel selectadSubategoryLabel;
    public PlaceableItemUpgradeUI itemUpgradeUI;
    public UnityEngine.GameObject clanLogoHolder;
    public UILabel clanHeaderLabel;
    public UITexture[] clanLogos;
    public UnityEngine.GameObject cameraObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> devUI;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    internal void 丌丐与丙东万上丛东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐丌三丈东丘丝丑世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丌三丈东丘丝丑世 != 1152921536847057944);
    
    }
    internal void 丄专丏丅丗丐丏万专(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐丌三丈东丘丝丑世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丌三丈东丘丝丑世 != 1152921536847194520);
    
    }
    internal void 世业丐丏丗业丟一上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.业丏丗上专与丐丌丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丏丗上专与丐丌丒 != 1152921536847331104);
    
    }
    internal void 丑丕一丁专一三且丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.业丏丗上专与丐丌丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丏丗上专与丐丌丒 != 1152921536847467680);
    
    }
    internal void 丐丗世三丝丞专三一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不东丝丑三不业丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不东丝丑三不业丒 != 1152921536847604264);
    
    }
    internal void 丝丈专且丆业一丄丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不东丝丑三不业丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不东丝丑三不业丒 != 1152921536847740840);
    
    }
    protected virtual void Awake()
    {
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        Base_BuildingUI.instance = this;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.devUI, 丏业丟一东丂东丘丛:  false);
        System.IDisposable val_3 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_280), 与且专丈不万东一万:  0);
    }
    protected virtual void Start()
    {
        PGCompany.丑且丆万丏丝丘丙丟 val_25;
        var val_26;
        var val_27;
        var val_29;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_25 = this;
        val_26 = 1152921530862937872;
        if(((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) == false) || ((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) == null))
        {
            goto label_4;
        }
        
        val_27 = null;
        val_27 = null;
        if((Base_BuildingUI.<>c.<>9__40_0) == null)
        {
            goto label_7;
        }
        
        label_33:
        this.enableOnSlideUp.ForEach(action:  Base_BuildingUI.<>c.<>9__40_0);
        val_29 = null;
        val_29 = null;
        if((Base_BuildingUI.<>c.<>9__40_1) == null)
        {
            goto label_11;
        }
        
        label_37:
        this.enableOnSlideDown.ForEach(action:  Base_BuildingUI.<>c.<>9__40_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanHeaderLabel, 丏业丟一东丂东丘丛:  true);
        val_31 = Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanHeaderLabel, 丕丗丘丑丛与丑业丒:  val_31.东丙上东业丆不丟丘());
        val_32 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanLogoHolder, 丏业丟一东丂东丘丛:  true);
        val_33 = 0;
        goto label_17;
        label_24:
        UITexture val_25 = this.clanLogos[0];
        val_31 = Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan.世丐专丂世丄世丂丌();
        val_32 = val_31;
        val_33 = 1;
        label_17:
        if(val_33 < this.clanLogos.Length)
        {
            goto label_24;
        }
        
        val_25 = ???;
        val_26 = ???;
        goto typeof(Base_BuildingUI).__il2cppRuntimeField_1D8;
        label_4:
        val_34 = null;
        val_34 = null;
        string val_26 = PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛;
        val_26 = System.String.op_Equality(a:  val_25 + 96, b:  val_26);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25 + 216, 丏业丟一东丂东丘丛:  val_26);
        string val_27 = PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄;
        val_27 = System.String.op_Equality(a:  val_25 + 96, b:  val_27);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25 + 224, 丏业丟一东丂东丘丛:  val_27);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25 + 288, 丏业丟一东丂东丘丛:  false);
        val_25.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  true);
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  val_25);
        return;
        label_7:
        Base_BuildingUI.<>c.<>9__40_0 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::三丌丐丁东三业丄丟(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.enableOnSlideUp != null)
        {
            goto label_33;
        }
        
        goto label_33;
        label_11:
        Base_BuildingUI.<>c.<>9__40_1 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::丒丄七下下丟丟丒丏(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.enableOnSlideDown != null)
        {
            goto label_37;
        }
        
        goto label_37;
    }
    protected virtual void 丐丌丆万三丄与东丈()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bBuildInfoUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rightAnchorUI, 丏业丟一东丂东丘丛:  false);
    }
    protected virtual void OnEnable()
    {
        this.categoryUI.selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_250));
        this.subcategoryUI.selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_260));
        this.itemsListUI.selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_270));
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::世丁丑丕丏不业一丙()));
        BankController.东丂下丞世丒丆丝丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::与丑丂一专丅丘与三()));
        BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::东丂东丟世七业丙丟()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::业丕丐丝与丄丏丆丂()));
        this.世丁丑丕丏不业一丙();
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_280), 与且专丈不万东一万:  System.String.Format(format:  "Base_BuildingUI_{0}", arg0:  this.gameObject.name));
    }
    protected virtual void OnDisable()
    {
        this.categoryUI.selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_250));
        this.subcategoryUI.selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_260));
        this.itemsListUI.selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_270));
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::世丁丑丕丏不业一丙()));
        BankController.且丆专丗与下专丞丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::与丑丂一专丅丘与三()));
        BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::东丂东丟世七业丙丟()));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Base_BuildingUI::业丕丐丝与丄丏丆丂()));
        var val_9 = 0;
        val_9 = val_9 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    protected virtual void OnDestroy()
    {
    
    }
    private void 与丑丂一专丅丘与三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cameraObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 东丂东丟世七业丙丟()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cameraObject, 丏业丟一东丂东丘丛:  true);
    }
    private void 业丕丐丝与丄丏丆丂()
    {
        null = null;
        MainMenuController.丞丟丂三丝丆丌丌丗 = true;
        丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
    }
    public void U_ShowTutorialInfo()
    {
        ClansTutorialController.Instance.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  4, 丈东丘丏与丌东东下:  this.transform);
    }
    private void 世丁丑丕丏不业一丙()
    {
        this.itemUpgradeUI.Setup(业世丟丐丘丐专与不:  丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.supercategory));
    }
    public void SlideToggle()
    {
        if(this.slideUp != false)
        {
                this.丛世丟丁丅下丌丅丐(丌丄丗七丝丘与丆与:  false);
            return;
        }
        
        this.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
    }
    internal void 丝且七丑不丘丘丏万(bool 丌丄丗七丝丘与丆与 = False)
    {
        System.Collections.Generic.List<UIWidget> val_5;
        var val_6;
        var val_8;
        System.Collections.Generic.List<UnityEngine.GameObject> val_9;
        val_5 = this;
        this.slideUp = true;
        val_6 = null;
        val_6 = null;
        if((Base_BuildingUI.<>c.<>9__52_0) == null)
        {
            goto label_3;
        }
        
        label_18:
        this.enableOnSlideUp.ForEach(action:  Base_BuildingUI.<>c.<>9__52_0);
        val_8 = null;
        val_9 = this.enableOnSlideDown;
        val_8 = null;
        if((Base_BuildingUI.<>c.<>9__52_1) == null)
        {
            goto label_7;
        }
        
        label_22:
        val_9.ForEach(action:  Base_BuildingUI.<>c.<>9__52_1);
        if(丌丄丗七丝丘与丆与 == false)
        {
                return;
        }
        
        this.holder.localPosition = new UnityEngine.Vector3() {x = this.slideUpPos, y = V9.16B, z = V10.16B};
        val_5 = this.widgetsAlpha;
        List.Enumerator<T> val_1 = val_5.GetEnumerator();
        val_9 = 1152921526158939600;
        label_14:
        if(((-2116679672) & 1) == 0)
        {
            goto label_12;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_3:
        Base_BuildingUI.<>c.<>9__52_0 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::三丗丏上丙且丕专丄(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.enableOnSlideUp != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_7:
        Base_BuildingUI.<>c.<>9__52_1 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::丐丞丄且不丕丒丐下(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(val_9 != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丛世丟丁丅下丌丅丐(bool 丌丄丗七丝丘与丆与 = False)
    {
        System.Collections.Generic.List<UIWidget> val_5;
        var val_6;
        var val_8;
        System.Collections.Generic.List<UnityEngine.GameObject> val_9;
        val_5 = this;
        this.itemInfoUI.Hide();
        this.slideUp = false;
        val_6 = null;
        val_6 = null;
        if((Base_BuildingUI.<>c.<>9__53_0) == null)
        {
            goto label_4;
        }
        
        label_19:
        this.enableOnSlideUp.ForEach(action:  Base_BuildingUI.<>c.<>9__53_0);
        val_8 = null;
        val_9 = this.enableOnSlideDown;
        val_8 = null;
        if((Base_BuildingUI.<>c.<>9__53_1) == null)
        {
            goto label_8;
        }
        
        label_23:
        val_9.ForEach(action:  Base_BuildingUI.<>c.<>9__53_1);
        if(丌丄丗七丝丘与丆与 == false)
        {
                return;
        }
        
        this.holder.localPosition = new UnityEngine.Vector3() {x = this.slideDownPos, y = V9.16B, z = V10.16B};
        val_5 = this.widgetsAlpha;
        List.Enumerator<T> val_1 = val_5.GetEnumerator();
        val_9 = 1152921526158939600;
        label_15:
        if(((-2116504184) & 1) == 0)
        {
            goto label_13;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_4:
        Base_BuildingUI.<>c.<>9__53_0 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::丏丑丙且丄东丄丄丅(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.enableOnSlideUp != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_8:
        Base_BuildingUI.<>c.<>9__53_1 = new System.Action<UnityEngine.GameObject>(object:  Base_BuildingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Base_BuildingUI.<>c::下七丟丌专丆万万丕(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(val_9 != null)
        {
            goto label_23;
        }
        
        goto label_23;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void ShowDivisionPromoInfoView()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanDivisionPromo, 丏业丟一东丂东丘丛:  true);
    }
    protected virtual void Update()
    {
        float val_7;
        var val_21;
        float val_23;
        float val_24;
        var val_26;
        float val_27;
        val_21 = this;
        if(this.slideUp == false)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_1 = this.holder.localPosition;
        val_23 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.slideUpPos, y = V11.16B, z = V12.16B}, t:  val_23 * this.slideSpeed);
        val_24 = val_4.z;
        this.holder.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_24};
        List.Enumerator<T> val_5 = this.widgetsAlpha.GetEnumerator();
        val_26 = 1152921526158938576;
        val_27 = 1f;
        label_11:
        if(((-2116214688) & 1) == 0)
        {
            goto label_23;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        float val_11 = UnityEngine.Mathf.Lerp(a:  val_7, b:  val_27, t:  UnityEngine.Time.deltaTime * this.slideSpeed);
        goto label_11;
        label_17:
        UnityEngine.Vector3 val_12 = this.holder.localPosition;
        val_23 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.slideDownPos, y = this.slideSpeed, z = V12.16B}, t:  val_23 * this.slideSpeed);
        val_27 = val_15.x;
        val_24 = val_15.z;
        this.holder.localPosition = new UnityEngine.Vector3() {x = val_27, y = val_15.y, z = val_24};
        List.Enumerator<T> val_16 = this.widgetsAlpha.GetEnumerator();
        val_26 = 1152921526158938576;
        label_27:
        if(((-2116214688) & 1) == 0)
        {
            goto label_23;
        }
        
        string val_17 = val_7.丐丏七丌丕丗业且上();
        float val_20 = UnityEngine.Mathf.Lerp(a:  val_7, b:  0f, t:  UnityEngine.Time.deltaTime * this.slideSpeed);
        goto label_27;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal virtual void 下与丞三丅丛丄七丕(PlaceableItemSettings 下丅丙一丂丗丅丝七)
    {
        if(下丅丙一丂丗丅丝七 != null)
        {
                string val_1 = 下丅丙一丂丗丅丝七.CategoryName;
            string val_2 = 下丅丙一丂丗丅丝七.SubcategoryName;
        }
    
    }
    internal virtual void 下与丞三丅丛丄七丕(string 七丆丒与丗丌丄且丂 = "", string 丒丑丞丁世丌专不丈 = "", string 下丅丙一丂丗丅丝七 = "")
    {
        string val_11;
        string val_12;
        val_11 = 丒丑丞丁世丌专不丈;
        val_12 = 七丆丒与丗丌丄且丂;
        this.itemInfoUI.Hide();
        if((System.String.IsNullOrEmpty(value:  val_12)) != false)
        {
                System.Collections.Generic.List<System.String> val_2 = 丄丈业一下万且丂丕.丈世世三万丝一丕一(且三丟七下丂专丈丈:  this.supercategory);
            if(val_2.Count >= 1)
        {
                val_12 = val_2.Item[0];
        }
        else
        {
                val_12 = "";
        }
        
        }
        
        this.selectedCategory = val_12;
        this.categoryUI.下与丞三丅丛丄七丕(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  val_12);
        if((System.String.IsNullOrEmpty(value:  val_11)) != false)
        {
                System.Collections.Generic.List<System.String> val_6 = 丄丈业一下万且丂丕.丝且丕且丁世不东丒(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory);
            if(val_6.Count >= 1)
        {
                val_11 = val_6.Item[0];
        }
        else
        {
                val_11 = "";
        }
        
        }
        
        this.selectedSubcategory = val_11;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.selectadSubategoryLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + val_11 + "_Title"));
        this.subcategoryUI.下与丞三丅丛丄七丕(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory, 丒丑丞丁世丌专不丈:  this.selectedSubcategory);
        this.selectedItem = 下丅丙一丂丗丅丝七;
        this.itemsListUI.下与丞三丅丛丄七丕(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory, 丒丑丞丁世丌专不丈:  this.selectedSubcategory, 下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
    }
    protected virtual void 丈丗丈丌丁丒东下业()
    {
        string val_11;
        string val_12;
        string val_13;
        System.Collections.Generic.List<System.String> val_1 = 丄丈业一下万且丂丕.丈世世三万丝一丕一(且三丟七下丂专丈丈:  this.supercategory);
        if(val_1.Count > 0)
        {
                string val_3 = val_1.Item[0];
        }
        else
        {
                val_11 = "";
        }
        
        this.selectedCategory = val_11;
        if(this.categoryUI.selectableButtonController.selectedButton != 0)
        {
                val_12 = this.categoryUI.selectableButtonController.selectedButton.name;
            this.selectedCategory = val_12;
        }
        else
        {
                val_12 = this.selectedCategory;
        }
        
        System.Collections.Generic.List<System.String> val_6 = 丄丈业一下万且丂丕.丝且丕且丁世不东丒(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  val_12);
        if(val_6.Count > 0)
        {
                val_13 = val_6.Item[0];
        }
        else
        {
                val_13 = "";
        }
        
        this.selectedSubcategory = val_13;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.selectadSubategoryLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + val_13 + "_Title"));
        this.subcategoryUI.下与丞三丅丛丄七丕(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory, 丒丑丞丁世丌专不丈:  this.selectedSubcategory);
        if(this.丐丌三丈东丘丝丑世 == null)
        {
                return;
        }
        
        this.丐丌三丈东丘丝丑世.Invoke();
    }
    protected virtual void 且丒万丞丕丏业业丄()
    {
        string val_8;
        string val_9;
        this.itemInfoUI.Hide();
        System.Collections.Generic.List<System.String> val_1 = 丄丈业一下万且丂丕.丝且丕且丁世不东丒(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory);
        if(val_1.Count > 0)
        {
                string val_3 = val_1.Item[0];
        }
        else
        {
                val_8 = "";
        }
        
        this.selectedSubcategory = val_8;
        if(this.subcategoryUI.selectableButtonController.selectedButton != 0)
        {
                val_9 = this.subcategoryUI.selectableButtonController.selectedButton.name;
            this.selectedSubcategory = val_9;
        }
        else
        {
                val_9 = this.selectedSubcategory;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.selectadSubategoryLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + val_9 + "_Title"));
        this.itemsListUI.下与丞三丅丛丄七丕(且三丟七下丂专丈丈:  this.supercategory, 七丆丒与丗丌丄且丂:  this.selectedCategory, 丒丑丞丁世丌专不丈:  this.selectedSubcategory, 下丅丙一丂丗丅丝七:  this.selectedItem);
        if(this.业丏丗上专与丐丌丒 == null)
        {
                return;
        }
        
        this.业丏丗上专与丐丌丒.Invoke();
    }
    protected virtual void 丘下丟丁上丏丛且且()
    {
        string val_4;
        this.selectedItem = "";
        if(this.itemsListUI.selectableButtonController.selectedButton != 0)
        {
                val_4 = this.itemsListUI.selectableButtonController.selectedButton.name;
            this.selectedItem = val_4;
        }
        else
        {
                val_4 = this.selectedItem;
        }
        
        this.selectedItemSettings = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_4);
        if(this.丗不东丝丑三不业丒 == null)
        {
                return;
        }
        
        this.丗不东丝丑三不业丒.Invoke();
    }
    public virtual void U_BackButton()
    {
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public virtual void U_StartTestButton()
    {
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public virtual void U_BankButton()
    {
        var val_6;
        System.Collections.Generic.List<BankViewTab> val_2 = new System.Collections.Generic.List<BankViewTab>();
        if(val_2 != null)
        {
                val_2.Add(item:  1);
            val_2.Add(item:  2);
        }
        else
        {
                val_2.Add(item:  1);
            val_2.Add(item:  2);
        }
        
        val_2.Add(item:  8);
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  val_2);
        new System.EventHandler() = new System.EventHandler(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_2B0);
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler());
        val_6 = null;
        val_6 = null;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  this.supercategory);
    }
    protected virtual void 丑丂万三丏下丕不且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        new System.EventHandler() = new System.EventHandler(object:  this, method:  typeof(Base_BuildingUI).__il2cppRuntimeField_2B0);
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler());
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        BankController.丑七不且上丗丁一世().下丏三下丟丌万丘七();
    }
    public virtual void GoToStore(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丞丘丞丏业且丛丏丘:  业世丟丐丘丐专与不.一丌世丑丄东丞丘三());
    }
    public void DEV_IncreaseMaxEnergy()
    {
    
    }
    public void DEV_DecreaseMaxEnergy()
    {
    
    }
    public void TurnOn()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void TurnOff()
    {
        this.gameObject.SetActive(value:  false);
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
    public Base_BuildingUI()
    {
        this.slideSpeed = 10f;
    }

}
