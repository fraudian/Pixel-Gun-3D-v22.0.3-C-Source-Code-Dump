using UnityEngine;

namespace Org.BouncyCastle.Asn1.Anssi
{
    public sealed class AnssiObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier FRP256v1;
        
        // Methods
        private AnssiObjectIdentifiers()
        {
        
        }
        private static AnssiObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.Anssi.AnssiObjectIdentifiers.FRP256v1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.2.250.1.223.101.256.1");
        }
    
    }

}
