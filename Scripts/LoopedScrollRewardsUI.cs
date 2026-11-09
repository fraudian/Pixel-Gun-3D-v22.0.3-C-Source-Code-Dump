using UnityEngine;
internal sealed class LoopedScrollRewardsUI : PGBehaviour
{
    // Fields
    private System.Action 丞下与业东东丏丒丆;
    private System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 三业不不丘丐业丝下;
    private System.Action 一丌丅丐丛业不丕丟;
    private MiniPoolMonoBehaviour itemViewPool;
    private UIPanel scrollPanel;
    private UIScrollView scrollView;
    private UnityEngine.Transform scrollContent;
    private UIWrapContent wrapContent;
    public LoopedScrollItemSelector itemSelector;
    private LootBoxRewardView droppedItemView;
    private System.Collections.Generic.List<UIRect> anchoredToScrollPanel;
    public float startDelay;
    public float timeStep;
    public float showDroppedTime;
    public float finishDelay;
    public float maxScrollWidht;
    public float finalLapsCount;
    public float randomOffset;
    public float distanceDelta;
    public float scrollSpeed;
    public float scrollAcceleration;
    private System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丛丟专丌七丐万丈丛;
    private System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 与丒丑三且丒丐下上;
    private System.Collections.Generic.List<LootBoxRewardView> 丁丙丗东丗丁万丆丕;
    private System.Collections.Generic.List<LootBoxRewardView> 与丕东丞丂业丑东丐;
    private float 丑专丝丙万万与丛丈;
    private UnityEngine.Coroutine 丈专丛丞万世丕丞丄;
    private LootBoxRewardView 丞下万上三丘上与专;
    private System.Nullable<UnityEngine.Vector3> 丟一丐与下丗东丄东;
    private System.Nullable<UnityEngine.Vector3> 丂丂三上下万丙业丙;
    private float 丁丝丝专丌且一且丈;
    
