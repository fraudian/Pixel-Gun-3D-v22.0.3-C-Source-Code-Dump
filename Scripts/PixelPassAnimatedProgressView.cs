using UnityEngine;
internal sealed class PixelPassAnimatedProgressView : PGBehaviour
{
    // Fields
    private static System.Action 丛丞不丆且丞七世不;
    private System.Action 丗丁丙丘与东上丟东;
    private bool updateOnExpChange;
    private UILabel levelLabel;
    private SimpleProgressBarWithAnimation _progressBar;
    private RewardParticlesReceiver rewardParticlesReceiver;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPremium;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    private bool 丐丙丕丘丗丐不丞丅;
    private int 丛丝上丄丐与丟丌万;
    private int 专世丁丞丕七专专丞;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal static void 丟丄丝一万世丅丘万(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PixelPassAnimatedProgressView.丛丞不丆且丞七世不, b:  丙业与丙丗丝不丈东);
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
    internal static void 丒丆专三专业丐丌业(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PixelPassAnimatedProgressView.丛丞不丆且丞七世不, value:  丙业与丙丗丝不丈东);
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
    internal void 丁丕丒丆且丆世丞丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗丁丙丘与东上丟东, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丁丙丘与东上丟东 != 1152921538551467704);
    
    }
    internal void 万丝丈丂丙七丂丂世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗丁丙丘与东上丟东, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丁丙丘与东上丟东 != 1152921538551604280);
    
    }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.万丄一不丌专丞下不();
    }
    private void OnEnable()
    {
        System.Action val_8;
        if(this.丑与万三丐丒丏一专 == null)
        {
                this.丑与万三丐丒丏一专 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            this.万丄一不丌专丞下不();
        }
        
        this.rewardParticlesReceiver.丅丛丝不丛与上丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassAnimatedProgressView::下丗不丞丄业与世下()));
        val_8 = System.Delegate.Combine(a:  this._progressBar.世丅丙世不三丈世丅, b:  new System.Action(object:  this, method:  System.Void PixelPassAnimatedProgressView::东丞与不东丟丁丅丒()));
        if(this._progressBar == null)
        {
            goto label_5;
        }
        
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_8 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_9:
        this._progressBar.世丅丙世不三丈世丅 = val_8;
        PGCompany.万下丛丁丟不下丄业.东业丅万丌丌丑丗丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassAnimatedProgressView::一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)));
        this.万丄一不丌专丞下不();
    }
    private void OnDisable()
    {
        System.Action val_6;
        this.rewardParticlesReceiver.世专丅丄万丂丅丐丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassAnimatedProgressView::下丗不丞丄业与世下()));
        val_6 = System.Delegate.Remove(source:  this._progressBar.世丅丙世不三丈世丅, value:  new System.Action(object:  this, method:  System.Void PixelPassAnimatedProgressView::东丞与不东丟丁丅丒()));
        if(this._progressBar == null)
        {
            goto label_3;
        }
        
        if(val_6 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_6 == null)
        {
            goto label_7;
        }
        
        label_4:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_7:
        this._progressBar.世丅丙世不三丈世丅 = val_6;
        PGCompany.万下丛丁丟不下丄业.丗世且上七丐丗丈东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassAnimatedProgressView::一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)));
    }
    private void 下丗不丞丄业与世下()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        bool val_10 = this.丐丙丕丘丗丐不丞丅;
        val_10 = val_10 + 3;
        var val_11 = ~val_10;
        val_11 = val_11 & 3;
        if(val_11 != 0)
        {
                return;
        }
        
        this.丐丙丕丘丗丐不丞丅 = true;
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PixelPassAnimatedProgressView::不丙丈七丘三丅不业()), 丆丐七丅丆丗丛上与:  5f);
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_3 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏();
        if(this.丑与万三丐丒丏一专 == null)
        {
            goto label_6;
        }
        
        if(val_3 == null)
        {
            goto label_7;
        }
        
        label_9:
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_4 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏();
        goto label_8;
        label_6:
        if(val_3 != null)
        {
            goto label_9;
        }
        
        label_7:
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_5 = this.丑与万三丐丒丏一专.丛丙丌专丐七丛丘三();
        label_8:
        if(this.丛丝上丄丐与丟丌万 == this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌())
        {
                int val_7 = val_5.丂丂下丑且下丌丝东();
        }
        
        this._progressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  this.专世丁丞丕七专专丞, 丑丒丒丅七丞东丟丕:  val_5.丗丏丆丂专东丆三丑(), 七丝东丛东丝且丆不:  val_5.丗丏丆丂专东丆三丑(), 丈世万丙丟东与丕丞:  true);
    }
    private void 东丞与不东丟丁丅丒()
    {
        if(this.丗丁丙丘与东上丟东 != null)
        {
                this.丗丁丙丘与东上丟东.Invoke();
        }
        
        this.万丄一不丌专丞下不();
    }
    private void 一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)
    {
        if(this.updateOnExpChange == false)
        {
                return;
        }
        
        this.万丄一不丌专丞下不();
    }
    private void 万丄一不丌专丞下不()
    {
        int val_15;
        this.丐丙丕丘丗丐不丞丅 = false;
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌());
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_6 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏();
        if(this.丑与万三丐丒丏一专 == null)
        {
            goto label_7;
        }
        
        if(val_6 == null)
        {
            goto label_8;
        }
        
        label_10:
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_7 = this.丑与万三丐丒丏一专.一丞丛丂丗丁业丑丏();
        goto label_9;
        label_7:
        if(val_6 != null)
        {
            goto label_10;
        }
        
        label_8:
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_8 = this.丑与万三丐丒丏一专.丛丙丌专丐七丛丘三();
        label_9:
        if(val_8 != null)
        {
                val_15 = val_8.丂丂下丑且下丌丝东();
        }
        else
        {
                val_15 = 0.丂丂下丑且下丌丝东();
        }
        
        this._progressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  val_15, 七丝东丛东丝且丆不:  val_8.丗丏丆丂专东丆三丑(), 丈世万丙丟东与丕丞:  false);
        this.丛丝上丄丐与丟丌万 = this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌();
        this.专世丁丞丕七专专丞 = val_8.丂丂下丑且下丌丝东();
    }
    public PixelPassAnimatedProgressView()
    {
    
    }
    private void 不丙丈七丘三丅不业()
    {
        this.丐丙丕丘丗丐不丞丅 = false;
    }

}
