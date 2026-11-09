using UnityEngine;
private sealed class AndroidVideoClient.OnCaptureOverlayStateListenerProxy.<>c__DisplayClass2_0
{
    // Fields
    public GooglePlayGames.Android.AndroidVideoClient.OnCaptureOverlayStateListenerProxy <>4__this;
    public int overlayState;
    
    // Methods
    public AndroidVideoClient.OnCaptureOverlayStateListenerProxy.<>c__DisplayClass2_0()
    {
    
    }
    internal void <onCaptureOverlayStateChanged>b__0()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.<>4__this.mListener.OnCaptureOverlayStateChanged(overlayState:  ((this.overlayState - 1) < 4) ? this.overlayState : (!0));
    }

}
