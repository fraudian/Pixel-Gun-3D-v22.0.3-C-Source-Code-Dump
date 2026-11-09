using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT571R1Point : AbstractF2mPoint
    {
        // Properties
        public override Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        public SecT571R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecT571R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecT571R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement get_YCoord()
        {
            var val_3;
            var val_4;
            if((X21 | X19) == 0)
            {
                    val_3 = 0;
                return (Org.BouncyCastle.Math.EC.ECFieldElement)val_3;
            }
            
            if((X21 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_3;
            }
            
            val_4 = mem[X19 + 456 + 8];
            val_4 = X19 + 456 + 8;
            val_3 = X19;
            if(X19 == 0)
            {
                    val_4 = 0;
            }
            
            if(this.IsNormalized() != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_3;
            }
            
            if(val_3 == 0)
            {
                
            }
        
        }
        protected internal override bool get_CompressionYTilde()
        {
            var val_3;
            if((X19 & 1) != 0)
            {
                    val_3 = 0;
            }
            else
            {
                    var val_2 = X19;
                val_3 = this.GetEncoded() ^ val_2;
            }
            
            val_2 = val_3 & 1;
            return (bool)val_2;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_2;
            var val_4;
            Org.BouncyCastle.Math.EC.ECFieldElement val_21;
            var val_22;
            var val_23;
            var val_24;
            Org.BouncyCastle.Math.EC.ECFieldElement val_25;
            Org.BouncyCastle.Math.EC.ECCurve val_26;
            var val_27;
            var val_28;
            var val_29;
            Org.BouncyCastle.Math.EC.ECFieldElement val_30;
            var val_31;
            Org.BouncyCastle.Math.EC.ECFieldElement val_32;
            bool val_33;
            var val_34;
            var val_35;
            var val_36;
            Org.BouncyCastle.Math.EC.ECFieldElement val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            Org.BouncyCastle.Math.EC.ECCurve val_42;
            Org.BouncyCastle.Math.EC.ECCurve val_43;
            var val_44;
            bool val_45;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement val_46;
            Org.BouncyCastle.Math.EC.ECCurve val_47;
            var val_49;
            var val_50;
            Org.BouncyCastle.Math.EC.ECFieldElement val_51;
            var val_52;
            Org.BouncyCastle.Math.EC.ECFieldElement val_53;
            val_22 = b;
            val_23 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_5;
            }
            
            }
            
            val_25 = b.m_x;
            val_26 = this.Curve;
            if((137158656 & 1) == 0)
            {
                goto label_7;
            }
            
            if((val_25 & 1) == 0)
            {
                goto label_9;
            }
            
            if(val_26 != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_7:
            if((X22 + 24) == 0)
            {
                    val_29 = 0;
            }
            
            val_30 = b.m_y;
            val_31 = mem[X22 + 32];
            val_31 = X22 + 32;
            if(b.m_zs.Length == 0)
            {
                    val_29 = 0;
            }
            
            val_32 = b.m_zs[0];
            val_33 = static_value_082CE000;
            val_34 = val_30;
            val_35 = val_25;
            if((val_31 & 1) == 0)
            {
                    val_35 = val_25;
                val_34 = val_30;
            }
            
            val_36 = val_32;
            if((val_36 & 1) == 0)
            {
                    val_24 = 137158656;
                val_29 = mem[static_value_082CE000 + 456 + 8];
                val_29 = static_value_082CE000 + 456 + 8;
                val_33 = val_33;
            }
            
            val_37 = val_33;
            val_27 = mem[static_value_082CE000 + 408 + 8];
            val_27 = static_value_082CE000 + 408 + 8;
            val_38 = val_24;
            if((val_38 & 1) == 0)
            {
                goto label_26;
            }
            
            goto label_29;
            label_9:
            val_39 = ???;
            val_35 = ???;
            val_40 = ???;
            val_31 = ???;
            val_24 = ???;
            val_37 = ???;
            val_41 = ???;
            val_30 = ???;
            val_32 = ???;
            val_36 = ???;
            val_25 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2D8;
            label_26:
            val_28 = mem[val_25 + 592];
            val_28 = val_25 + 592;
            if((val_25 & 1) == 0)
            {
                goto label_31;
            }
            
            val_42 = val_2;
            val_43 = val_40;
            val_21 = val_43;
            if((val_21 & 1) == 0)
            {
                goto label_41;
            }
            
            val_44 = null;
            val_44 = null;
            val_45 = mem[val_40 + 48];
            val_45 = val_40 + 48;
            val_46 = Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT;
            val_22 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point();
            val_47 = val_42;
            goto label_44;
            label_5:
            val_22 = val_23;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
            label_29:
            label_11:
            val_39 = ???;
            val_35 = ???;
            val_40 = ???;
            val_31 = ???;
            val_24 = ???;
            val_37 = ???;
            val_41 = ???;
            val_32 = ???;
            val_36 = ???;
            goto val_1 + 648;
            label_31:
            val_25 = val_37;
            val_21 = val_37;
            if((val_21 & 1) == 0)
            {
                goto label_51;
            }
            
            val_49 = null;
            val_43 = val_2;
            goto label_70;
            label_41:
            val_43 = val_43;
            val_50 = null;
            val_50 = null;
            val_51 = val_42;
            goto label_62;
            label_51:
            val_52 = mem[val_37 + 456 + 8];
            val_52 = val_37 + 456 + 8;
            val_53 = val_37;
            if((val_36 & 1) == 0)
            {
                    val_52 = mem[val_53 + 456 + 8];
                val_52 = val_53 + 456 + 8;
                val_53 = val_53;
            }
            
            val_43 = val_25;
            if((val_4 & 1) == 0)
            {
                goto label_68;
            }
            
            val_42 = val_2;
            goto label_69;
            label_70:
            val_45 = mem[val_40 + 48];
            val_45 = val_40 + 48;
            val_46 = Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_5 = null;
            val_22 = val_5;
            val_47 = ;
            label_44:
            val_5 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_47, x:  val_21, y:  val_46, withCompression:  val_45);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
            label_68:
            val_42 = val_2;
            val_51 = val_53;
            label_62:
            val_53 = val_51;
            label_69:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_6 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_6[0] = val_53;
            val_45 = mem[val_40 + 48];
            val_45 = val_40 + 48;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_7 = null;
            val_22 = val_7;
            val_7 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_42, x:  val_21, y:  val_43, zs:  val_6, withCompression:  val_45);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_16;
            Org.BouncyCastle.Math.EC.ECFieldElement val_17;
            Org.BouncyCastle.Math.EC.ECCurve val_18;
            var val_19;
            var val_20;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_21;
            var val_22;
            Org.BouncyCastle.Math.EC.ECFieldElement val_23;
            var val_24;
            var val_25;
            var val_26;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement val_27;
            var val_28;
            val_16 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_28;
            }
            
            }
            
            val_18 = this.Curve;
            if((X21 & 1) == 0)
            {
                goto label_4;
            }
            
            val_18 = ???;
            val_19 = ???;
            val_17 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_288;
            label_4:
            if((val_19 + 32 + 8 + 24) == 0)
            {
                    val_20 = 0;
            }
            
            val_21 = mem[val_19 + 32 + 8 + 32];
            val_21 = val_19 + 32 + 8 + 32;
            val_22 = mem[val_19 + 32 + 8 + 32 + 576];
            val_22 = val_19 + 32 + 8 + 32 + 576;
            val_23 = val_21;
            if((val_23 & 1) == 0)
            {
                goto label_9;
            }
            
            val_24 = val_21;
            val_25 = val_19 + 32;
            if((val_19 + 32) != 0)
            {
                goto label_11;
            }
            
            val_24 = val_21;
            goto label_11;
            label_9:
            val_20 = mem[val_19 + 32 + 456 + 8];
            val_20 = val_19 + 32 + 456 + 8;
            val_25 = val_19 + 32;
            val_22 = mem[val_19 + 32 + 8 + 32 + 504 + 8];
            val_22 = val_19 + 32 + 8 + 32 + 504 + 8;
            val_24 = val_21;
            label_11:
            if(((val_19 + 32) & 1) != 0)
            {
                    val_26 = null;
                val_26 = null;
                val_27 = Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_2 = null;
                val_28 = val_2;
                val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_18, x:  val_19 + 32, y:  val_27, withCompression:  val_19 + 48);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_28;
            }
            
            if((val_23 & 1) != 0)
            {
                    val_23 = val_19 + 32;
            }
            else
            {
                    val_23 = val_19 + 32;
                val_17 = val_17;
            }
            
            val_27 = val_17;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_3 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_21 = val_3;
            val_21[0] = val_23;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_4 = null;
            val_28 = val_4;
            val_4 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_18, x:  val_19 + 32, y:  val_27, zs:  val_3, withCompression:  val_19 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_28;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_4;
            var val_5;
            Org.BouncyCastle.Math.EC.ECFieldElement val_10;
            var val_18;
            var val_19;
            Org.BouncyCastle.Math.EC.ECCurve val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            Org.BouncyCastle.Math.EC.ECFieldElement val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_18 = b;
            val_19 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_18;
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_5;
            }
            
            }
            
            val_20 = this.Curve;
            if((X23 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_18;
            }
            
            if(b.m_zs.Length == 0)
            {
                    val_21 = 0;
            }
            
            if(((b.m_x & 1) != 0) || ((b.m_zs[0] & 1) == 0))
            {
                goto label_13;
            }
            
            if(null == null)
            {
                    val_22 = 0;
                val_21 = 0;
            }
            
            val_23 = X26;
            val_24 = b.m_y;
            val_25 = b.m_y;
            val_26 = b.m_x;
            val_27 = val_25;
            if((val_26 & 1) == 0)
            {
                goto label_28;
            }
            
            if((val_27 & 1) == 0)
            {
                goto label_29;
            }
            
            val_27 = val_18;
            goto label_30;
            label_13:
            val_29 = ???;
            val_18 = ???;
            val_23 = ???;
            val_24 = ???;
            val_26 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point).__il2cppRuntimeField_2D8;
            label_5:
            val_28 = mem[val_29];
            val_28 = val_29;
            val_27 = val_29;
            label_30:
            label_37:
            val_20 = val_4;
            val_30 = val_5;
            val_25 = val_10;
            goto val_28 + 792;
            label_28:
            if((val_27 & 1) == 0)
            {
                goto label_32;
            }
            
            val_31 = null;
            val_31 = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_14 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_20, x:  val_25, y:  Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT, withCompression:  val_5 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_18;
            label_29:
            if(val_20 != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_32:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_15 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_15[0] = val_25;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_16 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  val_20, x:  val_25, y:  val_25, zs:  val_15, withCompression:  val_5 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_18;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Negate()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(==0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
            }
            
            }
            
            val_5 = mem[static_value_082CE000 + 592];
            val_5 = static_value_082CE000 + 592;
            if((137158656 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
            }
            
            if((X21 + 24) == 0)
            {
                    val_5 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_2 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_2[0] = X21 + 32;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point val_3 = null;
            val_4 = val_3;
            val_3 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  this.Curve, x:  static_value_082CE000, y:  X23, zs:  val_2, withCompression:  X21 + 32);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
        }
    
    }

}
