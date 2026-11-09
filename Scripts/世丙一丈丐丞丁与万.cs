using UnityEngine;
private sealed class BaseBot.世丙一丈丐丞丁与万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public RilisoftBot.BaseBot 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseBot.世丙一丈丐丞丁与万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_24;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_24:
        if(this.丕丕世且下一与丝与 > 0f)
        {
                val_9 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
        label_5:
        if((this.丝且与丝丒丟万丁专.下不丌万丙且一万东 != 0) && (丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null))
        {
                if(this.丝且与丝丒丟万丁专.丅丏三七丁丑丞丄丏.owner != 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())
        {
                this.丝且与丝丒丟万丁专.下不丌万丙且一万东.丘丝丌丌丟丄丁丒七(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丅丏三七丁丑丞丄丏.owner != 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())
        {
            goto label_24;
        }
        
        this.丝且与丝丒丟万丁专.DestroyByNetworkType();
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
