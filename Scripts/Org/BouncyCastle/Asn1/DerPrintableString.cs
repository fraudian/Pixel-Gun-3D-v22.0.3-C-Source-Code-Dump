using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerPrintableString : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerPrintableString GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerPrintableString)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerPrintableString)obj;
        }
        public static Org.BouncyCastle.Asn1.DerPrintableString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            if(isExplicit != false)
            {
                    return Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(obj:  obj.obj);
            }
            
            new Org.BouncyCastle.Asn1.DerPrintableString() = new Org.BouncyCastle.Asn1.DerPrintableString(str:  Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  obj.obj)), validate:  false);
            return (Org.BouncyCastle.Asn1.DerPrintableString)new Org.BouncyCastle.Asn1.DerPrintableString();
        }
        public DerPrintableString(byte[] str)
        {
            string val_1 = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  str);
        }
        public DerPrintableString(string str)
        {
        
        }
        public DerPrintableString(string str, bool validate)
        {
            var val_4;
            if(str != null)
            {
                    if(validate != false)
            {
                    if((Org.BouncyCastle.Asn1.DerPrintableString.IsPrintableString(str:  str)) == false)
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
            derOut.WriteEncoded(tag:  19, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str));
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerPrintableString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        public static bool IsPrintableString(string str)
        {
            var val_7;
            var val_8;
            val_7 = 0;
            goto label_1;
            label_13:
            if((System.Char.IsLetterOrDigit(c:  W21)) == true)
            {
                goto label_7;
            }
            
            var val_2 = W21 & 65535;
            if(val_2 > 58)
            {
                goto label_5;
            }
            
            val_8 = 0;
            if(val_2 > 58)
            {
                    return (bool)val_8;
            }
            
            val_2 = 1 << val_2;
            val_2 = val_2 & 288506907621064704;
            if(val_2 != 0)
            {
                goto label_7;
            }
            
            return (bool)val_8;
            label_5:
            var val_3 = W21 | 2;
            val_3 = val_3 & 65535;
            if(val_3 != 63)
            {
                goto label_9;
            }
            
            label_7:
            val_7 = 1;
            label_1:
            if(val_7 >= str.Length)
            {
                goto label_11;
            }
            
            if((str.Chars[1] & 65535) <= '')
            {
                goto label_13;
            }
            
            label_9:
            val_8 = 0;
            return (bool)val_8;
            label_11:
            val_8 = 1;
            return (bool)val_8;
        }
    
    }

}
