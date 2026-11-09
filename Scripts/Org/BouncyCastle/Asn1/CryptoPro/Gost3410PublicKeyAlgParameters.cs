using UnityEngine;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
    public class Gost3410PublicKeyAlgParameters : Asn1Encodable
    {
        // Fields
        private Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
        private Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet;
        private Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier DigestParamSet { get; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionParamSet { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters() = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters();
            return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410PublicKeyAlgParameters)val_10;
        }
        public Gost3410PublicKeyAlgParameters(Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet)
        {
        
        }
        public Gost3410PublicKeyAlgParameters(Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet, Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet)
        {
            string val_4;
            this = new System.Object();
            if(publicKeyParamSet == null)
            {
                goto label_1;
            }
            
            if(digestParamSet == null)
            {
                goto label_2;
            }
            
            this.publicKeyParamSet = publicKeyParamSet;
            this.digestParamSet = digestParamSet;
            this.encryptionParamSet = encryptionParamSet;
            return;
            label_1:
            val_4 = "publicKeyParamSet";
            goto label_3;
            label_2:
            val_4 = "digestParamSet";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        public Gost3410PublicKeyAlgParameters(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_6;
            var val_7;
            var val_8;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_9;
            var val_10;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_11;
            this = new System.Object();
            val_6 = seq;
            if(val_6 != null)
            {
                    val_7 = 0;
                val_6 = 0;
            }
            
            this.publicKeyParamSet = val_6;
            val_8 = 1;
            val_9 = seq;
            if(val_9 != null)
            {
                    val_8 = null;
                val_8 = 0;
                val_10 = 0;
                val_9 = 0;
            }
            
            this.digestParamSet = val_9;
            if(seq < 3)
            {
                    return;
            }
            
            val_11 = seq;
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            this.encryptionParamSet = val_11;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_PublicKeyParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.publicKeyParamSet;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_DigestParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.digestParamSet;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_EncryptionParamSet()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.encryptionParamSet;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            val_1[0] = this.publicKeyParamSet;
            val_1[1] = this.digestParamSet;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.encryptionParamSet == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_3[0] = this.encryptionParamSet;
            val_2.Add(objs:  val_3);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
    
    }

}
