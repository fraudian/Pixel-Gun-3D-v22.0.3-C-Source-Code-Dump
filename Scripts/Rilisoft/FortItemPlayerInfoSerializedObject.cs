using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class FortItemPlayerInfoSerializedObject
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.FortItemPlayerInfo> Infos;
        
        // Methods
        public FortItemPlayerInfoSerializedObject()
        {
            this.Infos = new System.Collections.Generic.List<Rilisoft.FortItemPlayerInfo>();
        }
    
    }

}
