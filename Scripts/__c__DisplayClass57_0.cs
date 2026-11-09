using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass57_0
{
    // Fields
    public System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass57_0()
    {
    
    }
    internal void <LoadAchievements>b__0(GooglePlayGames.BasicApi.Achievement[] ach)
    {
        var val_3;
        UnityEngine.SocialPlatforms.IAchievement[] val_1 = new UnityEngine.SocialPlatforms.IAchievement[0];
        val_3 = 0;
        goto label_2;
        label_8:
        val_3 = 1;
        val_1[0] = new GooglePlayGames.PlayGamesAchievement(ach:  ach[0]);
        label_2:
        if(val_3 < val_1.Length)
        {
            goto label_8;
        }
        
        this.callback.Invoke(obj:  val_1);
    }

}
