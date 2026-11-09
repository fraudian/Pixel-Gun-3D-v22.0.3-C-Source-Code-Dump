using UnityEngine;
internal sealed class UniversalRewardFinalView : PGBehaviour
{
    // Fields
    private System.Action 丈三下丛丞丝世不丏;
    private System.Action 丄丆丙业世丏与丞丛;
    private ItemRewardListViewScrolled rewardListView;
    private UnityEngine.AudioClip onSetup;
    private UnityEngine.AudioClip coolnessOne;
    private UnityEngine.AudioClip coolnessTwo;
    private UnityEngine.AudioClip coolnessThree;
    private UnityEngine.AudioClip coolnessFour;
    private UnityEngine.GameObject state_Animations;
    private UnityEngine.GameObject state_Finished;
    
    // Methods
    internal void 业丗与丗三且丝丏不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈三下丛丞丝世不丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921539483447944);
    
    }
    internal void 丝不丘丛上丕万与七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈三下丛丞丝世不丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921539483584520);
    
    }
    internal void 丘丏丘丄丈且上丕东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丆丙业世丏与丞丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921539483721104);
    
    }
    internal void 丁丁丁东业丒下丈业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丆丙业世丏与丞丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921539483857680);
    
    }
    private void OnEnable()
    {
        this.rewardListView.add_onFillList(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardFinalView::七丐丅七丏下与丅丂()));
        this.rewardListView.add_onAddReward(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丄与丘丑业专丞七丅>(object:  this, method:  System.Void UniversalRewardFinalView::一丁不丗世上丂丂丈(PGCompany.丄与丘丑业专丞七丅 丘丂丅且丄丑丞万丟)));
    }
    private void OnDisable()
    {
        this.rewardListView.remove_onFillList(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardFinalView::七丐丅七丏下与丅丂()));
        this.rewardListView.remove_onAddReward(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丄与丘丑业专丞七丅>(object:  this, method:  System.Void UniversalRewardFinalView::一丁不丗世上丂丂丈(PGCompany.丄与丘丑业专丞七丅 丘丂丅且丄丑丞万丟)));
        this.rewardListView.丄一且丄丑专丙丗世();
    }
    public void Setup(UniversalRewardController.与丏下丒与丙丟丝一 丁东丛丅业七丏丌丑)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Animations, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Finished, 丏业丟一东丂东丘丛:  false);
        this.gameObject.SetActive(value:  true);
        if(this.丈三下丛丞丝世不丏 != null)
        {
                this.丈三下丛丞丝世不丏.Invoke();
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.onSetup);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Animations, 丏业丟一东丂东丘丛:  true);
        this.rewardListView.丄一且丄丑专丙丗世();
        this.rewardListView.丈且东丑丂且万丒丅(丑丟上一三业万万丏:  丁东丛丅业七丏丌丑.丆丌丙丛丄丂丘丟丟);
    }
    private void 一丁不丗世上丂丂丈(PGCompany.丄与丘丑业专丞七丅 丘丂丅且丄丑丞万丟)
    {
        this.丘上七一丆丐一丝丘(丗七丟丈三不丕一三:  丘丂丅且丄丑丞万丟);
    }
    private void 七丐丅七丏下与丅丂()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Animations, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Finished, 丏业丟一东丂东丘丛:  true);
        if(this.丄丆丙业世丏与丞丛 == null)
        {
                return;
        }
        
        this.丄丆丙业世丏与丞丛.Invoke();
    }
    private void 丘上七一丆丐一丝丘(PGCompany.丄与丘丑业专丞七丅 丗七丟丈三不丕一三)
    {
        UnityEngine.AudioClip val_7;
        UnityEngine.AudioClip val_8;
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "One")) == false)
        {
            goto label_3;
        }
        
        val_7 = this.coolnessOne;
        goto label_10;
        label_3:
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Two")) == false)
        {
            goto label_6;
        }
        
        val_7 = this.coolnessTwo;
        goto label_10;
        label_6:
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Three")) == false)
        {
            goto label_9;
        }
        
        val_7 = this.coolnessThree;
        goto label_10;
        label_9:
        val_8 = 0;
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Four")) == false)
        {
            goto label_12;
        }
        
        val_7 = this.coolnessFour;
        label_10:
        val_8 = mem[this.coolnessFour];
        label_12:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_8);
    }
    public UniversalRewardFinalView()
    {
    
    }

}
