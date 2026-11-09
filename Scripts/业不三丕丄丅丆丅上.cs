using UnityEngine;
private sealed class ReelController.业不三丕丄丅丆丅上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ReelController 丝且与丝丒丟万丁专;
    public UnityEngine.GameObject 万且万且丑丗且丌丆;
    public UnityEngine.Vector3 三丙业丝丐上不丝丈;
    private UIPanel 丁丁丒丈丌丐丛且世;
    private float 与下丌丞丏丕丗且七;
    private float 丛下丙丙丙丅下丘专;
    private float 丝且专七下丞与丑丐;
    private int 丌不丝东丟丅丅世不;
    private UnityEngine.Transform 万丌三丏丞丝世下丄;
    private UnityEngine.Vector3 不丙丅世专丏万丂丝;
    private UnityEngine.Vector3 丏丌万丘一世丙丙丂;
    private UnityEngine.Vector2 丞三丕丛七丂丗丗丟;
    private UnityEngine.Vector2 丟丒丑丝丛丟丕丄丑;
    private float 丕丑丐不丝上丌上业;
    private int 万丙丞丞丐业丌丅三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReelController.业不三丕丄丅丆丅上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_34;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_33 = 106038304 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_33 = val_33 + 106038304;
        }
        else
        {
                val_34 = 0;
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
