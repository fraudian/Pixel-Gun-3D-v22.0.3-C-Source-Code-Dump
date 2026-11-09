using UnityEngine;
public class UIDragObject : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform target;
    public UIPanel panelRegion;
    public UnityEngine.Vector3 scrollMomentum;
    public bool restrictWithinPanel;
    public UIRect contentRect;
    public UIDragObject.丏丛丙一丘丞丅丞丑 dragEffect;
    public float momentumAmount;
    protected UnityEngine.Vector3 scale;
    private float scrollWheelFactor;
    private UnityEngine.Plane 丑丞丗专丁丕丂丁丅;
    private UnityEngine.Vector3 丗丝丑丐丑丂七丌丄;
    private UnityEngine.Vector3 专丟丆丛丁七下三丝;
    private UnityEngine.Vector3 七丐丁丆上丒丄丏三;
    private UnityEngine.Vector3 丈世丙业业七丟不丒;
    private UnityEngine.Bounds 业丛丟三丌丈下不丄;
    private int 丘与丂丐丐丂不丒丝;
    private bool 不世丌丝且三上丏丌;
    private bool 且丙万丞东丗下丝丅;
    
    // Properties
    public UnityEngine.Vector3 丈丝七专万丘七业下 { get; set; }
    
    // Methods
    public UnityEngine.Vector3 get_dragMovement()
    {
        return new UnityEngine.Vector3() {x = this.scale};
    }
    public void set_dragMovement(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.scale = 丙业与丙丗丝不丈东;
        mem[1152921531087098940] = 丙业与丙丗丝不丈东.y;
        mem[1152921531087098944] = 丙业与丙丗丝不丈东.z;
    }
    private void OnEnable()
    {
        if(this.scrollWheelFactor != 0f)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.scale, y = V9.16B, z = V10.16B}, d:  this.scrollWheelFactor);
            this.scrollMomentum = val_1;
            mem[1152921531087235484] = val_1.y;
            mem[1152921531087235488] = val_1.z;
            this.scrollWheelFactor = 0f;
        }
        
        if(((this.contentRect == 0) && (this.target != 0)) && (UnityEngine.Application.isPlaying != false))
        {
                UIWidget val_5 = this.target.GetComponent<UIWidget>();
            if(val_5 != 0)
        {
                this.contentRect = val_5;
        }
        
        }
        
        if(this.target != 0)
        {
                UnityEngine.Vector3 val_8 = this.target.position;
        }
        else
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        }
        
        this.丗丝丑丐丑丂七丌丄 = val_9;
        mem[1152921531087235548] = val_9.y;
        mem[1152921531087235552] = val_9.z;
    }
    private void OnDisable()
    {
        this.不世丌丝且三上丏丌 = false;
    }
    private void 不丝丁丙丞丐三丝专()
    {
        if(this.target != 0)
        {
                0 = UIPanel.Find(丄上七丟不丗丕下丟:  this.target.transform.parent);
        }
        
        this.panelRegion = 0;
        if(0 != 0)
        {
                return;
        }
        
        this.restrictWithinPanel = false;
    }
    private void 丂丌丐丁丐上一东丛()
    {
        UnityEngine.Bounds val_6;
        var val_7;
        var val_11;
        float val_12;
        UnityEngine.Bounds val_13;
        var val_14;
        val_11 = this;
        val_12 = 0;
        val_13 = UnityEngine.Object.op_Implicit(exists:  this.contentRect);
        UnityEngine.Transform val_2 = this.panelRegion.cachedTransform;
        if(val_13 == false)
        {
            goto label_4;
        }
        
        UnityEngine.Matrix4x4 val_3 = val_2.worldToLocalMatrix;
        val_14 = 0;
        goto label_7;
        label_11:
        val_12 = 8.96831E-44f;
        val_14 = 1;
        mem[32] = val_12;
        mem[36] = 0f;
        mem[40] = 4.656534E-34f;
        label_7:
        if(val_14 < 4)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_7 = 0;
        val_6 = 0;
        val_13 = this.业丛丟三丌丈下不丄;
        UIRect val_9 = this.contentRect + 52;
        mem[1152921531087690408] = val_7;
        this.业丛丟三丌丈下不丄 = val_6;
        do
        {
            val_11 = 1 + 1;
        }
        while(val_11 != 4);
        
        return;
        label_4:
        UnityEngine.Bounds val_10 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  val_2, 三丏丑不业丏不丂丈:  this.target);
        mem[1152921531087690408] = val_7;
        this.业丛丟三丌丈下不丄 = val_6;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        UnityEngine.GameObject val_14;
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_15 = null;
        val_15 = null;
        val_16 = UICamera.currentTouchID;
        if(val_16 == 2)
        {
                return;
        }
        
        val_16 = UICamera.currentTouchID;
        if(val_16 == 3)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.timeScale;
        if(val_1 < 0)
        {
                if(val_1 != 0f)
        {
                return;
        }
        
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        val_14 = this.gameObject;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_14)) == false)
        {
                return;
        }
        
        val_14 = this.target;
        if(val_14 == 0)
        {
                return;
        }
        
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_16;
        }
        
        if(this.且丙万丞东丗下丝丅 == true)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        this.不世丌丝且三上丏丌 = true;
        this.且丙万丞东丗下丝丅 = true;
        this.丘与丂丐丐丂不丒丝 = UICamera.currentTouchID;
        this.CancelMovement();
        if(this.restrictWithinPanel != false)
        {
                if(this.panelRegion == 0)
        {
                this.不丝丁丙丞丐三丝专();
        }
        
            if(this.restrictWithinPanel != false)
        {
                this.丂丌丐丁丐上一东丛();
        }
        
        }
        
        this.CancelSpring();
        val_18 = null;
        val_18 = null;
        val_14 = this.panelRegion;
        val_19 = UICamera.currentCamera.transform;
        if(val_14 == 0)
        {
            goto label_30;
        }
        
        val_19 = this.panelRegion.cachedTransform;
        if(val_19 != null)
        {
            goto label_42;
        }
        
        goto label_33;
        label_16:
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(this.丘与丂丐丐丂不丒丝 != UICamera.currentTouchID)
        {
                return;
        }
        
        this.且丙万丞东丗下丝丅 = false;
        if(this.restrictWithinPanel == false)
        {
                return;
        }
        
        if(this.dragEffect != 2)
        {
                return;
        }
        
        val_14 = this.target;
        if((this.panelRegion.ConstrainTargetToBounds(丞下万上三丘上与专:  val_14, 不且丆东丝丟丛丅东: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}, m_Extents = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}}, 丌丄丗七丝丘与丆与:  false)) == false)
        {
                return;
        }
        
        this.CancelMovement();
        return;
        label_30:
        if(val_19 != null)
        {
            goto label_42;
        }
        
        label_33:
        label_42:
        UnityEngine.Quaternion val_11 = val_19.rotation;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, point:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_21 = null;
        val_21 = null;
        this.丑丞丗专丁丕丂丁丅 = 0;
        mem[1152921531087896556] = 0;
        mem[1152921531087896564] = 0;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_7;
        丞上且下专丞东专世 val_23;
        var val_24;
        var val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        val_23 = 1152921505096622080;
        val_24 = null;
        val_24 = null;
        if(this.丘与丂丐丐丂不丒丝 != UICamera.currentTouchID)
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
        
        if(this.target == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if(UICamera.currentTouch == null)
        {
                val_25 = null;
        }
        
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 2;
        val_23 = UICamera.currentTouch;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UICamera.currentTouch.下业丕七东丌丝下且, y = UICamera.currentTouch + 20 + 4});
        val_26 = val_5.x;
        val_27 = val_5.z;
        UnityEngine.Ray val_6 = UICamera.currentCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_26, y = val_5.y, z = val_27});
        if((this.丑丞丗专丁丕丂丁丅 & 1) == 0)
        {
                return;
        }
        
        val_28 = val_7;
        val_29 = 0f;
        val_30 = val_28;
        val_31 = val_27;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = val_30, z = val_31}, b:  new UnityEngine.Vector3() {x = this.专丟丆丛丁七下三丝, y = val_5.y, z = val_26});
        val_35 = val_9.x;
        val_36 = val_9.y;
        val_37 = val_9.z;
        this.专丟丆丛丁七下三丝 = 0f;
        mem[1152921531088094568] = val_28;
        mem[1152921531088094572] = val_27;
        if(this.不世丌丝且三上丏丌 != true)
        {
                this.不世丌丝且三上丏丌 = true;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_35 = val_10.x;
            val_36 = val_10.y;
            val_37 = val_10.z;
        }
        
        if(val_35 == 0f)
        {
                if(val_36 == 0f)
        {
            goto label_26;
        }
        
        }
        
        UnityEngine.Vector3 val_11 = this.target.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37});
        val_29 = val_11.x;
        val_30 = val_11.y;
        val_31 = val_11.z;
        UnityEngine.Vector3 val_12 = this.target.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31});
        val_35 = val_12.x;
        val_36 = val_12.y;
        val_37 = val_12.z;
        label_26:
        if(this.dragEffect != 0)
        {
                val_38 = this.momentumAmount;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, d:  val_38 * 0.01f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = val_28, z = 0f}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_29 = this.七丐丁丆上丒丄丏三;
            val_30 = val_28;
            val_31 = 0f;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = 0f}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, t:  0.67f);
            this.七丐丁丆上丒丄丏三 = val_16;
            mem[1152921531088094580] = val_16.y;
            mem[1152921531088094584] = val_16.z;
        }
        
        UnityEngine.Vector3 val_17 = this.target.localPosition;
        val_26 = val_17.x;
        val_27 = val_17.z;
        this.下丏且一三丐一丐不(丈且下丕丆丗丑专一:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37});
        if(this.restrictWithinPanel == false)
        {
                return;
        }
        
        val_23 = this.target;
        val_28 = val_36;
        UnityEngine.Vector3 val_18 = val_23.localPosition;
        val_38 = val_18.x;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_26, y = val_17.y, z = val_27});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_35, y = val_28, z = val_37}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        if(this.dragEffect == 2)
        {
                return;
        }
        
        val_23 = this.panelRegion;
        if((val_23.ConstrainTargetToBounds(丞下万上三丘上与专:  this.target, 不且丆东丝丟丛丅东: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}, m_Extents = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}}, 丌丄丗七丝丘与丆与:  true)) == false)
        {
                return;
        }
        
        this.CancelMovement();
    }
    private void 下丏且一三丐一丐不(UnityEngine.Vector3 丈且下丕丆丗丑专一)
    {
        float val_7;
        float val_10;
        var val_11;
        float val_22;
        float val_23;
        var val_24;
        float val_25;
        UnityEngine.Transform val_26;
        float val_27;
        float val_28;
        var val_30;
        float val_31;
        if(this.panelRegion == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丗丝丑丐丑丂七丌丄, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = 丈且下丕丆丗丑专一.x, y = 丈且下丕丆丗丑专一.y, z = 丈且下丕丆丗丑专一.z});
        this.丗丝丑丐丑丂七丌丄 = val_2;
        mem[1152921531088300828] = val_2.y;
        mem[1152921531088300832] = val_2.z;
        UnityEngine.Transform val_3 = this.target.parent;
        UnityEngine.Rigidbody val_4 = this.target.GetComponent<UnityEngine.Rigidbody>();
        if(val_3 == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Matrix4x4 val_6 = val_3.worldToLocalMatrix;
        val_23 = val_10;
        if(this.丗丝丑丐丑丂七丌丄 >= 0f)
        {
            goto label_14;
        }
        
        if((double)this.丗丝丑丐丑丂七丌丄 != (-0.5))
        {
            goto label_15;
        }
        
        val_24 = val_11;
        val_25 = -1f;
        goto label_16;
        label_3:
        val_26 = this.target;
        UnityEngine.Vector3 val_12 = val_26.position;
        val_22 = val_12.y;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_22, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 丈且下丕丆丗丑专一.x, y = 丈且下丕丆丗丑专一.y, z = 丈且下丕丆丗丑专一.z});
        val_23 = val_13.x;
        val_27 = val_13.z;
        val_26.position = new UnityEngine.Vector3() {x = val_23, y = val_13.y, z = val_27};
        return;
        label_10:
        if(val_4 == 0)
        {
            goto label_24;
        }
        
        val_23 = this.丗丝丑丐丑丂七丌丄;
        if(val_4 != null)
        {
            goto label_42;
        }
        
        goto label_26;
        label_14:
        if((double)this.丗丝丑丐丑丂七丌丄 != 0.5)
        {
            goto label_27;
        }
        
        val_24 = val_11;
        val_25 = 1f;
        label_16:
        val_25 = (float)val_24 + val_25;
        var val_15 = (((long)val_24 & 1) != 0) ? ((float)val_24) : (val_25);
        goto label_31;
        label_24:
        val_23 = this.丗丝丑丐丑丂七丌丄;
        this.target.position = new UnityEngine.Vector3() {x = val_23, y = 丈且下丕丆丗丑专一.y, z = 丈且下丕丆丗丑专一.x};
        goto label_43;
        label_15:
        float val_21 = -0.5f;
        val_21 = this.丗丝丑丐丑丂七丌丄 + val_21;
        goto label_31;
        label_27:
        float val_22 = 0.5f;
        val_22 = this.丗丝丑丐丑丂七丌丄 + val_22;
        label_31:
        if(val_7 >= 0f)
        {
            goto label_32;
        }
        
        if((double)val_7 != (-0.5))
        {
            goto label_33;
        }
        
        val_30 = val_11;
        val_31 = -1f;
        goto label_34;
        label_32:
        if((double)val_7 != 0.5)
        {
            goto label_35;
        }
        
        val_30 = val_11;
        val_31 = 1f;
        label_34:
        val_31 = (float)val_30 + val_31;
        var val_16 = (((long)val_30 & 1) != 0) ? ((float)val_30) : (val_31);
        goto label_37;
        label_33:
        float val_23 = -0.5f;
        val_23 = val_7 + val_23;
        goto label_37;
        label_35:
        float val_24 = 0.5f;
        val_24 = val_7 + val_24;
        label_37:
        if(val_4 == 0)
        {
            goto label_40;
        }
        
        UnityEngine.Matrix4x4 val_18 = val_3.localToWorldMatrix;
        val_23 = this.丗丝丑丐丑丂七丌丄;
        val_28 = val_7;
        val_27 = val_23;
        if(val_4 != null)
        {
            goto label_42;
        }
        
        label_26:
        label_42:
        val_4.position = new UnityEngine.Vector3() {x = val_23, y = val_28, z = val_27};
        goto label_43;
        label_40:
        this.target.localPosition = new UnityEngine.Vector3() {x = this.丗丝丑丐丑丂七丌丄, y = val_7, z = val_23};
        label_43:
        val_26 = this.panelRegion.GetComponent<UIScrollView>();
        if(val_26 == 0)
        {
                return;
        }
    
    }
    private void LateUpdate()
    {
        UIPanel val_13;
        if(this.target == 0)
        {
                return;
        }
        
        float val_2 = RealTime.deltaTime;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.丈世丙业业七丟不丒, y = V11.16B, z = V9.16B});
        this.七丐丁丆上丒丄丏三 = val_3;
        mem[1152921531088486676] = val_3.y;
        mem[1152921531088486680] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_5 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = this.丈世丙业业七丟不丒, y = this.丈世丙业业七丟不丒, z = V11.16B}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丛上丟丌丄丗丁世与:  20f, 丑丗丘与丈不七东丛:  val_2);
        this.丈世丙业业七丟不丒 = val_5.x;
        mem[1152921531088486688] = val_5.y;
        mem[1152921531088486692] = val_5.z;
        if(val_5.x < 0)
        {
                return;
        }
        
        if(this.且丙万丞东丗下丝丅 != false)
        {
                UnityEngine.Vector3 val_6 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = mem[1152921531088486676], z = mem[1152921531088486680]}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_2);
            return;
        }
        
        val_13 = this.panelRegion;
        if(val_13 == 0)
        {
                this.不丝丁丙丞丐三丝专();
        }
        
        UnityEngine.Vector3 val_8 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = mem[1152921531088486676], z = mem[1152921531088486680]}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_2);
        this.下丏且一三丐一丐不(丈且下丕丆丗丑专一:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        if(this.restrictWithinPanel != false)
        {
                val_13 = this.panelRegion;
            if(val_13 != 0)
        {
                this.丂丌丐丁丐上一东丛();
            val_13 = this.target;
            if((this.panelRegion.ConstrainTargetToBounds(丞下万上三丘上与专:  val_13, 不且丆东丝丟丛丅东: ref  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}, m_Extents = new UnityEngine.Vector3() {x = this.业丛丟三丌丈下不丄, y = this.业丛丟三丌丈下不丄, z = this.业丛丟三丌丈下不丄}}, 丌丄丗七丝丘与丆与:  (this.dragEffect == 0) ? 1 : 0)) != false)
        {
                this.CancelMovement();
        }
        else
        {
                this.CancelSpring();
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_12 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = mem[1152921531088486676], z = mem[1152921531088486680]}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_2);
        if(val_12.x >= 0)
        {
                return;
        }
        
        this.CancelMovement();
    }
    public void CancelMovement()
    {
        if(this.target != 0)
        {
                UnityEngine.Vector3 val_2 = this.target.localPosition;
            this.target.localPosition = new UnityEngine.Vector3() {x = (float)UnityEngine.Mathf.RoundToInt(f:  val_2.x), y = (float)UnityEngine.Mathf.RoundToInt(f:  val_2.y), z = (float)UnityEngine.Mathf.RoundToInt(f:  val_2.z)};
        }
        
        if(this.target != 0)
        {
                UnityEngine.Vector3 val_7 = this.target.position;
        }
        else
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        }
        
        this.丗丝丑丐丑丂七丌丄 = val_8;
        mem[1152921531088643708] = val_8.y;
        mem[1152921531088643712] = val_8.z;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_9;
        mem[1152921531088643732] = val_9.y;
        mem[1152921531088643736] = val_9.z;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        this.丈世丙业业七丟不丒 = val_10;
        mem[1152921531088643744] = val_10.y;
        mem[1152921531088643748] = val_10.z;
    }
    public void CancelSpring()
    {
        SpringPosition val_1 = this.target.GetComponent<SpringPosition>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.enabled = false;
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.scrollMomentum, y = V12.16B, z = V13.16B}, d:  丞且丅三三东不丄且 * 0.05f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丈世丙业业七丟不丒, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.丈世丙业业七丟不丒 = val_6;
        mem[1152921531088908704] = val_6.y;
        mem[1152921531088908708] = val_6.z;
    }
    public UIDragObject()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.scrollMomentum = val_1;
        mem[1152921531089024700] = val_1.y;
        mem[1152921531089024704] = val_1.z;
        this.dragEffect = 2;
        this.scale = 0;
        mem[1152921531089024736] = 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_2;
        mem[1152921531089024788] = val_2.y;
        mem[1152921531089024792] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.丈世丙业业七丟不丒 = val_3;
        mem[1152921531089024800] = val_3.y;
        mem[1152921531089024804] = val_3.z;
    }

}
