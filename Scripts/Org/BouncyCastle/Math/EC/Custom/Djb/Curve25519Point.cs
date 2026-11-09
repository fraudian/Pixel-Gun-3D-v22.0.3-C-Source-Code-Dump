using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
    internal class Curve25519Point : AbstractFpPoint
    {
        // Methods
        public Curve25519Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
        
        }
        public Curve25519Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            withCompression = withCompression;
            this = new Org.BouncyCastle.Math.EC.ECPointBase(curve:  curve, x:  x, y:  y, withCompression:  withCompression);
            if(((x == 0) ? 1 : 0) == ((y == 0) ? 1 : 0))
            {
                    return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "Exactly one of the field elements is null");
        }
        internal Curve25519Point(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            val_2 = new Org.BouncyCastle.Math.EC.ECPointBase(curve:  curve, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint Detach()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  0, x:  this.AffineXCoord, y:  this.AffineYCoord, withCompression:  false);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
        {
            if(index != 1)
            {
                    return this.GetZCoord(index:  typeof(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point).__il2cppRuntimeField_370>>0&0xFFFFFFFF);
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point).__il2cppRuntimeField_368;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            System.UInt32[] val_21;
            System.UInt32[] val_22;
            System.UInt32[] val_23;
            var val_32;
            var val_52;
            var val_53;
            Org.BouncyCastle.Math.EC.ECCurve val_54;
            var val_55;
            Org.BouncyCastle.Math.EC.ECFieldElement val_56;
            var val_57;
            var val_58;
            Org.BouncyCastle.Math.EC.ECFieldElement val_59;
            System.UInt32[] val_60;
            System.UInt32[] val_61;
            System.UInt32[] val_62;
            System.UInt32[] val_63;
            Org.BouncyCastle.Math.EC.ECFieldElement val_64;
            var val_65;
            System.UInt32[] val_66;
            System.UInt32[] val_67;
            var val_68;
            System.UInt32[] val_69;
            System.UInt32[] val_70;
            System.UInt32[] val_71;
            System.UInt32[] val_72;
            System.UInt32[] val_73;
            System.UInt32[] val_74;
            System.UInt32[] val_75;
            val_52 = this;
            if(this.IsInfinity != false)
            {
                    val_53 = b;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_53;
            }
            
            if(b.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_53;
            }
            
            if(val_52 == b)
            {
                goto label_5;
            }
            
            val_54 = this.Curve;
            Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.RawXCoord;
            val_55 = this.RawYCoord;
            if(val_55 != null)
            {
                    val_55 = 0;
            }
            
            val_56 = this.RawZCoords[0];
            if(val_56 != null)
            {
                    val_56 = 0;
            }
            
            val_57 = b.RawXCoord;
            if(val_57 != null)
            {
                    val_57 = 0;
            }
            
            val_58 = b.RawYCoord;
            if(val_58 != null)
            {
                    val_58 = 0;
            }
            
            val_59 = b.RawZCoords[0];
            if(val_59 != null)
            {
                    val_59 = 0;
            }
            
            System.UInt32[] val_17 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            System.UInt32[] val_18 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_60 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            val_61 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            if((val_56 & 1) == 0)
            {
                goto label_32;
            }
            
            val_62 = 11993091;
            val_63 = 11993091;
            if(val_59 != 0)
            {
                goto label_41;
            }
            
            goto label_36;
            label_5:
            val_60 = ???;
            val_64 = ???;
            val_56 = ???;
            val_59 = ???;
            val_55 = ???;
            val_58 = ???;
            val_61 = ???;
            val_54 = ???;
            val_57 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point).__il2cppRuntimeField_318;
            label_32:
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_56 + 16, z:  val_60);
            val_62 = val_21;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_60, y:  val_57 + 16, z:  val_62);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_60, y:  val_56 + 16, z:  val_60);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_60, y:  val_58 + 16, z:  val_60);
            val_63 = val_60;
            if(val_59 != 0)
            {
                goto label_41;
            }
            
            label_36:
            label_41:
            if((val_59 & 1) != 0)
            {
                    val_65 = val_22;
                if(val_65 == 0)
            {
                    val_65 = val_22;
            }
            
                val_66 = mem[val_22 + 16];
                val_66 = val_22 + 16;
                val_67 = mem[val_55 + 16];
                val_67 = val_55 + 16;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_59 + 16, z:  val_61);
                val_68 = val_22;
                if(val_68 == 0)
            {
                    val_68 = val_22;
            }
            
                val_66 = val_23;
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_61, y:  val_22 + 16, z:  val_66);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_61, y:  val_59 + 16, z:  val_61);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_61, y:  val_55 + 16, z:  val_61);
                val_67 = val_61;
            }
            
            val_69 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_66, y:  val_62, z:  val_69);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_67, y:  val_63, z:  val_21);
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  val_69)) == false)
            {
                goto label_52;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat256.IsZero(x:  val_21)) == false)
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            System.UInt32[] val_27 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_69, z:  val_27);
            System.UInt32[] val_28 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_27, y:  val_69, z:  val_28);
            val_22 = val_27;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_27, y:  val_66, z:  val_60);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Negate(x:  val_28, z:  val_28);
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  val_67, y:  val_28, zz:  val_23);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce27(x:  Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(x:  val_60, y:  val_60, z:  val_28), z:  val_28);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_30 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_61;
            if(val_30 == null)
            {
                goto label_57;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_21, z:  val_61);
            val_70 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544502865296].x;
            val_71 = val_70;
            goto label_58;
            label_53:
            val_64 = val_54;
            label_54:
            val_53 = val_64;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_53;
            label_57:
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_21, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544502865296].x);
            val_71 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544502865296].x;
            val_70 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544502865296].x;
            label_58:
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_71, y:  val_28, z:  val_70);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_31 = null;
            val_67 = val_31;
            val_31 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_28;
            val_61 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544502865296].x;
            val_62 = val_32;
            if(val_67 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_60, y:  val_61, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503016848].x);
                val_72 = val_23;
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.MultiplyAddToExt(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503016848].x, y:  val_21, zz:  val_72);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_60, y:  val_61, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503016848].x);
                val_72 = val_23;
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.MultiplyAddToExt(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503016848].x, y:  val_21, zz:  val_72);
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(xx:  val_72, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503016848].x);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_33 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_69;
            if((val_62 & 1) == 0)
            {
                    if(val_33 != null)
            {
                    val_73 = mem[val_56 + 16];
                val_73 = val_56 + 16;
                val_61 = val_69;
            }
            else
            {
                    val_61 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503242128].x;
                val_73 = mem[val_56 + 16];
                val_73 = val_56 + 16;
                val_69 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503242128].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_61, y:  val_73, z:  val_69);
            }
            
            if((val_59 & 1) == 0)
            {
                    if(val_33 != null)
            {
                    val_61 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503242128].x;
                val_74 = mem[val_59 + 16];
                val_74 = val_59 + 16;
                val_75 = val_61;
            }
            else
            {
                    val_75 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503242128].x;
                val_74 = mem[val_59 + 16];
                val_74 = val_59 + 16;
                val_61 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544503242128].x;
            }
            
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_75, y:  val_74, z:  val_61);
            }
            
            var val_51 = val_59;
            val_51 = val_62 & val_51;
            var val_34 = (val_51 != 1) ? (val_22) : 0;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_35 = new Org.BouncyCastle.Math.EC.ECFieldElement[2];
            val_56 = val_35;
            val_56[0] = val_33;
            val_56[1] = val_64;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point val_38 = null;
            val_53 = val_38;
            val_38 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  val_54, x:  val_30, y:  val_31, zs:  val_35, withCompression:  val_64.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_53;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint Twice()
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = this;
            if(this.IsInfinity == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_11;
            }
            
            Org.BouncyCastle.Math.EC.ECCurve val_2 = this.Curve;
            if((this.RawYCoord & 1) != 0)
            {
                    val_10 = ???;
            }
            else
            {
                    val_11 = val_10;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_11;
            }
        
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
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point val_8 = null;
            this = val_8;
            val_8 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  this.Curve, x:  this.RawXCoord, y:  this.RawYCoord, zs:  this.RawZCoords, withCompression:  this.IsCompressed);
            return (Org.BouncyCastle.Math.EC.ECPoint)this;
        }
        protected virtual Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement CalculateJacobianModifiedW(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z, uint[] ZSquared)
        {
            System.UInt32[] val_6;
            var val_7;
            var val_8;
            System.UInt32[] val_9;
            System.UInt32[] val_10;
            val_6 = ZSquared;
            val_7 = this.Curve;
            if(val_7 != null)
            {
                    val_7 = 0;
            }
            
            if((Z & 1) != 0)
            {
                    val_8 = val_7;
                return (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)val_8;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_4 = null;
            val_8 = val_4;
            val_4 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            .x = val_5;
            if(val_6 == null)
            {
                goto label_8;
            }
            
            label_17:
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_6, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544504461600].x);
            val_6 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544504461600].x;
            val_9 = val_6;
            if(val_7 == 0)
            {
                    val_9 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544504461600].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_6, y:  11993091, z:  val_9);
            return (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)val_8;
            label_8:
            val_10 = val_5;
            if(val_8 == null)
            {
                    val_10 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544504461600].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  Z.x, z:  val_10);
            if(val_8 != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        protected virtual Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement GetJacobianModifiedW()
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_5;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_1 = this.RawZCoords;
            val_5 = val_1[1];
            Org.BouncyCastle.Math.EC.ECFieldElement val_5 = val_1[0];
            val_5 = this;
            val_1[1] = val_5;
            return (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)val_5;
        }
        protected virtual Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point TwiceJacobianModified(bool calculateW)
        {
            var val_25;
            var val_26;
            Org.BouncyCastle.Math.EC.ECFieldElement val_27;
            System.UInt32[] val_28;
            System.UInt32[] val_29;
            System.UInt32[] val_30;
            System.UInt32[] val_31;
            System.UInt32[] val_32;
            var val_33;
            System.UInt32[] val_34;
            System.UInt32[] val_35;
            System.UInt32[] val_36;
            System.UInt32[] val_37;
            Org.BouncyCastle.Math.EC.ECFieldElement val_38;
            System.UInt32[] val_40;
            val_25 = this.RawXCoord;
            if(val_25 != null)
            {
                    val_25 = 0;
            }
            
            val_26 = this.RawYCoord;
            if(val_26 != null)
            {
                    val_26 = 0;
            }
            
            val_27 = this.RawZCoords[0];
            if(val_27 != null)
            {
                    val_27 = 0;
            }
            
            System.UInt32[] val_8 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  11993091, z:  val_8);
            uint val_10 = Org.BouncyCastle.Math.Raw.Nat256.AddTo(x:  0, z:  val_8);
            val_10 = val_10 + (Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(x:  val_8, y:  val_8, z:  val_8));
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce27(x:  val_10, z:  val_8);
            System.UInt32[] val_11 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(x:  11993091, z:  val_11);
            System.UInt32[] val_12 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_11, y:  11993091, z:  val_12);
            System.UInt32[] val_13 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_12, y:  11993091, z:  val_13);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(x:  val_13, z:  val_13);
            val_28 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_12, z:  val_28);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(x:  val_28, z:  val_28);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_15 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_12;
            if(val_15 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_8, z:  val_12);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x, y:  val_13, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x);
                val_29 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x;
                val_30 = val_29;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x:  val_8, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x, y:  val_13, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x);
                val_30 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x;
                val_29 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_30, y:  val_13, z:  val_29);
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_16 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_13;
            if(val_16 != null)
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_13, y:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x, y:  val_8, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x);
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x;
                val_32 = val_31;
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_13, y:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506307632].x, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x);
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x, y:  val_8, z:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x);
                val_32 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x;
                val_31 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506569776].x;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(x:  val_32, y:  val_28, z:  val_31);
            val_33 = 1152921505521381376;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_17 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_11;
            val_34 = 0;
            if((Org.BouncyCastle.Math.Raw.Nat256.IsOne(x:  11993091)) != true)
            {
                    if(val_17 != null)
            {
                    val_35 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506905648].x;
                val_36 = 11993091;
                val_37 = val_35;
            }
            else
            {
                    val_37 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506905648].x;
                val_36 = 11993091;
                val_35 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544506905648].x;
            }
            
                val_34 = val_36;
                Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_37, y:  val_34, z:  val_35);
                val_33 = 1152921505521381376;
            }
            
            if(calculateW == false)
            {
                goto label_29;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement val_19 = null;
            val_38 = val_19;
            val_19 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
            .x = val_28;
            if(val_38 == null)
            {
                goto label_30;
            }
            
            val_40 = val_28;
            goto label_31;
            label_29:
            val_38 = 0;
            goto label_32;
            label_30:
            val_40 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544507020336].x;
            val_28 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544507020336].x;
            label_31:
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x:  val_40, y:  this, z:  val_28);
            val_34 = (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544507020336].x;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(x:  (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)[1152921544507020336].x, z:  val_34);
            label_32:
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_21 = new Org.BouncyCastle.Math.EC.ECFieldElement[2];
            val_21[0] = val_17;
            val_21[1] = val_38;
            return (Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  this.Curve, x:  val_15, y:  val_16, zs:  val_21, withCompression:  this.IsCompressed);
        }
    
    }

}
