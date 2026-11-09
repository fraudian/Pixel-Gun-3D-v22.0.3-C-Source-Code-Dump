using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class F2mPoint : AbstractF2mPoint
    {
        // Properties
        public override Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal override bool CompressionYTilde { get; }
        
        // Methods
        public F2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public F2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    if(x == null)
            {
                    return;
            }
            
                Org.BouncyCastle.Math.EC.F2mFieldElement.CheckFieldElements(a:  x, b:  y);
                if(curve == null)
            {
                    return;
            }
            
                Org.BouncyCastle.Math.EC.F2mFieldElement.CheckFieldElements(a:  x, b:  curve);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal F2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        public F2mPoint(Org.BouncyCastle.Math.EC.ECCurve curve)
        {
        
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.F2mPoint(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement get_YCoord()
        {
            var val_5;
            var val_6;
            int val_1 = this.CurveCoordinateSystem;
            if((val_1 - 5) > 1)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)X19;
            }
            
            if((X22 | X19) == 0)
            {
                    val_5 = 0;
                return (Org.BouncyCastle.Math.EC.ECFieldElement)X19;
            }
            
            if((X22 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)X19;
            }
            
            val_6 = mem[X19 + 456 + 8];
            val_6 = X19 + 456 + 8;
            if(val_1 != 6)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)X19;
            }
            
            if(X19 == 0)
            {
                    val_6 = 0;
            }
            
            if(this.IsNormalized() == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)X19;
            }
            
            if(X19 == 0)
            {
                
            }
        
        }
        protected internal override bool get_CompressionYTilde()
        {
            var val_4;
            if((X19 & 1) == 0)
            {
                goto label_1;
            }
            
            val_4 = 0;
            goto label_2;
            label_1:
            if((this.CurveCoordinateSystem - 5) > 1)
            {
                goto label_4;
            }
            
            var val_3 = X19;
            val_4 = X20 ^ val_3;
            label_2:
            val_3 = val_4 & 1;
            return (bool)val_3;
            label_4:
            if(X20 == 0)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            Org.BouncyCastle.Math.EC.ECCurve val_6;
            var val_7;
            var val_25;
            var val_26;
            var val_27;
            Org.BouncyCastle.Math.EC.ECFieldElement val_28;
            bool val_29;
            var val_30;
            var val_31;
            var val_32;
            Org.BouncyCastle.Math.EC.ECFieldElement val_33;
            var val_34;
            Org.BouncyCastle.Math.EC.ECFieldElement val_35;
            var val_36;
            var val_37;
            bool val_38;
            Org.BouncyCastle.Math.EC.ECFieldElement val_39;
            var val_40;
            Org.BouncyCastle.Math.EC.ECCurve val_41;
            Org.BouncyCastle.Math.EC.ECFieldElement val_42;
            Org.BouncyCastle.Math.EC.ECFieldElement val_43;
            var val_44;
            Org.BouncyCastle.Math.EC.ECFieldElement val_45;
            Org.BouncyCastle.Math.EC.ECFieldElement val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            Org.BouncyCastle.Math.EC.ECFieldElement val_55;
            var val_56;
            Org.BouncyCastle.Math.EC.ECFieldElement val_57;
            var val_58;
            var val_59;
            Org.BouncyCastle.Math.EC.ECFieldElement val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            Org.BouncyCastle.Math.EC.ECCurve val_65;
            Org.BouncyCastle.Math.EC.ECFieldElement val_66;
            Org.BouncyCastle.Math.EC.ECFieldElement val_67;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_68;
            Org.BouncyCastle.Math.EC.ECCurve val_69;
            var val_70;
            Org.BouncyCastle.Math.EC.ECFieldElement val_71;
            Org.BouncyCastle.Math.EC.ECFieldElement val_72;
            Org.BouncyCastle.Math.EC.ECFieldElement val_73;
            var val_74;
            val_25 = b;
            val_26 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_40;
            }
            
            }
            
            if(b.m_x == null)
            {
                    if(b.m_y == null)
            {
                goto label_5;
            }
            
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_1 = this.Curve;
            val_28 = b.m_x;
            if(val_1 == 6)
            {
                goto label_7;
            }
            
            if(val_1 == 1)
            {
                goto label_8;
            }
            
            if(val_1 != null)
            {
                goto label_9;
            }
            
            if((X21 & 1) == 0)
            {
                goto label_14;
            }
            
            if((X23 & 1) == 0)
            {
                goto label_40;
            }
            
            goto label_65;
            label_7:
            if((X21 & 1) == 0)
            {
                goto label_18;
            }
            
            if((val_28 & 1) == 0)
            {
                goto label_20;
            }
            
            goto label_40;
            label_8:
            if((X23 + 24) == 0)
            {
                    val_32 = 0;
            }
            
            val_33 = b.m_y;
            val_34 = mem[X23 + 32];
            val_34 = X23 + 32;
            if(b.m_zs.Length == 0)
            {
                    val_32 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_24 = b.m_zs[0];
            if((val_34 & 1) == 0)
            {
                    val_33 = val_33;
                val_35 = val_28;
            }
            
            val_36 = X21;
            if((val_24 & 1) == 0)
            {
                    val_31 = ???;
                val_32 = mem[X21 + 456 + 8];
                val_32 = X21 + 456 + 8;
                val_36 = X21;
            }
            
            val_37 = val_33;
            if((val_35 & 1) == 0)
            {
                goto label_37;
            }
            
            if((val_37 & 1) != 0)
            {
                goto label_65;
            }
            
            val_30 = mem[val_1];
            val_30 = val_1;
            goto label_40;
            label_14:
            val_39 = X23;
            val_40 = new Org.BouncyCastle.Math.EC.F2mPoint();
            val_41 = val_1;
            val_42 = X23;
            val_43 = val_39;
            goto label_47;
            label_18:
            if(mem[137158680] == 0)
            {
                    val_44 = 0;
            }
            
            val_45 = b.m_y;
            val_29 = static_value_082CE020;
            if(b.m_zs.Length == 0)
            {
                    val_44 = 0;
            }
            
            val_46 = b.m_zs[0];
            val_47 = ???;
            val_48 = val_45;
            val_49 = val_28;
            val_49 = val_28;
            val_48 = val_45;
            val_50 = val_46;
            if((val_50 & 1) == 0)
            {
                    val_27 = X21;
                val_44 = mem[val_47 + 456 + 8];
                val_44 = val_47 + 456 + 8;
                val_47 = val_47;
            }
            
            val_51 = val_47;
            val_52 = mem[X21 + 408 + 8];
            val_52 = X21 + 408 + 8;
            val_53 = val_27;
            if((val_53 & 1) == 0)
            {
                goto label_62;
            }
            
            if((val_51 & 1) == 0)
            {
                goto label_64;
            }
            
            goto label_65;
            label_37:
            val_55 = val_35;
            val_57 = val_55;
            var val_3 = (val_34 != 1) ? (val_24) : (val_34);
            if(((val_34 | val_24) & 1) == 0)
            {
                    val_56 = mem[X23 + 32 + 456 + 8];
                val_56 = X23 + 32 + 456 + 8;
            }
            
            if((val_24 & 1) == 0)
            {
                goto label_72;
            }
            
            val_58 = val_35;
            goto label_73;
            label_5:
            val_40 = val_26;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_40;
            label_20:
            val_59 = ???;
            val_51 = ???;
            val_60 = ???;
            val_61 = ???;
            val_27 = ???;
            val_53 = ???;
            val_57 = ???;
            val_46 = ???;
            val_62 = ???;
            val_50 = ???;
            val_63 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2D8;
            label_62:
            val_54 = mem[val_61 + 592];
            val_54 = val_61 + 592;
            if((val_61 & 1) == 0)
            {
                goto label_76;
            }
            
            if(val_60 == 0)
            {
                goto label_77;
            }
            
            val_64 = mem[val_60 + 24];
            val_64 = val_60 + 24;
            goto label_78;
            label_72:
            val_58 = val_35;
            val_55 = val_55;
            label_73:
            val_39 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_39[0] = val_57;
            val_40 = new Org.BouncyCastle.Math.EC.F2mPoint();
            val_65 = val_1;
            val_66 = val_58;
            val_67 = val_37;
            val_68 = val_39;
            goto label_85;
            label_64:
            val_30 = mem[val_1];
            val_30 = val_1;
            label_40:
            val_52 = mem[val_1 + 648];
            val_52 = val_1 + 648;
            val_54 = mem[val_1 + 656];
            val_54 = val_1 + 656;
            label_65:
            val_59 = ???;
            val_51 = ???;
            val_60 = ???;
            val_27 = ???;
            val_53 = ???;
            val_57 = ???;
            val_46 = ???;
            val_62 = ???;
            val_50 = ???;
            val_63 = ???;
            goto val_1 + 648;
            label_76:
            val_69 = val_6;
            val_39 = val_51;
            if((val_39 & 1) != 0)
            {
                goto label_90;
            }
            
            val_70 = mem[val_51 + 456 + 8];
            val_70 = val_51 + 456 + 8;
            val_71 = val_51;
            if((val_50 & 1) == 0)
            {
                    val_70 = mem[val_71 + 456 + 8];
                val_70 = val_71 + 456 + 8;
                val_71 = val_71;
            }
            
            val_72 = val_51;
            if((val_7 & 1) != 0)
            {
                goto label_96;
            }
            
            val_73 = val_71;
            goto label_98;
            label_77:
            val_64 = 28563616;
            label_78:
            val_69 = val_6;
            val_57 = val_60;
            val_39 = val_57;
            if((val_39 & 1) == 0)
            {
                goto label_106;
            }
            
            label_90:
            val_38 = mem[val_60 + 48];
            val_38 = val_60 + 48;
            Org.BouncyCastle.Math.EC.F2mPoint val_8 = null;
            val_40 = val_8;
            val_41 = val_69;
            val_42 = val_39;
            val_43 = val_69;
            label_47:
            val_8 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_41, x:  val_42, y:  val_43, withCompression:  val_38);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_40;
            label_106:
            val_72 = val_57;
            val_74 = null;
            val_74 = null;
            val_73 = val_69;
            label_98:
            val_71 = val_73;
            label_96:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_9 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_57 = val_9;
            val_57[0] = val_71;
            val_38 = mem[val_60 + 48];
            val_38 = val_60 + 48;
            Org.BouncyCastle.Math.EC.F2mPoint val_10 = null;
            val_40 = val_10;
            val_65 = val_69;
            val_66 = val_39;
            val_67 = val_72;
            val_68 = val_57;
            label_85:
            val_10 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_65, x:  val_66, y:  val_67, zs:  val_9, withCompression:  val_38);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_40;
            label_9:
            System.InvalidOperationException val_23 = new System.InvalidOperationException(message:  "unsupported coordinate system");
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_20;
            Org.BouncyCastle.Math.EC.ECFieldElement val_21;
            Org.BouncyCastle.Math.EC.ECCurve val_22;
            var val_23;
            var val_25;
            var val_26;
            Org.BouncyCastle.Math.EC.ECFieldElement val_27;
            bool val_28;
            bool val_29;
            Org.BouncyCastle.Math.EC.ECFieldElement val_30;
            var val_31;
            Org.BouncyCastle.Math.EC.ECCurve val_32;
            Org.BouncyCastle.Math.EC.ECFieldElement val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            Org.BouncyCastle.Math.EC.ECFieldElement val_42;
            Org.BouncyCastle.Math.EC.ECFieldElement val_43;
            var val_44;
            Org.BouncyCastle.Math.EC.ECFieldElement val_45;
            var val_46;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_47;
            Org.BouncyCastle.Math.EC.ECCurve val_48;
            Org.BouncyCastle.Math.EC.ECFieldElement val_49;
            Org.BouncyCastle.Math.EC.ECFieldElement val_50;
            Org.BouncyCastle.Math.EC.ECFieldElement val_51;
            var val_52;
            Org.BouncyCastle.Math.EC.ECFieldElement val_53;
            var val_54;
            var val_55;
            val_20 = this;
            if(true == 0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            }
            
            }
            
            val_22 = this.Curve;
            val_23 = X21;
            if((val_23 & 1) == 0)
            {
                goto label_5;
            }
            
            val_22 = ???;
            val_25 = ???;
            val_23 = ???;
            val_21 = ???;
            val_26 = ???;
            val_27 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_288;
            label_5:
            if(val_22 == 6)
            {
                goto label_6;
            }
            
            if(val_22 == 1)
            {
                goto label_7;
            }
            
            if(val_22 != 0)
            {
                goto label_8;
            }
            
            val_28 = val_25 + 32;
            val_29 = mem[val_25 + 48];
            val_29 = val_25 + 48;
            val_30 = val_21;
            val_31 = new Org.BouncyCastle.Math.EC.F2mPoint();
            val_32 = val_22;
            val_33 = val_28;
            goto label_14;
            label_6:
            val_27 = mem[val_25 + 32];
            val_27 = val_25 + 32;
            if((val_25 + 32 + 8 + 24) == 0)
            {
                    val_34 = 0;
            }
            
            val_26 = val_25 + 32 + 8 + 32;
            val_35 = val_25 + 32 + 8 + 32;
            if((val_26 & 1) == 0)
            {
                    val_34 = mem[val_25 + 32 + 456 + 8];
                val_34 = val_25 + 32 + 456 + 8;
                val_35 = val_25 + 32 + 8 + 32;
            }
            
            val_36 = mem[val_22 + 688];
            val_36 = val_22 + 688;
            val_28 = val_22;
            val_37 = val_28;
            if((val_26 & 1) == 0)
            {
                    val_36 = val_35;
                val_34 = mem[val_28 + 456 + 8];
                val_34 = val_28 + 456 + 8;
                val_37 = val_28;
            }
            
            val_38 = mem[val_25 + 32 + 408 + 8];
            val_38 = val_25 + 32 + 408 + 8;
            if((val_27 & 1) == 0)
            {
                goto label_26;
            }
            
            val_29 = mem[val_25 + 48];
            val_29 = val_25 + 48;
            val_30 = val_22;
            Org.BouncyCastle.Math.EC.F2mPoint val_2 = null;
            val_31 = val_2;
            val_32 = val_22;
            val_33 = val_27;
            label_14:
            val_2 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_32, x:  val_33, y:  val_30, withCompression:  val_29);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            label_7:
            val_39 = mem[val_25 + 32];
            val_39 = val_25 + 32;
            if((val_25 + 32 + 8 + 24) == 0)
            {
                    val_40 = 0;
            }
            
            val_41 = mem[val_25 + 32 + 8 + 32 + 576];
            val_41 = val_25 + 32 + 8 + 32 + 576;
            if(((val_25 + 32 + 8 + 32) & 1) == 0)
            {
                goto label_32;
            }
            
            val_42 = val_21;
            goto label_33;
            label_26:
            val_43 = val_27;
            if((val_26 & 1) == 0)
            {
                    val_43 = val_27;
                val_38 = mem[val_25 + 32 + 456 + 8];
                val_38 = val_25 + 32 + 456 + 8;
            }
            
            if(val_22 >= (val_22 >> 1))
            {
                goto label_36;
            }
            
            if((val_22 & 1) == 0)
            {
                goto label_38;
            }
            
            val_44 = mem[val_37 + 408 + 8];
            val_44 = val_37 + 408 + 8;
            val_45 = val_27;
            val_46 = val_37;
            if(val_27 != 0)
            {
                goto label_58;
            }
            
            goto label_42;
            label_32:
            val_42 = val_21;
            val_41 = val_25 + 32 + 8 + 32;
            val_40 = mem[val_25 + 32 + 456 + 8];
            val_40 = val_25 + 32 + 456 + 8;
            val_39 = val_39;
            label_33:
            val_26 = val_21;
            val_29 = val_42;
            val_47 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_47[0] = val_42;
            val_28 = mem[val_25 + 48];
            val_28 = val_25 + 48;
            val_31 = new Org.BouncyCastle.Math.EC.F2mPoint();
            val_48 = val_22;
            val_49 = val_29;
            val_50 = val_21;
            goto label_53;
            label_36:
            if((val_26 & 1) == 0)
            {
                goto label_54;
            }
            
            val_51 = val_43;
            val_45 = val_27;
            goto label_67;
            label_38:
            val_44 = val_35;
            val_45 = val_27;
            val_46 = val_37;
            if(val_27 != 0)
            {
                goto label_58;
            }
            
            label_42:
            label_58:
            val_26 = val_28;
            val_51 = val_43;
            val_52 = mem[val_25 + 32 + 408 + 8];
            val_52 = val_25 + 32 + 408 + 8;
            val_53 = val_27;
            if((val_26 & 1) == 0)
            {
                goto label_64;
            }
            
            val_54 = val_51;
            if(val_53 != 0)
            {
                goto label_73;
            }
            
            goto label_66;
            label_54:
            val_51 = val_43;
            val_45 = val_27;
            val_21 = val_21;
            label_67:
            val_52 = mem[val_21 + 408 + 8];
            val_52 = val_21 + 408 + 8;
            val_55 = val_21;
            val_54 = val_51;
            if(val_55 != 0)
            {
                goto label_73;
            }
            
            label_66:
            val_54 = val_51;
            goto label_73;
            label_64:
            if((val_26 & 1) != 0)
            {
                goto label_71;
            }
            
            val_52 = mem[val_26 + 456 + 8];
            val_52 = val_26 + 456 + 8;
            val_54 = val_26;
            label_73:
            val_29 = val_53;
            label_71:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_4 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_47 = val_4;
            val_47[0] = val_51;
            val_28 = mem[val_25 + 48];
            val_28 = val_25 + 48;
            Org.BouncyCastle.Math.EC.F2mPoint val_5 = null;
            val_31 = val_5;
            val_48 = val_22;
            val_49 = val_45;
            val_50 = val_29;
            label_53:
            val_5 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_48, x:  val_49, y:  val_50, zs:  val_4, withCompression:  val_28);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_31;
            label_8:
            System.InvalidOperationException val_18 = new System.InvalidOperationException(message:  "unsupported coordinate system");
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
            var val_23;
            Org.BouncyCastle.Math.EC.ECFieldElement val_24;
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
            if((X23 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
            }
            
            if(val_19 != 6)
            {
                goto label_15;
            }
            
            if(b.m_zs.Length == 0)
            {
                    val_20 = 0;
            }
            
            if(((b.m_x & 1) != 0) || ((b.m_zs[0] & 1) == 0))
            {
                goto label_15;
            }
            
            if((X25 + 24) == 0)
            {
                    val_21 = 0;
                val_20 = 0;
            }
            
            val_22 = X25 + 32;
            val_23 = b.m_y;
            val_24 = val_19;
            val_25 = b.m_x;
            val_26 = val_24;
            if((val_25 & 1) == 0)
            {
                goto label_32;
            }
            
            if((val_26 & 1) == 0)
            {
                goto label_39;
            }
            
            val_26 = val_17;
            goto label_34;
            label_15:
            val_28 = ???;
            val_17 = ???;
            val_22 = ???;
            val_23 = ???;
            val_25 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.F2mPoint).__il2cppRuntimeField_2D8;
            label_5:
            val_27 = mem[val_28];
            val_27 = val_28;
            val_26 = val_28;
            label_34:
            label_39:
            val_19 = val_4;
            val_29 = val_5;
            val_24 = val_10;
            goto val_27 + 792;
            label_32:
            if((val_26 & 1) != 0)
            {
                    Org.BouncyCastle.Math.EC.F2mPoint val_14 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_19, x:  val_24, y:  val_19, withCompression:  val_5 + 48);
                return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_15 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_15[0] = val_24;
            Org.BouncyCastle.Math.EC.F2mPoint val_16 = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  val_19, x:  val_24, y:  val_24, zs:  val_15, withCompression:  val_5 + 48);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_17;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Negate()
        {
            var val_6 = this;
            if(==0)
            {
                    if(true == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint);
            }
            
            }
            
            if((137158656 & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint);
            }
            
            if(this.Curve <= 6)
            {
                    var val_6 = 106054768 + (val_1) << 2;
                val_6 = val_6 + 106054768;
            }
            else
            {
                    System.InvalidOperationException val_5 = new System.InvalidOperationException(message:  "unsupported coordinate system");
            }
        
        }
    
    }

}
