using UnityEngine;

namespace BestHTTP.Caching
{
    public class HTTPCacheFileInfo : IComparable<BestHTTP.Caching.HTTPCacheFileInfo>
    {
        // Fields
        private System.Uri <Uri>k__BackingField;
        private System.DateTime <LastAccess>k__BackingField;
        private int <BodyLength>k__BackingField;
        private string <ETag>k__BackingField;
        private string <LastModified>k__BackingField;
        private System.DateTime <Expires>k__BackingField;
        private long <Age>k__BackingField;
        private long <MaxAge>k__BackingField;
        private System.DateTime <Date>k__BackingField;
        private bool <MustRevalidate>k__BackingField;
        private System.DateTime <Received>k__BackingField;
        private string <ConstructedPath>k__BackingField;
        private ulong <MappedNameIDX>k__BackingField;
        
        // Properties
        internal System.Uri Uri { get; set; }
        internal System.DateTime LastAccess { get; set; }
        public int BodyLength { get; set; }
        private string ETag { get; set; }
        private string LastModified { get; set; }
        private System.DateTime Expires { get; set; }
        private long Age { get; set; }
        private long MaxAge { get; set; }
        private System.DateTime Date { get; set; }
        private bool MustRevalidate { get; set; }
        private System.DateTime Received { get; set; }
        private string ConstructedPath { get; set; }
        internal ulong MappedNameIDX { get; set; }
        
