using UnityEngine;

namespace BestHTTP
{
    internal sealed class HTTPConnection : ConnectionBase
    {
        // Fields
        private BestHTTP.PlatformSupport.TcpClient.General.TcpClient Client;
        private System.IO.Stream Stream;
        private BestHTTP.KeepAliveHeader KeepAlive;
        
        // Properties
        public override bool IsRemovable { get; }
        
        // Methods
        public override bool get_IsRemovable()
        {
            long val_7;
            var val_8;
            val_7 = this;
            if(this.IsRemovable == false)
            {
                goto label_1;
            }
            
            label_10:
            val_8 = 1;
            return (bool)val_8;
            label_1:
            if((this.IsFree == false) || (this.KeepAlive == null))
            {
                goto label_4;
            }
            
            System.DateTime val_3 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime());
            val_7 = val_4._ticks;
            System.TimeSpan val_5 = this.KeepAlive.TimeOut;
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_7}, t2:  new System.TimeSpan() {_ticks = val_5._ticks})) == true)
            {
                goto label_10;
            }
            
            label_4:
            val_8 = 0;
            return (bool)val_8;
        }
        internal HTTPConnection(string serverAddress)
        {
        
        }
        protected override void ThreadFunc(object param)
        {
            var val_137;
            System.MissingFieldException val_138;
            var val_139;
            object val_140;
            var val_141;
            System.Exception val_142;
            string val_143;
            var val_144;
            var val_147;
            int val_148;
            var val_150;
            BestHTTP.Logger.ILogger val_151;
            BestHTTP.KeepAliveHeader val_153;
            var val_154;
            var val_155;
            var val_156;
            var val_157;
            var val_158;
            var val_159;
            BestHTTP.HTTPRequestStates val_160;
            if(this.HasProxy != true)
            {
                    BestHTTP.HTTPRequest val_2 = this.CurrentRequest;
                if((val_2.<Proxy>k__BackingField) != null)
            {
                    BestHTTP.HTTPRequest val_3 = this.CurrentRequest;
                this.Proxy = val_3.<Proxy>k__BackingField;
            }
            
            }
            
            if(this.TryLoadAllFromCache() == false)
            {
                goto label_5;
            }
            
            val_137 = 0;
            val_138 = 0;
            val_139 = 0;
            goto label_290;
            label_5:
            if(this.Client != null)
            {
                    if(this.Client.IsConnected() != true)
            {
                    this.Close();
            }
            
            }
            
            val_140 = 0;
            val_137 = 0;
            val_141 = 0;
            val_142 = 0;
            label_150:
            val_139 = 0;
            if(val_137 == 1)
            {
                    this.Close();
                System.Threading.Thread.Sleep(millisecondsTimeout:  100);
            }
            
            BestHTTP.HTTPRequest val_6 = this.CurrentRequest;
            this.LastProcessedUri = ((val_6.<IsRedirected>k__BackingField) == false) ? val_6.<Uri>k__BackingField : val_6.<RedirectUri>k__BackingField;
            this.Connect();
            if(this.State == 7)
            {
                goto label_11;
            }
            
            BestHTTP.HTTPRequest val_9 = this.CurrentRequest;
            if(val_9.disableCache != true)
            {
                    BestHTTP.Caching.HTTPCacheService.SetHeaders(request:  this.CurrentRequest);
            }
            
            BestHTTP.HTTPRequest val_11 = this.CurrentRequest;
            this.Client.NoDelay = ((val_11.<TryToMinimizeTCPLatency>k__BackingField) == true) ? 1 : 0;
            this.CurrentRequest.SendOutTo(stream:  this.Stream);
            bool val_17 = this.Receive();
            if(this.State == 8)
            {
                goto label_291;
            }
            
            BestHTTP.HTTPConnectionStates val_19 = this.State;
            if(val_19 == 7)
            {
                goto label_291;
            }
            
            if(((val_142 | ((val_19 == 7) ? (val_140) : (val_17))) & 1) != 0)
            {
                    val_137 = 0;
            }
            else
            {
                    BestHTTP.HTTPRequest val_22 = this.CurrentRequest;
                var val_23 = ((val_22.<DisableRetry>k__BackingField) == false) ? 1 : 0;
                val_137 = (val_22.<DisableRetry>k__BackingField) ^ 1;
            }
            
            val_143 = this.CurrentRequest;
            if((val_24.<Response>k__BackingField) == null)
            {
                goto label_37;
            }
            
            BestHTTP.HTTPRequest val_25 = this.CurrentRequest;
            if((val_25.<IsCookiesEnabled>k__BackingField) != false)
            {
                    BestHTTP.HTTPRequest val_26 = this.CurrentRequest;
                BestHTTP.Cookies.CookieJar.Set(response:  val_26.<Response>k__BackingField);
            }
            
            BestHTTP.HTTPRequest val_27 = this.CurrentRequest;
            int val_137 = val_27.<Response>k__BackingField.<StatusCode>k__BackingField;
            if(val_137 <= 308)
            {
                goto label_45;
            }
            
            if(val_137 == 407)
            {
                goto label_46;
            }
            
            if(val_137 != 401)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_28 = this.CurrentRequest;
            val_143 = BestHTTP.Authentication.DigestStore.FindBest(authHeaders:  val_28.<Response>k__BackingField.GetHeaderValues(name:  "www-authenticate"));
            if((System.String.IsNullOrEmpty(value:  val_143)) == true)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_32 = this.CurrentRequest;
            BestHTTP.Authentication.Digest val_34 = BestHTTP.Authentication.DigestStore.GetOrCreate(uri:  ((val_32.<IsRedirected>k__BackingField) == false) ? val_32.<Uri>k__BackingField : val_32.<RedirectUri>k__BackingField);
            val_34.ParseChallange(header:  val_143);
            val_143 = this.CurrentRequest;
            if((val_35.<Credentials>k__BackingField) == null)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_36 = this.CurrentRequest;
            val_143 = mem[val_36.<IsRedirected>k__BackingField == false ? val_36.<Uri>k__BackingField : val_36.<RedirectUri>k__BackingField];
            val_143 = ((val_36.<IsRedirected>k__BackingField) == false) ? val_36.<Uri>k__BackingField : val_36.<RedirectUri>k__BackingField;
            if((val_34.IsUriProtected(uri:  val_143)) == false)
            {
                goto label_130;
            }
            
            val_143 = this.CurrentRequest;
            if((val_143.HasHeader(name:  "Authorization")) != false)
            {
                    if(val_34.Stale == false)
            {
                goto label_130;
            }
            
            }
            
            val_137 = 2;
            goto label_130;
            label_37:
            val_140 = val_17;
            if(val_137 == true)
            {
                goto label_150;
            }
            
            goto label_151;
            label_45:
            val_137 = val_137 - 301;
            if(val_137 > 7)
            {
                goto label_130;
            }
            
            val_137 = 1 << val_137;
            val_137 = val_137 & 195;
            if(val_137 == 0)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_42 = this.CurrentRequest;
            val_143 = val_42.<RedirectCount>k__BackingField;
            BestHTTP.HTTPRequest val_43 = this.CurrentRequest;
            if(val_143 >= (val_43.<MaxRedirects>k__BackingField))
            {
                goto label_130;
            }
            
            if(this.CurrentRequest == null)
            {
                goto label_74;
            }
            
            val_148 = val_44.<RedirectCount>k__BackingField;
            goto label_75;
            label_46:
            BestHTTP.HTTPRequest val_45 = this.CurrentRequest;
            if((val_45.<Proxy>k__BackingField) == null)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_46 = this.CurrentRequest;
            val_143 = BestHTTP.Authentication.DigestStore.FindBest(authHeaders:  val_46.<Response>k__BackingField.GetHeaderValues(name:  "proxy-authenticate"));
            if((System.String.IsNullOrEmpty(value:  val_143)) == true)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_50 = this.CurrentRequest;
            BestHTTP.Authentication.Digest val_51 = BestHTTP.Authentication.DigestStore.GetOrCreate(uri:  val_50.<Proxy>k__BackingField.<Address>k__BackingField);
            val_51.ParseChallange(header:  val_143);
            BestHTTP.HTTPRequest val_52 = this.CurrentRequest;
            val_143 = val_52.<Proxy>k__BackingField;
            if((val_52.<Proxy>k__BackingField.<Credentials>k__BackingField) == null)
            {
                goto label_130;
            }
            
            BestHTTP.HTTPRequest val_53 = this.CurrentRequest;
            val_143 = val_53.<Proxy>k__BackingField.<Address>k__BackingField;
            if((val_51.IsUriProtected(uri:  val_143)) == false)
            {
                goto label_130;
            }
            
            val_143 = this.CurrentRequest;
            if((val_143.HasHeader(name:  "Proxy-Authorization")) != false)
            {
                    if(val_51.Stale == false)
            {
                goto label_130;
            }
            
            }
            
            val_137 = 3;
            goto label_130;
            label_74:
            val_148 = 130653168;
            val_147 = 184;
            label_75:
            mem[184] = 130653169;
            BestHTTP.HTTPRequest val_58 = this.CurrentRequest;
            string val_59 = val_58.<Response>k__BackingField.GetFirstHeaderValue(name:  "location");
            if((System.String.IsNullOrEmpty(value:  val_59)) == true)
            {
                goto label_102;
            }
            
            System.Uri val_61 = this.GetRedirectUri(location:  val_59);
            var val_138 = 0;
            val_138 = val_138 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                goto label_110;
            }
            
            BestHTTP.Logger.ILogger val_66 = BestHTTP.HTTPManager.Logger;
            BestHTTP.HTTPRequest val_67 = this.CurrentRequest;
            var val_142 = val_66;
            if((val_66 + 286) == 0)
            {
                goto label_119;
            }
            
            var val_139 = val_66 + 176;
            var val_140 = 0;
            val_139 = val_139 + 8;
            label_118:
            if(((val_66 + 176 + 8) + -8) == null)
            {
                goto label_117;
            }
            
            val_140 = val_140 + 1;
            val_139 = val_139 + 16;
            if(val_140 < (val_66 + 286))
            {
                goto label_118;
            }
            
            goto label_119;
            label_117:
            var val_141 = val_139;
            val_141 = val_141 + 12;
            val_142 = val_142 + val_141;
            val_150 = val_142 + 296;
            label_119:
            val_66.Verbose(division:  "HTTPConnection", verb:  System.String.Format(format:  "{0} - Redirected to Location: \'{1}\' redirectUri: \'{1}\'", arg0:  ((val_67.<IsRedirected>k__BackingField) == false) ? val_67.<Uri>k__BackingField : val_67.<RedirectUri>k__BackingField, arg1:  val_59, arg2:  val_61));
            label_110:
            if(val_70.onBeforeRedirection != null)
            {
                    if((val_70.onBeforeRedirection.Invoke(originalRequest:  this.CurrentRequest, response:  val_70.<Response>k__BackingField, redirectUri:  val_61)) == false)
            {
                goto label_122;
            }
            
            }
            
            bool val_73 = this.CurrentRequest.RemoveHeader(name:  "Host");
            BestHTTP.HTTPRequest val_75 = this.CurrentRequest;
            this.CurrentRequest.SetHeader(name:  "Referer", value:  ((val_75.<IsRedirected>k__BackingField) == false) ? val_75.<Uri>k__BackingField : val_75.<RedirectUri>k__BackingField);
            val_143 = this.CurrentRequest;
            val_77.<RedirectUri>k__BackingField = val_61;
            BestHTTP.HTTPRequest val_78 = this.CurrentRequest;
            val_78.<Response>k__BackingField = 0;
            val_141 = 1;
            if(this.CurrentRequest == null)
            {
                    val_141 = val_141;
            }
            
            val_79.<IsRedirected>k__BackingField = true;
            goto label_130;
            label_122:
            val_151 = BestHTTP.HTTPManager.Logger;
            if(val_151 == null)
            {
                    val_151 = val_151;
            }
            
            val_143 = "OnBeforeRedirection returned False";
            var val_143 = 0;
            val_143 = val_143 + 1;
            val_151 = val_151;
            val_151.Information(division:  "HTTPConnection", info:  val_143);
            label_130:
            var val_82 = val_141 & 1;
            this.TryStoreInCache();
            BestHTTP.HTTPRequest val_83 = this.CurrentRequest;
            if((val_83.<Response>k__BackingField) == null)
            {
                goto label_139;
            }
            
            BestHTTP.HTTPRequest val_84 = this.CurrentRequest;
            if((val_84.<Response>k__BackingField.<IsClosedManually>k__BackingField) == true)
            {
                goto label_160;
            }
            
            label_139:
            BestHTTP.HTTPRequest val_85 = this.CurrentRequest;
            if((val_85.<Response>k__BackingField) != null)
            {
                    BestHTTP.HTTPRequest val_86 = this.CurrentRequest;
                val_143 = val_86.<Response>k__BackingField.HasHeaderWithValue(headerName:  "connection", value:  "close");
            }
            else
            {
                    val_143 = 1;
            }
            
            BestHTTP.HTTPRequest val_88 = this.CurrentRequest;
            bool val_144 = val_88.isKeepAlive;
            val_144 = val_144 ^ 1;
            val_144 = val_144 & 255;
            val_144 = val_143 | val_144;
            if(val_144 == false)
            {
                goto label_149;
            }
            
            this.Close();
            label_160:
            if(val_137 == true)
            {
                goto label_150;
            }
            
            goto label_151;
            label_149:
            BestHTTP.HTTPRequest val_89 = this.CurrentRequest;
            if((val_89.<Response>k__BackingField) == null)
            {
                goto label_160;
            }
            
            BestHTTP.HTTPRequest val_90 = this.CurrentRequest;
            System.Collections.Generic.List<System.String> val_91 = val_90.<Response>k__BackingField.GetHeaderValues(name:  "keep-alive");
            if((val_91 == null) || (val_91.Count < 1))
            {
                goto label_160;
            }
            
            val_153 = this.KeepAlive;
            if(val_153 == null)
            {
                    val_153 = new BestHTTP.KeepAliveHeader();
                val_153 = new BestHTTP.KeepAliveHeader();
                this.KeepAlive = val_153;
            }
            
            new BestHTTP.KeepAliveHeader().Parse(headerValues:  val_91);
            goto label_160;
            label_151:
            val_138 = 0;
            val_139 = val_141 & 1;
            goto label_290;
            label_11:
            new System.Exception() = new System.Exception(message:  "AbortRequested");
            mem[8] = null;
            label_291:
            new System.Exception() = new System.Exception(message:  "AbortRequested");
            label_102:
            BestHTTP.HTTPRequest val_97 = this.CurrentRequest;
            new System.MissingFieldException() = new System.MissingFieldException(message:  System.String.Format(format:  "Got redirect status({0}) without \'location\' header!", arg0:  val_97.<Response>k__BackingField.<StatusCode>k__BackingField.ToString()));
            val_143 = 0;
            val_144 = new System.MissingFieldException();
            if(val_143 != 1)
            {
                goto label_303;
            }
            
            if((null & 1) == 0)
            {
                goto label_265;
            }
            
            val_154 = 1;
            goto label_266;
            label_265:
            if((null & 1) == 0)
            {
                goto label_267;
            }
            
            val_154 = 2;
            label_266:
            var val_101 = val_154 & 3;
            if(val_101 == 1)
            {
                goto label_268;
            }
            
            if(val_101 != 2)
            {
                    return;
            }
            
            if(this.CurrentRequest == null)
            {
                goto label_270;
            }
            
            BestHTTP.HTTPRequest val_103 = this.CurrentRequest;
            if(val_103.useStreaming != false)
            {
                    BestHTTP.HTTPRequest val_104 = this.CurrentRequest;
                bool val_106 = BestHTTP.Caching.HTTPCacheService.DeleteEntity(uri:  ((val_104.<IsRedirected>k__BackingField) == false) ? val_104.<Uri>k__BackingField : val_104.<RedirectUri>k__BackingField, removeFromLibrary:  true);
            }
            
            BestHTTP.HTTPRequest val_107 = this.CurrentRequest;
            val_107.<Response>k__BackingField = 0;
            BestHTTP.HTTPConnectionStates val_108 = this.State;
            if(val_108 == 7)
            {
                goto label_277;
            }
            
            if(val_108 == 8)
            {
                goto label_278;
            }
            
            if(val_108 != 9)
            {
                goto label_279;
            }
            
            label_277:
            if(this.CurrentRequest == null)
            {
                    val_155 = 0;
            }
            
            val_156 = 5;
            goto label_287;
            label_268:
            BestHTTP.HTTPRequest val_110 = this.CurrentRequest;
            val_110.<Response>k__BackingField = 0;
            BestHTTP.HTTPRequest val_111 = this.CurrentRequest;
            val_111.<Exception>k__BackingField = null;
            BestHTTP.HTTPRequest val_112 = this.CurrentRequest;
            val_112.<State>k__BackingField = 6;
            this.Close();
            goto label_285;
            label_278:
            if(this.CurrentRequest == null)
            {
                    val_155 = 0;
            }
            
            val_156 = 7;
            goto label_287;
            label_279:
            BestHTTP.HTTPRequest val_114 = this.CurrentRequest;
            val_114.<Exception>k__BackingField = null;
            if(this.CurrentRequest == null)
            {
                    val_155 = 0;
            }
            
            val_156 = 4;
            label_287:
            mem[180] = val_156;
            label_270:
            this.Close();
            label_285:
            val_137 = 0;
            val_138 = 0;
            goto label_290;
            label_267:
            mem[8] = null;
            goto label_291;
            label_303:
            if( != 1)
            {
                goto label_369;
            }
            
            val_138 = mem[8];
            val_137 = 0;
            label_290:
            if(this.CurrentRequest == null)
            {
                goto label_305;
            }
            
            val_157 = null;
            val_157 = null;
            val_143 = BestHTTP.HTTPManager.Locker;
            bool val_117 = false;
            System.Threading.Monitor.Enter(obj:  val_143, lockTaken: ref  val_117);
            if(this.CurrentRequest == null)
            {
                goto label_313;
            }
            
            BestHTTP.HTTPRequest val_119 = this.CurrentRequest;
            if((val_119.<Response>k__BackingField) == null)
            {
                goto label_313;
            }
            
            BestHTTP.HTTPRequest val_120 = this.CurrentRequest;
            if((val_120.<Response>k__BackingField.<IsUpgraded>k__BackingField) == false)
            {
                goto label_313;
            }
            
            this.State = 3;
            goto label_314;
            label_313:
            if((val_139 & 1) != 0)
            {
                    val_158 = 2;
            }
            
            this.State = (this.Client == 0) ? 9 : 5;
            label_314:
            BestHTTP.HTTPRequest val_122 = this.CurrentRequest;
            if((val_122.<State>k__BackingField) == 2)
            {
                    if(this.State != 9)
            {
                    if(this.State != 5)
            {
                goto label_321;
            }
            
            }
            
                BestHTTP.HTTPRequest val_125 = this.CurrentRequest;
                if((val_125.<Response>k__BackingField) != null)
            {
                    val_159 = this.CurrentRequest;
                val_160 = 3;
            }
            else
            {
                    BestHTTP.HTTPRequest val_127 = this.CurrentRequest;
                BestHTTP.HTTPRequest val_128 = this.CurrentRequest;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_140 = this.State.ToString();
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_142 = new System.Exception();
                val_142 = new System.Exception(message:  System.String.Format(format:  "Remote server closed the connection before sending response header! Previous request state: {0}. Connection state: {1}", arg0:  val_128.<State>k__BackingField.ToString(), arg1:  val_140));
                val_127.<Exception>k__BackingField = val_142;
                val_159 = this.CurrentRequest;
                val_160 = 4;
            }
            
                val_134.<State>k__BackingField = val_160;
            }
            
            label_321:
            BestHTTP.HTTPRequest val_135 = this.CurrentRequest;
            if((val_135.<State>k__BackingField) == 6)
            {
                    this.State = mem[8];
            }
            
            System.DateTime val_136 = System.DateTime.UtcNow;
            mem[1152921553610174456] = val_136.dateData;
            this.RecycleNow();
            val_137 = val_137 + 1;
            mem2[0] = 1831;
            if(val_117 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_143);
            }
            
            if((val_137 != 1) && ((1152921553610162208 + ((val_137 + 1)) << 2) == 1831))
            {
                    val_137 = val_137 - 1;
            }
            else
            {
                    if(val_138 != 0)
            {
                    val_138 = 0;
            }
            
            }
            
            BestHTTP.Caching.HTTPCacheService.SaveLibrary();
            BestHTTP.Cookies.CookieJar.Persist();
            label_305:
            if(val_137 != 1)
            {
                    if(val_138 == 0)
            {
                    return;
            }
            
                if((1152921553610162208 + ((val_137 + 1)) << 2) == 1842)
            {
                    return;
            }
            
                return;
            }
            
            if(val_138 != 0)
            {
                    return;
            }
            
            return;
            label_369:
        }
        private void Connect()
        {
            object val_173;
            System.Uri val_174;
            BestHTTP.PlatformSupport.TcpClient.General.TcpClient val_175;
            var val_176;
            int val_177;
            string val_180;
            object val_181;
            string val_182;
            string val_183;
            var val_185;
            string val_186;
            var val_187;
            var val_189;
            string val_192;
            string val_194;
            var val_196;
            var val_198;
            BestHTTP.Authentication.Credentials val_199;
            string val_200;
            var val_204;
            var val_205;
            System.Collections.Generic.List<System.String> val_208;
            Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer val_209;
            val_173 = this;
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            if(this.CurrentRequest == null)
            {
                goto label_2;
            }
            
            if((val_1.<Proxy>k__BackingField) == null)
            {
                goto label_3;
            }
            
            label_6:
            val_174 = val_2.<Proxy>k__BackingField.<Address>k__BackingField;
            goto label_5;
            label_2:
            if((val_1.<Proxy>k__BackingField) != null)
            {
                goto label_6;
            }
            
            label_3:
            var val_3 = ((val_2.<IsRedirected>k__BackingField) == false) ? val_2.<Uri>k__BackingField : val_2.<RedirectUri>k__BackingField;
            label_5:
            val_175 = this.Client;
            if(val_175 == null)
            {
                    BestHTTP.PlatformSupport.TcpClient.General.TcpClient val_4 = null;
                val_175 = val_4;
                val_4 = new BestHTTP.PlatformSupport.TcpClient.General.TcpClient();
                this.Client = val_175;
            }
            
            if(val_4.Connected == false)
            {
                goto label_9;
            }
            
            val_176 = BestHTTP.HTTPManager.Logger;
            val_177 = 1152921505557803008;
            var val_179 = 0;
            val_179 = val_179 + 1;
            goto label_16;
            label_9:
            BestHTTP.HTTPRequest val_7 = this.CurrentRequest;
            this.Client.ConnectTimeout = new System.TimeSpan() {_ticks = val_7.<ConnectTimeout>k__BackingField};
            var val_180 = 0;
            val_180 = val_180 + 1;
            goto label_25;
            label_16:
            if((val_176.Level & 255) > 1)
            {
                goto label_94;
            }
            
            val_176 = BestHTTP.HTTPManager.Logger;
            if(val_3 == 0)
            {
                goto label_29;
            }
            
            val_180 = val_3.Host;
            goto label_30;
            label_25:
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                goto label_31;
            }
            
            BestHTTP.HTTPRequest val_18 = this.CurrentRequest;
            if(val_3 == 0)
            {
                goto label_36;
            }
            
            val_181 = val_3.Host;
            goto label_37;
            label_29:
            val_180 = 0.Host;
            label_30:
            val_182 = val_3.Port.ToString();
            val_183 = "Already connected to " + val_180 + ":"(":") + val_182;
            val_185 = null;
            val_186 = "HTTPConnection";
            var val_181 = 0;
            val_187 = 1152921505557839880;
            val_181 = val_181 + 1;
            goto label_103;
            label_36:
            val_181 = 0.Host;
            label_37:
            var val_182 = 0;
            val_182 = val_182 + 1;
            BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPConnection", verb:  System.String.Format(format:  "\'{0}\' - Connecting to {1}:{2}", arg0:  ((val_18.<IsRedirected>k__BackingField) == false) ? val_18.<Uri>k__BackingField : val_18.<RedirectUri>k__BackingField, arg1:  val_181, arg2:  val_3.Port.ToString()));
            label_31:
            val_189 = null;
            val_189 = null;
            this.Client.SendBufferSize = BestHTTP.HTTPManager.SendBufferSize;
            this.Client.ReceiveBufferSize = BestHTTP.HTTPManager.ReceiveBufferSize;
            var val_183 = 0;
            val_183 = val_183 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    object[] val_35 = new object[4];
                BestHTTP.HTTPRequest val_36 = this.CurrentRequest;
                val_35[0] = ((val_36.<IsRedirected>k__BackingField) == false) ? val_36.<Uri>k__BackingField : val_36.<RedirectUri>k__BackingField;
                val_35[1] = this.Client.SendBufferSize.ToString();
                val_35[2] = this.Client.ReceiveBufferSize.ToString();
                val_35[3] = this.Client.Client.Blocking.ToString();
                var val_184 = 0;
                val_184 = val_184 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPConnection", verb:  System.String.Format(format:  "\'{0}\' - Buffer sizes - Send: {1} Receive: {2} Blocking: {3}", args:  val_35));
            }
            
            if(val_3 != 0)
            {
                    val_192 = val_3.Host;
            }
            else
            {
                    val_192 = 0.Host;
            }
            
            val_177 = val_3.Port;
            this.Client.Connect(hostname:  val_192, port:  val_177);
            val_176 = BestHTTP.HTTPManager.Logger;
            var val_185 = 0;
            val_185 = val_185 + 1;
            if((val_176.Level & 255) > 1)
            {
                goto label_94;
            }
            
            val_176 = BestHTTP.HTTPManager.Logger;
            if(val_3 != 0)
            {
                    val_194 = val_3.Host;
            }
            else
            {
                    val_194 = 0.Host;
            }
            
            val_182 = val_3.Port.ToString();
            val_183 = "Connected to " + val_194 + ":"(":") + val_182;
            val_185 = null;
            val_186 = "HTTPConnection";
            var val_186 = 0;
            val_187 = 1152921505557839880;
            val_186 = val_186 + 1;
            label_103:
            val_176.Information(division:  val_186, info:  val_183);
            label_94:
            System.DateTime val_62 = System.DateTime.UtcNow;
            this.StartTime = new System.DateTime() {dateData = val_62.dateData};
            if(this.Stream != null)
            {
                    return;
            }
            
            BestHTTP.HTTPRequest val_63 = this.CurrentRequest;
            bool val_65 = BestHTTP.HTTPProtocolFactory.IsSecureProtocol(uri:  ((val_63.<IsRedirected>k__BackingField) == false) ? val_63.<Uri>k__BackingField : val_63.<RedirectUri>k__BackingField);
            this.Stream = this.Client.GetStream();
            if(this.HasProxy == false)
            {
                goto label_251;
            }
            
            BestHTTP.HTTPProxy val_68 = this.Proxy;
            if((val_68.<IsTransparent>k__BackingField) == false)
            {
                goto label_111;
            }
            
            if(val_65 == false)
            {
                    return;
            }
            
            BestHTTP.HTTPProxy val_69 = this.Proxy;
            if((val_69.<NonTransparentForHTTPS>k__BackingField) == false)
            {
                goto label_114;
            }
            
            label_111:
            val_196 = null;
            val_196 = null;
            System.IO.BinaryWriter val_71 = new System.IO.BinaryWriter(output:  new BestHTTP.Extensions.WriteOnlyBufferedStream(stream:  this.Stream, bufferSize:  BestHTTP.HTTPRequest.UploadChunkSize));
            label_249:
            BestHTTP.HTTPRequest val_72 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_75 = this.CurrentRequest;
            string val_78 = System.String.Format(format:  "CONNECT {0}:{1} HTTP/1.1", arg0:  ((val_72.<IsRedirected>k__BackingField) == false) ? val_72.<Uri>k__BackingField : val_72.<RedirectUri>k__BackingField.Host, arg1:  ((val_75.<IsRedirected>k__BackingField) == false) ? val_75.<Uri>k__BackingField : val_75.<RedirectUri>k__BackingField.Port);
            var val_187 = 0;
            val_187 = val_187 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "HTTPConnection", info:  "Sending " + val_78);
            BestHTTP.Extensions.Extensions.SendAsASCII(stream:  val_71, str:  val_78);
            val_198 = null;
            val_198 = null;
            BestHTTP.Extensions.Extensions.SendAsASCII(stream:  val_71, str:  "Proxy-Connection: Keep-Alive");
            BestHTTP.Extensions.Extensions.SendAsASCII(stream:  val_71, str:  "Connection: Keep-Alive");
            BestHTTP.HTTPRequest val_82 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_85 = this.CurrentRequest;
            BestHTTP.Extensions.Extensions.SendAsASCII(stream:  val_71, str:  System.String.Format(format:  "Host: {0}:{1}", arg0:  ((val_82.<IsRedirected>k__BackingField) == false) ? val_82.<Uri>k__BackingField : val_82.<RedirectUri>k__BackingField.Host, arg1:  ((val_85.<IsRedirected>k__BackingField) == false) ? val_85.<Uri>k__BackingField : val_85.<RedirectUri>k__BackingField.Port));
            if(this.HasProxy == false)
            {
                goto label_162;
            }
            
            BestHTTP.HTTPProxy val_90 = this.Proxy;
            if((val_90.<Credentials>k__BackingField) == null)
            {
                goto label_162;
            }
            
            BestHTTP.HTTPProxy val_91 = this.Proxy;
            BestHTTP.Authentication.AuthenticationTypes val_92 = val_91.<Credentials>k__BackingField.Type;
            if((val_92 == 0) || (val_92 == 2))
            {
                goto label_145;
            }
            
            if(val_92 != 1)
            {
                goto label_162;
            }
            
            BestHTTP.HTTPProxy val_94 = this.Proxy;
            BestHTTP.HTTPProxy val_96 = this.Proxy;
            string val_98 = val_94.<Credentials>k__BackingField.UserName(val_94.<Credentials>k__BackingField.UserName) + ":"(":") + val_96.<Credentials>k__BackingField.Password(val_96.<Credentials>k__BackingField.Password);
            val_200 = 0;
            System.Byte[] val_102 = BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  System.String.Format(format:  "Proxy-Authorization: {0}", arg0:  "Basic " + System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8)(System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8))));
            goto label_156;
            label_145:
            BestHTTP.HTTPProxy val_103 = this.Proxy;
            BestHTTP.Authentication.Digest val_104 = BestHTTP.Authentication.DigestStore.Get(uri:  val_103.<Address>k__BackingField);
            if(val_104 == null)
            {
                goto label_162;
            }
            
            BestHTTP.HTTPProxy val_106 = this.Proxy;
            val_199 = val_106.<Credentials>k__BackingField;
            string val_107 = val_104.GenerateResponseHeader(request:  this.CurrentRequest, credentials:  val_199, isProxy:  true);
            if((System.String.IsNullOrEmpty(value:  val_107)) == true)
            {
                goto label_162;
            }
            
            val_200 = 0;
            string val_109 = System.String.Format(format:  "Proxy-Authorization: {0}", arg0:  val_107);
            var val_188 = 0;
            val_188 = val_188 + 1;
            val_200 = 0;
            if((BestHTTP.HTTPManager.Logger.Level & 255) <= 1)
            {
                    var val_189 = 0;
                val_189 = val_189 + 1;
                val_200 = "Sending proxy authorization header: "("Sending proxy authorization header: ") + val_109;
                BestHTTP.HTTPManager.Logger.Information(division:  "HTTPConnection", info:  val_200);
            }
            
            System.Byte[] val_117 = BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  val_109);
            label_156:
            val_204 = null;
            val_204 = null;
            label_162:
            val_205 = null;
            val_205 = null;
            BestHTTP.HTTPRequest val_118 = this.CurrentRequest;
            val_118.<ProxyResponse>k__BackingField = new BestHTTP.HTTPResponse(request:  this.CurrentRequest, stream:  this.Stream, isStreamed:  false, isFromCache:  false);
            BestHTTP.HTTPRequest val_121 = this.CurrentRequest;
            if(((val_121.<ProxyResponse>k__BackingField) & 1) == 0)
            {
                goto label_188;
            }
            
            var val_190 = 0;
            val_190 = val_190 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) <= 1)
            {
                    object[] val_127 = new object[6];
                val_127[0] = "Proxy returned - status code: ";
                BestHTTP.HTTPRequest val_128 = this.CurrentRequest;
                val_127[1] = val_128.<ProxyResponse>k__BackingField.<StatusCode>k__BackingField;
                val_127[2] = " message: ";
                BestHTTP.HTTPRequest val_129 = this.CurrentRequest;
                val_127[3] = val_129.<ProxyResponse>k__BackingField.<Message>k__BackingField;
                val_127[4] = " Body: ";
                BestHTTP.HTTPRequest val_130 = this.CurrentRequest;
                val_127[5] = val_130.<ProxyResponse>k__BackingField.DataAsText;
                var val_191 = 0;
                val_191 = val_191 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  "HTTPConnection", info:  +val_127);
            }
            
            BestHTTP.HTTPRequest val_134 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_135 = this.CurrentRequest;
            if((val_134.<ProxyResponse>k__BackingField.<StatusCode>k__BackingField) != 407)
            {
                goto label_233;
            }
            
            string val_137 = BestHTTP.Authentication.DigestStore.FindBest(authHeaders:  val_135.<ProxyResponse>k__BackingField.GetHeaderValues(name:  "proxy-authenticate"));
            if((System.String.IsNullOrEmpty(value:  val_137)) == true)
            {
                goto label_251;
            }
            
            BestHTTP.HTTPProxy val_139 = this.Proxy;
            BestHTTP.Authentication.Digest val_140 = BestHTTP.Authentication.DigestStore.GetOrCreate(uri:  val_139.<Address>k__BackingField);
            val_140.ParseChallange(header:  val_137);
            BestHTTP.HTTPProxy val_141 = this.Proxy;
            if((val_141.<Credentials>k__BackingField) == null)
            {
                goto label_251;
            }
            
            BestHTTP.HTTPProxy val_142 = this.Proxy;
            if((val_140.IsUriProtected(uri:  val_142.<Address>k__BackingField)) == false)
            {
                goto label_251;
            }
            
            if(((this.CurrentRequest.HasHeader(name:  "Proxy-Authorization")) == false) || (val_140.Stale == true))
            {
                goto label_249;
            }
            
            goto label_251;
            label_233:
            int val_192 = val_135.<ProxyResponse>k__BackingField.<StatusCode>k__BackingField;
            if(val_192 == 304)
            {
                goto label_251;
            }
            
            val_192 = val_192 - 200;
            if(val_192 >= 100)
            {
                goto label_252;
            }
            
            label_251:
            if(val_65 == false)
            {
                    return;
            }
            
            label_114:
            BestHTTP.HTTPRequest val_147 = this.CurrentRequest;
            System.IO.Stream val_148 = this.Client.GetStream();
            if((val_147.<UseAlternateSSL>k__BackingField) == false)
            {
                goto label_256;
            }
            
            BestHTTP.HTTPRequest val_151 = this.CurrentRequest;
            val_208 = val_151.<CustomTLSServerNameList>k__BackingField;
            if(val_208 != null)
            {
                    if(val_208.Count != 0)
            {
                goto label_263;
            }
            
            }
            
            BestHTTP.HTTPRequest val_153 = this.CurrentRequest;
            if((BestHTTP.Extensions.Extensions.IsHostIsAnIPAddress(uri:  ((val_153.<IsRedirected>k__BackingField) == false) ? val_153.<Uri>k__BackingField : val_153.<RedirectUri>k__BackingField)) != true)
            {
                    System.Collections.Generic.List<System.String> val_156 = null;
                val_208 = val_156;
                val_156 = new System.Collections.Generic.List<System.String>(capacity:  1);
                BestHTTP.HTTPRequest val_157 = this.CurrentRequest;
                val_156.Add(item:  ((val_157.<IsRedirected>k__BackingField) == false) ? val_157.<Uri>k__BackingField : val_157.<RedirectUri>k__BackingField.Host);
            }
            
            label_263:
            BestHTTP.HTTPRequest val_160 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_162 = this.CurrentRequest;
            if((val_162.<CustomCertificateVerifyer>k__BackingField) == null)
            {
                goto label_269;
            }
            
            BestHTTP.HTTPRequest val_163 = this.CurrentRequest;
            val_209 = val_163.<CustomCertificateVerifyer>k__BackingField;
            goto label_271;
            label_256:
            System.Net.Security.SslStream val_165 = new System.Net.Security.SslStream(innerStream:  val_148, leaveInnerStreamOpen:  false, userCertificateValidationCallback:  new System.Net.Security.RemoteCertificateValidationCallback(object:  this, method:  System.Boolean BestHTTP.HTTPConnection::<Connect>b__7_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors)));
            if((val_165 & 1) == 0)
            {
                    BestHTTP.HTTPRequest val_166 = this.CurrentRequest;
                string val_168 = ((val_166.<IsRedirected>k__BackingField) == false) ? val_166.<Uri>k__BackingField : val_166.<RedirectUri>k__BackingField.Host;
            }
            
            this.Stream = val_165;
            return;
            label_269:
            Org.BouncyCastle.Crypto.Tls.AlwaysValidVerifyer val_169 = null;
            val_209 = val_169;
            val_169 = new Org.BouncyCastle.Crypto.Tls.AlwaysValidVerifyer();
            label_271:
            BestHTTP.HTTPRequest val_170 = this.CurrentRequest;
            Org.BouncyCastle.Crypto.Tls.LegacyTlsClient val_171 = new Org.BouncyCastle.Crypto.Tls.LegacyTlsClient(targetUri:  ((val_160.<IsRedirected>k__BackingField) == false) ? val_160.<Uri>k__BackingField : val_160.<RedirectUri>k__BackingField, verifyer:  val_169, prov:  val_170.<CustomClientCredentialsProvider>k__BackingField, hostNames:  val_156);
            this.Stream = new Org.BouncyCastle.Crypto.Tls.TlsClientProtocol(stream:  val_148, secureRandom:  new Org.BouncyCastle.Security.SecureRandom());
            return;
            label_188:
            System.Exception val_172 = null;
            val_173 = val_172;
            val_172 = new System.Exception(message:  "Connection to the Proxy Server failed!");
            label_281:
            label_252:
            BestHTTP.HTTPRequest val_173 = val_172.CurrentRequest;
            BestHTTP.HTTPRequest val_174 = val_172.CurrentRequest;
            BestHTTP.HTTPRequest val_175 = val_172.CurrentRequest;
            System.Exception val_178 = new System.Exception(message:  System.String.Format(format:  "Proxy returned Status Code: \"{0}\", Message: \"{1}\" and Response: {2}", arg0:  val_173.<ProxyResponse>k__BackingField.<StatusCode>k__BackingField, arg1:  val_174.<ProxyResponse>k__BackingField.<Message>k__BackingField, arg2:  val_175.<ProxyResponse>k__BackingField.DataAsText));
            goto label_281;
        }
        private bool Receive()
        {
            string val_43;
            BestHTTP.SupportedProtocols val_44;
            BestHTTP.HTTPResponse val_47;
            var val_48;
            var val_53;
            val_43 = this;
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            if(this.CurrentRequest == null)
            {
                goto label_2;
            }
            
            if((val_1.<ProtocolHandler>k__BackingField) == 0)
            {
                goto label_3;
            }
            
            label_5:
            val_44 = val_2.<ProtocolHandler>k__BackingField;
            goto label_4;
            label_2:
            if((val_1.<ProtocolHandler>k__BackingField) != 0)
            {
                goto label_5;
            }
            
            label_3:
            label_4:
            var val_46 = 0;
            val_46 = val_46 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    BestHTTP.HTTPRequest val_10 = this.CurrentRequest;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                var val_47 = 0;
                val_47 = val_47 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPConnection", verb:  System.String.Format(format:  "{0} - Receive - protocol: {1}", arg0:  ((val_10.<IsRedirected>k__BackingField) == false) ? val_10.<Uri>k__BackingField : val_10.<RedirectUri>k__BackingField, arg1:  BestHTTP.HTTPProtocolFactory.GetProtocolFromUri(uri:  ((val_2.<IsRedirected>k__BackingField) == false) ? val_2.<Uri>k__BackingField : val_2.<RedirectUri>k__BackingField).ToString()));
            }
            
            BestHTTP.HTTPRequest val_15 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_17 = this.CurrentRequest;
            val_47 = BestHTTP.HTTPProtocolFactory.Get(protocol:  null, request:  this.CurrentRequest, stream:  this.Stream, isStreamed:  val_17.useStreaming, isFromCache:  false);
            val_15.<Response>k__BackingField = val_47;
            BestHTTP.HTTPRequest val_19 = this.CurrentRequest;
            if(((val_19.<Response>k__BackingField) & 1) == 0)
            {
                goto label_29;
            }
            
            BestHTTP.HTTPRequest val_20 = this.CurrentRequest;
            if((val_20.<Response>k__BackingField.<StatusCode>k__BackingField) != 304)
            {
                goto label_38;
            }
            
            BestHTTP.HTTPRequest val_21 = this.CurrentRequest;
            if(val_21.disableCache == true)
            {
                goto label_38;
            }
            
            BestHTTP.HTTPRequest val_22 = this.CurrentRequest;
            val_47 = val_22.<IsRedirected>k__BackingField;
            val_48 = this.CurrentRequest;
            if(val_47 == false)
            {
                goto label_39;
            }
            
            if((this.LoadFromCache(uri:  val_23.<RedirectUri>k__BackingField)) == true)
            {
                goto label_38;
            }
            
            val_48 = this.CurrentRequest;
            label_39:
            bool val_26 = this.LoadFromCache(uri:  val_25.<Uri>k__BackingField);
            label_38:
            var val_48 = 0;
            val_48 = val_48 + 1;
            goto label_46;
            label_29:
            var val_49 = 0;
            val_49 = val_49 + 1;
            goto label_53;
            label_46:
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                goto label_54;
            }
            
            BestHTTP.HTTPRequest val_33 = this.CurrentRequest;
            val_43 = System.String.Format(format:  "{0} - Receive - Finished Successfully!", arg0:  ((val_33.<IsRedirected>k__BackingField) == false) ? val_33.<Uri>k__BackingField : val_33.<RedirectUri>k__BackingField);
            val_47 = "HTTPConnection";
            var val_50 = 0;
            val_50 = val_50 + 1;
            goto label_63;
            label_53:
            if((BestHTTP.HTTPManager.Logger.Level & 255) != 0)
            {
                goto label_64;
            }
            
            BestHTTP.HTTPRequest val_40 = this.CurrentRequest;
            val_47 = System.String.Format(format:  "{0} - Receive - Failed! Response will be null, returning with false.", arg0:  ((val_40.<IsRedirected>k__BackingField) == false) ? val_40.<Uri>k__BackingField : val_40.<RedirectUri>k__BackingField);
            var val_51 = 0;
            val_51 = val_51 + 1;
            goto label_73;
            label_63:
            BestHTTP.HTTPManager.Logger.Verbose(division:  val_47, verb:  val_43);
            label_54:
            val_53 = 1;
            return (bool)val_53;
            label_73:
            BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPConnection", verb:  val_47);
            label_64:
            val_43 = this.CurrentRequest;
            val_53 = 0;
            val_45.<Response>k__BackingField = 0;
            return (bool)val_53;
        }
        private bool LoadFromCache(System.Uri uri)
        {
            string val_27;
            var val_28;
            string val_30;
            BestHTTP.Caching.HTTPCacheFileInfo val_32;
            var val_33;
            val_27 = this;
            int val_12 = 0;
            val_28 = 1152921505557803008;
            var val_28 = 0;
            val_28 = val_28 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    BestHTTP.HTTPRequest val_6 = this.CurrentRequest;
                val_30 = "HTTPConnection";
                var val_29 = 0;
                val_29 = val_29 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  val_30, verb:  System.String.Format(format:  "{0} - LoadFromCache for Uri: {1}", arg0:  ((val_6.<IsRedirected>k__BackingField) == false) ? val_6.<Uri>k__BackingField : val_6.<RedirectUri>k__BackingField, arg1:  uri));
            }
            
            val_32 = BestHTTP.Caching.HTTPCacheService.GetEntity(uri:  uri);
            if(val_32 == null)
            {
                goto label_21;
            }
            
            BestHTTP.HTTPRequest val_11 = this.CurrentRequest;
            val_11.<Response>k__BackingField.<CacheFileInfo>k__BackingField = val_32;
            System.IO.Stream val_13 = val_32.GetBodyStream(length: out  val_12);
            if(val_13 == null)
            {
                    return (bool)val_33;
            }
            
            BestHTTP.HTTPRequest val_14 = this.CurrentRequest;
            val_28 = "content-length";
            if((val_14.<Response>k__BackingField.GetHeaderValues(name:  "content-length")) == null)
            {
                    BestHTTP.HTTPRequest val_16 = this.CurrentRequest;
                System.Collections.Generic.List<System.String> val_17 = new System.Collections.Generic.List<System.String>(capacity:  1);
                val_30 = val_12.ToString();
                null.Add(item:  val_30);
                val_16.<Response>k__BackingField.<Headers>k__BackingField.Add(key:  "content-length", value:  null);
            }
            
            BestHTTP.HTTPRequest val_19 = this.CurrentRequest;
            val_19.<Response>k__BackingField.<IsFromCache>k__BackingField = true;
            BestHTTP.HTTPRequest val_20 = this.CurrentRequest;
            if(val_20.cacheOnly != true)
            {
                    BestHTTP.HTTPRequest val_21 = this.CurrentRequest;
                val_21.<Response>k__BackingField.ReadRaw(stream:  val_13, contentLength:  0);
            }
            
            val_32 = 0;
            val_27 = 0;
            var val_30 = 0;
            val_30 = val_30 + 1;
            goto label_41;
            label_21:
            val_32 = BestHTTP.HTTPManager.Logger;
            BestHTTP.HTTPRequest val_23 = this.CurrentRequest;
            val_27 = System.String.Format(format:  "{0} - LoadFromCache for Uri: {1} - Cached entity not found!", arg0:  ((val_23.<IsRedirected>k__BackingField) == false) ? val_23.<Uri>k__BackingField : val_23.<RedirectUri>k__BackingField, arg1:  uri);
            var val_31 = 0;
            val_31 = val_31 + 1;
            goto label_51;
            label_41:
            val_13.Dispose();
            if(val_32 == 1)
            {
                goto label_53;
            }
            
            if(285 == 283)
            {
                goto label_56;
            }
            
            if(285 == 285)
            {
                goto label_55;
            }
            
            label_53:
            label_56:
            val_33 = 1;
            return (bool)val_33;
            label_51:
            val_32.Warning(division:  "HTTPConnection", warn:  val_27);
            label_55:
            val_33 = 0;
            return (bool)val_33;
        }
        private bool TryLoadAllFromCache()
        {
            System.Uri val_20;
            var val_23;
            val_20 = this;
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            if(((val_1.disableCache != true) && (BestHTTP.Caching.HTTPCacheService.IsSupported != false)) && ((BestHTTP.Caching.HTTPCacheService.IsCachedEntityExpiresInTheFuture(request:  this.CurrentRequest)) != false))
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    BestHTTP.HTTPRequest val_10 = this.CurrentRequest;
                var val_22 = 0;
                val_22 = val_22 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPConnection", verb:  System.String.Format(format:  "{0} - TryLoadAllFromCache - whole response loading from cache", arg0:  ((val_10.<IsRedirected>k__BackingField) == false) ? val_10.<Uri>k__BackingField : val_10.<RedirectUri>k__BackingField));
            }
            
                BestHTTP.HTTPRequest val_14 = this.CurrentRequest;
                val_14.<Response>k__BackingField = BestHTTP.Caching.HTTPCacheService.GetFullResponse(request:  this.CurrentRequest);
                BestHTTP.HTTPRequest val_17 = this.CurrentRequest;
                if((val_17.<Response>k__BackingField) != null)
            {
                    val_23 = 1;
                return (bool)val_23;
            }
            
            }
            
            val_23 = 0;
            return (bool)val_23;
        }
        private void TryStoreInCache()
        {
            System.Uri val_16;
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            if(val_1.useStreaming == true)
            {
                    return;
            }
            
            BestHTTP.HTTPRequest val_2 = this.CurrentRequest;
            if(val_2.disableCache != false)
            {
                    return;
            }
            
            BestHTTP.HTTPRequest val_3 = this.CurrentRequest;
            if((val_3.<Response>k__BackingField) == null)
            {
                    return;
            }
            
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            BestHTTP.HTTPRequest val_5 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_7 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_8 = this.CurrentRequest;
            if((BestHTTP.Caching.HTTPCacheService.IsCacheble(uri:  ((val_5.<IsRedirected>k__BackingField) == false) ? val_5.<Uri>k__BackingField : val_5.<RedirectUri>k__BackingField, method:  val_7.<MethodType>k__BackingField, response:  val_8.<Response>k__BackingField)) == false)
            {
                    return;
            }
            
            BestHTTP.HTTPRequest val_10 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_11 = this.CurrentRequest;
            if((val_10.<IsRedirected>k__BackingField) != false)
            {
                    val_16 = val_11.<Uri>k__BackingField;
            }
            else
            {
                    val_16 = mem[val_11.<IsRedirected>k__BackingField == false ? val_11.<Uri>k__BackingField : val_11.<RedirectUri>k__BackingField];
                val_16 = ((val_11.<IsRedirected>k__BackingField) == false) ? val_11.<Uri>k__BackingField : val_11.<RedirectUri>k__BackingField;
            }
            
            BestHTTP.HTTPRequest val_13 = this.CurrentRequest;
            BestHTTP.HTTPRequest val_14 = this.CurrentRequest;
            BestHTTP.Caching.HTTPCacheFileInfo val_15 = BestHTTP.Caching.HTTPCacheService.Store(uri:  val_16, method:  val_13.<MethodType>k__BackingField, response:  val_14.<Response>k__BackingField);
        }
        private System.Uri GetRedirectUri(string location)
        {
            System.Uri val_13;
            string val_14;
            string val_15;
            val_13 = new System.Uri();
            val_13 = new System.Uri(uriString:  location);
            if(new System.Uri().IsFile != true)
            {
                    if((System.String.op_Equality(a:  new System.Uri().AbsolutePath, b:  location)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_13 = 0;
            label_4:
            if((System.Uri.op_Equality(uri1:  val_13, uri2:  0)) == false)
            {
                    return val_13;
            }
            
            BestHTTP.HTTPRequest val_6 = this.CurrentRequest;
            if((val_6.<Uri>k__BackingField) != null)
            {
                    val_14 = val_6.<Uri>k__BackingField.Scheme;
                val_15 = val_6.<Uri>k__BackingField.Host;
            }
            else
            {
                    val_14 = 0.Scheme;
                val_15 = 0.Host;
            }
            
            System.UriBuilder val_12 = new System.UriBuilder(scheme:  val_14, host:  val_15, port:  val_6.<Uri>k__BackingField.Port, pathValue:  location);
            if(val_12 != null)
            {
                    return val_12.Uri;
            }
            
            return val_12.Uri;
        }
        internal override void Abort(BestHTTP.HTTPConnectionStates newState)
        {
            this.State = newState;
            if(this.State == 8)
            {
                    System.DateTime val_2 = System.DateTime.UtcNow;
                this.TimedOutStart = new System.DateTime() {dateData = val_2.dateData};
            }
            
            if(this.Stream == null)
            {
                    return;
            }
            
            this.Stream.Dispose();
        }
        private void Close()
        {
            this.KeepAlive = 0;
            this.LastProcessedUri = 0;
            if(this.Client == null)
            {
                    return;
            }
            
            this.Client.Close();
            this.Client = 0;
            mem[1152921553613997208] = 0;
        }
        protected override void Dispose(bool disposing)
        {
            this.Close();
            disposing = disposing;
            this.Dispose(disposing:  disposing);
        }
        private bool <Connect>b__7_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors)
        {
            BestHTTP.HTTPRequest val_1 = this.CurrentRequest;
            if(val_1 != null)
            {
                    return val_1.CallCustomCertificationValidator(cert:  cert, chain:  chain);
            }
            
            return val_1.CallCustomCertificationValidator(cert:  cert, chain:  chain);
        }
    
    }

}
