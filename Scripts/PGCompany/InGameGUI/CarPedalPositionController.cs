using UnityEngine;

namespace PGCompany.InGameGUI
{
    internal class CarPedalPositionController : PGBehaviour
    {
        // Methods
        private void Start()
        {
            if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().localPosition;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            TouchButton val_11 = this.GetComponent<TouchButton>();
            if(val_11 == null)
            {
                    return;
            }
            
            val_11.CalculateButtonRect(丆丏一专不丝丈丗上:  不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>());
        }
        public CarPedalPositionController()
        {
        
        }
    
    }

}
