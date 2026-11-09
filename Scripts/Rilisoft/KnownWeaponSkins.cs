using UnityEngine;

namespace Rilisoft
{
    public class KnownWeaponSkins : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<string> KnownAssetsNames;
        
        // Methods
        public KnownWeaponSkins()
        {
            this.KnownAssetsNames = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
