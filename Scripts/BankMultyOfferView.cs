using UnityEngine;
internal class BankMultyOfferView : MonoBehaviour, 世丙丘下丝丗上下丏<System.Collections.Generic.ICollection<Rilisoft.OfferItem>>, 丄世专丆丛世下丟东
{
    // Fields
    private UIBasicSprite _mainTexture;
    private OfferItemView _leftView;
    private OfferItemView _rightView;
    private UnityEngine.GameObject _plusObject;
    private UITable _table;
    private System.Collections.Generic.ICollection<Rilisoft.OfferItem> <丅丝丌丝丁丏丙东丞>k__BackingField;
    private System.Action<Rilisoft.且丏上上丛丟七丁下> 上与丁丟与专丞丐丐;
    
    // Properties
    public System.Collections.Generic.ICollection<Rilisoft.OfferItem> 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public System.Collections.Generic.ICollection<Rilisoft.OfferItem> get_Context()
    {
        return (System.Collections.Generic.ICollection<Rilisoft.OfferItem>)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(System.Collections.Generic.ICollection<Rilisoft.OfferItem> 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void add_OnVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上与丁丟与专丞丐丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上与丁丟与专丞丐丐 != 1152921537958215640);
    
    }
    public void remove_OnVisibilityChanged(System.Action<Rilisoft.且丏上上丛丟七丁下> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上与丁丟与专丞丐丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上与丁丟与专丞丐丐 != 1152921537958352216);
    
    }
    public void Setup(System.Collections.Generic.ICollection<Rilisoft.OfferItem> 与且专丈不万东一万)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        OfferItemView val_7;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)) == false)
        {
                return;
        }
        
        val_7 = 1152921504690978816;
        var val_9 = 0;
        val_9 = val_9 + 1;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) >= 2)
        {
            goto label_8;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_13;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._leftView, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rightView, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._plusObject, 丏业丟一东丂东丘丛:  true);
        this._leftView.Setup(与且专丈不万东一万:  System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField));
        val_7 = this._rightView;
        if(val_7 != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        val_7.Setup(与且专丈不万东一万:  System.Linq.Enumerable.Last<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField));
        goto label_19;
        label_13:
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) != 1)
        {
            goto label_19;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._leftView, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rightView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._plusObject, 丏业丟一东丂东丘丛:  false);
        Rilisoft.OfferItem val_8 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        if(this._leftView != null)
        {
            goto label_22;
        }
        
        goto label_23;
        label_19:
        this._table.repositionNow = true;
        if(this._table == null)
        {
            
        }
    
    }
    public BankMultyOfferView()
    {
    
    }

}
