using UnityEngine;
internal sealed class GadgetAudioComponent : PGBehaviour
{
    // Fields
    private UnityEngine.AudioSource audioSource;
    private UnityEngine.AudioClip soundActivate;
    private UnityEngine.AudioClip soundOn;
    private UnityEngine.AudioClip soundDeactivate;
    
    // Methods
    private void OnEnable()
    {
        this.audioSource.loop = false;
        this.audioSource.Stop();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁万丕丐世丌丛七七());
    }
    private System.Collections.IEnumerator 丁万丕丐世丌丛七七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GadgetAudioComponent.丛丈丙丅丟专丌丌丛();
    }
    internal void Deactivate()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.下丐丁与丛东上丁丂());
    }
    private System.Collections.IEnumerator 下丐丁与丛东上丁丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GadgetAudioComponent.丆丑业丈丑世丒丑一();
    }
    public GadgetAudioComponent()
    {
    
    }

}
