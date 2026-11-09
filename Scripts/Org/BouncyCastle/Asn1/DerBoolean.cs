using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerBoolean : Asn1Object
    {
        // Fields
        private readonly byte value;
        public static readonly Org.BouncyCastle.Asn1.DerBoolean False;
        public static readonly Org.BouncyCastle.Asn1.DerBoolean True;
        
        // Properties
        public bool IsTrue { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerBoolean GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerBoolean)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerBoolean)obj;
        }
        public static Org.BouncyCastle.Asn1.DerBoolean GetInstance(bool value)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = null;
            if(value != false)
            {
                    val_2 = null;
                val_3 = 1152921505542631432;
                return (Org.BouncyCastle.Asn1.DerBoolean)Org.BouncyCastle.Asn1.DerBoolean.__il2cppRuntimeField_static_fields;
            }
            
            val_4 = null;
            return (Org.BouncyCastle.Asn1.DerBoolean)Org.BouncyCastle.Asn1.DerBoolean.__il2cppRuntimeField_static_fields;
        }
        public static Org.BouncyCastle.Asn1.DerBoolean GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
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
            
            return Org.BouncyCastle.Asn1.DerBoolean.GetInstance(obj:  val_6);
            label_2:
            val_6 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerBoolean.GetInstance(obj:  val_6);
            }
            
            label_3:
            if(val_6 != 0)
            {
                    val_5 = null;
                val_5 = 0;
                val_6 = 0;
                return (Org.BouncyCastle.Asn1.DerBoolean)Org.BouncyCastle.Asn1.DerBoolean.FromOctetString(value:  val_6);
            }
            
            return (Org.BouncyCastle.Asn1.DerBoolean)Org.BouncyCastle.Asn1.DerBoolean.FromOctetString(value:  val_6);
        }
        public DerBoolean(byte[] val)
        {
            this = new System.Object();
            if(val.Length == 1)
            {
                    this.value = val[0];
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "byte value should have 1 byte in it", paramName:  "val");
        }
        private DerBoolean(bool value)
        {
            val_1 = new System.Object();
            this.value = (int)(value >> 0) & 1;
        }
        public bool get_IsTrue()
        {
            return (bool)(this.value != 0) ? 1 : 0;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = this.value;
            derOut.WriteEncoded(tag:  1, bytes:  val_1);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerBoolean.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            return (int)(this.value != 0) ? 1 : 0.GetHashCode();
        }
        public override string ToString()
        {
            return (string)(this.value == 0) ? "FALSE" : "TRUE";
        }
        internal static Org.BouncyCastle.Asn1.DerBoolean FromOctetString(byte[] value)
        {
            System.Byte[] val_3;
            var val_4;
            Org.BouncyCastle.Asn1.DerBoolean val_5;
            var val_6;
            val_3 = value;
            if(value.Length != 1)
            {
                goto label_2;
            }
            
            byte val_3 = val_3[0];
            if(val_3 == 0)
            {
                goto label_3;
            }
            
            if(val_3 != 255)
            {
                goto label_4;
            }
            
            val_3 = 1152921505542627328;
            val_4 = null;
            val_4 = null;
            val_5 = Org.BouncyCastle.Asn1.DerBoolean.True;
            return (Org.BouncyCastle.Asn1.DerBoolean)val_5;
            label_3:
            val_3 = 1152921505542627328;
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Asn1.DerBoolean.False;
            return (Org.BouncyCastle.Asn1.DerBoolean)val_5;
            label_4:
            Org.BouncyCastle.Asn1.DerBoolean val_1 = null;
            val_5 = val_1;
            val_1 = new Org.BouncyCastle.Asn1.DerBoolean(val:  val_3);
            return (Org.BouncyCastle.Asn1.DerBoolean)val_5;
            label_2:
            System.ArgumentException val_2 = new System.ArgumentException(message:  "BOOLEAN value should have 1 byte in it", paramName:  "value");
        }
        private static DerBoolean()
        {
            .value = 0;
            Org.BouncyCastle.Asn1.DerBoolean.False = new Org.BouncyCastle.Asn1.DerBoolean();
            .value = 255;
            Org.BouncyCastle.Asn1.DerBoolean.True = new Org.BouncyCastle.Asn1.DerBoolean();
        }
    
    }

}
