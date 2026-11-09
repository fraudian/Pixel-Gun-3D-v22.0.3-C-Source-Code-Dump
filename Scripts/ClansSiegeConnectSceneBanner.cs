using UnityEngine;
public class ClansSiegeConnectSceneBanner : BannerWindow
{
    // Methods
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
    public ClansSiegeConnectSceneBanner()
    {
    
    }

}
