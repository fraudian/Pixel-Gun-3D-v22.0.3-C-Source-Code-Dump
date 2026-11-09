using UnityEngine;
public class AGSSocialLeaderboard : ILeaderboard
{
    // Fields
    private readonly AGSLeaderboard leaderboard;
    public long localPlayerScore;
    public int localPlayerRank;
    private UnityEngine.SocialPlatforms.TimeScope _timeScope;
    private string <id>k__BackingField;
    private UnityEngine.SocialPlatforms.UserScope <userScope>k__BackingField;
    private UnityEngine.SocialPlatforms.Range <range>k__BackingField;
    private UnityEngine.SocialPlatforms.IScore[] <scores>k__BackingField;
    
    // Properties
    public bool loading { get; }
    public string id { get; set; }
    public UnityEngine.SocialPlatforms.UserScope userScope { get; set; }
    public UnityEngine.SocialPlatforms.Range range { get; set; }
    public UnityEngine.SocialPlatforms.TimeScope timeScope { get; set; }
    public UnityEngine.SocialPlatforms.IScore localUserScore { get; }
    public uint maxRange { get; }
    public UnityEngine.SocialPlatforms.IScore[] scores { get; set; }
    public string title { get; }
    
    // Methods
    public AGSSocialLeaderboard(AGSLeaderboard leaderboard)
    {
        if(leaderboard != null)
        {
                this.leaderboard = leaderboard;
        }
        else
        {
                AGSClient.LogGameCircleError(errorMessage:  "AGSSocialLeaderboard constructor \"leaderboard\" argument should not be null");
            this.leaderboard = AGSLeaderboard.GetBlankLeaderboard();
        }
        
        this.<id>k__BackingField = leaderboard.id;
        this.<scores>k__BackingField = new AGSSocialLeaderboardScore[0];
        this.localPlayerScore = 0;
        this.localPlayerRank = 0;
        this._timeScope = 65533;
    }
    public AGSSocialLeaderboard()
    {
        this.leaderboard = AGSLeaderboard.GetBlankLeaderboard();
        this.localPlayerScore = 0;
        this.localPlayerRank = 0;
        this._timeScope = 65533;
    }
    public bool ScoresAvailable()
    {
        if(this.leaderboard == null)
        {
                return false;
        }
        
        if((this.<scores>k__BackingField) == null)
        {
                return false;
        }
        
        if((this.<scores>k__BackingField.Length) == 0)
        {
                return false;
        }
        
        if((this.localPlayerScore & 9223372036854775808) != 0)
        {
                return false;
        }
        
        int val_2 = this.localPlayerRank;
        val_2 = val_2 >> 31;
        return (bool)val_2 ^ 1;
    }
    public bool get_loading()
    {
        if(this.leaderboard == null)
        {
                return true;
        }
        
        if((this.<scores>k__BackingField) == null)
        {
                return true;
        }
        
        if((this.<scores>k__BackingField.Length) == 0)
        {
                return true;
        }
        
        if((this.localPlayerScore & 9223372036854775808) != 0)
        {
                return true;
        }
        
        return (bool)this.localPlayerRank >> 31;
    }
    public string get_id()
    {
        return (string)this.<id>k__BackingField;
    }
    public void set_id(string value)
    {
        this.<id>k__BackingField = value;
    }
    public UnityEngine.SocialPlatforms.UserScope get_userScope()
    {
        return (UnityEngine.SocialPlatforms.UserScope)this.<userScope>k__BackingField;
    }
    public void set_userScope(UnityEngine.SocialPlatforms.UserScope value)
    {
        this.<userScope>k__BackingField = value;
    }
    public UnityEngine.SocialPlatforms.Range get_range()
    {
        return new UnityEngine.SocialPlatforms.Range() {from = this.<range>k__BackingField, count = this.<range>k__BackingField};
    }
    public void set_range(UnityEngine.SocialPlatforms.Range value)
    {
        this.<range>k__BackingField = value;
    }
    public UnityEngine.SocialPlatforms.TimeScope get_timeScope()
    {
        return (UnityEngine.SocialPlatforms.TimeScope)this._timeScope;
    }
    public void set_timeScope(UnityEngine.SocialPlatforms.TimeScope value)
    {
        this.localPlayerScore = 0;
        this.localPlayerRank = 0;
        this.<scores>k__BackingField = new AGSSocialLeaderboardScore[0];
        this._timeScope = value;
        this.LoadScores(callback:  0);
        GameCircleSocial.Instance.RequestLocalUserScore(leaderboard:  this);
    }
    public UnityEngine.SocialPlatforms.IScore get_localUserScore()
    {
        var val_5;
        int val_6;
        AGSScore val_1 = new AGSScore();
        val_5 = null;
        val_5 = null;
        if(val_1 != null)
        {
                .player = AGSSocialLocalUser.player;
            .scoreValue = this.localPlayerScore;
            .scoreString = this.localPlayerScore.ToString();
            val_6 = this.localPlayerRank;
        }
        else
        {
                mem[16] = AGSSocialLocalUser.player;
            mem[40] = this.localPlayerScore;
            mem[32] = this.localPlayerScore.ToString();
            val_6 = val_6;
        }
        
        .rank = val_6;
        return (UnityEngine.SocialPlatforms.IScore)new AGSSocialLeaderboardScore(score:  val_1, leaderboard:  this.leaderboard);
    }
    public uint get_maxRange()
    {
        AGSClient.LogGameCircleError(errorMessage:  "ILeaderboard.maxRange.get is not available for GameCircle");
        return 0;
    }
    public UnityEngine.SocialPlatforms.IScore[] get_scores()
    {
        return (UnityEngine.SocialPlatforms.IScore[])this.<scores>k__BackingField;
    }
    public void set_scores(UnityEngine.SocialPlatforms.IScore[] value)
    {
        this.<scores>k__BackingField = value;
    }
    public string get_title()
    {
        if(this.leaderboard == null)
        {
                return 0;
        }
        
        return (string)this.leaderboard.name;
    }
    public void SetUserFilter(string[] userIDs)
    {
        AGSClient.LogGameCircleError(errorMessage:  "ILeaderboard.SetUserFilter is not available for GameCircle");
    }
    public void LoadScores(System.Action<bool> callback)
    {
        if(this.leaderboard != null)
        {
                GameCircleSocial.Instance.RequestScores(leaderboard:  this, callback:  callback);
            return;
        }
        
        callback.Invoke(obj:  false);
    }

}
