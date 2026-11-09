using UnityEngine;
public class setupGadgetPanel : MonoBehaviour
{
    // Fields
    public UIInputRilisoft timeLabel;
    public UIInputRilisoft thresholdLabel;
    
    // Methods
    private void Awake()
    {
        null = null;
        this.timeLabel.value = ToString();
        this.thresholdLabel.value = ToString();
    }
    public void timeInputChanged(UIInputRilisoft 丗丄下丈丑七丗丞专)
    {
        var val_3 = null;
        TouchPadController.丑丅丂丒且丅专丑丟 = System.Single.Parse(s:  this.timeLabel.value);
    }
    public void thresholdInputChanged(UIInputRilisoft 丗丄下丈丑七丗丞专)
    {
        var val_3 = null;
        TouchPadController.三丆丁丞与丘丄七丞 = System.Int32.Parse(s:  this.thresholdLabel.value);
    }
    public setupGadgetPanel()
    {
    
    }

}
