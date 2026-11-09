using UnityEngine;

namespace Org.BouncyCastle.Asn1.Sec
{
    public sealed class SecNamedCurves
    {
        // Fields
        private static readonly System.Collections.IDictionary objIds;
        private static readonly System.Collections.IDictionary curves;
        private static readonly System.Collections.IDictionary names;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private SecNamedCurves()
        {
        
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
        private static Org.BouncyCastle.Math.BigInteger FromHex(string hex)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  hex));
        }
        private static void DefineCurve(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.objIds.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  oid);
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names.Add(key:  oid, value:  name);
            var val_7 = 0;
            val_7 = val_7 + 1;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.curves.Add(key:  oid, value:  holder);
        }
        private static SecNamedCurves()
        {
            var val_4;
            var val_5;
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
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.curves = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp112r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r1, holder:  SecNamedCurves.Secp112r1Holder.Instance);
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp112r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r2, holder:  SecNamedCurves.Secp112r2Holder.Instance);
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp128r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r1, holder:  SecNamedCurves.Secp128r1Holder.Instance);
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp128r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r2, holder:  SecNamedCurves.Secp128r2Holder.Instance);
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp160k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160k1, holder:  SecNamedCurves.Secp160k1Holder.Instance);
            val_10 = null;
            val_10 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp160r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r1, holder:  SecNamedCurves.Secp160r1Holder.Instance);
            val_11 = null;
            val_11 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp160r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r2, holder:  SecNamedCurves.Secp160r2Holder.Instance);
            val_12 = null;
            val_12 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp192k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192k1, holder:  SecNamedCurves.Secp192k1Holder.Instance);
            val_13 = null;
            val_13 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp192r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1, holder:  SecNamedCurves.Secp192r1Holder.Instance);
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp224k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224k1, holder:  SecNamedCurves.Secp224k1Holder.Instance);
            val_15 = null;
            val_15 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp224r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1, holder:  SecNamedCurves.Secp224r1Holder.Instance);
            val_16 = null;
            val_16 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp256k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256k1, holder:  SecNamedCurves.Secp256k1Holder.Instance);
            val_17 = null;
            val_17 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp256r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1, holder:  SecNamedCurves.Secp256r1Holder.Instance);
            val_18 = null;
            val_18 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp384r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1, holder:  SecNamedCurves.Secp384r1Holder.Instance);
            val_19 = null;
            val_19 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "secp521r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1, holder:  SecNamedCurves.Secp521r1Holder.Instance);
            val_20 = null;
            val_20 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect113r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r1, holder:  SecNamedCurves.Sect113r1Holder.k);
            val_21 = null;
            val_21 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect113r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r2, holder:  SecNamedCurves.Sect113r2Holder.k);
            val_22 = null;
            val_22 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect131r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r1, holder:  SecNamedCurves.Sect131r1Holder.k3);
            val_23 = null;
            val_23 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect131r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r2, holder:  SecNamedCurves.Sect131r2Holder.k3);
            val_24 = null;
            val_24 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect163k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1, holder:  SecNamedCurves.Sect163k1Holder.k3);
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect163r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r1, holder:  SecNamedCurves.Sect163r1Holder.k3);
            val_26 = null;
            val_26 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect163r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2, holder:  SecNamedCurves.Sect163r2Holder.k3);
            val_27 = null;
            val_27 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect193r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r1, holder:  SecNamedCurves.Sect193r1Holder.k);
            val_28 = null;
            val_28 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect193r2", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r2, holder:  SecNamedCurves.Sect193r2Holder.k);
            val_29 = null;
            val_29 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect233k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1, holder:  SecNamedCurves.Sect233k1Holder.k);
            val_30 = null;
            val_30 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect233r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1, holder:  SecNamedCurves.Sect233r1Holder.k);
            val_31 = null;
            val_31 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect239k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT239k1, holder:  SecNamedCurves.Sect239k1Holder.k);
            val_32 = null;
            val_32 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect283k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1, holder:  SecNamedCurves.Sect283k1Holder.k3);
            val_33 = null;
            val_33 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect283r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1, holder:  SecNamedCurves.Sect283r1Holder.k3);
            val_34 = null;
            val_34 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect409k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1, holder:  SecNamedCurves.Sect409k1Holder.k);
            val_35 = null;
            val_35 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect409r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1, holder:  SecNamedCurves.Sect409r1Holder.k);
            val_36 = null;
            val_36 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect571k1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1, holder:  SecNamedCurves.Sect571k1Holder.k3);
            val_37 = null;
            val_37 = null;
            Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve(name:  "sect571r1", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1, holder:  SecNamedCurves.Sect571r1Holder.k3);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetOid(name:  name);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_1;
            }
            
            return Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid:  val_1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(Org.BouncyCastle.Asn1.Sec.SecNamedCurves.curves.Item[oid] == null)
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
            val_7 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.objIds;
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
            val_5 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names;
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
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names.Values);
        }
    
    }

}
