using UnityEngine;
private sealed class AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0()
    {
    
    }
    internal void <GetAllInvitations>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.AndroidJavaObject val_2 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        if((val_2.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>())) >= 1)
        {
                object val_14 = 0;
            val_11 = 0;
            var val_11 = 0;
        }
        else
        {
                val_12 = 0;
            val_13 = 0;
            mem[1152921541807096320].Invoke(obj:  new GooglePlayGames.BasicApi.Multiplayer.Invitation[0]);
            val_14 = 0 + 1;
            mem2[0] = 129;
            if(val_2 == null)
        {
            
        }
        else
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_2.Dispose();
        }
        
            if(val_14 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921541807084176 + ((0 + 1)) << 2) == 129)
        {
                return;
        }
        
            return;
        }
        
            if( != 0)
        {
                return;
        }
        
        }
    
    }
    internal void <GetAllInvitations>b__1(UnityEngine.AndroidJavaObject exception)
    {
        this.callback.Invoke(obj:  0);
    }

}
