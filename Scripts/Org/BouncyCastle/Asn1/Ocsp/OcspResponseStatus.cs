using UnityEngine;

namespace Org.BouncyCastle.Asn1.Ocsp
{
    public class OcspResponseStatus : DerEnumerated
    {
        // Fields
        public const int Successful = 0;
        public const int MalformedRequest = 1;
        public const int InternalError = 2;
        public const int TryLater = 3;
        public const int SignatureRequired = 5;
        public const int Unauthorized = 6;
        
        // Methods
        public OcspResponseStatus(int value)
        {
        
        }
        public OcspResponseStatus(Org.BouncyCastle.Asn1.DerEnumerated value)
        {
            int val_2 = value.Value.IntValue;
        }
    
    }

}
