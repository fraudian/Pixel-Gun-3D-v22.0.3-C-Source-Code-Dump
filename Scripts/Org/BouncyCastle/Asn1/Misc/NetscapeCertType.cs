using UnityEngine;

namespace Org.BouncyCastle.Asn1.Misc
{
    public class NetscapeCertType : DerBitString
    {
        // Fields
        public const int SslClient = 128;
        public const int SslServer = 64;
        public const int Smime = 32;
        public const int ObjectSigning = 16;
        public const int Reserved = 8;
        public const int SslCA = 4;
        public const int SmimeCA = 2;
        public const int ObjectSigningCA = 1;
        
        // Methods
        public NetscapeCertType(int usage)
        {
        
        }
        public NetscapeCertType(Org.BouncyCastle.Asn1.DerBitString usage)
        {
            Org.BouncyCastle.Asn1.DerBitString val_1 = usage;
            val_1 = new Org.BouncyCastle.Asn1.DerBitString(data:  val_1, padBits:  usage);
        }
        public override string ToString()
        {
            return (string)"NetscapeCertType: 0x"("NetscapeCertType: 0x") + this.GetBytes()[0].ToString(format:  "X")(this.GetBytes()[0].ToString(format:  "X"));
        }
    
    }

}
