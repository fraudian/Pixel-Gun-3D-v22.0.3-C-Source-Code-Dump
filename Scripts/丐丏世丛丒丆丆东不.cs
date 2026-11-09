using UnityEngine;
private sealed class 专丒七丌丟丘上业专.丐丏世丛丒丆丆东不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Messaging.专丒七丌丟丘上业专 丝且与丝丒丟万丁专;
    private string 丌丌丘与丈业三不专;
    private System.DateTime 丏丑不丛丒七专丟东;
    private string 丂三丑万七丏丏世丌;
    private int 丄上丟丒丒丂下丆业;
    private string 丟不丏丒丈下丟东上;
    private System.IO.StreamReader 一丞丙万且丗不不一;
    private System.Threading.Tasks.Task<string> 上丈下丘丒丘丗丛丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 专丒七丌丟丘上业专.丐丏世丛丒丆丆东不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 97;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_46;
        string val_38 = 0;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_44 = 106032384 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_44 = val_44 + 106032384;
        }
        else
        {
                val_46 = 0;
            return (bool)val_46;
        }
    
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.一丞丙万且丗不不一 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.一丞丙万且丗不不一.Dispose();
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
