using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP384R1Point : AbstractFpPoint
    {
        // Methods
        public SecP384R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public SecP384R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal SecP384R1Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            bool val_1 = withCompression;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            System.UInt32[] val_21;
            System.UInt32[] val_22;
            Org.BouncyCastle.Math.EC.ECCurve val_30;
            var val_33;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            Org.BouncyCastle.Math.EC.ECFieldElement val_57;
            Org.BouncyCastle.Math.EC.ECFieldElement val_58;
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
            System.UInt32[] val_71;
            val_51 = this;
            if(this.IsInfinity != false)
            {
                    val_52 = b;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_52;
            }
            
            if(b.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_52;
            }
            
            if(val_51 == b)
            {
                goto label_5;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_3 = this.Curve;
            val_53 = this.RawXCoord;
            if(val_53 != null)
            {
                    val_53 = 0;
            }
            
            val_54 = this.RawYCoord;
            if(val_54 != null)
            {
                    val_54 = 0;
            }
            
            val_55 = b.RawXCoord;
            if(val_55 != null)
            {
                    val_55 = 0;
            }
            
            val_56 = b.RawYCoord;
            if(val_56 != null)
            {
                    val_56 = 0;
            }
            
            val_57 = this.RawZCoords[0];
            if(val_57 != null)
            {
                    val_57 = 0;
            }
            
            val_58 = b.RawZCoords[0];
            if(val_58 != null)
            {
                    val_58 = 0;
            }
            
            System.UInt32[] val_17 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  24);
            System.UInt32[] val_18 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  24);
            val_59 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            val_60 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            if((val_57 & 1) == 0)
            {
                goto label_32;
            }
            
            val_61 = 11993091;
            if(val_58 != 0)
            {
                goto label_41;
            }
            
            goto label_36;
            label_5:
            val_55 = ???;
            val_62 = ???;
            val_53 = ???;
            val_57 = ???;
            val_58 = ???;
            val_54 = ???;
            val_60 = ???;
            val_59 = ???;
            val_56 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point).__il2cppRuntimeField_318;
            label_32:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_57 + 16, z:  val_59);
            val_61 = val_21;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_59, y:  val_55 + 16, z:  val_61);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_59, y:  val_57 + 16, z:  val_59);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_59, y:  val_56 + 16, z:  val_59);
            if(val_58 != 0)
            {
                goto label_41;
            }
            
            label_36:
            label_41:
            if((val_58 & 1) != 0)
            {
                    val_63 = mem[val_53 + 16];
                val_63 = val_53 + 16;
                val_64 = mem[val_54 + 16];
                val_64 = val_54 + 16;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_58 + 16, z:  val_60);
                val_63 = val_22;
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_60, y:  val_53 + 16, z:  val_63);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_60, y:  val_58 + 16, z:  val_60);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_60, y:  val_54 + 16, z:  val_60);
                val_64 = val_60;
            }
            
            val_65 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_63, y:  val_61, z:  val_65);
            val_66 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_64, y:  val_59, z:  val_66);
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  12, x:  val_65)) == false)
            {
                goto label_52;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  12, x:  val_66)) == false)
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_65, z:  val_59);
            System.UInt32[] val_27 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_59, y:  val_65, z:  val_27);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_59, y:  val_63, z:  val_59);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Negate(x:  val_27, z:  val_27);
            Org.BouncyCastle.Math.Raw.Nat384.Mul(x:  val_64, y:  val_27, zz:  val_22);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.AddBothTo(len:  12, x:  val_59, y:  val_59, z:  val_27), z:  val_27);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_29 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_60;
            if(val_29 == null)
            {
                goto label_57;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_66, z:  val_60);
            val_67 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x;
            val_68 = val_67;
            goto label_58;
            label_53:
            val_62 = val_30;
            label_54:
            val_52 = val_62;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_52;
            label_57:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_66, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x);
            val_68 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x;
            val_67 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x;
            label_58:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_68, y:  val_27, z:  val_67);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_31 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_27;
            if(val_31 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_59, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291192640].x);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_59, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291041088].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291192640].x);
            }
            
            Org.BouncyCastle.Math.Raw.Nat384.Mul(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291192640].x, y:  val_66, zz:  val_21);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddExt(xx:  val_22, yy:  val_21, zz:  val_22);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(xx:  val_22, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291192640].x);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_32 = null;
            val_63 = val_32;
            val_32 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_65;
            if((val_33 & 1) == 0)
            {
                    if(val_63 != null)
            {
                    val_69 = mem[val_57 + 16];
                val_69 = val_57 + 16;
                val_66 = val_65;
            }
            else
            {
                    val_66 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291381056].x;
                val_69 = mem[val_57 + 16];
                val_69 = val_57 + 16;
                val_65 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291381056].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_66, y:  val_69, z:  val_65);
            }
            
            if((val_58 & 1) == 0)
            {
                    if(val_63 != null)
            {
                    val_70 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291381056].x;
                val_71 = mem[val_58 + 16];
                val_71 = val_58 + 16;
                val_65 = val_70;
            }
            else
            {
                    val_65 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291381056].x;
                val_71 = mem[val_58 + 16];
                val_71 = val_58 + 16;
                val_70 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544291381056].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_65, y:  val_71, z:  val_70);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_34 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_34[0] = val_63;
            val_57 = val_62.IsCompressed;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point val_37 = null;
            val_52 = val_37;
            val_37 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve:  val_30, x:  val_29, y:  val_31, zs:  val_34, withCompression:  val_57);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_52;
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
            val_25 = 1152921505518080000;
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
            
            System.UInt32[] val_10 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            val_29 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            System.UInt32[] val_12 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  11993091, z:  val_12);
            System.UInt32[] val_13 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_12, z:  val_13);
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
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_30, z:  val_29);
            val_30 = val_29;
            if(val_27 != 0)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  11993091, y:  val_30, z:  val_10);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Add(x:  11993091, y:  val_30, z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_29, y:  val_10, z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.AddBothTo(len:  12, x:  val_29, y:  val_29, z:  val_29), z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  val_12, y:  11993091, z:  val_12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(len:  12, z:  val_12, bits:  2, c:  0), z:  val_12);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(x:  Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(len:  12, x:  val_13, bits:  3, c:  0, z:  val_10), z:  val_10);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_17 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_13;
            if(val_17 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_29, z:  val_13);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x, y:  val_12, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x);
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x;
                val_32 = val_31;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x, y:  val_12, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x);
                val_32 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x;
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_32, y:  val_12, z:  val_31);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_18 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_12;
            if(val_18 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_12, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x, y:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x);
                val_33 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x;
                val_34 = val_33;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_12, y:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544292775136].x, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x);
                Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x, y:  val_29, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x);
                val_34 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x;
                val_33 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293037280].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(x:  val_34, y:  val_10, z:  val_33);
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement val_19 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement();
            .x = val_29;
            if(val_19 == null)
            {
                    val_29 = (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293373152].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Twice(x:  11993091, z:  val_29);
            val_25 = val_2;
            if((0 & 1) == 0)
            {
                    Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293373152].x, y:  11993091, z:  (Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)[1152921544293373152].x);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_20 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_26 = val_20;
            val_26[0] = val_19;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point val_23 = null;
            val_24 = val_23;
            val_23 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve:  val_25, x:  val_17, y:  val_18, zs:  val_20, withCompression:  this.IsCompressed);
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
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point val_8 = null;
            this = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve:  this.Curve, x:  this.RawXCoord, y:  this.RawYCoord, zs:  this.RawZCoords, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)this;
        }
    
    }

}
