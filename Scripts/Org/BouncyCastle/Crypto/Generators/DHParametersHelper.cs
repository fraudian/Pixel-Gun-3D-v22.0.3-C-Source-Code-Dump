using UnityEngine;

namespace Org.BouncyCastle.Crypto.Generators
{
    internal class DHParametersHelper
    {
        // Fields
        private static readonly Org.BouncyCastle.Math.BigInteger Six;
        private static readonly int[][] primeLists;
        private static readonly int[] primeProducts;
        private static readonly Org.BouncyCastle.Math.BigInteger[] BigPrimeProducts;
        
        // Methods
        private static Org.BouncyCastle.Math.BigInteger[] ConstructBigPrimeProducts(int[] primeProducts)
        {
            var val_3;
            Org.BouncyCastle.Math.BigInteger[] val_1 = new Org.BouncyCastle.Math.BigInteger[0];
            val_3 = 0;
            goto label_2;
            label_10:
            val_3 = 1;
            val_1[0] = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  primeProducts[0]);
            label_2:
            if(val_3 < val_1.Length)
            {
                goto label_10;
            }
            
            return val_1;
        }
        internal static Org.BouncyCastle.Math.BigInteger[] GenerateSafePrimes(int size, int certainty, Org.BouncyCastle.Security.SecureRandom random)
        {
            var val_28;
            Org.BouncyCastle.Math.BigInteger val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            Org.BouncyCastle.Math.BigInteger val_39;
            var val_40;
            int val_1 = size - 1;
            if(size <= 32)
            {
                goto label_1;
            }
            
            int val_28 = certainty;
            val_28 = val_28 - 2;
            val_28 = 1431633920;
            val_28 = 21845;
            label_52:
            Org.BouncyCastle.Math.BigInteger val_3 = null;
            val_29 = val_3;
            val_3 = new Org.BouncyCastle.Math.BigInteger(bitLength:  val_1, certainty:  0, random:  random);
            label_36:
            val_30 = 0;
            goto label_2;
            label_31:
            val_31 = null;
            val_31 = null;
            int val_29 = Org.BouncyCastle.Crypto.Generators.DHParametersHelper.BigPrimeProducts.Length;
            val_32 = val_3.Remainder(n:  Org.BouncyCastle.Crypto.Generators.DHParametersHelper.BigPrimeProducts.Length + 32).IntValue;
            if(val_30 == 0)
            {
                    val_29 = val_29 >> 32;
                val_29 = val_29 + (val_29 >> 63);
                val_29 = val_29 + (val_29 << 1);
                val_29 = val_32 - val_29;
                if(val_29 != 2)
            {
                    val_29 = val_29 << 1;
                int val_7 = val_29 + 2;
                val_33 = null;
                val_29 = val_3.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)val_7));
                val_33 = null;
                int val_10 = val_7 + val_32;
                val_32 = val_10 - ((val_10 / (Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts.Length + 32)) * (Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts.Length + 32));
            }
            
            }
            
            val_34 = null;
            val_34 = null;
            val_35 = 0;
            label_26:
            if(val_35 >= (Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists.Length + 32 + 24))
            {
                goto label_23;
            }
            
            var val_12 = (Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists.Length + 32) + 0;
            var val_30 = (Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists.Length + 32 + 0) + 32;
            int val_13 = val_32 / val_30;
            val_13 = val_32 - (val_13 * val_30);
            if(val_13 == 0)
            {
                goto label_27;
            }
            
            val_30 = val_30 >> 1;
            val_35 = val_35 + 1;
            if(val_13 != val_30)
            {
                goto label_26;
            }
            
            goto label_27;
            label_23:
            val_30 = 1;
            label_2:
            val_36 = null;
            val_36 = null;
            if(val_30 < Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists.Length)
            {
                goto label_31;
            }
            
            goto label_32;
            label_27:
            val_37 = null;
            val_37 = null;
            Org.BouncyCastle.Math.BigInteger val_14 = val_29.Add(value:  Org.BouncyCastle.Crypto.Generators.DHParametersHelper.Six);
            goto label_36;
            label_32:
            if((val_29.BitLength != val_1) || ((val_29.RabinMillerTest(certainty:  2, random:  random, randomlySelected:  true)) == false))
            {
                goto label_52;
            }
            
            val_38 = null;
            val_38 = null;
            val_39 = val_29.ShiftLeft(n:  1).Add(value:  Org.BouncyCastle.Math.BigInteger.One);
            if((val_39.RabinMillerTest(certainty:  certainty, random:  random, randomlySelected:  true)) == false)
            {
                goto label_52;
            }
            
            if(certainty >= 3)
            {
                    if((val_29.RabinMillerTest(certainty:  val_28, random:  random, randomlySelected:  true)) == false)
            {
                goto label_52;
            }
            
            }
            
            if((Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(k:  val_39)) < (size >> 2))
            {
                goto label_52;
            }
            
            goto label_60;
            label_1:
            val_35 = 1152921505512914944;
            do
            {
                label_62:
                Org.BouncyCastle.Math.BigInteger val_22 = null;
                val_29 = val_22;
                val_22 = new Org.BouncyCastle.Math.BigInteger(bitLength:  val_1, certainty:  2, random:  random);
                val_40 = null;
                val_28 = val_22.ShiftLeft(n:  1);
                val_40 = null;
                val_39 = val_28.Add(value:  Org.BouncyCastle.Math.BigInteger.One);
            }
            while((val_39.IsProbablePrime(certainty:  certainty, randomlySelected:  true)) == false);
            
            if(certainty >= 3)
            {
                    if((val_22.IsProbablePrime(certainty:  certainty, randomlySelected:  true)) == false)
            {
                goto label_62;
            }
            
            }
            
            label_60:
            Org.BouncyCastle.Math.BigInteger[] val_27 = new Org.BouncyCastle.Math.BigInteger[2];
            if(val_27 == null)
            {
                goto label_63;
            }
            
            if(val_39 != null)
            {
                goto label_64;
            }
            
            goto label_67;
            label_63:
            if(val_39 == null)
            {
                goto label_67;
            }
            
            label_64:
            label_67:
            val_27[0] = val_39;
            val_27[1] = val_29;
            return val_27;
        }
        internal static Org.BouncyCastle.Math.BigInteger SelectGenerator(Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Security.SecureRandom random)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            do
            {
                val_5 = null;
                val_5 = null;
                Org.BouncyCastle.Math.BigInteger val_3 = Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(min:  Org.BouncyCastle.Math.BigInteger.Two, max:  p.Subtract(n:  Org.BouncyCastle.Math.BigInteger.Two), random:  random).ModPow(e:  Org.BouncyCastle.Math.BigInteger.Two, m:  p);
            }
            while((val_3 & 1) != 0);
            
            return val_3;
        }
        public DHParametersHelper()
        {
        
        }
        private static DHParametersHelper()
        {
            Org.BouncyCastle.Crypto.Generators.DHParametersHelper.Six = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  6);
            Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeLists = Org.BouncyCastle.Math.BigInteger.BytesPerInt;
            Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts = Org.BouncyCastle.Math.BigInteger.primeProducts;
            Org.BouncyCastle.Crypto.Generators.DHParametersHelper.BigPrimeProducts = Org.BouncyCastle.Crypto.Generators.DHParametersHelper.ConstructBigPrimeProducts(primeProducts:  Org.BouncyCastle.Crypto.Generators.DHParametersHelper.primeProducts);
        }
    
    }

}
