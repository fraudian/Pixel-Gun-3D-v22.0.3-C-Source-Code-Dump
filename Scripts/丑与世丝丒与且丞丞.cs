using UnityEngine;
private sealed class 世与丛一丕丄丗丈丅.丑与世丝丒与且丞丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.三东丏不丗世丅丌丄 丄业丏丙且丞业上东;
    public Rilisoft.世与丛一丕丄丗丈丅 丝且与丝丒丟万丁专;
    private int 丕上与且丅丄专三东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 世与丛一丕丄丗丈丅.丑与世丝丒与且丞丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_9;
        int val_12;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_9 = 106044076 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_9 = val_9 + 106044076;
        }
        else
        {
                val_12 = 0;
            return (bool)val_12;
        }
    
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
