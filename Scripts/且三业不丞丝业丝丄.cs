using UnityEngine;
private sealed class BPChallengeVisible.且三业不丞丝业丝丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPChallengeVisible 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPChallengeVisible.且三业不丞丝业丝丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_2;
        }
        
        goto label_7;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = this.丝且与丝丒丟万丁专.下且世丆丟且丑与丕();
        if(val_9.一丗丅丟上丒丒丑丈() == false)
        {
            goto label_6;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        label_2:
        val_9 = this.丝且与丝丒丟万丁专.丂与丞丄丒丁下上东();
        if(val_9 == true)
        {
            goto label_8;
        }
        
        goto label_14;
        label_1:
        val_10 = 0;
        return (bool)val_10;
        label_7:
        val_9 = 0.丂与丞丄丒丁下上东();
        if(val_9 == false)
        {
            goto label_14;
        }
        
        label_8:
        if(this.丝且与丝丒丟万丁专.丙丐丛上且丆丅三丏 != true)
        {
                if(this.丝且与丝丒丟万丁专.下且世丆丟且丑与丕().丏丂丁丗下七丕专丆() != false)
        {
                PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_7 = this.丝且与丝丒丟万丁专.下且世丆丟且丑与丕();
            val_7.丛丘丐丒不丆丞丌丁(丟专三丙丒丄丂下与:  val_7);
        }
        
        }
        
        label_14:
        val_10 = 1;
        this.丝且与丝丒丟万丁专.丙丐丛上且丆丅三丏 = val_9;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_6:
        val_10 = 0;
        this.丝且与丝丒丟万丁专.丙下一与丗七与专一 = 0;
        return (bool)val_10;
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
