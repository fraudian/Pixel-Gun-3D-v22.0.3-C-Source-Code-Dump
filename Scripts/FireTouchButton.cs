using UnityEngine;
public class FireTouchButton : TouchButton
{
    // Fields
    public UnityEngine.GameObject bulletIcon;
    public UnityEngine.GameObject swordIcon;
    public UnityEngine.GameObject repairIcon;
    public UITexture shootTime;
    private static FireTouchButton 丘三丞且世丛丛丒一;
    private UITexture 与丗丒世不丐丈七丁;
    private bool 丏丕丌丙不且专三不;
    
    // Methods
    private void Start()
    {
        this.与丗丒世不丐丈七丁 = this.repairIcon.GetComponent<UITexture>();
    }
    internal bool 丛丙丘丆丛与丛丘丕()
    {
        var val_45;
        var val_46;
        Player_move_c val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        val_45 = null;
        val_45 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_46 = null;
            val_46 = null;
            val_47 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_47 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_48 = null;
            val_48 = null;
            val_47 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_47 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_49 = null;
            val_49 = null;
            val_47 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_47 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_50 = null;
            val_50 = null;
            val_51 = null;
            val_51 = null;
            val_47 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
            val_47 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            val_47 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_47.isWorldMapOpened == true)
        {
                return false;
        }
        
