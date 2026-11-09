using UnityEngine;
public class AGSAchievement
{
    // Fields
    public string title;
    public string id;
    public string description;
    public float progress;
    public int pointValue;
    public bool isHidden;
    public bool isUnlocked;
    public int position;
    public System.DateTime dateUnlocked;
    
    // Methods
    public static AGSAchievement fromHashtable(System.Collections.Hashtable hashtable)
    {
        new AGSAchievement() = new System.Object();
        .title = hashtable.ToString();
        .id = hashtable.ToString();
        .description = hashtable.ToString();
        .progress = System.Single.Parse(s:  hashtable.ToString());
        .pointValue = System.Int32.Parse(s:  hashtable.ToString());
        .position = System.Int32.Parse(s:  hashtable.ToString());
        .isUnlocked = System.Boolean.Parse(value:  hashtable.ToString());
        .isHidden = System.Boolean.Parse(value:  hashtable.ToString());
        System.DateTime val_19 = AGSAchievement.getTimefromEpochTime(javaTimeStamp:  System.Int64.Parse(s:  hashtable.ToString()));
        .dateUnlocked = val_19;
        return (AGSAchievement)new AGSAchievement();
    }
    public static AGSAchievement GetBlankAchievement()
    {
        var val_2;
        AGSAchievement val_1 = new AGSAchievement();
        if(val_1 != null)
        {
                .isHidden = false;
            .isUnlocked = false;
            .title = "";
            .id = "";
            .description = "";
            .progress = 0f;
            .pointValue = 0;
        }
        else
        {
                mem[16] = "";
            mem[24] = "";
            mem[32] = "";
            .pointValue = 0;
            mem[48] = 0;
            .isUnlocked = false;
            mem[40] = 0;
        }
        
        .position = 0;
        val_2 = null;
        val_2 = null;
        .dateUnlocked = System.DateTime.MinValue;
        return val_1;
    }
    private static System.DateTime getTimefromEpochTime(long javaTimeStamp)
    {
        System.DateTime val_1 = 0.AddMilliseconds(value:  (double)javaTimeStamp);
        System.DateTime val_2 = val_1.dateData.ToLocalTime();
        return (System.DateTime)val_2.dateData;
    }
    public override string ToString()
    {
        object[] val_1 = new object[8];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.title != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.title == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.title;
        val_1[1] = this.id;
        val_1[2] = this.pointValue;
        val_1[3] = this.isHidden;
        val_1[4] = this.isUnlocked;
        val_1[5] = this.progress;
        val_1[6] = this.position;
        val_1[7] = this.dateUnlocked;
        return (string)System.String.Format(format:  "title: {0}, id: {1}, pointValue: {2}, hidden: {3}, unlocked: {4}, progress: {5}, position: {6}, date: {7} ", args:  val_1);
    }
    public AGSAchievement()
    {
    
    }

}
