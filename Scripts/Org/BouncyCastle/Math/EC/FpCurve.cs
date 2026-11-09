using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class FpCurve : AbstractFpCurve
    {
        // Fields
        private const int FP_DEFAULT_COORDS = 4;
        protected readonly Org.BouncyCastle.Math.BigInteger m_q;
        protected readonly Org.BouncyCastle.Math.BigInteger m_r;
        protected readonly Org.BouncyCastle.Math.EC.FpPoint m_infinity;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Q { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public override int FieldSize { get; }
        
        // Methods
        public FpCurve(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b)
        {
        
        }
        public FpCurve(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b, Org.BouncyCastle.Math.BigInteger order, Org.BouncyCastle.Math.BigInteger cofactor)
        {
            this.m_q = q;
            this.m_r = Org.BouncyCastle.Math.EC.FpFieldElement.CalculateResidue(p:  q);
            this.m_infinity = new Org.BouncyCastle.Math.EC.FpPoint(curve:  this, x:  0, y:  0, withCompression:  false);
            mem[1152921544061605848] = this;
            mem[1152921544061605856] = this;
            mem[1152921544061605864] = order;
            mem[1152921544061605872] = cofactor;
            mem[1152921544061605880] = 4;
        }
        protected FpCurve(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.EC.ECFieldElement a, Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
        
        }
        protected FpCurve(Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.EC.ECFieldElement a, Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.BigInteger order, Org.BouncyCastle.Math.BigInteger cofactor)
        {
            this.m_q = q;
            this.m_r = r;
            this.m_infinity = new Org.BouncyCastle.Math.EC.FpPoint(curve:  this, x:  0, y:  0, withCompression:  false);
            mem[1152921544061919960] = a;
            mem[1152921544061919968] = b;
            mem[1152921544061919976] = order;
            mem[1152921544061919984] = cofactor;
            mem[1152921544061919992] = 4;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.FpCurve(q:  this.m_q, r:  this.m_r, a:  X22, b:  X23, order:  X24, cofactor:  this);
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            if(coord < 3)
            {
                    return true;
            }
            
            return (bool)(coord == 4) ? 1 : 0;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Q()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_q;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public override int get_FieldSize()
        {
            if(this.m_q != null)
            {
                    return this.m_q.BitLength;
            }
            
            return this.m_q.BitLength;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.FpFieldElement(q:  this.m_q, r:  this.m_r, x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.FpPoint(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.FpPoint(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint ImportPoint(Org.BouncyCastle.Math.EC.ECPoint p)
        {
            var val_5;
            if(this == p)
            {
                    return this.ImportPoint(p:  p);
            }
            
            if(this.CoordinateSystem != 2)
            {
                    return this.ImportPoint(p:  p);
            }
            
            if(p.m_x == null)
            {
                    if(p.m_y == null)
            {
                    return this.ImportPoint(p:  p);
            }
            
            }
            
            val_5 = p;
            if((val_5 - 2) > 2)
            {
                    return this.ImportPoint(p:  p);
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_3 = new Org.BouncyCastle.Math.EC.ECFieldElement[1];
            val_3[0] = this;
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.FpPoint(curve:  this, x:  this, y:  this, zs:  val_3, withCompression:  p.m_withCompression);
        }
    
    }

}
