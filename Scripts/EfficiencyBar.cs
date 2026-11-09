using UnityEngine;
public class EfficiencyBar : MonoBehaviour
{
    // Fields
    public UILabel efficiencyLabel;
    public UISprite currentBar;
    public UISprite upBar;
    public UISprite maxUpBar;
    internal bool 业丑丙三一七下丙丙;
    private float 与丗七丐丑丒丁与丟;
    private float 丏专上东丗丗业丈三;
    private float 丛丏丑丐东丘丌丈东;
    private int 东不丁丒丛丙万下丏;
    private float 丁上丒丂三丈专丂世;
    private float 丙专万专丟万丂丒丏;
    private float 丈丂一一丞丛专下不;
    private bool 丁下丘丘丞业丒丕丏;
    
    // Methods
    internal void 丝丘专专丛且丆丏东(int 七丝东丛东丝且丆不, int 上丞丕专丈业丁世专, int 丞丌东丟且丒丐丑丂 = 0, int 业上丞丐万三丒丘上 = 0)
    {
        UILabel val_7;
        UISprite val_8;
        float val_9;
        val_7 = 业上丞丐万三丒丘上;
        val_8 = 七丝东丛东丝且丆不;
        if(this.丁下丘丘丞业丒丕丏 != false)
        {
                float val_7 = (float)上丞丕专丈业丁世专;
            val_9 = (float)val_8;
            val_7 = val_7 / val_9;
            this.currentBar.fillAmount = val_7;
            val_8 = this.upBar;
            float val_8 = (float)丞丌东丟且丒丐丑丂;
            val_8 = val_8 / val_9;
            val_8.fillAmount = val_8;
            float val_9 = (float)val_7;
            val_9 = val_9 / val_9;
            this.maxUpBar.fillAmount = val_9;
            val_7 = this.efficiencyLabel;
            val_7.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0437"), arg1:  上丞丕专丈业丁世专);
            this.丁下丘丘丞业丒丕丏 = false;
            return;
        }
        
        float val_11 = (float)val_8;
        this.东不丁丒丛丙万下丏 = 上丞丕专丈业丁世专;
        val_9 = this.丈丂一一丞丛专下不;
        float val_3 = (float)上丞丕专丈业丁世专 / val_11;
        this.与丗七丐丑丒丁与丟 = val_3;
        this.丏专上东丗丗业丈三 = (float)丞丌东丟且丒丐丑丂 / val_11;
        float val_10 = (float)val_7;
        val_10 = val_10 / val_11;
        this.丛丏丑丐东丘丌丈东 = val_10;
        float val_5 = this.currentBar.fillAmount;
        val_5 = val_3 - val_5;
        val_11 = val_5 / this.丁上丒丂三丈专丂世;
        this.丙专万专丟万丂丒丏 = UnityEngine.Mathf.Max(a:  val_9, b:  val_11);
        this.业丑丙三一七下丙丙 = true;
    }
    private void Update()
    {
        UISprite val_6;
        float val_7;
        val_6 = this;
        if(this.业丑丙三一七下丙丙 == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丙专万专丟万丂丒丏 * val_2;
        val_7 = this.currentBar.fillAmount + val_2;
        if(val_7 >= this.与丗七丐丑丒丁与丟)
        {
                this.业丑丙三一七下丙丙 = false;
            this.upBar.fillAmount = this.丏专上东丗丗业丈三;
            this.maxUpBar.fillAmount = this.丛丏丑丐东丘丌丈东;
            this.efficiencyLabel.text = this.与丗七丐丑丒丁与丟.ToString();
            this.efficiencyLabel.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0437"), arg1:  this.东不丁丒丛丙万下丏);
            val_7 = this.与丗七丐丑丒丁与丟;
        }
        
        val_6 = this.currentBar;
        val_6.fillAmount = val_7;
    }
    public EfficiencyBar()
    {
        this.丁上丒丂三丈专丂世 = 1f;
        this.丙专万专丟万丂丒丏 = 1f;
        this.丈丂一一丞丛专下不 = 0.03f;
        this.丁下丘丘丞业丒丕丏 = true;
    }

}
