using UnityEngine;
public class GadgetRecipesCategoryButton : SelectableButton
{
    // Fields
    private UISprite icon;
    internal CaptionView 丒上万丆万丁七与三;
    private GadgetRecipesUI 不丛丒世丙七丌业万;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(CaptionView 丒上万丆万丁七与三, string 丛丐丌丙丈七丛丛东, GadgetRecipesUI 不丛丒世丙七丌业万)
    {
        this.丒上万丆万丁七与三 = 丒上万丆万丁七与三;
        this.不丛丒世丙七丌业万 = 不丛丒世丙七丌业万;
        this.icon.spriteName = 丛丐丌丙丈七丛丛东;
    }
    public override void OnClick()
    {
        this.OnClick();
        if(this.丒上万丆万丁七与三 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.丒上万丆万丁七与三.transform.localPosition;
        this.不丛丒世丙七丌业万.ScrollTo(下业丕七东丌丝下且:  -val_3.y);
    }
    public GadgetRecipesCategoryButton()
    {
    
    }

}
