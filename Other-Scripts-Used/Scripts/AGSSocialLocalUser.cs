using UnityEngine;
public class AGSSocialLocalUser : AGSSocialUser, ILocalUser, IUserProfile
{
    // Fields
    public static AGSPlayer player;
    public static System.Collections.Generic.List<AGSSocialUser> friendList;
    
    // Properties
    public UnityEngine.SocialPlatforms.IUserProfile[] friends { get; }
    public bool authenticated { get; }
    public bool underage { get; }
    public override string id { get; }
    
    // Methods
    public void Authenticate(System.Action<bool> callback)
    {
        GameCircleSocial.Instance.RequestLocalPlayer(callback:  callback);
        var val_4 = 0;
        val_4 = val_4 + 1;
        UnityEngine.Social.Active.Authenticate(user:  this, callback:  callback);
    }
    public void LoadFriends(System.Action<bool> callback)
    {
        GameCircleSocial.Instance.RequestFriends(callback:  callback);
    }
    public UnityEngine.SocialPlatforms.IUserProfile[] get_friends()
    {
        null = null;
        if(AGSSocialLocalUser.friendList != null)
        {
                return AGSSocialLocalUser.friendList.ToArray();
        }
        
        return AGSSocialLocalUser.friendList.ToArray();
    }
    public bool get_authenticated()
    {
        return AGSPlayerClient.IsSignedIn();
    }
    public bool get_underage()
    {
        AGSClient.LogGameCircleError(errorMessage:  "ILocalUser.underage.get is not available for GameCircle");
        return false;
    }
    public void Authenticate(System.Action<bool, string> callback)
    {
        .callback = callback;
        this.Authenticate(callback:  new System.Action<System.Boolean>(object:  new AGSSocialLocalUser.<>c__DisplayClass10_0(), method:  System.Void AGSSocialLocalUser.<>c__DisplayClass10_0::<Authenticate>b__0(bool success)));
    }
    public override string get_id()
    {
        null = null;
        if(AGSSocialLocalUser.player != null)
        {
                return (string)AGSSocialLocalUser.player.playerId;
        }
        
        return (string)AGSSocialLocalUser.player.playerId;
    }
    public AGSSocialLocalUser()
    {
        val_1 = new System.Object();
        mem[1152921524064688112] = AGSPlayer.GetBlankPlayer();
    }
    private static AGSSocialLocalUser()
    {
        AGSSocialLocalUser.player = AGSPlayer.GetBlankPlayer();
        AGSSocialLocalUser.friendList = new System.Collections.Generic.List<AGSSocialUser>();
    }

}
