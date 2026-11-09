using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT131R2Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT131R2_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point m_infinity;
        
        // Properties
        public override int FieldSize { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override bool IsKoblitz { get; }
        public virtual int M { get; }
        public virtual bool IsTrinomial { get; }
        public virtual int K1 { get; }
        public virtual int K2 { get; }
        public virtual int K3 { get; }
        
        // Methods
        public SecT131R2Curve()
        {
            var val_8;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(curve:  this, x:  0, y:  0, withCompression:  false);
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "03E5A88919D7CAFCBF415F07C2176573B2"));
            mem[1152921544345678104] = this;
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04B8266A46C55657AC734CE38F018F2192"));
            mem[1152921544345678112] = this;
            mem[1152921544345678120] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0400000000000000016954A233049BA98F"));
            val_8 = null;
            val_8 = null;
            mem[1152921544345678136] = 6;
            mem[1152921544345678128] = Org.BouncyCastle.Math.BigInteger.Two;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 6) ? 1 : 0;
        }
        public override int get_FieldSize()
        {
            return 131;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override bool get_IsKoblitz()
        {
            return false;
        }
        public virtual int get_M()
        {
            return 131;
        }
        public virtual bool get_IsTrinomial()
        {
            return false;
        }
        public virtual int get_K1()
        {
            return 2;
        }
        public virtual int get_K2()
        {
            return 3;
        }
        public virtual int get_K3()
        {
            return 8;
        }
    
    }

}
