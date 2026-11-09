using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class ReasonFlags : DerBitString
    {
        // Fields
        public const int Unused = 128;
        public const int KeyCompromise = 64;
        public const int CACompromise = 32;
        public const int AffiliationChanged = 16;
        public const int Superseded = 8;
        public const int CessationOfOperation = 4;
        public const int CertificateHold = 2;
        public const int PrivilegeWithdrawn = 1;
        public const int AACompromise = 32768;
        
        // Methods
        public ReasonFlags(int reasons)
        {
        
        }
        public ReasonFlags(Org.BouncyCastle.Asn1.DerBitString reasons)
        {
            Org.BouncyCastle.Asn1.DerBitString val_1 = reasons;
            val_1 = new Org.BouncyCastle.Asn1.DerBitString(data:  val_1, padBits:  reasons);
        }
    
    }

}
