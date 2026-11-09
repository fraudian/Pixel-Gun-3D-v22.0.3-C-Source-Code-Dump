using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableARKitInit
    {
        // Fields
        public ARKitPlugin.Utils.serializableARSessionConfiguration config;
        public UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗 runOption;
        
        // Methods
        public serializableARKitInit(ARKitPlugin.Utils.serializableARSessionConfiguration 三丁丕丒丕丒丌丆丞, UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗 东丞且下丘丛丏丄不)
        {
            this.config = 三丁丕丒丕丒丌丆丞;
            this.runOption = 东丞且下丘丛丏丄不;
        }
    
    }

}
