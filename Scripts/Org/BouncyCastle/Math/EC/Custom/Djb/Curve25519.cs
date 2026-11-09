using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
    internal class Curve25519 : AbstractFpCurve
    {
        // Fields
        public static readonly Org.BouncyCastle.Math.BigInteger q;
        private const int Curve25519_DEFAULT_COORDS = 4;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point m_infinity;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Q { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        
        // Methods
        public Curve25519()
        {
            null = null;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  this, x:  0, y:  0, withCompression:  false);
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA984914A144"));
            mem[1152921544489017480] = this;
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "7B425ED097B425ED097B425ED097B425ED097B425ED097B4260B5E9C7710C864"));
            mem[1152921544489017488] = this;
            mem[1152921544489017496] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "1000000000000000000000000000000014DEF9DEA2F79CD65812631A5CF5D3ED"));
            mem[1152921544489017504] = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  8);
            mem[1152921544489017512] = 4;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519();
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            return (bool)(coord == 4) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Q()
        {
            null = null;
            return (Org.BouncyCastle.Math.BigInteger)Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            null = null;
            if(Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS != 0)
            {
                    return Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS.BitLength;
            }
            
            return Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        private static Curve25519()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519_DEFAULT_COORDS = Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(x:  Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PInv);
        }
    
    }

}
