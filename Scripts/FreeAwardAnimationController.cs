using UnityEngine;
public class FreeAwardAnimationController : MonoBehaviour
{
    // Fields
    private UnityEngine.Animation 业与丘丞丂专丘丗世;
    
    // Methods
    private void Awake()
    {
        this.业与丘丞丂专丘丗世 = this.GetComponent<UnityEngine.Animation>();
    }
    private void OnEnable()
    {
        null = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
                return;
        }
        
        this.业与丘丞丂专丘丗世.Item["Animate"].time = this.业与丘丞丂专丘丗世.Item["Animate"].length;
    }
    public FreeAwardAnimationController()
    {
    
    }

}
