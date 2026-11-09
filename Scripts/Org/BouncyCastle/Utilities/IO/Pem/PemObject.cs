using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemObject : PemObjectGenerator
    {
        // Fields
        private string type;
        private System.Collections.IList headers;
        private byte[] content;
        
        // Properties
        public string Type { get; }
        public System.Collections.IList Headers { get; }
        public byte[] Content { get; }
        
        // Methods
        public PemObject(string type, byte[] content)
        {
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
        }
        public PemObject(string type, System.Collections.IList headers, byte[] content)
        {
            this.type = type;
            this.headers = Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  headers);
            this.content = content;
        }
        public string get_Type()
        {
            return (string)this.type;
        }
        public System.Collections.IList get_Headers()
        {
            return (System.Collections.IList)this.headers;
        }
        public byte[] get_Content()
        {
            return (System.Byte[])this.content;
        }
        public Org.BouncyCastle.Utilities.IO.Pem.PemObject Generate()
        {
            return (Org.BouncyCastle.Utilities.IO.Pem.PemObject)this;
        }
    
    }

}
