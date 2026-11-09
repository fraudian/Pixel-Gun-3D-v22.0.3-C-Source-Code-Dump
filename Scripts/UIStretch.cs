using UnityEngine;
public class UIStretch : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera uiCamera;
    public UnityEngine.GameObject container;
    public UIStretch.丄丏东专与世三丂一 style;
    public bool runOnlyOnce;
    public UnityEngine.Vector2 relativeSize;
    public UnityEngine.Vector2 initialSize;
    public UnityEngine.Vector2 borderPadding;
    private UIWidget widgetContainer;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UIWidget 丆不下丄丄且丞一丈;
    private UISprite 丂丑丌丂丝专丗丆东;
    private UIPanel 与业丌丄且丁丛与丁;
    private UIRoot 丝丘下与丛丟丁东丏;
    private UnityEngine.Animation 三上下丁丅丅下上丑;
    private UnityEngine.Rect 不丝下丆丐丙丘东丛;
    private bool 不世丌丝且三上丏丌;
    
    // Methods
    private void Awake()
    {
        var val_9;
        万一丆与下丈丐丌丙 val_10;
        this.三上下丁丅丅下上丑 = this.GetComponent<UnityEngine.Animation>();
        this.不丝下丆丐丙丘东丛 = 0;
        mem[1152921535361650232] = 0;
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
        this.丂丑丌丂丝专丗丆东 = this.GetComponent<UISprite>();
        this.与业丌丄且丁丛与丁 = this.GetComponent<UIPanel>();
        val_9 = null;
        val_9 = null;
        if(((System.Delegate.Combine(a:  UICamera.onScreenResize, b:  new UICamera.万一丆与下丈丐丌丙(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIStretch::专丂上万丗丗丘丙丛()))) != null) && (null != null))
        {
                val_10 = 0;
        }
        
        UICamera.onScreenResize = val_10;
    }
    private void OnDestroy()
    {
        var val_4;
        万一丆与下丈丐丌丙 val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  UICamera.onScreenResize, value:  new UICamera.万一丆与下丈丐丌丙(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIStretch::专丂上万丗丗丘丙丛()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        UICamera.onScreenResize = val_5;
    }
    private void 专丂上万丗丗丘丙丛()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        if(this.runOnlyOnce == false)
        {
                return;
        }
        
        this.Update();
    }
    private void Start()
    {
        if(this.container == 0)
        {
                if(this.widgetContainer != 0)
        {
                this.container = this.widgetContainer.gameObject;
            this.widgetContainer = 0;
        }
        
        }
        
        if(this.uiCamera == 0)
        {
                this.uiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
        }
        
        this.丝丘下与丛丟丁东丏 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        this.Update();
        this.不世丌丝且三上丏丌 = true;
    }
    private void Update()
    {
        float val_13;
        UnityEngine.Object val_71;
        UnityEngine.Object val_72;
        float val_73;
        float val_74;
        float val_75;
        float val_76;
        float val_77;
        UnityEngine.Vector2 val_79;
        float val_80;
        float val_85;
        int val_86;
        UISprite val_87;
        float val_88;
        float val_89;
        float val_90;
        if(this.三上下丁丅丅下上丑 != 0)
        {
                if(this.三上下丁丅丅下上丑.isPlaying == true)
        {
                return;
        }
        
        }
        
        if(this.style == 0)
        {
                return;
        }
        
        val_71 = 0;
        if(this.container != 0)
        {
                val_71 = this.container.GetComponent<UIWidget>();
        }
        
        if(this.container != 0)
        {
            goto label_13;
        }
        
        val_72 = 0;
        if(val_71 == 0)
        {
            goto label_16;
        }
        
        label_13:
        val_72 = this.container.GetComponent<UIPanel>();
        label_16:
        if(val_71 == 0)
        {
            goto label_20;
        }
        
        UnityEngine.Bounds val_11 = val_71.CalculateBounds(丟上与丝下丁丈丕丅:  this.transform.parent);
        this.不丝下丆丐丙丘东丛.x = val_13;
        label_118:
        label_38:
        label_119:
        label_109:
        val_73 = V1.16B;
        val_74 = 1f;
        val_75 = V1.16B;
        if((1f != val_74) && (val_75 > 1f))
        {
                float val_57 = (float)this.丝丘下与丛丟丁东丏.activeHeight;
            val_57 = val_57 / val_75;
            val_73 = val_73 * val_57;
            val_75 = val_75 * val_57;
        }
        
        if(this.丆不下丄丄且丞一丈 == 0)
        {
            goto label_28;
        }
        
        int val_16 = this.丆不下丄丄且丞一丈.width;
        val_76 = (float)this.丆不下丄丄且丞一丈.height;
        val_13 = 0;
        val_77 = 0f;
        goto label_31;
        label_20:
        if(val_72 == 0)
        {
            goto label_34;
        }
        
        if(val_72.clipping == 0)
        {
            goto label_36;
        }
        
        UnityEngine.Vector4 val_20 = val_72.finalClipRegion;
        val_20.x = val_20.x - (val_20.z * 0.5f);
        this.不丝下丆丐丙丘东丛.x = val_20.x;
        float val_22 = val_20.w * 0.5f;
        val_22 = val_20.y - val_22;
        goto label_38;
        label_28:
        UnityEngine.Vector3 val_23 = this.丐一丗丛丕世丘东丁.localScale;
        val_77 = val_23.y;
        label_31:
        if((this.style - 2) > 4)
        {
            goto label_40;
        }
        
        var val_58 = 106066112 + ((this.style - 2)) << 2;
        val_58 = val_58 + 106066112;
        goto (106066112 + ((this.style - 2)) << 2 + 106066112);
        label_34:
        if(this.container == 0)
        {
            goto label_44;
        }
        
        UnityEngine.Transform val_27 = this.transform.parent;
        UnityEngine.Transform val_29 = this.container.transform;
        if(val_27 == 0)
        {
            goto label_49;
        }
        
        UnityEngine.Bounds val_30 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  val_27, 三丏丑不业丏不丂丈:  val_29);
        goto label_50;
        label_40:
        val_79 = val_73 * this.relativeSize;
        val_80 = val_79;
        if(this.style != 1)
        {
                val_80 = val_79;
            val_77 = val_75 * val_23.y;
        }
        
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
            goto label_58;
        }
        
        if(this.丂丑丌丂丝专丗丆东.mAtlas != 0)
        {
                val_74 = this.丂丑丌丂丝专丗丆东.mAtlas.pixelSize;
        }
        
        if(this.style == 2)
        {
            goto label_65;
        }
        
        UnityEngine.Vector2 val_59 = this.borderPadding;
        val_59 = val_74 * val_59;
         =  - val_59;
        val_85 = ;
        val_86 = UnityEngine.Mathf.RoundToInt(f:  val_85);
        this.丂丑丌丂丝专丗丆东.width = val_86;
        if(this.style == 1)
        {
            goto label_100;
        }
        
        label_65:
        val_87 = this.丂丑丌丂丝专丗丆东;
        val_85 =  - (val_74 * val_23.z);
        goto label_72;
        label_58:
        if(this.丆不下丄丄且丞一丈 == 0)
        {
            goto label_75;
        }
        
        if(this.style == 2)
        {
            goto label_76;
        }
        
        val_85 =  - this.borderPadding;
        val_86 = UnityEngine.Mathf.RoundToInt(f:  val_85);
        this.丆不下丄丄且丞一丈.width = val_86;
        if(this.style == 1)
        {
            goto label_100;
        }
        
        label_76:
        val_87 = this.丆不下丄丄且丞一丈;
        val_85 =  - ;
        label_72:
        val_86 = UnityEngine.Mathf.RoundToInt(f:  val_85);
        val_87.height = val_86;
        label_100:
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
        label_112:
        UnityEngine.Vector3 val_41 = this.丐一丗丛丕世丘东丁.localScale;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, rhs:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z})) != false)
        {
                this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z};
        }
        
        if(this.runOnlyOnce == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.enabled = false;
        return;
        label_75:
        if(this.与业丌丄且丁丛与丁 == 0)
        {
            goto label_95;
        }
        
        UnityEngine.Vector4 val_45 = this.与业丌丄且丁丛与丁.baseClipRegion;
        val_88 = val_45.z;
        val_89 = val_45.w;
        if(this.style == 2)
        {
            goto label_97;
        }
        
        val_88 =  - this.borderPadding;
        if(this.style == 1)
        {
            goto label_98;
        }
        
        label_97:
        val_89 =  - this.borderPadding;
        label_98:
        this.与业丌丄且丁丛与丁.baseClipRegion = new UnityEngine.Vector4() {x = val_45.x, y = val_45.y, z = val_88, w = val_89};
        goto label_100;
        label_44:
        if(this.uiCamera == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_47 = this.uiCamera.pixelRect;
        this.不丝下丆丐丙丘东丛 = val_47;
        mem[1152921535362434004] = val_47.m_YMin;
        mem[1152921535362434008] = val_47.m_Width;
        mem[1152921535362434012] = val_47.m_Height;
        if(this.丝丘下与丛丟丁东丏 == 0)
        {
            goto label_119;
        }
        
        float val_49 = this.丝丘下与丛丟丁东丏.pixelSizeAdjustment;
        goto label_109;
        label_95:
        if(this.style == 2)
        {
            goto label_110;
        }
        
         =  - this.borderPadding;
        if(this.style == 1)
        {
            goto label_112;
        }
        
        label_110:
         =  - this.borderPadding;
        goto label_112;
        label_36:
        if(this.丝丘下与丛丟丁东丏 == 0)
        {
            goto label_115;
        }
        
        float val_60 = (float)this.丝丘下与丛丟丁东丏.activeHeight;
        val_60 = val_60 / (float)UnityEngine.Screen.height;
        val_90 = val_60 * 0.5f;
        goto label_117;
        label_49:
        UnityEngine.Bounds val_53 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_29);
        label_50:
        this.不丝下丆丐丙丘东丛.x = 0f;
        goto label_118;
        label_115:
        val_90 = 0.5f;
        label_117:
        float val_61 = (float)-UnityEngine.Screen.width;
        val_61 = val_90 * val_61;
        float val_62 = (float)-UnityEngine.Screen.height;
        val_62 = val_90 * val_62;
        float val_56 = this.不丝下丆丐丙丘东丛.x;
        goto label_119;
    }
    public UIStretch()
    {
        this.runOnlyOnce = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
        this.relativeSize = val_1;
        mem[1152921535362762916] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
        this.initialSize = val_2;
        mem[1152921535362762924] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.borderPadding = val_3;
        mem[1152921535362762932] = val_3.y;
    }

}
