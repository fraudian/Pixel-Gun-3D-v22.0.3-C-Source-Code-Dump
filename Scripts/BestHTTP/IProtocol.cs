using UnityEngine;

namespace BestHTTP
{
    public interface IProtocol
    {
        // Properties
        public abstract bool IsClosed { get; }
        
        // Methods
        public abstract bool get_IsClosed(); // 0
        public abstract void HandleEvents(); // 0
    
    }

}
