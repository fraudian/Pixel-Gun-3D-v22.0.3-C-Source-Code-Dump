using UnityEngine;
public abstract class UIRect : MonoBehaviour
{
    // Fields
    public UIRect.AnchorPoint leftAnchor;
    public UIRect.AnchorPoint rightAnchor;
    public UIRect.AnchorPoint bottomAnchor;
    public UIRect.AnchorPoint topAnchor;
    public UIRect.丘一丄与上世丑七丅 updateAnchors;
    protected UnityEngine.GameObject 丑丒丕上三丑丒专上;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected 丒丞丕丕七丁丗丟丛<UIRect> 与不丆业丌下丞丙与;
    protected bool 丆丕丟丄丅丄专与专;
    protected bool 丝与与丐丁丆丌下丐;
    private bool 丞业世东丟下专丗世;
    private int 丒丕下丐丅丄丒丁丛;
    private bool 东丞丑东三东七丐丌;
    private UIRoot 丝丘下与丛丟丁东丏;
    private UIRect 丟丑丘丈且丕丈丂世;
    private bool 一丏七丐丐世丒与专;
    protected UnityEngine.Camera 丟丕东万丐丁丁专一;
    protected bool 不世丌丝且三上丏丌;
    public float finalAlpha;
    protected static UnityEngine.Vector3[] 专丏丛下世丙丝丈三;
    
    // Properties
    public UnityEngine.GameObject 丕丂丂丌丛不丏丙七 { get; }
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Camera 上丙七丂丛丙七万下 { get; }
    public bool 业丙与丅丆丙丟与丕 { get; }
    public virtual bool 不丄丄东专丌丆一丐 { get; }
    public virtual bool 业丕丁下世与万三丑 { get; }
    public virtual bool 丞七丟丞丒丂丕七丆 { get; }
    public UIRect 丈东丘丏与丌东东下 { get; }
    public UIRoot 七万上丐一丈丏丏专 { get; }
    public bool 丕专上业丕丄上丏且 { get; }
    public abstract float 与专丌丅丙上丌一丄 { get; set; }
    public abstract UnityEngine.Vector3[] 丝下丒丙丂万丆丞业 { get; }
    public abstract UnityEngine.Vector3[] 丈丞上三七丌丑业丛 { get; }
    protected float 丒上三丕丙丄丑东丝 { get; }
    
