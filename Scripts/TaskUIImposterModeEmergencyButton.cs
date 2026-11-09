using UnityEngine;
internal sealed class TaskUIImposterModeEmergencyButton : TaskUIImposterModeAbstract
{
    // Fields
    private UILabel statusLabel;
    private UnityEngine.GameObject canBePressed;
    private UnityEngine.GameObject cannotBePressed;
    private const string 业七丘专世专丄丛东 = "Key_10190";
    private const string 丙丆下七丈丗丘一丝 = "Key_10191";
    private const string 丙丂专丙丝丏丁丏业 = "Key_10192";
    private UnityEngine.Coroutine 丁业丗丒丛丌东丘丅;
    
    // Methods
    protected override void OnEnable()
    {
        var val_4;
        this.OnEnable();
        val_4 = null;
        val_4 = null;
        if(PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丂专丁丝丂丒东七上 > 0)
        {
                if(this.丁业丗丒丛丌东丘丅 != null)
        {
                this.StopCoroutine(routine:  this.丁业丗丒丛丌东丘丅);
        }
        
            this.丁业丗丒丛丌东丘丅 = this.StartCoroutine(routine:  this.丌丕且丛七专丐丈丄());
            return;
        }
        
        this.statusLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10191");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.canBePressed, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cannotBePressed, 丏业丟一东丂东丘丛:  true);
    }
    protected override void OnDisable()
    {
        if(this.丁业丗丒丛丌东丘丅 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丁业丗丒丛丌东丘丅);
    }
    public void StartVoting()
    {
        var val_2;
        PlayerTaskImposterModeController val_3;
        int val_4;
        var val_5;
        var val_6;
        var val_7;
        val_2 = null;
        val_2 = null;
        val_3 = PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗;
        if(val_3 != null)
        {
                val_4 = mem[PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗 + 148];
            val_4 = PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丂专丁丝丂丒东七上;
        }
        else
        {
                val_3 = 148;
            val_4 = 0;
        }
        
        mem[148] = -1;
        val_5 = null;
        val_5 = null;
        if(GameController.onlineMode == null)
        {
            goto label_7;
        }
        
        val_6 = null;
        if(null == val_6)
        {
            goto label_8;
        }
        
        label_7:
        val_7 = null;
        goto label_9;
        label_8:
        val_7 = val_6;
        label_9:
        var val_1 = (val_6 == val_7) ? GameController.onlineMode : 0;
        val_6 == val_7 ? GameController.onlineMode : 0 + 536.不丄丅专一丘丏专丟(丄丐丆丞与丟上上下:  false, 与丟丅七丞且且丛丕:  System.String.alignConst);
    }
    public void U_PressStartVoting()
    {
        this.StartVoting();
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
    
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
    
    }
    private System.Collections.IEnumerator 丌丕且丛七专丐丈丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TaskUIImposterModeEmergencyButton.丆丗且下丈七丛丌丗();
    }
    public TaskUIImposterModeEmergencyButton()
    {
        val_1 = new PGBehaviour();
    }

}
