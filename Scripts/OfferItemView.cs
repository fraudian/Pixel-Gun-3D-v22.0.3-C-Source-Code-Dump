using UnityEngine;
internal class OfferItemView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.OfferItem>
{
    // Fields
    private static System.Action<OfferItemView> 丌不丂丌丁丛丆丟与;
    private UILabel _nameLabel;
    private UIBasicSprite _itemTexture;
    private UILabel _countLabel;
    private bool _showInfoByClick;
    private bool middleTexture;
    private bool simpeTexture;
    private UnityEngine.GameObject _partsIconGo;
    private UILabel _partsCountLabel;
    private UIWidget _widget;
    private Rilisoft.OfferItem <丅丝丌丝丁丏丙东丞>k__BackingField;
    
    // Properties
    internal UIWidget 丕丟丟丝丝丞七且下 { get; }
    public Rilisoft.OfferItem 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    internal static void 万万且丞与万业丈丌(System.Action<OfferItemView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  OfferItemView.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丂东东丌世与与上丛(System.Action<OfferItemView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  OfferItemView.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal UIWidget 丁丏世七三丗与丏与()
    {
        return (UIWidget)this._widget;
    }
    public Rilisoft.OfferItem get_Context()
    {
        return (Rilisoft.OfferItem)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        if(this._widget != 0)
        {
                return;
        }
        
        this._widget = this.GetComponent<UIWidget>();
    }
    public void Setup(Rilisoft.OfferItem 与且专丈不万东一万)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        UIBasicSprite val_18;
        string val_20;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        if(this._itemTexture == 0)
        {
            goto label_4;
        }
        
        if(this.middleTexture == false)
        {
            goto label_5;
        }
        
        val_18 = this._itemTexture;
        UnityEngine.Texture val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.MiddleTexture;
        goto label_10;
        label_5:
        val_18 = this._itemTexture;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
            goto label_8;
        }
        
        if(this.simpeTexture == false)
        {
            goto label_9;
        }
        
        label_11:
        UnityEngine.Texture val_3 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.SimpleTexture;
        goto label_10;
        label_8:
        if(this.simpeTexture == true)
        {
            goto label_11;
        }
        
        label_9:
        label_10:
        val_20 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Texture;
        label_4:
        if(this._nameLabel != 0)
        {
                val_20 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Name;
            this._nameLabel.text = val_20;
        }
        
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Type) != 1070)
        {
            goto label_19;
        }
        
        if(this._countLabel != 0)
        {
                this._countLabel.gameObject.SetActive(value:  false);
        }
        
        if(this._partsIconGo != 0)
        {
                this._partsIconGo.SetActive(value:  true);
        }
        
        if(this._partsCountLabel == 0)
        {
                return;
        }
        
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
        {
            goto label_48;
        }
        
        label_49:
        label_48:
        this._partsCountLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count);
        return;
        label_19:
        if(this._partsIconGo != 0)
        {
                this._partsIconGo.SetActive(value:  false);
        }
        
        if(this._partsCountLabel != 0)
        {
                this._partsCountLabel.gameObject.SetActive(value:  false);
        }
        
        if(this._countLabel == 0)
        {
                return;
        }
        
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
        {
            goto label_48;
        }
        
        goto label_49;
    }
    private void OnClick()
    {
        if(OfferItemView.丌不丂丌丁丛丆丟与 == null)
        {
                return;
        }
        
        OfferItemView.丌不丂丌丁丛丆丟与.Invoke(obj:  this);
    }
    public OfferItemView()
    {
        this._showInfoByClick = true;
    }

}
