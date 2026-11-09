using UnityEngine;
private class AndroidRealTimeMultiplayerClient.MessageReceivedListenerProxy : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.MessageReceivedListenerProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
    {
        this.mListener = listener;
    }
    public void onRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
    {
        isReliable = isReliable;
        this.mListener.OnRealTimeMessageReceived(isReliable:  isReliable, senderId:  senderId, data:  data);
    }

}
