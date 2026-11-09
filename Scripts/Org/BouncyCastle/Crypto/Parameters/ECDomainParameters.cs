using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class ECDomainParameters
    {
        // Fields
        internal Org.BouncyCastle.Math.EC.ECCurve curve;
        internal byte[] seed;
        internal Org.BouncyCastle.Math.EC.ECPoint g;
        internal Org.BouncyCastle.Math.BigInteger n;
        internal Org.BouncyCastle.Math.BigInteger h;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECCurve Curve { get; }
        public Org.BouncyCastle.Math.EC.ECPoint G { get; }
        public Org.BouncyCastle.Math.BigInteger N { get; }
        public Org.BouncyCastle.Math.BigInteger H { get; }
        
        // Methods
        public ECDomainParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n)
        {
            null = null;
        }
        public ECDomainParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h)
        {
        
        }
        public ECDomainParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h, byte[] seed)
        {
            string val_5;
            val_1 = new System.Object();
            if(curve == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(n == null)
            {
                goto label_3;
            }
            
            if(h == null)
            {
                goto label_4;
            }
            
            this.curve = curve;
            this.g = val_1;
            this.n = n;
            this.h = h;
            this.seed = Org.BouncyCastle.Utilities.Arrays.Clone(data:  seed);
            return;
            label_1:
            val_5 = "curve";
            goto label_7;
            label_2:
            val_5 = "g";
            goto label_7;
            label_3:
            val_5 = "n";
            goto label_7;
            label_4:
            val_5 = "h";
            label_7:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        public Org.BouncyCastle.Math.EC.ECCurve get_Curve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)this.curve;
        }
        public Org.BouncyCastle.Math.EC.ECPoint get_G()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.g;
        }
        public Org.BouncyCastle.Math.BigInteger get_N()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.n;
        }
        public Org.BouncyCastle.Math.BigInteger get_H()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.h;
        }
        public byte[] GetSeed()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.seed);
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        protected virtual bool Equals(Org.BouncyCastle.Crypto.Parameters.ECDomainParameters other)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_7;
            var val_8;
            val_7 = this.curve;
            val_8 = other;
            if((val_7 & 1) == 0)
            {
                    return false;
            }
            
            val_7 = this.g;
            if((val_7 & 1) == 0)
            {
                    return false;
            }
            
            val_7 = this.n;
            if((val_7 & 1) == 0)
            {
                    return false;
            }
            
            val_8 = ???;
            val_7 = ???;
            goto Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_vtable;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_3 = this.h;
            Org.BouncyCastle.Math.EC.ECCurve val_1 = this.curve * 37;
            val_1 = this.g ^ val_1;
            val_1 = val_1 * 37;
            val_1 = this.n ^ val_1;
            val_3 = val_3 ^ (val_1 * 37);
            return (int)val_3;
        }
    
    }

}
