using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    public abstract class FiniteFields
    {
        // Fields
        internal static readonly Org.BouncyCastle.Math.Field.IFiniteField GF_2;
        internal static readonly Org.BouncyCastle.Math.Field.IFiniteField GF_3;
        
        // Methods
        public static Org.BouncyCastle.Math.Field.IPolynomialExtensionField GetBinaryExtensionField(int[] exponents)
        {
            int val_5;
            var val_6;
            if(exponents[0] != 0)
            {
                goto label_11;
            }
            
            val_5 = exponents.Length;
            if(val_5 < 2)
            {
                goto label_4;
            }
            
            label_8:
            if(1 >= val_5)
            {
                    val_5 = exponents.Length;
            }
            
            var val_1 = 1 - 1;
            if(exponents[4] <= (exponents[((long)(int)((1 - 1))) << 2]))
            {
                goto label_7;
            }
            
            val_1 = (long)val_1 + 2;
            if(val_1 < exponents.Length)
            {
                goto label_8;
            }
            
            label_4:
            val_6 = null;
            val_6 = null;
            .exponents = Org.BouncyCastle.Utilities.Arrays.Clone(data:  exponents);
            .subfield = Org.BouncyCastle.Math.Field.FiniteFields.GF_2;
            .minimalPolynomial = new Org.BouncyCastle.Math.Field.GF2Polynomial();
            return (Org.BouncyCastle.Math.Field.IPolynomialExtensionField)new Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField();
            label_7:
            label_11:
            null = new System.ArgumentException(message:  "Polynomial exponents must be montonically increasing", paramName:  "exponents");
            goto label_11;
        }
        public static Org.BouncyCastle.Math.Field.IFiniteField GetPrimeField(Org.BouncyCastle.Math.BigInteger characteristic)
        {
            Org.BouncyCastle.Math.BigInteger val_7;
            var val_8;
            var val_9;
            Org.BouncyCastle.Math.Field.IFiniteField val_10;
            var val_11;
            val_7 = characteristic;
            if(val_7 != null)
            {
                    val_8 = val_7.BitLength;
            }
            else
            {
                    val_8 = 0.BitLength;
            }
            
            if((val_8 < 2) || (val_7.SignValue <= 0))
            {
                goto label_4;
            }
            
            if(val_8 > 2)
            {
                goto label_8;
            }
            
            int val_4 = val_7.IntValue;
            if(val_4 == 3)
            {
                goto label_7;
            }
            
            if(val_4 == 2)
            {
                    val_7 = 1152921505513660416;
                val_9 = null;
                val_9 = null;
                val_10 = Org.BouncyCastle.Math.Field.FiniteFields.GF_2;
                return (Org.BouncyCastle.Math.Field.IFiniteField)val_10;
            }
            
            label_8:
            Org.BouncyCastle.Math.Field.PrimeField val_5 = null;
            val_10 = val_5;
            val_5 = new Org.BouncyCastle.Math.Field.PrimeField();
            .characteristic = val_7;
            return (Org.BouncyCastle.Math.Field.IFiniteField)val_10;
            label_7:
            val_11 = null;
            val_11 = null;
            return (Org.BouncyCastle.Math.Field.IFiniteField)val_10;
            label_4:
            System.ArgumentException val_6 = new System.ArgumentException(message:  "Must be >= 2", paramName:  "characteristic");
        }
        protected FiniteFields()
        {
        
        }
        private static FiniteFields()
        {
            .characteristic = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  2);
            Org.BouncyCastle.Math.Field.FiniteFields.GF_2 = new Org.BouncyCastle.Math.Field.PrimeField();
            .characteristic = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  3);
            Org.BouncyCastle.Math.Field.FiniteFields.GF_3 = new Org.BouncyCastle.Math.Field.PrimeField();
        }
    
    }

}
