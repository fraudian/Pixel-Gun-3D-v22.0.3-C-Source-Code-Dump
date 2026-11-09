using UnityEngine;
internal class TurretControllerScene_Artillery_Tower : TurretControllerScene_Artillery
{
    // Fields
    private UnityEngine.Transform tower;
    private UnityEngine.Transform gun;
    private float idleAlphaY;
    private float idleRotateSpeedY;
    private float maxDeltaRotateY;
    private float idleGunXConstantAngle;
    private float idleRotateSpeedX;
    private float speedRotateY;
    private float speedRotateX;
    private UnityEngine.Quaternion 业专丑丐丕专丟丆丆;
    private UnityEngine.Quaternion 丄丌业不不丆丙丈丑;
    
    // Methods
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
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        UnityEngine.Transform val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        UnityEngine.Transform val_24;
        float val_25;
        float val_26;
        float val_27;
        val_18 = this;
        this.丈丞一丈丑丝丈丂丂();
        if(true != 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        val_19 = this.idleAlphaY;
        if(System.Math.Abs(val_19) < 0)
        {
                val_20 = this.maxDeltaRotateY;
            val_21 = val_20 * (-0.5f);
            val_22 = val_20 * 0.5f;
            this.idleAlphaY = UnityEngine.Random.Range(min:  val_21, max:  val_22);
        }
        else
        {
                float val_20 = this.idleAlphaY;
            val_23 = val_20;
            val_23 = val_20;
            val_23 = this.idleAlphaY;
            float val_19 = System.Math.Abs(val_20);
            val_19 = (UnityEngine.Time.deltaTime * this.idleRotateSpeedY) * val_19;
            val_20 = val_19 / val_23;
            val_23 = val_23 - val_20;
            this.idleAlphaY = val_23;
            UnityEngine.Quaternion val_4 = this.tower.localRotation;
            UnityEngine.Quaternion val_5 = this.tower.localRotation;
            val_24 = this.tower;
            UnityEngine.Quaternion val_6 = val_24.localRotation;
            val_6.z = val_20 + val_6.z;
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_19 = val_7.x;
            val_25 = val_7.z;
            val_21 = val_19;
            val_22 = val_7.y;
            val_20 = val_25;
            this.tower.localRotation = new UnityEngine.Quaternion() {x = val_21, y = val_22, z = val_20, w = val_7.w};
        }
        
        if(this.gun == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_9 = this.gun.localRotation;
        val_19 = UnityEngine.Mathf.DeltaAngle(current:  val_9.x, target:  -this.idleGunXConstantAngle);
        val_25 = System.Math.Abs(val_19);
        if(val_25 <= 1f)
        {
                return;
        }
        
        val_26 = this.speedRotateX * UnityEngine.Time.deltaTime;
        if(val_25 > val_26)
        {
                float val_12 = UnityEngine.Time.deltaTime;
            val_12 = this.idleRotateSpeedX * val_12;
            val_26 = -(val_25 * val_12);
            val_27 = val_26 / val_19;
        }
        else
        {
                val_27 = -val_19;
        }
        
        UnityEngine.Quaternion val_13 = this.gun.localRotation;
        val_24 = this.gun;
        UnityEngine.Quaternion val_14 = val_24.localRotation;
        val_18 = this.gun;
        UnityEngine.Quaternion val_15 = val_18.localRotation;
        float val_16 = val_13.x - val_27;
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_19 = val_17.x;
        val_25 = val_17.z;
        this.gun.localRotation = new UnityEngine.Quaternion() {x = val_19, y = val_17.y, z = val_25, w = val_17.w};
    }
    protected override void 丗丅世且丛丑业世丑()
    {
        float val_77;
        丅丙上七上一丐不下 val_78;
        float val_79;
        UnityEngine.Object val_80;
        float val_83;
        float val_84;
        float val_85;
        float val_86;
        float val_87;
        float val_88;
        float val_89;
        float val_90;
        var val_92;
        var val_93;
        float val_95;
        float val_96;
        float val_97;
        float val_98;
        var val_99;
        val_77 = 0;
        if((137125888 != 0) && ((mem[137125912] + 1389) != 0))
        {
                mem[1152921540620543488] = 0;
            mem[1152921540620543496] = 0;
        }
        
        if(mem[137125912] == 0)
        {
            goto label_9;
        }
        
        val_78 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  mem[137125912]);
        if(val_78 == null)
        {
            goto label_12;
        }
        
        bool val_5 = this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_78);
        goto label_14;
        label_9:
        val_78 = 0;
        goto label_14;
        label_12:
        label_14:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_7 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W23, 丅七上一丈丕上丒丞:  W22).世且一丄且上丄不一();
        val_79 = -1f;
        label_69:
        val_80 = 0;
        label_68:
        var val_80 = 0;
        val_80 = val_80 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_21;
        }
        
        var val_81 = 0;
        val_81 = val_81 + 1;
        T val_11 = val_7.Current;
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Transform val_13 = this.transform;
        UnityEngine.Vector3 val_14 = val_13.position;
        val_83 = val_12.x;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_83, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        丅丙上七上一丐不下 val_16 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_11);
        if(val_16 != null)
        {
                float val_17 = val_16.丌不丙与业一丌丞丁();
        }
        
        if(val_15.x != val_79)
        {
            goto label_35;
        }
        
        goto label_36;
        label_35:
        if(val_16 == null)
        {
            goto label_37;
        }
        
        float val_18 = val_16.丌不丙与业一丌丞丁();
        val_85 = val_18;
        if(val_16 == null)
        {
            goto label_38;
        }
        
        float val_19 = val_16.丌不丙与业一丌丞丁();
        goto label_40;
        label_37:
        val_83 = val_12.x;
        goto label_40;
        label_38:
        label_40:
        val_84 = val_85 * val_18;
        label_36:
        if(((val_15.x >= 0) || (val_15.x >= 0)) || (val_15.x <= val_84))
        {
            goto label_68;
        }
        
        UnityEngine.Vector3 val_20 = val_13.position;
        UnityEngine.Vector3 val_21 = val_11.position;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_86 = val_20.y;
        val_87 = val_20.z;
        val_89 = -(this.丕丏丐丄与丘一丗丙(丞下万上三丘上与专:  val_11));
        val_90 = val_89;
        if((System.Single.IsNaN(f:  val_90)) != false)
        {
                val_89 = 45f;
            val_90 = val_20.x;
            val_86 = val_20.y;
            val_87 = val_20.z;
            val_88 = 下且丏世下丝上丂丌.与下丌丘丗上丄丞与(与与丕丁且丐丘丆东:  new UnityEngine.Vector3() {x = val_90, y = val_86, z = val_87}, 丌丛丒与丝且丗万与:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, 一不丅与丟丌丏丟东:  val_89);
        }
        
        UnityEngine.Vector3 val_27 = val_13.position;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_86, z = val_87}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z})) * 0.5f);
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  下且丏世下丝上丂丌.上东上丕一丈丆东与(丛上丟丌丄丗丁世与:  val_88, 一不丅与丟丌丏丟东:  val_89));
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        UnityEngine.Vector3 val_35 = val_13.position;
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
        UnityEngine.Vector3 val_37 = val_13.position;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, direction:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, maxDistance:  val_37.x, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) == true)
        {
            goto label_68;
        }
        
        UnityEngine.Vector3 val_41 = val_11.transform.position;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  0f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) == false)
        {
            goto label_69;
        }
        
        丅丙上七上一丐不下 val_45 = 0f.GetComponentInParent<丅丙上七上一丐不下>();
        if(val_45 == null)
        {
            goto label_68;
        }
        
        var val_82 = 0;
        val_82 = val_82 + 1;
        if(val_45.transform != val_11)
        {
            goto label_68;
        }
        
        goto label_69;
        label_21:
        val_92 = 0;
        val_93 = 0;
        if(val_7 == null)
        {
            
        }
        else
        {
                var val_83 = 0;
            val_83 = val_83 + 1;
            val_7.Dispose();
        }
        
        if(UnityEngine.Object.__il2cppRuntimeField_cctor_finished == 0)
        {
            goto label_137;
        }
        
        UnityEngine.Vector3 val_52 = position;
        val_95 = val_52.z;
        UnityEngine.Transform val_53 = this.transform;
        UnityEngine.Vector3 val_54 = val_53.position;
        val_96 = val_54.y;
        val_77 = val_52.x;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_77, y = val_52.y, z = val_95}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_96, z = val_54.z});
        if(0 != 0)
        {
                float val_56 = 0.丌不丙与业一丌丞丁();
        }
        
        if(val_55.x != val_79)
        {
            goto label_131;
        }
        
        goto label_132;
        label_131:
        if(0 == 0)
        {
            goto label_133;
        }
        
        float val_57 = 0.丌不丙与业一丌丞丁();
        val_98 = val_57;
        if(0 == 0)
        {
            goto label_134;
        }
        
        float val_58 = 0.丌不丙与业一丌丞丁();
        goto label_136;
        label_133:
        val_77 = val_52.x;
        goto label_136;
        label_134:
        label_136:
        val_97 = val_98 * val_57;
        label_132:
        if(val_57 < 0)
        {
                mem[1152921540620543488] = 0;
        }
        
        label_137:
        if(((val_53 == 0) || (val_80 == 0)) || (val_53 == val_80))
        {
            goto label_146;
        }
        
        UnityEngine.Vector3 val_62 = val_80.position;
        UnityEngine.Transform val_63 = this.transform;
        UnityEngine.Vector3 val_64 = val_63.position;
        val_96 = val_64.y;
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, b:  new UnityEngine.Vector3() {x = val_64.x, y = val_96, z = val_64.z});
        UnityEngine.Vector3 val_66 = val_63.position;
        val_95 = val_66.z;
        UnityEngine.Vector3 val_68 = this.transform.position;
        val_77 = val_66.x;
        UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_77, y = val_66.y, z = val_95}, b:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
        val_97 = val_69.x;
        val_99 = null;
        var val_70 = ((UnityEngine.Object.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
        if(val_97 < 0)
        {
            goto label_153;
        }
        
        label_160:
        var val_84 = 0;
        val_84 = val_84 & (UnityEngine.Object.op_Inequality(x:  val_53, y:  0));
        if(val_84 == false)
        {
                return;
        }
        
        不七世丁丟丏世业丑 val_72 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  val_78);
        val_80.SendRemoveTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_72.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_72.丏与丅下丞丗与七下);
        return;
        label_146:
        val_99 = null;
        var val_74 = ((UnityEngine.Object.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
        if(val_80 == 0)
        {
            goto label_160;
        }
        
        label_153:
        if(val_80 == val_53)
        {
                return;
        }
        
        float val_76 = UnityEngine.Time.time;
        if(val_97 >= 0)
        {
                return;
        }
        
        不七世丁丟丏世业丑 val_78 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_80));
        val_80.SendSetTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_78.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_78.丏与丅下丞丗与七下);
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_37;
        float val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        val_37 = 1152921504848912384;
        if(137125888 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  137125888);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.z);
        UnityEngine.Vector3 val_4 = this.tower.position;
        UnityEngine.Vector3 val_5 = this.tower.position;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_5.z);
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Quaternion val_8 = this.tower.rotation;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.up;
        float val_36 = val_7.x;
        val_10.y = (UnityEngine.Mathf.Sign(f:  val_7.x)) * (UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, to:  new UnityEngine.Vector2() {x = val_36, y = val_7.y}));
        val_38 = this.speedRotateY;
        float val_39 = this.丐丟丅东且东丑丄丞(丅丝东三专且上丁业:  val_8.y, 丕东丑丂丅丈丆专丁:  val_10.y);
        float val_14 = UnityEngine.Mathf.Sign(f:  val_39);
        float val_15 = val_38 * UnityEngine.Time.deltaTime;
        val_36 = val_15 * val_14;
        val_14 = -(val_15 * val_14);
        float val_38 = System.Math.Abs(val_39);
        val_39 = -val_39;
        val_39 = (System.Math.Abs(val_36) > val_38) ? (val_39) : (val_14);
        val_40 = 0.001f;
        val_41 = System.Math.Abs(val_39);
        if(val_41 > val_40)
        {
                val_40 = 0f;
            val_41 = 0f;
            val_39 = val_39;
            this.tower.Rotate(xAngle:  val_40, yAngle:  val_41, zAngle:  val_39);
        }
        
        float val_16 = this.丕丏丐丄与丘一丗丙(丞下万上三丘上与专:  0);
        mem[1152921540620750196] = val_16;
        if(this.gun != 0)
        {
                UnityEngine.Quaternion val_20 = this.gun.localRotation;
            val_43 = ((System.Single.IsNaN(f:  -val_16)) != true) ? -45f : (-val_16);
            val_44 = UnityEngine.Mathf.DeltaAngle(current:  val_20.x, target:  val_43);
            float val_40 = System.Math.Abs(val_44);
            if(val_40 > 1f)
        {
                val_45 = this.speedRotateX * UnityEngine.Time.deltaTime;
            if(val_40 > val_45)
        {
                val_45 = val_44;
            val_43 = this.speedRotateX * UnityEngine.Time.deltaTime;
            val_46 = val_43 * (UnityEngine.Mathf.Sign(f:  val_45));
        }
        
            UnityEngine.Quaternion val_25 = this.gun.localRotation;
            UnityEngine.Quaternion val_26 = this.gun.localRotation;
            UnityEngine.Quaternion val_27 = this.gun.localRotation;
            float val_28 = val_46 + val_25.x;
            UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_42 = val_29.x;
            val_38 = val_29.z;
            this.gun.localRotation = new UnityEngine.Quaternion() {x = val_42, y = val_29.y, z = val_38, w = val_29.w};
        }
        
            var val_30 = (val_40 < 0) ? 1 : 0;
        }
        else
        {
                val_37 = 1;
        }
        
        bool val_34 = ((val_38 < 0) ? 1 : 0) & (this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.gun)));
        val_34 = val_37 & val_34;
        if(val_34 != true)
        {
                return;
        }
        
        bool val_35 = this.丄业丟丌丏丁上丑丛();
    }
    public override void ShotArtillery(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕)
    {
        this.ShotArtillery(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕);
    }
    protected override void Update()
    {
        if(true != 0)
        {
                if(((true != 0) ? 1 : 0) != ((W9 != 0) ? 1 : 0))
        {
                mem[1152921540621105096] = true;
        }
        
        }
        
        this.下专专专丄世丗且丐();
        if(this.gun != 0)
        {
                UnityEngine.Quaternion val_4 = this.gun.rotation;
            this.业专丑丐丕专丟丆丆 = val_4;
            mem[1152921540621105336] = val_4.y;
            mem[1152921540621105340] = val_4.z;
            mem[1152921540621105344] = val_4.w;
        }
        
        if(this.tower == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_6 = this.tower.rotation;
        this.丄丌业不不丆丙丈丑 = val_6;
        mem[1152921540621105352] = val_6.y;
        mem[1152921540621105356] = val_6.z;
        mem[1152921540621105360] = val_6.w;
    }
    protected override void LateUpdate()
    {
        if(true == 0)
        {
                return;
        }
        
        if(this.tower != 0)
        {
                this.tower.rotation = new UnityEngine.Quaternion() {x = this.丄丌业不不丆丙丈丑, y = V9.16B, z = V10.16B, w = V11.16B};
        }
        
        if(this.gun == 0)
        {
                return;
        }
        
        this.gun.rotation = new UnityEngine.Quaternion() {x = this.业专丑丐丕专丟丆丆, y = V9.16B, z = V10.16B, w = V11.16B};
    }
    public TurretControllerScene_Artillery_Tower()
    {
        mem2[0] = ;
        this.speedRotateY = 100f;
        this.speedRotateX = 100f;
        mem[1152921540621378332] = 1101004800;
        mem[1152921540621378340] = 1045220557;
        mem[1152921540621378376] = 1014350479;
        mem[1152921540621378416] = 1056964608;
        mem[1152921540621378428] = 1065353216;
        val_1 = new TurretControllerScene();
    }

}
