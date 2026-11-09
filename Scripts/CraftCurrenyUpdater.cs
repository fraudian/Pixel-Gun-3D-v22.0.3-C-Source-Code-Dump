using UnityEngine;
public class CraftCurrenyUpdater : MonoBehaviour
{
    // Fields
    private CurrencyUI currencyUI;
    
    // Methods
    private void OnEnable()
    {
        this.丅且业专丆七丑丐丏();
        BankController.丁下丂丒万一下七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CraftCurrenyUpdater::丅且业专丆七丑丐丏()));
    }
    private void OnDisable()
    {
        BankController.与丄丅丘且丟世丗丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CraftCurrenyUpdater::丅且业专丆七丑丐丏()));
    }
    private void 丅且业专丆七丑丐丏()
    {
        this.currencyUI.丈且东丑丂且万丒丅(丒世丘丘上丆丝东丞:  BankController.万丗东七与上丗专丅(), 七丈丟下世三万丙丄:  "CraftCurrency");
    }
    public CraftCurrenyUpdater()
    {
    
    }

}
