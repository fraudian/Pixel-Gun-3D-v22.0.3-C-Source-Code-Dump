using UnityEngine;
internal class LootBoxRewardsView : PGBehaviour
{
    // Fields
    private static System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丕丈丘丞专丁业丏七;
    private static System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丏丗与三丟与上丄丝;
    private static System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丛七下业不丈不一业;
    private static System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 专丐东万三丒东丞万;
    private System.Action 丁与下万丄丑丐丗丐;
    private System.Action 丈一丞丝丁且丗丘万;
    private System.Action 丙一丄丞三世丈业世;
    private System.Action 世丅丙世不三丈世丅;
    private System.Action 丛且东丘丌丟丕丗丌;
    private System.Action 丙业丑丙丆七丗世丕;
    private System.Action 丙世丙三丌丂丄七丁;
    private System.Action 丐不与七东万丗专丂;
    private System.Collections.Generic.List<LootBoxUI_Listener> listeners;
    private bool 万丝专丌丌三丟丆丄;
    protected ItemLootBoxView lootBoxItemView;
    protected MiniPoolMonoBehaviour repeatedRewardViewPool;
    protected System.Collections.Generic.List<UnityEngine.GameObject> allRewardsViewHolder;
    protected GuiApplyersGroup guiApplyersGroup;
    protected UnityEngine.AudioClip onSetupClip;
    protected UnityEngine.AudioClip onOpenChestClip;
    protected UnityEngine.AudioClip onAnimationStartClip;
    protected UnityEngine.AudioClip onAnimationFinishClip;
    protected UnityEngine.AudioClip onCollectRewardsClip;
    protected System.Collections.Generic.List<LootBoxRewardView> 丞不丈世丟丏下丒丕;
    private PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丞七与丌丘不不丈专;
    private PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 <世七丐与东下与丞业>k__BackingField;
    private int 丘三丐丂丈丅丅丌丆;
    private bool 丈丞丆丂三丆丒丁丘;
    private UnityEngine.Coroutine 丈专丛丞万世丕丞丄;
    
    // Properties
    internal bool 不丑业一丐丝丈丞丕 { get; }
    internal PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丆丂丙万丕丑丞丞丙 { get; }
    internal PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 丈丒专且丙丏丁丗丙 { get; set; }
    
