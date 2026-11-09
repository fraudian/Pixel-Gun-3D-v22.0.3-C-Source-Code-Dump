using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT571R1Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT571R1_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point m_infinity;
        internal static readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B;
        internal static readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B_SQRT;
        
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
        public SecT571R1Curve()
        {
            var val_4;
            var val_5;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_4 = null;
            val_4 = null;
            mem[1152921544485170856] = this;
            val_5 = null;
            val_5 = null;
            mem[1152921544485170864] = Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B;
            mem[1152921544485170872] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "03FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE661CE18FF55987308059B186823851EC7DD9CA1161DE93D5174D66E8382E9BB2FE84E47"));
            mem[1152921544485170888] = 6;
            mem[1152921544485170880] = Org.BouncyCastle.Math.BigInteger.Two;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 6) ? 1 : 0;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            return 571;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            Org.BouncyCastle.Math.EC.AbstractF2mPoint val_2 = 67480;
            val_2 = new Org.BouncyCastle.Math.EC.AbstractF2mPoint(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
            return (Org.BouncyCastle.Math.EC.ECPoint)val_2;
        }
        public override bool get_IsKoblitz()
        {
            return false;
        }
        public virtual int get_M()
        {
            return 571;
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
            return 5;
        }
        public virtual int get_K3()
        {
            return 10;
        }
        private static SecT571R1Curve()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement val_6;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "02F40E7E2221F295DE297117B7F3D62F5C6A97FFCB8CEFF1CD6BA8CE4A9A18AD84FFABBD8EFA59332BE7AD6756A66E294AFD185A78FF12AA520E4DE739BACA0C7FFEFF7F2955727A")));
            val_6 = Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B;
            if(val_6 != null)
            {
                    val_6 = 0;
            }
            
            Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT = val_6;
        }
    
    }

}
