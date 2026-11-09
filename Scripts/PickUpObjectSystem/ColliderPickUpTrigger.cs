using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class ColliderPickUpTrigger : BasePickUpTrigger
    {
        // Methods
        private void Awake()
        {
            UnityEngine.BoxCollider val_2 = this.gameObject.AddComponent<UnityEngine.BoxCollider>();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            if(val_2 != null)
            {
                    val_2.size = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            else
            {
                    val_2.size = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            val_2.isTrigger = true;
        }
        private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
        {
            Player_move_c val_5;
            var val_6;
            val_5 = 1152921504848912384;
            if((丘丛丏丘丝七世七丅.gameObject.GetComponentInParent<SkinName>()) == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            bool val_4 = UnityEngine.Object.op_Equality(x:  val_2.playerMoveC, y:  val_5);
            if(val_4 == false)
            {
                    return;
            }
            
            if(val_4 == false)
            {
                    return;
            }
            
            val_4.Invoke();
        }
        public ColliderPickUpTrigger()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
