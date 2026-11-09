using UnityEngine;
public class GoToClanBuildingsButton : PGBehaviour
{
    // Methods
    public void U_GoToClanbuildings()
    {
        var val_4 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_4.丞丗丑丈一丅丗丌丟() == null)
        {
                return;
        }
        
        val_4 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_4.ForceShowBanner(丌丅丕一丛丛丄一万:  55, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public GoToClanBuildingsButton()
    {
    
    }

}
