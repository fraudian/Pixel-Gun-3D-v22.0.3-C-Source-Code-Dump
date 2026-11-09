using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerOctetString : Asn1OctetString
    {
        // Methods
        public DerOctetString(byte[] str)
        {
        
        }
        public DerOctetString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  4, bytes:  X19);
        }
        internal static void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut, byte[] bytes, int offset, int length)
        {
            derOut.WriteByte(value:  4);
            derOut.WriteLength(length:  length);
            derOut.Write(buffer:  bytes, offset:  offset, count:  length);
        }
    
    }

}
