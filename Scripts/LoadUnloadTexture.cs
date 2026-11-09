using UnityEngine;
public class LoadUnloadTexture : MonoBehaviour
{
    // Fields
    private string texturePath;
    public bool isTextureMasked;
    private string textureAlphaPath;
    private UITextureMasked 丏丝丂三丑下丕丟上;
    private UITexture 三与丕丘丌丈一丆七;
    
    // Properties
    private UITextureMasked 丁万业丂丞丙丒丁丁 { get; }
    private UITexture 丌丟三丅上丅上丗丞 { get; }
    
    // Methods
    private void OnEnable()
    {
        if(this.isTextureMasked != false)
        {
                this.丐上东丞丘丌丙七丕();
            return;
        }
        
        this.丙丄丈丌业丝七丌丛();
    }
    private void 丐上东丞丘丌丙七丕()
    {
        UnityEngine.Object val_11 = 1152921505284374528;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.texturePath)) == true)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.textureAlphaPath)) == true)
        {
                return;
        }
        
        val_11 = 1152921504848912384;
        if(this.丘世专丏丁丐万丗丘() == 0)
        {
                return;
        }
        
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.texturePath)) == 0)
        {
                return;
        }
        
        val_11 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.textureAlphaPath);
        if(val_11 == 0)
        {
                return;
        }
        
        UITextureMasked val_9 = this.丘世专丏丁丐万丗丘();
        if(this.丘世专丏丁丐万丗丘() == null)
        {
            
        }
    
    }
    private void 丙丄丈丌业丝七丌丛()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.texturePath)) == true)
        {
                return;
        }
        
        if(this.丆下世世丟七专丞丒() == 0)
        {
                return;
        }
        
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.texturePath)) == 0)
        {
                return;
        }
        
        if(this.丆下世世丟七专丞丒() == null)
        {
            
        }
    
    }
    private void OnDisable()
    {
        if(this.isTextureMasked != false)
        {
                this.丌东丛上世业一丛丘();
            return;
        }
        
        this.丈丌丁世丂七丈丅不();
    }
    private void 丌东丛上世业一丛丘()
    {
        if(this.丘世专丏丁丐万丗丘() == 0)
        {
                return;
        }
        
        UITextureMasked val_3 = this.丘世专丏丁丐万丗丘();
        UITextureMasked val_4 = this.丘世专丏丁丐万丗丘();
        UITextureMasked val_5 = this.丘世专丏丁丐万丗丘();
        if(this.丘世专丏丁丐万丗丘() == null)
        {
            
        }
    
    }
    private void 丈丌丁世丂七丈丅不()
    {
        if(this.丆下世世丟七专丞丒() == 0)
        {
                return;
        }
        
        UITexture val_3 = this.丆下世世丟七专丞丒();
        if(this.丆下世世丟七专丞丒() == null)
        {
            
        }
    
    }
    private UITextureMasked 丘世专丏丁丐万丗丘()
    {
        UITextureMasked val_3;
        if(this.丏丝丂三丑下丕丟上 == 0)
        {
                this.丏丝丂三丑下丕丟上 = this.GetComponent<UITextureMasked>();
            return val_3;
        }
        
        val_3 = this.丏丝丂三丑下丕丟上;
        return val_3;
    }
    private UITexture 丆下世世丟七专丞丒()
    {
        UITexture val_3;
        if(this.三与丕丘丌丈一丆七 == 0)
        {
                this.三与丕丘丌丈一丆七 = this.GetComponent<UITexture>();
            return val_3;
        }
        
        val_3 = this.三与丕丘丌丈一丆七;
        return val_3;
    }
    public LoadUnloadTexture()
    {
        this.isTextureMasked = true;
    }

}
