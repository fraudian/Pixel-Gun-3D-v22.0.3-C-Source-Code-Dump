using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerIA5String : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerIA5String GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerIA5String)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerIA5String)obj;
        }
        public static Org.BouncyCastle.Asn1.DerIA5String GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            var val_6;
            object val_7;
            if(obj.obj == null)
            {
                goto label_2;
            }
            
            val_7 = obj.obj;
            if(isExplicit == false)
            {
                goto label_3;
            }
            
            return Org.BouncyCastle.Asn1.DerIA5String.GetInstance(obj:  val_7);
            label_2:
            val_7 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerIA5String.GetInstance(obj:  val_7);
            }
            
            label_3:
            if(val_7 != 0)
            {
                    val_6 = null;
                val_6 = 0;
                val_7 = 0;
            }
            
            new Org.BouncyCastle.Asn1.DerIA5String() = new Org.BouncyCastle.Asn1.DerIA5String(str:  Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  val_7), validate:  false);
            return (Org.BouncyCastle.Asn1.DerIA5String)new Org.BouncyCastle.Asn1.DerIA5String();
        }
        public DerIA5String(byte[] str)
        {
            string val_1 = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  str);
        }
        public DerIA5String(string str)
        {
        
        }
        public DerIA5String(string str, bool validate)
        {
            var val_4;
            if(str != null)
            {
                    if(validate != false)
            {
                    if((Org.BouncyCastle.Asn1.DerIA5String.IsIA5String(str:  str)) == false)
            {
                goto label_3;
            }
            
            }
            
                this.str = str;
                return;
            }
            
            System.ArgumentNullException val_2 = null;
            val_4 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "str");
            goto label_4;
            label_3:
            System.ArgumentException val_3 = null;
            val_4 = val_3;
            val_3 = new System.ArgumentException(message:  "string contains illegal characters", paramName:  "str");
            label_4:
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
            derOut.WriteEncoded(tag:  22, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str));
        }
        protected override int Asn1GetHashCode()
        {
            if(this.str == null)
            {
                
            }
        
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerIA5String.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        public static bool IsIA5String(string str)
        {
            var val_4;
            var val_4 = 0;
            label_3:
            if(val_4 >= str.Length)
            {
                goto label_1;
            }
            
            val_4 = val_4 + 1;
            if((str.Chars[0] & 65535) <= '')
            {
                goto label_3;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}
