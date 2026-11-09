using UnityEngine;
internal class PlaySoundOnAnimatorEvent : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource source;
    
    // Methods
    public void PlaySound()
    {
        if(this.source == 0)
        {
                return;
        }
        
        this.source.Play();
    }
    public void StopSound()
    {
        if(this.source == 0)
        {
                return;
        }
        
        this.source.Stop();
    }
    public PlaySoundOnAnimatorEvent()
    {
    
    }

}
