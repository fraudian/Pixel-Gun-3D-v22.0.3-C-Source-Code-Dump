using UnityEngine;
internal class SpSubscriptionViewComponent : SPViewComponentBase
{
    // Fields
    private static System.Action 丈丈且且七丑上丌丏;
    private UnityEngine.GameObject _smallInfoButton;
    private UIButton btnBuy;
    private UIButton btnInfo;
    private System.Collections.Generic.List<UILabel> headerLabels;
    private UIBasicSprite _mainTexture;
    private UIBasicSprite _singleRewardTexture;
    private UnityEngine.GameObject _singleRewardContainer;
    private UISprite _repeatableRewardSprite;
    private System.Collections.Generic.List<UILabel> _repeatableRewardLabels;
    private UISprite _repeatableRewardTotalSprite;
    private System.Collections.Generic.List<UILabel> _repeatableRewardTotalLabels;
    private UnityEngine.GameObject _trialContainer;
    private System.Collections.Generic.List<UILabel> _trialLabels;
    private UnityEngine.GameObject _buyContainer;
    private System.Collections.Generic.List<UILabel> _buyLabels;
    private UnityEngine.GameObject _timerContainer;
    private PGCompany.TimerUI _timer;
    private UnityEngine.GameObject _pickupContainer;
    private UnityEngine.GameObject _giveObject;
    private UIWidget _dragWidget;
    private bool 东专丙七与丕丑丆丕;
    private UIPanel 丏丝丛丕丆专丘丌丌;
    
    // Properties
    private UIPanel 七丐丌专万世世丁丐 { get; }
    
