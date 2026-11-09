using UnityEngine;
private sealed class CoroutineRunner.丙一万与丂丒上丛三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丅丞与且专且丅丘三;
    public System.Action 丌专业且丛丏丞丝且;
    private int 东丑业丞丏东上七世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丙一万与丂丒上丛三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        var val_2;
        int val_3;
        int val_4;
        val_1 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_1;
        }
        
        val_2 = this;
        val_3 = 0;
        this.东丑业丞丏东上七世 = 0;
        goto label_3;
        label_0:
        val_4 = 0;
        goto label_4;
        label_1:
        val_2 = this;
        val_3 = this.东丑业丞丏东上七世;
        label_3:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 < this.丅丞与且专且丅丘三)
        {
                val_3 = val_3 + 1;
            this.东丑业丞丏东上七世 = val_3;
            val_4 = 1;
        }
        else
        {
                if(this.丌专业且丛丏丞丝且 != null)
        {
                this.丌专业且丛丏丞丝且.Invoke();
        }
        
            val_4 = 2;
        }
        
        val_1 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_4:
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_1;
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
