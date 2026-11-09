using UnityEngine;

namespace BestHTTP
{
    public sealed class HTTPRequest : IEnumerator, IEnumerator<BestHTTP.HTTPRequest>, IDisposable
    {
        // Fields
        public static readonly byte[] EOL;
        public static readonly string[] MethodNames;
        public static int UploadChunkSize;
        private System.Uri <Uri>k__BackingField;
        private BestHTTP.HTTPMethods <MethodType>k__BackingField;
        private byte[] <RawData>k__BackingField;
        private System.IO.Stream <UploadStream>k__BackingField;
        private bool <DisposeUploadStream>k__BackingField;
        private bool <UseUploadStreamLength>k__BackingField;
        public BestHTTP.OnUploadProgressDelegate OnUploadProgress;
        private int <MaxFragmentQueueLength>k__BackingField;
        private BestHTTP.OnRequestFinishedDelegate <Callback>k__BackingField;
        public BestHTTP.OnDownloadProgressDelegate OnProgress;
        public BestHTTP.OnRequestFinishedDelegate OnUpgraded;
        private bool <DisableRetry>k__BackingField;
        private bool <IsRedirected>k__BackingField;
        private System.Uri <RedirectUri>k__BackingField;
        private BestHTTP.HTTPResponse <Response>k__BackingField;
        private BestHTTP.HTTPResponse <ProxyResponse>k__BackingField;
        private System.Exception <Exception>k__BackingField;
        private object <Tag>k__BackingField;
        private BestHTTP.Authentication.Credentials <Credentials>k__BackingField;
        private BestHTTP.HTTPProxy <Proxy>k__BackingField;
        private int <MaxRedirects>k__BackingField;
        private bool <UseAlternateSSL>k__BackingField;
        private bool <IsCookiesEnabled>k__BackingField;
        private System.Collections.Generic.List<BestHTTP.Cookies.Cookie> customCookies;
        private BestHTTP.Forms.HTTPFormUsage <FormUsage>k__BackingField;
        private BestHTTP.HTTPRequestStates <State>k__BackingField;
        private int <RedirectCount>k__BackingField;
        private System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> CustomCertificationValidator;
        private System.TimeSpan <ConnectTimeout>k__BackingField;
        private System.TimeSpan <Timeout>k__BackingField;
        private bool <EnableTimoutForStreaming>k__BackingField;
        private bool <EnableSafeReadOnUnknownContentLength>k__BackingField;
        private int <Priority>k__BackingField;
        private Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer <CustomCertificateVerifyer>k__BackingField;
        private Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider <CustomClientCredentialsProvider>k__BackingField;
        private System.Collections.Generic.List<string> <CustomTLSServerNameList>k__BackingField;
        private BestHTTP.SupportedProtocols <ProtocolHandler>k__BackingField;
        private BestHTTP.OnBeforeRedirectionDelegate onBeforeRedirection;
        private BestHTTP.OnBeforeHeaderSendDelegate _onBeforeHeaderSend;
        private bool <TryToMinimizeTCPLatency>k__BackingField;
        private long <Downloaded>k__BackingField;
        private long <DownloadLength>k__BackingField;
        private bool <DownloadProgressChanged>k__BackingField;
        private long <Uploaded>k__BackingField;
        private long <UploadLength>k__BackingField;
        private bool <UploadProgressChanged>k__BackingField;
        private bool isKeepAlive;
        private bool disableCache;
        private bool cacheOnly;
        private int streamFragmentSize;
        private bool useStreaming;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> <Headers>k__BackingField;
        private BestHTTP.Forms.HTTPFormBase FieldCollector;
        private BestHTTP.Forms.HTTPFormBase FormImpl;
        
        // Properties
        public System.Uri Uri { get; set; }
        public BestHTTP.HTTPMethods MethodType { get; set; }
        public byte[] RawData { get; set; }
        public System.IO.Stream UploadStream { get; set; }
        public bool DisposeUploadStream { get; set; }
        public bool UseUploadStreamLength { get; set; }
        public bool IsKeepAlive { get; set; }
        public bool DisableCache { get; set; }
        public bool CacheOnly { get; set; }
        public bool UseStreaming { get; set; }
        public int StreamFragmentSize { get; set; }
        public int MaxFragmentQueueLength { get; set; }
        public BestHTTP.OnRequestFinishedDelegate Callback { get; set; }
        public bool DisableRetry { get; set; }
        public bool IsRedirected { get; set; }
        public System.Uri RedirectUri { get; set; }
        public System.Uri CurrentUri { get; }
        public BestHTTP.HTTPResponse Response { get; set; }
        public BestHTTP.HTTPResponse ProxyResponse { get; set; }
        public System.Exception Exception { get; set; }
        public object Tag { get; set; }
        public BestHTTP.Authentication.Credentials Credentials { get; set; }
        public bool HasProxy { get; }
        public BestHTTP.HTTPProxy Proxy { get; set; }
        public int MaxRedirects { get; set; }
        public bool UseAlternateSSL { get; set; }
        public bool IsCookiesEnabled { get; set; }
        public System.Collections.Generic.List<BestHTTP.Cookies.Cookie> Cookies { get; set; }
        public BestHTTP.Forms.HTTPFormUsage FormUsage { get; set; }
        public BestHTTP.HTTPRequestStates State { get; set; }
        public int RedirectCount { get; set; }
        public System.TimeSpan ConnectTimeout { get; set; }
        public System.TimeSpan Timeout { get; set; }
        public bool EnableTimoutForStreaming { get; set; }
        public bool EnableSafeReadOnUnknownContentLength { get; set; }
        public int Priority { get; set; }
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer CustomCertificateVerifyer { get; set; }
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider CustomClientCredentialsProvider { get; set; }
        public System.Collections.Generic.List<string> CustomTLSServerNameList { get; set; }
        public BestHTTP.SupportedProtocols ProtocolHandler { get; set; }
        public bool TryToMinimizeTCPLatency { get; set; }
        internal long Downloaded { get; set; }
        internal long DownloadLength { get; set; }
        internal bool DownloadProgressChanged { get; set; }
        internal long UploadStreamLength { get; }
        internal long Uploaded { get; set; }
        internal long UploadLength { get; set; }
        internal bool UploadProgressChanged { get; set; }
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Headers { get; set; }
        public object Current { get; }
        private BestHTTP.HTTPRequest System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.Current { get; }
        
