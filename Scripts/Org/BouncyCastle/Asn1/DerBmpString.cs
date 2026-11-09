using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerBmpString : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerBmpString GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerBmpString)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerBmpString)obj;
        }
        public static Org.BouncyCastle.Asn1.DerBmpString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            if(isExplicit == false)
            {
                    return (Org.BouncyCastle.Asn1.DerBmpString)new Org.BouncyCastle.Asn1.DerBmpString(str:  Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  obj.obj));
            }
            
            return Org.BouncyCastle.Asn1.DerBmpString.GetInstance(obj:  obj.obj);
        }
        public DerBmpString(byte[] str)
        {
            var val_6;
            var val_7;
            int val_8;
            if(str == null)
            {
                goto label_1;
            }
            
            var val_2 = ((str.Length < 0) ? (str.Length + 1) : str.Length) >> 1;
            char[] val_3 = new char[0];
            val_6 = 0;
            val_7 = 1;
            goto label_2;
            label_7:
            val_8 = str.Length;
            if(0 >= val_8)
            {
                    val_8 = str.Length;
            }
            
            byte val_6 = str[0];
            val_6 = 1;
            val_7 = 3;
            val_3[0] = str[1];
            label_2:
            if(val_6 != val_3.Length)
            {
                goto label_7;
            }
            
            this.str = 0.CreateString(val:  val_3);
            return;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "str");
        }
        public DerBmpString(string str)
        {
            if(str != null)
            {
                    this.str = str;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "str");
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
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerBmpString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            byte[] val_2 = new byte[0];
            if(val_1.Length != 0)
            {
                    var val_7 = 1;
                do
            {
                val_2[(long)val_7 - 1] = this.str.ToCharArray()[0] >> 8;
                val_2[1] = val_1[0x0] + 32;
                val_7 = val_7 + 2;
            }
            while((0 + 1) != val_1.Length);
            
            }
            
            derOut.WriteEncoded(tag:  30, bytes:  val_2);
        }
    
    }

}
