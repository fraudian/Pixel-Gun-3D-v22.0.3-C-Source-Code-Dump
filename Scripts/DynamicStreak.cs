using UnityEngine;
public class DynamicStreak : MonoBehaviour
{
    // Fields
    private UISprite[] sprites;
    private UILabel message;
    
    // Methods
    public void Set(string 万丑丞一丝丌丐丒丘, string 丄丙下丝丛丒七丂丘)
    {
        goto label_0;
        label_4:
        this.sprites[0].spriteName = 万丑丞一丝丌丐丒丘;
        0 = 1;
        label_0:
        if(0 < this.sprites.Length)
        {
            goto label_4;
        }
        
        this.message.text = 丄丙下丝丛丒七丂丘;
    }
    public DynamicStreak()
    {
    
    }

}
