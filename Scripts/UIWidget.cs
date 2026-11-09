using UnityEngine;
public class UIWidget : UIRect
{
    // Fields
    private bool _isMinimapLabel;
    protected UnityEngine.Color mColor;
    protected UIWidget.七丐与七丌不丂丞且 mPivot;
    protected int mWidth;
    protected int mHeight;
    protected int mDepth;
    public UIWidget.丒万丟丆丝丐丟下且 onChange;
    public UIDrawCall.丝丂丏世丌丈一与业 mOnRender;
    public bool autoResizeBoxCollider;
    public bool hideIfOffScreen;
    public UIWidget.丐丂丅丟丑丘丑上丈 keepAspectRatio;
    public float aspectRatio;
    public UIPanel panel;
    public 丏丌业丑万丐丐不丙 geometry;
    public bool fillGeometry;
    protected bool 丅三丒上万丗丗丄丝;
    protected UnityEngine.Vector4 万丈丅不丌丗业丕丙;
    private UnityEngine.Matrix4x4 丄世丘且万且七丏东;
    private bool 丅丆专丛丛丈上丆万;
    private bool 丆专万与一丒丕丐下;
    private bool 一七且且丗丞丂丘专;
    private float 上业丘专丆丏东下丂;
    private bool 丌东丟三丈丄万业丂;
    public UIDrawCall drawCall;
    protected UnityEngine.Vector3[] 三丑丄丄丘丛丐世不;
    private int 不不丙丈与专丄丏丌;
    private int 丒丈上万丘丁丟丕丄;
    private UnityEngine.Vector3 丝下万丈丙丏丛丞与;
    private UnityEngine.Vector3 下三丐一丌下丘丞与;
    
    // Properties
    public UIDrawCall.丝丂丏世丌丈一与业 丂丈丛丐丏丘丆丑丐 { get; set; }
    public UnityEngine.Vector4 丛丅丞三丝丛丝专专 { get; set; }
    public UnityEngine.Vector2 丗上下丐上丒丗与丆 { get; }
    public int 业与三万七丝不万东 { get; set; }
    public int 丟丌丐丘丆丙丑丑一 { get; set; }
    public UnityEngine.Color 丑丞丈丗丄丙丟万丄 { get; set; }
    public override float 与专丌丅丙上丌一丄 { get; set; }
    public bool 不与万丌一丈下丑丈 { get; }
    public bool 专丄丆业业专一丅七 { get; }
    public UIWidget.七丐与七丌不丂丞且 丒丌专丙丒丒丐丂丄 { get; set; }
    public UIWidget.七丐与七丌不丂丞且 不丌丕不七丗丞万万 { get; set; }
    public int 丟丕丞丁丝丂上丄上 { get; set; }
    public int 丂丟丝一一丑万丌与 { get; }
    public override UnityEngine.Vector3[] 丝下丒丙丂万丆丞业 { get; }
    public virtual UnityEngine.Vector2 丟丘丞丟世东丒丟丅 { get; }
    public UnityEngine.Vector3 且丌丆不丞上丅丂丂 { get; }
    public override UnityEngine.Vector3[] 丈丞上三七丌丑业丛 { get; }
    public UnityEngine.Vector3 丛万万丆不东七丗丌 { get; }
    public virtual UnityEngine.Vector4 丈丅且丛丑丞万丁丝 { get; }
    public virtual UnityEngine.Material 丘上专不丂万业不一 { get; set; }
    public virtual UnityEngine.Texture 丒丕世丏丆丗三专丑 { get; set; }
    public virtual UnityEngine.Texture 丐丅与世七不丌丙丆 { get; set; }
    public virtual UnityEngine.Shader 丕丄与专丛丝丄丐下 { get; set; }
    public UnityEngine.Vector2 业丝丞丐丁东丗上下 { get; }
    public bool 一与与丞不丞丕下专 { get; }
    public virtual int 上专上丛丈丆丗丒丟 { get; }
    public virtual int 丐丆丏丂上丒丗丌丁 { get; }
    public virtual UnityEngine.Vector4 业三丏专丘专丏丛与 { get; set; }
    
