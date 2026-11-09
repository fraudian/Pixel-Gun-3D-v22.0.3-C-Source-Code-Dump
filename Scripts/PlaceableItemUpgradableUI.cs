using UnityEngine;
public class PlaceableItemUpgradableUI : PGBehaviour
{
    // Fields
    private PlaceableItemButton 丙丞万丑不不七业丗;
    private System.Collections.Generic.List<UISprite> partsIcon;
    private System.Collections.Generic.List<UILabel> partsLabel;
    private System.Collections.Generic.List<UISprite> partsBar;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnMaxLevel;
    private UILabel levelLabel;
    private UnityEngine.GameObject placeButton;
    private UnityEngine.GameObject upgradeButton;
    private UnityEngine.GameObject grayUpgradeButton;
    private UnityEngine.GameObject upgrading;
    private UnityEngine.GameObject removeButton;
    private UnityEngine.GameObject canUpgradeIndicator;
    private UnityEngine.GameObject unlocked;
    private UnityEngine.GameObject energy;
    private UnityEngine.GameObject lockedByParts;
    private UnityEngine.GameObject addItemButtonDEV;
    
    // Methods
    public void Setup(PlaceableItemButton 丒丏丛丆丟三丗且丌)
    {
        this.丙丞万丑不不七业丗 = 丒丏丛丆丟三丗且丌;
    }
    public void UpdateUI()
    {
        UnityEngine.GameObject val_34;
        var val_35;
        PlaceableItemSettings val_36;
        var val_37;
        var val_38;
        PlaceableItemButton val_39;
        var val_40;
        bool val_41;
        var val_42;
        var val_43;
        val_34 = this;
        this.placeButton.SetActive(value:  false);
        this.upgradeButton.SetActive(value:  false);
        this.grayUpgradeButton.SetActive(value:  false);
        this.upgrading.SetActive(value:  false);
        this.removeButton.SetActive(value:  false);
        this.lockedByParts.SetActive(value:  false);
        this.unlocked.SetActive(value:  false);
        this.energy.SetActive(value:  false);
        this.addItemButtonDEV.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.partsLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsBar, 丏业丟一东丂东丘丛:  false);
        if(this.丙丞万丑不不七业丗 == 0)
        {
                return;
        }
        
        if(this.丙丞万丑不不七业丗.丑丝一一三丟三三丞 == null)
        {
                return;
        }
        
        PGCompany.万丛下丐与丅与丅专 val_2 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.丐万且丏丙万下专丑();
        if(val_2 != null)
        {
                val_35 = val_2.丁丕丁三丁丗不三丟();
        }
        else
        {
                val_35 = 0.丁丕丁三丁丗不三丟();
        }
        
        val_36 = val_2.万丙东丙丐丕专丈丕();
        if(val_35 >= val_36)
        {
            goto label_21;
        }
        
        if(val_2 != null)
        {
                val_37 = val_2.且丆丟业丞丕丑上且();
        }
        else
        {
                val_37 = 0.且丆丟业丞丕丑上且();
        }
        
        if(val_37 >= val_2.丏丈丁专专丘丒丂丂())
        {
            goto label_24;
        }
        
        label_21:
        val_38 = 0;
        goto label_25;
        label_24:
        bool val_11 = ((丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.supercategory)) == 0) ? 1 : 0;
        label_25:
        this.canUpgradeIndicator.SetActive(value:  val_11);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  val_2.丁丕丁三丁丗不三丟() + 1));
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnMaxLevel, 丏业丟一东丂东丘丛:  (val_35 >= val_36) ? 1 : 0);
        if(val_35 < val_36)
        {
                UnityEngine.Color val_17 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.ItemRarity);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丄丁一丐丕与丝一丈:  this.partsIcon, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.partsLabel, 丕丗丘丑丛与丑业丒:  val_2.且丆丟业丞丕丑上且() + "/"("/") + val_2.丏丈丁专专丘丒丂丂());
            if(val_2 != null)
        {
                val_36 = val_2.且丆丟业丞丕丑上且();
        }
        else
        {
                val_36 = 0.且丆丟业丞丕丑上且();
        }
        
            float val_33 = (float)val_36;
            val_33 = val_33 / (float)val_2.丏丈丁专专丘丒丂丂();
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.partsBar, 丙业与丙丗丝不丈东:  val_33);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsIcon, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.partsLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UISprite>(不丗上三丛丒上东丑:  this.partsBar, 丏业丟一东丂东丘丛:  true);
        }
        
        val_39 = this.丙丞万丑不不七业丗;
        if(this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.IsPurchased == false)
        {
            goto label_49;
        }
        
        this.unlocked.SetActive(value:  true);
        this.energy.SetActive(value:  true);
        bool val_25 = this.丙丞万丑不不七业丗.ShowingParameters;
        val_39 = this.丙丞万丑不不七业丗;
        val_36 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞;
        if(val_36 == null)
        {
            goto label_54;
        }
        
        if(val_25 == false)
        {
            goto label_55;
        }
        
        label_64:
        val_39 = this.丙丞万丑不不七业丗;
        if((丂丘丗丗与且丌丁丙.丕丄专专世丞丙丟下(且三丟七下丂专丈丈:  this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.supercategory)) == this.丙丞万丑不不七业丗.丑丝一一三丟三三丞)
        {
            goto label_59;
        }
        
        if(val_11 == 0)
        {
            goto label_60;
        }
        
        val_40 = 1152921505580326912;
        val_34 = this.upgradeButton;
        goto label_61;
        label_49:
        val_34 = this.lockedByParts;
        if(val_34 != null)
        {
            goto label_74;
        }
        
        label_75:
        label_74:
        val_41 = 1;
        goto label_63;
        label_54:
        if(val_25 == true)
        {
            goto label_64;
        }
        
        label_55:
        if(val_36.Placeable == false)
        {
                return;
        }
        
        val_39 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞;
        if((Base_BuildingUI_Controller.instance & 1) == 0)
        {
            goto label_68;
        }
        
        丑业专丄七与与丕上 val_34 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.itemType;
        if(val_34 <= 5)
        {
                val_34 = 1 << val_34;
            val_34 = val_34 & 52;
            if(val_34 != 0)
        {
                return;
        }
        
        }
        
        val_42 = 1152921505580326912;
        val_34 = this.removeButton;
        goto label_73;
        label_59:
        if(this.upgrading != null)
        {
            goto label_74;
        }
        
        goto label_75;
        label_68:
        val_42 = 1152921505580326912;
        val_34 = this.placeButton;
        label_73:
        val_43 = 0;
        bool val_28 = PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业();
        goto label_78;
        label_60:
        if(val_2 != null)
        {
                val_39 = val_2.丁丕丁三丁丗不三丟();
        }
        else
        {
                val_39 = 0.丁丕丁三丁丗不三丟();
        }
        
        if(val_39 >= val_2.万丙东丙丐丕专丈丕())
        {
                return;
        }
        
        val_40 = 1152921505580326912;
        val_34 = this.grayUpgradeButton;
        label_61:
        val_43 = 0;
        label_78:
        val_41 = PGCompany.丂丘丞丂丏七丁丄不.一不丙丛丘世七三丐();
        label_63:
        val_34.SetActive(value:  val_41);
    }
    public void AddItemDEV()
    {
    
    }
    public PlaceableItemUpgradableUI()
    {
    
    }

}
