using UnityEngine;
internal sealed class DragInfoWindow : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 丌且丑丅丁丄万丘丅;
    private UnityEngine.Rect 丂丈与丒不丝上丁丞;
    private UnityEngine.Vector3 丅业丆万一万专丏三;
    private UnityEngine.Vector3 丟丏丁七丂与与且七;
    private UnityEngine.Vector3 三世丈丁丞上丗下专;
    private UnityEngine.Vector3 丏世丂专一丌丑丈丒;
    
    // Methods
    private void Awake()
    {
        var val_7;
        var val_8;
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丌且丑丅丁丄万丘丅 = val_2;
        mem[1152921536980960220] = val_2.y;
        mem[1152921536980960224] = val_2.z;
        UIRect val_5 = this.transform.parent.GetComponentInParent<UIRect>();
        if(val_5.leftAnchor <= 1)
        {
                val_7 = 0;
        }
        
        this.丅业丆万一万专丏三 = val_5.leftAnchor;
        mem[1152921536980960252] = typeof(UIRect).__il2cppRuntimeField_1C8;
        this.丟丏丁七丂与与且七 = val_5.leftAnchor;
        mem[1152921536980960264] = typeof(UIRect).__il2cppRuntimeField_1C8;
        UIRect val_6 = this.GetComponent<UIRect>();
        if(val_6.leftAnchor <= 1)
        {
                val_8 = 0;
        }
        
        this.三世丈丁丞上丗下专 = val_6.leftAnchor;
        mem[1152921536980960276] = typeof(UIRect).__il2cppRuntimeField_1C8;
        this.丏世丂专一丌丑丈丒 = val_6.leftAnchor;
        mem[1152921536980960288] = typeof(UIRect).__il2cppRuntimeField_1C8;
    }
    private void OnEnable()
    {
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.丌且丑丅丁丄万丘丅, y = V9.16B, z = V10.16B};
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector2 val_7 = this.丗丘丒丄丅丗丂丞丟(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private UnityEngine.Vector2 丗丘丒丄丅丗丂丞丟(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        float val_1 = this.丅业丆万一万专丏三 - this.三世丈丁丞上丗下专;
        float val_2 = this.丟丏丁七丂与与且七 - this.丏世丂专一丌丑丈丒;
        float val_3 = UnityEngine.Mathf.Clamp(value:  下业丕七东丌丝下且.x, min:  val_1, max:  val_2);
        val_1 = val_3 - val_1;
        val_2 = val_2 - S3;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_3, y:  UnityEngine.Mathf.Clamp(value:  下业丕七东丌丝下且.y, min:  val_1, max:  val_2));
        return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public DragInfoWindow()
    {
    
    }

}
