using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RsaKeyParameters : AsymmetricKeyParameter
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger modulus;
        private readonly Org.BouncyCastle.Math.BigInteger exponent;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger Modulus { get; }
        public Org.BouncyCastle.Math.BigInteger Exponent { get; }
        
        // Methods
        public RsaKeyParameters(bool isPrivate, Org.BouncyCastle.Math.BigInteger modulus, Org.BouncyCastle.Math.BigInteger exponent)
        {
            string val_6;
            var val_7;
            string val_9;
            string val_10;
            isPrivate = isPrivate;
            if(modulus == null)
            {
                goto label_1;
            }
            
            if(exponent == null)
            {
                goto label_2;
            }
            
            if(modulus.SignValue <= 0)
            {
                goto label_3;
            }
            
            if(exponent.SignValue <= 0)
            {
                goto label_4;
            }
            
            this.modulus = modulus;
            this.exponent = exponent;
            return;
            label_1:
            val_6 = "modulus";
            goto label_5;
            label_2:
            System.ArgumentNullException val_3 = null;
            val_6 = "exponent";
            label_5:
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  val_6);
            goto label_6;
            label_3:
            val_9 = "Not a valid RSA modulus";
            val_10 = "modulus";
            goto label_7;
            label_4:
            System.ArgumentException val_4 = null;
            val_9 = "Not a valid RSA exponent";
            val_10 = "exponent";
            label_7:
            val_7 = val_4;
            val_4 = new System.ArgumentException(message:  val_9, paramName:  val_10);
            label_6:
        }
        public Org.BouncyCastle.Math.BigInteger get_Modulus()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.modulus;
        }
        public Org.BouncyCastle.Math.BigInteger get_Exponent()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.exponent;
        }
        public override bool Equals(object obj)
        {
            var val_10;
            if(obj == null)
            {
                    return false;
            }
            
            var val_10 = null;
            val_10 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_10) ? obj : 0.IsPrivate;
            val_10 = val_10 ^ this.IsPrivate;
            if(val_10 == true)
            {
                    return false;
            }
            
            val_10 = mem[(System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24];
            val_10 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24;
            this = ???;
            val_10 = ???;
            goto (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 32 + 296;
        }
        public override int GetHashCode()
        {
            int val_3 = this.IsPrivate.GetHashCode();
            val_3 = this.exponent ^ this.modulus ^ val_3;
            return (int)val_3;
        }
    
    }

}
