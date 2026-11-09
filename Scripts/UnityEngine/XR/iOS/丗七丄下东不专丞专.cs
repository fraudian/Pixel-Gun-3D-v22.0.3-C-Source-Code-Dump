using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class 丗七丄下东不专丞专
    {
        // Methods
        public static UnityEngine.Vector3 丘丛丝七丐丁七一丐(UnityEngine.Matrix4x4 丙丐万下万下丄上专)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = -val_1.z};
        }
        public static UnityEngine.Quaternion 下丞丙丄三万丛世丑(UnityEngine.Matrix4x4 丙丐万下万下丄上专)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丟丒业丐与丂丅上东(东丝丄丝丙专丘三丏:  new UnityEngine.Matrix4x4() {m00 = 丙丐万下万下丄上专.m00, m01 = 丙丐万下万下丄上专.m01, m02 = 丙丐万下万下丄上专.m02, m03 = 丙丐万下万下丄上专.m03});
            return new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = -val_1.z, w = -val_1.w};
        }
        private static UnityEngine.Quaternion 丟丒业丐与丂丅上东(UnityEngine.Matrix4x4 东丝丄丝丙专丘三丏)
        {
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_1 = 东丝丄丝丙专丘三丏.Item[0, 0];
            float val_34 = 1f;
            float val_4 = val_1 + val_34;
            val_4 = val_4 + 东丝丄丝丙专丘三丏.Item[1, 1];
            if(val_1 >= _TYPE_MAX_)
            {
                    val_33 = UnityEngine.Mathf.Max(a:  0f, b:  val_4 + 东丝丄丝丙专丘三丏.Item[2, 2]);
            }
            
            float val_7 = 东丝丄丝丙专丘三丏.Item[0, 0];
            float val_10 = val_7 + val_34;
            val_10 = val_10 - 东丝丄丝丙专丘三丏.Item[1, 1];
            val_10 = val_10 - 东丝丄丝丙专丘三丏.Item[2, 2];
            if(val_7 >= _TYPE_MAX_)
            {
                    val_34 = UnityEngine.Mathf.Max(a:  0f, b:  val_10);
            }
            
            float val_33 = 东丝丄丝丙专丘三丏.Item[1, 1];
            float val_15 = val_34 - 东丝丄丝丙专丘三丏.Item[0, 0];
            val_15 = val_15 + val_33;
            val_15 = val_15 - 东丝丄丝丙专丘三丏.Item[2, 2];
            float val_16 = UnityEngine.Mathf.Max(a:  0f, b:  val_15);
            if(val_16 >= _TYPE_MAX_)
            {
                    val_35 = val_16;
            }
            
            val_33 = val_33 * 0.5f;
            float val_17 = val_34 * 0.5f;
            val_33 = val_35 * 0.5f;
            float val_21 = val_34 - 东丝丄丝丙专丘三丏.Item[0, 0];
            val_21 = val_21 - 东丝丄丝丙专丘三丏.Item[1, 1];
            val_21 = val_21 + 东丝丄丝丙专丘三丏.Item[2, 2];
            float val_22 = UnityEngine.Mathf.Max(a:  0f, b:  val_21);
            if(val_22 >= _TYPE_MAX_)
            {
                    val_36 = val_22;
            }
            
            val_34 = val_36 * 0.5f;
            float val_35 = 东丝丄丝丙专丘三丏.Item[2, 1];
            float val_24 = 东丝丄丝丙专丘三丏.Item[1, 2];
            val_24 = val_35 - val_24;
            val_24 = val_17 * val_24;
            val_35 = val_17 * (UnityEngine.Mathf.Sign(f:  val_24));
            float val_36 = 东丝丄丝丙专丘三丏.Item[0, 2];
            float val_27 = 东丝丄丝丙专丘三丏.Item[2, 0];
            val_27 = val_36 - val_27;
            val_27 = val_33 * val_27;
            val_36 = val_33 * (UnityEngine.Mathf.Sign(f:  val_27));
            float val_30 = 东丝丄丝丙专丘三丏.Item[0, 1];
            val_30 = 东丝丄丝丙专丘三丏.Item[1, 0] - val_30;
            val_30 = val_34 * val_30;
            return new UnityEngine.Quaternion() {x = val_35, y = val_36, z = val_34 * (UnityEngine.Mathf.Sign(f:  val_30)), w = val_33};
        }
        public 丗七丄下东不专丞专()
        {
        
        }
    
    }

}
