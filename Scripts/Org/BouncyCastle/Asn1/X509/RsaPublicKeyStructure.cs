using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class RsaPublicKeyStructure : Asn1Encodable
    {
        // Fields
        private Org.BouncyCastle.Math.BigInteger modulus;
        private Org.BouncyCastle.Math.BigInteger publicExponent;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Modulus { get; }
        public Org.BouncyCastle.Math.BigInteger PublicExponent { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure() = new Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure();
            return (Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure)val_10;
        }
        public RsaPublicKeyStructure(Org.BouncyCastle.Math.BigInteger modulus, Org.BouncyCastle.Math.BigInteger publicExponent)
        {
            string val_6;
            var val_7;
            string val_9;
            string val_10;
            if(modulus == null)
            {
                goto label_1;
            }
            
            if(publicExponent == null)
            {
                goto label_2;
            }
            
            if(modulus.SignValue <= 0)
            {
                goto label_3;
            }
            
            if(publicExponent.SignValue <= 0)
            {
                goto label_4;
            }
            
            this.modulus = modulus;
            this.publicExponent = publicExponent;
            return;
            label_1:
            val_6 = "modulus";
            goto label_5;
            label_2:
            System.ArgumentNullException val_3 = null;
            val_6 = "publicExponent";
            label_5:
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  val_6);
            goto label_6;
            label_3:
            val_9 = "Not a valid RSA modulus";
            val_10 = "modulus";
            goto label_7;
            label_4:
            System.ArgumentException val_4 = null;
            val_9 = "Not a valid RSA public exponent";
            val_10 = "publicExponent";
            label_7:
            val_7 = val_4;
            val_4 = new System.ArgumentException(message:  val_9, paramName:  val_10);
            label_6:
        }
        private RsaPublicKeyStructure(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.modulus = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq).PositiveValue;
                this.publicExponent = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq).PositiveValue;
                return;
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + seq);
        }
        public Org.BouncyCastle.Math.BigInteger get_Modulus()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.modulus;
        }
        public Org.BouncyCastle.Math.BigInteger get_PublicExponent()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.publicExponent;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            Org.BouncyCastle.Asn1.DerInteger val_2 = new Org.BouncyCastle.Asn1.DerInteger(value:  this.modulus);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new Org.BouncyCastle.Asn1.DerInteger(value:  this.publicExponent);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
