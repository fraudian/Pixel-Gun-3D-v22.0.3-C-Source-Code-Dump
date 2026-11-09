using UnityEngine;
private sealed class FriendPreviewItem.上世世业丘不丗下丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 东丞丒丙世丏三下丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendPreviewItem.上世世业丘不丗下丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_8;
        int val_9;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(UnityEngine.Application.isEditor == true)
        {
            goto label_3;
        }
        
        goto label_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(this.东丞丒丙世丏三下丟.isDone == false)
        {
            goto label_6;
        }
        
        bool val_4 = System.String.IsNullOrEmpty(value:  this.东丞丒丙世丏三下丟.error);
        object[] val_5 = new object[1];
        val_8 = val_5;
        if(this.东丞丒丙世丏三下丟 == null)
        {
            goto label_8;
        }
        
        if(val_4 == false)
        {
            goto label_9;
        }
        
        label_18:
        val_8[0] = this.东丞丒丙世丏三下丟.text;
        UnityEngine.Debug.LogFormat(format:  "Request succeeded: {0}", args:  val_5);
        goto label_16;
        label_6:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_8:
        if(val_4 == true)
        {
            goto label_18;
        }
        
        label_9:
        val_8[0] = this.东丞丒丙世丏三下丟.error;
        UnityEngine.Debug.LogWarningFormat(format:  "Request failed: {0}", args:  val_5);
        label_16:
        val_9 = 0;
        return (bool)val_9;
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
