using UnityEngine;
internal sealed class HatchPetView : PGBehaviour
{
    // Fields
    private System.Action 与丝丐丛丘且丝且丟;
    private System.Action 丂丙专丐专丘丏丛丂;
    private System.Action 丝七万丛丆丟丏丂丑;
    private System.Action 丄与下丈世丐丌丛丝;
    private System.Action 七丒且世业丘世丒丑;
    private System.Action 丗丗丈丆上丏万三丕;
    private PGCompany.丕下丆丑万世业丈丟 丄丈世业七丐三上东;
    private PGCompany.上丕一与丕丏丟丂东 三丗下丕丕下丑丁丙;
    private PGCompany.世丒丗丅丛丕不万丂 丟丅丆丘七丞东丁丝;
    private PGCompany.三东丏不丗世丅丌丄 丈与丁丄不丗七丌万;
    private UnityEngine.GameObject trainingHintAccept;
    private HatchEggUI hatchEggUI;
    private EggHatchResultView eggHatchResultView;
    private UnityEngine.GameObject eggViewHolder;
    private UnityEngine.GameObject petViewHolder;
    private UnityEngine.GameObject hatchButton;
    private PGCompany.InventoryItemView eggItemView;
    private HatchingEggRefsHolder eggExample;
    private float hatchEggAnimDuration;
    private UnityEngine.GameObject upgradeButton;
    private UnityEngine.Transform petObjectHolder;
    private UIInput petNameInput;
    private PGCompany.InventoryItemView petItemView;
    private PGCompany.InventoryItemView upagradePrice;
    private PGCompany.InventoryItemView compensationItemView;
    private UnityEngine.GameObject titleHolder;
    private UILabel titleLabel;
    private UILabel rareLabel;
    private PGCompany.ProgressBarView upgradeBar_OldView;
    private PGCompany.ProgressBarView upgradeBar_NewValue;
    private UILabel curLvlLabel;
    private UILabel nexLvlLabel;
    private UILabel newPointCountLabel;
    private UnityEngine.GameObject upgradeParticles;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnMaxLevel;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnMaxLevel;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfCanUpgrade;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableIfCanUpgrade;
    private bool 丏丄丈丞丐丁丑丙丐;
    private HatchingEggRefsHolder 七丅丄丞丞丄丈专丝;
    private UnityEngine.GameObject 一丏丞丄不丅丗丒丑;
    public AnimationCoroutineRunner petProfileAnimationRunner;
    
    // Properties
    public PGCompany.丕下丆丑万世业丈丟 丕下丆丑万世业丈丟 { get; }
    public PGCompany.上丕一与丕丏丟丂东 与且丕丕东业专上丌 { get; }
    public PGCompany.世丒丗丅丛丕不万丂 丑丐丌丒丛上上丝专 { get; }
    public PGCompany.三东丏不丗世丅丌丄 东七丝丆丈业丐丟上 { get; }
    
