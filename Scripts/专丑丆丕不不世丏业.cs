using UnityEngine;
private sealed class LeaderboardEventController.专丑丆丕不不世丏业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LeaderboardEventController 丝且与丝丒丟万丁专;
    public int 丟丟丄专上丟丁丐丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.专丑丆丕不不世丏业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丁七丈丌丈丂世万下 != null)
        {
                if(this.丝且与丝丒丟万丁专.丁七丈丌丈丂世万下.Count == 0)
        {
                this.丟丟丄专上丟丁丐丝 = 0;
        }
        
            this = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丟三丂丒丏不丌丝与(丟丟丄专上丟丁丐丝:  this.丟丟丄专上丟丁丐丝, 丛专下丞丒丛下下与:  true));
            return false;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
