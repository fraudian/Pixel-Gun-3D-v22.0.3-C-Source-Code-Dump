using UnityEngine;
public class ResizeWidgetForRatio : MonoBehaviour
{
    // Fields
    private UIWidget[] widgets;
    private UnityEngine.Vector2 sizeFor4x3;
    private UnityEngine.Vector2 sizeFor16x9;
    public bool isLabels;
    private int fontSizeFor4x3;
    private int fontSizeFor16x9;
    
    // Methods
    private void Start()
    {
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(this.widgets == null)
        {
                return;
        }
        
        float val_11 = (float)UnityEngine.Screen.width;
        val_11 = 1152921504838422528;
        val_11 = val_11 / (float)UnityEngine.Screen.height;
        val_12 = 0;
        if((double)val_11 > 1.7)
        {
            goto label_2;
        }
        
        goto label_3;
        label_13:
        this.widgets[0].width = UnityEngine.Mathf.RoundToInt(f:  this.sizeFor16x9);
        val_13 = UnityEngine.Mathf.RoundToInt(f:  this.sizeFor16x9);
        this.widgets[0].height = val_13;
        val_14 = 1;
        label_2:
        if(val_14 < this.widgets.Length)
        {
            goto label_13;
        }
        
        if(this.isLabels == false)
        {
                return;
        }
        
        val_11 = 1152921524277258528;
        val_15 = 0;
        goto label_15;
        label_25:
        this.widgets[0].width = UnityEngine.Mathf.RoundToInt(f:  this.sizeFor4x3);
        val_13 = UnityEngine.Mathf.RoundToInt(f:  this.sizeFor4x3);
        this.widgets[0].height = val_13;
        val_16 = 1;
        label_3:
        if(val_16 < this.widgets.Length)
        {
            goto label_25;
        }
        
        if(this.isLabels == false)
        {
                return;
        }
        
        val_11 = 1152921524277258528;
        val_17 = 0;
        goto label_27;
        label_36:
        val_13 = 0;
        UILabel val_7 = this.widgets[val_13].GetComponent<UILabel>();
        if(val_7 != 0)
        {
                val_13 = this.fontSizeFor16x9;
            val_7.fontSize = val_13;
        }
        
        val_15 = 1;
        label_15:
        if(val_15 < this.widgets.Length)
        {
            goto label_36;
        }
        
        return;
        label_46:
        val_13 = 1;
        UILabel val_9 = this.widgets[val_13].GetComponent<UILabel>();
        if(val_9 != 0)
        {
                val_13 = this.fontSizeFor4x3;
            val_9.fontSize = val_13;
        }
        
        val_17 = 2;
        label_27:
        if(val_17 < this.widgets.Length)
        {
            goto label_46;
        }
    
    }
    public ResizeWidgetForRatio()
    {
    
    }

}
