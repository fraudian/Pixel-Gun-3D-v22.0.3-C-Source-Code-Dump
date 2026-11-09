using UnityEngine;
public class PlaceableItemNotUpgradableUI : PGBehaviour
{
    // Fields
    private PlaceableItemButton 丙丞万丑不不七业丗;
    private PGCompany.ItemCurrencyUI itemCurrencyUI;
    private UnityEngine.GameObject placeButton;
    private UnityEngine.GameObject purchaseButton;
    private PGCompany.ItemCurrencyUI buttonItemCurrencyUI;
    private UnityEngine.GameObject purchasedIndicator;
    private UnityEngine.GameObject installedIndicator;
    private UnityEngine.GameObject enableIfPurchasePending;
    
    // Methods
    public void Setup(PlaceableItemButton 丒丏丛丆丟三丗且丌)
    {
        this.丙丞万丑不不七业丗 = 丒丏丛丆丟三丗且丌;
    }
    public void UpdateUI()
    {
        UnityEngine.GameObject val_18;
        PlaceableItemSettings val_19;
        var val_20;
        var val_21;
        val_18 = this;
        this.itemCurrencyUI.gameObject.SetActive(value:  false);
        this.purchaseButton.SetActive(value:  false);
        this.placeButton.SetActive(value:  false);
        this.purchasedIndicator.SetActive(value:  false);
        this.installedIndicator.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfPurchasePending, 丏业丟一东丂东丘丛:  false);
        if(this.丙丞万丑不不七业丗 == 0)
        {
                return;
        }
        
        if(this.丙丞万丑不不七业丗.丑丝一一三丟三三丞 == null)
        {
                return;
        }
        
        PGCompany.万丛下丐与丅与丅专 val_3 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.一丌世丑丄东丞丘三();
        if(this.丙丞万丑不不七业丗.丑丝一一三丟三三丞.IsPurchased == false)
        {
            goto label_18;
        }
        
        PGCompany.万丛下丐与丅与丅专 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.万丛下丐与丅与丅专>(丈丄不七三万丄丁不:  val_3.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        val_19 = this.丙丞万丑不不七业丗.丑丝一一三丟三三丞;
        if(Base_BuildingUI_Controller.instance < 1)
        {
            goto label_23;
        }
        
        val_18 = this.installedIndicator;
        if(val_18 != null)
        {
            goto label_50;
        }
        
        goto label_25;
        label_18:
        val_19 = Rilisoft.Singleton<ClansController>.Instance;
        丞丂丘丒丟丞丑下丄 val_9 = val_19.丞丗丑丈一丅丗丌丟();
        if(val_9 == null)
        {
            goto label_28;
        }
        
        val_19 = val_9.丐丌与丏丂东业业上();
        if(val_19 == null)
        {
            goto label_28;
        }
        
        int val_16 = val_3.业东丅东丌上丗丑不();
        val_16 = val_19.丅丒世丒与丝丆丟丈(丆专且丕专丗与一丏:  val_16);
        val_20 = 0;
        goto label_30;
        label_28:
        val_20 = 0;
        label_30:
        if(((-2081492100) & 1) != 0)
        {
                if(val_20.GetValueOrDefault() == false)
        {
            goto label_32;
        }
        
        }
        
        val_18 = this.enableIfPurchasePending;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        return;
        label_23:
        this.purchasedIndicator.SetActive(value:  true);
        val_18 = this.placeButton;
        val_21 = PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业();
        goto label_40;
        label_32:
        if(this.丙丞万丑不不七业丗.selectableButton.selected == false)
        {
            goto label_43;
        }
        
        val_19 = this.buttonItemCurrencyUI;
        val_19.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  val_3, 丗丂丞丛丒丒丟万丗:  false);
        val_18 = this.purchaseButton;
        if(val_18 != null)
        {
            goto label_50;
        }
        
        label_25:
        label_51:
        label_50:
        val_21 = 1;
        label_40:
        val_18.SetActive(value:  true);
        return;
        label_43:
        this.itemCurrencyUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  val_3, 丗丂丞丛丒丒丟万丗:  false);
        if(this.itemCurrencyUI.gameObject != null)
        {
            goto label_50;
        }
        
        goto label_51;
    }
    public PlaceableItemNotUpgradableUI()
    {
    
    }

}
