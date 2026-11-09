using UnityEngine;
private sealed class Rocket.丕丏丒上丅丈东丁三 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丕丏丒上丅丈东丁三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RocketSettings val_69;
        int val_70;
        var val_71;
        RocketSettings val_72;
        float val_73;
        UnityEngine.Vector3 val_75;
        float val_76;
        float val_77;
        float val_78;
        RocketSettings val_79;
        RocketSettings val_80;
        var val_81;
        var val_82;
        UnityEngine.Transform val_83;
        UnityEngine.Transform val_84;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_69 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_69 != 0)
        {
            goto label_5;
        }
        
        val_70 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_70;
        return (bool)val_70;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        label_156:
        val_71 = 0;
        goto label_9;
        label_5:
        if((this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 != false) && (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 31))
        {
                if(this.丝且与丝丒丟万丁专.丝丑丕且丈丈专业丛 != null)
        {
                this.丝且与丝丒丟万丁专.StopCoroutine(routine:  this.丝且与丝丒丟万丁专.丝丑丕且丈丈专业丛);
        }
        
            this.丝且与丝丒丟万丁专.丝丑丕且丈丈专业丛 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丄业丙丝丐丌丏丆三());
        }
        
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.explosionName, b:  System.String.alignConst)) != false)
        {
                this.丝且与丝丒丟万丁专.一丐丙丒下丗丙丟三 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.explosionName;
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.smokeEffects == null)
        {
            goto label_18;
        }
        
        val_72 = 1;
        goto label_19;
        label_26:
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.smokeEffects[(long)this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上].SetActive(value:  (val_72 == this.丝且与丝丒丟万丁专.丗丑丞丗七业丆丙丁) ? 1 : 0);
        val_72 = 2;
        label_19:
        if((val_72 - 1) < this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.smokeEffects.Length)
        {
            goto label_26;
        }
        
        label_18:
        this.丝且与丝丒丟万丁专.万丝一万丐且丌业丛 = false;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isBFG == false)
        {
            goto label_28;
        }
        
        val_72 = 0;
        this.丝且与丝丒丟万丁专.东丞一丛丙丙丆丐丛 = new float[0];
        goto label_31;
        label_38:
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.bfgLightnings[0].丆世与丑丆丅丐万且();
        val_72 = 1;
        label_31:
        if(val_72 < this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.bfgLightnings.Length)
        {
            goto label_38;
        }
        
        label_28:
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_92;
        }
        
        this.丝且与丝丒丟万丁专.丐丏丘万丛一丛丅七 = 0;
        this.丝且与丝丒丟万丁专.专丂丝七上一丏丛丕 = 0;
        this.丝且与丝丒丟万丁专.万丂业且丂丕丂丞一 = false;
        this.丝且与丝丒丟万丁专.丝业丏丙上丟业丛丁 = this.丝且与丝丒丟万丁专.丂丞一丑丅与丏丙丅;
        this.丝且与丝丒丟万丁专.专丛不丞丟丌上丝下 = 0;
        this.丝且与丝丒丟万丁专.不丘丝丟丞丘专丆丅(丙业与丙丗丝不丈东:  0);
        this.丝且与丝丒丟万丁专.丞七且丄丟下东丕一 = 0;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isBFG != false)
        {
                this.丝且与丝丒丟万丁专.丛丛业与丅丛业上万 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丝丈丝三丁丛丏世丄 = 0;
        this.丝且与丝丒丟万丁专.万世丄一丅丌丑丌丈 = 0;
        this.丝且与丝丒丟万丁专.业丄丒下丝世丘丁丅 = 0;
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.丂万丞丁不专丝三丟 = 1f;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.spiralRandomStartAngle == false)
        {
            goto label_44;
        }
        
        val_73 = (float)UnityEngine.Random.Range(min:  0, max:  104);
        goto label_45;
        label_7:
        val_70 = 0;
        return (bool)val_70;
        label_8:
        val_71 = 1;
        label_9:
        val_72 = 1152921504848912384;
        val_69 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟();
        if(val_69 == 0)
        {
            goto label_58;
        }
        
        Player_move_c val_11 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟();
        val_69 = val_11.myPlayerTransform;
        if(val_69.childCount == 0)
        {
            goto label_58;
        }
        
        val_69 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕();
        if(val_69 == 0)
        {
            goto label_58;
        }
        
        val_69 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕().丞丗丒丒丗丘东丗丝();
        if(val_69 != 0)
        {
            goto label_64;
        }
        
        label_58:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_70 = 1;
        return (bool)val_70;
        label_44:
        UnityEngine.Quaternion val_21 = this.丝且与丝丒丟万丁专.transform.rotation;
        label_45:
        this.丝且与丝丒丟万丁专.上七且丙且万下丄丕 = val_21.z;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 21)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.丅丆万丙丕丕丞丁丁().enabled = true;
        }
        
        if((this.丝且与丝丒丟万丁专.丈丞丂丏且丙业丐丈(丁丂且丝丐与东上丈:  this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上)) != false)
        {
                this.丝且与丝丒丟万丁专.丂丝不一丑下三七业().useGravity = true;
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.DynamicCollisionCollider != false)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.丗丆三丂丁万专丕丞();
        }
        else
        {
                this.丝且与丝丒丟万丁专.丆丑丘专上业一丟丗().size = new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.sizeBoxCollider, y = V9.16B, z = V10.16B};
            val_72 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
            val_75 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.centerBoxCollider;
            val_77 = val_75;
            val_78 = V9.16B;
            val_73 = V10.16B;
            this.丝且与丝丒丟万丁专.丆丑丘专上业一丟丗().center = new UnityEngine.Vector3() {x = val_77, y = val_78, z = val_73};
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly != 13)
        {
                if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly != 27)
        {
            goto label_84;
        }
        
        }
        
        val_79 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != null)
        {
            goto label_85;
        }
        
        val_79 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_79 == null)
        {
            goto label_101;
        }
        
        label_85:
        val_76 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.chargeScaleMin;
        val_75 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.chargeScaleMax;
        val_77 = val_76;
        val_78 = val_75;
        val_73 = this.丝且与丝丒丟万丁专.丗丕不万万丅丄丕丅;
        float val_28 = UnityEngine.Mathf.Lerp(a:  val_77, b:  val_78, t:  val_73);
        UnityEngine.Vector3 val_30 = this.丝且与丝丒丟万丁专.丆丑丘专上业一丟丗().size;
        label_84:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 29)
        {
                this.丝且与丝丒丟万丁专.丏且与丏丝不一下丝 = 0;
        }
        
        label_92:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 13)
        {
            goto label_94;
        }
        
        val_69 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly != 27)
        {
            goto label_96;
        }
        
        label_94:
        val_69 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.transform;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
        val_72 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        val_80 = val_72;
        if(val_72 != null)
        {
            goto label_100;
        }
        
        val_80 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_80 == null)
        {
            goto label_101;
        }
        
        label_100:
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  UnityEngine.Mathf.Lerp(a:  this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.chargeScaleMin, b:  this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.chargeScaleMax, t:  this.丝且与丝丒丟万丁专.丗丕不万万丅丄丕丅));
        val_75 = val_34.x;
        val_76 = val_34.z;
        val_69.localScale = new UnityEngine.Vector3() {x = val_75, y = val_34.y, z = val_76};
        label_96:
        if((this.丝且与丝丒丟万丁专.丐丙东丏丂业与业丂 == false) || (this.丝且与丝丒丟万丁专.丞丆下丆丄万丝下世 == false))
        {
            goto label_106;
        }
        
        if(this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不() == 0)
        {
            goto label_111;
        }
        
        val_69 = this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不();
        if(val_37.harpoon == false)
        {
            goto label_111;
        }
        
        label_106:
        this.丝且与丝丒丟万丁专.与丅丟丐丄丑丒业丞();
        label_178:
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 != false)
        {
                this.丝且与丝丒丟万丁专.专下丟丈丙下一丟丟();
            if((this.丝且与丝丒丟万丁专.丞三与丑业业丕丗丞 != false) && (GameConnect.丒上世丑丈丒丒与丕() != false))
        {
                val_69 = 1152921504848912384;
            if(this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕() != 0)
        {
                WeaponSounds val_43 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕();
            if(val_43.harpoonStartPoint != 0)
        {
                ContinuousTrail val_45 = this.丝且与丝丒丟万丁专.GetComponentInChildren<ContinuousTrail>();
            if(val_45 != 0)
        {
                WeaponSounds val_48 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕();
            val_69 = val_48.harpoonStartPoint;
            val_75 = this.丝且与丝丒丟万丁专.丗世丕丐丑丁丐丟丒;
            val_45.丅丘万不三丏丒与丄(丈丗与丞一上且上上:  val_69, 专丂丕丗丗东世丞下:  this.丝且与丝丒丟万丁专.transform, 丛业上丄丏丛丞丆丕:  val_75);
        }
        
        }
        
        }
        
        }
        
            if((this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 31) && (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.boomerangUseTrail != false))
        {
                ContinuousTrail val_50 = this.丝且与丝丒丟万丁专.GetComponentInChildren<ContinuousTrail>();
            if(val_50 != 0)
        {
                WeaponSounds val_53 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕();
            val_69 = val_53.harpoonStartPoint;
            val_72 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
            val_75 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.boomerangDistance;
            val_50.丅丘万不三丏丒与丄(丈丗与丞一上且上上:  val_69, 专丂丕丗丗东世丞下:  this.丝且与丝丒丟万丁专.transform, 丛业上丄丏丛丞丆丕:  val_75);
        }
        
        }
        
        }
        
        val_81 = 0;
        goto label_143;
        label_147:
        val_69 = this.丝且与丝丒丟万丁专.GetComponentsInChildren<UnityEngine.TrailRenderer>(includeInactive:  true)[0];
        val_69.Clear();
        val_81 = 1;
        label_143:
        if(val_81 < val_55.Length)
        {
            goto label_147;
        }
        
        val_70 = 0;
        this.丝且与丝丒丟万丁专.不丁丗丙丄与东丑丑 = 0;
        return (bool)val_70;
        label_111:
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_156;
        }
        
        val_82 = null;
        val_82 = null;
        int val_58 = (this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟() != WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC) ? 9 : 29;
        if(this.丝且与丝丒丟万丁专.gameObject.layer == val_58)
        {
            goto label_156;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.gameObject, 不东丛三丂丌丑专丆:  val_58);
        goto label_156;
        label_64:
        if((val_71 & 1) != 0)
        {
                val_83 = 448;
            val_84 = 16;
        }
        else
        {
                val_84 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟;
            val_83 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟;
        }
        
        val_84.SetParent(p:  this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕().丞丗丒丒丗丘东丗丝());
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.zero;
        mem[this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟].localPosition = new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z};
        UnityEngine.Quaternion val_66 = UnityEngine.Quaternion.identity;
        mem[this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟].localRotation = new UnityEngine.Quaternion() {x = val_66.x, y = val_66.y, z = val_66.z, w = val_66.w};
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 == 0)
        {
            goto label_178;
        }
        
        UnityEngine.Vector3 val_69 = UnityEngine.Vector3.zero;
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.transform.localPosition = new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z};
        goto label_178;
        label_101:
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Rocket.丕丏丒上丅丈东丁三();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
