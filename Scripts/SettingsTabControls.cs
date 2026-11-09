using UnityEngine;
internal sealed class SettingsTabControls : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject trainingButton;
    public UIControlLayoutStyleSwitcher simpleSwitcher;
    public UIControlLayoutStyleSwitcher advancedSwitcher;
    public UIControlLayoutStyleSwitcher imposterSwitcher;
    private UIButton defSettingsBtn;
    private 下丂世丂不丛专一一.丛七万丑下东业下丟 丒业丌万丟丑丛丒丏;
    private 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丄丅三不不丘丑丞世;
    private UITypeControlLayoutSwitcher[] 丈丕丘专专业与世与;
    internal static UnityEngine.Events.UnityAction<下丂世丂不丛专一一.丛七万丑下东业下丟> 上丄丐世世丘七与丈;
    internal static SettingsTabControls 丆丕丝丒不丙且丐丗;
    
    // Properties
    public 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 东丂丆专世丌万丅专 { get; }
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 丕东丒与丑东上不丛 { get; }
    private System.Collections.Generic.List<ControlFireSettings> 丈丘丛七丘世丆丟丒 { get; set; }
    
    // Methods
    public 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 get_selectedControlStyle()
    {
        return (丁三丆丒丝与丏丕一)this.丄丅三不不丘丑丞世;
    }
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 七丐丈丁丐下七业世()
    {
        return (丛七万丑下东业下丟)this.丒业丌万丟丑丛丒丏;
    }
    private System.Collections.Generic.List<ControlFireSettings> 丒丌丌三上上一丈下()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        if(丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 == null)
        {
                val_4 = null;
            val_4 = null;
            val_3 = new System.Collections.Generic.List<ControlFireSettings>();
        }
        
        val_5 = null;
        val_5 = null;
        if(丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 == null)
        {
            
        }
    
    }
    private void 丞丘世丄专丈上丐世(System.Collections.Generic.List<ControlFireSettings> 丙业与丙丗丝不丈东)
    {
        null = null;
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.丂且不业丂专丛丆东();
    }
    private void Awake()
    {
        System.Delegate val_9;
        var val_10;
        UnityEngine.Events.UnityAction val_11;
        val_9 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  SettingsTabControls.丆丕丝丒不丙且丐丗)) != true)
        {
                SettingsTabControls.丆丕丝丒不丙且丐丗 = this;
        }
        
        this.丈丕丘专专业与世与 = this.GetComponentsInChildren<UITypeControlLayoutSwitcher>();
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_4 = null;
        val_9 = val_4;
        val_4 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SettingsTabControls::丅丈与三丁丈且且丝());
        val_11 = System.Delegate.Combine(a:  SettingsWindowManager.丆丕丝丒不丙且丐丗.与七且下三丒丘丐七, b:  val_4);
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_8;
        }
        
        if(val_11 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        val_10 = 0;
        if(val_11 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_12:
        SettingsWindowManager.丆丕丝丒不丙且丐丗.与七且下三丒丘丐七 = val_11;
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_10 = 0;
        }
        
        if(val_10.丏丐丑专丘丂世丁一() == true)
        {
                return;
        }
        
        ControlsSettingsBase.一丆下丆丘丑丌丅丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SettingsTabControls::丕一丙东丑一业丟丏()));
    }
    private void Start()
    {
        this.东一三一万且丕世不();
        this.且丘丂丞世丞东业丗();
    }
    private void 且丘丂丞世丞东业丗()
    {
        UnityEngine.GameObject val_8;
        UnityEngine.Object val_9;
        var val_10;
        var val_11;
        val_8 = 1152921505258975232;
        val_9 = SettingsWindowManager.丆丕丝丒不丙且丐丗;
        if(val_9 == 0)
        {
                return;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_9 = 0;
        }
        
        if(val_9.丏丐丑专丘丂世丁一() == false)
        {
                return;
        }
        
        val_10 = 0;
        goto label_6;
        label_19:
        val_11 = null;
        UITypeControlLayoutSwitcher val_8 = this.丈丕丘专专业与世与[0];
        val_11 = null;
        丛七万丑下东业下丟 val_3 = PauseNGUIController.丄丞丁丈与业上丞丟.丐三不与丅丒丆万且();
        if(val_8 != null)
        {
                val_8.一丅丈丝且丈丆丑世(丁丅丈丌丟世丗丗丟:  val_3);
            val_8.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  false);
        }
        else
        {
                0.一丅丈丝且丈丆丑世(丁丅丈丌丟世丗丗丟:  val_3);
            0.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  false);
        }
        
        val_8 = val_8.gameObject;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  (PauseNGUIController.丄丞丁丈与业上丞丟.丐三不与丅丒丆万且() == val_8.丌丈七丄世丟丛一丛()) ? 1 : 0);
        val_10 = 1;
        label_6:
        if(val_10 < this.丈丕丘专专业与世与.Length)
        {
            goto label_19;
        }
    
    }
    private void 东一三一万且丕世不()
    {
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.trainingButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabControls.{0} is null", arg0:  "trainingButton"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.simpleSwitcher, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabControls.{0} is null", arg0:  "simpleSwitcher"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.advancedSwitcher, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabControls.{0} is null", arg0:  "advancedSwitcher"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.imposterSwitcher, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabControls.{0} is null", arg0:  "imposterSwitcher"));
    }
    internal void 与丗万三丁专三上丘(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)
    {
        UIControlLayoutStyleSwitcher val_10;
        UIControlLayoutStyleSwitcher val_11;
        val_10 = this;
        UnityEngine.Debug.Log(message:  "TypeControlLayout change - "("TypeControlLayout change - ") + 丁丅丈丌丟世丗丗丟);
        this.丒业丌万丟丑丛丒丏 = 丁丅丈丌丟世丗丗丟;
        bool val_3 = (丁丅丈丌丟世丗丗丟 != 3) ? 1 : 0;
        this.simpleSwitcher.gameObject.SetActive(value:  val_3);
        this.advancedSwitcher.gameObject.SetActive(value:  val_3);
        val_11 = this.imposterSwitcher.gameObject;
        val_11.SetActive(value:  (丁丅丈丌丟世丗丗丟 == 3) ? 1 : 0);
        this.丅丈与三丁丈且且丝();
        if(丁丅丈丌丟世丗丗丟 == 3)
        {
                this.丝丛一丁专丗专丅东(丏东丆丆丛丄丕丈丞:  1);
            if(SettingsTabControls.上丄丐世世丘七与丈 == null)
        {
                return;
        }
        
            SettingsTabControls.上丄丐世世丘七与丈.Invoke(arg0:  3);
            return;
        }
        
        if(SettingsTabControls.上丄丐世世丘七与丈 != null)
        {
                SettingsTabControls.上丄丐世世丘七与丈.Invoke(arg0:  丁丅丈丌丟世丗丗丟);
        }
        
        丁三丆丒丝与丏丕一 val_7 = SettingsTabControls.上丄丐世世丘七与丈.丑丞下丘丂丅与丟东(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
        val_11 = this.simpleSwitcher;
        val_11.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  (val_7 == 1) ? 1 : 0);
        val_10 = this.advancedSwitcher;
        val_10.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  (val_7 == 2) ? 1 : 0);
    }
    private void 丅丈与三丁丈且且丝()
    {
        var val_4;
        if((UnityEngine.Object.op_Implicit(exists:  this.trainingButton)) == false)
        {
                return;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗.下与专不七世丐丏七() != false)
        {
                var val_3 = (this.丒业丌万丟丑丛丒丏 == 0) ? 1 : 0;
        }
        else
        {
                val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.trainingButton, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        if(this.defSettingsBtn == 0)
        {
                return;
        }
        
        this.defSettingsBtn.onClick.Clear();
        this.defSettingsBtn.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void SettingsTabControls::SetDefaultSettings())));
    }
    public void SetDefaultSettings()
    {
        int val_11;
        丛七万丑下东业下丟[] val_1 = new 丛七万丑下东业下丟[3];
        val_11 = val_1.Length;
        if(val_11 <= 1)
        {
                val_11 = val_1.Length;
        }
        
        val_1[0] = 1;
        if(val_11 <= 2)
        {
                val_11 = val_1.Length;
        }
        
        val_1[1] = 2;
        if(val_11 >= 1)
        {
                do
        {
            if((val_1.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  val_1[0], 与丄丁丏丙与业丗丑:  1)) != null)
        {
                val_2.IsAiming = true;
            val_2.IsAutoShooting = true;
        }
        else
        {
                mem[25] = true;
            mem[26] = true;
        }
        
            val_2.GameSecondFireButtonMode = 2;
            val_3.IsAiming = true;
            val_3.IsAutoShooting = ((val_1[0x0] + 32) != 0) ? 1 : 0;
            val_3.GameSecondFireButtonMode = ((val_1[0x0] + 32) == 0) ? 0 : 2;
        }
        while((0 + 1) < val_1.Length);
        
        }
        
        ControlFireSettings val_7 = this.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  val_1[0x0] + 32, 与丄丁丏丙与业丗丑:  2).丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  this.丒业丌万丟丑丛丒丏, 与丄丁丏丙与业丗丑:  2);
        this.simpleSwitcher.aimingCheckbox.IsChecked = true;
        this.advancedSwitcher.aimingCheckbox.IsChecked = true;
        this.advancedSwitcher.autoShootingCheckbox.IsChecked = (val_7.Type != 0) ? 1 : 0;
        if(this.advancedSwitcher == null)
        {
            goto label_20;
        }
        
        if(val_7.Type == 0)
        {
            goto label_21;
        }
        
        label_30:
        this.advancedSwitcher.offSniperModeButton.enabled = true;
        this.advancedSwitcher.offSniperModeButton.Set(丏业丟一东丂东丘丛:  true);
        if(this.advancedSwitcher.offSniperModeButton != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        this.advancedSwitcher.offSniperModeButton.enabled = this.advancedSwitcher.offSniperModeButton.enabled;
        this.丌丝七丑一三东且丂();
        SettingsWindowManager.丆丕丝丒不丙且丐丗.CloseDefConfirmWindow();
        return;
        label_20:
        if(val_7.Type != 0)
        {
            goto label_30;
        }
        
        label_21:
        bool val_11 = this.advancedSwitcher.sniperModeButton.enabled;
        this.advancedSwitcher.sniperModeButton.enabled = true;
        this.advancedSwitcher.sniperModeButton.Set(丏业丟一东丂东丘丛:  true);
        if(this.advancedSwitcher.sniperModeButton != null)
        {
            goto label_37;
        }
        
        goto label_38;
    }
    private 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丑丞下丘丂丅与丟东(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)
    {
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_5;
        .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        if((System.Linq.Enumerable.FirstOrDefault<ControlFireSettings>(source:  this.丒丌丌三上上一丈下(), predicate:  new System.Func<ControlFireSettings, System.Boolean>(object:  new SettingsTabControls.丄丆丌丌丕丈丆丆业(), method:  System.Boolean SettingsTabControls.丄丆丌丌丕丈丆丆业::丂下丟丁与万专丈丄(ControlFireSettings 三丟东丕丄丄下下丑)))) != null)
        {
                val_5 = val_4.Style;
            return (丁三丆丒丝与丏丕一)val_5;
        }
        
        val_5 = 2;
        return (丁三丆丒丝与丏丕一)val_5;
    }
    internal ControlFireSettings 丐丏丈丂丈丙丑丅丄(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 与丄丁丏丙与业丗丑)
    {
        object val_7;
        丛七万丑下东业下丟 val_8;
        ControlFireSettings val_9;
        SettingsTabControls.丒丂万丒丂一上丞一 val_1 = null;
        val_7 = val_1;
        val_1 = new SettingsTabControls.丒丂万丒丂一上丞一();
        if(val_7 != null)
        {
                val_8 = val_7;
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        }
        else
        {
                val_8 = 16;
            mem[16] = 丁丅丈丌丟世丗丗丟;
        }
        
        .与丄丁丏丙与业丗丑 = 与丄丁丏丙与业丗丑;
        val_9 = System.Linq.Enumerable.FirstOrDefault<ControlFireSettings>(source:  this.丒丌丌三上上一丈下(), predicate:  new System.Func<ControlFireSettings, System.Boolean>(object:  val_1, method:  System.Boolean SettingsTabControls.丒丂万丒丂一上丞一::丒专丂丙丕丈丛三丂(ControlFireSettings 三丟东丕丄丄下下丑)));
        if(val_9 != null)
        {
                return val_9;
        }
        
        ControlFireSettings val_5 = ControlFireSettings.不丁丑丁丈上丅丌丐(丁丅丈丌丟世丗丗丟:  val_8, 丏东丆丆丛丄丕丈丞:  (SettingsTabControls.丒丂万丒丂一上丞一)[1152921538968291824].与丄丁丏丙与业丗丑);
        val_9 = val_5;
        val_7 = val_5.丒丌丌三上上一丈下();
        val_7.Add(item:  val_9);
        return val_9;
    }
    internal void 丒丒丌丙丒丏不丏世()
    {
        int val_6;
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_7;
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_8;
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_9;
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_10;
        var val_11;
        丛七万丑下东业下丟[] val_1 = new 丛七万丑下东业下丟[2];
        val_6 = val_1.Length;
        if(val_6 == 0)
        {
                val_6 = val_1.Length;
        }
        
        val_1[0] = 2;
        if(val_6 <= 1)
        {
                val_6 = val_1.Length;
        }
        
        val_1[0] = 1;
        if(val_6 >= 1)
        {
                do
        {
            丛七万丑下东业下丟 val_7 = val_1[0];
            if((val_1.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  val_7, 与丄丁丏丙与业丗丑:  1)) != null)
        {
                val_7 = val_2.Style;
            val_8 = this.丄丅三不不丘丑丞世;
        }
        else
        {
                val_7 = 1;
            val_8 = this.丄丅三不不丘丑丞世;
        }
        
            val_2.IsSelected = (val_7 == val_8) ? 1 : 0;
            if((this.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  val_7, 与丄丁丏丙与业丗丑:  2)) != null)
        {
                val_9 = val_4.Style;
            val_10 = this.丄丅三不不丘丑丞世;
        }
        else
        {
                val_9 = 1;
            val_10 = this.丄丅三不不丘丑丞世;
        }
        
            val_4.IsSelected = (val_9 == val_10) ? 1 : 0;
        }
        while((0 + 1) < val_1.Length);
        
        }
        
        val_11 = null;
        val_11 = null;
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.丂且不业丂专丛丆东();
    }
    internal void 丝丛一丁专丗专丅东(下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丏东丆丆丛丄丕丈丞)
    {
        UnityEngine.Debug.Log(message:  "LayoutStyle change - "("LayoutStyle change - ") + 丏东丆丆丛丄丕丈丞);
        this.丄丅三不不丘丑丞世 = 丏东丆丆丛丄丕丈丞;
        this.丌丝七丑一三东且丂();
    }
    internal void 丙七丙丕丝丐一丛丆()
    {
        this.丌丝七丑一三东且丂();
    }
    private void 丌丝七丑一三东且丂()
    {
        System.Func<TSource, System.Boolean> val_19;
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_20;
        var val_21;
        if(this.丒业丌万丟丑丛丒丏 != 3)
        {
            goto label_1;
        }
        
        System.Func<ControlFireSettings, System.Boolean> val_2 = null;
        val_19 = val_2;
        val_2 = new System.Func<ControlFireSettings, System.Boolean>(object:  this, method:  System.Boolean SettingsTabControls::丐丌丒丝业不一丅不(ControlFireSettings 三丟东丕丄丄下下丑));
        if((System.Linq.Enumerable.FirstOrDefault<ControlFireSettings>(source:  this.丒丌丌三上上一丈下(), predicate:  val_2)) != null)
        {
            goto label_15;
        }
        
        ControlFireSettings val_4 = new ControlFireSettings();
        val_19 = this.丒业丌万丟丑丛丒丏;
        if(val_4 == null)
        {
            goto label_3;
        }
        
        .Type = val_19;
        val_20 = this.丄丅三不不丘丑丞世;
        goto label_4;
        label_1:
        bool val_6 = this.simpleSwitcher.aimingCheckbox.IsChecked;
        if((this.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  this.丒业丌万丟丑丛丒丏, 与丄丁丏丙与业丗丑:  1)) != null)
        {
                val_5.IsAiming = val_6;
            val_5.IsAutoShooting = true;
            val_5.IsSelected = (val_5.Style == this.丄丅三不不丘丑丞世) ? 1 : 0;
        }
        else
        {
                mem[25] = val_6;
            mem[26] = 1;
            mem[24] = (1 == this.丄丅三不不丘丑丞世) ? 1 : 0;
        }
        
        val_5.GameSecondFireButtonMode = 2;
        ControlFireSettings val_11 = this.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  this.丒业丌万丟丑丛丒丏, 与丄丁丏丙与业丗丑:  2);
        val_11.IsAiming = this.advancedSwitcher.aimingCheckbox.IsChecked;
        val_19 = this.advancedSwitcher.autoShootingCheckbox;
        val_11.IsAutoShooting = val_19.IsChecked;
        val_11.IsSelected = (val_11.Style == this.丄丅三不不丘丑丞世) ? 1 : 0;
        val_11.GameSecondFireButtonMode = this.advancedSwitcher.SelectedSecondFireMode;
        goto label_15;
        label_3:
        mem[16] = val_19;
        val_20 = this.丄丅三不不丘丑丞世;
        label_4:
        .Style = val_20;
        this.丒丌丌三上上一丈下().Add(item:  val_4);
        label_15:
        val_21 = null;
        val_21 = null;
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.丂且不业丂专丛丆东();
    }
    internal void 丝且业且丆且丗七丏()
    {
        var val_6;
        PauseNGUIController val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        val_7 = PauseNGUIController.丄丞丁丈与业上丞丟;
        if(val_7 == null)
        {
                val_8 = null;
            val_8 = null;
            val_7 = MainMenuController.丄丞丁丈与业上丞丟;
        }
        
        bool val_1 = UnityEngine.Object.op_Implicit(exists:  val_7);
        if(val_1 != false)
        {
                if((val_1.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  this.丒业丌万丟丑丛丒丏, 与丄丁丏丙与业丗丑:  this.丄丅三不不丘丑丞世)) != null)
        {
                丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (val_2.IsLeftHanded == false) ? 1 : 0);
        }
        
            if(val_7 != null)
        {
                val_7.东东一世专业下丒丌(丙业与丙丗丝不丈东:  this.丒业丌万丟丑丛丒丏);
            val_7.不丐三且上专丄丏丟();
        }
        else
        {
                val_7.东东一世专业下丒丌(丙业与丙丗丝不丈东:  this.丒业丌万丟丑丛丒丏);
            val_7.不丐三且上专丄丏丟();
        }
        
            MainMenuController.丄丞丁丈与业上丞丟 + 40.SetActive(value:  true);
            if(null == null)
        {
                gameObject.SetActive(value:  false);
        }
        
        }
        
        val_9 = null;
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_9 = null;
        }
        
        SettingsWindowManager.丆丕丝丒不丙且丐丗.<丗一丝专上业丗丒丈>k__BackingField = true;
        SettingsWindowManager.丆丕丝丒不丙且丐丗.gameObject.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        var val_7;
        UnityEngine.Events.UnityAction val_8;
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_8 = System.Delegate.Remove(source:  SettingsWindowManager.丆丕丝丒不丙且丐丗.与七且下三丒丘丐七, value:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SettingsTabControls::丅丈与三丁丈且且丝()));
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_5;
        }
        
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        val_7 = 0;
        if(val_8 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_9:
        SettingsWindowManager.丆丕丝丒不丙且丐丗.与七且下三丒丘丐七 = val_8;
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_7 = 0;
        }
        
        if(val_7.丏丐丑专丘丂世丁一() == true)
        {
                return;
        }
        
        ControlsSettingsBase.丂丑不丑丙丛丘丄下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SettingsTabControls::丕一丙东丑一业丟丏()));
    }
    private void 丕一丙东丑一业丟丏()
    {
        if((this.丐丏丈丂丈丙丑丅丄(丁丅丈丌丟世丗丗丟:  this.丒业丌万丟丑丛丒丏, 与丄丁丏丙与业丗丑:  this.丄丅三不不丘丑丞世)) == null)
        {
                return;
        }
        
        bool val_3 = ~丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        val_3 = val_3 & 1;
        val_1.IsLeftHanded = val_3;
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.丂且不业丂专丛丆东();
    }
    public SettingsTabControls()
    {
    
    }
    private bool 丐丌丒丝业不一丅不(ControlFireSettings 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.Type == this.丒业丌万丟丑丛丒丏) ? 1 : 0;
    }

}
