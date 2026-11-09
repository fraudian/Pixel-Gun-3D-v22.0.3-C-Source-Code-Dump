using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerUtf8String : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerUtf8String GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerUtf8String)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerUtf8String)obj;
        }
        public static Org.BouncyCastle.Asn1.DerUtf8String GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_1 = obj.GetObject();
            if(isExplicit == false)
            {
                    return (Org.BouncyCastle.Asn1.DerUtf8String)new Org.BouncyCastle.Asn1.DerUtf8String(str:  Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  val_1));
            }
            
            return Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(obj:  val_1);
        }
        public DerUtf8String(byte[] str)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            if(str != null)
            {
                    if(val_1 == null)
            {
                    return;
            }
            
                return;
            }
            
            if(val_1 != null)
            {
                    return;
            }
        
        }
        public DerUtf8String(string str)
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
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerUtf8String.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  12, bytes:  System.Text.Encoding.UTF8);
        }
    
    }

}
