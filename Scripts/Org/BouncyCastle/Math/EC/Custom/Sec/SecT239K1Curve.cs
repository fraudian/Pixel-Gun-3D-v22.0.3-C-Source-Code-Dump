using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT239K1Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT239K1_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point m_infinity;
        
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
        public SecT239K1Curve()
        {
            var val_5;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_5 = null;
            val_5 = null;
            mem[1152921544425151560] = this;
            mem[1152921544425151568] = this;
            mem[1152921544425151576] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "2000000000000000000000000000005A79FEC67CB6E91F1C1DA800E478A5"));
            mem[1152921544425151584] = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
            mem[1152921544425151592] = 6;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve();
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
            return 239;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override bool get_IsKoblitz()
        {
            return true;
        }
        public virtual int get_M()
        {
            return 239;
        }
        public virtual bool get_IsTrinomial()
        {
            return true;
        }
        public virtual int get_K1()
        {
            return 158;
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
