using UnityEngine;
public class AGSSocialUser : IUserProfile
{
    // Fields
    private AGSPlayer player;
    
    // Properties
    public string userName { get; }
    public virtual string id { get; }
    public bool isFriend { get; }
    public UnityEngine.SocialPlatforms.UserState state { get; }
    public UnityEngine.Texture2D image { get; }
    
    // Methods
    public AGSSocialUser()
    {
        this.player = AGSPlayer.GetBlankPlayer();
    }
    public AGSSocialUser(AGSPlayer player)
    {
        if(player == null)
        {
            goto label_0;
        }
        
        label_3:
        this.player = player;
        return;
        label_0:
        AGSPlayer val_1 = AGSPlayer.GetBlankPlayer();
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_3;
    }
    public string get_userName()
    {
        if(this.player != null)
        {
                return (string)this.player.alias;
        }
        
        return (string)this.player.alias;
    }
    public virtual string get_id()
    {
        if(this.player != null)
        {
                return (string)this.player.playerId;
        }
        
        return (string)this.player.playerId;
    }
    public bool get_isFriend()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = AGSSocialLocalUser.friendList.GetEnumerator();
        label_6:
        if(((-2016015176) & 1) == 0)
        {
            goto label_4;
        }
        
        if((System.String.op_Equality(a:  0.丐丏七丌丕丗业且上(), b:  this)) == false)
        {
            goto label_6;
        }
        
        val_5 = 1;
        goto label_7;
        label_4:
        val_5 = 0;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_5;
    }
    public UnityEngine.SocialPlatforms.UserState get_state()
    {
        AGSClient.LogGameCircleError(errorMessage:  "ILocalUser.state.get is not available for GameCircle");
        return 3;
    }
    public UnityEngine.Texture2D get_image()
    {
        AGSClient.LogGameCircleError(errorMessage:  "ILocalUser.image.get is not available for GameCircle");
        return 0;
    }

}
