using UnityEngine;

namespace Org.BouncyCastle.Asn1.Anssi
{
    public class AnssiNamedCurves
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
        private static Org.BouncyCastle.Math.BigInteger FromHex(string hex)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  hex));
        }
        private static void DefineCurve(string name, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
        {
            var val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.objIds.Add(key:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  name), value:  oid);
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names.Add(key:  oid, value:  name);
            var val_7 = 0;
            val_7 = val_7 + 1;
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.curves.Add(key:  oid, value:  holder);
        }
        private static AnssiNamedCurves()
        {
            var val_4;
            var val_5;
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.curves = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.DefineCurve(name:  "FRP256v1", oid:  Org.BouncyCastle.Asn1.Anssi.AnssiObjectIdentifiers.FRP256v1, holder:  AnssiNamedCurves.Frp256v1Holder.Instance);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_1 = Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetOid(name:  name);
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_1;
            }
            
            return Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByOid(oid:  val_1);
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.curves.Item[oid] == null)
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
            val_7 = Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.objIds;
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
            val_5 = Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names;
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
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names.Values);
        }
        public AnssiNamedCurves()
        {
        
        }
    
    }

}