    // Methods
    internal void 丞丁上丐丁不丆丙与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丞下与业东东丏丒丆, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞下与业东东丏丒丆 != 1152921537698413816);
    
    }
    internal void 丞上业丆丏世丟一世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丞下与业东东丏丒丆, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞下与业东东丏丒丆 != 1152921537698550392);
    
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
        while(this.三业不不丘丐业丝下 != 1152921537698686976);
    
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
        while(this.三业不不丘丐业丝下 != 1152921537698823552);
    
    }
    internal void 世专丞丅丂丑专丒丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.一丌丅丐丛业不丕丟, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丌丅丐丛业不丕丟 != 1152921537698960136);
    
    }
    internal void 丏丆业下丅丌丄丆业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.一丌丅丐丛业不丕丟, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丌丅丐丛业不丕丟 != 1152921537699096712);
    
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丑七不与丛丆一丂丞)
    {
        this.丛丟专丌七丐万丈丛 = 丑七不与丛丆一丂丞;
        this.与丒丑三且丒丐下上 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedItemView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemViewPool.example, 丏业丟一东丂东丘丛:  false);
        this.上东与丛丞下丈专丈();
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.上东与丛丞下丈专丈();
    }
    private void 上东与丛丞下丈专丈()
    {
        var val_3;
        int val_17;
        var val_18;
        this.世业丒万丘丆专丘丐();
        List.Enumerator<T> val_1 = this.丛丟专丌七丐万丈丛.GetEnumerator();
        label_14:
        if(((-1267037856) & 1) == 0)
        {
            goto label_2;
        }
        
        LootBoxRewardView val_5 = this.itemViewPool.Get<LootBoxRewardView>();
        val_5.transform.SetParent(p:  this.scrollContent);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_5.transform);
        val_5.丈且东丑丂且万丒丅(丆丈丑丅东丙丘三且:  val_3.丐丏七丌丕丗业且上());
        val_5.name = val_4.m_stringLength.业上丙丞丐丄丆丅七();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        this.与丕东丞丂业丑东丐.Add(item:  val_5);
        goto label_14;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_17 = (float)UnityEngine.Mathf.Max(a:  1, b:  this.与丕东丞丂业丑东丐.Count - 1);
        float[] val_12 = new float[3];
        val_17 = val_12.Length;
        val_17 = val_17 * (float)this.wrapContent.itemSize;
        if(val_17 == 0)
        {
                val_17 = val_12.Length;
        }
        
        val_12[0] = val_17;
        val_12[1] = this.maxScrollWidht;
        val_12[2] = (float)UnityEngine.Screen.width;
        float val_14 = UnityEngine.Mathf.Min(values:  val_12);
        if(this.scrollPanel != null)
        {
                UnityEngine.Vector2 val_15 = this.scrollPanel.GetViewSize();
            val_18 = val_15.y;
        }
        else
        {
                UnityEngine.Vector2 val_16 = 0.GetViewSize();
            val_18 = val_16.y;
        }
        
        this.丄上七丂丄丗不丝七();
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
        if((LoopedScrollRewardsUI.<>c.<>9__34_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        this.anchoredToScrollPanel.ForEach(action:  LoopedScrollRewardsUI.<>c.<>9__34_0);
        return;
        label_4:
        LoopedScrollRewardsUI.<>c.<>9__34_0 = new System.Action<UIRect>(object:  LoopedScrollRewardsUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoopedScrollRewardsUI.<>c::丄一丁七丗丆丘专丝(UIRect 三丟东丕丄丄下下丑));
        if(this.anchoredToScrollPanel != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    internal void 丆丙专一一东丏下丂(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丘丂丅且丄丑丞万丟)
    {
        System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> val_1 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>();
        val_1.Add(item:  丘丂丅且丄丑丞万丟);
        this.丆丙专一一东丏下丂(丈丌丆丁世丛专且丕:  val_1);
    }
    internal void 丆丙专一一东丏下丂(System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丈丌丆丁世丛专且丕)
    {
        var val_3;
        this.与丒丑三且丒丐下上 = 丈丌丆丁世丛专且丕;
        this.丁丙丗东丗丁万丆丕.Clear();
        List.Enumerator<T> val_1 = 丈丌丆丁世丛专且丕.GetEnumerator();
        label_9:
        if(((-1266540016) & 1) == 0)
        {
            goto label_3;
        }
        
        new LoopedScrollRewardsUI.且且丛丌丝三丏丙丛() = new LoopedScrollRewardsUI.且且丛丌丝三丏丙丛();
        .下丅丙一丂丗丅丝七 = val_3.丐丏七丌丕丗业且上();
        System.Func<LootBoxRewardView, System.Boolean> val_6 = new System.Func<LootBoxRewardView, System.Boolean>(object:  new LoopedScrollRewardsUI.且且丛丌丝三丏丙丛(), method:  System.Boolean LoopedScrollRewardsUI.且且丛丌丝三丏丙丛::丂一丞七丘上丄与且(LootBoxRewardView 三丟东丕丄丄下下丑));
        LootBoxRewardView val_7 = System.Linq.Enumerable.FirstOrDefault<LootBoxRewardView>(source:  this.与丕东丞丂业丑东丐, predicate:  null);
        if(val_7 == 0)
        {
            goto label_9;
        }
        
        this.丁丙丗东丗丁万丆丕.Add(item:  val_7);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丁丙丗东丗丁万丆丕.Count == 0)
        {
                return;
        }
        
        if(this.丈专丛丞万世丕丞丄 != null)
        {
                this.StopCoroutine(routine:  this.丈专丛丞万世丕丞丄);
        }
        
        this.丈专丛丞万世丕丞丄 = this.StartCoroutine(routine:  this.下丗不丞丄业与世下());
    }
    internal void 世业丒万丘丆专丘丐()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.与丕东丞丂业丑东丐.GetEnumerator();
        label_7:
        if(((-1266313328) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_4.transform.SetParent(p:  this.itemViewPool.transform);
        this.itemViewPool.Return(万且万且丑丗且丌丆:  val_4);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.与丕东丞丂业丑东丐.Clear();
        UnityEngine.Vector3 val_8 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_9 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_8.y, z = val_8.z};
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = val_10.y, z = val_10.z});
        this.scrollPanel.clipOffset = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        if(this.wrapContent == null)
        {
                return;
        }
        
        if(this.wrapContent == null)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LoopedScrollRewardsUI.下丟丄丛丙上丌丙丕(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丝业丝丅东与三东丆()
    {
        if(this.丁丙丗东丗丁万丆丕.Count >= 1)
        {
                this.丞下万上三丘上与专 = System.Linq.Enumerable.First<LootBoxRewardView>(source:  this.丁丙丗东丗丁万丆丕);
            this.丁丙丗东丗丁万丆丕.RemoveAt(index:  0);
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Next Reward: "("Next Reward: ") + this.丞下万上三丘上与专.name);
        }
        
        if(this.丁丙丗东丗丁万丆丕.Count != 0)
        {
                return;
        }
        
        this.SetFinalTargetPosition();
    }
    public void SetFinalTargetPosition()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Last Reward: "("Last Reward: ") + this.丞下万上三丘上与专.name);
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tposition = : "("\tposition = : ") + this.丘丛丝七丐丁七一丐(丞下万上三丘上与专:  this.丞下万上三丘上与专)(this.丘丛丝七丐丁七一丐(丞下万上三丘上与专:  this.丞下万上三丘上与专)));
        UnityEngine.Vector3 val_6 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_7 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        this.丟一丐与下丗东丄东 = 0;
        mem[1152921537700794488] = 0;
        this.丂丂三上下万丙业丙 = 0;
        mem[1152921537700794504] = 0;
    }
    private float 丘丛丝七丐丁七一丐(LootBoxRewardView 丞下万上三丘上与专)
    {
        float val_11;
        float val_12;
        UnityEngine.Vector3 val_2 = this.scrollView.transform.localPosition;
        float val_4 = (float)this.与丕东丞丂业丑东丐.Count * (float)this.wrapContent.itemSize;
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
        val_13 = ((float)this.与丕东丞丂业丑东丐.IndexOf(item:  丞下万上三丘上与专)) * val_13;
        val_13 = (val_2.x + val_4) - val_13;
        val_13 = val_13 - (UnityEngine.Random.Range(min:  -this.randomOffset, max:  this.randomOffset));
        return (float)val_13;
    }
    private void 世业丄丒东七丐丒丕()
    {
        this.丁丝丝专丌且一且丈 = UnityEngine.Mathf.Lerp(a:  this.丁丝丝专丌且一且丈, b:  this.scrollSpeed, t:  UnityEngine.Time.unscaledDeltaTime * this.scrollAcceleration);
        UnityEngine.Vector3 val_5 = this.scrollView.transform.localPosition;
        float val_22 = val_5.x;
        float val_21 = this.finalLapsCount;
        float val_20 = (float)this.与丕东丞丂业丑东丐.Count;
        val_20 = val_20 * (float)this.wrapContent.itemSize;
        val_21 = val_21 * val_20;
        val_22 = val_22 - val_21;
        UnityEngine.Vector3 val_9 = this.scrollView.transform.localPosition;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_5.y, z = val_5.z}, t:  UnityEngine.Time.unscaledDeltaTime * this.丁丝丝专丌且一且丈);
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector2 val_13 = this.scrollPanel.clipOffset;
        float val_24 = val_13.x;
        float val_23 = (float)this.wrapContent.itemSize;
        val_23 = (float)this.与丕东丞丂业丑东丐.Count * val_23;
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
    private void 与世万丄一丑丒丞世(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丘丂丅且丄丑丞万丟)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedItemView, 丏业丟一东丂东丘丛:  true);
        if(this.droppedItemView != null)
        {
                this.droppedItemView.丈且东丑丂且万丒丅(丆丈丑丅东丙丘三且:  丘丂丅且丄丑丞万丟);
        }
        
        UnityEngine.Coroutine val_5 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void LoopedScrollRewardsUI::丗与三丐丙万不丑下()), 丆丐七丅丆丗丛上与:  UnityEngine.Mathf.Max(a:  0f, b:  UnityEngine.Mathf.Min(a:  this.showDroppedTime, b:  this.timeStep + (-0.1f))));
        if(this.三业不不丘丐业丝下 == null)
        {
                return;
        }
        
        this.三业不不丘丐业丝下.Invoke(obj:  丘丂丅且丄丑丞万丟);
    }
    public LoopedScrollRewardsUI()
    {
        this.scrollSpeed = 1f;
        this.scrollAcceleration = 7.346868E-41f;
        this.startDelay = ;
        this.timeStep = ;
        this.showDroppedTime = 1f;
        this.finishDelay = 3f;
        this.maxScrollWidht = ;
        this.finalLapsCount = ;
        this.randomOffset = 40f;
        this.distanceDelta = 5f;
        this.丛丟专丌七丐万丈丛 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>();
        this.与丒丑三且丒丐下上 = new System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>();
        this.丁丙丗东丗丁万丆丕 = new System.Collections.Generic.List<LootBoxRewardView>();
        this.与丕东丞丂业丑东丐 = new System.Collections.Generic.List<LootBoxRewardView>();
    }
    private void 丗与三丐丙万不丑下()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedItemView, 丏业丟一东丂东丘丛:  false);
    }

}
