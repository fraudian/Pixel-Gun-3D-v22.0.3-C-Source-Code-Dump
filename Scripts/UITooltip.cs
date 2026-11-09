using UnityEngine;
public class UITooltip : MonoBehaviour
{
    // Fields
    protected static UITooltip 丂丙万丘三丙丒且丛;
    public UnityEngine.Camera uiCamera;
    public UILabel text;
    public UnityEngine.GameObject tooltipRoot;
    public UISprite background;
    public float appearSpeed;
    public bool scalingTransitions;
    protected UnityEngine.GameObject 丘丘丕丄丟一丞与且;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected float 丌丘丁丛丝上丁丁丗;
    protected float 上丘一丐丌丕丂丒丞;
    protected UnityEngine.Vector3 丞丌上丂与业丆丅丅;
    protected UnityEngine.Vector3 丕不丆丝丝业七丁丏;
    protected UIWidget[] 丟丑丕丟下丆丐世三;
    
    // Properties
    public static bool 不与万丌一丈下丑丈 { get; }
    
    // Methods
    public static bool get_isVisible()
    {
        UITooltip val_3;
        var val_4;
        val_3 = UITooltip.丂丙万丘三丙丒且丛;
        if(val_3 != 0)
        {
                val_3 = UITooltip.丂丙万丘三丙丒且丛;
            var val_2 = (UITooltip.丂丙万丘三丙丒且丛.丌丘丁丛丝上丁丁丗 == 1f) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private void Awake()
    {
        UITooltip.丂丙万丘三丙丒且丛 = this;
    }
    private void OnDestroy()
    {
        UITooltip.丂丙万丘三丙丒且丛 = 0;
    }
    protected virtual void Start()
    {
        UnityEngine.Object val_8;
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丟丑丕丟下丆丐世三 = this.GetComponentsInChildren<UIWidget>();
        UnityEngine.Vector3 val_3 = this.丐一丗丛丕世丘东丁.localPosition;
        this.丞丌上丂与业丆丅丅 = val_3;
        mem[1152921535371034508] = val_3.y;
        mem[1152921535371034512] = val_3.z;
        val_8 = 0;
        if(this.uiCamera == val_8)
        {
                val_8 = 0;
            this.uiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
        }
    
    }
    protected virtual void Update()
    {
        float val_12;
        float val_13;
        if(this.丘丘丕丄丟一丞与且 != UICamera.tooltipObject)
        {
                val_12 = 0f;
            this.丘丘丕丄丟一丞与且 = 0;
            this.丌丘丁丛丝上丁丁丗 = 0f;
        }
        else
        {
                val_12 = this.丌丘丁丛丝上丁丁丗;
        }
        
        if(this.上丘一丐丌丕丂丒丞 == val_12)
        {
                return;
        }
        
        val_13 = this.上丘一丐丌丕丂丒丞;
        float val_5 = UnityEngine.Mathf.Lerp(a:  val_13, b:  val_12, t:  RealTime.deltaTime * this.appearSpeed);
        this.上丘一丐丌丕丂丒丞 = val_5;
        if((System.Math.Abs(val_5 - this.丌丘丁丛丝上丁丁丗)) < 0)
        {
                val_13 = this.丌丘丁丛丝上丁丁丗;
            this.上丘一丐丌丕丂丒丞 = this.丌丘丁丛丝上丁丁丗;
        }
        
        val_13 = val_13 * val_13;
        if(this.scalingTransitions == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丕不丆丝丝业七丁丏, y = val_12, z = this.上丘一丐丌丕丂丒丞}, d:  0.25f);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        float val_13 = this.上丘一丐丌丕丂丒丞;
        val_13 = val_13 * (-0.5f);
        val_13 = val_13 + 1.5f;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  val_13);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = val_9.y, z = val_13}, b:  new UnityEngine.Vector3() {x = val_7.x, y = -val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = -val_7.y, z = val_7.z}, t:  this.上丘一丐丌丕丂丒丞);
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    protected virtual void 七丑业上不丐丝丂丁(float 下下丏一丙不丘丌丞)
    {
        UnityEngine.Color val_2;
        if(this.丟丑丕丟下丆丐世三.Length < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            UIWidget val_2 = this.丟丑丕丟下丆丐世三[val_3];
            if(val_2 != null)
        {
                val_2 = this.丟丑丕丟下丆丐世三[0x0][0].mColor;
        }
        else
        {
                val_2 = this.丟丑丕丟下丆丐世三[0x0][0].mColor;
        }
        
            val_2.color = new UnityEngine.Color() {r = val_2, g = V10.16B, b = V11.16B, a = 下下丏一丙不丘丌丞};
            val_3 = val_3 + 1;
        }
        while((this.丟丑丕丟下丆丐世三.Length & 4294967295) != val_3);
    
    }
    protected virtual void 丒丁丅一下丂专万不(string 丟下丞丈丗且上丏丂)
    {
        var val_36;
        float val_48;
        var val_49;
        float val_50;
        long val_51;
        float val_52;
        var val_53;
        long val_55;
        float val_56;
        var val_57;
        if(this.text != 0)
        {
                if((System.String.IsNullOrEmpty(value:  丟下丞丈丗且上丏丂)) == false)
        {
            goto label_4;
        }
        
        }
        
        this.丘丘丕丄丟一丞与且 = 0;
        this.丌丘丁丛丝上丁丁丗 = 0f;
        return;
        label_4:
        this.丌丘丁丛丝上丁丁丗 = 1f;
        this.丘丘丕丄丟一丞与且 = UICamera.tooltipObject;
        this.text.text = 丟下丞丈丗且上丏丂;
        UnityEngine.Vector2 val_4 = UICamera.lastEventPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.丞丌上丂与业丆丅丅 = val_5;
        mem[1152921535371706380] = val_5.y;
        mem[1152921535371706384] = val_5.z;
        UnityEngine.Transform val_6 = this.text.transform;
        if(val_6 != null)
        {
                UnityEngine.Vector3 val_7 = val_6.localPosition;
            val_48 = val_7.x;
            val_49 = val_7.y;
        }
        else
        {
                UnityEngine.Vector3 val_8 = 0.localPosition;
            val_48 = val_8.x;
            val_49 = val_8.y;
        }
        
        UnityEngine.Vector3 val_9 = val_6.localScale;
        UnityEngine.Vector2 val_10 = this.text.printedSize;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_11.x = val_9.x * val_11.x;
        val_50 = val_9.y * val_11.y;
        this.丕不丆丝丝业七丁丏 = val_11.x;
        mem[1152921535371706392] = val_50;
        mem[1152921535371706396] = val_11.z;
        if(this.background != 0)
        {
                val_11.z = val_11.x + val_11.z;
            val_11.x = val_48 - val_11.x;
            val_50 = (-val_49) - val_50;
            val_11.x = val_11.x + val_11.x;
            val_50 = val_50 + val_50;
            val_11.x = val_11.z + val_11.x;
            val_50 = (val_50 + S3) + val_50;
            float val_14 = this.丕不丆丝丝业七丁丏 + val_11.x;
            this.丕不丆丝丝业七丁丏 = val_14;
            mem[1152921535371706392] = S5 + val_50;
            this.background.width = UnityEngine.Mathf.RoundToInt(f:  val_14);
            this.background.height = UnityEngine.Mathf.RoundToInt(f:  val_14);
        }
        
        if(this.uiCamera == 0)
        {
            goto label_24;
        }
        
        float val_46 = (float)UnityEngine.Screen.width;
        val_46 = this.丞丌上丂与业丆丅丅 / val_46;
        this.丞丌上丂与业丆丅丅 = UnityEngine.Mathf.Clamp01(value:  val_46);
        float val_47 = (float)UnityEngine.Screen.height;
        val_47 = this.丞丌上丂与业丆丅丅 / val_47;
        mem[1152921535371706380] = UnityEngine.Mathf.Clamp01(value:  val_47);
        float val_48 = this.uiCamera.orthographicSize;
        UnityEngine.Vector3 val_25 = this.丐一丗丛丕世丘东丁.parent.lossyScale;
        val_48 = val_48 / val_25.y;
        float val_49 = (float)UnityEngine.Screen.height;
        val_49 = val_49 * 0.5f;
        val_48 = val_49 / val_48;
        val_49 = this.丕不丆丝丝业七丁丏 * val_48;
        val_49 = val_49 / (float)UnityEngine.Screen.width;
        UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_49, y:  (val_48 * val_9.x) / (float)UnityEngine.Screen.height);
        float val_50 = val_31.x;
        val_50 = 1f - val_50;
        float val_32 = UnityEngine.Mathf.Min(a:  this.丞丌上丂与业丆丅丅, b:  val_50);
        this.丞丌上丂与业丆丅丅 = val_32;
        float val_33 = UnityEngine.Mathf.Max(a:  val_32, b:  val_31.y);
        mem[1152921535371706380] = val_33;
        UnityEngine.Vector3 val_34 = this.uiCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = val_33, z = val_48});
        this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        UnityEngine.Vector3 val_35 = this.丐一丗丛丕世丘东丁.localPosition;
        this.丞丌上丂与业丆丅丅 = val_35;
        mem[1152921535371706380] = val_35.y;
        mem[1152921535371706384] = val_35.z;
        if(val_35.x >= 0f)
        {
            goto label_33;
        }
        
        if((double)val_35.x != (-0.5))
        {
            goto label_34;
        }
        
        val_51 = (long)val_36;
        val_52 = (float)val_36;
        val_53 = val_52 + (-1f);
        goto label_35;
        label_24:
        if((this.丞丌上丂与业丆丅丅 + this.丕不丆丝丝业七丁丏) > (float)UnityEngine.Screen.width)
        {
                UnityEngine.Vector3 val_51 = this.丕不丆丝丝业七丁丏;
            float val_52 = (float)UnityEngine.Screen.width;
            val_51 = val_52 - val_51;
            this.丞丌上丂与业丆丅丅 = val_51;
        }
        
        val_52 = val_52 - val_51;
        if(val_52 < 0)
        {
                mem[1152921535371706380] = val_51;
        }
        
        float val_53 = (float)UnityEngine.Screen.width;
        val_53 = val_53 * 0.5f;
        val_53 = this.丞丌上丂与业丆丅丅 - val_53;
        this.丞丌上丂与业丆丅丅 = val_53;
        float val_54 = (float)UnityEngine.Screen.height;
        val_54 = val_54 * 0.5f;
        val_54 = val_9.x - val_54;
        mem[1152921535371706380] = val_54;
        goto label_38;
        label_33:
        if((double)val_35.x != 0.5)
        {
            goto label_39;
        }
        
        val_51 = (long)val_36;
        val_52 = (float)val_36;
        val_53 = val_52 + 1f;
        label_35:
        val_52 = ((val_51 & 1) != 0) ? (val_52) : (val_53);
        goto label_41;
        label_34:
        float val_55 = -0.5f;
        val_55 = val_35.x + val_55;
        goto label_41;
        label_39:
        label_41:
        this.丞丌上丂与业丆丅丅 = val_35.x + 0.5f;
        if(val_35.x >= 0f)
        {
            goto label_42;
        }
        
        if((double)val_35.x != (-0.5))
        {
            goto label_43;
        }
        
        val_55 = (long)val_36;
        val_56 = (float)val_36;
        val_57 = val_56 + (-1f);
        goto label_44;
        label_42:
        if((double)val_35.x != 0.5)
        {
            goto label_45;
        }
        
        val_55 = (long)val_36;
        val_56 = (float)val_36;
        val_57 = val_56 + 1f;
        label_44:
        var val_43 = ((val_55 & 1) != 0) ? (val_56) : (val_57);
        goto label_47;
        label_43:
        float val_56 = -0.5f;
        val_56 = val_35.x + val_56;
        goto label_47;
        label_45:
        float val_44 = val_35.x + 0.5f;
        label_47:
        mem[1152921535371706380] = val_35.x;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = val_35.x, z = val_34.y};
        label_38:
        if(this.tooltipRoot != 0)
        {
                this.tooltipRoot.BroadcastMessage(methodName:  "UpdateAnchors");
            return;
        }
        
        this.text.BroadcastMessage(methodName:  "UpdateAnchors");
    }
    public static void ShowText(string 丕丗丘丑丛与丑业丒)
    {
        if(UITooltip.丂丙万丘三丙丒且丛 == 0)
        {
                return;
        }
        
        丕丗丘丑丛与丑业丒 = ???;
        goto typeof(UITooltip).__il2cppRuntimeField_198;
    }
    public static void Show(string 丕丗丘丑丛与丑业丒)
    {
        if(UITooltip.丂丙万丘三丙丒且丛 == 0)
        {
                return;
        }
        
        丕丗丘丑丛与丑业丒 = ???;
        goto typeof(UITooltip).__il2cppRuntimeField_198;
    }
    public static void Hide()
    {
        UITooltip val_2;
        var val_3;
        val_2 = UITooltip.丂丙万丘三丙丒且丛;
        if(val_2 == 0)
        {
                return;
        }
        
        val_3 = null;
        if(UITooltip.丂丙万丘三丙丒且丛 == null)
        {
                val_3 = null;
        }
        
        UITooltip.丂丙万丘三丙丒且丛.丘丘丕丄丟一丞与且 = 0;
        val_2 = UITooltip.丂丙万丘三丙丒且丛;
        UITooltip.丂丙万丘三丙丒且丛.丌丘丁丛丝上丁丁丗 = 0f;
    }
    public UITooltip()
    {
        this.appearSpeed = 10f;
        this.scalingTransitions = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丕不丆丝丝业七丁丏 = val_1;
        mem[1152921535372260888] = val_1.y;
        mem[1152921535372260892] = val_1.z;
    }

}
