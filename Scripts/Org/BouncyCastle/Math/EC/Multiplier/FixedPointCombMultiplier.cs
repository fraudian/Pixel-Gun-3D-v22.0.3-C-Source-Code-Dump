using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class FixedPointCombMultiplier : AbstractECMultiplier
    {
        // Methods
        protected override Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_12;
            var val_13;
            var val_14;
            int val_1 = Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(c:  p);
            int val_2 = k.BitLength;
            if(val_2 <= val_1)
            {
                    Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo val_4 = Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.Precompute(p:  p, minWidth:  850370672);
                val_12 = val_4;
                int val_5 = val_1 + val_12;
                val_5 = val_5 - 1;
                int val_6 = val_5 / val_12;
                val_13 = (val_2 > val_1) ? 0 : p;
                if(val_6 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
            
                int val_7 = val_6 * val_12;
                var val_12 = 0;
                val_12 = val_7 - 1;
                do
            {
                val_14 = 0;
                int val_8 = val_12 - val_12;
                if((val_8 & 2147483648) == 0)
            {
                    do
            {
                val_7 = k.TestBit(n:  val_8);
                val_8 = val_8 - val_6;
                val_14 = 0 | val_7;
            }
            while((val_8 & 2147483648) == 0);
            
            }
            
                Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo val_10 = val_4 + (((long)(int)((0 | (val_9 & 1)))) << 3);
                val_12 = val_12 + 1;
                val_13 = val_13;
            }
            while(val_12 != val_6);
            
                return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
            
            System.InvalidOperationException val_11 = new System.InvalidOperationException(message:  "fixed-point comb doesn\'t support scalars larger than the curve order");
        }
        protected virtual int GetWidthForCombSize(int combSize)
        {
            return (int)(combSize >= 258) ? (5 + 1) : 5;
        }
        public FixedPointCombMultiplier()
        {
            val_1 = new System.Object();
        }
    
    }

}
