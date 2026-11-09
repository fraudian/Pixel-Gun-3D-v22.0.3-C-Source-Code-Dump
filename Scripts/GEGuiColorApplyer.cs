using UnityEngine;
public class GEGuiColorApplyer : GEGuiApplyer
{
    // Fields
    private UIWidget ressiver;
    
    // Methods
    internal override void 丘上丐世丆丑且丞丒()
    {
        this.丘上丐世丆丑且丞丒();
        if(this.ressiver != 0)
        {
                return;
        }
        
        this.ressiver = this.GetComponent<UIWidget>();
    }
    internal override bool 七丆业丗不业丙丏三()
    {
        if(this.七丆业丗不业丙丏三() == false)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.ressiver, y:  0);
    }
    internal override bool 三业丒丑丂三丕上丛()
    {
        var val_4;
        if((this & 1) != 0)
        {
                mem[1152921537426828736] = 1;
            mem[1152921537426828784] = this.Context;
            UnityEngine.Color val_3 = GameEventsHalper.丈三丆丟丝七与丛丌(丅东专与不三丂丁丝:  this.Context, 丒丘丏上丙丟丑丕丈:  typeof(GEGuiColorApplyer).__il2cppRuntimeField_1B0);
            this.ressiver.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public GEGuiColorApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
