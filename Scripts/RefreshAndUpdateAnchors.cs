using UnityEngine;
public class RefreshAndUpdateAnchors : MonoBehaviour
{
    // Fields
    public UIPanel panel;
    
    // Methods
    private void Start()
    {
        this.panel.ResetAndUpdateAnchors();
        this.panel.Refresh();
    }
    public RefreshAndUpdateAnchors()
    {
    
    }

}
