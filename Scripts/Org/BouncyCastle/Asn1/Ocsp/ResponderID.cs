using UnityEngine;

namespace Org.BouncyCastle.Asn1.Ocsp
{
    public class ResponderID : Asn1Encodable, IAsn1Choice
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1Encodable id;
        
        // Properties
        public virtual Org.BouncyCastle.Asn1.X509.X509Name Name { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Ocsp.ResponderID GetInstance(object obj)
        {
            object val_12;
            var val_13;
            val_12 = obj;
            if(val_12 == null)
            {
                    return (Org.BouncyCastle.Asn1.Ocsp.ResponderID);
            }
            
            Org.BouncyCastle.Asn1.Ocsp.ResponderID val_4 = null;
            val_13 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.Ocsp.ResponderID(id:  Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  val_12));
            return (Org.BouncyCastle.Asn1.Ocsp.ResponderID);
        }
        public ResponderID(Org.BouncyCastle.Asn1.Asn1OctetString id)
        {
            if(id != null)
            {
                    this.id = id;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "id");
        }
        public ResponderID(Org.BouncyCastle.Asn1.X509.X509Name id)
        {
            if(id != null)
            {
                    this.id = id;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "id");
        }
        public static Org.BouncyCastle.Asn1.Ocsp.ResponderID GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            return Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(obj:  obj.GetObject());
        }
        public virtual byte[] GetKeyHash()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_2 = this.id;
            if(val_2 == null)
            {
                    return (System.Byte[])val_2;
            }
            
            val_2 = 0;
            return (System.Byte[])val_2;
        }
        public virtual Org.BouncyCastle.Asn1.X509.X509Name get_Name()
        {
            return Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  this.id);
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.DerTaggedObject val_3 = new Org.BouncyCastle.Asn1.DerTaggedObject();
             = new Org.BouncyCastle.Asn1.Asn1TaggedObject(explicitly:  true, tagNo:  1, obj:  this.id);
            return (Org.BouncyCastle.Asn1.Asn1Object);
        }
    
    }

}
