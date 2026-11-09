using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224K1Curve : AbstractFpCurve
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger q;
        private const int SECP224K1_DEFAULT_COORDS = 2;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point m_infinity;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Q { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        
        // Methods
        public SecP224K1Curve()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            val_6 = null;
            val_6 = null;
            mem[1152921544209925816] = this;
            Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  5);
            mem[1152921544209925824] = this;
            mem[1152921544209925832] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "010000000000000000000000000001DCE8D2EC6184CAF0A971769FB1F7"));
            mem[1152921544209925848] = 2;
            mem[1152921544209925840] = Org.BouncyCastle.Math.BigInteger.One;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 2) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Q()
        {
            null = null;
            return (Org.BouncyCastle.Math.BigInteger)Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS != 0)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        private static SecP224K1Curve()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_DEFAULT_COORDS = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFE56D"));
        }
    
    }

}
