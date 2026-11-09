using UnityEngine;
public class AlmanachTutorialStep_WeaponReward : AlmanachTutorialStep
{
    // Methods
    public override bool IsComplete()
    {
        if(AlmanachTutorialManager.丑且万丏七丝丞上三() == null)
        {
                return true;
        }
        
        return 上且丁万与丌下丐上.丟万下专丟上业丁下(一业一丕丅下业世与:  AlmanachTutorialManager.丑且万丏七丝丞上三());
    }
    public override void StartStep()
    {
        null = null;
        AlmanachMainUI.instance.ShowAlmanach(与且丒丐丆丆丒丛丏:  1, 丄三丛七一丅丘丛丅:  1, 丞一丁业丄一一业且:  AlmanachTutorialManager.丑且万丏七丝丞上三().业东丅东丌上丗丑不(), 世万丐专世丕业丟东:  false);
        AlmanachEndlessScrollCell val_4 = AlmanachMainUI.instance.GetWeaponCell(丞丅上丏丂且下丅与:  ToString());
        if(val_4 != 0)
        {
                mem[1152921524323201600] = val_4.transform;
        }
        
        this.StartStep();
    }
    public override void CompleteStep()
    {
        null = null;
        AlmanachMainUI.instance.ShowAlmanach(与且丒丐丆丆丒丛丏:  1, 丄三丛七一丅丘丛丅:  1, 丞一丁业丄一一业且:  AlmanachTutorialManager.丑且万丏七丝丞上三().业东丅东丌上丗丑不(), 世万丐专世丕业丟东:  true);
        this.CompleteStep();
    }
    public AlmanachTutorialStep_WeaponReward()
    {
        mem[1152921524323450160] = 1;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
