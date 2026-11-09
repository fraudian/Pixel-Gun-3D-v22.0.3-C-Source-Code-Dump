using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerTaggedObjectParser : Asn1TaggedObjectParser, IAsn1Convertible
    {
        // Fields
        private bool _constructed;
        private int _tagNumber;
        private Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        
        // Properties
        public bool IsConstructed { get; }
        public int TagNo { get; }
        
        // Methods
        internal BerTaggedObjectParser(int baseTag, int tagNumber, System.IO.Stream contentStream)
        {
            new Org.BouncyCastle.Asn1.Asn1StreamParser() = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  System.IO.Stream val_3 = contentStream, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_3));
            val_3 = new System.Object();
            this._tagNumber = tagNumber;
            this._constructed = (uint)(baseTag >> 5) & 1;
            this._parser = new Org.BouncyCastle.Asn1.Asn1StreamParser();
        }
        internal BerTaggedObjectParser(bool constructed, int tagNumber, Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            val_1 = new System.Object();
            this._tagNumber = tagNumber;
            this._constructed = constructed;
            this._parser = val_1;
        }
        public bool get_IsConstructed()
        {
            return (bool)this._constructed;
        }
        public int get_TagNo()
        {
            return (int)this._tagNumber;
        }
        public Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
        {
            int val_9;
            var val_10;
            val_9 = tag;
            val_10 = this;
            if(isExplicit == false)
            {
                    return val_10 + 24.ReadImplicit(constructed:  ((val_10 + 16) != 0) ? 1 : 0, tag:  val_9 = ???);
            }
            
            if(this._constructed != false)
            {
                    val_10 = ???;
            }
            else
            {
                    System.IO.IOException val_8 = new System.IO.IOException(message:  "Explicit tags must be constructed (see X.690 8.14.2)");
            }
        
        }
        public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this._parser.ReadTaggedObject(constructed:  (this._constructed == true) ? 1 : 0, tag:  this._tagNumber);
        }
    
    }

}