    // Methods
    public UnityEngine.GameObject get_cachedGameObject()
    {
        UnityEngine.GameObject val_3;
        if(this.丑丒丕上三丑丒专上 == 0)
        {
                this.丑丒丕上三丑丒专上 = this.gameObject;
            return val_3;
        }
        
        val_3 = this.丑丒丕上三丑丒专上;
        return val_3;
    }
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    public UnityEngine.Camera get_anchorCamera()
    {
        if(this.东丞丑东三东七丐丌 == true)
        {
                return (UnityEngine.Camera)this.丟丕东万丐丁丁专一;
        }
        
        this.ResetAnchors();
        return (UnityEngine.Camera)this.丟丕东万丐丁丁专一;
    }
    public bool get_isFullyAnchored()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.leftAnchor.target)) == false)
        {
                return false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rightAnchor.target)) == false)
        {
                return false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.topAnchor.target)) == false)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.bottomAnchor.target);
    }
    public virtual bool get_isAnchoredHorizontally()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.leftAnchor.target)) == false)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.rightAnchor.target);
        }
        
        return true;
    }
    public virtual bool get_isAnchoredVertically()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bottomAnchor.target)) == false)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.topAnchor.target);
        }
        
        return true;
    }
    public virtual bool get_canBeAnchored()
    {
        return true;
    }
    public UIRect get_parent()
    {
        UIRect val_4;
        if(this.丝与与丐丁丆丌下丐 != false)
        {
                val_4 = this.丟丑丘丈且丕丈丂世;
            return val_3;
        }
        
        this.丝与与丐丁丆丌下丐 = true;
        UIRect val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRect>(丄上七丟不丗丕下丟:  this.cachedTransform.parent);
        this.丟丑丘丈且丕丈丂世 = val_3;
        return val_3;
    }
    public UIRoot get_root()
    {
        UIRect val_5;
        UIRoot val_6;
        val_5 = this;
        goto label_1;
        label_5:
        val_5 = this.丟丑丘丈且丕丈丂世;
        label_1:
        if(val_5.parent != 0)
        {
            goto label_5;
        }
        
        if(this.丟丑丘丈且丕丈丂世.一丏七丐丐世丒与专 != false)
        {
                val_6 = this.丟丑丘丈且丕丈丂世.丝丘下与丛丟丁东丏;
            return val_4;
        }
        
        this.丟丑丘丈且丕丈丂世.一丏七丐丐世丒与专 = true;
        UIRoot val_4 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丄上七丟不丗丕下丟:  val_5.cachedTransform);
        this.丟丑丘丈且丕丈丂世.丝丘下与丛丟丁东丏 = val_4;
        return val_4;
    }
    public bool get_isAnchored()
    {
        var val_10;
        var val_11;
        val_10 = this;
        val_11 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.leftAnchor.target)) != true)
        {
                val_11 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.rightAnchor.target)) != true)
        {
                val_11 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.topAnchor.target)) != true)
        {
                val_11 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.bottomAnchor.target)) == false)
        {
                return false;
        }
        
        }
        
        }
        
        }
        
        val_10 = ???;
        goto typeof(UIRect).__il2cppRuntimeField_188;
    }
    public abstract float get_alpha(); // 0
    public abstract void set_alpha(float 丙业与丙丗丝不丈东); // 0
    public abstract float CalculateFinalAlpha(int 与专丙丝丝且丂且丒); // 0
    public abstract UnityEngine.Vector3[] get_localCorners(); // 0
    public abstract UnityEngine.Vector3[] get_worldCorners(); // 0
    protected float 丂业一丏三丞七三丌()
    {
        UnityEngine.Camera val_17;
        var val_18;
        float val_19;
        val_17 = this;
        if(this.东丞丑东三东七丐丌 != true)
        {
                this.ResetAnchors();
        }
        
        val_18 = 0f;
        if(this.丟丕东万丐丁丁专一 == 0)
        {
                return (float)UnityEngine.Mathf.Lerp(a:  val_19 = this.丟丕东万丐丁丁专一.nearClipPlane, b:  val_17.farClipPlane, t:  0.5f);
        }
        
        if(this.丟丕东万丐丁丁专一.orthographic != true)
        {
                UnityEngine.Transform val_3 = this.cachedTransform;
            UnityEngine.Transform val_4 = this.丟丕东万丐丁丁专一.transform;
            UnityEngine.Quaternion val_5 = val_3.rotation;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = val_3.position;
            UnityEngine.Vector3 val_9 = val_4.position;
            val_19 = val_9.x;
            UnityEngine.Quaternion val_10 = val_4.rotation;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, point:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_18 = val_19;
            if((568325152 & 1) != 0)
        {
                return (float)UnityEngine.Mathf.Lerp(a:  val_19, b:  val_17.farClipPlane, t:  0.5f);
        }
        
        }
        
        val_17 = this.丟丕东万丐丁丁专一;
        return (float)UnityEngine.Mathf.Lerp(a:  val_19, b:  val_17.farClipPlane, t:  0.5f);
    }
    public virtual void Invalidate(bool 丕丐丟下东专丒丘业)
    {
        var val_1;
        this.丆丕丟丄丅丄专与专 = true;
        if(丕丐丟下东专丒丘业 == false)
        {
                return;
        }
        
        val_1 = 0;
    }
    public virtual UnityEngine.Vector3[] GetSides(UnityEngine.Transform 一世丛下丘东世专丈)
    {
        float val_7;
        var val_8;
        UnityEngine.Vector3[] val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.东丞丑东三东七丐丌 != true)
        {
                this.ResetAnchors();
        }
        
        if(this.丟丕东万丐丁丁专一 != 0)
        {
                return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  this.丟丕东万丐丁丁专一, 丟丕丞丁丝丂上丄上:  this.丂业一丏三丞七三丌(), 一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        UnityEngine.Vector3 val_4 = this.cachedTransform.position;
        val_7 = val_4.x;
        do
        {
            val_8 = null;
            val_8 = null;
            val_9 = 0 + 1;
            val_10 = 0 + 12;
            mem2[0] = val_7;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
        }
        while(val_9 != 4);
        
        if(一世丛下丘东世专丈 != 0)
        {
                var val_7 = 0;
            do
        {
            val_11 = null;
            val_11 = null;
            val_9 = UIRect.专丏丛下世丙丝丈三;
            UnityEngine.Vector3 val_6 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = UIRect.专丏丛下世丙丝丈三 + 32, y = UIRect.专丏丛下世丙丝丈三 + 32 + 4, z = UIRect.专丏丛下世丙丝丈三 + 40});
            val_7 = val_6.x;
            val_7 = val_7 + 1;
            val_10 = 0 + 12;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_7;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_6.y;
            UIRect.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_6.z;
        }
        while(val_7 != 4);
        
        }
        
        val_12 = null;
        val_12 = null;
        return (UnityEngine.Vector3[])UIRect.专丏丛下世丙丝丈三;
    }
    protected UnityEngine.Vector3 丂七丆东专三丙丂万(UIRect.AnchorPoint 丗丐与丐丕丆丗丁下, UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        UnityEngine.Object val_16;
        UnityEngine.Camera val_17;
        float val_21;
        float val_22;
        val_16 = 丄上七丟不丗丕下丟;
        val_17 = 丗丐与丐丕丆丗丁下;
        if(this.东丞丑东三东七丐丌 != true)
        {
                this.ResetAnchors();
        }
        
        if(this.丟丕东万丐丁丁专一 != 0)
        {
                if(丗丐与丐丕丆丗丁下.targetCam != 0)
        {
            goto label_8;
        }
        
        }
        
        val_16 = this.cachedTransform;
        UnityEngine.Vector3 val_4 = val_16.localPosition;
        return new UnityEngine.Vector3() {x = val_15.x, y = val_16, z = val_15.z};
        label_8:
        UnityEngine.Rect val_5 = 丗丐与丐丕丆丗丁下.targetCam.rect;
        val_17 = 丗丐与丐丕丆丗丁下.targetCam;
        UnityEngine.Vector3 val_6 = 丗丐与丐丕丆丗丁下.target.position;
        UnityEngine.Vector3 val_7 = val_17.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        float val_8 = val_5.m_XMin.System.IConvertible.ToSingle(provider:  0);
        float val_11 = (val_7.x * val_7.x) + val_8;
        float val_12 = (val_7.y * val_8) + val_8;
        val_21 = 0f;
        UnityEngine.Vector3 val_13 = this.丟丕东万丐丁丁专一.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_21});
        val_22 = val_13.x;
        if(val_16 != 0)
        {
                val_21 = val_13.z;
            UnityEngine.Vector3 val_15 = val_16.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_22, y = val_13.y, z = val_21});
            val_22 = val_15.x;
        }
        
        float val_16 = 0.5f;
        val_15.x = val_22 + val_16;
        val_16 = val_15.y + val_16;
        return new UnityEngine.Vector3() {x = val_15.x, y = val_16, z = val_15.z};
    }
    protected virtual void OnEnable()
    {
        this.丒丕下丐丅丄丒丁丛 = 0;
        if(this.updateAnchors == 0)
        {
                this.东丞丑东三东七丐丌 = false;
            this.丞业世东丟下专丗世 = true;
        }
        
        this.丒丕下丐丅丄丒丁丛 = 0;
    }
    protected virtual void 丅丒丐且丘丝丝丄且()
    {
        this.丆丕丟丄丅丄专与专 = true;
        this.丝与与丐丁丆丌下丐 = false;
        this.一丏七丐丐世丒与专 = false;
        if(this.parent == 0)
        {
                return;
        }
        
        this.丟丑丘丈且丕丈丂世.与不丆业丌下丞丙与.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
    }
    protected virtual void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丟丑丘丈且丕丈丂世)) != false)
        {
                bool val_2 = this.丟丑丘丈且丕丈丂世.与不丆业丌下丞丙与.Remove(下丅丙一丂丗丅丝七:  this);
        }
        
        this.丝与与丐丁丆丌下丐 = false;
        this.一丏七丐丐世丒与专 = false;
        this.丝丘下与丛丟丁东丏 = 0;
        this.丟丑丘丈且丕丈丂世 = 0;
    }
    protected virtual void Awake()
    {
        不丌丂丁丄一与丆丙.丈丝丟丁业丙一世丕(下丐三丆丝与不丗丕:  this.gameObject);
        this.不世丌丝且三上丏丌 = false;
        this.丑丒丕上三丑丒专上 = this.gameObject;
        this.丐一丗丛丕世丘东丁 = this.transform;
    }
    protected void Start()
    {
        this.不世丌丝且三上丏丌 = true;
        goto typeof(UIRect).__il2cppRuntimeField_278;
    }
    public void Update()
    {
        if(this.东丞丑东三东七丐丌 != true)
        {
                this.ResetAnchors();
        }
        
        int val_1 = UnityEngine.Time.frameCount;
        if(this.丒丕下丐丅丄丒丁丛 == val_1)
        {
                return;
        }
        
        if(this.updateAnchors != 1)
        {
                if(this.丞业世东丟下专丗世 == false)
        {
            goto typeof(UIRect).__il2cppRuntimeField_288;
        }
        
        }
        
        this.丒东丑丆丄丝上东丂(丒丄丙丄丅丅业丏万:  val_1);
        goto typeof(UIRect).__il2cppRuntimeField_288;
    }
    protected void 丒东丑丆丄丝上东丂(int 丒丄丙丄丅丅业丏万)
    {
        var val_16;
        UnityEngine.Transform val_17;
        this.丒丕下丐丅丄丒丁丛 = 丒丄丙丄丅丅业丏万;
        this.丞业世东丟下专丗世 = false;
        if((UnityEngine.Object.op_Implicit(exists:  this.leftAnchor.target)) != false)
        {
                if((this.leftAnchor.rect != 0) && (this.leftAnchor.rect.丒丕下丐丅丄丒丁丛 != 丒丄丙丄丅丅业丏万))
        {
                this.leftAnchor.rect.Update();
        }
        
            val_16 = 1;
        }
        else
        {
                val_16 = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bottomAnchor.target)) != false)
        {
                if((this.bottomAnchor.rect != 0) && (this.bottomAnchor.rect.丒丕下丐丅丄丒丁丛 != 丒丄丙丄丅丅业丏万))
        {
                this.bottomAnchor.rect.Update();
        }
        
            val_16 = 1;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rightAnchor.target)) != false)
        {
                if((this.rightAnchor.rect != 0) && (this.rightAnchor.rect.丒丕下丐丅丄丒丁丛 != 丒丄丙丄丅丅业丏万))
        {
                this.rightAnchor.rect.Update();
        }
        
            val_16 = 1;
        }
        
        val_17 = this.topAnchor.target;
        if((UnityEngine.Object.op_Implicit(exists:  val_17)) != false)
        {
                val_17 = this.topAnchor.rect;
            if(val_17 == 0)
        {
            goto typeof(UIRect).__il2cppRuntimeField_248;
        }
        
            val_17 = this.topAnchor.rect;
            if(this.topAnchor.rect.丒丕下丐丅丄丒丁丛 == 丒丄丙丄丅丅业丏万)
        {
            goto typeof(UIRect).__il2cppRuntimeField_248;
        }
        
            this.topAnchor.rect.Update();
        }
        else
        {
                if(val_16 == 0)
        {
                return;
        }
        
        }
    
    }
    public void UpdateAnchors()
    {
        if(this.isAnchored == false)
        {
                return;
        }
        
        this.丒丕下丐丅丄丒丁丛 = 0;
        this.丞业世东丟下专丗世 = true;
        this.丒东丑丆丄丝上东丂(丒丄丙丄丅丅业丏万:  UnityEngine.Time.frameCount);
    }
    protected abstract void 东七一下丕丛与丑丝(); // 0
    public void SetAnchor(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        this.leftAnchor.target = 丙丒七丄上与丏丙丙;
        this.rightAnchor.target = 丙丒七丄上与丏丙丙;
        this.topAnchor.target = 丙丒七丄上与丏丙丙;
        this.bottomAnchor.target = 丙丒七丄上与丏丙丙;
        this.ResetAnchors();
        this.UpdateAnchors();
    }
    public void SetAnchor(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 != 0)
        {
                0 = 丝三丁东丈丒世丅业.transform;
        }
        
        this.leftAnchor.target = 0;
        this.rightAnchor.target = 0;
        this.topAnchor.target = 0;
        this.bottomAnchor.target = 0;
        this.ResetAnchors();
        this.UpdateAnchors();
    }
    public void SetAnchor(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丈丂丕下丏丈丞丗业, int 专丙丗业世丐与丝丙, int 丂丌丌丛丆丆丙丌丈, int 世丂丘万丛万丞丞丌)
    {
        if(丝三丁东丈丒世丅业 != 0)
        {
                0 = 丝三丁东丈丒世丅业.transform;
        }
        
        this.leftAnchor.target = 0;
        this.rightAnchor.target = 0;
        this.topAnchor.target = 0;
        this.bottomAnchor.target = 0;
        this.leftAnchor.relative = 0f;
        this.rightAnchor.relative = 1f;
        this.bottomAnchor.relative = 0f;
        this.topAnchor.relative = 1f;
        this.leftAnchor.absolute = 丈丂丕下丏丈丞丗业;
        this.rightAnchor.absolute = 丂丌丌丛丆丆丙丌丈;
        this.bottomAnchor.absolute = 专丙丗业世丐与丝丙;
        this.topAnchor.absolute = 世丂丘万丛万丞丞丌;
        this.ResetAnchors();
        this.UpdateAnchors();
    }
    public void ResetAnchors()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        this.东丞丑东三东七丐丌 = true;
        val_12 = 0;
        this.leftAnchor.rect = this.leftAnchor.target.GetComponent<UIRect>();
        val_13 = 0;
        this.bottomAnchor.rect = this.bottomAnchor.target.GetComponent<UIRect>();
        val_14 = 0;
        this.rightAnchor.rect = this.rightAnchor.target.GetComponent<UIRect>();
        val_15 = 0;
        this.topAnchor.rect = this.topAnchor.target.GetComponent<UIRect>();
        UnityEngine.Camera val_11 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.cachedGameObject.layer);
        this.丟丕东万丐丁丁专一 = val_11;
        val_11.上业丅丁丆东丞丁一(丟丞丌一世丐且丄丂:  this.leftAnchor);
        val_11.上业丅丁丆东丞丁一(丟丞丌一世丐且丄丂:  this.bottomAnchor);
        val_11.上业丅丁丆东丞丁一(丟丞丌一世丐且丄丂:  this.rightAnchor);
        val_11.上业丅丁丆东丞丁一(丟丞丌一世丐且丄丂:  this.topAnchor);
        this.丞业世东丟下专丗世 = true;
    }
    public void ResetAndUpdateAnchors()
    {
        this.ResetAnchors();
        this.UpdateAnchors();
    }
    public abstract void SetRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一); // 0
    private void 上业丅丁丆东丞丁一(UIRect.AnchorPoint 丟丞丌一世丐且丄丂)
    {
        if(丟丞丌一世丐且丄丂.target != 0)
        {
                0 = 0;
        }
        
        丟丞丌一世丐且丄丂.targetCam = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  丟丞丌一世丐且丄丂.target.gameObject.layer);
    }
    public virtual void ParentHasChanged()
    {
        UIRect val_8;
        this.丝与与丐丁丆丌下丐 = false;
        UIRect val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRect>(丄上七丟不丗丕下丟:  this.cachedTransform.parent);
        val_8 = this.丟丑丘丈且丕丈丂世;
        if(val_8 == val_3)
        {
                return;
        }
        
        val_8 = this.丟丑丘丈且丕丈丂世;
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_8 = this.丟丑丘丈且丕丈丂世.与不丆业丌下丞丙与;
            bool val_6 = val_8.Remove(下丅丙一丂丗丅丝七:  this);
        }
        
        this.丟丑丘丈且丕丈丂世 = val_3;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                this.丟丑丘丈且丕丈丂世.与不丆业丌下丞丙与.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
        }
        
        this.一丏七丐丐世丒与专 = false;
    }
    protected abstract void 丁业三上丛丐且专东(); // 0
    protected virtual void 丑丈丆万丅上丞丗丐()
    {
    
    }
    protected UIRect()
    {
        this.leftAnchor = new UIRect.AnchorPoint();
        .relative = 1f;
        this.rightAnchor = new UIRect.AnchorPoint();
        this.bottomAnchor = new UIRect.AnchorPoint();
        .relative = 1f;
        this.topAnchor = new UIRect.AnchorPoint();
        this.updateAnchors = 1;
        this.与不丆业丌下丞丙与 = new 丒丞丕丕七丁丗丟丛<UIRect>();
        this.丆丕丟丄丅丄专与专 = 1;
        this.丞业世东丟下专丗世 = 1;
        this.丒丕下丐丅丄丒丁丛 = 0;
        this.finalAlpha = 1f;
    }
    private static UIRect()
    {
        UIRect.专丏丛下世丙丝丈三 = new UnityEngine.Vector3[4];
    }

}
