using UnityEngine;
protected class PetEngine.丁丁丗丞丒丕不丑丐 : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private float 丄业丘一丗丁丛丐专;
    private float 丗丏丁东丙丙丆丘丙;
    private UnityEngine.Transform 丟丒丐丑丗一专丄丏;
    private Rilisoft.PetEngine 不丟专丛丘丛且丌丂;
    
    // Methods
    public PetEngine.丁丁丗丞丒丕不丑丐(Rilisoft.PetEngine 与且专丈不万东一万)
    {
        this.不丟专丛丘丛且丌丂 = 与且专丈不万东一万;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 且丕丞丈且上丁东丞)
    {
        var val_12;
        var val_13;
        Rilisoft.丛七下丌丑不一丄业 val_14;
        this.In(且丕丞丈且上丁东丞:  且丕丞丈且上丁东丞);
        this.不丟专丛丘丛且丌丂.丞丑丏不七丞业东丕(丙业与丙丗丝不丈东:  true);
        Player_move_c val_1 = this.不丟专丛丘丛且丌丂.万东丂七东丁与业东();
        if(val_1.万丝一万丐且丌业丛 == false)
        {
            goto label_4;
        }
        
        val_13 = 1152921543318620400;
        val_14 = 7;
        goto label_5;
        label_4:
        val_12 = 1152921504848912384;
        if(this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟 != 0)
        {
            goto label_9;
        }
        
        val_13 = 1152921543318620400;
        val_14 = 1;
        label_5:
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  val_14);
        return;
        label_9:
        UnityEngine.Vector3 val_3 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        PetInfo val_5 = this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑();
        float val_12 = val_5.AttackStopDistance;
        val_12 = val_12 * val_12;
        if(val_4.x > val_12)
        {
                this.不丟专丛丘丛且丌丂.To(丘丏世丈业丛丞丘丒:  3);
            return;
        }
        
        this.丟丒丐丑丗一专丄丏 = this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟;
        if(this.不丟专丛丘丛且丌丂.isPetStone == true)
        {
                return;
        }
        
        if(this.不丟专丛丘丛且丌丂.丄丐东三东丂与业与() != 0)
        {
                this.不丟专丛丘丛且丌丂.丄丐东三东丂与业与().SubscribeTo(丌丁一下丙业丙丗不:  this.不丟专丛丘丛且丌丂.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  2), 丒丁丐下上丒丂三丛:  2, 专丞丄丄且三丏万丐:  false, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PetEngine.丁丁丗丞丒丕不丑丐::三丈丄丑世丑丄万丗()));
        }
        
        this.丄业丘一丗丁丛丐专 = this.不丟专丛丘丛且丌丂.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  2);
        this.丗丏丁东丙丙丆丘丙 = 0f;
        if(this.不丟专丛丘丛且丌丂 != null)
        {
                return;
        }
    
    }
    private void 三丈丄丑世丑丄万丗()
    {
        this.不丟专丛丘丛且丌丂.丄丐东三东丂与业与().Unsubscribe(丌丁一下丙业丙丗不:  this.不丟专丛丘丛且丌丂.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  2), 丒丁丐下上丒丂三丛:  2, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PetEngine.丁丁丗丞丒丕不丑丐::三丈丄丑世丑丄万丗()));
        if(this != this.不丟专丛丘丛且丌丂.CurrentState)
        {
                return;
        }
        
        bool val_5 = UnityEngine.Object.op_Equality(x:  this.丟丒丐丑丗一专丄丏, y:  this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟);
        if(this.不丟专丛丘丛且丌丂 == null)
        {
            goto label_9;
        }
        
        if(val_5 == false)
        {
            goto label_10;
        }
        
        label_11:
        this.不丟专丛丘丛且丌丂.丂上丘三万丛丗世且();
        return;
        label_9:
        if(val_5 == true)
        {
            goto label_11;
        }
        
        label_10:
        this.不丟专丛丘丛且丌丂.丞丑丏不七丞业东丕(丙业与丙丗丝不丈东:  false);
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  1);
    }
    public override void Update()
    {
        UnityEngine.Transform val_6;
        float val_7;
        val_6 = this;
        this.Update();
        val_7 = this.丗丏丁东丙丙丆丘丙;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_7 + val_1;
        this.丗丏丁东丙丙丆丘丙 = val_1;
        if(val_1 < this.丄业丘一丗丁丛丐专)
        {
                if(this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟 != 0)
        {
            goto label_5;
        }
        
        }
        
        this.丗丏丁东丙丙丆丘丙 = 0f;
        this.不丟专丛丘丛且丌丂.丞丑丏不七丞业东丕(丙业与丙丗丝不丈东:  false);
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  1);
        return;
        label_5:
        UnityEngine.Vector3 val_3 = this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟.position;
        UnityEngine.Vector3 val_4 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position;
        UnityEngine.Vector3 val_5 = this.不丟专丛丘丛且丌丂.丘与丈丘丒丂丁丛丟.position;
        val_6 = this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与;
        val_7 = 0f;
        val_6.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_7, y = 0f, z = 0f});
    }
    public override void Out(Rilisoft.丛七下丌丑不一丄业 丒丁丐下上丒丂三丛)
    {
        this.Out(丒丁丐下上丒丂三丛:  丒丁丐下上丒丂三丛);
        this.不丟专丛丘丛且丌丂.丞丑丏不七丞业东丕(丙业与丙丗丝不丈东:  false);
        this.丄业丘一丗丁丛丐专 = 0f;
        this.丗丏丁东丙丙丆丘丙 = 0f;
        this.丟丒丐丑丗一专丄丏 = 0;
    }

}
