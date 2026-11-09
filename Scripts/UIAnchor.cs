using UnityEngine;
public class UIAnchor : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera uiCamera;
    public UnityEngine.GameObject container;
    public UIAnchor.与丆上丈丕丗丅东丏 side;
    public bool runOnlyOnce;
    public UnityEngine.Vector2 relativeOffset;
    public UnityEngine.Vector2 pixelOffset;
    private UIWidget widgetContainer;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UnityEngine.Animation 三上下丁丅丅下上丑;
    private UnityEngine.Rect 不丝下丆丐丙丘东丛;
    private UIRoot 丝丘下与丛丟丁东丏;
    private bool 不世丌丝且三上丏丌;
    
    // Methods
    private void Awake()
    {
        var val_6;
        万一丆与下丈丐丌丙 val_7;
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.三上下丁丅丅下上丑 = this.GetComponent<UnityEngine.Animation>();
        val_6 = null;
        val_6 = null;
        if(((System.Delegate.Combine(a:  UICamera.onScreenResize, b:  new UICamera.万一丆与下丈丐丌丙(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIAnchor::专丂上万丗丗丘丙丛()))) != null) && (null != null))
        {
                val_7 = 0;
        }
        
        UICamera.onScreenResize = val_7;
    }
    private void OnDestroy()
    {
        var val_4;
        万一丆与下丈丐丌丙 val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  UICamera.onScreenResize, value:  new UICamera.万一丆与下丈丐丌丙(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIAnchor::专丂上万丗丗丘丙丛()))) != null) && (null != null))
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
        var val_15;
        if(this.container == 0)
        {
                val_15 = 1;
        }
        else
        {
                if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_15 = 0;
        }
        else
        {
                val_15 = UnityEngine.Application.isPlaying;
        }
        
        }
        
        if(this.container == 0)
        {
                if(this.widgetContainer != 0)
        {
                this.container = this.widgetContainer.gameObject;
            this.widgetContainer = 0;
        }
        
        }
        
        this.丝丘下与丛丟丁东丏 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if((val_15 & (UnityEngine.Object.op_Equality(x:  this.uiCamera, y:  0))) != false)
        {
                this.uiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
        }
        
        this.Update();
        this.不世丌丝且三上丏丌 = true;
    }
    private void Update()
    {
        float val_14;
        UnityEngine.Object val_85;
        UnityEngine.Object val_86;
        UnityEngine.Rect val_87;
        float val_91;
        UnityEngine.Camera val_92;
        var val_93;
        float val_94;
        var val_95;
        float val_97;
        double val_98;
        float val_99;
        float val_100;
        var val_101;
        float val_102;
        var val_103;
        float val_104;
        double val_107;
        var val_108;
        float val_109;
        float val_110;
        float val_111;
        float val_112;
        float val_113;
        UnityEngine.Object val_114;
        var val_115;
        var val_116;
        float val_117;
        float val_118;
        float val_119;
        float val_120;
        与丆上丈丕丗丅东丏 val_121;
        var val_122;
        var val_123;
        var val_124;
        var val_125;
        float val_126;
        float val_127;
        float val_128;
        if(this.三上下丁丅丅下上丑 != 0)
        {
                if(this.三上下丁丅丅下上丑.enabled != false)
        {
                if(this.三上下丁丅丅下上丑.isPlaying == true)
        {
                return;
        }
        
        }
        
        }
        
        val_85 = 0;
        if(this.container != 0)
        {
                val_85 = this.container.GetComponent<UIWidget>();
        }
        
        if(this.container != 0)
        {
            goto label_14;
        }
        
        val_86 = 0;
        if(val_85 == 0)
        {
            goto label_17;
        }
        
        label_14:
        val_86 = this.container.GetComponent<UIPanel>();
        label_17:
        if(val_85 == 0)
        {
            goto label_21;
        }
        
        UnityEngine.Bounds val_12 = val_85.CalculateBounds(丟上与丝下丁丈丕丅:  this.container.transform.parent);
        val_87 = this.不丝下丆丐丙丘东丛;
        val_87.x = val_14;
        goto label_25;
        label_21:
        if(val_86 == 0)
        {
            goto label_28;
        }
        
        if(val_86.clipping == 0)
        {
            goto label_30;
        }
        
        UnityEngine.Vector4 val_17 = val_86.finalClipRegion;
        val_17.x = val_17.x - (val_17.z * 0.5f);
        this.不丝下丆丐丙丘东丛.x = val_17.x;
        float val_19 = val_17.w * 0.5f;
        val_19 = val_17.y - val_19;
        val_91 = val_17.w;
        goto label_32;
        label_28:
        if(this.container == 0)
        {
            goto label_35;
        }
        
        UnityEngine.Transform val_21 = this.container.transform;
        UnityEngine.Transform val_22 = val_21.parent;
        if(val_22 == 0)
        {
            goto label_40;
        }
        
        UnityEngine.Bounds val_24 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  val_22, 三丏丑不业丏不丂丈:  val_21);
        goto label_41;
        label_35:
        val_92 = this.uiCamera;
        if(val_92 == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_26 = this.uiCamera.pixelRect;
        val_93 = 1;
        this.不丝下丆丐丙丘东丛 = val_26;
        mem[1152921535284505468] = val_26.m_YMin;
        mem[1152921535284505472] = val_26.m_Width;
        mem[1152921535284505476] = val_26.m_Height;
        goto label_46;
        label_30:
        if(this.丝丘下与丛丟丁东丏 == 0)
        {
            goto label_49;
        }
        
        float val_83 = (float)this.丝丘下与丛丟丁东丏.activeHeight;
        val_83 = val_83 / (float)UnityEngine.Screen.height;
        val_94 = val_83 * 0.5f;
        goto label_51;
        label_40:
        UnityEngine.Bounds val_30 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_21);
        label_41:
        val_87 = this.不丝下丆丐丙丘东丛;
        val_87.x = val_14;
        label_25:
        val_91 = V1.16B;
        label_32:
        label_107:
        val_93 = 0;
        label_46:
        if(this.uiCamera == 0)
        {
                if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                float val_84 = val_91;
            val_95 = null;
            val_95 = null;
            val_84 = val_84 / IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            float val_85 = -0.5f;
            val_85 = (val_84 - IphoneXCameraScaler.且下丒丘丙丒丈丏万) * val_85;
            val_91 = this.不丝下丆丐丙丘东丛.x + val_85;
            this.不丝下丆丐丙丘东丛.x = val_91;
        }
        
        }
        
        val_92 = this.不丝下丆丐丙丘东丛;
        float val_35 = val_92.x;
        val_35 = val_35 + val_35;
        float val_36 = val_35 * 0.5f;
        val_35 = val_35 + val_35;
        val_97 = val_35 * 0.5f;
        if((this.side - 3) > 5)
        {
            goto label_60;
        }
        
        var val_86 = 106047196 + ((this.side - 3)) << 2;
        val_86 = val_86 + 106047196;
        goto (106047196 + ((this.side - 3)) << 2 + 106047196);
        label_60:
        float val_38 = val_92.x;
        与丆上丈丕丗丅东丏 val_87 = this.side;
        if(val_87 > 8)
        {
            goto label_64;
        }
        
        val_87 = 1 << val_87;
        if((val_87 & 290) != 0)
        {
            goto label_63;
        }
        
        val_87 = val_87 & 28;
        if(val_87 == 0)
        {
            goto label_64;
        }
        
        goto label_65;
        label_64:
        label_65:
        val_97 = val_38;
        label_63:
        float val_89 = val_38;
        UnityEngine.Vector2 val_88 = this.relativeOffset;
        val_88 = val_89 * val_88;
        val_88 = this.pixelOffset + val_88;
        val_89 = val_38 + val_88;
        val_38 = val_38 * val_88;
        val_38 = this.pixelOffset + val_38;
        val_100 = val_97 + val_38;
        if(val_93 == 0)
        {
            goto label_66;
        }
        
        if(this.uiCamera.orthographic == false)
        {
            goto label_68;
        }
        
        if(val_89 >= 0f)
        {
            goto label_71;
        }
        
        if((double)val_89 != (-0.5))
        {
            goto label_72;
        }
        
        val_101 = val_14;
        val_102 = -1f;
        goto label_73;
        label_66:
        if(val_89 >= 0f)
        {
            goto label_76;
        }
        
        if((double)val_89 != (-0.5))
        {
            goto label_77;
        }
        
        val_103 = val_14;
        val_104 = -1f;
        goto label_78;
        label_76:
        if((double)val_89 != 0.5)
        {
            goto label_79;
        }
        
        val_103 = val_14;
        val_104 = 1f;
        label_78:
        float val_90 = (float)val_103;
        val_104 = val_90 + val_104;
        val_90 = (((long)val_103 & 1) != 0) ? (val_90) : (val_104);
        goto label_83;
        label_71:
        if((double)val_89 != 0.5)
        {
            goto label_81;
        }
        
        val_101 = val_14;
        val_102 = 1f;
        label_73:
        float val_91 = (float)val_101;
        val_102 = val_91 + val_102;
        val_91 = (((long)val_101 & 1) != 0) ? (val_91) : (val_102);
        goto label_108;
        label_77:
        float val_92 = -0.5f;
        val_92 = val_89 + val_92;
        goto label_83;
        label_79:
        float val_41 = val_89 + 0.5f;
        label_83:
        if(val_100 >= 0f)
        {
            goto label_84;
        }
        
        val_107 = -0.5;
        if((double)val_100 != val_107)
        {
            goto label_85;
        }
        
        val_108 = val_14;
        val_109 = -1f;
        goto label_86;
        label_84:
        val_107 = 0.5;
        if((double)val_100 != val_107)
        {
            goto label_87;
        }
        
        val_108 = val_14;
        val_109 = 1f;
        label_86:
        float val_93 = (float)val_108;
        val_107 = val_93 + val_109;
        val_93 = (((long)val_108 & 1) != 0) ? (val_93) : (val_107);
        goto label_89;
        label_85:
        float val_94 = -0.5f;
        val_94 = val_100 + val_94;
        goto label_89;
        label_87:
        float val_42 = val_100 + 0.5f;
        label_89:
        if(val_86 == 0)
        {
            goto label_92;
        }
        
        val_111 = val_41;
        val_112 = val_42;
        val_113 = 0f;
        val_114 = val_86.cachedTransform;
        if(val_114 != null)
        {
            goto label_95;
        }
        
        goto label_95;
        label_92:
        if(this.container == 0)
        {
            goto label_103;
        }
        
        val_114 = this.container.transform.parent;
        if(val_114 == 0)
        {
            goto label_103;
        }
        
        val_111 = val_41;
        val_112 = val_42;
        val_113 = 0f;
        label_95:
        val_110 = val_111;
        val_107 = val_112;
        val_99 = val_113;
        UnityEngine.Vector3 val_49 = val_114.TransformPoint(position:  new UnityEngine.Vector3() {x = val_110, y = val_107, z = val_113});
        label_103:
        val_115 = this;
        UnityEngine.Vector3 val_50 = this.丐一丗丛丕世丘东丁.position;
        goto label_123;
        label_49:
        val_94 = 0.5f;
        label_51:
        float val_95 = (float)-UnityEngine.Screen.width;
        val_95 = val_94 * val_95;
        float val_96 = (float)-UnityEngine.Screen.height;
        val_96 = val_94 * val_96;
        float val_53 = this.不丝下丆丐丙丘东丛.x;
        goto label_107;
        label_72:
        float val_97 = -0.5f;
        val_97 = val_89 + val_97;
        goto label_108;
        label_81:
        label_108:
        if(val_49.y >= 0f)
        {
            goto label_109;
        }
        
        val_98 = -0.5;
        if((double)val_49.y != val_98)
        {
            goto label_110;
        }
        
        val_116 = val_14;
        val_117 = -1f;
        goto label_111;
        label_109:
        val_98 = 0.5;
        if((double)val_49.y != val_98)
        {
            goto label_112;
        }
        
        val_116 = val_14;
        val_117 = 1f;
        label_111:
        float val_98 = (float)val_116;
        val_98 = val_98 + val_117;
        val_98 = (((long)val_116 & 1) != 0) ? (val_98) : (val_98);
        goto label_114;
        label_110:
        float val_99 = -0.5f;
        val_99 = val_49.y + val_99;
        goto label_114;
        label_112:
        label_114:
        label_68:
        val_115 = this;
        val_92 = this.丐一丗丛丕世丘东丁;
        UnityEngine.Vector3 val_56 = val_92.position;
        UnityEngine.Vector3 val_57 = val_92.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
        val_110 = val_89 + 0.5f;
        val_107 = val_49.y + 0.5f;
        val_99 = val_57.z;
        UnityEngine.Vector3 val_58 = this.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_110, y = val_107, z = val_99});
        if((this.uiCamera.orthographic == false) || (this.丐一丗丛丕世丘东丁.parent == 0))
        {
            goto label_123;
        }
        
        UnityEngine.Vector3 val_63 = this.丐一丗丛丕世丘东丁.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z});
        UnityEngine.Vector3 val_66 = this.丐一丗丛丕世丘东丁.localPosition;
        val_92 = 1152921504838316032;
        val_118 = val_66.x;
        val_119 = val_66.y;
        val_120 = val_66.z;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_118, y = val_119, z = val_120}, rhs:  new UnityEngine.Vector3() {x = (float)UnityEngine.Mathf.RoundToInt(f:  val_63.x), y = (float)UnityEngine.Mathf.RoundToInt(f:  val_63.y), z = val_63.z})) != false)
        {
                val_118 = (float)UnityEngine.Mathf.RoundToInt(f:  val_63.x);
            val_119 = (float)UnityEngine.Mathf.RoundToInt(f:  val_63.y);
            val_120 = val_63.z;
            this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_118, y = val_119, z = val_120};
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_121 = this.side;
            if(val_121 == 8)
        {
                if((this.uiCamera.GetComponent<IPX>()) == 0)
        {
                val_122 = null;
            val_122 = null;
            val_120 = 1f;
            float val_100 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_119 = 768f;
            val_100 = val_120 - val_100;
            val_100 = val_100 * 0.5f;
            val_100 = val_100 * val_119;
            val_118 = ((float)UnityEngine.Mathf.RoundToInt(f:  val_63.y)) + val_100;
        }
        
            val_121 = this.side;
        }
        
            if(val_121 <= 2)
        {
                val_123 = null;
            val_123 = null;
            val_120 = 1f;
            val_119 = (float)UnityEngine.Screen.width / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_101 = IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            val_101 = val_120 - val_101;
            val_101 = val_101 * 0.5f;
            val_101 = val_119 * val_101;
            val_118 = ((float)UnityEngine.Mathf.RoundToInt(f:  val_63.x)) + val_101;
            val_121 = this.side;
        }
        
            if((val_121 - 4) <= 2)
        {
                val_124 = null;
            val_124 = null;
            val_119 = (float)UnityEngine.Screen.width / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_102 = IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            val_102 = 1f - val_102;
            val_120 = -0.5f;
            val_102 = val_102 * val_120;
            val_102 = val_119 * val_102;
            val_118 = val_118 + val_102;
            val_121 = this.side;
        }
        
            if(val_121 <= 7)
        {
                val_121 = 1 << val_121;
            val_121 = val_121 & 193;
            if(val_121 != 0)
        {
                if((this.uiCamera.GetComponent<IPX>()) == 0)
        {
                val_125 = null;
            val_125 = null;
            val_120 = 1f;
            float val_103 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_119 = 768f;
            val_103 = val_120 - val_103;
            val_103 = val_103 * val_119;
            val_118 = val_118 + val_103;
        }
        
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_78 = this.丐一丗丛丕世丘东丁.localPosition;
        val_126 = val_118;
        val_127 = val_63.z;
        val_128 = val_78.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_128, y = val_78.y, z = val_78.z}, rhs:  new UnityEngine.Vector3() {x = val_126, y = val_118, z = val_127})) == false)
        {
            goto label_170;
        }
        
        val_128 = val_118;
        val_127 = val_63.z;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_128, y = val_118, z = val_127};
        goto label_170;
        label_123:
        UnityEngine.Vector3 val_80 = this.丐一丗丛丕世丘东丁.position;
        val_126 = val_118;
        val_127 = val_63.z;
        val_128 = val_80.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_128, y = val_80.y, z = val_80.z}, rhs:  new UnityEngine.Vector3() {x = val_126, y = val_118, z = val_127})) != false)
        {
                val_128 = val_118;
            val_127 = val_63.z;
            this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_128, y = val_118, z = val_127};
        }
        
        label_170:
        if(this.runOnlyOnce == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    public UIAnchor()
    {
        this.side = 8;
        this.runOnlyOnce = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.relativeOffset = val_1;
        mem[1152921535284809844] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.pixelOffset = val_2;
        mem[1152921535284809852] = val_2.y;
    }

}
