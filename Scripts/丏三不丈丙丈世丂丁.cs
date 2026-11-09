using UnityEngine;
private sealed class BotHealth.丏三不丈丙丈世丂丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BotHealth 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BotHealth.丏三不丈丙丈世丂丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        UnityEngine.GameObject val_3;
        int val_4;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_3 = this.丝且与丝丒丟万丁专.丐丒丅丗丏上一丏丅;
        this.丝且与丝丒丟万丁专.上丕丂一丗丁丗丞丄 = true;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        val_2 = this.丝且与丝丒丟万丁专.丐丒丅丗丏上一丏丅;
        goto label_6;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_3:
        mem[24] = 1;
        val_3 = 64;
        label_4:
        BotHealth.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_3, 丐丅丁丂丐下丘世丄:  this.丝且与丝丒丟万丁专.hitTexture);
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.125f);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_5:
        val_2 = 64;
        label_6:
        BotHealth.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_2, 丐丅丁丂丐下丘世丄:  this.丝且与丝丒丟万丁专.丑丄丅丟丙丛丒丑丅);
        val_4 = 0;
        this.丝且与丝丒丟万丁专.上丕丂一丗丁丗丞丄 = false;
        return (bool)val_4;
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
