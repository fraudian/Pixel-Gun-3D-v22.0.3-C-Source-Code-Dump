using UnityEngine;

namespace BestHTTP.Extensions
{
    public interface IHeartbeat
    {
        // Methods
        public abstract void OnHeartbeatUpdate(System.TimeSpan dif); // 0
    
    }

}
