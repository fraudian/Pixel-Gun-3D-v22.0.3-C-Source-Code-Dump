using UnityEngine;
internal class 且丗丝丒下丙丆丂东 : 丆万丗下丞丒丐丙丛
{
    // Fields
    private float 丅丆七下丗一业与丑;
    
    // Properties
    internal override string 一丄七丟丈丝丙丌丞 { get; }
    
    // Methods
    internal override string 下丑不七不万丛上一()
    {
        return "gadget_denied";
    }
    internal 且丗丝丒下丙丆丂东(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        var val_2;
        this.丈七丁与丝上丕丝丕();
        this.丅丆七下丗一业与丑 = UnityEngine.Time.time;
        val_2 = null;
        val_2 = null;
        一丂下与丁丐且不丌(丙丗丕丟七丟上丈丌:  this, 丞世不丒下上上丝丑:  249);
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_4;
        this.丟丄不丄丝业专丅丙();
        float val_2 = this.丅丆七下丗一业与丑 - UnityEngine.Time.time;
        val_2 = val_2 + 0.4f;
        float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  val_2);
        val_4 = null;
        val_4 = null;
        GadgetHandsEffectStartFire(丕丕世且下一与丝与:  val_3);
        float val_4 = 0.5f;
        val_4 = val_3 + val_4;
        丅万丂业丟丄七丞丘(丕丕世且下一与丝与:  val_4);
        this.丝丂与丒丟丕丙不丅();
    }

}
