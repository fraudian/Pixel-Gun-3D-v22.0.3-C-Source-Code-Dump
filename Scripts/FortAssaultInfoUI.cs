using UnityEngine;
public class FortAssaultInfoUI : PGBehaviour
{
    // Fields
    private UILabel timerLabel;
    private UnityEngine.Coroutine 丕丆上下丕与东丈业;
    
    // Methods
    public void Setup()
    {
        this.且丒不丙丌丅丑丂丄();
    }
    private void 且丒不丙丌丅丑丂丄()
    {
        if(this.丕丆上下丕与东丈业 != null)
        {
                this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
            this.丕丆上下丕与东丈业 = 0;
        }
        
        this.丕丆上下丕与东丈业 = this.StartCoroutine(routine:  this.与东丆丟丞丈一丕上());
    }
    private void 一丛丄七一且东三七()
    {
        if(this.丕丆上下丕与东丈业 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
        this.丕丆上下丕与东丈业 = 0;
    }
    private System.Collections.IEnumerator 与东丆丟丞丈一丕上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortAssaultInfoUI.丗丁与丛世丅下丈丌();
    }
    private void 丝丂丕东专世丅丝丁()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timerLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  2), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    public FortAssaultInfoUI()
    {
    
    }

}
