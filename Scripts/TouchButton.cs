using UnityEngine;
public class TouchButton : MonoBehaviour
{
    // Fields
    public UnityEngine.Rect zoneRect;
    protected bool 丆丛丆丞下丅丂且丝;
    protected bool 丞一不东丙丑丄与丐;
    protected bool 丄东不且丘丏上与业;
    protected TouchPadController 业丝世丞丅专丛丘丌;
    public System.Action<bool> onPressed;
    public System.Action onClick;
    protected StateHolder 丑丒且上业一与丛丝;
    protected float 东丟万丄丘丗丑上世;
    protected UISprite 丗丙东东与丏丄下且;
    protected bool 东丞丂万丒丌丄丏丛;
    protected bool 丝丛丈丛丌丐丆七丕;
    
    // Properties
    public bool 丆丟专丑丁丒丁上丙 { get; }
    
    // Methods
    public bool get_isPressed()
    {
        return (bool)this.丄东不且丘丏上与业;
    }
    private void Awake()
    {
        null = null;
        this.业丝世丞丅专丛丘丌 = JoystickController.丘万丏三丏丑世丐丏;
        this.丑丒且上业一与丛丝 = this.GetComponent<StateHolder>();
        this.丗丙东东与丏丄下且 = this.GetComponent<UISprite>();
    }
    protected virtual void OnEnable()
    {
    
    }
    public virtual bool CanPress()
    {
        return true;
    }
    public virtual bool IsActive()
    {
        return true;
    }
    public virtual bool IsVisualBlock()
    {
        return false;
    }
    public virtual bool OnPress(bool 丆且上丘世下丅且丞, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_2;
        if(丆且上丘世下丅且丞 != false)
        {
                if((((this & 1) != 0) && ((this.zoneRect & 1) != 0)) && (this.丆丛丆丞下丅丂且丝 != false))
        {
                this.丞一不东丙丑丄与丐 = true;
        }
        
            var val_1 = (this.丞一不东丙丑丄与丐 == true) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        this.丞一不东丙丑丄与丐 = false;
        return (bool)val_2;
    }
    public virtual void OnPressed(bool 丁丐不且七丂业丗丆)
    {
        if(this.onPressed == null)
        {
                return;
        }
        
        丁丐不且七丂业丗丆 = 丁丐不且七丂业丗丆;
        this.onPressed.Invoke(obj:  丁丐不且七丂业丗丆);
    }
    public virtual void OnClick()
    {
        if(this.onClick == null)
        {
                return;
        }
        
        this.onClick.Invoke();
    }
    public virtual void SetPressed(bool 丁丐不且七丂业丗丆)
    {
        var val_1 = (this.丄东不且丘丏上与业 == true) ? 1 : 0;
        val_1 = val_1 ^ 丁丐不且七丂业丗丆;
        if(val_1 == false)
        {
                return;
        }
        
        this.丄东不且丘丏上与业 = 丁丐不且七丂业丗丆;
    }
    public virtual void Reset()
    {
        this.丞一不东丙丑丄与丐 = false;
        this.丄东不且丘丏上与业 = false;
    }
    public virtual void SetEnabled(bool 丛丅丘一丏丙且丌上)
    {
        this.丆丛丆丞下丅丂且丝 = 丛丅丘一丏丙且丌上;
    }
    public virtual void SetGreenBlink(bool 丛丅丘一丏丙且丌上)
    {
        this.东丞丂万丒丌丄丏丛 = 丛丅丘一丏丙且丌上;
    }
    public virtual void SetRedBlink(bool 丛丅丘一丏丙且丌上)
    {
        this.丝丛丈丛丌丐丆七丕 = 丛丅丘一丏丙且丌上;
    }
    public void CalculateButtonRect(UnityEngine.Camera 丆丏一专不丝丈丗上)
    {
        float val_10 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        if(丆丏一专不丝丈丗上 == 0)
        {
                UnityEngine.Debug.LogError(message:  "camera not setted");
        }
        
        val_10 = this.东丟万丄丘丗丑上世 * val_10;
        val_10 = val_10 + val_10;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = 丆丏一专不丝丈丗上.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_10, y:  val_10);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, d:  0.5f);
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        this.zoneRect = 0;
        mem[1152921540543051260] = 0;
        mem[1152921540543051268] = 0;
    }
    private void Update()
    {
        goto typeof(TouchButton).__il2cppRuntimeField_228;
    }
    public virtual void ButtonUpdate()
    {
        下七一丌丝丂丙七丑 val_3;
        if(this.丑丒且上业一与丛丝 == 0)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        if(this.丄东不且丘丏上与业 == false)
        {
            goto label_5;
        }
        
        val_3 = 1;
        if(this.丑丒且上业一与丛丝 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_4:
        val_3 = 2;
        if(this.丑丒且上业一与丛丝 != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this.丑丒且上业一与丛丝.state = val_3;
        return;
        label_5:
        if(this.东丞丂万丒丌丄丏丛 == false)
        {
            goto label_9;
        }
        
        if(this.丑丒且上业一与丛丝 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_9:
        if(this.丝丛丈丛丌丐丆七丕 == false)
        {
            goto label_12;
        }
        
        if(this.丑丒且上业一与丛丝 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_12:
        var val_2 = (this != 1) ? 2 : 0;
        if(this.丑丒且上业一与丛丝 != null)
        {
            goto label_15;
        }
        
        goto label_16;
    }
    internal void 丝丆且下丁三不丘世(float 下丌丟丏丏丘专丒专)
    {
        if(this.丗丙东东与丏丄下且 == 0)
        {
                return;
        }
        
        this.丗丙东东与丏丄下且.alpha = 下丌丟丏丏丘专丒专;
    }
    public void SetButtonSize(int 丟丒且一专丟丙下一)
    {
        float val_2 = (float)丟丒且一专丟丙下一;
        val_2 = val_2 * 0.5f;
        this.东丟万丄丘丗丑上世 = val_2;
        if(this.丗丙东东与丏丄下且 == 0)
        {
                return;
        }
        
        mem2[0] = 1;
        this.丗丙东东与丏丄下且.width = 丟丒且一专丟丙下一;
    }
    internal void 上丅丕丅丟丕丏丁丆(下丂世丂不丛专一一.丟一丙丈东上万不丕 丄一丌丝不三丙丗上)
    {
        this.transform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        this.SetButtonSize(丟丒且一专丟丙下一:  下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
        this.丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  V0.16B);
    }
    internal void 丝下丝丏世丝丈下丅(下丂世丂不丛专一一.丟一丙丈东上万不丕 丄一丌丝不三丙丗上, UnityEngine.Transform 丁丝且业丛丘丘专上)
    {
        UnityEngine.Vector3 val_4 = 丁丝且业丛丘丘专上.TransformPoint(position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        丁丝且业丛丘丘专上.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.SetButtonSize(丟丒且一专丟丙下一:  下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
        this.丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  val_4.x);
    }
    public TouchButton()
    {
        this.丆丛丆丞下丅丂且丝 = true;
        this.东丟万丄丘丗丑上世 = 40f;
    }

}
