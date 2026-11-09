using UnityEngine;
private sealed class Rocket.丌不丛一不丆七丁丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rocket 丝且与丝丒丟万丁专;
    public float 丕丕世且下一与丝与;
    public UnityEngine.Collider 且丙与丏下丅丐世丑;
    private int 丕丑专丑丆丐丁且丄;
    private int 丛丅不丟业丕世丁专;
    private UnityEngine.WaitForSeconds 丞上丌丁一业丁下丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丌不丛一不丆七丁丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_50;
        int val_55;
        val_50 = 0;
        if(this.丗丏丅丕丆世丁专丟 <= 6)
        {
                var val_52 = 106024924 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_52 = val_52 + 106024924;
        }
        else
        {
                val_55 = 0;
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
