using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerSequenceParser : Asn1SequenceParser, IAsn1Convertible
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Methods
        internal BerSequenceParser(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
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
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerSequence(v:  this._parser.ReadVector());
        }
    
    }

}
