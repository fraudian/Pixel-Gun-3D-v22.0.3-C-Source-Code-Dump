using UnityEngine;
public class ExecuteOnEnable : MonoBehaviour
{
    // Fields
    public UnityEngine.Events.UnityEvent onEnable;
    public bool isSoundFX;
    public bool lateUpdate;
    public bool forIphoneX;
    public bool forWideScreen;
    private bool 丞丂丙丘上丗丆专且;
    private bool 业丌丁业世业万一丝;
    private bool 丟东丙下与不专丟丆;
    
    // Methods
    private void Awake()
    {
        this.丞丂丙丘上丗丆专且 = 东丗上丁下业一丂丂.丐业丂丞且不东丕丗();
        float val_6 = (float)UnityEngine.Screen.width;
        val_6 = val_6 / (float)UnityEngine.Screen.height;
        this.业丌丁业世业万一丝 = (val_6 > 1.86f) ? 1 : 0;
    }
    private void OnEnable()
    {
        if(this.isSoundFX == false)
        {
            goto label_1;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == true)
        {
            goto label_9;
        }
        
        return;
        label_1:
        if(this.forIphoneX == false)
        {
            goto label_6;
        }
        
        if(this.丞丂丙丘上丗丆专且 == true)
        {
            goto label_9;
        }
        
        return;
        label_6:
        if(this.forWideScreen != false)
        {
                if(this.业丌丁业世业万一丝 == false)
        {
                return;
        }
        
        }
        
        label_9:
        this.丞丙东丌一三专丏不();
    }
    private void 丞丙东丌一三专丏不()
    {
        if(this.lateUpdate != false)
        {
                this.丟东丙下与不专丟丆 = true;
            return;
        }
        
        this.onEnable.Invoke();
    }
    private void LateUpdate()
    {
        if(this.丟东丙下与不专丟丆 == false)
        {
                return;
        }
        
        this.onEnable.Invoke();
        this.丟东丙下与不专丟丆 = false;
    }
    public ExecuteOnEnable()
    {
    
    }

}
