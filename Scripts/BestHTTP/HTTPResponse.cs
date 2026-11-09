using UnityEngine;

namespace BestHTTP
{
    public class HTTPResponse : IDisposable
    {
        // Fields
        internal const byte CR = 13;
        internal const byte LF = 10;
        public const int MinBufferSize = 4096;
        private int <VersionMajor>k__BackingField;
        private int <VersionMinor>k__BackingField;
        private int <StatusCode>k__BackingField;
        private string <Message>k__BackingField;
        private bool <IsStreamed>k__BackingField;
        private bool <IsStreamingFinished>k__BackingField;
        private bool <IsFromCache>k__BackingField;
        private BestHTTP.Caching.HTTPCacheFileInfo <CacheFileInfo>k__BackingField;
        private bool <IsCacheOnly>k__BackingField;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> <Headers>k__BackingField;
        private byte[] <Data>k__BackingField;
        private bool <IsUpgraded>k__BackingField;
        private System.Collections.Generic.List<BestHTTP.Cookies.Cookie> <Cookies>k__BackingField;
        protected string dataAsText;
        protected UnityEngine.Texture2D texture;
        private bool <IsClosedManually>k__BackingField;
        internal BestHTTP.HTTPRequest baseRequest;
        protected System.IO.Stream Stream;
        protected System.Collections.Generic.List<byte[]> streamedFragments;
        protected object SyncRoot;
        protected byte[] fragmentBuffer;
        protected int fragmentBufferDataLength;
        protected System.IO.Stream cacheStream;
        protected int allFragmentSize;
        private System.IO.MemoryStream decompressorInputStream;
        private System.IO.MemoryStream decompressorOutputStream;
        private BestHTTP.Decompression.Zlib.GZipStream decompressorGZipStream;
        private byte[] copyBuffer;
        private const int MinLengthToDecompress = 256;
        
        // Properties
        public int VersionMajor { get; set; }
        public int VersionMinor { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; }
        public string Message { get; set; }
        public bool IsStreamed { get; set; }
        public bool IsStreamingFinished { get; set; }
        public bool IsFromCache { get; set; }
        public BestHTTP.Caching.HTTPCacheFileInfo CacheFileInfo { get; set; }
        public bool IsCacheOnly { get; set; }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Headers { get; set; }
        public byte[] Data { get; set; }
        public bool IsUpgraded { get; set; }
        public System.Collections.Generic.List<BestHTTP.Cookies.Cookie> Cookies { get; set; }
        public string DataAsText { get; }
        public UnityEngine.Texture2D DataAsTexture2D { get; }
        public bool IsClosedManually { get; set; }
        
