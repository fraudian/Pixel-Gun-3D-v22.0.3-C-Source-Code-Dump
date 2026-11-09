using UnityEngine;

namespace Org.BouncyCastle.Asn1.Pkcs
{
    public class RsassaPssParameters : Asn1Encodable
    {
        // Fields
        private Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;
        private Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm;
        private Org.BouncyCastle.Asn1.DerInteger saltLength;
        private Org.BouncyCastle.Asn1.DerInteger trailerField;
        public static readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultHashAlgorithm;
        public static readonly Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultMaskGenFunction;
        public static readonly Org.BouncyCastle.Asn1.DerInteger DefaultSaltLength;
        public static readonly Org.BouncyCastle.Asn1.DerInteger DefaultTrailerField;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm { get; }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MaskGenAlgorithm { get; }
        public Org.BouncyCastle.Asn1.DerInteger SaltLength { get; }
        public Org.BouncyCastle.Asn1.DerInteger TrailerField { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters() = new Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters();
            return (Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)val_10;
        }
        public RsassaPssParameters()
        {
            null = null;
            this.hashAlgorithm = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm;
            this.maskGenAlgorithm = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction;
            this.saltLength = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength;
            this.trailerField = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField;
        }
        public RsassaPssParameters(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm, Org.BouncyCastle.Asn1.DerInteger saltLength, Org.BouncyCastle.Asn1.DerInteger trailerField)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.hashAlgorithm = hashAlgorithm;
            this.maskGenAlgorithm = val_1;
            this.saltLength = saltLength;
            this.trailerField = trailerField;
        }
        public RsassaPssParameters(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_11;
            var val_12;
            var val_13;
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_14;
            val_11 = 0;
            val_12 = null;
            val_12 = null;
            val_13 = 0;
            this.hashAlgorithm = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm;
            this.maskGenAlgorithm = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction;
            this.saltLength = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength;
            this.trailerField = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField;
            goto label_3;
            label_12:
            val_14 = seq;
            val_14 = 0;
            if(val_14.TagNo > 3)
            {
                goto label_7;
            }
            
            var val_11 = 106049108 + (val_3) << 2;
            val_11 = val_11 + 106049108;
            goto (106049108 + (val_3) << 2 + 106049108);
            label_3:
            if( != seq)
            {
                goto label_12;
            }
            
            return;
            label_7:
            System.ArgumentException val_10 = new System.ArgumentException(message:  "unknown tag");
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_HashAlgorithm()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.hashAlgorithm;
        }
        public Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier get_MaskGenAlgorithm()
        {
            return (Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.maskGenAlgorithm;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_SaltLength()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.saltLength;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_TrailerField()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.trailerField;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            var val_16;
            var val_17;
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            Org.BouncyCastle.Asn1.DerInteger val_24;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            val_16 = null;
            val_16 = null;
            val_17 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((this.hashAlgorithm.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm)) != true)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_4 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_18 = this.hashAlgorithm;
                val_4[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  0, obj:  val_18);
                val_17 = 0;
                val_2.Add(objs:  val_4);
            }
            
            val_19 = null;
            val_19 = null;
            val_20 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((this.maskGenAlgorithm.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction)) != true)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_7 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_18 = this.maskGenAlgorithm;
                val_7[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  1, obj:  val_18);
                val_20 = 0;
                val_2.Add(objs:  val_7);
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((this.saltLength.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength)) != true)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_10 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_18 = this.saltLength;
                val_10[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  2, obj:  val_18);
                val_22 = 0;
                val_2.Add(objs:  val_10);
            }
            
            val_23 = null;
            val_24 = this.trailerField;
            val_23 = null;
            if((val_24.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField)) == true)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_13 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerTaggedObject val_14 = null;
            val_24 = val_14;
            val_14 = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  3, obj:  this.trailerField);
            val_13[0] = val_24;
            val_2.Add(objs:  val_13);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
        private static RsassaPssParameters()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            .algorithm = Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1;
            .parameters = Org.BouncyCastle.Asn1.DerNull.Instance;
            Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier();
            val_7 = null;
            val_7 = null;
            .algorithm = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1;
            .parameters = Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultHashAlgorithm;
            Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultMaskGenFunction = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier();
            Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultSaltLength = new Org.BouncyCastle.Asn1.DerInteger(value:  20);
            Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField = new Org.BouncyCastle.Asn1.DerInteger(value:  1);
        }
    
    }

}
