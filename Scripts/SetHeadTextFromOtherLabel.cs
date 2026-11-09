using UnityEngine;
public class SetHeadTextFromOtherLabel : MonoBehaviour
{
    // Fields
    public UILabel otherLabel;
    public UILabel[] headLabels;
    
    // Methods
    private void Update()
    {
        goto label_0;
        label_6:
        this.headLabels[0].text = this.otherLabel.text;
        0 = 1;
        label_0:
        if(0 < this.headLabels.Length)
        {
            goto label_6;
        }
    
    }
    public SetHeadTextFromOtherLabel()
    {
    
    }

}
