using UnityEngine;
internal sealed class GeneratorControllerScene_Radar : GeneratorControllerScene
{
    // Methods
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        BaseEquipmentController val_5;
        byte val_6;
        float val_7;
        float val_8;
        val_5 = 丒专丈丛下丒一丒丛;
        val_6 = 丞丅上丏丂且下丅与;
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  val_6, 丒专丈丛下丒一丒丛:  val_5);
        if(this == null)
        {
                return;
        }
        
        val_6 = this.丆丘丒东且丂与丂丑();
        if((val_6.Equals(value:  "Radius Increase")) == false)
        {
                return;
        }
        
        if(val_5 != null)
        {
                val_7 = 丒专丈丛下丒一丒丛.distanceMultupler;
            val_8 = this.下与丗丒丐三丕丘丈();
        }
        else
        {
                val_5 = 40;
            val_7 = 4.656534E-34f;
            val_8 = this.下与丗丒丐三丕丘丈();
        }
        
        float val_5 = 0.01f;
        val_5 = val_8 * val_5;
        val_5 = val_7 + val_5;
        mem[40] = val_5;
    }
    public GeneratorControllerScene_Radar()
    {
        val_1 = new FortEquipObject();
    }

}
