using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class KeyParameter : ICipherParameters
    {
        // Fields
        private readonly byte[] key;
        
        // Methods
        public KeyParameter(byte[] key)
        {
            System.Byte[] val_4;
            if(key != null)
            {
                    object val_1 = key.Clone();
                if(val_1 != null)
            {
                    val_4 = val_1;
                if(val_4 == null)
            {
                    val_4 = 0;
            }
            
            }
            
                this.key = val_4;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "key");
        }
        public KeyParameter(byte[] key, int keyOff, int keyLen)
        {
            string val_6;
            var val_7;
            if(key == null)
            {
                goto label_1;
            }
            
            if(((keyOff & 2147483648) != 0) || (key.Length < keyOff))
            {
                goto label_3;
            }
            
            if(((keyLen & 2147483648) != 0) || ((keyLen + keyOff) > key.Length))
            {
                goto label_5;
            }
            
            byte[] val_2 = new byte[0];
            this.key = val_2;
            System.Array.Copy(sourceArray:  key, sourceIndex:  keyOff, destinationArray:  val_2, destinationIndex:  0, length:  keyLen);
            return;
            label_3:
            val_6 = "keyOff";
            goto label_6;
            label_1:
            System.ArgumentNullException val_3 = null;
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "key");
            goto label_7;
            label_5:
            System.ArgumentOutOfRangeException val_4 = null;
            val_6 = "keyLen";
            label_6:
            val_7 = val_4;
            val_4 = new System.ArgumentOutOfRangeException(paramName:  val_6);
            label_7:
        }
        public byte[] GetKey()
        {
            System.Byte[] val_3;
            var val_4;
            val_3 = this.key;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
    
    }

}
