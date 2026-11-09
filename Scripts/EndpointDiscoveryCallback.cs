using UnityEngine;
private class AndroidNearbyConnectionClient.EndpointDiscoveryCallback : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;
    
    // Methods
    public AndroidNearbyConnectionClient.EndpointDiscoveryCallback(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
    {
        this.mListener = listener;
    }
    public void onEndpointFound(string endpointId, UnityEngine.AndroidJavaObject endpointInfo)
    {
        string val_2;
        string val_3;
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_1 = this.CreateEndPointDetails(endpointId:  endpointId, endpointInfo:  endpointInfo);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.mListener.OnEndpointFound(discoveredEndpoint:  new GooglePlayGames.BasicApi.Nearby.EndpointDetails() {mEndpointId = val_3, mName = val_3, mServiceId = val_2});
    }
    public void onEndpointLost(string endpointId)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.mListener.OnEndpointLost(lostEndpointId:  endpointId);
    }
    private GooglePlayGames.BasicApi.Nearby.EndpointDetails CreateEndPointDetails(string endpointId, UnityEngine.AndroidJavaObject endpointInfo)
    {
        string val_2 = endpointInfo.Call<System.String>(methodName:  "getEndpointName", args:  System.Array.Empty<System.Object>());
        string val_4 = endpointInfo.Call<System.String>(methodName:  "getServiceId", args:  System.Array.Empty<System.Object>());
        val_0.mName = 0;
        val_0.mServiceId = 0;
        val_0.mEndpointId = 0;
    }

}
