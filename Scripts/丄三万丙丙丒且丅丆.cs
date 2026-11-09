using UnityEngine;
internal class 丄三万丙丙丒且丅丆 : 丅三且丘一丆丈万不
{
    // Fields
    internal UnityEngine.GameObject 一与万业不上丙业下;
    
    // Properties
    internal override string 一丄七丟丈丝丙丌丞 { get; }
    
    // Methods
    internal 丄三万丙丙丒且丅丆(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override string 下丑不七不万丛上一()
    {
        丕丈丏丝丗下丟丅丂 val_1 = this.丙丕丞且丕不丘丙丑();
        if(val_1 != null)
        {
                return val_1.业上丙丞丐丄丆丅七();
        }
        
        return val_1.业上丙丞丐丄丆丅七();
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        this.丈七丁与丝上丕丝丕();
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_1;
        if(true == 0)
        {
                this.丈丛下丌丗丑下万丆();
        }
        
        val_1 = null;
        val_1 = null;
        一丂下与丁丐且不丌(丙丗丕丟七丟上丈丌:  this, 丞世不丒下上上丝丑:  232);
        this.丟丄不丄丝业专丅丙();
        this.丝丂与丒丟丕丙不丅();
        丂丁丄丄上丞丈上丞();
    }
    internal override void 丞专一丙丁丒万三丏(WeaponSounds 丌丝下丄业一丄不三)
    {
        var val_11;
        float val_12;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  10000f);
        val_12 = val_2.x;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        Rocket val_4 = Player_move_c.丞专一丙丁丒万三丏(专丑一业业下且丅丗:  丌丝下丄业一丄不三, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_12, y = val_2.y, z = val_2.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, 丑三一万丆不丁万丏:  1f, 丗丑丞丗七业丆丙丁:  1, 不丐丂丂丘丞丁丑丌:  0);
        if(this.丙丕丞且丕不丘丙丑() != null)
        {
                val_11 = this.丙丕丞且丕不丘丙丑();
            val_12 = val_11.丁丒丝丈丈丒丞丘下(丅丏三七丁丑丞丄丏:  val_4.photonView);
            val_4.丈丒丄丝丐专丐丙丌 = val_12;
        }
        
        UnityEngine.GameObject val_9 = val_4.gameObject;
        this.一与万业不上丙业下 = val_9;
        this.东与一三丁七丕丑丁(丁丂丏与丗上丗一丆:  val_9.GetComponent<Rocket>());
    }
    internal override void 万丒一万丌丆丏丈不()
    {
        var val_17;
        float val_18;
        var val_19;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        var val_27;
        val_17 = this;
        if(this.一与万业不上丙业下 == 0)
        {
                return;
        }
        
        if(val_2.丅丕丟七丌丘丆丌上 != 0)
        {
                val_18 = val_2.丅丕丟七丌丘丆丌上.与丕丒丂丗一且不丁();
        }
        else
        {
                val_18 = 150f;
        }
        
        UnityEngine.Rigidbody val_5 = this.一与万业不上丙业下.GetComponent<UnityEngine.Rigidbody>();
        val_5.isKinematic = false;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_22;
        }
        
        val_19 = null;
        val_19 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丘丂三东丁且丙世七()) == false)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_8 = this.丁丁丏七丂丛丂丟丅();
        val_23 = val_8.x;
        val_24 = val_8.y;
        val_25 = val_8.z;
        val_26 = 0f;
        goto label_23;
        label_22:
        val_27 = null;
        val_27 = null;
        val_17 = myTransform;
        UnityEngine.Vector3 val_10 = val_17.forward;
        val_23 = val_10.x;
        val_24 = val_10.y;
        val_25 = val_10.z;
        val_26 = -5f;
        label_23:
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_26, z:  0f);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.1f);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(d:  val_18, a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, point:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        if(val_5 != null)
        {
                val_5.AddForce(force:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        }
        else
        {
                val_5.AddForce(force:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        }
        
        val_5.useGravity = true;
        this.一与万业不上丙业下.GetComponent<Rocket>().万丏世丆丁万丏丞丟(业丘东且七丕丞东不:  false);
    }

}
