using UnityEngine;
internal sealed class InventoryItemView_Info : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView _parentInventoryItemView;
    private PGCompany.InventoryItemView _inventoryItemView;
    
    // Properties
    internal PGCompany.InventoryItemView 丄丕不东丟丌丈万与 { get; set; }
    
    // Methods
    internal PGCompany.InventoryItemView 上七丏不东东丟丟丕()
    {
        PGCompany.InventoryItemView val_3;
        if(this._parentInventoryItemView == 0)
        {
                this._parentInventoryItemView = this.GetComponentInParent<PGCompany.InventoryItemView>();
            return val_3;
        }
        
        val_3 = this._parentInventoryItemView;
        return val_3;
    }
    internal void 业业丟丑万下与丟丛(PGCompany.InventoryItemView 丙业与丙丗丝不丈东)
    {
        this._parentInventoryItemView = 丙业与丙丗丝不丈东;
    }
    public void Show()
    {
        if(this.上七丏不东东丟丟丕() == 0)
        {
                return;
        }
        
        if(this._inventoryItemView == 0)
        {
                return;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_5 = this.上七丏不东东丟丟丕().ItemParams;
        PGCompany.InventoryItemView val_6 = this.上七丏不东东丟丟丕();
        if(val_6 == null)
        {
            goto label_8;
        }
        
        if(val_5 == null)
        {
            goto label_9;
        }
        
        label_11:
        PGCompany.三东丏不丗世丅丌丄 val_7 = val_6.ItemParams;
        goto label_10;
        label_8:
        if(val_5 != null)
        {
            goto label_11;
        }
        
        label_9:
        if(val_6.Context == null)
        {
            goto label_14;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_10 = this.上七丏不东东丟丟丕().Context;
        label_10:
        if(val_10 != null)
        {
                this._inventoryItemView.Setup(与且专丈不万东一万:  val_10);
            this.gameObject.SetActive(value:  true);
            return;
        }
        
        label_14:
        this.Hide();
    }
    public void Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnDisable()
    {
        this.Hide();
    }
    public InventoryItemView_Info()
    {
    
    }

}
