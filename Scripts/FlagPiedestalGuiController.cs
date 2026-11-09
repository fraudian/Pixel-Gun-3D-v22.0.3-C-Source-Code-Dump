using UnityEngine;
public class FlagPiedestalGuiController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject container;
    
    // Methods
    private void Awake()
    {
        var val_5;
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                var val_4 = (QuestsGSMAnager.丑七不且上丗丁一世().NumCompletedTasks > 6) ? 1 : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        var val_5;
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                var val_4 = (QuestsGSMAnager.丑七不且上丗丁一世().NumCompletedTasks > 6) ? 1 : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container, 丏业丟一东丂东丘丛:  false);
    }
    private void OnClick()
    {
        MainMenuController val_3;
        var val_4;
        var val_5;
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleLeaderboardsClicked();
    }
    public FlagPiedestalGuiController()
    {
    
    }

}
