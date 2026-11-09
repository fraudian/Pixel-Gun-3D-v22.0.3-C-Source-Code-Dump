using UnityEngine;
internal class TurretControllerScene_Tower : TurretControllerScene
{
    // Fields
    public UnityEngine.Transform tower;
    public UnityEngine.Transform gun;
    private UnityEngine.Transform 丆丄丞丐丐万一丒丌;
    private bool 丙丒丕下万丛专与丐;
    private UnityEngine.Transform 丄丝与丘不专下且丒;
    private bool 丕七丛与丅不丞与丁;
    public UnityEngine.Transform forwardFirst;
    public UnityEngine.Transform forwardSecond;
    public UnityEngine.Transform shootingPoint;
    protected bool 丙丑丁丆丌且不专丑;
    private float 丈丈丌不丏丘丞丐一;
    private float 业世丗专丘丟三丐丕;
    private float 丝丙丙丑丄丁丕丂丈;
    private float 丑一东东与丄丟丒业;
    private float 丗丅万业丞七丆一万;
    private float 不且丐丄丙丈丒且丛;
    protected float 东专与七万丌万丗七;
    protected float 丅下丆丘丆丝丄一丑;
    protected float 业丞丈专丏丑下万下;
    protected float 丈三丐且丝上丙丐丙;
    protected float 丆丛一三世与丙三丏;
    protected bool 丅丙丂丌丄丟丌丅丝;
    private UnityEngine.Quaternion 业专丑丐丕专丟丆丆;
    private UnityEngine.Quaternion 丄丌业不不丆丙丈丑;
    
    // Methods
    private void 不丁丛不丐丅丒不三()
    {
        bool val_8;
        bool val_9;
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        this.丆丄丞丐丐万一丒丌 = 0;
        if(this.tower != 0)
        {
                val_8 = UnityEngine.Object.op_Inequality(x:  this.丆丄丞丐丐万一丒丌, y:  0);
        }
        else
        {
                val_8 = false;
        }
        
        this.丙丒丕下万丛专与丐 = val_8;
        this.丄丝与丘不专下且丒 = 0;
        if(this.gun != 0)
        {
                val_9 = UnityEngine.Object.op_Inequality(x:  this.丄丝与丘不专下且丒, y:  0);
        }
        else
        {
                val_9 = false;
        }
        
        this.丕七丛与丅不丞与丁 = val_9;
    }
    protected override void Start()
    {
        this.Start();
        this.丙丑丁丆丌且不专丑 = UnityEngine.Object.op_Inequality(x:  this.shootingPoint, y:  0);
        this.不丁丛不丐丅丒不三();
        float val_4 = this.业丞丈专丏丑下万下;
        val_4 = val_4 * 0.8f;
        this.业丞丈专丏丑下万下 = val_4;
        if(this.gun != 0)
        {
                return;
        }
        
        this.丅丙丂丌丄丟丌丅丝 = true;
    }
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        UnityEngine.Transform val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        this.丈丞一丈丑丝丈丂丂();
        if(true != 0)
        {
                UnityEngine.Vector3 val_1 = this.tower.localEulerAngles;
            val_28 = 1152921504838422528;
            float val_28 = -360f;
            val_28 = val_1.z + val_28;
            float val_2 = (val_1.z > 180f) ? (val_28) : val_1.z;
            if(System.Math.Abs(val_2) > this.丆丛一三世与丙三丏)
        {
                val_29 = val_2 * this.东专与七万丌万丗七;
            val_30 = System.Math.Abs(val_29);
            val_31 = this.业世丗专丘丟三丐丕 * 0.5f;
            if(val_30 > val_31)
        {
                val_30 = this.业世丗专丘丟三丐丕;
            val_31 = (UnityEngine.Mathf.Sign(f:  val_29)) * val_30;
            val_29 = val_31 * 0.5f;
        }
        
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            val_32 = val_4.y;
            this.tower.Rotate(axis:  new UnityEngine.Vector3() {x = val_4.x, y = val_32, z = val_4.z}, angle:  -(val_29 * UnityEngine.Time.deltaTime));
            this.丑丄与下丑丅丘业丅();
            float val_30 = this.丆丛一三世与丙三丏;
            val_33 = UnityEngine.Mathf.Sign(f:  val_29);
            val_30 = val_30 + val_30;
            float val_9 = UnityEngine.Random.Range(min:  val_30 * 0.5f, max:  val_30);
            val_9 = -(val_33 * val_9);
            this.丈丈丌不丏丘丞丐一 = val_9;
            return;
        }
        
        }
        
