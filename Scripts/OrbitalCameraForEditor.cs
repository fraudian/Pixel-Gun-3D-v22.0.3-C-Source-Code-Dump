using UnityEngine;
internal sealed class OrbitalCameraForEditor : PGBehaviour
{
    // Fields
    public OrbitalCamera orbitalCamera;
    public UiEvents uiEvents;
    public float scrollWheelSensitivity;
    
    // Methods
    private void OnEnable()
    {
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForEditor::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        this.丆万丟东丈丙丒丟一();
    }
    private void OnDisable()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForEditor::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        this.万不丒上丕丗丂丘丒();
    }
    private void OnDestroy()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForEditor::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        this.万不丒上丕丗丂丘丒();
    }
    private void 丆万丟东丈丙丒丟一()
    {
        var val_3;
        if(this.uiEvents == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled != false)
        {
                return;
        }
        
        this.uiEvents.add_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void OrbitalCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
    }
    private void 万不丒上丕丗丂丘丒()
    {
        if(this.uiEvents == 0)
        {
                return;
        }
        
        this.uiEvents.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void OrbitalCameraForEditor::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
    }
    private void 上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)
    {
        this.万不丒上丕丗丂丘丒();
        this.丆万丟东丈丙丒丟一();
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
        
        if(this.orbitalCamera != null)
        {
                val_2 = this.orbitalCamera.丛丑上丝丆丆丁且丄;
            val_3 = this.scrollWheelSensitivity;
        }
        else
        {
                val_2 = 0f;
            val_3 = this.scrollWheelSensitivity;
        }
        
        val_1 = val_1 * val_3;
        val_1 = val_2 - val_1;
        this.orbitalCamera.ZoomValue = val_1;
    }
    private void LateUpdate()
    {
    
    }
    public OrbitalCameraForEditor()
    {
        this.scrollWheelSensitivity = 5f;
    }

}
