using UnityEngine;
public class ControlsSettingsBase : MonoBehaviour
{
    // Fields
    private static System.Action 丟专东专且丝丟万丅;
    public UnityEngine.GameObject settingsPanel;
    private System.Collections.Generic.Dictionary<下丂世丂不丛专一一.丟一丙丈东上万不丕, UnityEngine.GameObject> 丛不丄丁且世丁世丗;
    public UnityEngine.GameObject SettingsJoysticksPanel;
    private MainMenuControlSettings _settingsControls;
    private 下丂世丂不丛专一一.丛七万丑下东业下丟 丒丛下丞不丈三丈丝;
    private 下丂世丂不丛专一一 丑丒专丙东万丒丂丆;
    private bool 丐丈丌下与丝丐丌东;
    private ControlSizeController 丄丙丞丐丑丄丘且丙;
    private bool 一上丌丑下丈业东丌;
    private UnityEngine.Vector3[] 万丞丆丛业丐丅且与;
    private System.Collections.Generic.List<ButtonJoystickAdjust> 专业一丆丛丕丄东世;
    protected iPhoneXOrientationDetector 丄丞下下不丙三万下;
    private bool 丏下丄丞丑丂丘上与;
    private float 丝丄丞丅丆丐世七丄;
    internal UnityEngine.Coroutine 丘丒丐一业丒丂与业;
    internal UnityEngine.Coroutine 一丁丑丙丅丑丞丏下;
    internal UnityEngine.Coroutine 世丙丆不丙专丏丂丄;
    internal static string 且一不丅上三丗丒一;
    internal static string 丂丟丐专丛丌万一丝;
    private string 丒丗丞丌丞丄与丘丆;
    public bool _isCancellationRequested;
    
    // Properties
    internal bool 丏业世丐且丐东七七 { get; }
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 专万丛丘下丄丄丞丟 { get; set; }
    public bool 丂丙上专丄丑丕丙不 { get; set; }
    public UnityEngine.Vector3 丐与丟丗三一丝万丒 { get; }
    
    // Methods
    internal static void 一丆下丆丘丑丌丅丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  ControlsSettingsBase.丟专东专且丝丟万丅, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丂丑不丑丙丛丘丄下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  ControlsSettingsBase.丟专东专且丝丟万丅, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal bool 丄丅世丒一业丝专丕()
    {
        if(this._settingsControls == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = this._settingsControls.gameObject;
        if(val_2 != null)
        {
                return val_2.activeInHierarchy;
        }
        
        return val_2.activeInHierarchy;
    }
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 丐三不与丅丒丆万且()
    {
        return (丛七万丑下东业下丟)this.丒丛下丞不丈三丈丝;
    }
    internal void 东东一世专业下丒丌(下丂世丂不丛专一一.丛七万丑下东业下丟 丙业与丙丗丝不丈东)
    {
        ControlSizeController val_8;
        this.丒丛下丞不丈三丈丝 = 丙业与丙丗丝不丈东;
        this.丑丒专丙东万丒丂丆 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  丙业与丙丗丝不丈东);
        if(this.丄丙丞丐丑丄丘且丙 == 0)
        {
                val_8 = this.GetComponent<ControlSizeController>();
            this.丄丙丞丐丑丄丘且丙 = val_8;
        }
        else
        {
                val_8 = this.丄丙丞丐丑丄丘且丙;
        }
        
        if(val_8 != 0)
        {
                this.丄丙丞丐丑丄丘且丙.丏专丌万与上丆丈三 = this.丒丛下丞不丈三丈丝;
            this.丄丙丞丐丑丄丘且丙.丑丒专丙东万丒丂丆 = this.丑丒专丙东万丒丂丆;
            this.丄丙丞丐丑丄丘且丙.下丁万万丅丆东不不();
        }
        
        if(Initializer.丑七不且上丗丁一世() != 0)
        {
                if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.一丅丞业丂东且丒一();
            return;
        }
        
        }
        
        if(this.丒丛下丞不丈三丈丝 == 1)
        {
                this.上丁丄东丁丅丈丅丂();
            return;
        }
        
