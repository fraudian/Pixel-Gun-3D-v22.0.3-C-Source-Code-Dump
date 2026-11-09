using UnityEngine;
internal sealed class WidthNotLessThan : PGBehaviour
{
    // Fields
    internal UIWidget taget;
    internal int baseWidth;
    private UIWidget 与东七丏丆世丟丁丌;
    
    // Properties
    internal UIWidget 丕丟丟丝丝丞七且下 { get; }
    
    // Methods
    internal UIWidget 丁丏世七三丗与丏与()
    {
        UIWidget val_3;
        if(this.与东七丏丆世丟丁丌 == 0)
        {
                this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
            return val_3;
        }
        
        val_3 = this.与东七丏丆世丟丁丌;
        return val_3;
    }
    private void Update()
    {
        int val_12;
        if(this.taget.width > this.baseWidth)
        {
                if(this.丁丏世七三丗与丏与().width != this.taget.width)
        {
            goto label_4;
        }
        
        }
        
        if(this.taget.width >= this.baseWidth)
        {
                return;
        }
        
        if(this.丁丏世七三丗与丏与().width != this.baseWidth)
        {
            goto label_8;
        }
        
        return;
        label_4:
        UIWidget val_8 = this.丁丏世七三丗与丏与();
        val_12 = this.taget.width;
        goto label_11;
        label_8:
        val_12 = this.baseWidth;
        label_11:
        this.丁丏世七三丗与丏与().width = val_12;
        this.丁丏世七三丗与丏与().ResetAndUpdateAnchors();
    }
    public WidthNotLessThan()
    {
    
    }

}
