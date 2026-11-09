using UnityEngine;
public class PlaySoundRepeatedly : MonoBehaviour
{
    // Fields
    public float Between;
    public float Delay;
    public float Interval;
    public int Repeats;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一下东一丈一丁丄丝());
    }
    private System.Collections.IEnumerator 一下东一丈一丁丄丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlaySoundRepeatedly.丘丙且万丒丝丂且丗();
    }
    public PlaySoundRepeatedly()
    {
        this.Between = 1f;
        this.Interval = 60f;
        this.Repeats = 3;
    }

}
