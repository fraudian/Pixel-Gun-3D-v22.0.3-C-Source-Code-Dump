using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public static class Misc
    {
        // Methods
        public static bool BuffersAreIdentical(byte[] a, byte[] b)
        {
            var val_1;
            if(a == b)
            {
                goto label_4;
            }
            
            val_1 = 0;
            if(a == null)
            {
                    return (bool)val_1;
            }
            
            if(b == null)
            {
                    return (bool)val_1;
            }
            
            if(a.Length != b.Length)
            {
                goto label_7;
            }
            
            if(a.Length < 1)
            {
                goto label_4;
            }
            
            label_8:
            if(a[0] != b[0])
            {
                goto label_7;
            }
            
            if((0 + 1) < a.Length)
            {
                goto label_8;
            }
            
            label_4:
            val_1 = 1;
            return (bool)val_1;
            label_7:
            val_1 = 0;
            return (bool)val_1;
        }
        public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
        {
            System.Array val_5;
            string val_7;
            var val_8;
            val_5 = array;
            if(val_5 == null)
            {
                goto label_1;
            }
            
            if(((offset & 2147483648) != 0) || )
            {
                goto label_3;
            }
            
            if(((length & 2147483648) != 0) || ((array.Length - offset) < length))
            {
                goto label_5;
            }
            
            if(offset == 0)
            {
                    if(array.Length == length)
            {
                    return (System.Byte[])val_5;
            }
            
            }
            
            byte[] val_2 = new byte[0];
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  offset, destinationArray:  val_2, destinationIndex:  0, length:  length);
            val_5 = val_2;
            return (System.Byte[])val_5;
            label_3:
            val_7 = "offset";
            goto label_8;
            label_1:
            System.ArgumentNullException val_3 = null;
            val_8 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "array");
            goto label_9;
            label_5:
            System.ArgumentOutOfRangeException val_4 = null;
            val_7 = "length";
            label_8:
            val_8 = val_4;
            val_4 = new System.ArgumentOutOfRangeException(paramName:  val_7);
            label_9:
        }
        public static T CheckNotNull<T>(T value)
        {
            if(value != null)
            {
                    return (GooglePlayGames.Android.AndroidSnapshotMetadata)value;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException();
        }
        public static T CheckNotNull<T>(T value, string paramName)
        {
            if(value != null)
            {
                    return (GooglePlayGames.BasicApi.Nearby.IDiscoveryListener)value;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  paramName);
        }
    
    }

}
