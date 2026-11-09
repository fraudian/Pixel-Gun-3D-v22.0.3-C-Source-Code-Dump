using UnityEngine;
internal sealed class ClanBuildingGraphicView : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UIBasicSprite> icon;
    private System.Collections.Generic.List<UIBasicSprite> emptyIcon;
    private System.Collections.Generic.List<UIBasicSprite> pattern;
    private System.Collections.Generic.List<UIWidget> mainColor;
    private System.Collections.Generic.List<UIWidget> secondaryColor;
    private System.Collections.Generic.List<UIWidget> extraColor;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        this.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.UpdateView();
    }
    public void UpdateView()
    {
        this.icon.ForEach(action:  new System.Action<UIBasicSprite>(object:  this, method:  System.Void ClanBuildingGraphicView::与业丗下东丞业上三(UIBasicSprite 三丟东丕丄丄下下丑)));
        this.emptyIcon.ForEach(action:  new System.Action<UIBasicSprite>(object:  this, method:  System.Void ClanBuildingGraphicView::丐丗丕东与丑丌上丙(UIBasicSprite 三丟东丕丄丄下下丑)));
        this.pattern.ForEach(action:  new System.Action<UIBasicSprite>(object:  this, method:  System.Void ClanBuildingGraphicView::丁业丒丂丆且丈专丌(UIBasicSprite 三丟东丕丄丄下下丑)));
        UnityEngine.Color val_4 = this.丛不丈不丙丟不三上.上一丂丟丑丕丕丘且();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.mainColor, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        UnityEngine.Color val_5 = this.丛不丈不丙丟不三上.丞丂丟下一业与丐丆();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.secondaryColor, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        UnityEngine.Color val_6 = this.丛不丈不丙丟不三上.丌丕上丟七不东一丗();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.extraColor, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UIBasicSprite>(不丗上三丛丒上东丑:  this.pattern, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UIBasicSprite>(不丗上三丛丒上东丑:  this.pattern, 丏业丟一东丂东丘丛:  true);
    }
    public ClanBuildingGraphicView()
    {
    
    }
    private void 与业丗下东丞业上三(UIBasicSprite 三丟东丕丄丄下下丑)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  三丟东丕丄丄下下丑, 与万丆丛丒万丝丙丑:  this.丛不丈不丙丟不三上);
    }
    private void 丐丗丕东与丑丌上丙(UIBasicSprite 三丟东丕丄丄下下丑)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  三丟东丕丄丄下下丑, 与万丆丛丒万丝丙丑:  this.丛不丈不丙丟不三上.丏三丏丅三且且丄丗());
    }
    private void 丁业丒丂丆且丈专丌(UIBasicSprite 三丟东丕丄丄下下丑)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  三丟东丕丄丄下下丑, 与万丆丛丒万丝丙丑:  this.丛不丈不丙丟不三上.与丙丘丟七丘丄专丟());
    }

}