        // Methods
        public int get_VersionMajor()
        {
            return (int)this.<VersionMajor>k__BackingField;
        }
        protected void set_VersionMajor(int value)
        {
            this.<VersionMajor>k__BackingField = value;
        }
        public int get_VersionMinor()
        {
            return (int)this.<VersionMinor>k__BackingField;
        }
        protected void set_VersionMinor(int value)
        {
            this.<VersionMinor>k__BackingField = value;
        }
        public int get_StatusCode()
        {
            return (int)this.<StatusCode>k__BackingField;
        }
        protected void set_StatusCode(int value)
        {
            this.<StatusCode>k__BackingField = value;
        }
        public bool get_IsSuccess()
        {
            return (bool)(((this.<StatusCode>k__BackingField) == 304) ? 1 : 0) | ((((this.<StatusCode>k__BackingField) - 200) < 100) ? 1 : 0);
        }
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        protected void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        public bool get_IsStreamed()
        {
            return (bool)this.<IsStreamed>k__BackingField;
        }
        protected void set_IsStreamed(bool value)
        {
            this.<IsStreamed>k__BackingField = value;
        }
        public bool get_IsStreamingFinished()
        {
            return (bool)this.<IsStreamingFinished>k__BackingField;
        }
        internal void set_IsStreamingFinished(bool value)
        {
            this.<IsStreamingFinished>k__BackingField = value;
        }
        public bool get_IsFromCache()
        {
            return (bool)this.<IsFromCache>k__BackingField;
        }
        internal void set_IsFromCache(bool value)
        {
            this.<IsFromCache>k__BackingField = value;
        }
        public BestHTTP.Caching.HTTPCacheFileInfo get_CacheFileInfo()
        {
            return (BestHTTP.Caching.HTTPCacheFileInfo)this.<CacheFileInfo>k__BackingField;
        }
        internal void set_CacheFileInfo(BestHTTP.Caching.HTTPCacheFileInfo value)
        {
            this.<CacheFileInfo>k__BackingField = value;
        }
        public bool get_IsCacheOnly()
        {
            return (bool)this.<IsCacheOnly>k__BackingField;
        }
        private void set_IsCacheOnly(bool value)
        {
            this.<IsCacheOnly>k__BackingField = value;
        }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_Headers()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>)this.<Headers>k__BackingField;
        }
        protected void set_Headers(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> value)
        {
            this.<Headers>k__BackingField = value;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        internal void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
        public bool get_IsUpgraded()
        {
            return (bool)this.<IsUpgraded>k__BackingField;
        }
        protected void set_IsUpgraded(bool value)
        {
            this.<IsUpgraded>k__BackingField = value;
        }
        public System.Collections.Generic.List<BestHTTP.Cookies.Cookie> get_Cookies()
        {
            return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>)this.<Cookies>k__BackingField;
        }
        internal void set_Cookies(System.Collections.Generic.List<BestHTTP.Cookies.Cookie> value)
        {
            this.<Cookies>k__BackingField = value;
        }
        public string get_DataAsText()
        {
            string val_3;
            if((this.<Data>k__BackingField) == null)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.dataAsText)) == false)
            {
                goto label_2;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if((this.<Data>k__BackingField) == null)
            {
                goto label_3;
            }
            
            label_8:
            val_3 = val_2;
            this.dataAsText = val_3;
            return val_3;
            label_1:
            val_3 = System.String.alignConst;
            return val_3;
            label_2:
            val_3 = this.dataAsText;
            return val_3;
            label_3:
            if(val_2 != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public UnityEngine.Texture2D get_DataAsTexture2D()
        {
            UnityEngine.Texture2D val_4;
            if((this.<Data>k__BackingField) != null)
            {
                    if(this.texture == 0)
            {
                    UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  0, height:  0, textureFormat:  5, mipChain:  false);
                this.texture = val_2;
                bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  this.<Data>k__BackingField, markNonReadable:  true);
            }
            
                val_4 = this.texture;
                return (UnityEngine.Texture2D)val_4;
            }
            
            val_4 = 0;
            return (UnityEngine.Texture2D)val_4;
        }
        public bool get_IsClosedManually()
        {
            return (bool)this.<IsClosedManually>k__BackingField;
        }
        protected void set_IsClosedManually(bool value)
        {
            this.<IsClosedManually>k__BackingField = value;
        }
        public HTTPResponse(BestHTTP.HTTPRequest request, System.IO.Stream stream, bool isStreamed, bool isFromCache)
        {
            this.SyncRoot = new System.Object();
            val_2 = new System.Object();
            this.baseRequest = request;
            this.Stream = val_2;
            this.<IsStreamed>k__BackingField = isStreamed;
            this.<IsFromCache>k__BackingField = isFromCache;
            this.<IsClosedManually>k__BackingField = false;
            this.<IsCacheOnly>k__BackingField = request.cacheOnly;
        }
        public virtual bool Receive(int forceReadRawContentLength = -1, bool readPayloadData = True)
        {
            BestHTTP.HTTPRequest val_65;
            var val_67;
            string val_68;
            var val_70;
            int val_71;
            string val_74;
            int val_75;
            var val_76;
            var val_77;
            var val_81;
            var val_82;
            val_65 = this;
            var val_69 = 0;
            val_69 = val_69 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    val_67 = 0;
                this.VerboseLogging(str:  System.String.Format(format:  "Receive. forceReadRawContentLength: \'{0:N0}\', readPayloadData: \'{1:N0}\'", arg0:  forceReadRawContentLength, arg1:  readPayloadData));
            }
            
            string val_7 = BestHTTP.HTTPResponse.ReadTo(stream:  this.Stream, blocker:  32);
            val_68 = BestHTTP.HTTPManager.Logger;
            var val_70 = 0;
            val_70 = val_70 + 1;
            if((val_68.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "Status Line: \'{0}\'", arg0:  val_7));
            }
            
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                goto label_17;
            }
            
            val_65 = this.baseRequest;
            if((this.baseRequest.<DisableRetry>k__BackingField) == true)
            {
                goto label_19;
            }
            
            label_102:
            val_70 = 0;
            return (bool)val_70;
            label_17:
            char[] val_14 = new char[2];
            val_71 = val_14.Length;
            if(val_71 == 0)
            {
                    val_71 = val_14.Length;
            }
            
            val_14[0] = '/';
            val_14[0] = '.';
            System.String[] val_15 = val_7.Split(separator:  val_14);
            this.<VersionMajor>k__BackingField = System.Int32.Parse(s:  val_15[1]);
            this.<VersionMinor>k__BackingField = System.Int32.Parse(s:  val_15[2]);
            var val_73 = 0;
            val_73 = val_73 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    val_67 = 0;
                this.VerboseLogging(str:  System.String.Format(format:  "HTTP Version: \'{0}.{1}\'", arg0:  this.<VersionMajor>k__BackingField.ToString(), arg1:  this.<VersionMinor>k__BackingField.ToString()));
            }
            
            string val_25 = BestHTTP.HTTPResponse.NoTrimReadTo(stream:  this.Stream, blocker1:  32, blocker2:  10);
            var val_74 = 0;
            val_74 = val_74 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "Status Code: \'{0}\'", arg0:  val_25));
            }
            
            if((this.baseRequest.<DisableRetry>k__BackingField) == false)
            {
                goto label_45;
            }
            
            val_74 = val_25;
            int val_32 = System.Int32.Parse(s:  val_74);
            goto label_46;
            label_45:
            if((System.Int32.TryParse(s:  val_25, result: out  val_32)) == false)
            {
                goto label_102;
            }
            
            val_74 = val_32;
            label_46:
            this.<StatusCode>k__BackingField = val_74;
            val_75 = 0;
            if(val_25.Length < 1)
            {
                goto label_52;
            }
            
            if(val_25 != null)
            {
                    val_76 = val_25.Length;
            }
            else
            {
                    val_76 = 0.Length;
            }
            
            val_75 = val_76 - 1;
            if((val_25.Chars[val_75] & 255) == '
            ')
            {
                goto label_52;
            }
            
            if(val_25 != null)
            {
                    val_77 = val_25.Length;
            }
            else
            {
                    val_77 = 0.Length;
            }
            
            val_75 = val_77 - 1;
            if((val_25.Chars[val_75] & 255) != '')
            {
                goto label_55;
            }
            
            label_52:
            val_68 = System.String.Format(format:  "{0} - Skipping Status Message reading!", arg0:  ((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField);
            var val_75 = 0;
            val_75 = val_75 + 1;
            BestHTTP.HTTPManager.Logger.Warning(division:  "HTTPResponse", warn:  val_68);
            this.<Message>k__BackingField = System.String.alignConst;
            label_88:
            this.ReadHeaders(stream:  this.Stream);
            if((this.<StatusCode>k__BackingField) != 101)
            {
                goto label_65;
            }
            
            if((this.HasHeaderWithValue(headerName:  "connection", value:  "upgrade")) == false)
            {
                goto label_66;
            }
            
            this.<IsUpgraded>k__BackingField = true;
            goto label_67;
            label_65:
            this.<IsUpgraded>k__BackingField = false;
            if(readPayloadData == true)
            {
                goto label_68;
            }
            
            goto label_86;
            label_66:
            System.Collections.Generic.List<System.String> val_48 = this.GetHeaderValues(name:  "upgrade");
            this.<IsUpgraded>k__BackingField = (val_48 != 0) ? 1 : 0;
            if(val_48 == null)
            {
                goto label_85;
            }
            
            label_67:
            var val_76 = 0;
            val_76 = val_76 + 1;
            goto label_77;
            label_55:
            this.<Message>k__BackingField = BestHTTP.HTTPResponse.ReadTo(stream:  this.Stream, blocker:  10);
            var val_77 = 0;
            val_77 = val_77 + 1;
            goto label_84;
            label_77:
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  "Request Upgraded!");
            }
            
            label_85:
            if(readPayloadData == false)
            {
                goto label_86;
            }
            
            label_68:
            bool val_56 = this.ReadPayload(forceReadRawContentLength:  forceReadRawContentLength);
            label_86:
            val_70 = 1;
            return (bool)val_70;
            label_84:
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                goto label_88;
            }
            
            this.VerboseLogging(str:  System.String.Format(format:  "Status Message: \'{0}\'", arg0:  this.<Message>k__BackingField));
            goto label_88;
            label_19:
            label_105:
            val_81 = new System.Exception(message:  "Remote server closed the connection before sending response header!");
            if(0 != 1)
            {
                goto label_89;
            }
            
            if((null & 1) == 0)
            {
                goto label_90;
            }
            
            val_82 = null;
            if((System.Exception)[1152921553655626432].captured_traces[8] != null)
            {
                goto label_92;
            }
            
            var val_80 = 0;
            val_80 = val_80 + 1;
            BestHTTP.HTTPManager.Logger.Warning(division:  "HTTPResponse", warn:  System.String.Format(format:  "{0} - Failed to read Status Line! Retry is enabled, returning with false.", arg0:  ((System.Exception)[1152921553655626432].captured_traces[8] == 0) ? ((System.Exception)[1152921553655626432].captured_traces[16]) : ((System.Exception)[1152921553655626432].captured_traces[104])));
            goto label_102;
            label_90:
            val_82 = 8;
            mem[8] = null;
            label_92:
            BestHTTP.Logger.ILogger val_66 = BestHTTP.HTTPManager.Logger;
            string val_68 = System.String.Format(format:  "{0} - Failed to read Status Line! Retry is disabled, re-throwing exception.", arg0:  ((System.Exception)[1152921553655626432].captured_traces[8] == 0) ? ((System.Exception)[1152921553655626432].captured_traces[16]) : ((System.Exception)[1152921553655626432].captured_traces[104]));
            goto label_105;
            label_89:
        }
        protected bool ReadPayload(int forceReadRawContentLength)
        {
            System.IO.Stream val_12;
            var val_13;
            var val_15;
            var val_16;
            int val_18;
            if(forceReadRawContentLength == 1)
            {
                goto label_1;
            }
            
            this.<IsFromCache>k__BackingField = true;
            this.ReadRaw(stream:  this.Stream, contentLength:  (long)forceReadRawContentLength);
            val_13 = BestHTTP.HTTPManager.Logger;
            val_15 = null;
            var val_14 = 0;
            val_16 = 1152921505557839880;
            val_14 = val_14 + 1;
            goto label_8;
            label_1:
            if(((this.<StatusCode>k__BackingField) - 100) < 100)
            {
                    return true;
            }
            
            if((this.<StatusCode>k__BackingField) == 204)
            {
                    return true;
            }
            
            if((this.<StatusCode>k__BackingField) == 304)
            {
                    return true;
            }
            
            if((this.baseRequest.<MethodType>k__BackingField) == 1)
            {
                    return true;
            }
            
            if((this.HasHeaderWithValue(headerName:  "transfer-encoding", value:  "chunked")) == false)
            {
                goto label_14;
            }
            
            this.ReadChunked(stream:  this.Stream);
            goto label_28;
            label_14:
            System.Collections.Generic.List<System.String> val_4 = this.GetHeaderValues(name:  "content-length");
            System.Collections.Generic.List<System.String> val_5 = this.GetHeaderValues(name:  "content-range");
            if(val_4 != null)
            {
                    if(val_5 == null)
            {
                goto label_17;
            }
            
            }
            
            if(val_5 == null)
            {
                goto label_18;
            }
            
            if(val_4 == null)
            {
                goto label_19;
            }
            
            label_17:
            val_12 = this.Stream;
            label_31:
            this.ReadRaw(stream:  val_12, contentLength:  System.Int64.Parse(s:  val_4.Item[0]));
            label_28:
            val_13 = BestHTTP.HTTPManager.Logger;
            val_15 = null;
            var val_15 = 0;
            val_16 = 1152921505557839880;
            val_15 = val_15 + 1;
            label_8:
            if((val_13.Level & 255) != 0)
            {
                    return true;
            }
            
            this.VerboseLogging(str:  "ReadPayload Finished!");
            return true;
            label_18:
            this.ReadUnknownSize(stream:  this.Stream);
            goto label_28;
            label_19:
            if(this.GetRange() != null)
            {
                    val_18 = val_12.<LastBytePos>k__BackingField;
            }
            else
            {
                    val_18 = 1;
            }
            
            int val_16 = val_12.<FirstBytePos>k__BackingField;
            val_16 = (val_18 + 1) - val_16;
            goto label_31;
        }
        protected void ReadHeaders(System.IO.Stream stream)
        {
            object val_11;
            string val_2 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker1:  58, blocker2:  10).Trim();
            val_11 = val_2;
            if((System.String.op_Inequality(a:  val_2, b:  System.String.alignConst)) == false)
            {
                    return;
            }
            
            do
            {
                string val_4 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker:  10);
                var val_12 = 0;
                val_12 = val_12 + 1;
                if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "Header - \'{0}\': \'{1}\'", arg0:  val_11, arg1:  val_4));
            }
            
                this.AddHeader(name:  val_11, value:  val_4);
                string val_10 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker1:  58, blocker2:  10);
                val_11 = val_10;
            }
            while((System.String.op_Inequality(a:  val_10, b:  System.String.alignConst)) == true);
        
        }
        protected void AddHeader(string name, string value)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7;
            val_6 = this;
            string val_1 = name.ToLower();
            val_7 = this.<Headers>k__BackingField;
            if(val_7 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
                this.<Headers>k__BackingField = val_7;
            }
            
            if((val_2.TryGetValue(key:  val_1, value: out  0)) != true)
            {
                    val_6 = this.<Headers>k__BackingField;
                System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>(capacity:  1);
                val_6.Add(key:  val_1, value:  val_5);
            }
            
            val_5.Add(item:  value);
        }
        public System.Collections.Generic.List<string> GetHeaderValues(string name)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            var val_7;
            val_6 = this;
            System.Collections.Generic.List<System.String> val_2 = 0;
            if((this.<Headers>k__BackingField) != null)
            {
                    val_6 = this.<Headers>k__BackingField;
                if((val_6.TryGetValue(key:  name.ToLower(), value: out  val_2)) != false)
            {
                    val_6 = val_2;
                var val_5 = (val_6.Count != 0) ? (val_2) : 0;
                return (System.Collections.Generic.List<System.String>)val_7;
            }
            
            }
            
            val_7 = 0;
            return (System.Collections.Generic.List<System.String>)val_7;
        }
        public string GetFirstHeaderValue(string name)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
            var val_7;
            val_6 = this;
            System.Collections.Generic.List<System.String> val_2 = 0;
            if((this.<Headers>k__BackingField) != null)
            {
                    val_6 = this.<Headers>k__BackingField;
                if((val_6.TryGetValue(key:  name.ToLower(), value: out  val_2)) != false)
            {
                    val_6 = val_2;
                if(val_6.Count != 0)
            {
                    val_6 = val_2;
                string val_5 = val_6.Item[0];
                return (string)val_7;
            }
            
            }
            
            }
            
            val_7 = 0;
            return (string)val_7;
        }
        public bool HasHeaderWithValue(string headerName, string value)
        {
            var val_6;
            var val_7;
            val_6 = this;
            System.Collections.Generic.List<System.String> val_1 = this.GetHeaderValues(name:  headerName);
            if(val_1 == null)
            {
                    return (bool)val_7;
            }
            
            if(val_1.Count < 1)
            {
                goto label_2;
            }
            
            val_6 = 0;
            label_4:
            if((System.String.Compare(strA:  val_1.Item[0], strB:  value, comparisonType:  5)) == 0)
            {
                goto label_3;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < val_1.Count)
            {
                goto label_4;
            }
            
            label_2:
            val_7 = 0;
            return (bool)val_7;
            label_3:
            val_7 = 1;
            return (bool)val_7;
        }
        public bool HasHeader(string headerName)
        {
            return (bool)((this.GetHeaderValues(name:  headerName)) != 0) ? 1 : 0;
        }
        public BestHTTP.HTTPRange GetRange()
        {
            var val_13;
            var val_14;
            System.Collections.Generic.List<System.String> val_1 = this.GetHeaderValues(name:  "content-range");
            if(val_1 == null)
            {
                goto label_1;
            }
            
            System.String[] val_4 = val_1.Item[0].Split(separator:  new char[3], options:  1);
            if((System.String.op_Equality(a:  val_4[1], b:  "*")) == false)
            {
                goto label_5;
            }
            
            BestHTTP.HTTPRange val_7 = null;
            val_13 = val_7;
            val_7 = new BestHTTP.HTTPRange();
            .<ContentLength>k__BackingField = System.Int32.Parse(s:  val_4[2]);
            .<IsValid>k__BackingField = false;
            return (BestHTTP.HTTPRange)val_13;
            label_1:
            val_13 = 0;
            return (BestHTTP.HTTPRange)val_13;
            label_5:
            if((System.String.op_Inequality(a:  val_4[3], b:  "*")) != false)
            {
                    val_14 = System.Int32.Parse(s:  val_4[3]);
            }
            else
            {
                    val_14 = 0;
            }
            
            BestHTTP.HTTPRange val_12 = null;
            val_13 = val_12;
            val_12 = new BestHTTP.HTTPRange(firstBytePosition:  System.Int32.Parse(s:  val_4[1]), lastBytePosition:  System.Int32.Parse(s:  val_4[2]), contentLength:  0);
            return (BestHTTP.HTTPRange)val_13;
        }
        public static string ReadTo(System.IO.Stream stream, byte blocker)
        {
            var val_5;
            var val_6;
            var val_7;
            byte val_5 = blocker;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            val_5 = val_5 & 255;
            label_5:
            if((stream == val_5) || (stream == 1))
            {
                goto label_3;
            }
            
            if(val_1 != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_5 = BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1).Trim();
            val_6 = 0;
            val_7 = 0;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if( != 1)
            {
                    return (string);
            }
            
            if(null == null)
            {
                    return (string);
            }
            
            return (string);
        }
        public static string ReadTo(System.IO.Stream stream, byte blocker1, byte blocker2)
        {
            var val_5;
            var val_6;
            var val_7;
            byte val_6 = blocker2;
            byte val_5 = blocker1;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            val_5 = val_5 & 255;
            val_6 = val_6 & 255;
            label_6:
            if(((stream == 1) || (stream == val_5)) || (stream == val_6))
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            val_5 = BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1).Trim();
            val_6 = 0;
            val_7 = 0;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_1.Dispose();
            if( != 1)
            {
                    return (string);
            }
            
            if(null == null)
            {
                    return (string);
            }
            
            return (string);
        }
        public static string NoTrimReadTo(System.IO.Stream stream, byte blocker1, byte blocker2)
        {
            var val_4;
            var val_5;
            var val_6;
            byte val_5 = blocker2;
            byte val_4 = blocker1;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            val_4 = val_4 & 255;
            val_5 = val_5 & 255;
            label_6:
            if(((stream == 1) || (stream == val_4)) || (stream == val_5))
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            val_4 = BestHTTP.Extensions.Extensions.AsciiToString(bytes:  val_1);
            val_5 = 0;
            val_6 = 0;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if( != 1)
            {
                    return (string);
            }
            
            if(null == null)
            {
                    return (string);
            }
            
            return (string);
        }
        protected int ReadChunkLength(System.IO.Stream stream)
        {
            int val_4 = 0;
            char[] val_2 = new char[1];
            val_2[0] = ';';
            string val_8 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker:  10).Split(separator:  val_2)[0];
            if((System.Int32.TryParse(s:  val_8, style:  512, provider:  0, result: out  val_4)) != false)
            {
                    return val_4;
            }
            
            System.Exception val_7 = new System.Exception(message:  System.String.Format(format:  "Can\'t parse \'{0}\' as a hex number!", arg0:  val_8));
        }
        protected void ReadChunked(System.IO.Stream stream)
        {
            bool val_42;
            string val_43;
            var val_44;
            long val_45;
            long val_46;
            bool val_47;
            var val_48;
            long val_50;
            long val_51;
            bool val_52;
            var val_53;
            var val_54;
            this.BeginReceiveStreamFragments();
            string val_1 = this.GetFirstHeaderValue(name:  "Content-Length");
            bool val_2 = System.String.IsNullOrEmpty(value:  val_1);
            var val_42 = ~val_2;
            val_42 = val_42 & 1;
            int val_3 = 0;
            if(val_2 != true)
            {
                    bool val_5 = System.Int32.TryParse(s:  val_1, result: out  val_3);
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "ReadChunked - hasContentLengthHeader: {0}, contentLengthHeader: {1} realLength: {2:N0}", arg0:  val_5.ToString(), arg1:  val_1, arg2:  0));
            }
            
            System.IO.MemoryStream val_12 = new System.IO.MemoryStream();
            int val_13 = val_12.ReadChunkLength(stream:  stream);
            var val_44 = 0;
            val_44 = val_44 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "chunkLength: {0:N0}", arg0:  val_13));
            }
            
            byte[] val_19 = new byte[0];
            this.baseRequest.<DownloadLength>k__BackingField = (long)(val_5 == false) ? (val_13) : (val_3);
            int val_45 = this.<StatusCode>k__BackingField;
            val_42 = 1;
            if(val_45 != 304)
            {
                    val_45 = val_45 - 200;
                if(val_45 >= 100)
            {
                    val_42 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_42 == true) ? 1 : 0;
            if((this.<IsFromCache>k__BackingField) != false)
            {
                    val_43 = 0;
            }
            else
            {
                    val_43 = this.GetFirstHeaderValue(name:  "content-encoding");
            }
            
            if((System.String.IsNullOrEmpty(value:  val_43)) == false)
            {
                goto label_24;
            }
            
            val_44 = 0;
            if(val_13 != 0)
            {
                goto label_25;
            }
            
            goto label_27;
            label_24:
            val_44 = System.String.op_Equality(a:  val_43, b:  "gzip");
            if(val_13 == 0)
            {
                goto label_27;
            }
            
            label_25:
            label_59:
            if(val_13 > mem[1152921553658236072])
            {
                    System.Array.Resize<System.Byte>(array: ref  val_19, newSize:  val_13);
            }
            
            val_43 = 0;
            label_37:
            int val_25 = val_13 - val_43;
            if(stream <= 0)
            {
                goto label_31;
            }
            
            if(this.baseRequest != null)
            {
                    val_45 = this.baseRequest.<Downloaded>k__BackingField;
                val_46 = this.baseRequest.<Downloaded>k__BackingField;
            }
            else
            {
                    val_45 = 4;
                val_46 = 280;
            }
            
            mem[280] = val_45 + (stream << );
            int val_46 = this.<StatusCode>k__BackingField;
            val_47 = 1;
            if(val_46 != 304)
            {
                    val_46 = val_46 - 200;
                if(val_46 >= 100)
            {
                    val_47 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_47 == true) ? 1 : 0;
            if(null < val_13)
            {
                goto label_37;
            }
            
            if(this.baseRequest.useStreaming == false)
            {
                goto label_39;
            }
            
            this.WaitWhileHasFragments();
            if(val_44 == false)
            {
                goto label_40;
            }
            
            System.Byte[] val_28 = this.Decompress(data:  val_19, offset:  0, count:  35622912, forceDecompress:  false);
            val_48 = 1152921505553330176;
            if(val_28 == null)
            {
                goto label_44;
            }
            
            this.FeedStreamFragment(buffer:  val_28, pos:  0, length:  val_28.Length);
            goto label_44;
            label_39:
            val_48 = 1152921505553330176;
            if(val_12 != null)
            {
                goto label_44;
            }
            
            goto label_44;
            label_40:
            this.FeedStreamFragment(buffer:  val_19, pos:  0, length:  35622912);
            val_48 = 1152921505553330176;
            label_44:
            int val_30 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker:  10).ReadChunkLength(stream:  stream);
            var val_47 = 0;
            val_47 = val_47 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "chunkLength: {0:N0}", arg0:  val_30));
            }
            
            if(val_5 != true)
            {
                    if(this.baseRequest != null)
            {
                    val_50 = this.baseRequest.<DownloadLength>k__BackingField;
                val_51 = this.baseRequest.<DownloadLength>k__BackingField;
            }
            else
            {
                    val_50 = 4;
                val_51 = 288;
            }
            
                mem[288] = val_50 + (val_30 << );
            }
            
            int val_48 = this.<StatusCode>k__BackingField;
            val_43 = this.baseRequest;
            val_52 = 1;
            if(val_48 != 304)
            {
                    val_48 = val_48 - 200;
                if(val_48 >= 100)
            {
                    val_52 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_52 == true) ? 1 : 0;
            if(val_30 != 0)
            {
                goto label_59;
            }
            
            label_27:
            if(this.baseRequest.useStreaming != false)
            {
                    if(val_44 != false)
            {
                    System.Byte[] val_38 = this.Decompress(data:  0, offset:  0, count:  0, forceDecompress:  true);
                if(val_38 != null)
            {
                    this.FeedStreamFragment(buffer:  val_38, pos:  0, length:  val_38.Length);
            }
            
            }
            
                this.FlushRemainingFragmentBuffer();
            }
            
            this.ReadHeaders(stream:  stream);
            if(this.baseRequest.useStreaming == false)
            {
                goto label_65;
            }
            
            val_53 = 0;
            val_54 = 0;
            if(val_12 != null)
            {
                goto label_68;
            }
            
            goto label_107;
            label_65:
            val_53 = 0;
            val_54 = 0;
            this.<Data>k__BackingField = this.DecodeStream(streamToDecode:  val_12);
            if(val_12 != null)
            {
                goto label_68;
            }
            
            goto label_107;
            label_31:
            System.Exception val_40 = BestHTTP.Extensions.ExceptionHelper.ServerClosedTCPStream();
            if(0 != 1)
            {
                goto label_106;
            }
            
            val_53 = 0;
            if(val_12 == null)
            {
                goto label_107;
            }
            
            label_68:
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_12.Dispose();
            label_107:
            if(val_53 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_106:
        }
        internal void ReadRaw(System.IO.Stream stream, long contentLength)
        {
            bool val_24;
            string val_26;
            bool val_27;
            System.IO.MemoryStream val_28;
            long val_29;
            long val_30;
            bool val_31;
            var val_32;
            var val_33;
            long val_28 = contentLength;
            this.BeginReceiveStreamFragments();
            this.baseRequest.<DownloadLength>k__BackingField = val_28;
            int val_24 = this.<StatusCode>k__BackingField;
            val_24 = 1;
            if(val_24 != 304)
            {
                    val_24 = val_24 - 200;
                if(val_24 >= 100)
            {
                    val_24 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_24 == true) ? 1 : 0;
            var val_25 = 0;
            val_25 = val_25 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "ReadRaw - contentLength: {0:N0}", arg0:  val_28));
            }
            
            if((this.<IsFromCache>k__BackingField) != false)
            {
                    val_26 = 0;
            }
            else
            {
                    val_26 = this.GetFirstHeaderValue(name:  "content-encoding");
            }
            
            if((System.String.IsNullOrEmpty(value:  val_26)) != false)
            {
                    val_27 = 0;
            }
            else
            {
                    val_27 = System.String.op_Equality(a:  val_26, b:  "gzip");
            }
            
            if(val_28 >= 2147483647)
            {
                    if(this.baseRequest.useStreaming == false)
            {
                goto label_19;
            }
            
            }
            
            System.IO.MemoryStream val_11 = null;
            val_28 = val_11;
            val_11 = new System.IO.MemoryStream(capacity:  (this.baseRequest.useStreaming == true) ? 0 : (val_28));
            int val_12 = System.Math.Max(val1:  this.baseRequest.streamFragmentSize, val2:  4096);
            byte[] val_13 = new byte[0];
            val_24 = val_13;
            if(val_28 < 1)
            {
                goto label_24;
            }
            
            label_44:
            label_36:
            int val_16 = System.Math.Min(val1:  System.Math.Min(val1:  2147483646, val2:  val_28), val2:  val_13.Length - 0);
            val_27 = stream;
            if(val_27 <= 0)
            {
                goto label_29;
            }
            
            if(this.baseRequest != null)
            {
                    val_29 = this.baseRequest.<Downloaded>k__BackingField;
                val_30 = this.baseRequest.<Downloaded>k__BackingField;
            }
            else
            {
                    val_29 = 4;
                val_30 = 280;
            }
            
            var val_26 = (long)val_27;
            val_26 = val_29 + val_26;
            mem[280] = val_26;
            int val_27 = this.<StatusCode>k__BackingField;
            val_31 = 1;
            if(val_27 != 304)
            {
                    val_27 = val_27 - 200;
                if(val_27 >= 100)
            {
                    val_31 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            val_28 = val_28 - (val_27 << );
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_31 == true) ? 1 : 0;
            if(val_28 >= 1)
            {
                    if(null < val_13.Length)
            {
                goto label_36;
            }
            
            }
            
            if(this.baseRequest.useStreaming == false)
            {
                goto label_38;
            }
            
            this.WaitWhileHasFragments();
            val_27 = val_27;
            if(val_27 == false)
            {
                goto label_39;
            }
            
            System.Byte[] val_18 = this.Decompress(data:  val_13, offset:  0, count:  35622912, forceDecompress:  false);
            if(val_18 == null)
            {
                goto label_43;
            }
            
            this.FeedStreamFragment(buffer:  val_18, pos:  0, length:  val_18.Length);
            goto label_43;
            label_38:
            val_27 = val_27;
            if(val_28 != null)
            {
                goto label_43;
            }
            
            goto label_43;
            label_39:
            this.FeedStreamFragment(buffer:  val_13, pos:  0, length:  35622912);
            label_43:
            if(val_28 >= 1)
            {
                goto label_44;
            }
            
            label_24:
            if(this.baseRequest.useStreaming != false)
            {
                    if(val_27 != false)
            {
                    System.Byte[] val_19 = this.Decompress(data:  0, offset:  0, count:  0, forceDecompress:  true);
                if(val_19 != null)
            {
                    this.FeedStreamFragment(buffer:  val_19, pos:  0, length:  val_19.Length);
            }
            
            }
            
                this.FlushRemainingFragmentBuffer();
            }
            
            if(this.baseRequest.useStreaming == false)
            {
                goto label_50;
            }
            
            val_32 = 0;
            val_33 = 0;
            if(val_28 != null)
            {
                goto label_53;
            }
            
            goto label_77;
            label_50:
            val_32 = 0;
            val_33 = 0;
            this.<Data>k__BackingField = this.DecodeStream(streamToDecode:  val_11);
            if(val_28 != null)
            {
                goto label_53;
            }
            
            goto label_77;
            label_29:
            System.Exception val_21 = BestHTTP.Extensions.ExceptionHelper.ServerClosedTCPStream();
            label_19:
            System.OverflowException val_22 = null;
            val_28 = val_22;
            val_22 = new System.OverflowException(message:  "You have to use STREAMING to download files bigger than 2GB!");
            if(0 != 1)
            {
                goto label_76;
            }
            
            val_32 = 0;
            if(val_28 == null)
            {
                goto label_77;
            }
            
            label_53:
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_22.Dispose();
            label_77:
            if(val_32 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_76:
        }
        protected void ReadUnknownSize(System.IO.Stream stream)
        {
            string val_19;
            var val_21;
            var val_22;
            long val_23;
            long val_24;
            long val_25;
            bool val_26;
            System.IO.MemoryStream val_27;
            var val_28;
            var val_29;
            if((this.<IsFromCache>k__BackingField) != false)
            {
                    val_19 = 0;
            }
            else
            {
                    val_19 = this.GetFirstHeaderValue(name:  "content-encoding");
            }
            
            if((System.String.IsNullOrEmpty(value:  val_19)) != false)
            {
                
            }
            else
            {
                    bool val_4 = System.String.op_Equality(a:  val_19, b:  "gzip");
            }
            
            System.IO.MemoryStream val_5 = new System.IO.MemoryStream();
            int val_6 = System.Math.Max(val1:  this.baseRequest.streamFragmentSize, val2:  4096);
            byte[] val_7 = new byte[0];
            var val_21 = 0;
            val_21 = val_21 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                goto label_15;
            }
            
            goto label_42;
            label_15:
            val_21 = val_7;
            this.VerboseLogging(str:  System.String.Format(format:  "ReadUnknownSize - buffer size: {0:N0}", arg0:  val_7.Length));
            goto label_42;
            label_26:
            val_22 = 1;
            val_7[(long)this.baseRequest] = ;
            if(((0 + val_22) >= val_7.Length) || ((stream & 1) == 0))
            {
                goto label_27;
            }
            
            if((stream & 2147483648) == 0)
            {
                goto label_26;
            }
            
            goto label_27;
            label_42:
            int val_14 = val_7.Length - 0;
            val_22 = stream;
            label_27:
            if(this.baseRequest != null)
            {
                    val_23 = this.baseRequest.<Downloaded>k__BackingField;
                val_24 = this.baseRequest.<Downloaded>k__BackingField;
            }
            else
            {
                    val_23 = 4;
                val_24 = 280;
            }
            
            long val_15 = val_23 + (val_22 << );
            mem[280] = val_15;
            if(this.baseRequest != null)
            {
                    val_25 = this.baseRequest.<Downloaded>k__BackingField;
            }
            else
            {
                    val_25 = mem[280];
            }
            
            this.baseRequest.<DownloadLength>k__BackingField = val_25;
            int val_22 = this.<StatusCode>k__BackingField;
            val_26 = 1;
            if(val_22 != 304)
            {
                    val_22 = val_22 - 200;
                if(val_22 >= 100)
            {
                    val_26 = this.<IsFromCache>k__BackingField;
            }
            
            }
            
            this.baseRequest.<DownloadProgressChanged>k__BackingField = (val_26 == true) ? 1 : 0;
            if(val_22 >= 1)
            {
                    if(null < val_7.Length)
            {
                goto label_42;
            }
            
            }
            
            if(this.baseRequest.useStreaming == false)
            {
                goto label_44;
            }
            
            this.WaitWhileHasFragments();
            if(val_4 == false)
            {
                goto label_45;
            }
            
            System.Byte[] val_17 = this.Decompress(data:  val_7, offset:  0, count:  35622912, forceDecompress:  false);
            if(val_17 == null)
            {
                goto label_49;
            }
            
            this.FeedStreamFragment(buffer:  val_17, pos:  0, length:  val_17.Length);
            goto label_49;
            label_44:
            if(val_5 != 0)
            {
                goto label_49;
            }
            
            goto label_49;
            label_45:
            this.FeedStreamFragment(buffer:  val_7, pos:  0, length:  35622912);
            label_49:
            if(val_22 >= 1)
            {
                goto label_42;
            }
            
            val_27 = val_5;
            if(this.baseRequest.useStreaming != false)
            {
                    if(val_4 != false)
            {
                    System.Byte[] val_18 = this.Decompress(data:  0, offset:  0, count:  0, forceDecompress:  true);
                if(val_18 != null)
            {
                    this.FeedStreamFragment(buffer:  val_18, pos:  0, length:  val_18.Length);
            }
            
            }
            
                this.FlushRemainingFragmentBuffer();
            }
            
            if(this.baseRequest.useStreaming == false)
            {
                goto label_56;
            }
            
            val_28 = 0;
            val_29 = 0;
            if(val_27 != 0)
            {
                goto label_59;
            }
            
            goto label_94;
            label_56:
            val_28 = 0;
            val_29 = 0;
            this.<Data>k__BackingField = this.DecodeStream(streamToDecode:  val_5);
            if(val_27 != 0)
            {
                goto label_59;
            }
            
            goto label_94;
            label_59:
            if(val_15 != 0)
            {
                    var val_23 = 0;
                do
            {
                val_23 = val_23 + 1;
            }
            while(val_23 < val_15);
            
            }
            
            val_5.Dispose();
            label_94:
            if( != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        protected byte[] DecodeStream(System.IO.MemoryStream streamToDecode)
        {
            System.IO.Stream val_16;
            var val_17;
            System.IO.Stream val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_16 = streamToDecode;
            val_17 = this;
            if((this.<IsFromCache>k__BackingField) == false)
            {
                goto label_2;
            }
            
            label_6:
            val_17 = ???;
            val_16 = ???;
            goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
            label_2:
            System.Collections.Generic.List<System.String> val_1 = val_17.GetHeaderValues(name:  "content-encoding");
            if(val_1 == null)
            {
                goto label_6;
            }
            
            string val_2 = val_1.Item[0];
            if((System.String.op_Equality(a:  val_2, b:  "gzip")) == false)
            {
                goto label_4;
            }
            
            BestHTTP.Decompression.Zlib.GZipStream val_4 = null;
            val_18 = val_16;
            val_19 = val_4;
            val_4 = new BestHTTP.Decompression.Zlib.GZipStream(stream:  val_18, mode:  1);
            goto label_5;
            label_4:
            if((System.String.op_Equality(a:  val_2, b:  "deflate")) == false)
            {
                goto label_6;
            }
            
            BestHTTP.Decompression.Zlib.DeflateStream val_6 = null;
            val_18 = val_16;
            val_19 = val_6;
            val_6 = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  val_18, mode:  1);
            label_5:
            System.IO.MemoryStream val_7 = new System.IO.MemoryStream(capacity:  val_16);
            byte[] val_8 = new byte[1024];
            label_11:
            if(val_19 < 1)
            {
                goto label_9;
            }
            
            if(val_7 != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            val_20 = val_7;
            val_21 = 0;
            val_22 = 0;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_7.Dispose();
            if( != 1)
            {
                    return (System.Byte[]);
            }
            
            if(null == null)
            {
                    return (System.Byte[]);
            }
            
            return (System.Byte[]);
        }
        private byte[] Decompress(byte[] data, int offset, int count, bool forceDecompress = False)
        {
            int val_13;
            var val_14;
            var val_15;
            System.IO.MemoryStream val_16;
            int val_17;
            var val_18;
            System.IO.MemoryStream val_19;
            System.Byte[] val_20;
            val_13 = count;
            val_14 = data;
            val_15 = this;
            val_16 = this.decompressorInputStream;
            if(val_16 == null)
            {
                    System.IO.MemoryStream val_1 = null;
                val_17 = val_13;
                val_18 = 0;
                val_16 = val_1;
                val_1 = new System.IO.MemoryStream(capacity:  val_17);
                this.decompressorInputStream = val_16;
            }
            
            if(val_14 != null)
            {
                    val_17 = val_14;
                val_18 = offset;
            }
            
            if(forceDecompress != true)
            {
                    if(this.decompressorInputStream < 256)
            {
                    return 0;
            }
            
            }
            
            if(this.decompressorGZipStream == null)
            {
                    this.decompressorGZipStream = new BestHTTP.Decompression.Zlib.GZipStream(stream:  this.decompressorInputStream, mode:  1, level:  6, leaveOpen:  true);
            }
            
            val_19 = this.decompressorOutputStream;
            if(val_19 != null)
            {
                goto label_10;
            }
            
            System.IO.MemoryStream val_3 = null;
            val_19 = val_3;
            val_3 = new System.IO.MemoryStream();
            this.decompressorOutputStream = val_19;
            if(val_19 == null)
            {
                goto label_11;
            }
            
            label_10:
            val_20 = this.copyBuffer;
            if(val_20 != null)
            {
                goto label_15;
            }
            
            val_20 = new byte[1024];
            this.copyBuffer = val_20;
            goto label_15;
            label_20:
            val_20 = this.copyBuffer;
            goto label_15;
            label_18:
            if(this.decompressorOutputStream != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_15:
            if(val_20 == null)
            {
                goto label_18;
            }
            
            label_17:
            if(this.decompressorGZipStream != null)
            {
                goto label_20;
            }
            
            val_15 = ???;
            val_13 = ???;
            val_14 = ???;
            goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_388;
            label_11:
        }
        protected void BeginReceiveStreamFragments()
        {
            BestHTTP.HTTPRequest val_5;
            if(this.baseRequest.disableCache == false)
            {
                goto label_2;
            }
            
            label_14:
            this.allFragmentSize = 0;
            return;
            label_2:
            if((this.baseRequest.useStreaming == false) || ((this.<IsFromCache>k__BackingField) == true))
            {
                goto label_14;
            }
            
            val_5 = this.baseRequest;
            if(this.baseRequest == null)
            {
                    val_5 = this.baseRequest;
            }
            
            if((BestHTTP.Caching.HTTPCacheService.IsCacheble(uri:  ((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField, method:  this.baseRequest.<MethodType>k__BackingField, response:  this)) == false)
            {
                goto label_14;
            }
            
            this.cacheStream = BestHTTP.Caching.HTTPCacheService.PrepareStreamed(uri:  ((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField, response:  this);
            goto label_14;
        }
        protected void FeedStreamFragment(byte[] buffer, int pos, int length)
        {
            int val_3;
            int val_4;
            int val_5;
            val_3 = length;
            val_4 = pos;
            goto label_0;
            label_10:
            int val_3 = this.fragmentBufferDataLength;
            int val_1 = this.baseRequest.streamFragmentSize - val_3;
            val_4 = val_1 + val_4;
            val_3 = val_3 - val_1;
            label_0:
            if(buffer == null)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
            
            if(this.fragmentBuffer != null)
            {
                    val_5 = this.fragmentBufferDataLength;
            }
            else
            {
                    val_5 = 0;
                this.fragmentBuffer = new byte[0];
                this.fragmentBufferDataLength = 0;
            }
            
            val_3 = val_5 + val_3;
            if(val_3 > this.baseRequest.streamFragmentSize)
            {
                goto label_10;
            }
            
            System.Array.Copy(sourceArray:  buffer, sourceIndex:  val_4, destinationArray:  this.fragmentBuffer, destinationIndex:  this.fragmentBufferDataLength, length:  val_3);
            val_4 = this.baseRequest;
            val_3 = this.fragmentBufferDataLength + val_3;
            this.fragmentBufferDataLength = val_3;
            if(val_3 != this.baseRequest.streamFragmentSize)
            {
                    return;
            }
            
            this.AddStreamedFragment(buffer:  this.fragmentBuffer);
            this.fragmentBuffer = 0;
            this.fragmentBufferDataLength = 0;
        }
        protected void FlushRemainingFragmentBuffer()
        {
            System.Byte[] val_1 = this.fragmentBuffer;
            if(val_1 != null)
            {
                    System.Array.Resize<System.Byte>(array: ref  val_1, newSize:  this.fragmentBufferDataLength);
                this.AddStreamedFragment(buffer:  this.fragmentBuffer);
                this.fragmentBuffer = 0;
                this.fragmentBufferDataLength = 0;
            }
            
            if(this.cacheStream == null)
            {
                    return;
            }
            
            this.cacheStream.Dispose();
            this.cacheStream = 0;
            BestHTTP.Caching.HTTPCacheService.SetBodyLength(uri:  ((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField, bodyLength:  this.allFragmentSize);
        }
        protected void AddStreamedFragment(byte[] buffer)
        {
            System.Collections.Generic.List<System.Byte[]> val_8;
            System.IO.Stream val_10;
            var val_11;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.SyncRoot, lockTaken: ref  val_1);
            if((this.<IsCacheOnly>k__BackingField) != true)
            {
                    val_8 = this.streamedFragments;
                if(val_8 == null)
            {
                    val_8 = null;
                val_8 = new System.Collections.Generic.List<System.Byte[]>();
                this.streamedFragments = val_8;
            }
            
                null.Add(item:  buffer);
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(buffer != null)
            {
                    if(((BestHTTP.HTTPManager.Logger.Level & 255) == 0) && (this.streamedFragments != null))
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "AddStreamedFragment buffer length: {0:N0} streamedFragments: {1:N0}", arg0:  buffer.Length, arg1:  this.streamedFragments.Count));
            }
            
            }
            
            val_10 = this.cacheStream;
            if(val_10 != null)
            {
                    int val_10 = this.allFragmentSize;
                val_11 = 0;
                val_10 = 0;
                val_10 = val_10 + buffer.Length;
                this.allFragmentSize = val_10;
            }
            else
            {
                    val_11 = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SyncRoot);
            }
            
            if(val_11 != 1)
            {
                    return;
            }
            
            if(val_10 == null)
            {
                    return;
            }
        
        }
        protected void WaitWhileHasFragments()
        {
            this.VerboseLogging(str:  "WaitWhileHasFragments");
            goto label_1;
            label_4:
            if(this.HasFragmentsInQueue() == false)
            {
                    return;
            }
            
            System.Threading.Thread.Sleep(millisecondsTimeout:  16);
            label_1:
            if(this.baseRequest.useStreaming == true)
            {
                goto label_4;
            }
        
        }
        private bool HasFragmentsInQueue()
        {
            var val_10;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.SyncRoot, lockTaken: ref  val_1);
            if(this.streamedFragments == null)
            {
                goto label_3;
            }
            
            int val_2 = this.streamedFragments.Count;
            if(val_2 < (this.baseRequest.<MaxFragmentQueueLength>k__BackingField))
            {
                goto label_3;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_10;
            label_3:
            val_10 = 0;
            goto label_12;
            label_10:
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "HasFragmentsInQueue - {0} / {1}", arg0:  this.streamedFragments.Count, arg1:  this.baseRequest.<MaxFragmentQueueLength>k__BackingField));
            }
            
            label_12:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SyncRoot);
            }
            
            if(0 != 1)
            {
                    return (bool)(((val_2 >= (this.baseRequest.<MaxFragmentQueueLength>k__BackingField)) ? 1 : 0) != 0) ? 1 : 0;
            }
            
            if(0 == 0)
            {
                    return (bool)(((val_2 >= (this.baseRequest.<MaxFragmentQueueLength>k__BackingField)) ? 1 : 0) != 0) ? 1 : 0;
            }
            
            return (bool)(((val_2 >= (this.baseRequest.<MaxFragmentQueueLength>k__BackingField)) ? 1 : 0) != 0) ? 1 : 0;
        }
        public System.Collections.Generic.List<byte[]> GetStreamedFragments()
        {
            System.Collections.Generic.List<System.Byte[]> val_13;
            var val_16;
            var val_17;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.SyncRoot, lockTaken: ref  val_1);
            if((this.streamedFragments == null) || (this.streamedFragments.Count == 0))
            {
                goto label_2;
            }
            
            val_13 = null;
            val_13 = new System.Collections.Generic.List<System.Byte[]>(collection:  this.streamedFragments);
            this.streamedFragments.Clear();
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_10;
            label_2:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  "GetStreamedFragments - no fragments, returning with null");
            }
            
            val_16 = 0;
            val_17 = 0;
            val_13 = 0;
            goto label_19;
            label_10:
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  System.String.Format(format:  "GetStreamedFragments - returning with {0:N0} fragments", arg0:  null.Count.ToString()));
            }
            
            val_16 = 0;
            val_17 = 0;
            label_19:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SyncRoot);
            }
            
            if(val_16 != 1)
            {
                    if(val_17 == 0)
            {
                    return val_13;
            }
            
                if(145 == 145)
            {
                    return val_13;
            }
            
                return val_13;
            }
            
            if(val_17 != 0)
            {
                    return val_13;
            }
            
            return val_13;
        }
        internal bool HasStreamedFragments()
        {
            var val_4;
            var val_5;
            var val_6;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.SyncRoot, lockTaken: ref  val_1);
            if(this.streamedFragments != null)
            {
                    val_4 = 0;
                val_5 = 0;
                var val_3 = (this.streamedFragments.Count >= (this.baseRequest.<MaxFragmentQueueLength>k__BackingField)) ? 1 : 0;
            }
            else
            {
                    val_4 = 0;
                val_5 = 0;
                val_6 = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SyncRoot);
            }
            
            if(val_4 != 1)
            {
                    return (bool)val_6;
            }
            
            if(val_5 == 0)
            {
                    return (bool)val_6;
            }
            
            return (bool)val_6;
        }
        internal void FinishStreaming()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    this.VerboseLogging(str:  "FinishStreaming");
            }
            
            this.<IsStreamingFinished>k__BackingField = true;
            if(this.cacheStream == null)
            {
                    return;
            }
            
            this.cacheStream.Dispose();
            this.cacheStream = 0;
        }
        private void VerboseLogging(string str)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPResponse", verb:  "\'" + ((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField(((this.baseRequest.<IsRedirected>k__BackingField) == false) ? this.baseRequest.<Uri>k__BackingField : this.baseRequest.<RedirectUri>k__BackingField) + "\' - "("\' - ") + str);
        }
        public void Dispose()
        {
            if(this.cacheStream == null)
            {
                    return;
            }
            
            this.cacheStream.Dispose();
            this.cacheStream = 0;
        }
    
    }

}
