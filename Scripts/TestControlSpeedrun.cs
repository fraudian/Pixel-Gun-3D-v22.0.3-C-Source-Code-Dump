using UnityEngine;
public class TestControlSpeedrun : MonoBehaviour
{
    // Fields
    private SettingsToggleButtons 丒世丅业丝东下与丗;
    private bool 下一七丝丘丕东上与;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void Update()
    {
        if((((this.下一七丝丘丕东上与 == true) ? 1 : 0) ^ this.丒世丅业丝东下与丗.IsChecked) == false)
        {
                return;
        }
        
        this.下一七丝丘丕东上与 = this.丒世丅业丝东下与丗.IsChecked;
        SpeedrunTrackController.丛专与丅下丌丆世丒.ChangeControlScheme(丘丄丒丗丞丈丁丄丗:  this.丒世丅业丝东下与丗.IsChecked);
    }
    public TestControlSpeedrun()
    {
    
    }

}
