using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerEnumerated : Asn1Object
    {
        // Fields
        private readonly byte[] bytes;
        private static readonly Org.BouncyCastle.Asn1.DerEnumerated[] cache;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Value { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerEnumerated GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerEnumerated)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerEnumerated)obj;
        }
        public static Org.BouncyCastle.Asn1.DerEnumerated GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
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
            
            return Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(obj:  val_6);
            label_2:
            val_6 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(obj:  val_6);
            }
            
            label_3:
            if(val_6 != 0)
            {
                    val_5 = null;
                val_5 = 0;
                val_6 = 0;
                return (Org.BouncyCastle.Asn1.DerEnumerated)Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(enc:  val_6);
            }
            
            return (Org.BouncyCastle.Asn1.DerEnumerated)Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(enc:  val_6);
        }
        public DerEnumerated(int val)
        {
            this = new System.Object();
            this.bytes = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)val).ToByteArray();
        }
        public DerEnumerated(Org.BouncyCastle.Math.BigInteger val)
        {
            val_1 = new System.Object();
            this.bytes = val.ToByteArray();
        }
        public DerEnumerated(byte[] bytes)
        {
            val_1 = new System.Object();
            this.bytes = bytes;
        }
        public Org.BouncyCastle.Math.BigInteger get_Value()
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(bytes:  this.bytes);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  10, bytes:  this.bytes);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + -9223372029374496768) + -8) == 1152921505542680576) ? asn1Object : 0;
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            return Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.bytes);
        }
        internal static Org.BouncyCastle.Asn1.DerEnumerated FromOctetString(byte[] enc)
        {
            System.Byte[] val_8;
            var val_9;
            var val_10;
            Org.BouncyCastle.Asn1.DerEnumerated val_11;
            var val_12;
            val_8 = enc;
            if(enc.Length != 0)
            {
                    if(enc.Length == 1)
            {
                    val_9 = null;
                val_9 = null;
                if(val_8[0] < Org.BouncyCastle.Asn1.DerEnumerated.cache.Length)
            {
                    val_10 = null;
                val_10 = null;
                Org.BouncyCastle.Asn1.DerEnumerated[] val_1 = Org.BouncyCastle.Asn1.DerEnumerated.cache + ((enc[0]) << 3);
                val_11 = mem[(Org.BouncyCastle.Asn1.DerEnumerated.cache + (enc[0]) << 3) + 32];
                val_11 = (Org.BouncyCastle.Asn1.DerEnumerated.cache + (enc[0]) << 3) + 32;
                if(val_11 != 0)
            {
                    return (Org.BouncyCastle.Asn1.DerEnumerated)val_11;
            }
            
                val_12 = null;
                val_12 = null;
                val_8 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_8);
                Org.BouncyCastle.Asn1.DerEnumerated val_3 = null;
                val_11 = val_3;
                val_3 = new Org.BouncyCastle.Asn1.DerEnumerated();
                .bytes = val_8;
                Org.BouncyCastle.Asn1.DerEnumerated[] val_4 = Org.BouncyCastle.Asn1.DerEnumerated.cache + ((enc[0]) << 3);
                (Org.BouncyCastle.Asn1.DerEnumerated.cache + (enc[0]) << 3).__unknownFiledOffset_20 = val_11;
                return (Org.BouncyCastle.Asn1.DerEnumerated)val_11;
            }
            
            }
            
                val_8 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_8);
                Org.BouncyCastle.Asn1.DerEnumerated val_6 = null;
                val_11 = val_6;
                val_6 = new Org.BouncyCastle.Asn1.DerEnumerated();
                .bytes = val_8;
                return (Org.BouncyCastle.Asn1.DerEnumerated)val_11;
            }
            
            System.ArgumentException val_7 = new System.ArgumentException(message:  "ENUMERATED has zero length", paramName:  "enc");
        }
        private static DerEnumerated()
        {
            Org.BouncyCastle.Asn1.DerEnumerated.cache = new Org.BouncyCastle.Asn1.DerEnumerated[12];
        }
    
    }

}
