using UnityEngine;
internal class 丌丅丂丆东与且丁丂 : 丄丅三丐丒丗上丗一
{
    // Methods
    internal 丌丅丂丆东与且丁丂(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        this.丈七丁与丝上丕丝丕();
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_31;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_32;
        var val_33;
        this.丟丄不丄丝业专丅丙();
        var val_31 = 0;
        do
        {
            UnityEngine.GameObject val_1 = RocketStack.丄丞丁丈与业上丞丟.丄丌丛丗世业丛丆丂();
            val_31 = null;
            val_31 = null;
            UnityEngine.Vector3 val_4 = transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_7 = transform.rotation;
            val_1.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            val_1.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, angle:  0f);
            UnityEngine.Transform val_10 = val_1.transform;
            UnityEngine.Vector3 val_11 = val_10.position;
            UnityEngine.Vector3 val_13 = val_1.transform.forward;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  2f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_10.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            UnityEngine.Transform val_16 = val_1.transform;
            UnityEngine.Vector3 val_17 = val_16.position;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  1.1f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            val_16.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            Rocket val_21 = val_1.GetComponent<Rocket>();
            float val_23 = this.丙丕丞且丕不丘丙丑().丑丈东丄丏三上丕丟();
            if(val_21 != null)
        {
                val_21.丈丒丄丝丐专丐丙丌 = val_23;
        }
        else
        {
                mem[112] = val_23;
        }
        
            val_21.丂丝不一丑下三七业().useGravity = true;
            if(val_21 != null)
        {
                val_21.下丐不世丁与与丄下 = 4.8f;
        }
        else
        {
                val_21.下丐不世丁与与丄下 = 4.8f;
        }
        
            val_21.丂丝不一丑下三七业().isKinematic = false;
            val_32 = 0;
            if(丙不丅丕三丂业东丕() != 0)
        {
                val_33 = null;
            val_33 = null;
            WeaponSounds val_30 = 丙不丅丕三丂业东丕();
            val_32 = val_30.三世丗丆丕万丐且三;
        }
        
            val_21.丑丕丅丗丂七丆丛东(世万丘丟丐上世不上:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 丁丐一与丘丛丐丈七:  138, 一丐丙丒下丗丙丟三:  "Explosion47", 丝三丛且丘不丌丙下:  this.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), 丑丆专丕世丐丛上丒:  val_32);
            val_31 = val_31 + 90;
        }
        while(val_31 != 360);
    
    }

}
