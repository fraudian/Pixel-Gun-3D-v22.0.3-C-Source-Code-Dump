using UnityEngine;
public class SquadDungeonPopup : MonoBehaviour
{
    // Fields
    public UnityEngine.Texture[] iconTextures;
    public UITexture[] monsterIcons;
    public UILabel[] monsterLevels;
    public UITexture[] bossIcons;
    public UILabel[] bossLevels;
    public Rilisoft.ButtonHandler hideBtn;
    
    // Methods
    internal void 上东与丛丞下丈专丈(DungeonWindowUI.万丗且专万丟丌丂丐 东一丁世丑丞业丄丐, 丐七不丝丆丐丂丐下 丒万丟丅丌丝丟下下)
    {
        var val_9;
        string val_10;
        var val_11;
        val_9 = 0;
        goto label_1;
        label_33:
        if(val_9 >= 东一丁世丑丞业丄丐.不丙且丄上且万丙丞.Length)
        {
            goto label_3;
        }
        
        if(东一丁世丑丞业丄丐.不丙且丄上且万丙丞[0] <= 丒万丟丅丌丝丟下下)
        {
            goto label_6;
        }
        
        label_3:
        val_10 = 0;
        this.monsterIcons[val_10].gameObject.SetActive(value:  false);
        goto label_11;
        label_6:
        this.monsterIcons[0].gameObject.SetActive(value:  true);
        UITexture val_12 = this.monsterIcons[0];
        UnityEngine.Texture val_14 = this.iconTextures[东一丁世丑丞业丄丐.不丙且丄上且万丙丞[0]];
        this.monsterLevels[0].gameObject.SetActive(value:  true);
        val_10 = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  1407933312);
        this.monsterLevels[0].text = val_10;
        label_11:
        val_9 = 1;
        label_1:
        if(val_9 < this.monsterIcons.Length)
        {
            goto label_33;
        }
        
        val_11 = 0;
        goto label_34;
        label_66:
        if(val_11 >= 东一丁世丑丞业丄丐.专丆丌丞丙丅丌丄丕.Length)
        {
            goto label_36;
        }
        
        if(东一丁世丑丞业丄丐.不丙且丄上且万丙丞[0] <= 丒万丟丅丌丝丟下下)
        {
            goto label_39;
        }
        
        label_36:
        val_10 = 0;
        this.bossIcons[val_10].gameObject.SetActive(value:  false);
        goto label_44;
        label_39:
        this.bossIcons[0].gameObject.SetActive(value:  true);
        UITexture val_20 = this.bossIcons[0];
        UnityEngine.Texture val_22 = this.iconTextures[东一丁世丑丞业丄丐.专丆丌丞丙丅丌丄丕[0]];
        this.bossLevels[0].gameObject.SetActive(value:  true);
        val_10 = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  1407933312);
        this.bossLevels[0].text = val_10;
        label_44:
        val_11 = 1;
        label_34:
        if(val_11 < this.bossIcons.Length)
        {
            goto label_66;
        }
    
    }
    public SquadDungeonPopup()
    {
    
    }

}
