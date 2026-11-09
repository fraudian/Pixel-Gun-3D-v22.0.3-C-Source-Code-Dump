using UnityEngine;
internal sealed class MiniBuffRewardUI : PGBehaviour
{
    // Fields
    internal UIWidget widget;
    private PGCompany.InventoryItemView itemView;
    private UILabel description;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丛丝丏丂东丏专三丁 丒不专世丙丝丑业万)
    {
        var val_10;
        object val_11;
        PGCompany.三东丏不丗世丅丌丄 val_12;
        object val_13;
        val_10 = 丒不专世丙丝丑业万;
        val_11 = "";
        if(val_10 == null)
        {
            goto label_1;
        }
        
        if(val_10.三专丞万丙丈丂丟且() != null)
        {
                if(val_10.三专丞万丙丈丂丟且().下三下东业丘且丟业() != null)
        {
                val_11 = val_10.三专丞万丙丈丂丟且().下三下东业丘且丟业();
        }
        
        }
        
        val_12 = 丒不专世丙丝丑业万.丈业丐丒丒丐丗丅丏;
        val_13 = "";
        if(val_12 == null)
        {
            goto label_10;
        }
        
        this.itemView.Setup(丈丄不七三万丄丁不:  val_12);
        val_12 = 丒不专世丙丝丑业万.丈业丐丒丒丐丗丅丏;
        PGCompany.上丙业丕丟与七专丁 val_6 = null;
        val_10 = val_6;
        val_6 = new PGCompany.上丙业丕丟与七专丁(丈丄不七三万丄丁不:  val_12);
        if(val_10 == null)
        {
            goto label_10;
        }
        
        val_13 = val_6.七业丑不七丐业丟丂();
        goto label_10;
        label_1:
        val_13 = val_11;
        label_10:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.description, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8705"), arg0:  val_11, arg1:  val_13));
    }
    public MiniBuffRewardUI()
    {
    
    }

}
