using UnityEngine;
internal class WeaponTargetDetectorCompass : WeaponTargetDetectorBase
{
    // Fields
    public bool useIdleRotation;
    public TweenRotation idleRotation;
    public UnityEngine.Transform compassNeedle;
    public UnityEngine.Transform[] compassNeedles;
    public float rotationSpeed;
    private float 一不丅与丟丌丏丟东;
    private bool 万与丄丌世丈七上一;
    
    // Methods
    internal override void 不上丆东丘丌丄丛且(UnityEngine.Transform 丞下万上三丘上与专, float 专世丂丆专业丌丈丈)
    {
        var val_22;
        var val_23;
        if(丞下万上三丘上与专 == 0)
        {
            goto label_3;
        }
        
        if(this.useIdleRotation == false)
        {
            goto label_4;
        }
        
        this.idleRotation.enabled = false;
        goto label_6;
        label_3:
        if(this.useIdleRotation == false)
        {
            goto label_7;
        }
        
        if(this.idleRotation.enabled != true)
        {
                UnityEngine.Quaternion val_3 = this.compassNeedle.localRotation;
            val_22 = 1152921504838369280;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  V12.16B);
            if((UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, b:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) > 3f)
        {
                UnityEngine.Quaternion val_6 = this.compassNeedle.localRotation;
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  V12.16B);
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_8 * this.rotationSpeed;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, b:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, t:  val_8);
            this.compassNeedle.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            return;
        }
        
        }
        
        this.idleRotation.quaternionLerp = true;
        if(this.万与丄丌世丈七上一 != false)
        {
                this.idleRotation.PlayForward();
            this.万与丄丌世丈七上一 = false;
        }
        
        this.idleRotation.enabled = true;
        return;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.compassNeedle, 丏业丟一东丂东丘丛:  true);
        label_6:
        val_23 = null;
        val_23 = null;
        UnityEngine.Vector3 val_11 = typeof(Player_move_c).__il2cppRuntimeField_628.transform.forward;
        UnityEngine.Vector3 val_12 = 丞下万上三丘上与专.position;
        UnityEngine.Vector3 val_14 = typeof(Player_move_c).__il2cppRuntimeField_628.transform.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
        this.一不丅与丟丌丏丟东 = CompasController.东东丂七专丁丆丛丁(一不丝丟世业丑丙一:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 丘丑丛丕下丈世下丂:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.z, z = ???});
        UnityEngine.Quaternion val_18 = this.compassNeedle.localRotation;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  this.一不丅与丟丌丏丟东);
        float val_20 = UnityEngine.Time.deltaTime;
        val_20 = val_20 * this.rotationSpeed;
        UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, b:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, t:  val_20);
        this.compassNeedle.localRotation = new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w};
        this.万与丄丌世丈七上一 = true;
        return;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.compassNeedle, 丏业丟一东丂东丘丛:  false);
    }
    internal override void 不上丆东丘丌丄丛且(System.Collections.Generic.List<UnityEngine.Transform> 丌业丅丒丛且万丛丒)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        UnityEngine.Transform[] val_26;
        val_20 = this;
        val_21 = 1152921505286238208;
        val_22 = UnityEngine.Mathf.Min(a:  丌业丅丒丛且万丛丒.Count, b:  137129984);
        val_23 = null;
        val_23 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        UnityEngine.Transform val_5 = typeof(Player_move_c).__il2cppRuntimeField_628.transform;
        if(val_22 > 0)
        {
                val_26 = this.compassNeedles;
            do
        {
            UnityEngine.Vector3 val_6 = val_5.forward;
            UnityEngine.Vector3 val_8 = 丌业丅丒丛且万丛丒.Item[0].position;
            UnityEngine.Vector3 val_9 = val_5.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            this.一不丅与丟丌丏丟东 = CompasController.东东丂七专丁丆丛丁(一不丝丟世业丑丙一:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丘丑丛丕下丈世下丂:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = ???});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.compassNeedles[0], 丏业丟一东丂东丘丛:  true);
            var val_13 = mem[this.compassNeedles] + 0;
            var val_14 = mem[this.compassNeedles] + 0;
            UnityEngine.Quaternion val_15 = (mem[this.compassNeedles] + 0) + 32.localRotation;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  this.一不丅与丟丌丏丟东);
            float val_17 = UnityEngine.Time.deltaTime;
            val_17 = val_17 * this.rotationSpeed;
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w}, b:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w}, t:  val_17);
            (mem[this.compassNeedles] + 0) + 32.localRotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
            val_21 = 0 + 1;
            this.万与丄丌世丈七上一 = true;
        }
        while(val_22 != val_21);
        
        }
        else
        {
                val_26 = this.compassNeedles;
        }
        
        val_20 = 1152921505284374528;
        goto label_41;
        label_47:
        var val_19 = mem[this.compassNeedles] + (((long)(int)(val_2)) << 3);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  (mem[this.compassNeedles] + ((long)(int)(val_2)) << 3) + 32, 丏业丟一东丂东丘丛:  false);
        val_22 = val_22 + 1;
        label_41:
        if(val_22 < (mem[this.compassNeedles] + 24))
        {
            goto label_47;
        }
    
    }
    public WeaponTargetDetectorCompass()
    {
        this.useIdleRotation = true;
        this.rotationSpeed = 8f;
        mem[1152921540327601240] = true;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
