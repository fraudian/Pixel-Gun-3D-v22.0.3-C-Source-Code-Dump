using UnityEngine;
internal class ExchangeEventBankViewItem : ExchangeBankViewItem
{
    // Fields
    private UISprite _currencyIcon;
    
    // Methods
    protected override void 丞业与下丛万丁下丙()
    {
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 != null)
        {
                UnityEngine.Texture val_6 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_2.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  this.ExchangeInfo.丒不丟丒丁丗丒丕丑()));
            this._currencyIcon.spriteName = val_2.专且丝与上下万与丅();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "set ExchangeEventBankViewItem icon fail: nullable active event");
    }
    public ExchangeEventBankViewItem()
    {
    
    }

}
