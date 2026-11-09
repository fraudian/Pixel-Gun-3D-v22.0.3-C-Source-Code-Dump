using UnityEngine;
private class GroundPetEngine.PetMoveToTargetState : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private Rilisoft.GroundPetEngine ctx;
    
    // Methods
    internal GroundPetEngine.PetMoveToTargetState(Rilisoft.PetEngine context)
    {
        var val_2 = 0;
        this.ctx = ;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 fromState)
    {
        var val_3;
        Rilisoft.丛七下丌丑不一丄业 val_4;
        this.In(且丕丞丈且上丁东丞:  fromState);
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.ctx, y:  0);
        if(this.ctx == null)
        {
            goto label_4;
        }
        
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_8:
        this.ctx.Nma.Stop();
        val_3 = 1152921543318620400;
        val_4 = 1;
        goto label_7;
        label_4:
        if(val_1 == true)
        {
            goto label_8;
        }
        
        label_5:
        Player_move_c val_2 = this.ctx.万东丂七东丁与业东();
        if(val_2.万丝一万丐且丌业丛 == false)
        {
                return;
        }
        
        this.ctx.Nma.Stop();
        val_3 = 1152921543318620400;
        val_4 = 7;
        label_7:
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  val_4);
    }
    public override void Update()
    {
        var val_29;
        float val_30;
        float val_31;
        var val_32;
        Rilisoft.丛七下丌丑不一丄业 val_33;
        Rilisoft.GroundPetEngine val_34;
        var val_35;
        Rilisoft.GroundPetEngine val_36;
        Rilisoft.GroundPetEngine val_37;
        val_29 = this;
        this.Update();
        if(((this.ctx == 0) || (this.ctx.丐丂丌丗丆丛东丘丁() == false)) || ((this.ctx.七七业丒丟丝丘不丞(丞下万上三丘上与专:  X21.gameObject, 业丆丏丙不丑七上丙:  200f)) == false))
        {
            goto label_9;
        }
        
        UnityEngine.Vector3 val_5 = X21.position;
        UnityEngine.Vector3 val_8 = this.ctx.万东丂七东丁与业东().transform.position;
        if((this.ctx.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 下丈丌三且三丝丄与:  val_9.MaxToOwnerDistance)) == false)
        {
            goto label_28;
        }
        
        UnityEngine.Vector3 val_11 = this.ctx.丙丕丞且丕不丘丙丑().position;
        val_30 = val_11.x;
        val_31 = val_11.z;
        UnityEngine.Vector3 val_12 = this.ctx.position;
        PetInfo val_13 = this.ctx.丙丕丞且丕不丘丙丑();
        if((this.ctx.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_30, y = val_11.y, z = val_31}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 下丈丌三且三丝丄与:  val_13.AttackDistance)) == false)
        {
            goto label_25;
        }
        
        if(this.ctx.业丒上丟丆上丙一丒() == true)
        {
                return;
        }
        
        val_32 = 1152921543318620400;
        val_33 = 4;
        goto label_28;
        label_9:
        val_32 = 1152921543318620400;
        val_33 = 1;
        label_28:
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  val_33);
        return;
        label_25:
        if(this.ctx.CanTeleportToTarget == false)
        {
            goto label_31;
        }
        
        this.ctx.Nma.Stop();
        this.ctx.Nma.ResetPath();
        val_34 = this.ctx;
        if(this.ctx != null)
        {
            goto label_34;
        }
        
        val_34 = this.ctx;
        if(val_34 == null)
        {
            goto label_52;
        }
        
        label_34:
        UnityEngine.Vector3 val_17 = this.ctx.Nma.position;
        val_30 = val_17.x;
        val_31 = val_17.z;
        bool val_18 = this.ctx.Nma.Warp(newPosition:  new UnityEngine.Vector3() {x = val_30, y = val_17.y, z = val_31});
        this.ctx.三且世三丂七丐一丟();
        val_35 = null;
        val_35 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.ctx.丘丒丝七丁下丂与丁() == false)
        {
                return;
        }
        
        mem2[0] = 1;
        return;
        label_31:
        if(this.ctx.Nma.isOnOffMeshLink == true)
        {
                return;
        }
        
        if((-66935300) != 0)
        {
                return;
        }
        
        val_36 = this.ctx;
        if(this.ctx != null)
        {
            goto label_51;
        }
        
        val_36 = this.ctx;
        if(val_36 == null)
        {
            goto label_52;
        }
        
        label_51:
        UnityEngine.Vector3 val_21 = this.ctx.Nma.position;
        bool val_22 = this.ctx.Nma.SetDestination(target:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        float val_23 = 丘丐丘万丌丟丞下丝.丙东不丗丗丟万丂一();
        float val_25 = this.ctx.丙丕丞且丕不丘丙丑().SpeedModif;
        float val_29 = val_25;
        val_37 = this.ctx;
        if(this.ctx != null)
        {
            goto label_59;
        }
        
        val_37 = this.ctx;
        if(val_37 == null)
        {
            goto label_60;
        }
        
        label_59:
        val_29 = val_23 * val_29;
        float val_27 = this.ctx.丙丕丞且丕不丘丙丑().SpeedModif;
        val_27 = val_25 * val_27;
        val_27 = val_23 * val_27;
        this.ctx.Nma.speed = UnityEngine.Mathf.Clamp(value:  val_27, min:  0f, max:  val_29);
        this.ctx.Nma.Resume();
        return;
        label_52:
        label_60:
    }
    public override void Out(Rilisoft.丛七下丌丑不一丄业 toState)
    {
        this.Out(丒丁丐下上丒丂三丛:  toState);
        this.ctx.Nma.Stop();
    }

}
