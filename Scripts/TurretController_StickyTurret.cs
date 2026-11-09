using UnityEngine;
internal sealed class TurretController_StickyTurret : TurretController_Tower
{
    // Fields
    private UnityEngine.Transform rotateObject;
    private UnityEngine.Transform movementObject;
    private UnityEngine.Transform dublicateTower;
    private float radiusDetectForPlacement;
    private UnityEngine.Transform aimObject;
    private float deltaDistance;
    private UnityEngine.Transform[] rayGroundPoints;
    private StickyTurretShot stickyTurretShot;
    private bool 丂丂丏丄丗丞丌东丆;
    protected 丅丙上七上一丐不下 丕不丝丛丌丁万上万;
    private SelfExplosionComponent selfExplosion;
    private bool 且丐丁丂且上一丝丗;
    private float deltaRotateSpeed;
    
    // Methods
    protected override void 丏且上丌丘丈世丂世(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        if(W8 == 0)
        {
                this.rotateObject.rotation = new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w};
        }
        
        this.丏且上丌丘丈世丂世();
    }
    public override void StartTurret()
    {
        var val_6;
        this.且丐丁丂且上一丝丗 = false;
        val_6 = null;
        val_6 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (W10 == 0))
        {
            goto label_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_24;
        }
        
        object[] val_1 = new object[1];
        UnityEngine.Quaternion val_2 = this.rotateObject.rotation;
        val_1[0] = val_2;
        七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  104, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_1);
        goto label_24;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                this.丏且上丌丘丈世丂世();
        }
        
        label_24:
        enabled = true;
        mem[1152921540161979532] = 1074580685;
        UnityEngine.Vector3 val_4 = this.movementObject.position;
        1152921540161979532.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.movementObject.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        float val_8;
        float val_9;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = S8 - val_1;
        mem[1152921540162121104] = val_1;
        if(val_1 < 0)
        {
                mem[1152921540162121104] = true;
            if(W9 == 0)
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this);
        }
        
        }
        
        float val_10 = 0.5f;
        if(System.Math.Abs(S8) < 0)
        {
                float val_9 = -0.5f;
            val_9 = S2 * val_9;
            val_10 = S2 * val_10;
            mem[1152921540162121224] = UnityEngine.Random.Range(min:  val_9, max:  val_10);
            return;
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        val_9 = V10.16B;
        val_9 = V10.16B;
        float val_11 = System.Math.Abs(S10);
        val_11 = (val_12 * S9) * val_11;
        val_12 = val_11 / val_9;
        val_9 = val_9 - val_12;
        mem[1152921540162121224] = val_9;
        UnityEngine.Quaternion val_6 = localRotation;
        val_6.y = val_12 + val_6.y;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_8 = val_7.x;
        localRotation = new UnityEngine.Quaternion() {x = val_8, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    protected override void 东丅下世丏专丝东丝()
    {
        UnityEngine.Transform val_17;
        var val_18;
        float val_19;
        var val_20;
        var val_23;
        if(this.丂丂丏丄丗丞丌东丆 != false)
        {
                val_17 = this.aimObject;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            UnityEngine.Transform val_1 = Player_move_c.不丙丞丂丗丙丄丙丛.transform;
            this.aimObject = val_1;
            if(val_1 == 0)
        {
                return;
        }
        
            val_17 = this.aimObject;
            this.丂丂丏丄丗丞丌东丆 = true;
        }
        
        UnityEngine.Vector3 val_3 = mem[this.aimObject].position;
        UnityEngine.Vector3 val_4 = mem[this.aimObject].forward;
        val_19 = this.deltaDistance;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_19, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) == false)
        {
            goto label_36;
        }
        
        this.movementObject.position = new UnityEngine.Vector3() {x = val_19, y = val_3.y, z = val_3.z};
        val_19 = val_19;
        this.rotateObject.up = new UnityEngine.Vector3() {x = val_19, y = val_3.y, z = val_3.z};
        val_20 = 0;
        goto label_16;
        label_38:
        val_17 = 0;
        UnityEngine.Vector3 val_7 = this.rayGroundPoints[val_17].position;
        UnityEngine.Vector3 val_8 = this.rayGroundPoints[val_17].forward;
        val_19 = this.radiusDetectForPlacement;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_19, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) == false)
        {
            goto label_36;
        }
        
        丅丙上七上一丐不下 val_11 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_11 == null)
        {
            goto label_24;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_17 = val_11.transform;
        if((val_17.CompareTag(tag:  "Player")) == true)
        {
            goto label_36;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        if((val_11.transform.CompareTag(tag:  "Enemy")) == true)
        {
            goto label_36;
        }
        
        label_24:
        val_20 = 1;
        label_16:
        if(val_20 < this.rayGroundPoints.Length)
        {
            goto label_38;
        }
        
        val_23 = 1;
        goto label_39;
        label_36:
        val_23 = 0;
        label_39:
        this.下丏专丑丂专丁下丝(丝世丏丑专丄丒业丏:  false);
    }
    private void 下丏专丑丂专丁下丝(bool 丝世丏丑专丄丒业丏)
    {
        float val_5;
        var val_6;
        if(丝世丏丑专丄丒业丏 != false)
        {
                val_5 = 0.08f;
            val_6 = 1f;
        }
        else
        {
                val_5 = 0.08f;
            val_6 = 0f;
        }
        
        this.materials[0].SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        UIButton val_3 = GetComponent<UIButton>();
        bool val_4 = 丝世丏丑专丄丒业丏;
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(this.stickyTurretShot != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.stickyTurretShot.丅丙业不丏丟丄丕丝(丞下万上三丘上与专:  X21, 业丏东三丄东且丈万:  V8.16B, 丛世一丟丞丁业丘丒:  this, 丆丈丅上丙业丌且丅:  137129984, 丌且下丕下下丌万丞:  (1152921505171275776 != 0) ? 1 : 0);
        return;
        label_3:
        if(this.stickyTurretShot != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_6;
        if(137129984 == 0)
        {
                this.丕不丝丛丌丁万上万 = 0;
            return;
        }
        
        if(this.丕不丝丛丌丁万上万 == null)
        {
                this.丕不丝丛丌丁万上万 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        }
        
        this.丄一一丌丙丂丌东丟();
        if(this.丄上上不丛万丝不一() == false)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = S8 - val_4;
        mem[1152921540162995300] = val_4;
        if(val_4 >= 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_12;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_17;
        }
        
        七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        goto label_17;
        label_12:
        this.世且丂丕丐丝丐丐且();
        label_17:
        mem[1152921540162995300] = 与丂丏丛丞丞丒丟丄.__il2cppRuntimeField_static_fields;
    }
    protected void 丄一一丌丙丂丌东丟()
    {
        this.dublicateTower.LookAt(target:  X21);
        UnityEngine.Quaternion val_1 = this.dublicateTower.localRotation;
        UnityEngine.Quaternion val_2 = this.dublicateTower.localRotation;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_3 * this.deltaRotateSpeed;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, b:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, t:  val_3);
        this.dublicateTower.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
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
    protected bool 丄上上不丛万丝不一()
    {
        var val_16;
        var val_17;
        val_16 = this;
        if(137129984 == 0)
        {
                val_17 = 0;
            return (bool)((System.Math.Abs(this.丐丟丅东且东丑丄丞(丅丝东三专且上丁业:  val_9.y, 丕东丑丂丅丈丆专丁:  val_12 = val_12 * (UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, to:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}))))) < 0) ? 1 : 0;
        }
        
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_3.z);
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_5.x, y:  val_6.z);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        UnityEngine.Quaternion val_9 = this.rotation;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.up;
        float val_12 = System.Math.Abs(val_8.x) / val_8.x;
        float val_14 = UnityEngine.Time.deltaTime;
        return (bool)((System.Math.Abs(this.丐丟丅东且东丑丄丞(丅丝东三专且上丁业:  val_9.y, 丕东丑丂丅丈丆专丁:  val_12))) < 0) ? 1 : 0;
    }
    protected override void 丕丕丞不丆业东下丒()
    {
        this.丕丕丞不丆业东下丒();
        if(this.且丐丁丂且上一丝丗 != false)
        {
                return;
        }
        
        this.且丐丁丂且上一丝丗 = true;
        this.selfExplosion.丐丟丐专丙一丄业丟(丌且下丕下下丌万丞:  X21.isMine, 丌丑丛业丈丘世丞丕:  X21, 业丞业一丒丛丝且专:  V8.16B);
    }
    public TurretController_StickyTurret()
    {
        this.radiusDetectForPlacement = 1f;
        this.deltaDistance = 4f;
        this.deltaRotateSpeed = 1f;
        mem[1152921540163624908] = ;
        mem[1152921540163624924] = 1130102784;
        val_1 = new TurretController();
    }

}
