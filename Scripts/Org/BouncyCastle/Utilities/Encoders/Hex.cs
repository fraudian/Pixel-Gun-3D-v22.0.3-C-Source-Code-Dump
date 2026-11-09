using UnityEngine;

namespace Org.BouncyCastle.Utilities.Encoders
{
    public sealed class Hex
    {
        // Fields
        private static readonly Org.BouncyCastle.Utilities.Encoders.IEncoder encoder;
        
        // Methods
        private Hex()
        {
        
        }
        public static string ToHexString(byte[] data)
        {
            return Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  data, off:  0, length:  data.Length);
        }
        public static string ToHexString(byte[] data, int off, int length)
        {
            return Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Encode(data:  data, off:  off, length:  length));
        }
        public static byte[] Encode(byte[] data)
        {
            return Org.BouncyCastle.Utilities.Encoders.Hex.Encode(data:  data, off:  0, length:  data.Length);
        }
        public static byte[] Encode(byte[] data, int off, int length)
        {
            var val_4;
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream(capacity:  length << 1);
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_4 = Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data:  data, off:  off, length:  length, outStream:  val_2);
            if(val_2 == null)
            {
                
            }
        
        }
        public static int Encode(byte[] data, System.IO.Stream outStream)
        {
            var val_2 = null;
            if(data == null)
            {
                goto label_3;
            }
            
            label_10:
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data:  data, off:  0, length:  data.Length, outStream:  outStream);
            label_3:
            if(Org.BouncyCastle.Utilities.Encoders.Hex.encoder != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public static int Encode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            var val_2 = null;
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Encode(data:  data, off:  off, length:  length, outStream:  outStream);
        }
        public static byte[] Decode(byte[] data)
        {
            var val_6;
            System.IO.MemoryStream val_4 = null;
            int val_7 = data.Length;
            val_7 = ((val_7 + 1) < 0) ? (val_7 + 2) : (val_7 + 1);
            val_4 = new System.IO.MemoryStream(capacity:  val_7 >> 1);
            val_6 = null;
            val_6 = null;
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_6 = Org.BouncyCastle.Utilities.Encoders.Hex.encoder.Decode(data:  data, off:  0, length:  data.Length, outStream:  val_4);
            if(val_4 == null)
            {
                
            }
        
        }
        public static byte[] Decode(string data)
        {
            var val_8;
            int val_1 = data.Length;
            System.IO.MemoryStream val_6 = new System.IO.MemoryStream(capacity:  (((val_1 + 1) < 0) ? (val_1 + 2) : (val_1 + 1)) >> 1);
            val_8 = null;
            val_8 = null;
            var val_9 = 0;
            val_9 = val_9 + 1;
            int val_8 = Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeString(data:  data, outStream:  val_6);
            if(val_6 == null)
            {
                
            }
        
        }
        public static int Decode(string data, System.IO.Stream outStream)
        {
            var val_2 = null;
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Org.BouncyCastle.Utilities.Encoders.Hex.encoder.DecodeString(data:  data, outStream:  outStream);
        }
        private static Hex()
        {
            Org.BouncyCastle.Utilities.Encoders.Hex.encoder = new Org.BouncyCastle.Utilities.Encoders.HexEncoder();
        }
    
    }

}
