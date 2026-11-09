using UnityEngine;
public sealed class ConstrainedLayout : PGBehaviour
{
    // Fields
    private bool repositionOnEnable;
    private bool setWidth;
    private bool setHeight;
    private int maxWidth;
    private int maxHeight;
    private UIWidget holderWidget;
    private WidgetLayoutConstrained widgetLayoutConstrained;
    private UIRect targetSize;
    private System.Collections.Generic.List<UIRect> anchorsToUpdate;
    
    // Methods
    private void OnEnable()
    {
        if(this.repositionOnEnable == false)
        {
                return;
        }
        
        this.丁下丏丙一丗下丈七();
    }
    internal void 业丏丗丐丂业东丂丗(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        this.widgetLayoutConstrained.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  丝三丁东丈丒世丅业);
    }
    internal void 业丏丗丐丂业东丂丗(UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)
    {
        this.widgetLayoutConstrained.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  不丗上三丛丒上东丑);
    }
    internal void 业丏丗丐丂业东丂丗(UIWidget 与丘东下丈东丛丂万)
    {
        this.widgetLayoutConstrained.widgetLayout.AddElement(世丌丌丙丞丟下东丞:  与丘东下丈东丛丂万);
    }
    internal void 世业丒万丘丆专丘丐()
    {
        this.widgetLayoutConstrained.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    internal void 丁下丏丙一丗下丈七()
    {
        UIRect val_7;
        int val_8;
        this.widgetLayoutConstrained.widget = this.holderWidget;
        this.targetSize.ResetAndUpdateAnchors();
        val_7 = this.targetSize;
        if(val_7 != null)
        {
                val_7 = 0;
        }
        
        val_8 = 0;
        if(this.setWidth != false)
        {
                if((this.maxWidth & 2147483648) == 0)
        {
                val_8 = UnityEngine.Mathf.Min(a:  0, b:  this.maxWidth);
        }
        
            this.holderWidget.width = val_8;
        }
        
        if(this.setHeight != false)
        {
                if((this.maxHeight & 2147483648) == 0)
        {
                val_7 = UnityEngine.Mathf.Min(a:  0, b:  this.maxHeight);
        }
        
            val_8 = this.holderWidget;
            val_8.height = val_7;
        }
        
        this.holderWidget.ResetAndUpdateAnchors();
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.anchorsToUpdate);
        this.widgetLayoutConstrained.Reposition();
    }
    public ConstrainedLayout()
    {
        this.setWidth = true;
        this.setHeight = true;
        this.maxWidth = 0;
        this.maxHeight = 0;
    }

}
