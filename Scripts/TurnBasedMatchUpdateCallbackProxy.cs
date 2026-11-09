using UnityEngine;
private class AndroidTurnBasedMultiplayerClient.TurnBasedMatchUpdateCallbackProxy : AndroidJavaProxy
{
    // Fields
    private System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.TurnBasedMatchUpdateCallbackProxy(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> matchDelegate)
    {
        this.mMatchDelegate = matchDelegate;
    }
    public void onTurnBasedMatchReceived(UnityEngine.AndroidJavaObject turnBasedMatch)
    {
        this.mMatchDelegate.Invoke(arg1:  GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  turnBasedMatch), arg2:  false);
    }
    public void onTurnBasedMatchRemoved(string invitationId)
    {
    
    }

}
