using UnityEngine;
public class WidgetLayoutElement : MonoBehaviour
{
    // Fields
    private WidgetLayout widgetLayout;
    
    // Methods
    private void OnEnable()
    {
        if(this.widgetLayout == 0)
        {
                return;
        }
        
        this.widgetLayout.Reposition();
    }
    private void OnDisable()
    {
        if(this.widgetLayout == 0)
        {
                return;
        }
        
        this.widgetLayout.Reposition();
    }
    public WidgetLayoutElement()
    {
    
    }

}
