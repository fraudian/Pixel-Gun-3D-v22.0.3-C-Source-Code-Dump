using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class FpPoint : AbstractFpPoint
    {
        // Methods
        public FpPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public FpPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal FpPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.FpPoint(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
        {
            int val_6;
            var val_7;
            val_6 = index;
            val_7 = this;
            if(val_6 != 1)
            {
                    return val_7.GetZCoord(index:  val_6 = ???);
            }
            
            if(this.CurveCoordinateSystem != 4)
            {
                    return val_7.GetZCoord(index:  val_6);
            }
            
            val_7 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_3B8;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            var val_17;
            var val_18;
            var val_20;
            Org.BouncyCastle.Math.EC.ECFieldElement val_22;
            Org.BouncyCastle.Math.EC.ECFieldElement val_23;
            var val_29;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            val_17 = b;
            val_18 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint);
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_5;
            }
            
            }
            
            if(val_18 == val_17)
            {
                goto label_46;
            }
            
            if(this.Curve > 4)
            {
                goto label_8;
            }
            
            var val_16 = 106054796 + (val_1) << 2;
            val_22 = b.m_x;
            val_23 = b.m_y;
            val_16 = val_16 + 106054796;
            goto (106054796 + (val_1) << 2 + 106054796);
            label_5:
            val_29 = val_18;
            return (Org.BouncyCastle.Math.EC.ECPoint);
            label_46:
            val_43 = ???;
            val_20 = ???;
            val_44 = ???;
            val_41 = ???;
            val_45 = ???;
            val_46 = ???;
            val_42 = ???;
            val_47 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_318;
            label_8:
            System.InvalidOperationException val_15 = new System.InvalidOperationException(message:  "unsupported coordinate system");
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_31;
            var val_32;
            var val_33;
            Org.BouncyCastle.Math.EC.ECCurve val_34;
            Org.BouncyCastle.Math.EC.ECFieldElement val_35;
            var val_36;
            var val_39;
            val_31 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_39;
            }
            
            }
            
            val_33 = this.Curve;
            if((X21 & 1) != 0)
            {
                    val_33 = ???;
                val_34 = ???;
                val_32 = ???;
                val_35 = ???;
                val_36 = ???;
            }
            else
            {
                    if(val_33 <= 4)
            {
                    var val_30 = 106054816 + (val_33) << 2;
                val_30 = val_30 + 106054816;
            }
            else
            {
                    System.InvalidOperationException val_29 = new System.InvalidOperationException(message:  "unsupported coordinate system");
            }
            
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            var val_7;
            var val_8;
            Org.BouncyCastle.Math.EC.ECFieldElement val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_7 = b;
            val_8 = this;
            if(val_8 == val_7)
            {
                goto label_1;
            }
            
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_28;
            }
            
            }
            
            if((137158656 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
            }
            
            val_9 = this.Curve;
            if(val_9 == 4)
            {
                goto label_10;
            }
            
            if(val_9 != null)
            {
                goto label_11;
            }
            
            if((b.m_x & 1) == 0)
            {
                goto label_15;
            }
            
            val_10 = val_8;
            if((b.m_y & 1) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
            }
            
            label_1:
            label_28:
            val_11 = ???;
            val_9 = ???;
            val_12 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_348;
            label_10:
            val_13 = val_11;
            goto label_18;
            label_11:
            val_13 = val_8;
            label_18:
            val_14 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_2D8;
            label_15:
            int val_2 = this.CurveCoordinateSystem;
            if((b.m_x & 1) == 0)
            {
                goto label_26;
            }
            
            if(this.Curve != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_26:
            Org.BouncyCastle.Math.EC.FpPoint val_6 = new Org.BouncyCastle.Math.EC.FpPoint(curve:  this.Curve, x:  this.AffineXCoord, y:  val_9, withCompression:  true);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
        {
            var val_8;
            var val_9;
            var val_10;
            Org.BouncyCastle.Math.EC.ECFieldElement val_11;
            var val_12;
            Org.BouncyCastle.Math.EC.ECFieldElement val_13;
            var val_14;
            var val_16;
            var val_17;
            var val_18;
            Org.BouncyCastle.Math.EC.ECCurve val_19;
            val_8 = this;
            if(true == 0)
            {
                goto label_1;
            }
            
            if(!=0)
            {
                goto label_3;
            }
            
            goto label_3;
            label_1:
            if(==0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_8;
            }
            
            label_3:
            if((137158656 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_8;
            }
            
            val_10 = this.Curve;
            if(val_10 == 4)
            {
                goto label_7;
            }
            
            if(val_10 != null)
            {
                goto label_8;
            }
            
            val_12 = val_8;
            val_13 = this.YCoord;
            Org.BouncyCastle.Math.EC.ECCurve val_3 = this.Curve;
            val_14 = this.CurveCoordinateSystem;
            val_16 = this.AffineXCoord;
            if((val_16 & 1) == 0)
            {
                goto label_17;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_6 = this.Curve;
            val_17 = ???;
            val_10 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_288;
            label_7:
            val_18 = val_17;
            goto label_19;
            label_8:
            val_18 = val_8;
            label_19:
            val_9 = ???;
            val_19 = ???;
            val_13 = ???;
            val_11 = ???;
            val_14 = ???;
            val_12 = ???;
            val_16 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_2D8;
            label_17:
            Org.BouncyCastle.Math.EC.FpPoint val_7 = new Org.BouncyCastle.Math.EC.FpPoint(curve:  val_19, x:  val_13, y:  val_11, withCompression:  val_19 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_8;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TimesPow2(int e)
        {
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            Org.BouncyCastle.Math.EC.ECFieldElement val_33;
            var val_34;
            var val_35;
            Org.BouncyCastle.Math.EC.ECFieldElement val_36;
            var val_37;
            var val_38;
            Org.BouncyCastle.Math.EC.ECFieldElement val_39;
            var val_40;
            var val_41;
            Org.BouncyCastle.Math.EC.ECFieldElement val_42;
            Org.BouncyCastle.Math.EC.ECCurve val_44;
            val_29 = this;
            if((e & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(e == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint);
            }
            
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint);
            }
            
            }
            
            if(e != 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_5:
            Org.BouncyCastle.Math.EC.ECCurve val_1 = this.Curve;
            if((X21 & 1) == 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_9:
            val_33 = val_1;
            if((X21 + 24) < 1)
            {
                goto label_12;
            }
            
            if((X21 + 32) != 0)
            {
                goto label_24;
            }
            
            label_25:
            label_24:
            if(((X21 + 32) & 1) != 0)
            {
                goto label_19;
            }
            
            if(val_1 == 4)
            {
                goto label_17;
            }
            
            if(val_1 == 2)
            {
                goto label_18;
            }
            
            if(val_1 != 1)
            {
                goto label_19;
            }
            
            val_32 = X23;
            val_31 = X21;
            val_34 = val_29;
            goto label_21;
            label_12:
            val_35 = null;
            val_35 = null;
            if(val_1 != null)
            {
                goto label_24;
            }
            
            goto label_25;
            label_17:
            val_34 = val_29;
            goto label_26;
            label_18:
            val_34 = val_29;
            label_21:
            label_26:
            val_33 = val_34;
            label_19:
            var val_28 = 0;
            label_43:
            if((X21 & 1) != 0)
            {
                goto label_28;
            }
            
            val_36 = val_29;
            val_37 = val_29;
            Org.BouncyCastle.Math.EC.ECFieldElement val_2 = this.AffineXCoord;
            val_38 = public Org.BouncyCastle.Math.EC.ECPoint Org.BouncyCastle.Math.EC.ECPoint::Normalize();
            if((this.Normalize() & 1) == 0)
            {
                    val_36 = this.CurveCoordinateSystem;
                val_38 = this.AffineXCoord;
                val_33 = val_29;
            }
            
            val_39 = val_36;
            Org.BouncyCastle.Math.EC.ECFieldElement val_6 = this.Y;
            val_40 = mem[val_4 + 440 + 8];
            val_40 = val_4 + 440 + 8;
            if(((X21 + 32) & 1) != 0)
            {
                    val_41 = val_37;
            }
            else
            {
                    val_40 = public Org.BouncyCastle.Math.EC.ECFieldElement Org.BouncyCastle.Math.EC.ECPoint::get_AffineXCoord();
                val_41 = this.AffineXCoord;
            }
            
            val_28 = val_28 + 1;
            if(val_28 < e)
            {
                goto label_43;
            }
            
            if(val_1 > 4)
            {
                goto label_44;
            }
            
            var val_29 = 106054836 + (val_1) << 2;
            val_29 = val_29 + 106054836;
            goto (106054836 + (val_1) << 2 + 106054836);
            label_28:
            val_44 = val_1;
            val_30 = mem[val_1 + 648];
            val_30 = val_1 + 648;
            label_6:
            label_10:
            val_42 = ???;
            val_39 = ???;
            val_33 = ???;
            val_37 = ???;
            goto val_1 + 648;
            label_1:
            System.ArgumentException val_26 = new System.ArgumentException(message:  "cannot be negative", paramName:  "e");
            label_72:
            label_44:
            System.InvalidOperationException val_27 = new System.InvalidOperationException(message:  "unsupported coordinate system");
            goto label_72;
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement Two(Org.BouncyCastle.Math.EC.ECFieldElement x)
        {
            if(x == null)
            {
                
            }
        
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement Three(Org.BouncyCastle.Math.EC.ECFieldElement x)
        {
            if(this != null)
            {
                    return this.CurveCoordinateSystem;
            }
            
            return this.CurveCoordinateSystem;
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement Four(Org.BouncyCastle.Math.EC.ECFieldElement x)
        {
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_358;
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement Eight(Org.BouncyCastle.Math.EC.ECFieldElement x)
        {
            goto typeof(Org.BouncyCastle.Math.EC.FpPoint).__il2cppRuntimeField_378;
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement DoubleProductFromSquares(Org.BouncyCastle.Math.EC.ECFieldElement a, Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement aSquared, Org.BouncyCastle.Math.EC.ECFieldElement bSquared)
        {
            if(a == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Negate()
        {
            var val_4 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
            }
            
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_1 = this.Curve;
            if(val_1 != null)
            {
                    Org.BouncyCastle.Math.EC.FpPoint val_2 = null;
                val_4 = val_2;
                val_2 = new Org.BouncyCastle.Math.EC.FpPoint(curve:  val_1, x:  X21, y:  X22, zs:  val_1, withCompression:  W24);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
            }
            
            Org.BouncyCastle.Math.EC.FpPoint val_3 = null;
            val_4 = val_3;
            val_3 = new Org.BouncyCastle.Math.EC.FpPoint(curve:  val_1, x:  X21, y:  X22, withCompression:  val_1);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement CalculateJacobianModifiedW(Org.BouncyCastle.Math.EC.ECFieldElement Z, Org.BouncyCastle.Math.EC.ECFieldElement ZSquared)
        {
            var val_9;
            var val_10;
            val_9 = this.Curve;
            if((val_9 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
            }
            
            if((Z & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_9;
            }
            
            val_10 = val_9;
            if(val_10 < val_9)
            {
                    val_9 = ???;
                val_10 = ???;
            }
        
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement GetJacobianModifiedW()
        {
            Org.BouncyCastle.Math.EC.FpPoint val_1 = mem[X21 + 40];
            val_1 = X21 + 40;
            if(val_1 != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_1;
            }
            
            val_1 = this;
            mem2[0] = val_1;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_1;
        }
        protected virtual Org.BouncyCastle.Math.EC.FpPoint TwiceJacobianModified(bool calculateW)
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_9;
            var val_10;
            Org.BouncyCastle.Math.EC.ECFieldElement val_11;
            var val_12;
            int val_1 = this.CurveCoordinateSystem;
            val_9 = this;
            Org.BouncyCastle.Math.EC.ECFieldElement val_2 = this.AffineXCoord;
            Org.BouncyCastle.Math.EC.ECFieldElement val_3 = this.Y;
            val_10 = mem[val_1 + 440 + 8];
            val_10 = val_1 + 440 + 8;
            if(calculateW != false)
            {
                    Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.AffineXCoord;
                val_11 = this;
            }
            else
            {
                    val_11 = 0;
            }
            
            val_12 = mem[static_value_082CE020 + 576];
            val_12 = static_value_082CE020 + 576;
            val_12 = static_value_082CE020;
            val_9 = this.AffineXCoord;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_7 = new Org.BouncyCastle.Math.EC.ECFieldElement[2];
            if(val_7 == null)
            {
                goto label_17;
            }
            
            if(val_9 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_9 == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_7[0] = val_9;
            val_7[1] = val_11;
            return (Org.BouncyCastle.Math.EC.FpPoint)new Org.BouncyCastle.Math.EC.FpPoint(curve:  this.Curve, x:  val_1, y:  val_1, zs:  val_7, withCompression:  true);
        }
    
    }

}
