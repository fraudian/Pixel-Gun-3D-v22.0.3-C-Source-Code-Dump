using UnityEngine;
private class AndroidVideoClient.OnCaptureOverlayStateListenerProxy : AndroidJavaProxy
{
    // Fields
    private GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener mListener;
    
    // Methods
    public AndroidVideoClient.OnCaptureOverlayStateListenerProxy(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener)
    {
        this.mListener = listener;
    }
    public void onCaptureOverlayStateChanged(int overlayState)
    {
        AndroidVideoClient.OnCaptureOverlayStateListenerProxy.<>c__DisplayClass2_0 val_1 = new AndroidVideoClient.OnCaptureOverlayStateListenerProxy.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .overlayState = overlayState;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  val_1, method:  System.Void AndroidVideoClient.OnCaptureOverlayStateListenerProxy.<>c__DisplayClass2_0::<onCaptureOverlayStateChanged>b__0()));
    }
    private static GooglePlayGames.BasicApi.VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState)
    {
        return (GooglePlayGames.BasicApi.VideoCaptureOverlayState)((overlayState - 1) < 4) ? overlayState : (!0);
    }

}
