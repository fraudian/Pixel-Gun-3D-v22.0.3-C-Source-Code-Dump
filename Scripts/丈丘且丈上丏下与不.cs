using UnityEngine;
protected class PetEngine.丈丘且丈上丏下与不 : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private Rilisoft.PetEngine 不丟专丛丘丛且丌丂;
    
    // Methods
    public PetEngine.丈丘且丈上丏下与不(Rilisoft.PetEngine 与且专丈不万东一万)
    {
        this.不丟专丛丘丛且丌丂 = 与且专丈不万东一万;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 且丕丞丈且上丁东丞)
    {
        UnityEngine.AudioClip val_6;
        this.In(且丕丞丈且上丁东丞:  且丕丞丈且上丁东丞);
        this.不丟专丛丘丛且丌丂.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this.不丟专丛丘丛且丌丂.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  3), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PetEngine.丈丘且丈上丏下与不::与丌丅丞三丌丒业丙()));
        if(this.不丟专丛丘丛且丌丂 != null)
        {
                val_6 = this.不丟专丛丘丛且丌丂.ClipDeath;
        }
        else
        {
                val_6 = 456;
        }
        
        this.不丟专丛丘丛且丌丂.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_6);
        this.不丟专丛丘丛且丌丂.万东丂七东丁与业东().且丛丝丑丞丛专丑丟();
        PetInfo val_4 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
        if(val_4.petExplode != true)
        {
                PetInfo val_5 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
            if(val_5.petDisablerExplode == false)
        {
                return;
        }
        
        }
        
        this.不丟专丛丘丛且丌丂.三上世七七上丞不丛();
    }
    private void 与丌丅丞三丌丒业丙()
    {
        if(this.不丟专丛丘丛且丌丂.EffectHide != 0)
        {
                this.不丟专丛丘丛且丌丂.EffectHide.OnEffectCompleted.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PetEngine.丈丘且丈上丏下与不::不万不万万丂一丘丂()));
            this.不丟专丛丘丛且丌丂.丌七业一丞丈丅万三();
            return;
        }
        
        this.不万不万万丂一丘丂();
    }
    private void 不万不万万丂一丘丂()
    {
        if(this.不丟专丛丘丛且丌丂.EffectHide != 0)
        {
                this.不丟专丛丘丛且丌丂.EffectHide.OnEffectCompleted.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PetEngine.丈丘且丈上丏下与不::不万不万万丂一丘丂()));
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  10000f);
        this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.不丟专丛丘丛且丌丂.To(丘丏世丈业丛丞丘丒:  6);
    }

}
