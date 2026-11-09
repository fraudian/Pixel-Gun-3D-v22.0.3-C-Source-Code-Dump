using UnityEngine;
public class NestAnimatorController : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        var val_3;
        string val_4;
        UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(val_1 == null)
        {
            goto label_6;
        }
        
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_7;
        }
        
        label_9:
        val_4 = "FastAppearance";
        goto label_8;
        label_6:
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
            goto label_9;
        }
        
        label_7:
        val_4 = "SlowAppearance";
        label_8:
        val_1.SetBool(name:  val_4, value:  true);
    }
    private void Update()
    {
    
    }
    public NestAnimatorController()
    {
    
    }

}
