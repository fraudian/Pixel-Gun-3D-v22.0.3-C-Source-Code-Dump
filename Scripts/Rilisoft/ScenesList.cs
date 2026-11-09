using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class ScenesList : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.ExistsSceneInfo> Infos;
        
        // Methods
        public ScenesList()
        {
            this.Infos = new System.Collections.Generic.List<Rilisoft.ExistsSceneInfo>();
        }
    
    }

}
