using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass73_0
{
    // Fields
    public GooglePlayGames.PlayGamesPlatform <>4__this;
    public UnityEngine.SocialPlatforms.ILeaderboard board;
    public System.Action<bool> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass73_0()
    {
    
    }
    internal void <LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)
    {
        UnityEngine.SocialPlatforms.ILeaderboard val_3 = this.board;
        if((this.<>4__this) == null)
        {
            goto label_1;
        }
        
        if(val_3 != null)
        {
            goto label_2;
        }
        
        goto label_6;
        label_1:
        if(val_3 == null)
        {
            goto label_6;
        }
        
        label_2:
        val_3 = 0;
        label_6:
        this.<>4__this.HandleLoadingScores(board:  val_3, scoreData:  scoreData, callback:  this.callback);
    }

}
