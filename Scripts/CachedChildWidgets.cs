using UnityEngine;
public class CachedChildWidgets : MonoBehaviour
{
    // Fields
    public UIPanel thisPanel;
    
    // Methods
    public void InvalidatePanel()
    {
        if(this.thisPanel == 0)
        {
                this.thisPanel = this.GetComponent<UIPanel>();
            return;
        }
        
        if(this.thisPanel == null)
        {
            
        }
    
    }
    public CachedChildWidgets()
    {
    
    }

}
