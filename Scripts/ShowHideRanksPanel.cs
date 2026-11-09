using UnityEngine;
internal sealed class ShowHideRanksPanel : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
    }
    private void OnDisable()
    {
        var val_6;
        ExperienceController val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        val_7 = ExperienceController.sharedController;
        if(val_7 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        float val_6 = 21f;
        val_6 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_6;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_6, y:  val_6);
        ExperienceController.sharedController.posRanks = val_5.x;
        ExperienceController.sharedController.__unknownFiledOffset_38 = val_5.y;
        val_7 = ExperienceController.sharedController;
        val_7.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
    }
    public ShowHideRanksPanel()
    {
    
    }

}
