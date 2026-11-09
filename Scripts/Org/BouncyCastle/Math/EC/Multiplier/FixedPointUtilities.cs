using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class FixedPointUtilities
    {
        // Fields
        public static readonly string PRECOMP_NAME;
        
        // Methods
        public static int GetCombSize(Org.BouncyCastle.Math.EC.ECCurve c)
        {
            if(c != null)
            {
                    return c.BitLength;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_1 = c;
            val_1 = val_1 + 1;
            return (int)val_1;
        }
        public static Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo GetFixedPointPreCompInfo(Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
        {
            Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo val_1 = null;
            preCompInfo = val_1;
            .m_width = 0;
            val_1 = new Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo();
            return (Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo)preCompInfo;
        }
        public static Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo Precompute(Org.BouncyCastle.Math.EC.ECPoint p, int minWidth)
        {
            Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo val_14;
            Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo val_15;
            var val_16;
            Org.BouncyCastle.Math.EC.ECPoint val_17;
            Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo val_18;
            var val_19;
            Org.BouncyCastle.Math.EC.ECPoint val_20;
            var val_21;
            var val_22;
            int val_14 = minWidth;
            val_14 = p;
            val_15 = val_14;
            val_16 = null;
            val_16 = null;
            val_17 = val_14 & 31;
            val_18 = Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetFixedPointPreCompInfo(preCompInfo:  val_15);
            int val_2 = 1 << val_17;
            if(val_18 != null)
            {
                    if(val_2 <= val_1.m_width)
            {
                    return val_18;
            }
            
            }
            
            val_19 = 1152921512609633008;
            int val_15 = Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(c:  val_15);
            val_15 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            val_14 = val_14 - 1;
            val_15[0] = val_14;
            if(val_14 >= 2)
            {
                    var val_17 = 0;
                val_15 = (val_14 + val_15) / val_14;
                do
            {
                var val_7 = val_17 + 1;
                val_17 = val_17 + 1;
                val_15[val_17] = val_15[val_17];
            }
            while((val_14 - 1) != val_17);
            
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_8 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            val_20 = val_15;
            val_8[0] = val_20;
            if((val_14 & 2147483648) == 0)
            {
                    do
            {
                var val_10 = 1 << ((long)val_14 & 31);
                if(val_10 < val_2)
            {
                    val_20 = val_15[(long)val_14];
                var val_19 = 0;
                do
            {
                val_19 = val_19 + (val_10 << 1);
                val_8[(long)val_10 + val_19] = val_8[0];
            }
            while((val_10 + val_19) < val_2);
            
            }
            
                val_19 = (long)val_14 - 1;
            }
            while((val_19 & 2147483648) == 0);
            
            }
            
            val_14 = val_15;
            val_18 = val_18;
            val_17 = val_14;
            if(val_18 != 0)
            {
                    val_21 = mem[val_1 + 376 + 8];
                val_21 = val_1 + 376 + 8;
            }
            else
            {
                    val_21 = mem[val_1 + 376 + 8];
                val_21 = val_1 + 376 + 8;
            }
            
            val_22 = null;
            val_22 = null;
            return val_18;
        }
        public FixedPointUtilities()
        {
        
        }
        private static FixedPointUtilities()
        {
            Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.PRECOMP_NAME = "bc_fixed_point";
        }
    
    }

}
