using UnityEngine;
public class ClanExtendDialogWindowController : DialogWindowController
{
    // Fields
    private 丈丞丕丘丕丗与上一 与一丝丅丁且且世丝;
    private bool 丘不下丛丞不不下丕;
    private UnityEngine.GameObject loadingObject;
    private UnityEngine.GameObject parentWindow;
    private UnityEngine.GameObject priceCoinsSprite;
    private UnityEngine.GameObject priceGemsSprite;
    private UILabel priceLabel;
    
    // Properties
    private bool 业三丛丂业世丁与丏 { get; set; }
    
    // Methods
    private bool 丁丆一丑丗东下业丛()
    {
        return (bool)this.丘不下丛丞不不下丕;
    }
    private void 丑专且不丞丝一丑万(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.丘不下丛丞不不下丕 = val_1;
        this.loadingObject.SetActive(value:  val_1);
        var val_2 = (~丙业与丙丗丝不丈东) & 1;
        var val_3 = (丙业与丙丗丝不丈东 != true) ? 2 : 0;
        if(this == null)
        {
            
        }
    
    }
    private void 丈万丘不丈丙丛丅丏()
    {
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  true);
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.丟专丝一丗丐世丒上(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanExtendDialogWindowController::丟上与丗东三七丐丄(bool 丗万且丌世不丗不专)));
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.世丘丐丄丗下万丏丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanExtendDialogWindowController::丐上与与三丄丆且丁(int 丂七东不不丈一丐不)));
        丞丂丘丒丟丞丑下丄 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        int val_7 = val_6.丄丑丙万丌丂一丄丙 + 5;
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丁丌一丄三业丗东丘().丟丈世与丌丝丒业七(专丐下丙丐七丑丑丂:  0, 下丂丏丘丈不丘丙丞:  0, 丘业丘不丝一丁丄丙:  0, 下丞业丂丂丟且丘丆:  new System.Nullable<丏丆丘丌且丒丏丄丏>() {HasValue = false}, 一丟丛丆丛业丗丘丆:  new System.Nullable<System.Int32>() {HasValue = false}, 丟丟不丌丄丟丈丂丙:  0, 一东丐一东丄一万丙:  0, 万丂不丁丟丄世专下:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    private void 与世丂丕下丟丛且下()
    {
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.三丐万万丂一丁丙业(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanExtendDialogWindowController::丟上与丗东三七丐丄(bool 丗万且丌世不丗不专)));
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.丄一丁丕丌丂丛东七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanExtendDialogWindowController::丐上与与三丄丆且丁(int 丂七东不不丈一丐不)));
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  false);
    }
    private void 丟上与丗东三七丐丄(bool 丗万且丌世不丗不专)
    {
        this.与世丂丕下丟丛且下();
        this.三丂与丟丌与与丌丟();
        this.CloseWindow();
    }
    private void 丐上与与三丄丆且丁(int 丂七东不不丈一丐不)
    {
        this.与世丂丕下丟丛且下();
        UnityEngine.Debug.LogError(message:  "Clan Extend: Can\'t change clan parameter: "("Clan Extend: Can\'t change clan parameter: ") + 丂七东不不丈一丐不);
        InfoWindowController.丟不丗丛丘一丕丄丁(东丏丂丙丑丁丞丞万:  false, 丑丒丁丏丝丞丘丁丟:  false);
    }
    public override void TryShowDialog(string 丄丙下丝丛丒七丂丘)
    {
        var val_11;
        var val_13;
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  false);
        val_11 = null;
        val_11 = null;
        this.与一丝丅丁且且世丝 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  50, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_3.丄丑丙万丌丂一丄丙 == 10)
        {
                丈丞丕丘丕丗与上一 val_4 = BalanceController.东上丏上上丌世下丌();
        }
        else
        {
                丈丞丕丘丕丗与上一 val_5 = BalanceController.丑丏不上一万丂丐丕();
        }
        
        this.与一丝丅丁且且世丝 = val_5;
        val_13 = null;
        val_13 = null;
        string val_11 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        bool val_7 = System.String.op_Equality(a:  val_5.东与三丌丅三丒丏业(), b:  val_11);
        val_11 = val_7;
        this.priceCoinsSprite.SetActive(value:  val_11);
        this.priceGemsSprite.SetActive(value:  (~val_7) & 1);
        this.priceLabel.text = this.与一丝丅丁且且世丝.丟丂丞不专丆万丒世().ToString();
        this.TryShowDialog(丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘);
    }
    protected override void 丌丘业不丘一世不丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.parentWindow, 丒世丘丘上丆丝东丞:  this.与一丝丅丁且且世丝, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void ClanExtendDialogWindowController::丈万丘不丈丙丛丅丏()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  true, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  78);
    }
    protected override void 丐丝丄丅丞丘丄丕丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丘不下丛丞不不下丕 != false)
        {
                return;
        }
        
        this.丐丝丄丅丞丘丄丕丘(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
    }
    protected override void 丌上业丝万与东东七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丘不下丛丞不不下丕 != false)
        {
                return;
        }
        
        this.丌上业丝万与东东七(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
    }
    protected override void 东下丂与丄一丏丅三()
    {
        if(this.丘不下丛丞不不下丕 != false)
        {
                return;
        }
        
        this.东下丂与丄一丏丅三();
    }
    public ClanExtendDialogWindowController()
    {
    
    }

}
