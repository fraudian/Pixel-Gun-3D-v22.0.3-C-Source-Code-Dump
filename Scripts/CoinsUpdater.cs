using UnityEngine;
internal sealed class CoinsUpdater : MonoBehaviour
{
    // Fields
    internal static readonly string 丗丛丏丛一丏丐专七;
    private UILabel 丂一一业丟丈丄丏七;
    private string 丏丘丗丏丄万丟丝丝;
    private bool 丄上丈丝丒七丂下东;
    
    // Methods
    private void Start()
    {
        this.丂一一业丟丈丄丏七 = this.GetComponent<UILabel>();
        mem[1152921525757701264] = this;
        mem[1152921525757701272] = System.Void CoinsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525757701248] = System.Void CoinsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
        if(this.丂一一业丟丈丄丏七 == 0)
        {
                return;
        }
        
        this.丂一一业丟丈丄丏七.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
    }
    private void OnEnable()
    {
        BankController.丁下丂丒万一下七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CoinsUpdater::专丆丐上丄上丆丑丐()));
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.且丌三不丝丝丏丆丂());
    }
    private void OnDisable()
    {
        BankController.与丄丅丘且丟世丗丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CoinsUpdater::专丆丐上丄上丆丑丐()));
    }
    private void 与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
    {
        var val_3;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == true)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        this.丏丘丗丏丄万丟丝丝 = CoinsUpdater.丗丛丏丛一丏丐专七;
    }
    private System.Collections.IEnumerator 且丌三不丝丝丏丆丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CoinsUpdater.丟七丐专丏丘专世丕();
    }
    private void 专丆丐上丄上丆丑丐()
    {
        UILabel val_9;
        string val_10;
        val_9 = this;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                if(this.丂一一业丟丈丄丏七 == 0)
        {
                return;
        }
        
            val_9 = this.丂一一业丟丈丄丏七;
            val_10 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
        }
        else
        {
                if(this.丂一一业丟丈丄丏七 == 0)
        {
                return;
        }
        
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_10 = "999";
        }
        else
        {
                val_9 = this.丏丘丗丏丄万丟丝丝;
            val_10 = val_9;
        }
        
        }
        
        this.丂一一业丟丈丄丏七.text = val_10;
    }
    public System.Collections.IEnumerator MyWaitForSeconds(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new CoinsUpdater.与东丘丒丟万不丂丌();
    }
    private void OnDestroy()
    {
        mem[1152921525758642016] = this;
        mem[1152921525758642024] = System.Void CoinsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525758642000] = System.Void CoinsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
        this.丄上丈丝丒七丂下东 = true;
    }
    public CoinsUpdater()
    {
        this.丏丘丗丏丄万丟丝丝 = "0";
    }
    private static CoinsUpdater()
    {
        CoinsUpdater.丗丛丏丛一丏丐专七 = "999";
    }

}
