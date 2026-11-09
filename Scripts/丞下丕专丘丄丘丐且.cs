using UnityEngine;
private sealed class 万丘业丅丅丏丆东丈.丞下丕专丘丄丘丐且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.万丘业丅丅丏丆东丈 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丘业丅丅丏丆东丈.丞下丕专丘丄丘丐且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 9)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 769;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_30;
        if(this.丗丏丅丕丆世丁专丟 <= 6)
        {
                var val_28 = 106040448 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_28 = val_28 + 106040448;
        }
        else
        {
                val_30 = 0;
            return (bool);
        }
    
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丅丂下丛丗丘万丙丝 = 0;
        }
        else
        {
                mem[24] = 0;
        }
        
        this.丝且与丝丒丟万丁专.丞七丑且业上丄下丙 = 0;
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
