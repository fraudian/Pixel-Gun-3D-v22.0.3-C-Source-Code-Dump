using UnityEngine;
internal sealed class ChallengeDoneAchieveBox : AchieveBox
{
    // Fields
    public Rilisoft.TextGroup Title;
    private UnityEngine.GameObject _textureGO;
    private UIBasicSprite 三与丕丘丌丈一丆七;
    private UnityEngine.Texture 世上丁丘丐不下专与;
    
    // Properties
    internal UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
    internal UnityEngine.Texture 与丆丂三丘东丆丌丒 { get; }
    
    // Methods
    internal UIBasicSprite 丆下世世丟七专丞丒()
    {
        if(this.三与丕丘丌丈一丆七 != 0)
        {
                return (UIBasicSprite)this.三与丕丘丌丈一丆七;
        }
        
        if(this._textureGO == 0)
        {
                return (UIBasicSprite)this.三与丕丘丌丈一丆七;
        }
        
        this.三与丕丘丌丈一丆七 = this._textureGO.GetComponent<UIBasicSprite>();
        return (UIBasicSprite)this.三与丕丘丌丈一丆七;
    }
    internal UnityEngine.Texture 丝不丆丟丆丄丞丙上()
    {
        UnityEngine.Texture val_3;
        if(this.世上丁丘丐不下专与 == 0)
        {
                this.世上丁丘丐不下专与 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/crown_icon");
            return val_3;
        }
        
        val_3 = this.世上丁丘丐不下专与;
        return val_3;
    }
    internal void 丟不丏世丝丕与世丘(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        UnityEngine.Texture val_4 = 与万丆丛丒万丝丙丑;
        if(val_4 == 0)
        {
                val_4 = this.丝不丆丟丆丄丞丙上();
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.丆下世世丟七专丞丒(), 与万丆丛丒万丝丙丑:  val_4);
    }
    internal void 丒一丝与丏丝万丘且(string 丕丗丘丑丛与丑业丒)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(丟丅丘丂丆丘三丟丄:  this.Title, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    public ChallengeDoneAchieveBox()
    {
    
    }

}
