using UnityEngine;
internal sealed class WeaponChargeShield : PGBehaviour
{
    // Fields
    public UnityEngine.Collider shieldCollider;
    private float protectionAngle;
    internal float energyDamageMutiplier;
    private UnityEngine.ParticleSystem protectPartile;
    private float protectParticleShowTime;
    private UnityEngine.GameObject destroyParticlesObj;
    private UnityEngine.GameObject 丛一丕下丘丕丆东万;
    internal WeaponSounds 丌丝下丄业一丄不三;
    private bool <一一七万与丄与丌丙>k__BackingField;
    public float speedMultiplier;
    private UnityEngine.Coroutine 不丁丈丂下且专丁丝;
    
    // Properties
    internal bool 丂丝下与丆与丁丞丐 { get; set; }
    
    // Methods
    internal bool 丑丛丛丌丝丘东七业()
    {
        return (bool)this.<一一七万与丄与丌丙>k__BackingField;
    }
    private void 丟丂且世丘丛丈丙丙(bool 丙业与丙丗丝不丈东)
    {
        this.<一一七万与丄与丌丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        UnityEngine.Collider val_9;
        if(this.丌丝下丄业一丄不三 == 0)
        {
                return;
        }
        
        if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        Player_move_c val_4 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_4.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_13;
        }
        
        }
        
        val_9 = this;
        this.shieldCollider.enabled = false;
        goto label_15;
        label_13:
        val_9 = this.shieldCollider;
        label_15:
        this.丛一丕下丘丕丆东万 = mem[this.shieldCollider].gameObject;
        Player_move_c val_8 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        丘丛丞且一丅丁丏丐.且丑丏下丈丆丕业丅(且丙与丏下丅丐世丑:  this.shieldCollider, 丗万丑东丂丈下且丗:  val_8.丂七一业下丈业丕丒);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.业丕丕丏世与一丂丆(且丙与丏下丅丐世丑:  this.shieldCollider);
    }
    internal static bool 且专丌丝一东丐丑丛(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 丂且丑三且丌丘下丌, float 丞丈专下丈专业三丞 = 0, string 丝三丛且丘不丌丙下 = "")
    {
        UnityEngine.Collider val_43;
        UnityEngine.Object val_63;
        var val_65;
        var val_66;
        UnityEngine.Object val_67;
        var val_68;
        System.Comparison<UnityEngine.RaycastHit> val_70;
        var val_71;
        var val_72;
        var val_73;
        val_63 = 丂丈丙且丈丗三丆丕;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if(((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == true) || ((System.String.op_Equality(a:  丝三丛且丘不丌丙下, b:  "Weapon617")) == true))
        {
            goto label_4;
        }
        
        val_65 = 0;
        if((val_63 == null) || (丘丛丞且一丅丁丏丐.丂丞东丛且世万丒丑() == false))
        {
            goto label_100;
        }
        
        val_63 = 0;
        val_66 = 1152921504848912384;
        if(val_63 != 0)
        {
            goto label_13;
        }
        
        label_4:
        val_65 = 0;
        label_100:
        val_65 = val_65 & 1;
        return (bool)val_65;
        label_13:
        if(0 != 0)
        {
                if(val_63.丟丌下三七丁与丟丑() == false)
        {
            goto label_23;
        }
        
        }
        
        if((val_63.丙不丅丕三丂业东丕() == 0) || (val_63.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() == 0))
        {
            goto label_23;
        }
        
        if((val_63.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东().下下丝万丑丒不上丆(且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z})) == false)
        {
            goto label_26;
        }
        
        goto label_27;
        label_23:
        val_67 = 0;
        if(专不丑且不丏东丟丅 == 0)
        {
            goto label_42;
        }
        
        val_67 = 0;
        if(val_63.丙不丅丕三丂业东丕() == 0)
        {
            goto label_42;
        }
        
        val_67 = 0;
        if(val_63.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() == 0)
        {
            goto label_42;
        }
        
        if((val_63.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东().下下丝万丑丒不上丆(专不丑且不丏东丟丅:  专不丑且不丏东丟丅)) == false)
        {
            goto label_40;
        }
        
        val_67 = val_63.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东();
        goto label_42;
        label_26:
        val_67 = 0;
        goto label_81;
        label_40:
        val_67 = 0;
        label_42:
        if(val_67 != 0)
        {
            goto label_81;
        }
        
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, rhs:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z})) == false)
        {
            goto label_81;
        }
        
        UnityEngine.Vector3 val_30 = val_63.myTransform.position;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z});
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  0.1f);
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<UnityEngine.RaycastHit>(source:  UnityEngine.Physics.RaycastAll(origin:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, direction:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, maxDistance:  val_33.x * 5f, layerMask:  536870912));
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  0.1f);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        UnityEngine.Color val_39 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, dir:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, color:  new UnityEngine.Color() {r = val_39.r, g = val_39.b, b = 20f}, duration:  val_31.x);
        val_68 = null;
        val_68 = null;
        val_70 = WeaponChargeShield.<>c.<>9__15_0;
        if(val_70 == null)
        {
                System.Comparison<UnityEngine.RaycastHit> val_40 = null;
            val_70 = val_40;
            val_40 = new System.Comparison<UnityEngine.RaycastHit>(object:  WeaponChargeShield.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponChargeShield.<>c::丏丕丝丆丝下丄丙且(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂, UnityEngine.RaycastHit 丙专一丌丌丁不丈专));
            WeaponChargeShield.<>c.<>9__15_0 = val_70;
        }
        
        val_36.Sort(comparison:  val_40);
        val_71 = 0;
        goto label_62;
        label_80:
        UnityEngine.RaycastHit val_41 = val_36.Item[0];
        if(val_38.x <= val_43.targetValue)
        {
            goto label_73;
        }
        
        UnityEngine.RaycastHit val_46 = val_36.Item[0];
        丅丙上七上一丐不下 val_47 = 丘丛丞且一丅丁丏丐.丂丅丐世上不丐丏丙(且丙与丏下丅丐世丑:  val_43);
        if(val_47 == null)
        {
            goto label_73;
        }
        
        val_72 = 0;
        if( == 0)
        {
            goto label_73;
        }
        
        val_66 = val_66;
        if((((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_47 : 0 + 24) == val_63) || ((IsEnemyTo(专丞上七七且丝七丗:  val_63)) == false))
        {
            goto label_78;
        }
        
        label_73:
        val_71 = 1;
        label_62:
        if(val_71 < val_36.Count)
        {
            goto label_80;
        }
        
        val_67 = val_67;
        goto label_81;
        label_78:
        val_73 = null;
        val_73 = null;
        var val_54 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_73) ? (val_47) : 0;
        label_27:
        val_67 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_73 ? val_47 : 0 + 24.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东();
        label_81:
        if((丞丈专下丈专业三丞 > 0f) && (val_67 != 0))
        {
                if(val_56.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() == val_63)
        {
                val_43 = 丞丈专下丈专业三丞;
            UnityEngine.Debug.LogError(message:  "CALL GetDamageToShield (damage = "("CALL GetDamageToShield (damage = ") + val_43 + ")");
            val_63.世丅七专七且丗丞丅(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 丏丞丙丌丆丙万丂丛:  false);
        }
        
        }
        
        bool val_61 = UnityEngine.Object.op_Inequality(x:  val_67, y:  0);
        goto label_100;
    }
    private bool 下下丝万丑丒不上丆(UnityEngine.Collider 专不丑且不丏东丟丅)
    {
        if((this.<一一七万与丄与丌丙>k__BackingField) == false)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Equality(x:  专不丑且不丏东丟丅, y:  this.shieldCollider);
    }
    private bool 下下丝万丑丒不上丆(UnityEngine.Vector3 且一丘丛丘丞丐丐业)
    {
        float val_8;
        float val_9;
        var val_10;
        val_8 = 且一丘丛丘丞丐丐业.z;
        val_9 = 且一丘丛丘丞丐丐业.x;
        if((this.<一一七万与丄与丌丙>k__BackingField) != false)
        {
                UnityEngine.Transform val_2 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().myTransform;
            UnityEngine.Vector3 val_3 = val_2.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9, y = 且一丘丛丘丞丐丐业.y, z = val_8}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_9 = val_4.z;
            UnityEngine.Vector3 val_5 = val_2.forward;
            val_8 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_9}, to:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            var val_7 = (System.Math.Abs(val_8) < 0) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    internal void 万万丌丏下与丝七丐()
    {
        if(this.不丁丈丂下且专丁丝 != null)
        {
                this.StopCoroutine(routine:  this.不丁丈丂下且专丁丝);
        }
        
        this.不丁丈丂下且专丁丝 = this.StartCoroutine(routine:  this.世不丝丒专丙一丘丘());
    }
    private void 丟丗丐一下不丂丈丙()
    {
        if(this.不丁丈丂下且专丁丝 != null)
        {
                this.StopCoroutine(routine:  this.不丁丈丂下且专丁丝);
            this.不丁丈丂下且专丁丝 = 0;
        }
        
        this.protectPartile.Stop();
    }
    internal void 丝世丞且与丒且丛一()
    {
        this.destroyParticlesObj.SetActive(value:  false);
        this.destroyParticlesObj.SetActive(value:  true);
    }
    private System.Collections.IEnumerator 世不丝丒专丙一丘丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponChargeShield.丂丆丐丄丘丆丁万丏();
    }
    private void Update()
    {
        if(this.丌丝下丄业一丄不三 == 0)
        {
                return;
        }
        
        if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        this.<一一七万与丄与丌丙>k__BackingField = this.丌丝下丄业一丄不三.丌丙丆下专丝丑且丈().IsPlaying(name:  "Charge");
        Player_move_c val_7 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_7.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == true)
        {
                return;
        }
        
        this.shieldCollider.enabled = ((this.<一一七万与丄与丌丙>k__BackingField) == true) ? 1 : 0;
        if(this.丛一丕下丘丕丆东万.layer == 29)
        {
                return;
        }
        
        this.丛一丕下丘丕丆东万.layer = 29;
    }
    public WeaponChargeShield()
    {
        this.protectionAngle = 89f;
        this.energyDamageMutiplier = 7.346868E-41f;
        this.protectParticleShowTime = 1f;
        this.speedMultiplier = 0.5f;
    }

}
