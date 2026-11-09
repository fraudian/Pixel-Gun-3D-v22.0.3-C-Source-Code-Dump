using UnityEngine;
internal sealed class SabotageSuccessCondition : BaseConditionEndRound
{
    // Methods
    internal override void 下丌且丈丝丗丛上丌()
    {
        System.Action val_4;
        System.Action val_1 = 1152921536494851024;
        val_1 = new System.Action(object:  this, method:  System.Void SabotageSuccessCondition::丞三东东业丑且不且());
        val_4 = System.Delegate.Combine(a:  SabotageImposterModeController.丆丕丝丒不丙且丐丗.丄丘丅不三东丙丆七, b:  val_1);
        if(SabotageImposterModeController.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != 1152921536494851024)
        {
                val_4 = 0;
        }
        
        label_6:
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.丄丘丅不三东丙丆七 = val_4;
    }
    internal override void 一丗一上丙丅下丑万()
    {
        System.Delegate val_4 = System.Delegate.Remove(source:  SabotageImposterModeController.丆丕丝丒不丙且丐丗.丄丘丅不三东丙丆七, value:  new System.Action(object:  this, method:  System.Void SabotageSuccessCondition::丞三东东业丑且不且()));
        if(SabotageImposterModeController.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.丄丘丅不三东丙丆七 = val_4;
    }
    private void 丞三东东业丑且不且()
    {
        this.丛万丙丏丝丗丛丄丐();
    }
    public SabotageSuccessCondition()
    {
    
    }

}
