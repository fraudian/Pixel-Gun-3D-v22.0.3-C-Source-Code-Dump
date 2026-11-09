using UnityEngine;
public class AlmanachTutorialStep_WeaponSetReward : AlmanachTutorialStep
{
    // Methods
    public override bool IsComplete()
    {
        if(AlmanachTutorialManager.上三丞且丞丐丟世丕() == null)
        {
                return true;
        }
        
        return 上且丁万与丌下丐上.丟万下专丟上业丁下(丕与丝万丑丏丑东与:  AlmanachTutorialManager.上三丞且丞丐丟世丕());
    }
    public override void StartStep()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        AlmanachMainUI.instance.ShowAlmanach(与且丒丐丆丆丒丛丏:  2, 丄三丛七一丅丘丛丅:  0, 丞一丁业丄一一业且:  0, 世万丐专世丕业丟东:  true);
        val_5 = null;
        val_5 = null;
        if((AlmanachMainUI.instance.GetWeaponSetCell(丞丅上丏丂且下丅与:  AlmanachTutorialManager.TutorialWeaponSetId)) != 0)
        {
                mem[1152921524323702848] = val_1.rewardUi.transform;
        }
        
        this.StartStep();
    }
    public override void CompleteStep()
    {
        var val_3;
        bool val_2 = 上且丁万与丌下丐上.丙丛丘上万丆丝丄七(丕与丝万丑丏丑东与:  AlmanachTutorialManager.上三丞且丞丐丟世丕());
        val_3 = null;
        val_3 = null;
        AlmanachMainUI.instance.ShowAlmanach(与且丒丐丆丆丒丛丏:  2, 丄三丛七一丅丘丛丅:  0, 丞一丁业丄一一业且:  0, 世万丐专世丕业丟东:  true);
        this.CompleteStep();
    }
    public AlmanachTutorialStep_WeaponSetReward()
    {
        mem[1152921524323947312] = 1;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
