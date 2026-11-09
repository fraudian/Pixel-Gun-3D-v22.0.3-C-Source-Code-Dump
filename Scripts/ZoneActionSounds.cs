using UnityEngine;
internal sealed class ZoneActionSounds : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource longBeepSound;
    private UnityEngine.AudioSource beepSound;
    private UnityEngine.AudioSource actionSound;
    private UnityEngine.AudioClip resetActionSound;
    private UnityEngine.AudioClip loopActionSound;
    private bool 丘丝丞丄丏业七世专;
    private bool 丁不丐万一丒业七丁;
    
    // Methods
    internal void 三丈七七丈丞东丗东()
    {
        if(this.resetActionSound == 0)
        {
                return;
        }
        
        this.actionSound.Stop();
        this.丁不丐万一丒业七丁 = false;
        this.actionSound.PlayOneShot(clip:  this.resetActionSound);
    }
    internal void 丐七丌下三专专丆丑(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.AudioSource val_5;
        var val_1 = (this.丁不丐万一丒业七丁 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        val_5 = this.actionSound;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = this.loopActionSound;
        if(val_5 == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 != false)
        {
                if(this.actionSound.isPlaying == true)
        {
                return;
        }
        
            this.actionSound.loop = true;
            val_5 = this.loopActionSound;
            this.actionSound.clip = val_5;
            this.actionSound.Play();
            this.丁不丐万一丒业七丁 = true;
            return;
        }
        
        if(this.丁不丐万一丒业七丁 == false)
        {
                return;
        }
        
        this.actionSound.Stop();
        this.丁不丐万一丒业七丁 = false;
    }
    internal void 丘丁丘东与丛丁上三()
    {
        if(this.gameObject.activeInHierarchy != false)
        {
                if(this.longBeepSound == 0)
        {
                return;
        }
        
            this.longBeepSound.Play();
            if(this.longBeepSound.isPlaying == true)
        {
                return;
        }
        
        }
        
        this.丘丝丞丄丏业七世专 = true;
    }
    internal void 丆万丑丞丅丕下上丞()
    {
        if(this.beepSound == 0)
        {
                return;
        }
        
        this.beepSound.Play();
    }
    private void Update()
    {
        if(this.丘丝丞丄丏业七世专 == false)
        {
                return;
        }
        
        this.丘丝丞丄丏业七世专 = false;
        this.丘丁丘东与丛丁上三();
    }
    public ZoneActionSounds()
    {
    
    }

}
