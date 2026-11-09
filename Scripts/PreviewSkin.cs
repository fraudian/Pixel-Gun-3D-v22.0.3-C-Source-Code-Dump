using UnityEngine;
public class PreviewSkin : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera previewCamera;
    private UnityEngine.Vector2 世丛丂万丛不丈丒丙;
    private bool 丆上且丝七与业丞丁;
    private UnityEngine.GameObject 且业丝一万丌丏上丗;
    private float 丗丛下丐丄丝丛丈不;
    private float 丕世三丂丈下丕业丄;
    private UnityEngine.Rect 丕业三丆且丙丝丐丏;
    private UnityEngine.Vector3 丒与东丟丏上下业丘;
    private UnityEngine.Vector3 丙丗丄东东世丗丘丑;
    
    // Methods
    private void Start()
    {
        float val_5 = this.丕世三丂丈下丕业丄;
        float val_4 = -2f;
        val_4 = this.丗丛下丐丄丝丛丈不 * val_4;
        val_4 = (float)UnityEngine.Screen.width + val_4;
        val_5 = val_5 + val_5;
        float val_3 = (float)UnityEngine.Screen.height - val_5;
        this.丕业三丆且丙丝丐丏 = 0;
        mem[1152921535967234132] = 0;
        mem[1152921535967234140] = 0;
    }
    private void Update()
    {
        float val_33;
        float val_34;
        float val_35;
        string val_36;
        var val_37;
        var val_38;
        if(this.丆上且丝七与业丞丁 == true)
        {
            goto label_1;
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_2;
        }
        
        UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
        if(专三三与三且一且一() == 0)
        {
            goto label_3;
        }
        
        label_2:
        if(this.丆上且丝七与业丞丁 == false)
        {
            goto label_15;
        }
        
        label_1:
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_15;
        }
        
        UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
        if(专三三与三且一且一() != 1)
        {
            goto label_15;
        }
        
        if(UnityEngine.Input.touchCount > 0)
        {
                UnityEngine.Touch val_8 = UnityEngine.Input.GetTouch(index:  0);
        }
        else
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
        }
        
        val_33 = this.世丛丂万丛不丈丒丙 - val_9.x;
        if((this.且业丝一万丌丏上丗 == 0) || (System.Math.Abs(val_33) <= 2f))
        {
            goto label_14;
        }
        
        new UnityEngine.Mathf().Unhighlight(丝三丁东丈丒世丅业:  this.且业丝一万丌丏上丗);
        this.且业丝一万丌丏上丗 = 0;
        goto label_15;
        label_14:
        val_34 = val_33 * 0.5f;
        val_35 = 0f;
        this.transform.Rotate(xAngle:  val_35, yAngle:  val_34, zAngle:  0f, relativeTo:  1);
        if(UnityEngine.Input.touchCount <= 0)
        {
            goto label_17;
        }
        
        UnityEngine.Touch val_13 = UnityEngine.Input.GetTouch(index:  0);
        goto label_18;
        label_3:
        if(UnityEngine.Input.touchCount <= 0)
        {
            goto label_19;
        }
        
        UnityEngine.Touch val_15 = UnityEngine.Input.GetTouch(index:  0);
        goto label_20;
        label_17:
        UnityEngine.Vector3 val_16 = UnityEngine.Input.mousePosition;
        val_33 = val_16.x;
        UnityEngine.Vector3 val_17 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_33, y:  val_17.y);
        val_35 = val_18.x;
        val_34 = val_18.y;
        label_18:
        this.世丛丂万丛不丈丒丙 = val_35;
        mem[1152921535967469316] = val_34;
        label_15:
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        UnityEngine.Touch val_20 = UnityEngine.Input.GetTouch(index:  0);
        if(专三三与三且一且一() != 3)
        {
                UnityEngine.Touch val_22 = UnityEngine.Input.GetTouch(index:  0);
            if(专三三与三且一且一() != 4)
        {
                return;
        }
        
        }
        
        val_36 = 1152921504848912384;
        if(this.且业丝一万丌丏上丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            ButtonClickSound.丆丕丝丒不丙且丐丗.Unhighlight(丝三丁东丈丒世丅业:  this.且业丝一万丌丏上丗);
            val_37 = null;
            val_37 = null;
            if(SkinEditorController.丄丞丁丈与业上丞丟 != 0)
        {
                val_38 = null;
            val_38 = null;
            val_36 = this.且业丝一万丌丏上丗.name;
            SkinEditorController.丄丞丁丈与业上丞丟.SelectPart(专三丆丗丆三丘万东:  val_36);
        }
        
            this.且业丝一万丌丏上丗 = 0;
        }
        
        this.丆上且丝七与业丞丁 = false;
        return;
        label_19:
        UnityEngine.Vector3 val_27 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_28 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_27.x, y:  val_28.y);
        label_20:
        this.世丛丂万丛不丈丒丙 = val_29.x;
        mem[1152921535967469316] = val_29.y;
        if((this.丕业三丆且丙丝丐丏 & 1) == 0)
        {
                return;
        }
        
        this.丆上且丝七与业丞丁 = true;
        UnityEngine.GameObject val_30 = this.GameObjectOnTouch(世丛丂万丛不丈丒丙:  new UnityEngine.Vector2() {x = this.世丛丂万丛不丈丒丙, y = val_29.y});
        this.且业丝一万丌丏上丗 = val_30;
        bool val_31 = UnityEngine.Object.op_Inequality(x:  val_30, y:  0);
        if(val_31 == false)
        {
                return;
        }
        
        val_31.Highlight(丝三丁东丈丒世丅业:  this.且业丝一万丌丏上丗);
    }
    public UnityEngine.GameObject GameObjectOnTouch(UnityEngine.Vector2 世丛丂万丛不丈丒丙)
    {
        float val_2;
        float val_3;
        var val_6;
        UnityEngine.Ray val_1 = this.previewCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_6 = 0;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, m_Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
        {
                return (UnityEngine.GameObject)0.gameObject;
        }
        
        return (UnityEngine.GameObject)0.gameObject;
    }
    public void Highlight(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.Renderer val_6 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Renderer>();
        if(val_6 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_4 = val_6.materials[0].GetColor(name:  "_ColorRili");
        val_6 = val_6.materials[0];
        val_6.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    public void Unhighlight(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.Renderer val_6 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Renderer>();
        if(val_6 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_4 = val_6.materials[0].GetColor(name:  "_ColorRili");
        val_6 = val_6.materials[0];
        val_6.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    private void OnEnable()
    {
        this.丆上且丝七与业丞丁 = false;
        this.且业丝一万丌丏上丗 = 0;
    }
    private void OnDisable()
    {
        this.丆上且丝七与业丞丁 = false;
        this.且业丝一万丌丏上丗 = 0;
    }
    public PreviewSkin()
    {
        this.丗丛下丐丄丝丛丈不 = 100f;
        this.丕世三丂丈下丕业丄 = 120f;
    }

}
