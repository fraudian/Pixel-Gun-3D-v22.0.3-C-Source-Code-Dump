using UnityEngine;
private sealed class TurretControllerScene_BattleCannon.七丘丛七丁三专下下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Vector3 丌丄丑丁丟丒且丅丂;
    public UnityEngine.Vector3 丙丌丙三一专丙且丟;
    public UnityEngine.Transform 丆丐丟丝世丈丑丈不;
    public float 丒丑且丏上丕上丝丏;
    public float 丟丈丘丏丁专丛与丛;
    public float 丁丅丒上三丕世下丅;
    private UnityEngine.Vector3 丈世丐丑丄世丕上七;
    private float 丐东专丆丌七下丕丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretControllerScene_BattleCannon.七丘丛七丁三专下下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        int val_24;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_17 = 106032464 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_17 = val_17 + 106032464;
        }
        else
        {
                val_24 = 0;
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
