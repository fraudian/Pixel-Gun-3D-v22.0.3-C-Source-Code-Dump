using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass51_0
{
    // Fields
    public string achievementID;
    public double progress;
    public GooglePlayGames.PlayGamesPlatform <>4__this;
    public System.Action<bool> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass51_0()
    {
    
    }
    internal void <ReportProgress>b__0(GooglePlayGames.BasicApi.Achievement[] ach)
    {
        GooglePlayGames.BasicApi.Achievement val_12;
        var val_13;
        string val_14;
        double val_15;
        double val_16;
        double val_17;
        System.Action<System.Boolean> val_18;
        val_13 = 0;
        goto label_1;
        label_6:
        val_12 = ach[0];
        if((System.String.op_Equality(a:  ach[0x0][0].mId, b:  this.achievementID)) == true)
        {
            goto label_4;
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < ach.Length)
        {
            goto label_6;
        }
        
        GooglePlayGames.OurUtils.Logger.e(msg:  "Unable to locate achievement " + this.achievementID);
        this.callback.Invoke(obj:  false);
        return;
        label_4:
        val_14 = mem[ach[0x0] + 32];
        val_14 = ach[0x0] + 32;
        if((ach[0x0] + 32 + 24) == 0)
        {
            goto label_12;
        }
        
        GooglePlayGames.OurUtils.Logger.d(msg:  "Progress " + this.progress + " interpreted as incremental target (approximate).");
        val_15 = this.progress;
        if((val_15 >= 0f) && (val_15 <= 1))
        {
                GooglePlayGames.OurUtils.Logger.w(msg:  "Progress " + val_15 + " is less than or equal to 1. You might be trying to use values in the range of [0,1], while values are expected to be within the range [0,100]. If you are using the latter, you can safely ignore this message.");
            val_15 = this.progress;
        }
        
        double val_12 = 100;
        val_12 = val_15 / val_12;
        val_15 = val_12 * ((double)ach[0x0] + 32 + 32);
        if(val_15 >= 0f)
        {
            goto label_23;
        }
        
        if(val_15 != (-0.5))
        {
            goto label_24;
        }
        
        val_16 = val_15;
        val_17 = -1;
        goto label_25;
        label_12:
        if(this.progress >= 100)
        {
            goto label_26;
        }
        
        GooglePlayGames.OurUtils.Logger.d(msg:  "Progress " + this.progress + " not enough to unlock non-incremental achievement."(" not enough to unlock non-incremental achievement."));
        val_18 = this.callback;
        val_18.Invoke(obj:  false);
        return;
        label_23:
        if(val_15 != 0.5)
        {
            goto label_31;
        }
        
        val_16 = this.progress;
        val_17 = 1;
        label_25:
        val_17 = val_16 + val_17;
        var val_6 = (((long)val_16 & (4.94065645841247E-324)) != 0) ? (val_16) : (val_17);
        goto label_41;
        label_26:
        GooglePlayGames.OurUtils.Logger.d(msg:  "Progress " + this.progress + " interpreted as UNLOCK.");
        val_14 = this.achievementID;
        val_18 = this.callback;
        var val_13 = 0;
        val_13 = val_13 + 1;
        goto label_40;
        label_24:
        double val_8 = val_15 + (-0.5);
        goto label_41;
        label_31:
        double val_9 = val_15 + 0.5;
        label_41:
        val_14 = this.achievementID;
        val_18 = this.callback;
        var val_14 = 0;
        val_14 = val_14 + 1;
        this.<>4__this.mClient.SetStepsAtLeast(achId:  val_14, steps:  (int)val_15, callback:  val_18);
        return;
        label_40:
        this.<>4__this.mClient.UnlockAchievement(achievementId:  val_14, successOrFailureCalllback:  val_18);
    }

}
