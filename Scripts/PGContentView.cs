using UnityEngine;
internal sealed class PGContentView : PGBehaviour
{
    // Fields
    internal UISprite _icon;
    internal UIBasicSprite _texture;
    internal UISprite _bgSprite;
    internal UIBasicSprite _gradient;
    internal UILabel nameLabel;
    internal UILabel descriptionLabel;
    internal UILabel typeLabel;
    private ExpOpenSystem.丒上丂丑丐不丂丐且 三不丘万丞专丟且丏;
    private string 丌丘丘丁丆七丕与丂;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(ExpOpenSystem.丒上丂丑丐不丂丐且 丕丈下丁丑丂丗丒业, string 丙丒七且世丂不丕丄)
    {
        this.三不丘万丞专丟且丏 = 丕丈下丁丑丂丗丒业;
        this.丌丘丘丁丆七丕与丂 = 丙丒七且世丂不丕丄;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        if(this.三不丘万丞专丟且丏 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._icon, 万丑丞一丝丌丐丒丘:  this.三不丘万丞专丟且丏.Icon);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.三不丘万丞专丟且丏.PathTexture));
        UnityEngine.Color val_2 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  this.三不丘万丞专丟且丏.BgColor);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._bgSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._gradient, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  this.三不丘万丞专丟且丏.东丙上东业丆不丟丘());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  this.三不丘万丞专丟且丏.丒丗丝不丕丈世丏丞());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.typeLabel, 丕丗丘丑丛与丑业丒:  this.三不丘万丞专丟且丏.丘丛丆丕且丂业世丌());
    }
    public PGContentView()
    {
    
    }

}
