using UnityEngine;
public class PlaceableItemButton : PGBehaviour
{
    // Fields
    private PlaceableItemSettings 丑丝一一三丟三三丞;
    public SelectableButton selectableButton;
    protected UILabel title;
    protected UITextureMasked texture;
    protected UILabel energyCount;
    protected System.Collections.Generic.List<UnityEngine.GameObject> notEnoughEnergy;
    protected System.Collections.Generic.List<UIWidget> notEnoughEnergyWidgets;
    protected UnityEngine.GameObject parametersGO;
    protected UnityEngine.GameObject infoButton;
    private PropertiesLayout propertiesLayout;
    private ClanDivisionUI lockedByClanDivision;
    private PlaceableItemUpgradableUI upgradableUI;
    private PlaceableItemNotUpgradableUI notNpgradableUI;
    private UnityEngine.GameObject newNotifContainer;
    private UnityEngine.GameObject unknownItemUI;
    private bool 下丆下丆三丕丈专丂;
    
    // Properties
    public PlaceableItemSettings 丈丛专丕下下丄丝丑 { get; set; }
    public bool 与丆与丂丄丞丒丏丑 { get; }
    private bool 东不丗东丑丄与不丕 { get; }
    public bool 丏一丆专与上丈三丈 { get; }
    
    // Methods
    public PlaceableItemSettings get_ItemSettings()
    {
        return (PlaceableItemSettings)this.丑丝一一三丟三三丞;
    }
    public void set_ItemSettings(PlaceableItemSettings 丙业与丙丗丝不丈东)
    {
        this.丑丝一一三丟三三丞 = 丙业与丙丗丝不丈东;
    }
    public bool get_Selected()
    {
        if(this.selectableButton != null)
        {
                return (bool)this.selectableButton.selected;
        }
        
        return (bool)this.selectableButton.selected;
    }
    internal virtual void 丈且东丑丂且万丒丅(PlaceableItemSettings 业世丟丐丘丐专与不, bool 且丑丛丏丌世丆七丌 = False)
    {
        this.丑丝一一三丟三三丞 = 业世丟丐丘丐专与不;
        this.upgradableUI.丙丞万丑不不七业丗 = this;
        this.notNpgradableUI.丙丞万丑不不七业丗 = this;
        this.gameObject.SetActive(value:  true);
        丂丘丗丗与且丌丁丙.丆丌丕世丅专下丝丐(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemButton::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
        丂丘丗丗与且丌丁丙.丞丌丄与东东丛丝丛(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemButton::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
    }
    private void OnDestroy()
    {
        丂丘丗丗与且丌丁丙.丆丌丕世丅专下丝丐(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemButton::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
    }
    private void 专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(this.丑丝一一三丟三三丞 == 业世丟丐丘丐专与不)
        {
            goto typeof(PlaceableItemButton).__il2cppRuntimeField_178;
        }
    
    }
    internal virtual void 东丒不七丝万丌丄三()
    {
        PlaceableItemSettings val_19;
        PlaceableItemUpgradableUI val_20;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unknownItemUI, 丏业丟一东丂东丘丛:  false);
        this.upgradableUI.gameObject.SetActive(value:  false);
        this.notNpgradableUI.gameObject.SetActive(value:  false);
        this.lockedByClanDivision.gameObject.SetActive(value:  false);
        if(this.丑丝一一三丟三三丞 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.infoButton, 丏业丟一东丂东丘丛:  (~this.丑丝一一三丟三三丞.IsDecoration) & 1);
        if(this.丑丝一一三丟三三丞.IsUnknown != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unknownItemUI, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        bool val_7 = this.丑丝一一三丟三三丞.IsKnownResources;
        this.name = this.丑丝一一三丟三三丞.name;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  this.丑丝一一三丟三三丞.丑东丐下专丞丕丘世());
        val_19 = this.丑丝一一三丟三三丞;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.title, 丕丗丘丑丛与丑业丒:  val_19.丘丄业丞丏与与丅丐());
        if(this.丑丝一一三丟三三丞.IsPurchased != true)
        {
                val_19 = this.丑丝一一三丟三三丞;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛()) < val_19.ClanDivision)
        {
                this.lockedByClanDivision.gameObject.SetActive(value:  true);
            val_19 = this.丑丝一一三丟三三丞.ClanDivision;
            this.lockedByClanDivision.丈且东丑丂且万丒丅(丅丅下丟丑专下与一:  val_19);
        }
        
        }
        
        if(this.丑丝一一三丟三三丞.IsUpgradable == false)
        {
            goto label_33;
        }
        
        this.upgradableUI.UpdateUI();
        val_20 = this.upgradableUI;
        if(val_20 != null)
        {
            goto label_38;
        }
        
        goto label_36;
        label_33:
        this.notNpgradableUI.UpdateUI();
        val_20 = this.notNpgradableUI;
        if(val_20 != null)
        {
            goto label_38;
        }
        
        label_36:
        label_38:
        val_20.gameObject.SetActive(value:  true);
        goto typeof(PlaceableItemButton).__il2cppRuntimeField_1B8;
    }
    private bool 丘丆一且丂丒上万丐()
    {
        var val_7;
        var val_8;
        val_7 = this;
        if(this.丑丝一一三丟三三丞 != null)
        {
                if(this.丑丝一一三丟三三丞.IsPurchased != false)
        {
                val_8 = 1;
            return (bool)(val_7 >= this.丑丝一一三丟三三丞.ClanDivision) ? 1 : 0;
        }
        
        }
        
        val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛();
        return (bool)(val_7 >= this.丑丝一一三丟三三丞.ClanDivision) ? 1 : 0;
    }
    public bool get_ShowingParameters()
    {
        if(this.parametersGO != null)
        {
                return this.parametersGO.activeSelf;
        }
        
        return this.parametersGO.activeSelf;
    }
    public virtual void ShowParameters()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.parametersGO, 丏业丟一东丂东丘丛:  true);
        this.propertiesLayout.世业丒万丘丆专丘丐();
        goto typeof(PlaceableItemButton).__il2cppRuntimeField_178;
    }
    public virtual void HideParameters()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.parametersGO, 丏业丟一东丂东丘丛:  false);
        goto typeof(PlaceableItemButton).__il2cppRuntimeField_178;
    }
    public virtual void OnClick()
    {
        PlaceableItemSettings val_2;
        PlaceableItemSettings val_3;
        var val_5;
        val_2 = this;
        if(this.丘丆一且丂丒上万丐() == false)
        {
                return;
        }
        
        if(this.selectableButton.selected != false)
        {
                val_3 = 1152921505159667712;
            if((Base_BuildingUI_Controller.instance & 1) != 0)
        {
                val_5 = 0;
        }
        else
        {
                val_3 = this.丑丝一一三丟三三丞;
            val_5 = 1;
        }
        
        }
        
        if((Base_BuildingUI_Controller.instance & 1) != 0)
        {
                val_3 = this.丑丝一一三丟三三丞;
            val_5 = 1;
        }
        else
        {
                val_2 = this.丑丝一一三丟三三丞;
        }
        
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    protected virtual void 丙与丁丞丝万丏丆三()
    {
        var val_13;
        var val_14;
        var val_16;
        System.Collections.Generic.List<UnityEngine.GameObject> val_17;
        var val_18;
        Base_BuildingUI_Controller val_3 = instance + ((this.丑丝一一三丟三三丞.Placeable != true) ? 352 : 368);
        bool val_4 = Base_BuildingUI_Controller.instance.Equals(other:  this.丑丝一一三丟三三丞);
        if(val_4 <= false)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.energyCount, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.energyCount, 丕丗丘丑丛与丑业丒:  val_4);
        val_13 = null;
        if(this.七丝三丆丝丏三不丄() <= Base_BuildingUI_Controller.instance)
        {
            goto label_7;
        }
        
        val_14 = null;
        if((PlaceableItemButton.<>c.<>9__32_1) == null)
        {
            goto label_10;
        }
        
        label_32:
        this.notEnoughEnergyWidgets.ForEach(action:  PlaceableItemButton.<>c.<>9__32_1);
        val_16 = PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业();
        val_17 = this.notEnoughEnergy;
        goto label_16;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.energyCount, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.notEnoughEnergy, 丏业丟一东丂东丘丛:  false);
        return;
        label_7:
        val_18 = null;
        if((PlaceableItemButton.<>c.<>9__32_0) == null)
        {
            goto label_21;
        }
        
        label_36:
        this.notEnoughEnergyWidgets.ForEach(action:  PlaceableItemButton.<>c.<>9__32_0);
        val_17 = this.notEnoughEnergy;
        val_16 = 0;
        label_16:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  false);
        int val_9 = this.丑丝一一三丟三三丞.一丌世丑丄东丞丘三().丑丐丙丄丅世世丑丒().丂丁丏一丙丛业且丌();
        return;
        label_10:
        PlaceableItemButton.<>c.<>9__32_1 = new System.Action<UIWidget>(object:  PlaceableItemButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PlaceableItemButton.<>c::丁下专不丈丑东一专(UIWidget 三丟东丕丄丄下下丑));
        if(this.notEnoughEnergyWidgets != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_21:
        PlaceableItemButton.<>c.<>9__32_0 = new System.Action<UIWidget>(object:  PlaceableItemButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PlaceableItemButton.<>c::丌不且丂丑上丂业三(UIWidget 三丟东丕丄丄下下丑));
        if(this.notEnoughEnergyWidgets != null)
        {
            goto label_36;
        }
        
        goto label_36;
    }
    public virtual void PlaceButtonPressed()
    {
        var val_19;
        var val_20;
        PlaceableItemSettings val_21;
        string val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        PlaceableItemSettings val_27;
        val_19 = null;
        val_19 = null;
        if((System.String.op_Equality(a:  this.丑丝一一三丟三三丞.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false)
        {
                if(ClanFieldBuildController.丑七不且上丗丁一世() != 0)
        {
                val_20 = ClanFieldBuildController.丑七不且上丗丁一世().丑丐且且丙丙丒专七();
        }
        else
        {
                val_20 = 0;
        }
        
            val_21 = this.丑丝一一三丟三三丞;
            if(val_21 != null)
        {
                val_22 = this.丑丝一一三丟三三丞.name;
        }
        else
        {
                val_22 = this.丑丝一一三丟三三丞.name;
            if(this.丑丝一一三丟三三丞 != null)
        {
                val_21 = this.丑丝一一三丟三三丞;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
            PGCompany.Analytics.一业丗丆世世上丁且.东一不东业与下世丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  0, 七丐丅专且专七三丆:  3, 东丝丅专丝丈一丘下:  0, 上丕丟丌上丐丝上上:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上上三七丟丝与丆与(), 丒丘丏上丙丟丑丕丈:  val_22, 下丗丁丒丘东丂不丑:  val_21.SubcategoryName, 丒世丘丘上丆丝东丞:  0, 丂下丛丝丆丂七丏丘:  0);
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = 0;
        if((System.String.op_Equality(a:  this.丑丝一一三丟三三丞.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) != false)
        {
                val_25 = null;
            val_25 = null;
            if(ClanTankBuildController.丄丘七三上丕世丞业 != 0)
        {
                val_26 = null;
            val_26 = null;
            val_20 = ClanTankBuildController.丄丘七三上丕世丞业.丄丛丁丕世丞丞三三();
        }
        else
        {
                val_20 = 0;
        }
        
            val_27 = this.丑丝一一三丟三三丞;
            if(val_27 != null)
        {
                val_22 = this.丑丝一一三丟三三丞.name;
        }
        else
        {
                val_22 = this.丑丝一一三丟三三丞.name;
            if(this.丑丝一一三丟三三丞 != null)
        {
                val_27 = this.丑丝一一三丟三三丞;
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
            val_24 = 3;
            PGCompany.Analytics.一业丗丆世世上丁且.东一不东业与下世丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  1, 七丐丅专且专七三丆:  3, 东丝丅专丝丈一丘下:  0, 上丕丟丌上丐丝上上:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丒三丕不七丁丅丈(), 丒丘丏上丙丟丑丕丈:  val_22, 下丗丁丒丘东丂不丑:  val_27.SubcategoryName, 丒世丘丘上丆丝东丞:  0, 丂下丛丝丆丂七丏丘:  0);
        }
        
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public virtual void RemoveButtonPressed()
    {
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public virtual void UpgrdeButtonPressed()
    {
        丂丘丗丗与且丌丁丙.一丑不不三丘丕一丞(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void ShowClanDivisionPromo()
    {
        Base_BuildingUI.instance.ShowDivisionPromoInfoView();
    }
    public virtual void PurchaseButtonPressed()
    {
        System.Action val_11;
        var val_12;
        PlaceableItemButton.丟丑不七不丆业丐丛 val_1 = new PlaceableItemButton.丟丑不七不丆业丐丛();
        PGCompany.万丛下丐与丅与丅专 val_2 = this.丑丝一一三丟三三丞.一丌世丑丄东丞丘三();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .与丘世丂上丌丒丗东 = val_2;
        if(val_2 != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        .丈丄不七三万丄丁不 = val_2.丑丐丙丄丅世世丑丒();
        val_11 = Rilisoft.Singleton<ClansController>.Instance;
        丞丂丘丒丟丞丑下丄 val_5 = val_11.丞丗丑丈一丅丗丌丟();
        if(val_5 == null)
        {
            goto label_8;
        }
        
        val_11 = val_5.丐丌与丏丂东业业上();
        if(val_11 == null)
        {
            goto label_8;
        }
        
        int val_11 = (PlaceableItemButton.丟丑不七不丆业丐丛)[1152921536878350544].丈丄不七三万丄丁不.业东丅东丌上丗丑不();
        val_11 = val_11.丅丒世丒与丝丆丟丈(丆专且丕专丗与一丏:  val_11);
        val_12 = 0;
        goto label_10;
        label_8:
        val_12 = 0;
        label_10:
        if(((-2088278852) & 1) == 0)
        {
                return;
        }
        
        if(val_12.GetValueOrDefault() == true)
        {
                return;
        }
        
        System.Action val_10 = null;
        val_11 = val_10;
        val_10 = new System.Action(object:  val_1, method:  System.Void PlaceableItemButton.丟丑不七不丆业丐丛::丙且丕丏丞丅丐丌且());
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  .与丘世丂上丌丒丗东, 七丒上且丝业业下七:  val_10, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  209, 丐丈上丂与上丂丒丏:  116);
        return;
        label_3:
        mem[24] = val_2;
        if(mem[24] != 0)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private int 七丝三丆丝丏三不丄()
    {
        var val_9;
        System.Action val_15;
        var val_16;
        Base_BuildingUI_Controller val_17;
        var val_18;
        val_15 = this;
        val_16 = Base_BuildingUI_Controller.instance;
        if(Base_BuildingUI_Controller.instance.且丄丏上丐丛世且丗 != false)
        {
                Base_BuildingUI_Controller val_3 = instance + ((this.丑丝一一三丟三三丞.Placeable != true) ? 352 : 368);
            val_16 = Base_BuildingUI_Controller.instance.Equals(other:  this.丑丝一一三丟三三丞);
        }
        
        val_17 = Base_BuildingUI_Controller.instance;
        if(Base_BuildingUI_Controller.instance.东丅丙丆丒丆三丂七 == false)
        {
                return (int)val_16;
        }
        
        val_17 = mem[ClanTankBuildBase.instance + 80];
        val_17 = ClanTankBuildBase.instance.selectedItemPoint;
        if(val_17 == 0)
        {
                return (int)val_16;
        }
        
        val_18 = null;
        val_18 = null;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        val_17 = 1152921536799564960;
        if(((-2088097296) & 1) == 0)
        {
            goto label_16;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
        string val_11 = val_10._value._obj.丐丏七丌丕丗业且上();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_10._value._obj == 0)
        {
            goto label_35;
        }
        
        val_17 = ???;
        if((System.String.op_Equality(a:  val_17, b:  this.丑丝一一三丟三三丞.name)) == false)
        {
            goto label_23;
        }
        
        val_16 = 0;
        return (int)val_16;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_35;
        label_23:
        val_15 = Base_BuildingUI_Controller.instance;
        val_17 = Base_BuildingUI_Controller.instance;
        val_16 = val_15 - val_17;
        return (int)val_16;
        label_35:
        val_15 = mem[Base_BuildingUI_Controller.instance + 72];
        val_15 = Base_BuildingUI_Controller.instance.丘丐专专丙与且且丌;
        val_16 = Base_BuildingUI_Controller.instance;
        return (int)val_16;
    }
    public PlaceableItemButton()
    {
    
    }

}
