using UnityEngine;

namespace Org.BouncyCastle.Asn1.Nist
{
    public sealed class NistNamedCurves
    {
        // Fields
        private static readonly System.Collections.IDictionary objIds;
        private static readonly System.Collections.IDictionary names;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private NistNamedCurves()
        {
        
        }
        private static void DefineCurveAlias(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.objIds.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  oid);
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names.Add(key:  oid, value:  name);
        }
        private static NistNamedCurves()
        {
            var val_3;
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "B-163", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "B-233", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "B-283", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "B-409", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "B-571", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "K-163", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "K-233", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "K-283", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "K-409", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "K-571", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "P-192", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "P-224", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "P-256", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "P-384", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1);
            Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias(name:  "P-521", oid:  Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetOid(name:  name);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_1;
            }
            
            return Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetByOid(oid:  val_1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            return Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid:  oid);
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
        {
            var val_5;
            var val_7;
            val_5 = null;
            val_5 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = Org.BouncyCastle.Asn1.Nist.NistNamedCurves.objIds;
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
            val_5 = Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names;
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
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names.Values);
        }
    
    }

}
