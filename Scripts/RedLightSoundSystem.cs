using UnityEngine;
internal sealed class RedLightSoundSystem : PGBehaviour
{
    // Fields
    private UnityEngine.AudioSource myAudio;
    private UnityEngine.AudioClip stopMusic;
    private UnityEngine.AudioClip runMusic;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        this.myAudio.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
    }
    public void PlayStop()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.myAudio.pitch = 1f;
        this.myAudio.clip = this.stopMusic;
        this.myAudio.Play();
    }
    public void PlayRunForTime(float 丂三丟丂丈丐丆丗丟)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        float val_2 = this.runMusic.length;
        val_2 = val_2 / 丂三丟丂丈丐丆丗丟;
        this.myAudio.pitch = val_2;
        this.myAudio.clip = this.runMusic;
        this.myAudio.Play();
    }
    public RedLightSoundSystem()
    {
    
    }

}
