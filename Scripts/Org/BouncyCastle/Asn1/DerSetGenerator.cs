using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerSetGenerator : DerGenerator
    {
        // Fields
        private readonly System.IO.MemoryStream _bOut;
        
        // Methods
        public DerSetGenerator(System.IO.Stream outStream)
        {
            this._bOut = new System.IO.MemoryStream();
        }
        public DerSetGenerator(System.IO.Stream outStream, int tagNo, bool isExplicit)
        {
            this._bOut = new System.IO.MemoryStream();
            isExplicit = isExplicit;
        }
        public override void AddObject(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            if((new Org.BouncyCastle.Asn1.DerOutputStream(os:  this._bOut)) == null)
            {
                
            }
        
        }
        public override System.IO.Stream GetRawOutputStream()
        {
            return (System.IO.Stream)this._bOut;
        }
        public override void Close()
        {
            this.WriteDerEncoded(tag:  49, bytes:  this._bOut);
        }
    
    }

}
