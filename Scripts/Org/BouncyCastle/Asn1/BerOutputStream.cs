using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerOutputStream : DerOutputStream
    {
        // Methods
        public BerOutputStream(System.IO.Stream os)
        {
            val_1 = new Org.BouncyCastle.Utilities.IO.FilterStream(s:  os);
        }
        public override void WriteObject(object obj)
        {
            object val_3 = obj;
            if(val_3 != null)
            {
                    val_3 = val_3;
                return;
            }
            
            this.WriteByte(value:  5);
            this.WriteByte(value:  0);
        }
    
    }

}
