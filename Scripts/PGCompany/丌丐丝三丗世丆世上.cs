using UnityEngine;

namespace PGCompany
{
    internal sealed class 丌丐丝三丗世丆世上
    {
        // Fields
        private float 七三丗丙丏丘丘丅上;
        private float 丅上丌世不丈丟丏专;
        private bool 丟三专丂丝七丕丅丂;
        private bool 不不丆三丝丗丂一丐;
        private bool 丗不上下三丒七丄丆;
        private const string 丘丅且且丑丒丈丕专 = "https://google.com";
        private System.Uri 一丞与上丏与丏丈与;
        
        // Properties
        internal float 丁丁东丘丄与丛且丈 { get; }
        internal bool 丗丐丆世丟不丄不与 { get; }
        internal bool 丙下专东丁不上丘丐 { get; }
        internal string 丌丆三万七且东三万 { get; }
        
        // Methods
        internal float 丄东丌丐丏专丒丛丘()
        {
            return (float)this.七三丗丙丏丘丘丅上;
        }
        internal bool 七上丕且丝万一不丂()
        {
            return (bool)this.丟三专丂丝七丕丅丂;
        }
        internal bool 丛丗丏丑七丁东丒与()
        {
            return (bool)this.不不丆三丝丗丂一丐;
        }
        internal string 七丆丘丘下丝丞丒丁()
        {
            return "https://google.com";
        }
        internal void 且丅丟丂三丆丏七丛()
        {
            var val_4;
            if(this.丗不上下三丒七丄丆 != false)
            {
                    return;
            }
            
            this.丘丈丅丏丗丂丂丂与();
            BestHTTP.HTTPRequest val_2 = new BestHTTP.HTTPRequest(uri:  this.一丞与上丏与丏丈与, methodType:  1, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void PGCompany.丌丐丝三丗世丆世上::不三丑丞不三下丙与(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟, BestHTTP.HTTPResponse 丑与丂丌世丕丆一丗)));
            val_4 = null;
            val_4 = null;
            if(val_2 != null)
            {
                    val_2.ConnectTimeout = new System.TimeSpan() {_ticks = System.TimeSpan.Zero};
                val_2.IsKeepAlive = false;
                val_2.DisableRetry = true;
                val_2.DisableCache = true;
            }
            else
            {
                    val_2.ConnectTimeout = new System.TimeSpan() {_ticks = System.TimeSpan.Zero};
                val_2.IsKeepAlive = false;
                val_2.DisableRetry = true;
                val_2.DisableCache = true;
            }
            
            BestHTTP.HTTPRequest val_3 = val_2.Send();
        }
        private void 不三丑丞不三下丙与(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟, BestHTTP.HTTPResponse 丑与丂丌世丕丆一丗)
        {
            float val_1 = UnityEngine.Time.unscaledTime;
            this.丟三专丂丝七丕丅丂 = true;
            val_1 = val_1 - this.丅上丌世不丈丟丏专;
            this.丗不上下三丒七丄丆 = false;
            this.七三丗丙丏丘丘丅上 = val_1;
            this.不不丆三丝丗丂一丐 = (丑与丂丌世丕丆一丗 != 0) ? 1 : 0;
            if(丑与丂丌世丕丆一丗 == null)
            {
                goto label_0;
            }
            
            丑与丂丌世丕丆一丗.Dispose();
            if(东丞丒丙世丏三下丟 == null)
            {
                    return;
            }
            
            label_2:
            东丞丒丙世丏三下丟.Dispose();
            return;
            label_0:
            this.七三丗丙丏丘丘丅上 = -1f;
            if(东丞丒丙世丏三下丟 != null)
            {
                goto label_2;
            }
        
        }
        private void 丘丈丅丏丗丂丂丂与()
        {
            this.七三丗丙丏丘丘丅上 = -1f;
            this.丅上丌世不丈丟丏专 = UnityEngine.Time.unscaledTime;
            this.丟三专丂丝七丕丅丂 = false;
            this.不不丆三丝丗丂一丐 = false;
            this.丗不上下三丒七丄丆 = true;
            if((System.Uri.op_Equality(uri1:  this.一丞与上丏与丏丈与, uri2:  0)) == false)
            {
                    return;
            }
            
            this.一丞与上丏与丏丈与 = new System.Uri(uriString:  "https://google.com");
        }
        public 丌丐丝三丗世丆世上()
        {
        
        }
    
    }

}
