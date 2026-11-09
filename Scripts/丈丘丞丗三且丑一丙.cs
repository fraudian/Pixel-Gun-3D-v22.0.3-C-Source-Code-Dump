using UnityEngine;
private sealed class ChestBatleRoyale.丈丘丞丗三且丑一丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ChestBatleRoyale 丝且与丝丒丟万丁专;
    private float 上上丄一丙万丟丛丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ChestBatleRoyale.丈丘丞丗三且丑一丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_7;
        var val_8;
        float val_9;
        int val_10;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_8 = val_7;
        this.上上丄一丙万丟丛丄 = 0.5f;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_1:
        val_8 = val_7;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.上上丄一丙万丟丛丄 <= 0f)
        {
                if((this.丝且与丝丒丟万丁专.丄丑专丑丝世丏丘丟.IsPlaying(name:  "Broken")) == false)
        {
            goto label_7;
        }
        
        }
        
        label_4:
        val_9 = this.上上丄一丙万丟丛丄;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_9 - val_2;
        val_10 = 1;
        this.上上丄一丙万丟丛丄 = val_2;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_7:
        val_7 = this.丝且与丝丒丟万丁专.chest;
        UnityEngine.Vector3 val_3 = val_7.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  10000f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_9 = val_6.x;
        val_7.position = new UnityEngine.Vector3() {x = val_9, y = val_6.y, z = val_6.z};
        label_2:
        val_10 = 0;
        return (bool)val_10;
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