    // Methods
    internal static void 丞丌丏三丝丐下丞业(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SpSubscriptionViewComponent.丈丈且且七丑上丌丏, b:  丙业与丙丗丝不丈东);
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
    internal static void 东不七一丆万七丂下(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SpSubscriptionViewComponent.丈丈且且七丑上丌丏, value:  丙业与丙丗丝不丈东);
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
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_47;
        var val_48;
        var val_50;
        val_47 = 且丘丏丁丑与丙与丁;
        this.Setup(且丘丏丁丑与丙与丁:  val_47);
        if(val_47 != null)
        {
                val_47 = 0;
        }
        
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_2 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        丘丙丁丅七一与且丈(丆万一不丌且东丐丐:  "reward-subscription-repeatable", 专丂丕丗丗东世丞下: ref  val_2);
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_3 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        丘丙丁丅七一与且丈(丆万一不丌且东丐丐:  "reward-subscription-single", 专丂丕丗丗东世丞下: ref  val_3);
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_4 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        丘丙丁丅七一与且丈(丆万一不丌且东丐丐:  "reward-subscription-repeatable-total", 专丂丕丗丗东世丞下: ref  val_4);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.headerLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8018"));
        if(this._singleRewardContainer != 0)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<PGCompany.丄与丘丑业专丞七丅>(丑东与丅丐丅丂丞业:  val_3)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._singleRewardContainer, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                PGCompany.丄与丘丑业专丞七丅 val_9 = val_3.Item[0];
            UIBasicSprite val_47 = this._singleRewardTexture;
            val_47 = (((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_9.ItemParams)) != 0) ? 1 : 0) & (UnityEngine.Object.op_Inequality(x:  val_47, y:  0));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._singleRewardContainer, 丏业丟一东丂东丘丛:  val_47);
            bool val_13 = this._singleRewardContainer.activeSelf;
        }
        
        }
        
        val_48 = 1152921539217954608;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<PGCompany.丄与丘丑业专丞七丅>(丑东与丅丐丅丂丞业:  val_2)) != true)
        {
                if(this._repeatableRewardSprite != 0)
        {
                this._repeatableRewardSprite.spriteName = val_2.Item[0].东东丐丕东丒丝丗丆(丗七丟丈三不丕一三:  val_16.ItemParams);
        }
        
            if(this._repeatableRewardLabels != null)
        {
                PGCompany.丄与丘丑业专丞七丅 val_18 = val_2.Item[0];
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._repeatableRewardLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8025"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_18.ItemParams.丂丁丏一丙丛业且丌())));
        }
        
            if(this._repeatableRewardTotalSprite != 0)
        {
                this._repeatableRewardTotalSprite.spriteName = val_2.Item[0].东东丐丕东丒丝丗丆(丗七丟丈三不丕一三:  val_24.ItemParams);
        }
        
        }
        
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<PGCompany.丄与丘丑业专丞七丅>(丑东与丅丐丅丂丞业:  val_4)) != true) && (this._repeatableRewardTotalLabels != null))
        {
                PGCompany.丄与丘丑业专丞七丅 val_27 = val_4.Item[0];
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._repeatableRewardTotalLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8027"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_27.ItemParams.丂丁丏一丙丛业且丌())));
        }
        
        this.丄丑七丘丁且丞丙专(丈三丂丏与一业丄丝:  与不丞丑七丘丁丂丛());
        string val_48 = "subscription_waiting";
        val_48 = 与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_48);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  val_48);
        if(this._timer.gameObject.activeSelf != false)
        {
                if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != false)
        {
                long val_38 = 专七专下且专三一且.上且一丈丐三丄一丆();
        }
        
            val_48 = 下丒丗丄丌丘不丑丘();
            this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_48 - PixelTime.丙丅丅业丟丁世丁丗(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        if((与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_not_bought_trial")) != false)
        {
                val_50 = 1;
        }
        else
        {
                val_50 = 与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_not_bought");
        }
        
        bool val_46 = val_50;
        this.btnInfo.enabled = val_46;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._smallInfoButton, 丏业丟一东丂东丘丛:  val_46);
        this.丕丁专上丐东丐丗丒();
    }
    private void 丄丑七丘丁且丞丙专(TagSystem.三与下丘七丘丌丏丄 丈三丂丏与一业丄丝)
    {
        UnityEngine.GameObject val_8;
        var val_9;
        if((丈三丂丏与一业丄丝.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_not_bought_trial")) != true)
        {
                if((丈三丂丏与一业丄丝.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_not_bought")) == false)
        {
            goto label_4;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._trialContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._pickupContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._buyLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8106"));
        goto label_16;
        label_4:
        if((丈三丂丏与一业丄丝.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_can_collect")) == false)
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._trialContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  false);
        val_8 = this._pickupContainer;
        val_9 = 1;
        goto label_14;
        label_11:
        if((丈三丂丏与一业丄丝.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription_waiting")) == false)
        {
            goto label_16;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._trialContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  true);
        val_8 = this._pickupContainer;
        val_9 = 0;
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  false);
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.headerLabels, 丏业丟一东丂东丘丛:  (~this._timerContainer.activeSelf) & 1);
    }
    private void 丕丁专上丐东丐丗丒()
    {
        if(this._dragWidget == 0)
        {
                return;
        }
        
        if(this.东专丙七与丕丑丆丕 == true)
        {
                return;
        }
        
        UIPanel val_2 = this.不丘丁专丙丈万丌丑();
        if(val_2 == 0)
        {
                return;
        }
        
        if((val_2.IsVisible(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = ???, y = V12.16B, z = V13.16B}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, 丐丆丂丒丁万丈丛丅:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???})) == false)
        {
                return;
        }
        
        this.东专丙七与丕丑丆丕 = this._dragWidget.isVisible;
        if(SpSubscriptionViewComponent.丈丈且且七丑上丌丏 == null)
        {
                return;
        }
        
        SpSubscriptionViewComponent.丈丈且且七丑上丌丏.Invoke();
    }
    private UIPanel 不丘丁专丙丈万丌丑()
    {
        UIPanel val_5;
        if(this.丏丝丛丕丆专丘丌丌 == 0)
        {
                this.丏丝丛丕丆专丘丌丌 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UIScrollView>(丝三丁东丈丒世丅业:  this.gameObject).GetComponent<UIPanel>();
            return val_5;
        }
        
        val_5 = this.丏丝丛丕丆专丘丌丌;
        return val_5;
    }
    private string 东东丐丕东丒丝丗丆(PGCompany.三东丏不丗世丅丌丄 丗七丟丈三不丕一三)
    {
        string val_4;
        var val_5;
        val_4 = 丗七丟丈三不丕一三;
        if(val_4 == null)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_4 = val_4.业上丙丞丐丄丆丅七();
        val_5 = null;
        val_5 = null;
        var val_3 = ((System.String.op_Equality(a:  val_4, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? "gem_znachek" : "coin_znachek";
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    public SpSubscriptionViewComponent()
    {
    
    }

}
