using UnityEngine;
public class FlyCamera : MonoBehaviour
{
    // Fields
    private float 丙丕七丏不丈专丞丑;
    private UnityEngine.Vector3 丏一万丁丟丒丙一丐;
    private float 丐丒丕三丕且一与三;
    private float 丏业丌丝丙与丕丌丄;
    private float 不丗丈丙丄七三丗与;
    private float 丈丛丈不七丌下丄与;
    
    // Methods
    private void Update()
    {
        var val_35;
        float val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        val_35 = this;
        if((UnityEngine.Input.GetMouseButton(button:  2)) != true)
        {
                if((UnityEngine.Input.GetMouseButton(button:  1)) == false)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = this.丏一万丁丟丒丙一丐, y = V11.16B, z = V10.16B});
        this.丏一万丁丟丒丙一丐 = val_4;
        mem[1152921540511733760] = val_4.y;
        mem[1152921540511733764] = val_4.z;
        float val_5 = -(val_4.y * this.丙丕七丏不丈专丞丑);
        float val_6 = this.丙丕七丏不丈专丞丑 * val_4.x;
        this.丏一万丁丟丒丙一丐 = 0;
        mem[1152921540511733764] = 0;
        UnityEngine.Vector3 val_8 = this.transform.eulerAngles;
        UnityEngine.Vector3 val_10 = this.transform.eulerAngles;
        float val_11 = val_8.x + this.丏一万丁丟丒丙一丐;
        val_10.y = val_10.y + val_10.z;
        this.丏一万丁丟丒丙一丐 = 0;
        mem[1152921540511733764] = 0;
        this.transform.eulerAngles = new UnityEngine.Vector3() {x = this.丏一万丁丟丒丙一丐, y = this.丏一万丁丟丒丙一丐, z = V10.16B};
        label_2:
        UnityEngine.Vector3 val_13 = UnityEngine.Input.mousePosition;
        this.丏一万丁丟丒丙一丐 = val_13;
        mem[1152921540511733760] = val_13.y;
        mem[1152921540511733764] = val_13.z;
        UnityEngine.Vector3 val_14 = this.丑与丐丒丁丛下丄上();
        float val_35 = this.丈丛丈不七丌下丄与;
        if((UnityEngine.Input.GetKey(key:  48)) != false)
        {
                val_35 = val_35 + UnityEngine.Time.deltaTime;
            this.丈丛丈不七丌下丄与 = val_35;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_35);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  this.不丗丈丙丄七三丗与);
            val_38 = UnityEngine.Mathf.Clamp(value:  val_18.x, min:  -this.丏业丌丝丙与丕丌丄, max:  this.丏业丌丝丙与丕丌丄);
            val_39 = UnityEngine.Mathf.Clamp(value:  val_18.y, min:  -this.丏业丌丝丙与丕丌丄, max:  this.丏业丌丝丙与丕丌丄);
            val_40 = val_18.z;
            val_41 = UnityEngine.Mathf.Clamp(value:  val_40, min:  -this.丏业丌丝丙与丕丌丄, max:  this.丏业丌丝丙与丕丌丄);
        }
        else
        {
                float val_36 = 0.5f;
            val_36 = val_35 * val_36;
            this.丈丛丈不七丌下丄与 = UnityEngine.Mathf.Clamp(value:  val_36, min:  1f, max:  1000f);
            val_40 = val_14.x;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40, y = val_14.y, z = val_14.z}, d:  this.丐丒丕三丕且一与三);
            val_38 = val_23.x;
            val_39 = val_23.y;
            val_41 = val_23.z;
        }
        
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_41}, d:  UnityEngine.Time.deltaTime);
        val_42 = val_25.y;
        UnityEngine.Vector3 val_27 = this.transform.position;
        this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_25.x, y = val_42, z = val_25.z});
        if((UnityEngine.Input.GetKey(key:  32)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_31 = this.transform.position;
        UnityEngine.Vector3 val_33 = this.transform.position;
        val_42 = val_33.z;
        val_35 = this.transform;
        val_35.position = new UnityEngine.Vector3() {x = val_31.x, y = val_27.y, z = val_42};
    }
    private UnityEngine.Vector3 丑与丐丒丁丛下丄上()
    {
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        val_9 = 0f;
        val_10 = 0f;
        val_11 = 0f;
        if((UnityEngine.Input.GetKey(key:  119)) != false)
        {
                val_12 = 0f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = val_12, z = 0f});
            val_11 = val_2.x;
            val_10 = val_2.y;
            val_9 = val_2.z;
        }
        
        if((UnityEngine.Input.GetKey(key:  115)) != false)
        {
                val_12 = 0f;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9}, b:  new UnityEngine.Vector3() {x = 0f, y = val_12, z = 0f});
            val_11 = val_4.x;
            val_10 = val_4.y;
            val_9 = val_4.z;
        }
        
        if((UnityEngine.Input.GetKey(key:  97)) != false)
        {
                val_12 = 0f;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9}, b:  new UnityEngine.Vector3() {x = 0f, y = val_12, z = 0f});
            val_11 = val_6.x;
            val_10 = val_6.y;
            val_9 = val_6.z;
        }
        
        if((UnityEngine.Input.GetKey(key:  100)) == false)
        {
                return new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9};
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_11 = val_8.x;
        val_10 = val_8.y;
        val_9 = val_8.z;
        return new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9};
    }
    public FlyCamera()
    {
        this.丙丕七丏不丈专丞丑 = 0.25f;
        this.丏一万丁丟丒丙一丐 = 0;
        mem[1152921540511990532] = 0;
        this.丐丒丕三丕且一与三 = ;
        this.丏业丌丝丙与丕丌丄 = ;
        this.不丗丈丙丄七三丗与 = 250f;
        this.丈丛丈不七丌下丄与 = 1f;
    }

}
