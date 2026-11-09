using UnityEngine;
private sealed class TempItemsController.业丐丁丁世不丟万丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TempItemsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TempItemsController.业丐丁丁世不丟万丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        var val_6;
        FriendsController val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = 0;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_5;
        val_6 = null;
        val_6 = null;
        val_7 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_7 != 0)
        {
            goto label_6;
        }
        
        val_8 = 0;
        val_5 = 1;
        goto label_7;
        label_1:
        val_9 = 0;
        val_10 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_8;
        }
        
        return (bool)val_10;
        label_6:
        val_11 = null;
        val_11 = null;
        val_7 = FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  1f);
        val_5 = 2;
        label_7:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_7);
        label_8:
        val_10 = val_9;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_10;
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
