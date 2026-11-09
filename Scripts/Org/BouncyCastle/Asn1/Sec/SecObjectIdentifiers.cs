using UnityEngine;

namespace Org.BouncyCastle.Asn1.Sec
{
    public abstract class SecObjectIdentifiers
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT239k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r2;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP384r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP521r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571k1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192r1;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256r1;
        
        // Methods
        protected SecObjectIdentifiers()
        {
        
        }
        private static SecObjectIdentifiers()
        {
            var val_64;
            var val_65;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.132.0");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve = val_1;
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".1");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".2");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT239k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".3");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".4");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".5");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".6");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".7");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".8");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".9");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".10");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".15");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".16");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".17");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".22");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".23");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".24");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".25");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".26");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".27");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".28");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".29");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r2 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".30");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".31");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".32");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".33");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".34");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".35");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".36");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".37");
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".38");
            val_64 = null;
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1 + ".39");
            val_65 = null;
            val_65 = null;
            val_64 = null;
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1;
            Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1;
        }
    
    }

}
