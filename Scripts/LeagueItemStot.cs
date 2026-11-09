using UnityEngine;
public class LeagueItemStot : MonoBehaviour
{
    // Fields
    private UnityEngine.Color 丞丙不丈丂上丑丞七;
    private UnityEngine.GameObject _lockIndicator;
    private UIBasicSprite _texture;
    
    // Methods
    private void 丟不丏世丝丕与世丘(UnityEngine.Texture 与万丆丛丒万丝丙丑, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        UIBasicSprite val_14;
        if((与万丆丛丒万丝丙丑 == 0) || ((与万丆丛丒万丝丙丑.name.Contains(value:  "_icon1_big")) == false))
        {
            goto label_6;
        }
        
        val_14 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
        goto label_9;
        label_6:
        val_14 = this._texture;
        if((System.Type.op_Equality(left:  this._texture.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_13;
        }
        
        val_14.enabled = false;
        val_14 = this._texture.gameObject.AddComponent<UITexture>();
        val_14.width = this._texture.width;
        val_14.height = this._texture.height;
        val_14.depth = this._texture.depth;
        UnityEngine.Color val_13 = this._texture.color;
        val_14.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        UnityEngine.Object.Destroy(obj:  this._texture);
        label_9:
        this._texture = val_14;
        label_13:
        val_14.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        if(this._texture == null)
        {
            
        }
    
    }
    private UIBasicSprite 下丕丁丘上三丆丕丈()
    {
        return (UIBasicSprite)this._texture;
    }
    private void Awake()
    {
        UnityEngine.Color val_1 = this._texture.color;
        this.丞丙不丈丂上丑丞七 = val_1;
        mem[1152921538729759148] = val_1.g;
        mem[1152921538729759152] = val_1.b;
        mem[1152921538729759156] = val_1.a;
        this.gameObject.SetActive(value:  false);
    }
    public void Set(UnityEngine.Texture 与万丆丛丒万丝丙丑, bool 世丈丟丈万上丈丟丟, bool 东丟丑万丐丏三七万)
    {
        UnityEngine.Color val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.gameObject.SetActive(value:  true);
        if((世丈丟丈万上丈丟丟 != true) && (东丟丑万丐丏三七万 != true))
        {
                UnityEngine.Color val_2 = UnityEngine.Color.white;
            val_5 = val_2.r;
            val_6 = val_2.g;
            val_7 = val_2.b;
            val_8 = val_2.a;
            val_9 = this._lockIndicator.gameObject;
            val_10 = 1;
        }
        else
        {
                val_5 = this.丞丙不丈丂上丑丞七;
            val_9 = this._lockIndicator.gameObject;
            val_10 = 0;
        }
        
        val_9.SetActive(value:  false);
        this.丟不丏世丝丕与世丘(与万丆丛丒万丝丙丑:  与万丆丛丒万丝丙丑, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5, g = V9.16B, b = V10.16B, a = V11.16B});
    }
    public void Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    public LeagueItemStot()
    {
    
    }

}
