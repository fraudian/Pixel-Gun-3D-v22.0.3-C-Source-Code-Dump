using UnityEngine;

namespace Rilisoft
{
    public class WearInvisbleParams : MonoBehaviour
    {
        // Fields
        public bool HideIsInvisible;
        public string InvisibleShader;
        public bool SkipSetInvisible;
        
        // Methods
        public WearInvisbleParams()
        {
            this.InvisibleShader = "Mobile/Transparent-Shop";
        }
    
    }

}
