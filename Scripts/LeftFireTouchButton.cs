using UnityEngine;
public class LeftFireTouchButton : FireTouchButton
{
    // Methods
    public override bool IsActive()
    {
        var val_39;
        InGameGUI val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘 val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_39 = 1152921505219145728;
        val_40 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_40.isWorldMapOpened == true)
        {
                return false;
        }
        
        val_41 = null;
        val_41 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_42 = null;
            val_42 = null;
            val_40 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_40 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_43 = null;
            val_43 = null;
            val_40 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_40 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_44 = null;
            val_44 = null;
            val_40 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_40 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_45 = null;
            val_45 = null;
            val_46 = null;
            val_46 = null;
            val_40 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
            val_40 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            val_47 = null;
            val_47 = null;
            val_40 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_40 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_48 = null;
            val_48 = null;
            val_40 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_40 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_40 = 丅与丌专丟一丝业三();
            if(val_40.activeInHierarchy == true)
        {
                return false;
        }
        
        }
        
        val_40 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_40 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(val_40 != 0)
        {
                val_40 = public System.Boolean UnityEngine.Object::Equals(object other);
            if(WindowEnabled == true)
        {
                return false;
        }
        
        }
        
        val_39 = 1152921505066536960;
        if(GameConnect.丙丌丒丈东七丒上丌() == true)
        {
                return false;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
                return false;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_49 = null;
            val_49 = null;
            val_40 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_40 != 0)
        {
                val_50 = null;
            val_50 = null;
            val_40 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_40.下上丏丁东丝丑世与() != null)
        {
                val_51 = null;
            val_51 = null;
            val_40 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count;
            if(val_40 > WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
                val_52 = null;
            val_52 = null;
            val_40 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
            if(val_40.七丝丈东丈丕丐与丗() == true)
        {
                return false;
        }
        
        }
        
        }
        
        }
        
        }
        
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return false;
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
                return false;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return false;
        }
        
        val_53 = null;
        val_53 = null;
        val_40 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_40 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((ControlFireSettings.丈业且丘丈不丄丈丒(丁丅丈丌丟世丗丗丟:  下丂世丂不丛专一一.丕丙丛万丒七业丄下(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()))) != null)
        {
                val_54 = val_25.GameSecondFireButtonMode;
        }
        else
        {
                val_54 = 2;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_55 = 1;
        }
        else
        {
                val_55 = TrainingController.下且丌丑丟丒丒丗丞();
        }
        
        if(val_40 != 0)
        {
                var val_31 = (typeof(Player_move_c).__il2cppRuntimeField_668 == 0) ? 50 : 0;
        }
        else
        {
                val_56 = 0;
        }
        
        val_57 = 1;
        if((val_54 != 1) && (GameConnect.丟丆丏上丌一丝丟业() != true))
        {
                if((val_54 == 0) && (val_40 != 0))
        {
                val_57 = InGameGUI.丕业丁丑丟不丏丗且();
        }
        else
        {
                val_57 = 0;
        }
        
        }
        
        val_57 = val_57 & val_55;
        if(val_57 == false)
        {
                return false;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return false;
        }
        
        val_58 = null;
        val_58 = null;
        val_40 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_36.isGrenadeWeapon != false)
        {
                return false;
        }
        
        val_59 = null;
        val_59 = null;
        if(((val_56 & 63) == 50) || (与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == true))
        {
                return false;
        }
        
        return false;
    }
    public LeftFireTouchButton()
    {
    
    }

}
