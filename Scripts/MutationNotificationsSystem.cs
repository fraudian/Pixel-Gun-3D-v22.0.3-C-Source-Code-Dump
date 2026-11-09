using UnityEngine;
internal sealed class MutationNotificationsSystem : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject redState;
    private UnityEngine.GameObject messageYouAreAMutant;
    private UnityEngine.GameObject messageYouAreASurvival;
    private UnityEngine.GameObject messageNowYouAreAMutant;
    private UnityEngine.GameObject messageNameBecameAMutant;
    private UnityEngine.GameObject messageSoonBecameAMutant;
    private UnityEngine.GameObject messageVictoryOfTheSurvivors;
    private UnityEngine.GameObject greenState;
    private UnityEngine.GameObject messageYouSurvived;
    private UnityEngine.GameObject messageSurvivorsAreDead;
    private UILabel timeToMutationLabel;
    private UILabel[] becameAMutantNickLabels;
    private double 东丐丄丁丞丟东上丂;
    private System.Collections.Generic.List<string> 丑丞丛下丏丅丕丑丙;
    
    // Methods
    public void AddTimeToHideMessage(double 丙丒七丄上与丏丙丙)
    {
        丙丒七丄上与丏丙丙 = this.东丐丄丁丞丟东上丂 + 丙丒七丄上与丏丙丙;
        this.东丐丄丁丞丟东上丂 = 丙丒七丄上与丏丙丙;
    }
    public void LateUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  22)) != false)
        {
                this.ShowMessageYouAreAMutant();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  21)) != false)
        {
                this.ShowMessageSoonBecameAMutant();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  24)) == false)
        {
                return;
        }
        
        this.HideAllMessages();
    }
    public void HideAllMessages()
    {
        this.redState.SetActive(value:  false);
        this.messageYouAreAMutant.SetActive(value:  false);
        this.messageYouAreASurvival.SetActive(value:  false);
        this.messageNowYouAreAMutant.SetActive(value:  false);
        this.messageNameBecameAMutant.SetActive(value:  false);
        this.messageSoonBecameAMutant.SetActive(value:  false);
        this.messageVictoryOfTheSurvivors.SetActive(value:  false);
        this.greenState.SetActive(value:  false);
        this.messageYouSurvived.SetActive(value:  false);
        this.messageSurvivorsAreDead.SetActive(value:  false);
    }
    public void ShowMessageYouAreAMutant()
    {
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        this.messageYouAreAMutant.SetActive(value:  true);
        this.东丐丄丁丞丟东上丂 = -1;
    }
    public void ShowMessageYouAreASurvival()
    {
        var val_2;
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        this.messageYouAreASurvival.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        float val_2 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageNowYouAreAMutant()
    {
        var val_2;
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        this.messageNowYouAreAMutant.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        float val_2 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageNameBecameAMutant(string 丗七专丝一七丏与丏)
    {
        UnityEngine.GameObject val_3;
        var val_4;
        var val_5;
        if((this.东丐丄丁丞丟东上丂 > (double)UnityEngine.Time.time) && (this.东丐丄丁丞丟东上丂 > 0f))
        {
                this.丑丞丛下丏丅丕丑丙.Add(item:  丗七专丝一七丏与丏);
            return;
        }
        
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        val_3 = this.messageNameBecameAMutant;
        val_3.SetActive(value:  true);
        val_4 = 0;
        goto label_6;
        label_11:
        val_3 = this.becameAMutantNickLabels[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_3, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_3, 丕丗丘丑丛与丑业丒:  丗七专丝一七丏与丏);
        val_4 = 1;
        label_6:
        if(val_4 < this.becameAMutantNickLabels.Length)
        {
            goto label_11;
        }
        
        val_5 = null;
        val_5 = null;
        float val_3 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_3 = UnityEngine.Time.time + val_3;
        this.东丐丄丁丞丟东上丂 = (double)val_3;
    }
    public void ShowMessageSoonBecameAMutant()
    {
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        this.messageSoonBecameAMutant.SetActive(value:  true);
        this.东丐丄丁丞丟东上丂 = -1;
    }
    public void HideMessageSoonBecameAMutant()
    {
        this.messageSoonBecameAMutant.SetActive(value:  false);
        if(this.东丐丄丁丞丟东上丂 != (-1))
        {
                return;
        }
        
        this.redState.SetActive(value:  false);
        this.东丐丄丁丞丟东上丂 = 0;
    }
    public void ShowMessageVictoryOfTheSurvivors()
    {
        var val_2;
        this.HideAllMessages();
        this.redState.SetActive(value:  true);
        this.messageVictoryOfTheSurvivors.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        float val_2 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageYouSurvived()
    {
        var val_2;
        this.HideAllMessages();
        this.greenState.SetActive(value:  true);
        this.messageYouSurvived.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        float val_2 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageSurvivorsAreDead()
    {
        var val_2;
        this.HideAllMessages();
        this.greenState.SetActive(value:  true);
        this.messageSurvivorsAreDead.SetActive(value:  true);
        val_2 = null;
        val_2 = null;
        float val_2 = (float)MutationController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    private void Start()
    {
    
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  46)) == false)
        {
                return;
        }
        
        this.ShowMessageNameBecameAMutant(丗七专丝一七丏与丏:  "KEK");
    }
    private void Update()
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = null;
        val_14 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_15 = null;
            val_15 = null;
            if(MutationController.丆丕丝丒不丙且丐丗.mutationStartTimer >= 0f)
        {
                val_16 = null;
            val_16 = null;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timeToMutationLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12406")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12406")) + " " + UnityEngine.Mathf.CeilToInt(f:  MutationController.丆丕丝丒不丙且丐丗.mutationStartTimer).ToString()(UnityEngine.Mathf.CeilToInt(f:  MutationController.丆丕丝丒不丙且丐丗.mutationStartTimer).ToString()));
        }
        
        }
        
        float val_8 = UnityEngine.Time.time;
        if((this.东丐丄丁丞丟东上丂 < 0) && (this.东丐丄丁丞丟东上丂 != (-1)))
        {
                this.HideAllMessages();
            if(this.丑丞丛下丏丅丕丑丙.Count >= 1)
        {
                this.ShowMessageNameBecameAMutant(丗七专丝一七丏与丏:  this.丑丞丛下丏丅丕丑丙.Item[0]);
            this.丑丞丛下丏丅丕丑丙.RemoveAt(index:  0);
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.respawnWindowController == 0)
        {
                return;
        }
        
        if(isShown == false)
        {
                return;
        }
        
        this.HideAllMessages();
    }
    public MutationNotificationsSystem()
    {
        this.丑丞丛下丏丅丕丑丙 = new System.Collections.Generic.List<System.String>();
    }

}
