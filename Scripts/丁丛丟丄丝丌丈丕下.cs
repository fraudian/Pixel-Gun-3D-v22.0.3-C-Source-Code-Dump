using UnityEngine;
protected class PetEngine.丁丛丟丄丝丌丈丕下 : StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>
{
    // Fields
    private bool 丁一上一与丆丌世丈;
    private bool 一丙丘丘丄七七丐不;
    private Rilisoft.PetEngine 不丟专丛丘丛且丌丂;
    
    // Methods
    public PetEngine.丁丛丟丄丝丌丈丕下(Rilisoft.PetEngine 与且专丈不万东一万)
    {
        this.不丟专丛丘丛且丌丂 = 与且专丈不万东一万;
    }
    public override void In(Rilisoft.丛七下丌丑不一丄业 且丕丞丈且上丁东丞)
    {
        this.In(且丕丞丈且上丁东丞:  且丕丞丈且上丁东丞);
        if(this.不丟专丛丘丛且丌丂.丐丂丌丗丆丛东丘丁() != false)
        {
                this.一丙丘丘丄七七丐不 = true;
            return;
        }
        
        this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  6);
    }
    public override void Update()
    {
        if(this.不丟专丛丘丛且丌丂.丆丙丘业一丛专世丙() != false)
        {
                if(this.不丟专丛丘丛且丌丂.东丞业丘丅业丏三丏() != false)
        {
                this.不丟专丛丘丛且丌丂.丗丑丝丕上丙世丆下();
            this.丆三丌一丂丞丙丁丝(丏业丟一东丂东丘丛:  1);
            this.一丙丘丘丄七七丐不 = false;
            return;
        }
        
        }
        
        if(this.丁一上一与丆丌世丈 != true)
        {
                this.丁一上一与丆丌世丈 = true;
            this.不丟专丛丘丛且丌丂.丗丑丝丕上丙世丆下();
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  10000f);
        this.不丟专丛丘丛且丌丂.七丈丁万丛万业丈与.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public override void Out(Rilisoft.丛七下丌丑不一丄业 丒丁丐下上丒丂三丛)
    {
        this.Out(丒丁丐下上丒丂三丛:  丒丁丐下上丒丂三丛);
        this.丁一上一与丆丌世丈 = false;
    }

}
