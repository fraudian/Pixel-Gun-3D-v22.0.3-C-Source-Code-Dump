using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT163K1Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT163K1_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point m_infinity;
        
        // Properties
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        public override bool IsKoblitz { get; }
        public virtual int M { get; }
        public virtual bool IsTrinomial { get; }
        public virtual int K1 { get; }
        public virtual int K2 { get; }
        public virtual int K3 { get; }
        
        // Methods
        public SecT163K1Curve()
        {
            var val_4;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_4 = null;
            val_4 = null;
            mem[1152921544361300648] = this;
            mem[1152921544361300656] = this;
            mem[1152921544361300664] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04000000000000000000020108A2E0CC0D99F8A5EF"));
            mem[1152921544361300680] = 6;
            mem[1152921544361300672] = Org.BouncyCastle.Math.BigInteger.Two;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 6) ? 1 : 0;
        }
        protected override Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
        {
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            return 163;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override bool get_IsKoblitz()
        {
            return true;
        }
        public virtual int get_M()
        {
            return 163;
        }
        public virtual bool get_IsTrinomial()
        {
            return false;
        }
        public virtual int get_K1()
        {
            return 3;
        }
        public virtual int get_K2()
        {
            return 6;
        }
        public virtual int get_K3()
        {
            return 7;
        }
    
    }

}
