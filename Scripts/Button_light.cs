using UnityEngine;
public sealed class Button_light : MonoBehaviour
{
    // Fields
    public UITexture lightTexture;
    
    // Methods
    private void Start()
    {
        if(this.lightTexture == 0)
        {
                return;
        }
        
        this.lightTexture.enabled = false;
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        if(this.lightTexture == 0)
        {
                return;
        }
        
        this.lightTexture.enabled = 丆且上丘世下丅且丞;
    }
    public Button_light()
    {
    
    }

}
