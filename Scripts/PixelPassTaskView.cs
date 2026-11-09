using UnityEngine;
internal sealed class PixelPassTaskView : PGBehaviour
{
    // Fields
    private System.Action 三专丌一且丄且丅丘;
    private UISprite icon;
    private PGCompany.GameTaskView taskView;
    private PGCompany.PixelPass.PixelPassTaskRewardedVideoView taskRewardedVideoView;
    private UILabel dialogWindowLabel;
    private UnityEngine.GameObject dialogWindow;
    private UnityEngine.GameObject adsButton;
    private UnityEngine.GameObject transitionButton;
    private SimpleTweenePlayer collectAnimation;
    private UnityEngine.GameObject dev;
    private PGCompany.TimerUI timer;
    private System.Collections.Generic.List<UnityEngine.GameObject> lockedByTime;
    private System.Collections.Generic.List<UnityEngine.GameObject> lockedByPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> canCollect;
    private System.Collections.Generic.List<UnityEngine.GameObject> collected;
    private PGCompany.InventoryItemView taskReward;
    private UILabel collectLabel;
    private UnityEngine.GameObject state_LockedByTime;
    private UnityEngine.GameObject state_NotLockedByTime;
    private TagSystem.CompoundTagBehaviour compoundTagBehaviour;
    private RewardParticlesSource.Settings particlesSourceSettings;
    private RewardParticlesSource rewardParticlesSource;
    private RewardParticlesReceiver ppexpParticlesReceiver;
    private RewardParticlesReceiver currencyParticlesReceiver;
    private UnityEngine.GameObject notificationGO;
    private GuiApplyersGroup _guiApplyersGroup;
    private PGCompany.PixelPass.一万丄一丌丆业丐丅 与世七丑丂专专丌丙;
    
