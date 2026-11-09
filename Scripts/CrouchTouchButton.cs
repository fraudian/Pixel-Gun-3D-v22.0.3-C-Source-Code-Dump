using UnityEngine;
public class CrouchTouchButton : TouchButton
{
    // Fields
    public UnityEngine.GameObject upIcon;
    public UnityEngine.GameObject downIcon;
    private float 万丈且丕上一业丙丟;
    private float 且丛丝丄与丂丌上丑;
    private bool 丏丁丁东丕丘丘丂不;
    private bool 丒业丕万丅上丒上丆;
    
    // Methods
    public override bool IsActive()
    {
        var val_8;
        GameModeController val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = null;
        val_8 = null;
        val_9 = GameController.mode;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
                return false;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_9 == 0)
        {
                return false;
        }
        
        val_11 = null;
        val_11 = null;
        val_9 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_12 = null;
        val_12 = null;
        val_9 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_13 = null;
        val_13 = null;
        val_9 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_14 = null;
        val_14 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9.isWorldMapOpened == true)
        {
                return false;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_9 = 丅与丌专丟一丝业三();
            if(val_9.activeInHierarchy == true)
        {
                return false;
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
                return false;
        }
        
        val_9 = public System.Boolean UnityEngine.Object::Equals(object other);
        if(WindowEnabled == false)
        {
                return false;
        }
        
        return false;
    }
    public override bool CanPress()
    {
        Player_move_c val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = this;
        if((val_2 & 1) == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        val_2 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 216];
        val_2 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 216;
        if(val_2.isGrounded == false)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_5 = null;
        val_5 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        return false;
    }
    public override void ButtonUpdate()
    {
        var val_8;
        下七一丌丝丂丙七丑 val_9;
        var val_10;
        var val_11;
        UnityEngine.GameObject val_12;
        var val_13;
        if((this & 1) != 0)
        {
                this.丏丁丁东丕丘丘丂不 = true;
            this.丒业丕万丅上丒上丆 = true;
        }
        else
        {
                if(this.丒业丕万丅上丒上丆 != false)
        {
                if(this.丏丁丁东丕丘丘丂不 != false)
        {
                if(this.且丛丝丄与丂丌上丑 <= 0f)
        {
                this.丒业丕万丅上丒上丆 = false;
        }
        
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.且丛丝丄与丂丌上丑 - val_1;
            this.且丛丝丄与丂丌上丑 = val_1;
        }
        else
        {
                this.丏丁丁东丕丘丘丂不 = true;
            this.且丛丝丄与丂丌上丑 = this.万丈且丕上一业丙丟;
        }
        
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_10 = null;
            val_10 = null;
            var val_3 = ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 269) != 0) ? 1 : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_22;
        }
        
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_23;
        }
        
        if(this.isPressed == false)
        {
            goto label_24;
        }
        
        val_9 = 1;
        if(null != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_23:
        val_9 = 2;
        if(null != 0)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        state = val_9;
        label_22:
        if(this.downIcon == null)
        {
            goto label_28;
        }
        
        if(val_11 == 0)
        {
            goto label_29;
        }
        
        label_32:
        this.downIcon.SetActive(value:  false);
        val_12 = this.upIcon;
        val_13 = 1;
        goto label_31;
        label_28:
        if(val_11 != 0)
        {
            goto label_32;
        }
        
        label_29:
        this.downIcon.SetActive(value:  true);
        val_12 = this.upIcon;
        val_13 = 0;
        label_31:
        val_12.SetActive(value:  false);
        return;
        label_24:
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_34;
        }
        
        if(null != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_34:
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_37;
        }
        
        if(null != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_37:
        var val_7 = (this != 1) ? 2 : ((val_11 != 0) ? 5 : 0);
        if(null != 0)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    public override void SetPressed(bool 丁丐不且七丂业丗丆)
    {
        bool val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = 丁丐不且七丂业丗丆;
        丁丐不且七丂业丗丆 = val_2;
        this.SetPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        if(val_2 == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        val_2 = GameController.mode;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_2 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丌丛丄丗丂丙丛七丄();
    }
    public CrouchTouchButton()
    {
        this.万丈且丕上一业丙丟 = (GameConnect.万不丒丌丙万丗东不() != true) ? 0.25f : 0.15f;
    }

}
