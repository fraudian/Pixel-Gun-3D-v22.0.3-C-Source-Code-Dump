using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass61_0
{
    // Fields
    public System.Action<UnityEngine.SocialPlatforms.IScore[]> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass61_0()
    {
    
    }
    internal void <LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)
    {
        this.callback.Invoke(obj:  scoreData.Scores);
    }

}
