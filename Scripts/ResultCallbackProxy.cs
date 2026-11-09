using UnityEngine;
private class AndroidTokenClient.ResultCallbackProxy : AndroidJavaProxy
{
    // Fields
    private System.Action<UnityEngine.AndroidJavaObject> mCallback;
    
    // Methods
    public AndroidTokenClient.ResultCallbackProxy(System.Action<UnityEngine.AndroidJavaObject> callback)
    {
        this.mCallback = callback;
    }
    public void onResult(UnityEngine.AndroidJavaObject tokenResult)
    {
        this.mCallback.Invoke(obj:  tokenResult);
    }

}
