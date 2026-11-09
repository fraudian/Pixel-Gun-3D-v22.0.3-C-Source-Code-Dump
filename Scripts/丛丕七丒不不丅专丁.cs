using UnityEngine;
private sealed class 下丑与丙丝丆不丂且.丛丕七丒不不丅专丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.下丑与丙丝丆不丂且 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 下丑与丙丝丆不丂且.丛丕七丒不不丅专丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        var val_4;
        int val_5;
        val_2 = this;
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
        if(!=0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        val_3 = 40;
        val_4 = 135970152;
        goto label_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        if((137129984 & 1) == 0)
        {
            goto label_12;
        }
        
        if((137129984 & 1) == 0)
        {
            goto label_14;
        }
        
        label_8:
        val_3 = this.丝且与丝丒丟万丁专;
        label_9:
        val_2 = mem[this.丝且与丝丒丟万丁专 + 40];
        val_2 = this.丝且与丝丒丟万丁专 + 40;
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_12:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_14:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.上不且丅丛丈与丑一);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_5 = 1;
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
