using UnityEngine;
public class UIButtonRotation : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform tweenTarget;
    public UnityEngine.Vector3 hover;
    public UnityEngine.Vector3 pressed;
    public float duration;
    private UnityEngine.Quaternion 丙东丒丁丐万三丟三;
    private bool 不世丌丝且三上丏丌;
    
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
        UnityEngine.Quaternion val_3 = val_4.localRotation;
        this.丙东丒丁丐万三丟三 = val_3;
        mem[1152921531075673488] = val_3.y;
        mem[1152921531075673492] = val_3.z;
        mem[1152921531075673496] = val_3.w;
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
        
        TweenRotation val_2 = this.tweenTarget.GetComponent<TweenRotation>();
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2 != null)
        {
                val_2.value = new UnityEngine.Quaternion() {x = this.丙东丒丁丐万三丟三, y = V10.16B, z = V9.16B, w = V8.16B};
        }
        else
        {
                val_2.value = new UnityEngine.Quaternion() {x = this.丙东丒丁丐万三丟三, y = V10.16B, z = V9.16B, w = V8.16B};
        }
        
        val_2.enabled = false;
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        var val_8;
        UnityEngine.Quaternion val_9;
        var val_11;
        UnityEngine.Vector3 val_14;
        UnityEngine.Quaternion val_17;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
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
        
        val_9 = this.丙东丒丁丐万三丟三;
        val_11 = 1152921504838369280;
        val_14 = this.pressed;
        goto label_5;
        label_4:
        val_17 = this.丙东丒丁丐万三丟三;
        if((UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
            goto label_8;
        }
        
        val_11 = 1152921504838369280;
        val_14 = this.hover;
        label_5:
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_14, y = V13.16B, z = V15.16B});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_17, y = V10.16B, z = V11.16B, w = V12.16B}, rhs:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        val_21 = val_6.x;
        val_22 = val_6.y;
        val_23 = val_6.z;
        val_24 = val_6.w;
        label_8:
        val_8 = TweenRotation.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_21, y = val_22, z = val_23, w = val_24});
        mem2[0] = 3;
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        var val_6;
        UnityEngine.Quaternion val_7;
        float val_8;
        float val_9;
        float val_10;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.不世丌丝且三上丏丌 != true)
        {
                this.Start();
        }
        
        val_7 = this.丙东丒丁丐万三丟三;
        if(丟丆丕且丆丈丂丌丘 != false)
        {
                UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.hover, y = V13.16B, z = V14.16B});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7, y = V10.16B, z = V11.16B, w = V12.16B}, rhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            val_7 = val_4.x;
            val_8 = val_4.y;
            val_9 = val_4.z;
            val_10 = val_4.w;
        }
        
        val_6 = TweenRotation.Begin(丝三丁东丈丒世丅业:  this.tweenTarget.gameObject, 与丈业丛丝丒丙一丏:  this.duration, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_7, y = val_8, z = val_9, w = val_10});
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
    public UIButtonRotation()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.hover = val_1;
        mem[1152921531076457076] = val_1.y;
        mem[1152921531076457080] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.pressed = val_2;
        mem[1152921531076457088] = val_2.y;
        mem[1152921531076457092] = val_2.z;
        this.duration = 0.2f;
    }

}
