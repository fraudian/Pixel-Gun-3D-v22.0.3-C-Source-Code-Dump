using UnityEngine;
internal sealed class ExplosionAttackTurretRocket : BaseAttackTurretRocket
{
    // Fields
    private bool 丒且上万下丄丑丈不;
    
    // Methods
    protected override void 丁万不且与丞丐丏丈(UnityEngine.Collision 三丑丈且丏业丐丝丗)
    {
        UnityEngine.Collision val_50;
        float val_51;
        float val_52;
        RayAndExplosionsStackController val_53;
        float val_54;
        float val_55;
        var val_56;
        var val_59;
        var val_61;
        val_50 = 三丑丈且丏业丐丝丗;
        if(this.丒且上万下丄丑丈不 == true)
        {
                return;
        }
        
        this.丁万不且与丞丐丏丈(三丑丈且丏业丐丝丗:  val_50);
        丅丙上七上一丐不下 val_2 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_50.collider);
        UnityEngine.Transform val_4 = val_50.transform.root;
        if((val_4.CompareTag(tag:  "Rocket")) == true)
        {
                return;
        }
        
        val_52 = 0.1f;
        if(S0 < 0)
        {
                mem[1152921540133559552] = 1;
        }
        
        if(1 != 0)
        {
                val_53 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟;
            UnityEngine.GameObject val_9 = val_53.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_4)) != true) ? 1166974216 : "Explosion47"));
            if(val_9 != 0)
        {
                UnityEngine.Transform val_11 = val_9.transform;
            val_53 = this.transform;
            UnityEngine.Vector3 val_13 = val_53.position;
            val_54 = val_13.x;
            val_55 = val_13.z;
            val_51 = val_54;
            val_52 = val_13.y;
            val_11.position = new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_55};
        }
        
        }
        
        if(null == 0)
        {
            goto label_20;
        }
        
        if(((val_2 == null) || (val_11 == 0)) || ((val_11.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_2)) == false))
        {
            goto label_101;
        }
        
        val_56 = 0;
        goto label_29;
        label_20:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_17 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  val_11, 丅七上一丈丕上丒丞:  val_50).世且一丄且上丄不一();
        val_53 = 1152921505333575680;
        val_54 = 2f;
        label_63:
        var val_52 = 0;
        val_52 = val_52 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_36;
        }
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        T val_21 = val_17.Current;
        UnityEngine.Vector3 val_22 = val_21.position;
        UnityEngine.Transform val_23 = this.transform;
        UnityEngine.Vector3 val_24 = val_23.position;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        val_25.y = val_25.y * val_25.y;
        if(val_25.x >= 0)
        {
            goto label_63;
        }
        
        丅丙上七上一丐不下 val_26 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_21);
        if((val_26 == null) || ((val_23.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_26)) == false))
        {
            goto label_63;
        }
        
        val_59 = 0;
        float val_29 = this.丈丆丝丑丙丈丒丑丏();
        UnityEngine.Vector3 val_31 = this.transform.position;
        UnityEngine.Transform val_32 = this.transform;
        UnityEngine.Vector3 val_33 = val_32.forward;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_54);
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
        var val_54 = 0;
        val_54 = val_54 + 1;
        float val_37 = val_22.x * val_22.x;
        val_37 = val_29 / val_37;
        val_37 = 1f - val_37;
        val_37 = val_29 * val_37;
        val_26.ApplyDamage(丞丈专下丈专业三丞:  val_37, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_32, 丒丈丐丐丗丐专丈丏:  0);
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_26);
        goto label_63;
        label_36:
        val_61 = 0;
        val_50 = 0;
        if(val_17 != null)
        {
            goto label_64;
        }
        
        goto label_95;
        label_29:
        val_54 = this.丈丆丝丑丙丈丒丑丏();
        val_50 = val_50.collider;
        UnityEngine.Vector3 val_42 = this.transform.position;
        UnityEngine.Transform val_43 = this.transform;
        UnityEngine.Vector3 val_44 = val_43.forward;
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, d:  2f);
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
        val_55 = val_46.y;
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_2.ApplyDamage(丞丈专下丈专业三丞:  val_54, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  val_50, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_46.x, y = val_55, z = val_46.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_43, 丒丈丐丐丗丐专丈丏:  0);
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_2);
        goto label_101;
        label_64:
        var val_56 = 0;
        val_56 = val_56 + 1;
        val_2.Dispose();
        label_95:
        label_101:
        UnityEngine.Object.Destroy(obj:  val_43.gameObject);
        UnityEngine.Vector3 val_51 = val_43.transform.position;
        this.丒且上万下丄丑丈不 = true;
    }
    protected override void 业万丗专丈下且丑万(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        丅丙上七上一丐不下 val_52;
        var val_53;
        UnityEngine.Object val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        var val_59;
        var val_62;
        var val_65;
        if(this.丒且上万下丄丑丈不 == true)
        {
                return;
        }
        
        this.业万丗专丈下且丑万(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅);
        val_52 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  丘丛丏丘丝七世七丅);
        if((丘丛丏丘丝七世七丅.transform.root.CompareTag(tag:  "Rocket")) == true)
        {
                return;
        }
        
        UnityEngine.Transform val_6 = 丘丛丏丘丝七世七丅.transform.root;
        val_53 = 1152921504848912384;
        val_54 = X23.transform.root;
        if(val_6 == val_54)
        {
                return;
        }
        
        val_56 = 0.1f;
        if(S0 < 0)
        {
                mem[1152921540133843744] = 1;
        }
        
        if(1 != 0)
        {
                val_54 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟;
            UnityEngine.GameObject val_13 = val_54.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6)) != true) ? 1167258408 : "Explosion47"));
            if(val_13 != 0)
        {
                UnityEngine.Transform val_15 = val_13.transform;
            val_54 = this.transform;
            UnityEngine.Vector3 val_17 = val_54.position;
            val_57 = val_17.x;
            val_58 = val_17.z;
            val_55 = val_57;
            val_56 = val_17.y;
            val_15.position = new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_58};
        }
        
        }
        
        if(null == 0)
        {
            goto label_26;
        }
        
        if(((val_52 == null) || (val_15 == 0)) || ((val_15.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_52)) == false))
        {
            goto label_103;
        }
        
        val_59 = 0;
        goto label_35;
        label_26:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_21 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  val_15, 丅七上一丈丕上丒丞:  val_52).世且一丄且上丄不一();
        val_54 = 1152921505333575680;
        label_67:
        var val_54 = 0;
        val_54 = val_54 + 1;
        if(val_21.MoveNext() == false)
        {
            goto label_42;
        }
        
        var val_55 = 0;
        val_55 = val_55 + 1;
        T val_25 = val_21.Current;
        UnityEngine.Vector3 val_26 = val_25.position;
        UnityEngine.Vector3 val_28 = this.transform.position;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_29.y = val_29.y * val_29.y;
        if(val_29.x >= 0)
        {
            goto label_67;
        }
        
        丅丙上七上一丐不下 val_30 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_25);
        if(val_30 == null)
        {
            goto label_67;
        }
        
        val_62 = 0;
        float val_32 = this.丈丆丝丑丙丈丒丑丏();
        UnityEngine.Vector3 val_34 = this.transform.position;
        UnityEngine.Transform val_35 = this.transform;
        UnityEngine.Vector3 val_36 = val_35.forward;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  2f);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        var val_56 = 0;
        val_56 = val_56 + 1;
        float val_40 = val_26.x * val_26.x;
        val_40 = val_32 / val_40;
        val_40 = 1f - val_40;
        val_40 = val_32 * val_40;
        val_30.ApplyDamage(丞丈专下丈专业三丞:  val_40, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_35, 丒丈丐丐丗丐专丈丏:  0);
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_30);
        goto label_67;
        label_35:
        val_57 = this.丈丆丝丑丙丈丒丑丏();
        UnityEngine.Vector3 val_44 = this.transform.position;
        UnityEngine.Transform val_45 = this.transform;
        UnityEngine.Vector3 val_46 = val_45.forward;
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  2f);
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        val_58 = val_48.y;
        var val_57 = 0;
        val_57 = val_57 + 1;
        val_52.ApplyDamage(丞丈专下丈专业三丞:  val_57, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  丘丛丏丘丝七世七丅, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_48.x, y = val_58, z = val_48.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_45, 丒丈丐丐丗丐专丈丏:  0);
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_52);
        goto label_103;
        label_42:
        val_65 = 0;
        val_52 = 0;
        if(val_21 == null)
        {
            
        }
        else
        {
                var val_58 = 0;
            val_58 = val_58 + 1;
            val_21.Dispose();
        }
        
        label_103:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        UnityEngine.Vector3 val_53 = this.transform.position;
        this.丒且上万下丄丑丈不 = true;
    }
    private void 丈丒丟丕丗丒丕一丛(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        UnityEngine.GameObject val_7;
        var val_8;
        var val_9;
        val_7 = 丂丈丙且丈丗三丆丕;
        if(true == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(val_7 != null)
        {
                val_9 = null;
            val_9 = null;
            var val_1 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_9) ? (val_7) : 0;
        }
        
        val_7 = 0.gameObject;
        UnityEngine.Vector3 val_4 = this.transform.position;
        float val_5 = this.丈丆丝丑丙丈丒丑丏();
        丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_7, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
    }
    protected override void 丞丌丏丂丟东丕丞不(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_21;
        float val_22;
        var val_26;
        var val_27;
        val_21 = 业丒丝丗与丐丛丟丏.z;
        val_22 = 业丒丝丗与丐丛丟丏.x;
        this.丞丌丏丂丟东丕丞不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_22, y = 业丒丝丗与丐丛丟丏.y, z = val_21});
        if(137109504 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  137109504);
        val_2.transform.position = new UnityEngine.Vector3() {x = val_22, y = 业丒丝丗与丐丛丟丏.y, z = val_21};
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_22 = val_5.z;
        val_2.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_22, w = val_5.w};
        DamageInRadiusEffect val_6 = val_2.GetComponent<DamageInRadiusEffect>();
        if(val_6 == 0)
        {
            goto label_13;
        }
        
        float val_8 = this.丈丆丝丑丙丈丒丑丏();
        if(W22 != 0)
        {
                val_22 = this.丈丆丝丑丙丈丒丑丏();
            val_6.丕丙丝丞丐丐三丄丝(三一丝且丝丛不丄丐:  W22, 丂丐丈丕丞下丁下丘:  1f, 丒丙丘丕且一丞丕丑:  val_8 * val_5.w, 丂上上不一丐业一丕:  W23, 丒下世丝丂万丑丏下:  val_22 * S12, 万丗丛丐丅丄七不丅:  val_5.y, 丂三丟丂丈丐丆丗丟:  1f, 丝三丛且丘不丌丙下:  X24, 东丏业丞丞业下丄世:  W25, 丅业下不东丗丄与三:  20, 丌丛丑三丆丘万丘丛:  false);
        }
        else
        {
                val_8 = val_8 * val_22;
            val_6.丆丌且丙丝不万丂丆(丒下世丝丂万丑丏下:  val_8, 万丗丛丐丅丄七不丅:  val_5.y, 丂三丟丂丈丐丆丗丟:  1f, 丝三丛且丘不丌丙下:  X22, 东丏业丞丞业下丄世:  W23, 丅业下不东丗丄与三:  20);
        }
        
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_14 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W24, 丅七上一丈丕上丒丞:  W23).世且一丄且上丄不一();
        label_31:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_24;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        new System.Collections.Generic.List<UnityEngine.Transform>().Add(item:  val_14.Current);
        goto label_31;
        label_24:
        val_26 = 0;
        val_27 = 0;
        if(val_14 == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_14.Dispose();
        }
        
        val_6.下丞与与三上丟丙与(专丒丗与东丗与丙业:  true, 世一丅丌专丕东丑丗:  (val_14 != 0) ? 1 : 0);
        label_13:
        if((val_2.GetComponent<FortSlowdownZone>()) != 0)
        {
                val_21.slowdownCoeff = val_14;
        }
        
        if(val_8 <= 0f)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2, t:  val_8);
    }
    public ExplosionAttackTurretRocket()
    {
    
    }

}
