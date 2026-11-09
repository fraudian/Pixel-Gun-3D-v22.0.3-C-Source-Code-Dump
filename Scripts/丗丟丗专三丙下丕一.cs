using UnityEngine;
private sealed class 业丗丕丟三丝丘三丗.丗丟丗专三丙下丕一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 业丗丕丟三丝丘三丗 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 业丗丕丟三丝丘三丗.丗丟丗专三丙下丕一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.不一丟丛丁且丒丐丑 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 < 0)
        {
            goto label_6;
        }
        
        }
        
            val_3 = 0;
            this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 = 1f;
            this.丝且与丝丒丟万丁专.丙丒丕丅丏上丛且一 = 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
        label_6:
        float val_3 = this.丝且与丝丒丟万丁专.丑丗专丆一上世业丗.showSmoothTime;
        val_3 = UnityEngine.Time.deltaTime / val_3;
        val_3 = this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 + val_3;
        this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 = val_3;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_3;
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
