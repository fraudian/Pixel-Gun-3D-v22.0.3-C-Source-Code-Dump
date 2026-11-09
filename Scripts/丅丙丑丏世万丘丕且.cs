using UnityEngine;
private sealed class WeaponManager.丅丙丑丏世万丘丕且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponManager 丝且与丝丒丟万丁专;
    private Rilisoft.丅丞丈丅东丆与世丈 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponManager.丅丙丑丏世万丘丕且(int 丗丏丅丕丆世丁专丟)
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
        val_1 = val_1 & 113;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private bool MoveNext()
    {
        int val_30;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_28 = 106016316 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_28 = val_28 + 106016316;
        }
        else
        {
                val_30 = 0;
            return (bool)val_30;
        }
    
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
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
