using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesPlatform : ISocialPlatform
    {
        // Fields
        private static GooglePlayGames.PlayGamesPlatform sInstance;
        private static bool sNearbyInitializePending;
        private static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient sNearbyConnectionClient;
        private readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
        private GooglePlayGames.PlayGamesLocalUser mLocalUser;
        private GooglePlayGames.BasicApi.IPlayGamesClient mClient;
        private string mDefaultLbUi;
        private System.Collections.Generic.Dictionary<string, string> mIdMap;
        
        // Properties
        public static bool DebugLogEnabled { get; set; }
        public static GooglePlayGames.PlayGamesPlatform Instance { get; }
        public static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient Nearby { get; }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient RealTime { get; }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient TurnBased { get; }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient SavedGame { get; }
        public GooglePlayGames.BasicApi.Events.IEventsClient Events { get; }
        public GooglePlayGames.BasicApi.Video.IVideoClient Video { get; }
        public UnityEngine.SocialPlatforms.ILocalUser localUser { get; }
        
        // Methods
        internal PlayGamesPlatform(GooglePlayGames.BasicApi.IPlayGamesClient client)
        {
            var val_4;
            this.mIdMap = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.mClient = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  client);
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
            val_4 = null;
            val_4 = null;
            this.mConfiguration = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration;
            mem[1152921541731778368] = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10;
            mem[1152921541731778384] = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20;
        }
        private PlayGamesPlatform(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration)
        {
            this.mIdMap = new System.Collections.Generic.Dictionary<System.String, System.String>();
            GooglePlayGames.OurUtils.Logger.w(msg:  "Creating new PlayGamesPlatform");
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
            mem[1152921541731968320] = configuration.mRequestAuthCode;
            mem[1152921541731968336] = configuration.mInvitationDelegate;
            this.mConfiguration = configuration.mEnableSavedGames;
        }
        public static bool get_DebugLogEnabled()
        {
            return GooglePlayGames.OurUtils.Logger.DebugLogEnabled;
        }
        public static void set_DebugLogEnabled(bool value)
        {
            GooglePlayGames.OurUtils.Logger.DebugLogEnabled = value;
        }
        public static GooglePlayGames.PlayGamesPlatform get_Instance()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            if(GooglePlayGames.PlayGamesPlatform.sInstance == null)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Instance was not initialized, using default configuration.");
                val_3 = null;
                val_3 = null;
                GooglePlayGames.PlayGamesPlatform.InitializeInstance(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration, mScopes = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration, mRequestAuthCode = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mForceRefresh = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mHidePopups = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mRequestEmail = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mRequestIdToken = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mAccountName = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mInvitationDelegate = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20});
            }
            
            val_4 = null;
            val_4 = null;
            return (GooglePlayGames.PlayGamesPlatform)GooglePlayGames.PlayGamesPlatform.sInstance;
        }
        public static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient get_Nearby()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            if(GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient == null)
            {
                    val_2 = null;
                val_2 = null;
                if(GooglePlayGames.PlayGamesPlatform.sNearbyInitializePending != true)
            {
                    GooglePlayGames.PlayGamesPlatform.sNearbyInitializePending = true;
                GooglePlayGames.PlayGamesPlatform.InitializeNearby(callback:  0);
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return (GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient)GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient;
        }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient get_RealTime()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetRtmpClient();
        }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient get_TurnBased()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetTbmpClient();
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient get_SavedGame()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetSavedGameClient();
        }
        public GooglePlayGames.BasicApi.Events.IEventsClient get_Events()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetEventsClient();
        }
        public GooglePlayGames.BasicApi.Video.IVideoClient get_Video()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetVideoClient();
        }
        public UnityEngine.SocialPlatforms.ILocalUser get_localUser()
        {
            return (UnityEngine.SocialPlatforms.ILocalUser)this.mLocalUser;
        }
        public static void InitializeInstance(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration)
        {
            var val_3;
            GooglePlayGames.PlayGamesPlatform val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = GooglePlayGames.PlayGamesPlatform.sInstance;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            val_5 = null;
            val_5 = null;
            if((GooglePlayGames.BasicApi.PlayGamesClientConfiguration.op_Inequality(c1:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = false, mScopes = 1152921505393160192, mRequestAuthCode = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mForceRefresh = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mHidePopups = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mRequestEmail = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mRequestIdToken = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mAccountName = GooglePlayGames.PlayGamesPlatform.sInstance + 32, mInvitationDelegate = GooglePlayGames.PlayGamesPlatform.sInstance + 48, mMatchDelegate = GooglePlayGames.PlayGamesPlatform.sInstance + 48}, c2:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = configuration.mEnableSavedGames, mRequestAuthCode = configuration.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = configuration.mInvitationDelegate, mMatchDelegate = configuration.mInvitationDelegate})) == false)
            {
                goto label_9;
            }
            
            label_3:
            GooglePlayGames.PlayGamesPlatform val_2 = null;
            val_2 = new GooglePlayGames.PlayGamesPlatform(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = configuration.mEnableSavedGames, mRequestAuthCode = configuration.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = configuration.mInvitationDelegate, mMatchDelegate = configuration.mInvitationDelegate});
            GooglePlayGames.PlayGamesPlatform.sInstance = val_2;
            return;
            label_9:
            GooglePlayGames.OurUtils.Logger.w(msg:  "PlayGamesPlatform already initialized. Ignoring this call.");
        }
        public static void InitializeNearby(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
            var val_3;
            var val_4;
            .callback = callback;
            UnityEngine.Debug.Log(message:  "Calling InitializeNearby!");
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient == null)
            {
                goto label_6;
            }
            
            if(((PlayGamesPlatform.<>c__DisplayClass30_0)[1152921541733598192].callback) == null)
            {
                goto label_7;
            }
            
            UnityEngine.Debug.Log(message:  "Nearby Already initialized: calling callback directly");
            val_4 = null;
            val_4 = null;
            (PlayGamesPlatform.<>c__DisplayClass30_0)[1152921541733598192].callback.Invoke(obj:  GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient);
            return;
            label_6:
            GooglePlayGames.NearbyConnectionClientFactory.Create(callback:  new System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient>(object:  new PlayGamesPlatform.<>c__DisplayClass30_0(), method:  System.Void PlayGamesPlatform.<>c__DisplayClass30_0::<InitializeNearby>b__0(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)));
            return;
            label_7:
            UnityEngine.Debug.Log(message:  "Nearby Already initialized");
        }
        public static GooglePlayGames.PlayGamesPlatform Activate()
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  "Activating PlayGamesPlatform.");
            UnityEngine.Social.Active = GooglePlayGames.PlayGamesPlatform.Instance;
            GooglePlayGames.OurUtils.Logger.d(msg:  "PlayGamesPlatform activated: "("PlayGamesPlatform activated: ") + UnityEngine.Social.Active);
            return GooglePlayGames.PlayGamesPlatform.Instance;
        }
        public void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.mClient.SetGravityForPopups(gravity:  gravity);
        }
        public void AddIdMapping(string fromId, string toId)
        {
            this.mIdMap.set_Item(key:  fromId, value:  toId);
        }
        public void Authenticate(System.Action<bool> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool, string> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool> callback, bool silent)
        {
            .callback = callback;
            this.Authenticate(callback:  new System.Action<System.Boolean, System.String>(object:  new PlayGamesPlatform.<>c__DisplayClass36_0(), method:  System.Void PlayGamesPlatform.<>c__DisplayClass36_0::<Authenticate>b__0(bool success, string msg)), silent:  silent);
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_3 = this.mClient;
            if(val_3 == null)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Creating platform-specific Play Games client.");
                val_3 = GooglePlayGames.PlayGamesClientFactory.GetPlatformPlayGamesClient(config:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = this.mConfiguration, mScopes = this.mConfiguration, mRequestAuthCode = ???, mForceRefresh = ???, mHidePopups = ???, mRequestEmail = ???, mRequestIdToken = ???, mAccountName = ???, mInvitationDelegate = ???, mMatchDelegate = ???});
                this.mClient = val_3;
                if(val_3 == null)
            {
                goto label_9;
            }
            
            }
            
            label_9:
            var val_3 = 0;
            val_3 = val_3 + 1;
            silent = silent;
            val_3.Authenticate(callback:  callback, silent:  silent);
        }
        public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool, string> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public bool IsAuthenticated()
        {
            if(this.mClient == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.IsAuthenticated();
        }
        public void SignOut()
        {
            if(this.mClient != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                this.mClient.SignOut();
            }
            
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
        }
        public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "GetUserId() can only be called after authentication.");
                callback.Invoke(obj:  new UnityEngine.SocialPlatforms.IUserProfile[0]);
                return;
            }
            
            this.mClient.LoadUsers(userIds:  userIds, callback:  callback);
        }
        public string GetUserId()
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                return this.mClient.GetUserId();
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "GetUserId() can only be called after authentication.");
            return "0";
        }
        public string GetIdToken()
        {
            if(this.mClient != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                return this.mClient.GetIdToken();
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "No client available, returning null.");
            return 0;
        }
        public string GetServerAuthCode()
        {
            if(this.mClient == null)
            {
                    return 0;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            if(this.mClient.IsAuthenticated() == false)
            {
                    return 0;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            return this.mClient.GetServerAuthCode();
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            object val_15;
            System.Action<System.String> val_16;
            var val_17;
            GooglePlayGames.BasicApi.IPlayGamesClient val_19;
            System.Action<System.Boolean, System.String> val_22;
            var val_23;
            PlayGamesPlatform.<>c__DisplayClass46_0 val_1 = null;
            val_15 = val_1;
            val_1 = new PlayGamesPlatform.<>c__DisplayClass46_0();
            if(val_15 != null)
            {
                    val_16 = val_15;
                .callback = callback;
            }
            else
            {
                    val_16 = 16;
                mem[16] = callback;
            }
            
            .<>4__this = this;
            if(this.mClient == null)
            {
                goto label_16;
            }
            
            var val_7 = 0;
            val_17 = 1152921505392984072;
            val_7 = val_7 + 1;
            val_17 = 1152921505392984088;
            val_19 = this.mClient;
            if(this.mClient.IsAuthenticated() == false)
            {
                goto label_8;
            }
            
            var val_8 = 0;
            val_17 = 1152921505392984072;
            val_8 = val_8 + 1;
            val_17 = 1152921505392984088;
            goto label_14;
            label_8:
            if((val_19 == null) || (reAuthenticateIfNeeded == false))
            {
                goto label_16;
            }
            
            System.Action<System.Boolean, System.String> val_4 = null;
            val_22 = val_4;
            val_23 = public System.Void System.Action<System.Boolean, System.String>::.ctor(object object, IntPtr method);
            val_4 = new System.Action<System.Boolean, System.String>(object:  val_1, method:  System.Void PlayGamesPlatform.<>c__DisplayClass46_0::<GetAnotherServerAuthCode>b__0(bool success, string msg));
            var val_9 = 0;
            val_17 = 1152921505392984072;
            val_9 = val_9 + 1;
            goto label_20;
            label_16:
            GooglePlayGames.OurUtils.Logger.e(msg:  "Cannot call GetAnotherServerAuthCode: not authenticated");
            mem[16].Invoke(obj:  0);
            return;
            label_14:
            val_23 = public System.Void GooglePlayGames.BasicApi.IPlayGamesClient::GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
            val_19 = ???;
            val_22 = ???;
            val_15 = ???;
            val_16 = ???;
            val_19.GetAnotherServerAuthCode(reAuthenticateIfNeeded:  reAuthenticateIfNeeded, callback:  val_16);
            return;
            label_20:
            val_19.Authenticate(callback:  val_4, silent:  false);
        }
        public string GetUserEmail()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.mClient.GetUserEmail();
        }
        public void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            var val_4;
            if(this.mClient == null)
            {
                goto label_6;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            if(this.mClient.IsAuthenticated() == false)
            {
                goto label_6;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4 = 11;
            goto label_11;
            label_6:
            GooglePlayGames.OurUtils.Logger.e(msg:  "GetPlayerStats can only be called after authentication.");
            .mValid = false;
            callback.Invoke(arg1:  4, arg2:  new GooglePlayGames.BasicApi.PlayerStats());
            return;
            label_11:
            this.mClient.GetPlayerStats(callback:  callback);
        }
        public string GetUserDisplayName()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                return this.mClient.GetUserDisplayName();
            }
            
            val_4 = null;
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            return (string)System.String.alignConst;
        }
        public string GetUserImageUrl()
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                return this.mClient.GetUserImageUrl();
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "GetUserImageUrl can only be called after authentication.");
            return 0;
        }
        public void ReportProgress(string achievementID, double progress, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_11;
            string val_12;
            var val_13;
            object val_14;
            double val_15;
            System.Action<T> val_16;
            IntPtr val_17;
            val_11 = callback;
            PlayGamesPlatform.<>c__DisplayClass51_0 val_1 = null;
            val_12 = val_1;
            val_1 = new PlayGamesPlatform.<>c__DisplayClass51_0();
            if(val_12 != null)
            {
                    val_13 = val_12;
                .callback = val_11;
                val_14 = 1152921541736450488;
                val_15 = 1152921541736450488;
                mem[1152921541736450464] = achievementID;
                mem[1152921541736450472] = progress;
                mem[1152921541736450480] = this;
            }
            else
            {
                    val_14 = 16;
                mem[16] = achievementID;
                val_15 = 1.18575755001899E-322;
                mem[24] = progress;
                mem[32] = this;
                val_13 = 40;
                mem[40] = val_11;
                val_11 = mem[40];
            }
            
            mem[40] = GooglePlayGames.PlayGamesPlatform.ToOnGameThread<System.Boolean>(toConvert:  val_11);
            if(this.IsAuthenticated() == false)
            {
                goto label_6;
            }
            
            object[] val_4 = new object[4];
            val_4[0] = "ReportProgress, ";
            val_4[1] = val_14;
            val_4[2] = ", ";
            val_4[3] = val_15;
            GooglePlayGames.OurUtils.Logger.d(msg:  +val_4);
            if(val_12 == null)
            {
                goto label_24;
            }
            
            mem[16] = this.MapId(id:  mem[16]);
            goto label_25;
            label_6:
            GooglePlayGames.OurUtils.Logger.e(msg:  "ReportProgress can only be called after authentication.");
            mem[40].Invoke(obj:  false);
            return;
            label_24:
            mem[16] = this.MapId(id:  mem[16]);
            label_25:
            if(mem[24] >= 0)
            {
                goto label_30;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  "Progress 0.00 interpreted as request to reveal.");
            if(val_12 == null)
            {
                goto label_33;
            }
            
            val_12 = mem[16];
            goto label_34;
            label_30:
            System.Action<GooglePlayGames.BasicApi.Achievement[]> val_8 = null;
            val_16 = val_8;
            val_17 = System.Void PlayGamesPlatform.<>c__DisplayClass51_0::<ReportProgress>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
            val_8 = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  val_1, method:  val_17);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_17 = 13;
            goto label_39;
            label_33:
            val_12 = mem[16];
            label_34:
            val_16 = mem[40];
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_44;
            label_39:
            this.mClient.LoadAchievements(callback:  val_8);
            return;
            label_44:
            this.mClient.RevealAchievement(achievementId:  val_12, successOrFailureCalllback:  val_16);
        }
        public void RevealAchievement(string achievementID, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "RevealAchievement: "("RevealAchievement: ") + achievementID);
                var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "RevealAchievement can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.RevealAchievement(achievementId:  this.MapId(id:  achievementID), successOrFailureCalllback:  callback);
        }
        public void UnlockAchievement(string achievementID, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "UnlockAchievement: "("UnlockAchievement: ") + achievementID);
                var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "UnlockAchievement can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.UnlockAchievement(achievementId:  this.MapId(id:  achievementID), successOrFailureCalllback:  callback);
        }
        public void IncrementAchievement(string achievementID, int steps, System.Action<bool> callback)
        {
            string val_6;
            if(this.IsAuthenticated() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "IncrementAchievement: ";
                val_2[1] = achievementID;
                val_2[2] = ", steps ";
                val_2[3] = steps;
                val_6 = +val_2;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                this = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "IncrementAchievement can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.IncrementAchievement(achievementId:  this, steps:  steps, successOrFailureCalllback:  callback);
        }
        public void SetStepsAtLeast(string achievementID, int steps, System.Action<bool> callback)
        {
            string val_6;
            if(this.IsAuthenticated() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "SetStepsAtLeast: ";
                val_2[1] = achievementID;
                val_2[2] = ", steps ";
                val_2[3] = steps;
                val_6 = +val_2;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                this = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "SetStepsAtLeast can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.SetStepsAtLeast(achId:  this, steps:  steps, callback:  callback);
        }
        public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
        {
            IntPtr val_5;
            .callback = callback;
            if(this.IsAuthenticated() != false)
            {
                    System.Action<GooglePlayGames.BasicApi.Achievement[]> val_3 = null;
                val_5 = System.Void PlayGamesPlatform.<>c__DisplayClass56_0::<LoadAchievementDescriptions>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
                val_3 = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  new PlayGamesPlatform.<>c__DisplayClass56_0(), method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 13;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "LoadAchievementDescriptions can only be called after authentication.");
                if(((PlayGamesPlatform.<>c__DisplayClass56_0)[1152921541737275472].callback) == null)
            {
                    return;
            }
            
                (PlayGamesPlatform.<>c__DisplayClass56_0)[1152921541737275472].callback.Invoke(obj:  0);
                return;
            }
            
            this.mClient.LoadAchievements(callback:  val_3);
        }
        public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
        {
            IntPtr val_5;
            .callback = callback;
            if(this.IsAuthenticated() != false)
            {
                    System.Action<GooglePlayGames.BasicApi.Achievement[]> val_3 = null;
                val_5 = System.Void PlayGamesPlatform.<>c__DisplayClass57_0::<LoadAchievements>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
                val_3 = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  new PlayGamesPlatform.<>c__DisplayClass57_0(), method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 13;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "LoadAchievements can only be called after authentication.");
                (PlayGamesPlatform.<>c__DisplayClass57_0)[1152921541737429680].callback.Invoke(obj:  0);
                return;
            }
            
            this.mClient.LoadAchievements(callback:  val_3);
        }
        public UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
        {
            return (UnityEngine.SocialPlatforms.IAchievement)new GooglePlayGames.PlayGamesAchievement();
        }
        public void ReportScore(long score, string board, System.Action<bool> callback)
        {
            string val_6;
            string val_7 = board;
            if(this.IsAuthenticated() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "ReportScore: score=";
                val_2[1] = score;
                val_2[2] = ", board=";
                val_2[3] = val_7;
                val_6 = +val_2;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                val_7 = this.MapId(id:  val_7 = board);
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "ReportScore can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.SubmitScore(leaderboardId:  val_7, score:  score, successOrFailureCalllback:  callback);
        }
        public void ReportScore(long score, string board, string metadata, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    object[] val_2 = new object[6];
                val_2[0] = "ReportScore: score=";
                val_2[1] = score;
                val_2[2] = ", board=";
                val_2[3] = board;
                val_2[4] = " metadata=";
                val_2[5] = metadata;
                GooglePlayGames.OurUtils.Logger.d(msg:  +val_2);
                this = this.mClient;
                var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "ReportScore can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.SubmitScore(leaderboardId:  this.MapId(id:  board), score:  score, metadata:  metadata, successOrFailureCalllback:  callback);
        }
        public void LoadScores(string leaderboardId, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
        {
            .callback = callback;
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.LoadScores(leaderboardId:  leaderboardId, start:  2, rowCount:  this.mClient.LeaderboardMaxResults(), collection:  1, timeSpan:  3, callback:  new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  new PlayGamesPlatform.<>c__DisplayClass61_0(), method:  System.Void PlayGamesPlatform.<>c__DisplayClass61_0::<LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)));
        }
        public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "LoadScores can only be called after authentication.");
                callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  leaderboardId, status:  -3));
                return;
            }
            
            this.mClient.LoadScores(leaderboardId:  leaderboardId, start:  start, rowCount:  rowCount, collection:  collection, timeSpan:  timeSpan, callback:  callback);
        }
        public void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "LoadMoreScores can only be called after authentication.");
                callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  token.mId, status:  -3));
                return;
            }
            
            this.mClient.LoadMoreScores(token:  token, rowCount:  rowCount, callback:  callback);
        }
        public UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
        {
            return (UnityEngine.SocialPlatforms.ILeaderboard)new GooglePlayGames.PlayGamesLeaderboard(id:  this.mDefaultLbUi);
        }
        public void ShowAchievementsUI()
        {
            this.ShowAchievementsUI(callback:  0);
        }
        public void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    val_4 = 0;
                GooglePlayGames.OurUtils.Logger.d(msg:  "ShowAchievementsUI callback is " + callback);
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = 18;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "ShowAchievementsUI can only be called after authentication.");
                return;
            }
            
            this.mClient.ShowAchievementsUI(callback:  callback);
        }
        public void ShowLeaderboardUI()
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  "ShowLeaderboardUI with default ID");
            this.ShowLeaderboardUI(leaderboardId:  this.MapId(id:  this.mDefaultLbUi), span:  3, callback:  0);
        }
        public void ShowLeaderboardUI(string leaderboardId)
        {
            string val_3 = leaderboardId;
            if(val_3 != null)
            {
                    val_3 = this.MapId(id:  val_3 = leaderboardId);
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mClient.ShowLeaderboardUI(leaderboardId:  val_3, span:  3, callback:  0);
        }
        public void ShowLeaderboardUI(string leaderboardId, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            this.ShowLeaderboardUI(leaderboardId:  leaderboardId, span:  3, callback:  callback);
        }
        public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "ShowLeaderboardUI, lbId=";
                val_2[1] = leaderboardId;
                val_2[2] = " callback is ";
                val_2[3] = callback;
                GooglePlayGames.OurUtils.Logger.d(msg:  +val_2);
                var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "ShowLeaderboardUI can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  -3);
                return;
            }
            
            this.mClient.ShowLeaderboardUI(leaderboardId:  leaderboardId, span:  span, callback:  callback);
        }
        public void SetDefaultLeaderboardForUI(string lbid)
        {
            string val_3;
            GooglePlayGames.OurUtils.Logger.d(msg:  "SetDefaultLeaderboardForUI: "("SetDefaultLeaderboardForUI: ") + lbid);
            if(lbid != null)
            {
                    string val_2 = this.MapId(id:  lbid);
            }
            else
            {
                    val_3 = 0;
            }
            
            this.mDefaultLbUi = val_3;
        }
        public void LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "LoadScores can only be called after authentication.");
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
            
            this.mClient.LoadFriends(callback:  callback);
        }
        public void LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback)
        {
            GooglePlayGames.PlayGamesPlatform val_24;
            GooglePlayGames.BasicApi.LeaderboardTimeSpan val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_31;
            var val_32;
            val_24 = this;
            PlayGamesPlatform.<>c__DisplayClass73_0 val_1 = new PlayGamesPlatform.<>c__DisplayClass73_0();
            if(val_1 != null)
            {
                    val_25 = val_1;
                .board = board;
                mem[1152921541739761952] = val_24;
            }
            else
            {
                    mem[16] = val_24;
                val_25 = 24;
                mem[24] = board;
            }
            
            .callback = callback;
            if(this.IsAuthenticated() == false)
            {
                goto label_3;
            }
            
            var val_26 = val_25;
            if((board + 286) == 0)
            {
                goto label_8;
            }
            
            var val_23 = board + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_7:
            if(((board + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (board + 286))
            {
                goto label_7;
            }
            
            goto label_8;
            label_3:
            GooglePlayGames.OurUtils.Logger.e(msg:  "LoadScores can only be called after authentication.");
            if(((PlayGamesPlatform.<>c__DisplayClass73_0)[1152921541739761936].callback) == null)
            {
                    return;
            }
            
            (PlayGamesPlatform.<>c__DisplayClass73_0)[1152921541739761936].callback.Invoke(obj:  false);
            return;
            label_6:
            var val_25 = val_23;
            val_25 = val_25 + 5;
            val_26 = val_26 + val_25;
            val_26 = val_26 + 296;
            label_8:
            UnityEngine.SocialPlatforms.TimeScope val_3 = val_25.timeScope;
            val_25 = (val_3 != 0) ? ((val_3 != 1) ? (2 + 1) : 2) : (0 + 1);
            mem2[0] = 1;
            object[] val_8 = new object[4];
            val_8[0] = "LoadScores, board=";
            val_8[1] = mem[24];
            val_8[2] = " callback is ";
            val_8[3] = (PlayGamesPlatform.<>c__DisplayClass73_0)[1152921541739761936].callback;
            GooglePlayGames.OurUtils.Logger.d(msg:  +val_8);
            var val_30 = mem[24];
            if((board + 286) == 0)
            {
                goto label_39;
            }
            
            var val_27 = board + 176;
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_38:
            if(((board + 176 + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < (board + 286))
            {
                goto label_38;
            }
            
            goto label_39;
            label_37:
            var val_29 = val_27;
            val_29 = val_29 + 2;
            val_30 = val_30 + val_29;
            val_27 = val_30 + 296;
            label_39:
            var val_34 = mem[24];
            if((board + 286) == 0)
            {
                goto label_45;
            }
            
            var val_31 = board + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_44:
            if(((board + 176 + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (board + 286))
            {
                goto label_44;
            }
            
            goto label_45;
            label_43:
            var val_33 = val_31;
            val_33 = val_33 + 4;
            val_34 = val_34 + val_33;
            val_28 = val_34 + 296;
            label_45:
            UnityEngine.SocialPlatforms.Range val_11 = mem[24].range;
            int val_12 = val_11.from >> 32;
            var val_14 = (val_12 > 0) ? this.mClient : 0;
            if(val_12 <= 0)
            {
                goto label_46;
            }
            
            var val_39 = mem[24];
            val_24 = ((val_12 > 0) ? 1 : 0) << 1;
            if((board + 286) == 0)
            {
                goto label_52;
            }
            
            var val_35 = board + 176;
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_51:
            if(((board + 176 + 8) + -8) == null)
            {
                goto label_50;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (board + 286))
            {
                goto label_51;
            }
            
            goto label_52;
            label_46:
            var val_37 = 0;
            val_37 = val_37 + 1;
            goto label_57;
            label_50:
            var val_38 = val_35;
            val_38 = val_38 + 4;
            val_39 = val_39 + val_38;
            val_29 = val_39 + 296;
            label_52:
            UnityEngine.SocialPlatforms.Range val_16 = mem[24].range;
            if(val_1 != null)
            {
                goto label_69;
            }
            
            label_70:
            label_69:
            var val_43 = mem[24];
            if((board + 286) == 0)
            {
                goto label_63;
            }
            
            var val_40 = board + 176;
            var val_41 = 0;
            val_40 = val_40 + 8;
            label_62:
            if(((board + 176 + 8) + -8) == null)
            {
                goto label_61;
            }
            
            val_41 = val_41 + 1;
            val_40 = val_40 + 16;
            if(val_41 < (board + 286))
            {
                goto label_62;
            }
            
            goto label_63;
            label_61:
            var val_42 = val_40;
            val_42 = val_42 + 3;
            val_43 = val_43 + val_42;
            val_31 = val_43 + 296;
            label_63:
            var val_47 = val_14;
            if((val_12 > 0 ? this.mClient : 0 + 286) == 0)
            {
                goto label_68;
            }
            
            var val_44 = val_12 > 0 ? this.mClient : 0 + 176;
            var val_45 = 0;
            val_44 = val_44 + 8;
            label_67:
            if(((val_12 > 0 ? this.mClient : 0 + 176 + 8) + -8) == null)
            {
                goto label_66;
            }
            
            val_45 = val_45 + 1;
            val_44 = val_44 + 16;
            if(val_45 < (val_12 > 0 ? this.mClient : 0 + 286))
            {
                goto label_67;
            }
            
            goto label_68;
            label_66:
            var val_46 = val_44;
            val_46 = val_46 + 20;
            val_47 = val_47 + val_46;
            val_32 = val_47 + 296;
            label_68:
            val_14.LoadScores(leaderboardId:  (val_12 > 0) ? mem[24].id : 0, start:  val_24, rowCount:  val_16.from >> 32, collection:  (mem[24].userScope == 1) ? (1 + 1) : 1, timeSpan:  val_25, callback:  new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  val_1, method:  System.Void PlayGamesPlatform.<>c__DisplayClass73_0::<LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)));
            return;
            label_57:
            int val_22 = this.mClient.LeaderboardMaxResults();
            if(val_1 != null)
            {
                goto label_69;
            }
            
            goto label_70;
        }
        public bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board)
        {
            if(board == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return board.loading;
        }
        public void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate deleg)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.mClient.RegisterInvitationDelegate(invitationDelegate:  deleg);
        }
        internal void HandleLoadingScores(GooglePlayGames.PlayGamesLeaderboard board, GooglePlayGames.BasicApi.LeaderboardScoreData scoreData, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_7 = callback;
            PlayGamesPlatform.<>c__DisplayClass76_0 val_1 = new PlayGamesPlatform.<>c__DisplayClass76_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .callback = val_7;
            mem[1152921541740213888] = this;
            mem[1152921541740213896] = board;
            if(board != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            GooglePlayGames.BasicApi.LeaderboardScoreData val_9 = scoreData;
            bool val_2 = board.SetFromData(data:  val_9);
            if(val_2 == false)
            {
                goto label_8;
            }
            
            val_7 = mem[1152921541740213896];
            if((val_7.HasAllScores() == true) || (scoreData.mNextPage == null))
            {
                goto label_8;
            }
            
            GooglePlayGames.PlayGamesLeaderboard val_7 = mem[1152921541740213896];
            val_7 = (board + 32) - val_7.ScoreCount;
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_17;
            label_8:
            val_9 = val_2;
            .callback.Invoke(obj:  val_9);
            return;
            label_1:
            mem[16] = this;
            mem[24] = board;
            mem[32] = val_7;
            if(mem[24] != 0)
            {
                goto label_20;
            }
            
            goto label_21;
            label_17:
            this.mClient.LoadMoreScores(token:  scoreData.mNextPage, rowCount:  val_7, callback:  new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  val_1, method:  System.Void PlayGamesPlatform.<>c__DisplayClass76_0::<HandleLoadingScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData nextScoreData)));
        }
        internal UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                return this.mClient.GetFriends();
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  "Cannot get friends when not authenticated!");
            UnityEngine.SocialPlatforms.IUserProfile[] val_2 = new UnityEngine.SocialPlatforms.IUserProfile[0];
            return this.mClient.GetFriends();
        }
        private string MapId(string id)
        {
            string val_4 = id;
            if(val_4 == null)
            {
                    return (string)val_4;
            }
            
            if((this.mIdMap.ContainsKey(key:  val_4 = id)) == false)
            {
                    return (string)val_4;
            }
            
            string val_2 = this.mIdMap.Item[val_4];
            GooglePlayGames.OurUtils.Logger.d(msg:  "Mapping alias " + val_4 + " to ID " + val_2);
            val_4 = val_2;
            return (string)val_4;
        }
        private static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert)
        {
            var val_1;
            System.Action<T> val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_1 = __RuntimeMethodHiddenParam;
            val_2 = toConvert;
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
        private static PlayGamesPlatform()
        {
        
        }
    
    }

}
