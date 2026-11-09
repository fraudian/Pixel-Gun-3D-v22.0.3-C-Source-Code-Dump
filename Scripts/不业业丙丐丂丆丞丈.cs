using UnityEngine;
private sealed class BaseOfferPackDrawer.不业业丙丐丂丆丞丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.BaseOfferPackDrawer 丝且与丝丒丟万丁专;
    private UnityEngine.Vector3 丌丘丁丞丕一丛丗丑;
    private float 丒东丞业且丑丈下丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseOfferPackDrawer.不业业丙丐丂丆丞丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        int val_10;
        UnityEngine.Vector3 val_11;
        float val_12;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丌东业丙丞丟丄且与 = true;
        goto label_4;
        label_1:
        val_8 = this;
        var val_1 = (this.丒东丞业且丑丈下丈 > 1f) ? 1 : 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_3:
        mem[40] = 1;
        label_4:
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专._windowObject.transform.position;
        val_8 = this;
        this.丒东丞业且丑丈下丈 = 0f;
        val_9 = 0;
        mem[1152921543282108200] = val_3.x;
        mem[1152921543282108204] = val_3.y;
        mem[1152921543282108208] = val_3.z;
        label_6:
        UnityEngine.Transform val_4 = this.丝且与丝丒丟万丁专._windowObject.transform;
        if(val_9 != 0)
        {
                val_11 = this.丝且与丝丒丟万丁专.丘丕丒丌丆业丕丙丅;
            val_4.position = new UnityEngine.Vector3() {x = val_11, y = V9.16B, z = V10.16B};
            val_10 = 0;
            this.丝且与丝丒丟万丁专.丌东业丙丞丟丄且与 = false;
            return (bool)val_10;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丌丘丁丞丕一丛丗丑, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.丘丕丒丌丆业丕丙丅, y = V13.16B, z = V11.16B}, t:  this.丒东丞业且丑丈下丈);
        val_12 = val_5.z;
        val_4.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_12};
        val_11 = this.丒东丞业且丑丈下丈;
        float val_6 = UnityEngine.Time.deltaTime;
        float val_8 = 1f;
        val_8 = val_8 / this.丝且与丝丒丟万丁专._animationTime;
        val_6 = val_8 * val_6;
        val_6 = val_11 + val_6;
        this.丒东丞业且丑丈下丈 = val_6;
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_10;
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
