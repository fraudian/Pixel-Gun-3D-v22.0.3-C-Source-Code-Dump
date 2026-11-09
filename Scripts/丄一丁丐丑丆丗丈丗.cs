using UnityEngine;
internal class 丄一丁丐丑丆丗丈丗 : 丄丅三丐丒丗上丗一
{
    // Methods
    internal 丄一丁丐丑丆丗丈丗(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
        val_1 = new 不丘丄丝丗丒丙一丌(丟丟万一不业上丐丗:  丟丟万一不业上丐丗);
        val_1.丝丂与丒丟丕丙不丅();
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        this.丈七丁与丝上丕丝丕();
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_19;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_20;
        var val_21;
        this.丟丄不丄丝业专丅丙();
        UnityEngine.GameObject val_1 = RocketStack.丄丞丁丈与业上丞丟.丄丌丛丗世业丛丆丂();
        val_19 = null;
        val_19 = null;
        WeaponSounds val_3 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        UnityEngine.Vector3 val_6 = val_3.bulletSpawnPoints.Item[0].transform.position;
        val_1.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_10 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().transform.rotation;
        val_1.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        Rocket val_11 = val_1.GetComponent<Rocket>();
        float val_13 = this.丙丕丞且丕不丘丙丑().丑丈东丄丏三上丕丟();
        if(val_11 != null)
        {
                val_11.丈丒丄丝丐专丐丙丌 = val_13;
            val_11.丐丅丟丟丞七丗三丙 = true;
        }
        else
        {
                mem[112] = val_13;
            val_11.丐丅丟丟丞七丗三丙 = true;
        }
        
        val_11.下丐不世丁与与丄下 = 3f;
        val_20 = 0;
        if(丙不丅丕三丂业东丕() != 0)
        {
                val_21 = null;
            val_21 = null;
            WeaponSounds val_18 = 丙不丅丕三丂业东丕();
            val_20 = val_18.三世丗丆丕万丐且三;
        }
        
        val_11.丑丕丅丗丂七丆丛东(世万丘丟丐上世不上:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 丁丐一与丘丛丐丈七:  52, 一丐丙丒下丗丙丟三:  "Explosion821", 丝三丛且丘不丌丙下:  this.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), 丑丆专丕世丐丛上丒:  val_20);
    }

}
