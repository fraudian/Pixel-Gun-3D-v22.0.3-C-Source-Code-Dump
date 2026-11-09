using UnityEngine;
public class BtnBannerNewGun : ButtonBannerBase
{
    // Fields
    public UILabel lbPrice;
    public UILabel lbSale;
    public UISprite sprCoinImg;
    public string tagForClick;
    public UITexture txGun;
    
    // Methods
    public override bool BannerIsActive()
    {
        return false;
    }
    public override void OnClickButton()
    {
        var val_2;
        if((System.String.IsNullOrEmpty(value:  this.tagForClick)) != false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandlePromoActionClicked(丒东业不丐丑丕丄丆:  this.tagForClick);
    }
    public override void OnHide()
    {
    
    }
    public override void OnShow()
    {
        if((System.String.IsNullOrEmpty(value:  this.tagForClick)) == false)
        {
                return;
        }
        
        goto typeof(BtnBannerNewGun).__il2cppRuntimeField_1B8;
    }
    public override void OnUpdateParameter()
    {
    
    }
    public override void OnChangeLocalize()
    {
    
    }
    public BtnBannerNewGun()
    {
        this.tagForClick = "";
        this = new UnityEngine.MonoBehaviour();
    }

}
