using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class WNafL2RMultiplier : AbstractECMultiplier
    {
        // Methods
        protected override Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            int val_1 = k.BitLength;
            val_28 = 1152921504622448640;
            val_29 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  852491440));
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_4 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p:  p, width:  val_29, includeNegated:  true);
            System.Int32[] val_5 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactWindowNaf(width:  val_29, k:  k);
            val_30 = p;
            val_31 = val_5.Length - 1;
            if()
            {
                goto label_11;
            }
            
            val_31 = val_5.Length;
            goto label_12;
            label_11:
            int val_27 = val_5[val_31 << 2];
            int val_6 = val_27 >> 16;
            int val_7 = val_29 & 31;
            var val_8 = (val_6 < 0) ? (-val_6) : (val_6);
            val_7 = 1 << val_7;
            var val_10 = (val_6 < 0) ? (val_4) : (val_4);
            val_32 = val_27 & 65535;
            if((val_8 << 2) >= val_7)
            {
                goto label_15;
            }
            
            val_33 = null;
            val_33 = null;
            System.Byte[] val_11 = Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)val_8;
            var val_28 = (Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)(int)(val_6 < 0 ?  (-(val_5[((val_5.Length - 1)) << 2][0] >> 16)) : (val_5[((val_5.Length - 1)) << 2][0] >> 16))) + 32;
            int val_12 = val_29 + 31;
            val_12 = val_12 & 31;
            int val_13 = val_29 - val_28;
            val_28 = val_28 + 31;
            val_28 = val_28 & 31;
            val_12 = 1 << val_12;
            val_28 = 1 << val_28;
            val_28 = val_28 ^ val_8;
            val_29 = val_28 << (val_13 & 31);
            val_34 = mem[val_6 < 0 ? val_4 : val_4 + 24];
            val_34 = val_6 < 0 ? val_4 : val_4 + 24;
            val_8 = val_29 + 1;
            if(((val_12 - 1) >> 1) >= val_34)
            {
                    val_34 = mem[val_6 < 0 ? val_4 : val_4 + 24];
                val_34 = val_6 < 0 ? val_4 : val_4 + 24;
            }
            
            var val_17 = val_10 + (((long)((((1 << ((val_3 + 31) & 31)) - 1)>>1) & 0x7FFFFFFF)) << 3);
            val_29 = mem[(val_6 < 0 ? val_4 : val_4 + ((long)((((1 << ((val_3 + 31) & 31)) - 1)>>1) & 0x7FFFFFFF)) << 3) + 32];
            val_29 = (val_6 < 0 ? val_4 : val_4 + ((long)((((1 << ((val_3 + 31) & 31)) - 1)>>1) & 0x7FFFFFFF)) << 3) + 32;
            int val_18 = val_8 >> 1;
            var val_19 = val_10 + (((long)((((((1 << (((Org.BouncyCastle.Math.EC.LongArray.BitLengths + (long)(int)(val_6 < 0 ?  (-(val_5[((val_5.Length - 1)) << 2][0] >> 16)) : (val_5[((val_5.Length - 1)) << 2][0] >> 16))) + 32 + 31) & 31)) ^ >>1) & 0x7FFFFFFF)) << 3);
            val_35 = val_29;
            val_32 = val_32 - val_13;
            val_28 = 1152921504622448640;
            if(val_35 != 0)
            {
                goto label_36;
            }
            
            goto label_37;
            label_15:
            val_29 = (long)(val_8 >> 1) & 2147483647;
            var val_21 = val_10 + (((long)((val_6 < 0 ?  (-(val_5[((val_5.Length - 1)) << 2][0] >> 16)) : (val_5[((val_5.Length - 1)) << 2][0] >> 16)>>1) & 0x7FFFFFFF)) << 3);
            val_35 = mem[(val_6 < 0 ? val_4 : val_4 + ((long)((val_6 < 0 ?  (-(val_5[((val_5.Length - 1)) << 2][0] >> 16)) : (val_5[((val_5.Length - 1)) << 2][0] >> 16)>>1) & 0x7FFFFFFF)) << 3) + 32];
            val_35 = (val_6 < 0 ? val_4 : val_4 + ((long)((val_6 < 0 ?  (-(val_5[((val_5.Length - 1)) << 2][0] >> 16)) : (val_5[((val_5.Length - 1)) << 2][0] >> 16)>>1) & 0x7FFFFFFF)) << 3) + 32;
            if(val_35 != 0)
            {
                goto label_36;
            }
            
            label_37:
            val_35 = 0;
            label_36:
            val_30 = val_35;
            label_12:
            val_31 = val_31 - 1;
            if((val_8 >> 1) < (val_6 < 0 ? val_4 : val_4 + 24))
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
            int val_29 = val_5[((long)(int)(((val_5.Length - 1) - 1))) << 2];
            int val_22 = val_29 >> 16;
            var val_25 = ((val_22 < 0) ? (-val_22) : (val_22)) >> 1;
            var val_26 = ((val_22 < 0) ? (val_4) : (val_4)) + (((long)((val_22 < 0 ?  (-(val_5[((long)(int)(((val_5.Length - 1) - 1))) << 2][0] >> 16)) : (val_5[((long)(int)(((val_5.Length - 1) - 1))) << 2][0] >> 16)>>1) & 0x7FFFFFFF)) << 3);
            val_29 = val_29 & 65535;
            if(val_30 != 0)
            {
                goto label_36;
            }
            
            goto label_37;
        }
        protected virtual int GetWindowSize(int bits)
        {
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  bits);
        }
        public WNafL2RMultiplier()
        {
            val_1 = new System.Object();
        }
    
    }

}
