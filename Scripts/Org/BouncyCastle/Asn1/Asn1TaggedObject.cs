using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1TaggedObject : Asn1Object, Asn1TaggedObjectParser, IAsn1Convertible
    {
        // Fields
        internal int tagNo;
        internal bool explicitly;
        internal Org.BouncyCastle.Asn1.Asn1Encodable obj;
        
        // Properties
        public int TagNo { get; }
        
        // Methods
        internal static bool IsConstructed(bool isExplicit, Org.BouncyCastle.Asn1.Asn1Object obj)
        {
            var val_5;
            var val_6;
            var val_8;
            val_5 = obj;
            val_6 = isExplicit;
            if(((( != 0) ? 1 : 0) & 1) == 0)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        public static Org.BouncyCastle.Asn1.Asn1TaggedObject GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_4;
            if(explicitly != false)
            {
                    val_4 = obj.obj;
                if(val_4 == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1TaggedObject)val_4;
            }
            
                if(val_4 == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1TaggedObject)val_4;
            }
            
                val_4 = 0;
                return (Org.BouncyCastle.Asn1.Asn1TaggedObject)val_4;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "implicitly tagged tagged object");
        }
        public static Org.BouncyCastle.Asn1.Asn1TaggedObject GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
            }
            
            return (Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
        }
        protected Asn1TaggedObject(int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            this.explicitly = true;
            val_1 = new System.Object();
            this.explicitly = true;
            this.tagNo = tagNo;
            this.obj = val_1;
        }
        protected Asn1TaggedObject(bool explicitly, int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            this.explicitly = true;
            val_1 = new System.Object();
            this.explicitly = (val_1 != 0) ? 1 : 0;
            this.tagNo = tagNo;
            this.obj = val_1;
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.Asn1TaggedObject.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            var val_2 = (this.explicitly == true) ? 1 : 0;
            val_2 = val_2 ^ ((((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.Asn1TaggedObject.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 20) != 0) ? 1 : 0);
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            int val_2 = this.tagNo.GetHashCode();
            if(this.obj == null)
            {
                    return (int)val_2;
            }
            
            val_2 = this.obj ^ val_2;
            return (int)val_2;
        }
        public int get_TagNo()
        {
            return (int)this.tagNo;
        }
        public bool IsExplicit()
        {
            return (bool)this.explicitly;
        }
        public bool IsEmpty()
        {
            return false;
        }
        public Org.BouncyCastle.Asn1.Asn1Object GetObject()
        {
            if(this.obj == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)this.obj;
            }
            
            goto typeof(Org.BouncyCastle.Asn1.Asn1Encodable).__il2cppRuntimeField_178;
        }
        public Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
        {
            bool val_16;
            object val_17;
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_18;
            var val_19;
            val_16 = isExplicit;
            val_17 = tag;
            val_18 = this;
            if(val_17 == 4)
            {
                goto label_1;
            }
            
            if(val_17 == 16)
            {
                goto label_2;
            }
            
            if(val_17 != 17)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Asn1.Asn1Set val_2 = Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj:  this, explicitly:  val_16);
            if(val_2 != null)
            {
                    return val_2.Parser;
            }
            
            return val_2.Parser;
            label_1:
            val_19 = Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  this, isExplicit:  val_16);
            if(val_19 != null)
            {
                    return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_19;
            }
            
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_19;
            label_2:
            Org.BouncyCastle.Asn1.Asn1Sequence val_6 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  this, explicitly:  val_16);
            val_16 = ???;
            val_18 = ???;
            val_17 = ???;
            goto typeof(Org.BouncyCastle.Asn1.Asn1Sequence).__il2cppRuntimeField_1D8;
            label_3:
            if((val_16 & 1) != 0)
            {
                    if((val_18 + 24) != 0)
            {
                    val_19 = val_18 + 24;
                return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_19;
            }
            
                val_19 = 0;
                return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_19;
            }
            
            System.Exception val_14 = Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException(message:  "implicit tagging for tag: "("implicit tagging for tag: ") + val_17);
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            val_1[0] = "[";
            val_1[1] = this.tagNo;
            val_1[2] = "]";
            val_1[3] = this.obj;
            return (string)+val_1;
        }
    
    }

}
