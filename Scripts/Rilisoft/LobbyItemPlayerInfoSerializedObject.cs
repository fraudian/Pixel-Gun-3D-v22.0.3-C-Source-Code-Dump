using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class LobbyItemPlayerInfoSerializedObject
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> Infos;
        
        // Methods
        public LobbyItemPlayerInfoSerializedObject()
        {
            this.Infos = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
        }
    
    }

}
