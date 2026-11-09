using UnityEngine;
private sealed class 三一丈七且丄与丝东.丄丝下下丆丙万丅七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public long 丆丐七丅丆丗丛上与;
    public Rilisoft.三一丈七且丄与丝东 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 三一丈七且丄与丝东.丄丝下下丆丙万丅七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        System.Collections.Generic.List<Rilisoft.GameEventData> val_5;
        int val_6;
        var val_7;
        val_4 = this;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.且丞丄丂丏丝三丙丌() == false)
        {
            goto label_3;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_5 = this.丝且与丝丒丟万丁专.东丐丛丟丆丂丅丆丙;
        goto label_5;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丆丐七丅丆丗丛上与 < 1)
        {
            goto label_7;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  (float)this.丆丐七丅丆丗丛上与);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_3:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
        label_4:
        val_5 = 64;
        label_5:
        this.丝且与丝丒丟万丁专.且七丙东东丘丛丄丆(丝七丐丁丌丄丂丂东:  val_5);
        val_4 = 1152921505459986432;
        val_7 = null;
        val_7 = null;
        val_6 = Rilisoft.三一丈七且丄与丝东.丌上丛丅世下东丑业;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke();
        label_7:
        val_6 = 0;
        return (bool)val_6;
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
