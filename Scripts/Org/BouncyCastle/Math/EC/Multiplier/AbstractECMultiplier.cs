using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public abstract class AbstractECMultiplier : ECMultiplier
    {
        // Methods
        public virtual Org.BouncyCastle.Math.EC.ECPoint Multiply(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_10;
            var val_11;
            Org.BouncyCastle.Math.EC.ECPoint val_12;
            var val_13;
            var val_14;
            Org.BouncyCastle.Math.EC.ECPoint val_15;
            val_10 = k;
            val_11 = p;
            val_12 = this;
            val_13 = 0;
            val_14 = val_10.SignValue;
            if(val_14 == 0)
            {
                goto label_1;
            }
            
            val_13 = 0;
            if(val_11.IsInfinity == false)
            {
                goto label_3;
            }
            
            label_1:
            val_12 = ???;
            val_11 = ???;
            val_14 = ???;
            val_10 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_288;
            label_3:
            Org.BouncyCastle.Math.BigInteger val_3 = val_10.Abs();
            val_15 = val_12;
            if(val_14 > 0)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  val_15 = val_15);
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  val_15);
        }
        protected abstract Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k); // 0
        protected AbstractECMultiplier()
        {
        
        }
    
    }

}
