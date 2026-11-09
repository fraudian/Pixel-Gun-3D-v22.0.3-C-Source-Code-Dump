using UnityEngine;
public class SpectorModeOnOffBtn : MonoBehaviour
{
    // Fields
    public bool isOnBtn;
    
    // Methods
    private void OnClick()
    {
        var val_4;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(this.isOnBtn != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
            NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.业七万七专丄丑万丘();
            return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丆丄上丛丝东丅专东();
    }
    public SpectorModeOnOffBtn()
    {
    
    }

}
