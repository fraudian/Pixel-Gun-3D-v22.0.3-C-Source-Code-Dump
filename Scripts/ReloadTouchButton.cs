using UnityEngine;
public class ReloadTouchButton : TouchButtonDelayed
{
    // Fields
    public UITexture reloadProgress;
    
    // Methods
    public override bool IsActive()
    {
        var val_29;
        var val_30;
        Player_move_c val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_30 = null;
            val_30 = null;
            val_31 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_31 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_32 = null;
            val_32 = null;
            val_31 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_31 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_33 = null;
            val_33 = null;
            val_31 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_31 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_34 = null;
            val_34 = null;
            val_35 = null;
            val_35 = null;
            val_31 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
            val_31 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            val_31 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_31.isWorldMapOpened == true)
        {
                return false;
        }
        
            if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_31 = 丅与丌专丟一丝业三();
            if(val_31.activeInHierarchy == true)
        {
                return false;
        }
        
        }
        
            if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_31 = public System.Boolean UnityEngine.Object::Equals(object other);
            if(WindowEnabled == true)
        {
                return false;
        }
        
        }
        
        }
        
        val_31 = 1152921505066536960;
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
        
        val_36 = null;
        val_36 = null;
        val_31 = 丙不丅丕三丂业东丕();
        if(val_31 == 0)
        {
                return false;
        }
        
        val_37 = null;
        val_37 = null;
        val_31 = 丙不丅丕三丂业东丕();
        if(val_13.isGrenadeWeapon != false)
        {
                return false;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_38 = 1;
        }
        else
        {
                val_38 = TrainingController.下且丌丑丟丒丒丗丞();
        }
        
        val_39 = null;
        val_39 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_40 = null;
            val_40 = null;
            val_41 = UnityEngine.Object.op_Inequality(x:  typeof(Player_move_c).__il2cppRuntimeField_668, y:  0);
        }
        else
        {
                val_41 = 0;
        }
        
        bool val_19 = UnityEngine.Object.op_Inequality(x:  InGameGUI.丙丞专丌丁丞与不丐.playerMoveC, y:  0);
        val_42 = 0;
        if((val_41 == 0) && (InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0))
        {
                val_43 = null;
            val_43 = null;
            bool val_27 = 与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下;
            val_27 = val_27 ^ 1;
            val_42 = val_27 & 255;
        }
        
        val_42 = val_42 & val_38;
        if(val_42 == false)
        {
                return false;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return false;
        }
        
        val_44 = null;
        val_44 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_45 = null;
        val_45 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗() == 0)
        {
                return false;
        }
        
        val_46 = null;
        val_46 = null;
        WeaponSounds val_25 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_25.isMelee == true)
        {
                return false;
        }
        
        val_47 = null;
        val_47 = null;
        WeaponSounds val_26 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_26.isShotMelee == true)
        {
                return false;
        }
        
        return false;
    }
    public override bool CanPress()
    {
        Player_move_c val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return (bool)0 & 1;
        }
        
        if((丕上丂丙上专丄专丗() == false) || ((val_10 & 1) == 0))
        {
                return (bool)0 & 1;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return (bool)0 & 1;
        }
        
        if(this.GadgetPanelPressed != true)
        {
                val_12 = null;
            val_12 = null;
            val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_13 = null;
            val_13 = null;
            val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        return (bool)0 & 1;
    }
    public ReloadTouchButton()
    {
    
    }

}
