using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public abstract class X9IntegerConverter
    {
        // Methods
        public static int GetByteLength(Org.BouncyCastle.Math.EC.ECFieldElement fe)
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_4 = fe;
            Org.BouncyCastle.Math.EC.ECFieldElement val_1 = val_4 + 7;
            val_4 = ((val_1 < 0) ? (val_4 + 14) : (val_1)) >> 3;
            return (int)val_4;
        }
        public static int GetByteLength(Org.BouncyCastle.Math.EC.ECCurve c)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_4 = c;
            Org.BouncyCastle.Math.EC.ECCurve val_1 = val_4 + 7;
            val_4 = ((val_1 < 0) ? (val_4 + 14) : (val_1)) >> 3;
            return (int)val_4;
        }
        public static byte[] IntegerToBytes(Org.BouncyCastle.Math.BigInteger s, int qLength)
        {
            System.Array val_6;
            int val_7;
            System.Array val_8;
            System.Array val_9;
            int val_10;
            var val_11;
            System.Byte[] val_1 = s.ToByteArrayUnsigned();
            if(val_1.Length > qLength)
            {
                    val_6 = new byte[0];
                val_7 = val_2.Length;
                val_8 = val_1;
                val_9 = val_6;
                val_10 = 0;
                val_11 = val_1.Length - val_7;
            }
            else
            {
                    if(val_1.Length >= qLength)
            {
                    return (System.Byte[])val_6;
            }
            
                byte[] val_3 = new byte[0];
                val_6 = val_3;
                val_7 = val_1.Length;
                val_8 = val_1;
                val_11 = 0;
                val_9 = val_6;
                val_10 = val_3.Length - val_7;
            }
            
            System.Array.Copy(sourceArray:  val_8, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  val_10, length:  val_7);
            return (System.Byte[])val_6;
        }
        protected X9IntegerConverter()
        {
        
        }
    
    }

}
