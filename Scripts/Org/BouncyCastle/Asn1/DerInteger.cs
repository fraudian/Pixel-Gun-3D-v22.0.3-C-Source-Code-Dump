using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerInteger : Asn1Object
    {
        // Fields
        private readonly byte[] bytes;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Value { get; }
        public Org.BouncyCastle.Math.BigInteger PositiveValue { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerInteger GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerInteger)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerInteger)obj;
        }
        public static Org.BouncyCastle.Asn1.DerInteger GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            if(obj != null)
            {
                    if(isExplicit != false)
            {
                    return Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  obj.obj);
            }
            
                .bytes = Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  obj.obj);
                return (Org.BouncyCastle.Asn1.DerInteger)new Org.BouncyCastle.Asn1.DerInteger();
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "obj");
        }
        public DerInteger(int value)
        {
            this = new System.Object();
            this.bytes = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)value).ToByteArray();
        }
        public DerInteger(Org.BouncyCastle.Math.BigInteger value)
        {
            this = new System.Object();
            if(value != null)
            {
                    this.bytes = value.ToByteArray();
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "value");
        }
        public DerInteger(byte[] bytes)
        {
            val_1 = new System.Object();
            this.bytes = bytes;
        }
        public Org.BouncyCastle.Math.BigInteger get_Value()
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(bytes:  this.bytes);
        }
        public Org.BouncyCastle.Math.BigInteger get_PositiveValue()
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  this.bytes);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  2, bytes:  this.bytes);
        }
        protected override int Asn1GetHashCode()
        {
            return Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.bytes);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerInteger.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        public override string ToString()
        {
            if(this.Value == null)
            {
                
            }
        
        }
    
    }

}
