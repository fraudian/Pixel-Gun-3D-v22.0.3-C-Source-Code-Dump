using UnityEngine;
public class Base_BuildingUI_Controller : PGBehaviour
{
    // Fields
    public static Base_BuildingUI_Controller instance;
    private System.Action 丘丐专专丙与且且丌;
    public Base_BuildingUI buildingUI;
    internal bool 且丄丏上丐丛世且丗;
    internal bool 东丅丙丆丒丆三丂七;
    private UnityEngine.GameObject 丗上丏丟丆专与丗丆;
    private ConnectionControl 丟丘世东丐丌丕丂丝;
    
    // Properties
    protected ConnectionControl 丙不丅丝丙专丕世丐 { get; }
    
    // Methods
    internal void 业丆丝不七一七世丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丘丐专专丙与且且丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丐专专丙与且且丌 != 1152921536854303912);
    
    }
    internal void 世东丂一丄三下业丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丘丐专专丙与且且丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丐专专丙与且且丌 != 1152921536854440488);
    
    }
    protected virtual void Awake()
    {
        Base_BuildingUI_Controller.instance = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.且丄丏上丐丛世且丗 = System.String.op_Equality(a:  val_1.m_Handle.name, b:  "FortFieldBuild");
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.东丅丙丆丒丆三丂七 = System.String.op_Equality(a:  val_5.m_Handle.name, b:  "ClanTankBuild");
        万专丙丌丌丐上丟三.不下丑丆丐且丆下与();
        this.buildingUI.丌丐与丙东万上丛东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1A0));
        this.buildingUI.世业丐丏丗业丟一上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1B0));
        this.buildingUI.丐丗世三丝丞专三一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1C0));
        丌丅且丗七丘丅丛丑.丌业三专丞丆万丏丁(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void Base_BuildingUI_Controller::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_230));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_240));
    }
    private void 丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆.世丛丘丙世丝丟一丂 <= 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂)
        {
                return;
        }
        
        if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() != false)
        {
                return;
        }
        
        丌丅且丗七丘丅丛丑.丏丂专丄七且不丌丛(与上丟丏业专业与专:  new 上丑下丆丄下丝东世() {丒丗丝七丛丟专丄丂 = 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂, 且丅七丏业丛丙丟下 = 万且万且丑丗且丌丆.且丅七丏业丛丙丟下, 世丛丘丙世丝丟一丂 = 万且万且丑丗且丌丆.世丛丘丙世丝丟一丂, 丟专丙丐专世丁与一 = 万且万且丑丗且丌丆.丟专丙丐专世丁与一});
    }
    protected virtual void Start()
    {
    
    }
    protected virtual void OnDestroy()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1A0);
        this.buildingUI.丄专丏丅丗丐丏万专(丙业与丙丗丝不丈东:  new System.Action());
        this.buildingUI.丑丕一丁专一三且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1B0));
        this.buildingUI.丝丈专且丆业一丄丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_1C0));
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_230));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(Base_BuildingUI_Controller).__il2cppRuntimeField_240));
        丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void Base_BuildingUI_Controller::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
    }
    protected virtual void 丈丗丈丌丁丒东下业()
    {
        if(this.buildingUI != null)
        {
            goto label_0;
        }
        
        this.buildingUI = this.buildingUI;
        if(this.buildingUI == null)
        {
            goto label_1;
        }
        
        label_0:
        this.世丆丘丏丙丗专丙丙(七丆丒与丗丌丄且丂:  this.buildingUI.selectedCategory, 丒丑丞丁世丌专不丈:  this.buildingUI.selectedSubcategory);
        return;
        label_1:
    }
    protected virtual void 且丒万丞丕丏业业丄()
    {
        if(this.buildingUI != null)
        {
            goto label_0;
        }
        
        this.buildingUI = this.buildingUI;
        if(this.buildingUI == null)
        {
            goto label_1;
        }
        
        label_0:
        this.世丆丘丏丙丗专丙丙(七丆丒与丗丌丄且丂:  this.buildingUI.selectedCategory, 丒丑丞丁世丌专不丈:  this.buildingUI.selectedSubcategory);
        return;
        label_1:
    }
    protected virtual void 丘下丟丁上丏丛且且()
    {
        this.buildingUI.itemsListUI.东丒不七丝万丌丄三();
    }
    public virtual void OnBackButton()
    {
    
    }
    public virtual void PlaceButtonPressed(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
    
    }
    public virtual void RemoveButtonPressed(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
    
    }
    public virtual void OnClick(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
    
    }
    public virtual bool IsItemInfoUIShown()
    {
        if(this.buildingUI.itemInfoUI != null)
        {
                return this.buildingUI.itemInfoUI.IsShown;
        }
        
        return this.buildingUI.itemInfoUI.IsShown;
    }
    public virtual void ToggleItemInfoUI(PlaceableItemSettings 业世丟丐丘丐专与不, bool 丛丅丘一丏丙且丌上)
    {
        if(this.buildingUI.itemInfoUI == null)
        {
            goto label_1;
        }
        
        if(丛丅丘一丏丙且丌上 == false)
        {
            goto label_2;
        }
        
        label_3:
        bool val_1 = this.buildingUI.itemInfoUI.Show(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        return;
        label_1:
        if(丛丅丘一丏丙且丌上 == true)
        {
            goto label_3;
        }
        
        label_2:
        this.buildingUI.itemInfoUI.Hide();
    }
    public virtual void OnItemUpgrade()
    {
    
    }
    public virtual void OnUpdateBuild()
    {
        if(this.丘丐专专丙与且且丌 != null)
        {
                this.丘丐专专丙与且且丌.Invoke();
        }
        
        this.buildingUI.itemsListUI.东丒不七丝万丌丄三();
    }
    public virtual bool PlacedOnSelected(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        return false;
    }
    public virtual int GetInstalledItemsCount(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        return 0;
    }
    public virtual int GetMaxEnegrgy()
    {
        return 0;
    }
    public virtual int GetCurrentEnergy()
    {
        return 0;
    }
    public virtual int GetCurrentItemEnergy(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(业世丟丐丘丐专与不 != null)
        {
                return 业世丟丐丘丐专与不.Energy;
        }
        
        return 业世丟丐丘丐专与不.Energy;
    }
    public virtual int GetPreviousItemEnergy(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(业世丟丐丘丐专与不 != null)
        {
                return 业世丟丐丘丐专与不.Energy;
        }
        
        return 业世丟丐丘丐专与不.Energy;
    }
    public virtual float GetCurrentEnergyMagnifier(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        return 1f;
    }
    public virtual bool UpgradeItem(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  业世丟丐丘丐专与不.丈业丂不三丌不丂丁(), 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = false});
        }
        
        return val_1.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  业世丟丐丘丐专与不.丈业丂不三丌不丂丁(), 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = false});
    }
    internal virtual 世专丙丟且丗丄丆丌 东丒丌丞丈丏丂丗丈()
    {
        return 0;
    }
    public virtual void DEV_IncreaseMaxEnergy()
    {
    
    }
    public virtual void DEV_DecreaseMaxEnergy()
    {
    
    }
    protected void 世丆丘丏丙丗专丙丙(string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        if(CameraMoverDirectoryManager.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        CameraMoverDirectoryManager.丄丘七三上丕世丞业.丛丛丟丁丛一丕丞丝(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 丒丑丞丁世丌专不丈:  丒丑丞丁世丌专不丈);
    }
    protected ConnectionControl 丁丒丗丞丂丏业业丗()
    {
        ConnectPanel val_11;
        UnityEngine.GameObject val_12;
        val_11 = 1152921504848912384;
        if(this.丟丘世东丐丌丕丂丝 != 0)
        {
                return (ConnectionControl)this.丟丘世东丐丌丕丂丝;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_2 != null)
        {
                val_2 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_12 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_12);
        this.丗上丏丟丆专与丗丆 = val_3;
        val_3.transform.SetParent(parent:  Base_BuildingUI.instance.transform, worldPositionStays:  false);
        this.丗上丏丟丆专与丗丆.SetActive(value:  false);
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丗上丏丟丆专与丗丆, 不东丛三丂丌丑专丆:  Base_BuildingUI.instance.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        ConnectionControl val_9 = this.gameObject.AddComponent<ConnectionControl>();
        this.丟丘世东丐丌丕丂丝 = val_9;
        val_11 = this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>();
        val_9.SetConnectPanel(丛丘下丗业丂一且业:  val_11);
        return (ConnectionControl)this.丟丘世东丐丌丕丂丝;
    }
    public virtual void TestConnect()
    {
    
    }
    internal virtual bool 万丐丒丝丟丘丌丘不(string 丟下丟丈万一丙东丄)
    {
        return false;
    }
    internal virtual void 丅丑丒丟丆丛丁三东()
    {
    
    }
    public Base_BuildingUI_Controller()
    {
    
    }

}
