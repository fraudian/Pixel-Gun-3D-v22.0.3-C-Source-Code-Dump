using UnityEngine;
internal sealed class CharacterCell : MonoBehaviour
{
    // Fields
    private UIBasicSprite icon;
    private UIBasicSprite classIcon;
    private UILabel nameLabel;
    private UnityEngine.GameObject selectedView;
    private UnityEngine.GameObject blockedView;
    private UILabel limitLabel;
    
    // Properties
    public UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    public UIBasicSprite 丁丙不丒上下上七丛 { get; }
    
    // Methods
    public UIBasicSprite get_Icon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icon);
        this.icon = val_1;
        return val_1;
    }
    public UIBasicSprite get_ClassIcon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.classIcon);
        this.classIcon = val_1;
        return val_1;
    }
    internal static string 七丗世业业丌丐专丒(下丐专一下不不上与.不丗丘不丄与丞丑丝 丛三丈丟丌丑丘丒丕)
    {
        var val_1;
        if(丛三丈丟丌丑丘丒丕 > 5)
        {
                return "Textures/MutationModeUI/"("Textures/MutationModeUI/") + System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_1 = mem[130691024 + (丛三丈丟丌丑丘丒丕) << 3];
        val_1 = 130691024 + (丛三丈丟丌丑丘丒丕) << 3;
        return "Textures/MutationModeUI/"("Textures/MutationModeUI/") + System.String.__il2cppRuntimeField_static_fields;
    }
    internal void 上东与丛丞下丈专丈(下丐专一下不不上与 丙丑丆上不丒上丕丛)
    {
        UILabel val_9;
        UIBasicSprite val_1 = this.Icon;
        UnityEngine.Texture val_2 = 丙丑丆上不丒上丕丛.丂丅丝丕丞丞丏业世();
        丏下业丈丏下一丐丂 val_4 = 万且三丛丗丐且东丑.丑七不且上丗丁一世().上七专上丁丞与业世(七丛业丘丕与丝不丝:  丙丑丆上不丒上丕丛.七丛业丘丕与丝不丝);
        val_9 = this.nameLabel;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        string val_5 = val_4.东丙上东业丆不丟丘();
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_12:
        val_9.text = val_5;
        UIBasicSprite val_6 = this.ClassIcon;
        UnityEngine.Texture val_8 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  CharacterCell.七丗世业业丌丐专丒(丛三丈丟丌丑丘丒丕:  丙丑丆上不丒上丕丛.丛三丈丟丌丑丘丒丕));
        val_9 = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        label_8:
        if(val_9 != 0)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    internal void 下丗三与丅丕三下上(int 丌丒丝东丌下丕丁丅, int 一丁丘丅丟与七丘与)
    {
        int val_4;
        var val_5;
        val_4 = 丌丒丝东丌下丕丁丅;
        if(一丁丘丅丟与七丘与 >= 1)
        {
                this.limitLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_4, arg1:  一丁丘丅丟与七丘与);
            var val_2 = (val_4 >= 一丁丘丅丟与七丘与) ? 1 : 0;
        }
        else
        {
                val_4 = System.String.Format(format:  "{0}", arg0:  val_4);
            this.limitLabel.text = val_4;
            val_5 = 0;
        }
        
        this.blockedView.SetActive(value:  false);
    }
    internal void 与丆与丂丄丞丒丏丑(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.selectedView.SetActive(value:  丙业与丙丗丝不丈东);
    }
    public CharacterCell()
    {
    
    }

}
