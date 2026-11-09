using UnityEngine;

namespace BestHTTP.SocketIO
{
    public interface ISocket
    {
        // Methods
        public abstract void Open(); // 0
        public abstract void Disconnect(bool remove); // 0
        public abstract void OnPacket(BestHTTP.SocketIO.Packet packet); // 0
        public abstract void EmitEvent(BestHTTP.SocketIO.SocketIOEventTypes type, object[] args); // 0
        public abstract void EmitEvent(string eventName, object[] args); // 0
        public abstract void EmitError(BestHTTP.SocketIO.SocketIOErrors errCode, string msg); // 0
    
    }

}
