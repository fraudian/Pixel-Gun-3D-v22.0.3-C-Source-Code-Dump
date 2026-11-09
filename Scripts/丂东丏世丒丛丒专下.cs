using UnityEngine;
private sealed class 丅业丅与丄与一丙一.丂东丏世丒丛丒专下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丅业丅与丄与一丙一 丝且与丝丒丟万丁专;
    public uint 七丞丙丒三丕且丌丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅业丅与丄与一丙一.丂东丏世丒丛丒专下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        uint val_7;
        var val_8;
        var val_9;
        val_7 = this;
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
        goto label_19;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        val_8 = 0;
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_5:
        val_8 = 1;
        goto label_10;
        label_27:
        val_8 = 0;
        this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 = this.丝且与丝丒丟万丁专.丄丆丈丆丕专不七七[this.七丞丙丒三丕且丌丟].Dequeue();
        label_10:
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万.MoveNext() == false)
        {
            goto label_19;
        }
        
        if((val_8 & 1) == 0)
        {
            goto label_20;
        }
        
        if(this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 == 1)
        {
            goto label_31;
        }
        
        var val_4 = (this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 == 0) ? 1 : 0;
        goto label_22;
        label_19:
        if(this.丝且与丝丒丟万丁专.丄丆丈丆丕专不七七[this.七丞丙丒三丕且丌丟].Count > 0)
        {
            goto label_27;
        }
        
        val_7 = this.七丞丙丒三丕且丌丟;
        val_9 = 0;
        this.丝且与丝丒丟万丁专.丁丅丘丁万万丗丅一[(this.七丞丙丒三丕且丌丟) << 2] = 0;
        return (bool)val_9;
        label_20:
        if(this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 == this.丝且与丝丒丟万丁专.丙丈世丁丒三丙丄三)
        {
            goto label_31;
        }
        
        label_22:
        if(((this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万 == this.丝且与丝丒丟万丁专.丝丏丐丂丅丁丛一丕) ? 1 : 0) == 0)
        {
            goto label_33;
        }
        
        this.丝且与丝丒丟万丁专.丁丅丘丁万万丗丅一[(this.七丞丙丒三丕且丌丟) << 2] = 0;
        goto label_35;
        label_31:
        this.丝且与丝丒丟万丁专.丁丅丘丁万万丗丅一[(this.七丞丙丒三丕且丌丟) << 2] = 1;
        label_35:
        var val_12 = 0;
        val_12 = val_12 + 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丒丄丅丅丝丏丗且万.Current;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
        label_33:
        this.丝且与丝丒丟万丁专.丁丅丘丁万万丗丅一[(this.七丞丙丒三丕且丌丟) << 2] = 2;
        this.丗丏丅丕丆世丁专丟 = 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丅下丈专丕丅丑业下;
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
