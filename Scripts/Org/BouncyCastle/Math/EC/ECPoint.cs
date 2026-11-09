using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class ECPoint
    {
        // Fields
        protected static Org.BouncyCastle.Math.EC.ECFieldElement[] EMPTY_ZS;
        protected internal readonly Org.BouncyCastle.Math.EC.ECCurve m_curve;
        protected internal readonly Org.BouncyCastle.Math.EC.ECFieldElement m_x;
        protected internal readonly Org.BouncyCastle.Math.EC.ECFieldElement m_y;
        protected internal readonly Org.BouncyCastle.Math.EC.ECFieldElement[] m_zs;
        protected internal readonly bool m_withCompression;
        protected internal System.Collections.IDictionary m_preCompTable;
        
        // Properties
        public virtual Org.BouncyCastle.Math.EC.ECCurve Curve { get; }
        protected virtual int CurveCoordinateSystem { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement X { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement Y { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement AffineXCoord { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement AffineYCoord { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement XCoord { get; }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement YCoord { get; }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement RawXCoord { get; }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement RawYCoord { get; }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement[] RawZCoords { get; }
        public bool IsInfinity { get; }
        public bool IsCompressed { get; }
        protected internal abstract bool CompressionYTilde { get; }
        
        // Methods
        protected static Org.BouncyCastle.Math.EC.ECFieldElement[] GetInitialZCoords(Org.BouncyCastle.Math.EC.ECCurve curve)
        {
            var val_6;
            var val_7;
            if((curve != null) && (curve != 5))
            {
                    if(curve != null)
            {
                goto label_3;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            return (Org.BouncyCastle.Math.EC.ECFieldElement[])Org.BouncyCastle.Math.EC.ECPoint.EMPTY_ZS;
            label_3:
            val_7 = null;
            val_7 = null;
            if((curve - 1) <= 5)
            {
                    var val_6 = 106054744 + ((curve - 1)) << 2;
                val_6 = val_6 + 106054744;
            }
            else
            {
                    System.ArgumentException val_5 = new System.ArgumentException(message:  "unknown coordinate system");
            }
        
        }
        protected ECPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            val_2 = new System.Object();
            this.m_curve = curve;
            this.m_x = val_2;
            this.m_y = y;
            this.m_zs = Org.BouncyCastle.Math.EC.ECPoint.GetInitialZCoords(curve:  curve);
            this.m_withCompression = withCompression;
        }
        internal ECPoint(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            val_1 = new System.Object();
            this.m_curve = curve;
            this.m_x = val_1;
            this.m_y = y;
            this.m_zs = zs;
            this.m_withCompression = withCompression;
        }
        protected internal bool SatisfiesCofactor()
        {
            Org.BouncyCastle.Math.EC.ECPoint val_3;
            var val_4;
            val_3 = this;
            if(this == null)
            {
                    return true;
            }
            
            val_4 = null;
            val_4 = null;
            if((val_3 & 1) != 0)
            {
                    return true;
            }
            
            val_3 = Org.BouncyCastle.Math.EC.ECAlgorithms.ReferenceMultiply(p:  this, k:  this);
            if(val_1.m_x != null)
            {
                    return true;
            }
            
            var val_2 = (val_1.m_y != 0) ? 1 : 0;
            return true;
        }
        protected abstract bool SatisfiesCurveEquation(); // 0
        public Org.BouncyCastle.Math.EC.ECPoint GetDetachedPoint()
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECCurve get_Curve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)this.m_curve;
        }
        protected abstract Org.BouncyCastle.Math.EC.ECPoint Detach(); // 0
        protected virtual int get_CurveCoordinateSystem()
        {
            if(this.m_curve == null)
            {
                    return (int)this.m_curve;
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.ECCurve).__il2cppRuntimeField_2E8;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_X()
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_Y()
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_AffineXCoord()
        {
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_1E8;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_AffineYCoord()
        {
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_1F8;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_XCoord()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_x;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement get_YCoord()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_y;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
        {
            var val_1;
            Org.BouncyCastle.Math.EC.ECFieldElement val_2;
            val_1 = index;
            if(((val_1 & 2147483648) == 0) && (this.m_zs.Length > val_1))
            {
                    val_1 = (long)val_1;
                val_2 = this.m_zs[val_1];
                return (Org.BouncyCastle.Math.EC.ECFieldElement)val_2;
            }
            
            val_2 = 0;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_2;
        }
        public virtual Org.BouncyCastle.Math.EC.ECFieldElement[] GetZCoords()
        {
            System.Array val_3;
            if(this.m_zs.Length != 0)
            {
                    int val_1 = this.m_zs.Length & 4294967295;
                Org.BouncyCastle.Math.EC.ECFieldElement[] val_2 = new Org.BouncyCastle.Math.EC.ECFieldElement[0];
                val_3 = val_2;
                System.Array.Copy(sourceArray:  this.m_zs, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.m_zs.Length);
                return val_3;
            }
            
            val_3 = this.m_zs;
            return val_3;
        }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement get_RawXCoord()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_x;
        }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement get_RawYCoord()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this.m_y;
        }
        protected internal Org.BouncyCastle.Math.EC.ECFieldElement[] get_RawZCoords()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement[])this.m_zs;
        }
        protected virtual void CheckNormalized()
        {
            if((this & 1) != 0)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "point not in normal form");
        }
        public virtual bool IsNormalized()
        {
            if(this == null)
            {
                    return true;
            }
            
            if(this == 5)
            {
                    return true;
            }
            
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return true;
            }
            
            }
            
            if(this.m_zs[0] == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint Normalize()
        {
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            }
            
            if(this == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            if(this == 5)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            if((this.m_zs[0] & 1) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
        
        }
        internal virtual Org.BouncyCastle.Math.EC.ECPoint Normalize(Org.BouncyCastle.Math.EC.ECFieldElement zInv)
        {
            if(1152921544084743342 >= 3)
            {
                goto label_1;
            }
            
            if(zInv != null)
            {
                goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_268;
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_268;
            label_1:
            if(this != 6)
            {
                    if(this == 1)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "not a projective coordinate system");
            }
            
            }
        
        }
        protected virtual Org.BouncyCastle.Math.EC.ECPoint CreateScaledPoint(Org.BouncyCastle.Math.EC.ECFieldElement sx, Org.BouncyCastle.Math.EC.ECFieldElement sy)
        {
            var val_1 = (this.m_withCompression == true) ? 1 : 0;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_1F8;
        }
        public bool get_IsInfinity()
        {
            if(this.m_x == null)
            {
                    return (bool)(this.m_y == 0) ? 1 : 0;
            }
            
            return false;
        }
        public bool get_IsCompressed()
        {
            return (bool)this.m_withCompression;
        }
        public bool IsValid()
        {
            var val_2;
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                goto label_2;
            }
            
            }
            
            if(this != null)
            {
                    if(((this & 1) == 0) || (this.SatisfiesCofactor() == false))
            {
                goto label_4;
            }
            
            }
            
            label_2:
            val_2 = 1;
            return (bool)val_2;
            label_4:
            val_2 = 0;
            return (bool)val_2;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ScaleX(Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            var val_9;
            var val_10;
            val_9 = this;
            val_10 = scale;
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_9;
            }
            
            }
            
            val_9 = ???;
            val_10 = ???;
            var val_1 = (this.m_withCompression == true) ? 1 : 0;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_208;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ScaleY(Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)this;
            }
            
            }
            
            this = ???;
            var val_1 = (this.m_withCompression == true) ? 1 : 0;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_208;
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                
            }
        
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.ECPoint other)
        {
            Org.BouncyCastle.Math.EC.ECPoint val_12;
            var val_13;
            Org.BouncyCastle.Math.EC.ECPoint val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            int val_20;
            Org.BouncyCastle.Math.EC.ECPoint val_21;
            var val_22;
            val_13 = other;
            val_14 = this;
            if(val_14 == val_13)
            {
                goto label_1;
            }
            
            if(val_13 == null)
            {
                goto label_31;
            }
            
            val_12 = val_14;
            if(this.m_x == null)
            {
                goto label_3;
            }
            
            val_16 = 0;
            goto label_4;
            label_1:
            val_17 = 1;
            return (bool)val_17;
            label_3:
            var val_1 = (this.m_y == 0) ? 1 : 0;
            label_4:
            if(other.m_x != null)
            {
                    val_18 = 0;
            }
            else
            {
                    var val_2 = (other.m_y == 0) ? 1 : 0;
            }
            
            if((val_1 | val_2) != 1)
            {
                goto label_8;
            }
            
            val_1 = val_1 & val_2;
            if(val_1 != 1)
            {
                goto label_31;
            }
            
            val_17 = 1;
            if(this == null)
            {
                    return (bool)val_17;
            }
            
            if(val_13 == null)
            {
                    return (bool)val_17;
            }
            
            goto label_12;
            label_8:
            if((val_12 | val_13) == null)
            {
                goto label_28;
            }
            
            if(this == null)
            {
                goto label_14;
            }
            
            if(val_13 == null)
            {
                goto label_15;
            }
            
            if((val_12 & 1) == 0)
            {
                goto label_31;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_5 = new Org.BouncyCastle.Math.EC.ECPoint[2];
            val_5[0] = val_14;
            val_5[1] = val_12;
            val_15 = val_5;
            val_20 = val_5.Length;
            if(val_20 == 0)
            {
                    val_15 = 0;
                val_20 = val_5.Length;
            }
            
            val_14 = val_5[0];
            if(val_20 <= 1)
            {
                    val_15 = 0;
            }
            
            val_21 = val_5[1];
            if(val_14 != null)
            {
                goto label_28;
            }
            
            goto label_26;
            label_14:
            val_21 = val_13;
            goto label_28;
            label_15:
            val_14 = val_14;
            if(this != null)
            {
                goto label_28;
            }
            
            label_26:
            label_28:
            val_12 = val_14;
            if((val_12 & 1) == 0)
            {
                goto label_31;
            }
            
            val_22 = val_13;
            label_12:
            val_21 = ???;
            val_12 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2B8;
            label_31:
            val_17 = 0;
            return (bool)val_17;
        }
        public override int GetHashCode()
        {
            var val_1;
            if(this != null)
            {
                    val_1 = this;
            }
            else
            {
                    val_1 = 0;
            }
            
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return (int)val_1;
            }
            
            }
            
            val_1 = 348454144;
            return (int)val_1;
        }
        public override string ToString()
        {
            var val_19;
            Org.BouncyCastle.Math.EC.ECFieldElement val_20;
            var val_21;
            val_19 = this;
            if(this.m_x == null)
            {
                    if(this.m_y == null)
            {
                    return "INF";
            }
            
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  '(');
                System.Text.StringBuilder val_3 = val_1.Append(value:  this.m_x);
                System.Text.StringBuilder val_4 = val_1.Append(value:  ',');
                val_20 = this.m_y;
            }
            else
            {
                    System.Text.StringBuilder val_5 = val_1.Append(value:  '(');
                System.Text.StringBuilder val_6 = val_1.Append(value:  this.m_x);
                System.Text.StringBuilder val_7 = val_1.Append(value:  ',');
                val_20 = this.m_y;
            }
            
            System.Text.StringBuilder val_8 = val_1.Append(value:  val_20);
            val_21 = 0;
            goto label_5;
            label_11:
            System.Text.StringBuilder val_9 = val_1.Append(value:  ',');
            System.Text.StringBuilder val_10 = val_1.Append(value:  this.m_zs[0]);
            val_21 = 1;
            label_5:
            if(val_21 < this.m_zs.Length)
            {
                goto label_11;
            }
            
            System.Text.StringBuilder val_11 = val_1.Append(value:  ')');
            val_19 = ???;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        public virtual byte[] GetEncoded()
        {
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_2B8;
        }
        public abstract byte[] GetEncoded(bool compressed); // 0
        protected internal abstract bool get_CompressionYTilde(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECPoint Add(Org.BouncyCastle.Math.EC.ECPoint b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECPoint Subtract(Org.BouncyCastle.Math.EC.ECPoint b); // 0
        public abstract Org.BouncyCastle.Math.EC.ECPoint Negate(); // 0
        public virtual Org.BouncyCastle.Math.EC.ECPoint TimesPow2(int e)
        {
            var val_2;
            int val_2 = e;
            val_2 = this;
            if((val_2 & 2147483648) == 0)
            {
                    val_2 = val_2 - 1;
                if((val_2 & 2147483648) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_2;
            }
            
                do
            {
                val_2 = val_2 - 1;
                val_2 = val_2;
            }
            while((val_2 & 2147483648) == 0);
            
                return (Org.BouncyCastle.Math.EC.ECPoint)val_2;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "cannot be negative", paramName:  "e");
        }
        public abstract Org.BouncyCastle.Math.EC.ECPoint Twice(); // 0
        public abstract Org.BouncyCastle.Math.EC.ECPoint Multiply(Org.BouncyCastle.Math.BigInteger b); // 0
        public virtual Org.BouncyCastle.Math.EC.ECPoint TwicePlus(Org.BouncyCastle.Math.EC.ECPoint b)
        {
            if(this == null)
            {
                
            }
        
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
        {
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_338;
        }
        private static ECPoint()
        {
            Org.BouncyCastle.Math.EC.ECPoint.EMPTY_ZS = new Org.BouncyCastle.Math.EC.ECFieldElement[0];
        }
    
    }

}
