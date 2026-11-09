using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Methods
        internal BerOctetStringParser(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            this._parser = parser;
        }
        public System.IO.Stream GetOctetStream()
        {
            Org.BouncyCastle.Asn1.ConstructedOctetStream val_1 = null;
            ._first = true;
            val_1 = new Org.BouncyCastle.Asn1.ConstructedOctetStream();
            ._parser = this._parser;
            return (System.IO.Stream)val_1;
        }
        public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            new Org.BouncyCastle.Asn1.BerOctetString() = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  Org.BouncyCastle.Utilities.IO.Streams.ReadAll(inStr:  this.GetOctetStream()));
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerOctetString();
        }
    
    }

}
