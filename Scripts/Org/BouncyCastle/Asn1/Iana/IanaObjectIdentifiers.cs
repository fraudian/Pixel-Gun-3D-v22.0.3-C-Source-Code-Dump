using UnityEngine;

namespace Org.BouncyCastle.Asn1.Iana
{
    public abstract class IanaObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IsakmpOakley;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier HmacMD5;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier HmacSha1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier HmacTiger;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier HmacRipeMD160;
        
        // Methods
        protected IanaObjectIdentifiers()
        {
        
        }
        private static IanaObjectIdentifiers()
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.8.1");
            Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.IsakmpOakley = val_1;
            Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacMD5 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".1");
            Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".2");
            Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacTiger = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3");
            Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacRipeMD160 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".4");
        }
    
    }

}
