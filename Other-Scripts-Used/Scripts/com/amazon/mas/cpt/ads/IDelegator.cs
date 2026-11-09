using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public interface IDelegator
    {
        // Methods
        public abstract void ExecuteSuccess(); // 0
        public abstract void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objDict); // 0
        public abstract void ExecuteError(com.amazon.mas.cpt.ads.AmazonException e); // 0
    
    }

}
