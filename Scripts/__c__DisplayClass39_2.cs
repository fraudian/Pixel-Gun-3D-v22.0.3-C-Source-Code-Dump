using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass39_2
{
    // Fields
    public int i;
    public GooglePlayGames.Android.AndroidClient.<>c__DisplayClass39_1 CS$<>8__locals2;
    
    // Methods
    public AndroidClient.<>c__DisplayClass39_2()
    {
    
    }
    internal void <LoadUsers>b__1(UnityEngine.AndroidJavaObject exception)
    {
        AndroidClient.<>c__DisplayClass39_1 val_5;
        int val_6;
        AndroidClient.<>c__DisplayClass39_1 val_7;
        int val_8;
        UnityEngine.Debug.Log(message:  "LoadUsers failed for index " + this.i);
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  this.CS$<>8__locals2.countLock, lockTaken: ref  val_2);
        val_5 = this.CS$<>8__locals2;
        if(val_5 != null)
        {
                val_6 = (this.CS$<>8__locals2.resultCount) + 1;
        }
        else
        {
                val_6 = (this.CS$<>8__locals2.resultCount) + 1;
            if((this.CS$<>8__locals2) != null)
        {
                val_5 = this.CS$<>8__locals2;
        }
        else
        {
                val_5 = 0;
        }
        
        }
        
        mem[40] = val_6;
        val_7 = this.CS$<>8__locals2;
        if(val_7 != null)
        {
                val_8 = this.CS$<>8__locals2.resultCount;
        }
        else
        {
                val_8 = this.CS$<>8__locals2.resultCount;
            if((this.CS$<>8__locals2) != null)
        {
                val_7 = this.CS$<>8__locals2;
        }
        else
        {
                val_7 = 0;
        }
        
        }
        
        if(val_8 == 28563616)
        {
                GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<UnityEngine.SocialPlatforms.IUserProfile[]>(callback:  this.CS$<>8__locals2.CS$<>8__locals1.callback, data:  this.CS$<>8__locals2.users);
        }
        
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.CS$<>8__locals2.countLock);
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }

}
