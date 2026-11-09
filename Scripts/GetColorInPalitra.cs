using UnityEngine;
internal sealed class GetColorInPalitra : MonoBehaviour
{
    // Fields
    public UITexture canvasTexture;
    public UISprite newColor;
    public UIButton okColorInPalitraButton;
    public UnityEngine.Texture2D mainPicker;
    public UnityEngine.Texture2D extendedPicker;
    private bool 万丝丅丕丕丑业专丆;
    
    // Methods
    private void Update()
    {
        UIButton val_14;
        var val_15;
        float val_16;
        var val_17;
        val_14 = this;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  0);
        val_15 = 0;
        val_16 = val_1.x;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_16, y:  val_1.y);
        if(((专三三与三且一且一() != 4) ? 1 : 0) == 0)
        {
                return;
        }
        
        if((this.丈丝丅丘丕万丝且丈(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y})) == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_9 = this.丛下丅丆且丞一丙丙(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        val_17 = this.canvasTexture;
        if(val_17 == null)
        {
            goto label_10;
        }
        
        if(null != null)
        {
            
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        val_17 = 0;
        goto label_13;
        label_10:
        label_13:
        UnityEngine.Color val_13 = val_17.GetPixel(x:  UnityEngine.Mathf.RoundToInt(f:  val_9.x), y:  UnityEngine.Mathf.RoundToInt(f:  val_9.y));
        val_16 = val_13.r;
        this.newColor.color = new UnityEngine.Color() {r = val_16, g = val_13.g, b = val_13.b, a = val_13.a};
        this.okColorInPalitraButton.defaultColor = new UnityEngine.Color() {r = val_16, g = val_13.g, b = val_13.b, a = val_13.a};
        mem2[0] = val_16;
        mem2[0] = val_13.g;
        mem2[0] = val_13.b;
        mem2[0] = val_13.a;
        val_14 = this.okColorInPalitraButton;
        mem2[0] = val_16;
        mem2[0] = val_13.g;
        mem2[0] = val_13.b;
        mem2[0] = val_13.a;
    }
    public void U_ChangePicker()
    {
        this.万丝丅丕丕丑业专丆 = this.万丝丅丕丕丑业专丆 ^ 1;
        var val_2 = (this.万丝丅丕丕丑业专丆 == false) ? this.extendedPicker : this.mainPicker;
        if(this.canvasTexture == null)
        {
            
        }
    
    }
    private bool 丈丝丅丘丕万丝且丈(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        UnityEngine.Vector3 val_5 = this.canvasTexture.transform.localPosition;
        float val_16 = (float)UnityEngine.Screen.height;
        val_16 = val_16 / 768f;
        UnityEngine.Vector3 val_9 = this.canvasTexture.transform.localPosition;
        float val_17 = (float)this.canvasTexture.width;
        float val_18 = (float)UnityEngine.Screen.width;
        val_17 = val_16 * val_17;
        val_18 = val_18 - val_17;
        float val_19 = (float)this.canvasTexture.height;
        val_19 = val_16 * val_19;
        val_19 = (float)UnityEngine.Screen.height - val_19;
        val_9.y = val_16 * val_9.y;
        val_18 = val_18 * 0.5f;
        val_19 = val_19 * 0.5f;
        val_18 = val_18 + (val_16 * val_5.x);
        val_9.y = val_19 + val_9.y;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_18, y:  val_9.y);
        float val_14 = val_16 * (float)this.canvasTexture.width;
        float val_15 = val_16 * (float)this.canvasTexture.height;
        return false;
    }
    private UnityEngine.Vector2 丛下丅丆且丞一丙丙(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        UnityEngine.Vector3 val_5 = this.canvasTexture.transform.localPosition;
        float val_20 = 768f;
        val_20 = (float)UnityEngine.Screen.height / val_20;
        UnityEngine.Vector3 val_9 = this.canvasTexture.transform.localPosition;
        float val_21 = (float)this.canvasTexture.width;
        float val_22 = (float)UnityEngine.Screen.width;
        val_21 = val_20 * val_21;
        val_22 = val_22 - val_21;
        float val_23 = (float)this.canvasTexture.height;
        val_23 = val_20 * val_23;
        val_23 = (float)UnityEngine.Screen.height - val_23;
        val_9.y = val_20 * val_9.y;
        val_22 = val_22 * 0.5f;
        val_23 = val_23 * 0.5f;
        val_22 = val_22 + (val_20 * val_5.x);
        val_9.y = val_23 + val_9.y;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_22, y:  val_9.y);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        float val_24 = (float)this.canvasTexture.width;
        val_24 = val_20 * val_24;
        val_24 = val_12.x / val_24;
        val_24 = val_24 * (float)this.canvasTexture.isAnchoredHorizontally;
        float val_25 = (float)this.canvasTexture.height;
        val_25 = val_20 * val_25;
        val_25 = val_12.y / val_25;
        val_25 = val_25 * (float)this.canvasTexture.canBeAnchored;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  (float)UnityEngine.Mathf.FloorToInt(f:  val_24), y:  (float)UnityEngine.Mathf.FloorToInt(f:  val_25));
        return new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
    }
    public GetColorInPalitra()
    {
    
    }

}
