using UnityEngine;
internal sealed class PixelPassSeasonEndWarningPanel : SimpleBunner
{
    // Fields
    private PixelPassSeasonEnd seasonEndView;
    private System.Collections.Generic.List<UnityEngine.GameObject> needPrem;
    private System.Collections.Generic.List<UnityEngine.GameObject> needLevels;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_4;
        System.Collections.Generic.List<UnityEngine.GameObject> val_5;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.needPrem, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.needLevels, 丏业丟一东丂东丘丛:  false);
        if(this.seasonEndView.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗() == false)
        {
            goto label_5;
        }
        
        if(this.seasonEndView.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.seasonEndView.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
            goto label_10;
        }
        
        val_4 = null;
        val_5 = this.needLevels;
        goto label_14;
        label_5:
        val_4 = null;
        val_5 = this.needPrem;
        label_14:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  true);
        return;
        label_10:
        this.Hide();
    }
    public void U_GetLevels()
    {
        this.Hide();
        this.seasonEndView.ShowBuyLevelUI();
    }
    public void U_GetPremium()
    {
        this.Hide();
        this.seasonEndView.U_BuyPremium();
    }
    public void U_CloseSeason()
    {
        this.Hide();
        this.seasonEndView.U_CloseSeason();
    }
    public PixelPassSeasonEndWarningPanel()
    {
    
    }

}
