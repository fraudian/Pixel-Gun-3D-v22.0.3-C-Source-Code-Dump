using UnityEngine;
internal sealed class CurrencyListView : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> _currencyIds;
    private ItemListUI itemListUI;
    
    // Methods
    private void OnEnable()
    {
        Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void CurrencyListView::丝丏上丄丅丙丕丕专(string 丏丂不专上丘丂不丅)));
        this.UpdateView();
    }
    private void OnDisable()
    {
        Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void CurrencyListView::丝丏上丄丅丙丕丕专(string 丏丂不专上丘丂不丅)));
    }
    private void 丝丏上丄丅丙丕丕专(string 丏丂不专上丘丂不丅)
    {
        this.UpdateView();
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> 且上丟业与丙丙丄业)
    {
        this._currencyIds = 且上丟业与丙丙丄业;
        this.UpdateView();
    }
    public void UpdateView()
    {
        System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> val_8;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(capacity:  this._currencyIds.Count);
        val_8 = this._currencyIds;
        List.Enumerator<T> val_3 = val_8.GetEnumerator();
        label_6:
        if((272526904 & 1) == 0)
        {
            goto label_3;
        }
        
        int val_4 = 0.丙东专丂世丈丏丁丂();
        val_2.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  val_4, 丂丕丂丏专丂丄丕且:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丞世不丒下上上丝丑:  val_4, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false})));
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_2);
    }
    public CurrencyListView()
    {
        this._currencyIds = new System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈>();
    }

}
