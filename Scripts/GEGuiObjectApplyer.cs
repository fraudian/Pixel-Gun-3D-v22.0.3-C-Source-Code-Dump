using UnityEngine;
public class GEGuiObjectApplyer : GEGuiApplyer
{
    // Fields
    public bool loadDefault;
    internal UnityEngine.GameObject 丌专万丄与丕一东丗;
    
    // Methods
    internal override bool 三业丒丑丂三丕上丛()
    {
        UnityEngine.GameObject val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        val_17 = this;
        if(this.七丆业丗不业丙丏三() == false)
        {
            goto label_1;
        }
        
        mem[1152921537429255184] = 1;
        mem[1152921537429255232] = this.Context;
        string val_5 = GameEventsHalper.丏丟世丄七三丒丟上(丞丕丟丁且丛三丕不:  this.Context.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  0);
        if(this.丌专万丄与丕一东丗 == 0)
        {
            goto label_5;
        }
        
        val_18 = this.丌专万丄与丕一东丗;
        if((System.String.op_Equality(a:  val_18.name, b:  val_5)) == true)
        {
            goto label_16;
        }
        
        label_5:
        if(this.丌专万丄与丕一东丗 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丌专万丄与丕一东丗);
        }
        
        val_18 = GameEventsHalper.丙丌丘丅丑与与丂万<UnityEngine.GameObject>(丞丕丟丁且丛三丕不:  this.Context.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  0, 下上丕丌业丁丙上丐:  this.loadDefault);
        this.丌专万丄与丕一东丗 = val_18;
        if(val_18 != 0)
        {
                this.丌专万丄与丕一东丗.transform.SetParent(p:  this.transform);
            val_18 = this.丌专万丄与丕一东丗.transform;
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_18);
            val_17 = this.丌专万丄与丕一东丗;
            val_17.name = val_5;
        }
        
        label_16:
        val_19 = 1;
        return (bool)val_19;
        label_1:
        val_19 = 0;
        return (bool)val_19;
    }
    public GEGuiObjectApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
