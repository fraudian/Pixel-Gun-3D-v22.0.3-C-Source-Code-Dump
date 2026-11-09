using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Null : Asn1Object
    {
        // Methods
        internal Asn1Null()
        {
            val_1 = new System.Object();
        }
        public override string ToString()
        {
            return "NULL";
        }
    
    }

}
