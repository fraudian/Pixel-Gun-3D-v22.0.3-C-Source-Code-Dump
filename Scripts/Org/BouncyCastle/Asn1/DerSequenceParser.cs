using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerSequenceParser : Asn1SequenceParser, IAsn1Convertible
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Methods
        internal DerSequenceParser(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
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
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  this._parser.ReadVector());
        }
    
    }

}
