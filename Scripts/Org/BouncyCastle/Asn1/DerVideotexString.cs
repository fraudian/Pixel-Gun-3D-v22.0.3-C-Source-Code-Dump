using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerVideotexString : DerStringBase
    {
        // Fields
        private readonly byte[] mString;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerVideotexString GetInstance(object obj)
        {
            object val_8;
            System.Byte[] val_9;
            string val_11;
            string val_13;
            string val_14;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerVideotexString)val_8;
            }
            
            if(val_8 != null)
            {
                    val_9 = val_8;
                if(val_9 == null)
            {
                    val_9 = 0;
            }
            
                val_8 = Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_9);
                if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerVideotexString)val_8;
            }
            
                val_8 = 0;
                return (Org.BouncyCastle.Asn1.DerVideotexString)val_8;
            }
            
            string val_5 = Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_8);
            val_11 = "illegal object in GetInstance: ";
            System.ArgumentException val_7 = null;
            val_14 = val_7;
            val_7 = new System.ArgumentException(message:   +, paramName:  "obj");
            mem[8] = null;
            val_13 = 8;
        }
        public static Org.BouncyCastle.Asn1.DerVideotexString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            var val_7;
            object val_8;
            val_7 = 0;
            val_8 = obj.GetObject();
            if(isExplicit != false)
            {
                    return Org.BouncyCastle.Asn1.DerVideotexString.GetInstance(obj:  val_8);
            }
            
            if(val_8 != null)
            {
                    val_7 = null;
                val_7 = 0;
                val_8 = 0;
            }
            
            .mString = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_8);
            return (Org.BouncyCastle.Asn1.DerVideotexString)new Org.BouncyCastle.Asn1.DerVideotexString();
        }
        public DerVideotexString(byte[] encoding)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Object();
            this.mString = Org.BouncyCastle.Utilities.Arrays.Clone(data:  encoding);
        }
        public override string GetString()
        {
            return Org.BouncyCastle.Utilities.Strings.FromByteArray(bs:  this.mString);
        }
        public byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.mString);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  21, bytes:  this.mString);
        }
        protected override int Asn1GetHashCode()
        {
            return Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.mString);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerVideotexString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
    
    }

}
