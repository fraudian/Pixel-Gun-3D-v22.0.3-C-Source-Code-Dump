using UnityEngine;
private sealed class CoinsAddIndic.上丛丁专丝丏丄不丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CoinsAddIndic 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoinsAddIndic.上丛丁专丝丏丄不丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 7)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 225;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丞与下世丈丈丆丑丒 = false;
    }
    private bool MoveNext()
    {
        int val_29;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_10 = 106024240 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_10 = val_10 + 106024240;
        }
        else
        {
                val_29 = 0;
            return (bool)val_29;
        }
    
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丞与下世丈丈丆丑丒 = false;
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
