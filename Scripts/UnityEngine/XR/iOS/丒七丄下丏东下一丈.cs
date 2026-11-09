using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class 丒七丄下丏东下一丈
    {
        // Fields
        private UnityEngine.MeshCollider 丅丁丄丅丅丌三丛丘;
        private UnityEngine.MeshFilter 世丒丗丝丆丑不丐丒;
        private static UnityEngine.GameObject 丆丟丈丄下且上丙丒;
        
        // Methods
        public static void 下且丈丑专丘丌专丞(UnityEngine.GameObject 丝三丁东丈丒世丅业)
        {
            null = null;
            UnityEngine.XR.iOS.丒七丄下丏东下一丈.丆丟丈丄下且上丙丒 = 丝三丁东丈丒世丅业;
        }
        public static UnityEngine.GameObject 上丘丗丐丆丂不丄丙(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 且丌丆不且丆三三丂)
        {
            var val_5;
            var val_6;
            UnityEngine.GameObject val_7;
            val_5 = null;
            val_5 = null;
            if(UnityEngine.XR.iOS.丒七丄下丏东下一丈.丆丟丈丄下且上丙丒 != 0)
            {
                    val_6 = null;
                val_6 = null;
                val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.XR.iOS.丒七丄下丏东下一丈.丆丟丈丄下且上丙丒);
            }
            else
            {
                    UnityEngine.GameObject val_3 = null;
                val_7 = val_3;
                val_3 = new UnityEngine.GameObject();
            }
            
            val_3.name = 且丌丆不且丆三三丂.丏且丐丆丒丕丕丝丆;
            return (UnityEngine.GameObject)UnityEngine.XR.iOS.丒七丄下丏东下一丈.丐世丗丆丏丒丙万丑(专下丒丁不丌丕三上:  val_3, 且丌丆不且丆三三丂:  new UnityEngine.XR.iOS.丆丂下丒丐丘上丄万() {不丂丅丁且丆东东丂 = new UnityEngine.Matrix4x4(), 丙丂丂业丂丁丌丂下 = new UnityEngine.Vector3(), 不东丈丟丅丂丝下下 = new UnityEngine.Vector3()});
        }
        public static UnityEngine.GameObject 丐世丗丆丏丒丙万丑(UnityEngine.GameObject 专下丒丁不丌丕三上, UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 且丌丆不且丆三三丂)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.XR.iOS.丒七丄下丏东下一丈.一上且丗七丒七万丗(专下丒丁不丌丕三上:  专下丒丁不丌丕三上, 丟丛万丝业世丌世丏:  new UnityEngine.Matrix4x4() {m00 = val_4, m10 = val_4, m20 = val_4, m30 = val_4, m01 = val_3, m11 = val_3, m21 = val_3, m31 = val_3, m02 = val_2, m12 = val_2, m22 = val_2, m32 = val_2, m03 = val_1, m13 = val_1, m23 = val_1, m33 = val_1}, 不东丈丟丅丂丝下下:  new UnityEngine.Vector3() {x = 且丌丆不且丆三三丂.不东丈丟丅丂丝下下.x, y = 且丌丆不且丆三三丂.不东丈丟丅丂丝下下.y, z = 且丌丆不且丆三三丂.不东丈丟丅丂丝下下.z}, 丙丂丂业丂丁丌丂下:  new UnityEngine.Vector3() {x = 且丌丆不且丆三三丂.丙丂丂业丂丁丌丂下.x, y = 且丌丆不且丆三三丂.丙丂丂业丂丁丌丂下.y, z = 且丌丆不且丆三三丂.丙丂丂业丂丁丌丂下.z});
            return (UnityEngine.GameObject)专下丒丁不丌丕三上;
        }
        public static void 一上且丗七丒七万丗(UnityEngine.GameObject 专下丒丁不丌丕三上, UnityEngine.Matrix4x4 丟丛万丝业世丌世丏, UnityEngine.Vector3 不东丈丟丅丂丝下下, UnityEngine.Vector3 丙丂丂业丂丁丌丂下)
        {
            UnityEngine.Object val_13;
            UnityEngine.Vector3 val_2 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丘丛丝七丐丁七一丐(丙丐万下万下丄上专:  new UnityEngine.Matrix4x4() {m00 = 丟丛万丝业世丌世丏.m00, m01 = 丟丛万丝业世丌世丏.m01, m02 = 丟丛万丝业世丌世丏.m02, m03 = 丟丛万丝业世丌世丏.m03});
            专下丒丁不丌丕三上.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_4 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丟丒业丐与丂丅上东(东丝丄丝丙专丘三丏:  new UnityEngine.Matrix4x4() {m00 = 丟丛万丝业世丌世丏.m00, m01 = 丟丛万丝业世丌世丏.m01, m02 = 丟丛万丝业世丌世丏.m02, m03 = 丟丛万丝业世丌世丏.m03});
            专下丒丁不丌丕三上.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = -val_4.z, w = -val_4.w};
            val_13 = 专下丒丁不丌丕三上.GetComponentInChildren<UnityEngine.MeshFilter>();
            if(val_13 == 0)
            {
                    return;
            }
            
            float val_13 = 0.1f;
            float val_9 = 不东丈丟丅丂丝下下.x * val_13;
            float val_10 = 不东丈丟丅丂丝下下.y * val_13;
            val_13 = 不东丈丟丅丂丝下下.z * val_13;
            val_13.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_13 = val_13.gameObject.transform;
            val_13.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public 丒七丄下丏东下一丈()
        {
        
        }
        private static 丒七丄下丏东下一丈()
        {
        
        }
    
    }

}
