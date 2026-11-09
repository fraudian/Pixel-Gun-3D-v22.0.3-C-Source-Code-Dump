using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecP224R1Curve : AbstractFpCurve
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger q;
        private const int SecP224R1_DEFAULT_COORDS = 2;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point m_infinity;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Q { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        
        // Methods
        public SecP224R1Curve()
        {
            var val_8;
            var val_9;
            val_8 = null;
            val_8 = null;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFE"));
            mem[1152921544226126504] = this;
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "B4050A850C04B3ABF54132565044B0B7D7BFD8BA270B39432355FFB4"));
            mem[1152921544226126512] = this;
            mem[1152921544226126520] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "FFFFFFFFFFFFFFFFFFFFFFFFFFFF16A2E0B8F03E13DD29455C5C2A3D"));
            val_9 = null;
            val_9 = null;
            mem[1152921544226126536] = 2;
            mem[1152921544226126528] = Org.BouncyCastle.Math.BigInteger.One;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 2) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Q()
        {
            null = null;
            return (Org.BouncyCastle.Math.BigInteger)Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS != 0)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        private static SecP224R1Curve()
        {
            Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1_DEFAULT_COORDS = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF000000000000000000000001"));
        }
    
    }

}
