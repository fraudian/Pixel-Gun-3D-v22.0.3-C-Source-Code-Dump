using UnityEngine;
internal sealed class EggHatchResultView : PGBehaviour
{
    // Fields
    private ItemListUI itemListUI;
    private ScrollViewHelper scrollHelper;
    private PGCompany.上丕一与丕丏丟丂东 业上丗上七丘丂世丝;
    
    // Properties
    public PGCompany.上丕一与丕丏丟丂东 世丄万丑丐一丂上丈 { get; }
    
    // Methods
    public PGCompany.上丕一与丕丏丟丂东 get_ItemEg()
    {
        return (PGCompany.上丕一与丕丏丟丂东)this.业上丗上七丘丂世丝;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.上丕一与丕丏丟丂东 丝丄丞且与丕不上丑)
    {
        if(this.scrollHelper != null)
        {
                this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        }
        
        this.业上丗上七丘丂世丝 = 丝丄丞且与丕不上丑;
        this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  丝丄丞且与丕不上丑.丐丁东丛丙丙丛丑丕());
    }
    public EggHatchResultView()
    {
    
    }

}