    // Methods
    public UIDrawCall.丝丂丏世丌丈一与业 get_onRender()
    {
        return (UIDrawCall.丝丂丏世丌丈一与业)this.mOnRender;
    }
    public void set_onRender(UIDrawCall.丝丂丏世丌丈一与业 丙业与丙丗丝不丈东)
    {
        UIDrawCall val_9;
        System.Delegate val_10;
        var val_11;
        UIDrawCall val_12;
        val_10 = 丙业与丙丗丝不丈东;
        if((System.Delegate.op_Inequality(d1:  this.mOnRender, d2:  val_10)) == false)
        {
                return;
        }
        
        if(((this.drawCall == 0) || (this.drawCall.onRender == null)) || (this.mOnRender == null))
        {
            goto label_7;
        }
        
        if(this.drawCall == null)
        {
            goto label_8;
        }
        
        val_11 = System.Delegate.Remove(source:  this.drawCall.onRender, value:  this.mOnRender);
        if(val_11 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        val_11 = System.Delegate.Remove(source:  this.drawCall.onRender, value:  this.mOnRender);
        if(val_11 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_12:
        mem2[0] = val_11;
        label_7:
        this.mOnRender = val_10;
        val_9 = this.drawCall;
        if(val_9 == 0)
        {
                return;
        }
        
        val_12 = this.drawCall;
        if(val_12 == null)
        {
            goto label_16;
        }
        
        val_10 = System.Delegate.Combine(a:  this.drawCall.onRender, b:  val_10);
        if(val_10 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        val_12 = 216;
        val_10 = System.Delegate.Combine(a:  496, b:  val_10);
        if(val_10 == null)
        {
            goto label_20;
        }
        
        label_17:
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_20:
        mem[216] = val_10;
    }
    public UnityEngine.Vector4 get_drawRegion()
    {
        return new UnityEngine.Vector4() {x = this.万丈丅不丌丗业丕丙};
    }
    public void set_drawRegion(UnityEngine.Vector4 丙业与丙丗丝不丈东)
    {
        float val_14;
        float val_15;
        var val_16;
        double val_17;
        double val_18;
        val_14 = 丙业与丙丗丝不丈东.w;
        val_15 = 丙业与丙丗丝不丈东.y;
        val_16 = this;
        if((UnityEngine.Vector4.op_Inequality(lhs:  new UnityEngine.Vector4() {x = this.万丈丅不丌丗业丕丙, y = V14.16B, z = V13.16B, w = V12.16B}, rhs:  new UnityEngine.Vector4() {x = 丙业与丙丗丝不丈东.x, y = val_15, z = 丙业与丙丗丝不丈东.z, w = val_14})) == false)
        {
                return;
        }
        
        this.万丈丅不丌丗业丕丙 = 丙业与丙丗丝不丈东;
        mem[1152921535245428480] = val_15;
        mem[1152921535245428484] = 丙业与丙丗丝不丈东.z;
        mem[1152921535245428488] = val_14;
        if(this.autoResizeBoxCollider != false)
        {
                this.ResizeCollider();
        }
        
        val_16 = ???;
        val_14 = ???;
        val_15 = ???;
        val_18 = ???;
        val_17 = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_338;
    }
    public UnityEngine.Vector2 get_pivotOffset()
    {
        return 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
    }
    public int get_width()
    {
        return (int)this.mWidth;
    }
    public void set_width(int 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_7;
        var val_8;
        var val_9;
        int val_1 = (this > 丙业与丙丗丝不丈东) ? (this) : 丙业与丙丗丝不丈东;
        if(this.mWidth == val_1)
        {
                return;
        }
        
        if(this.keepAspectRatio == 2)
        {
                return;
        }
        
        if(this.isAnchoredHorizontally == false)
        {
            goto label_3;
        }
        
        if(mem[137154576] == 0)
        {
            goto label_11;
        }
        
        val_7 = mem[mem[137154576] + 16];
        val_7 = mem[137154576] + 16;
        if(val_7 == 0)
        {
            goto label_11;
        }
        
        七丐与七丌不丂丞且 val_7 = this.mPivot;
        if(val_7 > 8)
        {
            goto label_14;
        }
        
        val_7 = 1 << val_7;
        if((val_7 & 73) != 0)
        {
            goto label_13;
        }
        
        val_7 = val_7 & 292;
        if(val_7 == 0)
        {
            goto label_14;
        }
        
        val_8 = this.mWidth - val_1;
        goto label_23;
        label_3:
        this.SetDimensions(与丘东下丈东丛丂万:  val_1, 一丗世三专三万丞丞:  this.mHeight);
        return;
        label_11:
        val_7 = mem[mem[137154576] + 16];
        val_7 = mem[137154576] + 16;
        if(val_7 == 0)
        {
            goto label_19;
        }
        
        val_9 = val_1 - this.mWidth;
        goto label_20;
        label_19:
        val_8 = this.mWidth - val_1;
        goto label_23;
        label_13:
        val_9 = val_1 - this.mWidth;
        label_20:
        label_23:
        万丗丅且丄丑世专与.下下业丈专丘丛丆丙(与丘东下丈东丛丂万:  this, 丈丂丕下丏丈丞丗业:  0f, 专丙丗业世丐与丝丙:  0f, 丂丌丌丛丆丆丙丌丈:  (float)val_9, 世丂丘万丛万丞丞丌:  0f);
        return;
        label_14:
        int val_8 = this.mWidth;
        val_8 = val_1 - val_8;
        val_8 = val_8 & 4294967294;
        if(val_8 == 0)
        {
                return;
        }
        
        float val_10 = 0.5f;
        float val_9 = (float)val_8;
        val_9 = val_9 * val_10;
        val_10 = ((float)-val_8) * val_10;
        goto label_23;
    }
    public int get_height()
    {
        return (int)this.mHeight;
    }
    public void set_height(int 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_7;
        var val_8;
        var val_9;
        int val_1 = (this > 丙业与丙丗丝不丈东) ? (this) : 丙业与丙丗丝不丈东;
        if(this.mHeight == val_1)
        {
                return;
        }
        
        if(this.keepAspectRatio == 1)
        {
                return;
        }
        
        if(this.isAnchoredVertically == false)
        {
            goto label_3;
        }
        
        if(mem[137154576] == 0)
        {
            goto label_11;
        }
        
        val_7 = mem[mem[137154576] + 16];
        val_7 = mem[137154576] + 16;
        if(val_7 == 0)
        {
            goto label_11;
        }
        
        七丐与七丌不丂丞且 val_7 = this.mPivot;
        if(val_7 < 3)
        {
            goto label_12;
        }
        
        val_7 = val_7 - 6;
        if(val_7 > 2)
        {
            goto label_13;
        }
        
        val_8 = val_1 - this.mHeight;
        goto label_19;
        label_3:
        this.SetDimensions(与丘东下丈东丛丂万:  this.mWidth, 一丗世三专三万丞丞:  val_1);
        return;
        label_11:
        val_7 = mem[mem[137154576] + 16];
        val_7 = mem[137154576] + 16;
        if(val_7 == 0)
        {
            goto label_18;
        }
        
        val_8 = val_1 - this.mHeight;
        goto label_19;
        label_18:
        val_9 = this.mHeight - val_1;
        goto label_20;
        label_12:
        val_9 = this.mHeight - val_1;
        label_20:
        label_19:
        万丗丅且丄丑世专与.下下业丈专丘丛丆丙(与丘东下丈东丛丂万:  this, 丈丂丕下丏丈丞丗业:  0f, 专丙丗业世丐与丝丙:  (float)val_9, 丂丌丌丛丆丆丙丌丈:  0f, 世丂丘万丛万丞丞丌:  0f);
        return;
        label_13:
        int val_8 = this.mHeight;
        val_8 = val_1 - val_8;
        val_8 = val_8 & 4294967294;
        if(val_8 == 0)
        {
                return;
        }
        
        float val_9 = 0.5f;
        float val_6 = (float)val_8 * val_9;
        val_9 = ((float)-val_8) * val_9;
        goto label_19;
    }
    public UnityEngine.Color get_color()
    {
        return new UnityEngine.Color() {r = this.mColor};
    }
    public void set_color(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        float val_10;
        float val_11;
        val_10 = 丙业与丙丗丝不丈东.g;
        val_11 = 丙业与丙丗丝不丈东.a;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.mColor, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a}, rhs:  new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = val_10, b = 丙业与丙丗丝不丈东.b, a = val_11})) == false)
        {
                return;
        }
        
        this.mColor = 丙业与丙丗丝不丈东;
        mem[1152921535246253352] = val_10;
        mem[1152921535246253356] = 丙业与丙丗丝不丈东.b;
        mem[1152921535246253360] = val_11;
        val_11 = ???;
        var val_2 = (this.mColor != val_11) ? 1 : 0;
        val_10 = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_1E8;
    }
    public override float get_alpha()
    {
        return (float)S0;
    }
    public override void set_alpha(float 丙业与丙丗丝不丈东)
    {
        if(S1 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        mem[1152921535246477360] = 丙业与丙丗丝不丈东;
        goto typeof(UIWidget).__il2cppRuntimeField_1E8;
    }
    public bool get_isVisible()
    {
        if(this.丆专万与一丒丕丐下 == false)
        {
                return false;
        }
        
        if(this.丅丆专丛丛丈上丆万 == false)
        {
                return false;
        }
        
        if(this.一七且且丗丞丂丘专 == false)
        {
                return false;
        }
        
        if(S0 <= 0.001f)
        {
                return false;
        }
        
        return 不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this);
    }
    public bool get_hasVertices()
    {
        if(this.geometry == null)
        {
                return (bool)this.geometry;
        }
        
        return this.geometry.丗丁丅丗三下丂丘一();
    }
    public UIWidget.七丐与七丌不丂丞且 get_rawPivot()
    {
        return (七丐与七丌不丂丞且)this.mPivot;
    }
    public void set_rawPivot(UIWidget.七丐与七丌不丂丞且 丙业与丙丗丝不丈东)
    {
        if(this.mPivot == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mPivot = 丙业与丙丗丝不丈东;
        if(this.autoResizeBoxCollider != false)
        {
                this.ResizeCollider();
        }
    
    }
    public UIWidget.七丐与七丌不丂丞且 get_pivot()
    {
        return (七丐与七丌不丂丞且)this.mPivot;
    }
    public void set_pivot(UIWidget.七丐与七丌不丂丞且 丙业与丙丗丝不丈东)
    {
        var val_11;
        var val_15;
        var val_16;
        float val_17;
        var val_19;
        float val_20;
        if(this.mPivot == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        if(null == null)
        {
                val_15 = 0;
        }
        
        this.mPivot = 丙业与丙丗丝不丈东;
        mem[1152921535247214824] = 1;
        UnityEngine.Transform val_1 = this.cachedTransform;
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Vector3 val_3 = val_1.localPosition;
        this.cachedTransform.position = new UnityEngine.Vector3() {x = (S13 - S15) + val_2.x, y = (S12 - S14) + val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_10 = this.cachedTransform.localPosition;
        if(val_10.x >= 0f)
        {
            goto label_12;
        }
        
        if((double)val_10.x != (-0.5))
        {
            goto label_13;
        }
        
        val_16 = val_11;
        val_17 = -1f;
        goto label_14;
        label_12:
        if((double)val_10.x != 0.5)
        {
            goto label_15;
        }
        
        val_16 = val_11;
        val_17 = 1f;
        label_14:
        val_17 = (float)val_16 + val_17;
        var val_12 = (((long)val_16 & 1) != 0) ? ((float)val_16) : (val_17);
        goto label_17;
        label_13:
        float val_15 = -0.5f;
        val_15 = val_10.x + val_15;
        goto label_17;
        label_15:
        float val_16 = 0.5f;
        val_16 = val_10.x + val_16;
        label_17:
        if(val_10.y >= 0f)
        {
            goto label_18;
        }
        
        if((double)val_10.y != (-0.5))
        {
            goto label_19;
        }
        
        val_19 = val_11;
        val_20 = -1f;
        goto label_20;
        label_18:
        if((double)val_10.y != 0.5)
        {
            goto label_21;
        }
        
        val_19 = val_11;
        val_20 = 1f;
        label_20:
        val_20 = (float)val_19 + val_20;
        var val_13 = (((long)val_19 & 1) != 0) ? ((float)val_19) : (val_20);
        goto label_23;
        label_19:
        float val_17 = -0.5f;
        val_17 = val_10.y + val_17;
        goto label_23;
        label_21:
        float val_18 = 0.5f;
        val_18 = val_10.y + val_18;
        label_23:
        this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_3.z};
    }
    public int get_depth()
    {
        return (int)this.mDepth;
    }
    public void set_depth(int 丙业与丙丗丝不丈东)
    {
        UIPanel val_4;
        if(this.mDepth == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        val_4 = this.panel;
        if(val_4 != 0)
        {
                val_4 = this.panel;
            val_4.RemoveWidget(与丘东下丈东丛丂万:  this);
        }
        
        this.mDepth = 丙业与丙丗丝不丈东;
        if(this.panel == 0)
        {
                return;
        }
        
        this.panel.AddWidget(与丘东下丈东丛丂万:  this);
        if(UnityEngine.Application.isPlaying != false)
        {
                return;
        }
        
        this.panel.SortWidgets();
        this.panel.RebuildAllDrawCalls();
    }
    public int get_raycastDepth()
    {
        UIPanel val_5;
        int val_6;
        val_5 = this;
        if(this.panel == 0)
        {
                UIPanel val_2 = this.CreatePanel();
        }
        
        val_6 = this.mDepth;
        if(this.panel == 0)
        {
                return (int)val_6;
        }
        
        val_5 = this.panel;
        val_6 = val_6 + (val_5.depth * 1000);
        return (int)val_6;
    }
    public override UnityEngine.Vector3[] get_localCorners()
    {
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_6 = val_1.x;
        float val_5 = (float)this.mHeight;
        float val_2 = -(val_6 * (float)this.mWidth);
        float val_3 = -(val_1.y * val_5);
        val_5 = val_5 - (val_1.y * val_5);
        this.三丑丄丄丘丛丐世不[0] = 0;
        this.三丑丄丄丘丛丐世不[0] = 0;
        this.三丑丄丄丘丛丐世不[0] = 0;
        val_6 = val_6 * (float)this.mWidth;
        val_6 = (float)this.mWidth - val_6;
        this.三丑丄丄丘丛丐世不[1] = 0;
        this.三丑丄丄丘丛丐世不[1] = 0;
        this.三丑丄丄丘丛丐世不[1] = 0;
        this.三丑丄丄丘丛丐世不[2] = 0;
        this.三丑丄丄丘丛丐世不[2] = 0;
        this.三丑丄丄丘丛丐世不[2] = 0;
        this.三丑丄丄丘丛丐世不[3] = 0;
        this.三丑丄丄丘丛丐世不[3] = 0;
        this.三丑丄丄丘丛丐世不[3] = 0;
        return (UnityEngine.Vector3[])this.三丑丄丄丘丛丐世不;
    }
    public virtual UnityEngine.Vector2 get_localSize()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public UnityEngine.Vector3 get_localCenter()
    {
        return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
    }
    public override UnityEngine.Vector3[] get_worldCorners()
    {
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_11 = val_1.x;
        float val_10 = val_1.y;
        float val_2 = -(val_11 * (float)this.mWidth);
        float val_3 = -(val_10 * (float)this.mHeight);
        UnityEngine.Transform val_4 = this.cachedTransform;
        UnityEngine.Vector3 val_5 = val_4.TransformPoint(x:  val_2, y:  val_3, z:  0f);
        val_10 = val_10 * (float)this.mHeight;
        this.三丑丄丄丘丛丐世不[0] = val_5;
        this.三丑丄丄丘丛丐世不[0] = val_5.y;
        this.三丑丄丄丘丛丐世不[0] = val_5.z;
        val_10 = (float)this.mHeight - val_10;
        UnityEngine.Vector3 val_6 = val_4.TransformPoint(x:  val_2, y:  val_10, z:  0f);
        this.三丑丄丄丘丛丐世不[1] = val_6;
        this.三丑丄丄丘丛丐世不[1] = val_6.y;
        this.三丑丄丄丘丛丐世不[1] = val_6.z;
        val_11 = (float)this.mWidth - (val_11 * (float)this.mWidth);
        UnityEngine.Vector3 val_8 = val_4.TransformPoint(x:  val_11, y:  val_10, z:  0f);
        this.三丑丄丄丘丛丐世不[2] = val_8;
        this.三丑丄丄丘丛丐世不[2] = val_8.y;
        this.三丑丄丄丘丛丐世不[2] = val_8.z;
        UnityEngine.Vector3 val_9 = val_4.TransformPoint(x:  val_11, y:  val_3, z:  0f);
        this.三丑丄丄丘丛丐世不[3] = val_9;
        this.三丑丄丄丘丛丐世不[3] = val_9.y;
        this.三丑丄丄丘丛丐世不[3] = val_9.z;
        return (UnityEngine.Vector3[])this.三丑丄丄丘丛丐世不;
    }
    public UnityEngine.Vector3 get_worldCenter()
    {
        UnityEngine.Transform val_1 = this.cachedTransform;
        UnityEngine.Vector3 val_2 = this.localCenter;
        if(val_1 != null)
        {
                return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        
        return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public virtual UnityEngine.Vector4 get_drawingDimensions()
    {
        float val_12;
        var val_13;
        float val_14;
        var val_15;
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_3 = -(val_1.x * (float)this.mWidth);
        val_12 = (float)this.mWidth - (val_1.x * (float)this.mWidth);
        val_13 = val_3;
        if(this.万丈丅不丌丗业丕丙 != 0f)
        {
                val_13 = UnityEngine.Mathf.Lerp(a:  val_3, b:  val_12, t:  this.万丈丅不丌丗业丕丙);
        }
        
        float val_6 = -(val_1.y * (float)this.mHeight);
        val_14 = (float)this.mHeight - (val_1.y * (float)this.mHeight);
        val_15 = val_6;
        if(S14 != 0f)
        {
                val_15 = UnityEngine.Mathf.Lerp(a:  val_6, b:  val_14, t:  V14.16B);
        }
        
        if(S14 != 1f)
        {
                val_12 = UnityEngine.Mathf.Lerp(a:  val_3, b:  val_12, t:  V14.16B);
        }
        
        if(val_3 != 1f)
        {
                val_14 = UnityEngine.Mathf.Lerp(a:  val_6, b:  val_14, t:  val_3);
        }
        
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public virtual UnityEngine.Material get_material()
    {
        return 0;
    }
    public virtual void set_material(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        System.NotImplementedException val_3 = new System.NotImplementedException(message:  this.GetType() + " has no material setter");
    }
    public virtual UnityEngine.Texture get_mainTexture()
    {
        if(this == 0)
        {
                return 0;
        }
        
        if(this != null)
        {
                return this.mainTexture;
        }
        
        return this.mainTexture;
    }
    public virtual void set_mainTexture(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        System.NotImplementedException val_3 = new System.NotImplementedException(message:  this.GetType() + " has no mainTexture setter");
    }
    public virtual UnityEngine.Texture get_textureAlpha()
    {
        if(this == 0)
        {
                return 0;
        }
        
        if(this != null)
        {
                return this.mainTexture;
        }
        
        return this.mainTexture;
    }
    public virtual void set_textureAlpha(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        System.NotImplementedException val_3 = new System.NotImplementedException(message:  this.GetType() + " has no mainTexture setter");
    }
    public virtual UnityEngine.Shader get_shader()
    {
        if(this == 0)
        {
                return 0;
        }
        
        if(this != null)
        {
                return this.shader;
        }
        
        return this.shader;
    }
    public virtual void set_shader(UnityEngine.Shader 丙业与丙丗丝不丈东)
    {
        System.NotImplementedException val_3 = new System.NotImplementedException(message:  this.GetType() + " has no shader setter");
    }
    public UnityEngine.Vector2 get_relativeSize()
    {
        return UnityEngine.Vector2.one;
    }
    public bool get_hasBoxCollider()
    {
        var val_4 = 0;
        if( == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.GetComponent<UnityEngine.BoxCollider2D>(), y:  0);
        }
        
        return true;
    }
    public void SetDimensions(int 与丘东下丈东丛丂万, int 一丗世三专三万丞丞)
    {
        if((this.mWidth == 与丘东下丈东丛丂万) && (this.mHeight == 一丗世三专三万丞丞))
        {
                return;
        }
        
        this.mWidth = 与丘东下丈东丛丂万;
        this.mHeight = 一丗世三专三万丞丞;
        if(this.keepAspectRatio == 0)
        {
            goto label_3;
        }
        
        if(this.keepAspectRatio == 2)
        {
            goto label_4;
        }
        
        if(this.keepAspectRatio != 1)
        {
            goto label_9;
        }
        
        float val_3 = (float)与丘东下丈东丛丂万;
        val_3 = val_3 / this.aspectRatio;
        this.mHeight = UnityEngine.Mathf.RoundToInt(f:  val_3);
        goto label_9;
        label_3:
        float val_4 = (float)与丘东下丈东丛丂万;
        val_4 = val_4 / (float)一丗世三专三万丞丞;
        this.aspectRatio = val_4;
        goto label_9;
        label_4:
        float val_5 = (float)一丗世三专三万丞丞;
        val_5 = this.aspectRatio * val_5;
        this.mWidth = UnityEngine.Mathf.RoundToInt(f:  val_5);
        label_9:
        this.丌东丟三丈丄万业丂 = true;
        if(this.autoResizeBoxCollider != false)
        {
                this.ResizeCollider();
        }
    
    }
    public override UnityEngine.Vector3[] GetSides(UnityEngine.Transform 一世丛下丘东世专丈)
    {
        var val_16;
        var val_17;
        UnityEngine.Vector3 val_18;
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_16 = (float)this.mWidth;
        float val_2 = val_1.x * val_16;
        float val_4 = val_1.y * (float)this.mHeight;
        float val_5 = (float)this.mHeight - val_4;
        val_4 = val_5 - val_4;
        float val_6 = val_4 * 0.5f;
        val_16 = this.cachedTransform;
        val_16 = val_16 - val_2;
        UnityEngine.Vector3 val_8 = val_16.TransformPoint(x:  -(val_1.x * val_16), y:  val_6, z:  0f);
        val_2 = val_16 - val_2;
        this.三丑丄丄丘丛丐世不[0] = val_8;
        this.三丑丄丄丘丛丐世不[0] = val_8.y;
        this.三丑丄丄丘丛丐世不[0] = val_8.z;
        float val_9 = val_2 * 0.5f;
        UnityEngine.Vector3 val_10 = val_16.TransformPoint(x:  val_9, y:  val_5, z:  0f);
        this.三丑丄丄丘丛丐世不[1] = val_10;
        this.三丑丄丄丘丛丐世不[1] = val_10.y;
        this.三丑丄丄丘丛丐世不[1] = val_10.z;
        UnityEngine.Vector3 val_11 = val_16.TransformPoint(x:  val_16, y:  val_6, z:  0f);
        this.三丑丄丄丘丛丐世不[2] = val_11;
        this.三丑丄丄丘丛丐世不[2] = val_11.y;
        this.三丑丄丄丘丛丐世不[2] = val_11.z;
        UnityEngine.Vector3 val_13 = val_16.TransformPoint(x:  val_9, y:  -(val_1.y * (float)this.mHeight), z:  0f);
        val_17 = val_13.x;
        val_18 = val_13.z;
        this.三丑丄丄丘丛丐世不[3] = val_13;
        this.三丑丄丄丘丛丐世不[3] = val_13.y;
        this.三丑丄丄丘丛丐世不[3] = val_18;
        if(一世丛下丘东世专丈 == 0)
        {
                return (UnityEngine.Vector3[])this.三丑丄丄丘丛丐世不;
        }
        
        var val_20 = 0;
        do
        {
            UnityEngine.Vector3 val_15 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.三丑丄丄丘丛丐世不[0], y = this.三丑丄丄丘丛丐世不[0], z = this.三丑丄丄丘丛丐世不[0]});
            val_17 = val_15.x;
            val_18 = val_15.z;
            val_20 = val_20 + 1;
            val_16 = 0 + 12;
            this.三丑丄丄丘丛丐世不[0] = val_15;
            this.三丑丄丄丘丛丐世不[0] = val_15.y;
            this.三丑丄丄丘丛丐世不[0] = val_18;
        }
        while(val_20 != 4);
        
        return (UnityEngine.Vector3[])this.三丑丄丄丘丛丐世不;
    }
    public override float CalculateFinalAlpha(int 与专丙丝丝且丂且丒)
    {
        if(this.不不丙丈与专丄丏丌 == 与专丙丝丝且丂且丒)
        {
                return (float)S0;
        }
        
        this.不不丙丈与专丄丏丌 = 与专丙丝丝且丂且丒;
        this.丕且不丒万万东丕丙(与专丙丝丝且丂且丒:  与专丙丝丝且丂且丒);
        return (float)S0;
    }
    protected void 丕且不丒万万东丕丙(int 与专丙丝丝且丂且丒)
    {
        float val_3 = 0f;
        if((this.丅丆专丛丛丈上丆万 != false) && (this.一七且且丗丞丂丘专 != false))
        {
                if(this.parent != 0)
        {
                val_3 = val_3 * S1;
        }
        
        }
        
        mem[1152921535251306764] = val_3;
    }
    public override void Invalidate(bool 丕丐丟下东专丒丘业)
    {
        mem[1152921535251435096] = 1;
        this.不不丙丈与专丄丏丌 = 0;
        if(this.panel == 0)
        {
                return;
        }
        
        if(this.hideIfOffScreen != true)
        {
                if(this.panel.hasCumulativeClipping == false)
        {
            goto label_11;
        }
        
        }
        
        bool val_3 = this.panel.IsVisible(与丘东下丈东丛丂万:  this);
        label_11:
        float val_5 = this.CalculateCumulativeAlpha(与专丙丝丝且丂且丒:  UnityEngine.Time.frameCount);
        var val_7 = (this.丅丆专丛丛丈上丆万 == true) ? 1 : 0;
        val_7 = ((val_5 > 0.001f) ? 1 : 0) ^ val_7;
        if((val_7 & 1) != 0)
        {
            goto label_8;
        }
        
        var val_8 = (this.丆专万与一丒丕丐下 == true) ? 1 : 0;
        val_8 = val_3 ^ val_8;
        if(val_8 == false)
        {
            goto label_9;
        }
        
        label_8:
        mem[1152921535251435096] = 1;
        this.丅丆专丛丛丈上丆万 = (val_5 > 0.001f) ? 1 : 0;
        this.丆专万与一丒丕丐下 = val_3;
        label_9:
        this.丕且不丒万万东丕丙(与专丙丝丝且丂且丒:  UnityEngine.Time.frameCount);
        if(丕丐丟下东专丒丘业 == false)
        {
                return;
        }
        
        this.Invalidate(丕丐丟下东专丒丘业:  true);
    }
    public float CalculateCumulativeAlpha(int 与专丙丝丝且丂且丒)
    {
        if(this.parent == 0)
        {
                return (float)S0;
        }
        
        float val_3 = S0 * S1;
        return (float)S0;
    }
    public override void SetRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一)
    {
        var val_22;
        UnityEngine.Object val_23;
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_22 = val_1.x;
        float val_2 = 三丟东丕丄丄下下丑 + 业与三万七丝不万东;
        float val_4 = 丒丒丄丁且丄丆丂丌 + 丟丌丐丘丆丙丑丑一;
        float val_23 = 0.5f;
        int val_7 = UnityEngine.Mathf.FloorToInt(f:  业与三万七丝不万东 + val_23);
        int val_9 = UnityEngine.Mathf.FloorToInt(f:  丟丌丐丘丆丙丑丑一 + val_23);
        UnityEngine.Transform val_14 = this.cachedTransform;
        UnityEngine.Vector3 val_15 = val_14.localPosition;
        if(((val_22 == val_23) ? (val_7 & 4294967294) : (val_7)) < this)
        {
                val_22 = this;
        }
        
        val_22 = (UnityEngine.Mathf.Lerp(a:  三丟东丕丄丄下下丑, b:  val_2, t:  val_22)) + val_23;
        val_23 = (UnityEngine.Mathf.Lerp(a:  丒丒丄丁且丄丆丂丌, b:  val_4, t:  val_1.y)) + val_23;
        if(((val_1.y == val_23) ? (val_9 & 4294967294) : (val_9)) < this)
        {
                val_23 = this;
        }
        
        val_14.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_1.y, z = val_15.z};
        this.width = 580073728;
        this.height = 580073728;
        if(this.isAnchored == false)
        {
                return;
        }
        
        UnityEngine.Transform val_17 = val_14.parent;
        if((UnityEngine.Object.op_Implicit(exists:  this)) != false)
        {
                this.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_17, 丈丑丑且业下丒丁丞:  三丟东丕丄丄下下丑);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this)) != false)
        {
                this.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_17, 丈丑丑且业下丒丁丞:  val_2);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this)) != false)
        {
                this.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_17, 丈丑丑且业下丒丁丞:  丒丒丄丁且丄丆丂丌);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
        {
                return;
        }
        
        this.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_17, 丈丑丑且业下丒丁丞:  val_4);
    }
    public void ResizeCollider()
    {
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(丝三丁东丈丒世丅业:  this.gameObject);
    }
    public static int FullCompareFunc(UIWidget 丈丂丕下丏丈丞丗业, UIWidget 丂丌丌丛丆丆丙丌丈)
    {
        int val_1 = UIPanel.CompareFunc(丆丛丑世下一丐且丕:  丈丂丕下丏丈丞丗业.panel, 丌丗丏丏丛东专丁且:  丂丌丌丛丆丆丙丌丈.panel);
        if(val_1 == 0)
        {
                return UIWidget.PanelCompareFunc(丈丂丕下丏丈丞丗业:  丈丂丕下丏丈丞丗业, 丂丌丌丛丆丆丙丌丈:  丂丌丌丛丆丆丙丌丈);
        }
        
        return val_1;
    }
    public static int PanelCompareFunc(UIWidget 丈丂丕下丏丈丞丗业, UIWidget 丂丌丌丛丆丆丙丌丈)
    {
        UnityEngine.Object val_7;
        var val_8;
        val_7 = 丂丌丌丛丆丆丙丌丈;
        if(丈丂丕下丏丈丞丗业.mDepth >= 丂丌丌丛丆丆丙丌丈.mDepth)
        {
            goto label_3;
        }
        
        label_15:
        val_8 = 0;
        return (int)val_8;
        label_3:
        if(丈丂丕下丏丈丞丗业.mDepth <= 丂丌丌丛丆丆丙丌丈.mDepth)
        {
            goto label_5;
        }
        
        label_12:
        val_8 = 1;
        return (int)val_8;
        label_5:
        val_7 = val_7;
        if(丈丂丕下丏丈丞丗业 == val_7)
        {
                val_8 = 0;
            return (int)val_8;
        }
        
        if(丈丂丕下丏丈丞丗业 == 0)
        {
            goto label_12;
        }
        
        if(val_7 == 0)
        {
            goto label_15;
        }
        
        var val_6 = (丈丂丕下丏丈丞丗业.GetInstanceID() >= val_7.GetInstanceID()) ? (-0) : 0;
        return (int)val_8;
    }
    public UnityEngine.Bounds CalculateBounds()
    {
        return this.CalculateBounds(丟上与丝下丁丈丕丅:  0);
    }
    public UnityEngine.Bounds CalculateBounds(UnityEngine.Transform 丟上与丝下丁丈丕丅)
    {
        var val_4;
        var val_10;
        var val_11;
        var val_12;
        UnityEngine.Bounds val_0;
        if(丟上与丝下丁丈丕丅 == 0)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_11 = 1152921535252341700;
            var val_9 = 1;
            do
        {
            val_9 = val_9 + 1;
        }
        while(val_9 != 4);
        
            val_12 = 0;
        }
        else
        {
                UnityEngine.Matrix4x4 val_3 = 丟上与丝下丁丈丕丅.worldToLocalMatrix;
            val_10 = val_4;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_11 = 1152921535252341700;
            var val_10 = 1;
            do
        {
            val_10 = val_10 + 1;
        }
        while(val_10 != 4);
        
            val_12 = 0;
        }
        
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        return val_0;
    }
    public void SetDirty()
    {
        if(this.drawCall != 0)
        {
                this = this.drawCall;
            this.drawCall.isDirty = true;
            return;
        }
        
        if(this.isVisible == false)
        {
                return;
        }
        
        if(this.geometry == null)
        {
                return;
        }
        
        if(this.geometry.丗丁丅丗三下丂丘一() == false)
        {
                return;
        }
        
        UIPanel val_4 = this.CreatePanel();
    }
    public void RemoveFromPanel()
    {
        if(this.panel != 0)
        {
                this.panel.RemoveWidget(与丘东下丈东丛丂万:  this);
            this.panel = 0;
        }
        
        this.drawCall = 0;
    }
    public virtual void MarkAsChanged()
    {
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        mem[1152921535252747320] = 1;
        if(this.panel == 0)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.丅三丒上万丗丗丄丝 != false)
        {
                return;
        }
        
        this.SetDirty();
        this.CheckLayer();
    }
    public UIPanel CreatePanel()
    {
        if(true == 0)
        {
                return (UIPanel)this.panel;
        }
        
        if(this.panel != 0)
        {
                return (UIPanel)this.panel;
        }
        
        if(this.enabled == false)
        {
                return (UIPanel)this.panel;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return (UIPanel)this.panel;
        }
        
        UIPanel val_8 = UIPanel.Find(丄上七丟不丗丕下丟:  this.cachedTransform, 丐丗丏东丘东丘丈且:  true, 且丅丟丛丛万丝下上:  this.cachedGameObject.layer);
        this.panel = val_8;
        if(val_8 == 0)
        {
                return (UIPanel)this.panel;
        }
        
        mem[1152921535252896185] = 0;
        this.panel.AddWidget(与丘东下丈东丛丂万:  this);
        this.CheckLayer();
        return (UIPanel)this.panel;
    }
    public void CheckLayer()
    {
        if(this.panel == 0)
        {
                return;
        }
        
        if(this.panel.gameObject.layer == this.gameObject.layer)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "You can\'t place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.", context:  this);
        this.gameObject.layer = this.panel.gameObject.layer;
    }
    public override void ParentHasChanged()
    {
        this.ParentHasChanged();
        if(this.panel == 0)
        {
                return;
        }
        
        if(this.panel == (UIPanel.Find(丄上七丟不丗丕下丟:  this.cachedTransform, 丐丗丏东丘东丘丈且:  true, 且丅丟丛丛万丝下上:  this.cachedGameObject.layer)))
        {
                return;
        }
        
        this.RemoveFromPanel();
        UIPanel val_7 = this.CreatePanel();
    }
    protected override void Awake()
    {
        var val_4;
        this.Awake();
        this.丅三丒上万丗丗丄丝 = UnityEngine.Application.isPlaying;
        val_4 = null;
        val_4 = null;
        UIRoot.上万丞丂丕丂丕丐万.set_Item(key:  this.cachedTransform, value:  this);
    }
    protected override void 丅丒丐且丘丝丝丄且()
    {
        this.丅丒丐且丘丝丝丄且();
        this.RemoveFromPanel();
        this.丌东丟三丈丄万业丂 = true;
        if((this.mWidth == 100) && (this.mHeight == 100))
        {
                UnityEngine.Vector3 val_2 = this.cachedTransform.localScale;
            if(val_2.x > 8f)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        
        }
        
        this.Update();
    }
    protected virtual void 丘业丑丌专七丘三三()
    {
        UnityEngine.Vector3 val_2 = this.cachedTransform.localScale;
        this.mWidth = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_2.x));
        this.mHeight = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_2.y));
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(丝三丁东丈丒世丅业:  this.gameObject, 三世与丌丈丈丅丒三:  true);
    }
    protected override void 丁业三上丛丐且专东()
    {
        if(this.mWidth == 1790)
        {
                this.width = 8;
        }
        
        UIPanel val_1 = this.CreatePanel();
    }
    protected override void 东七一下丕丛与丑丝()
    {
        var val_37;
        UnityEngine.Transform val_51;
        float val_53;
        float val_56;
        int val_57;
        int val_58;
        int val_59;
        int val_60;
        float val_61;
        float val_62;
        bool val_63;
        float val_64;
        float val_65;
        float val_66;
        int val_67;
        float val_68;
        float val_69;
        int val_70;
        int val_71;
        float val_72;
        int val_73;
        float val_74;
        var val_76;
        float val_77;
        var val_79;
        float val_80;
        int val_82;
        int val_83;
        float val_84;
        float val_85;
        UnityEngine.Transform val_1 = this.cachedTransform;
        if(val_1 != null)
        {
                val_51 = val_1.parent;
        }
        else
        {
                val_51 = 0.parent;
        }
        
        UnityEngine.Vector3 val_4 = val_1.localPosition;
        val_53 = val_4.y;
        UnityEngine.Vector2 val_5 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        val_56 = val_5.x;
        if(((val_1 != (X22 + 16)) || (val_1 != (X22 + 16 + 16))) || (val_1 != (X22 + 16 + 16 + 16)))
        {
            goto label_17;
        }
        
        UnityEngine.Vector3[] val_9 = val_1.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_51);
        if(val_9 == null)
        {
            goto label_19;
        }
        
        val_57 = val_9.Length;
        if(val_57 == 0)
        {
                val_57 = val_9.Length;
        }
        
        float val_10 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_9[0], 专丂丕丗丗东世丞下:  val_9[3], 丞上与七且与七三丐:  val_4.z);
        val_58 = val_9.Length;
        if(val_58 == 0)
        {
                val_58 = val_9.Length;
        }
        
        val_59 = val_9.Length;
        if(val_59 <= 3)
        {
                val_59 = val_9.Length;
        }
        
        float val_12 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_9[5], 专丂丕丗丗东世丞下:  val_9[2], 丞上与七且与七三丐:  val_4.z);
        val_60 = val_9.Length;
        if(val_60 <= 3)
        {
                val_60 = val_9.Length;
        }
        
        val_61 = val_5.y;
        val_62 = val_56;
        float val_54 = val_10;
        val_63 = 1;
        val_54 = val_54 + val_10;
        val_64 = (万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_9[0], 专丂丕丗丗东世丞下:  val_9[3], 丞上与七且与七三丐:  val_4.z)) + val_53;
        val_65 = (万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_9[5], 专丂丕丗丗东世丞下:  val_9[2], 丞上与七且与七三丐:  val_4.z)) + val_54;
        val_66 = val_12 + val_12;
        goto label_36;
        label_17:
        this.一七且且丗丞丂丘专 = true;
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
        {
            goto label_40;
        }
        
        UnityEngine.Vector3[] val_15 = val_1.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_51);
        if(val_15 == null)
        {
            goto label_42;
        }
        
        val_67 = val_15.Length;
        if(val_67 == 0)
        {
                val_67 = val_15.Length;
        }
        
        val_68 = val_15[3];
        float val_16 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_15[0], 专丂丕丗丗东世丞下:  val_68, 丞上与七且与七三丐:  X22 + 16 + 24);
        goto label_46;
        label_40:
        float val_57 = (float)this.mWidth;
        val_57 = val_56 * val_57;
        val_69 = val_4.x - val_57;
        goto label_47;
        label_42:
        UnityEngine.Vector3 val_17 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_51, 丄上七丟不丗丕下丟:  val_51);
        label_46:
        val_69 = val_17.x + (float)val_17.x;
        label_47:
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
            goto label_52;
        }
        
        UnityEngine.Vector3[] val_19 = val_15.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_51);
        if(val_19 == null)
        {
            goto label_54;
        }
        
        val_70 = val_19.Length;
        if(val_70 == 0)
        {
                val_70 = val_19.Length;
        }
        
        val_69 = val_19[0];
        val_68 = val_19[3];
        float val_20 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_69, 专丂丕丗丗东世丞下:  val_68, 丞上与七且与七三丐:  X22 + 16 + 24);
        goto label_58;
        label_52:
        val_68 = val_4.x - (val_56 * (float)this.mWidth);
        val_64 = val_68 + (float)this.mWidth;
        goto label_59;
        label_54:
        UnityEngine.Vector3 val_22 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_51, 丄上七丟不丗丕下丟:  val_51);
        label_58:
        val_64 = val_22.x + (float)val_22.x;
        label_59:
        if((UnityEngine.Object.op_Implicit(exists:  val_19)) == false)
        {
            goto label_64;
        }
        
        UnityEngine.Vector3[] val_24 = val_19.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_51);
        val_62 = val_56;
        if(val_24 == null)
        {
            goto label_66;
        }
        
        val_71 = val_24.Length;
        if(val_71 <= 3)
        {
                val_71 = val_24.Length;
        }
        
        val_61 = val_5.y;
        val_72 = val_4.x;
        val_68 = val_24[2];
        float val_25 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_24[5], 专丂丕丗丗东世丞下:  val_68, 丞上与七且与七三丐:  X22 + 16 + 24);
        if(val_24 != null)
        {
            goto label_84;
        }
        
        label_85:
        label_84:
        val_66 = val_25 + val_25;
        goto label_71;
        label_64:
        val_62 = val_56;
        val_72 = val_4.x;
        val_61 = val_5.y;
        float val_62 = (float)this.mHeight;
        val_62 = val_5.y * val_62;
        val_66 = val_53 - val_62;
        label_71:
        if((UnityEngine.Object.op_Implicit(exists:  val_19)) == false)
        {
            goto label_75;
        }
        
        UnityEngine.Vector3[] val_27 = val_19.万丆上世丁丐丂丌丈(一世丛下丘东世专丈:  val_51);
        if(val_27 == null)
        {
            goto label_77;
        }
        
        val_73 = val_27.Length;
        if(val_73 <= 3)
        {
                val_73 = val_27.Length;
        }
        
        val_74 = 万丗丅且丄丑世专与.下下丑丆下世东丏三(丈丗与丞一上且上上:  val_27[5], 专丂丕丗丗东世丞下:  val_27[2], 丞上与七且与七三丐:  val_22.z);
        val_53 = val_53;
        goto label_82;
        label_75:
        float val_29 = val_61 * (float)this.mHeight;
        val_29 = val_53 - val_29;
        val_65 = val_29 + (float)this.mHeight;
        goto label_87;
        label_66:
        UnityEngine.Vector3 val_30 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_51, 丄上七丟不丗丕下丟:  val_51);
        if(val_24 != null)
        {
            goto label_84;
        }
        
        goto label_85;
        label_77:
        UnityEngine.Vector3 val_31 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_51, 丄上七丟不丗丕下丟:  val_51);
        val_74 = val_31.y;
        label_82:
        val_65 = val_74 + (float)val_31.x;
        goto label_87;
        label_19:
        UnityEngine.Vector3 val_32 = this.丂七丆东专三丙丂万(丗丐与丐丕丆丗丁下:  val_51, 丄上七丟不丗丕下丟:  val_51);
        val_62 = val_56;
        val_61 = val_5.y;
        val_56 = val_53;
        val_32.x = val_32.x + val_56;
        val_66 = val_32.y + (float)val_4.x;
        val_64 = val_32.x + (float)val_32.x;
        val_65 = val_32.y + val_32.x;
        val_63 = ((val_32.z >= 0f) ? 1 : 0) | ((this.hideIfOffScreen == false) ? 1 : 0);
        label_36:
        this.一七且且丗丞丂丘专 = val_63;
        val_53 = val_53;
        val_72 = val_4.x;
        label_87:
        float val_35 = UnityEngine.Mathf.Lerp(a:  val_32.x, b:  val_64, t:  val_62);
        float val_36 = UnityEngine.Mathf.Lerp(a:  val_66, b:  val_65, t:  val_61);
        if(0f >= 0f)
        {
            goto label_94;
        }
        
        if((double)0f != (-0.5))
        {
            goto label_95;
        }
        
        val_76 = val_37;
        val_77 = -1f;
        goto label_96;
        label_94:
        if((double)0f != 0.5)
        {
            goto label_97;
        }
        
        val_76 = val_37;
        val_77 = 1f;
        label_96:
        float val_65 = (float)val_76;
        val_77 = val_65 + val_77;
        val_65 = (((long)val_76 & 1) != 0) ? (val_65) : (val_77);
        goto label_99;
        label_95:
        float val_66 = -0.5f;
        val_66 = 0f + val_66;
        goto label_99;
        label_97:
        float val_67 = 0.5f;
        val_67 = 0f + val_67;
        label_99:
        if(0f >= 0f)
        {
            goto label_100;
        }
        
        if((double)0f != (-0.5))
        {
            goto label_101;
        }
        
        val_79 = val_37;
        val_80 = -1f;
        goto label_102;
        label_100:
        if((double)0f != 0.5)
        {
            goto label_103;
        }
        
        val_79 = val_37;
        val_80 = 1f;
        label_102:
        float val_68 = (float)val_79;
        val_80 = val_68 + val_80;
        val_68 = (((long)val_79 & 1) != 0) ? (val_68) : (val_80);
        goto label_105;
        label_101:
        float val_69 = -0.5f;
        val_69 = 0f + val_69;
        goto label_105;
        label_103:
        float val_70 = 0.5f;
        val_70 = 0f + val_70;
        label_105:
        float val_71 = val_32.x;
        val_71 = val_64 - val_71;
        val_71 = val_71 + 0.5f;
        float val_39 = val_65 - val_66;
        val_82 = UnityEngine.Mathf.FloorToInt(f:  val_71);
        val_39 = val_39 + 0.5f;
        val_83 = UnityEngine.Mathf.FloorToInt(f:  val_39);
        if(this.keepAspectRatio == 0)
        {
            goto label_106;
        }
        
        val_65 = this.aspectRatio;
        if(val_65 != 0f)
        {
            goto label_107;
        }
        
        label_106:
        val_84 = val_72;
        label_125:
        if(val_82 < this)
        {
                val_82 = this;
        }
        
        if(val_83 < this)
        {
                val_83 = this;
        }
        
        val_85 = val_70;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_84, y = val_53, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_67, y = val_85, z = 0f});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z})) > 0.001f)
        {
                val_85 = val_67;
            val_84 = 0f;
            this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_85, y = val_70, z = val_84};
            if(this.一七且且丗丞丂丘专 != false)
        {
                mem[1152921535254074840] = 1;
        }
        
        }
        
        if(this.mWidth == val_82)
        {
                if(this.mHeight == val_83)
        {
                return;
        }
        
        }
        
        this.mWidth = val_82;
        this.mHeight = val_83;
        if(this.一七且且丗丞丂丘专 != false)
        {
                mem[1152921535254074840] = 1;
        }
        
        if(this.autoResizeBoxCollider == false)
        {
                return;
        }
        
        this.ResizeCollider();
        return;
        label_107:
        if(this.keepAspectRatio != 2)
        {
            goto label_119;
        }
        
        float val_72 = (float)val_83;
        val_72 = val_65 * val_72;
        int val_44 = UnityEngine.Mathf.RoundToInt(f:  val_72);
        goto label_125;
        label_119:
        float val_73 = (float)val_82;
        val_73 = val_73 / val_65;
        int val_45 = UnityEngine.Mathf.RoundToInt(f:  val_73);
        goto label_125;
    }
    protected override void 丑丈丆万丅上丞丗丐()
    {
        if(this.panel != 0)
        {
                return;
        }
        
        UIPanel val_2 = this.CreatePanel();
    }
    private void OnApplicationPause(bool 丆丕与三丝丙丑丛三)
    {
        if(丆丕与三丝丙丑丛三 == false)
        {
            goto typeof(UIWidget).__il2cppRuntimeField_338;
        }
    
    }
    protected override void OnDisable()
    {
        this.RemoveFromPanel();
        this.OnDisable();
    }
    private void OnDestroy()
    {
        var val_3;
        this.RemoveFromPanel();
        val_3 = null;
        val_3 = null;
        bool val_2 = UIRoot.上万丞丂丕丂丕丐万.Remove(key:  this.cachedTransform);
    }
    public bool UpdateVisibility(bool 七丆三丘上丟丂丆丒, bool 七丌丟丂三丒丆丑上)
    {
        var val_5;
        var val_1 = (this.丅丆专丛丛丈上丆万 == true) ? 1 : 0;
        val_1 = val_1 ^ 七丆三丘上丟丂丆丒;
        if(val_1 == true)
        {
            goto label_0;
        }
        
        var val_2 = (this.丆专万与一丒丕丐下 == true) ? 1 : 0;
        val_2 = val_2 ^ 七丌丟丂三丒丆丑上;
        if(val_2 == false)
        {
            goto label_1;
        }
        
        label_0:
        val_5 = 1;
        mem[1152921535254869336] = val_5;
        this.丅丆专丛丛丈上丆万 = 七丆三丘上丟丂丆丒;
        this.丆专万与一丒丕丐下 = 七丌丟丂三丒丆丑上;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
    }
    public bool UpdateTransform(int 丒丄丙丄丅丅业丏万)
    {
        float val_21;
        float val_22;
        float val_23;
        var val_25;
        UnityEngine.Transform val_1 = this.cachedTransform;
        this.丅三丒上万丗丗丄丝 = UnityEngine.Application.isPlaying;
        if(this.丌东丟三丈丄万业丂 == false)
        {
            goto label_1;
        }
        
        this.丌东丟三丈丄万业丂 = true;
        this.丒丈上万丘丁丟丕丄 = 0;
        val_1.hasChanged = false;
        UnityEngine.Vector2 val_4 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_20 = val_4.x;
        float val_21 = val_4.y;
        val_21 = (float)this.mHeight;
        val_22 = -(val_20 * (float)this.mWidth);
        val_20 = val_20 * (float)this.mWidth;
        val_21 = val_21 * val_21;
        UnityEngine.Vector3 val_6 = val_1.TransformPoint(x:  val_22, y:  -(val_21 * val_21), z:  0f);
        this.丝下万丈丙丏丛丞与 = val_6;
        mem[1152921535255018468] = val_6.y;
        mem[1152921535255018472] = val_6.z;
        val_23 = (float)this.mWidth - val_20;
        val_21 = val_21 - val_21;
        UnityEngine.Vector3 val_7 = val_1.TransformPoint(x:  val_23, y:  val_21, z:  0f);
        this.下三丐一丌下丘丞与 = val_7;
        mem[1152921535255018480] = val_7.y;
        mem[1152921535255018484] = val_7.z;
        goto label_22;
        label_1:
        if((this.panel.widgetsAreStatic == true) || (val_1.hasChanged == false))
        {
            goto label_22;
        }
        
        this.丒丈上万丘丁丟丕丄 = 0;
        val_1.hasChanged = false;
        UnityEngine.Vector2 val_9 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.mPivot);
        float val_22 = val_9.x;
        float val_23 = val_9.y;
        float val_24 = (float)this.mHeight;
        val_22 = val_22 * (float)this.mWidth;
        val_23 = val_23 * val_24;
        UnityEngine.Vector3 val_12 = val_1.TransformPoint(x:  -(val_22 * (float)this.mWidth), y:  -(val_23 * val_24), z:  0f);
        val_22 = val_12.z;
        val_24 = val_24 - val_23;
        UnityEngine.Vector3 val_14 = val_1.TransformPoint(x:  (float)this.mWidth - val_22, y:  val_24, z:  0f);
        val_23 = this.丝下万丈丙丏丛丞与;
        val_21 = val_14.y;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = V15.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_22});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z})) > (1E-06f))
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.下三丐一丌下丘丞与, y = val_23, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_21, z = val_14.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z})) <= (1E-06f))
        {
            goto label_22;
        }
        
        label_19:
        this.丝下万丈丙丏丛丞与 = val_12;
        mem[1152921535255018472] = val_22;
        this.下三丐一丌下丘丞与 = val_14;
        mem[1152921535255018480] = val_21;
        mem[1152921535255018468] = val_12.y;
        this.丌东丟三丈丄万业丂 = true;
        mem[1152921535255018484] = val_14.z;
        label_22:
        if(this.丌东丟三丈丄万业丂 == false)
        {
                return (bool)(this.丌东丟三丈丄万业丂 == true) ? 1 : 0;
        }
        
        if(this.onChange != null)
        {
                this.onChange.Invoke();
            if(this.丌东丟三丈丄万业丂 == false)
        {
                return (bool)(this.丌东丟三丈丄万业丂 == true) ? 1 : 0;
        }
        
        }
        
        val_25 = 1;
        return (bool)(this.丌东丟三丈丄万业丂 == true) ? 1 : 0;
    }
    public bool UpdateGeometry(int 丒丄丙丄丅丅业丏万)
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Matrix4x4 val_15;
        UnityEngine.Object val_24;
        var val_25;
        丏丌业丑万丐丐不丙 val_26;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_27;
        丏丌业丑万丐丐不丙 val_28;
        bool val_29;
        丏丌业丑万丐丐不丙 val_31;
        var val_33;
        val_24 = this;
        if((this.丅丆专丛丛丈上丆万 != false) && (this.上业丘专丆丏东下丂 != S0))
        {
                mem[1152921535255277848] = 1;
        }
        
        this.上业丘专丆丏东下丂 = ;
        if(1 == 0)
        {
            goto label_3;
        }
        
        if(((S0 <= 0.001f) || (this.丅丆专丛丛丈上丆万 == false)) || (this == 0))
        {
            goto label_8;
        }
        
        val_25 = this.geometry.丗丁丅丗三下丂丘一();
        if(this.fillGeometry == false)
        {
            goto label_10;
        }
        
        this.geometry.世业丒万丘丆专丘丐();
        val_26 = this.geometry;
        if(val_26 == null)
        {
            goto label_12;
        }
        
        val_27 = this.geometry.丗丞不丞业丑七且丗;
        val_28 = val_26;
        goto label_37;
        label_8:
        if(this.geometry.丗丁丅丗三下丂丘一() == false)
        {
            goto label_15;
        }
        
        if(this.fillGeometry == false)
        {
            goto label_28;
        }
        
        this.geometry.世业丒万丘丆专丘丐();
        goto label_28;
        label_3:
        val_29 = this.丌东丟三丈丄万业丂;
        if((this.丌东丟三丈丄万业丂 == false) || (this.geometry.丗丁丅丗三下丂丘一() == false))
        {
            goto label_21;
        }
        
        if(this.丒丈上万丘丁丟丕丄 != 丒丄丙丄丅丅业丏万)
        {
                UnityEngine.Matrix4x4 val_6 = this.cachedTransform.localToWorldMatrix;
            UnityEngine.Matrix4x4 val_11 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = this.panel.worldToLocal, m10 = this.panel.worldToLocal, m20 = this.panel.worldToLocal, m30 = this.panel.worldToLocal, m01 = ???, m11 = ???, m21 = ???, m31 = ???, m02 = ???, m12 = ???, m22 = ???, m32 = ???, m03 = ???, m13 = ???, m23 = ???, m33 = ???}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_9, m10 = val_9, m20 = val_9, m30 = val_9, m01 = val_10, m11 = val_10, m21 = val_10, m31 = val_10, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8});
            mem[1152921535255278060] = val_12;
            mem[1152921535255278044] = val_13;
            mem[1152921535255278028] = val_14;
            this.丒丈上万丘丁丟丕丄 = 丒丄丙丄丅丅业丏万;
            this.丄世丘且万且七丏东 = val_15;
        }
        
        if(this._isMinimapLabel == false)
        {
            goto label_27;
        }
        
        if(this.丆专万与一丒丕丐下 == false)
        {
            goto label_28;
        }
        
        val_31 = this.geometry;
        var val_16 = (this.panel.generateNormals == true) ? 1 : 0;
        goto label_35;
        label_15:
        val_29 = this.丌东丟三丈丄万业丂;
        label_21:
        val_25 = 0;
        mem2[0] = 0;
        goto label_40;
        label_27:
        val_31 = this.geometry;
        var val_17 = (this.panel.generateNormals == true) ? 1 : 0;
        val_33;
        goto label_35;
        label_12:
        val_28 = this.geometry;
        val_27 = this.geometry.丗丞不丞业丑七且丗;
        if(val_28 == null)
        {
            goto label_36;
        }
        
        val_26 = val_28;
        goto label_37;
        label_36:
        val_26 = this.geometry;
        if(val_26 == null)
        {
            goto label_38;
        }
        
        label_37:
        label_10:
        if(this.geometry.丗丁丅丗三下丂丘一() == false)
        {
            goto label_40;
        }
        
        if(this.丒丈上万丘丁丟丕丄 == 丒丄丙丄丅丅业丏万)
        {
            
        }
        else
        {
                UnityEngine.Matrix4x4 val_20 = this.cachedTransform.localToWorldMatrix;
            UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = this.panel.worldToLocal, m10 = this.panel.worldToLocal, m20 = this.panel.worldToLocal, m30 = this.panel.worldToLocal, m01 = ???, m11 = ???, m21 = ???, m31 = ???, m02 = ???, m12 = ???, m22 = ???, m32 = ???, m03 = ???, m13 = ???, m23 = ???, m33 = ???}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_9, m10 = val_9, m20 = val_9, m30 = val_9, m01 = val_10, m11 = val_10, m21 = val_10, m31 = val_10, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8});
            mem[1152921535255278060] = val_12;
            mem[1152921535255278044] = val_13;
            mem[1152921535255278028] = val_14;
            this.丒丈上万丘丁丟丕丄 = 丒丄丙丄丅丅业丏万;
            this.丄世丘且万且七丏东 = val_15;
        }
        
        val_31 = this.geometry;
        label_35:
        val_31.丆上丝丅丐世下丐丅(下丄上丐下万一丕丝:  new UnityEngine.Matrix4x4() {m00 = this.丄世丘且万且七丏东.m00, m01 = this.丄世丘且万且七丏东.m01, m02 = this.丄世丘且万且七丏东.m02, m03 = this.丄世丘且万且七丏东.m03}, 丁不且一丝丏业丐丆:  (this.panel.generateNormals == true) ? 1 : 0);
        label_28:
        val_25 = 1;
        this.丌东丟三丈丄万业丂 = false;
        label_40:
        mem[1152921535255277848] = 0;
        return (bool)val_25 & 1;
        label_38:
    }
    public void WriteToBuffers(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 业下丌下三丕丙丌下, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丈丂业丏丕不丆业丑, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丁丂专业丁丅丅丈丙, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丏丟万且丝丒丝丅东, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector4> 丙丒七丄上与丏丙丙)
    {
        this.geometry.业丛丂专且丅不丌丌(业下丌下三丕丙丌下:  业下丌下三丕丙丌下, 丈丂业丏丕不丆业丑:  丈丂业丏丕不丆业丑, 丁丂专业丁丅丅丈丙:  丁丂专业丁丅丅丈丙, 丏丟万且丝丒丝丅东:  丏丟万且丝丒丝丅东, 丙丒七丄上与丏丙丙:  丙丒七丄上与丏丙丙);
    }
    public virtual void MakePixelPerfect()
    {
        var val_3;
        var val_13;
        float val_14;
        var val_16;
        float val_17;
        var val_19;
        float val_20;
        UnityEngine.Vector3 val_2 = this.cachedTransform.localPosition;
        if(val_2.z >= 0f)
        {
            goto label_4;
        }
        
        if((double)val_2.z != (-0.5))
        {
            goto label_5;
        }
        
        val_13 = val_3;
        val_14 = -1f;
        goto label_6;
        label_4:
        if((double)val_2.z != 0.5)
        {
            goto label_7;
        }
        
        val_13 = val_3;
        val_14 = 1f;
        label_6:
        val_14 = (float)val_13 + val_14;
        var val_4 = (((long)val_13 & 1) != 0) ? ((float)val_13) : (val_14);
        goto label_9;
        label_5:
        float val_13 = -0.5f;
        val_13 = val_2.z + val_13;
        goto label_9;
        label_7:
        float val_14 = 0.5f;
        val_14 = val_2.z + val_14;
        label_9:
        if(val_2.x >= 0f)
        {
            goto label_10;
        }
        
        if((double)val_2.x != (-0.5))
        {
            goto label_11;
        }
        
        val_16 = val_3;
        val_17 = -1f;
        goto label_12;
        label_10:
        if((double)val_2.x != 0.5)
        {
            goto label_13;
        }
        
        val_16 = val_3;
        val_17 = 1f;
        label_12:
        val_17 = (float)val_16 + val_17;
        var val_5 = (((long)val_16 & 1) != 0) ? ((float)val_16) : (val_17);
        goto label_15;
        label_11:
        float val_15 = -0.5f;
        val_15 = val_2.x + val_15;
        goto label_15;
        label_13:
        float val_16 = 0.5f;
        val_16 = val_2.x + val_16;
        label_15:
        if(val_2.y >= 0f)
        {
            goto label_16;
        }
        
        if((double)val_2.y != (-0.5))
        {
            goto label_17;
        }
        
        val_19 = val_3;
        val_20 = -1f;
        goto label_18;
        label_16:
        if((double)val_2.y != 0.5)
        {
            goto label_19;
        }
        
        val_19 = val_3;
        val_20 = 1f;
        label_18:
        val_20 = (float)val_19 + val_20;
        var val_6 = (((long)val_19 & 1) != 0) ? ((float)val_19) : (val_20);
        goto label_21;
        label_17:
        float val_17 = -0.5f;
        val_17 = val_2.y + val_17;
        goto label_21;
        label_19:
        float val_18 = 0.5f;
        val_18 = val_2.y + val_18;
        label_21:
        this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_9 = this.cachedTransform.localScale;
        float val_11 = UnityEngine.Mathf.Sign(f:  val_9.x);
        float val_12 = UnityEngine.Mathf.Sign(f:  val_9.y);
        val_3 = 0;
        this.cachedTransform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public virtual int get_minWidth()
    {
        return 2;
    }
    public virtual int get_minHeight()
    {
        return 2;
    }
    public virtual UnityEngine.Vector4 get_border()
    {
        return UnityEngine.Vector4.zero;
    }
    public virtual void set_border(UnityEngine.Vector4 丙业与丙丗丝不丈东)
    {
    
    }
    public virtual void OnFill(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
    
    }
    public UIWidget()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.mPivot = 4;
        this.mHeight = 100;
        this.mColor = val_1;
        mem[1152921535256399416] = val_1.g;
        mem[1152921535256399420] = val_1.b;
        mem[1152921535256399424] = val_1.a;
        this.aspectRatio = 1f;
        this.geometry = new 丏丌业丑万丐丐不丙();
        this.fillGeometry = true;
        this.丅三丒上万丗丗丄丝 = true;
        this.丅丆专丛丛丈上丆万 = true;
        this.丆专万与一丒丕丐下 = true;
        this.一七且且丗丞丂丘专 = true;
        this.万丈丅不丌丗业丕丙 = 0;
        mem[1152921535256399504] = 0;
        mem[1152921535256399512] = 0;
        this.三丑丄丄丘丛丐世不 = new UnityEngine.Vector3[4];
        this.不不丙丈与专丄丏丌 = 0;
        this.丒丈上万丘丁丟丕丄 = 0;
    }

}
