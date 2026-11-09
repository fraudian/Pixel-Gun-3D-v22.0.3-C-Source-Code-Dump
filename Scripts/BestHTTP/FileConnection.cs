using UnityEngine;

namespace BestHTTP
{
    internal sealed class FileConnection : ConnectionBase
    {
        // Methods
        public FileConnection(string serverAddress)
        {
        
        }
        internal override void Abort(BestHTTP.HTTPConnectionStates newState)
        {
            this.State = newState;
            if(this.State == 8)
            {
                    System.DateTime val_2 = System.DateTime.UtcNow;
                this.TimedOutStart = new System.DateTime() {dateData = val_2.dateData};
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        protected override void ThreadFunc(object param)
        {
            var val_29;
            var val_30;
            var val_31;
            var val_33;
            val_29 = this;
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            new System.IO.FileStream() = new System.IO.FileStream(path:  ((val_1.<IsRedirected>k__BackingField) == false) ? val_1.<Uri>k__BackingField : val_1.<RedirectUri>k__BackingField.LocalPath, mode:  3, access:  1);
            System.IO.Stream[] val_5 = new System.IO.Stream[2];
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            val_5[0] = new System.IO.MemoryStream();
            val_5[1] = new System.IO.FileStream();
            new BestHTTP.StreamList() = new BestHTTP.StreamList(streams:  val_5);
            new BestHTTP.StreamList().Write(str:  "HTTP/1.1 200 Ok\r\n");
            new BestHTTP.StreamList().Write(str:  "Content-Type: application/octet-stream\r\n");
            new BestHTTP.StreamList().Write(str:  System.String.Format(format:  "Content-Length: {0}\r\n", arg0:  new System.IO.FileStream()));
            new BestHTTP.StreamList().Write(str:  "\r\n");
            BestHTTP.HTTPRequest val_9 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_11 = this.CurrentRequest;
            new BestHTTP.HTTPResponse() = new BestHTTP.HTTPResponse(request:  this.CurrentRequest, stream:  new BestHTTP.StreamList(), isStreamed:  (val_11.useStreaming == true) ? 1 : 0, isFromCache:  false);
            val_9.<Response>k__BackingField = new BestHTTP.HTTPResponse();
            BestHTTP.HTTPRequest val_14 = this.CurrentRequest;
            if(((val_14.<Response>k__BackingField) & 1) == 0)
            {
                    BestHTTP.HTTPRequest val_15 = this.CurrentRequest;
                val_15.<Response>k__BackingField = 0;
            }
            
            val_30 = 0;
            val_31 = 0;
            var val_29 = 0;
            val_29 = val_29 + 1;
            new BestHTTP.StreamList().Dispose();
            if(val_31 == 1)
            {
                goto label_26;
            }
            
            if(197 != 197)
            {
                goto label_76;
            }
            
            val_31 = 0;
            goto label_29;
            label_26:
            val_31 = 0;
            label_76:
            if(val_30 != 0)
            {
                    val_30 = 0;
            }
            
            label_29:
            val_33 = 0 + 1;
            mem2[0] = 209;
            if(new System.IO.FileStream() != null)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                new System.IO.FileStream().Dispose();
            }
            
            if((val_33 != 1) && ((1152921553608413968 + ((0 + 1)) << 2) == 209))
            {
                    var val_31 = 0;
                val_31 = val_31 ^ (val_33 >> 31);
                val_33 = val_33 + val_31;
            }
            else
            {
                    if(val_30 != 0)
            {
                    val_30 = 0;
            }
            
            }
            
            val_33 = val_33 + 1;
            mem2[0] = 368;
            this.State = 9;
            BestHTTP.HTTPRequest val_18 = this.CurrentRequest;
            if((val_18.<State>k__BackingField) == 2)
            {
                    BestHTTP.HTTPRequest val_19 = this.CurrentRequest;
                BestHTTP.HTTPRequest val_20 = this.CurrentRequest;
                val_29 = val_20;
                val_20.<State>k__BackingField = ((val_19.<Response>k__BackingField) == 0) ? (3 + 1) : 3;
            }
            
            if(val_33 != 1)
            {
                    if(val_30 == 0)
            {
                    return;
            }
            
                if((1152921553608413968 + (((0 + 1) + 1)) << 2) == 368)
            {
                    return;
            }
            
                return;
            }
            
            if(val_30 != 0)
            {
                    return;
            }
        
        }
    
    }

}
