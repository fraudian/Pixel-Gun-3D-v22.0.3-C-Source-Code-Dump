using UnityEngine;
private sealed class ArmRaceLoadoutsController.下上三世丄丕丏丑丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ArmRaceLoadoutsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ArmRaceLoadoutsController.下上三世丄丕丏丑丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ArmRaceLoadoutsController val_3;
        var val_4;
        Player_move_c val_5;
        var val_6;
        int val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_3 = this.丝且与丝丒丟万丁专;
            val_4 = null;
            val_4 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_5 != 0)
        {
                val_6 = null;
            val_6 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(丏丑业丛七七丘丅万() != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        }
        
            if(val_3 != null)
        {
                val_8 = this.丝且与丝丒丟万丁专.weaponId;
        }
        else
        {
                val_8 = 0;
        }
        
            val_3.GiveLoadoutWeapon(丞丅上丏丂且下丅与:  0);
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
