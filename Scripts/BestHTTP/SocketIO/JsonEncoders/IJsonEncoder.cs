using UnityEngine;

namespace BestHTTP.SocketIO.JsonEncoders
{
    public interface IJsonEncoder
    {
        // Methods
        public abstract System.Collections.Generic.List<object> Decode(string json); // 0
        public abstract string Encode(System.Collections.Generic.List<object> obj); // 0
        public abstract string EncodeNoSquareBraces(System.Collections.Generic.List<object> obj); // 0
    
    }

}
