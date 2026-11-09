using UnityEngine;
public class LabelAddToFrieadsNote : MonoBehaviour
{
    // Fields
    private bool 三丛丛丅丐丅丄下丏;
    private bool 丂七丆下丄丙丟丘上;
    
    // Methods
    private void Update()
    {
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丐丞丞丏丞业丄一丈.七万专丕丝丅丟丐丗();
        bool val_2 = val_6 ^ 1;
        var val_4 = (this.丂七丆下丄丙丟丘上 == true) ? 1 : 0;
        val_4 = val_4 ^ val_2;
        this.三丛丛丅丐丅丄下丏 = val_2;
        if(val_4 == false)
        {
            goto label_1;
        }
        
        UILabel val_5 = this.GetComponent<UILabel>();
        val_7 = null;
        if(val_6 == false)
        {
            goto label_2;
        }
        
        val_8 = null;
        val_6 = 与丂丏丛丞丞丒丟丄.七丆且世与丟世丙不;
        if(val_5 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_2:
        val_9 = null;
        val_6 = 与丂丏丛丞丞丒丟丄.丅丕丘丁下丁丈丘丘;
        if(val_5 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_5.text = val_6;
        label_1:
        this.丂七丆下丄丙丟丘上 = this.三丛丛丅丐丅丄下丏;
    }
    public LabelAddToFrieadsNote()
    {
    
    }

}
