using UnityEngine;

namespace GooglePlayGames
{
    internal class PlayGamesClientFactory
    {
        // Methods
        internal static GooglePlayGames.BasicApi.IPlayGamesClient GetPlatformPlayGamesClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration config)
        {
            var val_4;
            if(UnityEngine.Application.isEditor != false)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Creating IPlayGamesClient in editor, using DummyClient.");
                GooglePlayGames.BasicApi.DummyClient val_2 = null;
                val_4 = val_2;
                val_2 = new GooglePlayGames.BasicApi.DummyClient();
                return (GooglePlayGames.BasicApi.IPlayGamesClient)val_4;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  "Creating Android IPlayGamesClient Client");
            GooglePlayGames.Android.AndroidClient val_3 = null;
            val_4 = val_3;
            val_3 = new GooglePlayGames.Android.AndroidClient(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = config.mEnableSavedGames, mRequestAuthCode = config.mRequestAuthCode, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false, mInvitationDelegate = config.mInvitationDelegate, mMatchDelegate = config.mInvitationDelegate});
            return (GooglePlayGames.BasicApi.IPlayGamesClient)val_4;
        }
        public PlayGamesClientFactory()
        {
        
        }
    
    }

}
