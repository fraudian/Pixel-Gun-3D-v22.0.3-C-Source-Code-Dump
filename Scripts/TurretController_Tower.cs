using UnityEngine;
internal class TurretController_Tower : TurretController
{
    // Fields
    public UnityEngine.Transform tower;
    public UnityEngine.Transform gun;
    protected float 丈丈丌不丏丘丞丐一;
    protected float 业世丗专丘丟三丐丕;
    protected float 丝丙丙丑丄丁丕丂丈;
    private float 丗丅万业丞七丆一万;
    private float 不且丐丄丙丈丒且丛;
    protected float 东专与七万丌万丗七;
    protected float 丅下丆丘丆丝丄一丑;
    protected float 丈三丐且丝上丙丐丙;
    
    // Methods
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        this.丈丞一丈丑丝丈丂丂();
        if(System.Math.Abs(this.丈丈丌不丏丘丞丐一) < 0)
        {
                val_11 = this.丝丙丙丑丄丁丕丂丈;
            val_12 = val_11 * (-0.5f);
            val_13 = val_11 * 0.5f;
            this.丈丈丌不丏丘丞丐一 = UnityEngine.Random.Range(min:  val_12, max:  val_13);
        }
        else
        {
                float val_13 = UnityEngine.Time.deltaTime;
            val_14 = this.丈丈丌不丏丘丞丐一;
            val_14 = this.丈丈丌不丏丘丞丐一;
            val_14 = this.丈丈丌不丏丘丞丐一;
            float val_12 = System.Math.Abs(this.丈丈丌不丏丘丞丐一);
            val_12 = (val_13 * this.业世丗专丘丟三丐丕) * val_12;
            val_13 = val_12 / val_14;
            val_14 = val_14 - val_13;
            this.丈丈丌不丏丘丞丐一 = val_14;
            UnityEngine.Quaternion val_4 = this.tower.localRotation;
            val_4.z = val_13 + val_4.z;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15 = val_5.z;
            val_12 = val_5.x;
            val_13 = val_5.y;
            val_11 = val_15;
            this.tower.localRotation = new UnityEngine.Quaternion() {x = val_12, y = val_13, z = val_11, w = val_5.w};
        }
        
        UnityEngine.Quaternion val_6 = this.gun.localRotation;
        val_16 = 1f;
        if(System.Math.Abs(val_6.x) <= val_16)
        {
                return;
        }
        
