using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class ECNamedCurveTable
    {
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
        {
            if((Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByName(name:  name)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByName(name:  name)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetByName(name:  name)) != null)
            {
                    return val_4;
            }
            
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_4 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByName(name:  name);
            if(val_4 == null)
            {
                    return Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByName(name:  name);
            }
            
            return val_4;
        }
        public static string GetName(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            if((Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetName(oid:  oid)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetName(oid:  oid)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetName(oid:  oid)) != null)
            {
                    return val_4;
            }
            
            string val_4 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetName(oid:  oid);
            if(val_4 == null)
            {
                    return Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetName(oid:  oid);
            }
            
            return val_4;
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
        {
            if((Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetOid(name:  name)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetOid(name:  name)) != null)
            {
                    return val_4;
            }
            
            if((Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetOid(name:  name)) != null)
            {
                    return val_4;
            }
            
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_4 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid(name:  name);
            if(val_4 == null)
            {
                    return Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetOid(name:  name);
            }
            
            return val_4;
        }
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            if((Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByOid(oid:  oid)) != null)
            {
                    return val_3;
            }
            
            if((Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid:  oid)) != null)
            {
                    return val_3;
            }
            
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_3 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByOid(oid:  oid);
            if(val_3 == null)
            {
                    return Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByOid(oid:  oid);
            }
            
            return val_3;
        }
        public static System.Collections.IEnumerable get_Names()
        {
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(to:  val_1, range:  Org.BouncyCastle.Asn1.X9.X962NamedCurves.Names);
            Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(to:  val_1, range:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Names);
            Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(to:  val_1, range:  Org.BouncyCastle.Asn1.Nist.NistNamedCurves.Names);
            Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(to:  val_1, range:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.Names);
            Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(to:  val_1, range:  Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.Names);
            return (System.Collections.IEnumerable)val_1;
        }
        public ECNamedCurveTable()
        {
        
        }
    
    }

}
