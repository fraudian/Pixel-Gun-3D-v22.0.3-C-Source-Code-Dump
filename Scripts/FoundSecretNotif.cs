using UnityEngine;
internal sealed class FoundSecretNotif : PGBehaviour
{
    // Fields
    private string secretFoundLabelKey;
    private UILabel label;
    private float waitTime;
    
    // Methods
    private void OnEnable()
    {
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.secretFoundLabelKey), arg0:  SecretsFreemodeController.丆丕丝丒不丙且丐丗.GetCurrentSecretCount().ToString(), arg1:  SecretsFreemodeController.丆丕丝丒不丙且丐丗.业上一七丘丏丝下丈().ToString()));
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.东七丌丏丅专一东丝(丏丛与丅丛丌万专丌:  this.waitTime));
    }
    private System.Collections.IEnumerator 东七丌丏丅专一东丝(float 丏丛与丅丛丌万专丌)
    {
        FoundSecretNotif.七丄万丒丐七丟且与 val_1 = new FoundSecretNotif.七丄万丒丐七丟且与();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丏丛与丅丛丌万专丌 = 丏丛与丅丛丌万专丌;
        return (System.Collections.IEnumerator)val_1;
    }
    public FoundSecretNotif()
    {
        this.waitTime = 3f;
    }

}
