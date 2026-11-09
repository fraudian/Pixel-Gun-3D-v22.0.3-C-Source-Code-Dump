using UnityEngine;
private class AndroidNearbyConnectionClient.DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
{
    // Fields
    private System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> mResponseCallback;
    private GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
    private UnityEngine.AndroidJavaObject mClient;
    private string mLocalEndpointName;
    
    // Methods
    public AndroidNearbyConnectionClient.DiscoveringConnectionLifecycleCallback(System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener, UnityEngine.AndroidJavaObject client)
    {
        this.mResponseCallback = responseCallback;
        this.mListener = listener;
        this.mClient = client;
    }
    public void onConnectionInitiated(string endpointId, UnityEngine.AndroidJavaObject connectionInfo)
    {
        GooglePlayGames.BasicApi.Nearby.IMessageListener val_16;
        object val_17;
        var val_18;
        var val_20;
        object[] val_1 = new object[1];
        val_16 = this.mListener;
        val_1[0] = new AndroidNearbyConnectionClient.PayloadCallback(listener:  val_16);
        UnityEngine.AndroidJavaObject val_3 = null;
        val_17 = val_3;
        val_3 = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.PayloadCallbackProxy", args:  val_1);
        object[] val_4 = new object[2];
        val_4[0] = endpointId;
        val_4[1] = val_17;
        val_18 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "acceptConnection", args:  val_4);
        if(val_18 == null)
        {
            goto label_13;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        goto label_17;
        label_13:
        val_20 = 0;
        if(val_17 != null)
        {
            goto label_31;
        }
        
        goto label_32;
        label_17:
        val_18.Dispose();
        val_20 = 0;
        val_18 = 0;
        if(val_17 == null)
        {
            goto label_32;
        }
        
        label_31:
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_3.Dispose();
        label_32:
        if(val_20 != 1)
        {
                return;
        }
        
        if(val_18 == 0)
        {
                return;
        }
        
        val_17 = ???;
        val_20 = ???;
        val_16 = ???;
    }
    public void onConnectionResult(string endpointId, UnityEngine.AndroidJavaObject connectionResolution)
    {
        long val_8;
        Status val_9;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.AndroidJavaObject val_2 = connectionResolution.Call<UnityEngine.AndroidJavaObject>(methodName:  "getStatus", args:  System.Array.Empty<System.Object>());
        int val_4 = val_2.Call<System.Int32>(methodName:  "getStatusCode", args:  System.Array.Empty<System.Object>());
        if(val_2 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_2.Dispose();
        }
        
        if(val_4 == 8002)
        {
            goto label_10;
        }
        
        if(val_4 != 0)
        {
            goto label_11;
        }
        
        val_13 = null;
        val_13 = null;
        GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_7 = GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Accepted(localClientId:  GooglePlayGames.Android.AndroidNearbyConnectionClient.NearbyClientId, remoteEndpointId:  endpointId, payload:  new byte[0]);
        if(this.mResponseCallback != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        this.mResponseCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionResponse() {mLocalClientId = val_8, mRemoteEndpointId = val_8, mResponseStatus = val_9, mPayload = val_9});
        return;
        label_10:
        val_14 = null;
        val_14 = null;
        GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_10 = GooglePlayGames.BasicApi.Nearby.ConnectionResponse.AlreadyConnected(localClientId:  GooglePlayGames.Android.AndroidNearbyConnectionClient.NearbyClientId, remoteEndpointId:  endpointId);
        if(this.mResponseCallback != null)
        {
            goto label_27;
        }
        
        goto label_28;
        label_11:
        val_15 = null;
        val_15 = null;
        GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_11 = GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Rejected(localClientId:  GooglePlayGames.Android.AndroidNearbyConnectionClient.NearbyClientId, remoteEndpointId:  endpointId);
        if(this.mResponseCallback != null)
        {
            goto label_27;
        }
        
        goto label_28;
    }
    public void onDisconnected(string endpointId)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.mListener.OnRemoteEndpointDisconnected(remoteEndpointId:  endpointId);
    }

}
