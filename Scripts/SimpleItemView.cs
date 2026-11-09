using UnityEngine;
internal sealed class SimpleItemView : ItemViewComponent
{
    // Fields
    private UIBasicSprite _texture;
    private UIBasicSprite _icon;
    private UILabel _nameLabel;
    private UILabel _descriptionLabel;
    private System.Collections.Generic.List<ItemViewComponent> 丞丒丄一丞七丒且丛;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  丈丄不七三万丄丁不 = 丈丄不七三万丄丁不);
        this.丘丁东丟丒丙且丄七();
        List.Enumerator<T> val_1 = this.丞丒丄一丞七丒且丛.GetEnumerator();
        label_4:
        if(((-773140664) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal override void 丝一丅丆三东丂丞七()
    {
        if(true == 0)
        {
                return;
        }
        
        if(true == 0)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  X21);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._icon, 与万丆丛丒万丝丙丑:  X21);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nameLabel, 丕丗丘丑丛与丑业丒:  X21);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._descriptionLabel, 丕丗丘丑丛与丑业丒:  X21);
        List.Enumerator<T> val_1 = this.丞丒丄一丞七丒且丛.GetEnumerator();
        this = 1152921538193425584;
        label_12:
        if(((-772991800) & 1) == 0)
        {
            goto label_10;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丘丁东丟丒丙且丄七()
    {
        if(this.丞丒丄一丞七丒且丛 != null)
        {
                if(this.丞丒丄一丞七丒且丛.Count != 0)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<ItemViewComponent>(source:  this.GetComponentsInChildren<ItemViewComponent>(includeInactive:  true));
        this.丞丒丄一丞七丒且丛 = val_3;
        bool val_4 = val_3.Remove(item:  this);
    }
    public SimpleItemView()
    {
        this.丞丒丄一丞七丒且丛 = new System.Collections.Generic.List<ItemViewComponent>();
    }

}
