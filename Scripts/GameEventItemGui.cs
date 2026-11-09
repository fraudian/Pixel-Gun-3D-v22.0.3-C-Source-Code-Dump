using UnityEngine;
public class GameEventItemGui : MonoBehaviour
{
    // Fields
    protected UILabel _nameLabel;
    private UIBasicSprite _texture;
    private Rilisoft.GameEventItemData <丅不丙丌丟业一业丂>k__BackingField;
    private System.Action<GameEventItemGui> 丅丕丌丛万丂丈七与;
    
    // Properties
    protected UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
    public Rilisoft.GameEventItemData 丞丑且东丌与丏丏丁 { get; set; }
    
    // Methods
    protected UIBasicSprite 丆下世世丟七专丞丒()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
        this._texture = val_1;
        return val_1;
    }
    public Rilisoft.GameEventItemData get_Data()
    {
        return (Rilisoft.GameEventItemData)this.<丅不丙丌丟业一业丂>k__BackingField;
    }
    protected void 丏丝丈丗丄丛丐万丆(Rilisoft.GameEventItemData 丙业与丙丗丝不丈东)
    {
        this.<丅不丙丌丟业一业丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void add_Clicked(System.Action<GameEventItemGui> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921537431559584);
    
    }
    public void remove_Clicked(System.Action<GameEventItemGui> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921537431696160);
    
    }
    public virtual void FillItem(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
    {
        string val_13;
        this.<丅不丙丌丟业一业丂>k__BackingField = 一丐丗丁丞丆丅丟丄;
        if(this._nameLabel != 0)
        {
                val_13 = this.<丅不丙丌丟业一业丂>k__BackingField.与丆业丅上丗七丆一();
            this._nameLabel.text = val_13;
        }
        
        if(this.丆下世世丟七专丞丒() == 0)
        {
                return;
        }
        
        UIBasicSprite val_5 = this.丆下世世丟七专丞丒();
        UnityEngine.Texture val_6 = this.<丅不丙丌丟业一业丂>k__BackingField.丑东丐下专丞丕丘世();
        this = ???;
        val_13 = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
    }
    private void OnClick()
    {
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
    }
    public GameEventItemGui()
    {
    
    }

}
