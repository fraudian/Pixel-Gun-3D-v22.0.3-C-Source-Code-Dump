using UnityEngine;
private sealed class 业丗丕丟三丝丘三丗.不丗丕丅丘丁下不下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 业丗丕丟三丝丘三丗 丝且与丝丒丟万丁专;
    public 业丗丕丟三丝丘三丗.丏东丂专丗不丟一与 且七丂丆丅不丏丂丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 业丗丕丟三丝丘三丗.不丗丕丅丘丁下不下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        业丗丕丟三丝丘三丗.丏东丂专丗不丟一与 val_3;
        var val_4;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.不一丟丛丁且丒丐丑 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 > 0f)
        {
            goto label_6;
        }
        
        }
        
            this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 = 0f;
            val_3 = this.且七丂丆丅不丏丂丗;
            val_3.Invoke();
            val_4 = 0;
            this.丝且与丝丒丟万丁专.七丄丐丘东丏不专丁 = 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
        label_6:
        float val_3 = this.丝且与丝丒丟万丁专.丑丗专丆一上世业丗.hideSmoothTime;
        val_3 = UnityEngine.Time.deltaTime / val_3;
        val_3 = this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 - val_3;
        this.丝且与丝丒丟万丁专.丂下一业七丁丑专丄 = val_3;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
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
