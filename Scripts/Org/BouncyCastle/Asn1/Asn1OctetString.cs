using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1OctetString : Asn1Object, Asn1OctetStringParser, IAsn1Convertible
    {
        // Fields
        internal byte[] str;
        
        // Properties
        public Org.BouncyCastle.Asn1.Asn1OctetStringParser Parser { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Asn1OctetString GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            if(isExplicit == false)
            {
                    return Org.BouncyCastle.Asn1.BerOctetString.FromSequence(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj.obj));
            }
            
            return Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  obj.obj);
        }
        public static Org.BouncyCastle.Asn1.Asn1OctetString GetInstance(object obj)
        {
            object val_5 = obj;
            if(val_5 == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1OctetString)val_5;
            }
            
            val_5 = 9821;
            return (Org.BouncyCastle.Asn1.Asn1OctetString)val_5;
        }
        internal Asn1OctetString(byte[] str)
        {
            this = new System.Object();
            if(str != null)
            {
                    this.str = str;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "str");
        }
        internal Asn1OctetString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            this = new System.Object();
            this.str = obj.GetEncoded(encoding:  "DER");
        }
        public System.IO.Stream GetOctetStream()
        {
            return (System.IO.Stream)new System.IO.MemoryStream(buffer:  this.str, writable:  false);
        }
        public Org.BouncyCastle.Asn1.Asn1OctetStringParser get_Parser()
        {
            return (Org.BouncyCastle.Asn1.Asn1OctetStringParser)this;
        }
        public virtual byte[] GetOctets()
        {
            return (System.Byte[])this.str;
        }
        protected override int Asn1GetHashCode()
        {
            return Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            System.Byte[] val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerOctetString.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        public override string ToString()
        {
            return "#" + Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  this.str)(Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  this.str));
        }
    
    }

}
