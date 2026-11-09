using UnityEngine;
public class AnimationTuner : MonoBehaviour
{
    // Fields
    private float 丕丕世且下一与丝与;
    public float maxTime;
    public float minTime;
    public UnityEngine.Animation targetAnimation;
    
    // Methods
    private void Start()
    {
        this.丕丕世且下一与丝与 = UnityEngine.Random.Range(min:  this.minTime, max:  this.maxTime);
    }
    private void Update()
    {
        if(this.targetAnimation.isPlaying == true)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丕丕世且下一与丝与 - val_2;
        this.丕丕世且下一与丝与 = val_2;
        if(val_2 >= 0)
        {
                return;
        }
        
        this.丕丕世且下一与丝与 = UnityEngine.Random.Range(min:  this.minTime, max:  this.maxTime);
        bool val_4 = this.targetAnimation.Play();
    }
    public AnimationTuner()
    {
    
    }

}
