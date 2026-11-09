using UnityEngine;
public class AGSLeaderboardPercentile
{
    // Fields
    private const string percentileKey = "percentile";
    private const string scoreKey = "score";
    private const string playerKey = "player";
    public int percentile;
    public long score;
    public AGSPlayer player;
    
    // Methods
    public static AGSLeaderboardPercentile fromHashTable(System.Collections.Hashtable percentilesHashtable)
    {
        var val_8;
        .percentile = System.Int32.Parse(s:  percentilesHashtable.ToString());
        .score = System.Int64.Parse(s:  percentilesHashtable.ToString());
        val_8 = percentilesHashtable;
        if(val_8 != null)
        {
                val_8 = 0;
        }
        
        .player = AGSPlayer.fromHashtable(playerDataAsHashtable:  null);
        return (AGSLeaderboardPercentile)new AGSLeaderboardPercentile();
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "player: {0}, score: {1}, percentile: {2}", arg0:  this.player, arg1:  this.score, arg2:  this.percentile);
    }
    public AGSLeaderboardPercentile()
    {
    
    }

}
