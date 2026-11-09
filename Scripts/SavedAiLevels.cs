using UnityEngine;
[Serializable]
public class PlayerBotsManager.SavedAiLevels
{
    // Fields
    private int[] teammatesStartAiLevels;
    private int[] enemiesStartAiLevels;
    private int[] deathmatchStartAiLevels;
    public int[] teammatesAiLevels;
    public int[] enemiesAiLevels;
    public int[] dmAiLevels;
    
    // Methods
    public void 丒三丐丕下丌丕丟丝()
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  PlayerBotsManager.丁丟丛业丅丘丙丕丗, defaultValue:  "");
        if((System.String.IsNullOrEmpty(value:  val_1)) == false)
        {
            goto label_3;
        }
        
        PlayerBotsManager.SavedAiLevels val_3 = null;
        val_9 = val_3;
        val_3 = new PlayerBotsManager.SavedAiLevels();
        if(val_9 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_9 = UnityEngine.JsonUtility.FromJson<SavedAiLevels>(json:  val_1);
        if(val_9 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        this.teammatesAiLevels = (val_4.teammatesAiLevels == null) ? this.teammatesStartAiLevels : (val_4 + 40);
        this.enemiesAiLevels = (val_4.enemiesAiLevels == null) ? this.enemiesStartAiLevels : (val_4 + 48);
        this.dmAiLevels = (val_4.dmAiLevels == null) ? this.deathmatchStartAiLevels : (val_4 + 56);
    }
    public void 丟丗丁下丒丗丒丘业(int[] 不业业且丙丙七丛丂, int[] 丕丆丞与专丝三下东, int[] 丒丒丂丛丐丕丐下不)
    {
        var val_2;
        this.teammatesAiLevels = 不业业且丙丙七丛丂;
        this.enemiesAiLevels = 丕丆丞与专丝三下东;
        this.dmAiLevels = 丒丒丂丛丐丕丐下不;
        val_2 = null;
        val_2 = null;
        UnityEngine.PlayerPrefs.SetString(key:  PlayerBotsManager.丁丟丛业丅丘丙丕丗, value:  UnityEngine.JsonUtility.ToJson(obj:  this));
    }
    public PlayerBotsManager.SavedAiLevels()
    {
        this.teammatesStartAiLevels = new int[4] {3, 2, 2, 2};
        this.enemiesStartAiLevels = new int[5] {2, 1, 1, 0, 0};
        this.deathmatchStartAiLevels = new int[9] {2, 2, 1, 1, 0, 0, 0, 0, 0};
    }

}
