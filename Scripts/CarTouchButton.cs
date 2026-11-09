using UnityEngine;
public class CarTouchButton : TouchButton
{
    // Fields
    public UnityEngine.GameObject getInVechicle;
    public UnityEngine.GameObject getInPassenger;
    public UnityEngine.GameObject getOutVehicle;
    public UnityEngine.GameObject animObject;
    public UnityEngine.GameObject transportOwnerName;
    public bool activatedForHint;
    
    // Methods
    public override bool IsActive()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_103;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_103;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        val_14 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) == 0)
        {
            goto label_103;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = null;
        val_16 = null;
        val_17 = null;
        val_17 = null;
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive == true)
        {
            goto label_103;
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = null;
        val_21 = null;
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == false)
        {
            goto label_67;
        }
        
        label_103:
        this.activatedForHint = false;
        return false;
        label_67:
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                val_22 = null;
            val_22 = null;
            val_23 = null;
            val_23 = null;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened == true)
        {
            goto label_103;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                if(丅与丌专丟一丝业三().activeInHierarchy == true)
        {
            goto label_103;
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
                return false;
        }
        
        if(WindowEnabled == true)
        {
            goto label_103;
        }
        
        return false;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.transportOwnerName, 丏业丟一东丂东丘丛:  false);
        HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "use_vehicle");
    }
    public override bool CanPress()
    {
        var val_3;
        if((this & 1) != 0)
        {
                val_3 = this.丐东业丌丙万上业丏() ^ 1;
            return (bool)val_3 & 1;
        }
        
        val_3 = 0;
        return (bool)val_3 & 1;
    }
    private bool 丐东业丌丙万上业丏()
    {
        Player_move_c val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return (bool)0 & 1;
        }
        
        val_13 = null;
        val_13 = null;
        val_12 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_12 == 0)
        {
                return (bool)0 & 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_12 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_12 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_15 = null;
        val_15 = null;
        val_12 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
        val_12 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
        if(val_12 == 0)
        {
                return (bool)0 & 1;
        }
        
        val_16 = null;
        val_16 = null;
        val_12 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
        val_12 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
        if(val_12.不丐一丙丏丑丑丗一() == false)
        {
                return (bool)0 & 1;
        }
        
        val_17 = null;
        val_17 = null;
        val_12 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.丛丈丁丑丐业上七丙();
        if((System.String.op_Inequality(a:  val_12, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
                return (bool)0 & 1;
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        if(GameController.mode != null)
        {
                var val_9 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        bool val_12 = (val_20.丘七丈丅丐丄丐丗万(七三丁丄三一且丘上:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.万东丂七东丁与业东())) ^ 1;
        return (bool)0 & 1;
    }
    public override void ButtonUpdate()
    {
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        UnityEngine.GameObject val_36;
        var val_37;
        var val_38;
        var val_39;
        string val_40;
        int val_41;
        this.ButtonUpdate();
        if((this & 1) == 0)
        {
                return;
        }
        
        bool val_1 = this.丐东业丌丙万上业丏();
        if((val_1 == true) || (this.activatedForHint == true))
        {
            goto label_23;
        }
        
        this.activatedForHint = true;
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_23;
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_18;
        }
        
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = val_4.localPosition;
        UnityEngine.Vector3 val_6 = val_4.size;
        val_6.x = val_6.x * 0.5f;
        if(System.Math.Abs(val_5.x) <= val_6.x)
        {
            goto label_18;
        }
        
        val_25 = null;
        val_25 = null;
        万不万丈丂一万与丂();
        goto label_23;
        label_18:
        val_26 = null;
        val_26 = null;
        丌丕专丌世丁丒丈万();
        label_23:
        val_27 = null;
        val_27 = null;
        val_28 = null;
        val_28 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) != 0)
        {
                val_29 = null;
            val_29 = null;
            val_30 = UnityEngine.Object.op_Equality(x:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224 + 32, y:  0);
        }
        else
        {
                val_30 = 0;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getInVechicle, 丏业丟一东丂东丘丛:  false);
        val_31 = null;
        val_31 = null;
        val_32 = null;
        val_32 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) != 0)
        {
                val_33 = null;
            val_33 = null;
            val_34 = UnityEngine.Object.op_Inequality(x:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224 + 32, y:  0);
        }
        else
        {
                val_34 = 0;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getInPassenger, 丏业丟一东丂东丘丛:  false);
        val_35 = null;
        val_35 = null;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getOutVehicle, 丏业丟一东丂东丘丛:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.animObject, 丏业丟一东丂东丘丛:  ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266) == 0) ? 1 : 0);
        val_36 = this.transportOwnerName;
        if(val_1 == false)
        {
            goto label_98;
        }
        
        if(val_36.activeSelf == true)
        {
                return;
        }
        
        val_37 = null;
        val_37 = null;
        val_36 = 1152921504848912384;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) == 0)
        {
                return;
        }
        
        val_38 = null;
        val_38 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.万东丂七东丁与业东()) == 0)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        与丅丕丈丘东丝世丟 val_18 = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.万东丂七东丁与业东().丂丞东丞万万丒丑丆());
        if(val_18 == null)
        {
            goto label_128;
        }
        
        val_40 = val_18.丁下不丛下且丌专丈();
        goto label_129;
        label_98:
        label_142:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  false);
        return;
        label_128:
        val_40 = 0;
        label_129:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_40)) != false)
        {
                val_41 = System.String.alignConst;
        }
        else
        {
                val_41 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12718"), arg0:  val_40);
        }
        
        this.transportOwnerName.GetComponent<UILabel>().text = val_41;
        goto label_142;
    }
    public override void SetPressed(bool 丁丐不且七丂业丗丆)
    {
        bool val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_5 = 丁丐不且七丂业丗丆;
        丁丐不且七丂业丗丆 = val_5;
        this.SetPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        if(val_5 == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_7 = null;
            val_7 = null;
            三丐丄专丞丞专且丆();
        }
        
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) != 0)
        {
                val_11 = null;
            val_11 = null;
            typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丟丑丌丆丕丒丞三丏(丝一东丄丕丁不一丕:  0);
            return;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_5 == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_5 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_5 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_14 = null;
        val_14 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.世丏丏东丌七与东丁(丘上丅丝丄三一丕丁:  false);
    }
    public CarTouchButton()
    {
    
    }

}
