using UnityEngine;
public class AGSSocialLeaderboardScore : IScore
{
    // Fields
    private readonly AGSScore score;
    private string <leaderboardID>k__BackingField;
    private long <value>k__BackingField;
    
    // Properties
    public string leaderboardID { get; set; }
    public long value { get; set; }
    public System.DateTime date { get; }
    public string formattedValue { get; }
    public string userID { get; }
    public int rank { get; }
    
    // Methods
    public AGSSocialLeaderboardScore(AGSScore score, AGSLeaderboard leaderboard)
    {
        string val_2;
        val_1 = new System.Object();
        if(score == null)
        {
            goto label_1;
        }
        
        if(val_1 == null)
        {
            goto label_2;
        }
        
        this.score = score;
        this.<leaderboardID>k__BackingField = leaderboard.id;
        this.<value>k__BackingField = score.scoreValue;
        return;
        label_1:
        val_2 = "AGSSocialLeaderboardScore constructor \"score\" argument should not be null";
        goto label_5;
        label_2:
        val_2 = "AGSSocialLeaderboardScore constructor \"leaderboard\" argument should not be null";
        label_5:
        AGSClient.LogGameCircleError(errorMessage:  val_2);
    }
    public AGSSocialLeaderboardScore()
    {
        this.score = 0;
        this.<leaderboardID>k__BackingField = 0;
    }
    public string get_leaderboardID()
    {
        return (string)this.<leaderboardID>k__BackingField;
    }
    public void set_leaderboardID(string value)
    {
        this.<leaderboardID>k__BackingField = value;
    }
    public long get_value()
    {
        return (long)this.<value>k__BackingField;
    }
    public void set_value(long value)
    {
        this.<value>k__BackingField = value;
    }
    public System.DateTime get_date()
    {
        var val_1;
        AGSClient.LogGameCircleError(errorMessage:  "IScore.date.get is not available for GameCircle");
        val_1 = null;
        val_1 = null;
        return (System.DateTime)System.DateTime.MinValue;
    }
    public string get_formattedValue()
    {
        if(this.score == null)
        {
                return 0;
        }
        
        return (string)this.score.scoreString;
    }
    public string get_userID()
    {
        if(this.score == null)
        {
                return 0;
        }
        
        if(this.score.player != null)
        {
                return (string)this.score.player.alias;
        }
        
        return (string)this.score.player.alias;
    }
    public int get_rank()
    {
        if(this.score == null)
        {
                return 0;
        }
        
        return (int)this.score.rank;
    }
    public void ReportScore(System.Action<bool> callback)
    {
        GameCircleSocial.Instance.ReportScore(score:  this.<value>k__BackingField, board:  this.<leaderboardID>k__BackingField, callback:  callback);
        AGSLeaderboardsClient.SubmitScore(leaderboardId:  this.<leaderboardID>k__BackingField, score:  this.<value>k__BackingField, userData:  0);
    }

}
