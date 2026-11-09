using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerGraphicString : DerStringBase
    {
        // Fields
        private readonly byte[] mString;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerGraphicString GetInstance(object obj)
        {
            object val_8;
            System.Byte[] val_9;
            string val_11;
            string val_13;
            string val_14;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerGraphicString)val_8;
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
                    return (Org.BouncyCastle.Asn1.DerGraphicString)val_8;
            }
            
                val_8 = 0;
                return (Org.BouncyCastle.Asn1.DerGraphicString)val_8;
            }
            
            string val_5 = Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_8);
            val_11 = "illegal object in GetInstance: ";
            System.ArgumentException val_7 = null;
            val_14 = val_7;
            val_7 = new System.ArgumentException(message:   +, paramName:  "obj");
            mem[8] = null;
            val_13 = 8;
        }
        public static Org.BouncyCastle.Asn1.DerGraphicString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
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
            
            return Org.BouncyCastle.Asn1.DerGraphicString.GetInstance(obj:  val_7);
            label_2:
            val_7 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerGraphicString.GetInstance(obj:  val_7);
            }
            
            label_3:
            if(val_7 != 0)
            {
                    val_6 = null;
                val_6 = 0;
                val_7 = 0;
            }
            
            .mString = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_7);
            return (Org.BouncyCastle.Asn1.DerGraphicString)new Org.BouncyCastle.Asn1.DerGraphicString();
        }
        public DerGraphicString(byte[] encoding)
        {
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
            derOut.WriteEncoded(tag:  25, bytes:  this.mString);
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
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerGraphicString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
    
    }

}
