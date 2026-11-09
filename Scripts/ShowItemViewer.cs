using UnityEngine;
public class ShowItemViewer : PGBehaviour
{
    // Fields
    private UnityEngine.Transform holder;
    private PGCompany.InventoryItemView _itemView;
    
    // Methods
    public void Show()
    {
        UnityEngine.Transform val_16;
        PGCompany.三东丏不丗世丅丌丄 val_17;
        ItemRarity val_18;
        var val_19;
        val_16 = this;
        val_17 = 1152921504848912384;
        if(this.holder == 0)
        {
                return;
        }
        
        if(this._itemView == 0)
        {
                return;
        }
        
        if(this._itemView.ItemParams == null)
        {
                return;
        }
        
        .万丄丅丛下丐丒丞上 = ExperienceController.丞丞丘业东丙丏七丌();
        val_18 = this._itemView.ItemParams;
        if(val_18.不业丙丒丂丞下丆丙() != 10)
        {
            goto label_14;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_10 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this._itemView.ItemParams);
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        label_20:
        if(null != null)
        {
            goto label_25;
        }
        
        val_18 = val_10;
        .丅万丗上三不丙丆丒 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  val_18);
        label_14:
        val_16 = this.holder;
        val_17 = this._itemView.ItemParams;
        Rilisoft.ItemViewer val_15 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_16, 丈丄不七三万丄丁不:  val_17, 丗丟上上丒丐丗丞丙:  new ItemViewer.丕丈丏丑丌丂且万不(), 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        return;
        label_25:
        val_19 = X0;
    }
    public ShowItemViewer()
    {
    
    }

}
