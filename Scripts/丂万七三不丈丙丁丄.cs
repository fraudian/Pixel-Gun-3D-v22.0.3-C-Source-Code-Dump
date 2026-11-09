using UnityEngine;
private sealed class AgentLinkMover.丂万七三不丈丙丁丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AgentLinkMover 丝且与丝丒丟万丁专;
    private UnityEngine.AI.NavMeshAgent 丙丗丄丟东丒丈万丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AgentLinkMover.丂万七三不丈丙丁丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AI.NavMeshAgent val_10;
        object val_11;
        int val_12;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 3)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_14:
        mem[this.丙丗丄丟东丒丈万丆].CompleteOffMeshLink();
        goto label_10;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 4)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return true;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            UnityEngine.AI.NavMeshAgent val_2 = this.丝且与丝丒丟万丁专.GetComponent<UnityEngine.AI.NavMeshAgent>();
            val_10 = this;
            this.丙丗丄丟东丒丈万丆 = val_2;
            val_2.autoTraverseOffMeshLink = false;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_10 = this.丙丗丄丟东丒丈万丆;
        }
        
        if(mem[this.丙丗丄丟东丒丈万丆].isOnOffMeshLink == false)
        {
            goto label_10;
        }
        
        if(this.丝且与丝丒丟万丁专._moveMethod == 3)
        {
            goto label_12;
        }
        
        if(this.丝且与丝丒丟万丁专._moveMethod == 2)
        {
            goto label_13;
        }
        
        if(this.丝且与丝丒丟万丁专._moveMethod != 1)
        {
            goto label_14;
        }
        
        UnityEngine.Coroutine val_5 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  0.丑万丅不丘万丑下丆(七丘东丞世丆丕丙丅:  mem[this.丙丗丄丟东丒丈万丆]));
        val_12 = 1;
        goto label_18;
        label_10:
        val_11 = 0;
        val_12 = 4;
        label_18:
        this.丒上七丌业七丟与丐 = val_11;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return true;
        label_12:
        UnityEngine.Coroutine val_7 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  0.丟丅丁世上上且丞丙(七丘东丞世丆丕丙丅:  mem[this.丙丗丄丟东丒丈万丆], 与丈业丛丝丒丙一丏:  this.丝且与丝丒丟万丁专._duration, 专一上世业丗丒丘不:  this.丝且与丝丒丟万丁专._curve));
        goto label_18;
        label_13:
        UnityEngine.Coroutine val_9 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  0.丙丁世丂丑丒业七三(七丘东丞世丆丕丙丅:  mem[this.丙丗丄丟东丒丈万丆], 丟丌丐丘丆丙丑丑一:  this.丝且与丝丒丟万丁专._parabolaHeight, 与丈业丛丝丒丙一丏:  this.丝且与丝丒丟万丁专._duration));
        goto label_18;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
