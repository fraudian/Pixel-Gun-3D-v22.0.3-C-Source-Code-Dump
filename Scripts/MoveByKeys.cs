using UnityEngine;
public class MoveByKeys : MonoBehaviour
{
    // Fields
    public float Speed;
    public float JumpForce;
    public float JumpTimeout;
    private bool 世丛丘丗三丄专业丂;
    private float 与丆丟丆丌与万万丗;
    private UnityEngine.Rigidbody 与与丁世丐东丒丑万;
    private UnityEngine.Rigidbody2D 丑上且不与丟且丁丙;
    
    // Methods
    public void Start()
    {
        var val_13;
        UnityEngine.Object val_14;
        UnityEngine.Object val_15;
        UnityEngine.Object val_16;
        UnityEngine.Rigidbody2D val_17;
        var val_18;
        var val_19;
        val_13 = 0;
        goto label_1;
        label_34:
        T val_13 = this.GetComponents<UnityEngine.Component>()[0];
        if(val_13 != 0)
        {
                var val_2 = (val_13 == null) ? (val_13) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        if(val_14 != 0)
        {
                if(val_13 != 0)
        {
                var val_4 = (val_13 == null) ? (val_13) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
            this.世丛丘丗三丄专业丂 = UnityEngine.Object.op_Implicit(exists:  val_15);
        }
        
        if(val_13 != 0)
        {
                var val_7 = (val_13 == null) ? (val_13) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
        if(val_16 != 0)
        {
                if(val_13 != 0)
        {
                var val_9 = (val_13 == null) ? (val_13) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
            this.丑上且不与丟且丁丙 = val_17;
        }
        
        val_18 = 0;
        if( != 0)
        {
                val_19 = 0;
            this.与与丁世丐东丒丑万 = ;
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < val_1.Length)
        {
            goto label_34;
        }
    
    }
    public void FixedUpdate()
    {
        var val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        val_34 = "Horizontal";
        if((UnityEngine.Input.GetAxisRaw(axisName:  "Horizontal")) < 0)
        {
            goto label_3;
        }
        
        val_35 = 0.1f;
        if((UnityEngine.Input.GetAxisRaw(axisName:  "Horizontal")) <= val_35)
        {
            goto label_4;
        }
        
        label_3:
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = val_5.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.Speed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  UnityEngine.Input.GetAxisRaw(axisName:  "Horizontal"));
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_36 = val_13.z;
        val_37 = val_13.x;
        val_35 = val_13.y;
        val_38 = val_36;
        val_5.position = new UnityEngine.Vector3() {x = val_37, y = val_35, z = val_38};
        label_4:
        val_39 = this.与丆丟丆丌与万万丗;
        if(val_39 > 0f)
        {
                val_37 = val_39 - UnityEngine.Time.deltaTime;
            this.与丆丟丆丌与万万丗 = val_37;
        }
        else
        {
                val_34 = 1152921504848912384;
            if(this.与与丁世丐东丒丑万 == 0)
        {
                if(this.丑上且不与丟且丁丙 == 0)
        {
            goto label_27;
        }
        
        }
        
            if((UnityEngine.Input.GetKey(key:  32)) != false)
        {
                this.与丆丟丆丌与万万丗 = this.JumpTimeout;
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.up;
            val_38 = this.JumpForce;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, d:  val_38);
            val_39 = val_19.x;
            if(this.丑上且不与丟且丁丙 != 0)
        {
                val_37 = val_39;
            val_35 = val_19.y;
            this.丑上且不与丟且丁丙.AddForce(force:  new UnityEngine.Vector2() {x = val_37, y = val_35});
        }
        else
        {
                if(this.与与丁世丐东丒丑万 != 0)
        {
                UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_39, y = val_19.y});
            val_39 = val_22.x;
            val_36 = val_22.z;
            val_37 = val_39;
            val_35 = val_22.y;
            val_38 = val_36;
            this.与与丁世丐东丒丑万.AddForce(force:  new UnityEngine.Vector3() {x = val_37, y = val_35, z = val_38});
        }
        
        }
        
        }
        
        }
        
        label_27:
        if(this.世丛丘丗三丄专业丂 != false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetAxisRaw(axisName:  "Vertical")) >= 0)
        {
                val_35 = 0.1f;
            if((UnityEngine.Input.GetAxisRaw(axisName:  "Vertical")) <= val_35)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_25 = this.transform;
        UnityEngine.Vector3 val_26 = val_25.position;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  this.Speed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  UnityEngine.Input.GetAxisRaw(axisName:  "Vertical"));
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        val_25.position = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
    }
    public MoveByKeys()
    {
        this.Speed = 10f;
        this.JumpForce = 200f;
        this.JumpTimeout = 0.5f;
    }

}
