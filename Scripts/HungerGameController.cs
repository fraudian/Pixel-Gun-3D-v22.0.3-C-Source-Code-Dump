using UnityEngine;
internal sealed class HungerGameController : MiniGamesController
{
    // Methods
    protected override void 丐丈丌不丌丁东丒且()
    {
        var val_7;
        var val_8;
        var val_9;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_7 = activeSelf ^ 1;
        }
        else
        {
                val_7 = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 1)
        {
                return;
        }
        
        MiniGamesController val_4 = MiniGamesController.丑七不且上丗丁一世();
        if(val_4.isGo == false)
        {
                return;
        }
        
        var val_5 = (S0 > 10f) ? 1 : 0;
        val_5 = val_7 & val_5;
        if(val_5 != 1)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        丆丄丕丁丕一丙丕丒();
    }
    public HungerGameController()
    {
    
    }

}
