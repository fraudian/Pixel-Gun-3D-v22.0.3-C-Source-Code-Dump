using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class F2mCurve : AbstractF2mCurve
    {
        // Fields
        private const int F2M_DEFAULT_COORDS = 6;
        private readonly int m;
        private readonly int k1;
        private readonly int k2;
        private readonly int k3;
        protected readonly Org.BouncyCastle.Math.EC.F2mPoint m_infinity;
        
        // Properties
        public override int FieldSize { get; }
        public override Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }
        public int M { get; }
        public int K1 { get; }
        public int K2 { get; }
        public int K3 { get; }
        public Org.BouncyCastle.Math.BigInteger N { get; }
        public Org.BouncyCastle.Math.BigInteger H { get; }
        
        // Methods
        public F2mCurve(int m, int k, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b)
        {
        
        }
        public F2mCurve(int m, int k, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b, Org.BouncyCastle.Math.BigInteger order, Org.BouncyCastle.Math.BigInteger cofactor)
        {
        
        }
        public F2mCurve(int m, int k1, int k2, int k3, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b)
        {
        
        }
        public F2mCurve(int m, int k1, int k2, int k3, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b, Org.BouncyCastle.Math.BigInteger order, Org.BouncyCastle.Math.BigInteger cofactor)
        {
            string val_4;
            this.m = m;
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
            mem[1152921544065372776] = order;
            mem[1152921544065372784] = cofactor;
            this.m_infinity = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  this, x:  0, y:  0, withCompression:  false);
            if(k1 == 0)
            {
                goto label_1;
            }
            
            if(k2 == 0)
            {
                goto label_2;
            }
            
            if(k2 <= k1)
            {
                goto label_3;
            }
            
            if(k3 > k2)
            {
                goto label_4;
            }
            
            val_4 = "k3 must be > k2";
            goto label_8;
            label_2:
            if(k3 != 0)
            {
                goto label_6;
            }
            
            label_4:
            mem[1152921544065372760] = this;
            mem[1152921544065372768] = this;
            mem[1152921544065372792] = 6;
            return;
            label_1:
            val_4 = "k1 must be > 0";
            goto label_8;
            label_3:
            val_4 = "k2 must be > k1";
            goto label_8;
            label_6:
            val_4 = "k3 must be 0 if k2 == 0";
            label_8:
            null = new System.ArgumentException(message:  val_4);
        }
        protected F2mCurve(int m, int k1, int k2, int k3, Org.BouncyCastle.Math.EC.ECFieldElement a, Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.BigInteger order, Org.BouncyCastle.Math.BigInteger cofactor)
        {
            this.m = m;
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
            mem[1152921544065542120] = order;
            mem[1152921544065542128] = cofactor;
            this.m_infinity = new Org.BouncyCastle.Math.EC.F2mPoint(curve:  this, x:  0, y:  0, withCompression:  false);
            mem[1152921544065542104] = a;
            mem[1152921544065542112] = b;
            mem[1152921544065542136] = 6;
        }
        protected override Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)new Org.BouncyCastle.Math.EC.F2mCurve(m:  this.m, k1:  this.k1, k2:  this.k2, k3:  this.k3, a:  X24, b:  X25, order:  X26, cofactor:  ???);
        }
        public override bool SupportsCoordinateSystem(int coord)
        {
            if(coord < 2)
            {
                    return true;
            }
            
            return (bool)(coord == 6) ? 1 : 0;
        }
        protected override Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
        {
            if(this.IsKoblitz == false)
            {
                    return this.CreateDefaultMultiplier();
            }
            
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
        }
        public override int get_FieldSize()
        {
            return (int)this.m;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, k1:  this.k1, k2:  this.k2, k3:  this.k3, x:  x);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.F2mPoint(curve:  this, x:  x, y:  y, withCompression:  withCompression);
        }
        protected internal override Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y, Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)new Org.BouncyCastle.Math.EC.F2mPoint(curve:  this, x:  x, y:  y, zs:  zs, withCompression:  withCompression);
        }
        public override Org.BouncyCastle.Math.EC.ECPoint get_Infinity()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_infinity;
        }
        public int get_M()
        {
            return (int)this.m;
        }
        public bool IsTrinomial()
        {
            if(this.k2 == 0)
            {
                    return (bool)(this.k3 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public int get_K1()
        {
            return (int)this.k1;
        }
        public int get_K2()
        {
            return (int)this.k2;
        }
        public int get_K3()
        {
            return (int)this.k3;
        }
        public Org.BouncyCastle.Math.BigInteger get_N()
        {
            return (Org.BouncyCastle.Math.BigInteger)this;
        }
        public Org.BouncyCastle.Math.BigInteger get_H()
        {
            return (Org.BouncyCastle.Math.BigInteger)this;
        }
    
    }

}
