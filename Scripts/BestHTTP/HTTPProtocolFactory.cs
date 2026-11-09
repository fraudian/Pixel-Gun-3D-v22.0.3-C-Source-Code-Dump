using UnityEngine;

namespace BestHTTP
{
    internal static class HTTPProtocolFactory
    {
        // Methods
        public static BestHTTP.HTTPResponse Get(BestHTTP.SupportedProtocols protocol, BestHTTP.HTTPRequest request, System.IO.Stream stream, bool isStreamed, bool isFromCache)
        {
            var val_4;
            if(protocol == 3)
            {
                goto label_1;
            }
            
            if(protocol != 2)
            {
                goto label_2;
            }
            
            BestHTTP.WebSocket.WebSocketResponse val_1 = null;
            isStreamed = isStreamed;
            isFromCache = isFromCache;
            val_4 = val_1;
            val_1 = new BestHTTP.WebSocket.WebSocketResponse(request:  request, stream:  stream, isStreamed:  isStreamed, isFromCache:  isFromCache);
            return (BestHTTP.HTTPResponse)val_4;
            label_1:
            BestHTTP.ServerSentEvents.EventSourceResponse val_2 = null;
            isStreamed = isStreamed;
            isFromCache = isFromCache;
            val_4 = val_2;
            val_2 = new BestHTTP.ServerSentEvents.EventSourceResponse(request:  request, stream:  stream, isStreamed:  isStreamed, isFromCache:  isFromCache);
            return (BestHTTP.HTTPResponse)val_4;
            label_2:
            BestHTTP.HTTPResponse val_3 = null;
            isStreamed = isStreamed;
            isFromCache = isFromCache;
            val_4 = val_3;
            val_3 = new BestHTTP.HTTPResponse(request:  request, stream:  stream, isStreamed:  isStreamed, isFromCache:  isFromCache);
            return (BestHTTP.HTTPResponse)val_4;
        }
        public static BestHTTP.SupportedProtocols GetProtocolFromUri(System.Uri uri)
        {
            var val_9;
            if(((System.Uri.op_Equality(uri1:  uri, uri2:  0)) != true) && (uri.Scheme != null))
            {
                    string val_4 = uri.Scheme.ToLowerInvariant();
                if((System.String.op_Equality(a:  val_4, b:  "ws")) == false)
            {
                    return (BestHTTP.SupportedProtocols)((System.String.op_Equality(a:  val_4, b:  "wss")) != true) ? (1 + 1) : 1;
            }
            
                val_9 = 2;
                return (BestHTTP.SupportedProtocols)((System.String.op_Equality(a:  val_4, b:  "wss")) != true) ? (1 + 1) : 1;
            }
            
            System.Exception val_8 = new System.Exception(message:  "Malformed URI in GetProtocolFromUri");
        }
        public static bool IsSecureProtocol(System.Uri uri)
        {
            if((System.Uri.op_Equality(uri1:  uri, uri2:  0)) != true)
            {
                    if(uri.Scheme != null)
            {
                    string val_4 = uri.Scheme.ToLowerInvariant();
                if((System.String.op_Equality(a:  val_4, b:  "https")) == false)
            {
                    return System.String.op_Equality(a:  val_4, b:  "wss");
            }
            
                return true;
            }
            
            }
            
            System.Exception val_6 = new System.Exception(message:  "Malformed URI in IsSecureProtocol");
        }
    
    }

}
