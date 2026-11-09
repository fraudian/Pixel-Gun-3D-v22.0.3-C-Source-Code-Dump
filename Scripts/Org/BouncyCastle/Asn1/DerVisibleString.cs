using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerVisibleString : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerVisibleString GetInstance(object obj)
        {
            object val_9 = obj;
            if(val_9 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerVisibleString)val_9;
            }
            
            val_9 = val_9.GetObject();
            return (Org.BouncyCastle.Asn1.DerVisibleString)val_9;
        }
        public static Org.BouncyCastle.Asn1.DerVisibleString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.DerVisibleString.GetInstance(obj:  obj.GetObject());
        }
        public DerVisibleString(byte[] str)
        {
            string val_1 = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  str);
        }
        public DerVisibleString(string str)
        {
            this = new Org.BouncyCastle.Asn1.Asn1Object();
            if(str != null)
            {
                    this.str = str;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "str");
        }
        public override string GetString()
        {
            return (string)this.str;
        }
        public byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  26, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str));
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerVisibleString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            if(this.str == null)
            {
                
            }
        
        }
    
    }

}
