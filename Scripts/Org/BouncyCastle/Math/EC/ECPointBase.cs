using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class ECPointBase : ECPoint
    {
        // Methods
        protected internal ECPointBase(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
        }
        protected internal ECPointBase(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            val_1 = new System.Object();
            mem[1152921544087434928] = curve;
            mem[1152921544087434936] = val_1;
            mem[1152921544087434944] = y;
            mem[1152921544087434952] = zs;
            mem[1152921544087434960] = withCompression;
        }
        public override byte[] GetEncoded(bool compressed)
        {
            System.Array val_9;
            Org.BouncyCastle.Math.EC.ECFieldElement val_10;
            int val_11;
            System.Array val_12;
            if(true == 0)
            {
                    if(true == 0)
            {
                goto label_2;
            }
            
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_1 = this.Normalize();
            if(compressed == false)
            {
                goto label_5;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_2 = val_1.m_x + 1;
            val_9 = new byte[0];
            val_9[0] = (val_1 != 1) ? (2 + 1) : 2;
            val_10 = val_1.m_x;
            val_11 = 1;
            val_12 = val_1;
            goto label_9;
            label_5:
            if(val_1 == null)
            {
                goto label_11;
            }
            
            if(val_1 != null)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            Org.BouncyCastle.Math.EC.ECFieldElement val_8 = val_1.m_x;
            val_8 = val_8 + val_1.m_x;
            Org.BouncyCastle.Math.EC.ECFieldElement val_5 = val_8 + 1;
            byte[] val_6 = new byte[0];
            val_9 = val_6;
            val_9[0] = 4;
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_6, destinationIndex:  1, length:  val_1.m_x);
            val_10 = val_1.m_x;
            val_12 = val_1;
            val_11 = val_1.m_x + 1;
            label_9:
            System.Array.Copy(sourceArray:  val_12, sourceIndex:  0, destinationArray:  val_6, destinationIndex:  val_11, length:  val_10);
            return (System.Byte[])val_9;
            label_11:
            if(val_1 != null)
            {
                goto label_15;
            }
            
            goto label_16;
            label_2:
            byte[] val_7 = new byte[1];
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Multiply(Org.BouncyCastle.Math.BigInteger k)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.Curve.Multiply(p:  this, k:  k);
        }
    
    }

}
