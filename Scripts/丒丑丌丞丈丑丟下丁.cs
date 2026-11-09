using UnityEngine;
protected class PetEngine.丒丑丌丞丈丑丟下丁 : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private Rilisoft.PetEngine 不丟专丛丘丛且丌丂;
    
    // Methods
    public PetEngine.丒丑丌丞丈丑丟下丁(Rilisoft.PetEngine 与且专丈不万东一万)
    {
        this.不丟专丛丘丛且丌丂 = 与且专丈不万东一万;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 且丕丞丈且上丁东丞)
    {
        this.In(且丕丞丈且上丁东丞:  且丕丞丈且上丁东丞);
        this.不丟专丛丘丛且丌丂.与丑丗不丏丛三丛丄 = UnityEngine.Time.realtimeSinceStartup;
    }
    public override void Out(Rilisoft.丛七下丌丑不一丄业 丒丁丐下上丒丂三丛)
    {
        this.Out(丒丁丐下上丒丂三丛:  丒丁丐下上丒丂三丛);
    }
    public override void Update()
    {
        var val_7;
        this.Update();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  10000f);
        this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        if(this.不丟专丛丘丛且丌丂.丏丛万丆丝丌丏丟下() > 0f)
        {
                return;
        }
        
        this.不丟专丛丘丛且丌丂.与丑丗不丏丛三丛丄 = -1f;
        this.不丟专丛丘丛且丌丂.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  this.不丟专丛丘丛且丌丂.丙丕丞且丕不丘丙丑().HP);
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.不丟专丛丘丛且丌丂.丘丒丝七丁下丂与丁() != false)
        {
                this.不丟专丛丘丛且丌丂.专丆丐万上与丏丐丕();
        }
        
        }
        
        this.不丟专丛丘丛且丌丂.丂丌不丝丂下丙专东(丙业与丙丗丝不丈东:  true);
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  7);
    }

}
