using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class AbstractFpPoint : ECPointBase
    {
        // Properties
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        protected AbstractFpPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected AbstractFpPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected internal override bool get_CompressionYTilde()
        {
            if(this.AffineYCoord == null)
            {
                
            }
        
        }
        protected override bool SatisfiesCurveEquation()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_17;
            Org.BouncyCastle.Math.EC.ECFieldElement val_1 = this.RawXCoord;
            val_10 = this.Curve;
            val_11 = this.Curve;
            val_12 = this.RawYCoord;
            int val_5 = this.CurveCoordinateSystem;
            if((val_5 - 2) >= 3)
            {
                goto label_4;
            }
            
            if(val_7.Length == 0)
            {
                    val_13 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_10 = this.RawZCoords[0];
            if((val_10 & 1) != 0)
            {
                goto label_19;
            }
            
            val_10 = val_10;
            val_17 = val_11;
            val_14 = val_10;
            goto label_13;
            label_4:
            if(val_5 == 0)
            {
                goto label_19;
            }
            
            if(val_5 != 1)
            {
                goto label_15;
            }
            
            if(val_8.Length == 0)
            {
                    val_13 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_11 = this.RawZCoords[0];
            if((val_11 & 1) != 0)
            {
                goto label_19;
            }
            
            val_12 = val_12;
            val_10 = val_10;
            val_17 = val_11;
            val_14 = val_11;
            label_13:
            val_11 = val_17;
            label_19:
            if(val_12 != null)
            {
                goto typeof(Org.BouncyCastle.Math.EC.ECFieldElement).__il2cppRuntimeField_2B8;
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.ECFieldElement).__il2cppRuntimeField_2B8;
            label_15:
            System.InvalidOperationException val_9 = new System.InvalidOperationException(message:  "unsupported coordinate system");
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Subtract(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            if(b.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            if(b == null)
            {
                
            }
        
        }
    
    }

}
