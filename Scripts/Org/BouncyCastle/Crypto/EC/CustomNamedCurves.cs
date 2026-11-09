using UnityEngine;

namespace Org.BouncyCastle.Crypto.EC
{
    public sealed class CustomNamedCurves
    {
        // Fields
        private static readonly System.Collections.IDictionary nameToCurve;
        private static readonly System.Collections.IDictionary nameToOid;
        private static readonly System.Collections.IDictionary oidToCurve;
        private static readonly System.Collections.IDictionary oidToName;
        private static readonly System.Collections.IList names;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private CustomNamedCurves()
        {
        
        }
        private static Org.BouncyCastle.Math.BigInteger FromHex(string hex)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  hex));
        }
        private static Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(Org.BouncyCastle.Math.EC.ECCurve curve)
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)curve;
        }
        private static Org.BouncyCastle.Math.EC.ECCurve ConfigureCurveGlv(Org.BouncyCastle.Math.EC.ECCurve c, Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters p)
        {
            Config val_2 = c.SetEndomorphism(endomorphism:  new Org.BouncyCastle.Math.EC.Endo.GlvTypeBEndomorphism(curve:  c, parameters:  p));
            if(val_2 != null)
            {
                    return val_2.Create();
            }
            
            return val_2.Create();
        }
        private static void DefineCurve(string name, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_2 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.names.Add(value:  name);
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToCurve.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  holder);
        }
        private static void DefineCurveWithOid(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_7 = null;
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_2 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.names.Add(value:  name);
            var val_9 = 0;
            val_9 = val_9 + 1;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToName.Add(key:  oid, value:  name);
            var val_10 = 0;
            val_10 = val_10 + 1;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToCurve.Add(key:  oid, value:  holder);
            string val_5 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name);
            var val_11 = 0;
            val_11 = val_11 + 1;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToOid.Add(key:  val_5, value:  oid);
            var val_12 = 0;
            val_12 = val_12 + 1;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToCurve.Add(key:  val_5, value:  holder);
        }
        private static void DefineCurveAlias(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_6;
            var val_8;
            val_6 = null;
            val_6 = null;
            var val_7 = 0;
            val_7 = val_7 + 1;
            object val_2 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToCurve.Item[oid];
            if(val_2 != null)
            {
                    string val_3 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name);
                val_8 = null;
                val_8 = null;
                var val_8 = 0;
                val_8 = val_8 + 1;
                Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToOid.Add(key:  val_3, value:  oid);
                var val_9 = 0;
                val_9 = val_9 + 1;
                Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToCurve.Add(key:  val_3, value:  val_2);
                return;
            }
            
            System.InvalidOperationException val_6 = new System.InvalidOperationException();
        }
        private static CustomNamedCurves()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToCurve = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToOid = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToCurve = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToName = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurve(name:  "curve25519", holder:  CustomNamedCurves.Curve25519Holder.Instance);
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp128r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r1, holder:  CustomNamedCurves.SecP128R1Holder.Instance);
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp160k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160k1, holder:  CustomNamedCurves.SecP160K1Holder.Instance);
            val_10 = null;
            val_10 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp160r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r1, holder:  CustomNamedCurves.SecP160R1Holder.Instance);
            val_11 = null;
            val_11 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp160r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r2, holder:  CustomNamedCurves.SecP160R2Holder.Instance);
            val_12 = null;
            val_12 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp192k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192k1, holder:  CustomNamedCurves.SecP192K1Holder.Instance);
            val_13 = null;
            val_13 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp192r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1, holder:  CustomNamedCurves.SecP192R1Holder.Instance);
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp224k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224k1, holder:  CustomNamedCurves.SecP224K1Holder.Instance);
            val_15 = null;
            val_15 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp224r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1, holder:  CustomNamedCurves.SecP224R1Holder.Instance);
            val_16 = null;
            val_16 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp256k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256k1, holder:  CustomNamedCurves.SecP256K1Holder.Instance);
            val_17 = null;
            val_17 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp256r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1, holder:  CustomNamedCurves.SecP256R1Holder.Instance);
            val_18 = null;
            val_18 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp384r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1, holder:  CustomNamedCurves.SecP384R1Holder.Instance);
            val_19 = null;
            val_19 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "secp521r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1, holder:  CustomNamedCurves.SecP521R1Holder.Instance);
            val_20 = null;
            val_20 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect113r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r1, holder:  CustomNamedCurves.SecT113R1Holder.Instance);
            val_21 = null;
            val_21 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect113r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r2, holder:  CustomNamedCurves.SecT113R2Holder.Instance);
            val_22 = null;
            val_22 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect131r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r1, holder:  CustomNamedCurves.SecT131R1Holder.Instance);
            val_23 = null;
            val_23 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect131r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r2, holder:  CustomNamedCurves.SecT131R2Holder.Instance);
            val_24 = null;
            val_24 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect163k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1, holder:  CustomNamedCurves.SecT163K1Holder.Instance);
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect163r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r1, holder:  CustomNamedCurves.SecT163R1Holder.Instance);
            val_26 = null;
            val_26 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect163r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2, holder:  CustomNamedCurves.SecT163R2Holder.Instance);
            val_27 = null;
            val_27 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect193r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r1, holder:  CustomNamedCurves.SecT193R1Holder.Instance);
            val_28 = null;
            val_28 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect193r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r2, holder:  CustomNamedCurves.SecT193R2Holder.Instance);
            val_29 = null;
            val_29 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect233k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1, holder:  CustomNamedCurves.SecT233K1Holder.Instance);
            val_30 = null;
            val_30 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect233r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1, holder:  CustomNamedCurves.SecT233R1Holder.Instance);
            val_31 = null;
            val_31 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect239k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT239k1, holder:  CustomNamedCurves.SecT239K1Holder.Instance);
            val_32 = null;
            val_32 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect283k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1, holder:  CustomNamedCurves.SecT283K1Holder.Instance);
            val_33 = null;
            val_33 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect283r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1, holder:  CustomNamedCurves.SecT283R1Holder.Instance);
            val_34 = null;
            val_34 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect409k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1, holder:  CustomNamedCurves.SecT409K1Holder.Instance);
            val_35 = null;
            val_35 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect409r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1, holder:  CustomNamedCurves.SecT409R1Holder.Instance);
            val_36 = null;
            val_36 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect571k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1, holder:  CustomNamedCurves.SecT571K1Holder.Instance);
            val_37 = null;
            val_37 = null;
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveWithOid(name:  "sect571r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1, holder:  CustomNamedCurves.SecT571R1Holder.Instance);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "B-163", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "B-233", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "B-283", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "B-409", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "B-571", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "K-163", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "K-233", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "K-283", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "K-409", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "K-571", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "P-192", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "P-224", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "P-256", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "P-384", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1);
            Org.BouncyCastle.Crypto.EC.CustomNamedCurves.DefineCurveAlias(name:  "P-521", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            var val_5 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            if((Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToCurve.Item[Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name)]) == null)
            {
                    return 0;
            }
            
            return 0;
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToCurve.Item[oid] == null)
            {
                    return 0;
            }
            
            return 0;
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
        {
            var val_5;
            var val_7;
            val_5 = null;
            val_5 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.nameToOid;
            if((val_7.Item[Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name)]) == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_7;
            }
            
            val_7 = 0;
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_7;
        }
        public static string GetName(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_3;
            var val_5;
            val_3 = null;
            val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.oidToName;
            if(val_5.Item[oid] == null)
            {
                    return (string)val_5;
            }
            
            if(null == null)
            {
                    return (string)val_5;
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        public static System.Collections.IEnumerable get_Names()
        {
            null = null;
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Crypto.EC.CustomNamedCurves.names);
        }
    
    }

}
