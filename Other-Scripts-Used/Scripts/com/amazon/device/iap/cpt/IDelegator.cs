using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public interface IDelegator
    {
        // Methods
        public abstract void ExecuteSuccess(); // 0
        public abstract void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objDict); // 0
        public abstract void ExecuteError(com.amazon.device.iap.cpt.AmazonException e); // 0
    
    }

}
