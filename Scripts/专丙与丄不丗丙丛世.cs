using UnityEngine;
private sealed class BattlePassCurrencyUpdater.专丙与丄不丗丙丛世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassCurrencyUpdater 丝且与丝丒丟万丁专;
    public float 丕丕世且下一与丝与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassCurrencyUpdater.专丙与丄不丗丙丛世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.BattlePass.BattlePassCurrencyUpdater val_2;
        int val_3;
        val_2 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 1;
        mem2[0] = val_3;
        UnityEngine.WaitForSeconds val_1 = null;
        val_2 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丒上七丌业七丟与丐 = val_2;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 == null)
        {
            goto label_5;
        }
        
        val_2.上业丝丙丅东业丟丅(丌丒丝东丌下丕丁丅:  this.丝且与丝丒丟万丁专.丒丙七专丒东业丘世);
        mem2[0] = 0;
        goto label_6;
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_5:
        0.上业丝丙丅东业丟丅(丌丒丝东丌下丕丁丅:  15996064);
        mem[41] = 0;
        label_6:
        val_3 = 0;
        this.丝且与丝丒丟万丁专.丑丞丝丒丏丙东一丄 = 0;
        return (bool)val_3;
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
