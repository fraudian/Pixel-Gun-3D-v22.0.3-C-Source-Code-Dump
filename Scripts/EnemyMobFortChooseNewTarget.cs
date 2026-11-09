using UnityEngine;
internal sealed class EnemyMobFortChooseNewTarget : MobChooseNewTarget
{
    // Fields
    internal MyMobsCurrentAiState 丈专世丌三丝东万东;
    internal 且丝丈东丂丁且丘七 且三丕三丕丈下丕丝;
    internal System.Collections.Generic.List<且业且丙上三与东丕> 专丐丛丆与专世丆丂;
    private PatrolModifierMoveInRadius 丅丙丏丈丄丟丛丆且;
    private float 丐丞丗丙丑丟丅丌万;
    
    // Methods
    internal void 专丒东丝丕丟一专专(PatrolModifierMoveInRadius 丟丝上丄丂三丞且丄)
    {
        this.丅丙丏丈丄丟丛丆且 = 丟丝上丄丂三丞且丄;
    }
    protected override void 业丂丛丟上且丂东丂(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, float 丞丈专下丈专业三丞)
    {
        float val_7;
        RilisoftBot.BaseBot val_8;
        val_7 = 丞丈专下丈专业三丞;
        val_8 = 丗不丛七丏丄业三丁;
        this.业丂丛丟上且丂东丂(丗不丛七丏丄业三丁:  val_8, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒, 丞丈专下丈专业三丞:  val_7);
        if(丛世一丟丞丁业丘丒 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        var val_9 = 0;
        val_9 = val_9 + 1;
        UnityEngine.Transform val_4 = 丛世一丟丞丁业丘丒.transform;
        UnityEngine.Vector3 val_5 = val_4.position;
        val_7 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(val_7 >= 0)
        {
                return;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_4.SetTargetForced(丞下万上三丘上与专:  丛世一丟丞丁业丘丒.transform);
        val_8 = this.丈专世丌三丝东万东;
        mem[1152921540094993512] = 丛世一丟丞丁业丘丒;
        this.丈专世丌三丝东万东.丌万丑丂丗丅丘丄丑 = true;
    }
    private void Update()
    {
        var val_22;
        var val_84;
        var val_85;
        float val_87;
        float val_88;
        float val_89;
        float val_90;
        float val_91;
        float val_92;
        var val_93;
        var val_94;
        var val_95;
        UnityEngine.Object val_96;
        var val_97;
        var val_98;
        var val_99;
        float val_100;
        float val_101;
        var val_102;
        var val_103;
        var val_105;
        var val_106;
        val_84 = this;
        if(137129984 != 0)
        {
                PhotonView val_2 = photonView;
            if(val_2.isMine == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_4 = val_2.currentTarget;
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        val_85 = 0;
        if( == 0)
        {
            goto label_32;
        }
        
        var val_84 = 0;
        val_84 = val_84 + 1;
        if(val_4.IsDead() == true)
        {
            goto label_32;
        }
        
        UnityEngine.Transform val_10 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_11 = val_10.position;
        val_87 = val_11.z;
        UnityEngine.Vector3 val_14 = val_10.currentTarget.transform.position;
        val_88 = val_14.y;
        val_89 = val_11.y;
        val_90 = val_87;
        float val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_89, z = val_90}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_88, z = val_14.z});
        val_91 = val_15;
        if(val_91 > val_15)
        {
            goto label_32;
        }
        
        label_10:
        val_93 = 1152921540095506984;
        if(this.丅丙丏丈丄丟丛丆且 == 0)
        {
            goto label_49;
        }
        
        val_94 = 0;
        if( == 0)
        {
            goto label_49;
        }
        
        var val_87 = X21;
        if((X21 + 286) == 0)
        {
            goto label_46;
        }
        
        var val_85 = X21 + 176;
        var val_86 = 0;
        val_85 = val_85 + 8;
        label_45:
        if(((X21 + 176 + 8) + -8) == null)
        {
            goto label_44;
        }
        
        val_86 = val_86 + 1;
        val_85 = val_85 + 16;
        if(val_86 < (X21 + 286))
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        val_87 = val_87 + (((X21 + 176 + 8)) << 4);
        val_95 = val_87 + 296;
        label_46:
        val_96 = X21.transform;
        UnityEngine.Vector3 val_20 = val_96.position;
        val_91 = val_20.x;
        val_87 = val_20.z;
        val_92 = val_91;
        val_89 = val_20.y;
        val_90 = val_87;
        if((this.丅丙丏丈丄丟丛丆且 & 1) != 0)
        {
            goto label_49;
        }
        
        label_32:
        val_93 = val_84;
        this.丈专世丌三丝东万东.丌万丑丂丗丅丘丄丑 = false;
        mem[1152921540095506984] = 0;
        this.SetTarget(丞下万上三丘上与专:  0);
        label_49:
        if(mem[1152921540095506984] != 0)
        {
                if(56 != 0)
        {
                this.SetTarget(丞下万上三丘上与专:  0);
        }
        
            val_96 = mem[1152921540095506984];
            if(val_96 != 0)
        {
                val_96 = 0;
        }
        
            if((val_96 != 0) && (mem[1152921540095506984] != 0))
        {
                UnityEngine.AI.NavMeshPath val_25 = null;
            val_96 = val_25;
            val_25 = new UnityEngine.AI.NavMeshPath();
            UnityEngine.Vector3 val_27 = this.丌丟丄业且三丛丕丄().position;
            val_91 = val_27.x;
            val_87 = val_27.z;
            UnityEngine.Vector3 val_29 = mem[1152921540095506984].transform.position;
            val_92 = val_91;
            val_89 = val_27.y;
            val_90 = val_87;
            bool val_30 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_92, y = val_89, z = val_90}, targetPosition:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, areaMask:  0, path:  val_25);
            UnityEngine.Vector3[] val_31 = val_25.corners;
            if(val_31.Length != 0)
        {
                if(val_96 != null)
        {
                val_97 = val_25.corners;
        }
        else
        {
                val_97 = val_25.corners;
        }
        
            UnityEngine.Vector3[] val_34 = val_25.corners;
            int val_88 = val_34.Length;
            val_88 = val_88 - 1;
            val_96 = (long)val_88;
            var val_89 = 12;
            val_89 = val_97 + (val_96 * val_89);
            UnityEngine.Vector3 val_36 = mem[1152921540095506984].transform.position;
            val_88 = val_36.y;
            val_90 = ((long)(int)((val_34.Length - 1)) * 12) + val_33 + 40;
            val_91 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_34.Length - 1)) * 12) + val_33 + 32, y = ((long)(int)((val_34.Length - 1)) * 12) + val_33 + 32 + 4, z = val_90}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_88, z = val_36.z});
            val_87 = this.丐丞丗丙丑丟丅丌万;
            val_92 = ((long)(int)((val_34.Length - 1)) * 12) + val_33 + 32 + 4;
            val_89 = val_87;
            if(val_91 > (UnityEngine.Mathf.Min(a:  val_92, b:  val_89)))
        {
                this.SetTarget(丞下万上三丘上与专:  0);
        }
        
        }
        
        }
        
        }
        
        val_98 = null;
        val_98 = null;
        List.Enumerator<T> val_39 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_99 = 1152921504838316032;
        label_122:
        if((1128909360 & 1) == 0)
        {
            goto label_85;
        }
        
        string val_41 = val_22.丐丏七丌丕丗业且上();
        if(((long)(int)((val_34.Length - 1)) + 349) != 0)
        {
            goto label_122;
        }
        
        bool val_42 = UnityEngine.Object.op_Implicit(exists:  val_96);
        if(val_96.IsDead() == true)
        {
            goto label_122;
        }
        
        UnityEngine.Vector3 val_45 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_47 = val_41.丌丟丄业且三丛丕丄().position;
        val_100 = val_45.y;
        val_101 = val_45.z;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_100, z = val_101}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z})) >= 0)
        {
            goto label_122;
        }
        
        if(this.丅丙丏丈丄丟丛丆且 == 0)
        {
            goto label_102;
        }
        
        UnityEngine.Vector3 val_51 = val_41.transform.position;
        val_102 = val_51.x;
        val_100 = val_51.y;
        val_101 = val_51.z;
        val_99 = val_99;
        if((this.丅丙丏丈丄丟丛丆且 & 1) == 0)
        {
            goto label_122;
        }
        
        label_102:
        val_103 = val_99;
        new UnityEngine.AI.NavMeshPath() = new UnityEngine.AI.NavMeshPath();
        UnityEngine.Vector3 val_54 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_56 = val_41.transform.position;
        bool val_57 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, targetPosition:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, areaMask:  0, path:  new UnityEngine.AI.NavMeshPath());
        UnityEngine.Vector3[] val_58 = new UnityEngine.AI.NavMeshPath().corners;
        if(val_58.Length == 0)
        {
            goto label_122;
        }
        
        UnityEngine.Vector3[] val_60 = new UnityEngine.AI.NavMeshPath().corners;
        var val_90 = (long)val_60.Length - 1;
        val_90 = new UnityEngine.AI.NavMeshPath().corners + (val_90 * 12);
        UnityEngine.Vector3 val_63 = val_41.transform.position;
        val_88 = val_63.y;
        val_91 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_60.Length - 1)) * 12) + val_59 + 32, y = ((long)(int)((val_60.Length - 1)) * 12) + val_59 + 32 + 4, z = ((long)(int)((val_60.Length - 1)) * 12) + val_59 + 40}, b:  new UnityEngine.Vector3() {x = val_63.x, y = val_88, z = val_63.z});
        val_87 = this.丐丞丗丙丑丟丅丌万;
        float val_65 = UnityEngine.Mathf.Min(a:  ((long)(int)((val_60.Length - 1)) * 12) + val_59 + 32 + 4, b:  val_87);
        if(val_91 >= 0)
        {
            goto label_122;
        }
        
        this.SetTarget(丞下万上三丘上与专:  0);
        label_85:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(mem[1152921540095506984] != 0)
        {
                return;
        }
        
        val_96 = 1152921505327452160;
        if(TankController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(IsDead() == true)
        {
                return;
        }
        
        List.Enumerator<T> val_69 = TankController.丄丘七三上丕世丞业.下丈丕丗丟丘丆丗丅().GetEnumerator();
        val_103 = 1152921540095460368;
        val_105 = 0;
        goto label_167;
        label_177:
        val_96 = val_22.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_72 = val_96.transform.position;
        val_87 = val_72.z;
        UnityEngine.Transform val_73 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_74 = val_73.position;
        val_88 = val_74.y;
        UnityEngine.Vector3 val_75 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_87}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_88, z = val_74.z});
        val_91 = val_75.x;
        if(val_73 != null)
        {
            
        }
        else
        {
                val_106 = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
        }
        
        float val_91 = 6.389921E-43f;
        val_91 = val_72.y * val_91;
        var val_76 = (val_91 < 0) ? 1 : 0;
        var val_77 = (val_91 < 0) ? 1 : 0;
        UnityEngine.Object val_78 = (val_77 != val_76) ? (val_96) : (val_105);
        var val_79 = (val_77 != val_76) ? (val_91) : 1000000f;
        label_167:
        if((1128909328 & 1) != 0)
        {
            goto label_177;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_78 == 0)
        {
                return;
        }
        
        this.SetTarget(丞下万上三丘上与专:  val_78.业丒丁与世丘丕专丝());
        val_96 = 0;
        if(val_78 != 0)
        {
                val_96 = val_78.transform;
        }
        
        this.SetTargetForced(丞下万上三丘上与专:  val_96);
    }
    private void SetTarget(丅丙上七上一丐不下 丞下万上三丘上与专)
    {
        丅丙上七上一丐不下 val_3 = 丞下万上三丘上与专;
        this.丈专世丌三丝东万东.丌万丑丂丗丅丘丄丑 = (val_3 != 0) ? 1 : 0;
        mem[1152921540096004056] = val_3;
        if(val_3 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_3 = val_3.transform;
        }
        
        this.丈专世丌三丝东万东.SetTargetForced(丞下万上三丘上与专:  val_3);
    }
    private void OnDrawGizmosSelected()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.yellow;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        if(this == null)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  1f);
    }
    public EnemyMobFortChooseNewTarget()
    {
        this.专丐丛丆与专世丆丂 = new System.Collections.Generic.List<且业且丙上三与东丕>();
        this.丐丞丗丙丑丟丅丌万 = 3f;
    }

}
