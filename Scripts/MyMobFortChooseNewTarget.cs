using UnityEngine;
internal sealed class MyMobFortChooseNewTarget : MobChooseNewTarget
{
    // Fields
    internal MyMobsCurrentAiState 丈专世丌三丝东万东;
    internal 且丝丈东丂丁且丘七 且三丕三丕丈下丕丝;
    internal System.Collections.Generic.List<且业且丙上三与东丕> 专丐丛丆与专世丆丂;
    private PatrolModifierMoveInRadius 丅丙丏丈丄丟丛丆且;
    
    // Methods
    internal void 专丒东丝丕丟一专专(PatrolModifierMoveInRadius 丟丝上丄丂三丞且丄)
    {
        this.丅丙丏丈丄丟丛丆且 = 丟丝上丄丂三丞且丄;
    }
    protected override void 业丂丛丟上且丂东丂(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, float 丞丈专下丈专业三丞)
    {
        if(丛世一丟丞丁业丘丒 == null)
        {
                return;
        }
    
    }
    private void Update()
    {
        var val_25;
        var val_43;
        var val_44;
        float val_46;
        float val_47;
        float val_48;
        var val_49;
        var val_50;
        var val_51;
        UnityEngine.Object val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_43 = this;
        if(137105408 != 0)
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
        
        val_44 = 0;
        if( == 0)
        {
            goto label_32;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        if(val_4.IsDead() == true)
        {
            goto label_32;
        }
        
        UnityEngine.Transform val_10 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_11 = val_10.position;
        val_46 = val_11.z;
        UnityEngine.Vector3 val_14 = val_10.currentTarget.transform.position;
        val_47 = val_14.y;
        float val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_46}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_47, z = val_14.z});
        val_48 = val_15;
        if(val_48 > val_15)
        {
            goto label_32;
        }
        
        label_10:
        val_49 = 1152921540129838952;
        if(this.丅丙丏丈丄丟丛丆且 == 0)
        {
            goto label_49;
        }
        
        val_50 = 0;
        if( == 0)
        {
            goto label_49;
        }
        
        var val_48 = X21;
        if((X21 + 286) == 0)
        {
            goto label_46;
        }
        
        var val_46 = X21 + 176;
        var val_47 = 0;
        val_46 = val_46 + 8;
        label_45:
        if(((X21 + 176 + 8) + -8) == null)
        {
            goto label_44;
        }
        
        val_47 = val_47 + 1;
        val_46 = val_46 + 16;
        if(val_47 < (X21 + 286))
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        val_48 = val_48 + (((X21 + 176 + 8)) << 4);
        val_51 = val_48 + 296;
        label_46:
        val_52 = X21.transform;
        UnityEngine.Vector3 val_20 = val_52.position;
        val_48 = val_20.x;
        val_46 = val_20.z;
        if((this.丅丙丏丈丄丟丛丆且 & 1) != 0)
        {
            goto label_49;
        }
        
        label_32:
        val_49 = val_43;
        this.丈专世丌三丝东万东.丌万丑丂丗丅丘丄丑 = false;
        mem[1152921540129838952] = 0;
        this.丈专世丌三丝东万东.SetTargetForced(丞下万上三丘上与专:  0);
        label_49:
        val_53 = 0;
        if( != 0)
        {
                return;
        }
        
        val_54 = 1152921505189965824;
        val_55 = null;
        val_55 = null;
        List.Enumerator<T> val_23 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.GetEnumerator();
        val_56 = 1152921504838316032;
        val_57 = 0;
        goto label_89;
        label_90:
        val_52 = val_25.丐丏七丌丕丗业且上();
        if(((val_52 == 0) || (X22 == 0)) || ((X22 + 208) == 0))
        {
            goto label_89;
        }
        
        if((X22 + 208 + 208 + 96) == 0)
        {
            goto label_77;
        }
        
        UnityEngine.Vector3 val_32 = val_52.transform.position;
        val_48 = val_32.x;
        val_46 = val_32.z;
        val_56 = val_56;
        val_54 = 1152921505189965824;
        if(((X22 + 208 + 208 + 96 + 208 + 96) & 1) == 0)
        {
            goto label_89;
        }
        
        label_77:
        UnityEngine.Vector3 val_34 = this.丌丟丄业且三丛丕丄().position;
        val_48 = val_34.x;
        val_46 = val_34.z;
        UnityEngine.Vector3 val_36 = val_52.transform.position;
        val_47 = val_36.y;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_48, y = val_34.y, z = val_46}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_47, z = val_36.z})) < 0)
        {
                val_57 = val_52;
        }
        
        label_89:
        if((1163241328 & 1) != 0)
        {
            goto label_90;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(mem[1152921540129838952] == 0)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_40 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  mem[1152921540129838952].transform);
        val_52 = 1152921505240178688;
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_40.IsDead() == true)
        {
                return;
        }
        
        this.丈专世丌三丝东万东.丌万丑丂丗丅丘丄丑 = true;
        mem[1152921540129838952] = val_40;
        var val_50 = 0;
        val_50 = val_50 + 1;
        this.SetTargetForced(丞下万上三丘上与专:  val_40.transform);
    }
    public MyMobFortChooseNewTarget()
    {
        this.专丐丛丆与专世丆丂 = new System.Collections.Generic.List<且业且丙上三与东丕>();
        this = new PGBehaviour();
    }

}
