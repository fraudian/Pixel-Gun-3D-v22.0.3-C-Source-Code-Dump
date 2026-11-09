using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass38_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;
    
    // Methods
    public AndroidClient.<>c__DisplayClass38_0()
    {
    
    }
    internal void <GetPlayerStats>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_42;
        var val_43;
        float val_44;
        int val_45;
        float val_46;
        float val_47;
        var val_48;
        val_42 = 1152921516266839504;
        val_43 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        int val_6 = val_43.Call<System.Int32>(methodName:  "getAverageSessionLength", args:  System.Array.Empty<System.Object>());
        val_44 = V0.16B;
        val_45 = val_43.Call<System.Int32>(methodName:  "getNumberOfSessions", args:  System.Array.Empty<System.Object>());
        val_46 = val_43.Call<System.Single>(methodName:  "getSpendPercentile", args:  System.Array.Empty<System.Object>());
        val_47 = val_43.Call<System.Single>(methodName:  "getChurnProbability", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.PlayerStats() = new GooglePlayGames.BasicApi.PlayerStats(numberOfPurchases:  val_43.Call<System.Int32>(methodName:  "getNumberOfPurchases", args:  System.Array.Empty<System.Object>()), avgSessionLength:  val_44, daysSinceLastPlayed:  val_43.Call<System.Int32>(methodName:  "getDaysSinceLastPlayed", args:  System.Array.Empty<System.Object>()), numberOfSessions:  val_45, sessPercentile:  val_43.Call<System.Single>(methodName:  "getSessionPercentile", args:  System.Array.Empty<System.Object>()), spendPercentile:  val_46, spendProbability:  val_43.Call<System.Single>(methodName:  "getSpendProbability", args:  System.Array.Empty<System.Object>()), churnProbability:  val_47, highSpenderProbability:  val_43.Call<System.Single>(methodName:  "getHighSpenderProbability", args:  System.Array.Empty<System.Object>()), totalSpendNext28Days:  val_43.Call<System.Single>(methodName:  "getTotalSpendNext28Days", args:  System.Array.Empty<System.Object>()));
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats>(callback:  this.callback, t1:  0, t2:  new GooglePlayGames.BasicApi.PlayerStats());
        val_48 = 0;
        if(val_43 != null)
        {
                var val_42 = 0;
            val_42 = val_42 + 1;
            val_43.Dispose();
        }
        
        if(val_48 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_43 = ???;
        val_48 = ???;
        val_45 = ???;
        val_42 = ???;
        val_44 = ???;
        val_46 = ???;
        val_47 = ???;
    }
    internal void <GetPlayerStats>b__1(UnityEngine.AndroidJavaObject e)
    {
        UnityEngine.Debug.Log(message:  "GetPlayerStats failed");
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats>(callback:  this.callback, t1:  8, t2:  new GooglePlayGames.BasicApi.PlayerStats());
    }

}