            if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_47 = 丅与丌专丟一丝业三();
            if(val_47.activeInHierarchy == true)
        {
                return false;
        }
        
        }
        
            if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_47 = public System.Boolean UnityEngine.Object::Equals(object other);
            if(WindowEnabled == true)
        {
                return false;
        }
        
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_52 = null;
            val_52 = null;
            val_47 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_47 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        val_47 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_47.一下丐丗丈与丟丄业() == false)
        {
            goto label_139;
        }
        
        val_53 = null;
        val_53 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_47 == 0)
        {
            goto label_80;
        }
        
        val_54 = null;
        val_54 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_14.isCharging == true)
        {
            goto label_139;
        }
        
        val_55 = null;
        val_55 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_15.isDash == true)
        {
            goto label_139;
        }
        
        val_56 = null;
        val_56 = null;
        WeaponSounds val_16 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        val_47 = val_16.InShopEffects;
        if((val_47.Contains(item:  3)) == true)
        {
            goto label_139;
        }
        
        val_57 = null;
        val_57 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().一与上丙一丙丅丐业();
        if(val_47 != 0)
        {
            goto label_139;
        }
        
        val_58 = null;
        val_58 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_21.portalGun == true)
        {
            goto label_139;
        }
        
        val_59 = null;
        val_59 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_22.harpoon == true)
        {
            goto label_139;
        }
        
        val_60 = null;
        val_60 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_23.isMelee == true)
        {
            goto label_139;
        }
        
        val_61 = null;
        val_61 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_24.bazooka == true)
        {
            goto label_139;
        }
        
        label_80:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_126;
        }
        
        val_62 = null;
        val_62 = null;
        val_47 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        if(val_47 == 0)
        {
                return false;
        }
        
        val_63 = null;
        val_63 = null;
        val_47 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        if(val_47.丏世三万丟丙丙丟丘() == true)
        {
            goto label_139;
        }
        
        return false;
        label_126:
        if(GameConnect.丙丌丒丈东七丒上丌() != true)
        {
                if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return false;
        }
        
        }
        
        label_139:
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return false;
        }
        
        if(GameConnect.一业上七丟业且业丙() == true)
        {
                return false;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return false;
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
                return false;
        }
        
        val_64 = null;
        val_64 = null;
        val_47 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_65 = 1;
        }
        else
        {
                val_65 = TrainingController.下且丌丑丟丒丒丗丞();
        }
        
        if(val_47 == 0)
        {
            goto label_165;
        }
        
        var val_39 = (typeof(Player_move_c).__il2cppRuntimeField_668 == 0) ? 76 : 0;
        if(val_65 == true)
        {
            goto label_169;
        }
        
        return false;
        label_165:
        val_66 = 0;
        if(val_65 == false)
        {
                return false;
        }
        
        label_169:
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return false;
        }
        
        val_67 = null;
        val_67 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_47 == 0)
        {
                return false;
        }
        
        val_68 = null;
        val_68 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_43.isGrenadeWeapon != false)
        {
                return false;
        }
        
        val_69 = null;
        val_69 = null;
        if(((val_66 & 127) == 76) || (与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == true))
        {
                return false;
        }
        
        return false;
    }
    internal bool 丈丁丌丄不与丌业丐()
    {
        Player_move_c val_15;
        var val_16;
        var val_17;
        val_15 = this;
        if(this.transform.parent.gameObject.activeInHierarchy == false)
        {
                return (bool)0 & 1;
        }
        
        if(this.GadgetPanelPressed != true)
        {
                val_16 = null;
            val_16 = null;
            val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_17 = null;
            val_17 = null;
            val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        return (bool)0 & 1;
    }
    public override bool IsActive()
    {
        if(与丂丏丛丞丞丒丟丄.丗丒丆丗丛丗上丌丂() == true)
        {
                return val_3.丛丙丘丆丛与丛丘丕();
        }
        
        if(与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌() == false)
        {
                return val_3.丛丙丘丆丛与丛丘丕();
        }
        
        bool val_3 = GameConnect.丙丌丒丈东七丒上丌();
        if(val_3 == false)
        {
                return false;
        }
        
        return val_3.丛丙丘丆丛与丛丘丕();
    }
    public override bool CanPress()
    {
        if((this & 1) == 0)
        {
                return false;
        }
        
        return this.丈丁丌丄不与丌业丐();
    }
    public void SetMeeleIcon(bool 丗丞业丒丘丆丁丗丕)
    {
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                return;
        }
        
        丗丞业丒丘丆丁丗丕 = 丗丞业丒丘丆丁丗丕;
        this.swordIcon.SetActive(value:  丗丞业丒丘丆丁丗丕);
        this.bulletIcon.SetActive(value:  (~丗丞业丒丘丆丁丗丕) & 1);
    }
    public override bool IsVisualBlock()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                val_5 = 1;
        }
        else
        {
                bool val_2 = 且丂一丁丆丒与丁业();
            val_5 = val_2 ^ 1;
        }
        
        val_2 = val_5;
        return (bool)val_2;
    }
    public override void ButtonUpdate()
    {
        var val_19;
        var val_20;
        var val_21;
        this.ButtonUpdate();
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                WeaponSounds val_2 = 丙不丅丕三丂业东丕();
        }
        
        UnityEngine.GameObject val_3 = this.shootTime.gameObject;
        val_20 = null;
        val_20 = null;
        if(FireTouchButton.丘三丞且世丛丛丒一 != this)
        {
            goto label_20;
        }
        
        var val_5 = (0f > 0f) ? 1 : 0;
        if(val_3 != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_20:
        val_21 = 0;
        if(val_3 != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        val_3.SetActive(value:  false);
        this.shootTime.fillAmount = 0f;
    }
    private void OnEnable()
    {
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                this.丘上与七下丄丄丏丆();
        }
        
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void FireTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                return;
        }
        
        if(this != null)
        {
                return;
        }
        
        this.丏丕丌丙不且专三不 = false;
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void FireTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        var val_8;
        var val_9;
        val_8 = 丙业与丙丗丝不丈东;
        val_9 = this;
        if(val_8 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        if(七丐丅专且专七三丆 != 4)
        {
                return;
        }
        
        if(null == 2)
        {
                if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
            this.丏丕丌丙不且专三不 = true;
        }
        else
        {
                if(null == null)
        {
                return;
        }
        
            if(this.丏丕丌丙不且专三不 == false)
        {
                return;
        }
        
            this.丏丕丌丙不且专三不 = false;
        }
        
        val_9 = ???;
        val_8 = ???;
        goto typeof(FireTouchButton).__il2cppRuntimeField_1D8;
    }
    public override void SetPressed(bool 丁丐不且七丂业丗丆)
    {
        var val_2;
        var val_3;
        var val_4;
        丁丐不且七丂业丗丆 = 丁丐不且七丂业丗丆;
        this.SetPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        if(丁丐不且七丂业丗丆 == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_3 = null;
            val_3 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  1);
        }
        
        val_4 = null;
        val_4 = null;
        FireTouchButton.丘三丞且世丛丛丒一 = this;
    }
    private bool 东下丅丙丛且丐下丒()
    {
        var val_3;
        var val_4;
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        if(PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丂丗一丈丏丞丈万丟() == false)
        {
            goto label_7;
        }
        
        label_3:
        val_4 = 1;
        return (bool)val_4;
        label_7:
        val_4 = 0;
        return (bool)val_4;
    }
    private void 丘上与七下丄丄丏丆()
    {
        this.swordIcon.SetActive(value:  false);
        this.bulletIcon.SetActive(value:  false);
        this.repairIcon.SetActive(value:  true);
    }
    public FireTouchButton()
    {
    
    }
    private static FireTouchButton()
    {
    
    }

}
