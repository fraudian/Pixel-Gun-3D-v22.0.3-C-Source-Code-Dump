using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT193R2Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT193R2_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point m_infinity;
        
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
        public SecT193R2Curve()
        {
            var val_8;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(curve:  this, x:  0, y:  0, withCompression:  false);
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0163F35A5137C2CE3EA6ED8667190B0BC43ECD69977702709B"));
            mem[1152921544389482904] = this;
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "00C9BB9E8927D4D64C377E2AB2856A5B16E3EFB7F61D4316AE"));
            mem[1152921544389482912] = this;
            mem[1152921544389482920] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "010000000000000000000000015AAB561B005413CCD4EE99D5"));
            val_8 = null;
            val_8 = null;
            mem[1152921544389482936] = 6;
            mem[1152921544389482928] = Org.BouncyCastle.Math.BigInteger.Two;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve();
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
            return 193;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override bool get_IsKoblitz()
        {
            return false;
        }
        public virtual int get_M()
        {
            return 193;
        }
        public virtual bool get_IsTrinomial()
        {
            return true;
        }
        public virtual int get_K1()
        {
            return 15;
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
