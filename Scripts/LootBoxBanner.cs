using UnityEngine;
internal sealed class LootBoxBanner : BannerWindowWithBack
{
    // Fields
    private static System.Action 七东业丅丗下一丄丘;
    private static System.Action 且丆万丂世不丑丙世;
    private static System.Action 丝上丂一不专丂丄不;
    private static bool <不丟东上丂丘一不万>k__BackingField;
    internal MiniPoolGroup pool;
    internal UnityEngine.Transform lootBoxUIHolder;
    private PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丑丅不丄丑丒丝且业;
    private LootBoxUI 万丒且上丈丌丘与万;
    
    // Properties
    internal static bool 丅业东万丌丕上丌丄 { get; set; }
    
    // Methods
    internal static void 丙七不丗东丞丘专不(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  LootBoxBanner.七东业丅丗下一丄丘, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丞丕丂丏丌丈专业丕(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  LootBoxBanner.七东业丅丗下一丄丘, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 世丁万丛上丈丆丈不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LootBoxBanner.且丆万丂世不丑丙世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxBanner.且丆万丂世不丑丙世 != 1152921505200566280);
    
    }
    internal static void 丐东丄专业丁丅一丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LootBoxBanner.且丆万丂世不丑丙世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxBanner.且丆万丂世不丑丙世 != 1152921505200566280);
    
    }
    internal static void 东丑业丒且业丌丝丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LootBoxBanner.丝上丂一不专丂丄不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxBanner.丝上丂一不专丂丄不 != 1152921505200566288);
    
    }
    internal static void 丝七一不与不丙丕丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LootBoxBanner.丝上丂一不专丂丄不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxBanner.丝上丂一不专丂丄不 != 1152921505200566288);
    
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        return (bool)LootBoxBanner.<不丟东上丂丘一不万>k__BackingField;
    }
    private static void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
    {
        LootBoxBanner.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public static void ShowLootBoxUI(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丁丑丗丐专丌丝丗, Rilisoft.BankBannersHolder 丘丒丅三丞丞丛丛丌)
    {
        UnityEngine.Object val_3;
        var val_6;
        PGCompany.丆下丐丁丏世丈上丟 val_7;
        val_3 = 丘丒丅三丞丞丛丛丌;
        if(val_3 != 0)
        {
                val_6 = 100;
        }
        else
        {
                ModalBannerHolder val_2 = ModalBannerHolder.丑七不且上丗丁一世();
            val_3 = val_2.lootBoxHolder;
            val_6 = 100;
            val_7;
        }
        
        val_3.ShowBanner(丌丅丕一丛丛丄一万:  100, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = 七丁丑丗丐专丌丝丗, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public override void Show()
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_2;
        this.Show();
        PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
        this.上下丈丈专丞丒不世(七丁丑丗丐专丌丝丗:  val_2);
    }
    internal void 上下丈丈专丞丒不世(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丁丑丗丐专丌丝丗)
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_19;
        var val_20;
        string val_21;
        LootBoxUI val_22;
        var val_23;
        val_19 = 七丁丑丗丐专丌丝丗;
        val_20 = this;
        this.丌丞下万丈丒丑万丅();
        this.丑丅不丄丑丒丝且业 = val_19;
        if(this.万丒且上丈丌丘与万 != 0)
        {
                string val_4 = val_19.丟不丛丑一丗丄业丟().丟一上丝丆丈下丈丄();
            if((this.万丒且上丈丌丘与万.name.Equals(value:  val_4.丞丛丟下丌不丆世丗(丒丘丏上丙丟丑丕丈:  val_4))) != true)
        {
                val_21 = this.万丒且上丈丌丘与万.name;
            this.pool.Return(丛丄业丕且丗下一万:  val_21, 万且万且丑丗且丌丆:  this.万丒且上丈丌丘与万);
            this.万丒且上丈丌丘与万 = 0;
        }
        
        }
        
        val_22 = this.万丒且上丈丌丘与万;
        val_23 = 0;
        if(val_22 != 0)
        {
            goto label_16;
        }
        
        val_19 = this.丗一丙丄丙丑丛丄丗(七丁丑丗丐专丌丝丗:  val_19);
        this.万丒且上丈丌丘与万 = val_19;
        val_23 = 0;
        if(val_19 != 0)
        {
            goto label_16;
        }
        
        UnityEngine.Debug.LogError(message:  "No LootBoxUI!");
        val_19 = ???;
        val_20 = ???;
        val_22 = ???;
        val_21 = ???;
        goto typeof(LootBoxBanner).__il2cppRuntimeField_218;
        label_16:
        val_20.丑丏上丈丒丂且丞丛();
        if((val_20 + 320 + 8) == 0)
        {
            
        }
    
    }
    private LootBoxUI 丗一丙丄丙丑丛丄丗(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丁丑丗丐专丌丝丗)
    {
        LootBoxUI val_8 = this.pool.Get<LootBoxUI>(丛丄业丕且丗下一万:  七丁丑丗丐专丌丝丗.丟不丛丑一丗丄业丟().丟一上丝丆丈下丈丄());
        if(val_8 == 0)
        {
                val_8 = this.pool.Get<LootBoxUI>(丛丄业丕且丗下一万:  "LootBoxes/Prefabs/LootBoxUI/Default_LootBoxUI");
        }
        
        val_8.transform.SetParent(p:  this.lootBoxUIHolder);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_8.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
        return (LootBoxUI)val_8;
    }
    private string 丞丛丟下丌不丆世丗(string 丒丘丏上丙丟丑丕丈)
    {
        return "LootBoxes/Prefabs/LootBoxUI/"("LootBoxes/Prefabs/LootBoxUI/") + 丒丘丏上丙丟丑丕丈;
    }
    private void 丑丏上丈丒丂且丞丛()
    {
        if(this.万丒且上丈丌丘与万 == 0)
        {
                return;
        }
        
        this.万丒且上丈丌丘与万.add_onCurrentViewSetup(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCurrentViewSetup()));
        this.万丒且上丈丌丘与万.add_onChestOpen(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCurrentLootBox()));
        this.万丒且上丈丌丘与万.add_onAnimationStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxBanner::丗丒丏丁丂丁七一丒()));
        this.万丒且上丈丌丘与万.add_onAnimationFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxBanner::三七不丂丂东丈丙丄()));
        this.万丒且上丈丌丘与万.add_onCollectRewards(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCollectRewards()));
        this.万丒且上丈丌丘与万.add_onBackPressed(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnBackPressed()));
    }
    private void 丌丞下万丈丒丑万丅()
    {
        if(this.万丒且上丈丌丘与万 == 0)
        {
                return;
        }
        
        this.万丒且上丈丌丘与万.remove_onCurrentViewSetup(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCurrentViewSetup()));
        this.万丒且上丈丌丘与万.remove_onChestOpen(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCurrentLootBox()));
        this.万丒且上丈丌丘与万.remove_onAnimationStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxBanner::丗丒丏丁丂丁七一丒()));
        this.万丒且上丈丌丘与万.remove_onAnimationFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxBanner::三七不丂丂东丈丙丄()));
        this.万丒且上丈丌丘与万.remove_onCollectRewards(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnCollectRewards()));
        this.万丒且上丈丌丘与万.remove_onBackPressed(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void LootBoxBanner::OnBackPressed()));
    }
    public override void Hide()
    {
        this.丌丞下万丈丒丑万丅();
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.万丒且上丈丌丘与万, y:  0);
        this.Hide();
        if(LootBoxBanner.丝上丂一不专丂丄不 == null)
        {
                return;
        }
        
        LootBoxBanner.丝上丂一不专丂丄不.Invoke();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    protected override void OnEnable()
    {
        LootBoxBanner.<不丟东上丂丘一不万>k__BackingField = true;
        if(LootBoxBanner.七东业丅丗下一丄丘 != null)
        {
                LootBoxBanner.七东业丅丗下一丄丘.Invoke();
        }
        
        this.OnEnable();
        ModalBannerHolder.丑七不且上丗丁一世().丐业专丆万不世丈丑(丙业与丙丗丝不丈东:  false);
    }
    protected override void OnDisable()
    {
        LootBoxBanner.<不丟东上丂丘一不万>k__BackingField = false;
        if(LootBoxBanner.且丆万丂世不丑丙世 != null)
        {
                LootBoxBanner.且丆万丂世不丑丙世.Invoke();
        }
        
        this.OnDisable();
        ModalBannerHolder.丑七不且上丗丁一世().丐业专丆万不世丈丑(丙业与丙丗丝不丈东:  true);
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
    public void OnCurrentViewSetup()
    {
    
    }
    public void OnCurrentLootBox()
    {
    
    }
    private void 丗丒丏丁丂丁七一丒()
    {
    
    }
    private void 三七不丂丂东丈丙丄()
    {
    
    }
    public void OnCollectRewards()
    {
    
    }
    public void OnBackPressed()
    {
        goto typeof(LootBoxBanner).__il2cppRuntimeField_218;
    }
    public LootBoxBanner()
    {
    
    }

}
