using UnityEngine;
public class iPhoneXOrientationDetector : MonoBehaviour
{
    // Fields
    private UIAnchor anchor;
    private UnityEngine.Transform[] buttons;
    private UnityEngine.DeviceOrientation 业七丞丟丁丅丝专不;
    private bool 丝三丄专丗丞丄丄丌;
    public bool isSettings;
    private ControlsSettingsBase settings;
    private bool 丗丛七丈丆丘丗丘丕;
    
    // Methods
    private void OnEnable()
    {
        System.Func<ButtonJoystickAdjust, UnityEngine.Transform> val_12;
        var val_13;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        val_12 = 1152921504848912384;
        if(this.anchor == 0)
        {
                this.anchor = this.GetComponent<UIAnchor>();
        }
        
        if(this.settings == 0)
        {
                this.settings = this.GetComponentInParent<ControlsSettingsBase>();
        }
        
        if(this.buttons != null)
        {
                if(this.buttons.Length != 0)
        {
            goto label_11;
        }
        
        }
        
        val_13 = null;
        val_13 = null;
        val_12 = iPhoneXOrientationDetector.<>c.<>9__7_0;
        if(val_12 == null)
        {
                System.Func<ButtonJoystickAdjust, UnityEngine.Transform> val_7 = null;
            val_12 = val_7;
            val_7 = new System.Func<ButtonJoystickAdjust, UnityEngine.Transform>(object:  iPhoneXOrientationDetector.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Transform iPhoneXOrientationDetector.<>c::丈丌丗丟丐丝上且丕(ButtonJoystickAdjust 丏丂丛丙丆三专丂丛));
            iPhoneXOrientationDetector.<>c.<>9__7_0 = val_12;
        }
        
        this.buttons = System.Linq.Enumerable.ToArray<UnityEngine.Transform>(source:  System.Linq.Enumerable.Select<ButtonJoystickAdjust, UnityEngine.Transform>(source:  this.GetComponentsInChildren<ButtonJoystickAdjust>(includeInactive:  true), selector:  val_7));
        label_11:
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.丞丂丂上三丌丄一丌());
    }
    private System.Collections.IEnumerator 丞丂丂上三丌丄一丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new iPhoneXOrientationDetector.上三世丟东丒丈丙上();
    }
    public void Init()
    {
        UnityEngine.Transform[] val_13;
        var val_14;
        float val_15;
        var val_16;
        float val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4) || (this.anchor.side != 6))
        {
            goto label_23;
        }
        
        val_13 = this.buttons;
        val_14 = 0;
        val_15 = -1f;
        goto label_9;
        label_18:
        UnityEngine.Transform val_13 = val_13[0];
        UnityEngine.Vector3 val_3 = val_13.localPosition;
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8}, d:  val_15);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_18 = val_5.y;
        val_13.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_18, z = val_5.z};
        val_14 = 1;
        label_9:
        if(val_14 < this.buttons.Length)
        {
            goto label_18;
        }
        
        val_19 = null;
        val_19 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 != 0)
        {
                val_20 = null;
            val_20 = null;
            JoystickController.丘万丏三丏丑世丐丏.RecalculateRect();
        }
        
        label_23:
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 3) || (this.anchor.side != 0))
        {
            goto label_46;
        }
        
        val_13 = this.buttons;
        val_21 = 0;
        goto label_32;
        label_41:
        UnityEngine.Transform val_14 = val_13[0];
        UnityEngine.Vector3 val_8 = val_14.localPosition;
        val_22 = null;
        val_22 = null;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_15 = val_9.x;
        val_18 = val_9.z;
        val_14.localPosition = new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_18};
        val_21 = 1;
        label_32:
        if(val_21 < this.buttons.Length)
        {
            goto label_41;
        }
        
        val_23 = null;
        val_23 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 != 0)
        {
                val_24 = null;
            val_24 = null;
            JoystickController.丘万丏三丏丑世丐丏.RecalculateRect();
        }
        
        label_46:
        this.业七丞丟丁丅丝专不 = DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅();
        if(this.丗丛七丈丆丘丗丘丕 != true)
        {
                DeviceOrientationMonitor.丟丈东丑丒业丞业丌(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.DeviceOrientation>(object:  this, method:  System.Void iPhoneXOrientationDetector::丏丐丛东丌三业丏丗(UnityEngine.DeviceOrientation 万且万且丑丗且丌丆)));
            this.丗丛七丈丆丘丗丘丕 = true;
        }
        
        this.丝三丄专丗丞丄丄丌 = true;
    }
    private void OnDisable()
    {
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        this.StopAllCoroutines();
        DeviceOrientationMonitor.丕丆丁丆丟丈上万丝(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.DeviceOrientation>(object:  this, method:  System.Void iPhoneXOrientationDetector::丏丐丛东丌三业丏丗(UnityEngine.DeviceOrientation 万且万且丑丗且丌丆)));
        this.丗丛七丈丆丘丗丘丕 = false;
        if(this.丝三丄专丗丞丄丄丌 != false)
        {
                this.SetCoordForSave();
        }
        
        this.丝三丄专丗丞丄丄丌 = false;
    }
    public void SetCoordForSave()
    {
        UnityEngine.Transform[] val_10;
        var val_11;
        var val_12;
        float val_14;
        float val_15;
        var val_16;
        var val_17;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4) || (this.anchor.side != 6))
        {
            goto label_8;
        }
        
        val_10 = this.buttons;
        val_11 = 0;
        goto label_9;
        label_18:
        UnityEngine.Transform val_10 = val_10[0];
        UnityEngine.Vector3 val_3 = val_10.localPosition;
        val_12 = null;
        val_12 = null;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_14 = val_4.x;
        val_15 = val_4.z;
        val_10.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_4.y, z = val_15};
        val_11 = 1;
        label_9:
        if(val_11 < this.buttons.Length)
        {
            goto label_18;
        }
        
        label_8:
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 3) || (this.anchor.side != 0))
        {
            goto label_23;
        }
        
        val_10 = this.buttons;
        val_16 = 0;
        val_14 = -1f;
        goto label_24;
        label_33:
        UnityEngine.Transform val_11 = val_10[0];
        UnityEngine.Vector3 val_6 = val_11.localPosition;
        val_17 = null;
        val_17 = null;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8}, d:  val_14);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_15 = val_8.y;
        val_11.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_15, z = val_8.z};
        val_16 = 1;
        label_24:
        if(val_16 < this.buttons.Length)
        {
            goto label_33;
        }
        
        label_23:
        this.业七丞丟丁丅丝专不 = DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅();
        this.丝三丄专丗丞丄丄丌 = false;
    }
    public void SetButtonsForSwapHands(bool 七丆丟丗世丟且丒丆)
    {
        UnityEngine.Transform[] val_8;
        TouchPadController val_9;
        var val_10;
        var val_11;
        UnityEngine.Vector3 val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_9 = this;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        if(七丆丟丗世丟且丒丆 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_10 = null;
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == 3)
        {
                val_11 = null;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8}, d:  -1f);
            val_12 = val_4.x;
            val_13 = val_4.z;
        }
        else
        {
                val_14 = null;
            val_12 = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万;
        }
        
        val_8 = this.buttons;
        val_15 = 0;
        goto label_17;
        label_24:
        UnityEngine.Transform val_8 = val_8[0];
        UnityEngine.Vector3 val_5 = val_8.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_12, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_8.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_15 = 1;
        label_17:
        if(val_15 < this.buttons.Length)
        {
            goto label_24;
        }
        
        val_16 = null;
        val_16 = null;
        val_9 = JoystickController.丘万丏三丏丑世丐丏;
        if(val_9 == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        JoystickController.丘万丏三丏丑世丐丏.RecalculateRect();
    }
    private void 丏丐丛东丌三业丏丗(UnityEngine.DeviceOrientation 万且万且丑丗且丌丆)
    {
        ControlsSettingsBase val_16;
        UnityEngine.DeviceOrientation val_17;
        UnityEngine.Transform[] val_18;
        var val_19;
        var val_20;
        float val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_17 = 万且万且丑丗且丌丆;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        if(this.业七丞丟丁丅丝专不 == val_17)
        {
                return;
        }
        
        if(this.anchor.side != 0)
        {
            goto label_23;
        }
        
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 3)
        {
            goto label_9;
        }
        
        val_18 = this.buttons;
        val_19 = 0;
        goto label_10;
        label_19:
        UnityEngine.Transform val_16 = val_18[0];
        UnityEngine.Vector3 val_3 = val_16.localPosition;
        val_20 = null;
        val_20 = null;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_22 = val_4.x;
        val_23 = val_4.z;
        val_16.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_4.y, z = val_23};
        val_19 = 1;
        label_10:
        if(val_19 < this.buttons.Length)
        {
            goto label_19;
        }
        
        goto label_23;
        label_9:
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4)
        {
            goto label_23;
        }
        
        val_18 = this.buttons;
        val_24 = 0;
        goto label_24;
        label_33:
        UnityEngine.Transform val_17 = val_18[0];
        UnityEngine.Vector3 val_6 = val_17.localPosition;
        val_25 = null;
        val_25 = null;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_22 = val_7.x;
        val_23 = val_7.z;
        val_17.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_7.y, z = val_23};
        val_24 = 1;
        label_24:
        if(val_24 < this.buttons.Length)
        {
            goto label_33;
        }
        
        label_23:
        if(this.anchor.side != 6)
        {
            goto label_52;
        }
        
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4)
        {
            goto label_38;
        }
        
        val_18 = this.buttons;
        val_26 = 0;
        goto label_39;
        label_48:
        UnityEngine.Transform val_18 = val_18[0];
        UnityEngine.Vector3 val_9 = val_18.localPosition;
        val_27 = null;
        val_27 = null;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_22 = val_10.x;
        val_23 = val_10.z;
        val_18.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_10.y, z = val_23};
        val_26 = 1;
        label_39:
        if(val_26 < this.buttons.Length)
        {
            goto label_48;
        }
        
        goto label_52;
        label_38:
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 3)
        {
            goto label_52;
        }
        
        val_18 = this.buttons;
        val_28 = 0;
        goto label_53;
        label_62:
        UnityEngine.Transform val_19 = val_18[0];
        UnityEngine.Vector3 val_12 = val_19.localPosition;
        val_29 = null;
        val_29 = null;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 与丂丏丛丞丞丒丟丄.丐世丑丞丂丞丒与万, y = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D4, z = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.__il2cppRuntimeField_1D8});
        val_22 = val_13.x;
        val_23 = val_13.z;
        val_19.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_13.y, z = val_23};
        val_28 = 1;
        label_53:
        if(val_28 < this.buttons.Length)
        {
            goto label_62;
        }
        
        label_52:
        val_16 = this.settings;
        if(val_16 != 0)
        {
                val_16 = this.settings;
            val_16.SetJoyConstraints();
        }
        
        this.业七丞丟丁丅丝专不 = val_17;
        val_30 = null;
        val_30 = null;
        val_17 = JoystickController.丘万丏三丏丑世丐丏;
        if(val_17 == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        JoystickController.丘万丏三丏丑世丐丏.RecalculateRect();
    }
    public iPhoneXOrientationDetector()
    {
    
    }

}
