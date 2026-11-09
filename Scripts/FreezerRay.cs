using UnityEngine;
public class FreezerRay : MonoBehaviour
{
    // Fields
    private float 丐丑与三丐一与上丕;
    public float lifetime;
    private UnityEngine.Transform 丏丅丅专七丘丑上丂;
    public float timeLeft;
    public bool needToConsiderRotation;
    private WeaponSounds 丌丝下丄业一丄不三;
    
    // Properties
    set; }
    
    // Methods
    public void set_Length(float 丙业与丙丗丝不丈东)
    {
        this.transform.GetChild(index:  0).GetComponent<UnityEngine.LineRenderer>().SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    private void OnEnable()
    {
        float val_1 = this.timeLeft;
        val_1 = val_1 + this.lifetime;
        this.timeLeft = val_1;
    }
    private void LateUpdate()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.timeLeft - val_1;
        this.timeLeft = val_1;
        if(val_1 > 0f)
        {
                this.丟丗专丌且万丘丙丏();
            return;
        }
        
        this.GetComponent<RayAndExplosionsStackItem>().Deactivate();
    }
    internal void 一与丙业丐三丙丟丆(WeaponSounds 东丛丕丟丗丗七世丌, UnityEngine.Transform 丂世丛不丄丆丄丁丝, float 丏上万丅丏一不不丕)
    {
        this.丌丝下丄业一丄不三 = 东丛丕丟丗丗七世丌;
        this.丏丅丅专七丘丑上丂 = 丂世丛不丄丆丄丁丝;
        this.丐丑与三丐一与上丕 = 丏上万丅丏一不不丕;
        this.丟丗专丌且万丘丙丏();
    }
    private void 丟丗专丌且万丘丙丏()
    {
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        var val_32;
        UnityEngine.Camera val_33;
        if(this.丌丝下丄业一丄不三 == 0)
        {
                return;
        }
        
        if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        if(this.丏丅丅专七丘丑上丂 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.丌丝下丄业一丄不三.transform.forward;
        val_25 = this.丐丑与三丐一与上丕;
        val_26 = val_6.x;
        val_27 = val_6.y;
        val_28 = val_6.z;
        Player_move_c val_7 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_7.mySkinName.firstPersonControl.丌且下丕下下丌万丞 == false)
        {
            goto label_22;
        }
        
        Player_move_c val_8 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_8.mySkinName.firstPersonControl.丘丂三东丁且丙世七() == false)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_10 = this.丏丅丅专七丘丑上丂.position;
        val_29 = val_10.x;
        val_30 = val_10.y;
        val_31 = val_10.z;
        val_32 = null;
        val_32 = null;
        val_33 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
        if(val_33 != null)
        {
            goto label_34;
        }
        
        goto label_27;
        label_22:
        if(this.丌丝下丄业一丄不三.isDoubleSyncShot != true)
        {
                if(this.needToConsiderRotation == false)
        {
            goto label_30;
        }
        
        }
        
        UnityEngine.Vector3 val_13 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().transform.position;
        val_33 = this.丌丝下丄业一丄不三;
        val_29 = val_13.x;
        val_30 = val_13.y;
        val_31 = val_13.z;
        if(val_33 != null)
        {
            goto label_34;
        }
        
        label_27:
        label_34:
        UnityEngine.Vector3 val_15 = val_33.transform.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  this.丐丑与三丐一与上丕);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_18 = this.丏丅丅专七丘丑上丂.position;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        val_26 = val_19.x;
        val_27 = val_19.y;
        val_28 = val_19.z;
        UnityEngine.Vector3 val_20 = 0.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_25 = val_21.x;
        label_30:
        UnityEngine.Vector3 val_23 = this.丏丅丅专七丘丑上丂.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        this.transform.forward = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28};
        this.Length = val_25;
    }
    public void UpdatePosition(float 丏上万丅丏一不不丕)
    {
        float val_1 = this.timeLeft;
        this.丐丑与三丐一与上丕 = 丏上万丅丏一不不丕;
        val_1 = val_1 + this.lifetime;
        this.timeLeft = val_1;
    }
    private void OnDisable()
    {
        this.timeLeft = 0f;
        if(this.丌丝下丄业一丄不三 != 0)
        {
                if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() != 0)
        {
                this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().丒丄丗丞丏丟丂业世(不万专丐世丒丆丆下:  this);
        }
        
        }
        
        this.丏丅丅专七丘丑上丂 = 0;
        this.丌丝下丄业一丄不三 = 0;
    }
    public FreezerRay()
    {
        this.lifetime = 0.1f;
    }

}
