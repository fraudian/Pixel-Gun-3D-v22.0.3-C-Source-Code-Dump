using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass76_0
{
    // Fields
    public GooglePlayGames.PlayGamesPlatform <>4__this;
    public GooglePlayGames.PlayGamesLeaderboard board;
    public System.Action<bool> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass76_0()
    {
    
    }
    internal void <HandleLoadingScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData nextScoreData)
    {
        this.<>4__this.HandleLoadingScores(board:  this.board, scoreData:  nextScoreData, callback:  this.callback);
    }

}
