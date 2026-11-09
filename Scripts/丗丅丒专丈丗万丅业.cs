using UnityEngine;
private sealed class WeaponManager.丗丅丒专丈丗万丅业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponManager 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponManager.丗丅丒专丈丗万丅业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_5;
        int val_6;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_1 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  "Rocket");
        this.丅丒丑丄丞丑下丈丕 = val_1;
        this.丒上七丌业七丟与丐 = val_1;
        val_6 = 1;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone == false)
        {
            goto label_5;
        }
        
        val_5 = this.丅丒丑丄丞丑下丈丕.asset;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        if(val_5 != null)
        {
            goto label_8;
        }
        
        goto label_12;
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        if(val_5 == null)
        {
            goto label_12;
        }
        
        label_8:
        if(null != null)
        {
                val_5 = 0;
        }
        
        label_12:
        val_6 = 0;
        this.丝且与丝丒丟万丁专._rocketCache = val_5;
        return (bool)val_6;
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
