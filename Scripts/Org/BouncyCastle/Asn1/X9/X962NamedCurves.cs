using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public sealed class X962NamedCurves
    {
        // Fields
        private static readonly System.Collections.IDictionary objIds;
        private static readonly System.Collections.IDictionary curves;
        private static readonly System.Collections.IDictionary names;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private X962NamedCurves()
        {
        
        }
        private static void DefineCurve(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.objIds.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  oid);
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.names.Add(key:  oid, value:  name);
            var val_7 = 0;
            val_7 = val_7 + 1;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.curves.Add(key:  oid, value:  holder);
        }
        private static X962NamedCurves()
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
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.curves = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime192v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1, holder:  X962NamedCurves.Prime192v1Holder.Instance);
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime192v2", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v2, holder:  X962NamedCurves.Prime192v2Holder.Instance);
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime192v3", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v3, holder:  X962NamedCurves.Prime192v3Holder.Instance);
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime239v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v1, holder:  X962NamedCurves.Prime239v1Holder.Instance);
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime239v2", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v2, holder:  X962NamedCurves.Prime239v2Holder.Instance);
            val_10 = null;
            val_10 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime239v3", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v3, holder:  X962NamedCurves.Prime239v3Holder.Instance);
            val_11 = null;
            val_11 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "prime256v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1, holder:  X962NamedCurves.Prime256v1Holder.Instance);
            val_12 = null;
            val_12 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb163v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v1, holder:  X962NamedCurves.C2pnb163v1Holder.Instance);
            val_13 = null;
            val_13 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb163v2", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v2, holder:  X962NamedCurves.C2pnb163v2Holder.Instance);
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb163v3", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v3, holder:  X962NamedCurves.C2pnb163v3Holder.Instance);
            val_15 = null;
            val_15 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb176w1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb176w1, holder:  X962NamedCurves.C2pnb176w1Holder.Instance);
            val_16 = null;
            val_16 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb191v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v1, holder:  X962NamedCurves.C2tnb191v1Holder.Instance);
            val_17 = null;
            val_17 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb191v2", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v2, holder:  X962NamedCurves.C2tnb191v2Holder.Instance);
            val_18 = null;
            val_18 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb191v3", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v3, holder:  X962NamedCurves.C2tnb191v3Holder.Instance);
            val_19 = null;
            val_19 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb208w1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb208w1, holder:  X962NamedCurves.C2pnb208w1Holder.Instance);
            val_20 = null;
            val_20 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb239v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v1, holder:  X962NamedCurves.C2tnb239v1Holder.Instance);
            val_21 = null;
            val_21 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb239v2", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v2, holder:  X962NamedCurves.C2tnb239v2Holder.Instance);
            val_22 = null;
            val_22 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb239v3", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v3, holder:  X962NamedCurves.C2tnb239v3Holder.Instance);
            val_23 = null;
            val_23 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb272w1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb272w1, holder:  X962NamedCurves.C2pnb272w1Holder.Instance);
            val_24 = null;
            val_24 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb304w1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb304w1, holder:  X962NamedCurves.C2pnb304w1Holder.Instance);
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb359v1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb359v1, holder:  X962NamedCurves.C2tnb359v1Holder.Instance);
            val_26 = null;
            val_26 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2pnb368w1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb368w1, holder:  X962NamedCurves.C2pnb368w1Holder.Instance);
            val_27 = null;
            val_27 = null;
            Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve(name:  "c2tnb431r1", oid:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb431r1, holder:  X962NamedCurves.C2tnb431r1Holder.Instance);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetOid(name:  name);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_1;
            }
            
            return Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByOid(oid:  val_1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(Org.BouncyCastle.Asn1.X9.X962NamedCurves.curves.Item[oid] == null)
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
            val_7 = Org.BouncyCastle.Asn1.X9.X962NamedCurves.objIds;
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
            val_5 = Org.BouncyCastle.Asn1.X9.X962NamedCurves.names;
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
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.X9.X962NamedCurves.names.Values);
        }
    
    }

}
