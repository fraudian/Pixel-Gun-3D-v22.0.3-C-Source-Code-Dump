using UnityEngine;
private sealed class ClosingScript.丞下丗丄不丈丗丛不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClosingScript 丝且与丝丒丟万丁专;
    private UnityEngine.RectTransform 丒丄世丂丛丗东丆丈;
    private int 七丙三业丕丝丌七丟;
    private float 且丟一丑丂丁丛丈世;
    private float 上丑万丗丆三丂世丕;
    private UnityEngine.Color 丁丏丞丄丏丒七丒丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClosingScript.丞下丗丄不丈丗丛不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ClosingScript val_20;
        int val_21;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_20 = 106024208 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_20 = this.丝且与丝丒丟万丁专;
            val_20 = val_20 + 106024208;
        }
        else
        {
                val_21 = 0;
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
