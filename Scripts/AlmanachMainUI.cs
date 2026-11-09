using UnityEngine;
public class AlmanachMainUI : BannerWindow, 丑且丆万丏丝丘丙丟
{
    // Fields
    public static AlmanachMainUI instance;
    internal static int 丈七丝丑丑七且丏丗;
    internal static bool 丑丒万丐丞丒丈专丞;
    private static System.Action<AlmanachMainUI.丈丘七丞专丐不且世, AlmanachMainUI.丘丒丕专丌丅丆丗丄> 万世丒且丗丑不丏丈;
    private static System.Action 不七七丁丛丌丅专万;
    private static System.Action<PGCompany.丟丝东丈丐丙三下丛> 丘丞且业下下东不东;
    private UIButton arButton;
    private System.Collections.Generic.List<AlmanachMainUI.WeaponsScrollSettings> weaponsScrollSettings;
    private System.Collections.Generic.List<AlmanachMainUI.WeaponSetsScrollSettings> weaponSetsScrollSettings;
    private AlmanachMainUI.丈丘七丞专丐不且世 不上丞上丂丞不不上;
    private AlmanachMainUI.丘丒丕专丌丅丆丗丄 丅丞丂一丅万丂丂丁;
    public UnityEngine.GameObject holder;
    private AlmanachCategorySelectorUI almanachCtegorySelectorUI;
    private AlmanachWeaponInfoUI almanachWeaponInfoUI;
    public AlmanachMigrationUI almanachMigrationUI;
    private AlmanachTutorialManager almanachTutorialManager;
    private UIWidget weaponScrollHolder;
    private EndlessScroll weaponScroll;
    private UIWidget weaponSetsScrollHolder;
    private EndlessScrollDynamic weaponSetsScroll;
    private AlmanachCollectWeaponsStepUI almanachCollectWeaponsStepUI;
    private UnityEngine.GameObject toStartButton;
    private UnityEngine.GameObject toEndButton;
    private UnityEngine.GameObject toNextRewardButton;
    private OfferItemView nextRewardUI;
    private UnityEngine.GameObject almanachHelpUI;
    private UILabel collectedWeaponsCount;
    private UILabel collectedWeaponSetsCount;
    private PGCompany.丟丝东丈丐丙三下丛 且丛万丈丗丒一丛丒;
    private System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> 丁丛世丂丕东专丞丒;
    private UnityEngine.Color 不丂丝丘丅三且与丒;
    private bool 丛一上丗世丅丂丑丈;
    private UnityEngine.Coroutine 丈三丌丕世一与万丕;
    private System.IDisposable 七丝丕丅与且丘业万;
    public System.Collections.Generic.List<UIRect> weaponRectsToUpdate;
    public System.Collections.Generic.List<UIRect> weaponSetRectsToUpdate;
    private AlmanachMainUI.WeaponsScrollSettings 业丈七丟上丁专东东;
    private AlmanachMainUI.WeaponsScrollSettings 丝专一一世丌丄不丑;
    private AlmanachMainUI.WeaponSetsScrollSettings 且业业丛且丟丕三且;
    private AlmanachMainUI.WeaponSetsScrollSettings 丘七专丞丕丑丏一丗;
    public string musicClipName;
    private bool 一不丒丗与丂丕丝丝;
    private System.IDisposable 业与丛业丟一业丝丏;
    private static bool 丒上丏丂丟丙丏丛七;
    private static bool 丛丐世专万丛丑丗业;
    
    // Properties
    internal PGCompany.丟丝东丈丐丙三下丛 丈且下丝七丝三丗下 { get; }
    private System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> 丙丕丘丈丆丛且下丅 { get; }
    internal static bool 下丐丙专丕丙丗万丕 { get; }
    
