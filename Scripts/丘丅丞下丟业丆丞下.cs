using UnityEngine;
private sealed class 丗下丙丅且丐丞丙世.丘丅丞下丟业丆丞下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丗下丙丅且丐丞丙世 丝且与丝丒丟万丁专;
    private System.Nullable<bool> 丙世世万且丏丆丂丂;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丗下丙丅且丐丞丙世.丘丅丞下丟业丆丞下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        var val_23;
        int val_24;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丙世世万且丏丆丂丂 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.业一下丝丗丌与丙丘 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_22 = null;
        val_22 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 == 0) || (FriendsController.丝丗专上三不丄丑丑() < 1))
        {
            goto label_11;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_7 = this.丝且与丝丒丟万丁专.丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  60);
        if(val_7 == null)
        {
            goto label_17;
        }
        
        val_23 = val_7.七丂丌丈丄专丄三世();
        goto label_18;
        label_2:
        val_24 = 0;
        return (bool)val_24;
        label_17:
        val_23 = 0;
        label_18:
        if((this.丙世世万且丏丆丂丂 & 1) != 0)
        {
                if(val_23 != (this.丙世世万且丏丆丂丂 & 1))
        {
                BalanceController.丙丏丂下丂上七不一();
        }
        
        }
        
        mem2[0] = 0;
        label_11:
        long val_10 = FriendsController.丝丗专上三不丄丑丑();
        if(val_10 >= 1)
        {
                this.丝且与丝丒丟万丁专.<丛丂世丅丈专丑丅丅>k__BackingField = val_10;
        }
        
        val_24 = 1;
        this.丗丏丅丕丆世丁专丟 = val_24;
        this.丒上七丌业七丟与丐 = this.业一下丝丗丌与丙丘;
        return (bool)val_24;
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
