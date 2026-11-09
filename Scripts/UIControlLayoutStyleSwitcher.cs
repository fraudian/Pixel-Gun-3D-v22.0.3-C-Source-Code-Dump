using UnityEngine;
public class UIControlLayoutStyleSwitcher : MonoBehaviour
{
    // Fields
    private 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 layoutStyle;
    public UIToggle topCheckbox;
    public SettingsToggleButtons aimingCheckbox;
    public SettingsToggleButtons autoShootingCheckbox;
    public Rilisoft.ButtonHandler openControlsButton;
    public System.Collections.Generic.List<UIControlLayoutStyleSwitcher.MapHolderSettings> MapHolderSettingsList;
    public UITexture mapHolder;
    public UIToggle sniperModeButton;
    public UIToggle onModeButton;
    public UIToggle offSniperModeButton;
    private UIToggle 三丅丌丘三上丟丕东;
    private UIWidget 与东七丏丆世丟丁丌;
    
    // Properties
    private bool 丐上不业丐丕丅丆与 { get; }
    public 与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘 丟丝丄丂专三丈丁丏 { get; }
    
    // Methods
    private bool 与丘丕丌丄丁专丐丌()
    {
        if(this.三丅丌丘三上丟丕东 != null)
        {
                return this.三丅丌丘三上丟丕东.value;
        }
        
        return this.三丅丌丘三上丟丕东.value;
    }
    public 与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘 get_SelectedSecondFireMode()
    {
        UIToggle val_7;
        var val_8;
        val_7 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.sniperModeButton)) != false)
        {
                if(this.sniperModeButton.value == true)
        {
            goto label_16;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.onModeButton)) != false)
        {
                if(this.onModeButton.value != false)
        {
                val_8 = 1;
            return (与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘)val_8;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.offSniperModeButton)) != false)
        {
                val_7 = this.offSniperModeButton;
            if(val_7.value != false)
        {
                val_8 = 2;
            return (与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘)val_8;
        }
        
        }
        
        label_16:
        val_8 = 0;
        return (与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘)val_8;
    }
    private void Awake()
    {
        var val_23;
        UnityEngine.Events.UnityAction<丛七万丑下东业下丟> val_25;
        this.三丅丌丘三上丟丕东 = this.GetComponent<UIToggle>();
        val_1.onChange.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIControlLayoutStyleSwitcher::丑三丘丑丘业丘丌上())));
        if((UnityEngine.Object.op_Implicit(exists:  this.aimingCheckbox)) != false)
        {
                this.aimingCheckbox.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::丌丅万丆丗丅丈丛东(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 专丒丌丆下丐丞丟丞)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.autoShootingCheckbox)) != false)
        {
                this.autoShootingCheckbox.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::丞丌东丌上世东丙丁(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 专丒丌丆下丐丞丟丞)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.openControlsButton)) == false)
        {
            goto label_13;
        }
        
        val_23 = null;
        val_23 = null;
        if((UIControlLayoutStyleSwitcher.<>c.<>9__17_2) == null)
        {
            goto label_16;
        }
        
        label_38:
        this.openControlsButton.add_Clicked(丙业与丙丗丝不丈东:  UIControlLayoutStyleSwitcher.<>c.<>9__17_2);
        label_13:
        if((UnityEngine.Object.op_Implicit(exists:  this.sniperModeButton)) != false)
        {
                this.sniperModeButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::下丈且三东业丕丒七(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.onModeButton)) != false)
        {
                this.onModeButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::三丏丒丂丑丒一丈丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.offSniperModeButton)) != false)
        {
                this.offSniperModeButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::丏专丗世丐丗丞丕丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)));
        }
        
        this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
        if(((System.Delegate.Combine(a:  SettingsTabControls.上丄丐世世丘七与丈, b:  new UnityEngine.Events.UnityAction<丛七万丑下东业下丟>(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::业丄丑丞下不七丏三(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)))) != null) && (null != null))
        {
                val_25 = 0;
        }
        
        SettingsTabControls.上丄丐世世丘七与丈 = val_25;
        return;
        label_16:
        UIControlLayoutStyleSwitcher.<>c.<>9__17_2 = new System.EventHandler(object:  UIControlLayoutStyleSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UIControlLayoutStyleSwitcher.<>c::丁丛丅业丞三丟丛东(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
        if(this.openControlsButton != null)
        {
            goto label_38;
        }
        
        goto label_38;
    }
    private void Start()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.topCheckbox)) == false)
        {
                return;
        }
        
        this.topCheckbox.enabled = false;
    }
    private void 丑三丘丑丘业丘丌上()
    {
        UIWidget val_30;
        UIToggle val_31;
        if(this.与丘丕丌丄丁专丐丌() != false)
        {
                SettingsTabControls.丆丕丝丒不丙且丐丗.丝丛一丁专丗专丅东(丏东丆丆丛丄丕丈丞:  this.layoutStyle);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.与东七丏丆世丟丁丌)) != false)
        {
                val_30 = this.与东七丏丆世丟丁丌;
        }
        else
        {
                val_30 = this.GetComponent<UIWidget>();
            this.与东七丏丆世丟丁丌 = val_30;
        }
        
        val_31 = this.三丅丌丘三上丟丕东;
        var val_5 = (val_31.value != true) ? 1f : 0.5f;
        if((UnityEngine.Object.op_Implicit(exists:  this.openControlsButton)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.openControlsButton.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.topCheckbox)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.topCheckbox.Set(丏业丟一东丂东丘丛:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.aimingCheckbox)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.aimingCheckbox.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.autoShootingCheckbox)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.autoShootingCheckbox.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.sniperModeButton)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.sniperModeButton.GetComponent<Rilisoft.ButtonHandler>().丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.onModeButton)) != false)
        {
                val_31 = this.三丅丌丘三上丟丕东.value;
            this.onModeButton.GetComponent<Rilisoft.ButtonHandler>().丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.offSniperModeButton)) == false)
        {
                return;
        }
        
        this.offSniperModeButton.GetComponent<Rilisoft.ButtonHandler>().丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  this.三丅丌丘三上丟丕东.value);
    }
    private void 丙七丙丕丝丐一丛丆()
    {
        if(this.与丘丕丌丄丁专丐丌() == false)
        {
                return;
        }
        
        SettingsTabControls.丆丕丝丒不丙且丐丗.丙七丙丕丝丐一丛丆();
    }
    private void 业丄丑丞下不七丏三(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)
    {
        下丂世丂不丛专一一.丛七万丑下东业下丟 val_17;
        bool val_18;
        val_17 = 丁丅丈丌丟世丗丗丟;
        .丁丅丈丌丟世丗丗丟 = val_17;
        if(this.MapHolderSettingsList != null)
        {
                if((System.Linq.Enumerable.Any<MapHolderSettings>(source:  this.MapHolderSettingsList)) != false)
        {
                if((System.Linq.Enumerable.FirstOrDefault<MapHolderSettings>(source:  this.MapHolderSettingsList, predicate:  new System.Func<MapHolderSettings, System.Boolean>(object:  new UIControlLayoutStyleSwitcher.丈业丗丞丁七下一不(), method:  System.Boolean UIControlLayoutStyleSwitcher.丈业丗丞丁七下一不::万丌丌丛丕万下丈世(UIControlLayoutStyleSwitcher.MapHolderSettings 三丟东丕丄丄下下丑)))) != null)
        {
                bool val_5 = UnityEngine.Object.op_Implicit(exists:  this.mapHolder);
        }
        
        }
        
            val_17 = (UIControlLayoutStyleSwitcher.丈业丗丞丁七下一不)[1152921538983423632].丁丅丈丌丟世丗丗丟;
        }
        
        if(val_17 == 3)
        {
                return;
        }
        
        ControlFireSettings val_6 = SettingsTabControls.丆丕丝丒不丙且丐丗.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  val_17, 与丄丁丏丙与业丗丑:  this.layoutStyle);
        if((UnityEngine.Object.op_Implicit(exists:  this.aimingCheckbox)) != false)
        {
                this.aimingCheckbox.IsChecked = (val_6.IsAiming == true) ? 1 : 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.autoShootingCheckbox)) == false)
        {
            goto label_18;
        }
        
        if(this.layoutStyle != 1)
        {
            goto label_19;
        }
        
        val_18 = 1;
        if(this.autoShootingCheckbox != null)
        {
            goto label_23;
        }
        
        goto label_21;
        label_19:
        val_18 = val_6.IsAutoShooting;
        if(this.autoShootingCheckbox != null)
        {
            goto label_23;
        }
        
        label_21:
        label_23:
        this.autoShootingCheckbox.IsChecked = (val_18 == true) ? 1 : 0;
        label_18:
        if((UnityEngine.Object.op_Implicit(exists:  this.sniperModeButton)) != false)
        {
                this.sniperModeButton.Set(丏业丟一东丂东丘丛:  (val_6.GameSecondFireButtonMode == 0) ? 1 : 0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.onModeButton)) != false)
        {
                this.onModeButton.Set(丏业丟一东丂东丘丛:  (val_6.GameSecondFireButtonMode == 1) ? 1 : 0);
        }
        
        val_17 = this.offSniperModeButton;
        if((UnityEngine.Object.op_Implicit(exists:  val_17)) == false)
        {
                return;
        }
        
        this.offSniperModeButton.Set(丏业丟一东丂东丘丛:  (val_6.GameSecondFireButtonMode == 2) ? 1 : 0);
    }
    internal void 丄丑七丘丁且丞丙专(bool 丙业与丙丗丝不丈东)
    {
        UIToggle val_4;
        if((UnityEngine.Object.op_Implicit(exists:  this.三丅丌丘三上丟丕东)) == false)
        {
            goto label_3;
        }
        
        val_4 = this.三丅丌丘三上丟丕东;
        if(val_4 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_4 = this.GetComponent<UIToggle>();
        this.三丅丌丘三上丟丕东 = val_4;
        if(val_4 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_4.Set(丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        this.丑三丘丑丘业丘丌上();
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<丛七万丑下东业下丟> val_4;
        if(((System.Delegate.Remove(source:  SettingsTabControls.上丄丐世世丘七与丈, value:  new UnityEngine.Events.UnityAction<丛七万丑下东业下丟>(object:  this, method:  System.Void UIControlLayoutStyleSwitcher::业丄丑丞下不七丏三(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        SettingsTabControls.上丄丐世世丘七与丈 = val_4;
    }
    public UIControlLayoutStyleSwitcher()
    {
    
    }
    private void 丌丅万丆丗丅丈丛东(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 专丒丌丆下丐丞丟丞)
    {
        this.丙七丙丕丝丐一丛丆();
    }
    private void 丞丌东丌上世东丙丁(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 专丒丌丆下丐丞丟丞)
    {
        this.丙七丙丕丝丐一丛丆();
    }
    private void 下丈且三东业丕丒七(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
    {
        this.丙七丙丕丝丐一丛丆();
    }
    private void 三丏丒丂丑丒一丈丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
    {
        this.丙七丙丕丝丐一丛丆();
    }
    private void 丏专丗世丐丗丞丕丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
    {
        this.丙七丙丕丝丐一丛丆();
    }

}
