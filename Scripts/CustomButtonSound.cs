using UnityEngine;
public class CustomButtonSound : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip clickSound;
    
    // Methods
    private void OnClick()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.clickSound, 与丁万东丌丑下丏丕:  1f, 丟与不丄丕丞专下丛:  1f);
    }
    public CustomButtonSound()
    {
    
    }

}
