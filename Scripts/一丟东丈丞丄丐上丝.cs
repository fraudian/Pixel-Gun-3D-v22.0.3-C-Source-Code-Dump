using UnityEngine;
private sealed class BPChallengeVisible.一丟东丈丞丄丐上丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPChallengeVisible 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPChallengeVisible.一丟东丈丞丄丐上丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_14;
        int val_15;
        bool val_16;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_17;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_14 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_15 = 1;
        this.丒上七丌业七丟与丐 = val_14;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_1:
        val_14 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_14.下且世丆丟且丑与丕() == null)
        {
                return (bool)val_15;
        }
        
        if(val_14.isActiveAndEnabled == false)
        {
            goto label_17;
        }
        
        if(val_14 != null)
        {
                val_16 = this.丝且与丝丒丟万丁专.丙丐丛上且丆丅三丏;
            this.丝且与丝丒丟万丁专.丙丐丛上且丆丅三丏 = val_14.丂与丞丄丒丁下上东();
        }
        else
        {
                val_16 = 56;
            mem[56] = 0.丂与丞丄丒丁下上东();
        }
        
        if((val_14.下且世丆丟且丑与丕().丏丂丁丗下七丕专丆() == false) || (val_16 == false))
        {
            goto label_13;
        }
        
        if(val_14 == null)
        {
            goto label_14;
        }
        
        val_14 = val_14.下且世丆丟且丑与丕();
        goto label_15;
        label_13:
        if(this.丝且与丝丒丟万丁专.丙下一与丗七与专一 != null)
        {
            goto label_17;
        }
        
        val_15 = 0;
        this.丝且与丝丒丟万丁专.丙下一与丗七与专一 = val_14.StartCoroutine(routine:  val_14.专丏丐丝七七丐世丞());
        return (bool)val_15;
        label_14:
        val_14 = 0.下且世丆丟且丑与丕();
        label_15:
        0.丛丘丐丒不丆丞丌丁(丟专三丙丒丄丂下与:  val_14);
        label_17:
        val_15 = 0;
        return (bool)val_15;
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
