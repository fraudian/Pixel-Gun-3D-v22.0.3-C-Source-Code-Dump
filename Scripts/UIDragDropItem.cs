using UnityEngine;
public class UIDragDropItem : MonoBehaviour
{
    // Fields
    internal bool 七丄不丁丁东丌丁下;
    public UIDragDropItem.不不丟丑丝且丄与丐 restriction;
    public bool cloneOnDrag;
    public float pressAndHoldDelay;
    public bool interactable;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected UnityEngine.Transform 丟丑丘丈且丕丈丂世;
    protected UnityEngine.Collider 丑一丟一丞七丆丂丄;
    protected UnityEngine.Collider2D 丕七丘丝丄丁丄丛丒;
    protected UIButton 丝丏丞丁三丅三与丞;
    protected UIRoot 丝丘下与丛丟丁东丏;
    protected UIGrid 上丛丒丟丑七万丒专;
    protected UITable 丏七丏丆丘东丝且专;
    protected float 丟万一丝东丘与丈业;
    protected UIDragScrollView 丘业丏丛下丄丙专丘;
    protected bool 且丙万丞东丗下丝丅;
    protected bool 上丁东丕丁丙业丛丞;
    protected UICamera.丞上且下专丞东专世 丈七专丗世不业丑丈;
    public static System.Collections.Generic.List<UIDragDropItem> draggedItems;
    
