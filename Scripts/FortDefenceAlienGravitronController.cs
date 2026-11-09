using UnityEngine;
internal sealed class FortDefenceAlienGravitronController : FortTrap
{
    // Fields
    public float teleportDistance;
    
    // Methods
    public override void DetectedTarget()
    {
        this.DetectedTarget();
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  1000f, 丞丗且下世丐业丌丙:  0, 丐丟丘世丁三丕专专:  0);
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                this.与丑丄丛丆与丒且丒();
            return;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        this.丝丟丑丐专丁丁七丑();
    }
    private void 与丑丄丛丆与丒且丒()
    {
        var val_4;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_28 = 1152921505189539840;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.GetEnumerator();
        val_30 = 0;
        val_31 = 0;
        var val_30 = 0;
        label_84:
        if(((-47765056) & 1) == 0)
        {
            goto label_7;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_7 = this.transform.position;
        UnityEngine.Vector3 val_9 = val_5.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) >= 0)
        {
            goto label_84;
        }
        
        RilisoftBot.BaseBot val_11 = val_5.GetComponent<RilisoftBot.BaseBot>();
        if((val_11 == 0) || ((val_11.photonView.isMine == false) || (val_11.世丗万丞世丂丂丕丝 == false)))
        {
            goto label_84;
        }
        
        var val_15 = (FortDefenceLinkController.丄丘七三上丕世丞业 == 0) ? 0 : FortDefenceLinkController.丄丘七三上丕世丞业;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == null)
        {
            goto label_23;
        }
        
        val_32 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 == null ? 0 : FortDefenceLinkController.丄丘七三上丕世丞业 + 104];
        val_32 = FortDefenceLinkController.丄丘七三上丕世丞业 == null ? 0 : FortDefenceLinkController.丄丘七三上丕世丞业 + 104;
        if(val_32 != 0)
        {
            goto label_25;
        }
        
        goto label_26;
        label_23:
        val_32 = 0;
        label_26:
        label_25:
        List.Enumerator<T> val_16 = val_32.GetEnumerator();
        label_38:
        if(((-47765088) & 1) == 0)
        {
            goto label_50;
        }
        
        string val_17 = val_4.丐丏七丌丕丗业且上();
        PhotonView val_18 = val_11.photonView;
        object val_27 = val_18.丞丁丝丕世丏丌丞丁[0];
        if(null == 2)
        {
            goto label_38;
        }
        
        PhotonView val_19 = val_11.photonView;
        object val_28 = val_19.丞丁丝丕世丏丌丞丁[1];
        if(val_17.丝一丗且丙丂丌三丁() != null)
        {
            goto label_38;
        }
        
        UnityEngine.Vector3 val_21 = val_17.下专丟世丏丏世世专();
        UnityEngine.Debug.LogError(message:  "New Position " + val_21.x);
        bool val_24 = val_11.下不丌万丙且一万东.丅不丂下丐专丙丗丗().Warp(newPosition:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        val_11.下不丌万丙且一万东.丅不丂下丐专丙丗丗().ResetPath();
        if(val_11.下不丌万丙且一万东.丌万丁七丈业丈丗东 == 0)
        {
            goto label_50;
        }
        
        val_33 = val_30 + 1;
        mem2[0] = 353;
        val_34 = val_31;
        goto label_54;
        label_50:
        val_33 = val_30 + 1;
        val_34 = val_31;
        mem2[0] = 353;
        label_54:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_33 == 1) || ((1152921526033918304 + ((0 + 1)) << 2) != 353))
        {
            goto label_81;
        }
        
        var val_29 = 0;
        val_29 = val_29 ^ (val_33 >> 31);
        val_33 = val_33 + val_29;
        goto label_84;
        label_81:
        if( == 0)
        {
            goto label_84;
        }
        
        goto label_84;
        label_7:
        val_30 = val_30 + 1;
        mem2[0] = 381;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_30 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921526033918304 + ((0 + 1)) << 2) == 381)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 丝丟丑丐专丁丁七丑()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        WeaponManager val_13;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_11 = null;
        val_11 = null;
        UnityEngine.Vector3 val_5 = transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) >= 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_23;
        }
        
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_13 == null)
        {
            goto label_24;
        }
        
        label_23:
        UnityEngine.Coroutine val_8 = StartCoroutine(routine:  丑丒丌下下丛丟丟丑());
        return;
        label_24:
    }
    public FortDefenceAlienGravitronController()
    {
        this.teleportDistance = 1f;
    }

}