        // Methods
        internal System.Uri get_Uri()
        {
            return (System.Uri)this.<Uri>k__BackingField;
        }
        internal void set_Uri(System.Uri value)
        {
            this.<Uri>k__BackingField = value;
        }
        internal System.DateTime get_LastAccess()
        {
            return (System.DateTime)this.<LastAccess>k__BackingField;
        }
        internal void set_LastAccess(System.DateTime value)
        {
            this.<LastAccess>k__BackingField = value;
        }
        public int get_BodyLength()
        {
            return (int)this.<BodyLength>k__BackingField;
        }
        public void set_BodyLength(int value)
        {
            this.<BodyLength>k__BackingField = value;
        }
        private string get_ETag()
        {
            return (string)this.<ETag>k__BackingField;
        }
        private void set_ETag(string value)
        {
            this.<ETag>k__BackingField = value;
        }
        private string get_LastModified()
        {
            return (string)this.<LastModified>k__BackingField;
        }
        private void set_LastModified(string value)
        {
            this.<LastModified>k__BackingField = value;
        }
        private System.DateTime get_Expires()
        {
            return (System.DateTime)this.<Expires>k__BackingField;
        }
        private void set_Expires(System.DateTime value)
        {
            this.<Expires>k__BackingField = value;
        }
        private long get_Age()
        {
            return (long)this.<Age>k__BackingField;
        }
        private void set_Age(long value)
        {
            this.<Age>k__BackingField = value;
        }
        private long get_MaxAge()
        {
            return (long)this.<MaxAge>k__BackingField;
        }
        private void set_MaxAge(long value)
        {
            this.<MaxAge>k__BackingField = value;
        }
        private System.DateTime get_Date()
        {
            return (System.DateTime)this.<Date>k__BackingField;
        }
        private void set_Date(System.DateTime value)
        {
            this.<Date>k__BackingField = value;
        }
        private bool get_MustRevalidate()
        {
            return (bool)this.<MustRevalidate>k__BackingField;
        }
        private void set_MustRevalidate(bool value)
        {
            this.<MustRevalidate>k__BackingField = value;
        }
        private System.DateTime get_Received()
        {
            return (System.DateTime)this.<Received>k__BackingField;
        }
        private void set_Received(System.DateTime value)
        {
            this.<Received>k__BackingField = value;
        }
        private string get_ConstructedPath()
        {
            return (string)this.<ConstructedPath>k__BackingField;
        }
        private void set_ConstructedPath(string value)
        {
            this.<ConstructedPath>k__BackingField = value;
        }
        internal ulong get_MappedNameIDX()
        {
            return (ulong)this.<MappedNameIDX>k__BackingField;
        }
        internal void set_MappedNameIDX(ulong value)
        {
            this.<MappedNameIDX>k__BackingField = value;
        }
        internal HTTPCacheFileInfo(System.Uri uri)
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
        }
        internal HTTPCacheFileInfo(System.Uri uri, System.DateTime lastAcces, int bodyLength)
        {
            this.<Uri>k__BackingField = uri;
            this.<LastAccess>k__BackingField = lastAcces;
            this.<BodyLength>k__BackingField = bodyLength;
            this.<MaxAge>k__BackingField = 0;
            this.<MappedNameIDX>k__BackingField = BestHTTP.Caching.HTTPCacheService.GetNameIdx();
        }
        internal HTTPCacheFileInfo(System.Uri uri, System.IO.BinaryReader reader, int version)
        {
            int val_7 = version;
            val_1 = new System.Object();
            this.<Uri>k__BackingField = uri;
            System.DateTime val_2 = System.DateTime.FromBinary(dateData:  System.IO.BinaryReader val_1 = reader);
            this.<LastAccess>k__BackingField = val_2;
            this.<BodyLength>k__BackingField = val_1;
            if(val_7 != 1)
            {
                    if(val_7 != 2)
            {
                    return;
            }
            
                this.<MappedNameIDX>k__BackingField = val_1;
            }
            
            this.<ETag>k__BackingField = val_1;
            this.<LastModified>k__BackingField = val_1;
            val_7 = val_1;
            System.DateTime val_3 = System.DateTime.FromBinary(dateData:  val_7);
            this.<Expires>k__BackingField = val_3;
            this.<Age>k__BackingField = val_1;
            this.<MaxAge>k__BackingField = val_1;
            System.DateTime val_4 = System.DateTime.FromBinary(dateData:  val_1);
            this.<Date>k__BackingField = val_4;
            this.<MustRevalidate>k__BackingField = val_1 & 1;
            System.DateTime val_6 = System.DateTime.FromBinary(dateData:  val_1);
            this.<Received>k__BackingField = val_6;
        }
        internal void SaveTo(System.IO.BinaryWriter writer)
        {
            var val_1 = ((this.<MustRevalidate>k__BackingField) == true) ? 1 : 0;
            if(writer != null)
            {
                    return;
            }
        
        }
        public string GetPath()
        {
            if((this.<ConstructedPath>k__BackingField) != null)
            {
                    return val_3;
            }
            
            string val_3 = System.IO.Path.Combine(path1:  BestHTTP.Caching.HTTPCacheService.CacheFolder, path2:  this.<MappedNameIDX>k__BackingField.ToString(format:  "X"));
            this.<ConstructedPath>k__BackingField = val_3;
            return val_3;
        }
        public bool IsExists()
        {
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return false;
            }
            
