using UnityEngine;

namespace BestHTTP.WebSocket.Extensions
{
    public interface IExtension
    {
        // Methods
        public abstract void AddNegotiation(BestHTTP.HTTPRequest request); // 0
        public abstract bool ParseNegotiation(BestHTTP.WebSocket.WebSocketResponse resp); // 0
        public abstract byte GetFrameHeader(BestHTTP.WebSocket.Frames.WebSocketFrame writer, byte inFlag); // 0
        public abstract byte[] Encode(BestHTTP.WebSocket.Frames.WebSocketFrame writer); // 0
        public abstract byte[] Decode(byte header, byte[] data); // 0
    
    }

}
