using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224R1Point : AbstractFpPoint
    {
        // Methods
        public SecP224R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecP224R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecP224R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            System.UInt32[] val_21;
            System.UInt32[] val_22;
            Org.BouncyCastle.Math.EC.ECCurve val_29;
            var val_32;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            Org.BouncyCastle.Math.EC.ECFieldElement val_56;
            Org.BouncyCastle.Math.EC.ECFieldElement val_57;
            System.UInt32[] val_58;
            System.UInt32[] val_59;
            System.UInt32[] val_60;
            System.UInt32[] val_61;
            var val_62;
            System.UInt32[] val_63;
            System.UInt32[] val_64;
            System.UInt32[] val_65;
            System.UInt32[] val_66;
            System.UInt32[] val_67;
            System.UInt32[] val_68;
            System.UInt32[] val_69;
            System.UInt32[] val_70;
            val_50 = this;
            if(this.IsInfinity != false)
            {
                    val_51 = b;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_51;
            }
            
            if(b.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_51;
            }
            
            if(val_50 == b)
            {
                goto label_5;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_3 = this.Curve;
            val_52 = this.RawXCoord;
            if(val_52 != null)
            {
                    val_52 = 0;
            }
            
            val_53 = this.RawYCoord;
            if(val_53 != null)
            {
                    val_53 = 0;
            }
            
            val_54 = b.RawXCoord;
            if(val_54 != null)
            {
                    val_54 = 0;
            }
            
            val_55 = b.RawYCoord;
            if(val_55 != null)
            {
                    val_55 = 0;
            }
            
            val_56 = this.RawZCoords[0];
            if(val_56 != null)
            {
                    val_56 = 0;
            }
            
            val_57 = b.RawZCoords[0];
            if(val_57 != null)
            {
                    val_57 = 0;
            }
            
            System.UInt32[] val_17 = Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
            System.UInt32[] val_18 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_58 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_59 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            if((val_56 & 1) == 0)
            {
                goto label_32;
            }
            
            val_60 = 11993091;
            val_61 = 11993091;
            if(val_57 != 0)
            {
                goto label_41;
            }
            
            goto label_36;
            label_5:
            val_54 = ???;
            val_62 = ???;
            val_56 = ???;
            val_52 = ???;
            val_57 = ???;
            val_53 = ???;
            val_55 = ???;
            val_59 = ???;
            val_58 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point).__il2cppRuntimeField_318;
            label_32:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_56 + 16, z:  val_58);
            val_60 = val_21;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_58, y:  val_54 + 16, z:  val_60);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_58, y:  val_56 + 16, z:  val_58);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_58, y:  val_55 + 16, z:  val_58);
            val_61 = val_58;
            if(val_57 != 0)
            {
                goto label_41;
            }
            
            label_36:
            label_41:
            if((val_57 & 1) != 0)
            {
                    val_63 = mem[val_52 + 16];
                val_63 = val_52 + 16;
                val_64 = mem[val_53 + 16];
                val_64 = val_53 + 16;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_57 + 16, z:  val_59);
                val_63 = val_22;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_59, y:  val_52 + 16, z:  val_63);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_59, y:  val_57 + 16, z:  val_59);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_59, y:  val_53 + 16, z:  val_59);
                val_64 = val_59;
            }
            
            val_65 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_63, y:  val_60, z:  val_65);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_64, y:  val_61, z:  val_21);
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  val_65)) == false)
            {
                goto label_52;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat224.IsZero(x:  val_21)) == false)
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_65, z:  val_58);
            System.UInt32[] val_26 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_58, y:  val_65, z:  val_26);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_58, y:  val_63, z:  val_58);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Negate(x:  val_26, z:  val_26);
            val_63 = val_22;
            Org.BouncyCastle.Math.Raw.Nat224.Mul(x:  val_64, y:  val_26, zz:  val_63);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat224.AddBothTo(x:  val_58, y:  val_58, z:  val_26), z:  val_26);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_28 = null;
            val_64 = val_28;
            val_28 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_59;
            if(val_64 == null)
            {
                goto label_57;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_21, z:  val_59);
            val_66 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x;
            val_67 = val_66;
            goto label_58;
            label_53:
            val_62 = val_29;
            label_54:
            val_51 = val_62;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_51;
            label_57:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_21, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x);
            val_67 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x;
            val_66 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x;
            label_58:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_67, y:  val_26, z:  val_66);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_30 = null;
            val_59 = val_30;
            val_30 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_26;
            if(val_59 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_58, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242336656].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.MultiplyAddToExt(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242336656].x, y:  val_21, zz:  val_63);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_58, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242185104].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242336656].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.MultiplyAddToExt(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242336656].x, y:  val_21, zz:  val_63);
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(xx:  val_63, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242336656].x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_31 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_65;
            if((val_32 & 1) == 0)
            {
                    if(val_31 != null)
            {
                    val_68 = mem[val_56 + 16];
                val_68 = val_56 + 16;
                val_63 = val_65;
            }
            else
            {
                    val_63 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242561936].x;
                val_68 = mem[val_56 + 16];
                val_68 = val_56 + 16;
                val_65 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242561936].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_63, y:  val_68, z:  val_65);
            }
            
            if((val_57 & 1) == 0)
            {
                    if(val_31 != null)
            {
                    val_69 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242561936].x;
                val_70 = mem[val_57 + 16];
                val_70 = val_57 + 16;
                val_65 = val_69;
            }
            else
            {
                    val_65 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242561936].x;
                val_70 = mem[val_57 + 16];
                val_70 = val_57 + 16;
                val_69 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544242561936].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_65, y:  val_70, z:  val_69);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_33 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_33[0] = val_31;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point val_36 = null;
            val_51 = val_36;
            val_36 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  val_29, x:  val_28, y:  val_30, zs:  val_33, withCompression:  val_62.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_51;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_24;
            Org.BouncyCastle.Math.EC.ECCurve val_25;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_26;
            var val_27;
            Org.BouncyCastle.Math.EC.ECFieldElement val_28;
            System.UInt32[] val_29;
            System.UInt32[] val_30;
            System.UInt32[] val_31;
            System.UInt32[] val_32;
            System.UInt32[] val_33;
            System.UInt32[] val_34;
            val_24 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_24;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_2 = this.Curve;
            val_25 = 1152921505517441024;
            val_26 = this.RawYCoord;
            val_26 = 0;
            if((val_26 & 1) != 0)
            {
                    val_24 = val_2;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_24;
            }
            
            val_27 = this.RawXCoord;
            if(val_27 != null)
            {
                    val_27 = 0;
            }
            
            val_28 = this.RawZCoords[0];
            if(val_28 != null)
            {
                    val_28 = 0;
            }
            
            System.UInt32[] val_10 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            val_29 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            System.UInt32[] val_12 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  11993091, z:  val_12);
            System.UInt32[] val_13 = Org.BouncyCastle.Math.Raw.Nat224.Create();
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_12, z:  val_13);
            val_30 = 11993091;
            if((val_28 & 1) == 0)
            {
                goto label_20;
            }
            
            if(val_27 != 0)
            {
                goto label_25;
            }
            
            goto label_22;
            label_20:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_30, z:  val_29);
            val_30 = val_29;
            if(val_27 != 0)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  11993091, y:  val_30, z:  val_10);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(x:  11993091, y:  val_30, z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_29, y:  val_10, z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat224.AddBothTo(x:  val_29, y:  val_29, z:  val_29), z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  val_12, y:  11993091, z:  val_12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(len:  7, z:  val_12, bits:  2, c:  0), z:  val_12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(len:  7, x:  val_13, bits:  3, c:  0, z:  val_10), z:  val_10);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_17 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_13;
            if(val_17 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_29, z:  val_13);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x, y:  val_12, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x);
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x;
                val_32 = val_31;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(x:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x, y:  val_12, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x);
                val_32 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x;
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_32, y:  val_12, z:  val_31);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_18 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_12;
            if(val_18 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_12, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x, y:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x);
                val_33 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x;
                val_34 = val_33;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_12, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544243956016].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x, y:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x);
                val_34 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x;
                val_33 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244218160].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(x:  val_34, y:  val_10, z:  val_33);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement val_19 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement();
            .x = val_29;
            if(val_19 == null)
            {
                    val_29 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244554032].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Twice(x:  11993091, z:  val_29);
            val_25 = val_2;
            if((0 & 1) == 0)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244554032].x, y:  11993091, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)[1152921544244554032].x);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_20 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_26 = val_20;
            val_26[0] = val_19;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point val_23 = null;
            val_24 = val_23;
            val_23 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  val_25, x:  val_17, y:  val_18, zs:  val_20, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_24;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            var val_9;
            var val_10;
            val_9 = b;
            val_10 = this;
            if(val_10 != val_9)
            {
                    if(this.IsInfinity != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_9;
            }
            
                if(val_9.IsInfinity != false)
            {
                    val_10 = ???;
                val_9 = ???;
            }
            else
            {
                    if((val_10.RawYCoord & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_9;
            }
            
                if(val_10 != 0)
            {
                goto val_10 + 728;
            }
            
            }
            
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
        {
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            if((this.RawYCoord & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            if(this == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Negate()
        {
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point val_8 = null;
            this = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  this.Curve, x:  this.RawXCoord, y:  this.RawYCoord, zs:  this.RawZCoords, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)this;
        }
    
    }

}
