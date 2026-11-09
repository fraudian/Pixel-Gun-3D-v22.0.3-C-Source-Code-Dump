using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class SerializableVector4
    {
        // Fields
        public float x;
        public float y;
        public float z;
        public float w;
        
        // Methods
        public SerializableVector4(float 不万丁丅丙与丙丛且, float 业丟世且三丏世丟上, float 丆丈丄专与丗丈丁丑, float 不且丒丈丆丕丄与丞)
        {
            this.x = 不万丁丅丙与丙丛且;
            this.y = 业丟世且三丏世丟上;
            this.z = 丆丈丄专与丗丈丁丑;
            this.w = 不且丒丈丆丕丄与丞;
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.x != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.x == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.x;
            val_1[1] = this.y;
            val_1[2] = this.z;
            val_1[3] = this.w;
            return (string)System.String.Format(format:  "[{0}, {1}, {2}, {3}]", args:  val_1);
        }
        public static UnityEngine.Vector4 万丒丌丕万丏不丈世(ARKitPlugin.Utils.SerializableVector4 上下且万丌下丆丞丅)
        {
            float val_1;
            float val_2;
            float val_3;
            if(上下且万丌下丆丞丅 != null)
            {
                    val_1 = 上下且万丌下丆丞丅.x;
                val_2 = 上下且万丌下丆丞丅.y;
                val_3 = 上下且万丌下丆丞丅.z;
            }
            else
            {
                    val_1 = 1.68059E-38f;
                val_2 = 1.401298E-45f;
                val_3 = 6.606506E-38f;
            }
            
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        public static ARKitPlugin.Utils.SerializableVector4 万丒丌丕万丏不丈世(UnityEngine.Vector4 上下且万丌下丆丞丅)
        {
            .x = 上下且万丌下丆丞丅.x;
            .y = 上下且万丌下丆丞丅.y;
            .z = 上下且万丌下丆丞丅.z;
            .w = 上下且万丌下丆丞丅.w;
            return (ARKitPlugin.Utils.SerializableVector4)new ARKitPlugin.Utils.SerializableVector4();
        }
    
    }

}
