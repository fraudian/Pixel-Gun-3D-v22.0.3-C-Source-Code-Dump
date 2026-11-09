using UnityEngine;
public class UIKeyNavigation : MonoBehaviour
{
    // Fields
    public static 丒丞丕丕七丁丗丟丛<UIKeyNavigation> list;
    public UIKeyNavigation.丌一丆丛丁且丝东且 constraint;
    public UnityEngine.GameObject onUp;
    public UnityEngine.GameObject onDown;
    public UnityEngine.GameObject onLeft;
    public UnityEngine.GameObject onRight;
    public UnityEngine.GameObject onClick;
    public UnityEngine.GameObject onTab;
    public bool startsSelected;
    private bool 不世丌丝且三上丏丌;
    public static int mLastFrame;
    
    // Properties
    public static UIKeyNavigation 上丞丕专丈业丁世专 { get; }
    public bool 东世三丕三业七丑三 { get; }
    
    // Methods
    public static UIKeyNavigation get_current()
    {
        var val_4;
        UnityEngine.GameObject val_1 = UICamera.hoveredObject;
        val_4 = 0;
        if(val_1 == 0)
        {
                return (UIKeyNavigation)val_1.GetComponent<UIKeyNavigation>();
        }
        
        return (UIKeyNavigation)val_1.GetComponent<UIKeyNavigation>();
    }
    public bool get_isColliderEnabled()
    {
        if(this.enabled == false)
        {
                return false;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return false;
        }
        
        UnityEngine.Collider val_4 = this.GetComponent<UnityEngine.Collider>();
        if(val_4 != 0)
        {
                if(val_4 != null)
        {
                return val_4.enabled;
        }
        
            return val_4.enabled;
        }
        
        this = this.GetComponent<UnityEngine.Collider2D>();
        if(this == 0)
        {
                return false;
        }
        
        if(this != null)
        {
                return this.enabled;
        }
        
        return this.enabled;
    }
    protected virtual void OnEnable()
    {
        null = null;
        UIKeyNavigation.list.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        this.Start();
    }
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
        if(this.startsSelected == false)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UICamera.hoveredObject = this.gameObject;
    }
    protected virtual void OnDisable()
    {
        null = null;
        bool val_1 = UIKeyNavigation.list.Remove(下丅丙一丂丗丅丝七:  this);
    }
    private static bool 丅业东万丌丕上丌丄(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.GameObject val_7 = 丝三丁东丈丒世丅业;
        if((UnityEngine.Object.op_Implicit(exists:  val_7 = 丝三丁东丈丒世丅业)) == false)
        {
                return false;
        }
        
        if(val_7.activeInHierarchy == false)
        {
                return false;
        }
        
        UnityEngine.Collider val_3 = val_7.GetComponent<UnityEngine.Collider>();
        if(val_3 != 0)
        {
                if(val_3 != null)
        {
                return val_3.enabled;
        }
        
            return val_3.enabled;
        }
        
        val_7 = val_7.GetComponent<UnityEngine.Collider2D>();
        if(val_7 == 0)
        {
                return false;
        }
        
        if(val_7 != null)
        {
                return val_7.enabled;
        }
        
        return val_7.enabled;
    }
    public UnityEngine.GameObject GetLeft()
    {
        UnityEngine.GameObject val_3;
        if((UIKeyNavigation.丅业东万丌丕上丌丄(丝三丁东丈丒世丅业:  this.onLeft)) != false)
        {
                val_3 = this.onLeft;
            return (UnityEngine.GameObject)val_3;
        }
        
        丌一丆丛丁且丝东且 val_3 = this.constraint;
        val_3 = val_3 | 2;
        if(val_3 == 3)
        {
                val_3 = 0;
            return (UnityEngine.GameObject)val_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
        return this.Get(专世丏丞丆丛丒丕丈:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 三丟东丕丄丄下下丑:  1f, 丒丒丄丁且丄丆丂丌:  2f);
    }
    public UnityEngine.GameObject GetRight()
    {
        UnityEngine.GameObject val_3;
        if((UIKeyNavigation.丅业东万丌丕上丌丄(丝三丁东丈丒世丅业:  this.onRight)) != false)
        {
                val_3 = this.onRight;
            return (UnityEngine.GameObject)val_3;
        }
        
        丌一丆丛丁且丝东且 val_3 = this.constraint;
        val_3 = val_3 | 2;
        if(val_3 == 3)
        {
                val_3 = 0;
            return (UnityEngine.GameObject)val_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
        return this.Get(专世丏丞丆丛丒丕丈:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 三丟东丕丄丄下下丑:  1f, 丒丒丄丁且丄丆丂丌:  2f);
    }
    public UnityEngine.GameObject GetUp()
    {
        UnityEngine.GameObject val_3;
        if((UIKeyNavigation.丅业东万丌丕上丌丄(丝三丁东丈丒世丅业:  this.onUp)) != false)
        {
                val_3 = this.onUp;
            return (UnityEngine.GameObject)val_3;
        }
        
        丌一丆丛丁且丝东且 val_3 = this.constraint;
        val_3 = val_3 & 4294967294;
        if(val_3 == 2)
        {
                val_3 = 0;
            return (UnityEngine.GameObject)val_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        return this.Get(专世丏丞丆丛丒丕丈:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 三丟东丕丄丄下下丑:  2f, 丒丒丄丁且丄丆丂丌:  1f);
    }
    public UnityEngine.GameObject GetDown()
    {
        UnityEngine.GameObject val_3;
        if((UIKeyNavigation.丅业东万丌丕上丌丄(丝三丁东丈丒世丅业:  this.onDown)) != false)
        {
                val_3 = this.onDown;
            return (UnityEngine.GameObject)val_3;
        }
        
        丌一丆丛丁且丝东且 val_3 = this.constraint;
        val_3 = val_3 & 4294967294;
        if(val_3 == 2)
        {
                val_3 = 0;
            return (UnityEngine.GameObject)val_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        return this.Get(专世丏丞丆丛丒丕丈:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 三丟东丕丄丄下下丑:  2f, 丒丒丄丁且丄丆丂丌:  1f);
    }
    public UnityEngine.GameObject Get(UnityEngine.Vector3 专世丏丞丆丛丒丕丈, float 三丟东丕丄丄下下丑 = 1, float 丒丒丄丁且丄丆丂丌 = 1)
    {
        float val_16;
        var val_17;
        var val_18;
        var val_19;
        float val_20;
        var val_21;
        val_16 = 专世丏丞丆丛丒丕丈.z;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = val_1.TransformDirection(direction:  new UnityEngine.Vector3() {x = 专世丏丞丆丛丒丕丈.x, y = 专世丏丞丆丛丒丕丈.y, z = val_16});
        UnityEngine.Vector3 val_4 = UIKeyNavigation.不丗不丅丏且下下下(丝三丁东丈丒世丅业:  this.gameObject);
        val_17 = 0;
        val_18 = 0;
        goto label_4;
        label_29:
        val_19 = null;
        val_19 = null;
        UIKeyNavigation val_5 = UIKeyNavigation.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        if(((val_5 != this) && (val_5.constraint != 3)) && (val_5.isColliderEnabled != false))
        {
                if((val_5.GetComponent<UIWidget>()) != 0)
        {
                if((3.402823E+38f) == 0f)
        {
            goto label_25;
        }
        
        }
        
            UnityEngine.Vector3 val_11 = UIKeyNavigation.不丗不丅丏且下下下(丝三丁东丈丒世丅业:  val_5.gameObject);
            val_20 = val_11.x;
            val_16 = val_11.z;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20, y = val_11.y, z = val_16}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) >= 0)
        {
                val_16 = val_12.z;
            UnityEngine.Vector3 val_14 = val_1.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_16});
            val_14.x = val_14.x * 三丟东丕丄丄下下丑;
            val_14.y = val_14.y * 丒丒丄丁且丄丆丂丌;
            val_20 = val_14.x;
            if(val_20 <= (3.402823E+38f))
        {
                val_18 = val_5.gameObject;
        }
        
        }
        
        }
        
        label_25:
        val_17 = 1;
        label_4:
        val_21 = null;
        val_21 = null;
        if(val_17 < (UIKeyNavigation.list + 24))
        {
            goto label_29;
        }
        
        return (UnityEngine.GameObject)val_18;
    }
    protected static UnityEngine.Vector3 不丗不丅丏且下下下(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_18;
        UnityEngine.Object val_19;
        float val_23;
        float val_24;
        float val_25;
        var val_28;
        val_18 = 丝三丁东丈丒世丅业;
        if(val_18 != null)
        {
                val_19 = val_18.GetComponent<UIWidget>();
        }
        else
        {
                val_19 = 0.GetComponent<UIWidget>();
        }
        
        UICamera val_4 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  val_18.layer);
        if(val_4 != 0)
        {
                val_18 = val_18.transform;
            UnityEngine.Vector3 val_7 = val_18.position;
            val_23 = val_7.x;
            val_24 = val_7.y;
            val_25 = val_7.z;
            if(val_19 != 0)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.5f);
            val_23 = val_10.x;
            val_24 = val_10.y;
            val_25 = val_10.z;
        }
        
            val_28 = val_4.cachedCamera;
            UnityEngine.Vector3 val_12 = val_28.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            return new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        }
        
        if(val_19 != 0)
        {
                val_28 = val_19;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.5f);
            return new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        }
        
        val_28 = val_18.transform;
        UnityEngine.Vector3 val_17 = val_28.position;
        return new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    public virtual void OnNavigate(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        int val_10;
        UnityEngine.Object val_11;
        var val_12;
        var val_13;
        val_11 = this;
        if(UIPopupList.isOpen == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_10 = UIKeyNavigation.mLastFrame;
        if(val_10 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        val_13 = null;
        val_10 = UnityEngine.Time.frameCount;
        val_13 = null;
        UIKeyNavigation.mLastFrame = val_10;
        if((下上丐丆丝丟丝丒不 - 273) <= 3)
        {
                var val_10 = 106029848 + ((下上丐丆丝丟丝丒不 - 273)) << 2;
            val_10 = val_10 + 106029848;
        }
        else
        {
                val_11 = 0;
            if( == 0)
        {
                return;
        }
        
            UICamera.hoveredObject = ;
        }
    
    }
    public virtual void OnKey(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        int val_24;
        UnityEngine.Object val_25;
        var val_26;
        var val_27;
        UnityEngine.GameObject val_28;
        var val_29;
        var val_30;
        val_25 = this;
        if(UIPopupList.isOpen == true)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_24 = UIKeyNavigation.mLastFrame;
        if(val_24 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        val_27 = null;
        val_24 = UnityEngine.Time.frameCount;
        val_27 = null;
        UIKeyNavigation.mLastFrame = val_24;
        if(下上丐丆丝丟丝丒不 != 9)
        {
                return;
        }
        
        val_24 = 1152921504848912384;
        val_28 = this.onTab;
        if(val_28 != 0)
        {
            goto label_39;
        }
        
        val_29 = null;
        val_29 = null;
        if((UICamera.GetKey.Invoke(下上丐丆丝丟丝丒不:  48)) == true)
        {
            goto label_16;
        }
        
        val_30 = null;
        val_30 = null;
        if((UICamera.GetKey.Invoke(下上丐丆丝丟丝丒不:  47)) == false)
        {
            goto label_20;
        }
        
        label_16:
        val_28 = this.GetLeft();
        if(val_28 == 0)
        {
                val_28 = this.GetUp();
        }
        
        if(val_28 == 0)
        {
                val_28 = this.GetDown();
        }
        
        if(val_28 != 0)
        {
            goto label_39;
        }
        
        UnityEngine.GameObject val_13 = this.GetRight();
        goto label_30;
        label_20:
        val_28 = this.GetRight();
        if(val_28 == 0)
        {
                val_28 = this.GetDown();
        }
        
        if(val_28 == 0)
        {
                val_28 = this.GetUp();
        }
        
        if(val_28 != 0)
        {
            goto label_39;
        }
        
        label_30:
        val_28 = this.GetLeft();
        label_39:
        if(val_28 == 0)
        {
                return;
        }
        
        UICamera.currentScheme = 2;
        UICamera.hoveredObject = val_28;
        val_25 = val_28.GetComponent<UIInput>();
        if(val_25 == 0)
        {
                return;
        }
        
        val_25.isSelected = true;
    }
    protected virtual void OnClick()
    {
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.onClick)) == false)
        {
                return;
        }
        
        UICamera.hoveredObject = this.onClick;
    }
    public UIKeyNavigation()
    {
    
    }
    private static UIKeyNavigation()
    {
        UIKeyNavigation.list = new 丒丞丕丕七丁丗丟丛<UIKeyNavigation>();
        UIKeyNavigation.mLastFrame = 0;
    }

}
