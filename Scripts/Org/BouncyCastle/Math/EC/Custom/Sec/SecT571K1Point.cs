using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT571K1Point : AbstractF2mPoint
    {
        // Properties
        public override Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        public SecT571K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecT571K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecT571K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
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
            var val_5;
            Org.BouncyCastle.Math.EC.ECFieldElement val_21;
            var val_22;
            var val_23;
            var val_24;
            Org.BouncyCastle.Math.EC.ECFieldElement val_25;
            Org.BouncyCastle.Math.EC.ECCurve val_26;
            var val_28;
            Org.BouncyCastle.Math.EC.ECFieldElement val_29;
            var val_30;
            Org.BouncyCastle.Math.EC.ECFieldElement val_31;
            bool val_32;
            var val_33;
            var val_34;
            var val_35;
            Org.BouncyCastle.Math.EC.ECFieldElement val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            Org.BouncyCastle.Math.EC.ECCurve val_43;
            bool val_44;
            Org.BouncyCastle.Math.EC.ECFieldElement val_45;
            Org.BouncyCastle.Math.EC.ECCurve val_46;
            var val_47;
            Org.BouncyCastle.Math.EC.ECFieldElement val_48;
            var val_49;
            Org.BouncyCastle.Math.EC.ECFieldElement val_50;
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
                    val_28 = 0;
            }
            
            val_29 = b.m_y;
            val_30 = mem[X22 + 32];
            val_30 = X22 + 32;
            if(b.m_zs.Length == 0)
            {
                    val_28 = 0;
            }
            
            val_31 = b.m_zs[0];
            val_32 = static_value_082CE000;
            val_33 = val_29;
            val_34 = val_25;
            if((val_30 & 1) == 0)
            {
                    val_34 = val_25;
                val_33 = val_29;
            }
            
            val_35 = val_31;
            if((val_35 & 1) == 0)
            {
                    val_24 = 137158656;
                val_28 = mem[static_value_082CE000 + 456 + 8];
                val_28 = static_value_082CE000 + 456 + 8;
                val_32 = val_32;
            }
            
            val_36 = val_32;
            val_37 = mem[static_value_082CE000 + 408 + 8];
            val_37 = static_value_082CE000 + 408 + 8;
            val_38 = val_24;
            if((val_38 & 1) == 0)
            {
                goto label_26;
            }
            
            goto label_29;
            label_9:
            val_40 = ???;
            val_36 = ???;
            val_41 = ???;
            val_30 = ???;
            val_24 = ???;
            val_34 = ???;
            val_42 = ???;
            val_29 = ???;
            val_31 = ???;
            val_35 = ???;
            val_25 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2D8;
            label_26:
            val_39 = mem[val_25 + 592];
            val_39 = val_25 + 592;
            if((val_25 & 1) == 0)
            {
                goto label_31;
            }
            
            val_31 = val_2;
            val_43 = val_41;
            val_21 = val_43;
            if((val_21 & 1) == 0)
            {
                goto label_41;
            }
            
            val_44 = mem[val_41 + 48];
            val_44 = val_41 + 48;
            val_45 = val_31;
            val_22 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point();
            val_46 = val_31;
            goto label_43;
            label_5:
            val_22 = val_23;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
            label_11:
            val_37 = mem[val_1 + 648];
            val_37 = val_1 + 648;
            val_39 = mem[val_1 + 656];
            val_39 = val_1 + 656;
            label_29:
            val_40 = ???;
            val_36 = ???;
            val_41 = ???;
            val_30 = ???;
            val_24 = ???;
            val_34 = ???;
            val_42 = ???;
            val_31 = ???;
            val_35 = ???;
            goto val_1 + 648;
            label_31:
            val_25 = val_36;
            val_21 = val_36;
            if((val_21 & 1) == 0)
            {
                goto label_50;
            }
            
            val_43 = val_2;
            val_44 = mem[val_41 + 48];
            val_44 = val_41 + 48;
            val_45 = val_43;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_4 = null;
            val_22 = val_4;
            val_46 = val_43;
            label_43:
            val_4 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_46, x:  val_21, y:  val_45, withCompression:  val_44);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
            label_41:
            val_43 = val_43;
            val_47 = null;
            val_47 = null;
            val_48 = val_31;
            goto label_61;
            label_50:
            val_49 = mem[val_36 + 456 + 8];
            val_49 = val_36 + 456 + 8;
            val_50 = val_36;
            if((val_35 & 1) == 0)
            {
                    val_49 = mem[val_50 + 456 + 8];
                val_49 = val_50 + 456 + 8;
                val_50 = val_50;
            }
            
            val_31 = val_2;
            val_43 = val_25;
            if((val_5 & 1) != 0)
            {
                goto label_67;
            }
            
            val_48 = val_50;
            label_61:
            val_50 = val_48;
            label_67:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_6 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_6[0] = val_50;
            val_44 = mem[val_41 + 48];
            val_44 = val_41 + 48;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_7 = null;
            val_22 = val_7;
            val_7 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_31, x:  val_21, y:  val_43, zs:  val_6, withCompression:  val_44);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_22;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_17;
            Org.BouncyCastle.Math.EC.ECFieldElement val_18;
            Org.BouncyCastle.Math.EC.ECCurve val_19;
            var val_20;
            var val_21;
            bool val_22;
            var val_23;
            var val_24;
            var val_25;
            Org.BouncyCastle.Math.EC.ECFieldElement val_26;
            var val_27;
            var val_28;
            bool val_29;
            var val_30;
            Org.BouncyCastle.Math.EC.ECFieldElement val_31;
            val_17 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
            }
            
            val_19 = this.Curve;
            if((X25 & 1) != 0)
            {
                    val_19 = ???;
                val_20 = ???;
                val_22 = ???;
                val_18 = ???;
            }
            else
            {
                    if((val_20 + 32 + 8 + 24) == 0)
            {
                    val_21 = 0;
            }
            
                val_23 = mem[val_20 + 32 + 8 + 32];
                val_23 = val_20 + 32 + 8 + 32;
                val_24 = mem[val_20 + 32 + 8 + 32 + 576];
                val_24 = val_20 + 32 + 8 + 32 + 576;
                val_25 = val_23;
                if((val_23 & 1) == 0)
            {
                    val_24 = mem[val_20 + 32 + 8 + 32 + 504 + 8];
                val_24 = val_20 + 32 + 8 + 32 + 504 + 8;
                val_25 = val_23;
            }
            
                if((val_23 & 1) != 0)
            {
                    val_26 = val_20 + 32;
                if(val_26 == 0)
            {
                    val_26 = 0;
            }
            
                val_27 = 7;
            }
            else
            {
                    val_21 = mem[val_20 + 32 + 408 + 8];
                val_21 = val_20 + 32 + 408 + 8;
                val_26 = val_20 + 32;
                if(val_26 == 0)
            {
                    val_26 = 0;
            }
            
                val_27 = 10;
            }
            
                var val_2 = val_26 + 160;
                val_28 = mem[(val_26 + 160) + 296 + 8];
                val_28 = (val_26 + 160) + 296 + 8;
                if((val_26 & 1) != 0)
            {
                    val_29 = mem[val_20 + 48];
                val_29 = val_20 + 48;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_3 = null;
                val_30 = val_3;
                val_3 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_19, x:  val_26, y:  val_19, withCompression:  val_29);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
                val_31 = val_26;
                if((val_23 & 1) == 0)
            {
                    val_28 = mem[282584257677135];
                val_31 = val_26;
            }
            
                val_18 = val_20 + 32;
                if((val_23 & 1) == 0)
            {
                    val_23 = val_25;
            }
            
                val_29 = val_18;
                Org.BouncyCastle.Math.EC.ECFieldElement[] val_4 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
                val_4[0] = val_31;
                val_22 = mem[val_20 + 48];
                val_22 = val_20 + 48;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_5 = null;
                val_30 = val_5;
                val_5 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_19, x:  val_26, y:  val_29, zs:  val_4, withCompression:  val_22);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_4;
            var val_5;
            Org.BouncyCastle.Math.EC.ECFieldElement val_10;
            var val_17;
            var val_18;
            Org.BouncyCastle.Math.EC.ECCurve val_19;
            var val_20;
            var val_21;
            var val_22;
            Org.BouncyCastle.Math.EC.ECFieldElement val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_17 = b;
            val_18 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_5;
            }
            
            }
            
            val_19 = this.Curve;
            if((X22 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
            }
            
            if(b.m_zs.Length == 0)
            {
                    val_20 = 0;
            }
            
            if(((b.m_x & 1) != 0) || ((b.m_zs[0] & 1) == 0))
            {
                goto label_13;
            }
            
            if(null == null)
            {
                    val_21 = 0;
                val_20 = 0;
            }
            
            val_22 = X26;
            val_23 = b.m_y;
            val_24 = b.m_x;
            val_25 = val_24;
            val_26 = val_23;
            if((val_25 & 1) == 0)
            {
                goto label_27;
            }
            
            if((val_26 & 1) == 0)
            {
                goto label_28;
            }
            
            val_26 = val_17;
            goto label_29;
            label_13:
            val_28 = ???;
            val_17 = ???;
            val_24 = ???;
            val_22 = ???;
            val_25 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point).__il2cppRuntimeField_2D8;
            label_5:
            val_27 = mem[val_28];
            val_27 = val_28;
            val_26 = val_28;
            label_29:
            label_35:
            val_19 = val_4;
            val_29 = val_5;
            val_23 = val_10;
            goto val_27 + 792;
            label_27:
            if((val_26 & 1) == 0)
            {
                goto label_31;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_14 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_19, x:  val_23, y:  val_19, withCompression:  val_5 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
            label_28:
            if(val_19 != null)
            {
                goto label_35;
            }
            
            goto label_35;
            label_31:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_15 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_15[0] = val_23;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_16 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  val_19, x:  val_23, y:  val_23, zs:  val_15, withCompression:  val_5 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point val_3 = null;
            val_4 = val_3;
            val_3 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve:  this.Curve, x:  static_value_082CE000, y:  X23, zs:  val_2, withCompression:  X21 + 32);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_4;
        }
    
    }

}
