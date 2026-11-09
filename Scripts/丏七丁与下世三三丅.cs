using UnityEngine;
private sealed class ControlsSettingsBase.丏七丁与下世三三丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ControlsSettingsBase 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ControlsSettingsBase.丏七丁与下世三三丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_24;
        int val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        MainMenuControlSettings val_30;
        MainMenuControlSettings val_31;
        float val_32;
        float val_33;
        MainMenuControlSettings val_34;
        MainMenuControlSettings val_38;
        MainMenuControlSettings val_39;
        MainMenuControlSettings val_40;
        MainMenuControlSettings val_41;
        MainMenuControlSettings val_42;
        MainMenuControlSettings val_43;
        MainMenuControlSettings val_44;
        MainMenuControlSettings val_45;
        val_24 = this;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_25 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_25;
        }
        
            val_25 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_25;
            return (bool)val_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_2 = UnityEngine.Screen.height - 120;
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeftControlsAnchor.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        int val_4 = UnityEngine.Screen.width;
        UnityEngine.Vector3 val_5 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeftControlsAnchor.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_26 = val_5.x;
        val_27 = val_5.y;
        val_28 = val_5.z;
        if(this.丝且与丝丒丟万丁专._settingsControls == null)
        {
                val_26 = val_26;
            val_27 = val_27;
            val_28 = val_28;
        }
        
        this.丝且与丝丒丟万丁专._settingsControls.BottomRight.position = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.x, z = val_3.z};
        this.丝且与丝丒丟万丁专._settingsControls.TopLeft.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.x, z = val_3.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_29 = val_6.z;
        this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_29};
        val_30 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_22;
        }
        
        val_30 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_30 == null)
        {
            goto label_81;
        }
        
        label_22:
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_31 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_27;
        }
        
        val_31 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_31 == null)
        {
            goto label_81;
        }
        
        label_27:
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition;
        val_32 = 550f;
        val_33 = 0f;
        this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition = new UnityEngine.Vector3() {x = val_33, y = 0f, z = 0f};
        val_34 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_33;
        }
        
        val_34 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_34 == null)
        {
            goto label_81;
        }
        
        label_33:
        val_24 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight;
        UnityEngine.Vector3 val_10 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
            goto label_36;
        }
        
        val_24.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_24 = 1152921505171861504;
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4)
        {
                if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_43;
        }
        
        }
        
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4) || (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == true))
        {
            goto label_49;
        }
        
        val_38 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_50;
        }
        
        val_38 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_38 == null)
        {
            goto label_81;
        }
        
        label_50:
        UnityEngine.Vector3 val_15 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.position;
        val_32 = val_15.x;
        val_29 = val_15.z;
        val_33 = val_32;
        this.丝且与丝丒丟万丁专._settingsControls.BottomRight.position = new UnityEngine.Vector3() {x = val_33, y = val_15.y, z = val_29};
        val_39 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_54;
        }
        
        val_39 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_39 == null)
        {
            goto label_81;
        }
        
        label_54:
        val_24 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight;
        UnityEngine.Vector3 val_16 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition;
        label_36:
        val_16.x = val_16.x + (-100f);
        label_84:
        val_24.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_49:
        val_25 = 0;
        this.丝且与丝丒丟万丁专.世丙丆不丙专丏丂丄 = 0;
        return (bool)val_25;
        label_43:
        val_40 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_58;
        }
        
        val_40 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_40 == null)
        {
            goto label_81;
        }
        
        label_58:
        UnityEngine.Vector3 val_17 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.position;
        this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        val_41 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_62;
        }
        
        val_41 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_41 == null)
        {
            goto label_81;
        }
        
        label_62:
        UnityEngine.Vector3 val_18 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.localPosition;
        this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_42 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_66;
        }
        
        val_42 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_42 == null)
        {
            goto label_81;
        }
        
        label_66:
        UnityEngine.Vector3 val_19 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        UnityEngine.Vector3 val_20 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        float val_24 = 100f;
        val_24 = val_19.x + val_24;
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_43 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_72;
        }
        
        val_43 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_43 == null)
        {
            goto label_81;
        }
        
        label_72:
        UnityEngine.Vector3 val_21 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.position;
        this.丝且与丝丒丟万丁专._settingsControls.TopLeft.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        val_44 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_76;
        }
        
        val_44 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_44 == null)
        {
            goto label_81;
        }
        
        label_76:
        UnityEngine.Vector3 val_22 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition;
        this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_45 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_80;
        }
        
        val_45 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_45 == null)
        {
            goto label_81;
        }
        
        label_80:
        UnityEngine.Vector3 val_23 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition;
        val_23.x = val_23.x + (-100f);
        if(this.丝且与丝丒丟万丁专._settingsControls.BottomRight != null)
        {
            goto label_84;
        }
        
        goto label_84;
        label_81:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
