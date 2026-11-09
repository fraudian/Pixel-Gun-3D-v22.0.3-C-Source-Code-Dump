using UnityEngine;
internal sealed class TopRoundItemInfo : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UISprite> _listIcon;
    private UILabel _text;
    private 丏下一丌且三与丘丘 丐丙丒丈丄不一丈与;
    
    // Methods
    internal void 丅丝三丌且三丐万世(丏下一丌且三与丘丘 下丅丙一丂丗丅丝七)
    {
        var val_4 = this;
        this.丐丙丒丈丄不一丈与 = 下丅丙一丂丗丅丝七;
        List.Enumerator<T> val_1 = this._listIcon.GetEnumerator();
        label_9:
        if(((-1290184792) & 1) == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        0.丐丏七丌丕丗业且上().spriteName = this.丐丙丒丈丄不一丈与.GetNameSprite();
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丕下不与与不丞丟丙()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        this._text.text = this.丐丙丒丈丄不一丈与.GetInfo();
    }
    public TopRoundItemInfo()
    {
        this._listIcon = new System.Collections.Generic.List<UISprite>();
    }

}
