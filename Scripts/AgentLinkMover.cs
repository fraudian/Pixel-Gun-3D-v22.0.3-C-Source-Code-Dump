using UnityEngine;
public class AgentLinkMover : MonoBehaviour
{
    // Fields
    private UnityEngine.AnimationCurve _curve;
    private float _duration;
    private 下丙丕丞丂丑丒三丟 _moveMethod;
    private float _parabolaHeight;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且且丝东上与丏丑丑());
    }
    private System.Collections.IEnumerator 且且丝东上与丏丑丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AgentLinkMover.丂万七三不丈丙丁丄();
    }
    private System.Collections.IEnumerator 丑万丅不丘万丑下丆(UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七丘东丞世丆丕丙丅 = 七丘东丞世丆丕丙丅;
        return (System.Collections.IEnumerator)new AgentLinkMover.东丟丙丂丅上丏上丑();
    }
    private System.Collections.IEnumerator 丙丁世丂丑丒业七三(UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅, float 丟丌丐丘丆丙丑丑一, float 与丈业丛丝丒丙一丏)
    {
        AgentLinkMover.丞上丑丝丁丂丄世丁 val_1 = new AgentLinkMover.丞上丑丝丁丂丄世丁();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七丘东丞世丆丕丙丅 = 七丘东丞世丆丕丙丅;
            .丟丌丐丘丆丙丑丑一 = 丟丌丐丘丆丙丑丑一;
        }
        else
        {
                mem[32] = 七丘东丞世丆丕丙丅;
            mem[40] = 丟丌丐丘丆丙丑丑一;
        }
        
        .与丈业丛丝丒丙一丏 = 与丈业丛丝丒丙一丏;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丟丅丁世上上且丞丙(UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅, float 与丈业丛丝丒丙一丏, UnityEngine.AnimationCurve 专一上世业丗丒丘不)
    {
        AgentLinkMover.丞业丐丆专三丘不丑 val_1 = new AgentLinkMover.丞业丐丆专三丘不丑();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七丘东丞世丆丕丙丅 = 七丘东丞世丆丕丙丅;
            .与丈业丛丝丒丙一丏 = 与丈业丛丝丒丙一丏;
        }
        else
        {
                mem[32] = 七丘东丞世丆丕丙丅;
            mem[48] = 与丈业丛丝丒丙一丏;
        }
        
        .专一上世业丗丒丘不 = 专一上世业丗丒丘不;
        return (System.Collections.IEnumerator)val_1;
    }
    public AgentLinkMover()
    {
        this._curve = new UnityEngine.AnimationCurve();
        this._duration = 0.5f;
        this._moveMethod = 2;
        this._parabolaHeight = 2f;
    }

}
