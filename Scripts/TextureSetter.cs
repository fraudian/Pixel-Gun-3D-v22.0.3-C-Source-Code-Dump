using UnityEngine;
public sealed class TextureSetter : MonoBehaviour
{
    // Fields
    public string TextureName;
    
    // Methods
    private void Awake()
    {
        SkipPresser.丗丆丂七丄丅东与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TextureSetter::丟不丏世丝丕与世丘()));
        SkipTrainingButton.与一丏丂丒丙丟与丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TextureSetter::且不丅丅万丞业东丛()));
    }
    private void OnDestroy()
    {
        SkipPresser.丛上丅丛丂丞丐丈丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TextureSetter::丟不丏世丝丕与世丘()));
        SkipTrainingButton.东丟一丂世下东丛丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TextureSetter::且不丅丅万丞业东丛()));
    }
    private void 丟不丏世丝丕与世丘()
    {
        if((System.String.IsNullOrEmpty(value:  this.TextureName)) != false)
        {
                return;
        }
        
        UnityEngine.Texture val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "SkipTraining", 丌丗丏丏丛东专丁且:  this.TextureName));
        if((this.GetComponent<UITexture>()) == null)
        {
            
        }
    
    }
    private void 且不丅丅万丞业东丛()
    {
        if((this.GetComponent<UITexture>()) == null)
        {
            
        }
    
    }
    public TextureSetter()
    {
    
    }

}
