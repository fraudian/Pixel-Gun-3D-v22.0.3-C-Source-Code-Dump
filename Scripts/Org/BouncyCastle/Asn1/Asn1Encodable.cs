using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Encodable : IAsn1Convertible
    {
        // Fields
        public const string Der = "DER";
        public const string Ber = "BER";
        
        // Methods
        public byte[] GetEncoded()
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Asn1.Asn1OutputStream val_2 = new Org.BouncyCastle.Asn1.Asn1OutputStream(s:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        public byte[] GetEncoded(string encoding)
        {
            if((encoding.Equals(value:  "DER")) == false)
            {
                    return this.GetEncoded();
            }
            
            Org.BouncyCastle.Asn1.DerOutputStream val_3 = new Org.BouncyCastle.Asn1.DerOutputStream(s:  new System.IO.MemoryStream());
            this = ???;
            goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
        }
        public byte[] GetDerEncoded()
        {
            return (System.Byte[])this.GetEncoded(encoding:  "DER");
        }
        public sealed override int GetHashCode()
        {
            if(this == null)
            {
                
            }
        
        }
        public sealed override bool Equals(object obj)
        {
            var val_7;
            var val_8;
            val_7 = this;
            if(val_7 == obj)
            {
                goto label_7;
            }
            
            val_8 = obj;
            if(val_8 == null)
            {
                    return (bool)val_8;
            }
            
            val_7 = val_7;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(val_7 == val_8.ToAsn1Object())
            {
                goto label_7;
            }
            
            val_7 = ???;
            goto typeof(Org.BouncyCastle.Asn1.Asn1Encodable).__il2cppRuntimeField_198;
            label_7:
            val_8 = 1;
            return (bool)val_8;
        }
        public abstract Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object(); // 0
        protected Asn1Encodable()
        {
        
        }
    
    }

}
