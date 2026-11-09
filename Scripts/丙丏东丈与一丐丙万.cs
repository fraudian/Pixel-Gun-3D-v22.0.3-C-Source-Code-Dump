using UnityEngine;
private sealed class OneChestGameEventView.丙丏东丈与一丐丙万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.OneChestGameEventView 丝且与丝丒丟万丁专;
    public bool 丈丄丂丈丆丑丞专丌;
    private Rilisoft.OneChestGameEventView.业东下丕世丗丏万丏 丄丌丂东丘丗一万且;
    private System.Action 不东丏丞万与东不丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OneChestGameEventView.丙丏东丈与一丐丙万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_34;
        int val_35;
        val_34 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 8)
        {
                var val_34 = 106021904 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_34 = val_34 + 106021904;
        }
        else
        {
                val_35 = 0;
            return (bool);
        }
    
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
