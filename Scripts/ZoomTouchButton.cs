using UnityEngine;
public class ZoomTouchButton : TouchButtonDelayed
{
    // Fields
    public UnityEngine.GameObject zoomIcon;
    public UnityEngine.GameObject hornIcon;
    
    // Methods
    public override bool IsActive()
    {
        InGameGUI val_30;
        var val_31;
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
        var val_48;
        val_30 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_30.isWorldMapOpened == true)
        {
            goto label_132;
        }
        
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_32 = null;
            val_32 = null;
            val_30 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_30 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_33 = null;
            val_33 = null;
            val_30 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_30 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_34 = null;
            val_34 = null;
            val_30 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_30 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
            goto label_31;
        }
        
        val_30 = 丅与丌专丟一丝业三();
        if(val_30.activeInHierarchy == true)
        {
            goto label_132;
        }
        
        label_31:
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
            goto label_40;
        }
        
        val_30 = public System.Boolean UnityEngine.Object::Equals(object other);
        if(WindowEnabled == true)
        {
            goto label_132;
        }
        
        label_40:
        val_30 = 1152921505066536960;
        if((((GameConnect.丆丕丒与丂七与下上() != true) && (GameConnect.丛专丌且丕不专丈下() != true)) && (GameConnect.丁丁丗丐东丄丞一丛() != true)) && (GameConnect.一业上七丟业且业丙() != true))
        {
                if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_35 = 1;
        }
        else
        {
                val_35 = TrainingController.下且丌丑丟丒丒丗丞();
        }
        
            val_36 = null;
            val_36 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_37 = null;
            val_37 = null;
            val_38 = UnityEngine.Object.op_Inequality(x:  typeof(Player_move_c).__il2cppRuntimeField_668, y:  0);
        }
        else
        {
                val_38 = 0;
        }
        
            val_39 = null;
            val_39 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_40 = null;
            val_40 = null;
            val_41 = null;
            val_41 = null;
        }
        else
        {
                val_42 = 0;
        }
        
            if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC != 0)
        {
                val_30 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
            val_30 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        }
        
            val_30 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
            val_30 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
            val_43 = 0;
            if((val_38 == 0) && (val_30 == 0))
        {
                if(Player_move_c.丗丒丕专丛丆丈万一() != false)
        {
                val_30 = 1152921505171275776;
            val_44 = null;
            val_44 = null;
            bool val_27 = 与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下;
            val_27 = val_27 ^ 1;
            val_43 = val_27 & 255;
        }
        else
        {
                val_43 = 0;
        }
        
        }
        
            val_43 = val_43 & val_35;
            if(val_43 != false)
        {
                val_45 = null;
            val_45 = null;
            val_30 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_30 != 0)
        {
                val_46 = null;
            val_46 = null;
            val_30 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            if(val_30 != 0)
        {
                val_47 = null;
            val_47 = null;
            val_30 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            bool val_26 = val_30.世丆丙七丈与丝丁丐();
            val_26 = val_42 | val_26;
            if(val_26 != false)
        {
                val_48 = 1;
            return (bool)val_48;
        }
        
        }
        
        }
        
        }
        
        }
        
        label_132:
        val_48 = 0;
        return (bool)val_48;
    }
    public override bool CanPress()
    {
        Player_move_c val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = this;
        if((val_11 & 1) == 0)
        {
                return (bool)0 & 1;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return (bool)0 & 1;
        }
        
        if(this.GadgetPanelPressed == true)
        {
                return (bool)0 & 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(与丏下丝万上三丛不() == true)
        {
                return (bool)0 & 1;
        }
        
        val_13 = null;
        val_13 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                val_14 = null;
            val_14 = null;
            val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(专丝丄七丐丌丏东三() == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_16 = null;
        val_16 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        return (bool)0 & 1;
    }
    public override void ButtonUpdate()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        下七一丌丝丂丙七丑 val_22;
        this.ButtonUpdate();
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_15 = null;
            val_15 = null;
            val_16 = null;
            val_16 = null;
        }
        else
        {
                val_17 = 0;
        }
        
        if(this.hornIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.hornIcon, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.zoomIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.zoomIcon, 丏业丟一东丂东丘丛:  (val_17 == 0) ? 1 : 0);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_49;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_49;
        }
        
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_49;
        }
        
        val_20 = null;
        val_20 = null;
        var val_9 = (typeof(Player_move_c).__il2cppRuntimeField_57D != 0) ? 5 : 0;
        goto label_54;
        label_49:
        val_21 = 0;
        label_54:
        if(1152921505066536960 == 0)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
            goto label_58;
        }
        
        if(this.isPressed == false)
        {
            goto label_59;
        }
        
        val_22 = 1;
        if(null != 0)
        {
            goto label_69;
        }
        
        goto label_70;
        label_58:
        val_22 = 2;
        if(null != 0)
        {
            goto label_69;
        }
        
        label_70:
        label_69:
        state = val_22;
        return;
        label_59:
        if(null == null)
        {
            goto label_63;
        }
        
        if(null != 0)
        {
            goto label_69;
        }
        
        goto label_70;
        label_63:
        if(null == null)
        {
            goto label_66;
        }
        
        if(null != 0)
        {
            goto label_69;
        }
        
        goto label_70;
        label_66:
        var val_13 = (this.IsVisualBlock() != true) ? 2 : (val_21);
        if(null != 0)
        {
            goto label_69;
        }
        
        goto label_70;
    }
    public ZoomTouchButton()
    {
    
    }

}
