using UnityEngine;
private class GroundPetEngine.PetMoveToOwnerState : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private Rilisoft.GroundPetEngine ctx;
    
    // Methods
    internal GroundPetEngine.PetMoveToOwnerState(Rilisoft.PetEngine context)
    {
        var val_2 = 0;
        this.ctx = ;
    }
    public override void Update()
    {
        var val_28;
        Rilisoft.丛七下丌丑不一丄业 val_29;
        Rilisoft.GroundPetEngine val_30;
        Rilisoft.GroundPetEngine val_31;
        this.Update();
        if((this.ctx.万东丂七东丁与业东() == 0) || (this.ctx.丐丂丌丗丆丛东丘丁() == false))
        {
            goto label_6;
        }
        
        Player_move_c val_4 = this.ctx.万东丂七东丁与业东();
        if(val_4.万丝一万丐且丌业丛 == false)
        {
            goto label_9;
        }
        
        label_42:
        val_28 = 1152921543318620400;
        val_29 = 7;
        goto label_21;
        label_9:
        UnityEngine.Vector3 val_5 = X21.position;
        PetInfo val_6 = this.ctx.丙丕丞且丕不丘丙丑();
        if((this.ctx.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 下丈丌三且三丝丄与:  val_6.MinToOwnerDistance)) == false)
        {
            goto label_16;
        }
        
        label_6:
        val_28 = 1152921543318620400;
        val_29 = 1;
        label_21:
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  val_29);
        return;
        label_16:
        if(this.ctx == 0)
        {
            goto label_20;
        }
        
        goto label_21;
        label_20:
        UnityEngine.Vector3 val_9 = this.ctx.position;
        PetInfo val_10 = this.ctx.丙丕丞且丕不丘丙丑();
        if(((this.ctx.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 下丈丌三且三丝丄与:  val_10.MaxToOwnerDistance)) == false) || (this.ctx.Nma.enabled == false))
        {
            goto label_42;
        }
        
        UnityEngine.Vector3 val_13 = this.ctx.position;
        PetInfo val_14 = this.ctx.丙丕丞且丕不丘丙丑();
        if((this.ctx.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, 下丈丌三且三丝丄与:  val_14.MinToOwnerDistance)) == true)
        {
            goto label_42;
        }
        
        if(null != null)
        {
                return;
        }
        
        if((this.ctx & 1) == 0)
        {
                if(this.ctx.东丞业丘丅业丏三丏() == true)
        {
            goto label_42;
        }
        
        }
        
        if(this.ctx.Nma.isOnOffMeshLink == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_20 = this.ctx.gameObject.transform.position;
        Player_move_c val_21 = this.ctx.万东丂七东丁与业东();
        UnityEngine.Vector3 val_22 = val_21.myPlayerTransform.position;
        bool val_23 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, targetPosition:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, areaMask:  0, path:  this.ctx.Path);
        val_30 = this.ctx;
        if(this.ctx != null)
        {
            goto label_53;
        }
        
        val_30 = this.ctx;
        if(val_30 == null)
        {
            goto label_54;
        }
        
        label_53:
        bool val_24 = this.ctx.Nma.SetPath(path:  this.ctx.Path);
        float val_25 = 丘丐丘万丌丟丞下丝.丙东不丗丗丟万丂一();
        val_31 = this.ctx;
        if(this.ctx != null)
        {
            goto label_58;
        }
        
        val_31 = this.ctx;
        if(val_31 == null)
        {
            goto label_59;
        }
        
        label_58:
        float val_27 = this.ctx.丙丕丞且丕不丘丙丑().SpeedModif;
        val_27 = val_25 * val_27;
        val_27 = val_25 * val_27;
        this.ctx.Nma.speed = val_27;
        this.ctx.Nma.Resume();
        return;
        label_54:
        label_59:
    }
    public override void Out(Rilisoft.丛七下丌丑不一丄业 toState)
    {
        this.Out(丒丁丐下上丒丂三丛:  toState);
        this.ctx.Nma.ResetPath();
        this.ctx.Nma.Stop();
    }

}
