using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class CrlReason : DerEnumerated
    {
        // Fields
        public const int Unspecified = 0;
        public const int KeyCompromise = 1;
        public const int CACompromise = 2;
        public const int AffiliationChanged = 3;
        public const int Superseded = 4;
        public const int CessationOfOperation = 5;
        public const int CertificateHold = 6;
        public const int RemoveFromCrl = 8;
        public const int PrivilegeWithdrawn = 9;
        public const int AACompromise = 10;
        private static readonly string[] ReasonString;
        
        // Methods
        public CrlReason(int reason)
        {
        
        }
        public CrlReason(Org.BouncyCastle.Asn1.DerEnumerated reason)
        {
            int val_2 = reason.Value.IntValue;
        }
        public override string ToString()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = this.Value.IntValue;
            if(val_4 > 10)
            {
                    val_5 = "Invalid";
                return "CrlReason: "("CrlReason: ") + null;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = (long)val_4;
            System.String[] val_3 = Org.BouncyCastle.Asn1.X509.CrlReason.ReasonString + (((long)(int)(val_2)) << 3);
            return "CrlReason: "("CrlReason: ") + null;
        }
        private static CrlReason()
        {
            string[] val_1 = new string[11];
            val_1[0] = "Unspecified";
            val_1[1] = "KeyCompromise";
            val_1[2] = "CACompromise";
            val_1[3] = "AffiliationChanged";
            val_1[4] = "Superseded";
            val_1[5] = "CessationOfOperation";
            val_1[6] = "CertificateHold";
            val_1[7] = "Unknown";
            val_1[8] = "RemoveFromCrl";
            val_1[9] = "PrivilegeWithdrawn";
            val_1[10] = "AACompromise";
            Org.BouncyCastle.Asn1.X509.CrlReason.ReasonString = val_1;
        }
    
    }

}
