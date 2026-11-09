using UnityEngine;
public class ClanItemView : MonoBehaviour
{
    // Fields
    private UIBasicSprite _backgroundTexture;
    private UnityEngine.GameObject _crafted;
    protected ClanItem _item;
    protected UILabel _labelCount;
    protected UILabel _labelName;
    private UIBasicSprite _texture;
    public System.Func<ClanItem, string> CountFormatter;
    public System.Func<ClanItem, string> NameAndCountFormatter;
    public System.Func<ClanItem, string> NameFormatter;
    private System.Action<ClanItemView> 丌不丂丌丁丛丆丟与;
    
    // Properties
    public ClanItem 不下下丞三一丘丗丐 { get; }
    protected UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
    protected UIBasicSprite 丛丞且丗丒七丏丛丙 { get; }
    
    // Methods
    public ClanItem get_Item()
    {
        return (ClanItem)this._item;
    }
    protected UIBasicSprite 丆下世世丟七专丞丒()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
        this._texture = val_1;
        return val_1;
    }
    protected UIBasicSprite 丟丁丞丕七丝丆世丑()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._backgroundTexture);
        this._backgroundTexture = val_1;
        return val_1;
    }
    public void add_OnClicked(System.Action<ClanItemView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921536749979856);
    
    }
    public void remove_OnClicked(System.Action<ClanItemView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921536750116432);
    
    }
    public virtual void Set(ClanItem 下丅丙一丂丗丅丝七)
    {
        this._item = 下丅丙一丂丗丅丝七;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        if(下丅丙一丂丗丅丝七._type == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._crafted, 丏业丟一东丂东丘丛:  this._item.IsCrafted);
    }
    protected virtual void 丟不丏世丝丕与世丘()
    {
        if(this._item == null)
        {
                return;
        }
        
        if(this.丆下世世丟七专丞丒() == 0)
        {
                return;
        }
        
        UnityEngine.Texture val_4 = this._item.Texture;
        if(this.丆下世世丟七专丞丒() == null)
        {
            
        }
    
    }
    protected virtual void 东与丂丏丐丞三丘丁()
    {
        ClanItem val_4;
        var val_5;
        if(this._item == null)
        {
                return;
        }
        
        if(this._labelName == 0)
        {
                return;
        }
        
        if(this.NameAndCountFormatter == null)
        {
            goto label_5;
        }
        
        val_4 = this._item;
        val_5 = 1152921536750530736;
        goto label_6;
        label_5:
        if(this.NameFormatter == null)
        {
            goto label_7;
        }
        
        val_5 = 1152921536750530736;
        val_4 = this._item;
        label_6:
        label_10:
        this._labelName.text = this.NameFormatter.Invoke(arg:  val_4);
        return;
        label_7:
        string val_3 = this._item.LocalizedName;
        goto label_10;
    }
    protected virtual void 丙丕丑丟丛丅业丝丙()
    {
        if(this._item == null)
        {
                return;
        }
        
        if(this._labelCount == 0)
        {
                return;
        }
        
        if(this.CountFormatter != null)
        {
                string val_2 = this.CountFormatter.Invoke(arg:  this._item);
        }
        else
        {
                if(this._item._count < 1)
        {
            goto label_14;
        }
        
            string val_3 = this._item._count.ToString();
        }
        
        label_14:
        this._labelCount.text = val_3;
        this = this._labelCount.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  (val_3 != null) ? 1 : 0);
    }
    protected virtual void 不丆业丌丆丛丑丗丏()
    {
        if(this._item == null)
        {
                return;
        }
        
        if(this.丟丁丞丕七丝丆世丑() == 0)
        {
                return;
        }
        
        UnityEngine.Texture val_4 = this._item.BackgroundTexture;
        if(this.丟丁丞丕七丝丆世丑() == null)
        {
            
        }
    
    }
    public virtual void OnClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丌不丂丌丁丛丆丟与 == null)
        {
                return;
        }
        
        this.丌不丂丌丁丛丆丟与.Invoke(obj:  this);
    }
    public ClanItemView()
    {
    
    }

}
