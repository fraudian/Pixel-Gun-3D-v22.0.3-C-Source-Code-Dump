using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerExternalParser : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Methods
        public DerExternalParser(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            val_1 = new System.Object();
            this._parser = parser;
        }
        public Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
        {
            if(this._parser == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerExternal(vector:  this._parser.ReadVector());
        }
    
    }

}
