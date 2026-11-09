using UnityEngine;
public class AGSScore
{
    // Fields
    public AGSPlayer player;
    public int rank;
    public string scoreString;
    public long scoreValue;
    
    // Methods
    public static AGSScore fromHashtable(System.Collections.Hashtable scoreHashTable)
    {
        System.Collections.Hashtable val_9 = scoreHashTable;
        if(val_9 != null)
        {
                val_9 = 0;
        }
        
        .player = AGSPlayer.fromHashtable(playerDataAsHashtable:  null);
        .rank = System.Int32.Parse(s:  scoreHashTable.ToString());
        .scoreString = scoreHashTable.ToString();
        .scoreValue = System.Int64.Parse(s:  scoreHashTable.ToString());
        return (AGSScore)new AGSScore();
    }
    public static System.Collections.Generic.List<AGSScore> fromArrayList(System.Collections.ArrayList list)
    {
        System.Collections.Hashtable val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<AGSScore> val_1 = new System.Collections.Generic.List<AGSScore>();
        label_17:
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(list.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_10 = list;
        if(val_10.Current != null)
        {
                val_10 = 0;
        }
        
        val_1.Add(item:  AGSScore.fromHashtable(scoreHashTable:  val_10));
        goto label_17;
        label_7:
        val_11 = 0;
        val_12 = 0;
        if(list != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            list.Dispose();
        }
        
        if( != 1)
        {
                return val_1;
        }
        
        if( == false)
        {
                return val_1;
        }
        
        return val_1;
    }
    public override string ToString()
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(this.player != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(this.player == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = this.player;
        val_1[1] = this.rank;
        val_1[2] = this.scoreValue;
        val_1[3] = this.scoreString;
        return (string)System.String.Format(format:  "player: {0}, rank: {1}, scoreValue: {2}, scoreString: {3}", args:  val_1);
    }
    public AGSScore()
    {
    
    }

}
