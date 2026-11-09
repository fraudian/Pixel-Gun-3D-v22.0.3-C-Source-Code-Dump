using UnityEngine;
private sealed class ControlsSettingsBase.不丈不万下丄丂丅丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ControlsSettingsBase 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ControlsSettingsBase.不丈不万下丄丂丅丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_23;
        int val_24;
        float val_25;
        MainMenuControlSettings val_26;
        float val_27;
        MainMenuControlSettings val_28;
        MainMenuControlSettings val_29;
        float val_30;
        float val_31;
        float val_32;
        MainMenuControlSettings val_33;
        MainMenuControlSettings val_34;
        MainMenuControlSettings val_35;
        MainMenuControlSettings val_36;
        val_23 = this;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_24 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_24;
        }
        
            val_24 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_24;
            return (bool)val_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_2 = UnityEngine.Screen.height - 120;
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeftControlsAnchor.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        int val_4 = UnityEngine.Screen.width;
        UnityEngine.Vector3 val_5 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeftControlsAnchor.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.丝且与丝丒丟万丁专._settingsControls.TopLeft.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        val_25 = val_3.z;
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_25};
        val_26 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_21;
        }
        
        val_26 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_26 == null)
        {
            goto label_67;
        }
        
        label_21:
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        val_27 = val_7.x;
        val_7.x = val_27 + 100f;
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_28 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_26;
        }
        
        val_28 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_28 == null)
        {
            goto label_67;
        }
        
        label_26:
        val_23 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft;
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition;
        val_23.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
            goto label_65;
        }
        
        val_29 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_33;
        }
        
        val_29 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_29 == null)
        {
            goto label_67;
        }
        
        label_33:
        UnityEngine.Vector3 val_10 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.localPosition;
        val_30 = 0f;
        val_31 = 0f;
        val_32 = 0f;
        this.丝且与丝丒丟万丁专._settingsControls.BottomLeft.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == 4) || (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false))
        {
            goto label_42;
        }
        
        val_25 = val_5.z;
        this.丝且与丝丒丟万丁专._settingsControls.BottomRight.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_25};
        val_33 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_45;
        }
        
        val_33 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_33 == null)
        {
            goto label_67;
        }
        
        label_45:
        UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition;
        this.丝且与丝丒丟万丁专._settingsControls.BottomRight.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_34 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_49;
        }
        
        val_34 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_34 == null)
        {
            goto label_67;
        }
        
        label_49:
        UnityEngine.Vector3 val_14 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        UnityEngine.Vector3 val_15 = this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition;
        float val_16 = val_14.x + 100f;
        val_30 = 0f;
        val_31 = 0f;
        val_32 = 0f;
        this.丝且与丝丒丟万丁专._settingsControls.TopRight.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
        label_42:
        if((DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() != 4) || (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false))
        {
            goto label_60;
        }
        
        val_35 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_61;
        }
        
        val_35 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_35 == null)
        {
            goto label_67;
        }
        
        label_61:
        val_23 = this.丝且与丝丒丟万丁专._settingsControls.BottomLeft;
        UnityEngine.Vector3 val_19 = this.丝且与丝丒丟万丁专._settingsControls.BottomRight.position;
        val_27 = val_19.x;
        val_25 = val_19.z;
        val_23.position = new UnityEngine.Vector3() {x = val_27, y = val_19.y, z = val_25};
        goto label_65;
        label_60:
        val_36 = this.丝且与丝丒丟万丁专._settingsControls;
        if(this.丝且与丝丒丟万丁专._settingsControls != null)
        {
            goto label_66;
        }
        
        val_36 = this.丝且与丝丒丟万丁专._settingsControls;
        if(val_36 == null)
        {
            goto label_67;
        }
        
        label_66:
        val_23 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft;
        UnityEngine.Vector3 val_20 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition;
        val_27 = val_20.x;
        UnityEngine.Vector3 val_21 = this.丝且与丝丒丟万丁专._settingsControls.TopLeft.localPosition;
        float val_22 = val_27 + 100f;
        val_23.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_65:
        val_24 = 0;
        this.丝且与丝丒丟万丁专.一丁丑丙丅丑丞丏下 = 0;
        return (bool)val_24;
        label_67:
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
