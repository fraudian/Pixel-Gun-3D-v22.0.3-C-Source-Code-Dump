using UnityEngine;
internal class LootBoxUI : PGBehaviour
{
    // Fields
    private System.Action 三丏七丈丆丂丟丈丆;
    private System.Action 丛丙丟丈业丁丌东丌;
    private System.Action 丙一丄丞三世丈业世;
    private System.Action 世丅丙世不三丈世丅;
    private System.Action 丛且东丘丌丟丕丗丌;
    private System.Action 不丞三上不三与丞丏;
    private System.Action 丁丕丏丆专东七丌丄;
    protected System.IDisposable 专丏业专不丂一丂丛;
    private PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丞七与丌丘不不丈专;
    internal GuiApplyersGroup guiApplyersGroup;
    private System.Collections.Generic.List<UnityEngine.Renderer> backgroundRenderers;
    private System.Collections.Generic.List<UIBasicSprite> backgroundTextures;
    protected System.Collections.Generic.List<UnityEngine.GameObject> backButtons;
    internal LootBoxRewardsView rewardsView_Default;
    internal LootBoxRewardsView rewardsView_Roulette;
    internal LootBoxRewardsView 不丌丘丘丅业丟丗丝;
    
    // Properties
    public PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丆丂丙万丕丑丞丞丙 { get; }
    internal bool 不丑业一丐丝丈丞丕 { get; }
    internal PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 丈丒专且丙丏丁丗丙 { get; }
    
