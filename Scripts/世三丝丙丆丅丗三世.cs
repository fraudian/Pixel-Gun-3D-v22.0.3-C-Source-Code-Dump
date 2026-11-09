using UnityEngine;
private sealed class LeaderboardsMiniGameController.世三丝丙丆丅丗三世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LeaderboardsMiniGameController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardsMiniGameController.世三丝丙丆丅丗三世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.LeaderboardsMiniGameController val_8;
        int val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        val_8 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        bool val_8 = this.丝且与丝丒丟万丁专.丗丈且万业丛万丝下;
        val_8 = val_8 + 3;
        var val_9 = ~val_8;
        val_9 = val_9 & 3;
        if(val_9 != 0)
        {
                return false;
        }
        
        this.丝且与丝丒丟万丁专.丗丈且万业丛万丝下 = true;
        this.丝且与丝丒丟万丁专._betterWrapContent.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  val_8, method:  System.Int32 Rilisoft.LeaderboardsMiniGameController::丘世下丐丞丅且三丛()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  val_8, method:  System.Void Rilisoft.LeaderboardsMiniGameController::业业专丌不业世一丞(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
        val_9 = this.丝且与丝丒丟万丁专.业丌丐丏丂丕七业丐;
        if(val_9 > (this.丝且与丝丒丟万丁专._betterWrapContent.VisibleCellsCount - 1))
        {
                val_10 = this.丝且与丝丒丟万丁专.业丌丐丏丂丕七业丐;
            if(val_10 > this.丝且与丝丒丟万丁专._betterWrapContent.VisibleCellsCount)
        {
                float val_10 = 0.6f;
            val_10 = (float)this.丝且与丝丒丟万丁专._betterWrapContent.VisibleCellsCount * val_10;
            val_10 = val_10 - (UnityEngine.Mathf.RoundToInt(f:  val_10));
        }
        
            val_9 = this.丝且与丝丒丟万丁专._betterWrapContent;
            val_9.ScrollTo(丘丒丌下丕专且七专:  val_10, 与丑丑丑丂丛一丝一:  false);
        }
        
        this.丝且与丝丒丟万丁专.丗丈且万业丛万丝下 = false;
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
