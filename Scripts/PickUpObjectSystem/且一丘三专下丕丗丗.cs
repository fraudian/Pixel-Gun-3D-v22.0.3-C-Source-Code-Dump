using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class 且一丘三专下丕丗丗 : 丕丈一七丗且丐丟丐
    {
        // Methods
        internal override UnityEngine.GameObject 专丄丞丈世一丒丅东(string 丛丄业丕且丗下一万, string 丞丅上丏丂且下丅与, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_7;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(val_1 != null)
            {
                    val_1.name = 丞丅上丏丂且下丅与;
            }
            else
            {
                    0.name = 丞丅上丏丂且下丅与;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  180f);
            val_2.eulersPerSecond = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            if((专丒丌丆下丐丞丟丞 != null) && (专丒丌丆下丐丞丟丞.Length != 0))
            {
                    object val_7 = 专丒丌丆下丐丞丟丞[0];
            }
            else
            {
                    val_7 = 0;
            }
            
            UnityEngine.Coroutine val_6 = val_1.AddComponent<ZeichenKraftwerk.Rotator>().StartCoroutine(routine:  this.丅丌丈丝业丄且七丈(且丟丞丁一七丑丅丌:  val_1, 丛丄业丕且丗下一万:  丛丄业丕且丗下一万, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丗丛丁世丒且丞丒丕:  0));
            return val_1;
        }
        private System.Collections.IEnumerator 丅丌丈丝业丄且七丈(UnityEngine.GameObject 且丟丞丁一七丑丅丌, string 丛丄业丕且丗下一万, string 丞丅上丏丂且下丅与, int 丗丛丁世丒且丞丒丕)
        {
            且一丘三专下丕丗丗.七专丙丐丝丄专丞业 val_1 = new 且一丘三专下丕丗丗.七专丙丐丝丄专丞业();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .且丟丞丁一七丑丅丌 = 且丟丞丁一七丑丅丌;
                .丛丄业丕且丗下一万 = 丛丄业丕且丗下一万;
                .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            }
            else
            {
                    mem[56] = 且丟丞丁一七丑丅丌;
                mem[32] = 丛丄业丕且丗下一万;
                mem[40] = 丞丅上丏丂且下丅与;
            }
            
            .丗丛丁世丒且丞丒丕 = 丗丛丁世丒且丞丒丕;
            return (System.Collections.IEnumerator)val_1;
        }
        public 且一丘三专下丕丗丗()
        {
            val_1 = new System.Object();
        }
    
    }

}
