using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT233K1Point : AbstractF2mPoint
    {
        // Properties
        public override Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        public SecT233K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecT233K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecT233K1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
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
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            Org.BouncyCastle.Math.EC.ECFieldElement val_19;
            var val_20;
            var val_21;
            var val_23;
            Org.BouncyCastle.Math.EC.ECCurve val_25;
            var val_29;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            Org.BouncyCastle.Math.EC.ECFieldElement val_46;
            var val_47;
            var val_48;
            var val_49;
            Org.BouncyCastle.Math.EC.ECFieldElement val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            Org.BouncyCastle.Math.EC.ECFieldElement val_55;
            var val_56;
            Org.BouncyCastle.Math.EC.ECCurve val_57;
            Org.BouncyCastle.Math.EC.ECFieldElement val_58;
            Org.BouncyCastle.Math.EC.ECFieldElement val_59;
            bool val_60;
            Org.BouncyCastle.Math.EC.ECCurve val_61;
            var val_62;
            var val_63;
            var val_64;
            Org.BouncyCastle.Math.EC.ECFieldElement val_65;
            var val_66;
            Org.BouncyCastle.Math.EC.ECFieldElement val_67;
            var val_68;
            Org.BouncyCastle.Math.EC.ECFieldElement val_69;
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
                    val_45 = 0;
            }
            
            val_46 = this.RawZCoords[0];
            if(val_37 == null)
            {
                goto label_14;
            }
            
            val_47 = val_37.RawYCoord;
            goto label_15;
            label_9:
            val_37 = ???;
            val_48 = ???;
            val_46 = ???;
            val_41 = ???;
            val_49 = ???;
            val_42 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2D8;
            label_14:
            val_47 = 0.RawYCoord;
            label_15:
            if(val_10.Length == 0)
            {
                    val_45 = 0;
            }
            
            val_50 = val_37.RawZCoords[0];
            val_51 = val_11;
            val_52 = val_47;
            val_53 = val_42;
            if((val_46 & 1) == 0)
            {
                    val_53 = val_42;
                val_52 = val_47;
            }
            
            val_54 = val_50;
            if((val_54 & 1) == 0)
            {
                    val_41 = val_41;
                val_45 = mem[val_11 + 456 + 8];
                val_45 = val_11 + 456 + 8;
                val_51 = val_51;
            }
            
            val_55 = val_51;
            val_43 = mem[val_41 + 408 + 8];
            val_43 = val_41 + 408 + 8;
            val_56 = val_41;
            if((val_56 & 1) == 0)
            {
                goto label_29;
            }
            
            if((val_55 & 1) == 0)
            {
                goto label_31;
            }
            
            val_43 = mem[val_48 + 792];
            val_43 = val_48 + 792;
            val_44 = mem[val_48 + 800];
            val_44 = val_48 + 800;
            goto label_32;
            label_29:
            val_44 = mem[val_42 + 592];
            val_44 = val_42 + 592;
            if((val_42 & 1) == 0)
            {
                goto label_34;
            }
            
            val_57 = val_49;
            val_58 = val_48;
            if((val_58 & 1) == 0)
            {
                goto label_43;
            }
            
            val_59 = val_57;
            val_60 = val_48.IsCompressed;
            val_61 = val_57;
            goto label_45;
            label_31:
            val_62 = val_49;
            val_43 = mem[val_62 + 648];
            val_43 = val_62 + 648;
            val_44 = mem[val_62 + 656];
            val_44 = val_62 + 656;
            label_32:
            label_11:
            val_53 = val_15;
            val_63 = val_16;
            val_46 = val_17;
            val_41 = val_18;
            val_55 = val_19;
            val_64 = val_20;
            val_50 = val_21;
            val_54 = val_23;
            goto val_62 + 648;
            label_34:
            val_58 = val_55;
            if((val_58 & 1) == 0)
            {
                goto label_51;
            }
            
            val_59 = val_25;
            val_60 = val_63.IsCompressed;
            val_61 = val_25;
            label_45:
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_61, x:  val_58, y:  val_59, withCompression:  val_60);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
            label_43:
            val_65 = val_48;
            val_66 = null;
            val_66 = null;
            val_67 = val_57;
            goto label_62;
            label_51:
            val_68 = mem[val_19 + 456 + 8];
            val_68 = val_19 + 456 + 8;
            val_69 = val_55;
            if((val_54 & 1) == 0)
            {
                    val_68 = mem[val_19 + 456 + 8];
                val_68 = val_19 + 456 + 8;
                val_69 = val_69;
            }
            
            val_65 = val_55;
            if((val_29 & 1) == 0)
            {
                goto label_68;
            }
            
            val_57 = val_25;
            goto label_69;
            label_68:
            val_57 = val_25;
            val_67 = val_69;
            label_62:
            val_69 = val_67;
            label_69:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_30 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_30[0] = val_69;
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_57, x:  val_58, y:  val_65, zs:  val_30, withCompression:  val_63.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_38;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_13;
            Org.BouncyCastle.Math.EC.ECCurve val_14;
            var val_15;
            var val_16;
            Org.BouncyCastle.Math.EC.ECFieldElement val_17;
            var val_19;
            Org.BouncyCastle.Math.EC.ECFieldElement val_20;
            var val_21;
            var val_22;
            Org.BouncyCastle.Math.EC.ECFieldElement val_23;
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
            
                val_17 = val_13.RawZCoords[0];
                val_19 = val_17;
                if((val_17 & 1) == 0)
            {
                    val_19 = val_17;
            }
            
                if((val_17 & 1) != 0)
            {
                    val_20 = val_4;
                if(val_20 == null)
            {
                    val_20 = 0;
            }
            
                val_21 = 7;
            }
            else
            {
                    val_20 = val_4;
                if(val_20 == null)
            {
                    val_20 = 0;
            }
            
                val_21 = 10;
            }
            
                var val_6 = val_20 + 160;
                val_22 = mem[(val_20 + 160) + 296 + 8];
                val_22 = (val_20 + 160) + 296 + 8;
                if((val_20 & 1) != 0)
            {
                    null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_14, x:  val_20, y:  val_14, withCompression:  val_13.IsCompressed);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
            
                val_23 = val_20;
                if((val_17 & 1) == 0)
            {
                    val_22 = mem[282584257677135];
                val_23 = val_20;
            }
            
                if((val_17 & 1) == 0)
            {
                    val_17 = val_19;
            }
            
                Org.BouncyCastle.Math.EC.ECFieldElement[] val_10 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
                val_10[0] = val_23;
                null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_14, x:  val_20, y:  val_4, zs:  val_10, withCompression:  val_13.IsCompressed);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_13;
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_7;
            var val_8;
            Org.BouncyCastle.Math.EC.ECFieldElement val_13;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            Org.BouncyCastle.Math.EC.ECCurve val_35;
            var val_36;
            Org.BouncyCastle.Math.EC.ECFieldElement val_37;
            var val_38;
            val_31 = b;
            val_32 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            }
            
            val_33 = 0;
            if(val_31.IsInfinity == false)
            {
                goto label_3;
            }
            
            label_37:
            val_32 = ???;
            val_31 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point).__il2cppRuntimeField_318;
            label_3:
            val_35 = val_32.Curve;
            if((val_32.RawXCoord & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            }
            
            if(val_31 != 0)
            {
                    val_36 = val_31.RawXCoord;
            }
            else
            {
                    val_36 = 0.RawXCoord;
            }
            
            if(val_19.Length == 0)
            {
                    val_34 = 0;
            }
            
            if(((val_36 & 1) != 0) || ((val_31.RawZCoords[0] & 1) == 0))
            {
                goto label_13;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_20 = val_32.RawYCoord;
            if(val_21.Length == 0)
            {
                    val_34 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_31 = val_32.RawZCoords[0];
            val_37 = val_31.RawYCoord;
            val_38 = val_37;
            if((val_36 & 1) == 0)
            {
                goto label_28;
            }
            
            if((val_38 & 1) == 0)
            {
                goto label_29;
            }
            
            if(val_31 != 0)
            {
                goto label_37;
            }
            
            goto label_37;
            label_13:
            val_38 = val_32;
            val_35 = val_7;
            val_32 = val_8;
            val_37 = val_13;
            goto val_32 + 728;
            label_28:
            if((val_38 & 1) == 0)
            {
                goto label_33;
            }
            
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_35, x:  val_37, y:  val_35, withCompression:  val_32.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            label_29:
            if(val_35 != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_33:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_26 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_26[0] = val_37;
            null = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  val_35, x:  val_37, y:  val_37, zs:  val_26, withCompression:  val_32.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point val_9 = null;
            val_10 = val_9;
            val_9 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  this.Curve, x:  val_2, y:  this.RawYCoord, zs:  val_6, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_10;
        }
    
    }

}
