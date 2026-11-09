using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass39_1
{
    // Fields
    public UnityEngine.SocialPlatforms.IUserProfile[] users;
    public int count;
    public object countLock;
    public int resultCount;
    public GooglePlayGames.Android.AndroidClient.<>c__DisplayClass39_0 CS$<>8__locals1;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__0;
    
    // Methods
    public AndroidClient.<>c__DisplayClass39_1()
    {
    
    }
    internal void <LoadUsers>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_9;
        var val_10;
        UnityEngine.AndroidJavaObject val_2 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        if(this.count < 1)
        {
            goto label_9;
        }
        
        var val_10 = 0;
        label_8:
        if((System.String.op_Equality(a:  val_2.Call<System.String>(methodName:  "getPlayerId", args:  System.Array.Empty<System.Object>()), b:  this.CS$<>8__locals1.userIds[0])) == true)
        {
            goto label_7;
        }
        
        val_10 = val_10 + 1;
        if(val_10 < this.count)
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        this.users[0] = GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_2);
        label_9:
        bool val_7 = false;
        System.Threading.Monitor.Enter(obj:  this.countLock, lockTaken: ref  val_7);
        int val_11 = this.resultCount;
        val_11 = val_11 + 1;
        this.resultCount = val_11;
        if(val_11 == this.count)
        {
                GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<UnityEngine.SocialPlatforms.IUserProfile[]>(callback:  this.CS$<>8__locals1.callback, data:  this.users);
        }
        
        val_9 = 0;
        if(val_7 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.countLock);
        }
        
        if(0 == 1)
        {
            goto label_19;
        }
        
        val_10 = 0;
        if(val_2 != null)
        {
            goto label_23;
        }
        
        goto label_40;
        label_19:
        if(val_9 != 0)
        {
                val_9 = 0;
        }
        
        val_10 = 0;
        if(val_2 != null)
        {
            goto label_23;
        }
        
        goto label_40;
        label_23:
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_2.Dispose();
        label_40:
        if( != 1)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }

}
