using UnityEngine;
public sealed class SabotageDoorsNetworkController : PhotonEventBehaviour, 东丁丆一业丈万丆丐
{
    // Methods
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        SabotageImposterModeController val_2;
        var val_3;
        int val_4;
        val_2 = 丞世不丒下上上丝丑;
        if((val_2 & 255) != 0)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        val_2 = SabotageImposterModeController.丆丕丝丒不丙且丐丗;
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_3 = 专丒丌丆下丐丞丟丞[1];
        val_2.丞丌丗丒丂丟丙三丘(丂丙上丁丗与丆业七:  21884928, 一下丗丌丒丏不丘不:  1.28822976017949E-231);
        val_3 = 1;
        return (bool)val_3;
    }
    internal void 业丐丘万下丁东丑且(int 丂丙上丁丗与丆业七)
    {
        object[] val_2 = new object[2];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(丂丙上丁丗与丆业七 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(丂丙上丁丗与丆业七 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = 丂丙上丁丗与丆业七;
        val_2[1] = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  1, 丕业丑万一丞丞东三:  true, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public SabotageDoorsNetworkController()
    {
    
    }

}
