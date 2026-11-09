using UnityEngine;
internal sealed class MonsterDeadCondition : BaseConditionEndRound
{
    // Fields
    private Player_move_c 下且丙丏上丘下专不;
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
        return (System.Collections.IEnumerator)new MonsterDeadCondition.丌丐丄下丞丐三丘与();
    }
    internal override void 一丗一上丙丅下丑万()
    {
        if(this.丁丛万与丄专丕丌丗 != null)
        {
                this.StopCoroutine(routine:  this.丁丛万与丄专丕丌丗);
        }
        
        this.下且丙丏上丘下专不 = 0;
    }
    public MonsterDeadCondition()
    {
    
    }

}
