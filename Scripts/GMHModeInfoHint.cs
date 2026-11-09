using UnityEngine;
internal sealed class GMHModeInfoHint : MonoBehaviour
{
    // Fields
    private HintPopup 丙不丈东丒下三丛丁;
    private System.Action<string, UnityEngine.MonoBehaviour> 丟不丒万丝与丂上丘;
    private string 丛丄业丕且丗下一万;
    
    // Properties
    private HintPopup 不丛丝下丝与丒丝丄 { get; }
    
    // Methods
    private HintPopup 万世丏世丅下丕丕不()
    {
        if(this.丙不丈东丒下三丛丁 != 0)
        {
                return (HintPopup)this.丙不丈东丒下三丛丁;
        }
        
        HintPopup val_2 = this.GetComponentInChildren<HintPopup>(includeInactive:  true);
        this.丙不丈东丒下三丛丁 = val_2;
        if(val_2 == 0)
        {
                return (HintPopup)this.丙不丈东丒下三丛丁;
        }
        
        this.丙不丈东丒下三丛丁.丘丌世专丌专丕丂丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GMHModeInfoHint::丌世与且丞丟丙业东()));
        return (HintPopup)this.丙不丈东丒下三丛丁;
    }
    private void OnEnable()
    {
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        this.万世丏世丅下丕丕不().gameObject.SetActive(value:  true);
    }
    private void 丌世与且丞丟丙业东()
    {
        if(this.丟不丒万丝与丂上丘 == null)
        {
                return;
        }
        
        this.丟不丒万丝与丂上丘.Invoke(arg1:  this.丛丄业丕且丗下一万, arg2:  this);
    }
    internal void 丅专不丛下丒丟东丐(System.Action<string, UnityEngine.MonoBehaviour> 丟不丒万丝与丂上丘, string 丛丄业丕且丗下一万)
    {
        this.丟不丒万丝与丂上丘 = 丟不丒万丝与丂上丘;
        this.丛丄业丕且丗下一万 = 丛丄业丕且丗下一万;
    }
    internal void 丘上丄专丈丂丆丝丁(PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
    {
        var val_6;
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        if(this.万世丏世丅下丕丕不() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_6 = this.万世丏世丅下丕丕不();
        if(val_6 == null)
        {
            goto label_6;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        val_6 = 0;
        goto label_9;
        label_6:
        label_9:
        val_6.丂丄业东丛不七世世(丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
    }
    internal void 丑丒万丝一丙丘业丆(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂)
    {
        var val_6;
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        if(this.万世丏世丅下丕丕不() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_6 = this.万世丏世丅下丕丕不();
        if(val_6 == null)
        {
            goto label_6;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        val_6 = 0;
        goto label_9;
        label_6:
        label_9:
        val_6.丝丐七世三丏丛丒丞(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 万丏丅万丅下丟丘丘:  false);
    }
    internal void 丅丐丂丝丌丅世万丐(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂)
    {
        var val_6;
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        if(this.万世丏世丅下丕丕不() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_6 = this.万世丏世丅下丕丕不();
        if(val_6 == null)
        {
            goto label_6;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        val_6 = 0;
        goto label_9;
        label_6:
        label_9:
        val_6.丝丐七世三丏丛丒丞(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 万丏丅万丅下丟丘丘:  true);
    }
    internal void 七东丘东专丗世且三(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_5;
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        if(this.万世丏世丅下丕丕不() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_5 = this.万世丏世丅下丕丕不();
        if(val_5 != null)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        0.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  丂丛丑东不丅丈一东);
        0.七东丘东专丗世且三();
        val_5 = 0;
        goto label_8;
        label_7:
        val_5.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  丂丛丑东不丅丈一东);
        val_5.七东丘东专丗世且三();
        label_8:
        val_5.丞七世丈丐丆丑丒丐();
    }
    internal void 丈万丆且丏丒丁丆丙(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_5;
        if(this.万世丏世丅下丕丕不() == 0)
        {
                return;
        }
        
        if(this.万世丏世丅下丕丕不() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_5 = this.万世丏世丅下丕丕不();
        if(val_5 != null)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        0.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  丂丛丑东不丅丈一东);
        0.丘专七专丂丅上丙与();
        val_5 = 0;
        goto label_8;
        label_7:
        val_5.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  丂丛丑东不丅丈一东);
        val_5.丘专七专丂丅上丙与();
        label_8:
        val_5.丞七世丈丐丆丑丒丐();
    }
    public GMHModeInfoHint()
    {
    
    }

}
