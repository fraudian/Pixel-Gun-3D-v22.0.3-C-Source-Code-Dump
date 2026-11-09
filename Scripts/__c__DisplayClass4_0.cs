using UnityEngine;
private sealed class AndroidVideoClient.<>c__DisplayClass4_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback;
    
    // Methods
    public AndroidVideoClient.<>c__DisplayClass4_0()
    {
    
    }
    internal void <GetCaptureCapabilities>b__0(UnityEngine.AndroidJavaObject videoCapabilities)
    {
        this.callback.Invoke(arg1:  1, arg2:  GooglePlayGames.Android.AndroidVideoClient.CreateVideoCapabilities(videoCapabilities:  videoCapabilities));
    }
    internal void <GetCaptureCapabilities>b__1(UnityEngine.AndroidJavaObject exception)
    {
        this.callback.Invoke(arg1:  -2, arg2:  0);
    }

}
