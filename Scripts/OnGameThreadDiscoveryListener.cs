using UnityEngine;
private class AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener : IDiscoveryListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;
    
    // Methods
    public AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
    {
        this.mListener = listener;
    }
    public void OnEndpointFound(GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint)
    {
        var val_3;
        AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass2_0 val_1 = new AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            val_3;
        }
        else
        {
                mem[16] = this;
            val_3;
        }
        
        mem[1152921541791172248] = discoveredEndpoint.mServiceId;
        .discoveredEndpoint = discoveredEndpoint.mEndpointId;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass2_0::<OnEndpointFound>b__0()));
    }
    public void OnEndpointLost(string lostEndpointId)
    {
        AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass3_0 val_1 = new AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .lostEndpointId = lostEndpointId;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener.<>c__DisplayClass3_0::<OnEndpointLost>b__0()));
    }

}
