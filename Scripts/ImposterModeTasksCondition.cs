using UnityEngine;
internal sealed class ImposterModeTasksCondition : BaseConditionEndRound
{
    // Methods
    internal override void 下丌且丈丝丗丛上丌()
    {
        var val_4;
        System.Action val_5;
        val_4 = null;
        val_4 = null;
        val_5 = System.Delegate.Combine(a:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丁一东丈丙丒且丒丌, b:  new System.Action(object:  this, method:  System.Void ImposterModeTasksCondition::上三丑下丑丅丐下万()));
        if(PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_4;
        }
        
        if(val_5 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_5:
        if(null != null)
        {
                val_5 = 0;
        }
        
        label_8:
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丁一东丈丙丒且丒丌 = val_5;
    }
    internal override void 一丗一上丙丅下丑万()
    {
        var val_4;
        System.Action val_5;
        val_4 = null;
        val_4 = null;
        val_5 = System.Delegate.Remove(source:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丁一东丈丙丒且丒丌, value:  new System.Action(object:  this, method:  System.Void ImposterModeTasksCondition::上三丑下丑丅丐下万()));
        if(PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_4;
        }
        
        if(val_5 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_5:
        if(null != null)
        {
                val_5 = 0;
        }
        
        label_8:
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丁一东丈丙丒且丒丌 = val_5;
    }
    private void 上三丑下丑丅丐下万()
    {
        this.丛万丙丏丝丗丛丄丐();
    }
    public ImposterModeTasksCondition()
    {
    
    }

}
