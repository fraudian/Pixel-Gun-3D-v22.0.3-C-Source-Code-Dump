using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Endo
{
    public class GlvTypeBEndomorphism : GlvEndomorphism, ECEndomorphism
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.EC.ECCurve m_curve;
        protected readonly Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters m_parameters;
        protected readonly Org.BouncyCastle.Math.EC.ECPointMap m_pointMap;
        
        // Properties
        public virtual Org.BouncyCastle.Math.EC.ECPointMap PointMap { get; }
        public virtual bool HasEfficientPointMap { get; }
        
        // Methods
        public GlvTypeBEndomorphism(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters parameters)
        {
            val_1 = new System.Object();
            this.m_curve = curve;
            this.m_parameters = val_1;
            this.m_pointMap = new Org.BouncyCastle.Math.EC.ScaleXPointMap(scale:  curve);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(Org.BouncyCastle.Math.BigInteger k)
        {
            Org.BouncyCastle.Math.BigInteger val_4 = k.Subtract(n:  this.m_parameters.m_lambda.Multiply(val:  this.m_parameters.m_v1).Add(value:  this.m_parameters.m_lambda.Multiply(val:  this.m_parameters.m_v1)));
            Org.BouncyCastle.Math.BigInteger[] val_9 = new Org.BouncyCastle.Math.BigInteger[2];
            if(val_9 == null)
            {
                goto label_20;
            }
            
            if(val_4 != null)
            {
                goto label_21;
            }
            
            goto label_24;
            label_20:
            if(val_4 == null)
            {
                goto label_24;
            }
            
            label_21:
            label_24:
            val_9[0] = val_4;
            val_9[1] = this.m_parameters.m_lambda.Multiply(val:  this.m_parameters.m_v2).Add(value:  this.m_parameters.m_lambda.Multiply(val:  this.m_parameters.m_v2)).Negate();
            return val_9;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPointMap get_PointMap()
        {
            return (Org.BouncyCastle.Math.EC.ECPointMap)this.m_pointMap;
        }
        public virtual bool get_HasEfficientPointMap()
        {
            return true;
        }
        protected virtual Org.BouncyCastle.Math.BigInteger CalculateB(Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.BigInteger g, int t)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            if(g != null)
            {
                    val_14 = g.SignValue;
            }
            else
            {
                    val_14 = 0.SignValue;
            }
            
            val_15 = k.Multiply(val:  g.Abs());
            if(val_15 == null)
            {
                goto label_4;
            }
            
            val_16 = val_15.ShiftRight(n:  t);
            val_17 = val_14 >> 31;
            if((val_15.TestBit(n:  t - 1)) == true)
            {
                goto label_5;
            }
            
            label_8:
            if(val_17 == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_20;
            }
            
            label_12:
            if(val_16 != null)
            {
                    return val_16.Negate();
            }
            
            return val_16.Negate();
            label_4:
            val_15 = 0.TestBit(n:  t - 1);
            val_18 = 0.ShiftRight(n:  t);
            val_17 = val_14 >> 31;
            if(val_15 == false)
            {
                goto label_8;
            }
            
            label_5:
            val_19 = null;
            val_19 = null;
            val_20 = val_18.Add(value:  Org.BouncyCastle.Math.BigInteger.One);
            if(val_17 != 0)
            {
                goto label_12;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)val_20;
        }
    
    }

}
