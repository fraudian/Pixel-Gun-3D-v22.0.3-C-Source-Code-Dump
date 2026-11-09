using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableFromEditorMessage
    {
        // Fields
        public System.Guid subMessageId;
        public ARKitPlugin.Utils.serializableARKitInit arkitConfigMsg;
        
        // Methods
        public serializableFromEditorMessage()
        {
        
        }
    
    }

}
