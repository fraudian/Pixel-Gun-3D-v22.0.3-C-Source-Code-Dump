using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableARSessionConfiguration
    {
        // Fields
        public UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄 alignment;
        public UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不 planeDetection;
        public bool getPointCloudData;
        public bool enableLightEstimation;
        
        // Methods
        public serializableARSessionConfiguration(UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄 专三丗不丙丝业丙专, UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不 丅东丐丕与丈丝三丏, bool 丟丂不与万丆丂丛丐, bool 不丆且丑丑与下丟不)
        {
            this.alignment = 专三丗不丙丝业丙专;
            this.planeDetection = 丅东丐丕与丈丝三丏;
            this.getPointCloudData = 丟丂不与万丆丂丛丐;
            this.enableLightEstimation = 不丆且丑丑与下丟不;
        }
        public static ARKitPlugin.Utils.serializableARSessionConfiguration 万丒丌丕万丏不丈世(UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕 丒丞丒一与丕丒丝上)
        {
            .alignment = 1152921540742966960;
            .planeDetection = 0;
            .getPointCloudData = (X1 != 255) ? 1 : 0;
            .enableLightEstimation = (255 != (X1 >> 8)) ? 1 : 0;
            return (ARKitPlugin.Utils.serializableARSessionConfiguration)new ARKitPlugin.Utils.serializableARSessionConfiguration();
        }
        public static UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializableARSessionConfiguration 丛不与三丌且丄丑且)
        {
            UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄 val_2;
            UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不 val_3;
            bool val_4;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕 val_0;
            if(丛不与三丌且丄丑且 != null)
            {
                    val_2 = 丛不与三丌且丄丑且.alignment;
                val_3 = 丛不与三丌且丄丑且.planeDetection;
                val_4 = 丛不与三丌且丄丑且.getPointCloudData;
            }
            else
            {
                    val_2 = 11993091;
                val_3 = 1;
                val_4 = 160;
            }
            
            var val_1 = (val_4 != 0) ? 1 : 0;
            return val_0;
        }
    
    }

}
