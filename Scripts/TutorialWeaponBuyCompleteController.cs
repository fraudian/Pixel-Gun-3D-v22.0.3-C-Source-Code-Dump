using UnityEngine;
public class TutorialWeaponBuyCompleteController : BannerWindow
{
    // Fields
    private bool 丗三丒丞丝丐丆东丈;
    
    // Methods
    public override void HideSelf()
    {
        if(this.丗三丒丞丝丐丆东丈 == true)
        {
                return;
        }
        
        上丐丛丗丑三万丘专.丛丄丆一且丏丂下丆();
        this.丗三丒丞丝丐丆东丈 = true;
    }
    public TutorialWeaponBuyCompleteController()
    {
    
    }

}
