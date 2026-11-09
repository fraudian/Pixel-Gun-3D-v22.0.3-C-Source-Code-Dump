using UnityEngine;
private class AndroidNearbyConnectionClient.PayloadCallback : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
    
    // Methods
    public AndroidNearbyConnectionClient.PayloadCallback(GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
    {
        this.mListener = listener;
    }
    public void onPayloadReceived(string endpointId, UnityEngine.AndroidJavaObject payload)
    {
        if((payload.Call<System.Int32>(methodName:  "getType", args:  System.Array.Empty<System.Object>())) != 1)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.mListener.OnMessageReceived(remoteEndpointId:  endpointId, data:  payload.Call<System.Byte[]>(methodName:  "asBytes", args:  System.Array.Empty<System.Object>()), isReliableMessage:  true);
    }

}
