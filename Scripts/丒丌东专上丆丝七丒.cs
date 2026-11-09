using UnityEngine;
internal class 丒丌东专上丆丝七丒 : 丄丅三丐丒丗上丗一
{
    // Methods
    internal 丒丌东专上丆丝七丒(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal override void 丈七丁与丝上丕丝丕()
    {
        this.丈七丁与丝上丕丝丕();
    }
    internal override void 丟丄不丄丝业专丅丙()
    {
        var val_21;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_22;
        var val_23;
        this.丟丄不丄丝业专丅丙();
        UnityEngine.GameObject val_1 = RocketStack.丄丞丁丈与业上丞丟.丄丌丛丗世业丛丆丂();
        val_21 = null;
        val_21 = null;
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
            val_11.世业万丕丘丘丕丅下 = true;
        }
        else
        {
                mem[112] = val_13;
            val_11.丐丅丟丟丞七丗三丙 = true;
            mem[152] = true;
        }
        
        val_11.丗丛丘丁三三丌丒万 = false;
        float val_15 = this.丙丕丞且丕不丘丙丑().丐下三下丆丛万丑丟();
        val_11.七丏上不丒万丐东丄 = 2f;
        val_15 = 100f - val_15;
        val_15 = val_15 / 100f;
        val_11.三上丅丈丄不丌万丙 = val_15;
        val_11.下丐不世丁与与丄下 = 5f;
        val_22 = 0;
        if(丙不丅丕三丂业东丕() != 0)
        {
                val_23 = null;
            val_23 = null;
            WeaponSounds val_20 = 丙不丅丕三丂业东丕();
            val_22 = val_20.三世丗丆丕万丐且三;
        }
        
        val_11.丑丕丅丗丂七丆丛东(世万丘丟丐上世不上:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 丁丐一与丘丛丐丈七:  141, 一丐丙丒下丗丙丟三:  "Explosion31373", 丝三丛且丘不丌丙下:  this.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), 丑丆专丕世丐丛上丒:  val_22);
    }

}
