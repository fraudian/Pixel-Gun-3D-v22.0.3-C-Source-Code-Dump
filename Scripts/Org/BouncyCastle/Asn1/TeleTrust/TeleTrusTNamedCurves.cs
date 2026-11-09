using UnityEngine;

namespace Org.BouncyCastle.Asn1.TeleTrust
{
    public class TeleTrusTNamedCurves
    {
        // Fields
        private static readonly System.Collections.IDictionary objIds;
        private static readonly System.Collections.IDictionary curves;
        private static readonly System.Collections.IDictionary names;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private static Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(Org.BouncyCastle.Math.EC.ECCurve curve)
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)curve;
        }
        private static void DefineCurve(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.objIds.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  oid);
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names.Add(key:  oid, value:  name);
            var val_7 = 0;
            val_7 = val_7 + 1;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.curves.Add(key:  oid, value:  holder);
        }
        private static TeleTrusTNamedCurves()
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
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.curves = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP160r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160R1, holder:  TeleTrusTNamedCurves.BrainpoolP160r1Holder.Instance);
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP160t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160T1, holder:  TeleTrusTNamedCurves.BrainpoolP160t1Holder.Instance);
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP192r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192R1, holder:  TeleTrusTNamedCurves.BrainpoolP192r1Holder.Instance);
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP192t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192T1, holder:  TeleTrusTNamedCurves.BrainpoolP192t1Holder.Instance);
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP224r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224R1, holder:  TeleTrusTNamedCurves.BrainpoolP224r1Holder.Instance);
            val_10 = null;
            val_10 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP224t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224T1, holder:  TeleTrusTNamedCurves.BrainpoolP224t1Holder.Instance);
            val_11 = null;
            val_11 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP256r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256R1, holder:  TeleTrusTNamedCurves.BrainpoolP256r1Holder.Instance);
            val_12 = null;
            val_12 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP256t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256T1, holder:  TeleTrusTNamedCurves.BrainpoolP256t1Holder.Instance);
            val_13 = null;
            val_13 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP320r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320R1, holder:  TeleTrusTNamedCurves.BrainpoolP320r1Holder.Instance);
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP320t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320T1, holder:  TeleTrusTNamedCurves.BrainpoolP320t1Holder.Instance);
            val_15 = null;
            val_15 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP384r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384R1, holder:  TeleTrusTNamedCurves.BrainpoolP384r1Holder.Instance);
            val_16 = null;
            val_16 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP384t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384T1, holder:  TeleTrusTNamedCurves.BrainpoolP384t1Holder.Instance);
            val_17 = null;
            val_17 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP512r1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512R1, holder:  TeleTrusTNamedCurves.BrainpoolP512r1Holder.Instance);
            val_18 = null;
            val_18 = null;
            Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve(name:  "brainpoolP512t1", oid:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512T1, holder:  TeleTrusTNamedCurves.BrainpoolP512t1Holder.Instance);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid(name:  name);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_1;
            }
            
            return Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByOid(oid:  val_1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.curves.Item[oid] == null)
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
            val_7 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.objIds;
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
            val_5 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names;
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
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names.Values);
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(short curvesize, bool twisted)
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid(name:  System.String.Format(format:  "brainpoolP{0}{1}1", arg0:  curvesize, arg1:  (twisted != true) ? "t" : "r"));
        }
        public TeleTrusTNamedCurves()
        {
        
        }
    
    }

}
