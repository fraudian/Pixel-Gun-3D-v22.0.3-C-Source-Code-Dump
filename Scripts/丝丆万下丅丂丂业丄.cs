using UnityEngine;
private sealed class OpenCloseDoor.丝丆万下丅丂丂业丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public OpenCloseDoor 丝且与丝丒丟万丁专;
    private float 三丂丝不丗丛丁七与;
    private UnityEngine.Vector3 专专专丆丈丌专丛丟;
    private UnityEngine.Quaternion 一丗丑丒丄丛丕世丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OpenCloseDoor.丝丆万下丅丂丂业丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        int val_29;
        UnityEngine.Vector3 val_30;
        UnityEngine.Quaternion val_31;
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
        
        val_24 = this.丝且与丝丒丟万丁专._deltaTime;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        val_24 = 0f;
        label_4:
        float val_24 = System.Math.Abs(val_24 - this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一);
        this.三丂丝不丗丛丁七与 = 0.01f;
        this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一 = 0.01f;
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.transform.localPosition;
        this.专专专丆丈丌专丛丟 = val_3;
        mem[1152921540038328736] = val_3.y;
        mem[1152921540038328740] = val_3.z;
        UnityEngine.Quaternion val_5 = this.丝且与丝丒丟万丁专.transform.localRotation;
        this.一丗丑丒丄丛丕世丟 = val_5;
        mem[1152921540038328748] = val_5.y;
        mem[1152921540038328752] = val_5.z;
        mem[1152921540038328756] = val_5.w;
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专.transform.localPosition;
        bool val_8 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专._closePositionDoor, y = this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Quaternion val_10 = this.丝且与丝丒丟万丁专.transform.localRotation;
        val_26 = val_10.x;
        val_27 = val_10.z;
        bool val_11 = UnityEngine.Quaternion.op_Equality(lhs:  new UnityEngine.Quaternion() {x = this.丝且与丝丒丟万丁专._closeRotationDoor, y = this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一, z = V10.16B, w = val_7.x}, rhs:  new UnityEngine.Quaternion() {x = val_26, y = val_10.y, z = val_27, w = val_10.w});
        label_6:
        val_28 = this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一;
        if(val_28 > 0f)
        {
            goto label_17;
        }
        
        label_2:
        val_29 = 0;
        return (bool)val_29;
        label_17:
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = val_28 - val_12;
        this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一 = val_12;
        val_27 = this.三丂丝不丗丛丁七与;
        val_26 = this.丝且与丝丒丟万丁专._closePositionDoor;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.专专专丆丈丌专丛丟, y = val_7.x, z = this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一}, b:  new UnityEngine.Vector3() {x = val_26, y = V10.16B, z = val_28}, t:  1f - (this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一 / val_27));
        val_28 = val_16.x;
        val_25 = val_16.z;
        this.丝且与丝丒丟万丁专.transform.localPosition = new UnityEngine.Vector3() {x = val_28, y = val_16.y, z = val_25};
        if(this.丝且与丝丒丟万丁专.calculateRotation != false)
        {
                val_31 = this.一丗丑丒丄丛丕世丟;
            val_26 = this.丝且与丝丒丟万丁专._closeRotationDoor;
            val_30 = val_26;
            val_31 = val_31;
            float val_25 = 1f;
            val_25 = val_25 - (this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一 / this.三丂丝不丗丛丁七与);
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_31, y = val_30, z = val_25, w = val_7.x}, b:  new UnityEngine.Quaternion() {x = val_26, y = this.专专专丆丈丌专丛丟, z = this.丝且与丝丒丟万丁专.丝丙一丝丈丂不丙一, w = val_27}, t:  val_25);
            val_28 = val_18.y;
            val_25 = val_18.w;
            if(((System.Single.IsNaN(f:  val_18.x)) != true) && ((System.Single.IsNaN(f:  val_28)) != true))
        {
                if((System.Single.IsNaN(f:  val_18.z)) != true)
        {
                if((System.Single.IsNaN(f:  val_25)) == false)
        {
            goto label_28;
        }
        
        }
        
        }
        
            UnityEngine.Debug.LogError(message:  "NAAAAn");
        }
        
        label_32:
        val_29 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
        label_28:
        this.丝且与丝丒丟万丁专.transform.localRotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_28, z = val_18.z, w = val_25};
        goto label_32;
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
