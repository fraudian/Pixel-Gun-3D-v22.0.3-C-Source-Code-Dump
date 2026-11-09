using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class FixedPointPreCompInfo : PreCompInfo
    {
        // Fields
        protected Org.BouncyCastle.Math.EC.ECPoint[] m_preComp;
        protected int m_width;
        
        // Properties
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] PreComp { get; set; }
        public virtual int Width { get; set; }
        
        // Methods
        public virtual Org.BouncyCastle.Math.EC.ECPoint[] get_PreComp()
        {
            return (Org.BouncyCastle.Math.EC.ECPoint[])this.m_preComp;
        }
        public virtual void set_PreComp(Org.BouncyCastle.Math.EC.ECPoint[] value)
        {
            this.m_preComp = value;
        }
        public virtual int get_Width()
        {
            return (int)this.m_width;
        }
        public virtual void set_Width(int value)
        {
            this.m_width = value;
        }
        public FixedPointPreCompInfo()
        {
            this.m_width = 0;
        }
    
    }

}
