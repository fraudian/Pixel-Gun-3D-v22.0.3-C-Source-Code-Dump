using UnityEngine;
internal sealed class GoToMainStoreButton : PGBehaviour
{
    // Fields
    private string _storeType;
    private ItemListFromInventoryUI currencyUI;
    
    // Methods
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅(不下丙丘丈下下丏一:  this._storeType);
    }
    internal void 丈且东丑丂且万丒丅(string 不下丙丘丈下下丏一)
    {
        System.Collections.Generic.IReadOnlyList<System.Int32> val_5;
        this._storeType = 不下丙丘丈下下丏一;
        PGCompany.MainStore.业与丝一不丑丕丘与 val_3 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝丈且万丐丟丗七一().丒一丂上丛丕丄丏丐(丌业专专丞专专丆丌:  this._storeType);
        if(this.currencyUI == null)
        {
                return;
        }
        
        if(val_3 != null)
        {
                val_5 = val_3.一丂丗丄丅丏三万一();
        }
        else
        {
                val_5 = 0;
        }
        
        this.currencyUI.丈且东丑丂且万丒丅(丞丂世丌世丅丗丁丂:  val_5);
    }
    public void U_GoToSore()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  "", 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  this._storeType, 与东万丕丆丆且丕丕:  0);
    }
    public GoToMainStoreButton()
    {
        this._storeType = "Default";
    }

}
