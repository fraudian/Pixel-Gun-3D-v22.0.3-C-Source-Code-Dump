using UnityEngine;

namespace PGCompany
{
    internal class GestureInstance : MonoBehaviour
    {
        // Fields
        internal static PGCompany.GestureInstance 丟专丙丄业一丒丙丘;
        
        // Methods
        private void Awake()
        {
            if(PGCompany.GestureInstance.丟专丙丄业一丒丙丘 == 0)
            {
                    PGCompany.GestureInstance.丟专丙丄业一丒丙丘 = this;
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "Duplicate [GestureInstance]");
        }
        private void OnDestroy()
        {
            PGCompany.GestureInstance.丟专丙丄业一丒丙丘 = 0;
        }
        public GestureInstance()
        {
        
        }
    
    }

}
