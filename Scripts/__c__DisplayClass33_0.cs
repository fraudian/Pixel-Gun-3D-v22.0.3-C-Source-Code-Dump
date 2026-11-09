using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass33_0
{
    // Fields
    public GooglePlayGames.Android.AndroidClient <>4__this;
    public System.Action uiCallback;
    
    // Methods
    public AndroidClient.<>c__DisplayClass33_0()
    {
    
    }
    internal void <SignOut>b__0(UnityEngine.AndroidJavaObject completedTask)
    {
        this.<>4__this.mInvitationCallback = 0;
        this.<>4__this.mTokenClient.Signout();
        this.<>4__this.mAuthState = 0;
        if(this.uiCallback == null)
        {
                return;
        }
        
        this.uiCallback.Invoke();
    }

}
