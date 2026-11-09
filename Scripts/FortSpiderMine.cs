using UnityEngine;
internal class FortSpiderMine : FortTrap
{
    // Fields
    private UnityEngine.Transform 丟丑丟上丌丒业丌业;
    private UnityEngine.AI.NavMeshAgent 丟丅三丝丄丈万丒三;
    private float 下下丕丟丛不不万万;
    private float 世丌丅丞丝丘世一丒;
    private UnityEngine.Animation 丆不丝丝上一丞七业;
    private FortSpiderMine.丙丂与丈丝世三业与 丄丟丞丈丁与丐丈丛;
    
    // Properties
    public float 丙丆丘七丏丑业与丒 { get; }
    
    // Methods
    public float get_damageRadius()
    {
        return BalanceController.丞丅三丁丄丅丌丌丐(丆万一不丌且东丐丐:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject));
    }
    private void Awake()
    {
        UnityEngine.AI.NavMeshAgent val_8;
        if(this.丟丅三丝丄丈万丒三 != 0)
        {
            goto label_3;
        }
        
        val_8 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.丟丅三丝丄丈万丒三 = val_8;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_8 = this.丟丅三丝丄丈万丒三;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_8.enabled = false;
        if(this.丆不丝丝上一丞七业 == 0)
        {
                this.丆不丝丝上一丞七业 = this.GetComponentInChildren<UnityEngine.Animation>(includeInactive:  true);
        }
        
        if(this.丟丑丟上丌丒业丌业 != 0)
        {
                return;
        }
        
        this.丟丑丟上丌丒业丌业 = this.transform.parent;
    }
    public override void Activate()
    {
        this.Activate();
        this.丟丅三丝丄丈万丒三.enabled = true;
        this.丄丟丞丈丁与丐丈丛 = 0;
    }
    public override void DetectTargets()
    {
        var val_30;
        var val_31;
        float val_32;
        float val_33;
        float val_34;
        var val_35;
        var val_37;
        float val_38;
        float val_39;
        var val_40;
        var val_41;
        var val_42;
        float val_43;
        float val_44;
        float val_45;
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_32 = val_6.x;
        val_33 = val_6.z;
        UnityEngine.Vector3 val_7 = this.丟丑丟上丌丒业丌业.position;
        val_34 = val_32;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34, y = val_6.y, z = val_33}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        if(this.丟丑丟上丌丒业丌业 == 0)
        {
            goto label_28;
        }
        
        val_35 = null;
        val_35 = null;
        if(this.丟丑丟上丌丒业丌业 == typeof(Player_move_c).__il2cppRuntimeField_378)
        {
            goto label_28;
        }
        
        label_68:
        this.丝一世业丒下不七丈();
        return;
        label_28:
        if(this.丟丑丟上丌丒业丌业 == 0)
        {
            goto label_39;
        }
        
        val_37 = null;
        val_37 = null;
        if(this.丟丑丟上丌丒业丌业 != typeof(Player_move_c).__il2cppRuntimeField_378)
        {
            goto label_39;
        }
        
        val_32 = val_8.x;
        float val_14 = this.damageRadius;
        val_14 = this.damageRadius * val_14;
        if(val_32 < 0)
        {
                return;
        }
        
        val_38 = 0f;
        if(val_8.x == 0)
        {
            goto label_41;
        }
        
        val_39 = val_8.x.不七不丈丐万丂丌下();
        if(val_8.x == 0)
        {
            goto label_43;
        }
        
        val_38 = val_8.x.不七不丈丐万丂丌下();
        goto label_43;
        label_39:
        if(this.丟丑丟上丌丒业丌业 != 0)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        if((this & 1) != 0)
        {
                val_32 = val_8.x;
            val_34 = this.damageRadius * this.damageRadius;
            if(val_32 < 0)
        {
                return;
        }
        
        }
        
        val_41 = null;
        val_41 = null;
        if((this & 1) == 0)
        {
            goto label_56;
        }
        
        val_42 = this;
        val_32 = val_8.x;
        val_43 = 0f;
        if(val_8.x == 0)
        {
            goto label_57;
        }
        
        val_33 = val_8.x.不七不丈丐万丂丌下();
        if(val_8.x == 0)
        {
            goto label_59;
        }
        
        val_43 = val_8.x.不七不丈丐万丂丌下();
        goto label_59;
        label_56:
        val_42 = 1152921526075435776;
        goto label_61;
        label_57:
        val_33 = 0f;
        label_59:
        val_34 = val_33 * val_43;
        if(val_32 < 0)
        {
                this.SetTarget();
            return;
        }
        
        label_61:
        val_32 = val_8.x;
        val_44 = 0f;
        if(null == null)
        {
            goto label_63;
        }
        
        val_33 = 1152921505064353792.不七不丈丐万丂丌下();
        if(null == null)
        {
            goto label_65;
        }
        
        val_44 = 1152921505064353792.不七不丈丐万丂丌下();
        goto label_65;
        label_63:
        val_33 = 0f;
        label_65:
        if(val_32 < (val_33 * val_44))
        {
                return;
        }
        
        this.一丟专丗丑丈丄上丟();
        return;
        label_41:
        val_39 = 0f;
        label_43:
        if(val_14 < 0)
        {
            goto label_68;
        }
        
        val_32 = val_39 * val_38;
        val_45 = 0f;
        if(val_8.x == 0)
        {
            goto label_69;
        }
        
        val_33 = val_8.x.不七不丈丐万丂丌下();
        if(val_8.x == 0)
        {
            goto label_71;
        }
        
        val_45 = val_8.x.不七不丈丐万丂丌下();
        goto label_71;
        label_69:
        val_33 = 0f;
        label_71:
        if(val_32 < (val_33 * val_45))
        {
                return;
        }
        
        this.丟下世丒丑丈丑丞丂();
    }
    private void 丁丛丏上一业七上丁()
    {
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        float val_17;
        float val_18;
        var val_19;
        val_13 = this;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if((val_13 & 1) == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_17 = val_2.z;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_17}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_18 = val_5.x;
        float val_7 = this.damageRadius;
        val_7 = this.damageRadius * val_7;
        if(val_18 >= 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        val_18 = this.下与丗丒丐三丕丘丈();
        UnityEngine.Vector3 val_10 = this.transform.position;
        val_17 = val_10.y;
        val_13 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        typeof(Player_move_c).__il2cppRuntimeField_600.ApplyDamage(丞丈专下丈专业三丞:  val_18, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_10.x, y = val_17, z = val_10.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_13, 丒丈丐丐丗丐专丈丏:  0);
    }
    public override void DetectedTarget()
    {
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  1000f, 丞丗且下世丐业丌丙:  0, 丐丟丘世丁三丕专专:  0);
    }
    private void 丝一世业丒下不七丈()
    {
        if(this.丟丅三丝丄丈万丒三.isOnNavMesh == false)
        {
                return;
        }
        
        if(this.丄丟丞丈丁与丐丈丛 != 1)
        {
                bool val_2 = this.丆不丝丝上一丞七业.Play(animation:  "walk");
        }
        
        this.丄丟丞丈丁与丐丈丛 = 1;
        UnityEngine.Vector3 val_3 = X21.position;
        bool val_4 = this.丟丅三丝丄丈万丒三.SetDestination(target:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = this.丟丅三丝丄丈万丒三.position;
        this.丌一丘丅丈丁丞业丐(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    private void 丌一丘丅丈丁丞业丐(UnityEngine.Vector3 丙丌丛丘丗与一专丁)
    {
        this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = 丙丌丛丘丗与一专丁.x, y = 0f, z = 丙丌丛丘丗与一专丁.z});
    }
    private void 一丟专丗丑丈丄上丟()
    {
        float val_13;
        float val_14;
        float val_15;
        丙丂与丈丝世三业与 val_16;
        if(this.丟丅三丝丄丈万丒三.isOnNavMesh == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.丟丅三丝丄丈万丒三.destination;
        UnityEngine.Vector3 val_3 = this.丟丑丟上丌丒业丌业.position;
        val_13 = val_2.x;
        val_14 = val_2.y;
        val_15 = val_2.z;
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丞丞丙且丄不丈丌三:  0.1f)) != true)
        {
                UnityEngine.Vector3 val_5 = this.丟丑丟上丌丒业丌业.position;
            val_13 = val_5.x;
            val_14 = val_5.y;
            val_15 = val_5.z;
            bool val_6 = this.丟丅三丝丄丈万丒三.SetDestination(target:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15});
        }
        
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.Vector3 val_9 = this.丟丑丟上丌丒业丌业.position;
        val_16 = this.丄丟丞丈丁与丐丈丛;
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丞丞丙且丄不丈丌三:  0.1f)) == false)
        {
            goto label_14;
        }
        
        if(val_16 == 0)
        {
            goto label_18;
        }
        
        bool val_11 = this.丆不丝丝上一丞七业.Play(animation:  "idle");
        val_16 = 0;
        goto label_18;
        label_14:
        if(val_16 != 1)
        {
                bool val_12 = this.丆不丝丝上一丞七业.Play(animation:  "walk");
            val_16 = 1;
        }
        
        label_18:
        this.丄丟丞丈丁与丐丈丛 = val_16;
    }
    private void SetTarget()
    {
        var val_4;
        float val_1 = UnityEngine.Time.time;
        if(this.下下丕丟丛不不万万 >= 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + 1f;
        this.下下丕丟丛不不万万 = val_2;
        val_4 = null;
        val_4 = null;
        SendSetTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  typeof(Player_move_c).__il2cppRuntimeField_628 + 496.viewID, 丏与丅下丞丗与七下:  0);
    }
    private void 丟下世丒丑丈丑丞丂()
    {
        var val_4;
        float val_1 = UnityEngine.Time.time;
        if(this.世丌丅丞丝丘世一丒 >= 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + 1f;
        this.世丌丅丞丝丘世一丒 = val_2;
        val_4 = null;
        val_4 = null;
        SendRemoveTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  typeof(Player_move_c).__il2cppRuntimeField_628 + 496.viewID, 丏与丅下丞丗与七下:  0);
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921526076512196] = 1;
        if(137105408 != 0)
        {
                SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        this.丁丛丏上一业七上丁();
        UnityEngine.GameObject val_3 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  "Explosion47"));
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public override void Deactivate()
    {
        this.Deactivate();
        this.丟丅三丝丄丈万丒三.enabled = false;
        UnityEngine.Vector3 val_2 = this.丟丑丟上丌丒业丌业.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public FortSpiderMine()
    {
        mem[1152921526076777136] = 1073741824;
        mem[1152921526076777160] = 1073741824;
        val_1 = new FortEquipObject();
    }

}
