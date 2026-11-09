using UnityEngine;
internal sealed class SPViewConponentPixelPass : SPViewComponentBase
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfLockedByPrmium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfUnlockedByPrmium;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_6;
        System.Collections.Generic.List<UnityEngine.GameObject> val_7;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfLockedByPrmium, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfUnlockedByPrmium, 丏业丟一东丂东丘丛:  false);
        mem[1152921538596445512] = 且丘丏丁丑与丙与丁;
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "can_be_locked_by_pixel_pass_premium")) == false)
        {
                return;
        }
        
        if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().三丐丌丏专世丆丞丗() != false)
        {
                val_6 = null;
            val_7 = this.enableIfUnlockedByPrmium;
        }
        else
        {
                val_6 = null;
            val_7 = this.enableIfLockedByPrmium;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
    }
    public SPViewConponentPixelPass()
    {
        val_1 = new PGBehaviour();
    }

}
