using UnityEngine;
public class GadgetPreviewUI : MonoBehaviour
{
    // Fields
    private UITexture icon;
    private UILabel gadgetName;
    private UILabel description;
    private UIBasicSprite bg;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专, string 丑世丁七丆万丙三丁, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.gadgetName.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  三丐三丞丘丕不丒专.nameLocalizationKey);
        this.description.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  三丐三丞丘丕不丒专.descriptionLocalizationKey);
        this.bg.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    public GadgetPreviewUI()
    {
    
    }

}
