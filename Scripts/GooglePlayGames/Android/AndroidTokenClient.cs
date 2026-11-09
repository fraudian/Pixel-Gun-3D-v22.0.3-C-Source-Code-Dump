using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidTokenClient : TokenClient
    {
        // Fields
        private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";
        private bool requestEmail;
        private bool requestAuthCode;
        private bool requestIdToken;
        private System.Collections.Generic.List<string> oauthScopes;
        private string webClientId;
        private bool forceRefresh;
        private bool hidePopups;
        private string accountName;
        private UnityEngine.AndroidJavaObject account;
        private string email;
        private string authCode;
        private string idToken;
        
        // Methods
        public void SetRequestAuthCode(bool flag, bool forceRefresh)
        {
            this.requestAuthCode = flag;
            this.forceRefresh = forceRefresh;
        }
        public void SetRequestEmail(bool flag)
        {
            this.requestEmail = flag;
        }
        public void SetRequestIdToken(bool flag)
        {
            this.requestIdToken = flag;
        }
        public void SetWebClientId(string webClientId)
        {
            this.webClientId = webClientId;
        }
        public void SetHidePopups(bool flag)
        {
            this.hidePopups = flag;
        }
        public void SetAccountName(string accountName)
        {
            this.accountName = accountName;
        }
        public void AddOauthScopes(string[] scopes)
        {
            System.Collections.Generic.List<System.String> val_2;
            if(scopes == null)
            {
                    return;
            }
            
            val_2 = this.oauthScopes;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
                this.oauthScopes = val_2;
            }
            
            val_1.AddRange(collection:  scopes);
        }
        public void Signout()
        {
            var val_2;
            System.Action val_4;
            this.authCode = 0;
            this.account = 0;
            val_2 = null;
            val_2 = null;
            val_4 = AndroidTokenClient.<>c.<>9__20_0;
            if(val_4 == null)
            {
                    System.Action val_1 = null;
                val_4 = val_1;
                val_1 = new System.Action(object:  AndroidTokenClient.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AndroidTokenClient.<>c::<Signout>b__20_0());
                AndroidTokenClient.<>c.<>9__20_0 = val_4;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  val_1);
        }
        public string GetEmail()
        {
            return (string)this.email;
        }
        public string GetAuthCode()
        {
            return (string)this.authCode;
        }
        public string GetIdToken()
        {
            return (string)this.idToken;
        }
        public void FetchTokens(bool silent, System.Action<int> callback)
        {
            System.Action val_5;
            AndroidTokenClient.<>c__DisplayClass24_0 val_1 = new AndroidTokenClient.<>c__DisplayClass24_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .silent = silent;
            }
            else
            {
                    mem[16] = this;
                val_5 = 0;
                mem[24] = silent;
            }
            
            .callback = callback;
            val_5 = new System.Action(object:  val_1, method:  System.Void AndroidTokenClient.<>c__DisplayClass24_0::<FetchTokens>b__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  val_5);
        }
        private void DoFetchToken(bool silent, System.Action<int> callback)
        {
            var val_14;
            var val_15;
            var val_17;
            var val_18;
            AndroidTokenClient.<>c__DisplayClass25_0 val_1 = new AndroidTokenClient.<>c__DisplayClass25_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            UnityEngine.AndroidJavaObject val_3 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            object[] val_4 = new object[10];
            val_4[0] = val_3;
            val_4[1] = silent;
            val_4[2] = this.requestAuthCode;
            val_4[3] = this.requestEmail;
            val_4[4] = this.requestIdToken;
            val_4[5] = this.webClientId;
            val_4[6] = this.forceRefresh;
            val_4[7] = this.oauthScopes.ToArray();
            val_4[8] = this.hidePopups;
            val_4[9] = this.accountName;
            UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fetchToken", args:  val_4);
            object[] val_8 = new object[1];
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTokenClient.<>c__DisplayClass25_0::<DoFetchToken>b__0(UnityEngine.AndroidJavaObject tokenResult));
            new AndroidTokenClient.ResultCallbackProxy() = new AndroidTokenClient.ResultCallbackProxy(callback:  null);
            val_8[0] = new AndroidTokenClient.ResultCallbackProxy();
            val_7.Call(methodName:  "setResultCallback", args:  val_8);
            val_14 = 0;
            val_15 = 0;
            if(val_7 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_7.Dispose();
            }
            
            if((val_14 != 1) && (221 == 221))
            {
                    val_14 = 0;
            }
            else
            {
                    if(val_15 != 0)
            {
                    val_15 = 0;
            }
            
            }
            
            val_17 = 0 + 1;
            mem2[0] = 233;
            val_18 = val_15;
            if(val_3 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
            if((val_17 != 1) && ((1152921541824327456 + ((0 + 1)) << 2) == 233))
            {
                    var val_16 = 0;
                val_16 = val_16 ^ (val_17 >> 31);
                val_17 = val_17 + val_16;
            }
            else
            {
                    if(val_18 != 0)
            {
                    val_15 = 0;
                val_18 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            }
            
            val_17 = val_17 + 1;
            mem2[0] = 245;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if(val_17 != 1)
            {
                    if(val_18 == 0)
            {
                    return;
            }
            
                if((1152921541824327456 + (((0 + 1) + 1)) << 2) != 245)
            {
                    return;
            }
            
                return;
            }
            
            if(val_18 == 0)
            {
                    return;
            }
        
        }
        public UnityEngine.AndroidJavaObject GetAccount()
        {
            return (UnityEngine.AndroidJavaObject)this.account;
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            AndroidTokenClient.<>c__DisplayClass27_0 val_1 = new AndroidTokenClient.<>c__DisplayClass27_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .reAuthenticateIfNeeded = reAuthenticateIfNeeded;
            }
            else
            {
                    mem[16] = this;
                mem[24] = reAuthenticateIfNeeded;
            }
            
            .callback = callback;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidTokenClient.<>c__DisplayClass27_0::<GetAnotherServerAuthCode>b__0()));
        }
        private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            var val_14;
            var val_15;
            var val_17;
            var val_18;
            .callback = callback;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            UnityEngine.AndroidJavaObject val_3 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            object[] val_4 = new object[10];
            val_4[0] = val_3;
            val_4[1] = reAuthenticateIfNeeded;
            val_4[2] = true;
            val_4[3] = null;
            val_4[4] = null;
            val_4[5] = this.webClientId;
            val_4[6] = null;
            val_4[7] = this.oauthScopes.ToArray();
            val_4[8] = true;
            val_4[9] = "";
            UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fetchToken", args:  val_4);
            object[] val_8 = new object[1];
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidTokenClient.<>c__DisplayClass28_0(), method:  System.Void AndroidTokenClient.<>c__DisplayClass28_0::<DoGetAnotherServerAuthCode>b__0(UnityEngine.AndroidJavaObject tokenResult));
            new AndroidTokenClient.ResultCallbackProxy() = new AndroidTokenClient.ResultCallbackProxy(callback:  null);
            val_8[0] = new AndroidTokenClient.ResultCallbackProxy();
            val_7.Call(methodName:  "setResultCallback", args:  val_8);
            val_14 = 0;
            val_15 = 0;
            if(val_7 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_7.Dispose();
            }
            
            if((val_14 != 1) && (188 == 188))
            {
                    val_14 = 0;
            }
            else
            {
                    if(val_15 != 0)
            {
                    val_15 = 0;
            }
            
            }
            
            val_17 = 0 + 1;
            mem2[0] = 200;
            val_18 = val_15;
            if(val_3 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
            if((val_17 != 1) && ((1152921541824905408 + ((0 + 1)) << 2) == 200))
            {
                    var val_16 = 0;
                val_16 = val_16 ^ (val_17 >> 31);
                val_17 = val_17 + val_16;
            }
            else
            {
                    if(val_18 != 0)
            {
                    val_15 = 0;
                val_18 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            }
            
            val_17 = val_17 + 1;
            mem2[0] = 212;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if(val_17 != 1)
            {
                    if(val_18 == 0)
            {
                    return;
            }
            
                if((1152921541824905408 + (((0 + 1) + 1)) << 2) != 212)
            {
                    return;
            }
            
                return;
            }
            
            if(val_18 == 0)
            {
                    return;
            }
        
        }
        public AndroidTokenClient()
        {
        
        }
    
    }

}
