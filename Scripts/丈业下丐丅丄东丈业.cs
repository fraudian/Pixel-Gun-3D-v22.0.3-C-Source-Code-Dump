using UnityEngine;
private sealed class FortCraftButton.丈业下丐丅丄东丈业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.FortCraftButton 丝且与丝丒丟万丁专;
    private UIButton 丝丘丄七丐丄七丗丒;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortCraftButton.丈业下丐丅丄东丈业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_32;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_32 = 106029184 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_32 = val_32 + 106029184;
        }
        else
        {
                val_32 = 0;
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
