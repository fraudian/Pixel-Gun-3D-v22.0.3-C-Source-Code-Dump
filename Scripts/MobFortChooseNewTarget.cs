using UnityEngine;
internal sealed class MobFortChooseNewTarget : MobChooseNewTarget
{
    // Fields
    internal FortCurrentAiState 丈专世丌三丝东万东;
    internal 且丝丈东丂丁且丘七 且三丕三丕丈下丕丝;
    internal System.Collections.Generic.List<且业且丙上三与东丕> 专丐丛丆与专世丆丂;
    internal System.Collections.Generic.List<DamageableObject> 丌丆一七丈丈丄下下;
    private bool 丘丁丆不丂专下丞丟;
    private float 世丙丟上丘上七万万;
    private float 丛丂万丈丐万不与一;
    private float 世丈丟专专丘一丛业;
    private System.Collections.Generic.Dictionary<丅丙上七上一丐不下, float> 丗七丅东丑下丄七丕;
    private UnityEngine.AI.NavMeshPath 丘一七丌丂一上丕专;
    private bool 丏东丁丑丁下下丗丅;
    private float 丐丞丗丙丑丟丅丌万;
    
    // Methods
    private void Awake()
    {
        this.丘一七丌丂一上丕专 = new UnityEngine.AI.NavMeshPath();
    }
    internal override void 丐丑七丈业丝丄东丝(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        mem[1152921540127351960] = 丗不丛七丏丄业三丁;
        mem[1152921540127351968] = 丑丁一丛万丘万丗不;
        this.丘丁丆不丂专下丞丟 = this.专丐丛丆与专世丆丂.Contains(item:  5);
        万七万丂三与丏丘丅 val_3 = 万七万丂三与丏丘丅.丑七不且上丗丁一世();
        丈丝丞下丙七与丙丟 val_5 = val_3.丐下下丅与上东丙丑(三丒丈七东下丌丝丗:  丗不丛七丏丄业三丁.name);
        if(val_5 == null)
        {
                return;
        }
        
        float val_7 = val_3.maxHealth;
        val_7 = val_5.丄不丒专丗丁丟万丂() * val_7;
        this.世丙丟上丘上七万万 = val_7;
    }
    protected override void 业丂丛丟上且丂东丂(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, float 丞丈专下丈专业三丞)
    {
        float val_19;
        System.Collections.Generic.List<且业且丙上三与东丕> val_20;
        var val_22;
        var val_24;
        var val_25;
        val_19 = 丞丈专下丈专业三丞;
        val_20 = 丛丘丟业下丐专丕丑();
        if(val_20.isMine == false)
        {
                return;
        }
        
        if(true == 0)
        {
            goto label_6;
        }
        
        if(丛世一丟丞丁业丘丒 != null)
        {
            goto label_17;
        }
        
        goto label_9;
        label_6:
        if(丛世一丟丞丁业丘丒 == null)
        {
            goto label_9;
        }
        
        val_20 = this.专丐丛丆与专世丆丂;
        if((val_20.Contains(item:  1)) == true)
        {
            goto label_29;
        }
        
        label_17:
        val_20 = this.专丐丛丆与专世丆丂;
        if((val_20.Contains(item:  3)) == false)
        {
            goto label_23;
        }
        
        val_22 = null;
        val_22 = null;
        var val_8 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_22) ? 丛世一丟丞丁业丘丒 : 0;
        val_20 = mem[(丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_22 ? 丛世一丟丞丁业丘丒 : 0 + 24 + 1560];
        val_20 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_22 ? 丛世一丟丞丁业丘丒 : 0 + 24 + 1560;
        if((this.丗七丅东丑下丄七丕.ContainsKey(key:  丛世一丟丞丁业丘丒)) == false)
        {
            goto label_36;
        }
        
        float val_11 = this.丗七丅东丑下丄七丕.Item[丛世一丟丞丁业丘丒];
        val_24 = 1152921540127495184;
        val_11 = val_11 - val_19;
        goto label_38;
        label_23:
        val_25 = 0;
        goto label_39;
        label_9:
        val_25 = 1;
        label_39:
        val_25 = ((((130718704 + (RilisoftBot.BaseBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 1 : 0) | val_25;
        val_20 = this.专丐丛丆与专世丆丂;
        if((val_20.Contains(item:  5)) == false)
        {
                return;
        }
        
        label_29:
        UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
        var val_20 = 0;
        val_20 = val_20 + 1;
        UnityEngine.Vector3 val_18 = 丛世一丟丞丁业丘丒.transform.position;
        val_19 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        if(val_19 >= 0)
        {
                return;
        }
        
        this.SetTarget(丞下万上三丘上与专:  丛世一丟丞丁业丘丒);
        return;
        label_36:
        val_24 = 1152921540127495184;
        label_38:
        this.丗七丅东丑下丄七丕.set_Item(key:  丛世一丟丞丁业丘丒, value:  -val_19);
    }
    private void Update()
    {
        if(137105408 != 0)
        {
                PhotonView val_2 = photonView;
            if((((this.丏东丁丑丁下下丗丅 == true) ? 1 : 0) ^ val_2.isMine) != false)
        {
                PhotonView val_6 = val_2.photonView;
            this.丏东丁丑丁下下丗丅 = val_6.isMine;
            this.SetTarget(丞下万上三丘上与专:  0);
        }
        
        }
        
        if(val_6 != 0)
        {
                if(val_6.photonView.isMine == false)
        {
                return;
        }
        
        }
        
        this.丘专专丑专丑丆上丑();
        this.专丁世丅丆丕上世一();
    }
    private void 丘专专丑专丑丆上丑()
    {
        var val_37;
        丅丙上七上一丐不下 val_100;
        var val_101;
        FortCurrentAiState val_102;
        var val_103;
        var val_104;
        float val_105;
        float val_106;
        float val_107;
        float val_108;
        float val_109;
        float val_110;
        var val_111;
        var val_114;
        var val_115;
        var val_116;
        var val_117;
        var val_124;
        float val_125;
        float val_126;
        var val_127;
        UnityEngine.Transform val_129;
        val_101 = 0;
        if( != 0)
        {
            goto label_9;
        }
        
        val_102 = this.丈专世丌三丝东万东;
        if(val_102 == 0)
        {
            goto label_9;
        }
        
        val_102 = this.丈专世丌三丝东万东;
        if(val_102.丝丄万丈丒丛丗丕与() == true)
        {
            goto label_48;
        }
        
        label_9:
        val_103 = 0;
        if( == 0)
        {
            goto label_17;
        }
        
        var val_106 = mem[137105408];
        if((mem[137105408] + 286) == 0)
        {
            goto label_22;
        }
        
        var val_103 = mem[137105408] + 176;
        var val_104 = 0;
        val_103 = val_103 + 8;
        label_21:
        if(((mem[137105408] + 176 + 8) + -8) == null)
        {
            goto label_20;
        }
        
        val_104 = val_104 + 1;
        val_103 = val_103 + 16;
        if(val_104 < (mem[137105408] + 286))
        {
            goto label_21;
        }
        
        goto label_22;
        label_20:
        var val_105 = val_103;
        val_105 = val_105 + 5;
        val_106 = val_106 + val_105;
        val_104 = val_106 + 296;
        label_22:
        if(IsDead() == true)
        {
            goto label_48;
        }
        
        label_17:
        val_102 = val_102.currentTarget;
        if(val_102 == 0)
        {
            goto label_29;
        }
        
        UnityEngine.Transform val_10 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_11 = val_10.position;
        val_105 = val_11.z;
        UnityEngine.Vector3 val_14 = val_10.currentTarget.transform.position;
        val_106 = val_14.y;
        val_107 = val_11.x;
        val_108 = val_11.y;
        val_109 = val_105;
        float val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_107, y = val_108, z = val_109}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_106, z = val_14.z});
        val_110 = val_15;
        if(==0)
        {
            goto label_48;
        }
        
        if(val_110 <= val_15)
        {
            goto label_41;
        }
        
        goto label_48;
        label_29:
        if(==0)
        {
            goto label_48;
        }
        
        label_41:
        this.丌丌丘七万丁丐丐上();
        goto label_182;
        label_48:
        if((this.专丐丛丆与专世丆丂.Contains(item:  3)) == false)
        {
            goto label_75;
        }
        
        val_114 = null;
        val_114 = null;
        List.Enumerator<T> val_35 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_115 = 1152921525761785056;
        val_116 = 1152921504838316032;
        val_100 = 0;
        goto label_110;
        label_111:
        val_102 = val_37.丐丏七丌丕丗业且上();
        if(((long)(int)((val_26.Length - 1)) + 349) == 0)
        {
                bool val_39 = UnityEngine.Object.op_Implicit(exists:  (long));
            if((long).IsDead() != true)
        {
                UnityEngine.Vector3 val_42 = this.丌丟丄业且三丛丕丄().position;
            val_105 = val_42.z;
            UnityEngine.Vector3 val_44 = val_102.丌丟丄业且三丛丕丄().position;
            val_106 = val_44.y;
            val_108 = val_42.y;
            val_109 = val_105;
            val_110 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_108, z = val_109}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_106, z = val_44.z});
            if(val_110 < 0)
        {
                UnityEngine.Vector3 val_47 = this.丌丟丄业且三丛丕丄().position;
            val_110 = val_47.x;
            val_105 = val_47.z;
            UnityEngine.Vector3 val_49 = val_102.transform.position;
            val_107 = val_110;
            val_108 = val_47.y;
            val_109 = val_105;
            bool val_50 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_107, y = val_108, z = val_109}, targetPosition:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, areaMask:  0, path:  this.丘一七丌丂一上丕专);
            UnityEngine.Vector3[] val_51 = this.丘一七丌丂一上丕专.corners;
            if(val_51.Length != 0)
        {
                UnityEngine.Vector3[] val_53 = this.丘一七丌丂一上丕专.corners;
            val_111 = val_53.Length - 1;
            var val_111 = (long)val_111;
            val_111 = this.丘一七丌丂一上丕专.corners + (val_111 * 12);
            UnityEngine.Vector3 val_55 = val_102.transform.position;
            val_106 = val_55.y;
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_55.x, y = val_106, z = val_55.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
            val_109 = ((long)(int)((val_53.Length - 1)) * 12) + val_52 + 40;
            val_110 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_53.Length - 1)) * 12) + val_52 + 32, y = ((long)(int)((val_53.Length - 1)) * 12) + val_52 + 32 + 4, z = val_109}, b:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z});
            val_105 = this.丐丞丗丙丑丟丅丌万;
            val_107 = ((long)(int)((val_53.Length - 1)) * 12) + val_52 + 32 + 4;
            val_108 = val_105;
            float val_59 = UnityEngine.Mathf.Min(a:  val_107, b:  val_108);
        }
        
        }
        
        }
        
        }
        
        label_110:
        if((1161606640 & 1) != 0)
        {
            goto label_111;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_100 == 0)
        {
            goto label_114;
        }
        
        goto label_181;
        label_75:
        val_100 = 0;
        if(val_100 == 0)
        {
            goto label_114;
        }
        
        goto label_181;
        label_114:
        if(this.丘丁丆不丂专下丞丟 == false)
        {
            goto label_181;
        }
        
        val_111 = 1152921505189965824;
        val_117 = null;
        val_117 = null;
        List.Enumerator<T> val_60 = 丘丛丞且一丅丁丏丐.不世七丗丑丑丅丞丂.GetEnumerator();
        val_115 = 1152921519068955088;
        val_116 = 1152921505063981056;
        val_102 = 0;
        label_170:
        val_100 = val_102;
        label_169:
        if((1161606608 & 1) == 0)
        {
            goto label_149;
        }
        
        丅丙上七上一丐不下 val_63 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_37.丐丏七丌丕丗业且上().transform);
        if((val_63 == null) || (null != null))
        {
            goto label_169;
        }
        
        var val_112 = 0;
        val_112 = val_112 + 1;
        if(val_63.IsDead() == true)
        {
            goto label_169;
        }
        
        UnityEngine.Vector3 val_66 = this.丌丟丄业且三丛丕丄().position;
        var val_113 = 0;
        val_113 = val_113 + 1;
        UnityEngine.Vector3 val_69 = val_63.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z})) >= 0)
        {
            goto label_169;
        }
        
        goto label_170;
        label_149:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_181:
        this.丌丌丘七万丁丐丐上();
        if(val_100 != 0)
        {
            goto label_182;
        }
        
        if((this.丌丆一七丈丈丄下下 == null) || (this.丌丆一七丈丈丄下下.Count < 1))
        {
            goto label_184;
        }
        
        val_100 = this.丌丆一七丈丈丄下下.Item[0];
        if(val_100 == null)
        {
            goto label_237;
        }
        
        var val_114 = 0;
        val_114 = val_114 + 1;
        goto label_190;
        label_184:
        val_100 = 0;
        label_182:
        if((this.丌丆一七丈丈丄下下 == null) || ((val_100 != 0) || (this.丌丆一七丈丈丄下下.Count != 0)))
        {
            goto label_237;
        }
        
        val_100 = 0;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
            goto label_237;
        }
        
        val_100 = FortDefenceLinkController.丄丘七三上丕世丞业.丅上世世丁下上不与();
        val_102 = FortDefenceLinkController.丄丘七三上丕世丞业.下不一万丟上一丐丙();
        if((val_100 != FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor) || (val_102 == 0))
        {
            goto label_203;
        }
        
        val_100 = 0;
        if(val_102 == 0)
        {
            goto label_237;
        }
        
        val_100 = 0;
        if(val_102 == 0)
        {
            goto label_237;
        }
        
        var val_115 = 0;
        val_115 = val_115 + 1;
        goto label_215;
        label_203:
        if(val_100 == null)
        {
            goto label_237;
        }
        
        var val_116 = 0;
        val_116 = val_116 + 1;
        if(val_100.IsDead() == true)
        {
            goto label_246;
        }
        
        UnityEngine.Vector3 val_84 = this.丌丟丄业且三丛丕丄().position;
        val_124 = null;
        val_125 = val_84.x;
        val_126 = val_84.y;
        val_105 = val_84.z;
        var val_117 = 0;
        val_127 = 1152921505240215560;
        val_117 = val_117 + 1;
        goto label_232;
        label_190:
        if(val_100.IsDead() == true)
        {
            goto label_246;
        }
        
        UnityEngine.Vector3 val_88 = this.丌丟丄业且三丛丕丄().position;
        val_124 = null;
        val_125 = val_88.x;
        val_126 = val_88.y;
        val_105 = val_88.z;
        var val_118 = 0;
        val_127 = 1152921505239576584;
        val_118 = val_118 + 1;
        label_232:
        UnityEngine.Vector3 val_91 = val_100.transform.position;
        val_106 = val_91.y;
        val_110 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_125, y = val_126, z = val_105}, b:  new UnityEngine.Vector3() {x = val_91.x, y = val_106, z = val_91.z});
        if(val_110 < 0)
        {
            goto label_237;
        }
        
        label_246:
        val_100 = 0;
        label_237:
        this.SetTarget(丞下万上三丘上与专:  val_100);
        return;
        label_215:
        if(val_102.业丒丁与世丘丕专丝().IsDead() == true)
        {
            goto label_246;
        }
        
        UnityEngine.Vector3 val_96 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_98 = val_102.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_96.x, y = val_96.y, z = val_96.z}, b:  new UnityEngine.Vector3() {x = val_98.x, y = val_98.y, z = val_98.z})) >= 0)
        {
            goto label_246;
        }
        
        this.SetTarget(丞下万上三丘上与专:  val_102.业丒丁与世丘丕专丝());
        val_129 = 0;
        if(val_102 != 0)
        {
                val_129 = val_102.transform;
        }
        
        this.SetTargetForced(丞下万上三丘上与专:  val_129);
    }
    private void 专丁世丅丆丕上世一()
    {
        System.Collections.Generic.Dictionary<丅丙上七上一丐不下, System.Single> val_5;
        丅丙上七上一丐不下 val_6;
        丅丙上七上一丐不下 val_7;
        val_5 = this;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.世丈丟专专丘一丛业 + val_1;
        this.世丈丟专专丘一丛业 = val_1;
        if(val_1 < this.丛丂万丈丐万不与一)
        {
                return;
        }
        
        this.世丈丟专专丘一丛业 = 0f;
        Dictionary.Enumerator<TKey, TValue> val_2 = this.丗七丅东丑下丄七丕.GetEnumerator();
        val_6 = 0;
        label_6:
        val_7 = val_6;
        label_5:
        if((1162139704 & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        if((val_1 <= 0f) || (val_1 < this.世丙丟上丘上七万万))
        {
            goto label_5;
        }
        
        string val_4 = val_3._value._obj.丐丏七丌丕丗业且上();
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_7 == 0)
        {
            
        }
        else
        {
                this.SetTarget(丞下万上三丘上与专:  null);
        }
        
        val_5 = this.丗七丅东丑下丄七丕;
        val_5.Clear();
    }
    private void 丌丌丘七万丁丐丐上()
    {
        goto label_10;
        label_12:
        if(this.丌丆一七丈丈丄下下.Item[0] != 0)
        {
                if(this.丌丆一七丈丈丄下下.Item[0].IsDead() == false)
        {
            goto label_8;
        }
        
        }
        
        this.丌丆一七丈丈丄下下.RemoveAt(index:  0);
        goto label_10;
        label_8:
        0 = 1;
        label_10:
        if(0 < this.丌丆一七丈丈丄下下.Count)
        {
            goto label_12;
        }
    
    }
    internal void 丑七七与丏丟丛业七(System.Collections.Generic.List<UnityEngine.Vector3> 一丅万丒上万七下世)
    {
        var val_19;
        var val_27;
        丅丙上七上一丐不下 val_28;
        var val_29;
        var val_30;
        var val_32;
        var val_34;
        var val_35;
        var val_37;
        var val_38;
        UnityEngine.Transform val_39;
        val_27 = this;
        if(==0)
        {
            goto label_1;
        }
        
        label_28:
        if((this.丌丆一七丈丈丄下下 == null) || ((!=0) || (this.丌丆一七丈丈丄下下.Count != 0)))
        {
            goto label_40;
        }
        
        val_29 = 1152921504848912384;
        val_28 = 0;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
            goto label_40;
        }
        
        val_30 = FortDefenceLinkController.丄丘七三上丕世丞业.丅上世世丁下上不与();
        HitBox val_4 = FortDefenceLinkController.丄丘七三上丕世丞业.下不一万丟上一丐丙();
        if((val_30 != FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor) || (val_4 == 0))
        {
            goto label_14;
        }
        
        val_28 = 0;
        if(val_4 == 0)
        {
            goto label_40;
        }
        
        val_28 = 0;
        if(val_4 == 0)
        {
            goto label_40;
        }
        
        val_28 = val_4.业丒丁与世丘丕专丝();
        var val_28 = 0;
        val_28 = val_28 + 1;
        goto label_26;
        label_1:
        if(this.丌丆一七丈丈丄下下 == null)
        {
            goto label_27;
        }
        
        if(this.丌丆一七丈丈丄下下.Count < 1)
        {
            goto label_28;
        }
        
        val_32 = this.丌丆一七丈丈丄下下.Item[0];
        if(val_32 == null)
        {
            goto label_40;
        }
        
        val_34 = null;
        var val_29 = 0;
        val_35 = 1152921505239576584;
        val_29 = val_29 + 1;
        goto label_39;
        label_14:
        if(val_30 == null)
        {
            goto label_40;
        }
        
        val_34 = null;
        var val_30 = 0;
        val_35 = 1152921505240215560;
        val_30 = val_30 + 1;
        label_39:
        var val_13 = (val_32.IsDead() != true) ? 0 : (val_32);
        goto label_40;
        label_26:
        if(val_28.IsDead() == false)
        {
            goto label_41;
        }
        
        label_27:
        val_28 = 0;
        label_40:
        val_37 = 0;
        if( == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_18 = 一丅万丒上万七下世.GetEnumerator();
        val_29 = 1152921524306282208;
        label_59:
        if((1162467136 & 1) == 0)
        {
            goto label_49;
        }
        
        UnityEngine.Vector3 val_21 = val_19.position;
        var val_33 = 1179403647;
        if(mem[282584257676957] == 0)
        {
            goto label_54;
        }
        
        var val_31 = mem[282584257676847];
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_53:
        if(((mem[282584257676847] + 8) + -8) == null)
        {
            goto label_52;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < mem[282584257676957])
        {
            goto label_53;
        }
        
        goto label_54;
        label_52:
        val_33 = val_33 + (((mem[282584257676847] + 8)) << 4);
        val_38 = val_33 + 296;
        label_54:
        UnityEngine.Vector3 val_23 = val_28.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z})) >= 0)
        {
            goto label_59;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_49:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_28 == 1152921524306284256)
        {
                return;
        }
        
        this.SetTarget(丞下万上三丘上与专:  val_28);
        return;
        label_41:
        this.SetTarget(丞下万上三丘上与专:  val_4.业丒丁与世丘丕专丝());
        val_39 = 0;
        if(val_4 != 0)
        {
                val_39 = val_4.transform;
        }
        
        this.SetTargetForced(丞下万上三丘上与专:  val_39);
    }
    private void SetTarget(丅丙上七上一丐不下 丞下万上三丘上与专)
    {
        var val_5;
        UnityEngine.Transform val_6;
        this.丈专世丌三丝东万东.万丌万丏丌丈且三丗(丙业与丙丗丝不丈东:  (丞下万上三丘上与专 != 0) ? 1 : 0);
        this.丈专世丌三丝东万东.东东专丒三东丂一丕(丙业与丙丗丝不丈东:  丞下万上三丘上与专);
        mem[1152921540129234136] = 丞下万上三丘上与专;
        val_5 = 0;
        val_6 = 0;
        if( != 0)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 丞下万上三丘上与专.transform;
        }
        
        this.SetTargetForced(丞下万上三丘上与专:  val_6);
    }
    public MobFortChooseNewTarget()
    {
        this.专丐丛丆与专世丆丂 = new System.Collections.Generic.List<且业且丙上三与东丕>();
        this.丌丆一七丈丈丄下下 = new System.Collections.Generic.List<DamageableObject>();
        this.丛丂万丈丐万不与一 = 2.5f;
        this.丗七丅东丑下丄七丕 = new System.Collections.Generic.Dictionary<丅丙上七上一丐不下, System.Single>();
        this.丐丞丗丙丑丟丅丌万 = 2f;
        this = new PGBehaviour();
    }

}
