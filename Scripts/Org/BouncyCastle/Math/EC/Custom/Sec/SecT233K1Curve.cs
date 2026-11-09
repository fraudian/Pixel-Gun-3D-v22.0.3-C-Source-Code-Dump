using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT233K1Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT233K1_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point m_infinity;
        
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
        public SecT233K1Curve()
        {
            var val_5;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_5 = null;
            val_5 = null;
            mem[1152921544405257016] = this;
            mem[1152921544405257024] = this;
            mem[1152921544405257032] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "8000000000000000000000000000069D5BB915BCD46EFB1AD5F173ABDF"));
            mem[1152921544405257040] = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
            mem[1152921544405257048] = 6;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 6) ? 1 : 0;
        }
        protected override Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
        {
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
        }
        public override int get_FieldSize()
        {
            return 233;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override bool get_IsKoblitz()
        {
            return true;
        }
        public virtual int get_M()
        {
            return 233;
        }
        public virtual bool get_IsTrinomial()
        {
            return true;
        }
        public virtual int get_K1()
        {
            return 74;
        }
        public virtual int get_K2()
        {
            return 0;
        }
        public virtual int get_K3()
        {
            return 0;
        }
    
    }

}
