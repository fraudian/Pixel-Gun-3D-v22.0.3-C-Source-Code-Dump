using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RsaPrivateCrtKeyParameters : RsaKeyParameters
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger e;
        private readonly Org.BouncyCastle.Math.BigInteger p;
        private readonly Org.BouncyCastle.Math.BigInteger q;
        private readonly Org.BouncyCastle.Math.BigInteger dP;
        private readonly Org.BouncyCastle.Math.BigInteger dQ;
        private readonly Org.BouncyCastle.Math.BigInteger qInv;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger PublicExponent { get; }
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger DP { get; }
        public Org.BouncyCastle.Math.BigInteger DQ { get; }
        public Org.BouncyCastle.Math.BigInteger QInv { get; }
        
        // Methods
        public RsaPrivateCrtKeyParameters(Org.BouncyCastle.Math.BigInteger modulus, Org.BouncyCastle.Math.BigInteger publicExponent, Org.BouncyCastle.Math.BigInteger privateExponent, Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger dP, Org.BouncyCastle.Math.BigInteger dQ, Org.BouncyCastle.Math.BigInteger qInv)
        {
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  publicExponent, name:  "publicExponent", desc:  "exponent");
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  p, name:  "p", desc:  "P value");
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  q, name:  "q", desc:  "Q value");
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  dP, name:  "dP", desc:  "DP value");
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  dQ, name:  "dQ", desc:  "DQ value");
            Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.ValidateValue(x:  qInv, name:  "qInv", desc:  "InverseQ value");
            this.e = publicExponent;
            this.p = p;
            this.q = q;
            this.dP = dP;
            this.dQ = dQ;
            this.qInv = qInv;
        }
        public Org.BouncyCastle.Math.BigInteger get_PublicExponent()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.e;
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.p;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.q;
        }
        public Org.BouncyCastle.Math.BigInteger get_DP()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.dP;
        }
        public Org.BouncyCastle.Math.BigInteger get_DQ()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.dQ;
        }
        public Org.BouncyCastle.Math.BigInteger get_QInv()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.qInv;
        }
        public override bool Equals(object obj)
        {
            Org.BouncyCastle.Math.BigInteger val_2;
            var val_3;
            var val_4;
            val_3 = this;
            if(val_3 == obj)
            {
                goto label_1;
            }
            
            if(obj == null)
            {
                goto label_19;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            val_2 = this.dP;
            val_2 = this.dQ;
            val_2 = this.p;
            val_2 = this.q;
            val_2 = this.e;
            val_3 = ???;
            val_2 = ???;
            goto (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 80 + 296;
            label_19:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_2 = this.qInv;
            Org.BouncyCastle.Math.BigInteger val_1 = this.dQ ^ this.dP;
            val_1 = val_1 ^ X22;
            val_1 = val_1 ^ X23;
            val_1 = val_1 ^ this.p;
            val_1 = val_1 ^ this.q;
            val_1 = val_1 ^ this.e;
            val_2 = val_1 ^ val_2;
            return (int)val_2;
        }
        private static void ValidateValue(Org.BouncyCastle.Math.BigInteger x, string name, string desc)
        {
            var val_5;
            var val_6;
            if(x == null)
            {
                goto label_1;
            }
            
            if(x.SignValue <= 0)
            {
                goto label_2;
            }
            
            return;
            label_1:
            val_5 = 1152921551372819008;
            val_6 = new System.ArgumentNullException(paramName:  name);
            goto label_3;
            label_2:
            val_5 = 1152921551372819008;
            val_6 = new System.ArgumentException(message:  "Not a valid RSA " + desc, paramName:  name);
            label_3:
        }
    
    }

}
