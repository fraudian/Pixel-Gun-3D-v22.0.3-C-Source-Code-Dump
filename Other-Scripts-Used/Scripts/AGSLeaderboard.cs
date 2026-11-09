using UnityEngine;
public class AGSLeaderboard
{
    // Fields
    public string name;
    public string id;
    public string displayText;
    public string scoreFormat;
    public string imageUrl;
    
    // Methods
    public static AGSLeaderboard fromHashtable(System.Collections.Hashtable hashtable)
    {
        .name = hashtable.ToString();
        .id = hashtable.ToString();
        .displayText = hashtable.ToString();
        .scoreFormat = hashtable.ToString();
        .imageUrl = hashtable.ToString();
        return (AGSLeaderboard)new AGSLeaderboard();
    }
    public static AGSLeaderboard GetBlankLeaderboard()
    {
        string val_2;
        AGSLeaderboard val_1 = new AGSLeaderboard();
        if(val_1 != null)
        {
                val_2 = "";
            .name = val_2;
            .id = val_2;
            .displayText = val_2;
            .scoreFormat = val_2;
        }
        else
        {
                mem[16] = "";
            mem[24] = "";
            mem[32] = "";
            mem[40] = "";
            val_2 = "";
        }
        
        .imageUrl = val_2;
        return val_1;
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.name != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.name == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.name;
        val_1[1] = this.id;
        val_1[2] = this.displayText;
        val_1[3] = this.scoreFormat;
        val_1[4] = this.imageUrl;
        return System.String.Format(format:  "name: {0}, id: {1}, displayText: {2}, scoreFormat: {3}, imageUrl: {4}", args:  val_1);
    }
    public AGSLeaderboard()
    {
    
    }

}
