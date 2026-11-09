using UnityEngine;
internal class 三且丆东七且丕丅丈 : 丒丈万丆丏三下丌丝
{
    // Methods
    internal 三且丆东七且丕丅丈(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_35;
        var val_36;
        float val_38;
        var val_39;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_40;
        var val_41;
        this.丟丄不丄丝业专丅丙();
        UnityEngine.GameObject val_1 = RocketStack.丄丞丁丈与业上丞丟.丄丌丛丗世业丛丆丂();
        val_35 = 1152921505286238208;
        val_36 = null;
        val_36 = null;
        UnityEngine.Vector3 val_5 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().transform.position;
        val_1.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_9 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().transform.rotation;
        val_1.transform.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
        val_1.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, angle:  90f);
        UnityEngine.Transform val_12 = val_1.transform;
        UnityEngine.Vector3 val_13 = val_12.position;
        UnityEngine.Vector3 val_15 = val_1.transform.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  2f);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        val_12.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        Rocket val_18 = val_1.GetComponent<Rocket>();
        val_18.丂丝不一丑下三七业().useGravity = true;
        float val_21 = this.丙丕丞且丕不丘丙丑().丑丈东丄丏三上丕丟();
        if(val_18 != null)
        {
                val_18.丈丒丄丝丐专丐丙丌 = val_21;
            val_18.下丐不世丁与与丄下 = 3f;
        }
        else
        {
                mem[112] = val_21;
            val_18.下丐不世丁与与丄下 = 3f;
        }
        
        if(val_18.丅丕丟七丌丘丆丌上 != 0)
        {
                val_38 = val_18.丅丕丟七丌丘丆丌上.与丕丒丂丗一且不丁();
        }
        else
        {
                val_38 = 150f;
        }
        
        UnityEngine.Rigidbody val_24 = val_18.GetComponent<UnityEngine.Rigidbody>();
        val_24.isKinematic = false;
        UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.Euler(x:  0f, y:  -15f, z:  0f);
        val_39 = null;
        val_39 = null;
        UnityEngine.Vector3 val_27 = myTransform.forward;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(d:  val_38, a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w}, point:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_24.AddForce(force:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        val_40 = 0;
        if(丙不丅丕三丂业东丕() != 0)
        {
                val_41 = null;
            val_41 = null;
            val_35 = 丙不丅丕三丂业东丕();
            val_40 = val_34.三世丗丆丕万丐且三;
        }
        
        val_18.丑丕丅丗丂七丆丛东(世万丘丟丐上世不上:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 丁丐一与丘丛丐丈七:  139, 一丐丙丒下丗丙丟三:  "ExplosiveAmmo", 丝三丛且丘不丌丙下:  this.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), 丑丆专丕世丐丛上丒:  val_40);
    }

}
