using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass59_0
{
    // Fields
    public GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate;
    
    // Methods
    public AndroidClient.<>c__DisplayClass59_0()
    {
    
    }
    internal void <RegisterInvitationDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool autoAccept)
    {
        autoAccept = autoAccept;
        this.invitationDelegate.Invoke(invitation:  invitation, shouldAutoAccept:  autoAccept);
    }

}
