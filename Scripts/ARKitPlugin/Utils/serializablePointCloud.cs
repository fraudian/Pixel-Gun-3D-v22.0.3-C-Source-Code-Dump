using UnityEngine;

namespace ARKitPlugin.Utils
{
    [Serializable]
    public class serializablePointCloud
    {
        // Fields
        public byte[] pointCloudData;
        
        // Methods
        public serializablePointCloud(byte[] 丌丕丑专三丅丞业丕)
        {
            this.pointCloudData = 丌丕丑专三丅丞业丕;
        }
        public static ARKitPlugin.Utils.serializablePointCloud 万丒丌丕万丏不丈世(UnityEngine.Vector3[] 丄一丗三丏业丙专丗)
        {
            System.Array val_8;
            var val_9;
            if(丄一丗三丏业丙专丗 != null)
            {
                    int val_14 = 丄一丗三丏业丙专丗.Length;
                val_14 = val_14 + (val_14 << 1);
                int val_1 = val_14 << 2;
                byte[] val_2 = new byte[0];
                val_8 = val_2;
                if(丄一丗三丏业丙专丗.Length >= 1)
            {
                    var val_15 = 8;
                do
            {
                var val_3 = 丄一丗三丏业丙专丗 + (0 * 12);
                System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  (0 * 12) + 丄一丗三丏业丙专丗 + 32), srcOffset:  0, dst:  val_2, dstOffset:  val_15 - 8, count:  4);
                var val_6 = 丄一丗三丏业丙专丗 + (0 * 12);
                System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  (0 * 12) + 丄一丗三丏业丙专丗 + 36), srcOffset:  0, dst:  val_2, dstOffset:  val_15 - 4, count:  4);
                var val_9 = 丄一丗三丏业丙专丗 + (0 * 12);
                System.Buffer.BlockCopy(src:  System.BitConverter.GetBytes(value:  (0 * 12) + 丄一丗三丏业丙专丗 + 40), srcOffset:  0, dst:  val_2, dstOffset:  8, count:  4);
                val_15 = val_15 + 12;
            }
            while((0 + 1) < 丄一丗三丏业丙专丗.Length);
            
            }
            
                ARKitPlugin.Utils.serializablePointCloud val_12 = null;
                val_9 = val_12;
                val_12 = new ARKitPlugin.Utils.serializablePointCloud();
            }
            else
            {
                    ARKitPlugin.Utils.serializablePointCloud val_13 = null;
                val_9 = val_13;
                val_13 = new ARKitPlugin.Utils.serializablePointCloud();
                val_8 = 0;
            }
            
            .pointCloudData = val_8;
            return (ARKitPlugin.Utils.serializablePointCloud)val_9;
        }
        public static UnityEngine.Vector3[] 万丒丌丕万丏不丈世(ARKitPlugin.Utils.serializablePointCloud 三丑丒丌丛丆丝下万)
        {
            var val_8;
            if(三丑丒丌丛丆丝下万.pointCloudData != null)
            {
                    int val_1 = 三丑丒丌丛丆丝下万.pointCloudData.Length * 715827883;
                val_1 = val_1 >> 33;
                val_8 = new UnityEngine.Vector3[0];
                if(三丑丒丌丛丆丝下万.pointCloudData.Length < 12)
            {
                    return (UnityEngine.Vector3[])val_8;
            }
            
                var val_11 = 0;
                var val_10 = 0;
                do
            {
                mem2[0] = System.BitConverter.ToSingle(value:  三丑丒丌丛丆丝下万.pointCloudData, startIndex:  0);
                mem2[0] = System.BitConverter.ToSingle(value:  三丑丒丌丛丆丝下万.pointCloudData, startIndex:  val_11 + 4);
                val_10 = val_10 + 1;
                val_11 = val_11 + 12;
                mem2[0] = System.BitConverter.ToSingle(value:  三丑丒丌丛丆丝下万.pointCloudData, startIndex:  val_11 + 8);
            }
            while((val_1 + (val_1 >> 63)) != val_10);
            
                return (UnityEngine.Vector3[])val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Vector3[])val_8;
        }
    
    }

}
