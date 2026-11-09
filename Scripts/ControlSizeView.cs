using UnityEngine;
internal sealed class ControlSizeView : MonoBehaviour
{
    // Fields
    public UISprite[] buttons;
    public SettingsToggleButtons leftHandPanel;
    public UISlider slider;
    public UISlider sliderAlpha;
    public UnityEngine.GameObject slidersBackground;
    
    // Methods
    public ControlSizeView()
    {
        this.buttons = new UISprite[9];
    }

}
