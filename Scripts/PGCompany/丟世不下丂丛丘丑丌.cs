using UnityEngine;

namespace PGCompany
{
    internal class 丟世不下丂丛丘丑丌 : 丞丛上丛丟东世丝丞
    {
        // Methods
        internal override bool 专丄丏丞丈丞丞不丒()
        {
            Player_move_c val_9;
            var val_10;
            var val_11;
            int val_12;
            var val_13;
            PGCompany.NamedZoneOnMap val_14;
            val_9 = 1152921505286238208;
            val_10 = null;
            val_10 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                    return false;
            }
            
            val_11 = null;
            val_11 = null;
            val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_9 == 0)
            {
                    return false;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  WeaponManager.丟丗丄业丘丗业丗七._turretCache)) != false)
            {
                    return false;
            }
            
            val_12 = System.String.alignConst;
            UnityEngine.Vector3 val_4 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_13 = 0;
            goto label_18;
            label_28:
            val_14 = Initializer.丆丝丒不丘丛丆上丗()[0];
            if((val_14.上万丘万丄与万下丌(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) == true)
            {
                goto label_24;
            }
            
            val_13 = 1;
            label_18:
            val_14 = Initializer.丆丝丒不丘丛丆上丗();
            if(val_13 < val_7.Length)
            {
                goto label_28;
            }
            
            goto label_29;
            label_24:
            PGCompany.NamedZoneOnMap val_9 = Initializer.丆丝丒不丘丛丆上丗()[0];
            val_12 = val_8[0x0][0].Tag;
            label_29:
            if(this != null)
            {
                    return val_12.Equals(value:  val_12, comparisonType:  5);
            }
            
            return val_12.Equals(value:  val_12, comparisonType:  5);
        }
        internal override void 下丌业业丐丘丐丘三()
        {
        
        }
        internal override void 不与丞下业丑丒丙万()
        {
        
        }
        public 丟世不下丂丛丘丑丌()
        {
            val_1 = new System.Object();
        }
    
    }

}
