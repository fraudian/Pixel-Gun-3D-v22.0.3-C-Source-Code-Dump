using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerUniversalString : DerStringBase
    {
        // Fields
        private static readonly char[] table;
        private readonly byte[] str;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerUniversalString GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerUniversalString)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerUniversalString)obj;
        }
        public static Org.BouncyCastle.Asn1.DerUniversalString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_1 = obj.GetObject();
            if(isExplicit == false)
            {
                    return (Org.BouncyCastle.Asn1.DerUniversalString)new Org.BouncyCastle.Asn1.DerUniversalString(str:  Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  val_1));
            }
            
            return Org.BouncyCastle.Asn1.DerUniversalString.GetInstance(obj:  val_1);
        }
        public DerUniversalString(byte[] str)
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
            char val_8;
            var val_9;
            var val_10;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  "#");
            val_8 = 0;
            val_9 = 0;
            goto label_1;
            label_13:
            byte val_8 = this.GetDerEncoded()[0];
            val_10 = null;
            val_10 = null;
            val_8 = val_8 >> 4;
            System.Char[] val_3 = Org.BouncyCastle.Asn1.DerUniversalString.table + (((val_2[0x0][0] >> 4)) << 1);
            System.Text.StringBuilder val_4 = val_1.Append(value:  (Org.BouncyCastle.Asn1.DerUniversalString.table + ((val_2[0x0][0] >> 4)) << 1) + 32);
            var val_9 = val_2[0x0] + 32;
            var val_5 = val_9 & 15;
            val_9 = val_9 & 15;
            System.Char[] val_6 = Org.BouncyCastle.Asn1.DerUniversalString.table + (((val_2[0x0] + 32 & 15)) << 1);
            val_8 = (Org.BouncyCastle.Asn1.DerUniversalString.table + ((val_2[0x0] + 32 & 15)) << 1) + 32;
            System.Text.StringBuilder val_7 = val_1.Append(value:  val_8);
            val_9 = 1;
            label_1:
            if(val_9 != val_2.Length)
            {
                goto label_13;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        public byte[] GetOctets()
        {
            System.Byte[] val_3;
            var val_4;
            val_3 = this.str;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  28, bytes:  this.str);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerUniversalString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        private static DerUniversalString()
        {
            Org.BouncyCastle.Asn1.DerUniversalString.table = new char[16];
        }
    
    }

}
