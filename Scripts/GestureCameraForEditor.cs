using UnityEngine;
internal sealed class GestureCameraForEditor : PGBehaviour
{
    // Fields
    public GestureCamera gestureCamera;
    public UiEvents uiEvents;
    private UnityEngine.Vector3 丑丘且业七丛不一丄;
    public float scrollWheelSensitivity;
    private bool 丗丅丈丈丙丌业丌丆;
    private UnityEngine.Vector3 丆七业丙丛丗丗不丐;
    private UnityEngine.Vector3 丐与丑丁下丁丒丙丒;
    
    // Methods
    private void OnEnable()
    {
        var val_2;
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForEditor::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        val_2 = null;
        val_2 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled != false)
        {
                return;
        }
        
        this.丆万丟东丈丙丒丟一();
    }
    private void 上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)
    {
        this.丙丏下丒与丐万上与();
        this.丆万丟东丈丙丒丟一();
    }
    private void OnDisable()
    {
        var val_2;
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForEditor::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        val_2 = null;
        val_2 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled != false)
        {
                return;
        }
        
        this.丙丏下丒与丐万上与();
    }
    private void 丆万丟东丈丙丒丟一()
    {
        var val_6;
        if(this.uiEvents == 0)
        {
            goto label_3;
        }
        
        val_6 = null;
        val_6 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
            goto label_6;
        }
        
        label_3:
        ClanWarMapUI.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        ClanWarMapUI.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForEditor::OnPress(bool 万东丂丒且丅丛丑丕)));
        return;
        label_6:
        this.uiEvents.add_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        this.uiEvents.add_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForEditor::OnPress(bool 万东丂丒且丅丛丑丕)));
    }
    private void 丙丏下丒与丐万上与()
    {
        if(this.uiEvents != 0)
        {
                this.uiEvents.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
            this.uiEvents.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForEditor::OnPress(bool 万东丂丒且丅丛丑丕)));
            return;
        }
        
        ClanWarMapUI.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        ClanWarMapUI.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForEditor::OnPress(bool 万东丂丒且丅丛丑丕)));
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丑丘且业七丛不一丄 = val_1;
        mem[1152921536910591628] = val_1.y;
        mem[1152921536910591632] = val_1.z;
    }
    private void OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
    
    }
    private void 万丒丄丐下与丙丗与()
    {
        float val_2;
        float val_3;
        float val_1 = UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel");
        if(val_1 == 0f)
        {
                return;
        }
        
        if(this.gestureCamera != null)
        {
                val_2 = this.gestureCamera.丛丑上丝丆丆丁且丄;
            val_3 = this.scrollWheelSensitivity;
        }
        else
        {
                val_2 = 1.765198E-38f;
            val_3 = this.scrollWheelSensitivity;
        }
        
        val_1 = val_1 * val_3;
        val_1 = val_2 - val_1;
        this.gestureCamera.ZoomValue = val_1;
    }
    private void 丗专丘下丗世上丐万()
    {
        var val_12;
        UnityEngine.Vector3 val_13;
        float val_14;
        float val_15;
        val_12 = this;
        if((UnityEngine.Input.GetKey(key:  52)) != true)
        {
                if((UnityEngine.Input.GetKey(key:  51)) == false)
        {
            goto label_3;
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_3;
        }
        
        if(this.丗丅丈丈丙丌业丌丆 == false)
        {
            goto label_4;
        }
        
        val_13 = this.丆七业丙丛丗丗不丐;
        goto label_5;
        label_3:
        this.丗丅丈丈丙丌业丌丆 = false;
        return;
        label_4:
        UnityEngine.Quaternion val_5 = this.transform.localRotation;
        this.丐与丑丁下丁丒丙丒 = val_5.x;
        mem[1152921536910944044] = val_5.y;
        mem[1152921536910944048] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        val_13 = val_6.x;
        val_14 = val_6.y;
        val_15 = val_6.z;
        this.丆七业丙丛丗丗不丐 = val_6;
        mem[1152921536910944032] = val_14;
        mem[1152921536910944036] = val_15;
        this.丗丅丈丈丙丌业丌丆 = true;
        label_5:
        UnityEngine.Vector3 val_7 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.forward;
        val_15 = val_14 - (UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, to:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, axis:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.z, z = val_5.x}));
        val_12 = this.transform;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.丐与丑丁下丁丒丙丒, y = val_15, z = val_14});
        val_12.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    private void LateUpdate()
    {
    
    }
    public GestureCameraForEditor()
    {
        this.scrollWheelSensitivity = 5f;
    }

}
