using UnityEngine;
public sealed class BlindEffectsController : PGBehaviour
{
    // Fields
    private PlayGadgetSFX defaultEffect;
    private System.Collections.Generic.List<Player_move_c.丏丙丘丒上丝丒丁且> names;
    private System.Collections.Generic.List<PlayGadgetSFX> effects;
    private PlayGadgetSFX 一丙丅不一丗丒世丌;
    
    // Methods
    internal void 丝丏丑丏丟丌世专丏(Player_move_c.丏丙丘丒上丝丒丁且 与丐丂丏丆且丅丆世, float 丂三丟丂丈丐丆丗丟)
    {
        PlayGadgetSFX val_4;
        int val_1 = this.names.IndexOf(item:  与丐丂丏丆且丅丆世);
        if(((val_1 & 2147483648) == 0) && (val_1 < this.effects.Count))
        {
                val_4 = this.effects.Item[val_1];
        }
        else
        {
                val_4 = this.defaultEffect;
        }
        
        this.一丙丅不一丗丒世丌 = val_4;
        this.defaultEffect.time = 丂三丟丂丈丐丆丗丟;
        this.一丙丅不一丗丒世丌.Play();
    }
    internal void 丆世三与业世丈三丅()
    {
        if(this.一丙丅不一丗丒世丌 == 0)
        {
                return;
        }
        
        this.一丙丅不一丗丒世丌.Stop();
        this.一丙丅不一丗丒世丌 = 0;
    }
    public BlindEffectsController()
    {
    
    }

}
