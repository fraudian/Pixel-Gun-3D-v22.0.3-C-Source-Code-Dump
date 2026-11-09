using UnityEngine;
private class AndroidRealTimeMultiplayerClient.RoomStatusUpdateCallbackProxy : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
    private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient mParent;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.RoomStatusUpdateCallbackProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient parent, GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
    {
        this.mListener = listener;
        this.mParent = parent;
    }
    public void onRoomConnecting(UnityEngine.AndroidJavaObject room)
    {
        this.mParent.mRoom = room;
    }
    public void onRoomAutoMatching(UnityEngine.AndroidJavaObject room)
    {
        this.mParent.mRoom = room;
    }
    public void onPeerInvitedToRoom(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        this.handleParticipantStatusChanged(room:  room, participantIds:  participantIds);
    }
    public void onPeerDeclined(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        this.handleParticipantStatusChanged(room:  room, participantIds:  participantIds);
    }
    public void onPeerJoined(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        this.handleParticipantStatusChanged(room:  room, participantIds:  participantIds);
    }
    public void onPeerLeft(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        this.handleParticipantStatusChanged(room:  room, participantIds:  participantIds);
    }
    private void handleParticipantStatusChanged(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        object val_11;
        this.mParent.mRoom = room;
        int val_1 = participantIds.Get<System.Int32>(fieldName:  "size");
        if(val_1 < 1)
        {
                return;
        }
        
        object val_11 = 0;
        label_27:
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_11 != 0)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_11 == 0)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_11;
        val_11 = participantIds.Call<System.String>(methodName:  "get", args:  val_2);
        object[] val_4 = new object[1];
        if(val_4 == null)
        {
            goto label_12;
        }
        
        if(val_11 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_11 == null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        val_4[0] = val_11;
        GooglePlayGames.BasicApi.Multiplayer.Participant val_6 = GooglePlayGames.Android.AndroidJavaConverter.ToParticipant(participant:  this.mParent.mRoom.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipant", args:  val_4));
        if(val_6.Status != 3)
        {
                if(val_6.Status != 4)
        {
            goto label_25;
        }
        
        }
        
        val_11 = this.mListener;
        val_11.OnParticipantLeft(participant:  val_6);
        if((this.mParent.GetRoomStatus() - 1) >= 2)
        {
                this.mParent.LeaveRoom();
        }
        
        label_25:
        val_11 = val_11 + 1;
        if(val_1 != val_11)
        {
            goto label_27;
        }
    
    }
    public void onConnectedToRoom(UnityEngine.AndroidJavaObject room)
    {
        if(this.mParent.GetRoomStatus() == 3)
        {
                this.mParent.mRoom = room;
            return;
        }
        
        this.handleConnectedSetChanged(room:  room);
    }
    public void onDisconnectedFromRoom(UnityEngine.AndroidJavaObject room)
    {
        if(this.mParent.GetRoomStatus() == 3)
        {
                this.mParent.mRoom = room;
            return;
        }
        
        this.handleConnectedSetChanged(room:  room);
        this.mParent.CleanSession();
    }
    public void onPeersConnected(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        if(this.mParent.GetRoomStatus() == 3)
        {
                this.mParent.mRoom = room;
            this.mParent.mListener.OnPeersConnected(participantIds:  GooglePlayGames.Android.AndroidJavaConverter.ToStringList(stringList:  participantIds).ToArray());
            return;
        }
        
        this.handleConnectedSetChanged(room:  room);
    }
    public void onPeersDisconnected(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds)
    {
        if(this.mParent.GetRoomStatus() == 3)
        {
                this.mParent.mRoom = room;
            this.mParent.mListener.OnPeersDisconnected(participantIds:  GooglePlayGames.Android.AndroidJavaConverter.ToStringList(stringList:  participantIds).ToArray());
            return;
        }
        
        this.handleConnectedSetChanged(room:  room);
    }
    private void handleConnectedSetChanged(UnityEngine.AndroidJavaObject room)
    {
        var val_5;
        GooglePlayGames.Android.AndroidRealTimeMultiplayerClient val_25;
        var val_26;
        var val_27;
        object val_29;
        var val_31;
        GooglePlayGames.Android.AndroidRealTimeMultiplayerClient val_32;
        val_25 = this;
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        val_26 = 1152921541795198912;
        List.Enumerator<T> val_3 = this.mParent.GetConnectedParticipants().GetEnumerator();
        val_27 = 1152921541795200960;
        label_6:
        if(((-1460806176) & 1) == 0)
        {
            goto label_3;
        }
        
        bool val_8 = val_1.Add(item:  val_5.丐丏七丌丕丗业且上().ParticipantId);
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.mParent.mRoom = room;
        System.Collections.Generic.HashSet<System.String> val_9 = null;
        val_29 = val_9;
        val_9 = new System.Collections.Generic.HashSet<System.String>();
        List.Enumerator<T> val_11 = this.mParent.GetConnectedParticipants().GetEnumerator();
        label_18:
        if(((-1460806176) & 1) == 0)
        {
            goto label_15;
        }
        
        bool val_14 = val_9.Add(item:  val_5.丐丏七丌丕丗业且上().ParticipantId);
        goto label_18;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_1.Equals(obj:  val_9)) != false)
        {
                GooglePlayGames.OurUtils.Logger.w(msg:  "Received connected set callback with unchanged connected set!");
            return;
        }
        
        System.Collections.Generic.List<System.String> val_16 = new System.Collections.Generic.List<System.String>();
        HashSet.Enumerator<T> val_17 = val_1.GetEnumerator();
        val_26 = 1152921531056473744;
        val_27 = 1152921517987147792;
        label_34:
        if(((-1460806208) & 1) == 0)
        {
            goto label_30;
        }
        
        string val_18 = val_5.丐丏七丌丕丗业且上();
        if((val_9.Contains(item:  val_18)) == true)
        {
            goto label_34;
        }
        
        val_16.Add(item:  val_18);
        goto label_34;
        label_30:
        val_29 = 0;
        val_31 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_39;
        }
        
        if(( == 0) || (246 == 246))
        {
            goto label_54;
        }
        
        label_53:
        label_54:
        if(this.mParent.GetRoomStatus() == 4)
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  "Participants disconnected during room setup, failing. Participants were: "("Participants disconnected during room setup, failing. Participants were: ") + System.String.Join(separator:  ",", value:  val_16.ToArray())(System.String.Join(separator:  ",", value:  val_16.ToArray())));
            this.mParent.mListener.OnRoomConnected(success:  false);
            val_25 = this.mParent;
            val_25.CleanSession();
            return;
        }
        
        val_32 = this.mParent;
        if(val_32 == null)
        {
            goto label_51;
        }
        
        val_25 = this.mParent.mListener;
        goto label_56;
        label_39:
        if( != 0)
        {
            goto label_53;
        }
        
        goto label_54;
        label_51:
        val_25 = this.mParent.mListener;
        if(this.mParent != null)
        {
                val_32 = this.mParent;
        }
        else
        {
                val_32 = 0;
        }
        
        label_56:
        val_25.OnRoomSetupProgress(percent:  val_32.GetPercentComplete());
    }
    public void onP2PConnected(string participantId)
    {
    
    }
    public void onP2PDisconnected(string participantId)
    {
    
    }

}
