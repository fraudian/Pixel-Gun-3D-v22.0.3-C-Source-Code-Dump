using UnityEngine;
internal class 丛与下世七三与丑丁 : 丒丙东丗丆丁丆不丁
{
    // Fields
    private TurretController 丆丁与丑三世与东与;
    
    // Methods
    internal 丛与下世七三与丑丁(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        if(this.丆丁与丑三世与东与 == 0)
        {
                return;
        }
        
        this.丆丁与丑三世与东与.SendImKilledRPC();
        this.丆丁与丑三世与东与 = 0;
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        this.丈七丁与丝上丕丝丕();
    }
    internal override void 下丏丂丄丗丈丂丆丛()
    {
        if(this.丆丁与丑三世与东与 != 0)
        {
                this.丆丁与丑三世与东与.SendImKilledRPC();
            this.丆丁与丑三世与东与 = 0;
        }
        
        this.丝丂与丒丟丕丙不丅();
    }
    internal void 专万三丌且丅七丅业(TurretController 下不丄七世上与专业)
    {
        var val_5;
        var val_6;
        if(true != 0)
        {
                val_5 = null;
            val_5 = null;
            丗丅与专一丘不不丅(东一丁世丑丞业丄丐:  this.丙丕丞且丕不丘丙丑());
        }
        
        下不丄七世上与专业.GadgetOnKill = new System.Action(object:  this, method:  System.Void 不丘丄丝丗丒丙一丌::丌上丛丆三东下丅丙());
        val_6 = null;
        val_6 = null;
        不丄业丞且东丁东丈(丗丄万丄丌丕丈丈三:  this.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七());
        this.丞丒丌世七丂丐万与();
        this.丆丁与丑三世与东与 = 下不丄七世上与专业;
    }

}
