using UnityEngine;
public class JumpTouchButton : TouchButton
{
    // Fields
    public UnityEngine.GameObject jumpIcon;
    public UnityEngine.GameObject jetPackIcon;
    public UnityEngine.GameObject jumpOutIcon;
    public UnityEngine.GameObject gliderOn;
    public UnityEngine.GameObject gliderOff;
    public UnityEngine.GameObject blockedJump;
    public UnityEngine.GameObject circle;
    public UnityEngine.GameObject backGround;
    private bool 丒业丕万丅上丒上丆;
    private float 万丈且丕上一业丙丟;
    private float 且丛丝丄与丂丌上丑;
    private bool 丏丁丁东丕丘丘丂不;
    
    // Methods
    public override bool IsActive()
    {
        var val_30;
        var val_31;
        var val_32;
        Player_move_c val_33;
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
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_31 = null;
            val_31 = null;
            val_32 = null;
            val_32 = null;
            val_33 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_33 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        }
        
        val_34 = null;
        val_34 = null;
        val_33 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_33 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_35 = null;
        val_35 = null;
        val_33 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_33 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_33 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_33.isWorldMapOpened == true)
        {
            goto label_138;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
            goto label_38;
        }
        
        val_33 = 丅与丌专丟一丝业三();
        if(val_33.activeInHierarchy == true)
        {
            goto label_138;
        }
        
        label_38:
        val_33 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_33 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(val_33 == 0)
        {
            goto label_47;
        }
        
        val_33 = public System.Boolean UnityEngine.Object::Equals(object other);
        if(WindowEnabled == true)
        {
            goto label_138;
        }
        
        label_47:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_70;
        }
        
        }
        
        val_36 = null;
        val_36 = null;
        val_33 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_33 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_33 != 0)
        {
                val_37 = null;
            val_37 = null;
            val_33 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_33 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_33 = 1152921505039699968;
            double val_12 = BattleRoyaleController.丄专丕丞丟七丐丞世();
            val_12 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_12;
            var val_13 = (val_12 > (double)BattleRoyaleController.丛下丗丐七丏丗丕丕) ? 1 : 0;
            return (bool)val_38;
        }
        
        label_70:
        if(((GameConnect.丁丁丗丐东丄丞一丛() == true) || (GameConnect.丛专丌且丕不专丈下() == true)) || (GameConnect.丟丆丏上丌一丝丟业() == true))
        {
            goto label_138;
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
        
        val_33 = 1152921505171275776;
        if(((与丂丏丛丞丞丒丟丄.丗丒丆丗丛丗上丌丂() == true) || (GameConnect.丆丕丒与丂七与下上() == true)) || (与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == false))
        {
            goto label_119;
        }
        
        val_42 = null;
        val_42 = null;
        val_33 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_33 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_33 == 0)
        {
            goto label_138;
        }
        
        val_43 = null;
        val_43 = null;
        val_33 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_33 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_44 = null;
        val_44 = null;
        val_33 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_33 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        label_119:
        if(val_41 == 0)
        {
            goto label_127;
        }
        
        label_138:
        val_38 = 0;
        return (bool)val_38;
        label_127:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == true)
        {
            goto label_129;
        }
        
        val_45 = null;
        val_45 = null;
        if(TrainingController.七专业一丂万丛丝上 < 3)
        {
            goto label_138;
        }
        
        label_129:
        if((((SelectionControlMode.IsShowing == true) || (PlantTheBombController.BlockControls == true)) || (MutationController.丑不专七丗丛丅与丟() == true)) || (RedLightController.丑不专七丗丛丅与丟() == true))
        {
            goto label_138;
        }
        
        return (bool)val_38;
    }
    public override bool CanPress()
    {
        var val_16;
        var val_17;
        var val_18;
        UnityEngine.Object val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_30;
        val_16 = this;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_63;
        }
        
        }
        
        val_17 = 1152921505286238208;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == val_19)
        {
            goto label_63;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_20 = null;
            val_20 = null;
            val_19 = 0;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_19)
        {
                val_21 = null;
            val_21 = null;
            val_16 = 1152921505039699968;
            double val_7 = BattleRoyaleController.丄专丕丞丟七丐丞世();
            val_7 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_7;
            var val_8 = (val_7 > (double)BattleRoyaleController.丛下丗丐七丏丗丕丕) ? 1 : 0;
            return (bool)val_22;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = null;
        val_25 = null;
        val_16 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_16 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        label_95:
        var val_9 = () ? 1 : 0;
        return (bool)val_22;
        label_63:
        val_30 = null;
        val_30 = null;
        if(((val_16 & 1) == 0) || (丘丐丘万丌丟丞下丝.丘丏万丆丗万丐丞下() == true))
        {
            goto label_88;
        }
        
        val_17 = this.gameObject;
        if(((val_17.activeInHierarchy == false) || (this.GadgetPanelPressed == true)) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0))
        {
            goto label_88;
        }
        
        val_16 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_16 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        if(val_16.丒七下丁丛不丄丅一() == false)
        {
            goto label_95;
        }
        
        val_22 = 1;
        return (bool)val_22;
        label_88:
        val_22 = 0;
        return (bool)val_22;
    }
    public override void ButtonUpdate()
    {
        下七一丌丝丂丙七丑 val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        UnityEngine.GameObject val_40;
        var val_41;
        var val_42;
        var val_43;
        if((this & 1) != 0)
        {
                this.丏丁丁东丕丘丘丂不 = false;
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
        
        if(137121792 == 0)
        {
            goto label_9;
        }
        
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_10;
        }
        
        if(this.isPressed == false)
        {
            goto label_11;
        }
        
        val_31 = 1;
        if(!=0)
        {
            goto label_110;
        }
        
        goto label_111;
        label_10:
        val_31 = 2;
        if(!=0)
        {
            goto label_110;
        }
        
        label_111:
        label_110:
        state = val_31;
        label_9:
        val_32 = null;
        val_32 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_40;
        }
        
        val_33 = null;
        val_33 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_40;
        }
        
        val_34 = null;
        val_34 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
            goto label_40;
        }
        
        val_35 = null;
        val_35 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) == 0)
        {
            goto label_40;
        }
        
        val_36 = null;
        val_36 = null;
        val_37 = null;
        var val_8 = ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 265) == 0) ? 1 : 0;
        val_37 = null;
        val_38 = null;
        val_38 = null;
        var val_9 = ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 241) == 0) ? 1 : 0;
        goto label_60;
        label_40:
        var val_33 = 0;
        label_109:
        if(this.gliderOn != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gliderOn, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.jumpOutIcon != 0)
        {
                var val_13 = (0 != 0) ? 1 : 0;
            var val_15 = val_33 ^ 1;
            val_15 = val_13 & val_15;
            val_13 = 1 | val_15;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.jumpOutIcon, 丏业丟一东丂东丘丛:  (((val_13 != 0) ? (val_15) : ((0 != 0) ? 0 : (0 ^ 1))) != 0) ? 1 : 0);
        }
        
        if(this.jumpIcon != 0)
        {
                val_39 = null;
            val_39 = null;
            var val_20 = (0 != 0) ? 1 : 0;
            var val_21 = (与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 == true) ? 1 : 0;
            val_21 = val_33 | val_21;
            val_20 = (val_21 | val_20) ^ 1;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.jumpIcon, 丏业丟一东丂东丘丛:  ((0 != 1) ? 1 : 0) & val_20);
        }
        
        val_40 = this.jetPackIcon;
        if(val_40 != 0)
        {
                val_40 = this.jetPackIcon;
            val_41 = null;
            val_41 = null;
            var val_26 = (0 != 0) ? 1 : 0;
            var val_27 = (与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 == false) ? 1 : 0;
            val_27 = val_33 | val_27;
            val_33 = val_27 | val_26;
            val_26 = val_33 ^ 1;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_40, 丏业丟一东丂东丘丛:  ((0 != 1) ? 1 : 0) & val_26);
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.blockedJump, 丏业丟一东丂东丘丛:  丘丐丘万丌丟丞下丝.丘丏万丆丗万丐丞下());
        return;
        label_11:
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_89;
        }
        
        if(!=0)
        {
            goto label_110;
        }
        
        goto label_111;
        label_89:
        if(this.丒业丕万丅上丒上丆 == false)
        {
            goto label_92;
        }
        
        if(!=0)
        {
            goto label_110;
        }
        
        goto label_111;
        label_60:
        val_42 = null;
        val_42 = null;
        val_43 = null;
        val_43 = null;
        goto label_109;
        label_92:
        var val_32 = (this != 1) ? 2 : 0;
        if(!=0)
        {
            goto label_110;
        }
        
        goto label_111;
    }
    public override void SetPressed(bool 丁丐不且七丂业丗丆)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        丁丐不且七丂业丗丆 = 丁丐不且七丂业丗丆;
        this.SetPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        if(丁丐不且七丂业丗丆 == false)
        {
                return;
        }
        
        val_5 = 1152921505051201536;
        val_6 = null;
        val_6 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_7 = null;
            val_7 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  2);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_42;
        }
        
        }
        
        val_5 = 1152921505286238208;
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_9 = null;
            val_9 = null;
            val_10 = null;
            val_11 = null;
            typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丈下丘万丙丌且丄且();
        }
        
        label_42:
        this.丏丁丁东丕丘丘丂不 = true;
        this.且丛丝丄与丂丌上丑 = 0f;
    }
    public JumpTouchButton()
    {
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_6;
        }
        
        }
        
        if(this != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        this.万丈且丕上一业丙丟 = 0.25f;
        return;
        label_6:
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }

}