            return System.IO.File.Exists(path:  this.GetPath());
        }
        internal void Delete()
        {
            var val_13 = this;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  this.GetPath());
            this.Reset();
        }
        private void Reset()
        {
            this.<BodyLength>k__BackingField = 0;
            this.<ETag>k__BackingField = System.String.alignConst;
            System.DateTime val_1 = System.DateTime.FromBinary(dateData:  0);
            this.<Expires>k__BackingField = val_1;
            this.<Age>k__BackingField = ;
            this.<MaxAge>k__BackingField = 18446744073709551615;
            this.<LastModified>k__BackingField = System.String.alignConst;
            System.DateTime val_2 = System.DateTime.FromBinary(dateData:  0);
            this.<Date>k__BackingField = val_2;
            this.<MustRevalidate>k__BackingField = false;
            System.DateTime val_3 = System.DateTime.FromBinary(dateData:  0);
            this.<Received>k__BackingField = val_3;
        }
        private void SetUpCachingValues(BestHTTP.HTTPResponse response)
        {
            string val_27;
            if(response != null)
            {
                    response.CacheFileInfo = this;
            }
            else
            {
                    0.CacheFileInfo = this;
            }
            
            this.<ETag>k__BackingField = BestHTTP.Extensions.Extensions.ToStrOrEmpty(str:  response.GetFirstHeaderValue(name:  "ETag"));
            System.DateTime val_4 = System.DateTime.FromBinary(dateData:  0);
            System.DateTime val_5 = BestHTTP.Extensions.Extensions.ToDateTime(str:  response.GetFirstHeaderValue(name:  "Expires"), defaultValue:  new System.DateTime() {dateData = val_4.dateData});
            this.<Expires>k__BackingField = val_5;
            if(response != null)
            {
                    this.<LastModified>k__BackingField = BestHTTP.Extensions.Extensions.ToStrOrEmpty(str:  response.GetFirstHeaderValue(name:  "Last-Modified"));
            }
            else
            {
                    this.<LastModified>k__BackingField = BestHTTP.Extensions.Extensions.ToStrOrEmpty(str:  0.GetFirstHeaderValue(name:  "Last-Modified"));
            }
            
            this.<Age>k__BackingField = BestHTTP.Extensions.Extensions.ToInt64(str:  response.GetFirstHeaderValue(name:  "Age"), defaultValue:  0);
            if(response != null)
            {
                    val_27 = response.GetFirstHeaderValue(name:  "Date");
                System.DateTime val_13 = System.DateTime.FromBinary(dateData:  0);
                System.DateTime val_14 = BestHTTP.Extensions.Extensions.ToDateTime(str:  val_27, defaultValue:  new System.DateTime() {dateData = val_13.dateData});
                this.<Date>k__BackingField = val_14;
            }
            else
            {
                    val_27 = 0.GetFirstHeaderValue(name:  "Date");
                System.DateTime val_16 = System.DateTime.FromBinary(dateData:  0);
                System.DateTime val_17 = BestHTTP.Extensions.Extensions.ToDateTime(str:  val_27, defaultValue:  new System.DateTime() {dateData = val_16.dateData});
                this.<Date>k__BackingField = val_17;
            }
            
            string val_18 = response.GetFirstHeaderValue(name:  "cache-control");
            if((System.String.IsNullOrEmpty(value:  val_18)) != true)
            {
                    val_27 = BestHTTP.Extensions.Extensions.FindOption(str:  val_18, option:  "max-age");
                if(val_27 != null)
            {
                    val_27 = val_27[1];
                if((System.Double.TryParse(s:  val_27, result: out  double val_21 = 1.28824384138708E-231)) != false)
            {
                    this.<MaxAge>k__BackingField = (long)0;
            }
            
            }
            
                this.<MustRevalidate>k__BackingField = val_18.ToLower().Contains(value:  "must-revalidate");
            }
            
            System.DateTime val_26 = System.DateTime.UtcNow;
            this.<Received>k__BackingField = val_26;
        }
        internal bool WillExpireInTheFuture()
        {
            if(this.IsExists() == false)
            {
                goto label_1;
            }
            
            bool val_12 = this.<MustRevalidate>k__BackingField;
            val_12 = val_12 + 3;
            var val_13 = ~val_12;
            val_13 = val_13 & 3;
            if(val_13 == 0)
            {
                goto label_2;
            }
            
            label_1:
            var val_14 = 0;
            label_11:
            val_14 = val_14 & 1;
            return (bool)val_14;
            label_2:
            if((this.<MaxAge>k__BackingField) == 1)
            {
                goto label_3;
            }
            
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.<Received>k__BackingField}, d2:  new System.DateTime() {dateData = this.<Date>k__BackingField});
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.dateData}, d2:  new System.DateTime() {dateData = this.<Date>k__BackingField});
            long val_15 = (long)val_7._ticks.TotalSeconds;
            val_15 = (System.Math.Max(val1:  System.Math.Max(val1:  0, val2:  (long)val_2._ticks.TotalSeconds), val2:  this.<Age>k__BackingField)) + val_15;
            var val_9 = (val_15 < (this.<MaxAge>k__BackingField)) ? 1 : 0;
            goto label_11;
            label_3:
            System.DateTime val_10 = System.DateTime.UtcNow;
            bool val_11 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = this.<Expires>k__BackingField}, t2:  new System.DateTime() {dateData = val_10.dateData});
            goto label_11;
        }
        internal void SetUpRevalidationHeaders(BestHTTP.HTTPRequest request)
        {
            if(this.IsExists() == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.<ETag>k__BackingField)) != true)
            {
                    request.AddHeader(name:  "If-None-Match", value:  this.<ETag>k__BackingField);
            }
            
            if((System.String.IsNullOrEmpty(value:  this.<LastModified>k__BackingField)) != false)
            {
                    return;
            }
            
            request.AddHeader(name:  "If-Modified-Since", value:  this.<LastModified>k__BackingField);
        }
        public System.IO.Stream GetBodyStream(out int length)
        {
            int val_5;
            var val_6;
            val_5 = 1152921553856597344;
            if(this.IsExists() != false)
            {
                    length = this.<BodyLength>k__BackingField;
                System.DateTime val_2 = System.DateTime.UtcNow;
                this.<LastAccess>k__BackingField = val_2;
                System.IO.FileStream val_4 = null;
                val_6 = val_4;
                val_4 = new System.IO.FileStream(path:  this.GetPath(), mode:  3, access:  1, share:  1);
                val_5 = length;
                if(val_6 != null)
            {
                    return (System.IO.Stream)val_6;
            }
            
                return (System.IO.Stream)val_6;
            }
            
            val_6 = 0;
            length = 0;
            return (System.IO.Stream)val_6;
        }
        internal BestHTTP.HTTPResponse ReadResponseTo(BestHTTP.HTTPRequest request)
        {
            System.IO.Stream val_9;
            BestHTTP.Caching.HTTPCacheFileInfo val_10;
            BestHTTP.HTTPResponse val_11;
            val_10 = this;
            if(this.IsExists() == false)
            {
                goto label_1;
            }
            
            System.DateTime val_2 = System.DateTime.UtcNow;
            this.<LastAccess>k__BackingField = val_2;
            System.IO.FileStream val_4 = null;
            val_9 = val_4;
            val_4 = new System.IO.FileStream(path:  this.GetPath(), mode:  3, access:  1, share:  1);
            val_11 = new BestHTTP.HTTPResponse();
            val_11 = new BestHTTP.HTTPResponse(request:  request, stream:  val_4, isStreamed:  request.UseStreaming, isFromCache:  true);
            new BestHTTP.HTTPResponse().CacheFileInfo = this;
            val_10 = 0;
            if(val_9 == null)
            {
                goto label_21;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_11;
            label_1:
            val_11 = 0;
            return val_11;
            label_11:
            val_4.Dispose();
            label_21:
            if(0 != 1)
            {
                    return val_11;
            }
            
            if(val_10 == 0)
            {
                    return val_11;
            }
            
            return val_11;
        }
        internal void Store(BestHTTP.HTTPResponse response)
        {
            var val_13;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            string val_2 = this.GetPath();
            val_26 = val_2.Length;
            if(val_26 > BestHTTP.HTTPManager.MaxPathLength)
            {
                    return;
            }
            
            if((System.IO.File.Exists(path:  val_2)) != false)
            {
                    this.Delete();
            }
            
            System.IO.FileStream val_6 = new System.IO.FileStream(path:  val_2, mode:  2);
            object[] val_7 = new object[2];
            val_7[0] = response.StatusCode;
            val_7[1] = response.Message;
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_6, format:  "HTTP/1.1 {0} {1}", values:  val_7);
            Dictionary.Enumerator<TKey, TValue> val_11 = response.Headers.GetEnumerator();
            goto label_22;
            label_36:
            ConfiguredValueTaskAwaiter val_15 = val_13.GetAwaiter();
            val_27 = 0;
            goto label_23;
            label_35:
            object[] val_16 = new object[2];
            val_16[0] = val_15._value._obj.丐丏七丌丕丗业且上();
            val_16[1] = val_15._value._obj.Item[0];
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_6, format:  "{0}: {1}", values:  val_16);
            val_27 = 1;
            label_23:
            if(val_27 < val_15._value._obj.Count)
            {
                goto label_35;
            }
            
            label_22:
            if((2005486688 & 1) != 0)
            {
                goto label_36;
            }
            
            val_28 = 0;
            val_29 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (209 == 209))
            {
                    val_28 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_6);
            System.Byte[] val_20 = response.Data;
            System.Byte[] val_21 = response.Data;
            val_30 = 1;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_6.Dispose();
            if(val_30 == 1)
            {
                goto label_72;
            }
            
            if((val_29 == 0) || (248 == 248))
            {
                goto label_80;
            }
            
            label_79:
            label_80:
            val_26 = response.Data;
            this.<BodyLength>k__BackingField = val_23.Length;
            System.DateTime val_24 = System.DateTime.UtcNow;
            this.<LastAccess>k__BackingField = val_24;
            this.SetUpCachingValues(response:  response);
            return;
            label_72:
            if(val_29 != 0)
            {
                goto label_79;
            }
            
            goto label_80;
        }
        internal System.IO.Stream GetSaveStream(BestHTTP.HTTPResponse response)
        {
            var val_14;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            string val_37;
            val_31 = this;
            val_32 = 0;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return (System.IO.Stream)val_32;
            }
            
            System.DateTime val_2 = System.DateTime.UtcNow;
            this.<LastAccess>k__BackingField = val_2;
            string val_3 = this.GetPath();
            if((System.IO.File.Exists(path:  val_3)) != false)
            {
                    this.Delete();
            }
            
            val_32 = 0;
            if(val_3.Length > BestHTTP.HTTPManager.MaxPathLength)
            {
                    return (System.IO.Stream)val_32;
            }
            
            System.IO.FileStream val_7 = new System.IO.FileStream(path:  val_3, mode:  2);
            object[] val_8 = new object[2];
            val_8[0] = response.StatusCode;
            val_8[1] = response.Message;
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_7, format:  "HTTP/1.1 {0} {1}", values:  val_8);
            Dictionary.Enumerator<TKey, TValue> val_12 = response.Headers.GetEnumerator();
            goto label_24;
            label_38:
            ConfiguredValueTaskAwaiter val_16 = val_14.GetAwaiter();
            val_33 = 0;
            goto label_25;
            label_37:
            object[] val_17 = new object[2];
            val_17[0] = val_16._value._obj.丐丏七丌丕丗业且上();
            val_17[1] = val_16._value._obj.Item[0];
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_7, format:  "{0}: {1}", values:  val_17);
            val_33 = 1;
            label_25:
            if(val_33 < val_16._value._obj.Count)
            {
                goto label_37;
            }
            
            label_24:
            if((2005815872 & 1) != 0)
            {
                goto label_38;
            }
            
            val_34 = 1152921504644227072;
            val_35 = 0;
            val_36 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (222 == 222))
            {
                    val_35 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_36 = 0;
            }
            
            }
            
            BestHTTP.Extensions.Extensions.WriteLine(fs:  val_7);
            val_37 = 1;
            if(val_7 != null)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_7.Dispose();
            }
            
            if(val_37 == 1)
            {
                goto label_71;
            }
            
            if((val_36 == 0) || (240 == 240))
            {
                goto label_83;
            }
            
            label_82:
            label_83:
            if(response.IsFromCache != false)
            {
                    if((response.Headers.ContainsKey(key:  "content-length")) != true)
            {
                    System.Collections.Generic.List<System.String> val_26 = new System.Collections.Generic.List<System.String>();
                val_37 = this.<BodyLength>k__BackingField.ToString();
                val_26.Add(item:  val_37);
                response.Headers.Add(key:  "content-length", value:  val_26);
            }
            
            }
            
            this.SetUpCachingValues(response:  response);
            val_31 = this.GetPath();
            System.IO.FileStream val_29 = null;
            val_32 = val_29;
            val_29 = new System.IO.FileStream(path:  val_31, mode:  6);
            return (System.IO.Stream)val_32;
            label_71:
            if(val_36 != 0)
            {
                goto label_82;
            }
            
            goto label_83;
        }
        public int CompareTo(BestHTTP.Caching.HTTPCacheFileInfo other)
        {
            if(other != null)
            {
                    return 2005997672;
            }
            
            return 2005997672;
        }
    
    }

}
