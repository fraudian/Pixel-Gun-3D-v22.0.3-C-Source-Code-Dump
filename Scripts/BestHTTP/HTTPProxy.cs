using UnityEngine;

namespace BestHTTP
{
    public sealed class HTTPProxy
    {
        // Fields
        private System.Uri <Address>k__BackingField;
        private BestHTTP.Authentication.Credentials <Credentials>k__BackingField;
        private bool <IsTransparent>k__BackingField;
        private bool <SendWholeUri>k__BackingField;
        private bool <NonTransparentForHTTPS>k__BackingField;
        
        // Properties
        public System.Uri Address { get; set; }
        public BestHTTP.Authentication.Credentials Credentials { get; set; }
        public bool IsTransparent { get; set; }
        public bool SendWholeUri { get; set; }
        public bool NonTransparentForHTTPS { get; set; }
        
        // Methods
        public System.Uri get_Address()
        {
            return (System.Uri)this.<Address>k__BackingField;
        }
        public void set_Address(System.Uri value)
        {
            this.<Address>k__BackingField = value;
        }
        public BestHTTP.Authentication.Credentials get_Credentials()
        {
            return (BestHTTP.Authentication.Credentials)this.<Credentials>k__BackingField;
        }
        public void set_Credentials(BestHTTP.Authentication.Credentials value)
        {
            this.<Credentials>k__BackingField = value;
        }
        public bool get_IsTransparent()
        {
            return (bool)this.<IsTransparent>k__BackingField;
        }
        public void set_IsTransparent(bool value)
        {
            this.<IsTransparent>k__BackingField = value;
        }
        public bool get_SendWholeUri()
        {
            return (bool)this.<SendWholeUri>k__BackingField;
        }
        public void set_SendWholeUri(bool value)
        {
            this.<SendWholeUri>k__BackingField = value;
        }
        public bool get_NonTransparentForHTTPS()
        {
            return (bool)this.<NonTransparentForHTTPS>k__BackingField;
        }
        public void set_NonTransparentForHTTPS(bool value)
        {
            this.<NonTransparentForHTTPS>k__BackingField = value;
        }
        public HTTPProxy(System.Uri address)
        {
            this.<Address>k__BackingField = address;
            this.<Credentials>k__BackingField = 0;
            this.<IsTransparent>k__BackingField = true;
            this.<SendWholeUri>k__BackingField = true;
            this.<NonTransparentForHTTPS>k__BackingField = true;
        }
        public HTTPProxy(System.Uri address, BestHTTP.Authentication.Credentials credentials)
        {
            val_1 = new System.Object();
            this.<Address>k__BackingField = address;
            this.<Credentials>k__BackingField = val_1;
            this.<IsTransparent>k__BackingField = true;
            this.<SendWholeUri>k__BackingField = true;
            this.<NonTransparentForHTTPS>k__BackingField = true;
        }
        public HTTPProxy(System.Uri address, BestHTTP.Authentication.Credentials credentials, bool isTransparent)
        {
            val_1 = new System.Object();
            this.<Address>k__BackingField = address;
            this.<Credentials>k__BackingField = val_1;
            this.<IsTransparent>k__BackingField = isTransparent;
            this.<SendWholeUri>k__BackingField = true;
            this.<NonTransparentForHTTPS>k__BackingField = true;
        }
        public HTTPProxy(System.Uri address, BestHTTP.Authentication.Credentials credentials, bool isTransparent, bool sendWholeUri)
        {
            val_1 = new System.Object();
            this.<Address>k__BackingField = address;
            this.<Credentials>k__BackingField = val_1;
            this.<IsTransparent>k__BackingField = isTransparent;
            this.<SendWholeUri>k__BackingField = true;
            this.<NonTransparentForHTTPS>k__BackingField = true;
        }
        public HTTPProxy(System.Uri address, BestHTTP.Authentication.Credentials credentials, bool isTransparent, bool sendWholeUri, bool nonTransparentForHTTPS)
        {
            val_1 = new System.Object();
            this.<Address>k__BackingField = address;
            this.<Credentials>k__BackingField = val_1;
            this.<IsTransparent>k__BackingField = isTransparent;
            this.<SendWholeUri>k__BackingField = sendWholeUri;
            this.<NonTransparentForHTTPS>k__BackingField = nonTransparentForHTTPS;
        }
    
    }

}
