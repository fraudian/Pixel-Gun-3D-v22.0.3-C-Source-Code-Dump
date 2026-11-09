using UnityEngine;
internal sealed class ItemView : PGBehaviour
{
    // Fields
    public UIWidget Widget;
    private UIBasicSprite _itemTexture;
    private UILabel _itemNameLabel;
    private UILabel _itemCountLabel;
    private UISprite _gearSprite;
    
    // Methods
    private void Awake()
    {
        if(this.Widget != 0)
        {
                return;
        }
        
        this.Widget = this.GetComponent<UIWidget>();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._itemTexture, 与万丆丛丒万丝丙丑:  下丅丙一丂丗丅丝七);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemNameLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCountLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gearSprite, 丏业丟一东丂东丘丛:  false);
        Rilisoft.OfferItemType val_1 = 下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙();
        if(val_1 <= 1150)
        {
            goto label_4;
        }
        
        if(val_1 <= 1200)
        {
            goto label_5;
        }
        
        if((val_1 == 1240) || (val_1 == 1250))
        {
            goto label_7;
        }
        
        if(val_1 != 1300)
        {
                return;
        }
        
        goto label_12;
        label_4:
        if(val_1 <= 1000)
        {
            goto label_10;
        }
        
        if(val_1 == 1010)
        {
            goto label_16;
        }
        
        if(val_1 == 1070)
        {
            goto label_12;
        }
        
        if(val_1 != 1150)
        {
                return;
        }
        
        goto label_15;
        label_5:
        if(val_1 == 1155)
        {
            goto label_15;
        }
        
        if(val_1 == 1200)
        {
            goto label_16;
        }
        
        return;
        label_10:
        if(val_1 == 10)
        {
            goto label_17;
        }
        
        if(val_1 != 1000)
        {
                return;
        }
        
        label_16:
        this.丙丝丐丏丒专下业丛(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        return;
        label_15:
        this.专丈与丄三丞丌丂丅(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        return;
        label_7:
        this.丒丄丏丏下且万与丟(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        return;
        label_12:
        this.丆丐上丐丛七丘丄丙(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        return;
        label_17:
        this.丞丆不丆丕万丁丙丈(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
    }
    internal void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._itemTexture, 与万丆丛丒万丝丙丑:  0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemNameLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._gearSprite, 与万丆丛丒万丝丙丑:  0);
    }
    private void 丙丝丐丏丒专下业丛(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCountLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七);
    }
    private void 专丈与丄三丞丌丂丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCountLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七);
    }
    private void 丞丆不丆丕万丁丙丈(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemNameLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemNameLabel, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七);
    }
    private void 丆丐上丐丛七丘丄丙(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gearSprite, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCountLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七);
    }
    private void 丒丄丏丏下且万与丟(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gearSprite, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCountLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七);
    }
    public ItemView()
    {
    
    }

}
