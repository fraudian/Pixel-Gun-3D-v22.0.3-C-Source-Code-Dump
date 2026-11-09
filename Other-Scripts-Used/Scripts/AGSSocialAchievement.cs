using UnityEngine;
public class AGSSocialAchievement : IAchievement, IAchievementDescription
{
    // Fields
    public readonly AGSAchievement achievement;
    private string <id>k__BackingField;
    private double <percentCompleted>k__BackingField;
    
    // Properties
    public string id { get; set; }
    public double percentCompleted { get; set; }
    public bool completed { get; }
    public bool hidden { get; }
    public System.DateTime lastReportedDate { get; }
    public string title { get; }
    public UnityEngine.Texture2D image { get; }
    public string achievedDescription { get; }
    public string unachievedDescription { get; }
    public int points { get; }
    
    // Methods
    public AGSSocialAchievement(AGSAchievement achievement)
    {
        AGSAchievement val_2 = achievement;
        if(val_2 == null)
        {
            goto label_1;
        }
        
        this.achievement = val_2;
        goto label_2;
        label_1:
        AGSClient.LogGameCircleError(errorMessage:  "AGSSocialAchievement constructor \"achievement\" argument should not be null");
        val_2 = AGSAchievement.GetBlankAchievement();
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        this.<id>k__BackingField = val_1.id;
        this.<percentCompleted>k__BackingField = (double)val_1.progress;
        return;
        label_5:
        this.<id>k__BackingField = 28563616;
    }
    public AGSSocialAchievement()
    {
        this.achievement = AGSAchievement.GetBlankAchievement();
    }
    public string get_id()
    {
        return (string)this.<id>k__BackingField;
    }
    public void set_id(string value)
    {
        this.<id>k__BackingField = value;
    }
    public double get_percentCompleted()
    {
        return (double)this.<percentCompleted>k__BackingField;
    }
    public void set_percentCompleted(double value)
    {
        this.<percentCompleted>k__BackingField = value;
    }
    public bool get_completed()
    {
        if(this.achievement != null)
        {
                return (bool)this.achievement.isUnlocked;
        }
        
        return (bool)this.achievement.isUnlocked;
    }
    public bool get_hidden()
    {
        if(this.achievement != null)
        {
                return (bool)this.achievement.isHidden;
        }
        
        return (bool)this.achievement.isHidden;
    }
    public System.DateTime get_lastReportedDate()
    {
        if(this.achievement != null)
        {
                return (System.DateTime)this.achievement.dateUnlocked;
        }
        
        return (System.DateTime)this.achievement.dateUnlocked;
    }
    public void ReportProgress(System.Action<bool> callback)
    {
        GameCircleSocial.Instance.ReportProgress(achievementID:  this.<id>k__BackingField, progress:  this.<percentCompleted>k__BackingField, callback:  callback);
    }
    public string get_title()
    {
        if(this.achievement != null)
        {
                return (string)this.achievement.title;
        }
        
        return (string)this.achievement.title;
    }
    public UnityEngine.Texture2D get_image()
    {
        AGSClient.LogGameCircleError(errorMessage:  "IAchievementDescription.image.get is not available for GameCircle");
        return 0;
    }
    public string get_achievedDescription()
    {
        if(this.achievement != null)
        {
                return (string)this.achievement.description;
        }
        
        return (string)this.achievement.description;
    }
    public string get_unachievedDescription()
    {
        if(this.achievement != null)
        {
                return (string)this.achievement.description;
        }
        
        return (string)this.achievement.description;
    }
    public int get_points()
    {
        if(this.achievement != null)
        {
                return (int)this.achievement.pointValue;
        }
        
        return (int)this.achievement.pointValue;
    }

}
