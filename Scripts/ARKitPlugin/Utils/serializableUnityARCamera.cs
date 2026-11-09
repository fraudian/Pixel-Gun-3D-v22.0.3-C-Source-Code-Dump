using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableUnityARCamera
    {
        // Fields
        public ARKitPlugin.Utils.serializableUnityARMatrix4x4 worldTransform;
        public ARKitPlugin.Utils.serializableUnityARMatrix4x4 projectionMatrix;
        public UnityEngine.XR.iOS.丙丈丞丁且且上七丏 trackingState;
        public UnityEngine.XR.iOS.丌七丕丞丘万丕专丌 trackingReason;
        public UnityEngine.XR.iOS.UnityVideoParams videoParams;
        public UnityEngine.XR.iOS.UnityARLightEstimate lightEstimation;
        public ARKitPlugin.Utils.serializablePointCloud pointCloud;
        
        // Methods
        public serializableUnityARCamera(ARKitPlugin.Utils.serializableUnityARMatrix4x4 丅下专上丌不三东丗, ARKitPlugin.Utils.serializableUnityARMatrix4x4 不丈与丂丈丙一三丄, UnityEngine.XR.iOS.丙丈丞丁且且上七丏 丏世东丈七丅丈丘丙, UnityEngine.XR.iOS.丌七丕丞丘万丕专丌 不丐专且东丝丘丄丏, UnityEngine.XR.iOS.UnityVideoParams 丁丟万丁丕丙丟下丘, UnityEngine.XR.iOS.UnityARLightEstimate 丗丕东丁世不上丂下, ARKitPlugin.Utils.serializablePointCloud 三丑丒丌丛丆丝下万)
        {
            val_1 = new System.Object();
            this.worldTransform = 丅下专上丌不三东丗;
            this.projectionMatrix = val_1;
            this.trackingState = 丏世东丈七丅丈丘丙;
            this.trackingReason = 不丐专且东丝丘丄丏;
            this.lightEstimation = 丗丕东丁世不上丂下;
            mem[1152921540740323476] = 丗丕东丁世不上丂下.ambientColorTemperature;
            this.pointCloud = 三丑丒丌丛丆丝下万;
            mem[1152921540740323464] = 丁丟万丁丕丙丟下丘.cvPixelBufferPtr;
            this.videoParams = 丁丟万丁丕丙丟下丘.yWidth;
        }
        public static ARKitPlugin.Utils.serializableUnityARCamera 万丒丌丕万丏不丈世(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 上下且万丌下丆丞丅)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            var val_9;
            UnityEngine.XR.iOS.UnityVideoParams val_10;
            .worldTransform = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.上丆上丕丞专丙丛丆() {丟世上丝下丏丛丆丁 = new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.三丏丅丒丛丕下且万.丟世上丝下丏丛丆丁.x}, 七且丞丈万丌万丙下 = new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.三丏丅丒丛丕下且万.七且丞丈万丌万丙下.x}, 一丛万丕与丌丞丝东 = new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.三丏丅丒丛丕下且万.一丛万丕与丌丞丝东.x}, 下且丂丐东世世丑下 = new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.三丏丅丒丛丕下且万.下且丂丐东世世丑下.x}});
            .projectionMatrix = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.上丆上丕丞专丙丛丆() {丟世上丝下丏丛丆丁 = new UnityEngine.Vector4() {x = val_4, y = val_4, z = val_4, w = val_4}, 七且丞丈万丌万丙下 = new UnityEngine.Vector4() {x = val_5, y = val_5, z = val_5, w = val_5}, 一丛万丕与丌丞丝东 = new UnityEngine.Vector4() {x = val_2, y = val_2, z = val_2, w = val_2}, 下且丂丐东世世丑下 = new UnityEngine.Vector4() {x = val_3, y = val_3, z = val_3, w = val_3}});
            .trackingState = 1773976800;
            .trackingReason = 268435464;
            mem[1152921540740619544] = val_9;
            .lightEstimation = 上下且万丌下丆丞丅.丄丄七上上丟丑丝丟.cvPixelBufferPtr;
            mem[1152921540740619556] = 上下且万丌下丆丞丅.丄丄七上上丟丑丝丟.cvPixelBufferPtr;
            .pointCloud = ARKitPlugin.Utils.serializablePointCloud.万丒丌丕万丏不丈世(丄一丗三丏业丙专丗:  上下且万丌下丆丞丅.丟世七丆一七丛丁下.ambientIntensity);
            .videoParams = val_10;
            return (ARKitPlugin.Utils.serializableUnityARCamera)new ARKitPlugin.Utils.serializableUnityARCamera();
        }
        public static UnityEngine.XR.iOS.丂与与丞丈三专丈丅 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializableUnityARCamera 上下且万丌下丆丞丅)
        {
            var val_12;
            UnityEngine.XR.iOS.丙丈丞丁且且上七丏 val_13;
            UnityEngine.XR.iOS.丌七丕丞丘万丕专丌 val_14;
            UnityEngine.XR.iOS.UnityARLightEstimate val_16;
            float val_17;
            UnityEngine.XR.iOS.丂与与丞丈三专丈丅 val_0;
            val_12 = 上下且万丌下丆丞丅;
            UnityEngine.XR.iOS.上丆上丕丞专丙丛丆 val_1 = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.worldTransform);
            UnityEngine.XR.iOS.上丆上丕丞专丙丛丆 val_2 = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.projectionMatrix);
            if(val_12 != null)
            {
                    val_13 = 上下且万丌下丆丞丅.trackingState;
                val_14 = 上下且万丌下丆丞丅.trackingReason;
                val_16 = 上下且万丌下丆丞丅.lightEstimation;
            }
            else
            {
                    val_13 = 64;
                val_14 = 0;
                val_16 = 1.401298E-45f;
                val_17 = 7.006492E-45f;
            }
            
            UnityEngine.Vector3[] val_3 = ARKitPlugin.Utils.serializablePointCloud.万丒丌丕万丏不丈世(三丑丒丌丛丆丝下万:  上下且万丌下丆丞丅.pointCloud);
            return val_0;
        }
    
    }

}
