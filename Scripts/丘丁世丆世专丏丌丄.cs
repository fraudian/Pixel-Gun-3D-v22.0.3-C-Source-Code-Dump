using UnityEngine;
private sealed class 丘专丛不三且丅丐丑.丘丁世丆世专丏丌丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丘专丛不三且丅丐丑.丘丁世丆世专丏丌丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专.专业丗丙且丐丟丏丐 != 0)
        {
                if(this.丝且与丝丒丟万丁专.专业丗丙且丐丟丏丐.丅与丌专丟一丝业三().activeInHierarchy != false)
        {
                this.丝且与丝丒丟万丁专.一丏丘且丞丙不且上();
            this.丝且与丝丒丟万丁专.丌且丟丅七丅丙业不();
            this.丝且与丝丒丟万丁专.与丟世且七与一丐丌();
            val_5 = 1;
            this.丗丏丅丕丆世丁专丟 = val_5;
            this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
            return (bool)val_5;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丄不丟丙下丆丘不丁();
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
