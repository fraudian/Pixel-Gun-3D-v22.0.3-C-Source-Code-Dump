using UnityEngine;
public class GEGuiLocalizationApplyer : GEGuiApplyer
{
    // Fields
    private I2.Loc.Localize ressiver;
    
    // Methods
    internal override void 丘上丐世丆丑且丞丒()
    {
        I2.Loc.Localize val_8;
        this.丘上丐世丆丑且丞丒();
        if(this.ressiver == 0)
        {
                val_8 = this.GetComponent<I2.Loc.Localize>();
            this.ressiver = val_8;
        }
        else
        {
                val_8 = this.ressiver;
        }
        
        if(val_8 != 0)
        {
                return;
        }
        
        this.ressiver = this.gameObject.AddComponent<I2.Loc.Localize>();
        this.gameObject.AddComponent<I2.Loc.Localize>().SetTerm(丂专丟专丕丈丘丘丌:  "Key_04B_03", 丟丛不丞丞丏丏丁丕:  "Key_04B_03");
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
        string val_6;
        var val_7;
        val_6 = this;
        if((val_6 & 1) != 0)
        {
                mem[1152921537427380368] = 1;
            mem[1152921537427380416] = this.Context;
            string val_3 = this.Context.业上丙丞丐丄丆丅七();
            val_6 = "GameEvent_" + val_3 + "_" + null;
            this.ressiver.SetTerm(丂专丟专丕丈丘丘丌:  val_6, 丟丛不丞丞丏丏丁丕:  "GameEvent_default_" + val_3);
            val_7 = 1;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public GEGuiLocalizationApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
