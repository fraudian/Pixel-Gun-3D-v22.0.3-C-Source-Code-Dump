using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class ECCurve
    {
        // Fields
        public const int COORD_AFFINE = 0;
        public const int COORD_HOMOGENEOUS = 1;
        public const int COORD_JACOBIAN = 2;
        public const int COORD_JACOBIAN_CHUDNOVSKY = 3;
        public const int COORD_JACOBIAN_MODIFIED = 4;
        public const int COORD_LAMBDA_AFFINE = 5;
        public const int COORD_LAMBDA_PROJECTIVE = 6;
        public const int COORD_SKEWED = 7;
        protected readonly Org.BouncyCastle.Math.Field.IFiniteField m_field;
        protected Org.BouncyCastle.Math.EC.ECFieldElement m_a;
        protected Org.BouncyCastle.Math.EC.ECFieldElement m_b;
        protected Org.BouncyCastle.Math.BigInteger m_order;
        protected Org.BouncyCastle.Math.BigInteger m_cofactor;
        protected int m_coord;
        protected Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism;
        protected Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier m_multiplier;
        
        // Properties
        public abstract int FieldSize { get; }
        public abstract Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public virtual Org.BouncyCastle.Math.Field.IFiniteField Field { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement A { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement B { get; }
        public virtual Org.BouncyCastle.Math.BigInteger Order { get; }
        public virtual Org.BouncyCastle.Math.BigInteger Cofactor { get; }
        public virtual int CoordinateSystem { get; }
        
        // Methods
        public static int[] GetAllCoordinateSystems()
        {
            return (System.Int32[])new int[8] {0, 1, 2, 3, 4, 5, 6, 7};
        }
        protected ECCurve(Org.BouncyCastle.Math.Field.IFiniteField field)
        {
            this.m_field = field;
        }
        public abstract int get_FieldSize(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x); // 0
        public abstract bool IsValidFieldElement(Org.BouncyCastle.Math.BigInteger x); // 0
        public virtual Org.BouncyCastle.Math.EC.ECCurve.Config Configure()
        {
            .outer = this;
            .coord = this.m_coord;
            .endomorphism = this.m_endomorphism;
            .multiplier = this.m_multiplier;
            return (Config)new ECCurve.Config();
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y)
        {
            if(this.IsValid() != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Invalid point coordinates");
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y, bool withCompression)
        {
            withCompression = withCompression;
            if(this.IsValid() != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Invalid point coordinates");
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y)
        {
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_1D8;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y, bool withCompression)
        {
            withCompression = withCompression;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_1F8;
        }
        protected abstract Org.BouncyCastle.Math.EC.ECCurve CloneCurve(); // 0
        protected internal abstract Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression); // 0
        protected internal abstract Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression); // 0
        protected virtual Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
        {
            var val_3;
            if(this.m_endomorphism != null)
            {
                    Org.BouncyCastle.Math.EC.Multiplier.GlvMultiplier val_1 = null;
                val_3 = val_1;
                val_1 = new Org.BouncyCastle.Math.EC.Multiplier.GlvMultiplier(curve:  this, glvEndomorphism:  this.m_endomorphism);
                return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)val_3;
            }
            
            Org.BouncyCastle.Math.EC.Multiplier.WNafL2RMultiplier val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Math.EC.Multiplier.WNafL2RMultiplier();
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)val_3;
        }
        public virtual bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 0) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo GetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name)
        {
            var val_4;
            System.Collections.IDictionary val_5;
            var val_7;
            var val_8;
            bool val_1 = false;
            val_4 = 0;
            System.Threading.Monitor.Enter(obj:  point, lockTaken: ref  val_1);
            val_5 = point.m_preCompTable;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 0;
            val_5 = val_5.Item[name];
            if(val_5 == null)
            {
                goto label_7;
            }
            
            val_7 = val_5;
            if(val_7 == null)
            {
                goto label_13;
            }
            
            val_8 = 0;
            val_5 = 0;
            goto label_20;
            label_7:
            val_8 = 0;
            label_13:
            val_7 = 0;
            label_20:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  point);
            }
            
            if(val_8 != 1)
            {
                    return (Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo)val_7;
            }
            
            if(val_5 == null)
            {
                    return (Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo)val_7;
            }
            
            return (Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo)val_7;
        }
        public virtual void SetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
        {
            System.Collections.IDictionary val_4;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  point, lockTaken: ref  val_1);
            val_4 = point.m_preCompTable;
            if(val_4 == null)
            {
                    val_4 = Org.BouncyCastle.Utilities.Platform.CreateHashtable(capacity:  4);
                point.m_preCompTable = val_4;
                if(val_4 == null)
            {
                goto label_13;
            }
            
            }
            
            label_13:
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4.set_Item(key:  name, value:  preCompInfo);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  point);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ImportPoint(Org.BouncyCastle.Math.EC.ECPoint p)
        {
            var val_7;
            var val_8;
            val_7 = p;
            val_8 = this;
            if(val_7 == val_8)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
            }
            
            if(p.m_x == null)
            {
                    if(p.m_y == null)
            {
                goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_288;
            }
            
            }
            
            val_7 = ???;
            val_8 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_1B8;
        }
        public virtual void NormalizeAll(Org.BouncyCastle.Math.EC.ECPoint[] points)
        {
            if(points == null)
            {
                
            }
        
        }
        public virtual void NormalizeAll(Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len, Org.BouncyCastle.Math.EC.ECFieldElement iso)
        {
            int val_4;
            int val_6 = off;
            if(this != 5)
            {
                    if(this != null)
            {
                goto label_2;
            }
            
            }
            
            if(iso != null)
            {
                goto label_3;
            }
            
            return;
            label_2:
            int val_5 = len;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_1 = new Org.BouncyCastle.Math.EC.ECFieldElement[0];
            int[] val_2 = new int[0];
            if(len < 1)
            {
                    return;
            }
            
            val_4 = 0;
            label_18:
            Org.BouncyCastle.Math.EC.ECPoint val_4 = points[(long)val_6];
            if(val_4 == null)
            {
                goto label_9;
            }
            
            if(iso == null)
            {
                    if((val_4 & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if(val_1 == null)
            {
                goto label_10;
            }
            
            if(val_4 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_4 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_1[0] = val_4;
            val_4 = val_4 + 1;
            val_2[0] = val_6;
            label_9:
            val_5 = val_5 - 1;
            val_6 = val_6 + 1;
            if(val_5 != 0)
            {
                goto label_18;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Math.EC.ECAlgorithms.MontgomeryTrick(zs:  val_1, off:  0, len:  val_4, scale:  iso);
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                val_8 = val_8 + 1;
                mem2[0] = points[null];
            }
            while(val_4 != val_8);
            
            return;
            label_3:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "not valid for affine coordinates", paramName:  "iso");
        }
        public abstract Org.BouncyCastle.Math.EC.ECPoint get_Infinity(); // 0
        public virtual Org.BouncyCastle.Math.Field.IFiniteField get_Field()
        {
            return (Org.BouncyCastle.Math.Field.IFiniteField)this.m_field;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_A()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_a;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_B()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_b;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Order()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_order;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Cofactor()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_cofactor;
        }
        public virtual int get_CoordinateSystem()
        {
            return (int)this.m_coord;
        }
        protected virtual void CheckPoint(Org.BouncyCastle.Math.EC.ECPoint point)
        {
            if((point != null) && (point == this))
            {
                    return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "must be non-null and on this curve", paramName:  "point");
        }
        protected virtual void CheckPoints(Org.BouncyCastle.Math.EC.ECPoint[] points)
        {
            if(points == null)
            {
                
            }
        
        }
        protected virtual void CheckPoints(Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
        {
            var val_6;
            var val_7;
            int val_8;
            val_7 = off;
            if(points == null)
            {
                goto label_1;
            }
            
            if(((len | val_7) & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_8 = points.Length;
            if((val_8 - len) < val_7)
            {
                goto label_10;
            }
            
            if(len < 1)
            {
                    return;
            }
            
            val_7 = val_7;
            val_6 = 1;
            goto label_5;
            label_9:
            val_8 = points.Length;
            val_6 = 2;
            label_5:
            int val_3 = val_7 + val_6;
            val_3 = val_3 - 1;
            Org.BouncyCastle.Math.EC.ECPoint val_6 = points[(long)val_3];
            if(val_6 != null)
            {
                    if(val_6 != this)
            {
                goto label_8;
            }
            
            }
            
            if(val_6 < (long)len)
            {
                goto label_9;
            }
            
            return;
            label_8:
            label_10:
            null = new System.ArgumentException(message:  "entries must be null or on this curve", paramName:  "points");
            goto label_10;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "points");
            goto label_10;
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.ECCurve other)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = other;
            if(this == val_1)
            {
                goto label_0;
            }
            
            if(val_1 == null)
            {
                goto label_7;
            }
            
            val_2 = this;
            if((val_2 & 1) == 0)
            {
                goto label_7;
            }
            
            val_2 = this;
            if((val_2 & 1) == 0)
            {
                goto label_7;
            }
            
            val_1 = ???;
            val_2 = ???;
            goto Org.BouncyCastle.Math.EC.ECCurve.__il2cppRuntimeField_vtable;
            label_7:
            val_3 = 0;
            return (bool)val_3;
            label_0:
            val_3 = 1;
            return (bool)val_3;
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                
            }
        
        }
        public override int GetHashCode()
        {
            int val_2 = Org.BouncyCastle.Utilities.Integers.RotateLeft(i:  798117424, distance:  16);
            val_2 = ((Org.BouncyCastle.Utilities.Integers.RotateLeft(i:  798117424, distance:  8)) ^ this) ^ val_2;
            return (int)val_2;
        }
        protected abstract Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, Org.BouncyCastle.Math.BigInteger X1); // 0
        public virtual Org.BouncyCastle.Math.EC.Endo.ECEndomorphism GetEndomorphism()
        {
            return (Org.BouncyCastle.Math.EC.Endo.ECEndomorphism)this.m_endomorphism;
        }
        public virtual Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier GetMultiplier()
        {
            Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier val_2;
            var val_3;
            var val_4;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            val_2 = this.m_multiplier;
            if(val_2 != null)
            {
                    val_3 = 0;
                val_4 = 0;
            }
            else
            {
                    val_2 = this;
                val_3 = 0;
                val_4 = 0;
                this.m_multiplier = val_2;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_3 != 1)
            {
                    return val_2;
            }
            
            if(val_4 == 0)
            {
                    return val_2;
            }
            
            return val_2;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint DecodePoint(byte[] encoded)
        {
            var val_31;
            var val_32;
            int val_1 = (1152921544060131095 < 0) ? 1152921544060131102 : 1152921544060131095;
            byte val_24 = encoded[0];
            if(val_24 <= 7)
            {
                    var val_25 = 106054712;
                val_1 = val_1 >> 3;
                val_25 = (106054712 + (encoded[0]) << 2) + val_25;
            }
            else
            {
                    val_31 = 1152921544060080656;
                val_32 = new System.FormatException(message:  "Invalid point encoding " + val_24);
            }
        
        }
    
    }

}
