using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerOctetString : DerOctetString, IEnumerable
    {
        // Fields
        private const int MaxLength = 1000;
        private readonly System.Collections.IEnumerable octs;
        
        // Methods
        public static Org.BouncyCastle.Asn1.BerOctetString FromSequence(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_10;
            object val_13;
            var val_15;
            var val_16;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = 0;
            if(seq.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_10 = 1;
            val_13 = seq.Current;
            if(val_13 != null)
            {
                    val_10 = 0;
                val_13 = 0;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_10 = 2;
            int val_9 = val_1.Add(value:  val_13);
            goto label_23;
            label_9:
            val_15 = 0;
            val_16 = 0;
            if(seq != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                seq.Dispose();
            }
            
            new Org.BouncyCastle.Asn1.BerOctetString() = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  Org.BouncyCastle.Asn1.BerOctetString.ToBytes(octs:  val_1));
            .octs = val_1;
            return (Org.BouncyCastle.Asn1.BerOctetString)new Org.BouncyCastle.Asn1.BerOctetString();
        }
        private static byte[] ToBytes(System.Collections.IEnumerable octs)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.IEnumerator val_3 = octs.GetEnumerator();
            label_25:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = public System.Object System.Collections.IEnumerator::get_Current();
            val_14 = val_3.Current;
            if(val_14 != null)
            {
                    val_13 = 0;
            }
            
            if(val_14 != null)
            {
                    val_13 = null;
                val_13 = 0;
                val_14 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_11:
            val_15 = 0;
            val_16 = 0;
            if(val_3 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            if(val_1 != null)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        public BerOctetString(byte[] str)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  str);
        }
        public BerOctetString(System.Collections.IEnumerable octets)
        {
            this = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  Org.BouncyCastle.Asn1.BerOctetString.ToBytes(octs:  octets));
            this.octs = octets;
        }
        public BerOctetString(Org.BouncyCastle.Asn1.Asn1Object obj)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1OctetString(obj:  obj);
        }
        public BerOctetString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            this = new Org.BouncyCastle.Asn1.Asn1OctetString(obj:  obj);
        }
        public override byte[] GetOctets()
        {
            return (System.Byte[])this;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            System.Collections.IEnumerable val_3 = this.octs;
            if(val_3 == null)
            {
                    val_3 = this.GenerateOcts();
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            return val_3.GetEnumerator();
        }
        public System.Collections.IEnumerator GetObjects()
        {
            return this.GetEnumerator();
        }
        private System.Collections.IList GenerateOcts()
        {
            var val_7;
            System.Array val_8;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_7 = 0;
            goto label_3;
            label_14:
            int val_3 = (System.Math.Min(val1:  X21 + 24, val2:  1000)) - val_7;
            byte[] val_4 = new byte[0];
            val_8 = val_4;
            System.Array.Copy(sourceArray:  X24, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  val_4.Length);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 2;
            int val_7 = val_1.Add(value:  new Org.BouncyCastle.Asn1.DerOctetString(str:  val_4));
            val_7 = 1000;
            label_3:
            if(val_7 < 487)
            {
                goto label_14;
            }
            
            return val_1;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            var val_10;
            var val_11;
            var val_12;
            this.Encode(derOut:  derOut);
            return;
            label_20:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = Current;
            if(val_10 == null)
            {
                goto label_20;
            }
            
            val_10 = 0;
            goto label_20;
            label_11:
            val_11 = 0;
            val_12 = 0;
            if( != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                Dispose();
            }
            
            derOut.WriteByte(value:  0);
            derOut.WriteByte(value:  0);
        }
    
    }

}
