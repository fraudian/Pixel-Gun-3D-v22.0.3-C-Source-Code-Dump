using UnityEngine;
private class AndroidNearbyConnectionClient.AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
{
    // Fields
    private System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> mResultCallback;
    private System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> mConnectionRequestCallback;
    private GooglePlayGames.Android.AndroidNearbyConnectionClient mClient;
    private string mLocalEndpointName;
    
    // Methods
    public AndroidNearbyConnectionClient.AdvertisingConnectionLifecycleCallbackProxy(System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback, GooglePlayGames.Android.AndroidNearbyConnectionClient client)
    {
        this.mResultCallback = resultCallback;
        this.mConnectionRequestCallback = connectionRequestCallback;
        this.mClient = client;
    }
    public void onConnectionInitiated(string endpointId, UnityEngine.AndroidJavaObject connectionInfo)
    {
        this.mLocalEndpointName = connectionInfo.Call<System.String>(methodName:  "getEndpointName", args:  System.Array.Empty<System.Object>());
        string val_3 = 0.GetServiceId();
        byte[] val_4 = new byte[0];
        this.mConnectionRequestCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionRequest() {mRemoteEndpoint = new GooglePlayGames.BasicApi.Nearby.EndpointDetails()});
    }
    public void onConnectionResult(string endpointId, UnityEngine.AndroidJavaObject connectionResolution)
    {
        System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> val_7;
        string val_8;
        UnityEngine.AndroidJavaObject val_2 = connectionResolution.Call<UnityEngine.AndroidJavaObject>(methodName:  "getStatus", args:  System.Array.Empty<System.Object>());
        int val_4 = val_2.Call<System.Int32>(methodName:  "getStatusCode", args:  System.Array.Empty<System.Object>());
        if(val_2 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            val_2.Dispose();
        }
        
        if(val_4 == 8001)
        {
            goto label_10;
        }
        
        if(val_4 != 0)
        {
            goto label_11;
        }
        
        val_7 = this.mResultCallback;
        val_8 = this.mLocalEndpointName;
        goto label_13;
        label_10:
        val_7 = this.mResultCallback;
        val_8 = this.mLocalEndpointName;
        goto label_13;
        label_11:
        val_7 = this.mResultCallback;
        val_8 = this.mLocalEndpointName;
        label_13:
        val_7.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.AdvertisingResult());
    }
    public void onDisconnected(string endpointId)
    {
        if(this.mClient.mAdvertisingMessageListener == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.mClient.mAdvertisingMessageListener.OnRemoteEndpointDisconnected(remoteEndpointId:  endpointId);
    }

}
