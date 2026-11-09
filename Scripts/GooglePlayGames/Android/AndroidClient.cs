using UnityEngine;

namespace GooglePlayGames.Android
{
    public class AndroidClient : IPlayGamesClient
    {
        // Fields
        private readonly object GameServicesLock;
        private readonly object AuthStateLock;
        private readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
        private GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient mTurnBasedClient;
        private GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient mRealTimeClient;
        private GooglePlayGames.BasicApi.SavedGame.ISavedGameClient mSavedGameClient;
        private GooglePlayGames.BasicApi.Events.IEventsClient mEventsClient;
        private GooglePlayGames.BasicApi.Video.IVideoClient mVideoClient;
        private GooglePlayGames.Android.AndroidTokenClient mTokenClient;
        private System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> mInvitationDelegate;
        private GooglePlayGames.BasicApi.Multiplayer.Player mUser;
        private GooglePlayGames.Android.AndroidClient.AuthState mAuthState;
        private UnityEngine.AndroidJavaClass mGamesClass;
        private static string TasksClassName;
        private UnityEngine.AndroidJavaObject mInvitationCallback;
        private readonly int mLeaderboardMaxResults;
        
        // Methods
        internal AndroidClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration)
        {
            var val_5;
            var val_6;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_7;
            this.GameServicesLock = new System.Object();
            this.AuthStateLock = new System.Object();
            this.mGamesClass = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.Games");
            this.mLeaderboardMaxResults = 25;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.CreateObject();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.PlayGamesClientConfiguration>(value:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = configuration.mEnableSavedGames, mRequestAuthCode = configuration.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = configuration.mInvitationDelegate, mMatchDelegate = configuration.mInvitationDelegate});
            mem[1152921541748725904] = val_5;
            mem[1152921541748725888] = val_6;
            this.mConfiguration = val_7;
            this.RegisterInvitationDelegate(invitationDelegate:  configuration.mEnableSavedGames.丞丈业东专丅丆与七());
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            var val_5;
            AndroidClient.<>c__DisplayClass18_0 val_1 = new AndroidClient.<>c__DisplayClass18_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this.AuthStateLock, lockTaken: ref  val_2);
            if(this.mAuthState == 1)
            {
                    GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean, System.String>(callback:  (AndroidClient.<>c__DisplayClass18_0)[1152921541749027680].callback, t1:  true, t2:  0);
                val_5 = 117;
            }
            else
            {
                    val_5 = 75;
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.AuthStateLock);
            }
            
            if(0 == 1)
            {
                goto label_8;
            }
            
            if(75 == 117)
            {
                    return;
            }
            
            if(0 == 0)
            {
                goto label_13;
            }
            
            if(75 != 75)
            {
                goto label_11;
            }
            
            goto label_13;
            label_8:
            if(0 == 0)
            {
                goto label_13;
            }
            
            label_11:
            label_13:
            this.InitializeTokenClient();
            UnityEngine.Debug.Log(message:  "Starting Auth with token client.");
            this.mTokenClient.FetchTokens(silent:  silent, callback:  new System.Action<System.Int32>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass18_0::<Authenticate>b__0(int result)));
        }
        private static System.Action<T> AsOnGameThreadCallback<T>(System.Action<T> callback)
        {
            var val_1;
            System.Action<T> val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_1 = __RuntimeMethodHiddenParam;
            val_2 = callback;
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = val_2;
            }
            else
            {
                    mem[16] = val_2;
                val_2 = mem[16];
            }
            
            if(val_2 != 0)
            {
                    val_3 = __RuntimeMethodHiddenParam + 48 + 32;
                return (System.Action<T>)val_3;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 294];
            val_4 = __RuntimeMethodHiddenParam + 48 + 16 + 294;
            if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 294];
                val_4 = __RuntimeMethodHiddenParam + 48 + 16 + 294;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 184 + 8];
            val_3 = __RuntimeMethodHiddenParam + 48 + 16 + 184 + 8;
            if(val_3 != 0)
            {
                    return (System.Action<T>)val_3;
            }
            
            val_5 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 294];
            val_5 = __RuntimeMethodHiddenParam + 48 + 16 + 294;
            if((val_5 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 294];
                val_5 = __RuntimeMethodHiddenParam + 48 + 16 + 294;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 48];
            val_6 = __RuntimeMethodHiddenParam + 48;
            if(((__RuntimeMethodHiddenParam + 48 + 16 + 294) & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 48];
                val_6 = __RuntimeMethodHiddenParam + 48;
            }
            
            val_3 = __RuntimeMethodHiddenParam + 48 + 32;
            val_1 = mem[__RuntimeMethodHiddenParam + 48 + 16];
            val_1 = __RuntimeMethodHiddenParam + 48 + 16;
            mem2[0] = val_3;
            return (System.Action<T>)val_3;
        }
        private static void InvokeCallbackOnGameThread<T>(System.Action<T> callback, T data)
        {
            System.Action<T> val_2 = callback;
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_2;
            }
            
            mem2[0] = val_2;
            mem2[0] = data;
            if(val_2 == null)
            {
                    return;
            }
            
            label_6:
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16));
            return;
            label_2:
            mem[16] = val_2;
            mem[24] = data;
            val_2 = mem[16];
            if(val_2 != 0)
            {
                goto label_6;
            }
        
        }
        private static System.Action<T1, T2> AsOnGameThreadCallback<T1, T2>(System.Action<T1, T2> toInvokeOnGameThread)
        {
            mem2[0] = toInvokeOnGameThread;
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 294) & 1) != 0)
            {
                    return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
            }
            
            return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
        }
        private static void InvokeCallbackOnGameThread<T1, T2>(System.Action<T1, T2> callback, T1 t1, T2 t2)
        {
            System.Action<T1, T2> val_2 = callback;
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_2;
            }
            
            mem2[0] = val_2;
            mem2[0] = t1;
            mem2[0] = t2;
            if(val_2 == null)
            {
                    return;
            }
            
            label_6:
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16));
            return;
            label_2:
            mem[16] = val_2;
            mem[24] = t1;
            mem[32] = t2;
            val_2 = mem[16];
            if(val_2 != 0)
            {
                goto label_6;
            }
        
        }
        private void InitializeGameServices()
        {
            if(this.mTokenClient != null)
            {
                    return;
            }
            
            this.InitializeTokenClient();
        }
        private void InitializeTokenClient()
        {
            GooglePlayGames.Android.AndroidTokenClient val_19;
            string val_20;
            val_19 = this;
            if(this.mTokenClient != null)
            {
                    return;
            }
            
            this.mTokenClient = new GooglePlayGames.Android.AndroidTokenClient();
            if(GooglePlayGames.GameInfo.WebClientIdInitialized() == true)
            {
                goto label_4;
            }
            
            if(this.mConfiguration.mEnableSavedGames.丞丅七丗丑丕东下丕() == true)
            {
                goto label_3;
            }
            
            if(this.mConfiguration.mEnableSavedGames.下丕且丝丐丙丏丛上() == false)
            {
                goto label_4;
            }
            
            label_3:
            GooglePlayGames.OurUtils.Logger.e(msg:  "Server Auth Code and ID Token require web clientId to configured.");
            label_4:
            this.mTokenClient.SetWebClientId(webClientId:  "");
            this.mTokenClient.SetRequestAuthCode(flag:  this.mConfiguration.mEnableSavedGames.下丕且丝丐丙丏丛上(), forceRefresh:  this.mConfiguration.mEnableSavedGames.万丛丐上世丅丑一丅());
            this.mTokenClient.SetRequestEmail(flag:  this.mConfiguration.mEnableSavedGames.丐丂与丅丘三上丆东());
            this.mTokenClient.SetRequestIdToken(flag:  this.mConfiguration.mEnableSavedGames.丞丅七丗丑丕东下丕());
            this.mTokenClient.SetHidePopups(flag:  this.mConfiguration.mEnableSavedGames.丄丐丐不丌三丙丞不());
            val_20 = 1152921505724518352;
            string[] val_15 = new string[1];
            val_15[0] = "https://www.googleapis.com/auth/games_lite";
            this.mTokenClient.AddOauthScopes(scopes:  val_15);
            if(this.mConfiguration.mEnableSavedGames.下丕且丝丐丙丏丛上() != false)
            {
                    string[] val_17 = new string[1];
                val_20 = "https://www.googleapis.com/auth/drive.appdata";
                val_17[0] = val_20;
                this.mTokenClient.AddOauthScopes(scopes:  val_17);
            }
            
            this.mTokenClient.AddOauthScopes(scopes:  this.mConfiguration.mEnableSavedGames);
            val_19 = this.mTokenClient;
            val_19.SetAccountName(accountName:  this.mConfiguration.mEnableSavedGames.丘一一丆业丂丘丒世());
        }
        public string GetUserEmail()
        {
            if(this.IsAuthenticated() != false)
            {
                    if(this.mTokenClient != null)
            {
                    return this.mTokenClient.GetEmail();
            }
            
                return this.mTokenClient.GetEmail();
            }
            
            UnityEngine.Debug.Log(message:  "Cannot get API client - not authenticated");
            return 0;
        }
        public string GetIdToken()
        {
            if(this.IsAuthenticated() != false)
            {
                    if(this.mTokenClient != null)
            {
                    return this.mTokenClient.GetIdToken();
            }
            
                return this.mTokenClient.GetIdToken();
            }
            
            UnityEngine.Debug.Log(message:  "Cannot get API client - not authenticated");
            return 0;
        }
        public string GetServerAuthCode()
        {
            if(this.IsAuthenticated() != false)
            {
                    if(this.mTokenClient != null)
            {
                    return this.mTokenClient.GetAuthCode();
            }
            
                return this.mTokenClient.GetAuthCode();
            }
            
            UnityEngine.Debug.Log(message:  "Cannot get API client - not authenticated");
            return 0;
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            this.mTokenClient.GetAnotherServerAuthCode(reAuthenticateIfNeeded:  reAuthenticateIfNeeded, callback:  GooglePlayGames.Android.AndroidClient.AsOnGameThreadCallback<System.String>(callback:  callback));
        }
        public bool IsAuthenticated()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.AuthStateLock, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.AuthStateLock);
            }
            
            if(0 != 1)
            {
                    return (bool)(this.mAuthState == 1) ? 1 : 0;
            }
            
            if(0 == 0)
            {
                    return (bool)(this.mAuthState == 1) ? 1 : 0;
            }
            
            return (bool)(this.mAuthState == 1) ? 1 : 0;
        }
        public void LoadFriends(System.Action<bool> callback)
        {
            var val_2;
            var val_3;
            System.Action<T> val_4;
            if(this.IsAuthenticated() != false)
            {
                    val_2 = 1152921541750673808;
                val_3 = 1;
                val_4 = callback;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Cannot loadFriends when not authenticated");
                val_2 = 1152921541750673808;
                val_4 = callback;
                val_3 = 0;
            }
            
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  val_4, data:  false);
        }
        public UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            UnityEngine.SocialPlatforms.IUserProfile[] val_1 = new UnityEngine.SocialPlatforms.IUserProfile[0];
        }
        public void SignOut()
        {
            this.SignOut(uiCallback:  0);
        }
        public void SignOut(System.Action uiCallback)
        {
            GooglePlayGames.Android.AndroidTokenClient val_8;
            var val_9;
            var val_10;
            var val_12;
            AndroidClient.<>c__DisplayClass33_0 val_1 = new AndroidClient.<>c__DisplayClass33_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .uiCallback = uiCallback;
            val_8 = this.mTokenClient;
            if(val_8 == null)
            {
                    return;
            }
            
            if(this.mInvitationCallback == null)
            {
                goto label_25;
            }
            
            val_8 = this.getInvitationsClient();
            object[] val_3 = new object[1];
            val_3[0] = this.mInvitationCallback;
            UnityEngine.AndroidJavaObject val_4 = val_8.Call<UnityEngine.AndroidJavaObject>(methodName:  "unregisterInvitationCallback", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass33_0::<SignOut>b__0(UnityEngine.AndroidJavaObject completedTask));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnCompleteListener<UnityEngine.AndroidJavaObject>(task:  val_4, callback:  null);
            val_9 = 0;
            val_10 = 0;
            if(val_4 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_4.Dispose();
            }
            
            if(val_9 == 1)
            {
                goto label_15;
            }
            
            val_12 = val_10;
            if(val_8 != null)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            if(val_10 != 0)
            {
                    val_10 = 0;
            }
            
            val_12 = 0;
            val_9 = 0;
            if(val_8 == null)
            {
                goto label_19;
            }
            
            label_16:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8.Dispose();
            label_19:
            if(val_9 != 1)
            {
                    return;
            }
            
            label_25:
            val_8 = this.mTokenClient;
            val_8.Signout();
            this.mAuthState = 0;
            if(((AndroidClient.<>c__DisplayClass33_0)[1152921541751130656].uiCallback) == null)
            {
                    return;
            }
            
            (AndroidClient.<>c__DisplayClass33_0)[1152921541751130656].uiCallback.Invoke();
        }
        public string GetUserId()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.id;
            }
            
            return this.mUser.id;
        }
        public string GetUserDisplayName()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.userName;
            }
            
            return this.mUser.userName;
        }
        public string GetUserImageUrl()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.AvatarURL;
            }
            
            return this.mUser.AvatarURL;
        }
        public void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity)
        {
            var val_8;
            var val_10;
            if(this.IsAuthenticated() != true)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Cannot call SetGravityForPopups when not authenticated");
            }
            
            UnityEngine.AndroidJavaObject val_2 = this.getGamesClient();
            object[] val_3 = new object[1];
            val_3[0] = gravity | 1;
            val_8 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "setGravityForPopups", args:  val_3);
            if(val_8 == null)
            {
                goto label_9;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_13;
            label_9:
            val_10 = 0;
            if(val_2 != null)
            {
                goto label_27;
            }
            
            goto label_28;
            label_13:
            val_8.Dispose();
            val_10 = 0;
            val_8 = 0;
            if(val_2 == null)
            {
                goto label_28;
            }
            
            label_27:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_2.Dispose();
            label_28:
            if(val_10 != 1)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            var val_9;
            var val_10;
            var val_12;
            AndroidClient.<>c__DisplayClass38_0 val_1 = new AndroidClient.<>c__DisplayClass38_0();
            .callback = callback;
            UnityEngine.AndroidJavaObject val_2 = this.getPlayerStatsClient();
            object[] val_3 = new object[1];
            val_3[0] = null;
            UnityEngine.AndroidJavaObject val_4 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadPlayerStats", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass38_0::<GetPlayerStats>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_4, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass38_0::<GetPlayerStats>b__1(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_4, callback:  null);
            val_9 = 0;
            val_10 = 0;
            if(val_4 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_4.Dispose();
            }
            
            if(val_9 == 1)
            {
                goto label_12;
            }
            
            val_12 = val_10;
            if(val_2 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_10 != 0)
            {
                    val_10 = 0;
            }
            
            val_12 = 0;
            val_9 = 0;
            if(val_2 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
            label_16:
            if(val_9 != 1)
            {
                    return;
            }
            
            if(val_12 == 0)
            {
                    return;
            }
        
        }
        public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
            var val_18;
            var val_19;
            var val_20;
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_25;
            System.Action<UnityEngine.AndroidJavaObject> val_26;
            int val_28;
            var val_31;
            AndroidClient.<>c__DisplayClass39_0 val_1 = new AndroidClient.<>c__DisplayClass39_0();
            if(val_1 != null)
            {
                    .userIds = userIds;
            }
            else
            {
                    mem[16] = userIds;
            }
            
            .callback = callback;
            if(this.IsAuthenticated() == false)
            {
                goto label_3;
            }
            
            val_19 = this.getPlayersClient();
            new AndroidClient.<>c__DisplayClass39_1() = new System.Object();
            .CS$<>8__locals1 = val_1;
            new System.Object() = new System.Object();
            .countLock = new System.Object();
            .resultCount = 0;
            .count = (AndroidClient.<>c__DisplayClass39_1)[1152921541752178224].CS$<>8__locals1.userIds.Length;
            int val_6 = ((AndroidClient.<>c__DisplayClass39_1)[1152921541752178224].CS$<>8__locals1.userIds.Length) & 4294967295;
            .users = new UnityEngine.SocialPlatforms.IUserProfile[0];
            new AndroidClient.<>c__DisplayClass39_2() = new System.Object();
            if((new AndroidClient.<>c__DisplayClass39_2()) == null)
            {
                goto label_7;
            }
            
            val_20 = new AndroidClient.<>c__DisplayClass39_2();
            .CS$<>8__locals2 = new AndroidClient.<>c__DisplayClass39_1();
            goto label_8;
            label_3:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<UnityEngine.SocialPlatforms.IUserProfile[]>(callback:  (AndroidClient.<>c__DisplayClass39_0)[1152921541752170032].callback, data:  new UnityEngine.SocialPlatforms.IUserProfile[0]);
            return;
            label_7:
            val_20 = 24;
            mem[24] = new AndroidClient.<>c__DisplayClass39_1();
            label_8:
            val_21 = 0;
            val_22 = 0;
            val_23 = 0;
            val_24 = 0;
            goto label_35;
            label_48:
            object[] val_10 = new object[1];
            val_25 = (AndroidClient.<>c__DisplayClass39_2)[1152921541752231472].i;
            System.String[] val_11 = .userIds + (((AndroidClient.<>c__DisplayClass39_2)[1152921541752231472].i) << 3);
            val_10[0] = mem[(userIds + ((AndroidClient.<>c__DisplayClass39_2)[1152921541752231472].i) << 3) + 32];
            UnityEngine.AndroidJavaObject val_12 = val_19.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadPlayer", args:  val_10);
            val_26 = mem[1152921541752178280];
            if(val_26 == 0)
            {
                    val_25 = mem[24];
                val_26 = null;
                val_26 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidClient.<>c__DisplayClass39_1(), method:  System.Void AndroidClient.<>c__DisplayClass39_1::<LoadUsers>b__0(UnityEngine.AndroidJavaObject annotatedData));
                mem[1152921541752178280] = val_26;
            }
            
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_12, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidClient.<>c__DisplayClass39_2(), method:  System.Void AndroidClient.<>c__DisplayClass39_2::<LoadUsers>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_12, callback:  null);
            val_24 = 1;
            if(val_12 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_12.Dispose();
            }
            
            if((val_24 == 1) || (278 != 278))
            {
                goto label_30;
            }
            
            var val_19 = 0;
            val_19 = val_19 ^ 0;
            val_24 = val_24 + val_19;
            if((new AndroidClient.<>c__DisplayClass39_2()) != null)
            {
                goto label_36;
            }
            
            label_37:
            val_28 = (AndroidClient.<>c__DisplayClass39_2)[1152921541752231472].i;
            goto label_32;
            label_30:
            if(val_23 == 0)
            {
                goto label_33;
            }
            
            val_22 = 0;
            val_23 = 0;
            if((new AndroidClient.<>c__DisplayClass39_2()) == null)
            {
                goto label_37;
            }
            
            label_36:
            val_28 = (AndroidClient.<>c__DisplayClass39_2)[1152921541752231472].i;
            label_32:
            val_21 = val_28 + 1;
            goto label_35;
            label_33:
            if((new AndroidClient.<>c__DisplayClass39_2()) != null)
            {
                goto label_36;
            }
            
            goto label_37;
            label_35:
            .i = val_21;
            if(val_21 < .count)
            {
                goto label_48;
            }
            
            val_31 = val_24 + 1;
            mem2[0] = 330;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_19.Dispose();
            }
            
            if(val_31 == 1)
            {
                goto label_80;
            }
            
            if(( == 0) || ((1152921541752084960 + ((val_24 + 1)) << 2) == 330))
            {
                goto label_82;
            }
            
            label_83:
            val_18 = ???;
            val_19 = ???;
            val_23 = ???;
            val_22 = ???;
            val_21 = ???;
            val_25 = ???;
            val_31 = ???;
            label_80:
            if(val_23 != 0)
            {
                goto label_83;
            }
            
            label_82:
            var val_17 = val_18 - 80;
        }
        public void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback)
        {
            var val_9;
            var val_10;
            var val_12;
            AndroidClient.<>c__DisplayClass40_0 val_1 = new AndroidClient.<>c__DisplayClass40_0();
            .callback = callback;
            UnityEngine.AndroidJavaObject val_2 = this.getAchievementsClient();
            object[] val_3 = new object[1];
            val_3[0] = null;
            UnityEngine.AndroidJavaObject val_4 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "load", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass40_0::<LoadAchievements>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_4, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass40_0::<LoadAchievements>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_4, callback:  null);
            val_9 = 0;
            val_10 = 0;
            if(val_4 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_4.Dispose();
            }
            
            if(val_9 == 1)
            {
                goto label_12;
            }
            
            val_12 = val_10;
            if(val_2 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_10 != 0)
            {
                    val_10 = 0;
            }
            
            val_12 = 0;
            val_9 = 0;
            if(val_2 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
            label_16:
            if(val_9 != 1)
            {
                    return;
            }
            
            if(val_12 == 0)
            {
                    return;
            }
        
        }
        public void UnlockAchievement(string achId, System.Action<bool> callback)
        {
            var val_11;
            var val_12;
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            val_11 = this.getAchievementsClient();
            object[] val_3 = new object[1];
            val_3[0] = achId;
            val_11.Call(methodName:  "unlock", args:  val_3);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            val_12 = 0;
            if(val_11 == null)
            {
                goto label_22;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_13;
            label_1:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            return;
            label_13:
            val_11.Dispose();
            label_22:
            if(val_12 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_11 = ???;
            val_12 = ???;
        }
        public void RevealAchievement(string achId, System.Action<bool> callback)
        {
            var val_11;
            var val_12;
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            val_11 = this.getAchievementsClient();
            object[] val_3 = new object[1];
            val_3[0] = achId;
            val_11.Call(methodName:  "reveal", args:  val_3);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            val_12 = 0;
            if(val_11 == null)
            {
                goto label_22;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_13;
            label_1:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            return;
            label_13:
            val_11.Dispose();
            label_22:
            if(val_12 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_11 = ???;
            val_12 = ???;
        }
        public void IncrementAchievement(string achId, int steps, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            UnityEngine.AndroidJavaObject val_2 = this.getAchievementsClient();
            object[] val_3 = new object[2];
            val_3[0] = achId;
            val_3[1] = steps;
            val_2.Call(methodName:  "increment", args:  val_3);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            if(val_2 == null)
            {
                goto label_27;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_16;
            label_1:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            return;
            label_16:
            val_2.Dispose();
            label_27:
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            UnityEngine.AndroidJavaObject val_2 = this.getAchievementsClient();
            val_2.Call(methodName:  "setSteps", args:  1152921505719563712);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            if(val_2 == null)
            {
                goto label_27;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_16;
            label_1:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            return;
            label_16:
            val_2.Dispose();
            label_27:
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    GooglePlayGames.Android.AndroidHelperFragment.ShowAchievementsUI(cb:  this.GetUiSignOutCallbackOnGameThread(callback:  callback));
                return;
            }
            
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.UIStatus>(callback:  callback, data:  -3);
        }
        public int LeaderboardMaxResults()
        {
            return (int)this.mLeaderboardMaxResults;
        }
        public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            System.Action<GooglePlayGames.BasicApi.UIStatus> val_2 = this.GetUiSignOutCallbackOnGameThread(callback:  callback);
            if(leaderboardId == null)
            {
                goto label_2;
            }
            
            GooglePlayGames.Android.AndroidHelperFragment.ShowLeaderboardUI(leaderboardId:  leaderboardId, timeSpan:  span, cb:  val_2);
            return;
            label_1:
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.UIStatus>(callback:  callback, data:  -3);
            return;
            label_2:
            GooglePlayGames.Android.AndroidHelperFragment.ShowAllLeaderboardsUI(cb:  val_2);
        }
        private System.Action<GooglePlayGames.BasicApi.UIStatus> GetUiSignOutCallbackOnGameThread(System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            AndroidClient.<>c__DisplayClass48_0 val_1 = new AndroidClient.<>c__DisplayClass48_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            return GooglePlayGames.Android.AndroidClient.AsOnGameThreadCallback<GooglePlayGames.BasicApi.UIStatus>(callback:  new System.Action<GooglePlayGames.BasicApi.UIStatus>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass48_0::<GetUiSignOutCallbackOnGameThread>b__0(GooglePlayGames.BasicApi.UIStatus status)));
        }
        public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            var val_12;
            object val_13;
            var val_14;
            var val_15;
            var val_17;
            AndroidClient.<>c__DisplayClass49_0 val_1 = new AndroidClient.<>c__DisplayClass49_0();
            if(val_1 != null)
            {
                    val_12 = val_1;
                .collection = collection;
                mem[1152921541753749744] = callback;
                mem[1152921541753749752] = this;
                val_13 = 1152921541753749768;
                mem[1152921541753749760] = leaderboardId;
            }
            else
            {
                    mem[16] = callback;
                mem[24] = this;
                val_13 = 32;
                mem[32] = leaderboardId;
                val_12 = 40;
                mem[40] = collection;
            }
            
            .timeSpan = timeSpan;
            UnityEngine.AndroidJavaObject val_2 = this.getLeaderboardsClient();
            object[] val_4 = new object[4];
            val_4[0] = val_13;
            val_4[1] = GooglePlayGames.Android.AndroidJavaConverter.ToLeaderboardVariantTimeSpan(span:  (AndroidClient.<>c__DisplayClass49_0)[1152921541753749728].timeSpan);
            val_4[2] = GooglePlayGames.Android.AndroidJavaConverter.ToLeaderboardVariantCollection(collection:  mem[40]);
            val_4[3] = rowCount;
            UnityEngine.AndroidJavaObject val_7 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  (start == 1) ? "loadTopScores" : "loadPlayerCenteredScores", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass49_0::<LoadScores>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass49_0::<LoadScores>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_7, callback:  null);
            val_14 = 0;
            val_15 = 0;
            if(val_7 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_7.Dispose();
            }
            
            if(val_14 == 1)
            {
                goto label_22;
            }
            
            val_17 = val_15;
            if(val_2 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_15 != 0)
            {
                    val_15 = 0;
            }
            
            val_17 = 0;
            val_14 = 0;
            if(val_2 == null)
            {
                goto label_26;
            }
            
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.Dispose();
            label_26:
            if(val_14 != 1)
            {
                    return;
            }
            
            if(val_17 == 0)
            {
                    return;
            }
        
        }
        public void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            var val_12;
            var val_13;
            var val_15;
            AndroidClient.<>c__DisplayClass50_0 val_1 = new AndroidClient.<>c__DisplayClass50_0();
            if(val_1 != null)
            {
                    .callback = callback;
                .<>4__this = this;
            }
            else
            {
                    mem[16] = callback;
                mem[24] = this;
            }
            
            .token = token;
            UnityEngine.AndroidJavaObject val_2 = this.getLeaderboardsClient();
            object[] val_3 = new object[3];
            val_3[0] = (AndroidClient.<>c__DisplayClass50_0)[1152921541753970496].token.InternalObject;
            val_3[1] = rowCount;
            val_3[2] = GooglePlayGames.Android.AndroidJavaConverter.ToPageDirection(direction:  (AndroidClient.<>c__DisplayClass50_0)[1152921541753970496].token.Direction);
            UnityEngine.AndroidJavaObject val_7 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMoreScores", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass50_0::<LoadMoreScores>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass50_0::<LoadMoreScores>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_7, callback:  null);
            val_12 = 0;
            val_13 = 0;
            if(val_7 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_7.Dispose();
            }
            
            if(val_12 == 1)
            {
                goto label_21;
            }
            
            val_15 = val_13;
            if(val_2 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_13 != 0)
            {
                    val_13 = 0;
            }
            
            val_15 = 0;
            val_12 = 0;
            if(val_2 == null)
            {
                goto label_25;
            }
            
            label_22:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.Dispose();
            label_25:
            if(val_12 != 1)
            {
                    return;
            }
            
            if(val_15 == 0)
            {
                    return;
            }
        
        }
        private GooglePlayGames.BasicApi.LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, GooglePlayGames.BasicApi.ResponseStatus status, UnityEngine.AndroidJavaObject leaderboardScoresJava)
        {
            var val_50;
            GooglePlayGames.BasicApi.LeaderboardTimeSpan val_52;
            string val_53;
            GooglePlayGames.BasicApi.LeaderboardScoreData val_54;
            var val_55;
            UnityEngine.AndroidJavaObject val_56;
            int val_57;
            var val_58;
            var val_61;
            System.Object[] val_64;
            string val_65;
            var val_66;
            var val_68;
            val_52 = timespan;
            val_53 = leaderboardId;
            GooglePlayGames.BasicApi.LeaderboardScoreData val_1 = null;
            val_54 = val_1;
            val_1 = new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  val_53, status:  status);
            val_55 = 1152921516266839504;
            val_56 = leaderboardScoresJava.Call<UnityEngine.AndroidJavaObject>(methodName:  "getScores", args:  System.Array.Empty<System.Object>());
            int val_5 = val_56.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>());
            if(val_5 < 1)
            {
                goto label_3;
            }
            
            object val_56 = 0;
            val_57 = 0;
            goto label_59;
            label_3:
            val_58 = 0;
            goto label_5;
            label_59:
            object[] val_6 = new object[1];
            if(val_6 == null)
            {
                goto label_27;
            }
            
            if(val_56 != 0)
            {
                goto label_28;
            }
            
            goto label_31;
            label_27:
            if(val_56 == 0)
            {
                goto label_31;
            }
            
            label_28:
            label_31:
            val_6[0] = val_56;
            UnityEngine.AndroidJavaObject val_7 = val_56.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_6);
            System.DateTime val_10 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  val_7.Call<System.Int64>(methodName:  "getTimestampMillis", args:  System.Array.Empty<System.Object>()));
            UnityEngine.AndroidJavaObject val_14 = val_7.Call<UnityEngine.AndroidJavaObject>(methodName:  "getScoreHolder", args:  System.Array.Empty<System.Object>());
            val_52 = val_14.Call<System.String>(methodName:  "getPlayerId", args:  System.Array.Empty<System.Object>());
            val_61 = 0 + 1;
            mem2[0] = 181;
            if(val_14 != null)
            {
                    var val_52 = 0;
                val_52 = val_52 + 1;
                val_14.Dispose();
            }
            
            if((val_61 != 1) && ((-1506767104 + ((0 + 1)) << 2) == 181))
            {
                    var val_53 = 0;
                val_53 = val_53 ^ (val_61 >> 31);
                val_61 = val_61 + val_53;
            }
            else
            {
                    val_57 = 0;
            }
            
            val_53 = val_53;
            val_54 = val_54;
            new GooglePlayGames.PlayGamesScore() = new GooglePlayGames.PlayGamesScore(date:  new System.DateTime() {dateData = val_10.dateData}, leaderboardId:  val_53, rank:  val_7.Call<System.Int64>(methodName:  "getRank", args:  System.Array.Empty<System.Object>()), playerId:  val_52, value:  val_7.Call<System.Int64>(methodName:  "getRawScore", args:  System.Array.Empty<System.Object>()), metadata:  val_7.Call<System.String>(methodName:  "getScoreTag", args:  System.Array.Empty<System.Object>()));
            int val_23 = val_1.AddScore(score:  new GooglePlayGames.PlayGamesScore());
            val_58 = val_61 + 1;
            mem2[0] = 256;
            val_55 = 1152921516266839504;
            if(val_7 != null)
            {
                    var val_54 = 0;
                val_54 = val_54 + 1;
                val_7.Dispose();
            }
            
            if((val_58 != 1) && ((-1506767104 + (((0 + 1) + 1)) << 2) == 256))
            {
                    val_56 = val_56;
                var val_55 = 0;
                val_55 = val_55 ^ (val_58 >> 31);
                val_58 = val_58 + val_55;
            }
            else
            {
                    val_56 = val_56;
            }
            
            val_56 = val_56 + 1;
            if(val_56 < val_5)
            {
                goto label_59;
            }
            
            label_5:
            val_1.NextPageToken = new GooglePlayGames.BasicApi.ScorePageToken(internalObject:  val_56, id:  val_53, collection:  collection, timespan:  val_52, direction:  1);
            val_1.PrevPageToken = new GooglePlayGames.BasicApi.ScorePageToken(internalObject:  val_56, id:  val_53, collection:  collection, timespan:  val_52, direction:  2);
            UnityEngine.AndroidJavaObject val_28 = leaderboardScoresJava.Call<UnityEngine.AndroidJavaObject>(methodName:  "getLeaderboard", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaObject val_30 = val_28.Call<UnityEngine.AndroidJavaObject>(methodName:  "getVariants", args:  System.Array.Empty<System.Object>());
            object[] val_31 = new object[1];
            val_64 = val_31;
            val_64[0] = 0;
            UnityEngine.AndroidJavaObject val_32 = val_30.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_31);
            val_65 = 1152921516267678832;
            val_1.Title = val_28.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>());
            if((val_32.Call<System.Boolean>(methodName:  "hasPlayerInfo", args:  System.Array.Empty<System.Object>())) != false)
            {
                    System.DateTime val_37 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  0);
                val_64 = val_32.Call<System.Int64>(methodName:  "getPlayerRank", args:  System.Array.Empty<System.Object>());
                val_65 = val_32.Call<System.String>(methodName:  "getPlayerScoreTag", args:  System.Array.Empty<System.Object>());
                val_54 = val_54;
                new GooglePlayGames.PlayGamesScore() = new GooglePlayGames.PlayGamesScore(date:  new System.DateTime() {dateData = val_37.dateData}, leaderboardId:  val_53, rank:  val_64, playerId:  mem[1152921541754797864].id, value:  val_32.Call<System.Int64>(methodName:  "getRawPlayerScore", args:  System.Array.Empty<System.Object>()), metadata:  val_65);
                val_1.PlayerScore = new GooglePlayGames.PlayGamesScore();
            }
            
            val_1.ApproximateCount = val_32.Call<System.Int64>(methodName:  "getNumScores", args:  System.Array.Empty<System.Object>());
            val_66 = val_58 + 1;
            mem2[0] = 568;
            if(val_32 != null)
            {
                    var val_57 = 0;
                val_57 = val_57 + 1;
                val_32.Dispose();
            }
            
            if(val_66 == 1)
            {
                goto label_85;
            }
            
            val_68 = 0;
            if(val_68 != 0)
            {
                    if((-1506767104 + ((((0 + 1) + 1) + 1)) << 2) != 568)
            {
                goto label_87;
            }
            
            }
            
            if(val_30 != null)
            {
                goto label_145;
            }
            
            goto label_146;
            label_85:
            val_68 = 0;
            if(val_68 == 0)
            {
                goto label_90;
            }
            
            label_87:
            val_68 = 0;
            if(val_30 != null)
            {
                goto label_145;
            }
            
            goto label_146;
            label_90:
            val_66 = 0;
            if(val_30 == null)
            {
                goto label_146;
            }
            
            label_145:
            var val_58 = 0;
            val_58 = val_58 + 1;
            val_30.Dispose();
            label_146:
            if(val_66 == 1)
            {
                goto label_98;
            }
            
            if(val_68 == 0)
            {
                goto label_101;
            }
            
            if(val_50 != 568)
            {
                goto label_100;
            }
            
            goto label_101;
            label_98:
            if(val_68 == 0)
            {
                goto label_102;
            }
            
            label_100:
            val_68 = 0;
            label_101:
            if(val_28 == null)
            {
                goto label_149;
            }
            
            label_148:
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_28.Dispose();
            label_149:
            if(val_66 != 1)
            {
                    if(val_68 == 0)
            {
                    return val_54;
            }
            
                if(val_50 == 568)
            {
                    return val_54;
            }
            
                return val_54;
            }
            
            if(val_68 != 0)
            {
                    return val_54;
            }
            
            return val_54;
            label_102:
            if(val_28 != null)
            {
                goto label_148;
            }
            
            goto label_149;
        }
        public void SubmitScore(string leaderboardId, long score, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != true)
            {
                    GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            }
            
            UnityEngine.AndroidJavaObject val_2 = this.getLeaderboardsClient();
            object[] val_3 = new object[2];
            val_3[0] = leaderboardId;
            val_3[1] = score;
            val_2.Call(methodName:  "submitScore", args:  val_3);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            if(val_2 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_2.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != true)
            {
                    GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  false);
            }
            
            UnityEngine.AndroidJavaObject val_2 = this.getLeaderboardsClient();
            object[] val_3 = new object[3];
            val_3[0] = leaderboardId;
            val_3[1] = score;
            val_3[2] = metadata;
            val_2.Call(methodName:  "submitScore", args:  val_3);
            GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean>(callback:  callback, data:  true);
            if(val_2 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_2.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient()
        {
            GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient val_3;
            if(this.IsAuthenticated() != false)
            {
                    bool val_2 = false;
                System.Threading.Monitor.Enter(obj:  this.GameServicesLock, lockTaken: ref  val_2);
                val_3 = this.mRealTimeClient;
                if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.GameServicesLock);
            }
            
                if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_3;
            }
            
                if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_3;
            }
            
                return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_3;
            }
            
            val_3 = 0;
            return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_3;
        }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.GameServicesLock, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.GameServicesLock);
            }
            
            if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient)this.mTurnBasedClient;
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient)this.mTurnBasedClient;
            }
            
            return (GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient)this.mTurnBasedClient;
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.GameServicesLock, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.GameServicesLock);
            }
            
            if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)this.mSavedGameClient;
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)this.mSavedGameClient;
            }
            
            return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)this.mSavedGameClient;
        }
        public GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.GameServicesLock, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.GameServicesLock);
            }
            
            if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.Events.IEventsClient)this.mEventsClient;
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Events.IEventsClient)this.mEventsClient;
            }
            
            return (GooglePlayGames.BasicApi.Events.IEventsClient)this.mEventsClient;
        }
        public GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.GameServicesLock, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.GameServicesLock);
            }
            
            if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.Video.IVideoClient)this.mVideoClient;
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Video.IVideoClient)this.mVideoClient;
            }
            
            return (GooglePlayGames.BasicApi.Video.IVideoClient)this.mVideoClient;
        }
        public void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate)
        {
            GooglePlayGames.BasicApi.InvitationReceivedDelegate val_4;
            System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean> val_5;
            val_4 = invitationDelegate;
            AndroidClient.<>c__DisplayClass59_0 val_1 = new AndroidClient.<>c__DisplayClass59_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .invitationDelegate = val_4;
            if(val_4 == null)
            {
                goto label_2;
            }
            
            label_6:
            System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean>(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass59_0::<RegisterInvitationDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool autoAccept));
            val_5 = GooglePlayGames.Android.AndroidClient.AsOnGameThreadCallback<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean>(toInvokeOnGameThread:  val_2);
            goto label_5;
            label_1:
            mem[16] = val_4;
            val_4 = mem[16];
            if(val_4 != 0)
            {
                goto label_6;
            }
            
            label_2:
            val_5 = 0;
            label_5:
            this.mInvitationDelegate = val_5;
        }
        private UnityEngine.AndroidJavaObject getAchievementsClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getAchievementsClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getAchievementsClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getGamesClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getGamesClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getGamesClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getInvitationsClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInvitationsClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInvitationsClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getPlayersClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getPlayersClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getPlayersClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getLeaderboardsClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getLeaderboardsClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getLeaderboardsClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getPlayerStatsClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getPlayerStatsClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getPlayerStatsClient", args:  val_1);
        }
        private UnityEngine.AndroidJavaObject getVideosClient()
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.mTokenClient.GetAccount();
            if(this.mGamesClass != null)
            {
                    return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getVideosClient", args:  val_1);
            }
            
            return this.mGamesClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getVideosClient", args:  val_1);
        }
        private static AndroidClient()
        {
            GooglePlayGames.Android.AndroidClient.TasksClassName = "com.google.android.gms.tasks.Tasks";
        }
    
    }

}
