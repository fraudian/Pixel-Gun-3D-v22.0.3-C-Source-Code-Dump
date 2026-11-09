using UnityEngine;
public class UICustomTooltip : MonoBehaviour
{
    // Fields
    private static UICustomTooltip 丂丙万丘三丙丒且丛;
    public UnityEngine.Camera uiCamera;
    public UILabel text;
    public UISprite background;
    public float appearSpeed;
    public bool scalingTransitions;
    public bool followMousePosition;
    public UnityEngine.Vector2 backgroundPadding;
    public UnityEngine.Vector2 positionOffset;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private float 丌丘丁丛丝上丁丁丗;
    private float 上丘一丐丌丕丂丒丞;
    private UnityEngine.Vector3 丞丌上丂与业丆丅丅;
    private UnityEngine.Vector3 丕不丆丝丝业七丁丏;
    private UIWidget[] 丟丑丕丟下丆丐世三;
    
    // Methods
    private void Awake()
    {
        UICustomTooltip.丂丙万丘三丙丒且丛 = this;
    }
    private void OnDestroy()
    {
        UICustomTooltip.丂丙万丘三丙丒且丛 = 0;
    }
    private void Start()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丟丑丕丟下丆丐世三 = this.GetComponentsInChildren<UIWidget>();
        UnityEngine.Vector3 val_4 = this.丐一丗丛丕世丘东丁.localPosition;
        this.丞丌上丂与业丆丅丅 = val_4;
        mem[1152921535442408700] = val_4.y;
        mem[1152921535442408704] = val_4.z;
        UnityEngine.Vector3 val_5 = this.丐一丗丛丕世丘东丁.localScale;
        this.丕不丆丝丝业七丁丏 = val_5;
        mem[1152921535442408712] = val_5.y;
        mem[1152921535442408716] = val_5.z;
        if(this.uiCamera == 0)
        {
                this.uiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
        }
        
