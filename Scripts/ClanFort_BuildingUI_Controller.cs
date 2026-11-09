using UnityEngine;
public class ClanFort_BuildingUI_Controller : Base_BuildingUI_Controller
{
    // Fields
    private ClanTestMatchBanner 万丒与下丕丛三专丏;
    
    // Properties
    private ClanTestMatchBanner 丑专上东上下专丟且 { get; }
    
    // Methods
    protected override void Start()
    {
        this.Start();
        new System.Action() = new System.Action(object:  this, method:  public System.Void Base_BuildingUI_Controller::OnUpdateBuild());
        ClanFieldBuildController.丑七不且上丗丁一世().丂丑丏上丑丕丏与丙(丙业与丙丗丝不丈东:  new System.Action());
    }
    protected override void OnDestroy()
    {
        this.OnDestroy();
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        new System.Action() = new System.Action(object:  this, method:  public System.Void Base_BuildingUI_Controller::OnUpdateBuild());
        ClanFieldBuildController.丑七不且上丗丁一世().三丛丗丘丞丕丒丝七(丙业与丙丗丝不丈东:  new System.Action());
    }
    public override void OnItemUpgrade()
    {
        ClanFieldBuildController.丑七不且上丗丁一世().业七东丆丐一丛丈丏();
        this.OnItemUpgrade();
    }
    protected override void 且丒万丞丕丏业业丄()
    {
        this.且丒万丞丕丏业业丄();
        ClanFieldBuildController.丑七不且上丗丁一世().且丕丝丆与丒世东丂(业世丟丐丘丐专与不:  0);
    }
    public override void OnBackButton()
    {
        this.OnBackButton();
        if(ClanFieldBuildController.丑七不且上丗丁一世() != 0)
        {
                if(ClanFieldBuildController.丑七不且上丗丁一世().丑东业且专丗丕丙丕() != 0)
        {
                ClanFieldBuildController.丑七不且上丗丁一世().CancelSelectedItem();
        }
        
        }
        
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().与丟丝上丟三丝东丐();
    }
    public override void PlaceButtonPressed(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        string val_8;
        丑业专丄七与与丕上 val_9;
        this.PlaceButtonPressed(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        val_9 = 业世丟丐丘丐专与不.itemType;
        if(val_9 == 1)
        {
                ClanFieldBuildController val_3 = ClanFieldBuildController.丑七不且上丗丁一世();
            if((ClanFieldBuildController.丑七不且上丗丁一世().丞东丆丝丞下丆世丆(与不丕丆丈不丙丟丛:  业世丟丐丘丐专与不)) > val_3.上丝东丈丂丐丌丅与)
        {
                UnityEngine.Debug.LogError(message:  "Not enough energy!");
            return;
        }
        
            val_8 = 1152921505144119296;
            if(FortFieldTurretPlatformController.instance != 0)
        {
                val_8 = 业世丟丐丘丐专与不.CategoryName;
            FortFieldTurretPlatformController.instance.丙丘与丒七丒丞丗丈(丈与丏且丆丗七丑丛:  val_8, 七丐丌上上万丘三丆:  业世丟丐丘丐专与不.SubcategoryName);
        }
        
            ClanFieldBuildController.丑七不且上丗丁一世().且丕丝丆与丒世东丂(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
            val_9 = 业世丟丐丘丐专与不.itemType;
        }
        
        val_9 = val_9 & 4294967294;
        if(val_9 != 2)
        {
                return;
        }
        
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.东丌丟三丞世一一丑(业世丟丐丘丐专与不:  业世丟丐丘丐专与不, 东且丄专丞丆丂业一:  false);
    }
    public override void OnClick(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        this.OnClick(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        if(业世丟丐丘丐专与不.itemType != 3)
        {
                return;
        }
        
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.SetTemporaryItem(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
    }
    public override int GetInstalledItemsCount(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        }
        
        return val_1.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
    }
    public override int GetMaxEnegrgy()
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.MaxBuildEnergy;
        }
        
        return val_1.MaxBuildEnergy;
    }
    public override int GetCurrentEnergy()
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
    }
    public override int GetCurrentItemEnergy(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丞东丆丝丞下丆世丆(与不丕丆丈不丙丟丛:  业世丟丐丘丐专与不);
        }
        
        return val_1.丞东丆丝丞下丆世丆(与不丕丆丈不丙丟丛:  业世丟丐丘丐专与不);
    }
    public override int GetPreviousItemEnergy(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.世丗丄丄丛丕业丕丅(与不丕丆丈不丙丟丛:  业世丟丐丘丐专与不);
        }
        
        return val_1.世丗丄丄丛丕业丕丅(与不丕丆丈不丙丟丛:  业世丟丐丘丐专与不);
    }
    public override float GetCurrentEnergyMagnifier(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        var val_1 = this;
        return ClanFieldBuildController.上上丗丗丏丞万丁丞(与不丕丆丈不丙丟丛:  null, 丌丒丝东丌下丕丁丅:  -2102906032);
    }
    internal override 世专丙丟且丗丄丆丌 东丒丌丞丈丏丂丗丈()
    {
        ClanFieldBuildController val_1 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丒丑丛世丘业丗丑丛();
        }
        
        return val_1.丒丑丛世丘业丗丑丛();
    }
    public override void DEV_IncreaseMaxEnergy()
    {
    
    }
    public override void DEV_DecreaseMaxEnergy()
    {
    
    }
    private ClanTestMatchBanner 丙且丁三丐丈东丑业()
    {
        UnityEngine.GameObject val_8;
        if(this.万丒与下丕丛三专丏 != 0)
        {
                return (ClanTestMatchBanner)this.万丒与下丕丛三专丏;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "NguiWindows/Clan/ClanTestMatch_Banner");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_8 = 0;
        }
        
        UnityEngine.GameObject val_5 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  Base_BuildingUI.instance.gameObject, 丑且不丕与专丄业丙:  val_8);
        if(val_5 != null)
        {
                this.万丒与下丕丛三专丏 = val_5.GetComponent<ClanTestMatchBanner>();
        }
        else
        {
                this.万丒与下丕丛三专丏 = 0.GetComponent<ClanTestMatchBanner>();
        }
        
        val_5.SetActive(value:  false);
        return (ClanTestMatchBanner)this.万丒与下丕丛三专丏;
    }
    public override void TestConnect()
    {
        SquareField.丄丘七三上丕世丞业.丝丐丈业丘丂丐丁丞();
        ClanFieldBuildController.丑七不且上丗丁一世().丕与世万不丒丌三丂();
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.七丞丒专万且丟丞丅();
        this.丙且丁三丐丈东丑业().专万万一丁业丘下丕(丞东丗万丌丏丛丒丄:  false, 三丑丁一丐丘丟丄丈:  new System.Action(object:  this, method:  System.Void ClanFort_BuildingUI_Controller::下丄丑三专下丛丛丒()));
    }
    private void 下丄丑三专下丛丛丒()
    {
        this.丁丒丗丞丂丏业业丗().丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void ClanFort_BuildingUI_Controller::丈丑与丄东丆丙丄丆()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    internal override void 丅丑丒丟丆丛丁三东()
    {
    
    }
    public ClanFort_BuildingUI_Controller()
    {
    
    }
    private void 丈丑与丄东丆丙丄丆()
    {
        null = null;
        MainMenuController.业丏不世下专下丅丅 = true;
        goto typeof(ClanFort_BuildingUI_Controller).__il2cppRuntimeField_1C8;
    }

}
