using UnityEngine;
private sealed class PetEngine.与专丙丙丟与丁下丛 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丙不三七上丑丗丑丏;
    public float 七专丙丆丑丄丅世下;
    private System.Action 丌专业且丛丏丞丝且;
    public System.Action 下丌丘且丞丑世丏丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetEngine.与专丙丙丟与丁下丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丙不三七上丑丗丑丏);
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
        label_1:
        val_2 = this.丌专业且丛丏丞丝且;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke();
        label_2:
        val_2 = 0;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        float val_4;
        var val_5;
        if((this.丗丏丅丕丆世丁专丟 != 2) || (this.丈世三丐万且丅上丈 != System.Environment.CurrentManagedThreadId))
        {
            goto label_2;
        }
        
        val_4 = this.七专丙丆丑丄丅世下;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this;
        goto label_3;
        label_2:
        PetEngine.与专丙丙丟与丁下丛 val_2 = null;
        val_5 = val_2;
        val_2 = new PetEngine.与专丙丙丟与丁下丛();
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        val_4 = this.七专丙丆丑丄丅世下;
        if(val_5 == null)
        {
            goto label_4;
        }
        
        label_3:
        .丙不三七上丑丗丑丏 = val_4;
        .丌专业且丛丏丞丝且 = this.下丌丘且丞丑世丏丙;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_5;
        label_4:
        mem[36] = val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
