using UnityEngine;

namespace Org.BouncyCastle.Asn1.Pkcs
{
    public class ContentInfo : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;
        private readonly Org.BouncyCastle.Asn1.Asn1Encodable content;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType { get; }
        public Org.BouncyCastle.Asn1.Asn1Encodable Content { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Pkcs.ContentInfo GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.Pkcs.ContentInfo)val_3;
            }
            
            Org.BouncyCastle.Asn1.Pkcs.ContentInfo val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.Pkcs.ContentInfo(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.Pkcs.ContentInfo)val_3;
        }
        private ContentInfo(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = seq;
            val_7 = 0;
            if(val_6 != null)
            {
                    val_7 = null;
                val_7 = 0;
                val_8 = 0;
                val_6 = 0;
            }
            
            this.contentType = val_6;
            if(seq < 2)
            {
                    return;
            }
            
            val_9 = seq;
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            this.content = val_9.GetObject();
        }
        public ContentInfo(Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, Org.BouncyCastle.Asn1.Asn1Encodable content)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.contentType = contentType;
            this.content = val_1;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_ContentType()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.contentType;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable get_Content()
        {
            return (Org.BouncyCastle.Asn1.Asn1Encodable)this.content;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_6;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_6 = val_1;
            val_6[0] = this.contentType;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.content == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.BerTaggedObject val_4 = null;
            val_6 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.BerTaggedObject(tagNo:  0, obj:  this.content);
            val_3[0] = val_6;
            val_2.Add(objs:  val_3);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerSequence(v:  val_2);
        }
    
    }

}
