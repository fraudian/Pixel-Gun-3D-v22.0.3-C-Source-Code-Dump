using UnityEngine;
public class CameraSwitch : MonoBehaviour
{
    // Fields
    private int 不且丈丟丕丌丄万东;
    public UnityEngine.GameObject[] objects;
    public UnityEngine.UI.Text text;
    
    // Methods
    private void OnEnable()
    {
        string val_1 = this.objects[this.不且丈丟丕丌丄万东].name;
        if(this.text == null)
        {
            
        }
    
    }
    public void NextCamera()
    {
        int val_5;
        var val_6;
        if((this.不且丈丟丕丌丄万东 + 1) < this.objects.Length)
        {
                val_5 = this.不且丈丟丕丌丄万东 + 1;
        }
        else
        {
                val_5 = 0;
        }
        
        val_6 = 0;
        goto label_3;
        label_8:
        this.objects[0].SetActive(value:  (val_5 == val_6) ? 1 : 0);
        val_6 = 1;
        label_3:
        if(val_6 < this.objects.Length)
        {
            goto label_8;
        }
        
        this.不且丈丟丕丌丄万东 = val_5;
        string val_3 = this.objects[0].name;
        if(this.text == null)
        {
            
        }
    
    }
    public CameraSwitch()
    {
    
    }

}