    // Methods
    protected virtual void Awake()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丑一丟一丞七丆丂丄 = this.gameObject.GetComponent<UnityEngine.Collider>();
        this.丕七丘丝丄丁丄丛丒 = this.gameObject.GetComponent<UnityEngine.Collider2D>();
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = UICamera.hoveredObject;
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        this.上丁东丕丁丙业丛丞 = false;
        this = ???;
        goto typeof(UIDragDropItem).__il2cppRuntimeField_238;
    }
    protected virtual void Start()
    {
        this.丝丏丞丁三丅三与丞 = this.GetComponent<UIButton>();
        this.丘业丏丛下丄丙专丘 = this.GetComponent<UIDragScrollView>();
    }
    protected virtual void OnPress(bool isPressed)
    {
        var val_2;
        int val_4;
        if(this.interactable == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = UICamera.currentTouchID;
        if(val_4 == 2)
        {
                return;
        }
        
        val_2 = null;
        val_4 = UICamera.currentTouchID;
        if(val_4 == 3)
        {
                return;
        }
        
        if(isPressed != false)
        {
                if(this.且丙万丞东丗下丝丅 == true)
        {
                return;
        }
        
            this.丈七专丗世不业丑丈 = UICamera.currentTouch;
            float val_1 = RealTime.time;
            this.且丙万丞东丗下丝丅 = true;
            val_1 = val_1 + this.pressAndHoldDelay;
            this.丟万一丝东丘与丈业 = val_1;
            return;
        }
        
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        if(this.丈七专丗世不业丑丈 != UICamera.currentTouch)
        {
                return;
        }
        
        this.且丙万丞东丗下丝丅 = false;
        this.丈七专丗世不业丑丈 = 0;
    }
    protected virtual void Update()
    {
        if(this.restriction != 3)
        {
                return;
        }
        
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        if(this.上丁东丕丁丙业丛丞 == true)
        {
                return;
        }
        
        float val_1 = RealTime.time;
        if(this.丟万一丝东丘与丈业 >= 0)
        {
                return;
        }
        
        goto typeof(UIDragDropItem).__il2cppRuntimeField_1D8;
    }
    protected virtual void OnDragStart()
    {
        var val_2;
        if(this.interactable == false)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(this.丈七专丗世不业丑丈 != UICamera.currentTouch)
        {
                return;
        }
        
        if(this.restriction == 3)
        {
                return;
        }
        
        if(this.restriction != 2)
        {
                if(this.restriction != 1)
        {
            goto typeof(UIDragDropItem).__il2cppRuntimeField_1D8;
        }
        
            float val_3 = System.Math.Abs(S8);
            if(System.Math.Abs(this.丈七专丗世不业丑丈.东丞不不丙丁丄下且) < 0)
        {
                return;
        }
        
        }
        else
        {
                if(System.Math.Abs(this.丈七专丗世不业丑丈.东丞不不丙丁丄下且) > System.Math.Abs(S8))
        {
                return;
        }
        
        }
    
    }
    public virtual void StartDragging()
    {
        var val_32;
        var val_33;
        float val_34;
        float val_35;
        var val_36;
        var val_37;
        丞上且下专丞东专世 val_38;
        var val_39;
        var val_40;
        var val_41;
        UnityEngine.GameObject val_43;
        val_33 = this;
        if(this.interactable == false)
        {
                return;
        }
        
        if(this.上丁东丕丁丙业丛丞 == true)
        {
                return;
        }
        
        if(this.cloneOnDrag == false)
        {
            goto label_3;
        }
        
        this.且丙万丞东丗下丝丅 = false;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.GameObject val_5 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  val_1.parent.gameObject, 丑且不丕与专丄业丙:  this.gameObject);
        UnityEngine.Transform val_6 = val_5.transform;
        UnityEngine.Vector3 val_7 = val_1.localPosition;
        val_6.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Quaternion val_8 = val_1.localRotation;
        val_6.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        UnityEngine.Vector3 val_9 = val_1.localScale;
        val_34 = val_9.x;
        val_35 = val_9.z;
        val_6.localScale = new UnityEngine.Vector3() {x = val_34, y = val_9.y, z = val_35};
        UIButtonColor val_10 = val_5.GetComponent<UIButtonColor>();
        val_36 = 0;
        if(val_10 != 0)
        {
                UnityEngine.Color val_13 = this.GetComponent<UIButtonColor>().defaultColor;
            val_34 = val_13.r;
            val_35 = val_13.b;
            val_10.defaultColor = new UnityEngine.Color() {r = val_34, g = val_13.g, b = val_35, a = val_13.a};
        }
        
        if(this.丈七专丗世不业丑丈 != null)
        {
                val_36 = 0;
            if(this.丈七专丗世不业丑丈.万东丂丒且丅丛丑丕 == this.gameObject)
        {
                this.丈七专丗世不业丑丈.上丞丕专丈业丁世专 = val_5;
            this.丈七专丗世不业丑丈.万东丂丒且丅丛丑丕 = val_5;
            this.丈七专丗世不业丑丈.丆丝东丞下丁丛丝与 = val_5;
            this.丈七专丗世不业丑丈.丙丕丛丒丁丐丒丕丕 = val_5;
        }
        
        }
        
        val_37 = public UIDragDropItem UnityEngine.GameObject::GetComponent<UIDragDropItem>();
        val_38 = this.丈七专丗世不业丑丈;
        val_39 = val_5.GetComponent<UIDragDropItem>();
        if(val_39 == null)
        {
            goto label_30;
        }
        
        val_16.丈七专丗世不业丑丈 = val_38;
        val_16.且丙万丞东丗下丝丅 = true;
        val_16.上丁东丕丁丙业丛丞 = true;
        goto label_31;
        label_3:
        this.上丁东丕丁丙业丛丞 = true;
        val_32 = ???;
        val_39 = ???;
        val_40 = ???;
        val_38 = ???;
        val_34 = ???;
        val_35 = ???;
        goto typeof(UIDragDropItem).__il2cppRuntimeField_218;
        label_30:
        mem[136] = val_38;
        mem[128] = 1;
        mem2[0] = 1;
        label_31:
        UnityEngine.GameObject val_17 = val_40.gameObject;
        if(val_39 != 0)
        {
            
        }
        
        val_41 = null;
        val_41 = null;
        if(UICamera.currentTouch == null)
        {
                UICamera.currentTouch = val_40 + 136;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        UICamera.Notify(丝三丁东丈丒世丅业:  val_40.gameObject, 且丁三丙丄一世不七:  "OnPress", 万且万且丑丗且丌丆:  val_32 - 36);
        val_43 = val_40.gameObject;
        UICamera.Notify(丝三丁东丈丒世丅业:  val_43, 且丁三丙丄一世不七:  "OnHover", 万且万且丑丗且丌丆:  null);
    }
    protected virtual void 丛世丝丁专丙上丝丏(UnityEngine.GameObject 专丑业丁丗丏丌不丛)
    {
    
    }
    protected virtual void OnDrag(UnityEngine.Vector2 delta)
    {
        var val_4;
        if(this.interactable == false)
        {
                return;
        }
        
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(this.丈七专丗世不业丑丈 != UICamera.currentTouch)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = delta.x, y = delta.y}, d:  this.丝丘下与丛丟丁东丏.pixelSizeAdjustment);
        goto typeof(UIDragDropItem).__il2cppRuntimeField_228;
    }
    protected virtual void OnDragEnd()
    {
        var val_3;
        if(this.interactable == false)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(this.丈七专丗世不业丑丈 != UICamera.currentTouch)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UICamera.hoveredObject;
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        this.上丁东丕丁丙业丛丞 = false;
        goto typeof(UIDragDropItem).__il2cppRuntimeField_238;
    }
    public void StopDragging(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        this.上丁东丕丁丙业丛丞 = false;
        goto typeof(UIDragDropItem).__il2cppRuntimeField_238;
    }
    protected virtual void 且与下七下丗丁丂丞()
    {
        var val_19;
        var val_20;
        UnityEngine.Transform val_21;
        val_19 = null;
        val_19 = null;
        if((UIDragDropItem.draggedItems.Contains(item:  this)) != true)
        {
                val_20 = null;
            val_20 = null;
            UIDragDropItem.draggedItems.Add(item:  this);
        }
        
        if(this.丘业丏丛下丄丙专丘 != 0)
        {
                this.丘业丏丛下丄丙专丘.enabled = false;
        }
        
        if(this.丝丏丞丁三丅三与丞 == 0)
        {
            goto label_14;
        }
        
        if(this.丝丏丞丁三丅三与丞 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_14:
        if(this.丑一丟一丞七丆丂丄 != 0)
        {
                this.丑一丟一丞七丆丂丄.enabled = false;
        }
        else
        {
                if(this.丕七丘丝丄丁丄丛丒 != 0)
        {
                this.丕七丘丝丄丁丄丛丒.enabled = false;
        }
        
        }
        
        label_24:
        UnityEngine.Transform val_6 = this.丐一丗丛丕世丘东丁.parent;
        this.丟丑丘丈且丕丈丂世 = val_6;
        this.丝丘下与丛丟丁东丏 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丄上七丟不丗丕下丟:  val_6);
        this.上丛丒丟丑七万丒专 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIGrid>(丄上七丟不丗丕下丟:  this.丟丑丘丈且丕丈丂世);
        this.丏七丏丆丘东丝且专 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UITable>(丄上七丟不丗丕下丟:  this.丟丑丘丈且丕丈丂世);
        val_21 = 1152921505089327104;
        if(UIDragDropRoot.root != 0)
        {
                val_21 = this.丐一丗丛丕世丘东丁;
            val_21.parent = UIDragDropRoot.root;
        }
        
        UnityEngine.Vector3 val_11 = this.丐一丗丛丕世丘东丁.localPosition;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = 0f};
        UnityEngine.Renderer val_12 = this.GetComponent<UnityEngine.Renderer>();
        if(val_12 != 0)
        {
                val_12.enabled = false;
        }
        
        SpringPosition val_14 = this.GetComponent<SpringPosition>();
        if(val_14 != 0)
        {
                val_14.enabled = false;
        }
        
        this.七丄不丁丁东丌丁下 = true;
        不丌丂丁丄一与丆丙.东丘东丏丑丛东丂丈(丝三丁东丈丒世丅业:  this.gameObject);
        if(this.丏七丏丆丘东丝且专 != 0)
        {
                this.丏七丏丆丘东丝且专.repositionNow = true;
        }
        
        if(this.上丛丒丟丑七万丒专 == 0)
        {
                return;
        }
        
        this.上丛丒丟丑七万丒专.repositionNow = true;
    }
    protected virtual void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector3 val_1 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    protected virtual void 丂上七丆专丈丛丞丂(UnityEngine.GameObject 专世丛世世与丙下丛)
    {
        var val_20;
        UnityEngine.Object val_21;
        UnityEngine.Transform val_22;
        if(this.cloneOnDrag == false)
        {
            goto label_1;
        }
        
        不丌丂丁丄一与丆丙.Destroy(万且万且丑丗且丌丆:  this.gameObject);
        goto label_52;
        label_1:
        if(this.丝丏丞丁三丅三与丞 == 0)
        {
            goto label_7;
        }
        
        if(this.丝丏丞丁三丅三与丞 != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_7:
        if(this.丑一丟一丞七丆丂丄 != 0)
        {
                this.丑一丟一丞七丆丂丄.enabled = true;
        }
        else
        {
                if(this.丕七丘丝丄丁丄丛丒 != 0)
        {
                this.丕七丘丝丄丁丄丛丒.enabled = true;
        }
        
        }
        
        label_17:
        val_21 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  专世丛世世与丙下丛)) != false)
        {
                val_21 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIDragDropContainer>(丝三丁东丈丒世丅业:  专世丛世世与丙下丛, 丕丗丆丕丈丑东丆丈:  0);
        }
        
        if(val_21 == 0)
        {
            goto label_26;
        }
        
        if(val_6.reparentTarget == 0)
        {
            goto label_30;
        }
        
        val_22 = val_6.reparentTarget;
        if(this.丐一丗丛丕世丘东丁 != null)
        {
            goto label_35;
        }
        
        goto label_32;
        label_26:
        this.丐一丗丛丕世丘东丁.parent = this.丟丑丘丈且丕丈丂世;
        goto label_34;
        label_30:
        val_22 = val_21.transform;
        if(this.丐一丗丛丕世丘东丁 != null)
        {
            goto label_35;
        }
        
        label_32:
        label_35:
        this.丐一丗丛丕世丘东丁.parent = val_22;
        UnityEngine.Vector3 val_10 = this.丐一丗丛丕世丘东丁.localPosition;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = 0f};
        label_34:
        UnityEngine.Transform val_11 = this.丐一丗丛丕世丘东丁.parent;
        this.丟丑丘丈且丕丈丂世 = val_11;
        val_20 = 1152921505093320704;
        this.上丛丒丟丑七万丒专 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIGrid>(丄上七丟不丗丕下丟:  val_11);
        this.丏七丏丆丘东丝且专 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UITable>(丄上七丟不丗丕下丟:  this.丟丑丘丈且丕丈丂世);
        if(this.丘业丏丛下丄丙专丘 != 0)
        {
                UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.丁一丅丅丏丝专且丑());
        }
        
        不丌丂丁丄一与丆丙.东丘东丏丑丛东丂丈(丝三丁东丈丒世丅业:  this.gameObject);
        if(this.丏七丏丆丘东丝且专 != 0)
        {
                this.丏七丏丆丘东丝且专.repositionNow = true;
        }
        
        if(this.上丛丒丟丑七万丒专 != 0)
        {
                this.上丛丒丟丑七万丒专.repositionNow = true;
        }
        
        label_52:
        this.七丄不丁丁东丌丁下 = false;
        goto typeof(UIDragDropItem).__il2cppRuntimeField_248;
    }
    protected virtual void 丄丏丈业东万且丝万()
    {
        null = null;
        bool val_1 = UIDragDropItem.draggedItems.Remove(item:  this);
        this.七丄不丁丁东丌丁下 = false;
    }
    protected System.Collections.IEnumerator 丁一丅丅丏丝专且丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UIDragDropItem.丏丝丝丄万丒与业丅();
    }
    public UIDragDropItem()
    {
        this.pressAndHoldDelay = 1f;
        this.interactable = true;
    }
    private static UIDragDropItem()
    {
        UIDragDropItem.draggedItems = new System.Collections.Generic.List<UIDragDropItem>();
    }

}