    // Methods
    public void add_onCurrentViewSetup(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三丏七丈丆丂丟丈丆, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丏七丈丆丂丟丈丆 != 1152921537727531752);
    
    }
    public void remove_onCurrentViewSetup(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三丏七丈丆丂丟丈丆, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丏七丈丆丂丟丈丆 != 1152921537727668328);
    
    }
    public void add_onChestOpen(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丙丟丈业丁丌东丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丙丟丈业丁丌东丌 != 1152921537727804912);
    
    }
    public void remove_onChestOpen(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丙丟丈业丁丌东丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丙丟丈业丁丌东丌 != 1152921537727941488);
    
    }
    public void add_onAnimationStart(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丙一丄丞三世丈业世 != 1152921537728078072);
    
    }
    public void remove_onAnimationStart(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丙一丄丞三世丈业世 != 1152921537728214648);
    
    }
    public void add_onAnimationFinish(System.Action 丙业与丙丗丝不丈东)
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
        while(this.世丅丙世不三丈世丅 != 1152921537728351232);
    
    }
    public void remove_onAnimationFinish(System.Action 丙业与丙丗丝不丈东)
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
        while(this.世丅丙世不三丈世丅 != 1152921537728487808);
    
    }
    public void add_onCollectRewards(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丛且东丘丌丟丕丗丌 != 1152921537728624392);
    
    }
    public void remove_onCollectRewards(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丛且东丘丌丟丕丗丌 != 1152921537728760968);
    
    }
    public void add_onBackPressed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.不丞三上不三与丞丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不丞三上不三与丞丏 != 1152921537728897552);
    
    }
    public void remove_onBackPressed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.不丞三上不三与丞丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不丞三上不三与丞丏 != 1152921537729034128);
    
    }
    public void add_onOnShowHistory(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丁丕丏丆专东七丌丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁丕丏丆专东七丌丄 != 1152921537729170712);
    
    }
    public void remove_onOnShowHistory(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丁丕丏丆专东七丌丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁丕丏丆专东七丌丄 != 1152921537729307288);
    
    }
    public PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 get_ChestProvider()
    {
        return (PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三)this.丞七与丌丘不不丈专;
    }
    internal bool 世丗丆丗三丏丐丐丑()
    {
        LootBoxRewardsView val_3;
        var val_4;
        val_3 = this;
        if(this.不丌丘丘丅业丟丗丝 == 0)
        {
                val_4 = 0;
            return (bool)(this.不丌丘丘丅业丟丗丝.万丝专丌丌三丟丆丄 == true) ? 1 : 0;
        }
        
        val_3 = this.不丌丘丘丅业丟丗丝;
        return (bool)(this.不丌丘丘丅业丟丗丝.万丝专丌丌三丟丆丄 == true) ? 1 : 0;
    }
    internal PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 丝丌上丙丁东丆丞丑()
    {
        LootBoxRewardsView val_2;
        PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙 val_3;
        val_2 = this;
        val_3 = 0;
        if(this.不丌丘丘丅业丟丗丝 == 0)
        {
                return (PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙)val_3;
        }
        
        if((this.不丌丘丘丅业丟丗丝.<世七丐与东下与丞业>k__BackingField) != null)
        {
                val_2 = this.不丌丘丘丅业丟丗丝;
            val_3 = this.不丌丘丘丅业丟丗丝.<世七丐与东下与丞业>k__BackingField;
            return (PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙)val_3;
        }
        
        val_3 = 0;
        return (PGCompany.LootBoxSystem.丗丕丙丟丐三丘丌丙)val_3;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        var val_14;
        var val_29;
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        if(this.guiApplyersGroup == 0)
        {
            goto label_8;
        }
        
        if((下下丈一业上万丏丕.丑丑丒与丙丂世丘丛(七丆丒与丗丌丄且丂:  "LootBoxStyle", 丒丑丞丁世丌专不丈:  一与且丐丝丘与丆丑.丟不丛丑一丗丄业丟().丌丏丈丗丌不七与不())) != false)
        {
                string val_11 = 一与且丐丝丘与丆丑.丟不丛丑一丗丄业丟().丌丏丈丗丌不七与不();
            if(this.guiApplyersGroup != null)
        {
            goto label_15;
        }
        
        }
        
        label_15:
        label_8:
        List.Enumerator<T> val_12 = this.backgroundRenderers.GetEnumerator();
        label_30:
        if(((-1236645584) & 1) == 0)
        {
            goto label_18;
        }
        
        string val_15 = val_14.丐丏七丌丕丗业且上();
        if((val_15 == 0) || (val_15.material == 0))
        {
            goto label_30;
        }
        
        val_15.sharedMaterial.mainTexture = 一与且丐丝丘与丆丑.丟不丛丑一丗丄业丟().丕东三上且且丕下世();
        goto label_30;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_22 = this.backgroundTextures.GetEnumerator();
        label_48:
        if(((-1236645616) & 1) == 0)
        {
            goto label_42;
        }
        
        string val_23 = val_14.丐丏七丌丕丗业且上();
        if(val_23 == null)
        {
            goto label_48;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_23, 与万丆丛丒万丝丙丑:  一与且丐丝丘与丆丑.丟不丛丑一丗丄业丟().丕东三上且且丕下世());
        goto label_48;
        label_42:
        val_29 = public System.Void List.Enumerator<UIBasicSprite>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丞七与丌丘不不丈专 = 一与且丐丝丘与丆丑;
        this.不丌丘丘丅业丟丗丝 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.不丌丘丘丅业丟丗丝, 丏业丟一东丂东丘丛:  true);
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_26 = this.丞七与丌丘不不丈专.丏丘下丞丘不丑万丏();
        if(val_26.一万丕丑世丆七丟世 != false)
        {
                this.一万丕丑世丆七丟世();
        }
        
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_27 = this.丞七与丌丘不不丈专.丏丘下丞丘不丑万丏();
        if(val_27.丗不丙丌丐世丛世丗 == false)
        {
                return;
        }
    
    }
    protected virtual void OnDestroy()
    {
        goto typeof(LootBoxUI).__il2cppRuntimeField_198;
    }
    protected virtual void 丑丏上丈丒丂且丞丛()
    {
        if(this.不丌丘丘丅业丟丗丝 == 0)
        {
                return;
        }
        
        this.不丌丘丘丅业丟丗丝.丅与丆上东下丏丑世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1D0));
        this.不丌丘丘丅业丟丗丝.不丂业丆下不丗万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1E0));
        this.不丌丘丘丅业丟丗丝.丗上与丕下丂上丂七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1F0));
        this.不丌丘丘丅业丟丗丝.东丟丑丙不丌丝丄且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_200));
        this.不丌丘丘丅业丟丗丝.不业七且丁丌丒丄丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_210));
    }
    protected virtual void 丌丞下万丈丒丑万丅()
    {
        if(this.不丌丘丘丅业丟丗丝 == 0)
        {
                return;
        }
        
        this.不丌丘丘丅业丟丗丝.丁世万丌丄且丌丅丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1D0));
        this.不丌丘丘丅业丟丗丝.丑丂丁丘且万东丙东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1E0));
        this.不丌丘丘丅业丟丗丝.业且丒上三丅丆丌一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_1F0));
        this.不丌丘丘丅业丟丗丝.丟丝丐专丁丈丄一丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_200));
        this.不丌丘丘丅业丟丗丝.专三丘一三丆一万不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI).__il2cppRuntimeField_210));
    }
    internal virtual void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsView_Default, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsView_Roulette, 丏业丟一东丂东丘丛:  false);
    }
    protected virtual LootBoxRewardsView 丞丙东丐与丅丅与一()
    {
        if(this.丞七与丌丘不不丈专.丟不丛丑一丗丄业丟().专万丙丆世三世丗七() != 2)
        {
                return this.rewardsView_Default;
        }
        
        this.rewardsView_Default = this.rewardsView_Roulette;
        return this.rewardsView_Default;
    }
    protected void 一万丕丑世丆七丟世()
    {
        this.丁丅丟丆丂丗专丕丄();
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "LootBoxUI_DisableBack");
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.backButtons, 丏业丟一东丂东丘丛:  false);
    }
    protected void 丁丅丟丆丂丗专丕丄()
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.backButtons, 丏业丟一东丂东丘丛:  true);
    }
    protected virtual void 万上与丁丏丛业丗业()
    {
        if(this.三丏七丈丆丂丟丈丆 == null)
        {
                return;
        }
        
        this.三丏七丈丆丂丟丈丆.Invoke();
    }
    protected virtual void 丄丐东且丁丟七东不()
    {
        if(this.丛丙丟丈业丁丌东丌 == null)
        {
                return;
        }
        
        this.丛丙丟丈业丁丌东丌.Invoke();
    }
    protected virtual void 丗丒丏丁丂丁七一丒()
    {
        if(this.丙一丄丞三世丈业世 == null)
        {
                return;
        }
        
        this.丙一丄丞三世丈业世.Invoke();
    }
    protected virtual void 三七不丂丂东丈丙丄()
    {
        if(this.世丅丙世不三丈世丅 == null)
        {
                return;
        }
        
        this.世丅丙世不三丈世丅.Invoke();
    }
    protected virtual void 三丑丆七上丑丅不三()
    {
        this.丁丅丟丆丂丗专丕丄();
        if(this.丛且东丘丌丟丕丗丌 != null)
        {
                this.丛且东丘丌丟丕丗丌.Invoke();
        }
        
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_1 = this.丞七与丌丘不不丈专.丏丘下丞丘不丑万丏();
        if(val_1.且丞丁丌万专万丝东 == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(LootBoxUI).__il2cppRuntimeField_238;
    }
    public virtual void OpenChest()
    {
        this.丁丅丟丆丂丗专丕丄();
        if(this.不丌丘丘丅业丟丗丝 == null)
        {
            
        }
    
    }
    public virtual void CollectRewards()
    {
        if(this.不丌丘丘丅业丟丗丝 == null)
        {
            
        }
    
    }
    public virtual void U_Back()
    {
        if(this.不丞三上不三与丞丏 == null)
        {
                return;
        }
        
        this.不丞三上不三与丞丏.Invoke();
    }
    public virtual void U_ShowDropHistory()
    {
        if(this.不丌丘丘丅业丟丗丝 == null)
        {
                return;
        }
        
        goto typeof(LootBoxRewardsView).__il2cppRuntimeField_228;
    }
    public virtual void U_HideDropHistory()
    {
        if(this.不丌丘丘丅业丟丗丝 == null)
        {
                return;
        }
        
        goto typeof(LootBoxRewardsView).__il2cppRuntimeField_238;
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
    
    }
    public void U_ShowProgressRoad()
    {
        ProgressRoad.丁丒丛丆与七丟丗丙.丄丄业世业丈丒丁万(丂世且丙丅丘不七丑:  0, 丏丆丅且上丅上丌丘:  0, 丘丒丅三丞丞丛丛丌:  0);
    }
    public LootBoxUI()
    {
    
    }

}
