using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    internal class DHKeyGeneratorHelper
    {
        // Fields
        internal static readonly Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper Instance;
        
        // Methods
        private DHKeyGeneratorHelper()
        {
        
        }
        internal Org.BouncyCastle.Math.BigInteger CalculatePrivate(Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, Org.BouncyCastle.Security.SecureRandom random)
        {
            var val_13;
            int val_14;
            Org.BouncyCastle.Math.BigInteger val_15;
            var val_16;
            Org.BouncyCastle.Math.BigInteger val_18;
            Org.BouncyCastle.Math.BigInteger val_19;
            var val_20;
            if(dhParams.l != 0)
            {
                    val_13 = dhParams.l >> 2;
                val_14 = dhParams.l - 1;
                do
            {
                val_15 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  dhParams.l, random:  random).SetBit(n:  val_14);
            }
            while((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_15)) < val_13);
            
                return val_15;
            }
            
            val_16 = null;
            val_16 = null;
            if(dhParams.m != 0)
            {
                    val_18 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  dhParams.m - 1);
            }
            else
            {
                    val_18 = Org.BouncyCastle.Math.BigInteger.Two;
            }
            
            val_19 = dhParams.q;
            if(val_19 == null)
            {
                    val_19 = dhParams.p;
            }
            
            val_20 = null;
            val_20 = null;
            val_14 = val_19.Subtract(n:  Org.BouncyCastle.Math.BigInteger.Two);
            val_13 = val_14.BitLength >> 2;
            do
            {
                val_15 = Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(min:  val_18, max:  val_14, random:  random);
            }
            while((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_15)) < val_13);
            
            return val_15;
        }
        internal Org.BouncyCastle.Math.BigInteger CalculatePublic(Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_1;
            if(dhParams != null)
            {
                    val_1 = dhParams.g;
            }
            else
            {
                    val_1 = 28563616;
            }
            
            if(val_1 != 0)
            {
                    return val_1.ModPow(e:  x, m:  dhParams.p);
            }
            
            return val_1.ModPow(e:  x, m:  dhParams.p);
        }
        private static DHKeyGeneratorHelper()
        {
            Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance = new Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper();
        }
    
    }

}
