using UnityEngine;

namespace Org.BouncyCastle.Asn1.Ocsp
{
    public class OcspResponse : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus;
        private readonly Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes;
        
        // Properties
        public Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus ResponseStatus { get; }
        public Org.BouncyCastle.Asn1.Ocsp.ResponseBytes ResponseBytes { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.Ocsp.OcspResponse)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.Ocsp.OcspResponse() = new Org.BouncyCastle.Asn1.Ocsp.OcspResponse(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.Ocsp.OcspResponse();
            return (Org.BouncyCastle.Asn1.Ocsp.OcspResponse)val_10;
        }
        public OcspResponse(Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus, Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(responseStatus != null)
            {
                    this.responseStatus = responseStatus;
                this.responseBytes = val_1;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "responseStatus");
        }
        private OcspResponse(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_7;
            this.responseStatus = new Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus(value:  Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(obj:  seq));
            if(seq != 2)
            {
                    return;
            }
            
            val_7 = seq;
            if(val_7 != null)
            {
                    val_7 = 0;
            }
            
            this.responseBytes = Org.BouncyCastle.Asn1.Ocsp.ResponseBytes.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_7, explicitly:  true));
        }
        public Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus get_ResponseStatus()
        {
            return (Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus)this.responseStatus;
        }
        public Org.BouncyCastle.Asn1.Ocsp.ResponseBytes get_ResponseBytes()
        {
            return (Org.BouncyCastle.Asn1.Ocsp.ResponseBytes)this.responseBytes;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_6;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_6 = val_1;
            val_6[0] = this.responseStatus;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.responseBytes == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerTaggedObject val_4 = null;
            val_6 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  0, obj:  this.responseBytes);
            val_3[0] = val_6;
            val_2.Add(objs:  val_3);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
    
    }

}
