using UnityEngine;
private class AndroidRealTimeMultiplayerClient.RoomUpdateCallbackProxy : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
    private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient mParent;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.RoomUpdateCallbackProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient parent, GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
    {
        this.mListener = listener;
        this.mParent = parent;
    }
    public void onRoomCreated(int statusCode, UnityEngine.AndroidJavaObject room)
    {
        if(room != null)
        {
                this.mParent.mRoom = room;
            this.mListener.OnRoomSetupProgress(percent:  this.mParent.GetPercentComplete());
            return;
        }
        
        this.mListener.OnRoomConnected(success:  false);
    }
    public void onJoinedRoom(int statusCode, UnityEngine.AndroidJavaObject room)
    {
        int val_11;
        var val_12;
        var val_13;
        if(room == null)
        {
            goto label_1;
        }
        
        this.mParent.mRoom = room;
        UnityEngine.AndroidJavaObject val_2 = room.Call<UnityEngine.AndroidJavaObject>(methodName:  "getAutoMatchCriteria", args:  System.Array.Empty<System.Object>());
        if(val_2 == null)
        {
            goto label_3;
        }
        
        object[] val_3 = new object[2];
        val_3[0] = "min_automatch_players";
        val_3[1] = 0;
        val_11 = val_2.Call<System.Int32>(methodName:  "getInt", args:  val_3);
        val_12 = 0;
        val_13 = 0;
        var val_11 = 0;
        val_11 = val_11 + 1;
        goto label_14;
        label_1:
        this.mListener.OnRoomConnected(success:  false);
        return;
        label_3:
        val_11 = 0;
        val_12 = 0;
        goto label_16;
        label_14:
        val_2.Dispose();
        if(val_13 == 1)
        {
            goto label_17;
        }
        
        if(99 != 99)
        {
            goto label_18;
        }
        
        label_16:
        val_13 = 0;
        goto label_20;
        label_17:
        val_13 = 0;
        label_18:
        if(val_12 != 0)
        {
                val_12 = 0;
        }
        
        label_20:
        UnityEngine.AndroidJavaObject val_7 = room.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipantIds", args:  System.Array.Empty<System.Object>());
        val_11 = (val_7.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>())) + val_11;
        if(val_7 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_7.Dispose();
        }
        
        if(1 == 1)
        {
            goto label_27;
        }
        
        if((val_12 == 0) || (147 == 147))
        {
            goto label_32;
        }
        
        label_31:
        label_32:
        this.mParent.mMinPlayersToStart = val_11;
        return;
        label_27:
        if(val_12 != 0)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    public void onLeftRoom(int statusCode, string roomId)
    {
        this.mListener.OnLeftRoom();
        this.mParent.CleanSession();
    }
    public void onRoomConnected(int statusCode, UnityEngine.AndroidJavaObject room)
    {
        OnGameThreadForwardingListener val_1;
        var val_2;
        if(room != null)
        {
                this.mParent.mRoom = room;
            val_1 = this.mListener;
            val_2 = 1;
        }
        else
        {
                val_1 = this.mListener;
            val_2 = 0;
        }
        
        val_1.OnRoomConnected(success:  false);
    }

}
