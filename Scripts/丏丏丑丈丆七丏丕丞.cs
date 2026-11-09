using UnityEngine;
private sealed class SquareFieldTouch.丏丏丑丈丆七丏丕丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SquareFieldTouch 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SquareFieldTouch.丏丏丑丈丆七丏丕丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SquareFieldTouch val_6;
        SquareFieldCell val_7;
        UnityEngine.Vector3 val_8;
        object val_11;
        int val_12;
        var val_13;
        SquareField val_14;
        val_6 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.draggingCell == 0)
        {
            goto label_7;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.draggingCell;
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.draggingCell._coordinate;
        goto label_19;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForEndOfFrame val_2 = null;
        val_11 = val_2;
        val_2 = new UnityEngine.WaitForEndOfFrame();
        val_12 = 2;
        goto label_10;
        label_3:
        val_13 = 0;
        return (bool)val_13;
        label_7:
        val_6 = 1152921505266057216;
        if(SquareField.丄丘七三上丕世丞业.万七丐丅丐世业业丆 == 0)
        {
            goto label_15;
        }
        
        val_14 = SquareField.丄丘七三上丕世丞业;
        if(SquareField.丄丘七三上丕世丞业 != null)
        {
            goto label_16;
        }
        
        val_14 = SquareField.丄丘七三上丕世丞业;
        if(val_14 == null)
        {
            goto label_17;
        }
        
        label_16:
        val_6 = mem[SquareField.丄丘七三上丕世丞业 + 104];
        val_6 = SquareField.丄丘七三上丕世丞业.万七丐丅丐世业业丆;
        val_7 = mem[SquareField.丄丘七三上丕世丞业 + 104];
        val_7 = SquareField.丄丘七三上丕世丞业.万七丐丅丐世业业丆;
        if(null != 0)
        {
            goto label_19;
        }
        
        goto label_20;
        label_8:
        val_8 = this.丝且与丝丒丟万丁专.draggingCell._coordinate;
        label_20:
        label_19:
        UnityEngine.Vector3 val_4 = val_7.且世丅专七一丙丛丁(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8, y = V9.16B, z = V10.16B});
        label_15:
        UnityEngine.WaitForSeconds val_5 = null;
        val_11 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_12 = 1;
        label_10:
        val_13 = 1;
        this.丒上七丌业七丟与丐 = val_11;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_13;
        label_17:
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
