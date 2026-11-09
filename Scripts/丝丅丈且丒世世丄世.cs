using UnityEngine;
private sealed class AutoFade.丝丅丈且丒世世丄世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 世三丏丑丙丅丌且下;
    public AutoFade 丝且与丝丒丟万丁专;
    public UnityEngine.Color 一七专业丞丛世且丌;
    public float 丅世丗丛万下下专丕;
    private float 一专丞不东丐上丒且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutoFade.丝丅丈且丒世世丄世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_17 = 106031524 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_17 = val_17 + 106031524;
        }
        else
        {
                val_18 = 0;
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
