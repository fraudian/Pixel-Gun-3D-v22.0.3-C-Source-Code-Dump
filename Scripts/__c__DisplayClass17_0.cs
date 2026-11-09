using UnityEngine;
private sealed class AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0
{
    // Fields
    public GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
    public GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;
    public GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener;
    public System.Action <>9__1;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0()
    {
    
    }
    internal void <AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)
    {
        if(status == 1)
        {
            goto label_1;
        }
        
        if(status != 3)
        {
            goto label_2;
        }
        
        if((this.<>9__1) == null)
        {
            goto label_4;
        }
        
        label_13:
        this.<>4__this.mAndroidClient.SignOut(uiCallback:  this.<>9__1);
        return;
        label_1:
        this.<>4__this.mInvitation = invitation;
        this.<>4__this.AcceptInvitation(invitationId:  this.<>4__this.mInvitation.InvitationId, listener:  this.listener);
        return;
        label_2:
        GooglePlayGames.OurUtils.Logger.d(msg:  "User did not complete invitation screen.");
        this.listenerOnGameThread.OnRoomConnected(success:  false);
        return;
        label_4:
        this.<>9__1 = new System.Action(object:  this, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0::<AcceptFromInbox>b__1());
        if((this.<>4__this.mAndroidClient) != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    internal void <AcceptFromInbox>b__1()
    {
        this.listenerOnGameThread.OnRoomConnected(success:  false);
    }

}