    // Methods
    internal static void 丝丘七丄丒七东丛丒(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  LootBoxRewardsView.丕丈丘丞专丁业丏七, b:  丙业与丙丗丝不丈东);
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
    internal static void 丟丘丞与丆东下一丝(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  LootBoxRewardsView.丕丈丘丞专丁业丏七, value:  丙业与丙丗丝不丈东);
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
    internal static void 与一丟丄丆丘一丘丌(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LootBoxRewardsView.丏丗与三丟与上丄丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.丏丗与三丟与上丄丝 != 1152921505200779272);
    
    }
    internal static void 丂丅上丟丂七丌万丄(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LootBoxRewardsView.丏丗与三丟与上丄丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.丏丗与三丟与上丄丝 != 1152921505200779272);
    
    }
    internal static void 丕丆世丂丅丌丌丕三(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LootBoxRewardsView.丛七下业不丈不一业, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.丛七下业不丈不一业 != 1152921505200779280);
    
    }
    internal static void 专丈一东丝丑三丕丕(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LootBoxRewardsView.丛七下业不丈不一业, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.丛七下业不丈不一业 != 1152921505200779280);
    
    }
    internal static void 丟丏丄丞丗三丞与丙(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LootBoxRewardsView.专丐东万三丒东丞万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.专丐东万三丒东丞万 != 1152921505200779288);
    
    }
    internal static void 丏丞一丈一丞丂世丈(System.Action<PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LootBoxRewardsView.专丐东万三丒东丞万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LootBoxRewardsView.专丐东万三丒东丞万 != 1152921505200779288);
    
    }
    internal void 丅与丆上东下丏丑世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丁与下万丄丑丐丗丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁与下万丄丑丐丗丐 != 1152921537710469720);
    
    }
    internal void 丁世万丌丄且丌丅丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丁与下万丄丑丐丗丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁与下万丄丑丐丗丐 != 1152921537710606296);
    
    }
    internal void 不丂业丆下不丗万丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈一丞丝丁且丗丘万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈一丞丝丁且丗丘万 != 1152921537710742880);
    
    }
    internal void 丑丂丁丘且万东丙东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈一丞丝丁且丗丘万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈一丞丝丁且丗丘万 != 1152921537710879456);
    
    }
    internal void 丗上与丕下丂上丂七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙一丄丞三世丈业世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙一丄丞三世丈业世 != 1152921537711016040);
    
    }
    internal void 业且丒上三丅丆丌一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙一丄丞三世丈业世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙一丄丞三世丈业世 != 1152921537711152616);
    
    }
    internal void 东丟丑丙不丌丝丄且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.世丅丙世不三丈世丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丅丙世不三丈世丅 != 1152921537711289200);
    
    }
    internal void 丟丝丐专丁丈丄一丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.世丅丙世不三丈世丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丅丙世不三丈世丅 != 1152921537711425776);
    
    }
    internal void 不业七且丁丌丒丄丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛且东丘丌丟丕丗丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛且东丘丌丟丕丗丌 != 1152921537711562360);
    
    }
    internal void 专三丘一三丆一万不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛且东丘丌丟丕丗丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛且东丘丌丟丕丗丌 != 1152921537711698936);
    
    }
    internal void 一丗丏专丐丟丂丑且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙业丑丙丆七丗世丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙业丑丙丆七丗世丕 != 1152921537711835520);
    
    }
    internal void 丌不丙东丛丈丌丂与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙业丑丙丆七丗世丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙业丑丙丆七丗世丕 != 1152921537711972096);
    
    }
    internal void 丒丑丁丛丕丕不下一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙世丙三丌丂丄七丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙世丙三丌丂丄七丁 != 1152921537712108680);
    
    }
    internal void 丗丟且丐丕丈丁丅丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙世丙三丌丂丄七丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙世丙三丌丂丄七丁 != 1152921537712245256);
    
    }
    internal void 丒丟三丛丑丟丗一业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐不与七东万丗专丂, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐不与七东万丗专丂 != 1152921537712381840);
    
    }
    internal void 丆且丂丒丗不丕丟丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐不与七东万丗专丂, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐不与七东万丗专丂 != 1152921537712518416);
    
    }
    internal bool 世丗丆丗三丏丐丐丑()
    {
        return (bool)this.万丝专丌丌三丟丆丄;
    }
    internal PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 与万丐丕丒且丝一丗()
    {
        return (PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三)this.丞七与丌丘不不丈专;
    }
    internal PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 丝丌上丙丁东丆丞丑()
    {
        return (PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙)this.<世七丐与东下与丞业>k__BackingField;
    }
    private void 丆丁丆丅丐丅丅丙丆(PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 丙业与丙丗丝不丈东)
    {
        this.<世七丐与东下与丞业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        var val_3;
        UnityEngine.MonoBehaviour val_7;
        var val_8;
        var val_9;
        if(this.listeners == null)
        {
            goto label_12;
        }
        
        List.Enumerator<T> val_1 = this.listeners.GetEnumerator();
        label_7:
        if(((-1253440304) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((val_4 == 0) || (val_4 != null))
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        val_8 = public System.Void List.Enumerator<LootBoxUI_Listener>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_12:
        if(this.repeatedRewardViewPool != null)
        {
                val_7 = this.repeatedRewardViewPool.example;
            val_8 = 0;
            val_9 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丞七与丌丘不不丈专 = 一与且丐丝丘与丆丑;
        if(this.丁与下万丄丑丐丗丐 != null)
        {
                this.丁与下万丄丑丐丗丐.Invoke();
        }
        
        if(LootBoxRewardsView.丕丈丘丞专丁业丏七 == null)
        {
                return;
        }
        
        LootBoxRewardsView.丕丈丘丞专丁业丏七.Invoke(obj:  this.丞七与丌丘不不丈专);
    }
    internal virtual void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.allRewardsViewHolder, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丞不丈世丟丏下丒丕.GetEnumerator();
        label_9:
        if(((-1253258664) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        this.repeatedRewardViewPool.Return(万且万且丑丗且丌丆:  val_2);
        val_2.transform.SetParent(p:  this.repeatedRewardViewPool.transform);
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丞不丈世丟丏下丒丕.Clear();
    }
    protected virtual LootBoxRewardView 且专且丙丐且丟丐丙(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 万不丛丅丒丌丌丛丟)
    {
        LootBoxRewardView val_1 = this.repeatedRewardViewPool.Get<LootBoxRewardView>();
        this.丞不丈世丟丏下丒丕.Add(item:  val_1);
        val_1.丈且东丑丂且万丒丅(丆丈丑丅东丙丘三且:  万不丛丅丒丌丌丛丟);
        val_1.name = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  万不丛丅丒丌丌丛丟.三东丏不丗世丅丌丄);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
        return val_1;
    }
    internal virtual void 丌丟丆不丄专丐不丂()
    {
        this.<世七丐与东下与丞业>k__BackingField = this.丞七与丌丘不不丈专.丌万丗与七丄丕不丁();
        if(this.丈一丞丝丁且丗丘万 != null)
        {
                this.丈一丞丝丁且丗丘万.Invoke();
        }
        
        if(LootBoxRewardsView.丏丗与三丟与上丄丝 != null)
        {
                LootBoxRewardsView.丏丗与三丟与上丄丝.Invoke(obj:  this.丞七与丌丘不不丈专);
        }
        
        this.丘三丐丂丈丅丅丌丆 = 5;
        this.丈丞丆丂三丆丒丁丘 = true;
    }
    private void Update()
    {
        int val_1 = this.丘三丐丂丈丅丅丌丆;
        val_1 = val_1 - 1;
        this.丘三丐丂丈丅丅丌丆 = val_1;
        if((val_1 & 2147483648) == 0)
        {
                return;
        }
        
        if(this.丈丞丆丂三丆丒丁丘 == false)
        {
                return;
        }
        
        this.丈丞丆丂三丆丒丁丘 = false;
        this.丕万丑东丝丅丘丄上();
    }
    private void 丕万丑东丝丅丘丄上()
    {
        if(this.lootBoxItemView != null)
        {
            
        }
    
    }
    protected virtual void 东丒丝丙三丑下万丆()
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_1;
        this.万丝专丌丌三丟丆丄 = true;
        if(this.丙一丄丞三世丈业世 != null)
        {
                val_1 = 0;
            this.丙一丄丞三世丈业世.Invoke();
        }
        
        if(LootBoxRewardsView.丛七下业不丈不一业 != null)
        {
                val_1 = this.丞七与丌丘不不丈专;
            LootBoxRewardsView.丛七下业不丈不一业.Invoke(obj:  val_1);
        }
    
    }
    protected virtual void 丄丛丘且丑丄万丈丙()
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_1;
        this.万丝专丌丌三丟丆丄 = false;
        if(this.世丅丙世不三丈世丅 != null)
        {
                val_1 = 0;
            this.世丅丙世不三丈世丅.Invoke();
        }
        
        if(LootBoxRewardsView.专丐东万三丒东丞万 != null)
        {
                val_1 = this.丞七与丌丘不不丈专;
            LootBoxRewardsView.专丐东万三丒东丞万.Invoke(obj:  val_1);
        }
    
    }
    internal virtual void 东丗丟丐丞下万且不()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.allRewardsViewHolder, 丏业丟一东丂东丘丛:  false);
        if(this.丛且东丘丌丟丕丗丌 != null)
        {
                this.丛且东丘丌丟丕丗丌.Invoke();
        }
    
    }
    protected virtual void 丈丒丟东丈七七七七()
    {
        this.丈专丛丞万世丕丞丄 = this.StartCoroutine(routine:  this);
    }
    protected virtual void 丅丂东丐丌下丟不专()
    {
        if(this.丈专丛丞万世丕丞丄 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丈专丛丞万世丕丞丄);
    }
    protected virtual System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new LootBoxRewardsView.不丙丑专丝丏丂与丝();
    }
    protected virtual void 丗丗世丘丙不世丁丅()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.allRewardsViewHolder, 丏业丟一东丂东丘丛:  true);
        if((this.<世七丐与东下与丞业>k__BackingField) == null)
        {
                return;
        }
        
        this = ???;
        goto typeof(LootBoxRewardsView).__il2cppRuntimeField_1C8;
    }
    protected virtual void 丙下丂丟丟丛上专上(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        if(丆与丈丏丟七丁东丛 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丆与丈丏丟七丁东丛);
    }
    internal virtual void 丘丌丒丁丛丕丂专东()
    {
        if(this.丙业丑丙丆七丗世丕 == null)
        {
                return;
        }
        
        this.丙业丑丙丆七丗世丕.Invoke();
    }
    internal virtual void 丐丒与丄丛丕丞丏丅()
    {
        if(this.丙世丙三丌丂丄七丁 == null)
        {
                return;
        }
        
        this.丙世丙三丌丂丄七丁.Invoke();
    }
    public LootBoxRewardsView()
    {
        this.丞不丈世丟丏下丒丕 = new System.Collections.Generic.List<LootBoxRewardView>();
    }

}
