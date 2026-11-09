using UnityEngine;
internal sealed class NurseryNotAvailableBannerWindow : BannerWindow
{
    // Fields
    private UILabel levelRequiredLabel;
    
    // Methods
    public override void Show()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.MonoBehaviour val_7;
        if(this.levelRequiredLabel != 0)
        {
                val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅 >= 1)
        {
                val_5 = null;
            val_5 = null;
            this.levelRequiredLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3497"), arg0:  与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅);
            val_6 = 1;
            val_7 = this.levelRequiredLabel;
        }
        else
        {
                val_7 = this.levelRequiredLabel;
            val_6 = 0;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  false);
        }
        
        this.Show();
    }
    public NurseryNotAvailableBannerWindow()
    {
    
    }

}
