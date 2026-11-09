using UnityEngine;
internal sealed class PixelPassView : PGBehaviour
{
    // Fields
    private static PixelPassView 丝业丆丁业三丈丟东;
    private System.Action 丛丏下丙不丝且一一;
    private UnityEngine.GameObject dev;
    private PixelPassRewardsLineView rewardsLineView;
    private PixelPassTaskListView taskListView;
    private PixelPassElitTasksList elitTaskListView;
    private PGCompany.PixelPass.PixelPassEliteTaskGiveRewardView eliteTaskGiveRewardView;
    private PGCompany.PixelPassMigrationBanner migrationBanner;
    private PixelPassBuyPremium buyPremiumView;
    private PixelPassSeasonEnd seasonEnd;
    private PGCompany.TimerUI timerUI;
    private UnityEngine.GameObject mainHolder;
    private UnityEngine.GameObject characterHolder;
    private StoreCharacterHelper character;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> setUILayer;
    private System.Collections.Generic.List<UnityEngine.GameObject> setRocketLayer;
    private GuiApplyersGroup applyersGroup;
    private Rilisoft.BankBannersHolder bannersHolder;
    private UnityEngine.GameObject upgradePixelPassAnimation;
    private float upgradePixelPassAnimationDuration;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    internal 丆丝丈丐不专一丟且 东丑丞丏丝丂丝业不;
    protected System.IDisposable 专丏业专不丂一丂丛;
    private PGCompany.EventHubPresentation 与丛丌世丁万丒丟业;
    private UnityEngine.GameObject _mainContainer;
    private UnityEngine.GameObject _presentationContainer;
    private PGCompany.丝丆业不一丌东万世 一丟丅业丁丁丏丐丞;
    
