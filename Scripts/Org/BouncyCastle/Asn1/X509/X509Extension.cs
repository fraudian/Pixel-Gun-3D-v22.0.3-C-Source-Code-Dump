using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509Extension
    {
        // Fields
        internal bool critical;
        internal Org.BouncyCastle.Asn1.Asn1OctetString value;
        
        // Properties
        public bool IsCritical { get; }
        public Org.BouncyCastle.Asn1.Asn1OctetString Value { get; }
        
        // Methods
        public X509Extension(Org.BouncyCastle.Asn1.DerBoolean critical, Org.BouncyCastle.Asn1.Asn1OctetString value)
        {
            if(critical != null)
            {
                    this.critical = critical.IsTrue;
                this.value = value;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "critical");
        }
        public X509Extension(bool critical, Org.BouncyCastle.Asn1.Asn1OctetString value)
        {
            this.critical = critical;
            this.value = value;
        }
        public bool get_IsCritical()
        {
            return (bool)this.critical;
        }
        public Org.BouncyCastle.Asn1.Asn1OctetString get_Value()
        {
            return (Org.BouncyCastle.Asn1.Asn1OctetString)this.value;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable GetParsedValue()
        {
            return Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject(ext:  this);
        }
        public override int GetHashCode()
        {
            int val_1 = this.value.GetHashCode();
            bool val_2 = this.critical;
            val_2 = val_2 - 1;
            val_1 = val_1 ^ val_2;
            return (int)val_1;
        }
        public override bool Equals(object obj)
        {
            object val_6;
            var val_7;
            if(obj != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.X509.X509Extension.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
                val_6 = mem[(System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.X509.X509Extension.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24];
                val_6 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.X509.X509Extension.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24;
                if((this.value.Equals(obj:  val_6)) != false)
            {
                    var val_3 = (this.critical == true) ? 1 : 0;
                val_3 = val_3 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.X509.X509Extension.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 16) != 0) ? 1 : 0);
                val_7 = val_3 ^ 1;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public static Org.BouncyCastle.Asn1.Asn1Object ConvertValueToObject(Org.BouncyCastle.Asn1.X509.X509Extension ext)
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  ext.value);
        }
    
    }

}
