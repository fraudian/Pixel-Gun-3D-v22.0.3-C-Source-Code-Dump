using UnityEngine;
internal class FortAlienGravitronController : FortTrap
{
    // Methods
    public override void DetectedTarget()
    {
        var val_4;
        Player_move_c val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
    }
    public FortAlienGravitronController()
    {
    
    }

}
