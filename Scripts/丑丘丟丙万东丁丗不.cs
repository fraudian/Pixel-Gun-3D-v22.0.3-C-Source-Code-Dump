using UnityEngine;
private sealed class CoroutineRunner.丑丘丟丙万东丁丗不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丙不三七上丑丗丑丏;
    public System.Action 丌专业且丛丏丞丝且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丑丘丟丙万东丁丗不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        object val_3;
        int val_4;
        val_2 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丙不三七上丑丗丑丏 <= 0f)
        {
            goto label_4;
        }
        
        丕世专丒丁不丁丅丁 val_1 = null;
        val_3 = val_1;
        val_1 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.丙不三七上丑丗丑丏);
        val_4 = 1;
        goto label_5;
        label_1:
        val_4 = 0;
        goto label_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(this.丌专业且丛丏丞丝且 != null)
        {
                this.丌专业且丛丏丞丝且.Invoke();
        }
        
        val_3 = 0;
        val_4 = 2;
        label_5:
        val_2 = 1;
        this.丒上七丌业七丟与丐 = val_3;
        label_6:
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_2;
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
