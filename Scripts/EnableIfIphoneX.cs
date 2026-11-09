using UnityEngine;
public class EnableIfIphoneX : MonoBehaviour
{
    // Fields
    public UnityEngine.MonoBehaviour[] objects;
    public bool activateGameObject;
    
    // Methods
    private void Start()
    {
        var val_4;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_4;
        label_14:
        UnityEngine.MonoBehaviour val_4 = this.objects[0];
        if(val_4 != 0)
        {
                if(this.activateGameObject != false)
        {
                val_4.gameObject.SetActive(value:  true);
        }
        
            val_4.enabled = true;
        }
        
        val_4 = 1;
        label_4:
        if(val_4 < this.objects.Length)
        {
            goto label_14;
        }
    
    }
    public EnableIfIphoneX()
    {
    
    }

}
