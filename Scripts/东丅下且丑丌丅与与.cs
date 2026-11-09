using UnityEngine;
private sealed class MainMenuController.东丅下且丑丌丅与与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task 万不且且丛丆东丒业;
    public System.Action<System.Threading.Tasks.Task> 七丆丘上专丞上丟丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.东丅下且丑丌丅与与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<System.Threading.Tasks.Task> val_3;
        var val_4;
        System.Threading.Tasks.Task val_5;
        int val_6;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        val_4 = val_3;
        val_5 = this.万不且且丛丆东丒业;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 == null)
        {
            goto label_3;
        }
        
        if(this.七丆丘上专丞上丟丗 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_4 = val_3;
        val_5 = this.万不且且丛丆东丒业;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        label_6:
        if(val_5.IsCompleted == false)
        {
            goto label_7;
        }
        
        val_3 = this.七丆丘上专丞上丟丗;
        val_3.Invoke(obj:  val_5);
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_3:
        System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "task");
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