        // Methods
        public System.Uri get_Uri()
        {
            return (System.Uri)this.<Uri>k__BackingField;
        }
        private void set_Uri(System.Uri value)
        {
            this.<Uri>k__BackingField = value;
        }
        public BestHTTP.HTTPMethods get_MethodType()
        {
            return (BestHTTP.HTTPMethods)this.<MethodType>k__BackingField;
        }
        public void set_MethodType(BestHTTP.HTTPMethods value)
        {
            this.<MethodType>k__BackingField = value;
        }
        public byte[] get_RawData()
        {
            return (System.Byte[])this.<RawData>k__BackingField;
        }
        public void set_RawData(byte[] value)
        {
            this.<RawData>k__BackingField = value;
        }
        public System.IO.Stream get_UploadStream()
        {
            return (System.IO.Stream)this.<UploadStream>k__BackingField;
        }
        public void set_UploadStream(System.IO.Stream value)
        {
            this.<UploadStream>k__BackingField = value;
        }
        public bool get_DisposeUploadStream()
        {
            return (bool)this.<DisposeUploadStream>k__BackingField;
        }
        public void set_DisposeUploadStream(bool value)
        {
            this.<DisposeUploadStream>k__BackingField = value;
        }
        public bool get_UseUploadStreamLength()
        {
            return (bool)this.<UseUploadStreamLength>k__BackingField;
        }
        public void set_UseUploadStreamLength(bool value)
        {
            this.<UseUploadStreamLength>k__BackingField = value;
        }
        public bool get_IsKeepAlive()
        {
            return (bool)this.isKeepAlive;
        }
        public void set_IsKeepAlive(bool value)
        {
            if((this.<State>k__BackingField) != 2)
            {
                    this.isKeepAlive = value;
                return;
            }
            
            System.NotSupportedException val_2 = new System.NotSupportedException(message:  "Changing the IsKeepAlive property while processing the request is not supported.");
        }
        public bool get_DisableCache()
        {
            return (bool)this.disableCache;
        }
        public void set_DisableCache(bool value)
        {
            if((this.<State>k__BackingField) != 2)
            {
                    this.disableCache = value;
                return;
            }
            
            System.NotSupportedException val_2 = new System.NotSupportedException(message:  "Changing the DisableCache property while processing the request is not supported.");
        }
        public bool get_CacheOnly()
        {
            return (bool)this.cacheOnly;
        }
        public void set_CacheOnly(bool value)
        {
            if((this.<State>k__BackingField) != 2)
            {
                    this.cacheOnly = value;
                return;
            }
            
            System.NotSupportedException val_2 = new System.NotSupportedException(message:  "Changing the CacheOnly property while processing the request is not supported.");
        }
        public bool get_UseStreaming()
        {
            return (bool)this.useStreaming;
        }
        public void set_UseStreaming(bool value)
        {
            if((this.<State>k__BackingField) != 2)
            {
                    this.useStreaming = value;
                return;
            }
            
            System.NotSupportedException val_2 = new System.NotSupportedException(message:  "Changing the UseStreaming property while processing the request is not supported.");
        }
        public int get_StreamFragmentSize()
        {
            return (int)this.streamFragmentSize;
        }
        public void set_StreamFragmentSize(int value)
        {
            var val_3;
            if((this.<State>k__BackingField) == 2)
            {
                goto label_1;
            }
            
            if(value <= 0)
            {
                goto label_2;
            }
            
            this.streamFragmentSize = value;
            return;
            label_1:
            System.NotSupportedException val_1 = null;
            val_3 = val_1;
            val_1 = new System.NotSupportedException(message:  "Changing the StreamFragmentSize property while processing the request is not supported.");
            goto label_3;
            label_2:
            System.ArgumentException val_2 = null;
            val_3 = val_2;
            val_2 = new System.ArgumentException(message:  "StreamFragmentSize must be at least 1.");
            label_3:
        }
        public int get_MaxFragmentQueueLength()
        {
            return (int)this.<MaxFragmentQueueLength>k__BackingField;
        }
        public void set_MaxFragmentQueueLength(int value)
        {
            this.<MaxFragmentQueueLength>k__BackingField = value;
        }
        public BestHTTP.OnRequestFinishedDelegate get_Callback()
        {
            return (BestHTTP.OnRequestFinishedDelegate)this.<Callback>k__BackingField;
        }
        public void set_Callback(BestHTTP.OnRequestFinishedDelegate value)
        {
            this.<Callback>k__BackingField = value;
        }
        public bool get_DisableRetry()
        {
            return (bool)this.<DisableRetry>k__BackingField;
        }
        public void set_DisableRetry(bool value)
        {
            this.<DisableRetry>k__BackingField = value;
        }
        public bool get_IsRedirected()
        {
            return (bool)this.<IsRedirected>k__BackingField;
        }
        internal void set_IsRedirected(bool value)
        {
            this.<IsRedirected>k__BackingField = value;
        }
        public System.Uri get_RedirectUri()
        {
            return (System.Uri)this.<RedirectUri>k__BackingField;
        }
        internal void set_RedirectUri(System.Uri value)
        {
            this.<RedirectUri>k__BackingField = value;
        }
        public System.Uri get_CurrentUri()
        {
            return (System.Uri)((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField;
        }
        public BestHTTP.HTTPResponse get_Response()
        {
            return (BestHTTP.HTTPResponse)this.<Response>k__BackingField;
        }
        internal void set_Response(BestHTTP.HTTPResponse value)
        {
            this.<Response>k__BackingField = value;
        }
        public BestHTTP.HTTPResponse get_ProxyResponse()
        {
            return (BestHTTP.HTTPResponse)this.<ProxyResponse>k__BackingField;
        }
        internal void set_ProxyResponse(BestHTTP.HTTPResponse value)
        {
            this.<ProxyResponse>k__BackingField = value;
        }
        public System.Exception get_Exception()
        {
            return (System.Exception)this.<Exception>k__BackingField;
        }
        internal void set_Exception(System.Exception value)
        {
            this.<Exception>k__BackingField = value;
        }
        public object get_Tag()
        {
            return (object)this.<Tag>k__BackingField;
        }
        public void set_Tag(object value)
        {
            this.<Tag>k__BackingField = value;
        }
        public BestHTTP.Authentication.Credentials get_Credentials()
        {
            return (BestHTTP.Authentication.Credentials)this.<Credentials>k__BackingField;
        }
        public void set_Credentials(BestHTTP.Authentication.Credentials value)
        {
            this.<Credentials>k__BackingField = value;
        }
        public bool get_HasProxy()
        {
            return (bool)((this.<Proxy>k__BackingField) != 0) ? 1 : 0;
        }
        public BestHTTP.HTTPProxy get_Proxy()
        {
            return (BestHTTP.HTTPProxy)this.<Proxy>k__BackingField;
        }
        public void set_Proxy(BestHTTP.HTTPProxy value)
        {
            this.<Proxy>k__BackingField = value;
        }
        public int get_MaxRedirects()
        {
            return (int)this.<MaxRedirects>k__BackingField;
        }
        public void set_MaxRedirects(int value)
        {
            this.<MaxRedirects>k__BackingField = value;
        }
        public bool get_UseAlternateSSL()
        {
            return (bool)this.<UseAlternateSSL>k__BackingField;
        }
        public void set_UseAlternateSSL(bool value)
        {
            this.<UseAlternateSSL>k__BackingField = value;
        }
        public bool get_IsCookiesEnabled()
        {
            return (bool)this.<IsCookiesEnabled>k__BackingField;
        }
        public void set_IsCookiesEnabled(bool value)
        {
            this.<IsCookiesEnabled>k__BackingField = value;
        }
        public System.Collections.Generic.List<BestHTTP.Cookies.Cookie> get_Cookies()
        {
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_2 = this.customCookies;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<BestHTTP.Cookies.Cookie>();
            this.customCookies = val_2;
            return val_2;
        }
        public void set_Cookies(System.Collections.Generic.List<BestHTTP.Cookies.Cookie> value)
        {
            this.customCookies = value;
        }
        public BestHTTP.Forms.HTTPFormUsage get_FormUsage()
        {
            return (BestHTTP.Forms.HTTPFormUsage)this.<FormUsage>k__BackingField;
        }
        public void set_FormUsage(BestHTTP.Forms.HTTPFormUsage value)
        {
            this.<FormUsage>k__BackingField = value;
        }
        public BestHTTP.HTTPRequestStates get_State()
        {
            return (BestHTTP.HTTPRequestStates)this.<State>k__BackingField;
        }
        internal void set_State(BestHTTP.HTTPRequestStates value)
        {
            this.<State>k__BackingField = value;
        }
        public int get_RedirectCount()
        {
            return (int)this.<RedirectCount>k__BackingField;
        }
        internal void set_RedirectCount(int value)
        {
            this.<RedirectCount>k__BackingField = value;
        }
        public void add_CustomCertificationValidator(System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CustomCertificationValidator, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CustomCertificationValidator != 1152921553637272176);
        
        }
        public void remove_CustomCertificationValidator(System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CustomCertificationValidator, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CustomCertificationValidator != 1152921553637408752);
        
        }
        public System.TimeSpan get_ConnectTimeout()
        {
            return (System.TimeSpan)this.<ConnectTimeout>k__BackingField;
        }
        public void set_ConnectTimeout(System.TimeSpan value)
        {
            this.<ConnectTimeout>k__BackingField = value;
        }
        public System.TimeSpan get_Timeout()
        {
            return (System.TimeSpan)this.<Timeout>k__BackingField;
        }
        public void set_Timeout(System.TimeSpan value)
        {
            this.<Timeout>k__BackingField = value;
        }
        public bool get_EnableTimoutForStreaming()
        {
            return (bool)this.<EnableTimoutForStreaming>k__BackingField;
        }
        public void set_EnableTimoutForStreaming(bool value)
        {
            this.<EnableTimoutForStreaming>k__BackingField = value;
        }
        public bool get_EnableSafeReadOnUnknownContentLength()
        {
            return (bool)this.<EnableSafeReadOnUnknownContentLength>k__BackingField;
        }
        public void set_EnableSafeReadOnUnknownContentLength(bool value)
        {
            this.<EnableSafeReadOnUnknownContentLength>k__BackingField = value;
        }
        public int get_Priority()
        {
            return (int)this.<Priority>k__BackingField;
        }
        public void set_Priority(int value)
        {
            this.<Priority>k__BackingField = value;
        }
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer get_CustomCertificateVerifyer()
        {
            return (Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer)this.<CustomCertificateVerifyer>k__BackingField;
        }
        public void set_CustomCertificateVerifyer(Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer value)
        {
            this.<CustomCertificateVerifyer>k__BackingField = value;
        }
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider get_CustomClientCredentialsProvider()
        {
            return (Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider)this.<CustomClientCredentialsProvider>k__BackingField;
        }
        public void set_CustomClientCredentialsProvider(Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider value)
        {
            this.<CustomClientCredentialsProvider>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_CustomTLSServerNameList()
        {
            return (System.Collections.Generic.List<System.String>)this.<CustomTLSServerNameList>k__BackingField;
        }
        public void set_CustomTLSServerNameList(System.Collections.Generic.List<string> value)
        {
            this.<CustomTLSServerNameList>k__BackingField = value;
        }
        public BestHTTP.SupportedProtocols get_ProtocolHandler()
        {
            return (BestHTTP.SupportedProtocols)this.<ProtocolHandler>k__BackingField;
        }
        public void set_ProtocolHandler(BestHTTP.SupportedProtocols value)
        {
            this.<ProtocolHandler>k__BackingField = value;
        }
        public void add_OnBeforeRedirection(BestHTTP.OnBeforeRedirectionDelegate value)
        {
            BestHTTP.OnBeforeRedirectionDelegate val_3;
            if(((System.Delegate.Combine(a:  this.onBeforeRedirection, b:  value)) != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            this.onBeforeRedirection = val_3;
        }
        public void remove_OnBeforeRedirection(BestHTTP.OnBeforeRedirectionDelegate value)
        {
            BestHTTP.OnBeforeRedirectionDelegate val_3;
            if(((System.Delegate.Remove(source:  this.onBeforeRedirection, value:  value)) != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            this.onBeforeRedirection = val_3;
        }
        public void add_OnBeforeHeaderSend(BestHTTP.OnBeforeHeaderSendDelegate value)
        {
            BestHTTP.OnBeforeHeaderSendDelegate val_3;
            if(((System.Delegate.Combine(a:  this._onBeforeHeaderSend, b:  value)) != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            this._onBeforeHeaderSend = val_3;
        }
        public void remove_OnBeforeHeaderSend(BestHTTP.OnBeforeHeaderSendDelegate value)
        {
            BestHTTP.OnBeforeHeaderSendDelegate val_3;
            if(((System.Delegate.Remove(source:  this._onBeforeHeaderSend, value:  value)) != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            this._onBeforeHeaderSend = val_3;
        }
        public bool get_TryToMinimizeTCPLatency()
        {
            return (bool)this.<TryToMinimizeTCPLatency>k__BackingField;
        }
        public void set_TryToMinimizeTCPLatency(bool value)
        {
            this.<TryToMinimizeTCPLatency>k__BackingField = value;
        }
        internal long get_Downloaded()
        {
            return (long)this.<Downloaded>k__BackingField;
        }
        internal void set_Downloaded(long value)
        {
            this.<Downloaded>k__BackingField = value;
        }
        internal long get_DownloadLength()
        {
            return (long)this.<DownloadLength>k__BackingField;
        }
        internal void set_DownloadLength(long value)
        {
            this.<DownloadLength>k__BackingField = value;
        }
        internal bool get_DownloadProgressChanged()
        {
            return (bool)this.<DownloadProgressChanged>k__BackingField;
        }
        internal void set_DownloadProgressChanged(bool value)
        {
            this.<DownloadProgressChanged>k__BackingField = value;
        }
        internal long get_UploadStreamLength()
        {
            var val_1;
            System.IO.Stream val_2;
            val_1 = this;
            val_2 = this.<UploadStream>k__BackingField;
            if((val_2 != null) && ((this.<UseUploadStreamLength>k__BackingField) != false))
            {
                    return (long)val_2;
            }
            
            val_2 = 0;
            return (long)val_2;
        }
        internal long get_Uploaded()
        {
            return (long)this.<Uploaded>k__BackingField;
        }
        internal void set_Uploaded(long value)
        {
            this.<Uploaded>k__BackingField = value;
        }
        internal long get_UploadLength()
        {
            return (long)this.<UploadLength>k__BackingField;
        }
        internal void set_UploadLength(long value)
        {
            this.<UploadLength>k__BackingField = value;
        }
        internal bool get_UploadProgressChanged()
        {
            return (bool)this.<UploadProgressChanged>k__BackingField;
        }
        internal void set_UploadProgressChanged(bool value)
        {
            this.<UploadProgressChanged>k__BackingField = value;
        }
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_Headers()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>)this.<Headers>k__BackingField;
        }
        private void set_Headers(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> value)
        {
            this.<Headers>k__BackingField = value;
        }
        public HTTPRequest(System.Uri uri)
        {
            var val_5 = null;
            bool val_3 = BestHTTP.HTTPManager.IsCachingDisabled;
            bool val_4 = BestHTTP.HTTPManager.KeepAliveDefaultValue;
        }
        public HTTPRequest(System.Uri uri, BestHTTP.OnRequestFinishedDelegate callback)
        {
            var val_5 = null;
            bool val_3 = BestHTTP.HTTPManager.KeepAliveDefaultValue;
            bool val_4 = BestHTTP.HTTPManager.IsCachingDisabled;
        }
        public HTTPRequest(System.Uri uri, bool isKeepAlive, BestHTTP.OnRequestFinishedDelegate callback)
        {
            var val_4 = null;
            bool val_2 = isKeepAlive;
            bool val_3 = BestHTTP.HTTPManager.IsCachingDisabled;
        }
        public HTTPRequest(System.Uri uri, bool isKeepAlive, bool disableCache, BestHTTP.OnRequestFinishedDelegate callback)
        {
            bool val_1 = isKeepAlive;
            bool val_2 = disableCache;
        }
        public HTTPRequest(System.Uri uri, BestHTTP.HTTPMethods methodType)
        {
            var val_7 = null;
            bool val_5 = BestHTTP.HTTPManager.KeepAliveDefaultValue;
            bool val_6 = ((methodType != 255) ? 1 : 0) | BestHTTP.HTTPManager.IsCachingDisabled;
        }
        public HTTPRequest(System.Uri uri, BestHTTP.HTTPMethods methodType, BestHTTP.OnRequestFinishedDelegate callback)
        {
            var val_7 = null;
            bool val_5 = BestHTTP.HTTPManager.KeepAliveDefaultValue;
            bool val_6 = ((methodType != 255) ? 1 : 0) | BestHTTP.HTTPManager.IsCachingDisabled;
        }
        public HTTPRequest(System.Uri uri, BestHTTP.HTTPMethods methodType, bool isKeepAlive, BestHTTP.OnRequestFinishedDelegate callback)
        {
            var val_5 = null;
            isKeepAlive = isKeepAlive;
            bool val_4 = ((methodType != 255) ? 1 : 0) | BestHTTP.HTTPManager.IsCachingDisabled;
        }
        public HTTPRequest(System.Uri uri, BestHTTP.HTTPMethods methodType, bool isKeepAlive, bool disableCache, BestHTTP.OnRequestFinishedDelegate callback)
        {
            var val_14;
            this.<Uri>k__BackingField = uri;
            this.<MethodType>k__BackingField = methodType;
            this.IsKeepAlive = isKeepAlive;
            this.DisableCache = disableCache;
            this.<Callback>k__BackingField = callback;
            this.StreamFragmentSize = 4096;
            this.<MaxFragmentQueueLength>k__BackingField = 10;
            this.<RedirectCount>k__BackingField = 0;
            this.<MaxRedirects>k__BackingField = 2147483647;
            this.<DisableRetry>k__BackingField = (methodType != 255) ? 1 : 0;
            val_14 = null;
            this.<State>k__BackingField = 0;
            this.<DownloadProgressChanged>k__BackingField = false;
            this.<IsCookiesEnabled>k__BackingField = BestHTTP.HTTPManager.IsCookiesEnabled;
            this.<Downloaded>k__BackingField = 0;
            this.<DownloadLength>k__BackingField = 0;
            System.TimeSpan val_6 = BestHTTP.HTTPManager.ConnectTimeout;
            this.<ConnectTimeout>k__BackingField = val_6;
            System.TimeSpan val_7 = BestHTTP.HTTPManager.RequestTimeout;
            this.<Timeout>k__BackingField = val_7;
            this.<EnableTimoutForStreaming>k__BackingField = true;
            this.<EnableSafeReadOnUnknownContentLength>k__BackingField = true;
            this.<Proxy>k__BackingField = BestHTTP.HTTPManager.Proxy;
            this.<DisposeUploadStream>k__BackingField = true;
            this.<UseUploadStreamLength>k__BackingField = true;
            this.<CustomCertificateVerifyer>k__BackingField = BestHTTP.HTTPManager.DefaultCertificateVerifyer;
            this.<CustomClientCredentialsProvider>k__BackingField = BestHTTP.HTTPManager.DefaultClientCredentialsProvider;
            this.<UseAlternateSSL>k__BackingField = BestHTTP.HTTPManager.UseAlternateSSLDefaultValue;
            this.add_CustomCertificationValidator(value:  BestHTTP.HTTPManager.DefaultCertificationValidator);
            this.<TryToMinimizeTCPLatency>k__BackingField = BestHTTP.HTTPManager.TryToMinimizeTCPLatency;
        }
        public void AddField(string fieldName, string value)
        {
            this.AddField(fieldName:  fieldName, value:  value, e:  System.Text.Encoding.UTF8);
        }
        public void AddField(string fieldName, string value, System.Text.Encoding e)
        {
            BestHTTP.Forms.HTTPFormBase val_2 = this.FieldCollector;
            if(val_2 == null)
            {
                    BestHTTP.Forms.HTTPFormBase val_1 = null;
                val_2 = val_1;
                val_1 = new BestHTTP.Forms.HTTPFormBase();
                this.FieldCollector = val_2;
            }
            
            val_1.AddField(fieldName:  fieldName, value:  value, e:  e);
        }
        public void AddBinaryData(string fieldName, byte[] content)
        {
            this.AddBinaryData(fieldName:  fieldName, content:  content, fileName:  0, mimeType:  0);
        }
        public void AddBinaryData(string fieldName, byte[] content, string fileName)
        {
            this.AddBinaryData(fieldName:  fieldName, content:  content, fileName:  fileName, mimeType:  0);
        }
        public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
        {
            BestHTTP.Forms.HTTPFormBase val_2 = this.FieldCollector;
            if(val_2 == null)
            {
                    BestHTTP.Forms.HTTPFormBase val_1 = null;
                val_2 = val_1;
                val_1 = new BestHTTP.Forms.HTTPFormBase();
                this.FieldCollector = val_2;
            }
            
            val_1.AddBinaryData(fieldName:  fieldName, content:  content, fileName:  fileName, mimeType:  mimeType);
        }
        public void SetFields(UnityEngine.WWWForm wwwForm)
        {
            this.<FormUsage>k__BackingField = 4;
            .<Form>k__BackingField = wwwForm;
            this.FormImpl = new BestHTTP.Forms.UnityForm();
        }
        public void SetForm(BestHTTP.Forms.HTTPFormBase form)
        {
            this.FormImpl = form;
        }
        public System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> GetFormFields()
        {
            var val_3;
            if(this.FieldCollector != null)
            {
                    if(this.FieldCollector.IsEmpty == false)
            {
                goto label_2;
            }
            
            }
            
            val_3 = 0;
            return (System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>)val_3;
            label_2:
            System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>(collection:  this.FieldCollector.<Fields>k__BackingField);
            return (System.Collections.Generic.List<BestHTTP.Forms.HTTPFieldData>)val_3;
        }
        public void ClearForm()
        {
            this.FieldCollector = 0;
            this.FormImpl = 0;
        }
        private BestHTTP.Forms.HTTPFormBase SelectFormImplementation()
        {
            BestHTTP.Forms.HTTPFormBase val_3 = this.FormImpl;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            if(this.FieldCollector == null)
            {
                goto label_2;
            }
            
            if((this.<FormUsage>k__BackingField) > 4)
            {
                goto label_10;
            }
            
            var val_3 = 106047428 + (this.<FormUsage>k__BackingField) << 2;
            val_3 = val_3 + 106047428;
            goto (106047428 + (this.<FormUsage>k__BackingField) << 2 + 106047428);
            label_2:
            val_3 = 0;
            return val_3;
            label_10:
        }
        public void AddHeader(string name, string value)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_5;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            val_5 = this;
            val_6 = this.<Headers>k__BackingField;
            if(val_6 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
                this.<Headers>k__BackingField = val_6;
            }
            
            if((val_1.TryGetValue(key:  name, value: out  0)) != true)
            {
                    val_5 = this.<Headers>k__BackingField;
                System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>(capacity:  1);
                val_5.Add(key:  name, value:  val_4);
            }
            
            val_4.Add(item:  value);
        }
        public void SetHeader(string name, string value)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_5;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            val_5 = this;
            val_6 = this.<Headers>k__BackingField;
            if(val_6 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
                this.<Headers>k__BackingField = val_6;
            }
            
            if((val_1.TryGetValue(key:  name, value: out  0)) != true)
            {
                    val_5 = this.<Headers>k__BackingField;
                System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>(capacity:  1);
                val_5.Add(key:  name, value:  val_4);
            }
            
            val_4.Clear();
            val_4.Add(item:  value);
        }
        public bool RemoveHeader(string name)
        {
            if((this.<Headers>k__BackingField) == null)
            {
                    return (bool)this.<Headers>k__BackingField;
            }
            
            return this.<Headers>k__BackingField.Remove(key:  name);
        }
        public bool HasHeader(string name)
        {
            if((this.<Headers>k__BackingField) == null)
            {
                    return (bool)this.<Headers>k__BackingField;
            }
            
            return this.<Headers>k__BackingField.ContainsKey(key:  name);
        }
        public string GetFirstHeaderValue(string name)
        {
            string val_5;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            val_5 = name;
            val_6 = this.<Headers>k__BackingField;
            if(val_6 == null)
            {
                    return (string)val_6;
            }
            
            System.Collections.Generic.List<System.String> val_1 = 0;
            val_6 = 0;
            if((val_6.TryGetValue(key:  val_5, value: out  val_1)) == false)
            {
                    return (string)val_6;
            }
            
            val_5 = val_1;
            if(val_5.Count >= 1)
            {
                    val_5 = val_1;
                string val_4 = val_5.Item[0];
                return (string)val_6;
            }
            
            val_6 = 0;
            return (string)val_6;
        }
        public System.Collections.Generic.List<string> GetHeaderValues(string name)
        {
            string val_5;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            val_5 = name;
            val_6 = this.<Headers>k__BackingField;
            if(val_6 == null)
            {
                    return (System.Collections.Generic.List<System.String>)(val_5.Count < 1) ? 0 : (val_1);
            }
            
            System.Collections.Generic.List<System.String> val_1 = 0;
            val_6 = 0;
            if((val_6.TryGetValue(key:  val_5, value: out  val_1)) == false)
            {
                    return (System.Collections.Generic.List<System.String>)(val_5.Count < 1) ? 0 : (val_1);
            }
            
            val_5 = val_1;
            return (System.Collections.Generic.List<System.String>)(val_5.Count < 1) ? 0 : (val_1);
        }
        public void RemoveHeaders()
        {
            if((this.<Headers>k__BackingField) == null)
            {
                    return;
            }
            
            this.<Headers>k__BackingField.Clear();
        }
        public void SetRangeHeader(int firstBytePos)
        {
            this.SetHeader(name:  "Range", value:  System.String.Format(format:  "bytes={0}-", arg0:  firstBytePos));
        }
        public void SetRangeHeader(int firstBytePos, int lastBytePos)
        {
            this.SetHeader(name:  "Range", value:  System.String.Format(format:  "bytes={0}-{1}", arg0:  firstBytePos, arg1:  lastBytePos));
        }
        public void EnumerateHeaders(BestHTTP.OnHeaderEnumerationDelegate callback)
        {
            this.EnumerateHeaders(callback:  callback, callBeforeSendCallback:  false);
        }
        public void EnumerateHeaders(BestHTTP.OnHeaderEnumerationDelegate callback, bool callBeforeSendCallback)
        {
            var val_51;
            bool val_68;
            BestHTTP.OnHeaderEnumerationDelegate val_69;
            string val_70;
            BestHTTP.HTTPProxy val_71;
            long val_72;
            int val_73;
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_74;
            string val_75;
            string val_76;
            string val_77;
            string val_78;
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_79;
            var val_80;
            var val_81;
            int val_82;
            string val_83;
            string val_84;
            val_68 = callBeforeSendCallback;
            val_69 = callback;
            if((this.HasHeader(name:  "Host")) != true)
            {
                    val_70 = ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField.Authority;
                this.SetHeader(name:  "Host", value:  val_70);
            }
            
            if((this.<IsRedirected>k__BackingField) != false)
            {
                    if((this.HasHeader(name:  "Referer")) != true)
            {
                    val_70 = this.<Uri>k__BackingField;
                this.AddHeader(name:  "Referer", value:  val_70);
            }
            
            }
            
            if((this.HasHeader(name:  "Accept-Encoding")) != true)
            {
                    val_70 = "gzip, identity";
                this.AddHeader(name:  "Accept-Encoding", value:  val_70);
            }
            
            if((this.<Proxy>k__BackingField) != null)
            {
                    if((this.HasHeader(name:  "Proxy-Connection")) != true)
            {
                    val_70 = mem[this.isKeepAlive == true ? "Keep-Alive" : "Close"];
                val_70 = (this.isKeepAlive == true) ? "Keep-Alive" : "Close";
                this.AddHeader(name:  "Proxy-Connection", value:  val_70);
            }
            
            }
            
            if((this.HasHeader(name:  "Connection")) != true)
            {
                    val_70 = mem[this.isKeepAlive == true ? "Keep-Alive, TE" : "Close, TE"];
                val_70 = (this.isKeepAlive == true) ? "Keep-Alive, TE" : "Close, TE";
                this.AddHeader(name:  "Connection", value:  val_70);
            }
            
            if((this.HasHeader(name:  "TE")) != true)
            {
                    val_70 = "identity";
                this.AddHeader(name:  "TE", value:  val_70);
            }
            
            val_71 = "User-Agent";
            if((this.HasHeader(name:  "User-Agent")) != true)
            {
                    val_70 = "BestHTTP";
                this.AddHeader(name:  "User-Agent", value:  val_70);
            }
            
            if((this.<UploadStream>k__BackingField) == null)
            {
                goto label_12;
            }
            
            val_72 = this.UploadStreamLength;
            if(val_72 == 1)
            {
                    this.SetHeader(name:  "Transfer-Encoding", value:  "Chunked");
            }
            
            val_71 = "Content-Type";
            if((this.HasHeader(name:  "Content-Type")) == true)
            {
                goto label_91;
            }
            
            this.SetHeader(name:  "Content-Type", value:  "application/octet-stream");
            if((val_72 & 9223372036854775808) == 0)
            {
                goto label_86;
            }
            
            goto label_87;
            label_12:
            if(this.GetEntityBody() != null)
            {
                    val_73 = val_14.Length;
            }
            else
            {
                    val_73 = 0;
            }
            
            val_72 = 0;
            if((this.<RawData>k__BackingField) == null)
            {
                goto label_19;
            }
            
            label_91:
            if((val_72 & 9223372036854775808) != 0)
            {
                goto label_87;
            }
            
            label_86:
            val_71 = "Content-Length";
            if((this.HasHeader(name:  "Content-Length")) != true)
            {
                    this.SetHeader(name:  "Content-Length", value:  val_72.ToString());
            }
            
            label_87:
            if(((this.<Proxy>k__BackingField) == null) || ((this.<Proxy>k__BackingField.<Credentials>k__BackingField) == null))
            {
                goto label_40;
            }
            
            BestHTTP.Authentication.AuthenticationTypes val_17 = this.<Proxy>k__BackingField.<Credentials>k__BackingField.Type;
            if((val_17 == 0) || (val_17 == 2))
            {
                goto label_25;
            }
            
            if(val_17 != 1)
            {
                goto label_40;
            }
            
            val_71 = this.<Proxy>k__BackingField;
            val_74 = this.<Proxy>k__BackingField.<Credentials>k__BackingField.UserName(this.<Proxy>k__BackingField.<Credentials>k__BackingField.UserName) + ":"(":") + this.<Proxy>k__BackingField.<Credentials>k__BackingField.Password(this.<Proxy>k__BackingField.<Credentials>k__BackingField.Password);
            val_75 = "Proxy-Authorization";
            val_76 = "Basic " + System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8)(System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8));
            goto label_34;
            label_25:
            val_71 = this.<Proxy>k__BackingField;
            BestHTTP.Authentication.Digest val_24 = BestHTTP.Authentication.DigestStore.Get(uri:  this.<Proxy>k__BackingField.<Address>k__BackingField);
            if(val_24 == null)
            {
                goto label_40;
            }
            
            val_71 = this.<Proxy>k__BackingField;
            string val_25 = val_24.GenerateResponseHeader(request:  this, credentials:  this.<Proxy>k__BackingField.<Credentials>k__BackingField, isProxy:  false);
            if((System.String.IsNullOrEmpty(value:  val_25)) == true)
            {
                goto label_40;
            }
            
            val_75 = "Proxy-Authorization";
            val_76 = val_25;
            label_34:
            this.SetHeader(name:  val_75, value:  val_76);
            label_40:
            if((this.<Credentials>k__BackingField) == null)
            {
                goto label_54;
            }
            
            BestHTTP.Authentication.AuthenticationTypes val_27 = this.<Credentials>k__BackingField.Type;
            if((val_27 == 0) || (val_27 == 2))
            {
                goto label_43;
            }
            
            if(val_27 != 1)
            {
                goto label_54;
            }
            
            val_74 = this.<Credentials>k__BackingField.UserName(this.<Credentials>k__BackingField.UserName) + ":"(":") + this.<Credentials>k__BackingField.Password(this.<Credentials>k__BackingField.Password);
            val_77 = "Authorization";
            val_78 = "Basic " + System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8)(System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8));
            goto label_50;
            label_43:
            BestHTTP.Authentication.Digest val_35 = BestHTTP.Authentication.DigestStore.Get(uri:  ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField);
            if(val_35 == null)
            {
                goto label_54;
            }
            
            string val_36 = val_35.GenerateResponseHeader(request:  this, credentials:  this.<Credentials>k__BackingField, isProxy:  false);
            if((System.String.IsNullOrEmpty(value:  val_36)) == true)
            {
                goto label_54;
            }
            
            val_77 = "Authorization";
            val_78 = val_36;
            label_50:
            this.SetHeader(name:  val_77, value:  val_78);
            label_54:
            if((this.<IsCookiesEnabled>k__BackingField) == false)
            {
                goto label_59;
            }
            
            val_79 = BestHTTP.Cookies.CookieJar.Get(uri:  ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField);
            if((val_79 == null) || (val_79.Count == 0))
            {
                goto label_59;
            }
            
            val_74 = this.customCookies;
            if(val_74 == null)
            {
                goto label_68;
            }
            
            val_71 = 1152921553646319120;
            val_80 = 1152921553646320144;
            val_81 = 0;
            goto label_61;
            label_67:
            .customCookie = this.customCookies.Item[0];
            int val_44 = val_79.FindIndex(match:  new System.Predicate<BestHTTP.Cookies.Cookie>(object:  new HTTPRequest.<>c__DisplayClass237_0(), method:  System.Boolean HTTPRequest.<>c__DisplayClass237_0::<EnumerateHeaders>b__0(BestHTTP.Cookies.Cookie c)));
            if((val_44 & 2147483648) == 0)
            {
                    val_79.set_Item(index:  val_44, value:  (HTTPRequest.<>c__DisplayClass237_0)[1152921553646706176].customCookie);
            }
            else
            {
                    val_79.Add(item:  (HTTPRequest.<>c__DisplayClass237_0)[1152921553646706176].customCookie);
            }
            
            val_74 = this.customCookies;
            val_81 = 1;
            label_61:
            if(val_81 < val_74.Count)
            {
                goto label_67;
            }
            
            val_69 = val_69;
            val_68 = val_68;
            if(val_79 != null)
            {
                goto label_68;
            }
            
            goto label_101;
            label_59:
            val_79 = this.customCookies;
            if(val_79 == null)
            {
                goto label_101;
            }
            
            label_68:
            if(val_79.Count < 1)
            {
                goto label_101;
            }
            
            val_82 = System.String.alignConst;
            val_74 = BestHTTP.HTTPProtocolFactory.IsSecureProtocol(uri:  ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField);
            List.Enumerator<T> val_49 = val_79.GetEnumerator();
            val_80 = 1152921553646354960;
            val_71 = 1;
            label_83:
            if((1794937248 & 1) == 0)
            {
                goto label_72;
            }
            
            string val_52 = val_51.丐丏七丌丕丗业且上();
            val_83 = 0;
            if(val_52.IsSecure == false)
            {
                goto label_74;
            }
            
            val_83 = 0;
            if((val_74 & val_52.IsSecure) == false)
            {
                goto label_83;
            }
            
            label_74:
            if((val_71 & 1) == 0)
            {
                goto label_77;
            }
            
            val_84 = val_82;
            if(val_52 != null)
            {
                goto label_80;
            }
            
            goto label_79;
            label_77:
            val_83 = "; ";
            val_84 = val_82 + val_83;
            if(val_52 != null)
            {
                goto label_80;
            }
            
            label_79:
            label_80:
            string val_57 = val_84 + val_52;
            System.DateTime val_58 = System.DateTime.UtcNow;
            val_52.LastAccess = new System.DateTime() {dateData = val_58.dateData};
            goto label_83;
            label_19:
            if(this.FormImpl == null)
            {
                goto label_84;
            }
            
            label_90:
            BestHTTP.Forms.HTTPFormBase val_59 = this.SelectFormImplementation();
            if(this.FormImpl == null)
            {
                goto label_91;
            }
            
            if((val_72 & 9223372036854775808) == 0)
            {
                goto label_86;
            }
            
            goto label_87;
            label_72:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_69 = val_69;
            val_68 = val_68;
            goto label_100;
            label_84:
            if(this.FieldCollector == null)
            {
                goto label_91;
            }
            
            if(this.FieldCollector.IsEmpty == false)
            {
                goto label_90;
            }
            
            goto label_91;
            label_100:
            if((System.String.IsNullOrEmpty(value:  val_72)) != true)
            {
                    this.SetHeader(name:  "Cookie", value:  val_72);
            }
            
            label_101:
            if(( != false) && (this._onBeforeHeaderSend != null))
            {
                    this._onBeforeHeaderSend.Invoke(req:  this);
            }
            
            if( == false)
            {
                    return;
            }
            
            if((this.<Headers>k__BackingField) == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_62 = this.<Headers>k__BackingField.GetEnumerator();
            val_71 = 1152921553646394976;
            val_68 = 1152921553646396000;
            val_74 = 1152921553646398048;
            label_107:
            if((1794937208 & 1) == 0)
            {
                goto label_106;
            }
            
            ConfiguredValueTaskAwaiter val_63 = 0.GetAwaiter();
            Invoke(header:  val_63._value._obj.丐丏七丌丕丗业且上(), values:  val_63._value._obj);
            goto label_107;
            label_106:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void SendHeaders(System.IO.Stream stream)
        {
            HTTPRequest.<>c__DisplayClass238_0 val_1 = new HTTPRequest.<>c__DisplayClass238_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .stream = stream;
            this.EnumerateHeaders(callback:  new BestHTTP.OnHeaderEnumerationDelegate(object:  val_1, method:  System.Void HTTPRequest.<>c__DisplayClass238_0::<SendHeaders>b__0(string header, System.Collections.Generic.List<string> values)), callBeforeSendCallback:  true);
        }
        public string DumpHeaders()
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            this.SendHeaders(stream:  val_1);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 != 1)
            {
                    return (string)BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1);
            }
            
            if(0 == 0)
            {
                    return (string)BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1);
            }
            