        this.七丑业上不丐丝丂丁(下下丏一丙不丘丌丞:  0f);
    }
    private void Update()
    {
        float val_10;
        float val_11;
        float val_12;
        val_10 = this.丌丘丁丛丝上丁丁丗;
        if(this.上丘一丐丌丕丂丒丞 != val_10)
        {
                val_11 = UnityEngine.Time.deltaTime;
            val_12 = this.上丘一丐丌丕丂丒丞;
            float val_3 = UnityEngine.Mathf.Lerp(a:  val_12, b:  val_10, t:  val_11 * this.appearSpeed);
            this.上丘一丐丌丕丂丒丞 = val_3;
            if((System.Math.Abs(val_3 - this.丌丘丁丛丝上丁丁丗)) < 0)
        {
                val_12 = this.丌丘丁丛丝上丁丁丗;
            this.上丘一丐丌丕丂丒丞 = this.丌丘丁丛丝上丁丁丗;
        }
        
            val_12 = val_12 * val_12;
            this.七丑业上不丐丝丂丁(下下丏一丙不丘丌丞:  val_12);
            if(this.scalingTransitions != false)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丕不丆丝丝业七丁丏, y = val_10, z = this.上丘一丐丌丕丂丒丞}, d:  0.25f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            float val_11 = this.上丘一丐丌丕丂丒丞;
            val_11 = val_11 * (-0.5f);
            val_11 = val_11 + 1.5f;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_11);
            val_10 = val_7.x;
            val_11 = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = val_7.y, z = val_11}, b:  new UnityEngine.Vector3() {x = val_5.x, y = -val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = -val_5.y, z = val_5.z}, t:  this.上丘一丐丌丕丂丒丞);
            this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_10, y = val_7.y, z = val_11};
        }
        
        }
        
        if(this.followMousePosition == false)
        {
                return;
        }
        
        if(this.上丘一丐丌丕丂丒丞 <= 0f)
        {
                return;
        }
        
        this.七丒下丂丝且丕丌东();
    }
    private void 七丑业上不丐丝丂丁(float 下下丏一丙不丘丌丞)
    {
        if(this.丟丑丕丟下丆丐世三.Length < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            UIWidget val_3 = this.丟丑丕丟下丆丐世三[val_4];
            UnityEngine.Color val_2 = val_3.color;
            val_3.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = 下下丏一丙不丘丌丞};
            val_4 = val_4 + 1;
        }
        while((this.丟丑丕丟下丆丐世三.Length & 4294967295) != val_4);
    
    }
    private void 丒丁丅一下丂专万不(string 三丏丑不业丏不丂丈, UnityEngine.Color 七不丁与丐一丈三世)
    {
        var val_14;
        if(三丏丑不业丏不丂丈 != null)
        {
                if((System.String.IsNullOrEmpty(value:  三丏丑不业丏不丂丈)) == false)
        {
            goto label_2;
        }
        
        }
        
        this.丌丘丁丛丝上丁丁丗 = 0f;
        goto label_3;
        label_2:
        this.丌丘丁丛丝上丁丁丗 = 1f;
        this.text.text = 三丏丑不业丏不丂丈;
        if(this.background != 0)
        {
                UnityEngine.Transform val_3 = this.text.transform;
            UnityEngine.Vector3 val_4 = val_3.localScale;
            UnityEngine.Vector2 val_5 = this.text.printedSize;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            float val_7 = val_4.x * val_6.x;
            float val_8 = val_4.y * val_6.y;
            this.丕不丆丝丝业七丁丏 = val_7;
            mem[1152921535443031432] = val_8;
            mem[1152921535443031436] = val_6.z;
            UnityEngine.Vector2 val_13 = this.backgroundPadding;
            val_6.y = val_8 + val_6.z;
            val_13 = val_13 + val_6.y;
            val_13 = val_7 + val_13;
            this.丕不丆丝丝业七丁丏 = val_13;
            val_6.y = val_6.y + 七不丁与丐一丈三世.a;
            mem[1152921535443031436] = 1065353216;
            val_13 = val_13 + val_6.y;
            val_13 = val_4.y + val_13;
            mem[1152921535443031432] = val_13;
            if(val_3 != null)
        {
                UnityEngine.Vector3 val_9 = val_3.localPosition;
            val_14 = val_9.x;
        }
        else
        {
                UnityEngine.Vector3 val_10 = 0.localPosition;
            val_14 = val_10.x;
        }
        
            UnityEngine.Vector3 val_11 = val_3.localPosition;
            float val_12 = val_4.y + val_4.y;
            val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.background.width = (int)this.丕不丆丝丝业七丁丏;
            this.background.height = (int)this.丕不丆丝丝业七丁丏;
        }
        
        this.七丒下丂丝且丕丌东();
        label_3:
        float val_14 = this.上丘一丐丌丕丂丒丞;
        val_14 = val_14 * val_14;
        this.七丑业上不丐丝丂丁(下下丏一丙不丘丌丞:  val_14);
    }
    private void 七丒下丂丝且丕丌东()
    {
        float val_25;
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        this.丞丌上丂与业丆丅丅 = val_1;
        mem[1152921535443225340] = val_1.y;
        mem[1152921535443225344] = val_1.z;
        if(this.uiCamera != 0)
        {
                float val_25 = (float)UnityEngine.Screen.width;
            val_25 = this.丞丌上丂与业丆丅丅 / val_25;
            this.丞丌上丂与业丆丅丅 = UnityEngine.Mathf.Clamp01(value:  val_25);
            float val_26 = (float)UnityEngine.Screen.height;
            val_26 = this.丞丌上丂与业丆丅丅 / val_26;
            mem[1152921535443225340] = UnityEngine.Mathf.Clamp01(value:  val_26);
            float val_27 = this.uiCamera.orthographicSize;
            UnityEngine.Vector3 val_9 = this.丐一丗丛丕世丘东丁.parent.lossyScale;
            val_27 = val_27 / val_9.y;
            float val_28 = (float)UnityEngine.Screen.height;
            val_28 = val_28 * 0.5f;
            val_27 = val_28 / val_27;
            val_28 = this.丕不丆丝丝业七丁丏 * val_27;
            val_28 = val_28 / (float)UnityEngine.Screen.width;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_28, y:  (val_27 * S10) / (float)UnityEngine.Screen.height);
            float val_29 = val_15.x;
            val_29 = 1f - val_29;
            float val_16 = UnityEngine.Mathf.Min(a:  this.丞丌上丂与业丆丅丅, b:  val_29);
            this.丞丌上丂与业丆丅丅 = val_16;
            float val_17 = UnityEngine.Mathf.Max(a:  val_16, b:  val_15.y);
            mem[1152921535443225340] = val_17;
            UnityEngine.Vector3 val_18 = this.uiCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = val_17, z = val_27});
            this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_19 = this.丐一丗丛丕世丘东丁.localPosition;
            val_25 = val_19.z;
            val_19.x = val_19.x + this.positionOffset;
            val_19.y = val_19.y + (float)UnityEngine.Screen.height;
            this.丞丌上丂与业丆丅丅 = (float)(int)val_19.x;
            mem[1152921535443225340] = (float)(int)val_19.y;
            mem[1152921535443225344] = val_25;
            this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = (float)(int)val_19.x, y = (float)(int)val_19.y, z = val_25};
            return;
        }
        
        if((this.丞丌上丂与业丆丅丅 + this.丕不丆丝丝业七丁丏) > (float)UnityEngine.Screen.width)
        {
                UnityEngine.Vector3 val_30 = this.丕不丆丝丝业七丁丏;
            float val_31 = (float)UnityEngine.Screen.width;
            val_30 = val_31 - val_30;
            this.丞丌上丂与业丆丅丅 = val_30;
        }
        
        val_31 = val_31 - val_30;
        if(val_31 < 0)
        {
                mem[1152921535443225340] = val_30;
        }
        
        val_25 = this.丞丌上丂与业丆丅丅;
        float val_32 = (float)UnityEngine.Screen.width;
        val_32 = val_32 * 0.5f;
        val_32 = val_25 - val_32;
        this.丞丌上丂与业丆丅丅 = val_32;
        float val_33 = (float)UnityEngine.Screen.height;
        val_33 = val_33 * 0.5f;
        val_33 = S10 - val_33;
        mem[1152921535443225340] = val_33;
    }
    public static void Hide()
    {
        UICustomTooltip val_2 = UICustomTooltip.丂丙万丘三丙丒且丛;
        if(val_2 == 0)
        {
                return;
        }
        
        val_2 = UICustomTooltip.丂丙万丘三丙丒且丛;
        UICustomTooltip.丂丙万丘三丙丒且丛.丌丘丁丛丝上丁丁丗 = 0f;
    }
    public static void Show(string 丟专上丏专下丞丄丄)
    {
        if(UICustomTooltip.丂丙万丘三丙丒且丛 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UICustomTooltip.丂丙万丘三丙丒且丛.丒丁丅一下丂专万不(三丏丑不业丏不丂丈:  丟专上丏专下丞丄丄, 七不丁与丐一丈三世:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public static void Show(string 丟专上丏专下丞丄丄, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(UICustomTooltip.丂丙万丘三丙丒且丛 == 0)
        {
                return;
        }
        
        UICustomTooltip.丂丙万丘三丙丒且丛.丒丁丅一下丂专万不(三丏丑不业丏不丂丈:  丟专上丏专下丞丄丄, 七不丁与丐一丈三世:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    public UICustomTooltip()
    {
        this.appearSpeed = 10f;
        this.scalingTransitions = true;
        this.followMousePosition = true;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  4f, y:  4f);
        this.backgroundPadding = val_1.x;
        mem[1152921535443722460] = val_1.y;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  30f);
        this.positionOffset = val_2.x;
        mem[1152921535443722468] = val_2.y;
    }

}
