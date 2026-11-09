using UnityEngine;
internal class SymmetryToggleButton : MonoBehaviour
{
    // Fields
    public EditorTextures textureEditor;
    public UIToggle toggle;
    private bool 丌丈丝业三丕丗丌世;
    
    // Methods
    private void Awake()
    {
        this.丌丈丝业三丕丗丌世 = this.toggle.value;
    }
    internal void 丞丟丆上丕与一七丟()
    {
        this.丌丈丝业三丕丗丌世 = this.丌丈丝业三丕丗丌世 ^ 1;
        this.toggle.Set(丏业丟一东丂东丘丛:  (this.丌丈丝业三丕丗丌世 == false) ? 1 : 0);
        this.textureEditor.ToggleSymmetry(isSymmetry:  (this.丌丈丝业三丕丗丌世 == true) ? 1 : 0);
    }
    public void OnClick()
    {
        this.丞丟丆上丕与一七丟();
    }
    public SymmetryToggleButton()
    {
    
    }

}