        UnityEngine.Quaternion val_7 = this.gun.localRotation;
        val_16 = UnityEngine.Time.deltaTime;
        float val_10 = this.丅下丆丘丆丝丄一丑 * ((val_7.x < 0) ? -1f : (val_16));
        val_10 = val_16 * val_10;
        this.gun.Rotate(xAngle:  val_10, yAngle:  0f, zAngle:  0f);
    }
    protected override System.Collections.IEnumerator 丗丅世且丛丑业世丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_Tower.丕不与丗业丝丌丈丏();
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        float val_25;
        var val_26;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        this.丟丞丆上上丁丅下丐();
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_2.z);
        UnityEngine.Vector3 val_4 = this.tower.position;
        UnityEngine.Vector3 val_5 = this.tower.position;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_5.z);
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Quaternion val_8 = this.tower.rotation;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.up;
        val_25 = val_7.x;
        float val_11 = System.Math.Abs(val_7.x) / val_7.x;
        val_11 = val_11 * (UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, to:  new UnityEngine.Vector2() {x = val_25, y = val_7.y}));
        float val_27 = this.东专与七万丌万丗七;
        float val_29 = this.丐丟丅东且东丑丄丞(丅丝东三专且上丁业:  val_8.y, 丕东丑丂丅丈丆专丁:  val_11);
        float val_13 = UnityEngine.Time.deltaTime;
        val_26 = null;
        float val_26 = System.Math.Abs(val_29);
        val_13 = val_27 * val_13;
        val_13 = -(val_26 * val_13);
        val_27 = val_13 / val_29;
        val_26 = null;
        val_29 = (System.Math.Abs(val_27) > val_26) ? (-val_29) : (val_27);
        val_28 = 0.001f;
        val_29 = System.Math.Abs(val_29);
        if(val_29 > val_28)
        {
                val_29 = 0f;
            val_28 = 0f;
            val_25 = val_29;
            this.tower.Rotate(xAngle:  val_29, yAngle:  val_28, zAngle:  val_25);
        }
        
        UnityEngine.Vector3 val_14 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  this.tower);
        float val_30 = val_14.y;
        UnityEngine.Vector3 val_15 = this.tower.position;
        UnityEngine.Vector3 val_17 = this.transform.position;
        float val_19 = val_30 - val_15.y;
        val_19 = val_19 / (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_30, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}));
        val_19 = val_19 * (-180f);
        val_30 = val_19 / 3.141593f;
        UnityEngine.Quaternion val_20 = this.gun.localRotation;
        float val_33 = val_20.x.丐丟丅东且东丑丄丞(丅丝东三专且上丁业:  val_20.x, 丕东丑丂丅丈丆专丁:  val_30);
        float val_22 = UnityEngine.Time.deltaTime;
        float val_31 = System.Math.Abs(val_33);
        val_22 = this.丅下丆丘丆丝丄一丑 * val_22;
        val_22 = -(val_31 * val_22);
        val_22 = val_22 / val_33;
        val_33 = (System.Math.Abs(val_22) > val_31) ? (-val_33) : (val_22);
        if(System.Math.Abs(val_33) > val_28)
        {
                this.gun.Rotate(xAngle:  val_33, yAngle:  0f, zAngle:  0f);
        }
        
        if(val_26 >= 0)
        {
                return;
        }
        
        val_30 = this.丈三丐且丝上丙丐丙;
        float val_23 = UnityEngine.Time.deltaTime;
        val_23 = val_30 - val_23;
        this.丈三丐且丝上丙丐丙 = val_23;
        if(val_23 >= 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_33;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_38;
        }
        
        七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        goto label_38;
        label_33:
        this.世且丂丕丐丝丐丐且();
        label_38:
        this.丈三丐且丝上丙丐丙 = 与丂丏丛丞丞丒丟丄.__il2cppRuntimeField_static_fields;
    }
    private float 丐丟丅东且东丑丄丞(float 丅丝东三专且上丁业, float 丕东丑丂丅丈丆专丁)
    {
        float val_3;
        float val_3 = 丅丝东三专且上丁业;
        丅丝东三专且上丁业 = val_3 + 360f;
        val_3 = (val_3 < 0) ? (丅丝东三专且上丁业) : (val_3);
        float val_2 = (丕东丑丂丅丈丆专丁 < 0) ? (丕东丑丂丅丈丆专丁 + 360f) : 丕东丑丂丅丈丆专丁;
        val_3 = val_3 - val_2;
        if(System.Math.Abs(val_3) <= 180f)
        {
                return (float)val_3;
        }
        
        if(val_3 > val_2)
        {
                val_3 = val_3 + (-360f);
            return (float)val_3;
        }
        
        val_3 = val_3 + 360f;
        return (float)val_3;
    }
    protected override void 丕丕丞不丆业东下丒()
    {
        UnityEngine.Quaternion val_1 = this.gun.rotation;
        if(val_1.x <= this.不且丐丄丙丈丒且丛)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丅下丆丘丆丝丄一丑 * val_2;
        this.gun.Rotate(xAngle:  val_2, yAngle:  0f, zAngle:  0f);
    }
    protected override void 下专专专丄世丗且丐()
    {
        this.下专专专丄世丗且丐();
    }
    public TurretController_Tower()
    {
        mem2[0] = ;
        mem2[0] = 1130102784;
    }

}
