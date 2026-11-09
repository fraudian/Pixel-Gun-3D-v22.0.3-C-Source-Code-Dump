using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerSetParser : Asn1SetParser, IAsn1Convertible
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Methods
        internal BerSetParser(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            this._parser = parser;
        }
        public Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
        {
            if(this._parser == null)
            {
                
            }
        
        }
        public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerSet(v:  this._parser.ReadVector(), needsSorting:  false);
        }
    
    }

}