        val_33 = this.丈丈丌不丏丘丞丐一;
        if(System.Math.Abs(val_33) < 0)
        {
                val_34 = this.丝丙丙丑丄丁丕丂丈;
            float val_10 = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished != 0) ? 1f : 0.5f;
            val_35 = val_34 * val_10;
            val_36 = -(val_34 * val_10);
            this.丈丈丌不丏丘丞丐一 = UnityEngine.Random.Range(min:  val_36, max:  val_35);
        }
        else
        {
                float val_33 = this.丈丈丌不丏丘丞丐一;
            val_37 = val_33;
            val_37 = val_33;
            val_37 = this.丈丈丌不丏丘丞丐一;
            float val_32 = System.Math.Abs(val_33);
            val_32 = (UnityEngine.Time.deltaTime * this.业世丗专丘丟三丐丕) * val_32;
            val_33 = val_32 / val_37;
            val_37 = val_37 - val_33;
            this.丈丈丌不丏丘丞丐一 = val_37;
            UnityEngine.Quaternion val_14 = this.tower.localRotation;
            UnityEngine.Quaternion val_15 = this.tower.localRotation;
            val_28 = this.tower;
            UnityEngine.Quaternion val_16 = val_28.localRotation;
            val_16.z = val_33 + val_16.z;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_33 = val_17.x;
            val_32 = val_17.z;
            val_36 = val_33;
            val_35 = val_17.y;
            val_34 = val_32;
            this.tower.localRotation = new UnityEngine.Quaternion() {x = val_36, y = val_35, z = val_34, w = val_17.w};
            this.丑丄与下丑丅丘业丅();
        }
        
        if(this.gun == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_19 = this.gun.localRotation;
        val_33 = UnityEngine.Mathf.DeltaAngle(current:  val_19.x, target:  0f);
        val_32 = System.Math.Abs(val_33);
        if(val_32 <= 1f)
        {
                return;
        }
        
        val_38 = this.丅下丆丘丆丝丄一丑 * UnityEngine.Time.deltaTime;
        if(val_32 > val_38)
        {
                float val_22 = UnityEngine.Time.deltaTime;
            val_22 = this.丑一东东与丄丟丒业 * val_22;
            val_38 = -(val_32 * val_22);
            val_39 = val_38 / val_33;
        }
        else
        {
                val_39 = -val_33;
        }
        
        UnityEngine.Quaternion val_23 = this.gun.localRotation;
        UnityEngine.Quaternion val_24 = this.gun.localRotation;
        val_28 = this.gun;
        UnityEngine.Quaternion val_25 = val_28.localRotation;
        float val_26 = val_23.x - val_39;
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_33 = val_27.x;
        val_32 = val_27.z;
        this.gun.localRotation = new UnityEngine.Quaternion() {x = val_33, y = val_27.y, z = val_32, w = val_27.w};
        this.三专丐丝且丗丟丆丒();
    }
    protected override void 丗丅世且丛丑业世丑()
    {
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                bool val_2 = GameConnect.与丂丝丟丟三丑丝万();
        }
        
        this.下一丘丛不丄世东丕();
    }
    protected override void 丗丈丘丑丂丆丐业丂()
    {
        this.丗丈丘丑丂丆丐业丂();
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
    
    }
    private 丅丙上七上一丐不下 三丆下丕丐三东丁丏()
    {
        var val_3;
        float val_4;
        TankDamageable val_57;
        float val_58;
        var val_60;
        var val_61;
        var val_62;
        float val_63;
        TankDamageable val_64;
        UnityEngine.Object val_65;
        float val_70;
        float val_71;
        float val_72;
        float val_73;
        float val_75;
        var val_78;
        val_58 = 0;
        Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
        val_60 = 1152921540128699856;
        val_61 = 1152921504838848512;
        val_62 = 0;
        val_63 = 0f;
        label_16:
        val_64 = val_62;
        label_15:
        if((1669798208 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        val_65 = val_5._value._obj.丐丏七丌丕丗业且上();
        if(val_65 != null)
        {
                val_65 = 0;
        }
        
        if((val_65 == 0) || (val_4 <= val_63))
        {
            goto label_15;
        }
        
        var val_62 = 0;
        val_62 = val_62 + 1;
        if((this.世下丂丐丗且丂专七(丅专与丒丈丗丒丘丌:  val_5._value._obj.丐丏七丌丕丗业且上().transform)) == false)
        {
            goto label_15;
        }
        
        string val_14 = val_5._value._obj.丐丏七丌丕丗业且上();
        goto label_16;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_64 != 0)
        {
                return (丅丙上七上一丐不下)val_64;
        }
        
        val_62 = 1152921505327452160;
        if((TankController.丄丘七三上丕世丞业 == 0) || (TankController.丄丘七三上丕世丞业.丆世丙丈一丕丆丞丆 == 0))
        {
            goto label_70;
        }
        
        val_64 = mem[TankController.丄丘七三上丕世丞业 + 32];
        val_64 = TankController.丄丘七三上丕世丞业.丆世丙丈一丕丆丞丆;
        TankDamageable val_65 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_42;
        }
        
        var val_63 = mem[null + 176];
        var val_64 = 0;
        val_63 = val_63 + 8;
        label_41:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_40;
        }
        
        val_64 = val_64 + 1;
        val_63 = val_63 + 16;
        if(val_64 < (mem[null + 286]))
        {
            goto label_41;
        }
        
        goto label_42;
        label_40:
        val_65 = val_65 + (((mem[null + 176] + 8)) << 4);
        label_42:
        UnityEngine.Vector3 val_18 = transform.position;
        UnityEngine.Vector3 val_20 = this.transform.position;
        val_70 = val_20.y;
        val_58 = val_18.x;
        val_71 = val_18.y;
        val_72 = val_18.z;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_58, y = val_71, z = val_72}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_70, z = val_20.z});
        val_73 = val_21.z;
        val_57 = mem[TankController.丄丘七三上丕世丞业 + 32];
        val_57 = TankController.丄丘七三上丕世丞业.丆世丙丈一丕丆丞丆;
        if((this.世下丂丐丗且丂专七(丅专与丒丈丗丒丘丌:  transform)) == false)
        {
            goto label_70;
        }
        
        val_3 = 0;
        val_58 = 0f;
        val_72 = 0f;
        val_71 = this.丗丅万业丞七丆一万;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_58, y = 0f, z = val_72}, to:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_73})) >= 0)
        {
            goto label_70;
        }
        
        val_3 = 0;
        val_58 = 0f;
        val_72 = 0f;
        val_71 = this.不且丐丄丙丈丒且丛;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_58, y = 0f, z = val_72}, to:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_73})) <= val_71)
        {
            goto label_70;
        }
        
        UnityEngine.Vector3 val_26 = this.tower.position;
        val_73 = val_26.z;
        TankDamageable val_68 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_61;
        }
        
        var val_66 = mem[null + 176];
        var val_67 = 0;
        val_66 = val_66 + 8;
        label_60:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_59;
        }
        
        val_67 = val_67 + 1;
        val_66 = val_66 + 16;
        if(val_67 < (mem[null + 286]))
        {
            goto label_60;
        }
        
        goto label_61;
        label_59:
        val_68 = val_68 + (((mem[null + 176] + 8)) << 4);
        label_61:
        UnityEngine.Vector3 val_28 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  transform);
        val_57 = this.tower;
        val_70 = val_28.y;
        UnityEngine.Vector3 val_29 = val_57.position;
        val_75 = val_29.x;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_70, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_75, y = val_29.y, z = val_29.z});
        val_71 = val_26.y;
        val_72 = val_73;
        val_4 = 0;
        val_3 = val_58;
        val_58 = this.丌丆万丛万丞丙下三();
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_58, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) == false)
        {
            goto label_70;
        }
        
        val_73 = val_72;
        val_70 = val_71;
        UnityEngine.Color val_34 = UnityEngine.Color.green;
        val_75 = val_34.r;
        val_63 = val_34.b;
        val_71 = val_71;
        val_58 = val_58;
        val_72 = val_73;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_58, y = val_71, z = val_72}, dir:  new UnityEngine.Vector3() {x = val_58, y = val_70, z = val_72}, color:  new UnityEngine.Color() {r = val_75, g = val_63, b = 0.2f}, duration:  null);
        val_57 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_58);
        if(val_57 == null)
        {
            goto label_70;
        }
        
        var val_69 = 0;
        val_69 = val_69 + 1;
        val_57 = val_57.transform;
        TankDamageable val_72 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_79;
        }
        
        var val_70 = mem[null + 176];
        var val_71 = 0;
        val_70 = val_70 + 8;
        label_78:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_77;
        }
        
        val_71 = val_71 + 1;
        val_70 = val_70 + 16;
        if(val_71 < (mem[null + 286]))
        {
            goto label_78;
        }
        
        goto label_79;
        label_77:
        val_72 = val_72 + (((mem[null + 176] + 8)) << 4);
        label_79:
        if(val_57 == transform)
        {
                return (丅丙上七上一丐不下)val_64;
        }
        
        label_70:
        val_62 = 1152921505189965824;
        val_78 = null;
        val_78 = null;
        List.Enumerator<T> val_40 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_61 = 1152921525761786080;
        val_60 = 1152921504833470464;
        val_63 = 100000f;
        label_120:
        val_64 = 0;
        if((1669798096 & 1) == 0)
        {
            goto label_86;
        }
        
        string val_41 = val_3.丐丏七丌丕丗业且上();
        if(val_41.一丝丌丏万丐丌丆东() != false)
        {
                if(val_4 != 0)
        {
            goto label_120;
        }
        
        }
        
        UnityEngine.Vector3 val_44 = val_41.transform.position;
        UnityEngine.Vector3 val_46 = this.transform.position;
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
        if(((this.世下丂丐丗且丂专七(丅专与丒丈丗丒丘丌:  val_41.transform)) == false) || (val_47.x >= 0))
        {
            goto label_120;
        }
        
        val_3 = 0;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z})) >= 0)
        {
            goto label_120;
        }
        
        val_3 = 0;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z})) <= this.不且丐丄丙丈丒且丛)
        {
            goto label_120;
        }
        
        UnityEngine.Vector3 val_52 = this.tower.position;
        UnityEngine.Vector3 val_54 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  val_41.transform);
        UnityEngine.Vector3 val_55 = this.tower.position;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, b:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
        val_4 = 0;
        val_3 = 0;
        float val_57 = this.丌丆万丛万丞丙下三();
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_57, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) == false)
        {
            goto label_120;
        }
        
        UnityEngine.Color val_60 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_57, y = val_52.y, z = val_52.z}, dir:  new UnityEngine.Vector3() {x = val_57, y = val_52.y, z = val_52.z}, color:  new UnityEngine.Color() {r = val_60.r, g = val_60.b, b = 0.2f}, duration:  null);
        if(((HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_58)) == null) || (val_41 != null))
        {
            goto label_120;
        }
        
        goto label_120;
        label_86:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丅丙上七上一丐不下)val_64;
    }
    private bool 世下丂丐丗且丂专七(UnityEngine.Transform 丅专与丒丈丗丒丘丌)
    {
        float val_9;
        var val_10;
        UnityEngine.Vector3 val_1 = 丅专与丒丈丗丒丘丌.position;
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_9 = val_1.x;
        float val_4 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        if(this.IgnoreRadius == (-1f))
        {
            
        }
        
        if(val_4 > this.IgnoreRadius)
        {
                float val_7 = this.丌丆万丛万丞丙下三();
            var val_8 = (val_4 < 0) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    internal bool 专与丘与丒丂七丛上(UnityEngine.Transform 丅专与丒丈丗丒丘丌)
    {
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        var val_17;
        UnityEngine.Vector3 val_1 = this.tower.position;
        val_12 = val_1.z;
        UnityEngine.Vector3 val_2 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  丅专与丒丈丗丒丘丌);
        val_13 = val_2.y;
        UnityEngine.Vector3 val_3 = this.tower.position;
        val_14 = val_3.x;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_13, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_14, y = val_3.y, z = val_3.z});
        val_15 = this.丌丆万丛万丞丙下三();
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_15, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) != false)
        {
                val_12 = val_12;
            val_13 = val_1.y;
            UnityEngine.Color val_8 = UnityEngine.Color.green;
            val_14 = val_8.r;
            val_15 = val_8.b;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_15, y = val_1.y, z = val_12}, dir:  new UnityEngine.Vector3() {x = val_15, y = val_13, z = val_12}, color:  new UnityEngine.Color() {r = val_14, g = val_15, b = 0.2f, a = val_1.y}, duration:  0f);
            丅丙上七上一丐不下 val_9 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            if(val_9 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_9.transform == 丅专与丒丈丗丒丘丌)
        {
                val_17 = 1;
            return (bool)val_17;
        }
        
        }
        
        }
        
        val_17 = 0;
        return (bool)val_17;
    }
    protected void 丐万丙专丟丒丙与丂(UnityEngine.Transform 丘业丝下丑丈且东丒)
    {
        mem[1152921540636875360] = 丘业丝下丑丈且东丒;
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_12;
        this.丟丞丆上上丁丅下丐();
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_1.IsDead() == true)
        {
                return;
        }
        
        PhotonView val_4 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  val_1);
        if(val_4 != 0)
        {
                val_12 = val_4.isMine;
        }
        else
        {
                val_12 = 0;
        }
        
        if(1152921504848912384 == 0)
        {
                return;
        }
        
        if((val_12 & this.丄上上不丛万丝不一()) == false)
        {
                return;
        }
        
        float val_10 = UnityEngine.Time.deltaTime;
        val_10 = this.丈三丐且丝上丙丐丙 - val_10;
        this.丈三丐且丝上丙丐丙 = val_10;
        if(val_10 >= 0)
        {
                return;
        }
        
        val_12.SendShotRPC(上世万世丐丄上丑丆:  this);
        this.丈三丐且丝上丙丐丙 = this.丐丕世丂上丐丑东丂();
    }
    protected virtual void 丄一一丌丙丂丌东丟()
    {
        float val_23;
        float val_24;
        float val_26;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        UnityEngine.Vector3 val_1 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  137129984);
        val_23 = val_1.x;
        val_24 = val_1.z;
        if(this.丙丑丁丆丌且不专丑 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.shootingPoint.forward;
        UnityEngine.Vector3 val_3 = this.shootingPoint.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = val_1.y, z = val_24}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.z);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_4.z);
        val_26 = val_6.x;
        float val_24 = val_6.y;
        val_28 = UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, to:  new UnityEngine.Vector2() {x = val_26, y = val_24});
        float val_23 = System.Math.Abs(val_28);
        if(val_23 > 0.01f)
        {
                val_28 = val_28 * this.东专与七万丌万丗七;
            val_29 = this.业丞丈专丏丑下万下;
            val_30 = System.Math.Abs(val_28);
            if(val_30 > val_29)
        {
                val_29 = val_28;
            val_30 = this.业丞丈专丏丑下万下;
            val_28 = (UnityEngine.Mathf.Sign(f:  val_29)) * val_30;
        }
        
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            val_24 = -(val_28 * UnityEngine.Time.deltaTime);
            val_26 = val_9.z;
            this.tower.Rotate(axis:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_26}, angle:  val_24);
            this.丑丄与下丑丅丘业丅();
        }
        
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.right;
        val_31 = val_12.x;
        val_23 = val_12.z;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
        val_24 = UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, to:  new UnityEngine.Vector3() {x = val_31, y = val_12.y, z = val_23}, axis:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.z, z = val_4.z});
        if(this.gun == 0)
        {
                return;
        }
        
        if(val_23 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_2.y, y:  val_2.z);
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_4.y, y:  val_4.z);
        float val_26 = val_17.y;
        val_31 = ((val_24 > 0f) ? -1f : 1f) * (UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, to:  new UnityEngine.Vector2() {x = val_17.x, y = val_26}));
        if(System.Math.Abs(val_31) <= 0.01f)
        {
                return;
        }
        
        val_31 = val_31 * this.丅下丆丘丆丝丄一丑;
        val_32 = this.业丞丈专丏丑下万下;
        val_33 = System.Math.Abs(val_31);
        if(val_33 > val_32)
        {
                val_32 = val_31;
            val_33 = this.业丞丈专丏丑下万下;
            val_31 = (UnityEngine.Mathf.Sign(f:  val_32)) * val_33;
        }
        
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.right;
        val_23 = val_21.y;
        val_24 = UnityEngine.Time.deltaTime;
        val_26 = val_31 * val_24;
        this.gun.Rotate(axis:  new UnityEngine.Vector3() {x = val_21.x, y = val_23, z = val_21.z}, angle:  val_26, relativeTo:  1);
        this.三专丐丝且丗丟丆丒();
    }
    protected bool 丄上上不丛万丝不一()
    {
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        UnityEngine.Vector3 val_1 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  137129984);
        UnityEngine.Vector3 val_2 = this.shootingPoint.forward;
        UnityEngine.Vector3 val_3 = this.shootingPoint.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.z);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_4.z);
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_2.y, y:  val_2.z);
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_4.y, y:  val_4.z);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        val_21 = val_11.y;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.right;
        val_22 = val_12.z;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
        float val_15 = ((UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_11.x, y = val_21, z = val_11.z}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_22}, axis:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.z, z = val_1.y})) > 0f) ? -1f : 1f;
        val_23 = 10f;
        if((System.Math.Abs(UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, to:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}))) < 0)
        {
                val_15 = (UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, to:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y})) * val_15;
            val_22 = val_1.y;
            if(System.Math.Abs(val_15) >= 0)
        {
                if(this.丅丙丂丌丄丟丌丅丝 == false)
        {
            goto label_15;
        }
        
        }
        
            UnityEngine.Vector3 val_16 = this.tower.position;
            val_21 = val_16.y;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_22, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_21, z = val_16.z});
            val_23 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            float val_19 = this.丝丟丆上业丒丕上丂();
            var val_20 = (val_23 < 0) ? 1 : 0;
            return (bool)val_24;
        }
        
        label_15:
        val_24 = 0;
        return (bool)val_24;
    }
    protected void 丑丄与下丑丅丘业丅()
    {
        if(this.丙丒丕下万丛专与丐 == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_1 = this.tower.localRotation;
        this.丆丄丞丐丐万一丒丌.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
    }
    protected void 三专丐丝且丗丟丆丒()
    {
        if(this.丕七丛与丅不丞与丁 == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_1 = this.gun.localRotation;
        this.丄丝与丘不专下且丒.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
    }
    protected override void 下专专专丄世丗且丐()
    {
        this.下专专专丄世丗且丐();
    }
    protected override void Update()
    {
        this.Update();
        if(this.gun != 0)
        {
                UnityEngine.Quaternion val_2 = this.gun.rotation;
            this.业专丑丐丕专丟丆丆 = val_2;
            mem[1152921540637795032] = val_2.y;
            mem[1152921540637795036] = val_2.z;
            mem[1152921540637795040] = val_2.w;
        }
        
        if(this.tower == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_4 = this.tower.rotation;
        this.丄丌业不不丆丙丈丑 = val_4;
        mem[1152921540637795048] = val_4.y;
        mem[1152921540637795052] = val_4.z;
        mem[1152921540637795056] = val_4.w;
    }
    protected override void LateUpdate()
    {
        UnityEngine.Quaternion val_3;
        this.LateUpdate();
        if(true == 0)
        {
                return;
        }
        
        if(this.tower != 0)
        {
                val_3 = this.丄丌业不不丆丙丈丑;
            this.tower.rotation = new UnityEngine.Quaternion() {x = val_3, y = V9.16B, z = V10.16B, w = V11.16B};
        }
        
        this.丑丄与下丑丅丘业丅();
        if(this.gun != 0)
        {
                val_3 = this.业专丑丐丕专丟丆丆;
            this.gun.rotation = new UnityEngine.Quaternion() {x = val_3, y = V9.16B, z = V10.16B, w = V11.16B};
        }
        
        this.三专丐丝且丗丟丆丒();
    }
    private void 下一丘丛不丄世东丕()
    {
        丅丙上七上一丐不下 val_49;
        var val_50;
        float val_51;
        var val_52;
        var val_53;
        float val_54;
        float val_56;
        float val_57;
        float val_58;
        float val_61;
        float val_63;
        var val_66;
        var val_67;
        丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上 val_1 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W22, 丅七上一丈丕上丒丞:  false);
        if(137129984 == 0)
        {
            goto label_3;
        }
        
        val_49 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        if(val_49 != null)
        {
                val_49 = this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_49);
        }
        
        var val_5 = (val_49 == true) ? 1 : 0;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_3:
        val_50 = 0;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_6 = val_1.世且一丄且上丄不一();
        val_51 = 3.402823E+38f;
        val_52 = 1152921504691191808;
        val_53 = 0;
        val_54 = -1f;
        goto label_49;
        label_61:
        var val_50 = 0;
        val_50 = val_50 + 1;
        T val_8 = val_6.Current;
        UnityEngine.Vector3 val_9 = val_8.position;
        val_56 = val_9.x;
        val_57 = val_9.y;
        val_58 = val_9.z;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = val_10.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_56, y = val_57, z = val_58}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_61 = val_12.x;
        if(this.IgnoreRadius == val_54)
        {
            
        }
        else
        {
                val_57 = this.IgnoreRadius;
            val_63 = val_57 * this.IgnoreRadius;
        }
        
        if((val_50 | (~(UnityEngine.Object.op_Inequality(x:  val_10, y:  0)))) == true)
        {
            goto label_24;
        }
        
        UnityEngine.Vector3 val_18 = val_10.position;
        val_57 = val_18.x;
        val_58 = val_18.y;
        val_56 = val_61;
        UnityEngine.Vector3 val_20 = this.transform.position;
        val_51 = val_57;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_51, y = val_58, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_61 = val_56;
        val_54 = -1f;
        if((val_61 < 0) || (val_61 > val_21.x))
        {
            goto label_49;
        }
        
        label_24:
        val_51 = val_51;
        if(((val_61 < 0) && (val_61 > val_63)) && (val_61 < 0))
        {
                val_58 = val_12.z;
            val_51 = 0f;
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_51, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_58})) < 0)
        {
                val_58 = val_12.z;
            val_51 = 0f;
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_51, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_58})) > this.不且丐丄丙丈丒且丛)
        {
                UnityEngine.Vector3 val_24 = this.tower.position;
            val_56 = val_24.x;
            UnityEngine.Vector3 val_25 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  val_8);
            val_61 = val_25.x;
            UnityEngine.Vector3 val_26 = this.tower.position;
            val_58 = val_26.z;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_61, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_58});
            val_51 = this.丌丆万丛万丞丙下三();
            val_54 = -1f;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_51, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) != false)
        {
                val_61 = val_51;
            UnityEngine.Color val_31 = UnityEngine.Color.green;
            val_58 = val_31.b;
            val_51 = val_61;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_51, y = val_24.y, z = val_24.z}, dir:  new UnityEngine.Vector3() {x = val_51, y = val_24.y, z = val_24.z}, color:  new UnityEngine.Color() {r = val_31.r, g = val_58, b = 0.2f}, duration:  null);
            丅丙上七上一丐不下 val_32 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            val_56 = val_61;
            val_54 = -1f;
            if(val_32 != null)
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            bool val_35 = UnityEngine.Object.op_Equality(x:  val_32.transform, y:  val_8);
            val_53 = val_53 | val_35;
            var val_36 = (val_35 != true) ? (val_56) : (val_51);
            UnityEngine.Object val_37 = (val_35 != true) ? (val_8) : 0;
        }
        
        }
        
        }
        
        }
        
        }
        
        label_49:
        var val_52 = 0;
        val_52 = val_52 + 1;
        if(val_6.MoveNext() == true)
        {
            goto label_61;
        }
        
        val_66 = 0;
        val_67 = 0;
        if(val_6 == null)
        {
            
        }
        else
        {
                var val_53 = 0;
            val_53 = val_53 + 1;
            val_6.Dispose();
        }
        
        if(val_53 != false)
        {
                if(val_37 == val_6)
        {
                return;
        }
        
            float val_42 = UnityEngine.Time.time;
            if(val_56 >= 0)
        {
                return;
        }
        
            不七世丁丟丏世业丑 val_44 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_37));
            SendSetTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_44.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_44.丏与丅下丞丗与七下);
            return;
        }
        
        if((val_50 & (UnityEngine.Object.op_Inequality(x:  val_6, y:  0))) != true)
        {
                return;
        }
        
        不七世丁丟丏世业丑 val_48 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  0);
        SendRemoveTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_48.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_48.丏与丅下丞丗与七下);
    }
    public TurretControllerScene_Tower()
    {
        mem2[0] = ;
        mem2[0] = ;
        this.丆丛一三世与丙三丏 = 45f;
    }

}
