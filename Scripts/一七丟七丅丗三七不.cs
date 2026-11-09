using UnityEngine;
private sealed class WeaponParticleDelay.一七丟七丅丗三七不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public WeaponParticleDelay 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponParticleDelay.一七丟七丅丗三七不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.ParticleSystem val_6;
        int val_7;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专.partSystem;
        if(val_6 != 0)
        {
                val_6 = this.丝且与丝丒丟万丁专.partSystem.gameObject;
            if(val_6 != 0)
        {
                val_6 = this.丝且与丝丒丟万丁专.partSystem.gameObject;
            val_6.SetActive(value:  true);
        }
        
        }
        
        val_7 = 0;
        this.丝且与丝丒丟万丁专.丁丈丏世三一不上丐 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
