using UnityEngine;
public class BtnBannerSmile : ButtonBannerBase
{
    // Fields
    public string tagForClick;
    
    // Methods
    public override bool BannerIsActive()
    {
        bool val_1 = StickersController.丂丙业丘丈下丌东三();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public override void OnClickButton()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandlePromoActionClicked(丒东业不丐丑丕丄丆:  this.tagForClick);
    }
    public override void OnHide()
    {
    
    }
    public override void OnShow()
    {
    
    }
    public override void OnChangeLocalize()
    {
    
    }
    public BtnBannerSmile()
    {
        this.tagForClick = "";
        this = new UnityEngine.MonoBehaviour();
    }

}
