using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerBitString : DerStringBase
    {
        // Fields
        private static readonly char[] table;
        protected readonly byte[] mData;
        protected readonly int mPadBits;
        
        // Properties
        public virtual int PadBits { get; }
        public virtual int IntValue { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerBitString GetInstance(object obj)
        {
            object val_8;
            System.Byte[] val_9;
            string val_11;
            string val_13;
            string val_14;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerBitString)val_8;
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
                    return (Org.BouncyCastle.Asn1.DerBitString)val_8;
            }
            
                val_8 = 0;
                return (Org.BouncyCastle.Asn1.DerBitString)val_8;
            }
            
            string val_5 = Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_8);
            val_11 = "illegal object in GetInstance: ";
            System.ArgumentException val_7 = null;
            val_14 = val_7;
            val_7 = new System.ArgumentException(message:   +);
            mem[8] = null;
            val_13 = 8;
        }
        public static Org.BouncyCastle.Asn1.DerBitString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            var val_5;
            object val_6;
            if(obj.obj == null)
            {
                goto label_2;
            }
            
            val_6 = obj.obj;
            if(isExplicit == false)
            {
                goto label_3;
            }
            
            return Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_6);
            label_2:
            val_6 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_6);
            }
            
            label_3:
            if(val_6 != 0)
            {
                    val_5 = null;
                val_5 = 0;
                val_6 = 0;
                return (Org.BouncyCastle.Asn1.DerBitString)Org.BouncyCastle.Asn1.DerBitString.FromAsn1Octets(octets:  val_6);
            }
            
            return (Org.BouncyCastle.Asn1.DerBitString)Org.BouncyCastle.Asn1.DerBitString.FromAsn1Octets(octets:  val_6);
        }
        public DerBitString(byte[] data, int padBits)
        {
            var val_5;
            if(data == null)
            {
                goto label_1;
            }
            
            if(padBits >= 8)
            {
                goto label_2;
            }
            
            if(padBits != 0)
            {
                    if(data.Length == 0)
            {
                goto label_4;
            }
            
            }
            
            this.mData = Org.BouncyCastle.Utilities.Arrays.Clone(data:  data);
            this.mPadBits = padBits;
            return;
            label_1:
            System.ArgumentNullException val_2 = null;
            val_5 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "data");
            goto label_6;
            label_2:
            System.ArgumentException val_3 = null;
            val_5 = val_3;
            val_3 = new System.ArgumentException(message:  "must be in the range 0 to 7", paramName:  "padBits");
            goto label_6;
            label_4:
            System.ArgumentException val_4 = null;
            val_5 = val_4;
            val_4 = new System.ArgumentException(message:  "if \'data\' is empty, \'padBits\' must be 0");
            label_6:
        }
        public DerBitString(byte[] data)
        {
        
        }
        public DerBitString(int namedBits)
        {
            int val_8;
            System.Byte[] val_9;
            var val_10;
            int val_11;
            val_8 = namedBits;
            if(val_8 == 0)
            {
                goto label_1;
            }
            
            int val_1 = Org.BouncyCastle.Math.BigInteger.BitLen(w:  val_8);
            int val_2 = val_1 + 7;
            var val_4 = (val_2 < 0) ? (val_1 + 14) : (val_2);
            var val_5 = val_4 >> 3;
            val_9 = new byte[0];
            val_10 = 0;
            val_4 = ((long)(val_4 >> 3) & 536870911) - 1;
            goto label_4;
            label_7:
            val_9[0] = val_8;
            val_8 = val_8 >> 8;
            val_10 = 1;
            label_4:
            if(val_10 < val_4)
            {
                goto label_7;
            }
            
            val_9[val_4] = val_8;
            do
            {
                val_11 = 1;
                var val_7 = val_11 & 31;
                val_7 = 1 << val_7;
                val_7 = val_7 & val_8;
            }
            while(val_7 == 0);
            
            goto label_10;
            label_1:
            val_9 = new byte[0];
            val_11 = 0;
            label_10:
            this.mData = val_9;
            this.mPadBits = val_11;
        }
        public DerBitString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            System.Byte[] val_1 = obj.GetDerEncoded();
        }
        public virtual byte[] GetOctets()
        {
            if(this.mPadBits == 0)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.mData);
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "attempt to get non-octet aligned data from BIT STRING");
        }
        public virtual byte[] GetBytes()
        {
            System.Byte[] val_1 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.mData);
            if(this.mPadBits < 1)
            {
                    return val_1;
            }
            
            var val_3 = -4294967296;
            val_3 = val_3 + ((val_1.Length) << 32);
            int val_5 = this.mPadBits;
            val_5 = val_5 & 31;
            val_5 = 255 << val_5;
            val_5 = val_5 & (val_1[val_3 >> 32]);
            val_1[val_3 >> 32] = val_5;
            return val_1;
        }
        public virtual int get_PadBits()
        {
            return (int)this.mPadBits;
        }
        public virtual int get_IntValue()
        {
            var val_4;
            int val_1 = System.Math.Min(val1:  4, val2:  this.mData.Length);
            if(val_1 >= 1)
            {
                    var val_7 = 0;
                var val_6 = 0;
                do
            {
                byte val_5 = this.mData[val_6];
                val_6 = val_6 + 1;
                val_5 = val_5 << (val_7 & 24);
                val_4 = val_5 | 0;
                val_7 = val_7 + 8;
            }
            while(val_1 != val_6);
            
            }
            else
            {
                    val_4 = 0;
            }
            
            if(this.mPadBits < 1)
            {
                    return (int)val_4;
            }
            
            if(val_1 != this.mData.Length)
            {
                    return (int)val_4;
            }
            
            int val_8 = this.mPadBits;
            int val_3 = val_1 << 3;
            val_3 = val_3 + 24;
            val_8 = val_8 & 31;
            val_8 = 1 << val_8;
            val_8 = val_8 - 1;
            val_8 = val_8 << (val_3 & 24);
            val_4 = val_4 & (~val_8);
            return (int)val_4;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            int val_5 = this.mPadBits;
            if(val_5 >= 1)
            {
                    var val_5 = -4294967296;
                val_5 = val_5 + ((this.mData.Length) << 32);
                var val_1 = val_5 >> 32;
                val_5 = this.mPadBits;
                byte val_6 = this.mData[val_1];
                int val_2 = val_5 & 31;
                val_2 = 1 << val_2;
                val_2 = val_2 + 255;
                val_1 = val_2 & val_6;
                if(val_1 != 0)
            {
                    System.Byte[] val_3 = Org.BouncyCastle.Utilities.Arrays.Prepend(a:  this.mData, b:  val_5);
                var val_7 = -4294967296;
                val_6 = val_1 ^ val_6;
                val_7 = val_7 + ((val_3.Length) << 32);
                val_3[val_7 >> 32] = val_6;
                derOut.WriteEncoded(tag:  3, bytes:  val_3);
                return;
            }
            
            }
            
            derOut.WriteEncoded(tag:  3, first:  val_5 = this.mPadBits, bytes:  this.mData);
        }
        protected override int Asn1GetHashCode()
        {
            int val_2 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.mData);
            val_2 = val_2 ^ this.mPadBits.GetHashCode();
            return (int)val_2;
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerBitString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.mData, b:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerBitString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 16);
        }
        public override string GetString()
        {
            string val_8;
            var val_9;
            var val_10;
            System.Text.StringBuilder val_1 = null;
            val_8 = "#";
            val_1 = new System.Text.StringBuilder(value:  val_8);
            val_9 = 0;
            goto label_1;
            label_13:
            byte val_8 = this.GetDerEncoded()[0];
            val_10 = null;
            val_10 = null;
            val_8 = val_8 >> 4;
            System.Char[] val_3 = Org.BouncyCastle.Asn1.DerBitString.table + (((val_2[0x0][0] >> 4)) << 1);
            System.Text.StringBuilder val_4 = val_1.Append(value:  (Org.BouncyCastle.Asn1.DerBitString.table + ((val_2[0x0][0] >> 4)) << 1) + 32);
            var val_9 = val_2[0x0] + 32;
            var val_5 = val_9 & 15;
            val_9 = val_9 & 15;
            System.Char[] val_6 = Org.BouncyCastle.Asn1.DerBitString.table + (((val_2[0x0] + 32 & 15)) << 1);
            val_8 = (Org.BouncyCastle.Asn1.DerBitString.table + ((val_2[0x0] + 32 & 15)) << 1) + 32;
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
        internal static Org.BouncyCastle.Asn1.DerBitString FromAsn1Octets(byte[] octets)
        {
            var val_8;
            if(octets.Length > 0)
            {
                    byte val_8 = octets[0];
                System.Byte[] val_1 = Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  octets, from:  1, to:  octets.Length);
                if(((val_8 - 1) <= 6) && (val_1.Length != 0))
            {
                    var val_9 = -4294967296;
                val_9 = val_9 + ((val_1.Length) << 32);
                byte val_10 = val_1[val_9 >> 32];
                byte val_4 = val_8 & 31;
                val_4 = 1 << val_4;
                val_4 = val_4 + 255;
                val_10 = val_4 & val_10;
                if(val_10 != 0)
            {
                    Org.BouncyCastle.Asn1.BerBitString val_5 = null;
                val_8 = val_5;
                val_5 = new Org.BouncyCastle.Asn1.BerBitString(data:  val_1, padBits:  val_8);
                return (Org.BouncyCastle.Asn1.DerBitString)val_8;
            }
            
            }
            
                Org.BouncyCastle.Asn1.DerBitString val_6 = null;
                val_8 = val_6;
                val_6 = new Org.BouncyCastle.Asn1.DerBitString(data:  val_1, padBits:  val_8);
                return (Org.BouncyCastle.Asn1.DerBitString)val_8;
            }
            
            System.ArgumentException val_7 = new System.ArgumentException(message:  "truncated BIT STRING detected", paramName:  "octets");
        }
        private static DerBitString()
        {
            Org.BouncyCastle.Asn1.DerBitString.table = new char[16];
        }
    
    }

}
