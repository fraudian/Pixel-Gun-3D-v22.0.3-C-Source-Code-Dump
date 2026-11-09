using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass50_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
    public GooglePlayGames.Android.AndroidClient <>4__this;
    public GooglePlayGames.BasicApi.ScorePageToken token;
    
    // Methods
    public AndroidClient.<>c__DisplayClass50_0()
    {
    
    }
    internal void <LoadMoreScores>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        UnityEngine.AndroidJavaObject val_23;
        string val_24;
        GooglePlayGames.BasicApi.LeaderboardCollection val_25;
        var val_26;
        val_23 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        val_24 = this.token.LeaderboardId;
        val_25 = this.token.Collection;
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  this.callback, data:  this.<>4__this.CreateLeaderboardScoreData(leaderboardId:  val_24, collection:  val_25, timespan:  this.token.TimeSpan, status:  ((annotatedData.Call<System.Boolean>(methodName:  "isStale", args:  System.Array.Empty<System.Object>())) != true) ? (1 + 1) : 1, leaderboardScoresJava:  val_23));
        val_23.Call(methodName:  "release", args:  System.Array.Empty<System.Object>());
        val_26 = 0;
        if(val_23 != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_23.Dispose();
        }
        
        if(val_26 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_23 = ???;
        val_26 = ???;
        val_24 = ???;
        val_25 = ???;
    }
    internal void <LoadMoreScores>b__1(UnityEngine.AndroidJavaObject exception)
    {
        UnityEngine.Debug.Log(message:  "LoadMoreScores failed");
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  this.callback, data:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  this.token.LeaderboardId, status:  -2));
    }

}
