using UnityEngine;
public class DeadExplosionController : MonoBehaviour
{
    // Fields
    public UnityEngine.SkinnedMeshRenderer mySkinRenderer;
    public float timeAfteAnim;
    public float startTimerAnim;
    private float 丑上丌业丕一业三丆;
    
    // Methods
    public void StartAnim()
    {
        float val_1 = this.timeAfteAnim;
        val_1 = this.startTimerAnim + val_1;
        this.丑上丌业丕一业三丆 = val_1;
    }
    private void Update()
    {
        float val_3;
        if(this.丑上丌业丕一业三丆 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丑上丌业丕一业三丆 - val_1;
        this.丑上丌业丕一业三丆 = val_1;
        if(val_1 < 0)
        {
                val_1 = val_1 * 1.5f;
            val_1 = val_1 / this.startTimerAnim;
            val_3 = val_1 + (-0.25f);
        }
        else
        {
                val_3 = 1.25f;
        }
        
        this.mySkinRenderer.material.SetFloat(name:  "_Burn", value:  val_3);
    }
    public DeadExplosionController()
    {
        this.timeAfteAnim = 0.5f;
        this.startTimerAnim = 0.5f;
        this.丑上丌业丕一业三丆 = -1f;
    }

}
