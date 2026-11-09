using UnityEngine;
internal sealed class LootBoxRewardsView_Roulette : LootBoxRewardsView
{
    // Fields
    private System.Action 丗不东丝丑三不业丒;
    private System.Action 丏一丄丗丗丕下丘丞;
    private System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 三业不不丘丐业丝下;
    protected UnityEngine.AudioClip onSelectItemClip;
    protected UnityEngine.AudioClip onPreDropItemClip;
    protected UnityEngine.AudioClip onDropItemClip;
    public float startDelay;
    public float timeStep;
    public float finishDelay;
    public float droppedRewardShowTime;
    public float preDropTime;
    public float finalPreDropDistance;
    private LootBoxRewardView droppedRewardView;
    private LoopedScrollItemSelector itemSelector;
    public UIPanel scrollPanel;
    private UIScrollView scrollView;
    private UnityEngine.Transform scrollContent;
    private UIWrapContent wrapContent;
    private System.Collections.Generic.List<UIRect> anchoredToScrollPanel;
    private float maxScrollWidht;
    private float screenWidhtOffset;
    public float finalLapsCount;
    public float randomOffset;
    public float distanceDelta;
    public float scrollSpeed;
    public float scrollAcceleration;
    public int countForMiltipyer;
    public float deltaMiltipyer;
    private System.Collections.Generic.List<LootBoxRewardView> 丁丙丗东丗丁万丆丕;
    private float 丑专丝丙万万与丛丈;
    private LootBoxRewardView 丞下万上三丘上与专;
    private System.Nullable<UnityEngine.Vector3> 丟一丐与下丗东丄东;
    private System.Nullable<UnityEngine.Vector3> 丂丂三上下万丙业丙;
    private float 丁丝丝专丌且一且丈;
    
    // Properties
    internal float 丏丘丕丘丗丝丐专丑 { get; }
    internal float 丐业专丞丘一丒且丐 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 专一丟丆专丟一世一 { get; }
    
