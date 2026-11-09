using UnityEngine;
public class UIButtonOffset : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform tweenTarget;
    public UnityEngine.Vector3 hover;
    public UnityEngine.Vector3 pressed;
    public float duration;
    private UnityEngine.Vector3 丞丌上丂与业丆丅丅;
    private bool 不世丌丝且三上丏丌;
    private bool 且丙万丞东丗下丝丅;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_4;
        if(this.不世丌丝且三上丏丌 == true)
        {
                return;
        }
        
        this.不世丌丝且三上丏丌 = true;
        if(this.tweenTarget != 0)
        {
            goto label_4;
        }
        
        val_4 = this.transform;
        this.tweenTarget = val_4;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_4:
        val_4 = this.tweenTarget;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        UnityEngine.Vector3 val_3 = val_4.localPosition;
        this.丞丌上丂与业丆丅丅 = val_3;
        mem[1152921531074492432] = val_3.y;
        mem[1152921531074492436] = val_3.z;
    }
    private void OnEnable()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        this.OnHover(丟丆丕且丆丈丂丌丘:  UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject));
    }
    private void OnDisable()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        TweenPosition val_2 = this.tweenTarget.GetComponent<TweenPosition>();
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2 != null)
        {
                val_2.value = new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = V9.16B, z = V8.16B};
        }
        else
        {
                val_2.value = new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = V9.16B, z = V8.16B};
        }
        
        val_2.enabled = false;
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        var val_8;
        UnityEngine.Vector3 val_9;
        var val_11;
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3 val_16;
        float val_19;
        float val_20;
        float val_21;
        this.且丙万丞东丗下丝丅 = 丆丟专丑丁丒丁上丙;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.不世丌丝且三上丏丌 != true)
        {
                this.Start();
        }
        
        if(丆丟专丑丁丒丁上丙 == false)
        {
            goto label_4;
        }
        
        val_9 = this.丞丌上丂与业丆丅丅;
        val_11 = 1152921504838316032;
        val_13 = this.pressed;
        goto label_5;
        label_4:
        val_16 = this.丞丌上丂与业丆丅丅;
        if((UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
            goto label_8;
        }
        
        val_11 = 1152921504838316032;
        val_13 = this.hover;
        label_5:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_13, y = V12.16B, z = V14.16B});
        val_19 = val_6.x;
        val_20 = val_6.y;
        val_21 = val_6.z;
        label_8:
        val_8 = TweenPosition.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21});
        mem2[0] = 3;
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        var val_5;
        UnityEngine.Vector3 val_6;
        float val_7;
        float val_8;
        val_5 = this;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.不世丌丝且三上丏丌 != true)
        {
                this.Start();
        }
        
        val_6 = this.丞丌上丂与业丆丅丅;
        if(丟丆丕且丆丈丂丌丘 != false)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.hover, y = V12.16B, z = V13.16B});
            val_6 = val_3.x;
            val_7 = val_3.y;
            val_8 = val_3.z;
        }
        
        val_5 = TweenPosition.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        mem2[0] = 3;
    }
    private void 专丌丟下上东丞不丙()
    {
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.hover, y = V10.16B, z = V11.16B});
        this = TweenPosition.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        mem2[0] = 3;
    }
    private void 世丆丕丌丒下丆万上()
    {
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return;
        }
        
        this = TweenPosition.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = this.丞丌上丂与业丆丅丅});
        mem2[0] = 3;
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(丞丈丌且东丆丅丗万 != false)
        {
                if(UICamera.currentScheme != 2)
        {
                return;
        }
        
        }
        
        this.OnHover(丟丆丕且丆丈丂丌丘:  丞丈丌且东丆丅丗万);
    }
    public UIButtonOffset()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.hover = val_1;
        mem[1152921531075549172] = val_1.y;
        mem[1152921531075549176] = val_1.z;
        this.pressed = 0;
        mem[1152921531075549188] = 0;
        this.duration = 0.2f;
    }

}
