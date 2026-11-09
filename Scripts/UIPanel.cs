using UnityEngine;
public class UIPanel : UIRect
{
    // Fields
    public static System.Collections.Generic.List<UIPanel> list;
    public UIPanel.丛上丐丁丞三专专万 onGeometryUpdated;
    public UIPanel.世一不世丗丞丅丑丐 onRenderQueueUpdated;
    public bool showInPanelTool;
    public bool generateNormals;
    public bool widgetsAreStatic;
    public bool cullWhileDragging;
    public bool alwaysOnScreen;
    public bool anchorOffset;
    public bool softBorderPadding;
    public UIPanel.万与专丆下丌丕世与 renderQueue;
    public int startingRenderQueue;
    public System.Collections.Generic.List<UIWidget> widgets;
    public System.Collections.Generic.List<UIDrawCall> drawCalls;
    public UnityEngine.Matrix4x4 worldToLocal;
    public UnityEngine.Vector4 drawCallClipRange;
    public UIPanel.上丟丟且丁且丅丏丆 onClipMove;
    private UnityEngine.Texture2D mClipTexture;
    private float mAlpha;
    private UIDrawCall.丞东丙专丁上丐七丆 mClipping;
    private UnityEngine.Vector4 mClipRange;
    private UnityEngine.Vector2 mClipSoftness;
    private int mDepth;
    private int mSortingOrder;
    private bool 丕丘丑万万丝丝丝丏;
    private bool 丆下业丈丑丌丆七丒;
    private UnityEngine.Vector2 mClipOffset;
    private int 丒丈上万丘丁丟丕丄;
    private int 不不丙丈与专丄丏丌;
    private int 丝万不业丂丏丌且丄;
    private static float[] 丑下丅三万下丌丈丒;
    private UnityEngine.Vector2 且丛丄丝丘业丞丝丗;
    private UnityEngine.Vector2 丐丒丌丂且丙与丙丕;
    private bool 丆丁专不下丄丟丁丑;
    private bool 丐丈丆丈丟专丈一丛;
    private bool 丐不丈上丁丕万丛一;
    private UIPanel 丝丟丁七不丄丒东七;
    internal UnityEngine.Vector2 世下丐丐下专下七丑;
    private static UnityEngine.Vector3[] 三丑丄丄丘丛丐世不;
    private static int 丒丕下丐丅丄丒丁丛;
    private UIScrollView 丈丌丏丝东丅上丒丙;
    private UIDrawCall.丝丂丏世丌丈一与业 丐丅上丐丑且丗业一;
    private bool 丏丂丅丛丄万万与一;
    
    // Properties
    public static int 丈下与且七下上万与 { get; }
    public override bool 丞七丟丞丒丂丕七丆 { get; }
    public override float 与专丌丅丙上丌一丄 { get; set; }
    public int 丟丕丞丁丝丂上丄上 { get; set; }
    public int 一丑不丆丛丈三丟丑 { get; set; }
    public float 业与三万七丝不万东 { get; }
    public float 丟丌丐丘丆丙丑丑一 { get; }
    public bool 与万丏丏上丞丙丅丒 { get; }
    public bool 与丅丞丐万丟七丌丈 { get; }
    public UnityEngine.Vector3 专丞丕丅不丈丞与与 { get; }
    public UIDrawCall.丞东丙专丁上丐七丆 丟丅丐丙且东丙丁丌 { get; set; }
    public UIPanel 丆丏丟丌丅丟丙不丁 { get; }
    public int 丁世丝丆丒丂丝丝丌 { get; }
    public bool 一且丟丐上丘丕丄丏 { get; }
    public bool 丘世丒丙丐专丆丈丒 { get; }
    public bool 丐专丑下丞一丙下丕 { get; }
    public UnityEngine.Vector2 丌且与不东丅三丄丗 { get; set; }
    public UnityEngine.Texture2D 与丈丐丞丆丙万三世 { get; set; }
    public UnityEngine.Vector4 丄丘与丒丈丕丅丌丟 { get; set; }
    public UnityEngine.Vector4 丆上丏一一丒丁丆丐 { get; set; }
    public UnityEngine.Vector4 丈丑丑丗三丌丁丈丆 { get; }
    public UnityEngine.Vector2 丘丛上下丟丆丟丘七 { get; set; }
    public override UnityEngine.Vector3[] 丝下丒丙丂万丆丞业 { get; }
    public override UnityEngine.Vector3[] 丈丞上三七丌丑业丛 { get; }
    
    // Methods
    public static int get_nextUnusedDepth()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        int val_1 = UIPanel.list.Count;
        if(val_1 >= 1)
        {
                var val_5 = 0;
            do
        {
            val_6 = null;
            val_6 = null;
            UIPanel val_2 = UIPanel.list.Item[0];
            val_5 = val_5 + 1;
            val_7 = UnityEngine.Mathf.Max(a:  -2147483648, b:  val_2.mDepth);
        }
        while(val_1 != val_5);
        
            return (int)(val_7 == (-2147483648)) ? 0 : (val_7 + 1);
        }
        
