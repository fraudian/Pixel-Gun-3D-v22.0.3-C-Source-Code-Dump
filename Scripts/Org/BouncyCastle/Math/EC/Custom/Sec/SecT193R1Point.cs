using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT193R1Point : AbstractF2mPoint
    {
        // Properties
        public override Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        public SecT193R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecT193R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecT193R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement get_YCoord()
        {
            var val_5;
            var val_6;
            val_5 = this.RawYCoord;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            }
            
            if((this.RawXCoord & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            }
            
            val_5 = val_5;
            if(val_4.Length == 0)
            {
                    val_6 = 0;
            }
            
            if((this.RawZCoords[0] & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            }
            
            if(val_5 == null)
            {
                
            }
        
        }
        protected internal override bool get_CompressionYTilde()
        {
            var val_4;
            Org.BouncyCastle.Math.EC.ECFieldElement val_1 = this.RawXCoord;
            if((val_1 & 1) != 0)
            {
                    val_4 = 0;
            }
            else
            {
                    var val_3 = val_1;
                val_4 = this.RawYCoord ^ val_3;
            }
            
            val_3 = val_4 & 1;
            return (bool)val_3;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            var val_11;
            Org.BouncyCastle.Math.EC.ECFieldElement val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_23;
            Org.BouncyCastle.Math.EC.ECCurve val_26;
            var val_29;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            Org.BouncyCastle.Math.EC.ECFieldElement val_45;
            var val_46;
            var val_47;
            var val_48;
            Org.BouncyCastle.Math.EC.ECFieldElement val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            Org.BouncyCastle.Math.EC.ECFieldElement val_54;
            var val_55;
            var val_56;
            var val_57;
            Org.BouncyCastle.Math.EC.ECCurve val_58;
            Org.BouncyCastle.Math.EC.ECFieldElement val_59;
            Org.BouncyCastle.Math.EC.ECFieldElement val_60;
            bool val_61;
            Org.BouncyCastle.Math.EC.ECCurve val_62;
            var val_63;
            Org.BouncyCastle.Math.EC.ECFieldElement val_64;
            var val_65;
            Org.BouncyCastle.Math.EC.ECFieldElement val_66;
            var val_67;
            Org.BouncyCastle.Math.EC.ECFieldElement val_68;
            val_37 = b;
            val_38 = this;
            if(this.IsInfinity != false)
            {
                    val_39 = val_37;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
            }
            
            if(val_37.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
            }
            
            val_40 = this.Curve;
            val_41 = this.RawXCoord;
            val_42 = val_37.RawXCoord;
            if((val_41 & 1) == 0)
            {
                goto label_7;
            }
            
            if((val_42 & 1) == 0)
            {
                goto label_9;
            }
            
            if(val_40 != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_7:
            Org.BouncyCastle.Math.EC.ECFieldElement val_6 = this.RawYCoord;
            if(val_7.Length == 0)
            {
                    val_44 = 0;
            }
            
            val_45 = this.RawZCoords[0];
            if(val_37 == null)
            {
                goto label_14;
            }
            
            val_46 = val_37.RawYCoord;
            goto label_15;
            label_9:
            val_47 = ???;
            val_45 = ???;
            val_41 = ???;
            val_37 = ???;
            val_48 = ???;
            val_42 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2D8;
            label_14:
            val_46 = 0.RawYCoord;
            label_15:
            if(val_10.Length == 0)
            {
                    val_44 = 0;
            }
            
            val_49 = val_37.RawZCoords[0];
            val_50 = val_11;
            val_51 = val_46;
            val_52 = val_42;
            if((val_45 & 1) == 0)
            {
                    val_52 = val_42;
                val_51 = val_46;
            }
            
            val_53 = val_49;
            if((val_53 & 1) == 0)
            {
                    val_41 = val_41;
                val_44 = mem[val_11 + 456 + 8];
                val_44 = val_11 + 456 + 8;
                val_50 = val_50;
            }
            
            val_54 = val_50;
            val_55 = mem[val_41 + 408 + 8];
            val_55 = val_41 + 408 + 8;
            val_56 = val_41;
            if((val_56 & 1) == 0)
            {
                goto label_29;
            }
            
            if((val_54 & 1) == 0)
            {
                goto label_31;
            }
            
            val_55 = mem[val_47 + 792];
            val_55 = val_47 + 792;
            val_57 = mem[val_47 + 800];
            val_57 = val_47 + 800;
            goto label_32;
            label_29:
            val_57 = mem[val_42 + 592];
            val_57 = val_42 + 592;
            if((val_42 & 1) == 0)
            {
                goto label_34;
            }
            
            val_58 = val_48;
            val_59 = val_47;
            if((val_59 & 1) == 0)
            {
                goto label_45;
            }
            
            val_60 = val_58;
            val_61 = val_47.IsCompressed;
            val_62 = val_58;
            goto label_47;
            label_31:
            val_43 = mem[val_48];
            val_43 = val_48;
            label_11:
            val_55 = mem[val_43 + 648];
            val_55 = val_43 + 648;
            val_57 = mem[val_43 + 656];
            val_57 = val_43 + 656;
            label_32:
            val_54 = val_15;
            val_47 = val_16;
            val_45 = val_17;
            val_41 = val_18;
            val_52 = val_19;
            val_63 = val_20;
            val_49 = val_21;
            val_53 = val_23;
            goto val_43 + 648;
            label_34:
            val_59 = val_54;
            if((val_59 & 1) == 0)
            {
                goto label_53;
            }
            
            val_60 = val_26;
            val_61 = val_47.IsCompressed;
            val_62 = val_26;
            label_47:
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_62, x:  val_59, y:  val_60, withCompression:  val_61);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
            label_45:
            val_64 = val_47;
            val_65 = null;
            val_65 = null;
            val_66 = val_58;
            goto label_64;
            label_53:
            val_67 = mem[val_15 + 456 + 8];
            val_67 = val_15 + 456 + 8;
            val_68 = val_54;
            if((val_53 & 1) == 0)
            {
                    val_67 = mem[val_15 + 456 + 8];
                val_67 = val_15 + 456 + 8;
                val_68 = val_68;
            }
            
            val_58 = val_26;
            val_64 = val_54;
            if((val_29 & 1) != 0)
            {
                goto label_70;
            }
            
            val_66 = val_68;
            label_64:
            val_68 = val_66;
            label_70:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_30 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_30[0] = val_68;
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_58, x:  val_59, y:  val_64, zs:  val_30, withCompression:  val_47.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_13;
            Org.BouncyCastle.Math.EC.ECCurve val_14;
            Org.BouncyCastle.Math.EC.ECFieldElement val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            Org.BouncyCastle.Math.EC.ECFieldElement val_21;
            val_13 = this;
            if(this.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
            
            val_14 = this.Curve;
            val_15 = this.RawXCoord;
            if((val_15 & 1) != 0)
            {
                    val_14 = ???;
                val_13 = ???;
                val_15 = ???;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.ECFieldElement val_4 = val_13.RawYCoord;
                if(val_5.Length == 0)
            {
                    val_16 = 0;
            }
            
                Org.BouncyCastle.Math.EC.ECFieldElement val_13 = val_13.RawZCoords[0];
                val_17 = val_4;
                val_18 = val_13;
                if((val_13 & 1) == 0)
            {
                    val_17 = val_4;
                val_18 = val_13;
            }
            
                val_19 = mem[val_14 + 688];
                val_19 = val_14 + 688;
                val_20 = val_14;
                if((val_13 & 1) == 0)
            {
                    val_19 = val_18;
                val_16 = mem[val_20 + 456 + 8];
                val_16 = val_20 + 456 + 8;
                val_20 = val_20;
            }
            
                if((val_4 & 1) != 0)
            {
                    null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_14, x:  val_4, y:  val_14, withCompression:  val_13.IsCompressed);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
            
                if((val_13 & 1) != 0)
            {
                    val_21 = val_4;
            }
            else
            {
                    val_21 = val_4;
                val_15 = val_15;
            }
            
                Org.BouncyCastle.Math.EC.ECFieldElement[] val_9 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
                val_9[0] = val_21;
                null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_14, x:  val_4, y:  val_15, zs:  val_9, withCompression:  val_13.IsCompressed);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_7;
            var val_8;
            Org.BouncyCastle.Math.EC.ECFieldElement val_13;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            Org.BouncyCastle.Math.EC.ECCurve val_34;
            var val_35;
            Org.BouncyCastle.Math.EC.ECFieldElement val_36;
            var val_37;
            val_30 = b;
            val_31 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
            val_32 = 0;
            if(val_30.IsInfinity == false)
            {
                goto label_3;
            }
            
            label_40:
            val_31 = ???;
            val_30 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point).__il2cppRuntimeField_318;
            label_3:
            val_34 = val_31.Curve;
            if((val_31.RawXCoord & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
            if(val_30 != 0)
            {
                    val_35 = val_30.RawXCoord;
            }
            else
            {
                    val_35 = 0.RawXCoord;
            }
            
            if(val_19.Length == 0)
            {
                    val_33 = 0;
            }
            
            if(((val_35 & 1) != 0) || ((val_30.RawZCoords[0] & 1) == 0))
            {
                goto label_13;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_20 = val_31.RawYCoord;
            if(val_21.Length == 0)
            {
                    val_33 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_31 = val_31.RawZCoords[0];
            Org.BouncyCastle.Math.EC.ECFieldElement val_22 = val_30.RawYCoord;
            val_36 = val_34;
            val_37 = val_36;
            if((val_35 & 1) == 0)
            {
                goto label_32;
            }
            
            if(((val_37 & 1) == 0) || (val_30 != 0))
            {
                goto label_40;
            }
            
            goto label_40;
            label_13:
            val_37 = val_31;
            val_34 = val_7;
            val_31 = val_8;
            val_36 = val_13;
            goto val_31 + 728;
            label_32:
            if((val_37 & 1) != 0)
            {
                    null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_34, x:  val_36, y:  val_34, withCompression:  val_31.IsCompressed);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_26 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_26[0] = val_36;
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  val_34, x:  val_36, y:  val_36, zs:  val_26, withCompression:  val_31.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_30;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Negate()
        {
            var val_10;
            var val_11;
            val_10 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_10;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_2 = this.RawXCoord;
            if((val_2 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_10;
            }
            
            val_11 = 0;
            if(val_4.Length == 0)
            {
                    val_11 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_6 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_6[0] = this.RawZCoords[0];
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point val_9 = null;
            val_10 = val_9;
            val_9 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(curve:  this.Curve, x:  val_2, y:  this.RawYCoord, zs:  val_6, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_10;
        }
    
    }

}
