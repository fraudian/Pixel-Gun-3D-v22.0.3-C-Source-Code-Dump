using UnityEngine;
internal sealed class PixelPassSeasonEnd : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject dev;
    private PixelPassView pixelPassView;
    private UnityEngine.GameObject guiHolder;
    private UnityEngine.GameObject buyLevelHolder;
    private UnityEngine.GameObject allCollectedHolder;
    private UnityEngine.GameObject notCollectedHolder;
    private UIScrollView notCollectedScroll;
    private ItemListUI notCollectedRewardsList;
    private UnityEngine.GameObject youCanGetHolder;
    private UIScrollView youCanGetScroll;
    private ItemListUI youCanGetRewardsList;
    private UnityEngine.GameObject getPremiumButton;
    private UnityEngine.GameObject getLevelsButton;
    private PixelPassSeasonEndBuyLevel buyLevelView;
    private PixelPassSeasonEndWarningPanel warningPanel;
    private UnityEngine.GameObject disableOnOpen;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableListOnOpen;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    protected System.IDisposable 专丏业专不丂一丂丛;
    protected System.IDisposable 上三丒不与上万丝丝;
    private bool 不丒上万丘丆丐专丒;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        this.不丒上万丘丆丐专丒 = this.disableOnOpen.activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableOnOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableListOnOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dev, 丏业丟一东丂东丘丛:  false);
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "PixelPassSeasonEnd");
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassSeasonEnd::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    private void OnDisable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableOnOpen, 丏业丟一东丂东丘丛:  (this.不丒上万丘丆丐专丒 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableListOnOpen, 丏业丟一东丂东丘丛:  true);
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassSeasonEnd::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    private void 丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.丝一丅丆三东丂丞七();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buyLevelHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.warningPanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.guiHolder, 丏业丟一东丂东丘丛:  true);
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getPremiumButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getLevelsButton, 丏业丟一东丂东丘丛:  false);
        if(this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗() == false)
        {
            goto label_4;
        }
        
        if(this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
            goto label_10;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getLevelsButton, 丏业丟一东丂东丘丛:  true);
        goto label_10;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getPremiumButton, 丏业丟一东丂东丘丛:  true);
        label_10:
        this.丑丁丒丌丛且丗下丕(万丈丝丏丏丁丕丙三:  this.丏丙丄丗且丘上丑业());
    }
    private PixelPassSeasonEnd.下七一丌丝丂丙七丑 丏丙丄丗且丘上丑业()
    {
        var val_14;
        var val_15;
        val_14 = this;
        if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丐世丆丒下与丐丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专).Count) == 0)
        {
                if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丛三丑上丝一丕丞丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专).Count) == 0)
        {
            goto label_4;
        }
        
        }
        
        if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丐世丆丒下与丐丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专).Count) >= 1)
        {
                if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丛三丑上丝一丕丞丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专).Count) > 0)
        {
                val_15 = 4;
            return (下七一丌丝丂丙七丑)val_15;
        }
        
        }
        
        if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丐世丆丒下与丐丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专).Count) > 0)
        {
                val_15 = 2;
            return (下七一丌丝丂丙七丑)val_15;
        }
        
        val_14 = PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丛三丑上丝一丕丞丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
        var val_13 = (val_14.Count < 1) ? 0 : 3;
        return (下七一丌丝丂丙七丑)val_15;
        label_4:
        val_15 = 1;
        return (下七一丌丝丂丙七丑)val_15;
    }
    private void 丑丁丒丌丛且丗下丕(PixelPassSeasonEnd.下七一丌丝丂丙七丑 万丈丝丏丏丁丕丙三)
    {
        if((万丈丝丏丏丁丕丙三 - 1) > 3)
        {
                return;
        }
        
        var val_2 = 106043932 + ((万丈丝丏丏丁丕丙三 - 1)) << 2;
        val_2 = val_2 + 106043932;
        goto (106043932 + ((万丈丝丏丏丁丕丙三 - 1)) << 2 + 106043932);
    }
    private void 专丁丒丈丘七专东丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allCollectedHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notCollectedHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.youCanGetHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 丏丟丅丌丛上丂丈丆()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allCollectedHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notCollectedHolder, 丏业丟一东丂东丘丛:  true);
        this.notCollectedScroll.ResetPosition();
        this.notCollectedRewardsList.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丐世丆丒下与丐丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.youCanGetHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 专不丑丛丅丙东上丘()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allCollectedHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notCollectedHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.youCanGetHolder, 丏业丟一东丂东丘丛:  true);
        this.youCanGetScroll.ResetPosition();
        this.youCanGetRewardsList.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丛三丑上丝一丕丞丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专));
    }
    private void 业丂丐丌且且丛丆丛()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allCollectedHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notCollectedHolder, 丏业丟一东丂东丘丛:  true);
        this.notCollectedScroll.ResetPosition();
        this.notCollectedRewardsList.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丐世丆丒下与丐丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.youCanGetHolder, 丏业丟一东丂东丘丛:  true);
        this.youCanGetScroll.ResetPosition();
        this.youCanGetRewardsList.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丛三丑上丝一丕丞丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专));
    }
    public void ShowBuyLevelUI()
    {
        if(this.上三丒不与上万丝丝 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.上三丒不与上万丝丝.Dispose();
        }
        
        this.上三丒不与上万丝丝 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PixelPassSeasonEnd::HideBuyLevelUI()), 与且专丈不万东一万:  "PixelPassSeasonEnd_BuyLevel");
        this.buyLevelView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buyLevelHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.guiHolder, 丏业丟一东丂东丘丛:  false);
    }
    public void HideBuyLevelUI()
    {
        if(this.上三丒不与上万丝丝 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.上三丒不与上万丝丝.Dispose();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buyLevelHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.guiHolder, 丏业丟一东丂东丘丛:  true);
        this.丝一丅丆三东丂丞七();
    }
    public void U_StoreButton()
    {
        if(this.pixelPassView != null)
        {
                this.pixelPassView.U_GoToMainStore();
            return;
        }
        
        0.U_GoToMainStore();
    }
    public void U_BuyPremium()
    {
        this.pixelPassView.ShowBuyPremium();
    }
    public void U_BuyLevels()
    {
        this.ShowBuyLevelUI();
    }
    public void U_CloseSeason()
    {
        PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丟丙世丌与万东东丅();
        this.pixelPassView.U_Quit();
    }
    public void U_TryCloseSeason()
    {
        if(this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗() == false)
        {
            goto label_1;
        }
        
        0 = 0;
        if(this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
            goto label_4;
        }
        
        label_1:
        this.warningPanel.Show();
        return;
        label_4:
        this.U_CloseSeason();
    }
    public PixelPassSeasonEnd()
    {
    
    }

}
