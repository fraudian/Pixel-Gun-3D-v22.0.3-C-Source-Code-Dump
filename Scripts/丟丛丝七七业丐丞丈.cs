using UnityEngine;
private sealed class RegenerationMode.丟丛丝七七业丐丞丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.PixelGun3D.RegenerationMode 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RegenerationMode.丟丛丝七七业丐丞丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业 == 0)
        {
            goto label_10;
        }
        
        float val_4 = this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业.专一丟丏且丆丕丝七();
        if(this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业.丘七业丒丐世丂丅丒() >= 0)
        {
            goto label_10;
        }
        
        if(this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业 == null)
        {
            goto label_11;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业.丘七业丒丐世丂丅丒();
        goto label_12;
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_11:
        val_8 = this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业.丘七业丒丐世丂丅丒();
        label_12:
        float val_7 = 1f;
        val_7 = val_8 + val_7;
        this.丝且与丝丒丟万丁专.丏上丏且丑与丕丆业.上上丘一丁下丕上与(丙业与丙丗丝不丈东:  val_7);
        label_10:
        val_9 = 1;
        this.丗丏丅丕丆世丁专丟 = val_9;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_9;
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