    // Methods
    internal static void 丑丌丄丘三丆丄下专(System.Action<AlmanachMainUI.丈丘七丞专丐不且世, AlmanachMainUI.丘丒丕专丌丅丆丗丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AlmanachMainUI.万世丒且丗丑不丏丈, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.万世丒且丗丑不丏丈 != 1152921505032302608);
    
    }
    internal static void 下与一丅丅丘万上丕(System.Action<AlmanachMainUI.丈丘七丞专丐不且世, AlmanachMainUI.丘丒丕专丌丅丆丗丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AlmanachMainUI.万世丒且丗丑不丏丈, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.万世丒且丗丑不丏丈 != 1152921505032302608);
    
    }
    internal static void 世丏与丑东丛丞上丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AlmanachMainUI.不七七丁丛丌丅专万, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.不七七丁丛丌丅专万 != 1152921505032302616);
    
    }
    internal static void 丙丑丛丙丙下丂丗丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AlmanachMainUI.不七七丁丛丌丅专万, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.不七七丁丛丌丅专万 != 1152921505032302616);
    
    }
    internal static void 丑专丌业不丌与丄东(System.Action<PGCompany.丟丝东丈丐丙三下丛> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AlmanachMainUI.丘丞且业下下东不东, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.丘丞且业下下东不东 != 1152921505032302624);
    
    }
    internal static void 丛丟丆且一不丕东丘(System.Action<PGCompany.丟丝东丈丐丙三下丛> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AlmanachMainUI.丘丞且业下下东不东, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AlmanachMainUI.丘丞且业下下东不东 != 1152921505032302624);
    
    }
    public AlmanachMainUI.WeaponsScrollSettings GetWeaponsUISettings()
    {
        System.Collections.Generic.List<WeaponsScrollSettings> val_5;
        var val_6;
        val_5 = this;
        List.Enumerator<T> val_1 = this.weaponsScrollSettings.GetEnumerator();
        label_4:
        if(((-1753596888) & 1) == 0)
        {
            goto label_2;
        }
        
        val_6 = 0.丐丏七丌丕丗业且上();
        if(val_2.m_stringLength != 丒丁三上丂丅丌丈丁.丌且专业丈丒丄东万())
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (WeaponsScrollSettings)val_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_5 = this.weaponsScrollSettings;
        val_6 = val_5.Item[0];
        return (WeaponsScrollSettings)val_6;
    }
    public AlmanachMainUI.WeaponSetsScrollSettings GetWeaponSetsUISettings()
    {
        System.Collections.Generic.List<WeaponSetsScrollSettings> val_5;
        var val_6;
        val_5 = this;
        List.Enumerator<T> val_1 = this.weaponSetsScrollSettings.GetEnumerator();
        label_4:
        if(((-1753438808) & 1) == 0)
        {
            goto label_2;
        }
        
        val_6 = 0.丐丏七丌丕丗业且上();
        if(val_2.m_stringLength != 丒丁三上丂丅丌丈丁.丌且专业丈丒丄东万())
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (WeaponSetsScrollSettings)val_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_5 = this.weaponSetsScrollSettings;
        val_6 = val_5.Item[0];
        return (WeaponSetsScrollSettings)val_6;
    }
    internal PGCompany.丟丝东丈丐丙三下丛 丙丌一丙东上丞丏专()
    {
        return (PGCompany.丟丝东丈丐丙三下丛)this.且丛万丈丗丒一丛丒;
    }
    private System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> 丞丞丝丕丘不丁丄一()
    {
        return (System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>)this.丁丛世丂丕东专丞丒;
    }
    internal static bool 丛世丛与丌不丈丐丐()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(AlmanachMainUI.instance == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        if(null != 0)
        {
                return activeInHierarchy;
        }
        
        return activeInHierarchy;
    }
    protected override void Awake()
    {
        var val_3;
        this.Awake();
        val_3 = null;
        val_3 = null;
        AlmanachMainUI.instance = this;
        if(this.arButton == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arButton.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        上且丁万与丌下丐上.不丘业丈丈下三丛一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AlmanachMainUI::UpdateCollectWeaponsStepUI()));
        上且丁万与丌下丐上.丘七丁丄下丐丒三业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AlmanachMainUI::UpdateCollectWeaponsStepUI()));
        AlmanachMigrationUI.add_onGetRewardButtonPressed(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachMainUI::丒丝下丁且丕丌丕三()));
        上且丁万与丌下丐上.丒丕一丙业世三丂一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachMainUI::丄七丅丕丕三丂丘不()));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        上且丁万与丌下丐上.七三东丒丑丕丄丆世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AlmanachMainUI::UpdateCollectWeaponsStepUI()));
        上且丁万与丌下丐上.丐万丆丟专七丅丆丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AlmanachMainUI::UpdateCollectWeaponsStepUI()));
        AlmanachMigrationUI.remove_onGetRewardButtonPressed(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachMainUI::丒丝下丁且丕丌丕三()));
        上且丁万与丌下丐上.丅丛丟不丏业下丟专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachMainUI::丄七丅丕丕三丂丘不()));
    }
    private void 丒丝下丁且丕丌丕三()
    {
        this.世世丅丄丛丟丈丑丂();
    }
    private void 丄七丅丕丕三丂丘不()
    {
        this.丒丒丑丑丞丐丝七一();
    }
    public void Refresh()
    {
        var val_2;
        if(this.且丛万丈丗丒一丛丒 != null)
        {
                val_2 = this.且丛万丈丗丒一丛丒.业东丅东丌上丗丑不();
        }
        else
        {
                val_2 = 0;
        }
        
        this.ShowAlmanach(与且丒丐丆丆丒丛丏:  this.不上丞上丂丞不不上, 丄三丛七一丅丘丛丅:  this.丅丞丂一丅万丂丂丁, 丞一丁业丄一一业且:  0, 世万丐专世丕业丟东:  false);
    }
    public void ARButtonPressed()
    {
        System.Action val_15;
        AlmanachMainUI.丏丑丅丙世东丈丑丆 val_1 = new AlmanachMainUI.丏丑丅丙世东丈丑丆();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丟不丒万丝与丂上丘 = 0;
        System.Action val_2 = null;
        val_15 = val_2;
        val_2 = new System.Action(object:  val_1, method:  System.Void AlmanachMainUI.丏丑丅丙世东丈丑丆::丕丘丏丙丙丛七丕丙());
        if(val_1 != null)
        {
                .丟不丒万丝与丂上丘 = val_15;
        }
        else
        {
                .丟不丒万丝与丂上丘 = val_15;
            val_15 = (AlmanachMainUI.丏丑丅丙世东丈丑丆)[1152921524329614672].丟不丒万丝与丂上丘;
        }
        
        ARController.add_Closed(丙业与丙丗丝不丈东:  val_15);
        if(ARController.Instance == 0)
        {
                UnityEngine.Transform val_6 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "ARKitController"));
            val_6.parent = this.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_6.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            val_6.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_6.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        PGCompany.丗丟丄丈东丝丕丄世 val_12 = this.almanachWeaponInfoUI.Context;
        if(val_12 != null)
        {
                var val_13 = (null == null) ? (val_12) : 0;
        }
        
        ARController.Instance.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 三丐三丞丘丕不丒专:  0.丐上下三丑丈丑丄丟());
    }
    public override void Show()
    {
        var val_11;
        AlmanachMigrationUI val_12;
        var val_13;
        if(this.七丝丕丅与且丘业万 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            this.七丝丕丅与且丘业万.Dispose();
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.不丂丝丘丅三且与丒 = val_3;
        mem[1152921524329756612] = val_3.g;
        mem[1152921524329756616] = val_3.b;
        mem[1152921524329756620] = val_3.a;
        this.丛一上丗世丅丂丑丈 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.业丌丒丘丙且且丟丂(丙业与丙丗丝不丈东:  true);
        this.Show();
        val_11 = null;
        val_11 = null;
        AlmanachMainUI.丈七丝丑丑七且丏丗 = 0;
        if(上且丁万与丌下丐上.丘丑丕不丝万丝丛下() != true)
        {
                val_12 = 上且丁万与丌下丐上.七丞丝业万且丘丑丑();
            if(val_12 < 上且丁万与丌下丐上.与七丆丝丞三一丌丝())
        {
                val_13 = 0;
        }
        else
        {
                val_12 = this.almanachMigrationUI;
            val_12.Setup();
            val_13 = 1;
        }
        
            上且丁万与丌下丐上.丄专且丟丂不丑丞丐(业下丌一丛丞丄丘上:  true);
        }
        
        this.ShowAlmanach(与且丒丐丆丆丒丛丏:  1, 丄三丛七一丅丘丛丅:  1, 丞一丁业丄一一业且:  AlmanachMainUI.丈七丝丑丑七且丏丗 & (~(AlmanachMainUI.丈七丝丑丑七且丏丗 >> 31)), 世万丐专世丕业丟东:  true);
    }
    internal void 业丌丒丘丙且且丟丂(bool 丙业与丙丗丝不丈东)
    {
        bool val_2;
        if(丙业与丙丗丝不丈东 != false)
        {
                UnityEngine.Color val_1 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            val_2 = 0;
        }
        else
        {
                PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.不丂丝丘丅三且与丒});
            val_2 = this.丛一上丗世丅丂丑丈;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  val_2);
    }
    public void U_Back()
    {
        this.丝东丐丝东三丈世丝();
    }
    private void 丄丌万世丑且丙丛不()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  ButtonClickSound.丆丕丝丒不丙且丐丗, y:  0);
        if(val_1 != false)
        {
                if(val_1.丑上丘丌丏丕与东上() != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        }
        
        this.丝东丐丝东三丈世丝();
    }
    private void 丝东丐丝东三丈世丝()
    {
        if(this.丑上丘丌丏丕与东上() == false)
        {
                return;
        }
        
        this.丂丄丗丈专丟一丁丐();
        AlmanachMainUI.东与七丄丕世丑丟丕(丝三丄专丗丞丄丄丌:  true);
        if(this.七丝丕丅与且丘业万 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.七丝丕丅与且丘业万.Dispose();
        }
        
        this.业下与专三丄丐丟东();
        this.业丌丒丘丙且且丟丂(丙业与丙丗丝不丈东:  false);
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 业下与专三丄丐丟东()
    {
        if(this.丑上丘丌丏丕与东上() == false)
        {
                return;
        }
        
        上且丁万与丌下丐上.三下与丟丟丞丌丄丑();
        this.且丛万丈丗丒一丛丒 = 0;
        this.不上丞上丂丞不不上 = 0;
        this.weaponScroll.Clear();
        this.weaponSetsScroll.Clear();
        this.holder.SetActive(value:  false);
    }
    private bool 丑上丘丌丏丕与东上()
    {
        return AlmanachTutorialManager.TutorialFinished;
    }
    public void AlmanachCategorySelected(AlmanachMainUI.丈丘七丞专丐不且世 七丆丒与丗丌丄且丂, AlmanachMainUI.丘丒丕专丌丅丆丗丄 丙万丘丗丅万丐一世)
    {
        var val_2;
        if((this.不上丞上丂丞不不上 == 七丆丒与丗丌丄且丂) && (this.丅丞丂一丅万丂丂丁 == 丙万丘丗丅万丐一世))
        {
                return;
        }
        
        if((七丆丒与丗丌丄且丂 == 1) && (this.且丛万丈丗丒一丛丒 != null))
        {
                val_2 = this.且丛万丈丗丒一丛丒.业东丅东丌上丗丑不();
        }
        else
        {
                val_2 = 0;
        }
        
        this.ShowAlmanach(与且丒丐丆丆丒丛丏:  七丆丒与丗丌丄且丂, 丄三丛七一丅丘丛丅:  丙万丘丗丅万丐一世, 丞一丁业丄一一业且:  0, 世万丐专世丕业丟东:  true);
    }
    public void UpdateCollectWeaponsStepUI()
    {
        if(上且丁万与丌下丐上.世专丑东丈丌业丌丞().Count >= 1)
        {
                AlmanachCollectWeaponsStep val_4 = 上且丁万与丌下丐上.世专丑东丈丌业丌丞().Item[0];
        }
        
        this.almanachCollectWeaponsStepUI.丈且东丑丂且万丒丅(丝丒丛丄不丑丗业丙:  上且丁万与丌下丐上.丑丐丂丁丝丒丂上丂());
    }
    public void UpdateView()
    {
        丈丘七丞专丐不且世 val_1 = this.不上丞上丂丞不不上;
        if(val_1 == 1)
        {
                this.weaponScroll.UpdateCells();
            val_1 = this.不上丞上丂丞不不上;
        }
        
        if(val_1 == 2)
        {
                this.weaponSetsScroll.UpdateCells();
        }
        
        this.almanachWeaponInfoUI.UpdateView();
    }
    public void ShowAlmanach(AlmanachMainUI.丈丘七丞专丐不且世 与且丒丐丆丆丒丛丏, AlmanachMainUI.丘丒丕专丌丅丆丗丄 丄三丛七一丅丘丛丅, int 丞一丁业丄一一业且, bool 世万丐专世丕业丟东 = True)
    {
        var val_20;
        var val_21;
        System.Action<丈丘七丞专丐不且世, 丘丒丕专丌丅丆丗丄> val_22;
        PGCompany.丌东丛不丅三下业上.丌三丗丞一丐丆丅万();
        this.UpdateCollectWeaponsStepUI();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.collectedWeaponsCount, 丕丗丘丑丛与丑业丒:  上且丁万与丌下丐上.七丞丝业万且丘丑丑() + "/"("/") + 上且丁万与丌下丐上.丕丗七七丒万丏七东().Count);
        System.Collections.Generic.List<AlmanachWeaponSet> val_5 = 上且丁万与丌下丐上.丗丌丆一与丂丌丌与();
        if((AlmanachMainUI.<>c.<>9__69_0) == null)
        {
            goto label_10;
        }
        
        label_43:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.collectedWeaponSetsCount, 丕丗丘丑丛与丑业丒:  val_5.FindAll(match:  AlmanachMainUI.<>c.<>9__69_0).Count(val_5.FindAll(match:  AlmanachMainUI.<>c.<>9__69_0).Count) + "/"("/") + 上且丁万与丌下丐上.丗丌丆一与丂丌丌与().Count);
        this.almanachWeaponInfoUI.Hide();
        this.且丛万丈丗丒一丛丒 = 0;
        this.holder.SetActive(value:  true);
        if(与且丒丐丆丆丒丛丏 == 2)
        {
            goto label_20;
        }
        
        if(与且丒丐丆丆丒丛丏 != 1)
        {
            goto label_22;
        }
        
        this.丆东业专万不且丙丏(丄三丛七一丅丘丛丅:  丄三丛七一丅丘丛丅, 丈丁丄丘丛世七丙丝:  丞一丁业丄一一业且, 世万丐专世丕业丟东:  世万丐专世丕业丟东);
        goto label_22;
        label_10:
        val_20 = 丄三丛七一丅丘丛丅;
        goto label_41;
        label_20:
        this.丒上丒万丌丗专丞丕(丛丘丂丈丘下丂一丛:  丞一丁业丄一一业且, 世万丐专世丕业丟东:  false);
        label_22:
        this.almanachCtegorySelectorUI.SelectButton(七丆丒与丗丌丄且丂:  与且丒丐丆丆丒丛丏, 丙万丘丗丅万丐一世:  丄三丛七一丅丘丛丅);
        this.世世丅丄丛丟丈丑丂();
        val_21 = null;
        val_21 = null;
        val_22 = AlmanachMainUI.万世丒且丗丑不丏丈;
        if(val_22 != null)
        {
                val_22 = AlmanachMainUI.万世丒且丗丑不丏丈;
            if(val_22 == null)
        {
                val_22 = 0;
        }
        
            val_22.Invoke(arg1:  与且丒丐丆丆丒丛丏, arg2:  丄三丛七一丅丘丛丅);
        }
        
        this.丒丒丑丑丞丐丝七一();
        this.丈三丌丕世一与万丕 = CoroutineRunner.Instance.StartCoroutine(routine:  AlmanachMainUI.丌丐不与且一不业丂());
        this.七丝丕丅与且丘业万 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void AlmanachMainUI::丄丌万世丑且丙丛不()), 与且专丈不万东一万:  "AlmanachMainUI");
        AlmanachMainUI.丛丐世专万丛丑丗业 = false;
        return;
        label_41:
        AlmanachMainUI.<>c.<>9__69_0 = new System.Predicate<AlmanachWeaponSet>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AlmanachMainUI.<>c::丕丒世丁丘丘丐丗丞(AlmanachWeaponSet 上万一丈丅丏业丂不));
        if(val_5 != null)
        {
            goto label_43;
        }
        
        goto label_43;
    }
    private void 丂丄丗丈专丟一丁丐()
    {
        if(this.丈三丌丕世一与万丕 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丈三丌丕世一与万丕);
    }
    public override void Hide()
    {
        AlmanachMainUI.东与七丄丕世丑丟丕(丝三丄专丗丞丄丄丌:  true);
        this.Hide();
        if(AlmanachMainUI.不七七丁丛丌丅专万 == null)
        {
                return;
        }
        
        0.Invoke();
    }
    private void 丆东业专万不且丙丏(AlmanachMainUI.丘丒丕专丌丅丆丗丄 丄三丛七一丅丘丛丅, int 丈丁丄丘丛世七丙丝, bool 世万丐专世丕业丟东 = True)
    {
        var val_15;
        .丈丁丄丘丛世七丙丝 = 丈丁丄丘丛世七丙丝;
        this.丅丞丂一丅万丂丂丁 = 丄三丛七一丅丘丛丅;
        this.不上丞上丂丞不不上 = 1;
        this.weaponScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCell>(object:  this, method:  System.Void AlmanachMainUI::丒东丒丒丒丝三丈丝(EndlessScrollCell 丌丝万上丅丒一丈丘)));
        this.weaponScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCell>(object:  this, method:  System.Void AlmanachMainUI::丒东丒丒丒丝三丈丝(EndlessScrollCell 丌丝万上丅丒一丈丘)));
        this.weaponScroll.remove_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void AlmanachMainUI::万丞一丂不专丄丟丒(int 丆专且丕专丗与一丏)));
        this.weaponScroll.add_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void AlmanachMainUI::万丞一丂不专丄丟丒(int 丆专且丕专丗与一丏)));
        System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> val_6 = this.weaponScroll.丈丝七与丄丆丞世丁(丄三丛七一丅丘丛丅:  this.丅丞丂一丅万丂丂丁);
        this.丁丛世丂丕东专丞丒 = val_6;
        this.weaponScrollHolder.gameObject.SetActive(value:  true);
        this.weaponSetsScrollHolder.gameObject.SetActive(value:  false);
        this.丗一丄丘与下万不七(与不丕丆丈不丙丟丛:  this.GetWeaponsUISettings());
        this.weaponScroll.Init(上专丅业三丏丈丈丗:  this.丁丛世丂丕东专丞丒.Count, 丏丑丝万下与丁丞业:  UnityEngine.Mathf.Max(a:  0, b:  val_6.FindIndex(match:  new System.Predicate<PGCompany.丟丝东丈丐丙三下丛>(object:  new AlmanachMainUI.丅丆丛丄丘不丒丂丈(), method:  System.Boolean AlmanachMainUI.丅丆丛丄丘不丒丂丈::丈三不丒丁丌丅业下(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑)))), 世万丐专世丕业丟东:  世万丐专世丕业丟东);
        val_15 = null;
        val_15 = null;
        if(AlmanachMainUI.丑丒万丐丞丒丈专丞 != false)
        {
                this.丅丞不丌丐七丈丄不(一业一丕丅下业世与:  this.且丛万丈丗丒一丛丒);
            val_15 = null;
        }
        
        val_15 = null;
        AlmanachMainUI.丑丒万丐丞丒丈专丞 = false;
    }
    private System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> 丈丝七与丄丆丞世丁(AlmanachMainUI.丘丒丕专丌丅丆丗丄 丄三丛七一丅丘丛丅)
    {
        System.Collections.Generic.IEnumerable<TSource> val_13;
        var val_14;
        System.Comparison<PGCompany.丟丝东丈丐丙三下丛> val_16;
        var val_17;
        var val_19;
        var val_21;
        System.Func<PGCompany.丟丝东丈丐丙三下丛, CategoryNames> val_23;
        var val_24;
        System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Int32> val_26;
        val_13 = System.Linq.Enumerable.ToList<PGCompany.丟丝东丈丐丙三下丛>(source:  上且丁万与丌下丐上.丕丗七七丒万丏七东());
        if(丄三丛七一丅丘丛丅 == 3)
        {
            goto label_3;
        }
        
        if(丄三丛七一丅丘丛丅 == 2)
        {
            goto label_4;
        }
        
        if(丄三丛七一丅丘丛丅 != 1)
        {
            goto label_5;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = AlmanachMainUI.<>c.<>9__73_0;
        if(val_16 != null)
        {
            goto label_8;
        }
        
        System.Comparison<PGCompany.丟丝东丈丐丙三下丛> val_3 = null;
        val_16 = val_3;
        val_3 = new System.Comparison<PGCompany.丟丝东丈丐丙三下丛>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AlmanachMainUI.<>c::一丙丙丞业丅丂丐一(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑, PGCompany.丟丝东丈丐丙三下丛 丒丒丄丁且丄丆丂丌));
        AlmanachMainUI.<>c.<>9__73_0 = val_16;
        if(val_13 != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_3:
        val_17 = null;
        val_17 = null;
        if((AlmanachMainUI.<>c.<>9__73_3) == null)
        {
            goto label_15;
        }
        
        label_37:
        val_19 = null;
        val_13 = val_13.FindAll(match:  AlmanachMainUI.<>c.<>9__73_3);
        val_19 = null;
        val_16 = AlmanachMainUI.<>c.<>9__73_4;
        if(val_16 == null)
        {
            goto label_19;
        }
        
        label_8:
        if(val_13 != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        val_13.Sort(comparison:  val_16);
        label_5:
        if(val_13 != null)
        {
                return (System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>)val_13;
        }
        
        label_33:
        System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> val_5 = null;
        val_13 = val_5;
        val_5 = new System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>(capacity:  0);
        return (System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>)val_13;
        label_4:
        val_21 = null;
        val_21 = null;
        val_23 = AlmanachMainUI.<>c.<>9__73_1;
        if(val_23 == null)
        {
                System.Func<PGCompany.丟丝东丈丐丙三下丛, CategoryNames> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Func<PGCompany.丟丝东丈丐丙三下丛, CategoryNames>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames AlmanachMainUI.<>c::丟丒不丟丕丗丐丟丕(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑));
            AlmanachMainUI.<>c.<>9__73_1 = val_23;
        }
        
        val_24 = null;
        val_24 = null;
        val_26 = AlmanachMainUI.<>c.<>9__73_2;
        if(val_26 == null)
        {
                System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Int32> val_8 = null;
            val_26 = val_8;
            val_8 = new System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Int32>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AlmanachMainUI.<>c::业丁丞丒丝丕业丅三(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑));
            AlmanachMainUI.<>c.<>9__73_2 = val_26;
        }
        
        if((System.Linq.Enumerable.ToList<PGCompany.丟丝东丈丐丙三下丛>(source:  System.Linq.Enumerable.ThenBy<PGCompany.丟丝东丈丐丙三下丛, System.Int32>(source:  System.Linq.Enumerable.OrderBy<PGCompany.丟丝东丈丐丙三下丛, CategoryNames>(source:  val_13, keySelector:  val_6), keySelector:  val_8))) != null)
        {
                return (System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>)val_13;
        }
        
        goto label_33;
        label_15:
        AlmanachMainUI.<>c.<>9__73_3 = new System.Predicate<PGCompany.丟丝东丈丐丙三下丛>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AlmanachMainUI.<>c::丏且丌一丗下东丝丝(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑));
        if(val_13 != null)
        {
            goto label_37;
        }
        
        goto label_37;
        label_19:
        AlmanachMainUI.<>c.<>9__73_4 = new System.Comparison<PGCompany.丟丝东丈丐丙三下丛>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AlmanachMainUI.<>c::丄丒丟三且万一与世(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑, PGCompany.丟丝东丈丐丙三下丛 丒丒丄丁且丄丆丂丌));
        if(val_13 != null)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    private void 丒东丒丒丒丝三丈丝(EndlessScrollCell 丌丝万上丅丒一丈丘)
    {
        int val_7;
        PGCompany.丟丝东丈丐丙三下丛 val_8;
        var val_9;
        if(((丌丝万上丅丒一丈丘.Index & 2147483648) != 0) || (丌丝万上丅丒一丈丘.Index >= this.丁丛世丂丕东专丞丒.Count))
        {
            goto label_5;
        }
        
        val_7 = 丌丝万上丅丒一丈丘.Index;
        val_8 = this.丁丛世丂丕东专丞丒.Item[val_7];
        if(丌丝万上丅丒一丈丘 != null)
        {
            goto label_8;
        }
        
        goto label_14;
        label_5:
        val_8 = 0;
        if(丌丝万上丅丒一丈丘 == null)
        {
            goto label_14;
        }
        
        label_8:
        val_7 = 1152921505032138752;
        val_9 = null;
        val_9 = null;
        label_14:
        丈且东丑丂且万丒丅(一业一丕丅下业世与:  val_8);
    }
    private void 万丞一丂不专丄丟丒(int 丆专且丕专丗与一丏)
    {
        PGCompany.丟丝东丈丐丙三下丛 val_3;
        var val_4;
        if(((丆专且丕专丗与一丏 & 2147483648) == 0) && (this.丁丛世丂丕东专丞丒.Count > 丆专且丕专丗与一丏))
        {
                val_3 = this.丁丛世丂丕东专丞丒.Item[丆专且丕专丗与一丏];
        }
        else
        {
                val_3 = 0;
        }
        
        if(this.且丛万丈丗丒一丛丒 != val_3)
        {
                this.且丛万丈丗丒一丛丒 = val_3;
            val_4 = null;
            val_4 = null;
            if(AlmanachMainUI.丘丞且业下下东不东 == null)
        {
                return;
        }
        
            AlmanachMainUI.丘丞且业下下东不东.Invoke(obj:  this.且丛万丈丗丒一丛丒);
            return;
        }
        
        this.丅丞不丌丐七丈丄不(一业一丕丅下业世与:  val_3);
    }
    private void 丒上丒万丌丗专丞丕(int 丛丘丂丈丘下丂一丛, bool 世万丐专世丕业丟东 = True)
    {
        this.不上丞上丂丞不不上 = 2;
        this.weaponSetsScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void AlmanachMainUI::丟与丒万丄世丆丒丁(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this.weaponSetsScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void AlmanachMainUI::丟与丒万丄世丆丒丁(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this.weaponSetsScroll.remove_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void AlmanachMainUI::丑不丒丑丕万丗世丁(int 丆专且丕专丗与一丏)));
        this.weaponSetsScroll.add_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void AlmanachMainUI::丑不丒丑丕万丗世丁(int 丆专且丕专丗与一丏)));
        this.且业业丛且丟丕三且 = this.GetWeaponSetsUISettings();
        this.UpdateWeaponSetRects();
        this.丘七专丞丕丑丏一丗 = this.且业业丛且丟丕三且;
        this.weaponScrollHolder.gameObject.SetActive(value:  false);
        this.weaponSetsScrollHolder.gameObject.SetActive(value:  true);
        this.weaponSetsScroll.Init(上专丅业三丏丈丈丗:  上且丁万与丌下丐上.丗丌丆一与丂丌丌与().Count, 丏丑丝万下与丁丞业:  丛丘丂丈丘下丂一丛);
    }
    private void 丟与丒万丄世丆丒丁(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        int val_9;
        AlmanachWeaponSet val_10;
        var val_11;
        if(((丌丝万上丅丒一丈丘.Index & 2147483648) != 0) || (丌丝万上丅丒一丈丘.Index >= 上且丁万与丌下丐上.丗丌丆一与丂丌丌与().Count))
        {
            goto label_7;
        }
        
        val_9 = 丌丝万上丅丒一丈丘.Index;
        val_10 = 上且丁万与丌下丐上.丗丌丆一与丂丌丌与().Item[val_9];
        if(丌丝万上丅丒一丈丘 != null)
        {
            goto label_12;
        }
        
        goto label_18;
        label_7:
        val_10 = 0;
        if(丌丝万上丅丒一丈丘 == null)
        {
            goto label_18;
        }
        
        label_12:
        val_9 = 1152921505033043968;
        val_11 = null;
        val_11 = null;
        label_18:
        丈且东丑丂且万丒丅(丕与丝万丑丏丑东与:  val_10);
    }
    private void 丑不丒丑丕万丗世丁(int 丆专且丕专丗与一丏)
    {
    
    }
    public void UpdateWeaponRects()
    {
        List.Enumerator<T> val_1 = this.weaponRectsToUpdate.GetEnumerator();
        label_7:
        if(((-1748734648) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void UpdateWeaponSetRects()
    {
        List.Enumerator<T> val_1 = this.weaponSetRectsToUpdate.GetEnumerator();
        label_7:
        if(((-1748606264) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public bool NeedUpdateWeaponRects()
    {
        if(this.丝专一一世丌丄不丑 == null)
        {
                return true;
        }
        
        if(this.业丈七丟上丁专东东 == null)
        {
                return true;
        }
        
        if(this.丝专一一世丌丄不丑.aspectRatio != this.业丈七丟上丁专东东.aspectRatio)
        {
                return true;
        }
        
        return false;
    }
    private void 丗一丄丘与下万不七(AlmanachMainUI.WeaponsScrollSettings 与不丕丆丈不丙丟丛)
    {
        this.业丈七丟上丁专东东 = 与不丕丆丈不丙丟丛;
        this.UpdateWeaponRects();
        float val_3 = (float)this.weaponScrollHolder.width;
        val_3 = val_3 / (float)与不丕丆丈不丙丟丛.cellsInRow;
        this.weaponScroll.cellCountInRow = 与不丕丆丈不丙丟丛.cellsInRow;
        this.weaponScroll.cellSize = UnityEngine.Mathf.FloorToInt(f:  val_3);
        this.丝专一一世丌丄不丑 = this.业丈七丟上丁专东东;
    }
    public bool NeedUpdateWeaponSetsRects()
    {
        if(this.丘七专丞丕丑丏一丗 == null)
        {
                return true;
        }
        
        if(this.且业业丛且丟丕三且 == null)
        {
                return true;
        }
        
        if(this.丘七专丞丕丑丏一丗 != this.且业业丛且丟丕三且)
        {
                return true;
        }
        
        return false;
    }
    private void 七丟丈万丆丌与丘丘(AlmanachMainUI.WeaponSetsScrollSettings 与不丕丆丈不丙丟丛)
    {
        this.且业业丛且丟丕三且 = 与不丕丆丈不丙丟丛;
        this.UpdateWeaponSetRects();
        this.丘七专丞丕丑丏一丗 = this.且业业丛且丟丕三且;
    }
    public void ToStart()
    {
        if(this.不上丞上丂丞不不上 != 2)
        {
                if(this.不上丞上丂丞不不上 != 1)
        {
                return;
        }
        
            this.weaponScroll.ToStart();
            return;
        }
        
        this.weaponSetsScroll.ToStart();
    }
    public void ToEnd()
    {
        if(this.不上丞上丂丞不不上 != 2)
        {
                if(this.不上丞上丂丞不不上 != 1)
        {
                return;
        }
        
            this.weaponScroll.ToEnd();
            return;
        }
        
        this.weaponSetsScroll.ToEnd();
    }
    public void ToNextReward()
    {
        var val_8;
        var val_9;
        var val_10;
        if(this.不上丞上丂丞不不上 != 2)
        {
                if(this.不上丞上丂丞不不上 != 1)
        {
                return;
        }
        
            val_8 = null;
            val_8 = null;
            if(上且丁万与丌下丐上.丘丆丞丆一且且丌一.Count < 1)
        {
                return;
        }
        
            val_9 = null;
            val_9 = null;
            int val_3 = this.丁丛世丂丕东专丞丒.IndexOf(item:  上且丁万与丌下丐上.丘丆丞丆一且且丌一.Item[0]);
            if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
            this.weaponScroll.ToCell(丞世不丒下上上丝丑:  val_3);
            return;
        }
        
        val_10 = null;
        val_10 = null;
        if(上且丁万与丌下丐上.丙丝丄七一丌丏业丁.Count < 1)
        {
                return;
        }
        
        int val_7 = 上且丁万与丌下丐上.丗丌丆一与丂丌丌与().IndexOf(item:  上且丁万与丌下丐上.丙丝丄七一丌丏业丁.Item[0]);
        if((val_7 & 2147483648) != 0)
        {
                return;
        }
        
        this.weaponSetsScroll.ToCell(丞世不丒下上上丝丑:  val_7);
    }
    private void 丒丒丑丑丞丐丝七一()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        this.toNextRewardButton.SetActive(value:  false);
        if(this.不上丞上丂丞不不上 == 2)
        {
            goto label_2;
        }
        
        if(this.不上丞上丂丞不不上 != 1)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(上且丁万与丌下丐上.丘丆丞丆一且且丌一.Count < 1)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(this.nextRewardUI != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        this.nextRewardUI.Setup(与且专丈不万东一万:  上且丁万与丌下丐上.丕丏丂一与万丟专丙(一业一丕丅下业世与:  上且丁万与丌下丐上.丘丆丞丆一且且丌一.Item[0]));
        this.toNextRewardButton.SetActive(value:  true);
        return;
        label_2:
        val_8 = null;
        val_8 = null;
        if(上且丁万与丌下丐上.丙丝丄七一丌丏业丁.Count < 1)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        AlmanachWeaponSet val_5 = 上且丁万与丌下丐上.丙丝丄七一丌丏业丁.Item[0];
        if(this.nextRewardUI != null)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    private void Update()
    {
        if(this.不上丞上丂丞不不上 == 2)
        {
            goto label_0;
        }
        
        if(this.不上丞上丂丞不不上 != 1)
        {
                return;
        }
        
        this.toStartButton.SetActive(value:  (this.weaponScroll.endlessScrollBar.Value > 0.5f) ? 1 : 0);
        if(this.weaponScroll.endlessScrollBar != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        this.toEndButton.SetActive(value:  (this.weaponScroll.endlessScrollBar.Value <= 0.5f) ? 1 : 0);
        return;
        label_0:
        this.toStartButton.SetActive(value:  (this.weaponSetsScroll.endlessScrollBar.Value > 0.5f) ? 1 : 0);
        if(this.weaponSetsScroll.endlessScrollBar != null)
        {
            goto label_12;
        }
        
        goto label_13;
    }
    private void 三丅下丈丐七万世丅()
    {
    
    }
    private void 下一且万丕一丈丄丗()
    {
    
    }
    public void ShowAlmanachHelpUI()
    {
        if(this.业与丛业丟一业丝丏 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.业与丛业丟一业丝丏.Dispose();
        }
        
        this.业与丛业丟一业丝丏 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void AlmanachMainUI::HideAlmanachHelpUI()), 与且专丈不万东一万:  "AlmanachHelpUI");
        this.almanachHelpUI.SetActive(value:  true);
    }
    public void HideAlmanachHelpUI()
    {
        if(this.业与丛业丟一业丝丏 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.业与丛业丟一业丝丏.Dispose();
        }
        
        this.almanachHelpUI.SetActive(value:  false);
    }
    public AlmanachEndlessScrollCell GetWeaponCell(string 丞丅上丏丂且下丅与)
    {
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        bool val_4 = UnityEngine.Object.op_Equality(x:  System.Linq.Enumerable.First<EndlessScrollCell>(source:  this.weaponScroll.cellsList, predicate:  new System.Func<EndlessScrollCell, System.Boolean>(object:  new AlmanachMainUI.万丐丘不丝一丏丐世(), method:  System.Boolean AlmanachMainUI.万丐丘不丝一丏丐世::丘丙丆不丌丏丞丒与(EndlessScrollCell 三丟东丕丄丄下下丑))), y:  0);
        return 0;
    }
    public AlmanachWeaponSetCell GetWeaponSetCell(string 丞丅上丏丂且下丅与)
    {
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        bool val_4 = UnityEngine.Object.op_Equality(x:  System.Linq.Enumerable.First<EndlessScrollCellDynamic>(source:  this.weaponSetsScroll.cellsList, predicate:  new System.Func<EndlessScrollCellDynamic, System.Boolean>(object:  new AlmanachMainUI.丟丗东丛丘丂丌七丑(), method:  System.Boolean AlmanachMainUI.丟丗东丛丘丂丌七丑::丞万丛丙万万丝不三(EndlessScrollCellDynamic 三丟东丕丄丄下下丑))), y:  0);
        return 0;
    }
    private void 世世丅丄丛丟丈丑丂()
    {
        var val_2;
        if(this.almanachTutorialManager == 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(AlmanachMigrationUI.isActive != false)
        {
                return;
        }
        
        this.almanachTutorialManager.Init();
    }
    internal static System.Collections.IEnumerator 丌丐不与且一不业丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new AlmanachMainUI.世业丁丗七七丐丌丛();
    }
    internal static void 东与七丄丕世丑丟丕(bool 丝三丄专丗丞丄丄丌)
    {
        var val_3;
        System.Action<System.Boolean> val_5;
        var val_6;
        var val_7;
        var val_8;
        val_3 = null;
        val_3 = null;
        val_5 = AlmanachMainUI.<>c.<>9__107_0;
        if(val_5 == null)
        {
                val_5 = null;
            val_5 = new System.Action<System.Boolean>(object:  AlmanachMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AlmanachMainUI.<>c::丐丐七丆三丛与丛丘(bool 丗丛不丁丑专专丂且));
            AlmanachMainUI.<>c.<>9__107_0 = val_5;
        }
        
        val_6 = null;
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_6;
        }
        
        val_7 = null;
        if(AlmanachMainUI.丒上丏丂丟丙丏丛七 == false)
        {
                return;
        }
        
        label_14:
        null.Invoke(obj:  丝三丄专丗丞丄丄丌);
        return;
        label_6:
        val_8 = null;
        if(AlmanachMainUI.丒上丏丂丟丙丏丛七 == false)
        {
            goto label_14;
        }
    
    }
    internal void 丅丞不丌丐七丈丄不(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
    {
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_14;
        string val_15;
        if(一业一丕丅下业世与 == null)
        {
                return;
        }
        
        val_14 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if((PGCompany.丌东丛不丅三下业上.不与与丈丝丌丑丒丞(一业一丕丅下业世与:  一业一丕丅下业世与)) != 0)
        {
                if(一业一丕丅下业世与.丄丕三丄专丆丛丙专() != true)
        {
                val_14 = 1;
        }
        
        }
        
        val_15 = "none";
        if((上且丁万与丌下丐上.一丅丂丞丑下丝业上(与丘东下丈东丛丂万:  一业一丕丅下业世与)) != null)
        {
                val_15 = 上且丁万与丌下丐上.一丅丂丞丑下丝业上(与丘东下丈东丛丂万:  一业一丕丅下业世与).NameDefault;
        }
        
        if((val_14 | DeveloperConsoleController.丙丒丛一丞下三且一()) == false)
        {
                return;
        }
        
        val_14 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        PGCompany.Analytics.一业丗丆世世上丁且.丝万丂与且丂东丘丁(丆丛丑世下一丐且丕:  val_14, 丈丁丄丘丛世七丙丝:  一业一丕丅下业世与.业上丙丞丐丄丆丅七(), 上万一丈丅丏业丂不:  val_15);
        this.almanachWeaponInfoUI.Show(一业一丕丅下业世与:  一业一丕丅下业世与);
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
        this.UpdateView();
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        this.丂丄丗丈专丟一丁丐();
        AlmanachMainUI.东与七丄丕世丑丟丕(丝三丄专丗丞丄丄丌:  true);
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
        return 0.5f;
    }
    public AlmanachMainUI()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.不丂丝丘丅三且与丒 = val_1;
        mem[1152921524336588372] = val_1.g;
        mem[1152921524336588376] = val_1.b;
        mem[1152921524336588380] = val_1.a;
        this.musicClipName = "gallery_music";
    }
    private static AlmanachMainUI()
    {
        AlmanachMainUI.丈七丝丑丑七且丏丗 = 0;
        AlmanachMainUI.丑丒万丐丞丒丈专丞 = false;
        AlmanachMainUI.丒上丏丂丟丙丏丛七 = false;
        AlmanachMainUI.丛丐世专万丛丑丗业 = true;
    }

}
