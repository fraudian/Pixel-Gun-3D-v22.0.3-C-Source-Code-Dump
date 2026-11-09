using UnityEngine;
public class LevelUpBannerNewContentView : MonoBehaviour
{
    // Fields
    private UIBasicSprite _texture;
    public string ItemTag;
    private System.Action<LevelUpBannerNewContentView> 丕业七下一业七丘与;
    
    // Properties
    public UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
    
    // Methods
    public UIBasicSprite get_Texture()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
        this._texture = val_1;
        return val_1;
    }
    public void add_OnClickHandler(System.Action<LevelUpBannerNewContentView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕业七下一业七丘与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕业七下一业七丘与 != 1152921539435160472);
    
    }
    public void remove_OnClickHandler(System.Action<LevelUpBannerNewContentView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕业七下一业七丘与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕业七下一业七丘与 != 1152921539435297048);
    
    }
    private void OnClick()
    {
        if(this.丕业七下一业七丘与 == null)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        this.丕业七下一业七丘与.Invoke(obj:  this);
    }
    public LevelUpBannerNewContentView()
    {
    
    }

}
