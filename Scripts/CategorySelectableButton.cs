using UnityEngine;
internal class CategorySelectableButton : SelectableButton
{
    // Fields
    protected System.Collections.Generic.List<UIBasicSprite> icons;
    protected UILabel nameLabel;
    protected string noneCategoryTextureName;
    private CategoryNames 专丄丌且一丕万与丛;
    
    // Properties
    protected UnityEngine.Texture 业且丞与一丕丑丘丈 { get; }
    public CategoryNames 七丌丌丏丗东丕且丅 { get; }
    
    // Methods
    protected UnityEngine.Texture 上丐丘不丑上丆丈丝()
    {
        return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.noneCategoryTextureName);
    }
    public CategoryNames get_Category()
    {
        return (CategoryNames)this.专丄丌且一丕万与丛;
    }
    internal virtual void 丈且东丑丂且万丒丅(CategoryNames 七丆丒与丗丌丄且丂)
    {
        UnityEngine.Texture val_12;
        CategorySelectableButton.业东下丕世丗丏万丏 val_1 = new CategorySelectableButton.业东下丕世丗丏万丏();
        this.专丄丌且一丕万与丛 = 七丆丒与丗丌丄且丂;
        if(七丆丒与丗丌丄且丂 == 9990000)
        {
                UnityEngine.Texture val_2 = this.上丐丘不丑上丆丈丝();
        }
        
        val_12 = PGCompany.万丞丘与丕丞下万丌.丑东丐下专丞丕丘世(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        if(val_1 != null)
        {
                .三丟三丌上丘丈与丞 = val_12;
        }
        else
        {
                .三丟三丌上丘丈与丞 = val_12;
            val_12 = (CategorySelectableButton.业东下丕世丗丏万丏)[1152921536994120432].三丟三丌上丘丈与丞;
        }
        
        if(val_12 == 0)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Debug.LogError(message:  "Textures/Shop_Categories_Icons/shop_icon_"("Textures/Shop_Categories_Icons/shop_icon_") + 七丆丒与丗丌丄且丂.ToString().Replace(oldValue:  "Category", newValue:  "").ToLower()(七丆丒与丗丌丄且丂.ToString().Replace(oldValue:  "Category", newValue:  "").ToLower()));
        }
        
        this.icons.ForEach(action:  new System.Action<UIBasicSprite>(object:  val_1, method:  System.Void CategorySelectableButton.业东下丕世丗丏万丏::丆一且世上丗上一丗(UIBasicSprite 三丟东丕丄丄下下丑)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.世丞丞上世丗丒丏丈(丟丆丏且专不丕上专:  null));
    }
    public CategorySelectableButton()
    {
    
    }

}