            return (string)BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1);
        }
        public byte[] GetEntityBody()
        {
            if((this.<RawData>k__BackingField) != null)
            {
                    return (System.Byte[])this.<RawData>k__BackingField;
            }
            
            if(this.FormImpl == null)
            {
                goto label_1;
            }
            
            label_4:
            BestHTTP.Forms.HTTPFormBase val_1 = this.SelectFormImplementation();
            if(this.FormImpl == null)
            {
                    return (System.Byte[])this.<RawData>k__BackingField;
            }
            
            this = ???;
            goto typeof(BestHTTP.Forms.HTTPFormBase).__il2cppRuntimeField_188;
            label_1:
            if((val_3 + 344) == 0)
            {
                    return (System.Byte[])this.<RawData>k__BackingField;
            }
            
            if((val_3 + 344.IsEmpty) == false)
            {
                goto label_4;
            }
            
            return (System.Byte[])this.<RawData>k__BackingField;
        }
        internal void SendOutTo(System.IO.Stream stream)
        {
            object val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            System.Byte[] val_31;
            System.IO.Stream val_32;
            int val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_39;
            var val_40;
            if(((this.<Proxy>k__BackingField) != null) && ((this.<Proxy>k__BackingField.<SendWholeUri>k__BackingField) != false))
            {
                    val_24 = ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField.OriginalString;
            }
            else
            {
                    val_24 = BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField);
            }
            
            val_25 = null;
            val_25 = null;
            System.String[] val_5 = BestHTTP.HTTPRequest.MethodNames + ((this.<MethodType>k__BackingField) << 3);
            string val_6 = System.String.Format(format:  "{0} {1} HTTP/1.1", arg0:  (BestHTTP.HTTPRequest.MethodNames + (this.<MethodType>k__BackingField) << 3) + 32, arg1:  val_24);
            val_26 = 1152921505553330176;
            val_27 = 1152921505557803008;
            var val_25 = 0;
            val_25 = val_25 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) <= 1)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  "HTTPRequest", info:  System.String.Format(format:  "Sending request: \'{0}\'", arg0:  val_6));
            }
            
            val_30 = null;
            val_30 = null;
            float val_27 = (float)BestHTTP.HTTPRequest.UploadChunkSize;
            val_27 = val_27 * 1.5f;
            new BestHTTP.Extensions.WriteOnlyBufferedStream() = new BestHTTP.Extensions.WriteOnlyBufferedStream(stream:  stream, bufferSize:  (int)val_27);
            BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  val_6));
            BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
            this.SendHeaders(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream());
            BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
            val_31 = this.<RawData>k__BackingField;
            if(val_31 == null)
            {
                goto label_31;
            }
            
            label_38:
            val_32 = this.<UploadStream>k__BackingField;
            if(val_32 == null)
            {
                goto label_32;
            }
            
            if((this.<UseUploadStreamLength>k__BackingField) == false)
            {
                goto label_33;
            }
            
            long val_16 = this.UploadStreamLength;
            goto label_40;
            label_31:
            if(this.FormImpl == null)
            {
                goto label_35;
            }
            
            val_31 = this.FormImpl;
            if(val_31 != null)
            {
                goto label_38;
            }
            
            label_35:
            if((this.<UploadStream>k__BackingField) == null)
            {
                goto label_37;
            }
            
            goto label_38;
            label_32:
            val_32 = new System.IO.MemoryStream();
            val_32 = new System.IO.MemoryStream(buffer:  val_31, index:  0, count:  this.<RawData>k__BackingField.Length);
            val_33 = this.<RawData>k__BackingField.Length;
            goto label_40;
            label_33:
            val_33 = 0;
            label_40:
            this.<Uploaded>k__BackingField = 0;
            this.<UploadLength>k__BackingField = val_33;
            val_34 = null;
            val_34 = null;
            val_31 = new byte[0];
            goto label_43;
            label_56:
            if(null == 0)
            {
                    BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  0.ToString(format:  "X")));
                val_35 = null;
                val_35 = null;
                BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
            }
            
            if((this.<UseUploadStreamLength>k__BackingField) != true)
            {
                    val_36 = null;
                val_36 = null;
                BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
            }
            
            long val_28 = this.<Uploaded>k__BackingField;
            val_28 = val_28 + 0;
            this.<Uploaded>k__BackingField = val_28;
            this.<UploadProgressChanged>k__BackingField = true;
            label_43:
            if(val_32 >= 1)
            {
                goto label_56;
            }
            
            val_27 = 1152921505557803008;
            val_26 = 1152921505553330176;
            if((this.<UseUploadStreamLength>k__BackingField) != true)
            {
                    BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  "0"));
                val_37 = null;
                val_37 = null;
                BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
                BestHTTP.Extensions.Extensions.WriteArray(stream:  new BestHTTP.Extensions.WriteOnlyBufferedStream(), array:  BestHTTP.HTTPRequest.EOL);
            }
            
            if((this.<UploadStream>k__BackingField) != null)
            {
                goto label_63;
            }
            
            val_32.Dispose();
            goto label_63;
            label_37:
            label_63:
            var val_29 = 0;
            val_29 = val_29 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "HTTPRequest", info:  "\'" + val_6 + "\' sent out");
            val_39 = 0;
            val_40 = 0;
            if(((this.<UploadStream>k__BackingField) != null) && ((this.<DisposeUploadStream>k__BackingField) != false))
            {
                    this.<UploadStream>k__BackingField.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        internal void UpgradeCallback()
        {
            if((this.<Response>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<Response>k__BackingField.<IsUpgraded>k__BackingField) == false)
            {
                    return;
            }
            
            if(this.OnUpgraded == null)
            {
                    return;
            }
            
            this.OnUpgraded.Invoke(originalRequest:  this, response:  this.<Response>k__BackingField);
        }
        internal void CallCallback()
        {
            if((this.<Callback>k__BackingField) == null)
            {
                    return;
            }
            
            this.<Callback>k__BackingField.Invoke(originalRequest:  this, response:  this.<Response>k__BackingField);
        }
        internal bool CallOnBeforeRedirection(System.Uri redirectUri)
        {
            if(this.onBeforeRedirection == null)
            {
                    return true;
            }
            
            return this.onBeforeRedirection.Invoke(originalRequest:  this, response:  this.<Response>k__BackingField, redirectUri:  redirectUri);
        }
        internal void FinishStreaming()
        {
            if((this.<Response>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.useStreaming == false)
            {
                    return;
            }
            
            this.<Response>k__BackingField.FinishStreaming();
        }
        internal void Prepare()
        {
            if((this.<FormUsage>k__BackingField) != 4)
            {
                    return;
            }
            
            BestHTTP.Forms.HTTPFormBase val_1 = this.SelectFormImplementation();
        }
        internal bool CallCustomCertificationValidator(System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain)
        {
            if(this.CustomCertificationValidator == null)
            {
                    return true;
            }
            
            return this.CustomCertificationValidator.Invoke(arg1:  this, arg2:  cert, arg3:  chain);
        }
        public BestHTTP.HTTPRequest Send()
        {
            return BestHTTP.HTTPManager.SendRequest(request:  this);
        }
        public void Abort()
        {
            var val_12;
            string val_13;
            var val_16;
            val_12 = null;
            val_12 = null;
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  100);
            if((System.Threading.Monitor.TryEnter(obj:  BestHTTP.HTTPManager.Locker, timeout:  new System.TimeSpan() {_ticks = val_1._ticks})) == false)
            {
                goto label_37;
            }
            
            if((this.<State>k__BackingField) >= 3)
            {
                goto label_6;
            }
            
            if((BestHTTP.HTTPManager.GetConnectionWith(request:  this)) == null)
            {
                goto label_9;
            }
            
            if((((this.<Response>k__BackingField) == null) || ((this.<Response>k__BackingField.<IsStreamed>k__BackingField) == false)) || ((this.<Response>k__BackingField.cacheStream) == null))
            {
                goto label_32;
            }
            
            this.<Response>k__BackingField.cacheStream.Dispose();
            this.<Response>k__BackingField.cacheStream = 0;
            goto label_32;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_13 = "HTTPRequest";
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_21;
            label_9:
            if((BestHTTP.HTTPManager.RemoveFromQueue(request:  this)) == true)
            {
                goto label_24;
            }
            
            val_13 = "HTTPRequest";
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_31;
            label_21:
            BestHTTP.HTTPManager.Logger.Warning(division:  val_13, warn:  System.String.Format(format:  "Abort - Already in a state({0}) where no Abort required!", arg0:  this.<State>k__BackingField.ToString()));
            goto label_32;
            label_31:
            BestHTTP.HTTPManager.Logger.Warning(division:  val_13, warn:  "Abort - No active connection found with this request! (The request may already finished?)");
            label_24:
            this.<State>k__BackingField = 5;
            this.CallCallback();
            label_32:
            label_46:
            val_16 = null;
            val_16 = null;
            System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            if((0 != 1) && (201 == 201))
            {
                    return;
            }
            
            label_37:
            System.Exception val_11 = new System.Exception(message:  "Wasn\'t able to acquire a thread lock. Abort failed!");
            if(0 != 1)
            {
                goto label_45;
            }
            
            goto label_46;
            label_45:
        }
        public void Clear()
        {
            this.FieldCollector = 0;
            this.FormImpl = 0;
            this.RemoveHeaders();
            this.<IsRedirected>k__BackingField = false;
            this.<RedirectCount>k__BackingField = 0;
            this.<Downloaded>k__BackingField = 0;
            this.<DownloadLength>k__BackingField = 0;
        }
        private void VerboseLogging(string str)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPRequest", verb:  "\'" + ((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField(((this.<IsRedirected>k__BackingField) == false) ? this.<Uri>k__BackingField : this.<RedirectUri>k__BackingField) + "\' - "("\' - ") + str);
        }
        public object get_Current()
        {
            return 0;
        }
        public bool MoveNext()
        {
            return (bool)((this.<State>k__BackingField) < 3) ? 1 : 0;
        }
        public void Reset()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        private BestHTTP.HTTPRequest System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current()
        {
            return (BestHTTP.HTTPRequest)this;
        }
        public void Dispose()
        {
        
        }
        private static HTTPRequest()
        {
            int val_19;
            byte[] val_1 = new byte[2];
            val_19 = val_1.Length;
            if(val_19 == 0)
            {
                    val_19 = val_1.Length;
            }
            
            val_1[0] = 13;
            val_1[0] = 10;
            BestHTTP.HTTPRequest.EOL = val_1;
            string[] val_2 = new string[8];
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_4 = 0.ToString().ToUpper();
            if(val_2 == null)
            {
                goto label_7;
            }
            
            if(val_4 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_4 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_2[0] = val_4;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[1] = 1.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[2] = 2.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[3] = 3.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[4] = 4.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[5] = 5.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[6] = 6.ToString().ToUpper();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2[7] = 7.ToString().ToUpper();
            BestHTTP.HTTPRequest.MethodNames = val_2;
            BestHTTP.HTTPRequest.UploadChunkSize = 2048;
        }
    
    }

}
