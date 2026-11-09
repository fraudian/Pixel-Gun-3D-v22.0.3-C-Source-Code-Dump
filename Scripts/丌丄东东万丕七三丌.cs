using UnityEngine;
private sealed class Portal.丌丄东东万丕七三丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Portal 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Portal.丌丄东东万丕七三丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        var val_4;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.业东且万丏上丁丘丈 == false)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.丁丄丄丕业丙与丘下 = 0f;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        label_5:
        if(this.丝且与丝丒丟万丁专.丁丄丄丕业丙与丘下 <= 1f)
        {
            goto label_7;
        }
        
        label_10:
        this.丝且与丝丒丟万丁专.业东且万丏上丁丘丈 = false;
        label_4:
        val_3 = 2;
        goto label_8;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_7:
        float val_1 = UnityEngine.Time.deltaTime;
        label_11:
        val_1 = val_1 / this.丝且与丝丒丟万丁专.delayTeleportation;
        val_1 = this.丝且与丝丒丟万丁专.丁丄丄丕业丙与丘下 + val_1;
        mem2[0] = val_1;
        val_3 = 1;
        label_8:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_4;
        label_6:
        if(0f > 1f)
        {
            goto label_10;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        goto label_11;
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
