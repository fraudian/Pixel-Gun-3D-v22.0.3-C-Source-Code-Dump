using UnityEngine;
internal class GameLoopSpriteOnButton : MonoBehaviour
{
    // Fields
    internal PGCompany.GameplayLoop.GameplayLoopType LoopType;
    private UIBasicSprite Sprite;
    
    // Methods
    internal void 丆丐丅下丟上上七丄()
    {
        string val_7;
        PGCompany.GameplayLoop.业丒丅丂丗丁业上且 val_2 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丏丈丞丅丒与丄业东(丁丅丈丌丟世丗丗丟:  this.LoopType);
        if(val_2 != null)
        {
                val_7 = val_2.丐丆丅丝七世一丛且();
        }
        else
        {
                val_7 = 0.丐丆丅丝七世一丛且();
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != false)
        {
                return;
        }
        
        this.上丑丗丙上丂丑丞丄(专丙万三万且东三丐:  val_7, 丘下丂三一丆丌七不:  val_2.丒丂丑丞丟丟万丆丙());
    }
    private void 上丑丗丙上丂丑丞丄(string 专丙万三万且东三丐, string 丘下丂三一丆丌七不)
    {
        UnityEngine.Texture val_5 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  专丙万三万且东三丐);
        if(val_5 == 0)
        {
                UnityEngine.Debug.LogError(message:  "Get dafault texture: "("Get dafault texture: ") + 丘下丂三一丆丌七不);
            val_5 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丘下丂三一丆丌七不);
        }
        
        if(this.Sprite == null)
        {
            
        }
    
    }
    public GameLoopSpriteOnButton()
    {
    
    }

}
