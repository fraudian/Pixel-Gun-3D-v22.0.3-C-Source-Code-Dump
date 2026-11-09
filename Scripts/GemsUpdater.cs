using UnityEngine;
internal sealed class GemsUpdater : MonoBehaviour
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
        CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GemsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
        if(this.丂一一业丟丈丄丏七 == 0)
        {
                return;
        }
        
        this.丂一一业丟丈丄丏七.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
    }
    private void OnEnable()
    {
        BankController.丁下丂丒万一下七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GemsUpdater::专丆丐上丄上丆丑丐()));
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.且丌三不丝丝丏丆丂());
    }
    private void OnDisable()
    {
        BankController.与丄丅丘且丟世丗丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GemsUpdater::专丆丐上丄上丆丑丐()));
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
        this.丏丘丗丏丄万丟丝丝 = GemsUpdater.丗丛丏丛一丏丐专七;
    }
    private System.Collections.IEnumerator 且丌三不丝丝丏丆丂()
    {
        object val_1 = 40681;
        val_1 = new System.Object();
        if(val_1 != 0)
        {
                return (System.Collections.IEnumerator)val_1;
        }
        
        return (System.Collections.IEnumerator)val_1;
    }
    private void 专丆丐上丄上丆丑丐()
    {
        UILabel val_10;
        UILabel val_11;
        string val_12;
        var val_13;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_10 = this.丂一一业丟丈丄丏七;
            if(val_10 == 0)
        {
                return;
        }
        
            val_11 = this.丂一一业丟丈丄丏七;
            val_12 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
        }
        else
        {
                val_10 = 1152921504848912384;
            if(this.丂一一业丟丈丄丏七 == 0)
        {
                return;
        }
        
            val_13 = null;
            val_13 = null;
            if((ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0) && (ShopNGUIController.丛世丛与丌不丈丐丐() != false))
        {
                val_11 = this.丂一一业丟丈丄丏七;
            val_12 = "999";
        }
        else
        {
                val_11 = this.丏丘丗丏丄万丟丝丝;
            val_12 = val_11;
        }
        
        }
        
        this.丂一一业丟丈丄丏七.text = val_12;
    }
    public System.Collections.IEnumerator MyWaitForSeconds(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new GemsUpdater.与东丘丒丟万不丂丌();
    }
    private void OnDestroy()
    {
        CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GemsUpdater::与专丘丛丗丟且丁一(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
        this.丄上丈丝丒七丂下东 = true;
    }
    public GemsUpdater()
    {
        this.丏丘丗丏丄万丟丝丝 = "0";
    }
    private static GemsUpdater()
    {
        GemsUpdater.丗丛丏丛一丏丐专七 = "999";
    }

}
