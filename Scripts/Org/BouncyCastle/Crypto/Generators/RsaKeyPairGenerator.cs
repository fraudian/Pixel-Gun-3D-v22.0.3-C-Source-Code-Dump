using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    public class RsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
    {
        // Fields
        private static readonly int[] SPECIAL_E_VALUES;
        private static readonly int SPECIAL_E_HIGHEST;
        private static readonly int SPECIAL_E_BITS;
        protected static readonly Org.BouncyCastle.Math.BigInteger One;
        protected static readonly Org.BouncyCastle.Math.BigInteger DefaultPublicExponent;
        protected const int DefaultTests = 100;
        protected Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters parameters;
        
        // Methods
        public virtual void Init(Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
        {
            Org.BouncyCastle.Math.BigInteger val_2;
            Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters val_3;
            var val_4;
            Org.BouncyCastle.Security.SecureRandom val_5;
            val_3 = parameters;
            val_4 = null;
            val_4 = null;
            val_2 = Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.DefaultPublicExponent;
            if(val_3 != null)
            {
                    val_5 = parameters.random;
            }
            else
            {
                    val_5 = 11993091;
            }
            
            Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters val_1 = null;
            val_3 = val_1;
            val_1 = new Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters(publicExponent:  val_2, random:  val_5, strength:  parameters.strength, certainty:  100);
            this.parameters = val_3;
        }
        public virtual Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
        {
            Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters val_37;
            var val_39;
            var val_40;
            Org.BouncyCastle.Math.BigInteger val_41;
            Org.BouncyCastle.Math.BigInteger val_42;
            label_26:
            val_37 = this.parameters;
            if(this.parameters == null)
            {
                    val_37 = this.parameters;
            }
            
            var val_3 = X26 * 1431655766;
            var val_4 = ((W26 + 1) < 0) ? (W26 + 2) : (W26 + 1);
            var val_6 = val_4 >> 1;
            var val_8 = val_3 >> 32;
            Org.BouncyCastle.Math.BigInteger val_11 = val_37.PublicExponent;
            goto label_3;
            label_15:
            label_3:
            val_39 = this;
            goto label_4;
            label_12:
            Org.BouncyCastle.Math.BigInteger val_12 = val_8.Max(value:  X25);
            label_4:
            do
            {
            
            }
            while((val_12.Subtract(n:  val_12).Abs().BitLength) < (val_8 + (val_3 >> 63)));
            
            Org.BouncyCastle.Math.BigInteger val_16 = val_12.Multiply(val:  this);
            if(val_16.BitLength != W26)
            {
                goto label_12;
            }
            
            if((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_16)) < (W26 >> 2))
            {
                goto label_15;
            }
            
            int val_19 = val_12.CompareTo(value:  this);
            Org.BouncyCastle.Math.BigInteger val_20 = (val_19 >= 0) ? (this) : (val_12);
            val_40 = null;
            Org.BouncyCastle.Math.BigInteger val_21 = (val_19 >= 0) ? (val_12) : (this);
            val_40 = null;
            Org.BouncyCastle.Math.BigInteger val_22 = val_21.Subtract(n:  Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One);
            Org.BouncyCastle.Math.BigInteger val_23 = val_20.Subtract(n:  Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One);
            if(val_22 != null)
            {
                    val_41 = val_22.Gcd(value:  val_23);
            }
            else
            {
                    val_41 = 0.Gcd(value:  val_23);
            }
            
            Org.BouncyCastle.Math.BigInteger val_28 = val_11.ModInverse(m:  val_22.Divide(val:  val_41).Multiply(val:  val_23));
            if(val_28.BitLength <= (W26 - (val_4 >> 1)))
            {
                goto label_26;
            }
            
            if(val_28 != null)
            {
                    val_42 = val_28.Remainder(n:  val_22);
                return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_16, exponent:  val_11), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(modulus:  val_16, publicExponent:  val_11, privateExponent:  val_28, p:  val_21, q:  val_20, dP:  val_42 = 0.Remainder(n:  val_22), dQ:  val_28.Remainder(n:  val_23), qInv:  val_20.ModInverse(m:  val_21)));
            }
            
            return (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)new Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter:  new Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(isPrivate:  false, modulus:  val_16, exponent:  val_11), privateParameter:  new Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(modulus:  val_16, publicExponent:  val_11, privateExponent:  val_28, p:  val_21, q:  val_20, dP:  val_42, dQ:  val_28.Remainder(n:  val_23), qInv:  val_20.ModInverse(m:  val_21)));
        }
        protected virtual Org.BouncyCastle.Math.BigInteger ChooseRandomPrime(int bitlength, Org.BouncyCastle.Math.BigInteger e)
        {
            var val_11;
            var val_13;
            var val_14;
            int val_15;
            var val_16;
            val_11 = null;
            val_11 = null;
            if(e.BitLength > Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_BITS)
            {
                    val_13 = 1;
            }
            else
            {
                    val_13 = (Org.BouncyCastle.Utilities.Arrays.Contains(a:  Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.__il2cppRuntimeField_static_fields, n:  e.IntValue)) ^ 1;
            }
            
            do
            {
                Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(bitLength:  bitlength, certainty:  1, random:  X23);
                val_14 = null;
                val_14 = null;
            }
            while(((val_4.Mod(m:  e)) & 1) != 0);
            
            val_15 = this.parameters.Certainty;
            if((val_4.IsProbablePrime(certainty:  val_15, randomlySelected:  true)) != false)
            {
                    if(val_13 == false)
            {
                    return val_4;
            }
            
                val_16 = null;
                val_16 = null;
                val_15 = Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One;
                if(((e.Gcd(value:  val_4.Subtract(n:  Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One))) & 1) != 0)
            {
                    return val_4;
            }
            
            }
        
        }
        public RsaKeyPairGenerator()
        {
        
        }
        private static RsaKeyPairGenerator()
        {
            Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.DefaultTests = new int[5] {3, 5, 17, 257, 65537};
            var val_7 = -4294967296;
            val_7 = val_7 + ((mem[1152921551468435240]) << 32);
            var val_2 = val_7 >> 32;
            System.Int32[] val_3 = Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.DefaultTests + ((((-4294967296 + (mem[1152921551468435240]) << 32) >> 32)) << 2);
            Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_HIGHEST = (val_1 + (((-4294967296 + (mem[1152921551468435240]) << 32) >> 32)) << 2) + 32;
            Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_BITS = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.SPECIAL_E_HIGHEST).BitLength;
            Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.One = Org.BouncyCastle.Math.BigInteger.One;
            Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator.DefaultPublicExponent = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  65537);
        }
    
    }

}
