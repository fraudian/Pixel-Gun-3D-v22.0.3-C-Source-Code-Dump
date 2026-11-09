using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass49_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
    public GooglePlayGames.Android.AndroidClient <>4__this;
    public string leaderboardId;
    public GooglePlayGames.BasicApi.LeaderboardCollection collection;
    public GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan;
    
    // Methods
    public AndroidClient.<>c__DisplayClass49_0()
    {
    
    }
    internal void <LoadScores>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        string val_20;
        GooglePlayGames.BasicApi.LeaderboardTimeSpan val_21;
        UnityEngine.AndroidJavaObject val_22;
        var val_23;
        val_20 = this.leaderboardId;
        val_21 = this.timeSpan;
        val_22 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  this.callback, data:  this.<>4__this.CreateLeaderboardScoreData(leaderboardId:  val_20, collection:  this.collection, timespan:  val_21, status:  ((annotatedData.Call<System.Boolean>(methodName:  "isStale", args:  System.Array.Empty<System.Object>())) != true) ? (1 + 1) : 1, leaderboardScoresJava:  val_22));
        val_22.Call(methodName:  "release", args:  System.Array.Empty<System.Object>());
        val_23 = 0;
        if(val_22 != null)
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_22.Dispose();
        }
        
        if(val_23 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_22 = ???;
        val_23 = ???;
        val_20 = ???;
        val_21 = ???;
    }
    internal void <LoadScores>b__1(UnityEngine.AndroidJavaObject exception)
    {
        UnityEngine.Debug.Log(message:  "LoadScores failed");
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  this.callback, data:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  this.leaderboardId, status:  -2));
    }

}
