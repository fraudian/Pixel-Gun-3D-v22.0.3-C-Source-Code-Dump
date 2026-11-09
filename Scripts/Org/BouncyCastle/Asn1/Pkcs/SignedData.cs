using UnityEngine;

namespace Org.BouncyCastle.Asn1.Pkcs
{
    public class SignedData : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerInteger version;
        private readonly Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms;
        private readonly Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo;
        private readonly Org.BouncyCastle.Asn1.Asn1Set certificates;
        private readonly Org.BouncyCastle.Asn1.Asn1Set crls;
        private readonly Org.BouncyCastle.Asn1.Asn1Set signerInfos;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerInteger Version { get; }
        public Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithms { get; }
        public Org.BouncyCastle.Asn1.Pkcs.ContentInfo ContentInfo { get; }
        public Org.BouncyCastle.Asn1.Asn1Set Certificates { get; }
        public Org.BouncyCastle.Asn1.Asn1Set Crls { get; }
        public Org.BouncyCastle.Asn1.Asn1Set SignerInfos { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Pkcs.SignedData GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.Pkcs.SignedData)val_3;
            }
            
            Org.BouncyCastle.Asn1.Pkcs.SignedData val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.Pkcs.SignedData(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.Pkcs.SignedData)val_3;
        }
        public SignedData(Org.BouncyCastle.Asn1.DerInteger _version, Org.BouncyCastle.Asn1.Asn1Set _digestAlgorithms, Org.BouncyCastle.Asn1.Pkcs.ContentInfo _contentInfo, Org.BouncyCastle.Asn1.Asn1Set _certificates, Org.BouncyCastle.Asn1.Asn1Set _crls, Org.BouncyCastle.Asn1.Asn1Set _signerInfos)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.version = _version;
            this.digestAlgorithms = val_1;
            this.contentInfo = _contentInfo;
            this.certificates = _certificates;
            this.crls = _crls;
            this.signerInfos = _signerInfos;
        }
        private SignedData(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.Asn1Set val_22;
            Org.BouncyCastle.Asn1.DerInteger val_25;
            Org.BouncyCastle.Asn1.Asn1Set val_28;
            var val_30 = 0;
            val_30 = val_30 + 1;
            bool val_2 = seq.MoveNext();
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_25 = seq;
            if(val_25.Current != null)
            {
                    val_25 = 0;
            }
            
            this.version = val_25;
            var val_32 = 0;
            val_32 = val_32 + 1;
            bool val_8 = seq.MoveNext();
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_28 = seq;
            if(val_28.Current != null)
            {
                    val_28 = 0;
            }
            
            this.digestAlgorithms = val_28;
            var val_34 = 0;
            val_34 = val_34 + 1;
            bool val_13 = seq.MoveNext();
            var val_35 = 0;
            val_35 = val_35 + 1;
            this.contentInfo = Org.BouncyCastle.Asn1.Pkcs.ContentInfo.GetInstance(obj:  seq.Current);
            goto label_55;
            label_61:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_22 = seq.Current;
            if(val_22 != null)
            {
                    val_22 = 0;
            }
            
            this.signerInfos = val_22;
            label_55:
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(seq.MoveNext() == true)
            {
                goto label_61;
            }
        
        }
        public Org.BouncyCastle.Asn1.DerInteger get_Version()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.version;
        }
        public Org.BouncyCastle.Asn1.Asn1Set get_DigestAlgorithms()
        {
            return (Org.BouncyCastle.Asn1.Asn1Set)this.digestAlgorithms;
        }
        public Org.BouncyCastle.Asn1.Pkcs.ContentInfo get_ContentInfo()
        {
            return (Org.BouncyCastle.Asn1.Pkcs.ContentInfo)this.contentInfo;
        }
        public Org.BouncyCastle.Asn1.Asn1Set get_Certificates()
        {
            return (Org.BouncyCastle.Asn1.Asn1Set)this.certificates;
        }
        public Org.BouncyCastle.Asn1.Asn1Set get_Crls()
        {
            return (Org.BouncyCastle.Asn1.Asn1Set)this.crls;
        }
        public Org.BouncyCastle.Asn1.Asn1Set get_SignerInfos()
        {
            return (Org.BouncyCastle.Asn1.Asn1Set)this.signerInfos;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Set val_9;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[3];
            val_1[0] = this.version;
            val_1[1] = this.digestAlgorithms;
            val_1[2] = this.contentInfo;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.certificates != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_9 = this.certificates;
                val_3[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  0, obj:  val_9);
                val_2.Add(objs:  val_3);
            }
            
            if(this.crls != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_5 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_9 = this.crls;
                val_5[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  1, obj:  val_9);
                val_2.Add(objs:  val_5);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_7 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_7[0] = this.signerInfos;
            val_2.Add(objs:  val_7);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerSequence(v:  val_2);
        }
    
    }

}
