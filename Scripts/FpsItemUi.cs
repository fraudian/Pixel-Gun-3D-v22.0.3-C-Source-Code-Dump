using UnityEngine;
public class FpsItemUi : MonoBehaviour
{
    // Fields
    private UILabel currentFpsLabel;
    private UILabel avgFpsLabel;
    private UILabel avgMinFpsLabel;
    private UILabel dropCountFpsLabel;
    
    // Methods
    private void 丕上丘东丕下丟业不(float 七丆七不丛世丐不丟, float 丛七三丂丏丗东上丟, float 丘且丑与丅一丟丁业, int 丑专不丘丌丑丒丒世)
    {
        this.currentFpsLabel.text = System.String.Format(format:  "FPS: {0}", arg0:  七丆七不丛世丐不丟.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.avgFpsLabel.text = System.String.Format(format:  "Average: {0}", arg0:  丛七三丂丏丗东上丟.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.avgMinFpsLabel.text = System.String.Format(format:  "AvgMin: {0}", arg0:  丘且丑与丅一丟丁业.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.dropCountFpsLabel.text = 丑专不丘丌丑丒丒世.ToString(format:  "Drops: 0");
    }
    public FpsItemUi()
    {
    
    }

}
