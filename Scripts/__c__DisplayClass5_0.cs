using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0
{
    // Fields
    public System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0()
    {
    
    }
    internal void <CreateQuickMatch>b__0(UnityEngine.AndroidJavaObject turnBasedMatch)
    {
        this.callback.Invoke(arg1:  true, arg2:  GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  turnBasedMatch));
    }
    internal void <CreateQuickMatch>b__1(UnityEngine.AndroidJavaObject e)
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
