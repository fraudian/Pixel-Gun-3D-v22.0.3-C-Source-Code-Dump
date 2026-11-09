using UnityEngine;
private sealed class 丒丐一下丛东不丘丌.丄下丕丏丙丝丑丛世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private 丒丐一下丛东不丘丌.丞丂万丅不丒丘丟丗 丄丌丂东丘丗一万且;
    public System.Action<bool> 丗丞丒丆丄业丕上丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒丐一下丛东不丘丌.丄下丕丏丙丝丑丛世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_23;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_21 = 106019492 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_21 = val_21 + 106019492;
        }
        else
        {
                val_23 = 0;
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