    // Methods
    internal void 三世丘丄丐丐与丘丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.与丝丐丛丘且丝且丟, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与丝丐丛丘且丝且丟 != 1152921526208120392);
    
    }
    internal void 且丏丝丝丏丏丄与丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.与丝丐丛丘且丝且丟, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与丝丐丛丘且丝且丟 != 1152921526208256968);
    
    }
    internal void 丒丝丟丕一且丌世丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丂丙专丐专丘丏丛丂, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂丙专丐专丘丏丛丂 != 1152921526208393552);
    
    }
    internal void 丄丌丅丄丈丛丏丒业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丂丙专丐专丘丏丛丂, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂丙专丐专丘丏丛丂 != 1152921526208530128);
    
    }
    internal void 丕上丕丁不丘不丒丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丝七万丛丆丟丏丂丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝七万丛丆丟丏丂丑 != 1152921526208666712);
    
    }
    internal void 丈丌丈丏不丄丏与上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丝七万丛丆丟丏丂丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝七万丛丆丟丏丂丑 != 1152921526208803288);
    
    }
    internal void 丕与丑上丗丝丗丌不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄与下丈世丐丌丛丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄与下丈世丐丌丛丝 != 1152921526208939872);
    
    }
    internal void 丌万丁丙丂丛丗丞丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄与下丈世丐丌丛丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄与下丈世丐丌丛丝 != 1152921526209076448);
    
    }
    internal void 丏一上专万丄丘万丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.七丒且世业丘世丒丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七丒且世业丘世丒丑 != 1152921526209213032);
    
    }
    internal void 丂上丏三丝东丆丆万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.七丒且世业丘世丒丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七丒且世业丘世丒丑 != 1152921526209349608);
    
    }
    internal void 丌丈上下丅三丙丐与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗丗丈丆上丏万三丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丗丈丆上丏万三丕 != 1152921526209486192);
    
    }
    internal void 丞丟不丝丌且与丛丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗丗丈丆上丏万三丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丗丈丆上丏万三丕 != 1152921526209622768);
    
    }
    public PGCompany.丕下丆丑万世业丈丟 get_ItemEgg()
    {
        return (PGCompany.丕下丆丑万世业丈丟)this.丄丈世业七丐三上东;
    }
    public PGCompany.上丕一与丕丏丟丂东 get_HatchResult()
    {
        return (PGCompany.上丕一与丕丏丟丂东)this.三丗下丕丕下丑丁丙;
    }
    public PGCompany.世丒丗丅丛丕不万丂 get_CurrentPetItem()
    {
        return (PGCompany.世丒丗丅丛丕不万丂)this.丟丅丆丘七丞东丁丝;
    }
    public PGCompany.三东丏不丗世丅丌丄 get_CurrentPetParams()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.丈与丁丄不丗七丌万;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trainingHintAccept, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eggViewHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petViewHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eggHatchResultView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hatchButton, 丏业丟一东丂东丘丛:  true);
        this.丄丈世业七丐三上东 = 世丕丘丈丙世业东丕;
        this.丕丒丐丁丗丗东丐丗();
        if(this.eggItemView != null)
        {
                this.eggItemView.Setup(与且专丈不万东一万:  this.丄丈世业七丐三上东);
        }
        
        if(this.丄丈世业七丐三上东.三七世丌专丆与丄世() == null)
        {
                return;
        }
        
        this.七丅丄丞丞丄丈专丝.eggRenderer.material.mainTexture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Rilisoft.EggsManager.与不丛丛业丁七丏丛(三万万丒丏丒不丐丙:  this.丄丈世业七丐三上东.三七世丌专丆与丄世()));
    }
    internal void 业专丌业七丐丞一专(PGCompany.丟丌专丘下丘七丈东 业下丘丗丌东丈不丒)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hatchButton, 丏业丟一东丂东丘丛:  false);
        if(业下丘丗丌东丈不丒 == 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_1 = this.丄丈世业七丐三上东.三丌世丕下丌业丕一();
        }
        
        this.三丗下丕丕下丑丁丙 = this.丄丈世业七丐三上东.业专丌业七丐丞一专(世不丈万丛世且下三:  new PGCompany.丝不丅丗丄丄与丌丘() {丌万丑丟上七丐丐丕 = 业下丘丗丌东丈不丒, 专丈丟上丈丁丛七丒 = this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂()});
        if(this.与丝丐丛丘且丝且丟 != null)
        {
                this.与丝丐丛丘且丝且丟.Invoke();
        }
        
        this.七丅丄丞丞丄丈专丝.eggAnimator.SetBool(name:  "Open", value:  true);
        UnityEngine.Coroutine val_5 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void HatchPetView::丆与与丌丅丐丒丌专()), 丆丐七丅丆丗丛上与:  this.hatchEggAnimDuration);
    }
    private void 丟且丈丐丄丞丞丂且(PGCompany.三东丏不丗世丅丌丄 七万专与且丒丝万丁)
    {
        this.丏丄丈丞丐丁丑丙丐 = false;
        this.丈与丁丄不丗七丌万 = 七万专与且丒丝万丁;
        this.丟丅丆丘七丞东丁丝 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.世丒丗丅丛丕不万丂>(丈丄不七三万丄丁不:  七万专与且丒丝万丁);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eggViewHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petViewHolder, 丏业丟一东丂东丘丛:  true);
        this.丗七丌丑业丞丒三七();
        this.丞业一世与丅不专丛();
        if(this.丂丙专丐专丘丏丛丂 == null)
        {
                return;
        }
        
        this.丂丙专丐专丘丏丛丂.Invoke();
    }
    private void 丏丞专七丘丐丞东七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petViewHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eggHatchResultView, 丏业丟一东丂东丘丛:  true);
        this.eggHatchResultView.丈且东丑丂且万丒丅(丝丄丞且与丕不上丑:  this.三丗下丕丕下丑丁丙);
        if(this.七丒且世业丘世丒丑 == null)
        {
                return;
        }
        
        this.七丒且世业丘世丒丑.Invoke();
    }
    private void 丞业一世与丅不专丛()
    {
        UnityEngine.GameObject val_23;
        PGCompany.世丒丗丅丛丕不万丂 val_24;
        PGCompany.世丒丗丅丛丕不万丂 val_25;
        UIInput val_26;
        var val_27;
        val_23 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeParticles, 丏业丟一东丂东丘丛:  false);
        if(this.丈与丁丄不丗七丌万 == null)
        {
                return;
        }
        
        if(this.丟丅丆丘七丞东丁丝 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  this.丟丅丆丘七丞东丁丝);
        this.petNameInput.value = this.丟丅丆丘七丞东丁丝.专三丏丏东丌七丅且();
        if(this.petItemView != null)
        {
                this.petItemView.Setup(丈丄不七三万丄丁不:  this.丈与丁丄不丗七丌万);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rareLabel, 丕丗丘丑丛与丑业丒:  this.丟丅丆丘七丞东丁丝.与一专丗丅且丟丛丞());
        UnityEngine.Color val_3 = this.丟丅丆丘七丞东丁丝.丝一丙丝上丛三丄丈();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.rareLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        int val_4 = this.丟丅丆丘七丞东丁丝.一丙专七下万七丅世();
        this.upgradeBar_NewValue.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_4, 七丝东丛东丝且丆不:  (float)this.丟丅丆丘七丞东丁丝.丅丏下丕丛丛与丆丌(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.newPointCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "X{0}", arg0:  this.丈与丁丄不丗七丌万.丂丁丏一丙丛业且丌()));
        this.upgradeBar_OldView.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_4 - this.丈与丁丄不丗七丌万.丂丁丏一丙丛业且丌(), 七丝东丛东丝且丆不:  (float)this.丟丅丆丘七丞东丁丝.丅丏下丕丛丛与丆丌(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = false}, 下三丝东东且且且丙:  0);
        if(this.丏丄丈丞丐丁丑丙丐 != false)
        {
                this.upgradeBar_OldView.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_4, 七丝东丛东丝且丆不:  (float)this.丟丅丆丘七丞东丁丝.丅丏下丕丛丛与丆丌(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.newPointCountLabel, 丕丗丘丑丛与丑业丒:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeParticles, 丏业丟一东丂东丘丛:  true);
        }
        
        bool val_10 = this.丟丅丆丘七丞东丁丝.不且丅丏丁世上丙丁();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnMaxLevel, 丏业丟一东丂东丘丛:  val_10);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnMaxLevel, 丏业丟一东丂东丘丛:  (~val_10) & 1);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.curLvlLabel, 丕丗丘丑丛与丑业丒:  this.丟丅丆丘七丞东丁丝.丁丕丁三丁丗不三丟());
        val_24 = this.丟丅丆丘七丞东丁丝;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nexLvlLabel, 丕丗丘丑丛与丑业丒:  val_24.万丑丗丗万丕丏丝与());
        if((val_10 != false) && (this.compensationItemView != null))
        {
                val_24 = this.丈与丁丄不丗七丌万.丂丁丏一丙丛业且丌();
            this.compensationItemView.Setup(丈丄不七三万丄丁不:  this.丟丅丆丘七丞东丁丝.世与丄三业丐丙丘丕(丒七且一东丂丐丛丒:  val_24));
        }
        
        bool val_22 = this.丟丅丆丘七丞东丁丝.丛不东三一上丈世丛();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfCanUpgrade, 丏业丟一东丂东丘丛:  val_22);
        val_22 = (~val_22) & 1;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableIfCanUpgrade, 丏业丟一东丂东丘丛:  val_22);
        if((val_22 & 1) == 0)
        {
                this.upagradePrice.Setup(丈丄不七三万丄丁不:  this.丟丅丆丘七丞东丁丝.且与丏三不丟丂丙丏());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeButton, 丏业丟一东丂东丘丛:  true);
        }
        
        val_25 = this.丟丅丆丘七丞东丁丝;
        if(val_25.丁丕丁三丁丗不三丟() != 1)
        {
            goto label_44;
        }
        
        val_25 = this.丈与丁丄不丗七丌万;
        if(val_4 != val_25.丂丁丏一丙丛业且丌())
        {
            goto label_44;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.titleHolder, 丏业丟一东丂东丘丛:  false);
        val_26 = this.petNameInput;
        val_27 = 1;
        goto label_47;
        label_44:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.titleHolder, 丏业丟一东丂东丘丛:  true);
        val_26 = this.petNameInput;
        val_27 = 0;
        label_47:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_26, 丏业丟一东丂东丘丛:  false);
        val_23 = this.trainingHintAccept;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  false);
    }
    private void 丕丒丐丁丗丗东丐丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eggExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.七丅丄丞丞丄丈专丝, 丏业丟一东丂东丘丛:  false);
        if(this.七丅丄丞丞丄丈专丝 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.七丅丄丞丞丄丈专丝.gameObject);
        }
        
        HatchingEggRefsHolder val_5 = UnityEngine.Object.Instantiate<HatchingEggRefsHolder>(original:  this.eggExample, parent:  this.eggExample.transform.parent);
        this.七丅丄丞丞丄丈专丝 = val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
    }
    private void 丗七丌丑业丞丒三七()
    {
        if(this.一丏丞丄不丅丗丒丑 != 0)
        {
                this.petProfileAnimationRunner.StopAllCoroutines();
            UnityEngine.Object.Destroy(obj:  this.一丏丞丄不丅丗丒丑);
        }
        
        if(this.丟丅丆丘七丞东丁丝 == null)
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<Rilisoft.PetEngine>(path:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丘丕丂万丝丁丌丞业(世丐丗专丅三丝丑丆:  this.丟丅丆丘七丞东丁丝.业上丙丞丐丄丆丅七())).下七丏不丒丗业丛专(), parent:  this.petObjectHolder);
        this.一丏丞丄不丅丗丒丑 = val_7;
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_7.transform);
        PetInfo val_11 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丟丅丆丘七丞东丁丝.业上丙丞丐丄丆丅七());
        if(val_11.Behaviour != 0)
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.35f);
        }
        else
        {
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        }
        
        this.一丏丞丄不丅丗丒丑.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        UnityEngine.Transform val_16 = this.一丏丞丄不丅丗丒丑.transform;
        UnityEngine.Vector3 val_17 = val_16.localScale;
        UnityEngine.Vector3 val_18 = val_11.PositionInBanners;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  3f / val_18.z);
        val_16.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_22 = val_11.RotationInBanners;
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        this.一丏丞丄不丅丗丒丑.transform.localRotation = new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w};
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.一丏丞丄不丅丗丒丑, 不东丛三丂丌丑专丆:  this.petObjectHolder.gameObject.layer);
        this.专东丁丙丞丂东丝丁(丞下丂丝丁丏丛丌世:  this.一丏丞丄不丅丗丒丑);
    }
    private void 专东丁丙丞丂东丝丁(UnityEngine.GameObject 丞下丂丝丁丏丛丌世)
    {
        UnityEngine.Animation val_11;
        System.Object[] val_12 = this;
        if(丞下丂丝丁丏丛丌世 == 0)
        {
                return;
        }
        
        if(上丑三丁丄丛丁万丑.东丅三丏丂丞下上丑() == true)
        {
                return;
        }
        
        val_11 = 丞下丂丝丁丏丛丌世.GetComponent<UnityEngine.Animation>();
        this.petProfileAnimationRunner.StopAllCoroutines();
        if((val_11.GetClip(name:  "Profile")) == 0)
        {
                object[] val_6 = new object[1];
            val_12 = val_6;
            val_12[0] = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  丞下丂丝丁丏丛丌世);
            UnityEngine.Debug.LogErrorFormat(format:  "Error: pet {0} has no Profile animation clip (EggHatchingWindowController)", args:  val_6);
            return;
        }
        
        if(this.petProfileAnimationRunner.gameObject.activeInHierarchy != false)
        {
                val_12 = this.petProfileAnimationRunner;
            val_12.StartPlay(丆不丝丝上一丞七业:  val_11, 七不丐下丟专业万丅:  "Profile", 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  0);
            return;
        }
        
        val_12 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Coroutine couldn\'t be started because the the game object \'AnimationCoroutineRunner\' is inactive! (Pet)", args:  val_12);
    }
    public void U_Hatch()
    {
        this.业专丌业七丐丞一专(业下丘丗丌东丈不丒:  0);
    }
    public void U_UpgradePet()
    {
        HatchEggUI val_7;
        PGCompany.三东丏不丗世丅丌丄 val_8;
        val_7 = this;
        val_8 = this.丟丅丆丘七丞东丁丝.且与丏三不丟丂丙丏();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_8, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false})) != false)
        {
                val_8 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            val_8.专业丘丘且丌丕丐上(业丟丙丝丗万丗七上:  this.丟丅丆丘七丞东丁丝, 丒世丘丘上丆丝东丞:  this.丟丅丆丘七丞东丁丝.且与丏三不丟丂丙丏());
            this.丏丄丈丞丐丁丑丙丐 = true;
            this.丞业一世与丅不专丛();
            if(this.丝七万丛丆丟丏丂丑 == null)
        {
                return;
        }
        
            this.丝七万丛丆丟丏丂丑.Invoke();
            return;
        }
        
        val_7 = this.hatchEggUI;
        val_7.万丞丌七丈丄丙东万(与专丁丈丆丌丐丌丝:  this.丟丅丆丘七丞东丁丝.且与丏三不丟丂丙丏(), 丙丙专丝专上丅丛丏:  true);
    }
    public void U_CollectPet()
    {
        this.丟丅丆丘七丞东丁丝.下丘丞丙丛丙丙丄与(丒丘丏上丙丟丑丕丈:  this.petNameInput.value);
        if(this.丄与下丈世丐丌丛丝 != null)
        {
                this.丄与下丈世丐丌丛丝.Invoke();
        }
        
        int val_9 = this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕().IndexOf(item:  this.丈与丁丄不丗七丌万);
        val_9 = val_9 + 1;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6 = this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕();
        if(val_9 < this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕().Count)
        {
                this.丟且丈丐丄丞丞丂且(七万专与且丒丝万丁:  val_6.Item[val_9]);
            return;
        }
        
        if(val_6.Count < 2)
        {
                if(this.丗丗丈丆上丏万三丕 == null)
        {
                return;
        }
        
            this.丗丗丈丆上丏万三丕.Invoke();
            return;
        }
        
        this.丏丞专七丘丐丞东七();
    }
    public void U_HatchEnd()
    {
        if(this.丗丗丈丆上丏万三丕 == null)
        {
                return;
        }
        
        this.丗丗丈丆上丏万三丕.Invoke();
    }
    public HatchPetView()
    {
        this.hatchEggAnimDuration = 1f;
    }
    private void 丆与与丌丅丐丒丌专()
    {
        if((this == 0) || (this.gameObject.activeInHierarchy == false))
        {
            goto label_5;
        }
        
        if(((this.三丗下丕丕下丑丁丙 == null) || (this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕() == null)) || (this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕().Count == 0))
        {
            goto label_10;
        }
        
        this.丟且丈丐丄丞丞丂且(七万专与且丒丝万丁:  this.三丗下丕丕下丑丁丙.丐丁东丛丙丙丛丑丕().Item[0]);
        return;
        label_5:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Hatch Interapred");
        return;
        label_10:
        if(this.丗丗丈丆上丏万三丕 == null)
        {
                return;
        }
        
        this.丗丗丈丆上丏万三丕.Invoke();
    }

}
