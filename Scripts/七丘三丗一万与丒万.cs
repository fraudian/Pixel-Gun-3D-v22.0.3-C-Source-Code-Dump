using UnityEngine;
private sealed class HoldPositionsPoint.七丘三丗一万与丒万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public HoldPositionsPoint 丝且与丝丒丟万丁专;
    public int 与丂一三世丑丕丈丂;
    public int 丙一丆丕丑丟丑三丘;
    public float 丝丝丝丛上丈丅丕不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HoldPositionsPoint.七丘三丗一万与丒万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_7;
        int val_8;
        var val_9;
        int val_10;
        var val_11;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 3)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_10;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
            goto label_16;
        }
        
        label_10:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_16:
        if(this.丝且与丝丒丟万丁专.丁丞丗业丆丒上丈丞 <= 0)
        {
            goto label_19;
        }
        
        label_5:
        if(this.丝且与丝丒丟万丁专.丅丆三上丈专丒丂丒.上丕丁丆丈丈丂丑七() == false)
        {
            goto label_21;
        }
        
        val_9 = null;
        val_9 = null;
        this.丝且与丝丒丟万丁专.丁丞丗业丆丒上丈丞 = 丘丑丅三丆丑丌且丝();
        val_8 = 0;
        this.丝且与丝丒丟万丁专.previousCommand = this.与丂一三世丑丕丈丂;
        this.丝且与丝丒丟万丁专.ownerCommand = this.丙一丆丕丑丟丑三丘;
        this.丝且与丝丒丟万丁专.丙丞丛丕丅世下丅丒 = true;
        this.丝且与丝丒丟万丁专.rawCounter = this.丝丝丝丛上丈丅丕不;
        return (bool)val_8;
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_21:
        val_10 = 3;
        this.丒上七丌业七丟与丐 = 0;
        goto label_28;
        label_19:
        val_11 = null;
        val_11 = null;
        this.丝且与丝丒丟万丁专.丁丞丗业丆丒上丈丞 = 丘丑丅三丆丑丌且丝();
        this.丒上七丌业七丟与丐 = 0;
        val_10 = 2;
        label_28:
        this.丗丏丅丕丆世丁专丟 = val_10;
        val_8 = 1;
        return (bool)val_8;
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
