using UnityEngine;
public sealed class ButtonClickSound : MonoBehaviour
{
    // Fields
    internal static ButtonClickSound 丆丕丝丒不丙且丐丗;
    public UnityEngine.AudioClip Click;
    
    // Methods
    private void Start()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void PlayClick()
    {
        if(this.Click == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.Click);
    }
    internal static void 丁业上丏不丕三丗不()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
    }
    public ButtonClickSound()
    {
    
    }

}
