using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass15_0
{
    // Fields
    public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass15_0()
    {
    
    }
    internal void <RegisterMatchDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch, bool autoAccept)
    {
        autoAccept = autoAccept;
        this.del.Invoke(match:  turnBasedMatch, shouldAutoLaunch:  autoAccept);
    }

}
