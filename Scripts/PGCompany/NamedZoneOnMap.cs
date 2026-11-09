using UnityEngine;

namespace PGCompany
{
    public class NamedZoneOnMap : AreaBase
    {
        // Fields
        public UnityEngine.BoxCollider Zone;
        public string Tag;
        public string LocalizationKey;
        private UnityEngine.Transform 上丛丂三上与丂丕丑;
        
        // Properties
        private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        
        // Methods
        private UnityEngine.Transform 丌丟丄业且三丛丕丄()
        {
            UnityEngine.Transform val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.上丛丂三上与丂丕丑)) != false)
            {
                    val_3 = this.上丛丂三上与丂丕丑;
                return val_2;
            }
            
            UnityEngine.Transform val_2 = this.transform;
            this.上丛丂三上与丂丕丑 = val_2;
            return val_2;
        }
        internal static string 七业丑不七丐业丟丂(string 丆万一不丌且东丐丐)
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Zone_" + 丆万一不丌且东丐丐);
        }
        protected override void Awake()
        {
            UnityEngine.BoxCollider val_9;
            this.Awake();
            if(this.Zone == 0)
            {
                    val_9 = this.GetComponent<UnityEngine.BoxCollider>();
                this.Zone = val_9;
            }
            else
            {
                    val_9 = this.Zone;
            }
            
            if(val_9 == 0)
            {
                    string val_5 = "Attach BoxCollider to " + this.name;
            }
            else
            {
                    if(this.Zone.isTrigger != false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "BoxCollider on zone object " + this.name + " must be trigger", context:  this);
        }
        internal bool 上万丘万丄与万下丌(UnityEngine.Vector3 丈七丅上丟丑专丅丝)
        {
            var val_11;
            var val_12;
            val_11 = this;
            if(this.Zone == 0)
            {
                    val_12 = 0;
                return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            UnityEngine.Vector3 val_2 = this.Zone.size;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  2f);
            val_11 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_5 = val_11.position;
            val_12 = 0;
            if((val_5.z - val_3.z) > 丈七丅上丟丑专丅丝.z)
            {
                    return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            if(丈七丅上丟丑专丅丝.y > (val_3.y + val_5.y))
            {
                    return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            val_5.y = val_5.y - val_3.y;
            if(val_5.y > 丈七丅上丟丑专丅丝.y)
            {
                    return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            if((val_5.x - val_3.x) > 丈七丅上丟丑专丅丝.x)
            {
                    return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            val_5.x = val_3.x + val_5.x;
            if(丈七丅上丟丑专丅丝.x > val_5.x)
            {
                    return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
            }
            
            return (bool)(丈七丅上丟丑专丅丝.z <= (val_3.z + val_5.z)) ? 1 : 0;
        }
        private void OnTriggerEnter(UnityEngine.Collider 东丆丕万丑上下专丗)
        {
            var val_4;
            Player_move_c val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((东丆丕万丑上下专丗.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            Rilisoft.丞丛七上丕专丏丌丈.东丄丝丒七丛东丗丗(丂不专上丌丞丈丛下:  this.Tag, 丕丆丑丑丛三上丟业:  ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266) != 0) ? 1 : 0);
        }
        public NamedZoneOnMap()
        {
        
        }
    
    }

}
