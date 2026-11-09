using UnityEngine;
private sealed class 丐东不丅丂丂丅丙不.丟万丒丙丂丒业丙丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐东不丅丂丂丅丙不.丟万丒丙丂丒业丙丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        System.Action val_9;
        var val_10;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丗丕专丐丞丞下不丒 = new UnityEngine.WaitForSecondsRealtime(time:  0.9f);
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_5 = null;
        if(丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘() <= 0)
        {
            goto label_6;
        }
        
        label_23:
        val_6 = 1;
        this.丗丏丅丕丆世丁专丟 = val_6;
        this.丒上七丌业七丟与丐 = this.丗丕专丐丞丞下不丒;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_6:
        val_7 = null;
        if(丐东不丅丂丂丅丙不.丑业丝丛丅丐丙丙上() < 1)
        {
            goto label_23;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = 丐东不丅丂丂丅丙不.丈一丘丁上丙丞七业;
        if(val_9 != null)
        {
                val_9 = 丐东不丅丂丂丅丙不.丈一丘丁上丙丞七业;
            if(val_9 == null)
        {
                val_9 = 0;
        }
        
            val_9.Invoke();
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_23;
        }
        
        val_10 = null;
        val_10 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丛丈上且不丟丑万();
        goto label_23;
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
