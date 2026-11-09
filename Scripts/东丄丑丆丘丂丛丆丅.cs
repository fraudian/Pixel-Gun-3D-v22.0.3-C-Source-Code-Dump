using UnityEngine;
private sealed class 丅业丅与丄与一丙一.东丄丑丆丘丂丛丆丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丅业丅与丄与一丙一 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅业丅与丄与一丙一.东丄丑丆丘丂丛丆丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        丅丝不专世七丏丕七 val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 0;
        val_4 = 0;
        goto label_3;
        label_7:
        val_4 = this.丝且与丝丒丟万丁专.丄丆丈丆丕专不七七[0].Count + val_4;
        val_3 = 1;
        label_3:
        if(val_3 < this.丝且与丝丒丟万丁专.丄丆丈丆丕专不七七.Length)
        {
            goto label_7;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        if(val_4 == 0)
        {
            goto label_9;
        }
        
        label_12:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丅下丈专丕丅丑业下;
        goto label_10;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_8:
        if(val_4 != 0)
        {
            goto label_12;
        }
        
        label_9:
        val_5 = 0;
        val_2 = this.丝且与丝丒丟万丁专.丕丂专丂丌万丗东丈;
        label_10:
        mem2[0] = 1;
        return (bool)val_5;
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
