using UnityEngine;
private sealed class BaseCapturePoint.丕丕丘不丌上丒不丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BaseCapturePoint 丝且与丝丒丟万丁专;
    public int 与丂一三世丑丕丈丂;
    public int 丙一丆丕丑丟丑三丘;
    public int 丝丑丏业七不丆丁且;
    public float 丝丝丝丛上丈丅丕不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseCapturePoint.丕丕丘不丌上丒不丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        int val_6;
        float val_7;
        var val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_6;
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
            goto label_12;
        }
        
        label_6:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_12:
        if(this.丝且与丝丒丟万丁专.myCommand < 1)
        {
            goto label_16;
        }
        
        this.丝且与丝丒丟万丁专.previousCommand = this.与丂一三世丑丕丈丂;
        this.丝且与丝丒丟万丁专.ownerCommand = this.丙一丆丕丑丟丑三丘;
        this.丝且与丝丒丟万丁专.lastCaptureCommand = this.丝丑丏业七不丆丁且;
        if(this.丝丑丏业七不丆丁且 != this.丝且与丝丒丟万丁专.myCommand)
        {
            goto label_17;
        }
        
        val_7 = System.Math.Abs(this.丝丝丝丛上丈丅丕不);
        goto label_20;
        label_14:
        val_6 = 0;
        return (bool)val_6;
        label_16:
        val_8 = null;
        val_8 = null;
        this.丝且与丝丒丟万丁专.myCommand = 丘丑丅三丆丑丌且丝();
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
        label_17:
        val_7 = -System.Math.Abs(this.丝丝丝丛上丈丅丕不);
        label_20:
        val_6 = 0;
        this.丝且与丝丒丟万丁专.captureCounter = val_7;
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
