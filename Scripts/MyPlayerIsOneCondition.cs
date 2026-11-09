using UnityEngine;
public sealed class MyPlayerIsOneCondition : BaseConditionEndRound
{
    // Fields
    private UnityEngine.Coroutine 丁丛万与丄专丕丌丗;
    
    // Methods
    internal override void 下丌且丈丝丗丛上丌()
    {
        this.丁丛万与丄专丕丌丗 = this.StartCoroutine(routine:  this.丛一丈专一丒丞丑万());
    }
    private System.Collections.IEnumerator 丛一丈专一丒丞丑万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MyPlayerIsOneCondition.三丗三且丄丏丗一丂();
    }
    internal override void 一丗一上丙丅下丑万()
    {
        if(this.丁丛万与丄专丕丌丗 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丁丛万与丄专丕丌丗);
    }
    public MyPlayerIsOneCondition()
    {
    
    }

}
