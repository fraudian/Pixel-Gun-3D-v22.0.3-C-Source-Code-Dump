using UnityEngine;
private sealed class GameServicesController.与丞丅丘丟丄丒丁丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丏丒丐东丏丛下丕与;
    private float 世万丌不丑丛丞世丆;
    private UnityEngine.WaitForSeconds 丞与丁丁丘下与一丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameServicesController.与丞丅丘丟丄丒丁丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_59;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_71 = 106024768 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_71 = val_71 + 106024768;
        }
        else
        {
                val_59 = 0;
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
