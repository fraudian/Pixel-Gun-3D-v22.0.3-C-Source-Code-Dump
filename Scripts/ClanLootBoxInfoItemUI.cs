using UnityEngine;
internal sealed class ClanLootBoxInfoItemUI : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private UITexture bg;
    private UILabel fortLabel;
    private UILabel tankLabel;
    private UILabel moduleLabel;
    private UILabel _categoryLabel;
    private UISprite divisionSprite;
    private Rilisoft.ItemViewer 丅专丗丒与丏丘东丐;
    internal UnityEngine.Transform 丅丞丆东下丌丘丙丈;
    
    // Properties
    internal PGCompany.InventoryItemView 丆世丐丏丂七丘丄丁 { get; }
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        string val_37;
        var val_38;
        string val_39;
        var val_40;
        string val_41;
        var val_42;
        CategoryNames val_43;
        var val_44;
        if(this.fortLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fortLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.tankLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tankLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.moduleLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this._categoryLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1250)
        {
            goto label_37;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_9 = this.itemView.Context;
        if(val_9 != null)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        val_37 = 0;
        goto label_21;
        label_20:
        PlaceableItemSettings val_10 = val_9.丈丏专三世七丒丘丑();
        val_37 = val_10.supercategory;
        label_21:
        val_38 = null;
        val_38 = null;
        if(((System.String.op_Equality(a:  val_37, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false) && (this.fortLabel != null))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fortLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_13 = this.itemView.Context;
        if(val_13 != null)
        {
                if(null == null)
        {
            goto label_31;
        }
        
        }
        
        val_39 = 0;
        goto label_32;
        label_31:
        PlaceableItemSettings val_14 = val_13.丈丏专三世七丒丘丑();
        val_39 = val_14.supercategory;
        label_32:
        val_40 = null;
        val_40 = null;
        if(((System.String.op_Equality(a:  val_39, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) != false) && (this.tankLabel != null))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tankLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        label_37:
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1155)
        {
            goto label_49;
        }
        
        PGCompany.InventoryItemView val_37 = this.itemView;
        PGCompany.丗丟丄丈东丝丕丄世 val_19 = val_37.Context;
        if(val_19 != null)
        {
                if(null == null)
        {
            goto label_45;
        }
        
        }
        
        label_94:
        val_41 = 0;
        label_95:
        if(this.moduleLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this.moduleLabel != null)
        {
                if(val_41 != 0)
        {
                val_41 = val_41.世世上丕不丑丅七丆();
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.moduleLabel, 丕丗丘丑丛与丑业丒:  val_41);
        }
        
        }
        
        label_49:
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 10)
        {
            goto label_55;
        }
        
        val_42 = 0;
        val_43 = this.itemView.Context;
        if(val_43 == null)
        {
            goto label_57;
        }
        
        val_42 = null;
        if(null == val_42)
        {
            goto label_60;
        }
        
        val_42 = 0;
        val_43 = 0;
        goto label_60;
        label_57:
        label_60:
        if(this._categoryLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._categoryLabel != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._categoryLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.与丅丙专且世丂丝丈(七丆丒与丗丌丄且丂:  val_43)));
        }
        
        }
        
        this.丑丆丞丂丏丕三丏下();
        label_55:
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() == 1070)
        {
                this.丑丆丞丂丏丕三丏下();
        }
        
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 70)
        {
            goto label_76;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_33 = this.itemView.Context;
        if(val_33 != null)
        {
                if(null == null)
        {
            goto label_79;
        }
        
        }
        
        label_79:
        if(null != null)
        {
            goto label_96;
        }
        
        if(this._categoryLabel != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._categoryLabel, 丏业丟一东丂东丘丛:  true);
            if(this._categoryLabel != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._categoryLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.一丝丆七丁三三上丒(七丆丒与丗丌丄且丂:  val_33));
        }
        
        }
        
        this.丑丆丞丂丏丕三丏下();
        label_76:
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() == 1300)
        {
                this.丑丆丞丂丏丕三丏下();
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.bg, 与万丆丛丒万丝丙丑:  PGCompany.InventoryItemView.丏丘丑丗专丒丝丘丆(东东世丝业丝一丂丄:  this.itemView.Context));
        return;
        label_45:
        if(val_19 == null)
        {
            goto label_94;
        }
        
        val_37 = (null == null) ? (val_19) : 0;
        goto label_95;
        label_96:
        val_44 = X0;
    }
    internal PGCompany.InventoryItemView 业丗丗丒一丆东上东()
    {
        return (PGCompany.InventoryItemView)this.itemView;
    }
    private void 丑丆丞丂丏丕三丏下()
    {
        UISprite val_24;
        int val_25;
        var val_26;
        var val_27;
        var val_28;
        val_24 = this;
        PGCompany.丟丁且丝丁三丏丙且 val_16 = 0;
        val_25 = this.itemView.Context.业东丅东丌上丗丑不();
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1070)
        {
            goto label_5;
        }
        
        val_26 = this.itemView.Context;
        if(val_26 == null)
        {
            goto label_7;
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        val_26 = 0;
        goto label_10;
        label_7:
        label_10:
        val_25 = val_26.不一丆丑业且丆丙三().业东丅东丌上丗丑不();
        label_5:
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1300)
        {
            goto label_14;
        }
        
        val_27 = this.itemView.Context;
        if(val_27 == null)
        {
            goto label_16;
        }
        
        if(null == null)
        {
            goto label_19;
        }
        
        val_27 = 0;
        goto label_19;
        label_16:
        label_19:
        val_25 = val_27.不一丆丑业且丆丙三().业东丅东丌上丗丑不();
        label_14:
        val_28 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆();
        bool val_17 = val_28.TryGetValue(下上丐丆丝丟丝丒不:  val_25, 丙业与丙丗丝不丈东: out  val_16);
        if(val_16 == 0)
        {
                return;
        }
        
        val_28 = val_16.世丝丌一且丝专丑丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.divisionSprite, 丏业丟一东丂东丘丛:  true);
        val_24 = this.divisionSprite;
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_24, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  (this.itemView.丘七丕丁丗与丙东丅() != true) ? "cup{0}_mini_thin" : "cup{0}_small", arg0:  val_28 + 1.ToString()));
    }
    public void U_ClickOnInfo()
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_8;
        PGCompany.丗丟丄丈东丝丕丄世 val_9;
        if(this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1250)
        {
            goto label_4;
        }
        
        if((this.itemView.Context == null) || (null != null))
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        val_9 = this.itemView.Context;
        if((this.itemView.ItemParams.不业丙丒丂丞下丆丙() != 1155) || (val_9 == null))
        {
            goto label_13;
        }
        
        if(null == null)
        {
            goto label_12;
        }
        
        label_6:
        val_9 = 0;
        goto label_13;
        label_12:
        val_8 = val_9;
        label_7:
        val_9 = val_8;
        label_13:
        this.丅专丗丒与丏丘东丐 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.丅丞丆东下丌丘丙丈, 下丅丙一丂丗丅丝七:  val_9, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 丒不业且丄丅世世下:  false);
    }
    public ClanLootBoxInfoItemUI()
    {
    
    }

}
