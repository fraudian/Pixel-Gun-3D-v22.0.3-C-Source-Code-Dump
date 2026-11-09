using UnityEngine;
public class ShowHintAfterCraftTaskStateBehaviour : StateMachineBehaviour
{
    // Methods
    public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        MainMenuController.丄丞丁丈与业上丞丟.UpdateTutorialHints();
    }
    public ShowHintAfterCraftTaskStateBehaviour()
    {
    
    }

}
