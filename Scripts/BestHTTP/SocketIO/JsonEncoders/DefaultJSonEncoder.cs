using UnityEngine;

namespace BestHTTP.SocketIO.JsonEncoders
{
    public sealed class DefaultJSonEncoder : IJsonEncoder
    {
        // Methods
        public System.Collections.Generic.List<object> Decode(string json)
        {
            var val_4;
            if((BestHTTP.JSON.Json.Decode(json:  json, success: ref  true)) == null)
            {
                    return (System.Collections.Generic.List<System.Object>);
            }
            
            val_4 = 0;
            return (System.Collections.Generic.List<System.Object>);
        }
        public string Encode(System.Collections.Generic.List<object> obj)
        {
            return BestHTTP.JSON.Json.Encode(json:  obj);
        }
        public string EncodeNoSquareBraces(System.Collections.Generic.List<object> obj)
        {
            var val_13;
            var val_14;
            string val_1 = BestHTTP.JSON.Json.Encode(json:  obj);
            if(val_1.Length < 2)
            {
                    return val_1;
            }
            
            if((val_1.Chars[0] & 65535) != '[')
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    val_13 = val_1.Length;
            }
            else
            {
                    val_13 = 0.Length;
            }
            
            if(((val_1.Chars[val_13 - 1]) & 65535) != ']')
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    val_14 = val_1.Length;
                return val_1.Substring(startIndex:  1, length:  val_14 - 2);
            }
            
            val_14 = 0.Length;
            return val_1.Substring(startIndex:  1, length:  val_14 - 2);
        }
        public DefaultJSonEncoder()
        {
        
        }
    
    }

}
