using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class DHPublicKey : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerInteger y;
        
        // Properties
        public Org.BouncyCastle.Asn1.DerInteger Y { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.DHPublicKey GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            return Org.BouncyCastle.Asn1.X9.DHPublicKey.GetInstance(obj:  Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  obj, isExplicit:  isExplicit));
        }
        public static Org.BouncyCastle.Asn1.X9.DHPublicKey GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.DerInteger val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.DHPublicKey)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X9.DHPublicKey() = new Org.BouncyCastle.Asn1.X9.DHPublicKey(y:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X9.DHPublicKey();
            return (Org.BouncyCastle.Asn1.X9.DHPublicKey)val_10;
        }
        public DHPublicKey(Org.BouncyCastle.Asn1.DerInteger y)
        {
            if(y != null)
            {
                    this.y = y;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "y");
        }
        public Org.BouncyCastle.Asn1.DerInteger get_Y()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.y;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.y;
        }
    
    }

}
