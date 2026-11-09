using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Endo
{
    public class GlvTypeBParameters
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.BigInteger m_beta;
        protected readonly Org.BouncyCastle.Math.BigInteger m_lambda;
        protected readonly Org.BouncyCastle.Math.BigInteger[] m_v1;
        protected readonly Org.BouncyCastle.Math.BigInteger[] m_v2;
        protected readonly Org.BouncyCastle.Math.BigInteger m_g1;
        protected readonly Org.BouncyCastle.Math.BigInteger m_g2;
        protected readonly int m_bits;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Beta { get; }
        public virtual Org.BouncyCastle.Math.BigInteger Lambda { get; }
        public virtual Org.BouncyCastle.Math.BigInteger[] V1 { get; }
        public virtual Org.BouncyCastle.Math.BigInteger[] V2 { get; }
        public virtual Org.BouncyCastle.Math.BigInteger G1 { get; }
        public virtual Org.BouncyCastle.Math.BigInteger G2 { get; }
        public virtual int Bits { get; }
        
        // Methods
        public GlvTypeBParameters(Org.BouncyCastle.Math.BigInteger beta, Org.BouncyCastle.Math.BigInteger lambda, Org.BouncyCastle.Math.BigInteger[] v1, Org.BouncyCastle.Math.BigInteger[] v2, Org.BouncyCastle.Math.BigInteger g1, Org.BouncyCastle.Math.BigInteger g2, int bits)
        {
            val_1 = new System.Object();
            this.m_beta = beta;
            this.m_lambda = val_1;
            this.m_v1 = v1;
            this.m_v2 = v2;
            this.m_g1 = g1;
            this.m_g2 = g2;
            this.m_bits = bits;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Beta()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_beta;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Lambda()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_lambda;
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] get_V1()
        {
            return (Org.BouncyCastle.Math.BigInteger[])this.m_v1;
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] get_V2()
        {
            return (Org.BouncyCastle.Math.BigInteger[])this.m_v2;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_G1()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_g1;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_G2()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.m_g2;
        }
        public virtual int get_Bits()
        {
            return (int)this.m_bits;
        }
    
    }

}
