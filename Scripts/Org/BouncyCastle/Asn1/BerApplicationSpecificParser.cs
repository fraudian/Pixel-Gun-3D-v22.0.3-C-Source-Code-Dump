using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerApplicationSpecificParser : IAsn1ApplicationSpecificParser, IAsn1Convertible
    {
        // Fields
        private readonly int tag;
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser parser;
        
        // Methods
        internal BerApplicationSpecificParser(int tag, Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            val_1 = new System.Object();
            this.tag = tag;
            this.parser = val_1;
        }
        public Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
        {
            if(this.parser == null)
            {
                
            }
        
        }
        public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.BerApplicationSpecific(tagNo:  this.tag, vec:  this.parser.ReadVector());
        }
    
    }

}
