using UnityEngine;
internal sealed class OrbitalCameraForGamePad : PGBehaviour
{
    // Fields
    public OrbitalCamera orbitalCamera;
    public UiEvents uiEvents;
    public float sensativity;
    
    // Methods
    private void OnEnable()
    {
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForGamePad::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void OrbitalCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
    }
    private void OnDisable()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForGamePad::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void OrbitalCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
    }
    private void OnDestroy()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void OrbitalCameraForGamePad::上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void OrbitalCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
    }
    private void 上丂丕七世一东丘丗(string 万且万且丑丗且丌丆)
    {
        System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object> val_2 = new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void OrbitalCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞));
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  万且万且丑丗且丌丆)) != false)
        {
                PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  val_2);
            return;
        }
        
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  val_2);
    }
    private void 一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)
    {
        PGCompany.丆七丗丂世丞丗丙三 val_6 = 丅上三丏万丛七丐东;
        if(专丒丌丆下丐丞丟丞 == null)
        {
                return;
        }
        
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
                return;
        }
        
        if(val_6 != 2)
        {
                return;
        }
        
        val_6 = 1152921504850403328;
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  专丒丌丆下丐丞丟丞);
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 3.782474E-38f, y = V8.16B}, d:  this.sensativity);
        float val_7 = val_1.x;
        UnityEngine.Vector3 val_3 = this.transform.localEulerAngles;
        float val_6 = this.orbitalCamera.rotateSensitivity;
        val_6 = val_7 * val_6;
        val_7 = val_3.y + val_6;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_3.x, y = val_7, z = val_3.z});
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
    }
    public OrbitalCameraForGamePad()
    {
        this.sensativity = 2.3f;
    }

}
