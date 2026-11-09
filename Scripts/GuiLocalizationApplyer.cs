using UnityEngine;
public class GuiLocalizationApplyer : GuiApplyer
{
    // Fields
    private UILabel ressiver;
    public string lockKey;
    private string 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    private string 三丌丞丆业三万专丄;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        mem[1152921537857096576] = 专与万丐七丌丐丁丂;
        if(this.ressiver != 0)
        {
                return;
        }
        
        this.ressiver = this.GetComponent<UILabel>();
    }
    internal override bool 三业丒丑丂三丕上丛()
    {
        string val_3;
        var val_4;
        val_3 = this;
        if(this.七丆业丗不业丙丏三() != false)
        {
                this.lockKey = 137121792;
            if(this.ressiver != null)
        {
                val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  137121792);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.ressiver, 丕丗丘丑丛与丑业丒:  val_3);
        }
        
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal string 专丄下丆丛丂丅七丗()
    {
        return (string)((System.String.IsNullOrEmpty(value:  this.lockKey)) != true) ? "" : (this.lockKey);
    }
    internal void 丆东七丂专业下与三(string 与专丒七不丈上丐上)
    {
        this.lockKey = 与专丒七不丈上丐上;
        if(this.ressiver != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.ressiver, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  与专丒七不丈上丐上));
        }
        
        this.三丌丞丆业三万专丄 = 与专丒七不丈上丐上;
    }
    protected override void 不丏丌丟丑丄丟上丝()
    {
        if(137121792 == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.lockKey)) == true)
        {
                return;
        }
        
        bool val_3 = System.String.op_Inequality(a:  this.三丌丞丆业三万专丄, b:  this.lockKey);
        this.三丌丞丆业三万专丄 = this.lockKey;
    }
    public GuiLocalizationApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
