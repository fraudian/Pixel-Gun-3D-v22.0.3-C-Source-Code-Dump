using UnityEngine;
public class PlayAnimationSounds : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource aSource;
    public UnityEngine.AudioClip[] sounds;
    
    // Methods
    private void PlayAnimSound(int number)
    {
        this.aSource.pitch = 1f;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.aSource.loop = false;
        this.aSource.clip = this.sounds[(long)number];
        this.aSource.Play();
    }
    private void PlayAnimSoundPithced(int number)
    {
        this.aSource.pitch = UnityEngine.Random.Range(min:  0.6f, max:  1.2f);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.aSource.loop = false;
        this.aSource.clip = this.sounds[(long)number];
        this.aSource.Play();
    }
    public PlayAnimationSounds()
    {
    
    }

}
