using UnityEngine;
public class PlayDragonAudio : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip UpClip;
    public UnityEngine.AudioClip IdleClip;
    public UnityEngine.AudioClip DownClip;
    public UnityEngine.AudioClip ChargeClip;
    public UnityEngine.AudioSource audioSourceComp;
    
    // Methods
    private void 下与三上丘丈七不丕()
    {
        this.audioSourceComp.clip = this.UpClip;
        this.audioSourceComp.Play();
    }
    private void 丏丟七丝丆丌丟丌七()
    {
        this.audioSourceComp.clip = this.IdleClip;
        this.audioSourceComp.Play();
    }
    private void 丕丁七且丝东不丄丞()
    {
        this.audioSourceComp.clip = this.DownClip;
        this.audioSourceComp.Play();
    }
    private void 不丆丆下丌丁丒丆丁()
    {
        this.audioSourceComp.clip = this.ChargeClip;
        this.audioSourceComp.Play();
    }
    public PlayDragonAudio()
    {
    
    }

}
