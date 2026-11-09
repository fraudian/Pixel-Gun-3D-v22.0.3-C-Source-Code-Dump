using UnityEngine;
private class AndroidClient.InvitationCallbackProxy : AndroidJavaProxy
{
    // Fields
    private System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> mInvitationDelegate;
    
    // Methods
    public AndroidClient.InvitationCallbackProxy(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> invitationDelegate)
    {
        this.mInvitationDelegate = invitationDelegate;
    }
    public void onInvitationReceived(UnityEngine.AndroidJavaObject invitation)
    {
        this.mInvitationDelegate.Invoke(arg1:  GooglePlayGames.Android.AndroidJavaConverter.ToInvitation(invitation:  invitation), arg2:  false);
    }
    public void onInvitationRemoved(string invitationId)
    {
    
    }

}
