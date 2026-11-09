using UnityEngine;
public class ScaleButtonsPanel : MonoBehaviour
{
    // Fields
    public float scaleShort;
    public float scaleWidth;
    public bool Execute;
    
    // Methods
    private void Awake()
    {
        if(this.Execute == false)
        {
                return;
        }
        
        float val_5 = (float)UnityEngine.Screen.width;
        val_5 = val_5 / (float)UnityEngine.Screen.height;
        var val_3 = (val_5 > 1.5f) ? this.scaleWidth : this.scaleShort;
        this = this.transform;
        this.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ScaleButtonsPanel()
    {
        this.scaleShort = 0.79f;
        this.scaleWidth = 7.714148E-41f;
    }

}
