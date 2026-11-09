using UnityEngine;
protected class PetEngine.与七东丘丞丙上丅丝 : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private Rilisoft.PetEngine 不丟专丛丘丛且丌丂;
    
    // Methods
    public PetEngine.与七东丘丞丙上丅丝(Rilisoft.PetEngine 与且专丈不万东一万)
    {
        this.不丟专丛丘丛且丌丂 = 与且专丈不万东一万;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 且丕丞丈且上丁东丞)
    {
        this.不丟专丛丘丛且丌丂.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  0);
    }
    public override void Update()
    {
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        var val_26;
        Rilisoft.丛七下丌丑不一丄业 val_27;
        Player_move_c val_1 = this.不丟专丛丘丛且丌丂.万东丂七东丁与业东();
        if(val_1.万丝一万丐且丌业丛 == true)
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_4 = this.不丟专丛丘丛且丌丂.万东丂七东丁与业东().transform.position;
        if(val_4.y < 0)
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_5 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position;
        val_22 = val_5.x;
        val_23 = val_5.z;
        val_24 = val_5.y;
        PetInfo val_6 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
        val_25 = val_22;
        if((this.不丟专丛丘丛且丌丂.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_25, y = val_5.y, z = val_23}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_5.x, y = val_24, z = val_5.z}, 下丈丌三且三丝丄与:  val_6.MaxToOwnerDistance + 1f)) == false)
        {
            goto label_13;
        }
        
        if(this.不丟专丛丘丛且丌丂.丐丂丌丗丆丛东丘丁() == false)
        {
            goto label_43;
        }
        
        if(this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟 == 0)
        {
            goto label_22;
        }
        
        val_25 = 200f;
        if((this.不丟专丛丘丛且丌丂.七七业丒丟丝丘不丞(丞下万上三丘上与专:  this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟.gameObject, 业丆丏丙不丑七上丙:  val_25)) == false)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_13 = this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟.position;
        val_22 = val_13.x;
        val_23 = val_13.z;
        UnityEngine.Vector3 val_14 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position;
        val_24 = val_14.y;
        PetInfo val_15 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
        if((this.不丟专丛丘丛且丌丂.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_22, y = val_13.y, z = val_23}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_14.x, y = val_24, z = val_14.z}, 下丈丌三且三丝丄与:  val_15.AttackStopDistance)) == false)
        {
            goto label_43;
        }
        
        if(this.不丟专丛丘丛且丌丂.业丒上丟丆上丙一丒() == true)
        {
                return;
        }
        
        val_26 = 1152921543318620400;
        val_27 = 4;
        goto label_43;
        label_13:
        val_26 = 1152921543318620400;
        val_27 = 7;
        label_43:
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  val_27);
        return;
        label_22:
        if((this.不丟专丛丘丛且丌丂 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_18 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position;
        val_22 = val_18.x;
        val_23 = val_18.z;
        val_24 = val_18.y;
        PetInfo val_19 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
        if((this.不丟专丛丘丛且丌丂.上丗不丘上丘丕丟丞(丏丆丑丗七丄丙丝与:  new UnityEngine.Vector3() {x = val_22, y = val_18.y, z = val_23}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_18.x, y = val_24, z = val_18.z}, 下丈丌三且三丝丄与:  val_19.MinToOwnerDistance + 1f)) == false)
        {
            goto label_43;
        }
    
    }

}
