using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Object : Asn1Encodable
    {
        // Methods
        public static Org.BouncyCastle.Asn1.Asn1Object FromByteArray(byte[] data)
        {
            var val_6;
            var val_7;
            new System.IO.MemoryStream() = new System.IO.MemoryStream(buffer:  data, writable:  false);
            new Org.BouncyCastle.Asn1.Asn1InputStream() = new Org.BouncyCastle.Asn1.Asn1InputStream(inputStream:  new System.IO.MemoryStream(), limit:  data.Length);
            if(new System.IO.MemoryStream() == new System.IO.MemoryStream())
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.Asn1InputStream().ReadObject();
            }
            
            new System.IO.IOException() = new System.IO.IOException(message:  "extra data found after object");
            val_6 = new System.IO.IOException();
            if(0 == 1)
            {
                    val_7 = val_6;
                if((null & 1) != 0)
            {
                    System.IO.IOException val_5 = null;
                val_7 = val_5;
                val_5 = new System.IO.IOException(message:  "cannot recognise object in byte array");
            }
            
                mem[8] = null;
                val_6 = 8;
            }
        
        }
        public static Org.BouncyCastle.Asn1.Asn1Object FromStream(System.IO.Stream inStr)
        {
            new Org.BouncyCastle.Asn1.Asn1InputStream() = new Org.BouncyCastle.Asn1.Asn1InputStream(inputStream:  inStr, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  inStr));
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.Asn1InputStream().ReadObject();
        }
        public sealed override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this;
        }
        internal abstract void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut); // 0
        protected abstract bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object); // 0
        protected abstract int Asn1GetHashCode(); // 0
        internal bool CallAsn1Equals(Org.BouncyCastle.Asn1.Asn1Object obj)
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Object).__il2cppRuntimeField_198;
        }
        internal int CallAsn1GetHashCode()
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Object).__il2cppRuntimeField_1A8;
        }
        protected Asn1Object()
        {
            val_1 = new System.Object();
        }
    
    }

}