    // Methods
    internal void 丐丗世三丝丞专三一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不东丝丑三不业丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不东丝丑三不业丒 != this.丗不东丝丑三不业丒);
    
    }
    internal void 丝丈专且丆业一丄丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不东丝丑三不业丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不东丝丑三不业丒 != this.丗不东丝丑三不业丒);
    
    }
    internal void 且下业丝三丘丆丕丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏一丄丗丗丕下丘丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏一丄丗丗丕下丘丞 != this.丏一丄丗丗丕下丘丞);
    
    }
    internal void 丘丙丅丄丘七丘且丐(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏一丄丗丗丕下丘丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏一丄丗丗丕下丘丞 != this.丏一丄丗丗丕下丘丞);
    
    }
    internal void 丁丒丏专且丌三丞丗(System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三业不不丘丐业丝下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业不不丘丐业丝下 != this.三业不不丘丐业丝下);
    
    }
    internal void 丒丆丐丝丝丝专七丈(System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三业不不丘丐业丝下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业不不丘丐业丝下 != this.三业不不丘丐业丝下);
    
    }
    internal float 丄丌丑丘不丞东丐一()
    {
        if(true == 0)
        {
                return (float)val_2;
        }
        
        if(111576 == 0)
        {
                return (float)val_2;
        }
        
        if(111576.Count < this.countForMiltipyer)
        {
                return (float)val_2;
        }
        
        float val_2 = this.finalPreDropDistance;
        val_2 = val_2 * this.deltaMiltipyer;
        return (float)val_2;
    }
    internal float 且丘丄上丟一丌东三()
    {
        if(true == 0)
        {
                return (float)val_2;
        }
        
        if(111576 == 0)
        {
                return (float)val_2;
        }
        
        if(111576.Count < this.countForMiltipyer)
        {
                return (float)val_2;
        }
        
        float val_2 = this.distanceDelta;
        val_2 = val_2 * this.deltaMiltipyer;
        return (float)val_2;
    }
    internal PGCompany.三东丏不丗世丅丌丄 丕丟丐丈丐丄丌三丐()
    {
        if(this.itemSelector == 0)
        {
                return 0;
        }
        
        if(this.itemSelector != null)
        {
                return this.itemSelector.丕丟丐丈丐丄丌三丐();
        }
        
        return this.itemSelector.丕丟丐丈丐丄丌三丐();
    }
    private void OnEnable()
    {
        if(this.itemSelector == 0)
        {
                return;
        }
        
        this.itemSelector.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxRewardsView_Roulette::丘下丟丁上丏丛且且()));
    }
    private void OnDisable()
    {
        if(this.itemSelector == 0)
        {
                return;
        }
        
        this.itemSelector.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxRewardsView_Roulette::丘下丟丁上丏丛且且()));
    }
    internal override void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        this.丈且东丑丂且万丒丅(一与且丐丝丘与丆丑:  一与且丐丝丘与丆丑);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedRewardView, 丏业丟一东丂东丘丛:  false);
        this.丑不与下万一一丂上();
    }
    internal override void 世业丒万丘丆专丘丐()
    {
        var val_15;
        float val_16;
        float val_17;
        val_15 = this;
        this.世业丒万丘丆专丘丐();
        UnityEngine.Vector3 val_2 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_3 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        val_16 = val_4.y;
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_2.y, z = val_2.z};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = val_16, z = val_4.z});
        val_17 = val_6.x;
        this.scrollPanel.clipOffset = new UnityEngine.Vector2() {x = val_17, y = val_6.y};
        if(this.wrapContent == null)
        {
                return;
        }
        
        if(this.wrapContent == null)
        {
                return;
        }
        
        val_15 = ???;
        val_17 = ???;
        val_16 = ???;
        goto typeof(UIWrapContent).__il2cppRuntimeField_1C8;
    }
    internal override void 丌丟丆不丄专丐不丂()
    {
        int val_3;
        this.丌丟丆不丄专丐不丂();
        this.丁丙丗东丗丁万丆丕.Clear();
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] -----------dropped----------");
        List.Enumerator<T> val_1 = this.丁丙丗东丗丁万丆丕.GetEnumerator();
        label_15:
        if(((-1248662432) & 1) == 0)
        {
            goto label_4;
        }
        
        new LootBoxRewardsView_Roulette.丈丞丕丘丄丐且丈丂() = new System.Object();
        string val_5 = val_3.丐丏七丌丕丗业且上();
        .丗七丟丈三不丕一三 = val_5;
        System.Func<LootBoxRewardView, System.Boolean> val_6 = new System.Func<LootBoxRewardView, System.Boolean>(object:  new LootBoxRewardsView_Roulette.丈丞丕丘丄丐且丈丂(), method:  System.Boolean LootBoxRewardsView_Roulette.丈丞丕丘丄丐且丈丂::不丈一世三与丈东丑(LootBoxRewardView 三丟东丕丄丄下下丑));
        LootBoxRewardView val_7 = System.Linq.Enumerable.FirstOrDefault<LootBoxRewardView>(source:  val_5, predicate:  null);
        if(val_7 != 0)
        {
                this.丁丙丗东丗丁万丆丕.Add(item:  val_7);
        }
        
        val_3 = (LootBoxRewardsView_Roulette.丈丞丕丘丄丐且丈丂)[1152921537717971136].丗七丟丈三不丕一三.三东丏不丗世丅丌丄.丂丁丏一丙丛业且丌();
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[LootBoxUI] {0} {1}", arg0:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  (LootBoxRewardsView_Roulette.丈丞丕丘丄丐且丈丂)[1152921537717971136].丗七丟丈三不丕一三.三东丏不丗世丅丌丄), arg1:  val_3));
        goto label_15;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] -----------------------------");
    }
    protected override System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LootBoxRewardsView_Roulette.不丑丅一业上丘丈万();
    }
    public void ForceFinishAnimation()
    {
        this.丟丙万丘一丒丛不丂();
        mem2[0] = 0;
        mem2[0] = 0;
        this.scrollView.enabled = true;
        if(this.丟一丐与下丗东丄东 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(LootBoxRewardsView_Roulette).__il2cppRuntimeField_1B8;
    }
    protected override void 丄丛丘且丑丄万丈丙()
    {
        this.丑不与下万一一丂上();
        this.丄丛丘且丑丄万丈丙();
    }
    private void 丝业丝丅东与三东丆()
    {
        LootBoxRewardView val_12;
        var val_13;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] " + this.gameObject.name + " - SelectNextTarget"(" - SelectNextTarget"));
        if(this.丁丙丗东丗丁万丆丕.Count > 0)
        {
                val_12 = this.丞下万上三丘上与专;
            this.丞下万上三丘上与专 = System.Linq.Enumerable.First<LootBoxRewardView>(source:  this.丁丙丗东丗丁万丆丕);
            this.丁丙丗东丗丁万丆丕.RemoveAt(index:  0);
        }
        else
        {
                val_12 = this.丞下万上三丘上与专;
        }
        
        if(mem[this.丞下万上三丘上与专] == 0)
        {
                val_13 = "[LootBoxUI] Target is NULL!!!";
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[LootBoxUI] Target is {0} {1}", arg0:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  mem[this.丞下万上三丘上与专] + 72 + 16), arg1:  mem[this.丞下万上三丘上与专] + 72 + 16.丂丁丏一丙丛业且丌()));
        if(this.丁丙丗东丗丁万丆丕.Count != 0)
        {
                return;
        }
        
        this.SetFinalTargetPosition();
    }
    public void SetFinalTargetPosition()
    {
        float val_1 = this.丘丛丝七丐丁七一丐(丞下万上三丘上与专:  this.丞下万上三丘上与专);
        UnityEngine.Vector3 val_3 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_4 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.丟一丐与下丗东丄东 = 0;
        mem[1152921537718684384] = 0;
        this.丂丂三上下万丙业丙 = 0;
        mem[1152921537718684400] = 0;
    }
    private float 丘丛丝七丐丁七一丐(LootBoxRewardView 丞下万上三丘上与专)
    {
        float val_11;
        float val_12;
        UnityEngine.Transform val_1 = this.scrollView.transform;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        int val_3 = val_1.Count;
        float val_4 = (float)val_3 * (float)this.wrapContent.itemSize;
        float val_5 = val_2.x / val_4;
        float val_11 = System.Math.Abs(val_5);
        float val_7 = val_11 - ((float)UnityEngine.Mathf.FloorToInt(f:  val_11));
        if(val_7 <= 0f)
        {
            goto label_7;
        }
        
        val_11 = this.finalLapsCount;
        if(val_5 <= 0f)
        {
            goto label_8;
        }
        
        float val_12 = 1f;
        val_12 = val_12 - val_7;
        val_12 = val_4 * val_12;
        goto label_10;
        label_7:
        val_11 = this.finalLapsCount;
        val_12 = 0f;
        goto label_10;
        label_8:
        val_12 = val_4 * val_7;
        label_10:
        val_4 = val_4 * val_11;
        val_4 = val_12 - val_4;
        float val_13 = (float)this.wrapContent.itemSize;
        val_13 = ((float)val_3.IndexOf(item:  丞下万上三丘上与专)) * val_13;
        val_13 = (val_2.x + val_4) - val_13;
        val_13 = val_13 - (UnityEngine.Random.Range(min:  -this.randomOffset, max:  this.randomOffset));
        return (float)val_13;
    }
    private void 世业丄丒东七丐丒丕()
    {
        this.丁丝丝专丌且一且丈 = UnityEngine.Mathf.Lerp(a:  this.丁丝丝专丌且一且丈, b:  this.scrollSpeed, t:  UnityEngine.Time.unscaledDeltaTime * this.scrollAcceleration);
        UnityEngine.Transform val_4 = this.scrollView.transform;
        UnityEngine.Vector3 val_5 = val_4.localPosition;
        float val_22 = val_5.x;
        float val_21 = this.finalLapsCount;
        float val_20 = (float)val_4.Count;
        val_20 = val_20 * (float)this.wrapContent.itemSize;
        val_21 = val_21 * val_20;
        val_22 = val_22 - val_21;
        UnityEngine.Vector3 val_9 = this.scrollView.transform.localPosition;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_5.y, z = val_5.z}, t:  UnityEngine.Time.unscaledDeltaTime * this.丁丝丝专丌且一且丈);
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector2 val_13 = this.scrollPanel.clipOffset;
        float val_24 = val_13.x;
        float val_23 = (float)this.wrapContent.itemSize;
        val_23 = (float)this.scrollPanel.Count * val_23;
        val_24 = val_24 + (this.finalLapsCount * val_23);
        UnityEngine.Vector2 val_16 = this.scrollPanel.clipOffset;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = val_24, y = val_13.y}, t:  UnityEngine.Time.unscaledDeltaTime * this.丁丝丝专丌且一且丈);
        this.scrollPanel.clipOffset = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
    }
    private void 丐丟丗下丕丏丌丝丐()
    {
        this.丁丝丝专丌且一且丈 = UnityEngine.Mathf.Lerp(a:  this.丁丝丝专丌且一且丈, b:  this.scrollSpeed, t:  UnityEngine.Time.unscaledDeltaTime * this.scrollAcceleration);
        UnityEngine.Vector3 val_6 = this.scrollView.transform.localPosition;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, t:  UnityEngine.Time.unscaledDeltaTime * this.丁丝丝专丌且一且丈);
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector2 val_10 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, t:  UnityEngine.Time.unscaledDeltaTime * this.丁丝丝专丌且一且丈);
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        this.scrollPanel.clipOffset = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    private float 万上丏丆上上丅丅丛()
    {
        if((this.丟一丐与下丗东丄东 & 1) == 0)
        {
                return 0f;
        }
        
        UnityEngine.Vector3 val_2 = this.scrollView.transform.localPosition;
        return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    private void 丕一且丅万丘丛一三(LootBoxRewardView 丂东丟七世万下世下)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] " + this.gameObject.name + " - ShowDroppedRewardView"(" - ShowDroppedRewardView"));
        if(丂东丟七世万下世下 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[LootBoxUI] Targeted item view is null!");
            return;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[LootBoxUI] Show: {0} {1}", arg0:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丂东丟七世万下世下.专丌丕丆世丂万东万.三东丏不丗世丅丌丄), arg1:  丂东丟七世万下世下.专丌丕丆世丂万东万.三东丏不丗世丅丌丄.丂丁丏一丙丛业且丌()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedRewardView, 丏业丟一东丂东丘丛:  true);
        this.droppedRewardView.丈且东丑丂且万丒丅(丆丈丑丅东丙丘三且:  丂东丟七世万下世下.专丌丕丆世丂万东万);
        if(this.三业不不丘丐业丝下 != null)
        {
                this.三业不不丘丐业丝下.Invoke(obj:  丂东丟七世万下世下.专丌丕丆世丂万东万);
        }
        
        UnityEngine.Coroutine val_10 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void LootBoxRewardsView_Roulette::丟丙万丘一丒丛不丂()), 丆丐七丅丆丗丛上与:  this.droppedRewardShowTime);
        this.丙下丂丟丟丛上专上(丆与丈丏丟七丁东丛:  this.onDropItemClip);
    }
    private void 丟丙万丘一丒丛不丂()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedRewardView, 丏业丟一东丂东丘丛:  false);
    }
    private void 丘下丟丁上丏丛且且()
    {
        if(this.丗不东丝丑三不业丒 != null)
        {
                this.丗不东丝丑三不业丒.Invoke();
        }
        
        this.丙下丂丟丟丛上专上(丆与丈丏丟七丁东丛:  this.onSelectItemClip);
    }
    private void 丑不与下万一一丂上()
    {
        var val_4;
        int val_21;
        var val_22;
        List.Enumerator<T> val_2 = 上与与专业丞丙丌下().GetEnumerator();
        label_9:
        if(((-1246568608) & 1) == 0)
        {
            goto label_3;
        }
        
        LootBoxRewardView val_6 = this.且专且丙丐且丟丐丙(万不丛丅丒丌丌丛丟:  val_4.丐丏七丌丕丗业且上());
        val_6.transform.SetParent(p:  this.scrollContent);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_6.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  true);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_21 = (float)UnityEngine.Mathf.Max(a:  1, b:  val_4.Count - 1);
        float val_22 = UIRoot.GetPixelSizeAdjustment(丝三丁东丈丒世丅业:  this.gameObject);
        float[] val_15 = new float[3];
        val_21 = val_15.Length;
        val_21 = val_21 * (float)this.wrapContent.itemSize;
        if(val_21 == 0)
        {
                val_21 = val_15.Length;
        }
        
        val_15[0] = val_21;
        val_22 = val_22 * (float)UnityEngine.Screen.width;
        if(val_21 <= 1)
        {
                val_21 = val_15.Length;
        }
        
        val_22 = val_22 - this.screenWidhtOffset;
        val_15[1] = this.maxScrollWidht;
        val_15[2] = val_22;
        float val_16 = UnityEngine.Mathf.Min(values:  val_15);
        if(this.scrollPanel != null)
        {
                UnityEngine.Vector2 val_17 = this.scrollPanel.GetViewSize();
            val_22 = val_17.y;
        }
        else
        {
                UnityEngine.Vector2 val_18 = 0.GetViewSize();
            val_22 = val_18.y;
        }
        
        this.丄上七丂丄丗不丝七();
        UnityEngine.Coroutine val_20 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void LootBoxRewardsView_Roulette::专丞丂丌丞与丕丂丁()), 业丗七丕万万不丈丗:  1);
        if(this.itemSelector == null)
        {
                return;
        }
        
        this.itemSelector.下万与与丏丛丗万且();
    }
    private void 丄上七丂丄丗不丝七()
    {
        var val_2;
        this.scrollPanel.ResetAndUpdateAnchors();
        val_2 = null;
        val_2 = null;
        if((LootBoxRewardsView_Roulette.<>c.<>9__64_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        this.anchoredToScrollPanel.ForEach(action:  LootBoxRewardsView_Roulette.<>c.<>9__64_0);
        return;
        label_4:
        LootBoxRewardsView_Roulette.<>c.<>9__64_0 = new System.Action<UIRect>(object:  LootBoxRewardsView_Roulette.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LootBoxRewardsView_Roulette.<>c::且业三上丝业丝上丑(UIRect 三丟东丕丄丄下下丑));
        if(this.anchoredToScrollPanel != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public LootBoxRewardsView_Roulette()
    {
        this.preDropTime = 0.75f;
        this.timeStep = 3f;
        this.finalPreDropDistance = 10f;
        this.droppedRewardShowTime = 1f;
        mem2[0] = ;
        this.distanceDelta = 5f;
        this.scrollSpeed = 1f;
        this.scrollAcceleration = 1f;
        this.countForMiltipyer = 5;
        this.deltaMiltipyer = 2f;
        this.丁丙丗东丗丁万丆丕 = new System.Collections.Generic.List<LootBoxRewardView>();
    }
    private void 专丞丂丌丞与丕丂丁()
    {
        if(this.wrapContent == null)
        {
                return;
        }
        
        if(this.wrapContent == null)
        {
                return;
        }
        
        goto typeof(UIWrapContent).__il2cppRuntimeField_1C8;
    }

}
