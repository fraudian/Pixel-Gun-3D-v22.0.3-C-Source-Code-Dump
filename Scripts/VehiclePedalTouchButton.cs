using UnityEngine;
public class VehiclePedalTouchButton : TouchButton
{
    // Methods
    public override bool IsActive()
    {
        Player_move_c val_10;
        var val_11;
        UnityEngine.Object val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
            goto label_4;
        }
        
        val_10 = 丅与丌专丟一丝业三();
        if(val_10.activeInHierarchy == true)
        {
            goto label_40;
        }
        
        label_4:
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
            goto label_13;
        }
        
        val_10 = public System.Boolean UnityEngine.Object::Equals(object other);
        if(WindowEnabled == true)
        {
            goto label_40;
        }
        
        label_13:
        val_11 = null;
        val_11 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_12 = 0;
        if(val_10 != val_12)
        {
                val_13 = null;
            val_13 = null;
            val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_14 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266];
            val_14 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266;
            val_15 = null;
            val_15 = null;
            val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
            val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            val_12 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_16 = val_10 & 1;
            val_14 = 1;
        }
        else
        {
                val_14 = 0;
            val_16 = 0;
        }
        
        val_14 = val_16 & val_14;
        if(val_14 == 0)
        {
            goto label_40;
        }
        
        val_17 = null;
        val_17 = null;
        val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        if(丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不() == false)
        {
            goto label_52;
        }
        
        val_18 = 1;
        return (bool)(val_10 == 2) ? 1 : 0;
        label_40:
        val_18 = 0;
        return (bool)(val_10 == 2) ? 1 : 0;
        label_52:
        val_19 = null;
        val_19 = null;
        val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
        val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
        return (bool)(val_10 == 2) ? 1 : 0;
    }
    public override bool CanPress()
    {
        goto typeof(VehiclePedalTouchButton).__il2cppRuntimeField_188;
    }
    public VehiclePedalTouchButton()
    {
    
    }

}
