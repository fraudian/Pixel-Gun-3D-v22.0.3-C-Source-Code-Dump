using UnityEngine;
public class LoopedScrollItemView : SelectableButton
{
    // Fields
    private ScrollViewHelper scrollHelper;
    private bool scrollOnSelect;
    private PGCompany.InventoryItemView 丂丟七一丘七丞丅一;
    
    // Properties
    internal PGCompany.InventoryItemView 与专上丒东丕丞丅世 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 三东丏不丗世丅丌丄 { get; }
    
    // Methods
    internal PGCompany.InventoryItemView 一一业与丏丛丁专丘()
    {
        PGCompany.InventoryItemView val_3;
        if(this.丂丟七一丘七丞丅一 == 0)
        {
                this.丂丟七一丘七丞丅一 = this.GetComponent<PGCompany.InventoryItemView>();
            return val_3;
        }
        
        val_3 = this.丂丟七一丘七丞丅一;
        return val_3;
    }
    internal PGCompany.三东丏不丗世丅丌丄 丝上三丌丙七三七丏()
    {
        if(this.一一业与丏丛丁专丘() == 0)
        {
                return 0;
        }
        
        PGCompany.InventoryItemView val_3 = this.一一业与丏丛丁专丘();
        if(val_3 != null)
        {
                return val_3.ItemParams;
        }
        
        return val_3.ItemParams;
    }
    public override void OnClick()
    {
        if(this.scrollOnSelect != false)
        {
                UnityEngine.Vector3 val_2 = this.scrollHelper.transform.localPosition;
            UnityEngine.Vector3 val_4 = this.transform.localPosition;
            UnityEngine.Vector3 val_6 = this.transform.localPosition;
            this.scrollHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  true);
        }
        
        this.OnClick();
    }
    public LoopedScrollItemView()
    {
    
    }

}
