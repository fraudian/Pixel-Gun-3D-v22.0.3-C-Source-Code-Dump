using UnityEngine;
private sealed class TaskUIClearSection.丗且丑一丗丟丌七丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIClearSection 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIClearSection.丗且丑一丗丟丌七丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        UnityEngine.Animation val_6;
        var val_7;
        UnityEngine.Animation val_8;
        UnityEngine.Animation val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_5 = this.丝且与丝丒丟万丁专;
        val_6 = this.丝且与丝丒丟万丁专.animator;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        val_7 = this.丝且与丝丒丟万丁专;
        val_8 = this.丝且与丝丒丟万丁专.animator;
        goto label_9;
        label_4:
        val_5 = 128;
        val_6 = 123372880;
        label_5:
        val_6.clip = this.丝且与丝丒丟万丁专.shakeAnim;
        bool val_1 = val_5.Play();
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.timeInSeconds);
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_8:
        val_7 = 128;
        val_8 = 123372880;
        label_9:
        val_8.clip = this.丝且与丝丒丟万丁专.trashDrop;
        bool val_3 = val_7.Play();
        label_7:
        val_9 = this.丝且与丝丒丟万丁专.animator;
        if(val_9.isPlaying != false)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_10 = 1;
            return (bool)val_10;
        }
        
        this.丝且与丝丒丟万丁专.万丏丛东下丝下丟丕();
        label_3:
        val_10 = 0;
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
