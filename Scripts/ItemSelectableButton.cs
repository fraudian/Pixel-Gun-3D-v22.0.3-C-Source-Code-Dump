using UnityEngine;
internal sealed class ItemSelectableButton : SelectableButton
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private bool showItemViewer;
    private UnityEngine.Transform itemViewerHolder;
    private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
    
    // Properties
    internal PGCompany.三东丏不丗世丅丌丄 三东丏不丗世丅丌丄 { get; }
    internal PGCompany.InventoryItemView 丆世丐丏丂七丘丄丁 { get; }
    
    // Methods
    internal PGCompany.三东丏不丗世丅丌丄 丝上三丌丙七三七丏()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.丕丟丈丙丟丅丟丑七;
    }
    internal PGCompany.InventoryItemView 业丗丗丒一丆东上东()
    {
        return (PGCompany.InventoryItemView)this.itemView;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.丕丟丈丙丟丅丟丑七 = 丈丄不七三万丄丁不;
        this.itemView.Setup(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
    }
    public override void OnClick()
    {
        PGCompany.三东丏不丗世丅丌丄 val_9;
        if(((this.showItemViewer != false) && (this.showItemViewer != false)) && (this.丕丟丈丙丟丅丟丑七 != null))
        {
                .万丄丅丛下丐丒丞上 = ExperienceController.丞丞丘业东丙丏七丌();
            val_9 = this.丕丟丈丙丟丅丟丑七;
            if(val_9.不业丙丒丂丞下丆丙() == 10)
        {
                val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丈丄不七三万丄丁不:  this.丕丟丈丙丟丅丟丑七);
            .丅万丗上三不丙丆丒 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  val_9);
        }
        
            Rilisoft.ItemViewer val_8 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.itemViewerHolder, 丈丄不七三万丄丁不:  this.丕丟丈丙丟丅丟丑七, 丗丟上上丒丐丗丞丙:  new ItemViewer.丕丈丏丑丌丂且万不(), 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        }
        
        this.OnClick();
    }
    public ItemSelectableButton()
    {
    
    }

}
