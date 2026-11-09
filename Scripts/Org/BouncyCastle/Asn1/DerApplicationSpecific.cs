using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerApplicationSpecific : Asn1Object
    {
        // Fields
        private readonly bool isConstructed;
        private readonly int tag;
        private readonly byte[] octets;
        
        // Properties
        public int ApplicationTag { get; }
        
        // Methods
        internal DerApplicationSpecific(bool isConstructed, int tag, byte[] octets)
        {
            val_1 = new System.Object();
            this.tag = tag;
            this.isConstructed = isConstructed;
            this.octets = octets;
        }
        public DerApplicationSpecific(int tag, byte[] octets)
        {
            val_1 = new System.Object();
            this.isConstructed = false;
            this.tag = tag;
            this.octets = octets;
        }
        public DerApplicationSpecific(int tag, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        public DerApplicationSpecific(bool isExplicit, int tag, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            System.Byte[] val_8;
            val_1 = new System.Object();
            bool val_3 = isExplicit;
            val_8 = val_1.GetDerEncoded();
            bool val_4 = Org.BouncyCastle.Asn1.Asn1TaggedObject.IsConstructed(isExplicit:  val_3, obj:  Org.BouncyCastle.Asn1.Asn1Encodable val_1 = obj);
            this.isConstructed = val_4;
            this.tag = tag;
            if(val_3 != true)
            {
                    System.Byte[] val_8 = val_8;
                int val_6 = val_4.GetLengthOfHeader(data:  val_8);
                val_8 = val_2.Length - val_6;
                byte[] val_7 = new byte[0];
                System.Array.Copy(sourceArray:  val_8, sourceIndex:  val_6, destinationArray:  val_7, destinationIndex:  0, length:  val_7.Length);
                val_8 = val_7;
            }
            
            this.octets = val_8;
        }
        public DerApplicationSpecific(int tagNo, Org.BouncyCastle.Asn1.Asn1EncodableVector vec)
        {
            var val_6;
            val_1 = new System.Object();
            this.tag = tagNo;
            this.isConstructed = true;
            val_6 = 0;
            goto label_1;
            label_7:
            System.Byte[] val_4 = val_1.Item[0].GetDerEncoded();
            val_6 = 1;
            label_1:
            if(val_6 != val_1.Count)
            {
                goto label_7;
            }
            
            this.octets = new System.IO.MemoryStream();
        }
        private int GetLengthOfHeader(byte[] data)
        {
            byte val_4 = data[0];
            if(val_4 == 128)
            {
                    return 2;
            }
            
            var val_5 = (int)val_4 & 255;
            val_5 = 3 & (~(val_5 >> 7));
            if(val_5 != 0)
            {
                    return 2;
            }
            
            val_4 = val_4 & 127;
            if(val_4 < 5)
            {
                    byte val_1 = val_4 + 2;
                return 2;
            }
            
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "DER length more than 4 bytes: "("DER length more than 4 bytes: ") + val_4);
        }
        public bool IsConstructed()
        {
            return (bool)this.isConstructed;
        }
        public byte[] GetContents()
        {
            return (System.Byte[])this.octets;
        }
        public int get_ApplicationTag()
        {
            return (int)this.tag;
        }
        public Org.BouncyCastle.Asn1.Asn1Object GetObject()
        {
            return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  this.octets);
        }
        public Org.BouncyCastle.Asn1.Asn1Object GetObject(int derTagNo)
        {
            if(derTagNo < 31)
            {
                    System.Byte[] val_1 = this.GetEncoded();
                System.Byte[] val_2 = val_1.ReplaceTagNumber(newTag:  derTagNo, input:  val_1);
                if((val_1[0] & 32) == 0)
            {
                    return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_2);
            }
            
                byte val_5 = val_2[0];
                val_5 = val_5 | 32;
                val_2[0] = val_5;
                return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_2);
            }
            
            System.IO.IOException val_3 = new System.IO.IOException(message:  "unsupported tag number");
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(flags:  (this.isConstructed == true) ? 96 : 64, tagNo:  this.tag, bytes:  this.octets);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerApplicationSpecific.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            var val_3 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerApplicationSpecific.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 16) != 0) ? 1 : 0;
            val_3 = ((this.isConstructed == true) ? 1 : 0) ^ val_3;
            return Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.octets, b:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerApplicationSpecific.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 24);
        }
        protected override int Asn1GetHashCode()
        {
            int val_3 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.octets);
            val_3 = this.tag.GetHashCode() ^ this.isConstructed.GetHashCode() ^ val_3;
            return (int)val_3;
        }
        private byte[] ReplaceTagNumber(int newTag, byte[] input)
        {
            int val_6;
            var val_7;
            val_6 = 1;
            var val_8 = ~input[0];
            val_8 = val_8 & 31;
            if(val_8 != 0)
            {
                goto label_7;
            }
            
            byte val_9 = input[0];
            if((val_9 & 127) == 0)
            {
                goto label_5;
            }
            
            if((val_9 & 128) == 0)
            {
                    val_6 = 2;
            }
            else
            {
                    do
            {
                val_6 = 2 + 1;
            }
            while((input[2] & 2147483648) != 0);
            
            }
            
            label_7:
            int val_3 = (1 - val_6) + input.Length;
            byte[] val_4 = new byte[0];
            if(val_4 != null)
            {
                    val_7 = val_4;
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_6, destinationArray:  val_4, destinationIndex:  1, length:  val_4.Length - 1);
            }
            else
            {
                    val_7 = 24;
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_6, destinationArray:  0, destinationIndex:  1, length:  28563615);
            }
            
            val_4[0] = newTag;
            return (System.Byte[])val_4;
            label_5:
            System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "corrupted stream - invalid high tag number found");
        }
    
    }

}
