using UnityEngine;
public class RecommendClanBanner : ClansSiegeConnectSceneBanner
{
    // Methods
    public void U_CreateClan()
    {
        var val_4;
        MainMenuController val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
                return;
        }
        
        if((Rilisoft.丗万且下与专业丏丝.一丈且丞丏七上丝上(丛专下丞丒丛下下与:  false)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClansClickedCore(三丂东专丕专业丏万:  false);
        val_5 = ClanStartGui_v2.丑七不且上丗丁一世();
        val_5.U_CreateClick();
    }
    public void U_FindClan()
    {
        var val_3;
        MainMenuController val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_4 == 0)
        {
                return;
        }
        
        if((Rilisoft.丗万且下与专业丏丝.一丈且丞丏七上丝上(丛专下丞丒丛下下与:  false)) == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = MainMenuController.丄丞丁丈与业上丞丟;
        val_4.HandleClansClickedCore(三丂东专丕专业丏万:  false);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "CheckForClan");
    }
    private System.Collections.IEnumerator CheckForClan()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RecommendClanBanner.七一丝丂丂丅丛丌丂();
    }
    public RecommendClanBanner()
    {
    
    }

}
