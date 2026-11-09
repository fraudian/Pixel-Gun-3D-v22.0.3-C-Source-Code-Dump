using UnityEngine;

namespace PGCompany
{
    internal sealed class SpriteSelector : MonoBehaviour
    {
        // Fields
        private UISprite primary;
        private UISprite secondary;
        
        // Methods
        internal void 丄丄且丞丒丒丘丙丁(int 丏丙东下丌三丑与丕)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.primary, 丏业丟一东丂东丘丛:  ((丏丙东下丌三丑与丕 & 1) != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.secondary, 丏业丟一东丂东丘丛:  丏丙东下丌三丑与丕 & 1);
        }
        public SpriteSelector()
        {
        
        }
    
    }

}
