using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerExternal : Asn1Object
    {
        // Fields
        private Org.BouncyCastle.Asn1.DerObjectIdentifier directReference;
        private Org.BouncyCastle.Asn1.DerInteger indirectReference;
        private Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor;
        private int encoding;
        private Org.BouncyCastle.Asn1.Asn1Object externalContent;
        
        // Properties
        public Org.BouncyCastle.Asn1.Asn1Object DataValueDescriptor { get; set; }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier DirectReference { get; set; }
        public int Encoding { get; set; }
        public Org.BouncyCastle.Asn1.Asn1Object ExternalContent { get; set; }
        public Org.BouncyCastle.Asn1.DerInteger IndirectReference { get; set; }
        
        // Methods
        public DerExternal(Org.BouncyCastle.Asn1.Asn1EncodableVector vector)
        {
            Org.BouncyCastle.Asn1.DerInteger val_10;
            int val_11;
            string val_14;
            var val_15;
            this = new System.Object();
            val_10 = Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(v:  vector, index:  0);
            if(val_10 == null)
            {
                goto label_1;
            }
            
            val_11 = 0;
            val_11 = val_11 + 1;
            this.indirectReference = val_10;
            val_10 = Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(v:  vector, index:  val_11);
            if(val_10 == null)
            {
                goto label_19;
            }
            
            label_17:
            if(vector.Count != (val_11 + 1))
            {
                goto label_10;
            }
            
            if(val_10 == null)
            {
                goto label_13;
            }
            
            this.Encoding = val_11;
            if(this.encoding >= 3)
            {
                goto label_14;
            }
            
            this.externalContent = this.ToAsn1Object();
            return;
            label_1:
            val_11 = 0;
            label_19:
            val_11 = val_11 + 1;
            this.dataValueDescriptor = val_10;
            Org.BouncyCastle.Asn1.Asn1Object val_7 = Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(v:  vector, index:  val_11);
            if(vector != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_13:
            val_14 = "No tagged object found in vector. Structure doesn\'t seem to be of type External";
            goto label_20;
            label_10:
            System.ArgumentException val_9 = null;
            val_14 = "input vector too large";
            label_20:
            val_15 = val_9;
            val_9 = new System.ArgumentException(message:  val_14, paramName:  "vector");
            goto label_21;
            label_14:
            System.InvalidOperationException val_10 = null;
            val_15 = val_10;
            val_10 = new System.InvalidOperationException(message:  "invalid encoding value");
            label_21:
        }
        public DerExternal(Org.BouncyCastle.Asn1.DerObjectIdentifier directReference, Org.BouncyCastle.Asn1.DerInteger indirectReference, Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor, Org.BouncyCastle.Asn1.DerTaggedObject externalData)
        {
            var val_2;
            if(externalData != null)
            {
                
            }
            else
            {
                    val_2 = 11993091;
            }
            
            Org.BouncyCastle.Asn1.Asn1Object val_1 = externalData.ToAsn1Object();
        }
        public DerExternal(Org.BouncyCastle.Asn1.DerObjectIdentifier directReference, Org.BouncyCastle.Asn1.DerInteger indirectReference, Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor, int encoding, Org.BouncyCastle.Asn1.Asn1Object externalData)
        {
            val_1 = new System.Object();
            this.directReference = directReference;
            this.indirectReference = indirectReference;
            this.dataValueDescriptor = val_1;
            this.Encoding = encoding;
            this.externalContent = externalData;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms:  val_1, e:  this.directReference);
            Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms:  val_1, e:  this.indirectReference);
            Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms:  val_1, e:  this.dataValueDescriptor);
            Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms:  val_1, e:  new Org.BouncyCastle.Asn1.DerTaggedObject(tagNo:  8, obj:  this.externalContent));
            derOut.WriteEncoded(flags:  32, tagNo:  8, bytes:  val_1);
        }
        protected override int Asn1GetHashCode()
        {
            var val_5;
            var val_6;
            val_5 = public System.Int32 Org.BouncyCastle.Asn1.Asn1Encodable::GetHashCode();
            val_6 = this.externalContent.GetHashCode();
            if(this.directReference != null)
            {
                    val_5 = public System.Int32 Org.BouncyCastle.Asn1.Asn1Encodable::GetHashCode();
                val_6 = this.directReference.GetHashCode() ^ val_6;
            }
            
            if(this.indirectReference != null)
            {
                    val_5 = public System.Int32 Org.BouncyCastle.Asn1.Asn1Encodable::GetHashCode();
                val_6 = this.indirectReference.GetHashCode() ^ val_6;
            }
            
            if(this.dataValueDescriptor == null)
            {
                    return (int)val_6;
            }
            
            val_6 = this.dataValueDescriptor.GetHashCode() ^ val_6;
            return (int)val_6;
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            var val_5;
            if(this != asn1Object)
            {
                    if(asn1Object != null)
            {
                    var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
                if(((System.Object.Equals(objA:  this.directReference, objB:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 16)) != false) && ((System.Object.Equals(objA:  this.indirectReference, objB:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 24)) != false))
            {
                    if((System.Object.Equals(objA:  this.dataValueDescriptor, objB:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 32)) != false)
            {
                    if(this.externalContent != null)
            {
                    return this.externalContent.Equals(obj:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 48);
            }
            
                return this.externalContent.Equals(obj:  (Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerExternal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? asn1Object : 0 + 48);
            }
            
            }
            
            }
            
                val_5 = 0;
                return (bool)val_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        public Org.BouncyCastle.Asn1.Asn1Object get_DataValueDescriptor()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.dataValueDescriptor;
        }
        public void set_DataValueDescriptor(Org.BouncyCastle.Asn1.Asn1Object value)
        {
            this.dataValueDescriptor = value;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier get_DirectReference()
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)this.directReference;
        }
        public void set_DirectReference(Org.BouncyCastle.Asn1.DerObjectIdentifier value)
        {
            this.directReference = value;
        }
        public int get_Encoding()
        {
            return (int)this.encoding;
        }
        public void set_Encoding(int value)
        {
            if(this.encoding < 3)
            {
                    this.encoding = value;
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "invalid encoding value: "("invalid encoding value: ") + this.encoding);
        }
        public Org.BouncyCastle.Asn1.Asn1Object get_ExternalContent()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.externalContent;
        }
        public void set_ExternalContent(Org.BouncyCastle.Asn1.Asn1Object value)
        {
            this.externalContent = value;
        }
        public Org.BouncyCastle.Asn1.DerInteger get_IndirectReference()
        {
            return (Org.BouncyCastle.Asn1.DerInteger)this.indirectReference;
        }
        public void set_IndirectReference(Org.BouncyCastle.Asn1.DerInteger value)
        {
            this.indirectReference = value;
        }
        private static Org.BouncyCastle.Asn1.Asn1Object GetObjFromVector(Org.BouncyCastle.Asn1.Asn1EncodableVector v, int index)
        {
            if(v.Count > index)
            {
                    if(v.Item[index] != null)
            {
                goto typeof(Org.BouncyCastle.Asn1.Asn1Encodable).__il2cppRuntimeField_178;
            }
            
            }
            else
            {
                    System.ArgumentException val_3 = new System.ArgumentException(message:  "too few objects in input vector", paramName:  "v");
            }
        
        }
        private static void WriteEncodable(System.IO.MemoryStream ms, Org.BouncyCastle.Asn1.Asn1Encodable e)
        {
            System.IO.MemoryStream val_6 = ms;
            if(e == null)
            {
                    return;
            }
            
            if(e.GetDerEncoded() == null)
            {
                goto label_1;
            }
            
            label_4:
            val_6 = ???;
            goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_328;
            label_1:
            if(val_6 != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
    
    }

}
