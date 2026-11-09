using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableUnityARPlaneAnchor
    {
        // Fields
        public ARKitPlugin.Utils.serializableUnityARMatrix4x4 worldTransform;
        public ARKitPlugin.Utils.SerializableVector4 center;
        public ARKitPlugin.Utils.SerializableVector4 extent;
        public UnityEngine.XR.iOS.丒丒丕丄丌丞丘丄丛 planeAlignment;
        public byte[] identifierStr;
        
        // Methods
        public serializableUnityARPlaneAnchor(ARKitPlugin.Utils.serializableUnityARMatrix4x4 丅下专上丌不三东丗, ARKitPlugin.Utils.SerializableVector4 丑丒世上丅下丌与丄, ARKitPlugin.Utils.SerializableVector4 下丑三丈丅丙与丟丁, UnityEngine.XR.iOS.丒丒丕丄丌丞丘丄丛 丂丑丄丕丌一丑丈丘, byte[] 丘丘世东丗丒丏七专)
        {
            val_1 = new System.Object();
            this.worldTransform = 丅下专上丌不三东丗;
            this.center = val_1;
            this.extent = 下丑三丈丅丙与丟丁;
            this.planeAlignment = 丂丑丄丕丌一丑丈丘;
            this.identifierStr = 丘丘世东丗丒丏七专;
        }
        public static ARKitPlugin.Utils.serializableUnityARPlaneAnchor 万丒丌丕万丏不丈世(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 上下且万丌下丆丞丅)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_4;
            .x = 上下且万丌下丆丞丅.丙丂丂业丂丁丌丂下.x;
            .z = 上下且万丌下丆丞丅.丙丂丂业丂丁丌丂下.z;
            .w = 1f;
            .x = 上下且万丌下丆丞丅.不东丈丟丅丂丝下下.x;
            .z = 上下且万丌下丆丞丅.不东丈丟丅丂丝下下.z;
            .w = 1f;
            .worldTransform = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Matrix4x4() {m00 = val_3, m10 = val_3, m20 = val_3, m30 = val_3, m01 = val_4, m11 = val_4, m21 = val_4, m31 = val_4, m02 = val_1, m12 = val_1, m22 = val_1, m32 = val_1, m03 = val_2, m13 = val_2, m23 = val_2, m33 = val_2});
            .center = new ARKitPlugin.Utils.SerializableVector4();
            .extent = new ARKitPlugin.Utils.SerializableVector4();
            .planeAlignment = 上下且万丌下丆丞丅.世丕七丑丑丟不丙丏;
            .identifierStr = System.Text.Encoding.UTF8;
            return (ARKitPlugin.Utils.serializableUnityARPlaneAnchor)new ARKitPlugin.Utils.serializableUnityARPlaneAnchor();
        }
        public static UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializableUnityARPlaneAnchor 上下且万丌下丆丞丅)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            ARKitPlugin.Utils.SerializableVector4 val_7;
            float val_8;
            ARKitPlugin.Utils.SerializableVector4 val_9;
            ARKitPlugin.Utils.SerializableVector4 val_10;
            float val_11;
            ARKitPlugin.Utils.SerializableVector4 val_12;
            UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 val_0;
            val_7 = 上下且万丌下丆丞丅.center;
            if(val_7 == null)
            {
                goto label_2;
            }
            
            val_8 = 上下且万丌下丆丞丅.center.x;
            val_9 = val_7;
            goto label_5;
            label_2:
            val_9 = 上下且万丌下丆丞丅.center;
            val_8 = 上下且万丌下丆丞丅.center.x;
            if(val_9 == null)
            {
                goto label_4;
            }
            
            val_7 = val_9;
            goto label_5;
            label_4:
            val_7 = 上下且万丌下丆丞丅.center;
            if(val_7 == null)
            {
                goto label_11;
            }
            
            label_5:
            val_10 = 上下且万丌下丆丞丅.extent;
            if(val_10 == null)
            {
                goto label_7;
            }
            
            val_11 = 上下且万丌下丆丞丅.extent.x;
            val_12 = val_10;
            goto label_10;
            label_7:
            val_12 = 上下且万丌下丆丞丅.extent;
            val_11 = 上下且万丌下丆丞丅.extent.x;
            if(val_12 == null)
            {
                goto label_9;
            }
            
            val_10 = val_12;
            goto label_10;
            label_9:
            val_10 = 上下且万丌下丆丞丅.extent;
            if(val_10 == null)
            {
                goto label_11;
            }
            
            label_10:
            UnityEngine.Matrix4x4 val_2 = ARKitPlugin.Utils.serializableUnityARMatrix4x4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.worldTransform);
            val_0.丏且丐丆丒丕丕丝丆 = System.Text.Encoding.UTF8;
            val_0.世丕七丑丑丟不丙丏 = 上下且万丌下丆丞丅.planeAlignment;
            val_0.丙丂丂业丂丁丌丂下.x = 0f;
            val_0.丙丂丂业丂丁丌丂下.y = 0f;
            val_0.丙丂丂业丂丁丌丂下.z = 0f;
            val_0.不东丈丟丅丂丝下下.x = 0f;
            val_0.不东丈丟丅丂丝下下.y = 0f;
            val_0.不丂丅丁且丆东东丂.m03 = val_4;
            val_0.不丂丅丁且丆东东丂.m02 = val_3;
            val_0.不丂丅丁且丆东东丂.m01 = val_6;
            val_0.不丂丅丁且丆东东丂.m00 = val_5;
            val_0.不东丈丟丅丂丝下下.z = 0f;
            return val_0;
            label_11:
        }
    
    }

}
