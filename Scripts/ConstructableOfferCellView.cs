using UnityEngine;
internal sealed class ConstructableOfferCellView : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private UnityEngine.GameObject itemSelected;
    private UnityEngine.GameObject itemNotSelected;
    private UnityEngine.GameObject cantSeletItem;
    private ConstructableOfferView 丗丗专与业万上丛丆;
    private PGCompany.丕丘一丐丕上不万丁 丐丌丞东上万万丈丂;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(ConstructableOfferView 业东丞丏丛丄丅丅七, PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘)
    {
        this.丗丗专与业万上丛丆 = 业东丞丏丛丄丅丅七;
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        if(this.丐丌丞东上万万丈丂 == null)
        {
                return;
        }
        
        this.itemView.Setup(丈丄不七三万丄丁不:  this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemSelected, 丏业丟一东丂东丘丛:  (this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐() != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemNotSelected, 丏业丟一东丂东丘丛:  (this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐() == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cantSeletItem, 丏业丟一东丂东丘丛:  (~this.丐丌丞东上万万丈丂) & 1);
    }
    public void U_GoToSelection()
    {
        if((this.丐丌丞东上万万丈丂 & 1) == 0)
        {
                return;
        }
        
        this.丗丗专与业万上丛丆.丁丆专丕万丈丐丛上(丌丝万上丅丒一丈丘:  this.丐丌丞东上万万丈丂);
    }
    public ConstructableOfferCellView()
    {
    
    }

}
