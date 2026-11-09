using UnityEngine;
private sealed class RewardWindowController.丂丒与丕业丂上上丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardWindowController 丝且与丝丒丟万丁专;
    public System.Action 丗丗世丘丙不世丁丅;
    private float 丒丙丏七丑丑三丐丞;
    private UnityEngine.Vector3 专丂丄丈世丆丕一不;
    private UnityEngine.Vector3 下丘一丌丌万东丆丅;
    private UnityEngine.Vector3 丂下丑丆丞上上上丌;
    private int 专业七不丞丄不七丄;
    private int 东下世丈上丄丑下丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardWindowController.丂丒与丕业丂上上丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_123;
        int val_128;
        val_123 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_121 = 106030332 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_121 = val_121 + 106030332;
        }
        else
        {
                val_128 = 0;
            return (bool)val_128;
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
