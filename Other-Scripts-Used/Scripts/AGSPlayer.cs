using UnityEngine;
public class AGSPlayer
{
    // Fields
    public readonly string alias;
    public readonly string playerId;
    public readonly string avatarUrl;
    private const string aliasKey = "alias";
    private const string playerIdKey = "playerId";
    private const string avatarUrlKey = "avatarUrl";
    
    // Methods
    public static AGSPlayer fromHashtable(System.Collections.Hashtable playerDataAsHashtable)
    {
        string val_5;
        string val_6;
        string val_7;
        if((playerDataAsHashtable & 1) != 0)
        {
                val_5 = playerDataAsHashtable.ToString();
        }
        else
        {
                val_5 = "";
        }
        
        if((playerDataAsHashtable & 1) != 0)
        {
                val_6 = playerDataAsHashtable.ToString();
        }
        else
        {
                val_6 = "";
        }
        
        if((playerDataAsHashtable & 1) != 0)
        {
                val_7 = playerDataAsHashtable.ToString();
        }
        else
        {
                val_7 = "";
        }
        
        new AGSPlayer() = new System.Object();
        .alias = val_5;
        .playerId = val_6;
        .avatarUrl = val_7;
        return (AGSPlayer)new AGSPlayer();
    }
    public static AGSPlayer GetBlankPlayer()
    {
        .alias = "";
        .playerId = "";
        .avatarUrl = "";
        return (AGSPlayer)new AGSPlayer();
    }
    public static AGSPlayer BlankPlayerWithID(string playerId)
    {
        .alias = "";
        .playerId = playerId;
        .avatarUrl = "";
        return (AGSPlayer)new AGSPlayer();
    }
    private AGSPlayer(string alias, string playerId, string avatarUrl)
    {
        val_1 = new System.Object();
        this.alias = alias;
        this.playerId = val_1;
        this.avatarUrl = avatarUrl;
    }
    public override string ToString()
    {
        return System.String.Format(format:  "alias: {0}, playerId: {1}, avatarUrl: {2}", arg0:  this.alias, arg1:  this.playerId, arg2:  this.avatarUrl);
    }

}
