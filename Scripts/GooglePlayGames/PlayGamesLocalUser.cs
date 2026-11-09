using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
    {
        // Fields
        internal GooglePlayGames.PlayGamesPlatform mPlatform;
        private string emailAddress;
        private GooglePlayGames.BasicApi.PlayerStats mStats;
        
        // Properties
        public UnityEngine.SocialPlatforms.IUserProfile[] friends { get; }
        public bool authenticated { get; }
        public bool underage { get; }
        public string userName { get; }
        public string id { get; }
        public bool isFriend { get; }
        public UnityEngine.SocialPlatforms.UserState state { get; }
        public string AvatarURL { get; }
        public string Email { get; }
        
        // Methods
        internal PlayGamesLocalUser(GooglePlayGames.PlayGamesPlatform plaf)
        {
            this = new System.Object();
            mem[1152921541729273520] = "localUser";
            mem[1152921541729273528] = System.String.alignConst;
            mem[1152921541729273536] = System.String.alignConst;
            mem[1152921541729273544] = 0;
            this.emailAddress = 0;
            this.mStats = 0;
            this.mPlatform = plaf;
        }
        public void Authenticate(System.Action<bool> callback)
        {
            this.mPlatform.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool, string> callback)
        {
            this.mPlatform.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool> callback, bool silent)
        {
            silent = silent;
            this.mPlatform.Authenticate(callback:  callback, silent:  silent);
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            silent = silent;
            this.mPlatform.Authenticate(callback:  callback, silent:  silent);
        }
        public void LoadFriends(System.Action<bool> callback)
        {
            this.mPlatform.LoadFriends(user:  callback, callback:  callback);
        }
        public UnityEngine.SocialPlatforms.IUserProfile[] get_friends()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.GetFriends();
            }
            
            return this.mPlatform.GetFriends();
        }
        public string GetIdToken()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.GetIdToken();
            }
            
            return this.mPlatform.GetIdToken();
        }
        public bool get_authenticated()
        {
            if(this.mPlatform != null)
            {
                    return this.mPlatform.IsAuthenticated();
            }
            
            return this.mPlatform.IsAuthenticated();
        }
        public bool get_underage()
        {
            return true;
        }
        public string get_userName()
        {
            int val_6;
            string val_7;
            val_6 = System.String.alignConst;
            if(this.authenticated == false)
            {
                    return val_6;
            }
            
            val_6 = this.mPlatform.GetUserDisplayName();
            if((X21.Equals(value:  val_6)) == true)
            {
                    return val_6;
            }
            
            val_7 = this.mPlatform.GetUserId();
            this.ResetIdentity(displayName:  val_6, playerId:  val_7, avatarUrl:  this.mPlatform.GetUserImageUrl());
            return val_6;
        }
        public string get_id()
        {
            int val_6;
            string val_7;
            val_6 = System.String.alignConst;
            if(this.authenticated == false)
            {
                    return val_6;
            }
            
            val_6 = this.mPlatform.GetUserId();
            if((X21.Equals(value:  val_6)) == true)
            {
                    return val_6;
            }
            
            val_7 = this.mPlatform.GetUserDisplayName();
            this.ResetIdentity(displayName:  val_7, playerId:  val_6, avatarUrl:  this.mPlatform.GetUserImageUrl());
            return val_6;
        }
        public bool get_isFriend()
        {
            return true;
        }
        public UnityEngine.SocialPlatforms.UserState get_state()
        {
            return 0;
        }
        public string get_AvatarURL()
        {
            int val_6;
            string val_7;
            val_6 = System.String.alignConst;
            if(this.authenticated == false)
            {
                    return val_6;
            }
            
            val_6 = this.mPlatform.GetUserImageUrl();
            if((X21.Equals(value:  val_6)) == true)
            {
                    return val_6;
            }
            
            val_7 = this.mPlatform.GetUserDisplayName();
            this.ResetIdentity(displayName:  val_7, playerId:  this.mPlatform.GetUserId(), avatarUrl:  val_6);
            return val_6;
        }
        public string get_Email()
        {
            int val_5;
            string val_6;
            if((this.authenticated != false) && ((System.String.IsNullOrEmpty(value:  this.emailAddress)) != false))
            {
                    string val_3 = this.mPlatform.GetUserEmail();
                this.emailAddress = val_3;
                if(val_3 == null)
            {
                    val_5 = System.String.alignConst;
            }
            
                this.emailAddress = val_5;
            }
            
            if(this.authenticated == false)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_6 = this.emailAddress;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public void GetStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            PlayGamesLocalUser.<>c__DisplayClass28_0 val_1 = new PlayGamesLocalUser.<>c__DisplayClass28_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            if((this.mStats != null) && (this.mStats.mValid != false))
            {
                    callback.Invoke(arg1:  0, arg2:  this.mStats);
                return;
            }
            
            this.mPlatform.GetPlayerStats(callback:  new System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats>(object:  val_1, method:  System.Void PlayGamesLocalUser.<>c__DisplayClass28_0::<GetStats>b__0(GooglePlayGames.BasicApi.CommonStatusCodes rc, GooglePlayGames.BasicApi.PlayerStats stats)));
        }
    
    }

}
