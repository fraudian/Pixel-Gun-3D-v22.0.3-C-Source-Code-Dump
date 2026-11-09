using UnityEngine;
internal sealed class GestureCameraForGamePad : PGBehaviour
{
    // Fields
    public GestureCamera gestureCamera;
    public UiEvents uiEvents;
    public float sensativity;
    private float sensitivityZoom;
    private float sensitivityRotate;
    private UnityEngine.Vector3 丑丘且业七丛不一丄;
    
    // Methods
    private void OnEnable()
    {
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::丗丈丏丆专东丂丂丟(string 万且万且丑丗且丌丆)));
        GamepadManager.业世丘世丏一丗丗业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::业专丘丑丞且七丅世(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GestureCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
        if(this.uiEvents == 0)
        {
                return;
        }
        
        ClanWarMapUI.add_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForGamePad::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        ClanWarMapUI.add_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForGamePad::OnPress(bool 万东丂丒且丅丛丑丕)));
    }
    private void 丗丈丏丆专东丂丂丟(string 万且万且丑丗且丌丆)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  万且万且丑丗且丌丆)) == false)
        {
                return;
        }
        
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GestureCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
    }
    private void 业专丘丑丞且七丅世(string 万且万且丑丗且丌丆)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  万且万且丑丗且丌丆)) != false)
        {
                return;
        }
        
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GestureCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
    }
    private void 一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)
    {
        var val_9;
        GestureCamera val_10;
        var val_11;
        GestureCamera val_12;
        float val_13;
        float val_14;
        val_9 = 丅上三丏万丛七丐东;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
                return;
        }
        
        if(val_9 > 35)
        {
            goto label_4;
        }
        
        if(val_9 == 2)
        {
            goto label_5;
        }
        
        if(val_9 != 35)
        {
                return;
        }
        
        float val_2 = this.sensitivityZoom * (1.152922E+18f);
        val_2 = val_2 * UnityEngine.Time.deltaTime;
        val_2 = this.gestureCamera.丛丑上丝丆丆丁且丄 + val_2;
        this.gestureCamera.ZoomValue = val_2;
        return;
        label_4:
        if(val_9 == 36)
        {
            goto label_9;
        }
        
        if(val_9 != 37)
        {
                return;
        }
        
        if(null <= 0f)
        {
                return;
        }
        
        val_12 = this.gestureCamera;
        val_13 = this.sensitivityRotate;
        val_14 = -10f;
        goto label_14;
        label_5:
        if(专丒丌丆下丐丞丟丞 == null)
        {
                return;
        }
        
        val_9 = 1152921504850403328;
        if(null != null)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 3.782474E-38f, y = V8.16B}, d:  this.sensativity);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  UnityEngine.Time.deltaTime);
        this.gestureCamera.丌丟丄业且三丛丕丄().Translate(translation:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_10 = this.gestureCamera;
        UnityEngine.Vector3 val_7 = val_10.Position;
        UnityEngine.Vector3 val_8 = val_10.丌丒丟且丐丘丌一世(且丌上七丅东与丁万:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_10.Position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        return;
        label_9:
        if(null <= 0f)
        {
                return;
        }
        
        val_12 = this.gestureCamera;
        val_13 = this.sensitivityRotate;
        val_14 = 10f;
        label_14:
        val_14 = val_13 * val_14;
        val_12.丌丏丈丈世丙七丅一(三丈且丌丝丛丞业不:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丑丘且业七丛不一丄 = val_1;
        mem[1152921536911888792] = val_1.y;
        mem[1152921536911888796] = val_1.z;
    }
    private void OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        float val_13;
        if(UnityEngine.Input.touchCount > 0)
        {
                return;
        }
        
        if((GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField) == false)
        {
                return;
        }
        
        if(GamepadCursorController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        var val_11 = ~((int)(GamepadCursorController.丙丅丛七丅丒东丆与 >> 0) & 1);
        val_11 = val_11 & 7;
        if(val_11 != 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
        UnityEngine.Vector3 val_4 = this.gestureCamera.七丅丗丘万丈丄万丙(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, 丁万世丞丙丟丏专丆:  false);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_13 = V13.16B;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.丑丘且业七丛不一丄, y = V14.16B, z = val_13}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) != false)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丑丘且业七丛不一丄, y = V13.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_8 = this.gestureCamera.Position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_13 = val_9.z;
            this.gestureCamera.Position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_13};
        }
        
        UnityEngine.Vector3 val_10 = this.gestureCamera.七丅丗丘万丈丄万丙(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, 丁万世丞丙丟丏专丆:  false);
        this.丑丘且业七丛不一丄 = val_10;
        mem[1152921536912013080] = val_10.y;
        mem[1152921536912013084] = val_10.z;
    }
    private void OnDisable()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::丗丈丏丆专东丂丂丟(string 万且万且丑丗且丌丆)));
        GamepadManager.七世且丞丄丆上丆业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::业专丘丑丞且七丅世(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GestureCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
        ClanWarMapUI.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForGamePad::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        ClanWarMapUI.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForGamePad::OnPress(bool 万东丂丒且丅丛丑丕)));
    }
    private void OnDestroy()
    {
        GamepadManager.万丏丟丐丑丄万丅与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::丗丈丏丆专东丂丂丟(string 万且万且丑丗且丌丆)));
        GamepadManager.七世且丞丄丆上丆业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GestureCameraForGamePad::业专丘丑丞且七丅世(string 万且万且丑丗且丌丆)));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GestureCameraForGamePad::一且丑与世万三丑专(PGCompany.丆七丗丂世丞丗丙三 丅上三丏万丛七丐东, object 专丒丌丆下丐丞丟丞)));
        ClanWarMapUI.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void GestureCameraForGamePad::OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)));
        ClanWarMapUI.remove_onPress(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GestureCameraForGamePad::OnPress(bool 万东丂丒且丅丛丑丕)));
    }
    public GestureCameraForGamePad()
    {
        this.sensativity = 0.2f;
        this.sensitivityZoom = 3.5f;
        this.sensitivityRotate = 1f;
    }

}
