using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerT61String : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerT61String GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerT61String)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerT61String)obj;
        }
        public static Org.BouncyCastle.Asn1.DerT61String GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_1 = obj.GetObject();
            if(isExplicit != false)
            {
                    return Org.BouncyCastle.Asn1.DerT61String.GetInstance(obj:  val_1);
            }
            
            new Org.BouncyCastle.Asn1.DerT61String() = new Org.BouncyCastle.Asn1.DerT61String(str:  Org.BouncyCastle.Utilities.Strings.FromByteArray(bs:  Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  val_1)));
            return (Org.BouncyCastle.Asn1.DerT61String)new Org.BouncyCastle.Asn1.DerT61String();
        }
        public DerT61String(byte[] str)
        {
            string val_1 = Org.BouncyCastle.Utilities.Strings.FromByteArray(bs:  str);
        }
        public DerT61String(string str)
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
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  20, bytes:  Org.BouncyCastle.Utilities.Strings.ToByteArray(s:  this.str));
        }
        public byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Strings.ToByteArray(s:  this.str);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerT61String.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
    
    }

}
