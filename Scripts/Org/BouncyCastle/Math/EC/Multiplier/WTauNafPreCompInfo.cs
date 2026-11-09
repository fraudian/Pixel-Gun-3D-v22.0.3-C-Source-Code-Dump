using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public class WTauNafPreCompInfo : PreCompInfo
    {
        // Fields
        protected Org.BouncyCastle.Math.EC.AbstractF2mPoint[] m_preComp;
        
        // Properties
        public virtual Org.BouncyCastle.Math.EC.AbstractF2mPoint[] PreComp { get; set; }
        
        // Methods
        public virtual Org.BouncyCastle.Math.EC.AbstractF2mPoint[] get_PreComp()
        {
            return (Org.BouncyCastle.Math.EC.AbstractF2mPoint[])this.m_preComp;
        }
        public virtual void set_PreComp(Org.BouncyCastle.Math.EC.AbstractF2mPoint[] value)
        {
            this.m_preComp = value;
        }
        public WTauNafPreCompInfo()
        {
        
        }
    
    }

}
