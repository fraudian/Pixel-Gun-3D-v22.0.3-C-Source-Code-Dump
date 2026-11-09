using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class KeyUsage : DerBitString
    {
        // Fields
        public const int DigitalSignature = 128;
        public const int NonRepudiation = 64;
        public const int KeyEncipherment = 32;
        public const int DataEncipherment = 16;
        public const int KeyAgreement = 8;
        public const int KeyCertSign = 4;
        public const int CrlSign = 2;
        public const int EncipherOnly = 1;
        public const int DecipherOnly = 32768;
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.KeyUsage GetInstance(object obj)
        {
            object val_5 = obj;
            Org.BouncyCastle.Asn1.X509.KeyUsage val_3 = null;
            val_5 = val_3;
            val_3 = new Org.BouncyCastle.Asn1.X509.KeyUsage(usage:  Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_5 = obj));
            return (Org.BouncyCastle.Asn1.X509.KeyUsage)val_5;
        }
        public KeyUsage(int usage)
        {
        
        }
        private KeyUsage(Org.BouncyCastle.Asn1.DerBitString usage)
        {
            Org.BouncyCastle.Asn1.DerBitString val_1 = usage;
            val_1 = new Org.BouncyCastle.Asn1.DerBitString(data:  val_1, padBits:  usage);
        }
        public override string ToString()
        {
            var val_4;
            int val_5;
            byte val_6;
            System.Byte[] val_1 = this.GetBytes();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_4 = val_1;
            val_5 = val_1.Length;
            if(val_5 != 1)
            {
                goto label_2;
            }
            
            label_5:
            val_6 = val_1[0];
            return (string)"KeyUsage: 0x"("KeyUsage: 0x") + val_1[0].ToString(format:  "X")(val_1[0].ToString(format:  "X"));
            label_1:
            val_4 = 24;
            val_5 = 28563616;
            if(28563616 == 1)
            {
                goto label_5;
            }
            
            label_2:
            byte val_4 = val_1[0];
            return (string)"KeyUsage: 0x"("KeyUsage: 0x") + val_1[0].ToString(format:  "X")(val_1[0].ToString(format:  "X"));
        }
    
    }

}
