using UnityEngine;

namespace PGCompany
{
    internal class 上且丑丟丏丈丏丁丁 : 丞丛上丛丟东世丝丞
    {
        // Methods
        internal override bool 专丄丏丞丈丞丞不丒()
        {
            Player_move_c val_11;
            var val_12;
            var val_13;
            int val_14;
            var val_15;
            val_11 = 1152921505286238208;
            val_12 = null;
            val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                    return (bool)0 & 1;
            }
            
            val_13 = null;
            val_13 = null;
            val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_11 == 0)
            {
                    return (bool)0 & 1;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  WeaponManager.丟丗丄业丘丗业丗七._turretCache)) != false)
            {
                    return (bool)0 & 1;
            }
            
            val_14 = System.String.alignConst;
            UnityEngine.Vector3 val_5 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_15 = 0;
            goto label_19;
            label_29:
            if((Initializer.丆丝丒不丘丛丆上丗()[0].上万丘万丄与万下丌(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == true)
            {
                goto label_25;
            }
            
            val_15 = 1;
            label_19:
            PGCompany.NamedZoneOnMap[] val_8 = Initializer.丆丝丒不丘丛丆上丗();
            if(val_15 < val_8.Length)
            {
                goto label_29;
            }
            
            goto label_30;
            label_25:
            PGCompany.NamedZoneOnMap val_13 = Initializer.丆丝丒不丘丛丆上丗()[0];
            val_14 = val_9[0x0][0].Tag;
            label_30:
            bool val_11 = (val_14.Equals(value:  val_14, comparisonType:  5)) ^ 1;
            return (bool)0 & 1;
        }
        internal override void 下丌业业丐丘丐丘三()
        {
        
        }
        internal override void 不与丞下业丑丒丙万()
        {
        
        }
        public 上且丑丟丏丈丏丁丁()
        {
        
        }
    
    }

}
