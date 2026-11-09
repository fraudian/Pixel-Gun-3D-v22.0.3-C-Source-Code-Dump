using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class GlvMultiplier : AbstractECMultiplier
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.EC.ECCurve curve;
        protected readonly Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism;
        
        // Methods
        public GlvMultiplier(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism)
        {
            this = new System.Object();
            if((curve != null) && (curve != null))
            {
                    this.curve = curve;
                this.glvEndomorphism = glvEndomorphism;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Need curve with known group order", paramName:  "curve");
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_7;
            var val_9;
            int val_10;
            if((this.curve & 1) != 0)
            {
                    val_7 = 0;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_7 = 0;
                val_9 = public Org.BouncyCastle.Math.BigInteger[] Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism::DecomposeScalar(Org.BouncyCastle.Math.BigInteger k);
                Org.BouncyCastle.Math.BigInteger[] val_3 = this.glvEndomorphism.DecomposeScalar(k:  k.Mod(m:  p));
                val_10 = val_3.Length;
                if(val_10 == 0)
            {
                    val_9 = 0;
                val_10 = val_3.Length;
            }
            
                Org.BouncyCastle.Math.BigInteger val_12 = val_3[0];
                if(val_10 <= 1)
            {
                    val_9 = 0;
            }
            
                Org.BouncyCastle.Math.BigInteger val_13 = val_3[1];
                var val_14 = 0;
                val_14 = val_14 + 1;
                val_9 = 0;
                Org.BouncyCastle.Math.EC.ECPointMap val_5 = this.glvEndomorphism.PointMap;
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_9 = 1;
                if(this.glvEndomorphism.HasEfficientPointMap != false)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P:  p, k:  val_12, pointMapQ:  val_5, l:  val_13);
            }
            
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_9 = 0;
                return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P:  p, k:  val_12, Q:  val_5.Map(p:  p), l:  val_13);
            }
            
            System.InvalidOperationException val_10 = new System.InvalidOperationException();
        }
    
    }

}
