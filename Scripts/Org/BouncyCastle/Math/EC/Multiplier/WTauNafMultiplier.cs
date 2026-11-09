using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class WTauNafMultiplier : AbstractECMultiplier
    {
        // Fields
        internal static readonly string PRECOMP_NAME;
        
        // Methods
        protected override Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(Org.BouncyCastle.Math.EC.ECPoint point, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_9;
            var val_10;
            if(point != null)
            {
                    if(point != null)
            {
                    val_9 = 0;
            }
            
                int val_4 = 0.IntValue;
                sbyte val_5 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu(curveA:  (int)val_4 & 255);
                val_10 = null;
                val_10 = null;
                return (Org.BouncyCastle.Math.EC.ECPoint)this.MultiplyWTnaf(p:  point, lambda:  Org.BouncyCastle.Math.EC.Abc.Tnaf.PartModReduction(k:  k, m:  0, a:  val_4, s:  0, mu:  val_5, c:  10), preCompInfo:  0, a:  val_4, mu:  val_5);
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Only AbstractF2mPoint can be used in WTauNafMultiplier");
        }
        private Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyWTnaf(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo, sbyte a, sbyte mu)
        {
            var val_5;
            Org.BouncyCastle.Math.EC.Abc.ZTauElement[] val_6;
            val_5 = null;
            if((a & 255) != 0)
            {
                    val_5 = null;
                val_6 = 1152921505521545264;
                return Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.MultiplyFromWTnaf(p:  p, u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicWNaf(mu:  mu, lambda:  lambda, width:  4, pow2w:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  16), tw:  Org.BouncyCastle.Math.EC.Abc.Tnaf.GetTw(mu:  mu, w:  4), alpha:  val_6 = 1152921505521545248), preCompInfo:  preCompInfo);
            }
            
            val_5 = null;
            return Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.MultiplyFromWTnaf(p:  p, u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicWNaf(mu:  mu, lambda:  lambda, width:  4, pow2w:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  16), tw:  Org.BouncyCastle.Math.EC.Abc.Tnaf.GetTw(mu:  mu, w:  4), alpha:  val_6), preCompInfo:  preCompInfo);
        }
        private static Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyFromWTnaf(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte[] u, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
        {
            var val_16;
            var val_17;
            int val_18;
            Org.BouncyCastle.Math.EC.AbstractF2mPoint val_19;
            var val_20;
            sbyte val_21;
            var val_22;
            val_16 = p.Curve;
            val_16 = 0;
            Org.BouncyCastle.Math.EC.AbstractF2mPoint[] val_6 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetPreComp(p:  p, a:  val_16.IntValue);
            Org.BouncyCastle.Math.EC.Multiplier.WTauNafPreCompInfo val_7 = new Org.BouncyCastle.Math.EC.Multiplier.WTauNafPreCompInfo();
            val_17 = null;
            val_17 = null;
            val_18 = val_6.Length;
            Org.BouncyCastle.Math.EC.AbstractF2mPoint[] val_8 = new Org.BouncyCastle.Math.EC.AbstractF2mPoint[0];
            if(val_6.Length < 1)
            {
                goto label_16;
            }
            
            label_31:
            val_19 = val_6[0];
            if(val_8 == null)
            {
                goto label_22;
            }
            
            if(val_19 != null)
            {
                goto label_23;
            }
            
            goto label_29;
            label_22:
            if(val_19 == null)
            {
                goto label_29;
            }
            
            label_23:
            val_18 = null;
            val_18 = 0;
            val_19 = 0;
            label_29:
            if(0 >= val_8.Length)
            {
                    val_18 = 0;
            }
            
            val_8[0] = val_19;
            if((0 + 1) < val_6.Length)
            {
                goto label_31;
            }
            
            label_16:
            val_20 = p.Curve;
            if(val_20 != null)
            {
                    val_20 = 0;
            }
            
            int val_18 = u.Length;
            label_52:
            var val_19 = 0;
            label_40:
            val_18 = val_18 - 1;
            if((val_18 & 2147483648) != 0)
            {
                goto label_38;
            }
            
            val_19 = val_19 + 1;
            val_21 = u[(long)val_18];
            if(val_21 == 0)
            {
                goto label_40;
            }
            
            if(val_21 <= 0)
            {
                goto label_42;
            }
            
            if(val_6 == null)
            {
                goto label_43;
            }
            
            val_22 = val_6;
            goto label_46;
            label_42:
            val_21 = -val_21;
            val_22 = val_8;
            goto label_46;
            label_43:
            val_22 = 0;
            label_46:
            sbyte val_14 = val_21 >> 1;
            var val_15 = val_22 + (((long)((u[(long)(int)((u.Length - 1))][0]>>1) & 0x7FFFFFFF)) << 3);
            if(val_20 == 0)
            {
                goto label_52;
            }
            
            goto label_52;
            label_38:
            if(val_19 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)val_20;
            }
            
            val_20 = val_20;
            return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)val_20;
        }
        public WTauNafMultiplier()
        {
            val_1 = new System.Object();
        }
        private static WTauNafMultiplier()
        {
            Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.PRECOMP_NAME = "bc_wtnaf";
        }
    
    }

}
