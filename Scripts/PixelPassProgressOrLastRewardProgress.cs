using UnityEngine;
internal sealed class PixelPassProgressOrLastRewardProgress : PGBehaviour
{
    // Fields
    private UILabel levelLabel;
    private UILabel progressLabel;
    private PGCompany.InventoryItemView lastCellReward;
    private SimpleProgressBarWithAnimation _progressBar;
    private SimpleProgressBarWithAnimation _progressBar_lastCell;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfLastCell;
    private PGCompany.TimerUI _timerUI;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.丝一丅丆三东丂丞七();
    }
    private void OnEnable()
    {
        PGCompany.万下丛丁丟不下丄业.东业丅万丌丌丑丗丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrLastRewardProgress::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrLastRewardProgress::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        if(this.丑与万三丐丒丏一专 == null)
        {
                this.丑与万三丐丒丏一专 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            this.丝一丅丆三东丂丞七();
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        PGCompany.万下丛丁丟不下丄业.丗世且上七丐丗丈东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrLastRewardProgress::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrLastRewardProgress::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    private void 丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        object val_28;
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_29;
        SimpleProgressBarWithAnimation val_30;
        PGCompany.TimerUI val_32;
        val_28 = this;
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        if(this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfLastCell, 丏业丟一东丂东丘丛:  false);
        val_29 = this.丑与万三丐丒丏一专;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  val_29.丞丞丘业东丙丏七丌());
        if(this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏() == null)
        {
            goto label_27;
        }
        
        val_29 = System.String.Format(format:  "{0}/{1}", arg0:  this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏().丂丂下丑且下丌丝东(), arg1:  this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏().丗丏丆丂专东丆三丑());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.progressLabel, 丕丗丘丑丛与丑业丒:  val_29);
        val_30 = this._progressBar;
        if(val_30 == null)
        {
            goto label_27;
        }
        
        val_29 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏().丂丂下丑且下丌丝东();
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_16 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏();
        goto label_21;
        label_3:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfLastCell, 丏业丟一东丂东丘丛:  true);
        val_29 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丑与万三丐丒丏一专.丂丝下丏丄上丐丛丗().丈丏丁东上与东丙丕());
        this.lastCellReward.Setup(丈丄不七三万丄丁不:  val_29);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.progressLabel, 丕丗丘丑丛与丑业丒:  "# reward bar");
        val_30 = this._progressBar_lastCell;
        if(val_30 == null)
        {
            goto label_27;
        }
        
        val_29 = this.丑与万三丐丒丏一专.丂丝下丏丄上丐丛丗().丂丂下丑且下丌丝东();
        label_21:
        val_30.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  val_29, 七丝东丛东丝且丆不:  this.丑与万三丐丒丏一专.丂丝下丏丄上丐丛丗().丗丏丆丂专东丆三丑(), 丈世万丙丟东与丕丞:  false);
        label_27:
        val_32 = this._timerUI;
        if(val_32 != null)
        {
                val_29 = this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与();
            val_32.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_29, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PixelPassProgressOrLastRewardProgress::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_32 = this._timerUI;
        }
        
        val_28 = this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32, 丏业丟一东丂东丘丛:  (val_28 > 0) ? 1 : 0);
    }
    public PixelPassProgressOrLastRewardProgress()
    {
    
    }

}
