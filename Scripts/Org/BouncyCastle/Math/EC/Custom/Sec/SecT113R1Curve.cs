using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
    internal class SecT113R1Curve : AbstractF2mCurve
    {
        // Fields
        private const int SecT113R1_DEFAULT_COORDS = 6;
        protected readonly Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point m_infinity;
        
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
        public SecT113R1Curve()
        {
            var val_8;
            this.m_infinity = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve:  this, x:  0, y:  0, withCompression:  false);
            Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "003088250CA6E7C7FE649CE85820F7"));
            mem[1152921544321362760] = this;
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "00E8BEE4D3E2260744188BE0E9C723"));
            mem[1152921544321362768] = this;
            mem[1152921544321362776] = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0100000000000000D9CCEC8A39E56F"));
            val_8 = null;
            val_8 = null;
            mem[1152921544321362792] = 6;
            mem[1152921544321362784] = Org.BouncyCastle.Math.BigInteger.Two;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve();
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
            return 113;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override bool get_IsKoblitz()
        {
            return false;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, Org.BouncyCastle.Math.BigInteger X1)
        {
            var val_10;
            var val_11;
            var val_12;
            this.SetPreCompInfo(point:  public System.Void Org.BouncyCastle.Math.EC.ECCurve::SetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo), name:  typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve).__il2cppRuntimeField_180, preCompInfo:  null);
            if((this & 1) == 0)
            {
                goto label_2;
            }
            
            val_10 = this.B;
            val_11 = val_10;
            goto label_4;
            label_2:
            Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.A;
            val_12 = this.SolveQuadraticEquation(beta:  this.CreatePoint(x:  this.B, y:  public Org.BouncyCastle.Math.EC.ECPoint Org.BouncyCastle.Math.EC.ECCurve::CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y)));
            if(val_12 == null)
            {
                goto label_14;
            }
            
            var val_6 = (yTilde == 1) ? 1 : 0;
            val_6 = val_6 ^ val_12;
            if((val_6 & 1) != 0)
            {
                    val_12 = val_12;
            }
            
            val_10 = this.CoordinateSystem - 5;
            if(val_10 <= 1)
            {
                
            }
            
            val_11 = val_12;
            label_4:
            if(val_11 == null)
            {
                goto label_14;
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve).__il2cppRuntimeField_1F8;
            label_14:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Invalid point compression");
        }
        private Org.BouncyCastle.Math.EC.ECFieldElement SolveQuadraticEquation(Org.BouncyCastle.Math.EC.ECFieldElement beta)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_8;
            var val_9;
            if((beta & 1) != 0)
            {
                    val_5 = beta;
                return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = this;
            label_16:
            Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  113, random:  new System.Random());
            val_8 = 1;
            val_9 = beta;
            val_5 = val_4;
            goto label_6;
            label_11:
            val_5 = this.Configure();
            val_9 = val_9;
            val_8 = 2;
            label_6:
            if(val_8 < 113)
            {
                goto label_11;
            }
            
            if((val_9 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_5 & 1) != 0)
            {
                goto label_16;
            }
            
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            label_12:
            val_5 = 0;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
        }
        public virtual int get_M()
        {
            return 113;
        }
        public virtual bool get_IsTrinomial()
        {
            return true;
        }
        public virtual int get_K1()
        {
            return 9;
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
