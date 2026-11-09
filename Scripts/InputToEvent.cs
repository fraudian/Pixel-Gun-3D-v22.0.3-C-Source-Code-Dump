using UnityEngine;
public class InputToEvent : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丒丆且丆与丏丝丑七;
    public static UnityEngine.Vector3 inputHitPos;
    public bool DetectPointedAtGameObject;
    private static UnityEngine.GameObject <下丄下万丝丝业丁丒>k__BackingField;
    private UnityEngine.Vector2 且丝丑东不丄七丅丛;
    private UnityEngine.Vector2 丘上丑东丞东世丒七;
    public bool Dragging;
    private UnityEngine.Camera 上丄丐丐丟下丅专且;
    
    // Properties
    public static UnityEngine.GameObject 丒丘丘丑丄上丏业丈 { get; set; }
    public UnityEngine.Vector2 与七丗业三一丄丂专 { get; }
    
    // Methods
    public static UnityEngine.GameObject get_goPointedAt()
    {
        return (UnityEngine.GameObject)InputToEvent.<下丄下万丝丝业丁丒>k__BackingField;
    }
    private static void 丐三上丈世丑七丙丞(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        InputToEvent.<下丄下万丝丝业丁丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector2 get_DragVector()
    {
        if(this.Dragging == false)
        {
                return UnityEngine.Vector2.zero;
        }
        
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.丘上丑东丞东世丒七, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.且丝丑东不丄七丅丛, y = V8.16B});
    }
    private void Start()
    {
        this.上丄丐丐丟下丅专且 = this.GetComponent<UnityEngine.Camera>();
    }
    private void Update()
    {
        UnityEngine.GameObject val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        val_21 = this;
        if(this.DetectPointedAtGameObject != false)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_22 = val_1.x;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22, y = val_1.y, z = val_1.z});
            InputToEvent.<下丄下万丝丝业丁丒>k__BackingField = this.丝丟丈丂不丏丞丆下(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_5;
        }
        
        UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
        this.丘上丑东丞东世丒七 = val_2;
        mem[1152921535611041536] = val_2.y;
        if(专三三与三且一且一() == 0)
        {
            goto label_6;
        }
        
        if(专三三与三且一且一() != 3)
        {
                return;
        }
        
        this.七世丗且丑丝丐专丛(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        return;
        label_5:
        UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
        val_22 = val_8.x;
        val_23 = val_22;
        val_24 = val_8.y;
        val_25 = val_8.z;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
        this.丘上丑东丞东世丒七 = val_9;
        mem[1152921535611041536] = val_9.y;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
            val_22 = val_11.x;
            val_23 = val_22;
            val_24 = val_11.y;
            val_25 = val_11.z;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            this.丁丏上业东丟丝丏丅(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Input.mousePosition;
            val_22 = val_14.x;
            val_23 = val_22;
            val_24 = val_14.y;
            val_25 = val_14.z;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            this.七世丗且丑丝丐专丛(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        }
        
        if((UnityEngine.Input.GetMouseButtonDown(button:  1)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_17 = UnityEngine.Input.mousePosition;
        val_22 = val_17.x;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22, y = val_17.y, z = val_17.z});
        this.且丝丑东不丄七丅丛 = val_18;
        mem[1152921535611041528] = val_18.y;
        UnityEngine.GameObject val_19 = this.丝丟丈丂不丏丞丆下(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        this.丒丆且丆与丏丝丑七 = val_19;
        if(val_19 == 0)
        {
                return;
        }
        
        val_21 = this.丒丆且丆与丏丝丑七;
        val_21.SendMessage(methodName:  "OnPressRight", options:  1);
        return;
        label_6:
        this.丁丏上业东丟丝丏丅(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
    }
    private void 丁丏上业东丟丝丏丅(UnityEngine.Vector2 丅丙丆丕业上下丌丄)
    {
        this.且丝丑东不丄七丅丛 = 丅丙丆丕业上下丌丄;
        mem[1152921535611186344] = 丅丙丆丕业上下丌丄.y;
        this.Dragging = true;
        UnityEngine.GameObject val_1 = this.丝丟丈丂不丏丞丆下(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = 丅丙丆丕业上下丌丄.x, y = 丅丙丆丕业上下丌丄.y});
        this.丒丆且丆与丏丝丑七 = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丒丆且丆与丏丝丑七.SendMessage(methodName:  "OnPress", options:  1);
    }
    private void 七世丗且丑丝丐专丛(UnityEngine.Vector2 丅丙丆丕业上下丌丄)
    {
        if(this.丒丆且丆与丏丝丑七 != 0)
        {
                if((this.丝丟丈丂不丏丞丆下(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = 丅丙丆丕业上下丌丄.x, y = 丅丙丆丕业上下丌丄.y})) == this.丒丆且丆与丏丝丑七)
        {
                this.丒丆且丆与丏丝丑七.SendMessage(methodName:  "OnClick", options:  1);
        }
        
            this.丒丆且丆与丏丝丑七.SendMessage(methodName:  "OnRelease", options:  1);
            this.丒丆且丆与丏丝丑七 = 0;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.且丝丑东不丄七丅丛 = val_4;
        mem[1152921535611327112] = val_4.y;
        this.Dragging = false;
    }
    private UnityEngine.GameObject 丝丟丈丂不丏丞丆下(UnityEngine.Vector2 丅丙丆丕业上下丌丄)
    {
        float val_3;
        float val_4;
        UnityEngine.Camera val_7;
        var val_8;
        val_7 = this.上丄丐丐丟下丅专且;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丅丙丆丕业上下丌丄.x, y = 丅丙丆丕业上下丌丄.y});
        UnityEngine.Ray val_2 = val_7.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_8 = 0;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, m_Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  200f)) == false)
        {
                return (UnityEngine.GameObject)0.gameObject;
        }
        
        InputToEvent.inputHitPos = 200f;
        InputToEvent.inputHitPos.__il2cppRuntimeField_4 = val_1.y;
        InputToEvent.inputHitPos.__il2cppRuntimeField_8 = val_1.z;
        val_7;
        return (UnityEngine.GameObject)0.gameObject;
    }
    public InputToEvent()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.且丝丑东不丄七丅丛 = val_1;
        mem[1152921535611596104] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丘上丑东丞东世丒七 = val_2;
        mem[1152921535611596112] = val_2.y;
    }

}
