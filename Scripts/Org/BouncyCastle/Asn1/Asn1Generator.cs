using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Generator
    {
        // Fields
        private System.IO.Stream _out;
        
        // Properties
        protected System.IO.Stream Out { get; }
        
        // Methods
        protected Asn1Generator(System.IO.Stream outStream)
        {
            this._out = outStream;
        }
        protected System.IO.Stream get_Out()
        {
            return (System.IO.Stream)this._out;
        }
        public abstract void AddObject(Org.BouncyCastle.Asn1.Asn1Encodable obj); // 0
        public abstract System.IO.Stream GetRawOutputStream(); // 0
        public abstract void Close(); // 0
    
    }

}
