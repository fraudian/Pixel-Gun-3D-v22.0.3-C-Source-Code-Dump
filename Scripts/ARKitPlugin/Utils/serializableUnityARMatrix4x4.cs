using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializableUnityARMatrix4x4
    {
        // Fields
        public ARKitPlugin.Utils.SerializableVector4 column0;
        public ARKitPlugin.Utils.SerializableVector4 column1;
        public ARKitPlugin.Utils.SerializableVector4 column2;
        public ARKitPlugin.Utils.SerializableVector4 column3;
        
        // Methods
        public serializableUnityARMatrix4x4(ARKitPlugin.Utils.SerializableVector4 专丈丘丄东丞丌业业, ARKitPlugin.Utils.SerializableVector4 一不丝丟世业丑丙一, ARKitPlugin.Utils.SerializableVector4 丘丑丛丕下丈世下丂, ARKitPlugin.Utils.SerializableVector4 专丈丌一丅业七丌丌)
        {
            val_1 = new System.Object();
            this.column0 = 专丈丘丄东丞丌业业;
            this.column1 = val_1;
            this.column2 = 丘丑丛丕下丈世下丂;
            this.column3 = 专丈丌一丅业七丌丌;
        }
        public static ARKitPlugin.Utils.serializableUnityARMatrix4x4 万丒丌丕万丏不丈世(UnityEngine.XR.iOS.上丆上丕丞专丙丛丆 上下且万丌下丆丞丅)
        {
            .column0 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.丟世上丝下丏丛丆丁.x, y = 上下且万丌下丆丞丅.丟世上丝下丏丛丆丁.y, z = 上下且万丌下丆丞丅.丟世上丝下丏丛丆丁.z, w = 上下且万丌下丆丞丅.丟世上丝下丏丛丆丁.w});
            .column1 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.七且丞丈万丌万丙下.x, y = 上下且万丌下丆丞丅.七且丞丈万丌万丙下.y, z = 上下且万丌下丆丞丅.七且丞丈万丌万丙下.z, w = 上下且万丌下丆丞丅.七且丞丈万丌万丙下.w});
            .column2 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.一丛万丕与丌丞丝东.x, y = 上下且万丌下丆丞丅.一丛万丕与丌丞丝东.y, z = 上下且万丌下丆丞丅.一丛万丕与丌丞丝东.z, w = 上下且万丌下丆丞丅.一丛万丕与丌丞丝东.w});
            .column3 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4() {x = 上下且万丌下丆丞丅.下且丂丐东世世丑下.x, y = 上下且万丌下丆丞丅.下且丂丐东世世丑下.y, z = 上下且万丌下丆丞丅.下且丂丐东世世丑下.z, w = 上下且万丌下丆丞丅.下且丂丐东世世丑下.w});
            return (ARKitPlugin.Utils.serializableUnityARMatrix4x4)new ARKitPlugin.Utils.serializableUnityARMatrix4x4();
        }
        public static UnityEngine.XR.iOS.上丆上丕丞专丙丛丆 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializableUnityARMatrix4x4 上下且万丌下丆丞丅)
        {
            UnityEngine.XR.iOS.上丆上丕丞专丙丛丆 val_0;
            UnityEngine.Vector4 val_1 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column0);
            UnityEngine.Vector4 val_2 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column1);
            UnityEngine.Vector4 val_3 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column2);
            UnityEngine.Vector4 val_4 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column3);
            val_0.下且丂丐东世世丑下.x = 0f;
            val_0.下且丂丐东世世丑下.y = 0f;
            val_0.下且丂丐东世世丑下.z = 0f;
            val_0.下且丂丐东世世丑下.w = 0f;
            val_0.一丛万丕与丌丞丝东.x = 0f;
            val_0.一丛万丕与丌丞丝东.y = 0f;
            val_0.一丛万丕与丌丞丝东.z = 0f;
            val_0.一丛万丕与丌丞丝东.w = 0f;
            val_0.七且丞丈万丌万丙下.x = 0f;
            val_0.七且丞丈万丌万丙下.y = 0f;
            val_0.七且丞丈万丌万丙下.z = 0f;
            val_0.七且丞丈万丌万丙下.w = 0f;
            val_0.丟世上丝下丏丛丆丁.x = 0f;
            val_0.丟世上丝下丏丛丆丁.y = 0f;
            val_0.丟世上丝下丏丛丆丁.z = 0f;
            val_0.丟世上丝下丏丛丆丁.w = 0f;
            return val_0;
        }
        public static ARKitPlugin.Utils.serializableUnityARMatrix4x4 万丒丌丕万丏不丈世(UnityEngine.Matrix4x4 上下且万丌下丆丞丅)
        {
            .column0 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4());
            .column1 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4());
            .column2 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4());
            .column3 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.Vector4());
            return (ARKitPlugin.Utils.serializableUnityARMatrix4x4)new ARKitPlugin.Utils.serializableUnityARMatrix4x4();
        }
        public static UnityEngine.Matrix4x4 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializableUnityARMatrix4x4 上下且万丌下丆丞丅)
        {
            UnityEngine.Matrix4x4 val_0;
            UnityEngine.Vector4 val_1 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column0);
            UnityEngine.Vector4 val_2 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column1);
            UnityEngine.Vector4 val_3 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column2);
            UnityEngine.Vector4 val_4 = ARKitPlugin.Utils.SerializableVector4.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  上下且万丌下丆丞丅.column3);
            val_0.m03 = 0f;
            val_0.m13 = 0f;
            val_0.m23 = 0f;
            val_0.m33 = 0f;
            val_0.m02 = 0f;
            val_0.m12 = 0f;
            val_0.m22 = 0f;
            val_0.m32 = 0f;
            val_0.m01 = 0f;
            val_0.m11 = 0f;
            val_0.m21 = 0f;
            val_0.m31 = 0f;
            val_0.m00 = 0f;
            val_0.m10 = 0f;
            val_0.m20 = 0f;
            val_0.m30 = 0f;
            return val_0;
        }
    
    }

}
