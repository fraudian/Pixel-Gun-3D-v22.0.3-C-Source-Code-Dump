using UnityEngine;
public class TestControllThirdCameraSettings : MonoBehaviour
{
    // Fields
    public UISlider slider;
    public UILabel label;
    public int sliderInd;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void OnChangeValueSlider()
    {
    
    }
    public TestControllThirdCameraSettings()
    {
    
    }

}
