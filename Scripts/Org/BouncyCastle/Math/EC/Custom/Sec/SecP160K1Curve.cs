using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP160K1Curve : AbstractFpCurve
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger q;
        private const int SECP160K1_DEFAULT_COORDS = 2;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point m_infinity;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Q { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        
        // Methods
        public SecP160K1Curve()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_6 = null;
            val_6 = null;
            mem[1152921544138905064] = this;
            Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  7);
            mem[1152921544138905072] = this;
            mem[1152921544138905080] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0100000000000000000001B8FA16DFAB9ACA16B6B3"));
            mem[1152921544138905096] = 2;
            mem[1152921544138905088] = Org.BouncyCastle.Math.BigInteger.One;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 2) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Q()
        {
            null = null;
            return (Org.BouncyCastle.Math.BigInteger)Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_DEFAULT_COORDS;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_DEFAULT_COORDS != 0)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_DEFAULT_COORDS.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_DEFAULT_COORDS.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement val_1 = 66597;
            val_1 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x:  x);
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_1;
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        private static SecP160K1Curve()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_DEFAULT_COORDS = Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.SecP160R2_DEFAULT_COORDS;
        }
    
    }

}
