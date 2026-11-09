using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public struct PlayGamesClientConfiguration
    {
        // Fields
        public static readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration DefaultConfiguration;
        private readonly bool mEnableSavedGames;
        private readonly string[] mScopes;
        private readonly bool mRequestAuthCode;
        private readonly bool mForceRefresh;
        private readonly bool mHidePopups;
        private readonly bool mRequestEmail;
        private readonly bool mRequestIdToken;
        private readonly string mAccountName;
        private readonly GooglePlayGames.BasicApi.InvitationReceivedDelegate mInvitationDelegate;
        private readonly GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;
        
        // Properties
        public bool EnableSavedGames { get; }
        public bool IsHidingPopups { get; }
        public bool IsRequestingAuthCode { get; }
        public bool IsForcingRefresh { get; }
        public bool IsRequestingEmail { get; }
        public bool IsRequestingIdToken { get; }
        public string AccountName { get; }
        public string[] Scopes { get; }
        public GooglePlayGames.BasicApi.InvitationReceivedDelegate InvitationDelegate { get; }
        public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate MatchDelegate { get; }
        
        // Methods
        private PlayGamesClientConfiguration(GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder builder)
        {
        
        }
        public bool get_EnableSavedGames()
        {
            return (bool)this.mRequestAuthCode;
        }
        public bool get_IsHidingPopups()
        {
            return (bool)this;
        }
        public bool get_IsRequestingAuthCode()
        {
            return (bool)this.mInvitationDelegate;
        }
        public bool get_IsForcingRefresh()
        {
            return (bool)this;
        }
        public bool get_IsRequestingEmail()
        {
            return (bool)this;
        }
        public bool get_IsRequestingIdToken()
        {
            return (bool)this;
        }
        public string get_AccountName()
        {
            return (string)this.mMatchDelegate;
        }
        public string[] get_Scopes()
        {
            return (System.String[])this.mAccountName;
        }
        public static bool op_Equality(GooglePlayGames.BasicApi.PlayGamesClientConfiguration c1, GooglePlayGames.BasicApi.PlayGamesClientConfiguration c2)
        {
            var val_13;
            var val_1 = (c1.mEnableSavedGames == true) ? 1 : 0;
            val_1 = val_1 ^ ((c2.mEnableSavedGames == true) ? 1 : 0);
            if((val_1 & 1) == 0)
            {
                    var val_3 = (c1.mForceRefresh == true) ? 1 : 0;
                val_3 = val_3 ^ ((c2.mForceRefresh == true) ? 1 : 0);
                if((val_3 & 1) == 0)
            {
                    var val_5 = (c1.mHidePopups == true) ? 1 : 0;
                val_5 = val_5 ^ ((c2.mHidePopups == true) ? 1 : 0);
                if((val_5 & 1) == 0)
            {
                    var val_7 = (c1.mRequestEmail == true) ? 1 : 0;
                val_7 = val_7 ^ ((c2.mRequestEmail == true) ? 1 : 0);
                if((val_7 & 1) == 0)
            {
                    var val_9 = (c1.mRequestAuthCode == true) ? 1 : 0;
                val_9 = val_9 ^ ((c2.mRequestAuthCode == true) ? 1 : 0);
                if((val_9 & 1) == 0)
            {
                    if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  c1.mScopes, second:  c2.mScopes)) != false)
            {
                    val_13 = (~(System.String.op_Inequality(a:  c1.mAccountName, b:  c2.mAccountName))) & 1;
                return (bool)val_13;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public static bool op_Inequality(GooglePlayGames.BasicApi.PlayGamesClientConfiguration c1, GooglePlayGames.BasicApi.PlayGamesClientConfiguration c2)
        {
            bool val_1 = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.op_Equality(c1:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = c1.mEnableSavedGames, mRequestAuthCode = c1.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = c1.mInvitationDelegate, mMatchDelegate = c1.mInvitationDelegate}, c2:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = c2.mEnableSavedGames, mRequestAuthCode = c2.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = c2.mInvitationDelegate, mMatchDelegate = c2.mInvitationDelegate});
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public GooglePlayGames.BasicApi.InvitationReceivedDelegate get_InvitationDelegate()
        {
            return (GooglePlayGames.BasicApi.InvitationReceivedDelegate)this;
        }
        public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate get_MatchDelegate()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.MatchDelegate)this;
        }
        public override int GetHashCode()
        {
        
        }
        public override bool Equals(object obj)
        {
            return true;
        }
        private static PlayGamesClientConfiguration()
        {
            PlayGamesClientConfiguration.Builder val_1 = new PlayGamesClientConfiguration.Builder();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20 = 0;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10 = 0;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration = 0;
        }
    
    }

}
