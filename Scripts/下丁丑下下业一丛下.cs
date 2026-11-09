using UnityEngine;
private sealed class ExpController.下丁丑下下业一丛下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ExpController 丝且与丝丒丟万丁专;
    public bool 丛丏与专丙丄七三丞;
    public int 丑丛丌丟丝丆丌七上;
    public UnityEngine.AudioClip 东世丑世丛丞不专丕;
    private int 上业丄丞丑与丈不丕;
    private bool 万丘丞业丄丟世世丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExpController.下丁丑下下业一丛下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioClip val_50;
        int val_57;
        val_50 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_50 = 106018588 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_50 = val_50 + 106018588;
        }
        else
        {
                val_57 = 0;
            return (bool)val_57;
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