    // Methods
    internal void 丁丂丅万丛丈丝丘丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三专丌一且丄且丅丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921538587098136);
    
    }
    internal void 丝丛丂丅东丕丐下丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三专丌一且丄且丅丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921538587234712);
    
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)
    {
        PGCompany.PixelPass.一万丄一丌丆业丐丅 val_4 = 万不且且丛丆东丒业;
        this.与世七丑丂专专丌丙 = val_4;
        if(this.compoundTagBehaviour != null)
        {
                this.compoundTagBehaviour.与上丒丆丟与丘与丑();
            if(this.compoundTagBehaviour != null)
        {
                this.compoundTagBehaviour.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  PGCompany.PixelPass.丁且七丅丞丐丌丌世.丗丏丛丄三万丝下丟(三专三丐丁世丑丁丅:  val_4.业东丅东丌上丗丑不()));
        }
        
            val_4 = this.与世七丑丂专专丌丙;
        }
        
        if(val_4 != null)
        {
                PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_3 = val_4.丘丗不丂世丘三三丙();
            if(val_3 != null)
        {
                PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丒与丈世七丈丑丒(丈丂七世丟丞丂丗丒:  val_3, 专与万丐七丌丐丁丂:  this._guiApplyersGroup);
        }
        
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        object val_35;
        System.Collections.Generic.List<UnityEngine.GameObject> val_36;
        bool val_37;
        var val_38;
        var val_39;
        GuiApplyersGroup val_40;
        var val_41;
        val_35 = this;
        if(this.与世七丑丂专专丌丙 == null)
        {
                return;
        }
        
        if(this.collectAnimation != null)
        {
                this.collectAnimation.SetInitial();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notificationGO, 丏业丟一东丂东丘丛:  (~PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三()) & 1);
        if(this.与世七丑丂专专丌丙.业丙万丙世不丘丛上() != false)
        {
                val_36 = this.lockedByPremium;
            val_37 = 0;
        }
        else
        {
                val_37 = this.与世七丑丂专专丌丙.丗七与丛丁丏与丒七();
            val_36 = this.lockedByPremium;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  val_37);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.lockedByTime, 丏业丟一东丂东丘丛:  this.与世七丑丂专专丌丙.业丙万丙世不丘丛上());
        if(this.与世七丑丂专专丌丙.三下丐且世丝丛业丈() != false)
        {
                val_38 = (~this.与世七丑丂专专丌丙.万万上丆丑丐丗丝丛()) & 1;
        }
        else
        {
                val_38 = 0;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.canCollect, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.collected, 丏业丟一东丂东丘丛:  this.与世七丑丂专专丌丙.万万上丆丑丐丗丝丛());
        if(this.taskReward != null)
        {
                this.taskReward.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与世七丑丂专专丌丙.丈丏丁东上与东丙丕()));
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.collectLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.与世七丑丂专专丌丙.丗七与丛丁丏与丒七() != true) ? "Key_12502" : "Key_12317"));
        val_39 = 0;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  (~this.与世七丑丂专专丌丙.专丁丞万东丄万丄丄()) & 1);
        val_40 = this._guiApplyersGroup;
        if(val_40 == null)
        {
            goto label_32;
        }
        
        string val_20 = "PixelPass_TaskView_" + (this.与世七丑丂专专丌丙.专丁丞万东丄万丄丄() != true) ? "common" : "premium"((this.与世七丑丂专专丌丙.专丁丞万东丄万丄丄() != true) ? "common" : "premium");
        if(this.与世七丑丂专专丌丙 == null)
        {
            goto label_34;
        }
        
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_21 = this.与世七丑丂专专丌丙.丘丗不丂世丘三三丙();
        if(val_21 == null)
        {
            goto label_34;
        }
        
        val_41 = val_21.世丝丟业丅丛丕且丛();
        if(this.与世七丑丂专专丌丙 != null)
        {
            goto label_36;
        }
        
        val_40 = 0;
        goto label_36;
        label_34:
        val_41 = 0;
        label_36:
        val_39 = val_41;
        label_32:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.dialogWindowLabel, 丕丗丘丑丛与丑业丒:  this.与世七丑丂专专丌丙.丟下丄东上下丑与丆());
        if((this.与世七丑丂专专丌丙.业丙万丙世不丘丛上() != false) && (this.timer != null))
        {
                this.timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.与世七丑丂专专丌丙.与三东丌一丏且丂万(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PixelPassTaskView::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.icon, 万丑丞一丝丌丐丒丘:  this.与世七丑丂专专丌丙.丟丗丛丌一丁世东丑());
        this.taskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  this.与世七丑丂专专丌丙.丟下丄东上下丑与丆(), 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        this.taskView.丝一丅丆三东丂丞七();
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.state_LockedByTime, 丏业丟一东丂东丘丛:  this.与世七丑丂专专丌丙.业丙万丙世不丘丛上());
        val_35 = this.state_NotLockedByTime;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  (~this.与世七丑丂专专丌丙.业丙万丙世不丘丛上()) & 1);
    }
    public void U_ShowRewardedVideo()
    {
        this.丄专丑丙丛三专丑丝();
    }
    private void 丄专丑丙丛三专丑丝()
    {
        if(this.与世七丑丂专专丌丙 == null)
        {
                return;
        }
        
        if(this.taskRewardedVideoView == 0)
        {
                return;
        }
        
        if((this.与世七丑丂专专丌丙.丛下丁世专丟上且丗(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = false})) == false)
        {
                return;
        }
        
        System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(( & 1) == 0)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  37);
        bool val_7 = this.taskRewardedVideoView.且业下丅东与与丘丛(万不且且丛丆东丒业:  this.与世七丑丂专专丌丙, 丅丏丅丂丝一丆丙丅:  new System.DateTime() {}, 业丏丈世世世丞丒世:  new System.Action<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世(), method:  System.Void PGCompany.PixelPass.丘丏丅丆丑下业丙七::丆丕丏丈丏丐上下一(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)));
        this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        this.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dev, 丏业丟一东丂东丘丛:  false);
        PGCompany.PixelPass.丘丏丅丆丑下业丙七.丗一七丑一丞与不业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  this, method:  System.Void PixelPassTaskView::丘丘丘丌丈丛专丈丁(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)));
        PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PixelPassTaskView::上世丗丑七丘丅世丈(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
        PGCompany.世丐下丕专东丘丏且.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void PixelPassTaskView::丒丐万丞不专丁丆丙(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙业与丙丗丝不丈东)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassTaskView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskView::丝一丅丆三东丂丞七()));
        this.丝一丅丆三东丂丞七();
        this.七丟丙丒世丅不上东();
    }
    private void OnDisable()
    {
        PGCompany.PixelPass.丘丏丅丆丑下业丙七.丆丅丂丒丙丁世万丟(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  this, method:  System.Void PixelPassTaskView::丘丘丘丌丈丛专丈丁(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)));
        PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PixelPassTaskView::上世丗丑七丘丅世丈(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
        PGCompany.世丐下丕专东丘丏且.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void PixelPassTaskView::丒丐万丞不专丁丆丙(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙业与丙丗丝不丈东)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassTaskView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskView::丝一丅丆三东丂丞七()));
    }
    private void 上世丗丑七丘丅世丈(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        if(this.与世七丑丂专专丌丙.丟下丄东上下丑与丆() != 万不且且丛丆东丒业)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        this.七丟丙丒世丅不上东();
    }
    private void 丒丐万丞不专丁丆丙(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 丙业与丙丗丝不丈东)
    {
        if(this.与世七丑丂专专丌丙.丟下丄东上下丑与丆() != 万不且且丛丆东丒业)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        this.七丟丙丒世丅不上东();
    }
    private void 丘丘丘丌丈丛专丈丁(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)
    {
        var val_5;
        var val_6;
        if(this.与世七丑丂专专丌丙 != null)
        {
                int val_1 = this.与世七丑丂专专丌丙.业东丅东丌上丗丑不();
            val_5 = 0;
        }
        else
        {
                val_5 = 0;
        }
        
        if(val_5.丙东专丂世丈丏丁丂() != 万不且且丛丆东丒业.业东丅东丌上丗丑不())
        {
                return;
        }
        
        if(((-377680568) & 1) == 0)
        {
                return;
        }
        
        val_6 = null;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        this.七丟丙丒世丅不上东();
    }
    public void U_OnClck()
    {
        var val_10;
        PGCompany.PixelPass.一万丄一丌丆业丐丅 val_11;
        val_10 = this;
        val_11 = this.与世七丑丂专专丌丙;
        if(val_11 == null)
        {
                return;
        }
        
        if(this.三专丌一且丄且丅丘 != null)
        {
                this.三专丌一且丄且丅丘.Invoke();
            val_11 = this.与世七丑丂专专丌丙;
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
        }
        
        if(val_11.三下丐且世丝丛业丈() != false)
        {
                if(this.与世七丑丂专专丌丙.丗七与丛丁丏与丒七() != false)
        {
                if(PixelPassView.丝业丆丁业三丈丟东 == null)
        {
                return;
        }
        
            PixelPassView.丝业丆丁业三丈丟东.ShowBuyPremium();
            return;
        }
        
        }
        
        if(this.与世七丑丂专专丌丙.且世丝三不丂丟丞丑() == false)
        {
            goto label_34;
        }
        
        if(this.与世七丑丂专专丌丙.丙丛丘上万丆丝丄七() == false)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        if(this.collectAnimation != null)
        {
                this.collectAnimation.Play();
        }
        
        if(this.rewardParticlesSource == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_7 = this.与世七丑丂专专丌丙.丈丏丁东上与东丙丕().GetEnumerator();
        label_28:
        if(((-377486712) & 1) == 0)
        {
            goto label_20;
        }
        
        string val_8 = 0.丐丏七丌丕丗业且上();
        Rilisoft.OfferItemType val_9 = val_8.不业丙丒丂丞下丆丙();
        if(val_9 == 1460)
        {
            goto label_22;
        }
        
        if(val_9 != 1490)
        {
            goto label_23;
        }
        
        this.rewardParticlesSource.三且世三丂七丐一丟(丈丄不七三万丄丁不:  val_8, 业丄丒丑一丙丛丆丕:  this.ppexpParticlesReceiver, 与不丕丆丈不丙丟丛:  this.particlesSourceSettings);
        goto label_28;
        label_22:
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  13, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
        goto label_28;
        label_23:
        this.rewardParticlesSource.三且世三丂七丐一丟(丈丄不七三万丄丁不:  val_8, 业丄丒丑一丙丛丆丕:  this.currencyParticlesReceiver, 与不丕丆丈不丙丟丛:  this.particlesSourceSettings);
        goto label_28;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_34:
        this.丒三丏丁不丈丝丞丘();
    }
    public void U_Transition()
    {
        if(this.与世七丑丂专专丌丙 == null)
        {
                return;
        }
        
        if(this.与世七丑丂专专丌丙.丟丙丕丞丗三一且不() == null)
        {
                return;
        }
        
        if((this.与世七丑丂专专丌丙.丟丙丕丞丗三一且不() & 1) == 0)
        {
                return;
        }
        
        PGCompany.丕万丅丗丏三丙丈丁 val_3 = this.与世七丑丂专专丌丙.丟丙丕丞丗三一且不();
        this = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    internal void 丒三丏丁不丈丝丞丘()
    {
        var val_7;
        var val_8;
        if(this.与世七丑丂专专丌丙.三下丐且世丝丛业丈() != false)
        {
                return;
        }
        
        if((this.与世七丑丂专专丌丙.丛下丁世专丟上且丗(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = false})) != false)
        {
                val_7 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.三丈与丞上丘专丈丆();
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.与世七丑丂专专丌丙.丅丝丐七与丆且丗上() != false)
        {
                val_8 = this.与世七丑丂专专丌丙.丟丙丕丞丗三一且不() & 1;
        }
        else
        {
                val_8 = 0;
        }
        
        if((val_8 | val_7) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dialogWindow, 丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.adsButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.transitionButton, 丏业丟一东丂东丘丛:  false);
    }
    internal void 七丟丙丒世丅不上东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dialogWindow, 丏业丟一东丂东丘丛:  false);
    }
    private void 丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.丝一丅丆三东丂丞七();
    }
    public PixelPassTaskView()
    {
    
    }

}