        this.世七丌上丅丕且丑丒();
    }
    public bool get_IsBattleRoyaleSet()
    {
        return (bool)this.丐丈丌下与丝丐丌东;
    }
    public void set_IsBattleRoyaleSet(bool 丙业与丙丗丝不丈东)
    {
        this.丐丈丌下与丝丐丌东 = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector3 get_iPhoneXDeltaCoord()
    {
        var val_7;
        var val_8;
        if((东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false) && (DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == 3))
        {
                if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                val_7 = null;
            val_7 = null;
            return new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8};
        }
        
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        val_8 = null;
        val_8 = null;
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8}, d:  -1f);
    }
    protected internal void 不丐三且上专丄丏丟()
    {
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if(((-242857988) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        this.丆丌丈丙丕万丈丞丝();
        this.丏且且东丟丛下业丝();
        bool val_2 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        if(this._settingsControls.BottomLeftControlsAnchor == null)
        {
            goto label_9;
        }
        
        if(val_2 == false)
        {
            goto label_10;
        }
        
        label_14:
        this._settingsControls.BottomLeftControlsAnchor.side = 0;
        this._settingsControls.BottomRightControlsAnchor.side = 6;
        this.丆丑丙丁一一三业丁();
        goto label_13;
        label_9:
        if(val_2 == true)
        {
            goto label_14;
        }
        
        label_10:
        this._settingsControls.BottomLeftControlsAnchor.side = 6;
        this._settingsControls.BottomRightControlsAnchor.side = 0;
        this.下业丗丛丝丄丙丒丛();
        label_13:
        this.SetControlsCoords(丄下丞七丐丟丆丈丈:  false);
        this.丏下丄丞丑丂丘上与 = this.丐丈丌下与丝丐丌东;
        if(this.丘丒丐一业丒丂与业 != null)
        {
                this.StopCoroutine(routine:  this.丘丒丐一业丒丂与业);
        }
        
        this.丘丒丐一业丒丂与业 = this.StartCoroutine(routine:  this.丄丗七丝东上丕丌与());
    }
    private System.Collections.IEnumerator 丄丗七丝东上丕丌与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ControlsSettingsBase.万东丘丗且丛且世万();
    }
    protected void 丆丑丙丁一一三业丁()
    {
        if(this.一丁丑丙丅丑丞丏下 != null)
        {
                this.StopCoroutine(routine:  this.一丁丑丙丅丑丞丏下);
        }
        
        this.一丁丑丙丅丑丞丏下 = this.StartCoroutine(routine:  this.丌且丅三世丁丄丂万());
    }
    private System.Collections.IEnumerator 丌且丅三世丁丄丂万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ControlsSettingsBase.不丈不万下丄丂丅丝();
    }
    protected void 下业丗丛丝丄丙丒丛()
    {
        if(this.世丙丆不丙专丏丂丄 != null)
        {
                this.StopCoroutine(routine:  this.世丙丆不丙专丏丂丄);
        }
        
        this.世丙丆不丙专丏丂丄 = this.StartCoroutine(routine:  this.丘丝丗丛丏丈丌丌丟());
    }
    private System.Collections.IEnumerator 丘丝丗丛丏丈丌丌丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ControlsSettingsBase.丏七丁与下世三三丅();
    }
    public void SetJoyConstraints()
    {
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                this.丆丑丙丁一一三业丁();
        }
        else
        {
                this.下业丗丛丝丄丙丒丛();
        }
        
        if(this.丘丒丐一业丒丂与业 != null)
        {
                this.StopCoroutine(routine:  this.丘丒丐一业丒丂与业);
        }
        
        this.丘丒丐一业丒丂与业 = this.StartCoroutine(routine:  this.丄丗七丝东上丕丌与());
    }
    public void SetControlsCoords(bool 丄下丞七丐丟丆丈丈 = True)
    {
        var val_21;
        bool val_22;
        iPhoneXOrientationDetector val_23;
        this._settingsControls.MapObject.SetActive(value:  this.丑丒专丙东万丒丂丆 & 1);
        if(this._settingsControls.CarControlSwapTransform != 0)
        {
                if(Initializer.丑七不且上丗丁一世() != 0)
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_18;
        }
        
        }
        
            val_21 = this._settingsControls.CarControlSwapTransform.gameObject;
            val_22 = (~GameConnect.且丞丁东丝丗上丈业()) & 1;
        }
        else
        {
                label_18:
            val_21 = this._settingsControls.CarControlSwapTransform.gameObject;
            val_22 = System.Linq.Enumerable.Contains<丟一丙丈东上万不丕>(source:  this.丑丒专丙东万丒丂丆.丆丈丆三丕不丘丄不(), value:  11);
        }
        
            val_21.SetActive(value:  val_22);
        }
        
        val_23 = this.丄丞下下不丙三万下;
        if(val_23 != 0)
        {
                val_23 = this.丄丞下下不丙三万下;
            bool val_14 = (this.一上丌丑下丈业东丌 == true) ? 1 : 0;
            val_14 = val_14 ^ 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
            val_23.SetButtonsForSwapHands(七丆丟丗世丟且丒丆:  val_14);
        }
        
        this.一上丌丑下丈业东丌 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        this.丆专丌丒且丂万丆丅(丄下丞七丐丟丆丈丈:  丄下丞七丐丟丆丈丈);
    }
    private void 丆专丌丒且丂万丆丅(bool 丄下丞七丐丟丆丈丈 = True)
    {
        float val_3;
        float val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丛不丄丁且世丁世丗.GetEnumerator();
        label_15:
        if(((-241605776) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        int val_6 = val_5._value._obj.丙东专丂世丈丏丁丂();
        val_5._value._obj.transform.localPosition = new UnityEngine.Vector3() {x = val_3, y = val_4, z = V2.16B};
        if(val_4 >= 0)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5._value._obj, 丏业丟一东丂东丘丛:  true);
        if(丄下丞七丐丟丆丈丈 == false)
        {
            goto label_15;
        }
        
        val_5._value._obj.GetComponent<ButtonJoystickAdjust>().Touch();
        goto label_15;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5._value._obj, 丏业丟一东丂东丘丛:  false);
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 且丄七丅丝一丁丘丅()
    {
        if(this.丛不丄丁且世丁世丗 != null)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<丟一丙丈东上万不丕, UnityEngine.GameObject> val_1 = new System.Collections.Generic.Dictionary<丟一丙丈东上万不丕, UnityEngine.GameObject>();
        val_1.Add(key:  0, value:  this._settingsControls.zoomButton);
        val_1.Add(key:  1, value:  this._settingsControls.reloadButton);
        val_1.Add(key:  2, value:  this._settingsControls.jumpButton);
        val_1.Add(key:  3, value:  this._settingsControls.fireButton);
        val_1.Add(key:  4, value:  this._settingsControls.joystick);
        val_1.Add(key:  5, value:  this._settingsControls.grenadeButton);
        val_1.Add(key:  6, value:  this._settingsControls.fireButtonInJoystick);
        val_1.Add(key:  9, value:  this._settingsControls.gadget2Button);
        val_1.Add(key:  10, value:  this._settingsControls.gadget3Button);
        val_1.Add(key:  11, value:  this._settingsControls.carButton);
        val_1.Add(key:  12, value:  this._settingsControls.vehicleSpawnButton);
        val_1.Add(key:  13, value:  this._settingsControls.crouchButton);
        val_1.Add(key:  14, value:  this._settingsControls.autorunButton);
        val_1.Add(key:  15, value:  this._settingsControls.lootButton);
        val_1.Add(key:  16, value:  this._settingsControls.weaponsList);
        this.丛不丄丁且世丁世丗 = val_1;
    }
    protected void OnEnable()
    {
        var val_9;
        var val_10;
        if(this._settingsControls.HandSwapTransform != 0)
        {
                UnityEngine.Vector3 val_2 = this._settingsControls.HandSwapTransform.localPosition;
            this.丝丄丞丅丆丐世七丄 = val_2.x;
        }
        
        val_9 = null;
        val_9 = null;
        if(ExperienceController.sharedController != 0)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                val_10 = null;
            val_10 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        }
        
        this.且丄七丅丝一丁丘丅();
        if(this.丑丒专丙东万丒丂丆 == null)
        {
                this.丑丒专丙东万丒丂丆 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  0);
        }
        
        this.SetControlsCoords(丄下丞七丐丟丆丈丈:  true);
        this.丆丌丈丙丕万丈丞丝();
        this.丏且且东丟丛下业丝();
    }
    private void 世七丌上丅丕且丑丒()
    {
        if(this._settingsControls != null)
        {
            goto label_0;
        }
        
        this._settingsControls = this._settingsControls;
        if(this._settingsControls == null)
        {
            goto label_1;
        }
        
        label_0:
        this._settingsControls.Gadget0ButtonImageContainer.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        return;
        label_1:
    }
    private void 上丁丄东丁丅丈丅丂()
    {
        if(this._settingsControls != null)
        {
            goto label_0;
        }
        
        this._settingsControls = this._settingsControls;
        if(this._settingsControls == null)
        {
            goto label_1;
        }
        
        label_0:
        this._settingsControls.Gadget0ButtonImageContainer.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        return;
        label_1:
    }
    private void 一丅丞业丂东且丒一()
    {
        if(this._settingsControls != null)
        {
            goto label_0;
        }
        
        this._settingsControls = this._settingsControls;
        if(this._settingsControls == null)
        {
            goto label_1;
        }
        
        label_0:
        this._settingsControls.Gadget0ButtonImageContainer.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        return;
        label_1:
    }
    private void 丆丌丈丙丕万丈丞丝()
    {
        UnityEngine.Transform val_18;
        UnityEngine.Transform val_19;
        var val_20;
        float val_21;
        MainMenuControlSettings val_22;
        UnityEngine.Transform val_23;
        var val_24;
        MainMenuControlSettings val_28;
        var val_29;
        val_18 = this;
        val_19 = 1152921504848912384;
        if(this._settingsControls.HandSwapAnchor == 0)
        {
                return;
        }
        
        if(this._settingsControls.HandSwapTransform == 0)
        {
                return;
        }
        
        丛七万丑下东业下丟 val_17 = this.丒丛下丞不丈三丈丝;
        val_17 = val_17 - 1;
        if(val_17 > 1)
        {
            goto label_9;
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
            goto label_12;
        }
        
        val_20 = null;
        val_20 = null;
        float val_18 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
        val_18 = 768f / val_18;
        val_21 = (float)UnityEngine.Screen.height / val_18;
        goto label_15;
        label_9:
        bool val_5 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        if(this._settingsControls.HandSwapAnchor == null)
        {
            goto label_19;
        }
        
        if(val_5 == false)
        {
            goto label_20;
        }
        
        label_35:
        this._settingsControls.HandSwapAnchor.side = 1;
        goto label_21;
        label_12:
        val_21 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        label_15:
        bool val_7 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        if(this._settingsControls.HandSwapAnchor == null)
        {
            goto label_27;
        }
        
        if(val_7 == false)
        {
            goto label_28;
        }
        
        label_42:
        this._settingsControls.HandSwapAnchor.side = 1;
        label_21:
        val_22 = this._settingsControls;
        if(this._settingsControls != null)
        {
            goto label_29;
        }
        
        val_22 = this._settingsControls;
        if(val_22 == null)
        {
            goto label_37;
        }
        
        label_29:
        val_23 = this._settingsControls.HandSwapTransform;
        val_19 = this._settingsControls.HandSwapTransform;
        val_21 = this.丝丄丞丅丆丐世七丄;
        UnityEngine.Vector3 val_8 = val_19.localPosition;
        val_24 = val_8.y;
        val_18 = this._settingsControls.HandSwapTransform;
        UnityEngine.Vector3 val_9 = val_18.localPosition;
        goto label_34;
        label_19:
        if(val_5 == true)
        {
            goto label_35;
        }
        
        label_20:
        this._settingsControls.HandSwapAnchor.side = 5;
        val_28 = this._settingsControls;
        if(this._settingsControls != null)
        {
            goto label_36;
        }
        
        val_28 = this._settingsControls;
        if(val_28 == null)
        {
            goto label_37;
        }
        
        label_36:
        val_23 = this._settingsControls.HandSwapTransform;
        val_19 = this._settingsControls.HandSwapTransform;
        UnityEngine.Vector3 val_10 = val_19.localPosition;
        val_21 = val_10.y;
        val_18 = this._settingsControls.HandSwapTransform;
        UnityEngine.Vector3 val_11 = val_18.localPosition;
        val_29 = val_21;
        goto label_41;
        label_27:
        if(val_7 == true)
        {
            goto label_42;
        }
        
        label_28:
        this._settingsControls.HandSwapAnchor.side = 5;
        float val_19 = 99.627f;
        val_19 = this.丝丄丞丅丆丐世七丄 + val_19;
        val_23 = this._settingsControls.HandSwapTransform;
        val_19 = UnityEngine.Screen.width;
        UnityEngine.Vector3 val_15 = this._settingsControls.HandSwapTransform.localPosition;
        val_24 = val_15.y;
        val_18 = this._settingsControls.HandSwapTransform;
        UnityEngine.Vector3 val_16 = val_18.localPosition;
        float val_20 = (float)val_19;
        val_20 = val_20 / val_21;
        val_20 = val_20 - ((东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true) ? (val_19) : this.丝丄丞丅丆丐世七丄);
        label_34:
        val_29 = val_24;
        label_41:
        val_23.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_37:
    }
    private void 丏且且东丟丛下业丝()
    {
        UnityEngine.Transform val_15;
        UnityEngine.Transform val_16;
        var val_17;
        float val_18;
        MainMenuControlSettings val_19;
        UnityEngine.Transform val_20;
        var val_21;
        val_15 = this;
        丛七万丑下东业下丟 val_14 = this.丒丛下丞不丈三丈丝;
        val_14 = val_14 - 1;
        if(val_14 > 1)
        {
                return;
        }
        
        val_16 = 1152921505171808256;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_17 = null;
            val_17 = null;
            float val_15 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_15 = 768f / val_15;
            val_18 = (float)UnityEngine.Screen.height / val_15;
        }
        else
        {
                val_18 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        }
        
        if(this._settingsControls.HandSwapAnchor == 0)
        {
                return;
        }
        
        if(this._settingsControls.CarControlSwapTransform == 0)
        {
                return;
        }
        
        bool val_6 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        if(this._settingsControls.HandSwapAnchor == null)
        {
            goto label_21;
        }
        
        if(val_6 == false)
        {
            goto label_22;
        }
        
        label_29:
        this._settingsControls.HandSwapAnchor.side = 1;
        val_19 = this._settingsControls;
        if(this._settingsControls != null)
        {
            goto label_23;
        }
        
        val_19 = this._settingsControls;
        if(val_19 == null)
        {
            goto label_24;
        }
        
        label_23:
        val_20 = this._settingsControls.CarControlSwapTransform;
        val_16 = this._settingsControls.CarControlSwapTransform;
        val_18 = this.丝丄丞丅丆丐世七丄;
        UnityEngine.Vector3 val_7 = val_16.localPosition;
        val_21 = val_7.y;
        val_15 = this._settingsControls.CarControlSwapTransform;
        UnityEngine.Vector3 val_8 = val_15.localPosition;
        goto label_28;
        label_21:
        if(val_6 == true)
        {
            goto label_29;
        }
        
        label_22:
        this._settingsControls.HandSwapAnchor.side = 5;
        float val_16 = 99.627f;
        val_16 = this.丝丄丞丅丆丐世七丄 + val_16;
        val_20 = this._settingsControls.CarControlSwapTransform;
        val_16 = UnityEngine.Screen.width;
        UnityEngine.Vector3 val_12 = this._settingsControls.CarControlSwapTransform.localPosition;
        val_21 = val_12.y;
        val_15 = this._settingsControls.CarControlSwapTransform;
        UnityEngine.Vector3 val_13 = val_15.localPosition;
        float val_17 = (float)val_16;
        val_17 = val_17 / val_18;
        val_17 = val_17 - ((东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true) ? (val_16) : this.丝丄丞丅丆丐世七丄);
        label_28:
        val_20.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_24:
    }
    protected virtual void 与业丞丗丂业丙丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        if(this.丄丞下下不丙三万下 != 0)
        {
                this.丄丞下下不丙三万下.SetCoordForSave();
        }
        
        this.东丘下丁丟丁下丗丐();
        this.SettingsJoysticksPanel.SetActive(value:  false);
        this.settingsPanel.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        val_3 = null;
        val_3 = null;
        if(ControlsSettingsBase.丟专东专且丝丟万丅 == null)
        {
                return;
        }
        
        ControlsSettingsBase.丟专东专且丝丟万丅.Invoke();
    }
    protected void 且丐丌丞一丞一丕丝()
    {
        null = null;
        if(ControlsSettingsBase.丟专东专且丝丟万丅 == null)
        {
                return;
        }
        
        ControlsSettingsBase.丟专东专且丝丟万丅.Invoke();
    }
    private void 东丘下丁丟丁下丗丐()
    {
        float val_3;
        float val_4;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        var val_31;
        UIJoystick val_32;
        var val_33;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丛不丄丁且世丁世丗.GetEnumerator();
        val_20 = 0;
        val_21 = 0;
        var val_21 = 0;
        label_31:
        if(((-239533488) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        if(val_5._value._obj.丙东专丂世丈丏丁丂() == 14)
        {
            goto label_3;
        }
        
        int val_7 = val_5._value._obj.丙东专丂世丈丏丁丂();
        UnityEngine.Vector3 val_9 = val_5._value._obj.transform.localPosition;
        if(this.丑丒专丙东万丒丂丆 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_3:
        val_22 = val_3;
        val_23 = val_4;
        val_24 = V2.16B;
        Dictionary.Enumerator<TKey, TValue> val_10 = this.丛不丄丁且世丁世丗.GetEnumerator();
        label_11:
        if(((-239533568) & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_4.GetAwaiter();
        if(val_11._value._obj.丙东专丂世丈丏丁丂() != 4)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_14 = val_11._value._obj.transform.localPosition;
        val_25 = val_21 + 1;
        val_22 = val_14.x;
        mem2[0] = 131;
        val_23 = val_14.y;
        val_24 = val_14.z;
        goto label_15;
        label_10:
        val_25 = val_21 + 1;
        mem2[0] = 131;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((val_25 != 1) && ((-239533648 + ((0 + 1)) << 2) == 131))
        {
                var val_20 = 0;
            val_20 = val_20 ^ (val_25 >> 31);
            val_25 = val_25 + val_20;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        UnityEngine.Vector3 val_16 = val_5._value._obj.transform.localPosition;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24});
        int val_18 = val_5._value._obj.丙东专丂世丈丏丁丂();
        if(this.丑丒专丙东万丒丂丆 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_2:
        val_21 = val_21 + 1;
        mem2[0] = 263;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_21 == 1)
        {
            goto label_50;
        }
        
        if(( == 0) || ((-239533648 + ((0 + 1)) << 2) == 263))
        {
            goto label_63;
        }
        
        label_62:
        label_63:
        val_31 = null;
        val_31 = null;
        val_32 = JoystickController.丗三丄与丂丟丌专东;
        if(val_32 == 0)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        val_32 = JoystickController.丗三丄与丂丟丌专东;
        JoystickController.丗三丄与丂丟丌专东.IsInitPos = false;
        return;
        label_50:
        if( != 0)
        {
            goto label_62;
        }
        
        goto label_63;
    }
    private void 丏一丕丌专丐万且丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丆专丌丒且丂万丆丅(丄下丞七丐丟丆丈丈:  true);
        if(this.丄丞下下不丙三万下 == 0)
        {
                return;
        }
        
        this.丄丞下下不丙三万下.Init();
    }
    protected virtual void 丟丒丙丝三与丁丟丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this._isCancellationRequested = true;
        this.CancelPositionChanges();
    }
    public void CancelPositionChanges()
    {
        if(this.丄丞下下不丙三万下 != 0)
        {
                this.丄丞下下不丙三万下.SetCoordForSave();
        }
        
        this.SetControlsCoords(丄下丞七丐丟丆丈丈:  true);
    }
    protected void Start()
    {
        System.EventHandler val_13;
        if(this._settingsControls.savePosJoystikButton != 0)
        {
                Rilisoft.ButtonHandler val_2 = this._settingsControls.savePosJoystikButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                System.EventHandler val_4 = null;
            val_13 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  typeof(ControlsSettingsBase).__il2cppRuntimeField_170);
            val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        }
        
        if(this._settingsControls.defaultPosJoystikButton != 0)
        {
                Rilisoft.ButtonHandler val_6 = this._settingsControls.defaultPosJoystikButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_6 != 0)
        {
                System.EventHandler val_8 = null;
            val_13 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void ControlsSettingsBase::丏一丕丌专丐万且丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_6.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        }
        
        if(this._settingsControls.cancelPosJoystikButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_10 = this._settingsControls.cancelPosJoystikButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(ControlsSettingsBase).__il2cppRuntimeField_180));
    }
    public ControlsSettingsBase()
    {
        this.万丞丆丛业丐丅且与 = new UnityEngine.Vector3[0];
        this.专业一丆丛丕丄东世 = new System.Collections.Generic.List<ButtonJoystickAdjust>();
        this.丒丗丞丌丞丄与丘丆 = System.String.alignConst;
    }
    private static ControlsSettingsBase()
    {
        ControlsSettingsBase.且一不丅上三丗丒一 = "JoystickSettSettSett";
        ControlsSettingsBase.丂丟丐专丛丌万一丝 = "JoystickSettSettSettBR";
    }

}
