using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DefiniteLengthInputStream stream;
        
        // Methods
        internal DerOctetStringParser(Org.BouncyCastle.Asn1.DefiniteLengthInputStream stream)
        {
            this.stream = stream;
        }
        public System.IO.Stream GetOctetStream()
        {
            return (System.IO.Stream)this.stream;
        }
        public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            new Org.BouncyCastle.Asn1.DerOctetString() = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  this.stream.ToArray());
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerOctetString();
        }
    
    }

}
