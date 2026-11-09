using UnityEngine;
[Serializable]
public abstract class BaseTriggerAlternativeAttack
{
    // Fields
    protected AlternativeMobAttackController _controller;
    protected TriggerAlternativeAttackSetting _triggerSettings;
    protected float _currentCooldown;
    private System.Action OnActivateAttack;
    
    // Methods
    internal void 丁丐业丘且且七丞丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.OnActivateAttack, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnActivateAttack != 1152921539885027512);
    
    }
    internal void 七丝丈丛丂丅丘与三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.OnActivateAttack, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnActivateAttack != 1152921539885164088);
    
    }
    internal virtual void 丙丂丅丛丄丆业丛丆(TriggerAlternativeAttackSetting 与不丕丆丈不丙丟丛, AlternativeMobAttackController 丛世丕丘七东下丌丄)
    {
        this._triggerSettings = 与不丕丆丈不丙丟丛;
        this._controller = 丛世丕丘七东下丌丄;
        this._currentCooldown = 与不丕丆丈不丙丟丛.cooldown;
    }
    internal void 丄丅丏世丘丂丏丈下(System.Action 业丏丈世世世丞丒世)
    {
        this.丁丐业丘且且七丞丕(丙业与丙丗丝不丈东:  业丏丈世世世丞丒世);
    }
    internal void 丝丞丗与丂专三不七(System.Action 业丏丈世世世丞丒世)
    {
        this.七丝丈丛丂丅丘与三(丙业与丙丗丝不丈东:  业丏丈世世世丞丒世);
    }
    internal void 丕丙丂丆丒与与东丑()
    {
        if(this.OnActivateAttack == null)
        {
                return;
        }
        
        this.OnActivateAttack.Invoke();
    }
    internal abstract void 上专丄丑专丑丘业丌(); // 0
    protected BaseTriggerAlternativeAttack()
    {
    
    }

}
