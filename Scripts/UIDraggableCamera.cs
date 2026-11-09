using UnityEngine;
public class UIDraggableCamera : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform rootForBounds;
    public UnityEngine.Vector2 scale;
    public float scrollWheelFactor;
    public UIDragObject.丏丛丙一丘丞丅丞丑 dragEffect;
    public bool smoothDragStart;
    public float momentumAmount;
    private UnityEngine.Camera 丟丕东万丐丁丁专一;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private bool 且丙万丞东丗下丝丅;
    private UnityEngine.Vector2 七丐丁丆上丒丄丏三;
    private UnityEngine.Bounds 业丛丟三丌丈下不丄;
    private float 丈世丙业业七丟不丒;
    private UIRoot 丝丘下与丛丟丁东丏;
    private bool 东丌丈业丙丆丄世丑;
    
    // Properties
    public UnityEngine.Vector2 东世丈不丗丏上丐丂 { get; set; }
    
    // Methods
    public UnityEngine.Vector2 get_currentMomentum()
    {
        return new UnityEngine.Vector2() {x = this.七丐丁丆上丒丄丏三};
    }
    public void set_currentMomentum(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        this.七丐丁丆上丒丄丏三 = 丙业与丙丗丝不丈东;
        mem[1152921531085666576] = 丙业与丙丗丝不丈东.y;
    }
    private void Start()
    {
        this.丟丕东万丐丁丁专一 = this.GetComponent<UnityEngine.Camera>();
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丝丘下与丛丟丁东丏 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if(this.rootForBounds != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  this.gameObject)(不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  this.gameObject)) + " needs the \'Root For Bounds\' parameter to be set", context:  this);
        this.enabled = false;
    }
    private UnityEngine.Vector3 丆世丕上丒且下丑下()
    {
        if(this.rootForBounds != 0)
        {
                if(this.rootForBounds.childCount != 0)
        {
                UnityEngine.Rect val_3 = this.丟丕东万丐丁丁专一.rect;
            UnityEngine.Rect val_6 = this.丟丕东万丐丁丁专一.rect;
            float val_21 = (float)UnityEngine.Screen.width;
            float val_22 = (float)UnityEngine.Screen.height;
            val_21 = (val_3.m_XMin.System.IConvertible.ToSingle(provider:  0)) * val_21;
            val_22 = val_6.m_XMin * val_22;
            UnityEngine.Rect val_8 = this.丟丕东万丐丁丁专一.rect;
            UnityEngine.Rect val_10 = this.丟丕东万丐丁丁专一.rect;
            float val_23 = (float)UnityEngine.Screen.width;
            float val_24 = (float)UnityEngine.Screen.height;
            val_23 = val_8.m_XMin * val_23;
            val_24 = val_10.m_XMin * val_24;
            UnityEngine.Vector3 val_12 = this.丟丕东万丐丁丁专一.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_13 = this.丟丕东万丐丁丁专一.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this = this.业丛丟三丌丈下不丄;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13.x, y:  val_13.y);
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_13.x, y:  val_13.y);
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector2 val_18 = 万丗丅且丄丑世专与.且丒丝不且与业与且(上丑丗丞业丛丟丂丄:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, 业丒世丙七丁丝上三:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, 专丐丑且丌丒丛丝丕:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, 丈万专不世且丅不丑:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            return new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        }
        
        }
        
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
    }
    public bool ConstrainToBounds(bool 丌丄丗七丝丘与丆与)
    {
        UnityEngine.Transform val_10;
        UnityEngine.Transform val_11;
        var val_12;
        val_10 = this;
        val_11 = this.丐一丗丛丕世丘东丁;
        if(val_11 == 0)
        {
            goto label_7;
        }
        
        val_11 = this.rootForBounds;
        if(val_11 == 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_3 = this.丆世丕上丒且下丑下();
        if(val_3.x <= 0f)
        {
            goto label_7;
        }
        
        if(丌丄丗七丝丘与丆与 == false)
        {
            goto label_8;
        }
        
        val_10 = this.丐一丗丛丕世丘东丁;
        UnityEngine.Vector3 val_4 = val_10.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_10.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        val_12 = 1;
        return (bool)val_12;
        label_7:
        val_12 = 0;
        return (bool)val_12;
        label_8:
        UnityEngine.Vector3 val_7 = this.丐一丗丛丕世丘东丁.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        if((SpringPosition.Begin(丝三丁东丈丒世丅业:  this.gameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丛上丟丌丄丗丁世与:  13f)) != null)
        {
                val_9.ignoreTimeScale = true;
        }
        else
        {
                mem[41] = 1;
        }
        
        val_9.worldSpace = true;
        return (bool)val_12;
    }
    public void Press(bool 丆丟专丑丁丒丁上丙)
    {
        var val_4;
        UnityEngine.Bounds val_5;
        if(丆丟专丑丁丒丁上丙 != false)
        {
                this.东丌丈业丙丆丄世丑 = false;
        }
        
        if(this.rootForBounds == 0)
        {
                return;
        }
        
        this.且丙万丞东丗下丝丅 = 丆丟专丑丁丒丁上丙;
        if(丆丟专丑丁丒丁上丙 != false)
        {
                UnityEngine.Bounds val_3 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  this.rootForBounds, 一丐丂丘专丅丟丞七:  true);
            mem[1152921531086316468] = val_4;
            this.业丛丟三丌丈下不丄 = val_5;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            this.七丐丁丆上丒丄丏三 = val_6;
            mem[1152921531086316448] = val_6.y;
            this.丈世丙业业七丟不丒 = 0f;
            this = this.GetComponent<SpringPosition>();
            if(this == 0)
        {
                return;
        }
        
            this.enabled = false;
            return;
        }
        
        if(this.dragEffect != 2)
        {
                return;
        }
        
        bool val_9 = this.ConstrainToBounds(丌丄丗七丝丘与丆与:  false);
    }
    public void Drag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_15;
        float val_16;
        var val_17;
        float val_18;
        float val_19;
        val_15 = 丞且丅三三东不丄且.y;
        val_16 = 丞且丅三三东不丄且.x;
        if(this.smoothDragStart != false)
        {
                if(this.东丌丈业丙丆丄世丑 == false)
        {
            goto label_2;
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 2;
        if(this.丝丘下与丛丟丁东丏 != 0)
        {
                float val_2 = this.丝丘下与丛丟丁东丏.pixelSizeAdjustment;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16, y = val_15}, d:  val_2);
            val_16 = val_3.x;
            val_18 = val_3.y;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = this.scale, y = val_2});
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_16, y = val_18}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        val_19 = val_5.x;
        UnityEngine.Vector3 val_6 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19, y = val_5.y});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_19, y = val_5.y}, d:  this.momentumAmount * 0.01f);
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.七丐丁丆上丒丄丏三, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = this.七丐丁丆上丒丄丏三, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, t:  0.67f);
        this.七丐丁丆上丒丄丏三 = val_12;
        mem[1152921531086465280] = val_12.y;
        if(this.dragEffect == 2)
        {
                return;
        }
        
        if((this.ConstrainToBounds(丌丄丗七丝丘与丆与:  true)) == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
        this.七丐丁丆上丒丄丏三 = val_14;
        mem[1152921531086465280] = val_14.y;
        this.丈世丙业业七丟不丒 = 0f;
        return;
        label_2:
        this.东丌丈业丙丆丄世丑 = true;
    }
    public void Scroll(float 丞且丅三三东不丄且)
    {
        float val_6;
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if((UnityEngine.Mathf.Sign(f:  this.丈世丙业业七丟不丒)) != (UnityEngine.Mathf.Sign(f:  丞且丅三三东不丄且)))
        {
                val_6 = 0f;
            this.丈世丙业业七丟不丒 = 0f;
        }
        else
        {
                val_6 = this.丈世丙业业七丟不丒;
        }
        
        float val_6 = this.scrollWheelFactor;
        val_6 = val_6 * 丞且丅三三东不丄且;
        val_6 = val_6 + val_6;
        this.丈世丙业业七丟不丒 = val_6;
    }
    private void Update()
    {
        var val_13;
        UnityEngine.Bounds val_14;
        UnityEngine.Object val_20;
        float val_22;
        UnityEngine.Vector2 val_23;
        val_20 = this;
        float val_1 = RealTime.deltaTime;
        if(this.且丙万丞东丗下丝丅 != false)
        {
                SpringPosition val_2 = this.GetComponent<SpringPosition>();
            if(val_2 != 0)
        {
                val_2.enabled = false;
        }
        
            val_22 = this.丈世丙业业七丟不丒;
            val_23 = this.七丐丁丆上丒丄丏三;
        }
        else
        {
                val_22 = val_20;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.scale, y = V11.16B}, d:  this.丈世丙业业七丟不丒 * 20f);
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = new UnityEngine.Vector2(), y = V9.16B}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_23 = val_20;
            this.七丐丁丆上丒丄丏三 = val_6;
            mem[1152921531086738400] = val_6.y;
            float val_7 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  this.丈世丙业业七丟不丒, 专丂丕丗丗东世丞下:  0f, 丛上丟丌丄丗丁世与:  20f, 丑丗丘与丈不七东丛:  val_1);
            this.丈世丙业业七丟不丒 = val_7;
            if(val_7 > 0.01f)
        {
                UnityEngine.Vector3 val_8 = this.丐一丗丛丕世丘东丁.localPosition;
            UnityEngine.Vector2 val_9 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector2() {x = this.七丐丁丆上丒丄丏三, y = mem[1152921531086738400]}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_1);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Bounds val_12 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  this.rootForBounds, 一丐丂丘专丅丟丞七:  true);
            mem[1152921531086738420] = val_13;
            this.业丛丟三丌丈下不丄 = val_14;
            if((this.ConstrainToBounds(丌丄丗七丝丘与丆与:  (this.dragEffect == 0) ? 1 : 0)) == true)
        {
                return;
        }
        
            val_20 = this.GetComponent<SpringPosition>();
            if(val_20 == 0)
        {
                return;
        }
        
            val_20.enabled = false;
            return;
        }
        
        }
        
        mem2[0] = 0;
        UnityEngine.Vector2 val_19 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector2() {x = val_23, y = val_23}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_1);
    }
    public UIDraggableCamera()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
        this.scale = val_1;
        mem[1152921531086874900] = val_1.y;
        this.dragEffect = 2;
        this.smoothDragStart = true;
        this.momentumAmount = 35f;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.七丐丁丆上丒丄丏三 = val_2;
        mem[1152921531086874944] = val_2.y;
    }

}
