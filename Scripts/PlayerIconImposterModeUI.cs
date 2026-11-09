using UnityEngine;
internal sealed class PlayerIconImposterModeUI : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject cross;
    private UnityEngine.GameObject imposterContainer;
    private UITextureMasked playerAvatarTexture;
    private UISprite playerBackground;
    private UILabel playerNameLabel;
    
    // Methods
    internal void 丄丐丁不七丂丁业丌(bool 丒东三丌专丗三丂丟)
    {
        丒东三丌专丗三丂丟 = 丒东三丌专丗三丂丟;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cross, 丏业丟一东丂东丘丛:  丒东三丌专丗三丂丟);
    }
    internal void 下丞丛世下丅且丈三(bool 专丛下不丄且丌丛丕)
    {
        专丛下不丄且丌丛丕 = 专丛下不丄且丌丛丕;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.imposterContainer, 丏业丟一东丂东丘丛:  专丛下不丄且丌丛丕);
    }
    internal void 丈丑丅上七丑丅一丒(string 与丟丅七丞且且丛丕)
    {
        string val_8;
        string val_9;
        UnityEngine.Texture val_10;
        var val_11;
        val_8 = 与丟丅七丞且且丛丕;
        PlayerIconImposterModeUI.丒丑万一丁丕东一丗 val_1 = new PlayerIconImposterModeUI.丒丑万一丁丕东一丗();
        if(val_1 != null)
        {
                val_9 = val_1;
            .与丟丅七丞且且丛丕 = val_8;
        }
        else
        {
                val_9 = 16;
            mem[16] = val_8;
            val_8 = mem[16];
        }
        
        if((System.String.IsNullOrEmpty(value:  val_8)) != false)
        {
                return;
        }
        
        PGCompany.丌丙丈丕丛丆丝丗丟 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  val_9);
        if(val_4 != null)
        {
                val_10 = val_4;
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.playerAvatarTexture, 与万丆丛丒万丝丙丑:  val_10);
        val_11 = null;
        val_11 = null;
        System.ValueTuple<System.String, UnityEngine.Color32> val_6 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<System.String, UnityEngine.Color32>>(source:  ImposterModeController.丟丟丄且丄丞与丑丘, predicate:  new System.Func<System.ValueTuple<System.String, UnityEngine.Color32>, System.Boolean>(object:  val_1, method:  System.Boolean PlayerIconImposterModeUI.丒丑万一丁丕东一丗::下丏丕万且丙丒丝丂(System.ValueTuple<string, UnityEngine.Color32> 三丟东丕丄丄下下丑)));
        UnityEngine.Color val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 112, g = 140, b = 187, a = 174});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.playerBackground, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
    }
    internal void 三丅东丕丆丐三丞丄(string 丞丞下东且丗丄丒丏)
    {
        this.playerNameLabel.text = 丞丞下东且丗丄丒丏;
    }
    public PlayerIconImposterModeUI()
    {
    
    }

}