        val_7 = -2147483648;
        return (int)(val_7 == (-2147483648)) ? 0 : (val_7 + 1);
    }
    public override bool get_canBeAnchored()
    {
        return (bool)(this.mClipping != 0) ? 1 : 0;
    }
    public override float get_alpha()
    {
        return (float)this.mAlpha;
    }
    public override void set_alpha(float 丙业与丙丗丝不丈东)
    {
        float val_1 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(this.mAlpha == val_1)
        {
                return;
        }
        
        this.不不丙丈与专丄丏丌 = 0;
        this.丆下业丈丑丌丆七丒 = true;
        this.mAlpha = val_1;
        this.SetDirty();
    }
    public int get_depth()
    {
        return (int)this.mDepth;
    }
    public void set_depth(int 丙业与丙丗丝不丈东)
    {
        var val_2;
        if(this.mDepth == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mDepth = 丙业与丙丗丝不丈东;
        val_2 = null;
        val_2 = null;
        UIPanel.list.Sort(comparison:  new System.Comparison<UIPanel>(object:  0, method:  public static System.Int32 UIPanel::CompareFunc(UIPanel 丆丛丑世下一丐且丕, UIPanel 丌丗丏丏丛东专丁且)));
    }
    public int get_sortingOrder()
    {
        return (int)this.mSortingOrder;
    }
    public void set_sortingOrder(int 丙业与丙丗丝不丈东)
    {
        if(this.mSortingOrder == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mSortingOrder = 丙业与丙丗丝不丈东;
        this.丙丗三丒丝万丂东下();
    }
    public static int CompareFunc(UIPanel 丆丛丑世下一丐且丕, UIPanel 丌丗丏丏丛东专丁且)
    {
        var val_7;
        if(((丆丛丑世下一丐且丕 == 丌丗丏丏丛东专丁且) || (丆丛丑世下一丐且丕 == 0)) || (丌丗丏丏丛东专丁且 == 0))
        {
            goto label_9;
        }
        
        if(丆丛丑世下一丐且丕.mDepth >= 丌丗丏丏丛东专丁且.mDepth)
        {
            goto label_12;
        }
        
        val_7 = 0;
        return (int)val_7;
        label_9:
        val_7 = 0;
        return (int)val_7;
        label_12:
        if(丆丛丑世下一丐且丕.mDepth > 丌丗丏丏丛东专丁且.mDepth)
        {
                return (int)val_7;
        }
        
        var val_6 = (丆丛丑世下一丐且丕.GetInstanceID() < 丌丗丏丏丛东专丁且.GetInstanceID()) ? (-1) : 1;
        return (int)val_7;
    }
    public float get_width()
    {
        return this.GetViewSize();
    }
    public float get_height()
    {
        UnityEngine.Vector2 val_1 = this.GetViewSize();
        return (float)val_1.y;
    }
    public bool get_halfPixelOffset()
    {
        return (bool)this.丆丁专不下丄丟丁丑;
    }
    public bool get_usedForUI()
    {
        if(this.anchorCamera == 0)
        {
                return false;
        }
        
        if(this != null)
        {
                return this.orthographic;
        }
        
        return this.orthographic;
    }
    public UnityEngine.Vector3 get_drawCallOffset()
    {
        var val_20;
        var val_21;
        float val_23;
        val_20 = this;
        UnityEngine.Camera val_1 = this.anchorCamera;
        val_21 = 1152921504848912384;
        if((val_1 == 0) || (val_1.orthographic == false))
        {
            goto label_5;
        }
        
        UnityEngine.Vector2 val_4 = this.GetWindowSize();
        UIRoot val_5 = this.root;
        if(val_5 == 0)
        {
            goto label_8;
        }
        
        val_23 = this.root.pixelSizeAdjustment;
        goto label_10;
        label_5:
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_8:
        val_23 = 1f;
        label_10:
        val_23 = val_23 / val_4.y;
        val_23 = val_23 / val_5.orthographicSize;
        var val_11 = (this.丆丁专不下丄丟丁丑 == false) ? 1 : 0;
        var val_18 = (((((UnityEngine.Mathf.RoundToInt(f:  val_4.x)) & 1) != 0) ? ((this.丆丁专不下丄丟丁丑 == true) ? 1 : 0) : (val_11)) != 0) ? (-val_23) : 0f;
        var val_19 = (((((UnityEngine.Mathf.RoundToInt(f:  val_4.y)) & 1) != 0) ? ((this.丆丁专不下丄丟丁丑 == true) ? 1 : 0) : (val_11)) != 0) ? (val_23) : 0f;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public UIDrawCall.丞东丙专丁上丐七丆 get_clipping()
    {
        return (UIDrawCall.丞东丙专丁上丐七丆)this.mClipping;
    }
    public void set_clipping(UIDrawCall.丞东丙专丁上丐七丆 丙业与丙丗丝不丈东)
    {
        if(this.mClipping == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mClipping = 丙业与丙丗丝不丈东;
        this.丆下业丈丑丌丆七丒 = true;
        this.丒丈上万丘丁丟丕丄 = 0;
    }
    public UIPanel get_parentPanel()
    {
        return (UIPanel)this.丝丟丁七不丄丒东七;
    }
    public int get_clipCount()
    {
        UIPanel val_2;
        var val_3;
        val_2 = this;
        val_3 = 0;
        goto label_1;
        label_6:
        UIDrawCall.丞东丙专丁上丐七丆 val_2 = this.mClipping;
        val_2 = val_2 | 2;
        if(val_2 == 3)
        {
                val_3 = 1;
        }
        
        val_2 = this.丝丟丁七不丄丒东七;
        label_1:
        if(val_2 != 0)
        {
            goto label_6;
        }
        
        return (int)val_3;
    }
    public bool get_hasClipping()
    {
        UIDrawCall.丞东丙专丁上丐七丆 val_2 = this.mClipping;
        val_2 = val_2 | 2;
        return (bool)(val_2 == 3) ? 1 : 0;
    }
    public bool get_hasCumulativeClipping()
    {
        return (bool)(this.clipCount != 0) ? 1 : 0;
    }
    public bool get_clipsChildren()
    {
        return (bool)(this.clipCount != 0) ? 1 : 0;
    }
    public UnityEngine.Vector2 get_clipOffset()
    {
        return new UnityEngine.Vector2() {x = this.mClipOffset};
    }
    public void set_clipOffset(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东.x = this.mClipOffset - 丙业与丙丗丝不丈东.x;
        if(System.Math.Abs(丙业与丙丗丝不丈东.x) <= 0.001f)
        {
                if((System.Math.Abs(this.mClipOffset - 丙业与丙丗丝不丈东.y)) <= 0.001f)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector2 val_5 = this.mClipOffset;
        val_5 = val_5 - 丙业与丙丗丝不丈东.x;
        丙业与丙丗丝不丈东.y = 丙业与丙丗丝不丈东.y - 丙业与丙丗丝不丈东.y;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_5, y:  丙业与丙丗丝不丈东.y);
        this.mClipOffset = 丙业与丙丗丝不丈东;
        mem[1152921535343769264] = 丙业与丙丗丝不丈东.y;
        this.世下丐丐下专下七丑 = val_2.x;
        mem[1152921535343769316] = val_2.y;
        this.丘与专业丟且业万业();
        if(this.onClipMove == null)
        {
                return;
        }
        
        this.onClipMove.Invoke(丛丘下丗业丂一且业:  this);
    }
    private void 丘与专业丟且业万业()
    {
        var val_5;
        var val_6;
        this.丆下业丈丑丌丆七丒 = true;
        this.丒丈上万丘丁丟丕丄 = 0;
        val_5 = null;
        val_5 = null;
        int val_1 = UIPanel.list.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_5 = 0;
        do
        {
            val_6 = null;
            val_6 = null;
            if(UIPanel.list.Item[0] != this)
        {
                bool val_4 = UnityEngine.Object.op_Equality(x:  val_2.丝丟丁七不丄丒东七, y:  this);
        }
        
            val_5 = val_5 + 1;
        }
        while(val_1 != val_5);
    
    }
    public UnityEngine.Texture2D get_clipTexture()
    {
        return (UnityEngine.Texture2D)this.mClipTexture;
    }
    public void set_clipTexture(UnityEngine.Texture2D 丙业与丙丗丝不丈东)
    {
        if(this.mClipTexture == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mClipTexture = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector4 get_clipRange()
    {
        return new UnityEngine.Vector4() {x = this.mClipRange};
    }
    public void set_clipRange(UnityEngine.Vector4 丙业与丙丗丝不丈东)
    {
        this.baseClipRegion = new UnityEngine.Vector4() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z, w = 丙业与丙丗丝不丈东.w};
    }
    public UnityEngine.Vector4 get_baseClipRegion()
    {
        return new UnityEngine.Vector4() {x = this.mClipRange};
    }
    public void set_baseClipRegion(UnityEngine.Vector4 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东.x = this.mClipRange - 丙业与丙丗丝不丈东.x;
        if((System.Math.Abs(丙业与丙丗丝不丈东.x) <= 0.001f) && ((System.Math.Abs(this.mClipRange - 丙业与丙丗丝不丈东.y)) <= 0.001f))
        {
                if((System.Math.Abs(this.mClipRange - 丙业与丙丗丝不丈东.z)) <= 0.001f)
        {
                if((System.Math.Abs(this.mClipRange - 丙业与丙丗丝不丈东.w)) <= 0.001f)
        {
                return;
        }
        
        }
        
        }
        
        this.mClipRange = 丙业与丙丗丝不丈东;
        mem[1152921535344606476] = 丙业与丙丗丝不丈东.y;
        mem[1152921535344606480] = 丙业与丙丗丝不丈东.z;
        mem[1152921535344606484] = 丙业与丙丗丝不丈东.w;
        this.丆下业丈丑丌丆七丒 = true;
        this.丒丈上万丘丁丟丕丄 = 0;
        UIScrollView val_4 = this.GetComponent<UIScrollView>();
        if(val_4 != 0)
        {
                val_4.UpdatePosition();
        }
        
        if(this.onClipMove == null)
        {
                return;
        }
        
        this.onClipMove.Invoke(丛丘下丗业丂一且业:  this);
    }
    public UnityEngine.Vector4 get_finalClipRegion()
    {
        var val_3;
        UnityEngine.Vector2 val_1 = this.GetViewSize();
        if(this.mClipping != 0)
        {
                UnityEngine.Vector4 val_2 = this.mClipRange;
            val_2 = val_2 + this.mClipOffset;
            val_3 = S4 + S5;
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        
        val_3 = 0f;
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public UnityEngine.Vector2 get_clipSoftness()
    {
        return new UnityEngine.Vector2() {x = this.mClipSoftness};
    }
    public void set_clipSoftness(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.mClipSoftness, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y})) == false)
        {
                return;
        }
        
        this.mClipSoftness = 丙业与丙丗丝不丈东;
        mem[1152921535344958876] = 丙业与丙丗丝不丈东.y;
    }
    public override UnityEngine.Vector3[] get_localCorners()
    {
        var val_9;
        float val_10;
        float val_11;
        var val_12;
        UnityEngine.Vector3[] val_13;
        if(this.mClipping != 0)
        {
                UnityEngine.Vector2 val_7 = this.mClipOffset;
            val_7 = val_7 + this.mClipRange;
            val_9 = null;
            float val_2 = val_7 - (S11 * 0.5f);
            val_10 = (S3 + S4) - (S10 * 0.5f);
            val_9 = null;
            val_11 = S10 + val_10;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_20 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_24 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_28 = 0;
            val_2 = S11 + val_2;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_2C = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_30 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_34 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_38 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_3C = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_40 = 0;
            val_12 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_44 = val_12;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_48 = 0;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_4C = 0;
            val_13 = UIPanel.三丑丄丄丘丛丐世不;
            return (UnityEngine.Vector3[])val_13;
        }
        
        val_13 = this;
        do
        {
            UnityEngine.Vector3 val_6 = this.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = 2.766919E-21f});
            val_10 = val_6.x;
            val_11 = val_6.z;
            val_12 = 0 + 1;
            mem[1152921535345078784] = val_10;
            mem[1152921535345078788] = val_6.y;
            mem[1152921535345078792] = val_11;
        }
        while(val_12 != 4);
        
        return (UnityEngine.Vector3[])val_13;
    }
    public override UnityEngine.Vector3[] get_worldCorners()
    {
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        if(this.mClipping == 0)
        {
            goto label_1;
        }
        
        float val_2 = S14 * 0.5f;
        UnityEngine.Transform val_5 = this.cachedTransform;
        val_26 = null;
        val_26 = null;
        val_2 = (this.mClipOffset + this.mClipRange) - val_2;
        float val_6 = (S3 + S4) - (S13 * 0.5f);
        UnityEngine.Vector3 val_7 = val_5.TransformPoint(x:  val_2, y:  val_6, z:  0f);
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_20 = val_7.x;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_24 = val_7.y;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_28 = val_7.z;
        float val_8 = S13 + val_6;
        UnityEngine.Vector3 val_9 = val_5.TransformPoint(x:  val_2, y:  val_8, z:  0f);
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_2C = val_9.x;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_30 = val_9.y;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_34 = val_9.z;
        val_2 = S14 + val_2;
        UnityEngine.Vector3 val_10 = val_5.TransformPoint(x:  val_2, y:  val_8, z:  0f);
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_38 = val_10.x;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_3C = val_10.y;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_40 = val_10.z;
        UnityEngine.Vector3 val_11 = val_5.TransformPoint(x:  val_2, y:  val_6, z:  0f);
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_44 = val_11.x;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_48 = val_11.y;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_4C = val_11.z;
        label_50:
        val_27 = null;
        val_27 = null;
        return (UnityEngine.Vector3[])UIPanel.三丑丄丄丘丛丐世不;
        label_1:
        UnityEngine.Camera val_12 = this.anchorCamera;
        if(val_12 != 0)
        {
                return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  val_12, 丟丕丞丁丝丂上丄上:  this.丂业一丏三丞七三丌());
        }
        
        UnityEngine.Vector2 val_15 = this.GetViewSize();
        float val_27 = val_15.x;
        float val_26 = val_15.y;
        val_28 = null;
        val_28 = null;
        val_26 = val_26 + (val_26 * (-0.5f));
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_20 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_24 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_28 = 0;
        val_27 = val_27 + (val_27 * (-0.5f));
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_2C = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_30 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_34 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_38 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_3C = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_40 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_44 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_48 = 0;
        UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_4C = 0;
        if(this.anchorOffset == false)
        {
            goto label_50;
        }
        
        if(UIPanel.三丑丄丄丘丛丐世不 != 0)
        {
                if(UIPanel.三丑丄丄丘丛丐世不.transform.parent == this.cachedTransform)
        {
            goto label_50;
        }
        
        }
        
        UnityEngine.Vector3 val_24 = this.cachedTransform.position;
        var val_29 = 0;
        var val_28 = 0;
        do
        {
            val_29 = null;
            val_29 = null;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = UIPanel.三丑丄丄丘丛丐世不 + 32, y = UIPanel.三丑丄丄丘丛丐世不 + 32 + 4, z = UIPanel.三丑丄丄丘丛丐世不 + 40}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_28 = val_28 + 1;
            val_29 = val_29 + 12;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_20 = val_25.x;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_24 = val_25.y;
            UIPanel.三丑丄丄丘丛丐世不.__unknownFiledOffset_28 = val_25.z;
        }
        while(val_28 != 4);
        
        goto label_50;
    }
    public override UnityEngine.Vector3[] GetSides(UnityEngine.Transform 一世丛下丘东世专丈)
    {
        var val_25;
        float val_26;
        float val_27;
        var val_28;
        var val_29;
        if(this.mClipping != 0)
        {
                float val_2 = S2 + S3;
            val_2 = val_2 - (S4 * 0.5f);
            float val_4 = S4 + val_2;
            float val_5 = S11 * 0.5f;
            UnityEngine.Transform val_7 = this.cachedTransform;
            val_25 = null;
            val_25 = null;
            val_5 = (this.mClipOffset + this.mClipRange) - val_5;
            float val_8 = (val_2 + val_4) * 0.5f;
            float val_9 = S11 + val_5;
            UnityEngine.Vector3 val_10 = val_7.TransformPoint(x:  val_5, y:  val_8, z:  0f);
            val_5 = val_5 + val_9;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_10.x;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_10.y;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_10.z;
            val_5 = val_5 * 0.5f;
            UnityEngine.Vector3 val_11 = val_7.TransformPoint(x:  val_5, y:  val_4, z:  0f);
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_2C = val_11.x;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_30 = val_11.y;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_34 = val_11.z;
            UnityEngine.Vector3 val_12 = val_7.TransformPoint(x:  val_9, y:  val_8, z:  0f);
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_38 = val_12.x;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_3C = val_12.y;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_40 = val_12.z;
            UnityEngine.Vector3 val_13 = val_7.TransformPoint(x:  val_5, y:  val_2, z:  0f);
            val_26 = val_13.x;
            val_27 = val_13.z;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_44 = val_26;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_48 = val_13.y;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_4C = val_27;
            if(一世丛下丘东世专丈 != 0)
        {
                var val_26 = 0;
            var val_25 = 0;
            do
        {
            val_28 = null;
            val_28 = null;
            UnityEngine.Vector3 val_15 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = X24 + 32, y = X24 + 32 + 4, z = X24 + 40});
            val_26 = val_15.x;
            val_27 = val_15.z;
            val_25 = val_25 + 1;
            val_26 = val_26 + 12;
            mem2[0] = val_26;
            mem2[0] = val_15.y;
            mem2[0] = val_27;
        }
        while(val_25 != 4);
        
        }
        
            val_29 = null;
            val_29 = null;
            return (UnityEngine.Vector3[])UIRect.专丏丛下世丙丝丈三;
        }
        
        UnityEngine.Camera val_16 = this.anchorCamera;
        if(val_16 == 0)
        {
                return this.GetSides(一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        if(this.anchorOffset == false)
        {
                return this.GetSides(一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        UnityEngine.Vector3[] val_19 = 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  val_16, 丟丕丞丁丝丂上丄上:  this.丂业一丏三丞七三丌());
        UnityEngine.Vector3 val_21 = this.cachedTransform.position;
        var val_27 = 0;
        do
        {
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 7936.641f, y = 7936.641f, z = 7936.641f}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_27 = val_27 + 1;
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
        }
        while(val_27 != 4);
        
        if(一世丛下丘东世专丈 == 0)
        {
                return (UnityEngine.Vector3[])UIRect.专丏丛下世丙丝丈三;
        }
        
        var val_28 = 0;
        do
        {
            UnityEngine.Vector3 val_24 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 7936.641f, y = 7936.641f, z = 7936.641f});
            val_28 = val_28 + 1;
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
        }
        while(val_28 != 4);
        
        return (UnityEngine.Vector3[])UIRect.专丏丛下世丙丝丈三;
    }
    public override void Invalidate(bool 丕丐丟下东专丒丘业)
    {
        this.不不丙丈与专丄丏丌 = 0;
        this.Invalidate(丕丐丟下东专丒丘业:  丕丐丟下东专丒丘业);
    }
    public override float CalculateFinalAlpha(int 与专丙丝丝且丂且丒)
    {
        var val_5;
        float val_6;
        if(this.不不丙丈与专丄丏丌 == 与专丙丝丝且丂且丒)
        {
                return val_6;
        }
        
        this.不不丙丈与专丄丏丌 = 与专丙丝丝且丂且丒;
        val_5 = this.parent;
        if(this.parent != 0)
        {
                val_6 = S0 * this.mAlpha;
        }
        else
        {
                val_6 = this.mAlpha;
        }
        
        mem[1152921535345715308] = val_6;
        return val_6;
    }
    public override void SetRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一)
    {
        var val_21;
        UnityEngine.Object val_22;
        val_21 = this;
        int val_5 = (UnityEngine.Mathf.FloorToInt(f:  丟丌丐丘丆丙丑丑一 + 0.5f)) & 4294967294;
        val_22 = (UnityEngine.Mathf.FloorToInt(f:  业与三万七丝不万东 + 0.5f)) & 4294967294;
        UnityEngine.Transform val_6 = this.cachedTransform;
        UnityEngine.Vector3 val_7 = val_6.localPosition;
        var val_8 = (val_22 > 2) ? (val_22) : 2;
        float val_9 = 三丟东丕丄丄下下丑 + 0.5f;
        float val_10 = 丒丒丄丁且丄丆丂丌 + 0.5f;
        var val_11 = (val_5 > 2) ? (val_5) : 2;
        this.baseClipRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        if(this.isAnchored == false)
        {
                return;
        }
        
        UnityEngine.Transform val_13 = val_6.parent;
        if((UnityEngine.Object.op_Implicit(exists:  (val_2 & 4294967294) + 16)) != false)
        {
                (val_2 & 4294967294) + 16.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_13, 丈丑丑且业下丒丁丞:  三丟东丕丄丄下下丑);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  (val_2 & 4294967294) + 16 + 16)) != false)
        {
                (val_2 & 4294967294) + 16 + 16.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_13, 丈丑丑且业下丒丁丞:  三丟东丕丄丄下下丑 + 业与三万七丝不万东);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  (val_2 & 4294967294) + 16 + 16 + 16)) != false)
        {
                (val_2 & 4294967294) + 16 + 16 + 16.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_13, 丈丑丑且业下丒丁丞:  丒丒丄丁且丄丆丂丌);
        }
        
        val_22 = mem[(val_2 & 4294967294) + 16 + 16 + 16 + 16];
        val_22 = (val_2 & 4294967294) + 16 + 16 + 16 + 16;
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) == false)
        {
                return;
        }
        
        this.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_13, 丈丑丑且业下丒丁丞:  丒丒丄丁且丄丆丂丌 + 丟丌丐丘丆丙丑丑一);
    }
    public bool IsVisible(UnityEngine.Vector3 丆丛丑世下一丐且丕, UnityEngine.Vector3 丌丗丏丏丛东专丁且, UnityEngine.Vector3 丁丂专业丁丅丅丈丙, UnityEngine.Vector3 丐丆丂丒丁万丈丛丅)
    {
        var val_1;
        var val_2;
        var val_8;
        var val_9;
        this.丗丅丁丒一世丂丌丟();
        val_8 = null;
        val_8 = null;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_20 = 丆丛丑世下一丐且丕.x;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_24 = 丌丗丏丏丛东专丁且.x;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_28 = 丁丂专业丁丅丅丈丙.x;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_2C = 丁丂专业丁丅丅丈丙.z;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_20 = 丆丛丑世下一丐且丕.y;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_24 = 丌丗丏丏丛东专丁且.y;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_28 = val_1;
        UIPanel.丑下丅三万下丌丈丒.__unknownFiledOffset_2C = val_2;
        if((((UnityEngine.Mathf.Max(values:  UIPanel.丑下丅三万下丌丈丒)) >= 0) && ((UnityEngine.Mathf.Max(values:  UIPanel.丑下丅三万下丌丈丒)) >= 0)) && ((UnityEngine.Mathf.Min(values:  UIPanel.丑下丅三万下丌丈丒)) <= this.丐丒丌丂且丙与丙丕))
        {
                var val_7 = ((UnityEngine.Mathf.Min(values:  UIPanel.丑下丅三万下丌丈丒)) <= this.丐丒丌丂且丙与丙丕) ? 1 : 0;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public bool IsVisible(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
    {
        var val_2;
        if(this.mAlpha >= 0)
        {
                UIDrawCall.丞东丙专丁上丐七丆 val_2 = this.mClipping;
            val_2 = val_2 | 4;
            if(val_2 == 4)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
            this.丗丅丁丒一世丂丌丟();
            if(((丈七东丐世丒丅丗丌.x >= 0) && (丈七东丐世丒丅丗丌.y >= 0)) && (丈七东丐世丒丅丗丌.x <= this.丐丒丌丂且丙与丙丕))
        {
                var val_1 = (丈七东丐世丒丅丗丌.y <= 丈七东丐世丒丅丗丌.x) ? 1 : 0;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public bool IsVisible(UIWidget 与丘东下丈东丛丂万)
    {
        var val_3;
        var val_5;
        val_3 = 0;
        label_8:
        if(this == 0)
        {
            goto label_3;
        }
        
        UIDrawCall.丞东丙专丁上丐七丆 val_3 = this.mClipping;
        val_3 = val_3 | 4;
        if((val_3 != 4) || (与丘东下丈东丛丂万.hideIfOffScreen == true))
        {
            goto label_7;
        }
        
        goto label_8;
        label_7:
        if(val_3 == 0)
        {
                val_3 = 与丘东下丈东丛丂万;
        }
        
        if((this.IsVisible(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = ???, y = V9.16B, z = V10.16B}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = V11.16B, y = V12.16B, z = V13.16B}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = ???, y = ???, z = 1.981925E-21f}, 丐丆丂丒丁万丈丛丅:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???})) == true)
        {
            goto label_8;
        }
        
        val_5 = 0;
        return (bool)val_5;
        label_3:
        val_5 = 1;
        return (bool)val_5;
    }
    public bool Affects(UIWidget 与丘东下丈东丛丂万)
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = this;
        if(与丘东下丈东丛丂万 == 0)
        {
            goto label_8;
        }
        
        if(与丘东下丈东丛丂万.panel != 0)
        {
            goto label_7;
        }
        
        goto label_8;
        label_17:
        if(this == 与丘东下丈东丛丂万.panel)
        {
                return (bool)val_7;
        }
        
        val_7 = val_6;
        if(this.clipCount == 0)
        {
                return (bool)val_7;
        }
        
        val_6 = this.丝丟丁七不丄丒东七;
        label_7:
        if(val_6 != 0)
        {
            goto label_17;
        }
        
        label_8:
        val_7 = 0;
        return (bool)val_7;
    }
    public void RebuildAllDrawCalls()
    {
        this.丕丘丑万万丝丝丝丏 = true;
    }
    public void SetDirty()
    {
        int val_1 = this.drawCalls.Count;
        if(val_1 >= 1)
        {
                var val_3 = 0;
            do
        {
            UIDrawCall val_2 = this.drawCalls.Item[0];
            val_3 = val_3 + 1;
            val_2.isDirty = true;
        }
        while(val_1 != val_3);
        
        }
    
    }
    protected override void Awake()
    {
        null = null;
        UIRoot.丅丘丝不七丝丝三丘.set_Item(key:  this.cachedTransform, value:  this);
        this.Awake();
        if(UnityEngine.Application.platform != 2)
        {
                if(UnityEngine.Application.platform != 10)
        {
            goto label_5;
        }
        
        }
        
        if(this != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.丆丁专不下丄丟丁丑 = true;
        if(true != 0)
        {
                if((UnityEngine.SystemInfo.graphicsDeviceVersion.Contains(value:  "Direct3D")) != false)
        {
                this.丆丁专不下丄丟丁丑 = (UnityEngine.SystemInfo.graphicsShaderLevel < 40) ? 1 : 0;
        }
        
        }
        
        if(this.丈丌丏丝东丅上丒丙 != 0)
        {
                return;
        }
        
        this.丈丌丏丝东丅上丒丙 = this.GetComponent<UIScrollView>();
        return;
        label_5:
        var val_11 = (UnityEngine.Application.platform == 7) ? 1 : 0;
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    private void 且丆丈丙丙万业丁不()
    {
        UIPanel val_6;
        UnityEngine.Transform val_2 = this.cachedTransform.parent;
        val_6 = 0;
        if(val_2 != 0)
        {
                val_6 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  val_2.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        }
        
        this.丝丟丁七不丄丒东七 = val_6;
    }
    public override void ParentHasChanged()
    {
        this.ParentHasChanged();
        this.且丆丈丙丙万业丁不();
    }
    protected override void 丁业三上丛丐且专东()
    {
        this.丝万不业丂丏丌且丄 = this.cachedGameObject.layer;
    }
    protected override void OnEnable()
    {
        this.丕丘丑万万丝丝丝丏 = true;
        mem2[0] = 0;
        this.OnEnable();
        this.丒丈上万丘丁丟丕丄 = 0;
    }
    protected override void 丅丒丐且丘丝丝丄且()
    {
        var val_12;
        UnityEngine.Object val_13;
        var val_14;
        val_12 = null;
        val_12 = null;
        if((UIPanel.list.Contains(item:  this)) != false)
        {
                return;
        }
        
        this.丅丒丐且丘丝丝丄且();
        this.且丆丈丙丙万业丁不();
        if(((this.GetComponent<UnityEngine.Rigidbody>()) == 0) && (this.丝丟丁七不丄丒东七 == 0))
        {
                val_13 = 0;
            if(this.anchorCamera != 0)
        {
                val_13 = val_13.GetComponent<UICamera>();
        }
        
            if((val_13 != 0) && (val_7.eventType <= 1))
        {
                UnityEngine.Rigidbody val_10 = this.gameObject.AddComponent<UnityEngine.Rigidbody>();
            if(val_10 != null)
        {
                val_10.isKinematic = true;
        }
        else
        {
                val_10.isKinematic = true;
        }
        
            val_10.useGravity = false;
        }
        
        }
        
        this.丕丘丑万万丝丝丝丏 = true;
        mem2[0] = 0;
        val_14 = null;
        val_14 = null;
        UIPanel.list.Add(item:  this);
        UIPanel.list.Sort(comparison:  new System.Comparison<UIPanel>(object:  0, method:  public static System.Int32 UIPanel::CompareFunc(UIPanel 丆丛丑世下一丐且丕, UIPanel 丌丗丏丏丛东专丁且)));
    }
    protected override void OnDisable()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 0;
        goto label_2;
        label_9:
        UIDrawCall val_2 = X22.Item[0];
        if(val_2 != 0)
        {
                UIDrawCall.Destroy(丘七专丆丘丛丒丗东:  val_2);
        }
        
        val_6 = 1;
        label_2:
        if(val_6 < this.drawCalls.Count)
        {
            goto label_9;
        }
        
        this.drawCalls.Clear();
        val_7 = null;
        val_7 = null;
        bool val_4 = UIPanel.list.Remove(item:  this);
        mem2[0] = 0;
        if(UIPanel.list.Count == 0)
        {
                UIDrawCall.ReleaseAll();
            val_8 = null;
            val_8 = null;
            UIPanel.丒丕下丐丅丄丒丁丛 = 0;
        }
        
        this.OnDisable();
    }
    private void OnDestroy()
    {
        null = null;
        bool val_2 = UIRoot.丅丘丝不七丝丝三丘.Remove(key:  this.cachedTransform);
    }
    private void 丗丅丁丒一世丂丌丟()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.Matrix4x4 val_8;
        int val_15;
        int val_1 = UnityEngine.Time.frameCount;
        UnityEngine.Transform val_2 = this.cachedTransform;
        if(val_2.hasChanged != false)
        {
                val_2.hasChanged = false;
            val_15 = 0;
            this.丒丈上万丘丁丟丕丄 = val_15;
        }
        else
        {
                val_15 = this.丒丈上万丘丁丟丕丄;
        }
        
        if(val_15 == val_1)
        {
                return;
        }
        
        this.丒丈上万丘丁丟丕丄 = val_1;
        UnityEngine.Matrix4x4 val_4 = val_2.worldToLocalMatrix;
        mem[1152921535347823968] = val_5;
        mem[1152921535347823952] = val_6;
        mem[1152921535347823936] = val_7;
        this.worldToLocal = val_8;
        UnityEngine.Vector2 val_9 = this.GetViewSize();
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  0.5f);
        UnityEngine.Vector2 val_14 = this.mClipOffset;
        val_14 = val_14 + this.mClipRange;
        float val_11 = S4 + S5;
        val_10.x = val_10.x + val_14;
        val_10.y = val_10.y + val_11;
        this.且丛丄丝丘业丞丝丗 = val_14 - val_10.x;
        mem[1152921535347824084] = val_11 - val_10.y;
        this.丐丒丌丂且丙与丙丕 = val_10.x;
        mem[1152921535347824092] = val_10.y;
    }
    protected override void 东七一下丕丛与丑丝()
    {
        float val_51;
        float val_52;
        var val_55;
        int val_56;
        int val_57;
        int val_58;
        int val_59;
        float val_60;
        float val_61;
        float val_62;
        float val_63;
        int val_64;
        UnityEngine.Vector4 val_65;
        int val_66;
        int val_67;
        float val_68;
        int val_69;
        if(this.mClipping == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_1 = this.cachedTransform;
        UnityEngine.Transform val_2 = val_1.parent;
        UnityEngine.Vector2 val_3 = this.GetViewSize();
        UnityEngine.Vector3 val_4 = val_1.localPosition;
        val_51 = val_4.x;
        val_52 = val_4.y;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_4.z});
        float val_61 = val_5.x;
        float val_62 = val_5.y;
        if(((val_1 != (X22 + 16)) || (val_1 != (X22 + 16 + 16))) || (val_1 != (X22 + 16 + 16 + 16)))
        {
            goto label_20;
        }
        
        val_55 = val_1.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_2);
        if(val_55 == null)
        {
            goto label_22;
        }
        
        val_56 = val_9.Length;
        if(val_56 == 0)
        {
                val_56 = val_9.Length;
        }
        
        UnityEngine.Vector3 val_43 = val_55[0];
        float val_10 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_43, 专丂丕丗丗东世丞下:  val_55[3], 丞上与七且与七三丐:  val_4.z);
        val_57 = val_9.Length;
        if(val_57 == 0)
        {
                val_57 = val_9.Length;
        }
        
        val_58 = val_9.Length;
        if(val_58 <= 3)
        {
                val_58 = val_9.Length;
        }
        
        val_59 = val_9.Length;
        if(val_59 <= 3)
        {
                val_59 = val_9.Length;
        }
        
        float val_13 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_55[5], 专丂丕丗丗东世丞下:  val_55[2], 丞上与七且与七三丐:  val_4.z);
        val_60 = val_10 + val_10;
        val_61 = val_13 + val_13;
        val_62 = (万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_55[0], 专丂丕丗丗东世丞下:  val_55[3], 丞上与七且与七三丐:  val_4.z)) + (float)val_43;
        val_63 = (万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_55[5], 专丂丕丗丗东世丞下:  val_55[2], 丞上与七且与七三丐:  val_4.z)) + (float)S15;
        goto label_98;
        label_20:
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
        {
            goto label_43;
        }
        
        UnityEngine.Vector3[] val_15 = val_1.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_2);
        if(val_15 == null)
        {
            goto label_45;
        }
        
        val_64 = val_15.Length;
        if(val_64 == 0)
        {
                val_64 = val_15.Length;
        }
        
        val_51 = val_15[0];
        val_52 = val_15[3];
        float val_16 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_51, 专丂丕丗丗东世丞下:  val_52, 丞上与七且与七三丐:  X22 + 16 + 24);
        goto label_49;
        label_43:
        val_65 = this.mClipRange;
        val_52 = val_3.x * (-0.5f);
        val_60 = val_65 + val_52;
        goto label_50;
        label_45:
        UnityEngine.Vector3 val_17 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_2, 丄上七丟不丗丕下丟:  val_2);
        label_49:
        val_65 = (float)val_17.x;
        val_60 = val_17.x + val_65;
        label_50:
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
            goto label_55;
        }
        
        UnityEngine.Vector3[] val_19 = val_15.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_2);
        if(val_19 == null)
        {
            goto label_57;
        }
        
        val_66 = val_19.Length;
        if(val_66 == 0)
        {
                val_66 = val_19.Length;
        }
        
        val_65 = val_19[0];
        val_52 = val_19[3];
        float val_20 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_65, 专丂丕丗丗东世丞下:  val_52, 丞上与七且与七三丐:  X22 + 16 + 24);
        goto label_61;
        label_55:
        val_52 = val_3.x * 0.5f;
        val_62 = val_52 + this.mClipRange;
        goto label_62;
        label_57:
        UnityEngine.Vector3 val_21 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_2, 丄上七丟不丗丕下丟:  val_2);
        label_61:
        val_62 = val_21.x + (float)val_21.x;
        label_62:
        if((UnityEngine.Object.op_Implicit(exists:  val_19)) == false)
        {
            goto label_67;
        }
        
        UnityEngine.Vector3[] val_23 = val_19.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_2);
        if(val_23 == null)
        {
            goto label_69;
        }
        
        val_67 = val_23.Length;
        if(val_67 <= 3)
        {
                val_67 = val_23.Length;
        }
        
        val_68 = val_23[2];
        float val_24 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_23[5], 专丂丕丗丗东世丞下:  val_68, 丞上与七且与七三丐:  X22 + 16 + 24);
        if(val_23 != null)
        {
            goto label_88;
        }
        
        label_89:
        label_88:
        val_63 = val_24 + val_24;
        goto label_74;
        label_67:
        val_68 = val_3.y * (-0.5f);
        val_63 = (float)val_21.x + val_68;
        label_74:
        if((UnityEngine.Object.op_Implicit(exists:  val_19)) == false)
        {
            goto label_78;
        }
        
        val_55 = val_19.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_2);
        if(val_55 == null)
        {
            goto label_80;
        }
        
        val_69 = val_26.Length;
        if(val_69 <= 3)
        {
                val_69 = val_26.Length;
        }
        
        float val_27 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_55[5], 专丂丕丗丗东世丞下:  val_55[2], 丞上与七且与七三丐:  val_21.z);
        if(val_2 != null)
        {
            goto label_90;
        }
        
        label_91:
        label_90:
        val_61 = val_27 + val_27;
        goto label_98;
        label_78:
        float val_59 = 0.5f;
        val_59 = val_3.y * val_59;
        val_61 = val_59 + (float)val_21.x;
        label_98:
        UnityEngine.Vector2 val_60 = this.mClipOffset;
        val_60 = val_61 + val_60;
        val_61 = val_60 - val_60;
        float val_28 = val_62 - val_60;
        float val_29 = val_62 + val_21.z;
        val_62 = val_63 - val_29;
        float val_30 = val_61 - val_29;
        float val_31 = UnityEngine.Mathf.Lerp(a:  val_61, b:  val_28, t:  0.5f);
        float val_32 = UnityEngine.Mathf.Lerp(a:  val_62, b:  val_30, t:  0.5f);
        val_28 = val_28 - val_61;
        val_30 = val_30 - val_62;
        var val_35 = (val_28 < 0) ? UnityEngine.Mathf.Max(a:  2f, b:  this.mClipSoftness) : (val_28);
        var val_36 = (val_30 < 0) ? UnityEngine.Mathf.Max(a:  2f, b:  this.mClipSoftness) : (val_30);
        this.baseClipRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        return;
        label_69:
        UnityEngine.Vector3 val_37 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_2, 丄上七丟不丗丕下丟:  val_2);
        if(val_23 != null)
        {
            goto label_88;
        }
        
        goto label_89;
        label_80:
        UnityEngine.Vector3 val_38 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_2, 丄上七丟不丗丕下丟:  val_2);
        if(val_2 != null)
        {
            goto label_90;
        }
        
        goto label_91;
        label_22:
        UnityEngine.Vector3 val_39 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_2, 丄上七丟不丗丕下丟:  val_2);
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        float val_63 = (float)val_40.x;
        float val_41 = val_40.x + (float)val_39.z;
        float val_42 = val_40.y + (float)S13;
        val_63 = val_40.x + val_63;
        float val_64 = (float)val_40.x;
        val_64 = val_40.y + val_64;
        goto label_98;
    }
    public static void RefreshAllPanels()
    {
        null = null;
        UIPanel.丒丕下丐丅丄丒丁丛 = 0;
    }
    private void LateUpdate()
    {
        var val_16;
        int val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.List<UIDrawCall> val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        int val_26;
        val_16 = null;
        val_16 = null;
        val_17 = UIPanel.丒丕下丐丅丄丒丁丛;
        if(val_17 == UnityEngine.Time.frameCount)
        {
            goto label_16;
        }
        
        val_18 = null;
        val_18 = null;
        UIPanel.丒丕下丐丅丄丒丁丛 = UnityEngine.Time.frameCount;
        val_17 = 1152921535205043504;
        int val_3 = UIPanel.list.Count;
        val_19 = null;
        var val_4 = ((UIPanel.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
        if(val_3 >= 1)
        {
                val_21 = 1152921535205044528;
            do
        {
            val_22 = null;
            UIPanel.list.Item[0].丆丐丅下丟上上七丄();
            val_23 = null;
            val_24 = 0 + 1;
            var val_6 = ((UIPanel.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
        }
        while(val_3 != val_24);
        
        }
        
        val_23 = null;
        int val_7 = UIPanel.list.Count;
        if(val_7 < 1)
        {
            goto label_16;
        }
        
        label_37:
        val_25 = null;
        val_25 = null;
        val_21 = UIPanel.list.Item[0];
        if(val_21 == null)
        {
            goto label_20;
        }
        
        val_17 = val_8.renderQueue;
        if(val_17 == 0)
        {
            goto label_21;
        }
        
        val_21.丙丗三丒丝万丂东下();
        goto label_22;
        label_20:
        val_17 = 65536;
        if(val_17 == 0)
        {
            goto label_23;
        }
        
        val_17 = 65536;
        val_21.丙丗三丒丝万丂东下();
        label_22:
        int val_9 = val_8.drawCalls.Count;
        if(val_17 != 1)
        {
            goto label_25;
        }
        
        if(val_9 == 0)
        {
            goto label_34;
        }
        
        val_17 = val_8.startingRenderQueue;
        val_21 = val_8.drawCalls.Count;
        val_26 = val_21 + val_17;
        goto label_30;
        label_25:
        if(val_9 == 0)
        {
            goto label_34;
        }
        
        val_17 = val_8.startingRenderQueue;
        val_26 = val_17 + 1;
        label_30:
        int val_11 = UnityEngine.Mathf.Max(a:  184, b:  val_26);
        goto label_34;
        label_21:
        val_8.startingRenderQueue = 3000;
        val_21.丙丗三丒丝万丂东下();
        goto label_35;
        label_23:
        val_8.startingRenderQueue = 3000;
        val_21.丙丗三丒丝万丂东下();
        label_35:
        val_21 = val_8.drawCalls;
        int val_13 = val_21.Count + 3000;
        label_34:
        val_24 = 0 + 1;
        if(val_7 != val_24)
        {
            goto label_37;
        }
        
        label_16:
        if(mem[1152921535348585912] == 0)
        {
                return;
        }
        
        mem[1152921535348585912].Invoke();
    }
    private void 丆丐丅下丟上上七丄()
    {
        var val_5;
        this.丗丅丁丒一世丂丌丟();
        this.丒丒丂专丛下专丐万();
        this.与丒丐丗丆丕一专丁();
        if(this.丕丘丑万万丝丝丝丏 == false)
        {
            goto label_1;
        }
        
        this.丕丘丑万万丝丝丝丏 = false;
        this.丒与与丛业七丅丙丗();
        goto label_2;
        label_1:
        val_5 = 0;
        goto label_11;
        label_13:
        UIDrawCall val_1 = this.drawCalls.Item[0];
        if((val_1.isDirty != false) && ((this.FillDrawCall(丘七专丆丘丛丒丗东:  val_1)) != true))
        {
                UIDrawCall.Destroy(丘七专丆丘丛丒丗东:  val_1);
            this.drawCalls.RemoveAt(index:  0);
        }
        else
        {
                val_5 = 1;
        }
        
        label_11:
        if(val_5 < this.drawCalls.Count)
        {
            goto label_13;
        }
        
        label_2:
        if(this.丐不丈上丁丕万丛一 == false)
        {
                return;
        }
        
        this.丐不丈上丁丕万丛一 = false;
        if(this.丈丌丏丝东丅上丒丙 == 0)
        {
                return;
        }
        
        this.丈丌丏丝东丅上丒丙.UpdateScrollbars();
    }
    public void SortWidgets()
    {
        this.丐丈丆丈丟专丈一丛 = false;
        this.widgets.Sort(comparison:  new System.Comparison<UIWidget>(object:  0, method:  public static System.Int32 UIWidget::PanelCompareFunc(UIWidget 丈丂丕下丏丈丞丗业, UIWidget 丂丌丌丛丆丆丙丌丈)));
    }
    private void 丒与与丛业七丅丙丗()
    {
        UIWidget val_22;
        var val_23;
        var val_24;
        UnityEngine.Object val_25;
        UnityEngine.Object val_26;
        UnityEngine.Object val_27;
        UnityEngine.Object val_28;
        UnityEngine.Object val_29;
        var val_30;
        var val_31;
        UIDrawCall val_32;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_33;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector4> val_34;
        UIDrawCall.丝丂丏世丌丈一与业 val_35;
        val_22 = 1152921505094012928;
        val_23 = 0;
        goto label_1;
        label_6:
        UIDrawCall.Destroy(丘七专丆丘丛丒丗东:  X21.Item[0]);
        val_23 = 1;
        label_1:
        if(val_23 < this.drawCalls.Count)
        {
            goto label_6;
        }
        
        this.drawCalls.Clear();
        if(this.丐丈丆丈丟专丈一丛 != false)
        {
                this.SortWidgets();
        }
        
        val_24 = 0;
        val_25 = 0;
        goto label_36;
        label_69:
        val_22 = this.widgets.Item[0];
        if((val_22.isVisible == false) || (val_22.hasVertices == false))
        {
            goto label_13;
        }
        
        val_26 = val_22;
        val_27 = val_22;
        val_28 = val_22;
        val_29 = 0;
        if(val_29 != val_26)
        {
            goto label_23;
        }
        
        val_29 = 0;
        if(val_29 != val_27)
        {
            goto label_23;
        }
        
        val_29 = val_25;
        if(val_29 == val_28)
        {
            goto label_26;
        }
        
        label_23:
        val_30 = 1152921504848912384;
        val_31 = 1152921505094012928;
        if((0 == 0) || (28563616 == 0))
        {
            goto label_34;
        }
        
        this.drawCalls.Add(item:  0);
        0.UpdateGeometry(专丟丘三丆丌丈下东:  0);
        mem[216] = this.丐丅上丐丑且丗业一;
        val_32 = 0;
        this.丐丅上丐丑且丗业一 = 0;
        goto label_34;
        label_13:
        val_3.drawCall = 0;
        label_67:
        val_24 = 1;
        val_25 = val_25;
        goto label_36;
        label_26:
        val_28 = val_25;
        val_26 = 0;
        val_31 = 1152921505094012928;
        val_30 = 1152921504848912384;
        val_27 = 0;
        label_34:
        if(val_26 == 0)
        {
                if(val_28 == 0)
        {
                if(val_27 == 0)
        {
            goto label_67;
        }
        
        }
        
        }
        
        if(0 != 0)
        {
            goto label_48;
        }
        
        val_32 = UIDrawCall.Create(丛丘下丗业丂一且业:  this, 世丑丘丘丂专丅丆与:  val_26, 丟三丟三丅专丂丄丂:  val_27, 丕丄与专丛丝丄丐下:  val_28, 丆丟丞丌丝丏丒丏丑:  val_22);
        int val_15 = val_22.depth;
        if(val_32 == null)
        {
            goto label_51;
        }
        
        val_14.depthStart = val_15;
        val_14.depthEnd = val_15;
        goto label_52;
        label_48:
        int val_16 = val_22.depth;
        if(val_16 < 0)
        {
                mem[28] = val_16;
        }
        
        if(val_16 <= 64)
        {
            goto label_56;
        }
        
        mem[32] = val_16;
        goto label_56;
        label_51:
        mem[28] = val_15;
        mem[32] = mem[28];
        label_52:
        val_14.panel = this;
        label_56:
        val_3.drawCall = val_32;
        if(val_32 == 0)
        {
            goto label_67;
        }
        
        if(this.generateNormals != false)
        {
                val_33 = val_14.norms;
            val_34 = val_14.tans;
        }
        else
        {
                val_33 = 0;
            val_34 = 0;
        }
        
        val_22.WriteToBuffers(业下丌下三丕丙丌下:  val_14.verts, 丈丂业丏丕不丆业丑:  val_14.uvs, 丁丂专业丁丅丅丈丙:  val_14.cols, 丏丟万且丝丒丝丅东:  val_33, 丙丒七丄上与丏丙丙:  val_34);
        if(val_3.mOnRender == null)
        {
            goto label_67;
        }
        
        if(this.丐丅上丐丑且丗业一 == null)
        {
            goto label_63;
        }
        
        if(((System.Delegate.Combine(a:  this.丐丅上丐丑且丗业一, b:  val_3.mOnRender)) != null) && (null != null))
        {
                val_35 = 0;
        }
        
        this.丐丅上丐丑且丗业一 = val_35;
        goto label_67;
        label_63:
        this.丐丅上丐丑且丗业一 = val_3.mOnRender;
        goto label_67;
        label_36:
        if(val_24 < this.widgets.Count)
        {
            goto label_69;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if(28563616 == 0)
        {
                return;
        }
        
        this.drawCalls.Add(item:  0);
        0.UpdateGeometry(专丟丘三丆丌丈下东:  1);
        mem[216] = this.丐丅上丐丑且丗业一;
        this.丐丅上丐丑且丗业一 = 0;
    }
    public bool FillDrawCall(UIDrawCall 丘七专丆丘丛丒丗东)
    {
        var val_10;
        var val_11;
        bool val_12;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_13;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> val_14;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_15;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector4> val_16;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> val_17;
        UIDrawCall.丝丂丏世丌丈一与业 val_18;
        var val_19;
        if(丘七专丆丘丛丒丗东 == 0)
        {
            goto label_33;
        }
        
        丘七专丆丘丛丒丗东.isDirty = false;
        val_11 = 0;
        val_10 = 0;
        goto label_20;
        label_30:
        UIWidget val_2 = this.widgets.Item[0];
        if(val_2 != 0)
        {
            goto label_9;
        }
        
        this.widgets.RemoveAt(index:  0);
        goto label_20;
        label_9:
        if(val_2.drawCall != 丘七专丆丘丛丒丗东)
        {
            goto label_28;
        }
        
        if((val_2.isVisible == false) || (val_2.hasVertices == false))
        {
            goto label_17;
        }
        
        val_12 = this.generateNormals;
        if(丘七专丆丘丛丒丗东 == null)
        {
            goto label_18;
        }
        
        val_13 = 丘七专丆丘丛丒丗东.verts;
        val_14 = 丘七专丆丘丛丒丗东.uvs;
        goto label_19;
        label_17:
        val_2.drawCall = 0;
        label_28:
        val_11 = 1;
        goto label_20;
        label_18:
        val_14 = 丘七专丆丘丛丒丗东.uvs;
        val_12 = val_12;
        val_13 = 丘七专丆丘丛丒丗东.verts;
        label_19:
        if(val_12 != false)
        {
                val_15 = 丘七专丆丘丛丒丗东.norms;
            val_16 = 丘七专丆丘丛丒丗东.tans;
            val_17 = val_14;
        }
        else
        {
                val_17 = val_14;
            val_15 = 0;
            val_16 = 0;
        }
        
        val_2.WriteToBuffers(业下丌下三丕丙丌下:  val_13, 丈丂业丏丕不丆业丑:  val_17, 丁丂专业丁丅丅丈丙:  丘七专丆丘丛丒丗东.cols, 丏丟万且丝丒丝丅东:  val_15, 丙丒七丄上与丏丙丙:  val_16);
        if(val_2.mOnRender == null)
        {
            goto label_28;
        }
        
        if(this.丐丅上丐丑且丗业一 == null)
        {
            goto label_24;
        }
        
        if(((System.Delegate.Combine(a:  this.丐丅上丐丑且丗业一, b:  val_2.mOnRender)) != null) && (null != null))
        {
                val_18 = 0;
        }
        
        this.丐丅上丐丑且丗业一 = val_18;
        goto label_28;
        label_24:
        this.丐丅上丐丑且丗业一 = val_2.mOnRender;
        goto label_28;
        label_20:
        if(val_11 < this.widgets.Count)
        {
            goto label_30;
        }
        
        丘七专丆丘丛丒丗东.UpdateGeometry(专丟丘三丆丌丈下东:  0);
        val_19 = 1;
        丘七专丆丘丛丒丗东.onRender = this.丐丅上丐丑且丗业一;
        this.丐丅上丐丑且丗业一 = 0;
        return (bool)val_19;
        label_33:
        val_19 = 0;
        return (bool)val_19;
    }
    private void 丙丗三丒丝万丂东下()
    {
        float val_28;
        var val_29;
        float val_30;
        float val_31;
        float val_32;
        UnityEngine.Vector4 val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        float val_40;
        float val_41;
        var val_42;
        bool val_43;
        UnityEngine.Texture2D val_44;
        UnityEngine.Transform val_1 = this.cachedTransform;
        if(this.mClipping != 0)
        {
                UnityEngine.Vector4 val_3 = this.finalClipRegion;
            this.drawCallClipRange = val_3;
            float val_26 = 0.5f;
            mem[1152921535349600676] = val_3.y;
            val_28 = val_3.z * val_26;
            val_26 = val_3.w * val_26;
            val_29 = 1152921535349600680;
            mem[1152921535349600680] = val_28;
            mem[1152921535349600684] = val_26;
        }
        else
        {
                UnityEngine.Vector4 val_4 = UnityEngine.Vector4.zero;
            val_29 = 1152921535349600680;
            this.drawCallClipRange = val_4;
            mem[1152921535349600676] = val_4.y;
            mem[1152921535349600680] = val_4.z;
            mem[1152921535349600684] = val_4.w;
        }
        
        if(null == 0f)
        {
                float val_27 = (float)UnityEngine.Screen.width;
            val_28 = 0.5f;
            val_27 = val_27 * val_28;
            mem[1152921535349600680] = val_27;
        }
        
        if(val_27 == 0f)
        {
                val_28 = 0.5f;
            val_30 = (float)UnityEngine.Screen.height * val_28;
            mem[1152921535349600684] = val_30;
        }
        
        if(this.丆丁专不下丄丟丁丑 != false)
        {
                val_31 = -0.5f;
            val_32 = 0.5f;
            val_33 = this.drawCallClipRange + val_31;
            val_34 = val_28 + val_32;
            this.drawCallClipRange = val_33;
            mem[1152921535349600676] = val_34;
        }
        
        if(this.usedForUI != false)
        {
                UnityEngine.Transform val_8 = this.cachedTransform.parent;
            UnityEngine.Vector3 val_10 = this.cachedTransform.localPosition;
            val_35 = val_10.x;
            val_36 = val_10.y;
            val_37 = val_10.z;
            if(this.mClipping != 0)
        {
                val_35 = (float)UnityEngine.Mathf.RoundToInt(f:  val_35);
            val_30 = val_36;
            val_36 = (float)UnityEngine.Mathf.RoundToInt(f:  val_30);
        }
        
            if(val_8 != 0)
        {
                val_30 = val_35;
            val_28 = val_36;
            val_38 = val_37;
            UnityEngine.Vector3 val_14 = val_8.TransformPoint(position:  new UnityEngine.Vector3() {x = val_30, y = val_28, z = val_38});
            val_35 = val_14.x;
            val_36 = val_14.y;
            val_37 = val_14.z;
        }
        
            UnityEngine.Vector3 val_15 = this.drawCallOffset;
            val_39 = val_35;
            val_40 = val_36;
            val_41 = val_37;
            val_32 = val_15.x;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, b:  new UnityEngine.Vector3() {x = val_32, y = val_15.y, z = val_15.z});
        }
        else
        {
                UnityEngine.Vector3 val_17 = val_1.position;
        }
        
        UnityEngine.Quaternion val_18 = val_1.rotation;
        UnityEngine.Vector3 val_19 = val_1.lossyScale;
        val_42 = 0;
        goto label_35;
        label_39:
        UIDrawCall val_20 = this.drawCalls.Item[0];
        UnityEngine.Transform val_21 = val_20.cachedTransform;
        if(val_21 != null)
        {
                val_21.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            val_21.rotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        }
        else
        {
                0.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            val_21.rotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        }
        
        val_21.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        val_20.renderQueue = ((this.renderQueue == 2) ? 0 : (val_42)) + this.startingRenderQueue;
        if(this.alwaysOnScreen == false)
        {
            goto label_30;
        }
        
        if(this.mClipping == 0)
        {
            goto label_31;
        }
        
        if(val_20 == null)
        {
            goto label_37;
        }
        
        label_36:
        val_20.alwaysOnScreen = (this.mClipping == 4) ? 1 : 0;
        val_20.sortingOrder = this.mSortingOrder;
        val_44 = this.mClipTexture;
        goto label_33;
        label_30:
        val_43 = false;
        if(val_20 != null)
        {
            goto label_36;
        }
        
        label_37:
        val_20.alwaysOnScreen = val_43;
        val_20.sortingOrder = this.mSortingOrder;
        val_44 = this.mClipTexture;
        label_33:
        val_42 = 1;
        val_20.clipTexture = val_44;
        goto label_35;
        label_31:
        if(val_20 != null)
        {
            goto label_36;
        }
        
        goto label_37;
        label_35:
        if(val_42 < this.drawCalls.Count)
        {
            goto label_39;
        }
    
    }
    private void 丒丒丂专丛下专丐万()
    {
        int val_13;
        var val_14;
        val_13 = this.丝万不业丂丏丌且丄;
        UnityEngine.GameObject val_1 = this.cachedGameObject;
        if(val_13 == val_1.layer)
        {
                return;
        }
        
        this.丝万不业丂丏丌且丄 = val_1.layer;
        int val_4 = this.widgets.Count;
        if(val_4 >= 1)
        {
                var val_13 = 0;
            do
        {
            UIWidget val_5 = this.widgets.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
        {
                if(val_5.parent == this)
        {
                val_5.gameObject.layer = this.丝万不业丂丏丌且丄;
        }
        
        }
        
            val_13 = val_13 + 1;
        }
        while(val_4 != val_13);
        
        }
        
        this.ResetAnchors();
        val_14 = 0;
        goto label_17;
        label_22:
        this.drawCalls.Item[0].gameObject.layer = this.丝万不业丂丏丌且丄;
        val_14 = 1;
        label_17:
        val_13 = this.drawCalls;
        if(val_14 < val_13.Count)
        {
            goto label_22;
        }
    
    }
    private void 与丒丐丗丆丕一专丁()
    {
        var val_23;
        bool val_24;
        UIPanel val_25;
        bool val_26;
        bool val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        if(this.cullWhileDragging == false)
        {
            goto label_1;
        }
        
        val_23 = 0;
        if(this.丏丂丅丛丄万万与一 == false)
        {
            goto label_42;
        }
        
        label_41:
        val_23 = false;
        this.丏丂丅丛丄万万与一 = false;
        this.丆下业丈丑丌丆七丒 = true;
        label_42:
        int val_2 = UnityEngine.Time.frameCount;
        int val_3 = this.widgets.Count;
        if(val_3 <= 0)
        {
            goto label_4;
        }
        
        val_24 = 0;
        var val_22 = 0;
        label_24:
        UIWidget val_4 = this.widgets.Item[0];
        val_25 = val_4.panel;
        if((val_25 != this) || (val_4.enabled == false))
        {
            goto label_23;
        }
        
        if((val_4.UpdateTransform(丒丄丙丄丅丅业丏万:  val_2)) != true)
        {
                if(this.丆下业丈丑丌丆七丒 == false)
        {
            goto label_12;
        }
        
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_13;
        }
        
        val_25 = 1;
        label_16:
        val_26 = 1;
        goto label_14;
        label_13:
        if(this.clipCount == 0)
        {
                if(val_4.hideIfOffScreen == false)
        {
            goto label_16;
        }
        
        }
        
        val_26 = this.IsVisible(与丘东下丈东丛丂万:  val_4);
        label_14:
        bool val_11 = val_4.UpdateVisibility(七丆三丘上丟丂丆丒:  ((val_4.CalculateCumulativeAlpha(与专丙丝丝且丂且丒:  val_2)) > 0.001f) ? 1 : 0, 七丌丟丂三丒丆丑上:  val_26);
        label_12:
        if((val_4.UpdateGeometry(丒丄丙丄丅丅业丏万:  val_2)) == false)
        {
            goto label_23;
        }
        
        if(this.丕丘丑万万丝丝丝丏 == true)
        {
            goto label_18;
        }
        
        val_25 = val_4.drawCall;
        if(val_25 == 0)
        {
            goto label_21;
        }
        
        val_24 = true;
        val_4.drawCall.isDirty = val_24;
        goto label_23;
        label_21:
        UIDrawCall val_14 = this.FindDrawCall(与丘东下丈东丛丂万:  val_4);
        label_18:
        val_24 = 1;
        label_23:
        val_22 = val_22 + 1;
        if(val_3 != val_22)
        {
            goto label_24;
        }
        
        if(((val_24 & 1) != 0) && (this.onGeometryUpdated != null))
        {
                this.onGeometryUpdated.Invoke();
        }
        
        val_27 = this.丆下业丈丑丌丆七丒;
        goto label_27;
        label_1:
        val_28 = 0;
        val_29 = 0;
        goto label_28;
        label_40:
        val_30 = null;
        val_30 = null;
        val_28 = 1;
        label_28:
        val_31 = null;
        val_31 = null;
        if(val_28 < (UIScrollView.list + 24))
        {
            goto label_40;
        }
        
        if((((((UIScrollView.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0).isDragging) & true) != 0) ? (val_29) : (0 + 1)) & 1) != ((this.丏丂丅丛丄万万与一 == true) ? 1 : 0))
        {
            goto label_41;
        }
        
        goto label_42;
        label_4:
        val_27 = this.丆下业丈丑丌丆七丒;
        label_27:
        mem2[0] = 0;
    }
    public UIDrawCall FindDrawCall(UIWidget 与丘东下丈东丛丂万)
    {
        UnityEngine.Object val_14;
        int val_15;
        System.Collections.Generic.List<UIDrawCall> val_16;
        var val_17;
        var val_18;
        var val_19;
        val_14 = 与丘东下丈东丛丂万;
        int val_1 = 与丘东下丈东丛丂万.depth;
        val_15 = 0;
        label_17:
        val_16 = this.drawCalls;
        if(val_15 >= val_16.Count)
        {
            goto label_25;
        }
        
        val_16 = this.drawCalls.Item[0];
        if(val_15 != 0)
        {
                UIDrawCall val_5 = this.drawCalls.Item[val_15 - 1];
            val_17 = val_5.depthEnd + 1;
        }
        else
        {
                val_17 = -2147483648;
        }
        
        val_15 = val_15 + 1;
        if(val_15 == this.drawCalls.Count)
        {
                val_18 = 2147483647;
        }
        else
        {
                UIDrawCall val_7 = this.drawCalls.Item[val_15];
            val_18 = val_7.depthStart - 1;
        }
        
        if((val_17 > val_1) || (val_18 < val_1))
        {
            goto label_17;
        }
        
        if(val_16.baseMaterial != val_14)
        {
            goto label_25;
        }
        
        val_14 = val_16.mainTexture;
        if(val_14 != 与丘东下丈东丛丂万)
        {
            goto label_25;
        }
        
        val_19 = 0;
        if(与丘东下丈东丛丂万.isVisible == false)
        {
                return (UIDrawCall)val_19;
        }
        
        if(与丘东下丈东丛丂万 == null)
        {
            goto label_28;
        }
        
        与丘东下丈东丛丂万.drawCall = val_16;
        goto label_29;
        label_25:
        val_19 = 0;
        this.丕丘丑万万丝丝丝丏 = true;
        return (UIDrawCall)val_19;
        label_28:
        mem[328] = val_16;
        label_29:
        if(与丘东下丈东丛丂万.hasVertices == false)
        {
                return (UIDrawCall)val_19;
        }
        
        val_3.isDirty = true;
        return (UIDrawCall)val_19;
    }
    public void AddWidget(UIWidget 与丘东下丈东丛丂万)
    {
        System.Collections.Generic.List<UIWidget> val_8;
        var val_9;
        var val_10;
        this.丐不丈上丁丕万丛一 = true;
        if(this.widgets.Count == 0)
        {
            goto label_2;
        }
        
        val_8 = this.widgets;
        if(val_8 == null)
        {
            goto label_3;
        }
        
        if(this.丐丈丆丈丟专丈一丛 == false)
        {
            goto label_4;
        }
        
        label_8:
        val_8.Add(item:  与丘东下丈东丛丂万);
        this.SortWidgets();
        goto label_11;
        label_2:
        val_8 = this.widgets;
        val_8.Add(item:  与丘东下丈东丛丂万);
        goto label_11;
        label_3:
        if(this.丐丈丆丈丟专丈一丛 == true)
        {
            goto label_8;
        }
        
        label_4:
        val_8 = this.widgets;
        if((UIWidget.PanelCompareFunc(丈丂丕下丏丈丞丗业:  与丘东下丈东丛丂万, 丂丌丌丛丆丆丙丌丈:  val_8.Item[0])) == 1)
        {
            goto label_10;
        }
        
        val_8 = val_8.Count;
        label_13:
        if(val_8 <= 0)
        {
            goto label_11;
        }
        
        val_8 = val_8 - 1;
        if((UIWidget.PanelCompareFunc(丈丂丕下丏丈丞丗业:  与丘东下丈东丛丂万, 丂丌丌丛丆丆丙丌丈:  this.widgets.Item[val_8])) == 1)
        {
            goto label_13;
        }
        
        val_8 = val_8 + 1;
        val_9 = 1152921535350373600;
        val_10 = val_8;
        goto label_15;
        label_10:
        val_9 = 1152921535350373600;
        val_10 = 0;
        label_15:
        val_8.Insert(index:  0, item:  与丘东下丈东丛丂万);
        label_11:
        UIDrawCall val_7 = this.FindDrawCall(与丘东下丈东丛丂万:  与丘东下丈东丛丂万);
    }
    public void RemoveWidget(UIWidget 与丘东下丈东丛丂万)
    {
        System.Collections.Generic.List<UIWidget> val_4 = this.widgets;
        if((val_4.Remove(item:  与丘东下丈东丛丂万)) == false)
        {
                return;
        }
        
        val_4 = 与丘东下丈东丛丂万.drawCall;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = 与丘东下丈东丛丂万.depth;
        if(val_4 != 与丘东下丈东丛丂万.drawCall.depthStart)
        {
                if(val_4 != 与丘东下丈东丛丂万.drawCall.depthEnd)
        {
            goto label_10;
        }
        
        }
        
        this.丕丘丑万万丝丝丝丏 = true;
        label_10:
        与丘东下丈东丛丂万.drawCall.isDirty = true;
        与丘东下丈东丛丂万.drawCall = 0;
    }
    public void Refresh()
    {
        var val_3;
        var val_4;
        this.丕丘丑万万丝丝丝丏 = true;
        val_3 = null;
        val_3 = null;
        UIPanel.丒丕下丐丅丄丒丁丛 = 0;
        if(UIPanel.list.Count < 1)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UIPanel.list.Item[0].LateUpdate();
    }
    public virtual UnityEngine.Vector3 CalculateConstrainOffset(UnityEngine.Vector2 丒丛七丄世业东丝丁, UnityEngine.Vector2 七丝东丛东丝且丆不)
    {
        UnityEngine.Vector4 val_1 = this.finalClipRegion;
        float val_2 = val_1.z * 0.5f;
        float val_3 = val_1.w * 0.5f;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  丒丛七丄世业东丝丁.x, y:  丒丛七丄世业东丝丁.y);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  七丝东丛东丝且丆不.x, y:  七丝东丛东丝且丆不.y);
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_1.x - val_2, y:  val_1.y - val_3);
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_1.x + val_2, y:  val_1.y + val_3);
        if((this.softBorderPadding != false) && (this.mClipping == 3))
        {
                float val_15 = val_8.x;
            UnityEngine.Vector2 val_16 = this.mClipSoftness;
            val_15 = val_15 + val_16;
            val_16 = val_11.x - val_16;
            float val_17 = val_8.y;
            val_17 = val_17 + val_11.x;
        }
        
        UnityEngine.Vector2 val_13 = 万丗丅且丄丑世专与.且丒丝不且与业与且(上丑丗丞业丛丟丂丄:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, 业丒世丙七丁丝上三:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, 专丐丑且丌丒丛丝丕:  new UnityEngine.Vector2() {x = val_15, y = val_17}, 丈万专不世且丅不丑:  new UnityEngine.Vector2() {x = val_16, y = val_11.y - val_11.x});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        return new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    public bool ConstrainTargetToBounds(UnityEngine.Transform 丞下万上三丘上与专, ref UnityEngine.Bounds 不且丆东丝丟丛丅东, bool 丌丄丗七丝丘与丆与)
    {
        UnityEngine.Object val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_27;
        var val_28;
        val_18 = 丞下万上三丘上与专;
        val_19 = V0.16B;
        val_20 = V1.16B;
        val_21 = V2.16B;
        val_22 = V0.16B;
        val_23 = V1.16B;
        val_24 = V2.16B;
        val_25 = 1f;
        if(this.mClipping == 0)
        {
                UIRoot val_1 = this.root;
            if(val_1 != 0)
        {
                val_25 = val_1.pixelSizeAdjustment;
            if(val_25 == 1f)
        {
                val_25 = 1f;
        }
        else
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, d:  val_25);
            val_19 = val_4.x;
            val_20 = val_4.y;
            val_21 = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, d:  val_25);
            val_22 = val_5.x;
            val_23 = val_5.y;
            val_24 = val_5.z;
        }
        
        }
        
        }
        
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21});
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24});
        val_27 = val_6.y;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_27, z = val_7.x}, d:  val_25);
        if(val_8.x <= 0f)
        {
            goto label_14;
        }
        
        if(val_18 == null)
        {
            goto label_15;
        }
        
        if(丌丄丗七丝丘与丆与 == false)
        {
            goto label_16;
        }
        
        label_27:
        UnityEngine.Vector3 val_9 = val_18.localPosition;
        val_22 = val_8.x;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_8.z});
        val_25 = val_10.x;
        val_27 = val_10.z;
        val_18.localPosition = new UnityEngine.Vector3() {x = val_25, y = val_10.y, z = val_27};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25, y = val_10.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_18 = val_18.GetComponent<SpringPosition>();
        if(val_18 == 0)
        {
            goto label_25;
        }
        
        val_18.enabled = false;
        goto label_25;
        label_14:
        val_28 = 0;
        return (bool)val_28;
        label_15:
        if(丌丄丗七丝丘与丆与 == true)
        {
            goto label_27;
        }
        
        label_16:
        UnityEngine.Vector3 val_15 = val_18.localPosition;
        val_22 = val_8.x;
        val_27 = val_8.z;
        val_25 = val_15.x;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_27});
        val_18 = SpringPosition.Begin(丝三丁东丈丒世丅业:  val_18.gameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丛上丟丌丄丗丁世与:  13f);
        if(val_18 != null)
        {
                val_17.ignoreTimeScale = true;
        }
        else
        {
                mem[41] = 1;
        }
        
        val_17.worldSpace = false;
        label_25:
        val_28 = 1;
        return (bool)val_28;
    }
    public bool ConstrainTargetToBounds(UnityEngine.Transform 丞下万上三丘上与专, bool 丌丄丗七丝丘与丆与)
    {
        float val_3;
        float val_4;
        UnityEngine.Bounds val_2 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  this.cachedTransform, 三丏丑不业丏不丂丈:  丞下万上三丘上与专);
        return (bool)this.ConstrainTargetToBounds(丞下万上三丘上与专:  丞下万上三丘上与专, 不且丆东丝丟丛丅东: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, m_Extents = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, 丌丄丗七丝丘与丆与:  丌丄丗七丝丘与丆与);
    }
    public static UIPanel Find(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        return UIPanel.Find(丄上七丟不丗丕下丟:  丄上七丟不丗丕下丟, 丐丗丏东丘东丘丈且:  false, 且丅丟丛丛万丝下上:  0);
    }
    public static UIPanel Find(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 丐丗丏东丘东丘丈且)
    {
        丐丗丏东丘东丘丈且 = 丐丗丏东丘东丘丈且;
        return UIPanel.Find(丄上七丟不丗丕下丟:  丄上七丟不丗丕下丟, 丐丗丏东丘东丘丈且:  丐丗丏东丘东丘丈且, 且丅丟丛丛万丝下上:  0);
    }
    public static UIPanel Find(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 丐丗丏东丘东丘丈且, int 且丅丟丛丛万丝下上)
    {
        UnityEngine.Transform val_10;
        UnityEngine.Transform val_11;
        var val_12;
        var val_13;
        val_10 = 丄上七丟不丗丕下丟;
        UIPanel val_1 = 0;
        val_11 = val_10;
        goto label_1;
        label_9:
        val_12 = null;
        val_12 = null;
        if((UIRoot.丅丘丝不七丝丝三丘.TryGetValue(key:  val_11, value: out  val_1)) == true)
        {
            goto label_5;
        }
        
        val_11 = val_11.parent;
        label_1:
        if(val_11 != 0)
        {
            goto label_9;
        }
        
        label_5:
        if(val_1 == 0)
        {
            goto label_12;
        }
        
        val_13 = val_1;
        return (UIPanel)val_13;
        label_18:
        val_10 = val_10.parent;
        label_12:
        if(val_10.parent != 0)
        {
            goto label_18;
        }
        
        if(丐丗丏东丘东丘丈且 != false)
        {
                UIPanel val_9 = 不丌丂丁丄一与丆丙.丁丄丘万东丑丕万一(丄上七丟不丗丕下丟:  val_10, 专丆七上丆丈丈丂万:  false, 且丅丟丛丛万丝下上:  且丅丟丛丛万丝下上);
            return (UIPanel)val_13;
        }
        
        val_13 = 0;
        return (UIPanel)val_13;
    }
    public UnityEngine.Vector2 GetWindowSize()
    {
        float val_9;
        float val_10;
        UIRoot val_1 = this.root;
        UnityEngine.Vector2 val_2 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        val_9 = val_2.x;
        val_10 = val_2.y;
        if(val_1 == 0)
        {
                return new UnityEngine.Vector2() {x = val_9, y = val_10};
        }
        
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, d:  val_1.GetPixelSizeAdjustment(丟丌丐丘丆丙丑丑一:  UnityEngine.Mathf.RoundToInt(f:  val_10)));
        val_9 = val_6.x;
        val_10 = val_6.y;
        return new UnityEngine.Vector2() {x = val_9, y = val_10};
    }
    public UnityEngine.Vector2 GetViewSize()
    {
        if(this.mClipping != 0)
        {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        
        UnityEngine.Vector2 val_2 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
    }
    public UIPanel()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.Matrix4x4 val_7;
        this.showInPanelTool = true;
        this.cullWhileDragging = true;
        this.softBorderPadding = true;
        this.startingRenderQueue = 3000;
        this.widgets = new System.Collections.Generic.List<UIWidget>();
        this.drawCalls = new System.Collections.Generic.List<UIDrawCall>();
        UnityEngine.Matrix4x4 val_3 = UnityEngine.Matrix4x4.identity;
        mem[1152921535351910368] = val_4;
        mem[1152921535351910352] = val_5;
        mem[1152921535351910336] = val_6;
        this.worldToLocal = val_7;
        this.drawCallClipRange = 0;
        mem[1152921535351910388] = 0;
        mem[1152921535351910396] = 0;
        this.mAlpha = 1f;
        this.mClipRange = 0;
        mem[1152921535351910428] = 0;
        mem[1152921535351910436] = 0;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  4f, y:  4f);
        this.mClipSoftness = val_8.x;
        mem[1152921535351910444] = val_8.y;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        this.mClipOffset = val_9;
        mem[1152921535351910464] = val_9.y;
        this.丒丈上万丘丁丟丕丄 = 0;
        this.丝万不业丂丏丌且丄 = 0;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        this.且丛丄丝丘业丞丝丗 = val_10;
        mem[1152921535351910484] = val_10.y;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        this.丐丒丌丂且丙与丙丕 = val_11;
        mem[1152921535351910492] = val_11.y;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        this.世下丐丐下专下七丑 = val_12;
        mem[1152921535351910516] = val_12.y;
    }
    private static UIPanel()
    {
        UIPanel.list = new System.Collections.Generic.List<UIPanel>();
        UIPanel.丑下丅三万下丌丈丒 = new float[4];
        UIPanel.三丑丄丄丘丛丐世不 = new UnityEngine.Vector3[4];
        UIPanel.丒丕下丐丅丄丒丁丛 = 0;
    }

}
