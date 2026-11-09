using UnityEngine;
private sealed class ZombieGameView.丒下丟丟丅丅丐丗丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ZombieGameView 丝且与丝丒丟万丁专;
    public UnityEngine.GameObject 万且万且丑丗且丌丆;
    public int 丝丒丏丒万丂万万东;
    public UnityEngine.Vector3 三丙业丝丐上不丝丈;
    private UIPanel 丁丁丒丈丌丐丛且世;
    private float 与下丌丞丏丕丗且七;
    private float 丛下丙丙丙丅下丘专;
    private UnityEngine.Transform 丁下丟上丂丐丏丌业;
    private UnityEngine.Vector3 丙上丂丑丕业世丈不;
    private UnityEngine.Vector3 丄下东丙丅世丏丟丄;
    private UnityEngine.Vector2 丅一丌丒一丗万丆上;
    private UnityEngine.Vector2 丆丏且丝不丅丘丕丁;
    private float 与世东丈丏丆与丝丝;
    private int 丕东万丌万丛丂丐丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ZombieGameView.丒下丟丟丅丅丐丗丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_39;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_37 = 106016928 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_37 = val_37 + 106016928;
        }
        else
        {
                val_39 = 0;
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
