using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class OidTokenizer
    {
        // Fields
        private string oid;
        private int index;
        
        // Properties
        public bool HasMoreTokens { get; }
        
        // Methods
        public OidTokenizer(string oid)
        {
            this.oid = oid;
        }
        public bool get_HasMoreTokens()
        {
            return (bool)(this.index != 1) ? 1 : 0;
        }
        public string NextToken()
        {
            var val_5;
            int val_6;
            if(this.index == 1)
            {
                goto label_0;
            }
            
            int val_4 = this.index;
            int val_1 = this.oid.IndexOf(value:  '.', startIndex:  val_4);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            val_4 = val_1 - this.index;
            string val_2 = this.oid.Substring(startIndex:  this.index, length:  val_4);
            val_6 = val_1 + 1;
            goto label_4;
            label_0:
            val_5 = 0;
            return (string)this.oid.Substring(startIndex:  this.index);
            label_2:
            val_6 = 0;
            label_4:
            this.index = val_6;
            return (string)this.oid.Substring(startIndex:  this.index);
        }
    
    }

}