    // Properties
    internal static PixelPassView 丆丕丝丒不丙且丐丗 { get; }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal static PixelPassView 丑七不且上丗丁一世()
    {
        return (PixelPassView)PixelPassView.丝业丆丁业三丈丟东;
    }
    internal void 丞丌丑丐丑丆上丗丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丏下丙不丝且一一, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丏下丙不丝且一一 != 1152921538590111896);
    
    }
    internal void 丛不丝丗一丏三专丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丏下丙不丝且一一, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丏下丙不丝且一一 != 1152921538590248472);
    
    }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        this.上丐丑业丏一与丂丐();
        PixelPassView.丝业丆丁业三丈丟东 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dev, 丏业丟一东丂东丘丛:  false);
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PixelPassView::U_Back()), 与且专丈不万东一万:  "PixelPassView");
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.丕丒丒丞丛丐东与下.丂丘丕丛业且丗丑且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丕丒丒丞丛丐东与下>(object:  this, method:  System.Void PixelPassView::丞丟下丟丟丐上丘丁(PGCompany.丕丒丒丞丛丐东与下 七丞丂丝丈七丙丒丏)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradePixelPassAnimation, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        this.下一且万丕一丈丄丗();
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.丕丒丒丞丛丐东与下.丙东丗丏丆丑丘七丐(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丕丒丒丞丛丐东与下>(object:  this, method:  System.Void PixelPassView::丞丟下丟丟丐上丘丁(PGCompany.丕丒丒丞丛丐东与下 七丞丂丝丈七丙丒丏)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, 丆丝丈丐不专一丟且 丗三丝丈专七万丕丆)
    {
        var val_5;
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_19;
        PGCompany.三东丏不丗世丅丌丄 val_20;
        val_19 = 丈丂七世丟丞丂丗丒;
        if(val_19 == null)
        {
                val_19 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
        }
        
        List.Enumerator<T> val_3 = this.setUILayer.GetEnumerator();
        label_7:
        if(((-375682784) & 1) == 0)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_5.丐丏七丌丕丗业且上(), 不东丛三丂丌丑专丆:  5, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        goto label_7;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_7 = this.setRocketLayer.GetEnumerator();
        label_16:
        if(((-375682784) & 1) == 0)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_5.丐丏七丌丕丗业且上(), 不东丛三丂丌丑专丆:  29, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        goto label_16;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.character.万与七丕七丁丞下丆 = false;
        this.character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丑与万三丐丒丏一专 = val_19;
        this.东丑丞丏丝丂丝业不 = 丗三丝丈专七万丕丆;
        PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丒与丈世七丈丑丒(丈丂七世丟丞丂丗丒:  val_19, 专与万丐七丌丐丁丂:  this.applyersGroup);
        this.上丐丑业丏一与丂丐();
        if((this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与() >= 1) && (this.timerUI != null))
        {
                this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PixelPassView::丆丁世七丙丝丕丙世()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        if(this.丁万且与丆东专丂丌() == false)
        {
            goto label_27;
        }
        
        this.丟一丏丁丟丁丕东丐();
        goto label_28;
        label_27:
        if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丏不丁丒丁与丐丈丘(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专)) != false)
        {
                this.东丑丞丏丝丂丝业不 = new 丆丝丈丐不专一丟且();
            .不丌不世且丄不三丝 = 3;
        }
        
        if(this.东丑丞丏丝丂丝业不 == null)
        {
            goto label_31;
        }
        
        if(this.东丑丞丏丝丂丝业不.不丌不世且丄不三丝 == 3)
        {
            goto label_32;
        }
        
        if(this.东丑丞丏丝丂丝业不.不丌不世且丄不三丝 == 2)
        {
            goto label_33;
        }
        
        if(this.东丑丞丏丝丂丝业不.不丌不世且丄不三丝 != 1)
        {
            goto label_37;
        }
        
        val_20 = this.东丑丞丏丝丂丝业不.下丅丙一丂丗丅丝七;
        goto label_35;
        label_31:
        val_20 = 0;
        label_35:
        this.专丑丌丒丂丙丏丏丂(下丅丙一丂丗丅丝七:  val_20);
        goto label_37;
        label_32:
        this.专丑丌丒丂丙丏丏丂(下丅丙一丂丗丅丝七:  this.东丑丞丏丝丂丝业不.下丅丙一丂丗丅丝七);
        this.ShowBuyPremium();
        goto label_37;
        label_33:
        this.丁丒丌丒业丕丌丝丗(三专三丐丁世丑丁丅:  this.东丑丞丏丝丂丝业不.三专三丐丁世丑丁丅);
        label_37:
        this.丌七一丒丌丅丄下丟();
        label_28:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
    }
    private bool 丁万且与丆东专丂丌()
    {
        if(this.丑与万三丐丒丏一专 != null)
        {
                return this.丑与万三丐丒丏一专.丙丛丁世丞丏且丙业();
        }
        
        return this.丑与万三丐丒丏一专.丙丛丁世丞丏且丙业();
    }
    private void 丆丁世七丙丝丕丙世()
    {
        if(this.丁万且与丆东专丂丌() != false)
        {
                this.丟一丏丁丟丁丕东丐();
        }
        
        if(this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与() < 1)
        {
                return;
        }
        
        if(this.timerUI == null)
        {
                return;
        }
        
        this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PixelPassView::丆丁世七丙丝丕丙世()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    internal void 丙万丆丗七丘三丝一()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
        if(this.rewardsLineView.gameObject.activeSelf != false)
        {
                this.rewardsLineView.丝一丅丆三东丂丞七();
            return;
        }
        
        if(this.taskListView.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.taskListView.丝一丅丆三东丂丞七();
    }
    private void 专丑丌丒丂丙丏丏丂(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)
    {
        var val_11;
        var val_12;
        PixelPassView.丟丑不七不丆业丐丛 val_1 = new PixelPassView.丟丑不七不丆业丐丛();
        if(val_1 != null)
        {
                val_11 = val_1;
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            this.丅万不丆一七丐丝专();
        }
        else
        {
                val_11 = 16;
            mem[16] = 下丅丙一丂丗丅丝七;
            this.丅万不丆一七丐丝专();
        }
        
        if(val_11 == 0)
        {
            goto label_10;
        }
        
        PixelPassView.丈丘丅一东丁七丒丏 val_2 = new PixelPassView.丈丘丅一东丁七丒丏();
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  this.丑与万三丐丒丏一专.丒东丒上世丘一丗丈(), predicate:  new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  val_1, method:  System.Boolean PixelPassView.丟丑不七不丆业丐丛::万下丈三专丗不业丒(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丒丒丄丁且丄丆丂丌)));
        if(val_2 == null)
        {
            goto label_5;
        }
        
        .丈丘丝一丗下丈丐不 = val_5;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_10;
        label_5:
        mem[16] = val_5;
        if(mem[16] == 0)
        {
            goto label_10;
        }
        
        label_6:
        PGCompany.PixelPass.不万丄丛丁下业丟上 val_8 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.不万丄丛丁下业丟上>(source:  this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝(), predicate:  new System.Func<PGCompany.PixelPass.不万丄丛丁下业丟上, System.Boolean>(object:  val_2, method:  System.Boolean PixelPassView.丈丘丅一东丁七丒丏::且丄丑一丛万丌且东(PGCompany.PixelPass.不万丄丛丁下业丟上 三丟东丕丄丄下下丑)));
        if(val_8 == null)
        {
            goto label_10;
        }
        
        val_12 = this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().IndexOf(item:  val_8);
        goto label_13;
        label_10:
        val_12 = 0;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsLineView, 丏业丟一东丂东丘丛:  true);
        this.rewardsLineView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丝业丈专业万上与丝:  0);
        this.丒丅丘丄丁丟丑东丌();
        this.七丗丏不丘丑丂丛丟();
    }
    private void 丁丒丌丒业丕丌丝丗(int 三专三丐丁世丑丁丅 = -1)
    {
        this.丅万不丆一七丐丝专();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskListView, 丏业丟一东丂东丘丛:  true);
        this.taskListView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 三专三丐丁世丑丁丅:  三专三丐丁世丑丁丅);
        this.丒丅丘丄丁丟丑东丌();
        this.七丗丏不丘丑丂丛丟();
    }
    private void 七丗丏不丘丑丂丛丟()
    {
        PGCompany.PixelPass.PixelPassEliteTaskGiveRewardView val_3;
        if(this.丑与万三丐丒丏一专.丏与上与专丝丅三与() == false)
        {
                return;
        }
        
        if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() != false)
        {
                return;
        }
        
        if(this.eliteTaskGiveRewardView != null)
        {
                this.eliteTaskGiveRewardView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
            val_3 = this.eliteTaskGiveRewardView;
        }
        else
        {
                val_3 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
    }
    private void 丒丅丘丄丁丟丑东丌()
    {
        if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丁丘丑丗丂上丞丄三() == false)
        {
                return;
        }
        
        if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() == true)
        {
                return;
        }
        
        if(this.migrationBanner == null)
        {
                return;
        }
        
        this.migrationBanner.下与丞三丅丛丄七丕();
    }
    private void 与七丌丌与不不丏丑()
    {
        this.丅万不丆一七丐丝专();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.elitTaskListView, 丏业丟一东丂东丘丛:  true);
        this.elitTaskListView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
    }
    private void 丟一丏丁丟丁丕东丐()
    {
        this.丅万不丆一七丐丝专();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.seasonEnd, 丏业丟一东丂东丘丛:  true);
        this.seasonEnd.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
    }
    public void ShowBuyPremium()
    {
        this.buyPremiumView.下与丞三丅丛丄七丕(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
    }
    private void 丅万不丆一七丐丝专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsLineView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskListView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.elitTaskListView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buyPremiumView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eliteTaskGiveRewardView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.seasonEnd, 丏业丟一东丂东丘丛:  false);
    }
    private void 丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.buyPremiumView.Hide();
        this.丙万丆丗七丘三丝一();
        this.业三丂丟下丝专与万();
    }
    private void 业三丂丟下丝专与万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradePixelPassAnimation, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PixelPassView::丙七下东丆与世下一()), 丆丐七丅丆丗丛上与:  this.upgradePixelPassAnimationDuration);
    }
    public void U_ShowRewardList()
    {
        this.专丑丌丒丂丙丏丏丂(下丅丙一丂丗丅丝七:  0);
    }
    public void U_ShowTaskList()
    {
        this.丁丒丌丒业丕丌丝丗(三专三丐丁世丑丁丅:  0);
    }
    public void U_ShowEliteTaskList()
    {
        this.与七丌丌与不不丏丑();
    }
    public void U_Back()
    {
        if(this.丁万且与丆东专丂丌() != false)
        {
                this.丟一丏丁丟丁丕东丐();
            return;
        }
        
        if(this.rewardsLineView.gameObject.activeSelf != false)
        {
                label_12:
            this.丛丏下丙不丝且一一.Invoke();
            return;
        }
        
        if(this.elitTaskListView.gameObject.activeSelf != false)
        {
                this.丁丒丌丒业丕丌丝丗(三专三丐丁世丑丁丅:  0);
            return;
        }
        
        if((this.东丑丞丏丝丂丝业不 != null) && (this.东丑丞丏丝丂丝业不.不丌不世且丄不三丝 == 2))
        {
                if(this.taskListView.gameObject.activeSelf == true)
        {
            goto label_12;
        }
        
        }
        
        this.专丑丌丒丂丙丏丏丂(下丅丙一丂丗丅丝七:  0);
    }
    public void U_Quit()
    {
        this.丛丏下丙不丝且一一.Invoke();
    }
    public void U_GoToMainStore()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  "", 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "PixelPass", 与东万丕丆丆且丕丕:  0);
    }
    public void DEV_ShowSeasonEnd()
    {
        this.丟一丏丁丟丁丕东丐();
    }
    public void DEV_CollecrRewards()
    {
        this.丑与万三丐丒丏一专.下东丕七丕一丞专丏();
    }
    private void 丞丟下丟丟丐上丘丁(PGCompany.丕丒丒丞丛丐东与下 七丞丂丝丈七丙丒丏)
    {
        if(七丞丂丝丈七丙丒丏.下丄丈不与世丐业专 != 2300)
        {
                return;
        }
        
        this.丌七一丒丌丅丄下丟();
    }
    private void 丌七一丒丌丅丄下丟()
    {
        if(this.丑与万三丐丒丏一专.丞七下丗丂丗与丅万() == true)
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  252)) == true)
        {
                return;
        }
        
        if((PGCompany.EventHub.丗且丅丕丒丑丞一丙.丆丞丂丌上东丈丛东(且下丕七丙丗丄不七:  5, 丗丆下丑一丕专丘世:  PGCompany.EventHub.EventHubBanner.丝丏上且丄丗丛丕世())) == false)
        {
                return;
        }
        
        this.七东丝丄专丘一丆丄();
    }
    internal void 七东丝丄专丘一丆丄()
    {
        PGCompany.EventHubPresentation val_26;
        string val_28;
        object val_29;
        val_26 = 1152921504848912384;
        if(this.与丛丌世丁万丒丟业 != 0)
        {
                this.与丛丌世丁万丒丟业.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.与丛丌世丁万丒丟业.gameObject);
            this.与丛丌世丁万丒丟业 = 0;
        }
        
        string val_5 = PGCompany.EventHub.丗且丅丕丒丑丞一丙.业专丈丐丂丟丏丕丂(丗丒下丝专丏丗丆丄:  this.丑与万三丐丒丏一专.世丝丟业丅丛丕且丛());
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == false)
        {
            goto label_12;
        }
        
        val_28 = "Presentation path for event {0} not found. Skip presentation.";
        goto label_13;
        label_12:
        PGCompany.EventHubPresentation val_7 = UnityEngine.Resources.Load<PGCompany.EventHubPresentation>(path:  val_5);
        if(val_7 != 0)
        {
            goto label_16;
        }
        
        val_28 = "Presentation for event {0} not found. Skip presentation.";
        label_13:
        val_29 = System.String.Format(format:  val_28, arg0:  5);
        UnityEngine.Debug.LogError(message:  val_29);
        return;
        label_16:
        PGCompany.EventHubPresentation val_11 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.EventHubPresentation>(丑且不丕与专丄业丙:  val_7, 丈东丘丏与丌东东下:  this._presentationContainer.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        this.与丛丌世丁万丒丟业 = val_11;
        DisableHardwareBack val_13 = val_11.丅与丌专丟一丝业三().AddComponent<DisableHardwareBack>();
        this.与丛丌世丁万丒丟业.animationWrapper.丟下丞三丘丑丝业丟 = new EventHubPresentationAnimationWrapper.丝丂丕下丄丞东三上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PixelPassView::丌丌世丏丝丏丌万丝());
        this.与丛丌世丁万丒丟业.OnSkipButtonClick = new System.Action(object:  this, method:  System.Void PixelPassView::丌丌世丏丝丏丌万丝());
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "last_shown_presentation_time", 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  System.String.Format(format:  "last_shown_presentation_time_{0}", arg0:  5), 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东且丁丕丏丕丞且丞();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._presentationContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.与丛丌世丁万丒丟业, 丏业丟一东丂东丘丛:  true);
        this.一丟丅业丁丁丏丐丞 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
        val_26 = this.与丛丌世丁万丒丟业;
        val_29 = new PGCompany.丝丆业不一丌东万世().丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  (this.与丛丌世丁万丒丟业.fog == true) ? 1 : 0).丂丁丅丏与丕不专且(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.与丛丌世丁万丒丟业.fogColor, g = V9.16B, b = V10.16B, a = V11.16B});
        PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  val_29.丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.与丛丌世丁万丒丟业.ambientLignt, g = V9.16B, b = V10.16B, a = V11.16B}));
    }
    internal void 丌丌世丏丝丏丌万丝()
    {
        if(this.与丛丌世丁万丒丟业 != 0)
        {
                this.与丛丌世丁万丒丟业.gameObject.SetActive(value:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._presentationContainer, 丏业丟一东丂东丘丛:  false);
        PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.一丟丅业丁丁丏丐丞);
    }
    private void 一丄丁万业专且丐丏()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainHolder, 丏业丟一东丂东丘丛:  true);
    }
    private void 上丐丑业丏一与丂丐()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        this = "menu_music_pixel_pass_" + this.丑与万三丐丒丏一专.世丝丟业丅丛丕且丛().ToLower();
        if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  this)) != false)
        {
                return;
        }
        
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  this, 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
    }
    private void 下一且万丕一丈丄丗()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        this = "menu_music_pixel_pass_" + this.丑与万三丐丒丏一专.世丝丟业丅丛丕且丛().ToLower();
        if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  this)) == false)
        {
                return;
        }
        
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆(), 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
    }
    public PixelPassView()
    {
        this.upgradePixelPassAnimationDuration = 3.5f;
    }
    private void 丙七下东丆与世下一()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradePixelPassAnimation, 丏业丟一东丂东丘丛:  false);
    }

}
