using UnityEngine;
private sealed class SpeedrunTrackController.东丅丌丟东万丂万专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丌丄七丒丁丆丘丝业;
    public UnityEngine.Vector3 丅专与丒丈丗丒丘丌;
    public SpeedrunTrackController 丝且与丝丒丟万丁专;
    private Player_move_c 丐业丒丟一世丂一丒;
    private bool 丈七丛丞丙一丟万专;
    private bool 上万丒丝与丒不业丐;
    private UnityEngine.Vector3 丈一丟丑下丝丛下一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpeedrunTrackController.东丅丌丟东万丂万专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.CharacterController val_20;
        int val_21;
        var val_22;
        bool val_23;
        float val_26;
        UnityEngine.Vector3 val_28;
        float val_29;
        float val_30;
        val_20 = this;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_21 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_21;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            val_22 = null;
            val_22 = null;
            this.丐业丒丟一世丂一丒 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 216.enabled = false;
            this.丐业丒丟一世丂一丒.mySkinName.firstPersonControl.丗一丈世业七丆丄万();
            this.丐业丒丟一世丂一丒.万丘专一万丛万丙丆(丐上不业丐丕丅丆与:  true);
            this.丐业丒丟一世丂一丒.一丒三丄不丙丆丄丛(丐上不业丐丕丅丆与:  true);
            val_23 = val_20;
            this.丈七丛丞丙一丟万专 = true;
            this.上万丒丝与丒不业丐 = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  -8f);
            this.丈一丟丑下丝丛下一 = val_2;
            mem[1152921540334341448] = val_2.y;
            mem[1152921540334341452] = val_2.z;
        }
        else
        {
                val_23 = this.丈七丛丞丙一丟万专;
            this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        if(val_23 == false)
        {
            goto label_18;
        }
        
        if(this.上万丒丝与丒不业丐 == true)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_3 = this.丐业丒丟一世丂一丒.myPlayerTransform.position;
        if(val_3.y >= 0)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  18f);
        val_26 = val_5.y;
        float val_7 = UnityEngine.Time.deltaTime * 4f;
        val_28 = this.丈一丟丑下丝丛下一;
        val_29 = V8.16B;
        val_30 = V9.16B;
        goto label_25;
        label_22:
        this.上万丒丝与丒不业丐 = true;
        UnityEngine.Vector3 val_8 = this.丐业丒丟一世丂一丒.myPlayerTransform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丅专与丒丈丗丒丘丌, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  18f);
        val_26 = val_10.z;
        val_28 = this.丈一丟丑下丝丛下一;
        val_29 = V9.16B;
        val_30 = V10.16B;
        label_25:
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_26}, t:  UnityEngine.Time.deltaTime * 4f);
        this.丈一丟丑下丝丛下一 = val_13;
        mem[1152921540334341448] = val_13.y;
        mem[1152921540334341452] = val_13.z;
        UnityEngine.Vector3 val_14 = this.丐业丒丟一世丂一丒.myPlayerTransform.position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丈一丟丑下丝丛下一, y = val_26, z = V13.16B}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.丐业丒丟一世丂一丒.myPlayerTransform.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_18 = this.丐业丒丟一世丂一丒.myPlayerTransform.position;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丅专与丒丈丗丒丘丌, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        if(val_19.x < 0)
        {
                mem2[0] = 0;
        }
        
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_18:
        this.丐业丒丟一世丂一丒.一丒三丄不丙丆丄丛(丐上不业丐丕丅丆与:  false);
        this.丐业丒丟一世丂一丒.万丘专一万丛万丙丆(丐上不业丐丕丅丆与:  false);
        this.丐业丒丟一世丂一丒.mySkinName.firstPersonControl.丗一丈世业七丆丄万();
        val_20 = this.丐业丒丟一世丂一丒.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万;
        val_20.enabled = true;
        val_21 = 0;
        this.丝且与丝丒丟万丁专.丁丟东七与丏丙丗丙 = false;
        return (bool)val_21;
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
