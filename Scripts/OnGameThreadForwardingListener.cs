using UnityEngine;
private class AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener mListener;
    
    // Methods
    internal AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
    {
        this.mListener = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener>(value:  listener);
    }
    public void OnRoomSetupProgress(float percent)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass2_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .percent = percent;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass2_0::<OnRoomSetupProgress>b__0()));
    }
    public void OnRoomConnected(bool success)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass3_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .success = success;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass3_0::<OnRoomConnected>b__0()));
    }
    public void OnLeftRoom()
    {
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  this, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener::<OnLeftRoom>b__4_0()));
    }
    public void OnPeersConnected(string[] participantIds)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass5_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass5_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .participantIds = participantIds;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass5_0::<OnPeersConnected>b__0()));
    }
    public void OnPeersDisconnected(string[] participantIds)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass6_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass6_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .participantIds = participantIds;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass6_0::<OnPeersDisconnected>b__0()));
    }
    public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass7_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .isReliable = isReliable;
            .senderId = senderId;
        }
        else
        {
                mem[16] = this;
            mem[24] = isReliable;
            mem[32] = senderId;
        }
        
        .data = data;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass7_0::<OnRealTimeMessageReceived>b__0()));
    }
    public void OnParticipantLeft(GooglePlayGames.BasicApi.Multiplayer.Participant participant)
    {
        AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass8_0 val_1 = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .participant = participant;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener.<>c__DisplayClass8_0::<OnParticipantLeft>b__0()));
    }
    private void <OnLeftRoom>b__4_0()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.mListener.OnLeftRoom();
    }

}
