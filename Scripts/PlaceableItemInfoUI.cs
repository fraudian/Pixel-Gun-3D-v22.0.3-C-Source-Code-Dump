using UnityEngine;
public class PlaceableItemInfoUI : PGBehaviour
{
    // Fields
    private PlaceableItemSettings 丑丝一一三丟三三丞;
    private PGCompany.万丛下丐与丅与丅专 与丈丟一丙丕与不不;
    private UILabel itemName;
    private UILabel subcategpryLabel;
    private UILabel itemNextLevel;
    private UILabel itemRarity;
    private UILabel itemDescription;
    private UILabel buildStrength;
    private UITextureMasked itemTexture;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfCanUpgrade;
    private System.Collections.Generic.List<UISprite> partsIcon;
    private System.Collections.Generic.List<UILabel> partsLabel;
    private System.Collections.Generic.List<UISprite> partsBar;
    private PropertiesLayout propertiesLayout;
    private PGCompany.ItemEffectsLayout effectsLayout;
    private System.Collections.Generic.List<WidgetLayout> layouts;
    private UnityEngine.GameObject placeButton;
    private UnityEngine.GameObject removeButton;
    private UnityEngine.GameObject notEnoughEnergyButton;
    private UnityEngine.GameObject notEnoughPartsButton;
    private UnityEngine.GameObject upgradeButton;
    private UnityEngine.GameObject getPartsButton;
    private UnityEngine.GameObject grayUpgradeButton;
    private UnityEngine.GameObject finishUpgradeButton;
    private UnityEngine.GameObject speedUpUpgradeButton;
    private UILabel speedUpUpgradeLabel;
    private System.Collections.Generic.List<PGCompany.ItemCurrencyUI> speedUpUpgradeCurrencyUI;
    private System.Collections.Generic.List<PGCompany.ItemCurrencyUI> finishUpgradeCurrencyUI;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfUpgradePending;
    private UILabel currentBuildPower;
    private UILabel additionalBuildPower;
    private UILabel itemBuildPower;
    private UnityEngine.GameObject itemBuildPowerHolder;
    private UILabel itemUpgradePoints;
    private UILabel removeEnergyLabel;
    private UILabel energyLabel;
    private UILabel expLabel;
    private UnityEngine.GameObject buttonsHolder;
    
    // Properties
    public bool 七丂丑七丑世丂不丒 { get; }
    
