using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class AbstractF2mPoint : ECPointBase
    {
        // Methods
        protected AbstractF2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected AbstractF2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override bool SatisfiesCurveEquation()
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            Org.BouncyCastle.Math.EC.ECFieldElement val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_7 = this;
            Org.BouncyCastle.Math.EC.ECCurve val_1 = this.Curve;
            val_8 = this.RawXCoord;
            val_9 = this.RawYCoord;
            val_10 = val_1;
            val_11 = val_1;
            if(val_1 != 6)
            {
                goto label_4;
            }
            
            if(val_4.Length == 0)
            {
                    val_12 = 0;
            }
            
            val_13 = this.RawZCoords[0];
            val_14 = val_13;
            if((val_8 & 1) == 0)
            {
                goto label_9;
            }
            
            val_16 = val_9;
            if((val_14 & 1) != 0)
            {
                goto label_11;
            }
            
            val_17 = val_11;
            goto label_13;
            label_4:
            val_16 = val_9;
            if(val_1 == null)
            {
                goto label_21;
            }
            
            if(val_1 != 1)
            {
                goto label_17;
            }
            
            if(val_5.Length == 0)
            {
                    val_18 = 0;
            }
            
            val_7 = this.RawZCoords[0];
            if((val_7 & 1) == 0)
            {
                    val_16 = val_16;
                val_19 = val_10;
                val_20 = val_11;
            }
            
            label_21:
            val_21 = val_8;
            val_17 = val_8;
            label_13:
            val_22 = val_17;
            label_11:
            if(val_16 != null)
            {
                goto label_42;
            }
            
            label_43:
            label_42:
            val_15 = val_22;
            val_23 = ???;
            val_24 = ???;
            val_9 = ???;
            val_25 = ???;
            val_14 = ???;
            val_26 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECFieldElement).__il2cppRuntimeField_2B8;
            label_9:
            if((val_14 & 1) != 0)
            {
                    val_27 = val_9;
                val_28 = val_25;
                val_29 = mem[val_25 + 408 + 8];
                val_29 = val_25 + 408 + 8;
            }
            else
            {
                    val_27 = val_9;
                val_28 = val_25;
                val_29 = val_26;
            }
            
            if(val_27 != 0)
            {
                goto label_42;
            }
            
            goto label_43;
            label_17:
            System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "unsupported coordinate system");
        }
        public override Org.BouncyCastle.Math.EC.ECPoint ScaleX(Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            var val_24;
            Org.BouncyCastle.Math.EC.ECFieldElement val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_31;
            val_25 = scale;
            val_26 = this;
            if(this.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_26;
            }
            
            int val_2 = this.CurveCoordinateSystem;
            if(val_2 != 6)
            {
                    if(val_2 != 5)
            {
                    return val_26.ScaleX(scale:  val_25 = ???);
            }
            
                val_27 = this.RawXCoord;
                Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.RawYCoord;
                Org.BouncyCastle.Math.EC.ECCurve val_5 = this.Curve;
                val_28 = this.RawZCoords;
                val_29 = this.IsCompressed;
                bool val_8 = val_29;
            }
            else
            {
                    val_27 = this.RawXCoord;
                Org.BouncyCastle.Math.EC.ECFieldElement val_10 = this.RawYCoord;
                val_31 = 0;
                if(val_11.Length == 0)
            {
                    val_31 = 0;
            }
            
                Org.BouncyCastle.Math.EC.ECCurve val_12 = this.Curve;
                val_28 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
                val_28[0] = this.RawZCoords[0];
                val_29 = this.IsCompressed;
                bool val_15 = val_29;
            }
            
            val_26 = ???;
            val_24 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_208;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint ScaleY(Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_17;
            var val_18;
            val_17 = scale;
            val_18 = this;
            if(this.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_18;
            }
            
            if((this.CurveCoordinateSystem - 5) > 1)
            {
                    return val_18.ScaleY(scale:  val_17 = ???);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.RawXCoord;
            Org.BouncyCastle.Math.EC.ECFieldElement val_5 = this.RawYCoord;
            Org.BouncyCastle.Math.EC.ECCurve val_6 = this.Curve;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_7 = this.RawZCoords;
            bool val_9 = this.IsCompressed;
            val_18 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_208;
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
        public virtual Org.BouncyCastle.Math.EC.AbstractF2mPoint Tau()
        {
            var val_16;
            var val_20;
            val_16 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.AbstractF2mPoint);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_3 = this.RawXCoord;
            if(this.Curve <= 6)
            {
                    var val_16 = 106054656 + (val_2) << 2;
                val_16 = val_16 + 106054656;
            }
            else
            {
                    val_20 = new System.InvalidOperationException(message:  "unsupported coordinate system");
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.AbstractF2mPoint TauPow(int pow)
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_16;
            var val_17;
            var val_20;
            val_16 = pow;
            val_17 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.AbstractF2mPoint);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_3 = this.RawXCoord;
            if(this.Curve <= 6)
            {
                    var val_16 = 106054684 + (val_2) << 2;
                val_16 = val_16 + 106054684;
            }
            else
            {
                    val_20 = new System.InvalidOperationException(message:  "unsupported coordinate system");
            }
        
        }
    
    }

}
