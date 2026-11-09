using UnityEngine;

namespace BestHTTP.SocketIO
{
    public interface IManager
    {
        // Methods
        public abstract void Remove(BestHTTP.SocketIO.Socket socket); // 0
        public abstract void Close(bool removeSockets = True); // 0
        public abstract void TryToReconnect(); // 0
        public abstract bool OnTransportConnected(BestHTTP.SocketIO.Transports.ITransport transport); // 0
        public abstract void OnTransportError(BestHTTP.SocketIO.Transports.ITransport trans, string err); // 0
        public abstract void OnTransportProbed(BestHTTP.SocketIO.Transports.ITransport trans); // 0
        public abstract void SendPacket(BestHTTP.SocketIO.Packet packet); // 0
        public abstract void OnPacket(BestHTTP.SocketIO.Packet packet); // 0
        public abstract void EmitEvent(string eventName, object[] args); // 0
        public abstract void EmitEvent(BestHTTP.SocketIO.SocketIOEventTypes type, object[] args); // 0
        public abstract void EmitError(BestHTTP.SocketIO.SocketIOErrors errCode, string msg); // 0
        public abstract void EmitAll(string eventName, object[] args); // 0
    
    }

}
