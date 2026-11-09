using UnityEngine;
internal sealed class ExchangeWindow : MonoBehaviour
{
    // Fields
    private static ExchangeWindow 丙一一丁丆丄上世一;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UILabel _countLabel;
    private System.Action<丐万丆业丄丂世丌且> 丐丂丛丑丗东丝且丄;
    private bool 丕世与丏万丅东丝且;
    private Rilisoft.TextGroup _priceLabel;
    private UnityEngine.AudioClip _soundCloseConfirm;
    private UnityEngine.AudioClip _soundCloseDismiss;
    private UnityEngine.AudioClip _soundOpen;
    
    // Properties
    private static ExchangeWindow 丆丕丝丒不丙且丐丗 { get; }
    internal static bool 丆七且与且且不世丏 { get; }
    
    // Methods
    private static ExchangeWindow 丑七不且上丗丁一世()
    {
        ExchangeWindow val_3 = ExchangeWindow.丙一一丁丆丄上世一;
        if(val_3 != 0)
        {
                return (ExchangeWindow)ExchangeWindow.丙一一丁丆丄上世一;
        }
        
        val_3 = InfoWindowController.丑七不且上丗丁一世();
        ExchangeWindow.丙一一丁丆丄上世一 = val_2.ExchangeWindow;
        return (ExchangeWindow)ExchangeWindow.丙一一丁丆丄上世一;
    }
    internal static bool 与丌上丄丌丐丟丟丈()
    {
        if(ExchangeWindow.丑七不且上丗丁一世() == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_4 = ExchangeWindow.丑七不且上丗丁一世().gameObject;
        if(val_4 != null)
        {
                return val_4.activeInHierarchy;
        }
        
        return val_4.activeInHierarchy;
    }
    internal static void 下与丞三丅丛丄七丕(int 业万七丘丅丙丆与与, int 与丗一世丏丂丘业丛, System.Action<丐万丆业丄丂世丌且> 丌三丞丐丙丒丘三东)
    {
        System.Action<丐万丆业丄丂世丌且> val_19;
        int val_20;
        val_19 = 丌三丞丐丙丒丘三东;
        val_20 = 业万七丘丅丙丆与与;
        if(ExchangeWindow.与丌上丄丌丐丟丟丈() == true)
        {
                return;
        }
        
        ExchangeWindow val_2 = ExchangeWindow.丑七不且上丗丁一世();
        val_2.丕世与丏万丅东丝且 = ShopNGUIController.丛世丛与丌不丈丐丐();
        ExchangeWindow val_5 = ExchangeWindow.丑七不且上丗丁一世();
        val_5._countLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2978"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_20));
        ExchangeWindow val_9 = ExchangeWindow.丑七不且上丗丁一世();
        val_20 = val_9._priceLabel;
        val_20.Text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  与丗一世丏丂丘业丛);
        ExchangeWindow val_11 = ExchangeWindow.丑七不且上丗丁一世();
        val_11.丐丂丛丑丗东丝且丄 = val_19;
        val_19 = ExchangeWindow.丑七不且上丗丁一世().gameObject;
        val_19.SetActive(value:  true);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        ExchangeWindow val_15 = ExchangeWindow.丑七不且上丗丁一世();
        val_19 = val_15._soundOpen;
        if(val_19 == 0)
        {
                return;
        }
        
        ExchangeWindow val_17 = ExchangeWindow.丑七不且上丗丁一世();
        UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_17._soundOpen);
    }
    internal static void 丆世与丑丆丅丐万且()
    {
        if(ExchangeWindow.与丌上丄丌丐丟丟丈() == false)
        {
                return;
        }
        
        ExchangeWindow.丑七不且上丗丁一世().丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  0);
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ExchangeWindow::Dismiss()), 与且专丈不万东一万:  "ExchangeWindow");
    }
    private void Update()
    {
        if(ActivityIndicator.丙专三丙丌丝丏丌丅() != false)
        {
                if(ExchangeWindow.与丌上丄丌丐丟丟丈() != false)
        {
                this.丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  0);
        }
        
        }
        
        if(this.丕世与丏万丅东丝且 == false)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                return;
        }
        
        this.丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  0);
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        this.丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  0);
    }
    private void 丆世与丑丆丅丐万且(丐万丆业丄丂世丌且 东且丁丆丛丁丏丘且)
    {
        var val_7;
        UnityEngine.AudioClip val_8;
        if(this.丐丂丛丑丗东丝且丄 != null)
        {
                this.丐丂丛丑丗东丝且丄.Invoke(obj:  东且丁丆丛丁丏丘且);
            this.丐丂丛丑丗东丝且丄 = 0;
        }
        
        ExchangeWindow.丑七不且上丗丁一世().gameObject.SetActive(value:  false);
        if(东且丁丆丛丁丏丘且 != 1)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this._soundCloseConfirm != 0)
        {
                val_7 = 1152921505093320704;
            val_8 = this._soundCloseConfirm;
        }
        else
        {
                if(this._soundCloseDismiss == 0)
        {
                return;
        }
        
            val_7 = 1152921505093320704;
            val_8 = this._soundCloseDismiss;
        }
        
        UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_8);
    }
    public void Confirm()
    {
        this.丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  1);
    }
    public void Dismiss()
    {
        this.丆世与丑丆丅丐万且(东且丁丆丛丁丏丘且:  0);
    }
    public ExchangeWindow()
    {
    
    }

}
