using UnityEngine;

namespace BestHTTP.SocketIO.Transports
{
    public interface ITransport
    {
        // Properties
        public abstract BestHTTP.SocketIO.Transports.TransportTypes Type { get; }
        public abstract BestHTTP.SocketIO.Transports.TransportStates State { get; }
        public abstract BestHTTP.SocketIO.SocketManager Manager { get; }
        public abstract bool IsRequestInProgress { get; }
        public abstract bool IsPollingInProgress { get; }
        
        // Methods
        public abstract BestHTTP.SocketIO.Transports.TransportTypes get_Type(); // 0
        public abstract BestHTTP.SocketIO.Transports.TransportStates get_State(); // 0
        public abstract BestHTTP.SocketIO.SocketManager get_Manager(); // 0
        public abstract bool get_IsRequestInProgress(); // 0
        public abstract bool get_IsPollingInProgress(); // 0
        public abstract void Open(); // 0
        public abstract void Poll(); // 0
        public abstract void Send(BestHTTP.SocketIO.Packet packet); // 0
        public abstract void Send(System.Collections.Generic.List<BestHTTP.SocketIO.Packet> packets); // 0
        public abstract void Close(); // 0
    
    }

}
