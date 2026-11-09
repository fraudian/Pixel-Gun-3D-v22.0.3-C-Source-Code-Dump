using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerGeneralString : DerStringBase
    {
        // Fields
        private readonly string str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerGeneralString GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerGeneralString)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerGeneralString)obj;
        }
        public static Org.BouncyCastle.Asn1.DerGeneralString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
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
            
            return Org.BouncyCastle.Asn1.DerGeneralString.GetInstance(obj:  val_7);
            label_2:
            val_7 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerGeneralString.GetInstance(obj:  val_7);
            }
            
            label_3:
            if(val_7 != 0)
            {
                    val_6 = null;
                val_6 = 0;
                val_7 = 0;
            }
            
            new Org.BouncyCastle.Asn1.DerGeneralString() = new Org.BouncyCastle.Asn1.DerGeneralString(str:  Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  val_7));
            return (Org.BouncyCastle.Asn1.DerGeneralString)new Org.BouncyCastle.Asn1.DerGeneralString();
        }
        public DerGeneralString(byte[] str)
        {
            string val_1 = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  str);
        }
        public DerGeneralString(string str)
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
        public byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  27, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.str));
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerGeneralString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
    
    }

}
