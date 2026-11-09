using UnityEngine;
private sealed class FriendProfileView.且丕丂七丘丙丒与丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FriendProfileView 丝且与丝丒丟万丁专;
    public FriendProfileView.丑丙上一且不世一与 丏丅七丒一业七上不;
    public string 丁业世丅丌丛上下与;
    public 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 三丞丕上丞三丑丘丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendProfileView.且丕丂七丘丙丒与丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FriendProfileView.丑丙上一且不世一与 val_7;
        var val_8;
        FriendProfileView.丑丙上一且不世一与 val_9;
        FriendProfileView.丑丙上一且不世一与 val_10;
        int val_11;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921537309426592] = this.丝且与丝丒丟万丁专;
        mem[1152921537309426600] = System.Void FriendProfileView::丞丞丈丏与丙丅不丕();
        mem[1152921537309426576] = System.Void FriendProfileView::丞丞丈丏与丙丅不丕();
        val_8 = null;
        val_9 = System.Delegate.Combine(a:  this.丏丅七丒一业七上不, b:  new FriendProfileView.丑丙上一且不世一与());
        if((val_9 != null) && (null != val_8))
        {
                val_8 = null;
            val_9 = 0;
        }
        
        this.丏丅七丒一业七上不 = val_9;
        mem[1152921537309434784] = this.丝且与丝丒丟万丁专;
        mem[1152921537309434792] = System.Void FriendProfileView::丏且不丛丌丗丟三丆();
        mem[1152921537309434768] = System.Void FriendProfileView::丏且不丛丌丗丟三丆();
        if(((System.Delegate.Combine(a:  val_9, b:  new FriendProfileView.丑丙上一且不世一与())) != null) && (null != null))
        {
                val_10 = 0;
        }
        
        this.丏丅七丒一业七上不 = val_10;
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_11:
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  this.丁业世丅丌丛上下与)) != this.三丞丕上丞三丑丘丏)
        {
            goto label_14;
        }
        
        val_7 = this.丏丅七丒一业七上不;
        val_7.Invoke();
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_14:
        val_11 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
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
