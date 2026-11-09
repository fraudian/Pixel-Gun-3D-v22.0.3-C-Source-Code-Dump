using UnityEngine;
public class ClansLockedBanner : BannerWindow
{
    // Fields
    private UILabel levelRequiredLabel;
    
    // Methods
    public override void Show()
    {
        this.levelRequiredLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.clans"));
        this.Show();
    }
    public void U_CloseClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    public ClansLockedBanner()
    {
    
    }

}