    // Methods
    public bool get_IsShown()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    public bool Show(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        System.Action val_6;
        var val_7;
        if(业世丟丐丘丐专与不 != null)
        {
                if(业世丟丐丘丐专与不.IsDecoration == false)
        {
            goto label_2;
        }
        
        }
        
        val_7 = 0;
        this.丑丝一一三丟三三丞 = 0;
        this.与丈丟一丙丕与不不 = 0;
        return (bool)val_7;
        label_2:
        this.丑丝一一三丟三三丞 = 业世丟丐丘丐专与不;
        this.东丒不七丝万丌丄三();
        UnityEngine.GameObject val_2 = this.gameObject;
        val_2.SetActive(value:  true);
        val_2.丞丂丘丂丙丌上丘丝(丝三丄专丗丞丄丄丌:  false);
        丂丘丗丗与且丌丁丙.丆丌丕世丅专下丝丐(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemInfoUI::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
        丂丘丗丗与且丌丁丙.丞丌丄与东东丛丝丛(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemInfoUI::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
        System.Action val_5 = null;
        val_6 = val_5;
        val_5 = new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::东丒不七丝万丌丄三());
        Base_BuildingUI_Controller.instance.业丆丝不七一七世丘(丙业与丙丗丝不丈东:  val_5);
        val_7 = 1;
        return (bool)val_7;
    }
    public void Hide()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        val_1.SetActive(value:  false);
        val_1.丞丂丘丂丙丌上丘丝(丝三丄专丗丞丄丄丌:  true);
        丂丘丗丗与且丌丁丙.丆丌丕世丅专下丝丐(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemInfoUI::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
        Base_BuildingUI_Controller.instance.世东丂一丄三下业丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::东丒不七丝万丌丄三()));
    }
    public void OnDestroy()
    {
        丂丘丗丗与且丌丁丙.丆丌丕世丅专下丝丐(丙业与丙丗丝不丈东:  new System.Action<PlaceableItemSettings>(object:  this, method:  System.Void PlaceableItemInfoUI::专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)));
        Base_BuildingUI_Controller.instance.世东丂一丄三下业丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::东丒不七丝万丌丄三()));
    }
    private void 丞丂丘丂丙丌上丘丝(bool 丝三丄专丗丞丄丄丌)
    {
        static_value_082C9BFD = true;
        if((mem[-1152921504606336613]) == 0)
        {
                return;
        }
        
        ClanTankBuildBase.instance.clickOnPointEnabled = 丝三丄专丗丞丄丄丌;
    }
    private void 专一丈万下丆丅上万(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(this.丑丝一一三丟三三丞 != 业世丟丐丘丐专与不)
        {
                return;
        }
        
        this.东丒不七丝万丌丄三();
    }
    private void 东丒不七丝万丌丄三()
    {
        if(this.丑丝一一三丟三三丞 == null)
        {
                return;
        }
        
        this.与丈丟一丙丕与不不 = this.丑丝一一三丟三三丞.丐万且丏丙万下专丑();
        this.世丞丑且且丕丈七丝();
        this.丙丑丘业丕丗丗不丘();
        this.丂丈丆上东丘丌丏东();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfCanUpgrade, 丏业丟一东丂东丘丛:  this.upgradeButton.activeSelf);
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.layouts);
    }
    private void 世丞丑且且丕丈七丝()
    {
        var val_29;
        System.Collections.Generic.List<UISprite> val_30;
        var val_31;
        var val_32;
        string val_1 = this.丑丝一一三丟三三丞.丘丄业丞丏与与丅丐();
        PlaceableItemSettings val_29 = this.丑丝一一三丟三三丞;
        val_29 = 丂丘丗丗与且丌丁丙.与丑不万丐丆世一丞().Contains(item:  val_29);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfUpgradePending, 丏业丟一东丂东丘丛:  val_29);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemName, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFDC00]{0}[-] {1}", arg0:  this.丑丝一一三丟三三丞.丘丄业丞丏与与丅丐(), arg1:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  this.与丈丟一丙丕与不不.丁丕丁三丁丗不三丟() + 1)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.subcategpryLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + this.丑丝一一三丟三三丞.SubcategoryName + "_Title"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemDescription, 丕丗丘丑丛与丑业丒:  this.丑丝一一三丟三三丞.东且丏丆万与东丙万());
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.itemTexture, 与万丆丛丒万丝丙丑:  this.丑丝一一三丟三三丞.丑东丐下专丞丕丘世());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemRarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.丑丝一一三丟三三丞.ItemRarity));
        UnityEngine.Color val_18 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  this.丑丝一一三丟三三丞.ItemRarity);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.itemRarity, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.energyLabel, 丕丗丘丑丛与丑业丒:  Base_BuildingUI_Controller.instance);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.removeEnergyLabel, 丕丗丘丑丛与丑业丒:  Base_BuildingUI_Controller.instance);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.expLabel, 丕丗丘丑丛与丑业丒:  this.丑丝一一三丟三三丞.NextUpRewardPoints);
        if(this.与丈丟一丙丕与不不.丁丕丁三丁丗不三丟() < this.与丈丟一丙丕与不不.万丙东丙丐丕专丈丕())
        {
                UnityEngine.Color val_23 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  this.丑丝一一三丟三三丞.ItemRarity);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丄丁一丐丕与丝一丈:  this.partsIcon, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a});
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.partsLabel, 丕丗丘丑丛与丑业丒:  this.与丈丟一丙丕与不不.且丆丟业丞丕丑上且() + "/"("/") + this.与丈丟一丙丕与不不.丏丈丁专专丘丒丂丂());
            val_29 = this.与丈丟一丙丕与不不.且丆丟业丞丕丑上且();
            float val_30 = (float)val_29;
            val_30 = val_30 / (float)this.与丈丟一丙丕与不不.丏丈丁专专丘丒丂丂();
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.partsBar, 丙业与丙丗丝不丈东:  val_30);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsIcon, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.partsLabel, 丏业丟一东丂东丘丛:  true);
            val_30 = this.partsBar;
            val_31 = static System.Void 丞东丑专丛丆丄丝世::丙上丂专丈丏丑专上<UISprite>(System.Collections.Generic.List<T> 不丗上三丛丒上东丑, bool 丏业丟一东丂东丘丛);
            val_32 = 1;
        }
        else
        {
                val_29 = 1152921536881805808;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsIcon, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.partsLabel, 丏业丟一东丂东丘丛:  false);
            val_30 = this.partsBar;
            val_31 = static System.Void 丞东丑专丛丆丄丝世::丙上丂专丈丏丑专上<UISprite>(System.Collections.Generic.List<T> 不丗上三丛丒上东丑, bool 丏业丟一东丂东丘丛);
            val_32 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  val_30, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentBuildPower, 丕丗丘丑丛与丑业丒:  0);
    }
    private void 丙丑丘业丕丗丗不丘()
    {
        System.Collections.Generic.List<PGCompany.ItemCurrencyUI> val_40;
        UnityEngine.GameObject val_41;
        var val_42;
        PlaceableItemSettings val_43;
        UnityEngine.GameObject val_44;
        var val_45;
        var val_46;
        UnityEngine.GameObject val_47;
        var val_48;
        this.placeButton.SetActive(value:  false);
        this.removeButton.SetActive(value:  false);
        this.notEnoughEnergyButton.SetActive(value:  false);
        this.notEnoughPartsButton.SetActive(value:  false);
        if(this.丑丝一一三丟三三丞.IsPurchased == false)
        {
            goto label_6;
        }
        
        val_40 = Base_BuildingUI_Controller.instance;
        if(this.丑丝一一三丟三三丞 == null)
        {
            goto label_8;
        }
        
        if((val_40 & 1) == 0)
        {
            goto label_9;
        }
        
        label_29:
        丑业专丄七与与丕上 val_39 = this.丑丝一一三丟三三丞.itemType;
        if(val_39 > 5)
        {
            goto label_10;
        }
        
        val_39 = 1 << val_39;
        val_39 = val_39 & 52;
        if(val_39 != 0)
        {
            goto label_93;
        }
        
        label_10:
        val_41 = this.removeButton;
        val_42 = null;
        goto label_35;
        label_6:
        label_37:
        this.notEnoughPartsButton.SetActive(value:  true);
        label_93:
        this.upgradeButton.SetActive(value:  false);
        this.getPartsButton.SetActive(value:  false);
        this.grayUpgradeButton.SetActive(value:  false);
        this.finishUpgradeButton.SetActive(value:  false);
        this.speedUpUpgradeButton.SetActive(value:  false);
        if(this.丑丝一一三丟三三丞.IsPurchased == false)
        {
            goto label_71;
        }
        
        int val_3 = this.与丈丟一丙丕与不不.丁丕丁三丁丗不三丟();
        val_40 = this.与丈丟一丙丕与不不.万丙东丙丐丕专丈丕();
        if(val_3 < val_40)
        {
                if(this.与丈丟一丙丕与不不.且丆丟业丞丕丑上且() >= this.与丈丟一丙丕与不不.丏丈丁专专丘丒丂丂())
        {
            goto label_27;
        }
        
        }
        
        val_43 = 0;
        goto label_28;
        label_8:
        if((val_40 & 1) != 0)
        {
            goto label_29;
        }
        
        label_9:
        if(this.丑丝一一三丟三三丞.Placeable == false)
        {
            goto label_93;
        }
        
        if(Base_BuildingUI_Controller.instance <= Base_BuildingUI_Controller.instance)
        {
            goto label_33;
        }
        
        val_42 = null;
        val_41 = this.notEnoughEnergyButton;
        label_35:
        bool val_9 = PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业();
        goto label_37;
        label_27:
        label_28:
        PlaceableItemSettings val_12 = 丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.丑丝一一三丟三三丞.supercategory);
        if(val_12 == null)
        {
            goto label_44;
        }
        
        val_43 = this.丑丝一一三丟三三丞;
        if(val_12.Index != val_43.Index)
        {
            goto label_46;
        }
        
        this.finishUpgradeButton.SetActive(value:  PGCompany.丂丘丞丂丏七丁丄不.丅丂丅七上丁丒且丌());
        .丟丆丌丐丝丛业下下 = 丂丘丗丗与且丌丁丙.七丄丝丏丕上东且丙(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.speedUpUpgradeLabel, 丕丗丘丑丛与丑业丒:  "-"("-") + 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丂丘丗丗与且丌丁丙.丂丅丛丑丈丟万丗丙(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丂丘丗丗与且丌丁丙.丂丅丛丑丈丟万丗丙(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
        val_40 = this.finishUpgradeCurrencyUI;
        val_40.ForEach(action:  new System.Action<PGCompany.ItemCurrencyUI>(object:  new PlaceableItemInfoUI.丕丘丅三丛丘专世一(), method:  System.Void PlaceableItemInfoUI.丕丘丅三丛丘专世一::丂上三且一与万万业(PGCompany.ItemCurrencyUI 三丟东丕丄丄下下丑)));
        goto label_76;
        label_44:
        if((((丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.丑丝一一三丟三三丞.supercategory)) == 0) ? 1 : 0) == 0)
        {
            goto label_59;
        }
        
        this.upgradeButton.SetActive(value:  PGCompany.丂丘丞丂丏七丁丄不.一不丙丛丘世七三丐());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemUpgradePoints, 丕丗丘丑丛与丑业丒:  "+"("+") + this.丑丝一一三丟三三丞.NextUpRewardPoints);
        val_40 = this.与丈丟一丙丕与不不;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemNextLevel, 丕丗丘丑丛与丑业丒:  val_40.丁丕丁三丁丗不三丟() + 2);
        goto label_76;
        label_46:
        if(val_3 >= val_40)
        {
            goto label_76;
        }
        
        val_40 = this.与丈丟一丙丕与不不;
        if(this.与丈丟一丙丕与不不.且丆丟业丞丕丑上且() < val_40.丏丈丁专专丘丒丂丂())
        {
            goto label_71;
        }
        
        val_44 = this.grayUpgradeButton;
        val_40 = PGCompany.丂丘丞丂丏七丁丄不.一不丙丛丘世七三丐();
        val_45 = val_40;
        goto label_75;
        label_59:
        if(val_3 >= val_40)
        {
            goto label_76;
        }
        
        label_71:
        val_44 = this.getPartsButton;
        val_45 = 1;
        label_75:
        val_44.SetActive(value:  true);
        label_76:
        val_46 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsHolder, 丏业丟一东丂东丘丛:  PixelTime.丝业丁丌丘东丏世与());
        return;
        label_33:
        this.placeButton.SetActive(value:  PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业());
        if(this.丑丝一一三丟三三丞.Power >= 1)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemBuildPower, 丕丗丘丑丛与丑业丒:  "+"("+") + this.丑丝一一三丟三三丞.Power);
            val_47 = this.itemBuildPowerHolder;
            val_48 = 1;
        }
        else
        {
                val_47 = this.itemBuildPowerHolder;
            val_48 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_47, 丏业丟一东丂东丘丛:  false);
        goto label_93;
    }
    private void 丂丈丆上东丘丌丏东()
    {
        var val_9;
        PlaceableItemSettings val_10;
        UILabel val_11;
        UILabel val_12;
        string val_13;
        var val_14;
        if(this.upgradeButton.activeSelf != false)
        {
                val_9 = 1;
        }
        else
        {
                bool val_3 = (this.丑丝一一三丟三三丞 == (丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.丑丝一一三丟三三丞.supercategory))) ? 1 : 0;
        }
        
        this.propertiesLayout.世业丒万丘丆专丘丐();
        val_10 = this.丑丝一一三丟三三丞;
        this.丈万丟丐一上三三丕(七万一业丟且丟七丒:  val_3, 万丆三丑上三丒不七:  this.丑丝一一三丟三三丞.infoProreties);
        if(val_3 == 0)
        {
            goto label_9;
        }
        
        val_11 = this.additionalBuildPower;
        if(this.丑丝一一三丟三三丞.NextUpPower < 1)
        {
            goto label_11;
        }
        
        val_10 = "+"("+") + this.丑丝一一三丟三三丞.NextUpPower - this.丑丝一一三丟三三丞.Power(this.丑丝一一三丟三三丞.NextUpPower - this.丑丝一一三丟三三丞.Power);
        val_12 = val_11;
        val_13 = val_10;
        goto label_16;
        label_9:
        val_14 = 1152921505284374528;
        val_11 = this.additionalBuildPower;
        goto label_17;
        label_11:
        val_14 = 1152921505284374528;
        label_17:
        val_12 = val_11;
        val_13 = "";
        label_16:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  val_13);
        this.effectsLayout.七丗丏丌丌丛业世一(丌丞丌丌丈丁丏丅丟:  this.丑丝一一三丟三三丞.inShopEffects);
    }
    private void 丈万丟丐一上三三丕(bool 七万一业丟且丟七丒, System.Collections.Generic.List<丑丙上丛万丙丌且丙> 万丆三丑上三丒不七)
    {
        var val_3;
        var val_12;
        var val_13;
        val_12 = 七万一业丟且丟七丒;
        val_13 = this;
        if(val_12 == false)
        {
            goto label_13;
        }
        
        List.Enumerator<T> val_1 = 万丆三丑上三丒不七.GetEnumerator();
        label_7:
        if(((-2083481376) & 1) == 0)
        {
            goto label_15;
        }
        
        int val_4 = val_3.丙东专丂世丈丏丁丂();
        if(val_5.value <= 0f)
        {
            goto label_7;
        }
        
        PropertyUI val_7 = this.propertiesLayout.与丘丌业丗上下上世(与丈丘上丙丘丕丝丘:  PlaceableItemInfoProperties.丑丅丞丝业丄三一世(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞, 七丕世三丅上丐丄丐:  val_4), 丌丞丏专专七上与丞:  PlaceableItemInfoProperties.丅丞万丆丂七丒与上(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞, 七丕世三丅上丐丄丐:  val_4));
        goto label_7;
        label_13:
        List.Enumerator<T> val_8 = 万丆三丑上三丒不七.GetEnumerator();
        label_19:
        if(((-2083481376) & 1) == 0)
        {
            goto label_15;
        }
        
        if(val_10.value <= 0f)
        {
            goto label_19;
        }
        
        PropertyUI val_11 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(与丌七七丈业且一丒:  PlaceableItemInfoProperties.丑丅丞丝业丄三一世(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞, 七丕世三丅上丐丄丐:  val_3.丙东专丂世丈丏丁丂()));
        goto label_19;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void PlaceButtonPressed()
    {
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public void RemoveButtonPressed()
    {
        if(Base_BuildingUI_Controller.instance == null)
        {
            
        }
    
    }
    public void UpgrdeButtonPressed()
    {
        丂丘丗丗与且丌丁丙.一丑不不三丘丕一丞(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void FinishUpgrdeButtonPressed()
    {
        丂丘丗丗与且丌丁丙.下七上丐上丒丙丏丁(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void SpeedUpUpgrdeButtonPressed()
    {
        丂丘丗丗与且丌丁丙.丑东专下丛丐万丟世(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void GetPartsButtonPressed()
    {
        if(Base_BuildingUI.instance == null)
        {
            
        }
    
    }
    private void OnEnable()
    {
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::业下世世丕三业与丐()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::丕丅与丂丏丁丘下丝()));
    }
    private void 丕丅与丂丏丁丘下丝()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 业下世世丕三业与丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonsHolder, 丏业丟一东丂东丘丛:  true);
        this.丙丑丘业丕丗丗不丘();
    }
    private void OnDisable()
    {
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::业下世世丕三业与丐()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemInfoUI::丕丅与丂丏丁丘下丝()));
    }
    public PlaceableItemInfoUI()
    {
    
    }

}
