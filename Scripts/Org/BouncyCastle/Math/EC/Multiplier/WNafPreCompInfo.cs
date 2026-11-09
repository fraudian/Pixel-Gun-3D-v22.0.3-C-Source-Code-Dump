using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class WNafPreCompInfo : PreCompInfo
    {
        // Fields
        protected Org.BouncyCastle.Math.EC.ECPoint[] m_preComp;
        protected Org.BouncyCastle.Math.EC.ECPoint[] m_preCompNeg;
        protected Org.BouncyCastle.Math.EC.ECPoint m_twice;
        
        // Properties
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] PreComp { get; set; }
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] PreCompNeg { get; set; }
        public virtual Org.BouncyCastle.Math.EC.ECPoint Twice { get; set; }
        
        // Methods
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] get_PreComp()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint[])this.m_preComp;
        }
        public virtual void set_PreComp(Org.BouncyCastle.Math.EC.ECPoint[] value)
        {
            this.m_preComp = value;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] get_PreCompNeg()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint[])this.m_preCompNeg;
        }
        public virtual void set_PreCompNeg(Org.BouncyCastle.Math.EC.ECPoint[] value)
        {
            this.m_preCompNeg = value;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint get_Twice()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint)this.m_twice;
        }
        public virtual void set_Twice(Org.BouncyCastle.Math.EC.ECPoint value)
        {
            this.m_twice = value;
        }
        public WNafPreCompInfo()
        {
        
        }
    
    }

}
