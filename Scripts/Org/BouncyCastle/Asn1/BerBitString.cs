using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerBitString : DerBitString
    {
        // Methods
        public BerBitString(byte[] data, int padBits)
        {
        
        }
        public BerBitString(byte[] data)
        {
        
        }
        public BerBitString(int namedBits)
        {
        
        }
        public BerBitString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            this.Encode(derOut:  derOut);
        }
    
    }

}
