using UnityEngine;
private sealed class WorldPosIndicationItem.丙下丘丅丌上丁上丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丂七上与上不丘丐丛;
    public WorldPosIndicationItem 丝且与丝丒丟万丁专;
    public float 丈丗与丞一上且上上;
    public float 专丂丕丗丗东世丞下;
    public float 丂三丟丂丈丐丆丗丟;
    private float 上上丄一丙万丟丛丄;
    private bool 丏丒丁丘丁丝丂丞丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WorldPosIndicationItem.丙下丘丅丌上丁上丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_3;
        float val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_3 = true;
        this.上上丄一丙万丟丛丄 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丏丒丁丘丁丝丂丞丑 = val_3;
        val_4 = 0f;
        goto label_3;
        label_1:
        bool val_2 = this.丏丒丁丘丁丝丂丞丑;
        val_4 = this.上上丄一丙万丟丛丄;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = val_2 ^ 1;
        this.丏丒丁丘丁丝丂丞丑 = val_3;
        label_3:
        if(this.丂三丟丂丈丐丆丗丟 >= val_4)
        {
            goto label_4;
        }
        
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        val_4 = val_4 + this.丂七上与上不丘丐丛;
        this.上上丄一丙万丟丛丄 = val_4;
        val_2 = val_3 & 255;
        if(val_2 != false)
        {
                if(this.丝且与丝丒丟万丁专._tweenerAlpha != null)
        {
            goto label_9;
        }
        
        }
        
        label_9:
        this.丝且与丝丒丟万丁专._tweenerAlpha.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  this.专丂丕丗丗东世丞下, 专丂丕丗丗东世丞下:  this.丈丗与丞一上且上上, 与丈业丛丝丒丙一丏:  this.丂七上与上不丘丐丛, 丛丆丁业东上丁丆丘:  0);
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丂七上与上不丘丐丛);
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
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
