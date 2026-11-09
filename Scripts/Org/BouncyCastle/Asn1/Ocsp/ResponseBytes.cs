using UnityEngine;

namespace Org.BouncyCastle.Asn1.Ocsp
{
    public class ResponseBytes : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier responseType;
        private readonly Org.BouncyCastle.Asn1.Asn1OctetString response;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerObjectIdentifier ResponseType { get; }
        public Org.BouncyCastle.Asn1.Asn1OctetString Response { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Ocsp.ResponseBytes GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.Ocsp.ResponseBytes.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.Ocsp.ResponseBytes GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.Ocsp.ResponseBytes)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.Ocsp.ResponseBytes() = new Org.BouncyCastle.Asn1.Ocsp.ResponseBytes(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.Ocsp.ResponseBytes();
            return (Org.BouncyCastle.Asn1.Ocsp.ResponseBytes)val_10;
        }
        public ResponseBytes(Org.BouncyCastle.Asn1.DerObjectIdentifier responseType, Org.BouncyCastle.Asn1.Asn1OctetString response)
        {
            string val_4;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(responseType == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.responseType = responseType;
            this.response = val_1;
            return;
            label_1:
            val_4 = "responseType";
            goto label_3;
            label_2:
            val_4 = "response";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        private ResponseBytes(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            if(seq == 2)
            {
                    this.responseType = Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  seq);
                this.response = Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Wrong number of elements in sequence", paramName:  "seq");
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_ResponseType()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.responseType;
        }
        public Org.BouncyCastle.Asn1.Asn1OctetString get_Response()
        {
            return (Org.BouncyCastle.Asn1.Asn1OctetString)this.response;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.responseType != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.responseType == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.responseType;
            val_1[1] = this.response;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
