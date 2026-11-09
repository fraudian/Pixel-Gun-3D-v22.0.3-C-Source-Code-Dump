using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class ScaleXPointMap : ECPointMap
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.EC.ECFieldElement scale;
        
        // Methods
        public ScaleXPointMap(Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            this.scale = scale;
        }
        public virtual Org.BouncyCastle.Math.EC.ECPoint Map(Org.BouncyCastle.Math.EC.ECPoint p)
        {
            if(p == null)
            {
                
            }
        
        }
    
    }

}
