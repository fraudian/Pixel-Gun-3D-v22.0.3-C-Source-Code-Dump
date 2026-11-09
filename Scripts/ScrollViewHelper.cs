using UnityEngine;
public class ScrollViewHelper : MonoBehaviour
{
    // Fields
    public UIScrollView scrollView;
    public WidgetLayout widgetLayout;
    public bool stopScrollOnDisable;
    public float scrollDelta;
    public System.Collections.Generic.List<int> scrollToStartForIndexes;
    public bool canScrollOnLast;
    private System.Action 丐万丆东丙与与丂丂;
    private UIPanel 丗丒丟下丕丆丗丆丈;
    private UnityEngine.Vector3 专丅上一丈东三丈丌;
    private UnityEngine.Vector3 下业丕世丈丗下丆丒;
    private UnityEngine.Vector2 与且丐丆东上丒下世;
    private UnityEngine.Vector2 丅世丛丗东丘三丁不;
    private bool 丛不三丅与丏丈一丅;
    public float smoothScrollParam;
    public float smoothScrollEpsilon;
    public bool useNewScrolling;
    private float 业丑丈世一七丂丐丝;
    private int devIndex;
    
    // Properties
    public UIPanel 丆丐且丛丒三丗三世 { get; }
    
    // Methods
    internal void 丞且丐丂丞丆三丈丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐万丆东丙与与丂丂, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐万丆东丙与与丂丂 != 1152921540711642048);
    
    }
    internal void 下一专业丞万丒丝不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐万丆东丙与与丂丂, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐万丆东丙与与丂丂 != 1152921540711778624);
    
    }
    public UIPanel get_Panel()
    {
        UIPanel val_6;
        if(this.丗丒丟下丕丆丗丆丈 != 0)
        {
            goto label_3;
        }
        
        if(this.scrollView.panel == 0)
        {
            goto label_7;
        }
        
        UIPanel val_4 = this.scrollView.panel;
        goto label_9;
        label_3:
        val_6 = this.丗丒丟下丕丆丗丆丈;
        return val_5;
        label_7:
        UIPanel val_5 = this.GetComponent<UIPanel>();
        label_9:
        this.丗丒丟下丕丆丗丆丈 = val_5;
        return val_5;
    }
    private void OnDisable()
    {
        if(this.stopScrollOnDisable == false)
        {
                return;
        }
        
        this.丛不三丅与丏丈一丅 = false;
    }
    public void ScrollTo(UnityEngine.Transform 不七丘丘丒万七丄丒, bool 丌与丟丁万丝丞丄丏 = False)
    {
        .不七丘丘丒万七丄丒 = 不七丘丘丒万七丄丒;
        if(this.widgetLayout == 0)
        {
                UnityEngine.Debug.Log(message:  "widgetLayout is null!");
            return;
        }
        
        int val_4 = this.widgetLayout.widgets.FindIndex(match:  new System.Predicate<UIWidget>(object:  new ScrollViewHelper.世东丒与丞七不不东(), method:  System.Boolean ScrollViewHelper.世东丒与丞七不不东::专丒丐丝七下三上丆(UIWidget 三丟东丕丄丄下下丑)));
        if((val_4 & 2147483648) != 0)
        {
            goto label_9;
        }
        
        if(this.canScrollOnLast == false)
        {
            goto label_10;
        }
        
        label_16:
        if((this.scrollToStartForIndexes.Contains(item:  val_4)) == true)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_7 = (ScrollViewHelper.世东丒与丞七不不东)[1152921540712260432].不七丘丘丒万七丄丒.transform.localPosition;
        this.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 七丙不一下丞与丞一:  this.scrollDelta, 丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        return;
        label_9:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Wrong Child!");
        return;
        label_10:
        int val_9 = this.丗丐世丅上一三东丏();
        if(val_9 == 1)
        {
            goto label_15;
        }
        
        if(val_9 >= val_4)
        {
            goto label_16;
        }
        
        this.ScrollToEnd(丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        return;
        label_15:
        this.ScrollToStart(丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
    }
    private int 丗丐世丅上一三东丏()
    {
        float val_15;
        WidgetLayout val_16;
        int val_17;
        if(this.scrollView.canMoveHorizontally == false)
        {
            goto label_2;
        }
        
        float val_3 = this.Panel.width;
        goto label_4;
        label_2:
        val_15 = 0f;
        if(this.scrollView.canMoveVertically == false)
        {
            goto label_6;
        }
        
        label_4:
        val_15 = this.Panel.height;
        label_6:
        if(val_15 >= this.widgetLayout.GetSize())
        {
            goto label_12;
        }
        
        val_16 = 1152921526159197008;
        if(this.widgetLayout.widgets.Count == 0)
        {
            goto label_12;
        }
        
        float val_15 = 0f;
        label_24:
        val_17 = this.widgetLayout.widgets.Count - 1;
        if((val_17 & 2147483648) != 0)
        {
            goto label_15;
        }
        
        if(this.widgetLayout.widgets.Item[val_17].gameObject.activeSelf == false)
        {
            goto label_24;
        }
        
        val_16 = this.widgetLayout;
        val_15 = val_15 + (this.widgetLayout.GetSize(世丌丌丙丞丟下东丞:  this.widgetLayout.widgets.Item[val_17]));
        val_15 = val_15 + this.widgetLayout.spacing;
        if(val_15 >= 0)
        {
            goto label_24;
        }
        
        return (int)val_17;
        label_12:
        val_17 = 0;
        return (int)val_17;
        label_15:
        val_17 = 0;
        return (int)val_17;
    }
    public void ScrollTo(UnityEngine.Vector3 下业丕七东丌丝下且, float 七丙不一下丞与丞一 = 0, bool 丌与丟丁万丝丞丄丏 = False)
    {
        float val_27;
        float val_28;
        float val_29;
        var val_30;
        float val_31;
        float val_32;
        val_27 = 七丙不一下丞与丞一;
        val_28 = 下业丕七东丌丝下且.y;
        val_29 = 下业丕七东丌丝下且.x;
        val_30 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_31 = val_1.x;
        val_32 = val_1.y;
        this.scrollView.currentMomentum = new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_1.z};
        this.scrollView.DisableSpring();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        if(this.scrollView.movement == 1)
        {
            goto label_8;
        }
        
        if(this.scrollView.movement != 0)
        {
            goto label_9;
        }
        
        UnityEngine.Vector3 val_5 = this.scrollView.transform.localPosition;
        val_28 = val_5.y;
        UnityEngine.Vector3 val_7 = this.scrollView.transform.localPosition;
        float val_8 = val_27 - val_29;
        val_32 = val_28;
        UnityEngine.Vector2 val_10 = this.Panel.clipOffset;
        val_31 = val_29 - val_27;
        goto label_15;
        label_8:
        UnityEngine.Vector3 val_12 = this.scrollView.transform.localPosition;
        val_29 = val_12.x;
        UnityEngine.Vector3 val_14 = this.scrollView.transform.localPosition;
        float val_15 = val_27 - val_28;
        val_31 = val_29;
        UnityEngine.Vector2 val_17 = this.Panel.clipOffset;
        val_32 = val_28 - val_27;
        label_15:
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_17.x, y:  val_32);
        label_9:
        if(丌与丟丁万丝丞丄丏 != false)
        {
                this.专丅上一丈东三丈丌 = val_2;
            mem[1152921540712706472] = val_2.z;
            UnityEngine.Vector3 val_20 = this.scrollView.transform.localPosition;
            this.下业丕世丈丗下丆丒 = val_20;
            mem[1152921540712706480] = val_20.y;
            mem[1152921540712706484] = val_20.z;
            this.与且丐丆东上丒下世 = val_18.x;
            mem[1152921540712706492] = val_18.y;
            UnityEngine.Vector2 val_22 = this.Panel.clipOffset;
            this.丅世丛丗东丘三丁不 = val_22;
            mem[1152921540712706500] = val_22.y;
            this.丛不三丅与丏丈一丅 = true;
            this.业丑丈世一七丂丐丝 = 0f;
            return;
        }
        
        val_28 = val_2.z;
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_28};
        val_27 = val_18.x;
        val_30 = this.Panel;
        val_30.clipOffset = new UnityEngine.Vector2() {x = val_27, y = val_18.y};
    }
    public void StopSmoothScroll()
    {
        this.丛不三丅与丏丈一丅 = false;
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = this.专丅上一丈东三丈丌, y = V9.16B, z = V10.16B};
        this.Panel.clipOffset = new UnityEngine.Vector2() {x = this.与且丐丆东上丒下世, y = V9.16B};
    }
    private float 三丛且丗丙一万专世(float 丙丒七丄上与丏丙丙)
    {
        丙丒七丄上与丏丙丙 = 丙丒七丄上与丏丙丙 * (-2f);
        丙丒七丄上与丏丙丙 = 丙丒七丄上与丏丙丙 + 3f;
        丙丒七丄上与丏丙丙 = (丙丒七丄上与丏丙丙 * 丙丒七丄上与丏丙丙) * 丙丒七丄上与丏丙丙;
        return (float)丙丒七丄上与丏丙丙;
    }
    private float 东丑东一世丆丏丁不(float 丙丒七丄上与丏丙丙)
    {
        float val_2 = 6f;
        val_2 = 丙丒七丄上与丏丙丙 * val_2;
        float val_1 = 丙丒七丄上与丏丙丙 * 丙丒七丄上与丏丙丙;
        val_2 = val_2 + (-15f);
        val_1 = val_1 * 丙丒七丄上与丏丙丙;
        丙丒七丄上与丏丙丙 = val_2 * 丙丒七丄上与丏丙丙;
        丙丒七丄上与丏丙丙 = 丙丒七丄上与丏丙丙 + 10f;
        丙丒七丄上与丏丙丙 = val_1 * 丙丒七丄上与丏丙丙;
        return (float)丙丒七丄上与丏丙丙;
    }
    public void ScrollToStartSmooth()
    {
        this.ScrollToStart(丌与丟丁万丝丞丄丏:  true);
    }
    public void ScrollToStart(bool 丌与丟丁万丝丞丄丏 = False)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        丌与丟丁万丝丞丄丏 = 丌与丟丁万丝丞丄丏;
        this.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
    }
    public void ScrollToEndSmooth()
    {
        this.ScrollToEnd(丌与丟丁万丝丞丄丏:  true);
    }
    public void ScrollToEnd(bool 丌与丟丁万丝丞丄丏 = False)
    {
        float val_12 = this.widgetLayout.GetSize();
        if(this.scrollView.movement == 1)
        {
            goto label_2;
        }
        
        if(this.scrollView.movement != 0)
        {
            goto label_6;
        }
        
        val_12 = val_12 - this.Panel.width;
        UnityEngine.Vector2 val_5 = this.Panel.clipSoftness;
        val_12 = val_12 + val_5.x;
        goto label_6;
        label_2:
        float val_7 = this.Panel.height;
        val_7 = val_12 - val_7;
        UnityEngine.Vector2 val_9 = this.Panel.clipSoftness;
        val_12 = (-val_7) - val_9.y;
        label_6:
        this.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
    }
    public void StopScroll()
    {
        this.丛不三丅与丏丈一丅 = false;
    }
    private void Update()
    {
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        UnityEngine.Vector3 val_38;
        UnityEngine.Vector3 val_39;
        var val_40;
        float val_41;
        float val_45;
        float val_46;
        if(this.丛不三丅与丏丈一丅 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.scrollView.transform.localPosition;
        val_34 = val_2.x;
        val_35 = val_2.y;
        val_36 = val_2.z;
        if(((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = this.专丅上一丈东三丈丌, y = V12.16B, z = V10.16B}, 丞丞丙且丄不丈丌三:  this.smoothScrollEpsilon)) == true) || (this.scrollView.isDragging == true))
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_5 = this.scrollView.currentMomentum;
        val_33 = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_34 = val_5.x;
        val_35 = val_5.y;
        val_36 = val_33;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == false)
        {
            goto label_12;
        }
        
        label_8:
        this.丛不三丅与丏丈一丅 = false;
        label_12:
        if(this.useNewScrolling != false)
        {
                val_37 = this.业丑丈世一七丂丐丝 + UnityEngine.Time.unscaledDeltaTime;
            this.业丑丈世一七丂丐丝 = val_37;
            if(val_37 > this.smoothScrollParam)
        {
                val_37 = this.smoothScrollParam;
            this.业丑丈世一七丂丐丝 = this.smoothScrollParam;
        }
        
            val_37 = val_37 / this.smoothScrollParam;
            float val_9 = val_37 * val_37;
            val_37 = val_37 * (-2f);
            float val_10 = val_37 + 3f;
            val_9 = val_9 * val_10;
            val_38 = this.下业丕世丈丗下丆丒;
            val_39 = this.专丅上一丈东三丈丌;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_38, y = this.专丅上一丈东三丈丌, z = this.smoothScrollEpsilon}, b:  new UnityEngine.Vector3() {x = val_39, y = val_33, z = val_10}, t:  val_9);
            this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_40 = this.Panel;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.丅世丛丗东丘三丁不, y = val_12.x});
            val_41 = val_14.y;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.与且丐丆东上丒下世, y = val_14.y});
            val_45 = val_14.x;
            val_46 = val_41;
        }
        else
        {
                UnityEngine.Vector3 val_18 = this.scrollView.transform.localPosition;
            val_38 = UnityEngine.Time.unscaledDeltaTime;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = this.专丅上一丈东三丈丌, y = this.smoothScrollEpsilon, z = V12.16B}, t:  val_38 * this.smoothScrollParam);
            this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            val_40 = this.Panel;
            UnityEngine.Vector2 val_24 = this.Panel.clipOffset;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            val_41 = val_25.z;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.与且丐丆东上丒下世, y = val_25.y});
            val_39 = val_26.y;
            val_45 = val_25.x;
            val_46 = val_25.y;
        }
        
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_41}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_39, z = val_26.z}, t:  UnityEngine.Time.unscaledDeltaTime * this.smoothScrollParam);
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        val_40.clipOffset = new UnityEngine.Vector2() {x = val_30.x, y = val_30.y};
        if((this.丛不三丅与丏丈一丅 != true) && (this.丐万丆东丙与与丂丂 != null))
        {
                this.丐万丆东丙与与丂丂.Invoke();
        }
        
        this.scrollView.UpdateScrollbars();
    }
    public void ScrollTo4DEV()
    {
        this.ScrollTo(不七丘丘丒万七丄丒:  this.widgetLayout.widgets.Item[this.devIndex].transform, 丌与丟丁万丝丞丄丏:  false);
    }
    public void ScrollToStartDEV()
    {
        this.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
    }
    public void ScrollToEndDEV()
    {
        this.ScrollToEnd(丌与丟丁万丝丞丄丏:  false);
    }
    public ScrollViewHelper()
    {
        this.scrollDelta = 250f;
        this.scrollToStartForIndexes = new System.Collections.Generic.List<System.Int32>();
        this.smoothScrollParam = 5f;
        this.smoothScrollEpsilon = 7.714148E-41f;
        this.devIndex = 5;
    }

}
