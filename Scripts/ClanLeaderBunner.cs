using UnityEngine;
[Serializable]
public class ClanLeaderBunner
{
    // Fields
    public string id;
    public string name;
    public string logo;
    internal UnityEngine.Texture2D texture;
    
    // Methods
    internal ClanLeaderBunner()
    {
        this.id = System.String.alignConst;
        this.name = System.String.alignConst;
        this.logo = System.String.alignConst;
    }
    internal ClanLeaderBunner(string 丞丅上丏丂且下丅与, string 丒丘丏上丙丟丑丕丈, string 丁且专丑万万丘丟七)
    {
        val_1 = new System.Object();
        this.id = 丞丅上丏丂且下丅与;
        this.name = val_1;
        this.logo = 丁且专丑万万丘丟七;
        this.上一上丆万丏丘丞万();
    }
    internal void 上一上丆万丏丘丞万()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.logo)) == true)
        {
                return;
        }
        
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  1, height:  1);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  val_3, data:  System.Convert.FromBase64String(s:  this.logo));
        val_3.filterMode = 0;
        this.texture = val_3;
    }

}
