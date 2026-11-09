using UnityEngine;
internal sealed class LootBoxRewardsViewAllAtOnce : LootBoxRewardsView
{
    // Fields
    private LoopedScrollItemSelector itemSelector;
    public UIPanel scrollPanel;
    public UIScrollView scrollView;
    private UnityEngine.Transform scrollContent;
    private UIWrapContent wrapContent;
    private System.Collections.Generic.List<UIRect> anchoredToScrollPanel;
    private float animationTime;
    private float maxScrollWidht;
    private float screenWidhtOffset;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        this.丈且东丑丂且万丒丅(一与且丐丝丘与丆丑:  一与且丐丝丘与丆丑);
        this.丑不与下万一一丂上();
    }
    private void 丑不与下万一一丂上()
    {
        var val_4;
        int val_21;
        var val_22;
        List.Enumerator<T> val_2 = 上与与专业丞丙丌下().GetEnumerator();
        label_9:
        if(((-1244486752) & 1) == 0)
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
        UnityEngine.Coroutine val_20 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void LootBoxRewardsViewAllAtOnce::丅丗丁丘丞上丂丕丑()), 业丗七丕万万不丈丗:  1);
        if(this.itemSelector == null)
        {
                return;
        }
        
        this.itemSelector.下万与与丏丛丗万且();
    }
    internal override void 世业丒万丘丆专丘丐()
    {
        UnityEngine.Vector3 val_2 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_3 = this.scrollPanel.clipOffset;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_2.y, z = val_2.z};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = val_4.y, z = val_4.z});
        this.scrollPanel.clipOffset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        this.世业丒万丘丆专丘丐();
    }
    protected override System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LootBoxRewardsViewAllAtOnce.丂与丐三业丒与东丛();
    }
    private void 丄上七丂丄丗不丝七()
    {
        var val_2;
        this.scrollPanel.ResetAndUpdateAnchors();
        val_2 = null;
        val_2 = null;
        if((LootBoxRewardsViewAllAtOnce.<>c.<>9__13_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        this.anchoredToScrollPanel.ForEach(action:  LootBoxRewardsViewAllAtOnce.<>c.<>9__13_0);
        return;
        label_4:
        LootBoxRewardsViewAllAtOnce.<>c.<>9__13_0 = new System.Action<UIRect>(object:  LootBoxRewardsViewAllAtOnce.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LootBoxRewardsViewAllAtOnce.<>c::丄丄一丈不七三丕专(UIRect 三丟东丕丄丄下下丑));
        if(this.anchoredToScrollPanel != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    public LootBoxRewardsViewAllAtOnce()
    {
        this.animationTime = 1.5f;
        this.maxScrollWidht = 0f;
        this.screenWidhtOffset = 128f;
    }
    private void 丅丗丁丘丞上丂丕丑()
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
