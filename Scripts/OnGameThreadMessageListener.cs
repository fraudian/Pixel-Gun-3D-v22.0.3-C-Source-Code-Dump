using UnityEngine;
private class AndroidNearbyConnectionClient.OnGameThreadMessageListener : IMessageListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
    
    // Methods
    public AndroidNearbyConnectionClient.OnGameThreadMessageListener(GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
    {
        this.mListener = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IMessageListener>(value:  listener);
    }
    public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
    {
        AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass2_0 val_1 = new AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .remoteEndpointId = remoteEndpointId;
            .data = data;
        }
        else
        {
                mem[16] = this;
            mem[24] = remoteEndpointId;
            mem[32] = data;
        }
        
        .isReliableMessage = isReliableMessage;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass2_0::<OnMessageReceived>b__0()));
    }
    public void OnRemoteEndpointDisconnected(string remoteEndpointId)
    {
        AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass3_0 val_1 = new AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .remoteEndpointId = remoteEndpointId;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidNearbyConnectionClient.OnGameThreadMessageListener.<>c__DisplayClass3_0::<OnRemoteEndpointDisconnected>b__0()));
    }

}
