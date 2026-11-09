using UnityEngine;
public class VehicleSpawnTouchButton : TouchButton
{
    // Fields
    public UITexture cooldown;
    public UnityEngine.GameObject cooldownEnds;
    public UnityEngine.GameObject hintCar;
    private UIBasicSprite vehicleIcon;
    internal bool 丑丙丝丐丏丗丈丁丞;
    public UnityEngine.GameObject cantUseGadgetObj;
    private int 丗丐专一与丘丆丆东;
    public bool canShowSniperHint;
    private FreePlayModeController 下丘丆丁丄一丙东世;
    private string 丅丙丏丐丄丟丌丑丁;
    private bool 三一世丕丞三不丏丌;
    private UnityEngine.Coroutine 下丌丏丞丑丕丙丆不;
    private bool 丏丕丌丙不且专三不;
    
    // Properties
    private FreePlayModeController 世丗下业丙丑丒万丟 { get; }
    public UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    internal bool 世七丟且丆丒不丌丁 { get; set; }
    
    // Methods
    private FreePlayModeController 丛丛丕与丐万丛丘丝()
    {
        var val_3;
        FreePlayModeController val_4;
        if(this.下丘丆丁丄一丙东世 != 0)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        if(GameController.mode == null)
        {
            goto label_6;
        }
        
        var val_2 = (null == null) ? GameController.mode : 0;
        goto label_7;
        label_3:
        val_4 = this.下丘丆丁丄一丙东世;
        return val_4;
        label_6:
        val_4 = 0;
        label_7:
        this.下丘丆丁丄一丙东世 = val_4;
        return val_4;
    }
    public UIBasicSprite get_Icon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.vehicleIcon);
        this.vehicleIcon = val_1;
        return val_1;
    }
    public override bool IsActive()
    {
        InGameGUI val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return (bool)0 & 1;
        }
        
        val_10 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_10.isWorldMapOpened == true)
        {
                return (bool)0 & 1;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_12 = null;
        val_12 = null;
        val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_13 = null;
        val_13 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_10 != 0)
        {
                val_14 = null;
            val_14 = null;
            val_10 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_10 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        }
        
        return (bool)0 & 1;
    }
    public bool CanShowHint()
    {
        var val_13;
        InGameGUIPart_Freeplay val_14;
        var val_15;
        var val_16;
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_13 = WindowEnabled;
        }
        else
        {
                val_13 = 0;
        }
        
        val_14 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_14 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(val_14 != 0)
        {
                val_14 = 丅与丌专丟一丝业三();
            val_15 = val_14.activeInHierarchy ^ 1;
        }
        else
        {
                val_15 = 1;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_20;
        }
        
        val_14 = InGameGUI.丙丞专丌丁丞与不丐;
        bool val_7 = val_14.isWorldMapOpened;
        if(val_7 == false)
        {
            goto label_22;
        }
        
        label_20:
        val_16 = 0;
        return (bool)val_16;
        label_22:
        bool val_9 = val_7.丛七丘世丘丙丌七丂() ^ 1;
        val_9 = val_15 & val_9;
        val_16 = ((val_13 == 0) ? 1 : 0) & val_9;
        return (bool)val_16;
    }
    internal bool 丛七丘世丘丙丌七丂()
    {
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  136)) == true)
        {
                return (bool)丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  136));
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  136, 丙业与丙丗丝不丈东:  0);
        return (bool)丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  136));
    }
    internal void 丑与三丑丈上丙丄丘(bool 丙业与丙丗丝不丈东)
    {
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  136)) != true)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  136, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  136, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void OnEnable()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void VehicleSpawnTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        if(this.三一世丕丞三不丏丌 == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintCar, 丏业丟一东丂东丘丛:  false);
        if(this.下丌丏丞丑丕丙丆不 != null)
        {
                return;
        }
        
        this.下丌丏丞丑丕丙丆不 = this.StartCoroutine(routine:  this.专丅丁万世七丒丑丕());
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void VehicleSpawnTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        if(this.下丌丏丞丑丕丙丆不 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.下丌丏丞丑丕丙丆不);
        this.下丌丏丞丑丕丙丆不 = 0;
    }
    public override bool CanPress()
    {
        var val_6;
        bool val_7;
        val_6 = null;
        val_6 = null;
        if((this & 1) != 0)
        {
                if(this.gameObject.activeInHierarchy != false)
        {
                val_7 = this.丑丙丝丐丏丗丈丁丞;
            if(val_7 == false)
        {
                return (bool)val_7 & 1;
        }
        
            bool val_3 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7 & 1;
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        bool val_9;
        var val_10;
        val_9 = 丙业与丙丗丝不丈东;
        val_10 = this;
        if(val_9 == null)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 31)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_9);
        if(七丐丅专且专七三丆 != 16)
        {
                return;
        }
        
        if(null == 1)
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
        
        val_10 = ???;
        val_9 = ???;
        goto typeof(VehicleSpawnTouchButton).__il2cppRuntimeField_1D8;
    }
    public override void ButtonUpdate()
    {
        下七一丌丝丂丙七丑 val_16;
        float val_18;
        if(static_value_082C4000 == 0)
        {
            goto label_3;
        }
        
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        if(this.isPressed == false)
        {
            goto label_5;
        }
        
        val_16 = 1;
        if(!=0)
        {
            goto label_37;
        }
        
        goto label_38;
        label_4:
        val_16 = 2;
        if(!=0)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        state = val_16;
        label_3:
        if(this.丛丛丕与丐万丛丘丝() == 0)
        {
                return;
        }
        
        FreePlayModeController val_5 = this.丛丛丕与丐万丛丘丝();
        if(val_5.vehicleController == 0)
        {
            goto label_15;
        }
        
        if(val_5.vehicleController == null)
        {
            goto label_16;
        }
        
        val_18 = val_5.vehicleController.丏丛万丆丝丌丏丟下();
        goto label_17;
        label_5:
        if(null == null)
        {
            goto label_18;
        }
        
        if(!=0)
        {
            goto label_37;
        }
        
        goto label_38;
        label_16:
        val_18 = 0.丏丛万丆丝丌丏丟下();
        label_17:
        val_18 = val_18 / val_5.vehicleController.丂丙丆丝丄丗与不丗;
        if((val_18 <= 0f) && (this.丑丙丝丐丏丗丈丁丞 != true))
        {
                this.丑丙丝丐丏丗丈丁丞 = true;
            this.cooldownEnds.SetActive(value:  true);
            this.cooldownEnds.GetComponent<TweenScale>().PlayForward();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.cooldownEnds.GetComponent<UIPlaySound>().Play();
        }
        
        }
        
        this.丑丙丝丐丏丗丈丁丞 = (val_18 <= 0f) ? 1 : 0;
        this.cooldown.gameObject.SetActive(value:  (val_18 > 0f) ? 1 : 0);
        this.cooldown.fillAmount = val_18;
        label_15:
        this.专三不上丈丟丌丞丗();
        return;
        label_18:
        if(null == null)
        {
            goto label_34;
        }
        
        if(!=0)
        {
            goto label_37;
        }
        
        goto label_38;
        label_34:
        var val_15 = (this != 1) ? 2 : 0;
        if(!=0)
        {
            goto label_37;
        }
        
        goto label_38;
    }
    private void 专三不上丈丟丌丞丗()
    {
        this.丗丕丝丗丙丄丅丛丅(一丑丒丂丟业下上万:  丛且丗丌丏下七下丈.丗丘丌丘七丏丝下七());
    }
    internal void 丗丕丝丗丙丄丅丛丅(string 一丑丒丂丟业下上万)
    {
        var val_5;
        if((System.String.IsNullOrEmpty(value:  一丑丒丂丟业下上万)) == true)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.丅丙丏丐丄丟丌丑丁, b:  一丑丒丂丟业下上万)) == false)
        {
                return;
        }
        
        val_5 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  一丑丒丂丟业下上万, 七丆丒与丗丌丄且丂:  80, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        UIBasicSprite val_4 = this.Icon;
        this.丅丙丏丐丄丟丌丑丁 = 一丑丒丂丟业下上万;
    }
    private System.Collections.IEnumerator 专丅丁万世七丒丑丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleSpawnTouchButton.上丞丗丗东丅万业万();
    }
    internal void 丟丟东业世丁丐与上()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintCar, 丏业丟一东丂东丘丛:  false);
    }
    public override bool OnPress(bool 丆且上丘世下丅且丞, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_2;
        if(丆且上丘世下丅且丞 != false)
        {
                if((((this & 1) != 0) && ((1152921538139089048 & 1) != 0)) && (null != null))
        {
                mem[1152921538139089065] = 1;
        }
        
            var val_1 = (null != 0) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        mem[1152921538139089065] = 0;
        return (bool)val_2;
    }
    public bool Press(bool 丆且上丘世下丅且丞)
    {
        var val_2;
        if(丆且上丘世下丅且丞 != false)
        {
                if(((this & 1) != 0) && (null != null))
        {
                mem[1152921538139201065] = 1;
        }
        
            var val_1 = (null != 0) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        mem[1152921538139201065] = 0;
        return (bool)val_2;
    }
    public override void OnPressed(bool 丁丐不且七丂业丗丆)
    {
        丁丐不且七丂业丗丆 = 丁丐不且七丂业丗丆;
        this.OnPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        if(this.丛丛丕与丐万丛丘丝() == 0)
        {
                return;
        }
        
        this.丛丛丕与丐万丛丘丝().丌丙丞世且丗丛丟丟();
        this.丟丟东业世丁丐与上();
        this.丑与三丑丈上丙丄丘(丙业与丙丗丝不丈东:  true);
    }
    public VehicleSpawnTouchButton()
    {
        this.丑丙丝丐丏丗丈丁丞 = true;
        this.丅丙丏丐丄丟丌丑丁 = System.String.alignConst;
    }

}
